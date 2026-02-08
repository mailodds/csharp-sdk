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

void Check(string label, string? expected, string? actual) {
    if (expected == actual) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected={expected} got={actual}"); }
}

void CheckBool(string label, bool expected, bool? actual) {
    if (actual != null && expected == actual) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected={expected} got={actual}"); }
}

// Set up DI container with SDK
var services = new ServiceCollection();
services.AddLogging(b => b.SetMinimumLevel(LogLevel.Warning));
services.AddApi(options => {
    options.AddTokens(new BearerToken(apiKey));
    options.AddApiHttpClients(client => client.BaseAddress = new Uri("https://api.mailodds.com"));
});
var sp = services.BuildServiceProvider();
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
            Check($"{domain}.sub_status", expSub, data.SubStatus);
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

var total = passed + failed;
var result = failed == 0 ? "PASS" : "FAIL";
Console.WriteLine($"\n{result}: C# SDK ({passed}/{total})");
return failed == 0 ? 0 : 1;
