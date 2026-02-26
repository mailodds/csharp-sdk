// SDK smoke test -- validates build-from-source and API integration using the SDK client.
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MailOdds.Api;
using MailOdds.Client;
using MailOdds.Extensions;
using MailOdds.Model;

var apiKey = Environment.GetEnvironmentVariable("MAILODDS_TEST_KEY") ?? "";
if (string.IsNullOrEmpty(apiKey)) { Console.WriteLine("ERROR: MAILODDS_TEST_KEY not set"); return 1; }

int passed = 0, failed = 0;
var ts = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();

void Check(string label, string? expected, string? actual) {
    if (expected == actual) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected={expected} got={actual}"); }
}

void CheckBool(string label, bool expected, bool? actual) {
    if (actual != null && expected == actual) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected={expected} got={actual}"); }
}

void CheckTrue(string label, bool? actual) {
    if (actual == true) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected=true got={actual}"); }
}

void CheckNotNull(string label, object? actual) {
    if (actual != null) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected non-null got null"); }
}

// Set up DI container with SDK
var services = new ServiceCollection();
services.AddLogging(b => b.SetMinimumLevel(LogLevel.Warning));
services.AddApi(options => {
    options.AddTokens(new BearerToken(apiKey));
    options.AddApiHttpClients(client => client.BaseAddress = new Uri("https://api.mailodds.com"));
});
var sp = services.BuildServiceProvider();

// --- Email Validation ---
var api = sp.GetRequiredService<IEmailValidationApi>();

var cases = new (string email, string status, string action, string? sub)[] {
    ("test@deliverable.mailodds.com", "valid", "accept", null),
    ("test@invalid.mailodds.com", "invalid", "reject", "smtp_rejected"),
    ("test@risky.mailodds.com", "catch_all", "accept_with_caution", "catch_all_detected"),
    ("test@disposable.mailodds.com", "do_not_mail", "reject", "disposable"),
    ("test@role.mailodds.com", "do_not_mail", "reject", "role_account"),
    ("test@timeout.mailodds.com", "unknown", "retry_later", "smtp_unreachable"),
    ("test@freeprovider.mailodds.com", "valid", "accept", null),
};

// (free_provider, disposable, role_account, mx_found)
var boolCases = new (bool free, bool disp, bool role, bool mx)[] {
    (false, false, false, true),  // deliverable
    (false, false, false, true),  // invalid
    (false, false, false, true),  // risky
    (false, true, false, true),   // disposable
    (false, false, true, true),   // role
    (false, false, false, true),  // timeout
    (true, false, false, true),   // freeprovider
};

