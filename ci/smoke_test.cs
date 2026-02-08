// SDK smoke test -- validates build-from-source and API integration.
using System.Net.Http;
using System.Text;
using System.Text.Json;

var apiUrl = "https://api.mailodds.com";
var apiKey = Environment.GetEnvironmentVariable("MAILODDS_TEST_KEY") ?? "";
if (string.IsNullOrEmpty(apiKey)) { Console.WriteLine("ERROR: MAILODDS_TEST_KEY not set"); return 1; }

// Prove SDK types load
var _ = typeof(MailOdds.Api.EmailValidationApi);

int passed = 0, failed = 0;

void Check(string label, string? expected, string? actual) {
    if (expected == actual) passed++;
    else { failed++; Console.WriteLine($"  FAIL: {label} expected={expected} got={actual}"); }
}

async Task<(int code, JsonDocument? data)> ApiCall(string email, string key) {
    using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
    var content = new StringContent(JsonSerializer.Serialize(new { email }), Encoding.UTF8, "application/json");
    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {key}");
    var resp = await client.PostAsync($"{apiUrl}/v1/validate", content);
    var body = await resp.Content.ReadAsStringAsync();
    return ((int)resp.StatusCode, JsonDocument.Parse(body));
}

string? JGet(JsonDocument doc, string key) {
    if (!doc.RootElement.TryGetProperty(key, out var prop)) return null;
    if (prop.ValueKind == JsonValueKind.Null) return null;
    if (prop.ValueKind == JsonValueKind.True) return "true";
    if (prop.ValueKind == JsonValueKind.False) return "false";
    return prop.GetString();
}

var cases = new (string email, string status, string action, string? sub)[] {
    ("test@deliverable.mailodds.com", "valid", "accept", null),
    ("test@invalid.mailodds.com", "invalid", "reject", "smtp_rejected"),
    ("test@risky.mailodds.com", "catch_all", "accept_with_caution", "catch_all_detected"),
    ("test@disposable.mailodds.com", "do_not_mail", "reject", "disposable"),
    ("test@role.mailodds.com", "do_not_mail", "reject", "role_account"),
    ("test@timeout.mailodds.com", "unknown", "retry_later", "smtp_unreachable"),
    ("test@freeprovider.mailodds.com", "valid", "accept", null),
};

foreach (var (email, expStatus, expAction, expSub) in cases) {
    var domain = email.Split('@')[1].Split('.')[0];
    try {
        var (code, doc) = await ApiCall(email, apiKey);
        Check($"{domain}.status", expStatus, JGet(doc!, "status"));
        Check($"{domain}.action", expAction, JGet(doc!, "action"));
        Check($"{domain}.sub_status", expSub, JGet(doc!, "sub_status"));
        Check($"{domain}.test_mode", "true", JGet(doc!, "test_mode"));
    } catch (Exception e) {
        failed++;
        Console.WriteLine($"  FAIL: {domain} error: {e.Message}");
    }
}

var (code401, _2) = await ApiCall("test@deliverable.mailodds.com", "invalid_key");
Check("error.401", "401", code401.ToString());

using var c2 = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
c2.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
var r400 = await c2.PostAsync($"{apiUrl}/v1/validate", new StringContent("{}", Encoding.UTF8, "application/json"));
var c400 = (int)r400.StatusCode;
if (c400 == 400 || c400 == 422) passed++;
else { failed++; Console.WriteLine($"  FAIL: error.400 expected=400|422 got={c400}"); }

var total = passed + failed;
var result = failed == 0 ? "PASS" : "FAIL";
Console.WriteLine($"\n{result}: C# SDK ({passed}/{total})");
return failed == 0 ? 0 : 1;
