# MailOdds.Api.CampaignAnalyticsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCampaignABResults**](CampaignAnalyticsApi.md#getcampaignabresults) | **GET** /v1/campaigns/{campaign_id}/ab-results | Get A/B test results |
| [**GetCampaignAttribution**](CampaignAnalyticsApi.md#getcampaignattribution) | **GET** /v1/campaigns/{campaign_id}/conversions/attribution | Get campaign attribution |
| [**GetCampaignDeliveryConfidence**](CampaignAnalyticsApi.md#getcampaigndeliveryconfidence) | **GET** /v1/campaigns/{campaign_id}/delivery-confidence | Get pre-send delivery confidence |
| [**GetCampaignFunnel**](CampaignAnalyticsApi.md#getcampaignfunnel) | **GET** /v1/campaigns/{campaign_id}/funnel | Get campaign funnel |
| [**GetCampaignProviderIntelligence**](CampaignAnalyticsApi.md#getcampaignproviderintelligence) | **GET** /v1/campaigns/{campaign_id}/provider-intelligence | Get provider intelligence |

<a id="getcampaignabresults"></a>
# **GetCampaignABResults**
> GetCampaignABResults200Response GetCampaignABResults (string campaignId)

Get A/B test results

Get per-variant performance metrics for an A/B test campaign including open rate, click rate, and statistical confidence.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**GetCampaignABResults200Response**](GetCampaignABResults200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A/B test results |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaignattribution"></a>
# **GetCampaignAttribution**
> GetCampaignAttribution200Response GetCampaignAttribution (string campaignId)

Get campaign attribution

Get first-touch and last-touch attribution comparison for campaign conversions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**GetCampaignAttribution200Response**](GetCampaignAttribution200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attribution data |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaigndeliveryconfidence"></a>
# **GetCampaignDeliveryConfidence**
> GetCampaignDeliveryConfidence200Response GetCampaignDeliveryConfidence (string campaignId)

Get pre-send delivery confidence

Get a predicted delivery confidence score before sending a campaign. Evaluates list quality, sender reputation, and domain authentication.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**GetCampaignDeliveryConfidence200Response**](GetCampaignDeliveryConfidence200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delivery confidence score |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaignfunnel"></a>
# **GetCampaignFunnel**
> GetCampaignFunnel200Response GetCampaignFunnel (string campaignId)

Get campaign funnel

Get the full delivery and engagement funnel for a campaign showing progression from sent through delivered, opened, and clicked.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**GetCampaignFunnel200Response**](GetCampaignFunnel200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Campaign funnel analytics |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaignproviderintelligence"></a>
# **GetCampaignProviderIntelligence**
> GetCampaignProviderIntelligence200Response GetCampaignProviderIntelligence (string campaignId)

Get provider intelligence

Get per-provider delivery and engagement breakdown for a campaign (e.g. Gmail, Outlook, Yahoo).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**GetCampaignProviderIntelligence200Response**](GetCampaignProviderIntelligence200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Provider intelligence data |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

