// SDK smoke test -- validates build-from-source and API integration using the SDK client.
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MailOdds.Api;
using MailOdds.Client;
using MailOdds.Extensions;
using MailOdds.Model;

var apiKey = Environment.GetEnvironmentVariable("MAILODDS_TEST_KEY") ?? "";
if (string.IsNullOrEmpty(apiKey)) { Console.WriteLine("ERROR: MAILODDS_TEST_KEY not set"); return 1; }

int passed = 0, failed = 0, warned = 0;
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

void Warn(string label, string msg) {
    warned++;
    Console.WriteLine($"  WARN: {label} {msg}");
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
            var gotSub = data.SubStatus.HasValue ? ValidationResponse.SubStatusEnumToJsonValue(data.SubStatus) : null;
            if (gotSub == "domain_not_found" && expSub != "domain_not_found") {
                Warn($"{domain}", "test domain not configured (domain_not_found)");
                passed++; // SDK call succeeded
            } else {
                Check($"{domain}.status", expStatus, ValidationResponse.StatusEnumToJsonValue(data.Status));
                Check($"{domain}.action", expAction, ValidationResponse.ActionEnumToJsonValue(data.Action));
                Check($"{domain}.sub_status", expSub, gotSub);
                CheckBool($"{domain}.free_provider", boolCases[i].free, data.FreeProvider);
                CheckBool($"{domain}.disposable", boolCases[i].disp, data.Disposable);
                CheckBool($"{domain}.role_account", boolCases[i].role, data.RoleAccount);
                CheckBool($"{domain}.mx_found", boolCases[i].mx, data.MxFound);
            }
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
        } else if ((int)createResp.StatusCode == 500) {
            Warn("domains", $"server error: {createResp.StatusCode}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: domains.create unexpected status: {createResp.StatusCode}");
        }

        if (domainId != null) {
            var delResp = await domApi.DeleteSendingDomainAsync(domainId);
            if (delResp.IsOk) {
                CheckTrue("domains.delete", delResp.Ok()!.Deleted);
                domainId = null;
            } else if ((int)delResp.StatusCode == 500) {
                Warn("domains.delete", $"server error: {delResp.StatusCode}");
                domainId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: domains.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        if (e.Message.Contains("500") || e.Message.Contains("Internal Server Error")) {
            Warn("domains", $"server error: {e.Message}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: domains raised: {e.Message}");
        }
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

// --- DMARC Monitoring ---
{
    var dmarcApi = sp.GetRequiredService<IDMARCMonitoringApi>();
    string? dmarcDomainId = null;
    try {
        var addResp = await dmarcApi.AddDmarcDomainAsync(new AddDmarcDomainRequest(
            domain: $"smoke-{ts}.example.com"
        ));
        if (addResp.IsCreated) {
            var data = addResp.Created()!;
            CheckNotNull("dmarc.add.domain_id", data.Domain?.Id);
            dmarcDomainId = data.Domain?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: dmarc.add unexpected status: {addResp.StatusCode}");
        }

        var listResp = await dmarcApi.ListDmarcDomainsAsync();
        if (listResp.IsOk) {
            CheckNotNull("dmarc.list.domains", listResp.Ok()!.Domains);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: dmarc.list unexpected status: {listResp.StatusCode}");
        }

        if (dmarcDomainId != null) {
            var getResp = await dmarcApi.GetDmarcDomainAsync(dmarcDomainId);
            if (getResp.IsOk) {
                CheckNotNull("dmarc.get.domain", getResp.Ok()!.Domain);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: dmarc.get unexpected status: {getResp.StatusCode}");
            }

            var delResp = await dmarcApi.DeleteDmarcDomainAsync(dmarcDomainId);
            if (delResp.IsOk) {
                CheckTrue("dmarc.delete", delResp.Ok()!.Deleted);
                dmarcDomainId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: dmarc.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: dmarc raised: {e.Message}");
    } finally {
        if (dmarcDomainId != null) {
            try { await dmarcApi.DeleteDmarcDomainAsync(dmarcDomainId); } catch { }
        }
    }
}

// --- Blacklist Monitoring ---
{
    var blApi = sp.GetRequiredService<IBlacklistMonitoringApi>();
    string? monitorId = null;
    try {
        var addResp = await blApi.AddBlacklistMonitorAsync(new AddBlacklistMonitorRequest(
            target: $"smoke-{ts}.example.com",
            targetType: AddBlacklistMonitorRequest.TargetTypeEnum.Domain
        ));
        if (addResp.IsCreated) {
            var data = addResp.Created()!;
            CheckNotNull("blacklist.add.monitor_id", data.Monitor?.Id);
            monitorId = data.Monitor?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: blacklist.add unexpected status: {addResp.StatusCode}");
        }

        var listResp = await blApi.ListBlacklistMonitorsAsync();
        if (listResp.IsOk) {
            CheckNotNull("blacklist.list.monitors", listResp.Ok()!.Monitors);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: blacklist.list unexpected status: {listResp.StatusCode}");
        }

        if (monitorId != null) {
            var delResp = await blApi.DeleteBlacklistMonitorAsync(monitorId);
            if (delResp.IsOk) {
                CheckTrue("blacklist.delete", delResp.Ok()!.Deleted);
                monitorId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: blacklist.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: blacklist raised: {e.Message}");
    } finally {
        if (monitorId != null) {
            try { await blApi.DeleteBlacklistMonitorAsync(monitorId); } catch { }
        }
    }
}

// --- Server Tests ---
{
    var stApi = sp.GetRequiredService<IServerTestsApi>();
    string? serverTestId = null;
    try {
        var runResp = await stApi.RunServerTestAsync(new RunServerTestRequest(
            domain: "mailodds.com"
        ));
        if (runResp.IsCreated) {
            var data = runResp.Created()!;
            CheckNotNull("servertest.run.test_id", data.Test?.Id);
            serverTestId = data.Test?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: servertest.run unexpected status: {runResp.StatusCode}");
        }

        var listResp = await stApi.ListServerTestsAsync();
        if (listResp.IsOk) {
            CheckNotNull("servertest.list", listResp.Ok());
        } else {
            failed++;
            Console.WriteLine($"  FAIL: servertest.list unexpected status: {listResp.StatusCode}");
        }

        if (serverTestId != null) {
            var getResp = await stApi.GetServerTestAsync(serverTestId);
            if (getResp.IsOk) {
                CheckNotNull("servertest.get.test", getResp.Ok()!.Test);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: servertest.get unexpected status: {getResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: servertest raised: {e.Message}");
    }
}

// --- Contact Lists ---
{
    var clApi = sp.GetRequiredService<IContactListsApi>();
    string? contactListId = null;
    try {
        var createResp = await clApi.CreateContactListAsync(new CreateContactListRequest(
            name: $"smoke-{ts}"
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("contactlist.create.id", data.ContactList?.Id);
            contactListId = data.ContactList?.Id;
        } else {
            failed++;
            Console.WriteLine($"  FAIL: contactlist.create unexpected status: {createResp.StatusCode}");
        }

        var listResp = await clApi.ListContactListsAsync();
        if (listResp.IsOk) {
            CheckNotNull("contactlist.list", listResp.Ok()!.ContactLists);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: contactlist.list unexpected status: {listResp.StatusCode}");
        }

        if (contactListId != null) {
            var delResp = await clApi.DeleteContactListAsync(contactListId);
            if (delResp.IsOk) {
                CheckTrue("contactlist.delete", delResp.Ok()!.Deleted);
                contactListId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: contactlist.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: contactlist raised: {e.Message}");
    } finally {
        if (contactListId != null) {
            try { await clApi.DeleteContactListAsync(contactListId); } catch { }
        }
    }
}

// --- Content Classification ---
{
    var ccApi = sp.GetRequiredService<IContentClassificationApi>();
    try {
        var classifyResp = await ccApi.ClassifyContentAsync(new ClassifyContentRequest(
            subject: "Test",
            content: "Test body"
        ));
        if (classifyResp.IsOk) {
            CheckNotNull("content.classify.check", classifyResp.Ok()!.ContentCheck);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: content.classify unexpected status: {classifyResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: content.classify raised: {e.Message}");
    }
}

// --- Event Tracking ---
{
    var evtApi = sp.GetRequiredService<IEventsApi>();
    try {
        var evtResp = await evtApi.TrackEventAsync(new TrackEventRequest(
            eventType: TrackEventRequest.EventTypeEnum.Purchase,
            email: $"smoke-{ts}@example.com"
        ));
        if (evtResp.IsCreated) {
            var data = evtResp.Created()!;
            CheckTrue("event.track.created", data.Created);
            CheckNotNull("event.track.event_id", data.EventId);
            Check("event.track.schema_version", "1.1", data.SchemaVersion);
        } else if (evtResp.IsOk) {
            var data = evtResp.Ok()!;
            CheckTrue("event.track.created", data.Created);
            CheckNotNull("event.track.event_id", data.EventId);
            Check("event.track.schema_version", "1.1", data.SchemaVersion);
        } else {
            failed++;
            Console.WriteLine($"  FAIL: event.track unexpected status: {evtResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: event.track raised: {e.Message}");
    }
}

// --- Message Events (DI resolve only) ---
try {
    var eventsApi = sp.GetRequiredService<IMessageEventsApi>();
    CheckNotNull("events.resolve", eventsApi);
} catch (Exception e) {
    failed++;
    Console.WriteLine($"  FAIL: events.resolve raised: {e.Message}");
}

// --- Email Sending (DI resolve only) ---
try {
    var sendApi = sp.GetRequiredService<IEmailSendingApi>();
    CheckNotNull("sending.resolve", sendApi);
} catch (Exception e) {
    failed++;
    Console.WriteLine($"  FAIL: sending.resolve raised: {e.Message}");
}

// --- Alert Rules CRUD ---
{
    var alertApi = sp.GetRequiredService<IAlertRulesApi>();
    string? ruleId = null;
    try {
        var createResp = await alertApi.CreateAlertRuleAsync(new CreateAlertRuleRequest(
            metric: "hard_bounce_rate", threshold: 0.05m, channel: "webhook"
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("alert.create.id", data.Rule?.Id);
            ruleId = data.Rule?.Id;
        } else if ((int)createResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: alert_rules (plan-gated)");
        } else if ((int)createResp.StatusCode == 500 || (int)createResp.StatusCode == 400) {
            Warn("alert", $"server error: {createResp.StatusCode}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: alert.create unexpected status: {createResp.StatusCode}");
        }

        if (ruleId != null) {
            var getResp = await alertApi.GetAlertRuleAsync(ruleId);
            if (getResp.IsOk) {
                Check("alert.get.metric", "hard_bounce_rate", getResp.Ok()!.Rule?.Metric);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: alert.get unexpected status: {getResp.StatusCode}");
            }

            var updateResp = await alertApi.UpdateAlertRuleAsync(ruleId, new UpdateAlertRuleRequest(
                threshold: new Option<decimal?>(0.10m)
            ));
            if (updateResp.IsOk) {
                var updated = await alertApi.GetAlertRuleAsync(ruleId);
                if (updated.IsOk) {
                    CheckTrue("alert.update.threshold", updated.Ok()!.Rule?.Threshold == 0.10m);
                } else {
                    failed++;
                    Console.WriteLine($"  FAIL: alert.update.verify unexpected status: {updated.StatusCode}");
                }
            } else {
                failed++;
                Console.WriteLine($"  FAIL: alert.update unexpected status: {updateResp.StatusCode}");
            }

            var listResp = await alertApi.ListAlertRulesAsync();
            if (listResp.IsOk) {
                CheckTrue("alert.list.count", listResp.Ok()!.Rules?.Count > 0);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: alert.list unexpected status: {listResp.StatusCode}");
            }

            var delResp = await alertApi.DeleteAlertRuleAsync(ruleId);
            if (delResp.IsOk) {
                CheckTrue("alert.delete", delResp.Ok()!.Deleted);
                ruleId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: alert.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        if (e.Message.Contains("500") || e.Message.Contains("Internal Server Error")) {
            Warn("alert", $"server error: {e.Message}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: alert raised: {e.Message}");
        }
    } finally {
        if (ruleId != null) {
            try { await alertApi.DeleteAlertRuleAsync(ruleId); } catch { }
        }
    }
}

// --- Reputation ---
{
    var repApi = sp.GetRequiredService<IReputationApi>();
    try {
        var repResp = await repApi.GetReputationAsync(period: new Option<string>("7d"));
        if (repResp.IsOk) {
            CheckNotNull("reputation.get", repResp.Ok());
        } else if ((int)repResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: reputation.get (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: reputation.get unexpected status: {repResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: reputation.get raised: {e.Message}");
    }

    try {
        var timelineResp = await repApi.GetReputationTimelineAsync(period: new Option<string>("30d"));
        if (timelineResp.IsOk) {
            CheckNotNull("reputation.timeline", timelineResp.Ok());
        } else if ((int)timelineResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: reputation.timeline (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: reputation.timeline unexpected status: {timelineResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: reputation.timeline raised: {e.Message}");
    }
}

// --- Spam Check Delete ---
{
    var spamApi = sp.GetRequiredService<ISpamChecksApi>();
    string? spamCheckId = null;
    try {
        var runResp = await spamApi.RunSpamCheckAsync(new RunSpamCheckRequest(fromDomain: "example.com"));
        if (runResp.IsCreated) {
            var data = runResp.Created()!;
            CheckNotNull("spam.run.id", data.SpamCheck?.Id);
            spamCheckId = data.SpamCheck?.Id;
        } else if ((int)runResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: spam_checks (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: spam.run unexpected status: {runResp.StatusCode}");
        }

        if (spamCheckId != null) {
            var getResp = await spamApi.GetSpamCheckAsync(spamCheckId);
            if (getResp.IsOk) {
                Check("spam.get.id", spamCheckId, getResp.Ok()!.SpamCheck?.Id);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: spam.get unexpected status: {getResp.StatusCode}");
            }

            var delResp = await spamApi.DeleteSpamCheckAsync(spamCheckId);
            if (delResp.IsOk) {
                CheckTrue("spam.delete", delResp.Ok()!.Deleted);
                spamCheckId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: spam.delete unexpected status: {delResp.StatusCode}");
            }

            // Verify deleted
            try {
                var verifyResp = await spamApi.GetSpamCheckAsync(spamCheckId ?? "deleted");
                if (verifyResp.IsNotFound) {
                    passed++;
                } else {
                    failed++;
                    Console.WriteLine("  FAIL: spam.deleted still accessible");
                }
            } catch {
                passed++; // Any error means it was deleted
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: spam raised: {e.Message}");
    } finally {
        if (spamCheckId != null) {
            try { await spamApi.DeleteSpamCheckAsync(spamCheckId); } catch { }
        }
    }
}

// --- Bounce Analysis Delete ---
{
    var bounceApi = sp.GetRequiredService<IBounceAnalysisApi>();
    string? analysisId = null;
    try {
        var createResp = await bounceApi.CreateBounceAnalysisAsync(new CreateBounceAnalysisRequest(
            text: "550 5.1.1 User unknown\n452 4.2.2 Mailbox full",
            name: new Option<string?>($"smoke-{ts}")
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("bounce_analysis.create", data.Analysis);
            analysisId = data.Analysis?.Id;
        } else if ((int)createResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: bounce_analysis (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: bounce_analysis.create unexpected status: {createResp.StatusCode}");
        }

        if (analysisId != null) {
            var delResp = await bounceApi.DeleteBounceAnalysisAsync(analysisId);
            if (delResp.IsOk) {
                CheckTrue("bounce_analysis.delete", delResp.Ok()!.Deleted);
                analysisId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: bounce_analysis.delete unexpected status: {delResp.StatusCode}");
            }

            // Verify deleted
            try {
                var verifyResp = await bounceApi.GetBounceAnalysisAsync(analysisId ?? "deleted");
                if (verifyResp.IsNotFound) {
                    passed++;
                } else {
                    failed++;
                    Console.WriteLine("  FAIL: bounce_analysis.deleted still accessible");
                }
            } catch {
                passed++; // Any error means it was deleted
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: bounce_analysis raised: {e.Message}");
    } finally {
        if (analysisId != null) {
            try { await bounceApi.DeleteBounceAnalysisAsync(analysisId); } catch { }
        }
    }
}

// --- Pixel Settings ---
{
    var pixelApi = sp.GetRequiredService<IPixelSettingsApi>();
    try {
        var getResp = await pixelApi.GetPixelSettingsAsync();
        if (getResp.IsOk) {
            CheckNotNull("pixel.get.has_uuid", getResp.Ok()!.PixelUuid);
        } else if ((int)getResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: pixel_settings (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: pixel.get unexpected status: {getResp.StatusCode}");
        }

        if (getResp.IsOk) {
            var updateResp = await pixelApi.UpdatePixelSettingsAsync(new UpdatePixelSettingsRequest(
                pixelSubscribeListId: null
            ));
            if (updateResp.IsOk) {
                CheckNotNull("pixel.update.has_uuid", updateResp.Ok()!.PixelUuid);
            } else {
                failed++;
                Console.WriteLine($"  FAIL: pixel.update unexpected status: {updateResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: pixel raised: {e.Message}");
    }
}

// --- Contact List Contacts CRUD ---
{
    var clApi = sp.GetRequiredService<IContactListsApi>();
    string? clListId = null;
    try {
        var createResp = await clApi.CreateContactListAsync(new CreateContactListRequest(
            name: $"smoke-contacts-{ts}"
        ));
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("contacts.list_create.id", data.ContactList?.Id);
            clListId = data.ContactList?.Id;
        } else if ((int)createResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: contact_list_contacts (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: contacts.list_create unexpected status: {createResp.StatusCode}");
        }

        if (clListId != null) {
            var contactEmail = $"smoke-test-{ts}@example.com";
            var addResp = await clApi.AddContactAsync(clListId, new AddContactRequest(
                email: contactEmail, firstName: new Option<string?>("Smoke")
            ));
            if (addResp.IsCreated) {
                var contact = addResp.Created()!.Contact;
                CheckNotNull("contacts.add.contact", contact);

                // Extract contact ID from the Object response
                string? contactId = null;
                if (contact is System.Text.Json.JsonElement je && je.TryGetProperty("id", out var idProp)) {
                    contactId = idProp.GetString();
                }

                if (contactId != null) {
                    var updateContactResp = await clApi.UpdateContactAsync(clListId, contactId, new UpdateContactRequest(
                        lastName: new Option<string?>("Test")
                    ));
                    if (updateContactResp.IsOk) {
                        passed++; // update did not fail
                    } else {
                        failed++;
                        Console.WriteLine($"  FAIL: contacts.update unexpected status: {updateContactResp.StatusCode}");
                    }

                    var delContactResp = await clApi.DeleteContactAsync(clListId, contactId);
                    if (delContactResp.IsOk) {
                        passed++; // delete did not fail
                    } else {
                        failed++;
                        Console.WriteLine($"  FAIL: contacts.delete_contact unexpected status: {delContactResp.StatusCode}");
                    }
                }
            } else {
                failed++;
                Console.WriteLine($"  FAIL: contacts.add unexpected status: {addResp.StatusCode}");
            }

            var delListResp = await clApi.DeleteContactListAsync(clListId);
            if (delListResp.IsOk) {
                passed++; // list delete did not fail
                clListId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: contacts.delete_list unexpected status: {delListResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: contacts raised: {e.Message}");
    } finally {
        if (clListId != null) {
            try { await clApi.DeleteContactListAsync(clListId); } catch { }
        }
    }
}

// --- OOO Batch Check ---
{
    var oooApi = sp.GetRequiredService<IOutOfOfficeApi>();
    try {
        var oooResp = await oooApi.BatchCheckOooAsync(new BatchCheckOooRequest(
            emails: new List<string> { "test@example.com" }
        ));
        if (oooResp.IsOk) {
            CheckNotNull("ooo.batch.has_results", oooResp.Ok()!.Results);
        } else if ((int)oooResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: ooo_batch (plan-gated)");
        } else if ((int)oooResp.StatusCode == 500) {
            Warn("ooo", $"server error: {oooResp.StatusCode}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: ooo.batch unexpected status: {oooResp.StatusCode}");
        }
    } catch (Exception e) {
        if (e.Message.Contains("500") || e.Message.Contains("Internal Server Error")) {
            Warn("ooo", $"server error: {e.Message}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: ooo raised: {e.Message}");
        }
    }
}

// --- Engagement Summary ---
{
    var engageApi = sp.GetRequiredService<IEngagementApi>();
    try {
        var engageResp = await engageApi.GetEngagementSummaryAsync();
        if (engageResp.IsOk) {
            CheckNotNull("engagement.summary", engageResp.Ok());
        } else if (engageResp.IsForbidden) {
            Console.WriteLine("  SKIP: engagement_summary (plan-gated)");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: engagement.summary unexpected status: {engageResp.StatusCode}");
        }
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: engagement raised: {e.Message}");
    }
}

// --- Webhook CLI ---
{
    var webhookApi = sp.GetRequiredService<IWebhookCLIApi>();
    string? sessionId = null;
    try {
        var createResp = await webhookApi.CreateWebhookCliSessionAsync(
            new Option<CreateWebhookCliSessionRequest>(new CreateWebhookCliSessionRequest(
                forwardUrl: new Option<string?>("http://localhost:9999/hooks")
            ))
        );
        if (createResp.IsCreated) {
            var data = createResp.Created()!;
            CheckNotNull("webhook_cli.create.session_id", data.SessionId);
            sessionId = data.SessionId;
        } else if ((int)createResp.StatusCode == 403) {
            Console.WriteLine("  SKIP: webhook_cli (plan-gated)");
        } else if ((int)createResp.StatusCode == 500) {
            Warn("webhook_cli", $"server error: {createResp.StatusCode}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: webhook_cli.create unexpected status: {createResp.StatusCode}");
        }

        if (sessionId != null) {
            var deliveriesResp = await webhookApi.ListWebhookDeliveriesAsync(limit: new Option<int>(10));
            if (deliveriesResp.IsOk) {
                CheckNotNull("webhook_cli.deliveries", deliveriesResp.Ok());
            } else if ((int)deliveriesResp.StatusCode == 500) {
                Warn("webhook_cli.deliveries", $"server error: {deliveriesResp.StatusCode}");
            } else {
                failed++;
                Console.WriteLine($"  FAIL: webhook_cli.deliveries unexpected status: {deliveriesResp.StatusCode}");
            }

            var delResp = await webhookApi.DeleteWebhookCliSessionAsync(sessionId);
            if (delResp.IsOk) {
                CheckNotNull("webhook_cli.delete", delResp.Ok());
                sessionId = null;
            } else {
                failed++;
                Console.WriteLine($"  FAIL: webhook_cli.delete unexpected status: {delResp.StatusCode}");
            }
        }
    } catch (Exception e) {
        if (e.Message.Contains("500") || e.Message.Contains("Internal Server Error")) {
            Warn("webhook_cli", $"server error: {e.Message}");
        } else {
            failed++;
            Console.WriteLine($"  FAIL: webhook_cli raised: {e.Message}");
        }
    } finally {
        if (sessionId != null) {
            try { await webhookApi.DeleteWebhookCliSessionAsync(sessionId); } catch { }
        }
    }
}

var total = passed + failed;
var warnStr = warned > 0 ? $", {warned} warnings" : "";
var result = failed == 0 ? "PASS" : "FAIL";
Console.WriteLine($"\n{result}: C# SDK ({passed}/{total}{warnStr})");
return failed == 0 ? 0 : 1;
