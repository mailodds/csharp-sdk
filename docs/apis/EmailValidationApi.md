# MailOdds.Api.EmailValidationApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ValidateEmail**](EmailValidationApi.md#validateemail) | **POST** /v1/validate | Validate single email |

<a id="validateemail"></a>
# **ValidateEmail**
> ValidationResponse ValidateEmail (ValidateRequest validateRequest)

Validate single email

Validate a single email address. Returns detailed validation results including status, sub-status, and recommended action.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateRequest** | [**ValidateRequest**](ValidateRequest.md) |  |  |

### Return type

[**ValidationResponse**](ValidationResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Validation result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

