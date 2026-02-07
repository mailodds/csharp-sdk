# MailOdds.Api.SystemApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTelemetrySummary**](SystemApi.md#gettelemetrysummary) | **GET** /v1/telemetry/summary | Get validation telemetry |
| [**HealthCheck**](SystemApi.md#healthcheck) | **GET** /health | Health check |

<a id="gettelemetrysummary"></a>
# **GetTelemetrySummary**
> TelemetrySummary GetTelemetrySummary (string window = null)

Get validation telemetry

Get validation metrics for your account. Useful for building dashboards and monitoring. Supports ETag caching.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **window** | **string** | Time window for metrics | [optional] [default to 24h] |

### Return type

[**TelemetrySummary**](TelemetrySummary.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Telemetry summary |  * ETag - Hash of response for caching <br>  * Cache-Control - Caching directive <br>  |
| **304** | Not Modified - use cached response |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="healthcheck"></a>
# **HealthCheck**
> HealthCheck200Response HealthCheck ()

Health check

Check API health status. No authentication required.


### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheck200Response**](HealthCheck200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | API is healthy |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

