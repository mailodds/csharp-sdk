# MailOdds.Api.ISPFBLGuidesApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIspFblGuide**](ISPFBLGuidesApi.md#getispfblguide) | **GET** /v1/isp-fbl/guides/{isp_id} | Get ISP FBL guide |
| [**ListIspFblGuides**](ISPFBLGuidesApi.md#listispfblguides) | **GET** /v1/isp-fbl/guides | List ISP FBL guides |

<a id="getispfblguide"></a>
# **GetIspFblGuide**
> void GetIspFblGuide (string ispId)

Get ISP FBL guide

Retrieve a specific ISP feedback loop setup guide.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ispId** | **string** |  |  |

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
| **200** | Get ISP FBL guide |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listispfblguides"></a>
# **ListIspFblGuides**
> void ListIspFblGuides ()

List ISP FBL guides

List all ISP feedback loop setup guides.


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
| **200** | List ISP FBL guides |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