for (int i = 0; i < cases.Length; i++) {
    var (email, expStatus, expAction, expSub) = cases[i];
    var domain = email.Split('@')[1].Split('.')[0];
    try {
        var resp = await api.ValidateEmailAsync(new ValidateRequest(email: email));
        if (resp.IsOk) {
            var data = resp.Ok()!;
            Check($"{domain}.status", expStatus, ValidationResponse.StatusEnumToJsonValue(data.Status));
            Check($"{domain}.action", expAction, ValidationResponse.ActionEnumToJsonValue(data.Action));
            Check($"{domain}.sub_status", expSub, data.SubStatus.HasValue ? ValidationResponse.SubStatusEnumToJsonValue(data.SubStatus) : null);
            CheckBool($"{domain}.free_provider", boolCases[i].free, data.FreeProvider);
            CheckBool($"{domain}.disposable", boolCases[i].disp, data.Disposable);
            CheckBool($"{domain}.role_account", boolCases[i].role, data.RoleAccount);
            CheckBool($"{domain}.mx_found", boolCases[i].mx, data.MxFound);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: {domain} unexpected status: {resp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: {domain} error: {e.Message}");
    }
}

// Error handling: 401 with bad key
{
    var badServices = new ServiceCollection();
    badServices.AddLogging(b => b.SetMinimumLevel(LogLevel.Warning));
    badServices.AddApi(options => {
        options.AddTokens(new BearerToken("invalid_key"));
        options.AddApiHttpClients(client => client.BaseAddress = new Uri("https://api.mailodds.com"));
    });
    var badSp = badServices.BuildServiceProvider();
    var badApi = badSp.GetRequiredService<IEmailValidationApi>();
    try {
        var resp = await badApi.ValidateEmailAsync(new ValidateRequest(email: "test@deliverable.mailodds.com"));
        if (resp.IsUnauthorized) { passed++; }
        else { failed++; Console.WriteLine($"  FAIL: error.401 expected=401 got={resp.StatusCode}"); }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: error.401 exception: {e.Message}");
    }
}

// Error handling: 400/422 with missing email
try {
    var resp = await api.ValidateEmailAsync(new ValidateRequest(email: ""));
    if (resp.IsBadRequest) { passed++; }
    else if ((int)resp.StatusCode == 422) { passed++; }
    else { failed++; Console.WriteLine($"  FAIL: error.400 expected=400|422 got={resp.StatusCode}"); }
} catch (Exception e) {
    failed++;
    Console.WriteLine($"  FAIL: error.400 exception: {e.Message}");
}

// --- Bulk Validation ---
{
    var bulkApi = sp.GetRequiredService<IBulkValidationApi>();
    string? jobId = null;
    try {
        var resp = await bulkApi.CreateJobAsync(new CreateJobRequest(emails: new List<string> { "test@deliverable.mailodds.com" }));
        if (resp.IsCreated) {
            var data = resp.Created()!;
            CheckTrue("bulk.create.has_id", data.Job?.Id != null);
            CheckTrue("bulk.create.id_prefix", data.Job?.Id?.StartsWith("job_"));
            Check("bulk.create.status", "pending", data.Job?.Status != null ? Job.StatusEnumToJsonValue(data.Job.Status) : null);
            jobId = data.Job?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: bulk.create unexpected status: {resp.StatusCode}");
        }

        if (jobId != null) {
            var getResp = await bulkApi.GetJobAsync(jobId);
            if (getResp.IsOk) {
                Check("bulk.get.id", jobId, getResp.Ok()!.Job?.Id);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: bulk.get unexpected status: {getResp.StatusCode}");
            }

            var delResp = await bulkApi.DeleteJobAsync(jobId);
            if (delResp.IsOk) {
                CheckTrue("bulk.delete", delResp.Ok()!.Deleted);
                jobId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: bulk.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: bulk raised: {e.Message}");
    } finally {
        if (jobId != null) {
            try { await bulkApi.DeleteJobAsync(jobId); } catch { }
        }
    }
}

// --- Suppression Lists ---
{
    var suppApi = sp.GetRequiredService<ISuppressionListsApi>();
    var testEmail = $"smoketest-{ts}@example.com";
    try {
        var addResp = await suppApi.AddSuppressionAsync(new AddSuppressionRequest(
            entries: new List<AddSuppressionRequestEntriesInner> {
                new(type: AddSuppressionRequestEntriesInner.TypeEnum.Email, value: testEmail)
            }
        ));
        if (addResp.IsOk) {
            CheckTrue("supp.add.count", addResp.Ok()!.Added >= 1);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: supp.add unexpected status: {addResp.StatusCode}");
        }

        var checkResp = await suppApi.CheckSuppressionAsync(new CheckSuppressionRequest(email: testEmail));
        if (checkResp.IsOk) {
            CheckTrue("supp.check.suppressed", checkResp.Ok()!.Suppressed);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: supp.check unexpected status: {checkResp.StatusCode}");
        }

        var statsResp = await suppApi.GetSuppressionStatsAsync();
        if (statsResp.IsOk) {
            CheckNotNull("supp.stats.total", statsResp.Ok()!.Total);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: supp.stats unexpected status: {statsResp.StatusCode}");
        }

        var rmResp = await suppApi.RemoveSuppressionAsync(new RemoveSuppressionRequest(
            entries: new List<string> { testEmail }
        ));
        if (rmResp.IsOk) {
            CheckTrue("supp.remove.count", rmResp.Ok()!.Removed >= 1);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: supp.remove unexpected status: {rmResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: supp raised: {e.Message}");
        try { await suppApi.RemoveSuppressionAsync(new RemoveSuppressionRequest(entries: new List<string> { testEmail })); } catch { }
    }
}

// --- Validation Policies ---
{
    var polApi = sp.GetRequiredService<IValidationPoliciesApi>();
    int? policyId = null;

    // Cleanup leftover smoke policies (free plan allows only 1)
    try {
        var existingResp = await polApi.ListPoliciesAsync();
        if (existingResp.IsOk) {
            foreach (var p in existingResp.Ok()!.Policies ?? new List<MailOdds.Model.Policy>()) {
                if (p.Name != null && p.Name.StartsWith("smoke")) {
                    try { await polApi.DeletePolicyAsync(p.Id ?? 0); } catch { }
                }
            }
        }
    } catch { }

    try {
        var presetsResp = await polApi.GetPolicyPresetsAsync();
        if (presetsResp.IsOk) {
            var presets = presetsResp.Ok()!;
            CheckTrue("policy.presets.count", presets.Presets?.Count > 0);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: policy.presets unexpected status: {presetsResp.StatusCode}");
        }

        var createResp = await polApi.CreatePolicyFromPresetAsync(new CreatePolicyFromPresetRequest(
            presetId: CreatePolicyFromPresetRequest.PresetIdEnum.Strict,
            name: $"smoke-{ts}"
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("policy.create.id", data.Policy?.Id);
            policyId = data.Policy?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: policy.create unexpected status: {createResp.StatusCode}");
        }

        if (policyId != null) {
            var delResp = await polApi.DeletePolicyAsync(policyId.Value);
            if (delResp.IsOk) {
                CheckTrue("policy.delete", delResp.Ok()!.Deleted);
                policyId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: policy.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: policy raised: {e.Message}");
    } finally {
        if (policyId != null) {
            try { await polApi.DeletePolicyAsync(policyId.Value); } catch { }
        }
    }
}

// --- System ---
{
    // Health check (no auth required)
    var noAuthServices = new ServiceCollection();
    noAuthServices.AddLogging(b => b.SetMinimumLevel(LogLevel.Warning));
    noAuthServices.AddApi(options => {
        options.AddTokens(new BearerToken(""));
        options.AddApiHttpClients(client => client.BaseAddress = new Uri("https://api.mailodds.com"));
    });
    var noAuthSp = noAuthServices.BuildServiceProvider();
    try {
        var sysApi = noAuthSp.GetRequiredService<ISystemApi>();
        var healthResp = await sysApi.HealthCheckAsync();
        if (healthResp.IsOk) {
            Check("system.health", "healthy", healthResp.Ok()!.Status);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: system.health unexpected status: {healthResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: system.health raised: {e.Message}");
    }

    // Telemetry (auth required)
    try {
        var sysApi = sp.GetRequiredService<ISystemApi>();
        var telemResp = await sysApi.GetTelemetrySummaryAsync();
        if (telemResp.IsOk) {
            CheckNotNull("system.telemetry", telemResp.Ok());
        } else {
            failed++;
            Console.WriteLine($"  FAIL: system.telemetry unexpected status: {telemResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: system.telemetry raised: {e.Message}");
    }
}

// --- Sending Domains ---
{
    var domApi = sp.GetRequiredService<ISendingDomainsApi>();
    string? domainId = null;
    try {
        var listResp = await domApi.ListSendingDomainsAsync();
        if (listResp.IsOk) {
            CheckNotNull("domains.list", listResp.Ok()!.Domains);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: domains.list unexpected status: {listResp.StatusCode}");
        }

        var createResp = await domApi.CreateSendingDomainAsync(new CreateSendingDomainRequest(
            domain: $"smoke-{ts}.example.com"
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("domains.create.id", data.Domain?.Id);
            domainId = data.Domain?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: domains.create unexpected status: {createResp.StatusCode}");
        }

        if (domainId != null) {
            var delResp = await domApi.DeleteSendingDomainAsync(domainId);
            if (delResp.IsOk) {
                CheckTrue("domains.delete", delResp.Ok()!.Deleted);
                domainId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: domains.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: domains raised: {e.Message}");
    } finally {
        if (domainId != null) {
            try { await domApi.DeleteSendingDomainAsync(domainId); } catch { }
        }
    }
}

// --- Subscriber Lists ---
{
    var listsApi = sp.GetRequiredService<ISubscriberListsApi>();
    string? listId = null;
    try {
        var createResp = await listsApi.CreateListAsync(new CreateListRequest(name: $"smoke-{ts}"));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("lists.create.id", data.List?.Id);
            listId = data.List?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: lists.create unexpected status: {createResp.StatusCode}");
        }

        var allResp = await listsApi.GetListsAsync();
        if (allResp.IsOk) {
            CheckTrue("lists.list.count", allResp.Ok()!.Lists?.Count > 0);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: lists.list unexpected status: {allResp.StatusCode}");
        }

        if (listId != null) {
            var subResp = await listsApi.SubscribeAsync(listId, new SubscribeRequest(email: $"smoke-{ts}@example.com"));
            if (subResp.IsCreated) {
                CheckNotNull("lists.subscribe.id", subResp.Created()!.Subscriber?.Id);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: lists.subscribe unexpected status: {subResp.StatusCode}");
            }

            var delResp = await listsApi.DeleteListAsync(listId);
            if (delResp.IsOk) {
                CheckTrue("lists.delete", delResp.Ok()!.Deleted);
                listId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: lists.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: lists raised: {e.Message}");
    } finally {
        if (listId != null) {
            try { await listsApi.DeleteListAsync(listId); } catch { }
        }
    }
}

// --- Email Sending (DI resolve only) ---
try {
    var sendApi = sp.GetRequiredService<IEmailSendingApi>();
    CheckNotNull("sending.resolve", sendApi);
} catch (Exception e) {
    failed++;
    Console.WriteLine($"  FAIL: sending.resolve raised: {e.Message}");
}

var total = passed + failed;
var result = failed == 0 ? "PASS" : "FAIL";
Console.WriteLine($"\n{result}: C# SDK ({passed}/{total})");
return failed == 0 ? 0 : 1;
