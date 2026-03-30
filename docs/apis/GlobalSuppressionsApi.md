# MailOdds.Api.GlobalSuppressionsApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGlobalSuppressionOverride**](GlobalSuppressionsApi.md#addglobalsuppressionoverride) | **POST** /v1/global-suppressions/overrides | Add global suppression override |
| [**CheckGlobalSuppression**](GlobalSuppressionsApi.md#checkglobalsuppression) | **GET** /v1/global-suppressions/check | Check global suppression |
| [**RemoveGlobalSuppressionOverride**](GlobalSuppressionsApi.md#removeglobalsuppressionoverride) | **DELETE** /v1/global-suppressions/overrides | Remove global suppression override |

<a id="addglobalsuppressionoverride"></a>
# **AddGlobalSuppressionOverride**
> void AddGlobalSuppressionOverride ()

Add global suppression override

Add an override to allow sending to a globally suppressed email address.


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
| **201** | Add global suppression override |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="checkglobalsuppression"></a>
# **CheckGlobalSuppression**
> void CheckGlobalSuppression ()

Check global suppression

Check if an email address is globally suppressed.


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
| **200** | Check global suppression |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removeglobalsuppressionoverride"></a>
# **RemoveGlobalSuppressionOverride**
> void RemoveGlobalSuppressionOverride ()

Remove global suppression override

Remove an override for a globally suppressed email address.


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
| **200** | Remove global suppression override |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

