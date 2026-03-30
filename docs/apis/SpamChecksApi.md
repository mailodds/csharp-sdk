# MailOdds.Api.SpamChecksApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteSpamCheck**](SpamChecksApi.md#deletespamcheck) | **DELETE** /v1/spam-checks/{check_id} | Delete spam check |
| [**GetSpamCheck**](SpamChecksApi.md#getspamcheck) | **GET** /v1/spam-checks/{check_id} | Get spam check |
| [**ListSpamChecks**](SpamChecksApi.md#listspamchecks) | **GET** /v1/spam-checks | List spam checks |
| [**RunSpamCheck**](SpamChecksApi.md#runspamcheck) | **POST** /v1/spam-checks | Run spam check |

<a id="deletespamcheck"></a>
# **DeleteSpamCheck**
> DeletePolicyRule200Response DeleteSpamCheck (string checkId)

Delete spam check

Delete a spam check result.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkId** | **string** |  |  |

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
| **200** | Spam check deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspamcheck"></a>
# **GetSpamCheck**
> RunSpamCheck201Response GetSpamCheck (string checkId)

Get spam check

Get the detailed result of a specific spam check.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkId** | **string** |  |  |

### Return type

[**RunSpamCheck201Response**](RunSpamCheck201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Spam check details |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listspamchecks"></a>
# **ListSpamChecks**
> ListSpamChecks200Response ListSpamChecks (int page = null, int perPage = null)

List spam checks

List past spam check results with pagination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**ListSpamChecks200Response**](ListSpamChecks200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of spam checks |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="runspamcheck"></a>
# **RunSpamCheck**
> RunSpamCheck201Response RunSpamCheck (RunSpamCheckRequest runSpamCheckRequest)

Run spam check

Run backend spam checks on email sending parameters. Checks domain reputation, link safety, and subject line quality.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runSpamCheckRequest** | [**RunSpamCheckRequest**](RunSpamCheckRequest.md) |  |  |

### Return type

[**RunSpamCheck201Response**](RunSpamCheck201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Spam check result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

