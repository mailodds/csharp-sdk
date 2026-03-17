# MailOdds.Api.ReputationApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetReputation**](ReputationApi.md#getreputation) | **GET** /v1/reputation | Get account reputation |
| [**GetReputationTimeline**](ReputationApi.md#getreputationtimeline) | **GET** /v1/reputation/timeline | Get reputation timeline |

<a id="getreputation"></a>
# **GetReputation**
> GetReputation200Response GetReputation (string period = null)

Get account reputation

Get the aggregate reputation score and breakdown for the account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | Evaluation period | [optional] [default to 7d] |

### Return type

[**GetReputation200Response**](GetReputation200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account reputation |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreputationtimeline"></a>
# **GetReputationTimeline**
> GetReputationTimeline200Response GetReputationTimeline (string period = null)

Get reputation timeline

Get reputation metrics over time.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | Timeline period | [optional] [default to 30d] |

### Return type

[**GetReputationTimeline200Response**](GetReputationTimeline200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reputation timeline |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

