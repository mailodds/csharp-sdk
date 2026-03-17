# MailOdds.Api.PixelSettingsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPixelSettings**](PixelSettingsApi.md#getpixelsettings) | **GET** /v1/pixel-settings | Get pixel settings |
| [**UpdatePixelSettings**](PixelSettingsApi.md#updatepixelsettings) | **PATCH** /v1/pixel-settings | Update pixel settings |

<a id="getpixelsettings"></a>
# **GetPixelSettings**
> GetPixelSettings200Response GetPixelSettings ()

Get pixel settings

Get the web pixel tracking configuration.


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetPixelSettings200Response**](GetPixelSettings200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pixel settings |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepixelsettings"></a>
# **UpdatePixelSettings**
> GetPixelSettings200Response UpdatePixelSettings (UpdatePixelSettingsRequest updatePixelSettingsRequest)

Update pixel settings

Update the web pixel subscribe list configuration.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updatePixelSettingsRequest** | [**UpdatePixelSettingsRequest**](UpdatePixelSettingsRequest.md) |  |  |

### Return type

[**GetPixelSettings200Response**](GetPixelSettings200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pixel settings updated |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

