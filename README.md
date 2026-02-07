# MailOdds SDK for C#

Official C# client for the [MailOdds Email Validation API](https://mailodds.com/docs).

## Installation

```shell
dotnet add package MailOdds
```

Requires .NET 8 or later.

## Quick Start

```csharp
using MailOdds.Api;
using MailOdds.Client;
using MailOdds.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
    .ConfigureApi((ctx, services, options) =>
    {
        options.AddTokens(new BearerToken("mo_live_your_api_key"));
    })
    .Build();

var api = host.Services.GetRequiredService<IEmailValidationApi>();
var request = new ValidateRequest("user@example.com");
var response = await api.ValidateEmailAsync(request);
var result = response.Ok();

switch (result.Action)
{
    case ValidationResponse.ActionEnum.Accept:
        Console.WriteLine("Safe to send");
        break;
    case ValidationResponse.ActionEnum.AcceptWithCaution:
        Console.WriteLine("Valid but risky -- flag for review");
        break;
    case ValidationResponse.ActionEnum.Reject:
        Console.WriteLine("Do not send");
        break;
    case ValidationResponse.ActionEnum.RetryLater:
        Console.WriteLine("Temporary failure -- retry after backoff");
        break;
}
```

## Response Handling

Branch on the `action` field for decisioning:

| Action | Meaning | Recommended |
|--------|---------|-------------|
| `accept` | Safe to send | Add to mailing list |
| `accept_with_caution` | Valid but risky (catch-all, role account) | Flag for review |
| `reject` | Invalid or disposable | Do not send |
| `retry_later` | Temporary failure | Retry after backoff |

## Test Mode

Use an `mo_test_` prefixed API key with test domains for predictable responses without consuming credits.

## API Reference

- Website: https://mailodds.com
- Full documentation: https://mailodds.com/docs
- OpenAPI spec: https://mailodds.com/openapi.yaml
- All SDKs: https://mailodds.com/sdks

## License

MIT
