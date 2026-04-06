# MailOdds.Api.CampaignsApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelCampaign**](CampaignsApi.md#cancelcampaign) | **POST** /v1/campaigns/{campaign_id}/cancel | Cancel a campaign |
| [**CreateCampaign**](CampaignsApi.md#createcampaign) | **POST** /v1/campaigns | Create a campaign |
| [**CreateCampaignVariant**](CampaignsApi.md#createcampaignvariant) | **POST** /v1/campaigns/{campaign_id}/variants | Create A/B variant |
| [**DeleteCampaign**](CampaignsApi.md#deletecampaign) | **DELETE** /v1/campaigns/{campaign_id} | Delete a campaign |
| [**GetCampaign**](CampaignsApi.md#getcampaign) | **GET** /v1/campaigns/{campaign_id} | Get campaign with stats |
| [**ListCampaigns**](CampaignsApi.md#listcampaigns) | **GET** /v1/campaigns | List campaigns |
| [**ScheduleCampaign**](CampaignsApi.md#schedulecampaign) | **POST** /v1/campaigns/{campaign_id}/schedule | Schedule a campaign |
| [**SendCampaign**](CampaignsApi.md#sendcampaign) | **POST** /v1/campaigns/{campaign_id}/send | Send a campaign |

<a id="cancelcampaign"></a>
# **CancelCampaign**
> CampaignResponse CancelCampaign (string campaignId)

Cancel a campaign

Cancel a scheduled or in-progress campaign. Messages already delivered are not recalled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**CampaignResponse**](CampaignResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Campaign cancelled |  -  |
| **400** | Bad request |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcampaign"></a>
# **CreateCampaign**
> CampaignResponse CreateCampaign (CreateCampaignRequest createCampaignRequest)

Create a campaign

Create a new email campaign. Campaigns target a subscriber list and support A/B variant testing.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCampaignRequest** | [**CreateCampaignRequest**](CreateCampaignRequest.md) |  |  |

### Return type

[**CampaignResponse**](CampaignResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Campaign created |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcampaignvariant"></a>
# **CreateCampaignVariant**
> CreateCampaignVariant201Response CreateCampaignVariant (string campaignId, CreateVariantRequest createVariantRequest)

Create A/B variant

Add an A/B test variant to a campaign. Each variant has its own subject, body, and traffic weight. The campaign must be in draft status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |
| **createVariantRequest** | [**CreateVariantRequest**](CreateVariantRequest.md) |  |  |

### Return type

[**CreateCampaignVariant201Response**](CreateCampaignVariant201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Variant created |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecampaign"></a>
# **DeleteCampaign**
> DeletePolicyRule200Response DeleteCampaign (string campaignId)

Delete a campaign

Permanently delete a campaign. Only campaigns in draft, sent, failed, or cancelled status can be deleted.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

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
| **200** | Campaign deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaign"></a>
# **GetCampaign**
> CampaignResponse GetCampaign (string campaignId)

Get campaign with stats

Get a campaign by ID including delivery statistics and engagement metrics.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**CampaignResponse**](CampaignResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Campaign details with stats |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcampaigns"></a>
# **ListCampaigns**
> ListCampaigns200Response ListCampaigns (int page = null, int perPage = null, string status = null)

List campaigns

List all campaigns for the authenticated account with pagination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Page number | [optional] [default to 1] |
| **perPage** | **int** | Items per page | [optional] [default to 25] |
| **status** | **string** | Filter by campaign status | [optional]  |

### Return type

[**ListCampaigns200Response**](ListCampaigns200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of campaigns |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="schedulecampaign"></a>
# **ScheduleCampaign**
> CampaignResponse ScheduleCampaign (string campaignId, ScheduleCampaignRequest scheduleCampaignRequest)

Schedule a campaign

Schedule a campaign for future delivery. Provide a send_at timestamp in ISO 8601 format.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |
| **scheduleCampaignRequest** | [**ScheduleCampaignRequest**](ScheduleCampaignRequest.md) |  |  |

### Return type

[**CampaignResponse**](CampaignResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Campaign scheduled |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendcampaign"></a>
# **SendCampaign**
> CampaignResponse SendCampaign (string campaignId)

Send a campaign

Begin sending a campaign immediately. The campaign must be in draft status with at least one variant and a target list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Campaign UUID |  |

### Return type

[**CampaignResponse**](CampaignResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Campaign accepted for sending |  -  |
| **400** | Bad request |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

