# MailOdds.Api.BlacklistMonitoringApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddBlacklistMonitor**](BlacklistMonitoringApi.md#addblacklistmonitor) | **POST** /v1/blacklist-monitors | Add blacklist monitor |
| [**DeleteBlacklistMonitor**](BlacklistMonitoringApi.md#deleteblacklistmonitor) | **DELETE** /v1/blacklist-monitors/{monitor_id} | Delete a blacklist monitor |
| [**GetBlacklistHistory**](BlacklistMonitoringApi.md#getblacklisthistory) | **GET** /v1/blacklist-monitors/{monitor_id}/history | Get blacklist check history |
| [**ListBlacklistMonitors**](BlacklistMonitoringApi.md#listblacklistmonitors) | **GET** /v1/blacklist-monitors | List blacklist monitors |
| [**RunBlacklistCheck**](BlacklistMonitoringApi.md#runblacklistcheck) | **POST** /v1/blacklist-monitors/{monitor_id}/check | Run blacklist check |

<a id="addblacklistmonitor"></a>
# **AddBlacklistMonitor**
> AddBlacklistMonitor201Response AddBlacklistMonitor (AddBlacklistMonitorRequest addBlacklistMonitorRequest)

Add blacklist monitor

Add an IP address or domain to monitor against DNS blacklists. An initial check is run immediately.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addBlacklistMonitorRequest** | [**AddBlacklistMonitorRequest**](AddBlacklistMonitorRequest.md) |  |  |

### Return type

[**AddBlacklistMonitor201Response**](AddBlacklistMonitor201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Monitor created with initial check result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteblacklistmonitor"></a>
# **DeleteBlacklistMonitor**
> DeletePolicyRule200Response DeleteBlacklistMonitor (string monitorId)

Delete a blacklist monitor

Permanently remove a blacklist monitor and its check history.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **monitorId** | **string** | Monitor UUID |  |

### Return type

[**DeletePolicyRule200Response**](DeletePolicyRule200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Monitor deleted |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getblacklisthistory"></a>
# **GetBlacklistHistory**
> GetBlacklistHistory200Response GetBlacklistHistory (string monitorId, int page = null, int perPage = null)

Get blacklist check history

Get the listing and delisting timeline for a monitored IP or domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **monitorId** | **string** | Monitor UUID |  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**GetBlacklistHistory200Response**](GetBlacklistHistory200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Check history |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listblacklistmonitors"></a>
# **ListBlacklistMonitors**
> ListBlacklistMonitors200Response ListBlacklistMonitors ()

List blacklist monitors

List all blacklist monitors for the authenticated account.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListBlacklistMonitors200Response**](ListBlacklistMonitors200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of monitors |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="runblacklistcheck"></a>
# **RunBlacklistCheck**
> RunBlacklistCheck200Response RunBlacklistCheck (string monitorId)

Run blacklist check

Run an on-demand DNSBL check for a monitored IP or domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **monitorId** | **string** | Monitor UUID |  |

### Return type

[**RunBlacklistCheck200Response**](RunBlacklistCheck200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Check result |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

