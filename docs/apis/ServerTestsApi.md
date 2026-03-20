# MailOdds.Api.ServerTestsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetServerTest**](ServerTestsApi.md#getservertest) | **GET** /v1/server-tests/{test_id} | Get server test |
| [**ListServerTests**](ServerTestsApi.md#listservertests) | **GET** /v1/server-tests | List server tests |
| [**RunServerTest**](ServerTestsApi.md#runservertest) | **POST** /v1/server-tests | Run server test |

<a id="getservertest"></a>
# **GetServerTest**
> RunServerTest201Response GetServerTest (string testId)

Get server test

Get the detailed results of a specific server test.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testId** | **string** |  |  |

### Return type

[**RunServerTest201Response**](RunServerTest201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Server test details |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listservertests"></a>
# **ListServerTests**
> ListServerTests200Response ListServerTests (int page = null, int perPage = null)

List server tests

List past server test results with pagination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**ListServerTests200Response**](ListServerTests200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of server tests |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="runservertest"></a>
# **RunServerTest**
> RunServerTest201Response RunServerTest (RunServerTestRequest runServerTestRequest)

Run server test

Run an SMTP handshake test and MX configuration audit for a domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runServerTestRequest** | [**RunServerTestRequest**](RunServerTestRequest.md) |  |  |

### Return type

[**RunServerTest201Response**](RunServerTest201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Test result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

