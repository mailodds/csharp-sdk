# MailOdds C# / .NET SDK

The official .NET client for the MailOdds email deliverability platform. Monitor deliverability metrics, enforce validation policies, and protect sender reputation from any C# or .NET application.

[![NuGet](https://img.shields.io/nuget/v/MailOdds)](https://github.com/mailodds/csharp-sdk)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![API Docs](https://img.shields.io/badge/API-docs-blue)](https://mailodds.com/docs)

## Installation

```bash
dotnet add package MailOdds
```

Requires .NET 6 or later.

## Quick Start

```csharp
using MailOdds.Api;
using MailOdds.Client;
using MailOdds.Model;

var config = new Configuration
{
    BasePath = "https://api.mailodds.com/v1",
    AccessToken = Environment.GetEnvironmentVariable("MAILODDS_API_KEY")
};

var api = new EmailValidationApi(config);
var request = new ValidateRequest(email: "user@example.com");
var result = await api.ValidateEmailAsync(request);

Console.WriteLine($"Status: {result.Result.Status}, Action: {result.Result.Action}");
```

## MailOdds Platform

MailOdds provides a full-stack email deliverability platform. Explore the capabilities that this SDK connects you to:

- [Email Validation API](https://mailodds.com/email-validation-api) - Real-time email verification with 25+ checks
- [Email Sending API](https://mailodds.com/email-sending-api) - Transactional email delivery with DKIM dual signing
- [Email Campaigns](https://mailodds.com/docs) - A/B tested campaign delivery with engagement tracking
- [Email Blacklist Monitoring](https://mailodds.com/email-blacklist-monitoring) - Continuous monitoring across 80+ DNSBLs
- [Email Deliverability Platform](https://mailodds.com/email-deliverability-platform) - Unified dashboard for all deliverability signals
- [Email Spam Checker](https://mailodds.com/email-spam-checker) - Pre-send content analysis and spam score prediction
- [Email Suppression List](https://mailodds.com/email-suppression-list) - Centralized suppression management
- [Email Validation Policies](https://mailodds.com/email-validation-policies) - Rule-based validation with preset templates
- [Free Email Validator](https://mailodds.com/) - Try single-email validation on the homepage
- [Privacy](https://mailodds.com/privacy) - Data handling and privacy practices
- [Blog](https://mailodds.com/blog) - Email deliverability insights and platform updates

## Features

- **.NET 6+ with async/await** - All API methods provide both synchronous and asynchronous variants, letting you use `await` throughout your application for non-blocking I/O
- **Dependency injection support** - Register API clients in your DI container with standard .NET patterns, making it straightforward to use in ASP.NET Core, Worker Services, and other hosted applications
- **Polly retry policies** - Integrate with the Polly resilience library to add retry, circuit breaker, and timeout policies to all HTTP calls through the underlying HttpClient
- **Strongly typed models** - Every request and response is a C# class with full property typing, nullability annotations, and XML doc comments for IntelliSense support
- **Full platform coverage** - Access all MailOdds capabilities including validation, sending, campaigns, DMARC monitoring, blacklist checks, suppression lists, and validation policies
- **Structured error handling** - ApiException carries HTTP status codes, response bodies, and headers for precise error recovery in production systems

## Why MailOdds

MailOdds is a complete email deliverability platform built for developers. Every email validated or sent through MailOdds passes through 25+ real-time checks including syntax verification, DNS and MX validation, SMTP mailbox probing, disposable domain detection, and role account identification.

The platform maintains sub-200ms median response times for single validations, 99.9% API uptime, and processes bulk lists of up to 500,000 emails per job. MailOdds supports 11 language SDKs, an MCP server for AI agent integration, a CLI for local development, and a WordPress plugin for no-code deployments.

All email sending uses DKIM dual signing with automated key rotation, and the deliverability monitoring stack covers DMARC aggregate reports, blacklist surveillance across 80+ DNSBLs, and real-time sender health scoring.

## API Reference

Full documentation is available at [https://mailodds.com/docs](https://mailodds.com/docs).

All URIs are relative to `https://api.mailodds.com/v1`.

<details>
<summary>All Endpoints</summary>

| Class | Method | HTTP request | Description |
| ----- | ------ | ------------ | ----------- |
| *AgentControlPlaneApi* | **GetMcpCapabilities** | **GET** /v1/mcp/capabilities | Get MCP capabilities |
| *BlacklistMonitoringApi* | **AddBlacklistMonitor** | **POST** /v1/blacklist-monitors | Add blacklist monitor |
| *BlacklistMonitoringApi* | **DeleteBlacklistMonitor** | **DELETE** /v1/blacklist-monitors/{monitor_id} | Delete a blacklist monitor |
| *BlacklistMonitoringApi* | **GetBlacklistHistory** | **GET** /v1/blacklist-monitors/{monitor_id}/history | Get blacklist check history |
| *BlacklistMonitoringApi* | **ListBlacklistMonitors** | **GET** /v1/blacklist-monitors | List blacklist monitors |
| *BlacklistMonitoringApi* | **RunBlacklistCheck** | **POST** /v1/blacklist-monitors/{monitor_id}/check | Run blacklist check |
| *BounceAnalysisApi* | **CreateBounceAnalysis** | **POST** /v1/bounce-analyses | Analyze bounce logs |
| *BounceAnalysisApi* | **CrossReferenceBounces** | **GET** /v1/bounce-analyses/{analysis_id}/cross-reference | Cross-reference bounces with validation logs |
| *BounceAnalysisApi* | **GetBounceAnalysis** | **GET** /v1/bounce-analyses/{analysis_id} | Get bounce analysis |
| *BounceAnalysisApi* | **GetBounceRecords** | **GET** /v1/bounce-analyses/{analysis_id}/records | Get bounce records |
| *BulkValidationApi* | **CancelJob** | **POST** /v1/jobs/{job_id}/cancel | Cancel a job |
| *BulkValidationApi* | **CreateJob** | **POST** /v1/jobs | Create bulk validation job (JSON) |
| *BulkValidationApi* | **CreateJobFromS3** | **POST** /v1/jobs/upload/s3 | Create job from S3 upload |
| *BulkValidationApi* | **CreateJobUpload** | **POST** /v1/jobs/upload | Create bulk validation job (file upload) |
| *BulkValidationApi* | **DeleteJob** | **DELETE** /v1/jobs/{job_id} | Delete a job |
| *BulkValidationApi* | **GetJob** | **GET** /v1/jobs/{job_id} | Get job status |
| *BulkValidationApi* | **GetJobResults** | **GET** /v1/jobs/{job_id}/results | Get job results |
| *BulkValidationApi* | **GetPresignedUpload** | **POST** /v1/jobs/upload/presigned | Get S3 presigned upload URL |
| *BulkValidationApi* | **ListJobs** | **GET** /v1/jobs | List validation jobs |
| *CampaignAnalyticsApi* | **GetCampaignABResults** | **GET** /v1/campaigns/{campaign_id}/ab-results | Get A/B test results |
| *CampaignAnalyticsApi* | **GetCampaignAttribution** | **GET** /v1/campaigns/{campaign_id}/conversions/attribution | Get campaign attribution |
| *CampaignAnalyticsApi* | **GetCampaignDeliveryConfidence** | **GET** /v1/campaigns/{campaign_id}/delivery-confidence | Get pre-send delivery confidence |
| *CampaignAnalyticsApi* | **GetCampaignFunnel** | **GET** /v1/campaigns/{campaign_id}/funnel | Get campaign funnel |
| *CampaignAnalyticsApi* | **GetCampaignProviderIntelligence** | **GET** /v1/campaigns/{campaign_id}/provider-intelligence | Get provider intelligence |
| *CampaignsApi* | **CancelCampaign** | **POST** /v1/campaigns/{campaign_id}/cancel | Cancel a campaign |
| *CampaignsApi* | **CreateCampaign** | **POST** /v1/campaigns | Create a campaign |
| *CampaignsApi* | **CreateCampaignVariant** | **POST** /v1/campaigns/{campaign_id}/variants | Create A/B variant |
| *CampaignsApi* | **GetCampaign** | **GET** /v1/campaigns/{campaign_id} | Get campaign with stats |
| *CampaignsApi* | **ListCampaigns** | **GET** /v1/campaigns | List campaigns |
| *CampaignsApi* | **ScheduleCampaign** | **POST** /v1/campaigns/{campaign_id}/schedule | Schedule a campaign |
| *CampaignsApi* | **SendCampaign** | **POST** /v1/campaigns/{campaign_id}/send | Send a campaign |
| *ContactListsApi* | **AppendToContactList** | **POST** /v1/contact-lists/{list_id}/append | Append to contact list |
| *ContactListsApi* | **CreateContactList** | **POST** /v1/contact-lists | Create contact list |
| *ContactListsApi* | **DeleteContactList** | **DELETE** /v1/contact-lists/{list_id} | Delete a contact list |
| *ContactListsApi* | **GetInactiveContactsReport** | **GET** /v1/contacts/inactive-report | Get inactive contacts report |
| *ContactListsApi* | **ListContactLists** | **GET** /v1/contact-lists | List contact lists |
| *ContactListsApi* | **QueryContactList** | **POST** /v1/contact-lists/{list_id}/query | Query contact list |
| *ContentClassificationApi* | **ClassifyContent** | **POST** /v1/content-check | Classify email content |
| *DMARCMonitoringApi* | **AddDmarcDomain** | **POST** /v1/dmarc-domains | Add DMARC domain |
| *DMARCMonitoringApi* | **DeleteDmarcDomain** | **DELETE** /v1/dmarc-domains/{domain_id} | Delete a DMARC domain |
| *DMARCMonitoringApi* | **GetDmarcDomain** | **GET** /v1/dmarc-domains/{domain_id} | Get DMARC domain |
| *DMARCMonitoringApi* | **GetDmarcRecommendation** | **GET** /v1/dmarc-domains/{domain_id}/recommendation | Get DMARC policy recommendation |
| *DMARCMonitoringApi* | **GetDmarcSources** | **GET** /v1/dmarc-domains/{domain_id}/sources | Get DMARC sending sources |
| *DMARCMonitoringApi* | **GetDmarcTrend** | **GET** /v1/dmarc-domains/{domain_id}/trend | Get DMARC trend |
| *DMARCMonitoringApi* | **ListDmarcDomains** | **GET** /v1/dmarc-domains | List DMARC domains |
| *DMARCMonitoringApi* | **VerifyDmarcDomain** | **POST** /v1/dmarc-domains/{domain_id}/verify | Verify DMARC DNS records |
| *EmailSendingApi* | **DeliverBatch** | **POST** /v1/deliver/batch | Send to multiple recipients (max 100) |
| *EmailSendingApi* | **DeliverEmail** | **POST** /v1/deliver | Send a single email |
| *EmailValidationApi* | **ValidateBatch** | **POST** /v1/validate/batch | Validate multiple emails (sync) |
| *EmailValidationApi* | **ValidateEmail** | **POST** /v1/validate | Validate single email |
| *EventsApi* | **TrackEvent** | **POST** /v1/events/track | Track a commerce event |
| *MessageEventsApi* | **GetMessageEvents** | **GET** /v1/message-events | Get message events |
| *OAuth20Api* | **CreateToken** | **POST** /oauth/token | Create token |
| *OAuth20Api* | **GetJwks** | **GET** /.well-known/jwks.json | Get JSON Web Key Set |
| *OAuth20Api* | **IntrospectToken** | **POST** /oauth/introspect | Introspect token |
| *OAuth20Api* | **OauthServerMetadata** | **GET** /.well-known/oauth-authorization-server | OAuth server metadata |
| *OAuth20Api* | **RevokeToken** | **POST** /oauth/revoke | Revoke token |
| *ProductsApi* | **BatchProducts** | **POST** /v1/stores/{store_id}/products/batch | Batch push products |
| *ProductsApi* | **GetProduct** | **GET** /v1/store-products/{product_id} | Get a product |
| *ProductsApi* | **QueryProducts** | **GET** /v1/store-products | Query products |
| *SenderHealthApi* | **GetSenderHealth** | **GET** /v1/sender-health | Get sender health score |
| *SenderHealthApi* | **GetSenderHealthTrend** | **GET** /v1/sender-health/trend | Get sender health trend |
| *SendingDomainsApi* | **CreateSendingDomain** | **POST** /v1/sending-domains | Add a sending domain |
| *SendingDomainsApi* | **DeleteSendingDomain** | **DELETE** /v1/sending-domains/{domain_id} | Delete a sending domain |
| *SendingDomainsApi* | **GetSendingDomain** | **GET** /v1/sending-domains/{domain_id} | Get a sending domain |
| *SendingDomainsApi* | **GetSendingDomainIdentityScore** | **GET** /v1/sending-domains/{domain_id}/identity-score | Get domain identity score |
| *SendingDomainsApi* | **GetSendingStats** | **GET** /v1/sending-stats | Get sending statistics |
| *SendingDomainsApi* | **ListSendingDomains** | **GET** /v1/sending-domains | List sending domains |
| *SendingDomainsApi* | **VerifySendingDomain** | **POST** /v1/sending-domains/{domain_id}/verify | Verify domain DNS records |
| *ServerTestsApi* | **GetServerTest** | **GET** /v1/server-tests/{test_id} | Get server test |
| *ServerTestsApi* | **ListServerTests** | **GET** /v1/server-tests | List server tests |
| *ServerTestsApi* | **RunServerTest** | **POST** /v1/server-tests | Run server test |
| *SpamChecksApi* | **GetSpamCheck** | **GET** /v1/spam-checks/{check_id} | Get spam check |
| *SpamChecksApi* | **ListSpamChecks** | **GET** /v1/spam-checks | List spam checks |
| *SpamChecksApi* | **RunSpamCheck** | **POST** /v1/spam-checks | Run spam check |
| *StoreConnectionsApi* | **CreateStore** | **POST** /v1/stores | Create a store connection |
| *StoreConnectionsApi* | **DisconnectStore** | **DELETE** /v1/stores/{store_id} | Disconnect a store |
| *StoreConnectionsApi* | **GetStore** | **GET** /v1/stores/{store_id} | Get a store connection |
| *StoreConnectionsApi* | **ListStores** | **GET** /v1/stores | List store connections |
| *StoreConnectionsApi* | **TriggerSync** | **POST** /v1/stores/{store_id}/sync | Trigger product sync |
| *SubscriberListsApi* | **ConfirmSubscription** | **GET** /v1/confirm/{token} | Confirm subscription |
| *SubscriberListsApi* | **CreateList** | **POST** /v1/lists | Create a subscriber list |
| *SubscriberListsApi* | **DeleteList** | **DELETE** /v1/lists/{list_id} | Delete a subscriber list |
| *SubscriberListsApi* | **GetList** | **GET** /v1/lists/{list_id} | Get a subscriber list |
| *SubscriberListsApi* | **GetLists** | **GET** /v1/lists | List subscriber lists |
| *SubscriberListsApi* | **GetSubscribers** | **GET** /v1/lists/{list_id}/subscribers | List subscribers |
| *SubscriberListsApi* | **Subscribe** | **POST** /v1/subscribe/{list_id} | Subscribe to a list |
| *SubscriberListsApi* | **UnsubscribeSubscriber** | **DELETE** /v1/lists/{list_id}/subscribers/{subscriber_id} | Unsubscribe a subscriber |
| *SuppressionListsApi* | **AddSuppression** | **POST** /v1/suppression | Add suppression entries |
| *SuppressionListsApi* | **CheckSuppression** | **POST** /v1/suppression/check | Check suppression status |
| *SuppressionListsApi* | **GetSuppressionAuditLog** | **GET** /v1/suppression/audit | Get suppression audit log |
| *SuppressionListsApi* | **GetSuppressionStats** | **GET** /v1/suppression/stats | Get suppression statistics |
| *SuppressionListsApi* | **ListSuppression** | **GET** /v1/suppression | List suppression entries |
| *SuppressionListsApi* | **RemoveSuppression** | **DELETE** /v1/suppression | Remove suppression entries |
| *SystemApi* | **GetTelemetrySummary** | **GET** /v1/telemetry/summary | Get validation telemetry |
| *SystemApi* | **HealthCheck** | **GET** /health | Health check |
| *ValidationPoliciesApi* | **AddPolicyRule** | **POST** /v1/policies/{policy_id}/rules | Add rule to policy |
| *ValidationPoliciesApi* | **CreatePolicy** | **POST** /v1/policies | Create policy |
| *ValidationPoliciesApi* | **CreatePolicyFromPreset** | **POST** /v1/policies/from-preset | Create policy from preset |
| *ValidationPoliciesApi* | **DeletePolicy** | **DELETE** /v1/policies/{policy_id} | Delete policy |
| *ValidationPoliciesApi* | **DeletePolicyRule** | **DELETE** /v1/policies/{policy_id}/rules/{rule_id} | Delete rule |
| *ValidationPoliciesApi* | **GetPolicy** | **GET** /v1/policies/{policy_id} | Get policy |
| *ValidationPoliciesApi* | **GetPolicyPresets** | **GET** /v1/policies/presets | Get policy presets |
| *ValidationPoliciesApi* | **ListPolicies** | **GET** /v1/policies | List policies |
| *ValidationPoliciesApi* | **TestPolicy** | **POST** /v1/policies/test | Test policy evaluation |
| *ValidationPoliciesApi* | **UpdatePolicy** | **PUT** /v1/policies/{policy_id} | Update policy |

</details>

<details>
<summary>All Models</summary>

- AddBlacklistMonitor201Response
- AddBlacklistMonitorRequest
- AddDmarcDomain201Response
- AddDmarcDomainRequest
- AddPolicyRule201Response
- AddSuppressionRequest
- AddSuppressionRequestEntriesInner
- AddSuppressionResponse
- AppendToContactList200Response
- AppendToContactListRequest
- BatchDeliverRequest
- BatchDeliverRequestStructuredData
- BatchDeliverResponse
- BatchDeliverResponseDelivery
- BatchDeliverResponseRejectedInner
- BatchProductsRequest
- BatchProductsRequestProductsInner
- BatchProductsResponse
- BatchProductsResponseErrorsInner
- BlacklistMonitor
- BlacklistMonitorLatestCheck
- BounceAnalysisResponse
- BounceAnalysisResponseAnalysis
- BounceAnalysisResponseAnalysisCategories
- BounceAnalysisResponseAnalysisTopDomainsInner
- Campaign
- CampaignResponse
- CampaignStats
- CampaignVariant
- CheckSuppressionRequest
- ClassifyContent200Response
- ClassifyContent200ResponseContentCheck
- ClassifyContentRequest
- ConfirmSubscription200Response
- ContactList
- CreateBounceAnalysisRequest
- CreateCampaignRequest
- CreateCampaignVariant201Response
- CreateContactList201Response
- CreateContactListRequest
- CreateJobFromS3Request
- CreateJobRequest
- CreateList201Response
- CreateListRequest
- CreatePolicyFromPresetRequest
- CreatePolicyRequest
- CreateSendingDomain201Response
- CreateSendingDomainRequest
- CreateStore201Response
- CreateStoreRequest
- CreateToken200Response
- CreateVariantRequest
- CrossReferenceBounces200Response
- CrossReferenceBounces200ResponseCrossReference
- CrossReferenceBounces200ResponseCrossReferenceEntriesInner
- DeleteJob200Response
- DeletePolicy200Response
- DeletePolicyRule200Response
- DeliverRequest
- DeliverRequestOptions
- DeliverRequestStructuredData
- DeliverRequestToInner
- DeliverResponse
- DeliverResponseDelivery
- DisconnectStore200Response
- DmarcDomain
- ErrorResponse
- GetBlacklistHistory200Response
- GetBlacklistHistory200ResponseChecksInner
- GetBounceRecords200Response
- GetBounceRecords200ResponseRecordsInner
- GetCampaignABResults200Response
- GetCampaignABResults200ResponseVariantsInner
- GetCampaignABResults200ResponseWinner
- GetCampaignAttribution200Response
- GetCampaignAttribution200ResponseAttribution
- GetCampaignAttribution200ResponseAttributionFirstTouch
- GetCampaignDeliveryConfidence200Response
- GetCampaignDeliveryConfidence200ResponseFactors
- GetCampaignDeliveryConfidence200ResponseFactorsDomainAuth
- GetCampaignDeliveryConfidence200ResponseFactorsListQuality
- GetCampaignDeliveryConfidence200ResponseFactorsSenderReputation
- GetCampaignFunnel200Response
- GetCampaignFunnel200ResponseFunnel
- GetCampaignFunnel200ResponseRates
- GetCampaignProviderIntelligence200Response
- GetCampaignProviderIntelligence200ResponseProvidersInner
- GetDmarcDomain200Response
- GetDmarcDomain200ResponseDomain
- GetDmarcDomain200ResponseDomainAllOfSummary
- GetDmarcRecommendation200Response
- GetDmarcRecommendation200ResponseRecommendation
- GetDmarcSources200Response
- GetDmarcSources200ResponseSourcesInner
- GetDmarcTrend200Response
- GetDmarcTrend200ResponseTrendInner
- GetInactiveContactsReport200Response
- GetInactiveContactsReport200ResponseByListInner
- GetLists200Response
- GetMessageEvents200Response
- GetMessageEvents200ResponseClicksInner
- GetMessageEvents200ResponseEventsInner
- GetMessageEvents200ResponseSummary
- GetPresignedUploadRequest
- GetProduct200Response
- GetSenderHealth200Response
- GetSenderHealth200ResponseComponents
- GetSenderHealth200ResponseComponentsDeliveryRate
- GetSenderHealth200ResponseVolume
- GetSenderHealthTrend200Response
- GetSenderHealthTrend200ResponseDataPointsInner
- GetSendingDomainIdentityScore200Response
- GetSendingStats200Response
- GetSendingStats200ResponseStats
- GetSubscribers200Response
- HealthCheck200Response
- IdentityScoreCheck
- IntrospectToken200Response
- Job
- JobArtifacts
- JobListResponse
- JobResponse
- JobSummary
- JwksResponse
- JwksResponseKeysInner
- ListBlacklistMonitors200Response
- ListCampaigns200Response
- ListContactLists200Response
- ListDmarcDomains200Response
- ListSendingDomains200Response
- ListServerTests200Response
- ListSpamChecks200Response
- ListStores200Response
- McpCapabilities
- McpCapabilitiesPillarsInner
- McpCapabilitiesPillarsInnerToolsInner
- OAuthServerMetadata
- Pagination
- Policy
- PolicyListResponse
- PolicyListResponseLimits
- PolicyPresetsResponse
- PolicyPresetsResponsePresetsInner
- PolicyResponse
- PolicyRule
- PolicyRuleAction
- PolicyTestResponse
- PresignedUploadResponse
- PresignedUploadResponseUpload
- ProductFacets
- ProductFacetsCategoriesInner
- ProductFacetsPriceRangesInner
- ProductFacetsStoresInner
- QueryContactList200Response
- QueryContactList200ResponseEmailsInner
- QueryContactListRequest
- QueryContactListRequestFiltersInner
- QueryProducts200Response
- RemoveSuppression200Response
- RemoveSuppressionRequest
- ResultsResponse
- RunBlacklistCheck200Response
- RunBlacklistCheck200ResponseCheck
- RunServerTest201Response
- RunServerTestRequest
- RunSpamCheck201Response
- RunSpamCheckRequest
- ScheduleCampaignRequest
- SendingDomain
- SendingDomainDnsRecords
- SendingDomainDnsRecordsNs
- SendingDomainIdentityScore
- SendingDomainIdentityScoreBreakdown
- ServerTest
- ServerTestDnsChecks
- ServerTestMxRecordsInner
- ServerTestSmtpCheck
- SpamCheck
- SpamCheckChecks
- StoreConnection
- StoreProduct
- SubscribeRequest
- Subscriber
- SubscriberList
- SuppressionAuditResponse
- SuppressionAuditResponseEntriesInner
- SuppressionCheckResponse
- SuppressionEntry
- SuppressionListResponse
- SuppressionStatsResponse
- SuppressionStatsResponseByType
- SyncResponse
- TelemetrySummary
- TelemetrySummaryRates
- TelemetrySummaryTopDomainsInner
- TelemetrySummaryTopReasonsInner
- TelemetrySummaryTotals
- TestPolicyRequest
- TestPolicyRequestTestResult
- TrackEventRequest
- TrackEventResponse
- UnsubscribeSubscriber200Response
- UpdatePolicyRequest
- ValidateBatch200Response
- ValidateBatch200ResponseSummary
- ValidateBatchRequest
- ValidateRequest
- ValidationResponse
- ValidationResponsePolicyApplied
- ValidationResponseSuppressionMatch
- ValidationResult
- ValidationResultSuppression
- WebhookEvent

</details>

## Other SDKs

| Language | Package | Source |
|----------|---------|--------|
| [Python](https://mailodds.com/sdks) | [PyPI](https://pypi.org/project/mailodds/) | [GitHub](https://github.com/mailodds/python-sdk) |
| [TypeScript](https://mailodds.com/sdks) | [npm](https://www.npmjs.com/package/@mailodds/sdk) | [GitHub](https://github.com/mailodds/typescript-sdk) |
| [PHP](https://mailodds.com/sdks) | [Packagist](https://packagist.org/packages/mailodds/mailodds-php) | [GitHub](https://github.com/mailodds/php-sdk) |
| [Java](https://mailodds.com/sdks) | [GitHub](https://github.com/mailodds/java-sdk) | [GitHub](https://github.com/mailodds/java-sdk) |
| [Go](https://mailodds.com/sdks) | [pkg.go.dev](https://pkg.go.dev/github.com/mailodds/go-sdk) | [GitHub](https://github.com/mailodds/go-sdk) |
| [C# / .NET](https://mailodds.com/sdks) | [GitHub](https://github.com/mailodds/csharp-sdk) | [GitHub](https://github.com/mailodds/csharp-sdk) |
| [Ruby](https://mailodds.com/sdks) | [RubyGems](https://rubygems.org/gems/mailodds) | [GitHub](https://github.com/mailodds/ruby-sdk) |
| [Kotlin](https://mailodds.com/sdks) | [GitHub](https://github.com/mailodds/kotlin-sdk) | [GitHub](https://github.com/mailodds/kotlin-sdk) |
| [Rust](https://mailodds.com/sdks) | [crates.io](https://crates.io/crates/mailodds) | [GitHub](https://github.com/mailodds/rust-sdk) |
| [Swift](https://mailodds.com/sdks) | [GitHub](https://github.com/mailodds/swift-sdk) | [GitHub](https://github.com/mailodds/swift-sdk) |
| [Dart / Flutter](https://mailodds.com/sdks) | [pub.dev](https://pub.dev/packages/mailodds) | [GitHub](https://github.com/mailodds/dart-sdk) |

## Resources

- [API Documentation](https://mailodds.com/docs)
- [Dashboard](https://mailodds.com/dashboard)
- [Privacy Policy](https://mailodds.com/privacy)
- [Blog](https://mailodds.com/blog)
- [Contact Support](https://mailodds.com/contact)

## License

MIT
