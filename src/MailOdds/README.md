# Created with Openapi Generator

<a id="cli"></a>
## Creating the library
Create a config.yaml file similar to what is below, then run the following powershell command to generate the library `java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate -c config.yaml`

```yaml
generatorName: csharp
inputSpec: platform/frontend/static/openapi.yaml
outputDir: out

# https://openapi-generator.tech/docs/generators/csharp
additionalProperties:
  packageGuid: '{9CC8D9EE-350F-4AE8-885E-EC5D2F60D7FC}'

# https://openapi-generator.tech/docs/integrations/#github-integration
# gitHost:
# gitUserId:
# gitRepoId:

# https://openapi-generator.tech/docs/globals
# globalProperties:

# https://openapi-generator.tech/docs/customization/#inline-schema-naming
# inlineSchemaOptions:

# https://openapi-generator.tech/docs/customization/#name-mapping
# modelNameMappings:
# nameMappings:

# https://openapi-generator.tech/docs/customization/#openapi-normalizer
# openapiNormalizer:

# templateDir: https://openapi-generator.tech/docs/templating/#modifying-templates

# releaseNote:
```

<a id="usage"></a>
## Using the library in your project

```cs
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MailOdds.Api;
using MailOdds.Client;
using MailOdds.Model;
using Org.OpenAPITools.Extensions;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IBulkValidationApi>();
            ICancelJobApiResponse apiResponse = await api.CancelJobAsync("todo");
            JobResponse? model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, services, options) =>
          {
              // The type of token here depends on the api security specifications
              // Available token types are ApiKeyToken, BasicToken, BearerToken, HttpSigningToken, and OAuthToken.
              BearerToken token = new("<your token>");
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<BearerToken>, BearerToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(client =>
              {
                  // client configuration
              }, builder =>
              {
                  builder
                      .AddRetryPolicy(2)
                      .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                      .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30));
                      // add whatever middleware you prefer
                  }
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  Configure Polly in the IHttpClientBuilder
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After partial methods in the api classes.

## Api Information
- appName: MailOdds Email Validation API
- appVersion: 1.0.0
- appDescription: MailOdds provides email validation services to help maintain clean email lists  and improve deliverability. The API performs multiple validation checks including  format verification, domain validation, MX record checking, and disposable email detection.  ## Authentication  All API requests require authentication using a Bearer token. Include your API key  in the Authorization header:  &#x60;&#x60;&#x60; Authorization: Bearer YOUR_API_KEY &#x60;&#x60;&#x60;  API keys can be created in the MailOdds dashboard.  ## Rate Limits  Rate limits vary by plan: - Free: 10 requests/minute - Starter: 60 requests/minute   - Pro: 300 requests/minute - Business: 1000 requests/minute - Enterprise: Custom limits  ## Response Format  All responses include: - &#x60;schema_version&#x60;: API schema version (currently \&quot;1.0\&quot;) - &#x60;request_id&#x60;: Unique request identifier for debugging  Error responses include: - &#x60;error&#x60;: Machine-readable error code - &#x60;message&#x60;: Human-readable error description 

## Build
This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

- SDK version: 1.0.0
- Generator version: 7.19.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
