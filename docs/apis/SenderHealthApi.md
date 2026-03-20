# MailOdds.Api.SenderHealthApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSenderHealth**](SenderHealthApi.md#getsenderhealth) | **GET** /v1/sender-health | Get sender health score |
| [**GetSenderHealthTrend**](SenderHealthApi.md#getsenderhealthtrend) | **GET** /v1/sender-health/trend | Get sender health trend |

<a id="getsenderhealth"></a>
# **GetSenderHealth**
> GetSenderHealth200Response GetSenderHealth (string period = null)

Get sender health score

Get an aggregate sender health score (0-100) across all sending domains. Factors in delivery rate, bounce rate, complaint rate, and authentication status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | Time period for health calculation | [optional] [default to 30d] |

### Return type

[**GetSenderHealth200Response**](GetSenderHealth200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender health score |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsenderhealthtrend"></a>
# **GetSenderHealthTrend**
> GetSenderHealthTrend200Response GetSenderHealthTrend (string period = null)

Get sender health trend

Get historical sender health scores over time for trend analysis. Returns daily data points for the requested period.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | Time period for trend data | [optional] [default to 30d] |

### Return type

[**GetSenderHealthTrend200Response**](GetSenderHealthTrend200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender health trend |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

