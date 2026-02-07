# MailOdds.Api.SuppressionListsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddSuppression**](SuppressionListsApi.md#addsuppression) | **POST** /v1/suppression | Add suppression entries |
| [**CheckSuppression**](SuppressionListsApi.md#checksuppression) | **POST** /v1/suppression/check | Check suppression status |
| [**GetSuppressionStats**](SuppressionListsApi.md#getsuppressionstats) | **GET** /v1/suppression/stats | Get suppression statistics |
| [**ListSuppression**](SuppressionListsApi.md#listsuppression) | **GET** /v1/suppression | List suppression entries |
| [**RemoveSuppression**](SuppressionListsApi.md#removesuppression) | **DELETE** /v1/suppression | Remove suppression entries |

<a id="addsuppression"></a>
# **AddSuppression**
> AddSuppressionResponse AddSuppression (AddSuppressionRequest addSuppressionRequest)

Add suppression entries

Add emails or domains to the suppression list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addSuppressionRequest** | [**AddSuppressionRequest**](AddSuppressionRequest.md) |  |  |

### Return type

[**AddSuppressionResponse**](AddSuppressionResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entries added |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="checksuppression"></a>
# **CheckSuppression**
> SuppressionCheckResponse CheckSuppression (CheckSuppressionRequest checkSuppressionRequest)

Check suppression status

Check if an email is suppressed.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkSuppressionRequest** | [**CheckSuppressionRequest**](CheckSuppressionRequest.md) |  |  |

### Return type

[**SuppressionCheckResponse**](SuppressionCheckResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Suppression check result |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsuppressionstats"></a>
# **GetSuppressionStats**
> SuppressionStatsResponse GetSuppressionStats ()

Get suppression statistics

Get statistics about the suppression list.


### Parameters
This endpoint does not need any parameter.
### Return type

[**SuppressionStatsResponse**](SuppressionStatsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Suppression statistics |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsuppression"></a>
# **ListSuppression**
> SuppressionListResponse ListSuppression (int page = null, int perPage = null, string type = null, string search = null)

List suppression entries

List all suppression entries for the account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 50] |
| **type** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**SuppressionListResponse**](SuppressionListResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Suppression list |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removesuppression"></a>
# **RemoveSuppression**
> RemoveSuppression200Response RemoveSuppression (RemoveSuppressionRequest removeSuppressionRequest)

Remove suppression entries

Remove emails or domains from the suppression list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeSuppressionRequest** | [**RemoveSuppressionRequest**](RemoveSuppressionRequest.md) |  |  |

### Return type

[**RemoveSuppression200Response**](RemoveSuppression200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entries removed |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

