# MailOdds.Api.ContentClassificationApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClassifyContent**](ContentClassificationApi.md#classifycontent) | **POST** /v1/content-check | Classify email content |

<a id="classifycontent"></a>
# **ClassifyContent**
> ClassifyContent200Response ClassifyContent (ClassifyContentRequest classifyContentRequest)

Classify email content

Run LLM-powered content analysis on email content. Detects spam signals, compliance issues, and content quality. Provide either subject+html_body or raw content text.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **classifyContentRequest** | [**ClassifyContentRequest**](ClassifyContentRequest.md) |  |  |

### Return type

[**ClassifyContent200Response**](ClassifyContent200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Content classification result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

