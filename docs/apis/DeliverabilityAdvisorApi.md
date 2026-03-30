# MailOdds.Api.DeliverabilityAdvisorApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DismissDeliverabilityRecommendation**](DeliverabilityAdvisorApi.md#dismissdeliverabilityrecommendation) | **POST** /v1/deliverability/recommendations/{recommendation_id}/dismiss | Dismiss a deliverability recommendation |
| [**GetDeliverabilityRecommendations**](DeliverabilityAdvisorApi.md#getdeliverabilityrecommendations) | **GET** /v1/deliverability/recommendations | Get deliverability recommendations |

<a id="dismissdeliverabilityrecommendation"></a>
# **DismissDeliverabilityRecommendation**
> void DismissDeliverabilityRecommendation (string recommendationId)

Dismiss a deliverability recommendation

Dismiss a deliverability recommendation so it no longer appears.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recommendationId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dismiss a deliverability recommendation |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdeliverabilityrecommendations"></a>
# **GetDeliverabilityRecommendations**
> void GetDeliverabilityRecommendations ()

Get deliverability recommendations

Retrieve actionable deliverability recommendations for the account.


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get deliverability recommendations |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

