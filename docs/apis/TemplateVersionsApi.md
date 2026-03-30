# MailOdds.Api.TemplateVersionsApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CanaryTemplateVersion**](TemplateVersionsApi.md#canarytemplateversion) | **POST** /v1/campaigns/{campaign_id}/template-versions/{version_id}/canary | Start canary deployment |
| [**CreateTemplateVersion**](TemplateVersionsApi.md#createtemplateversion) | **POST** /v1/campaigns/{campaign_id}/template-versions | Create a template version |
| [**GetTemplateVersion**](TemplateVersionsApi.md#gettemplateversion) | **GET** /v1/campaigns/{campaign_id}/template-versions/{version_id} | Get a template version |
| [**ListTemplateVersions**](TemplateVersionsApi.md#listtemplateversions) | **GET** /v1/campaigns/{campaign_id}/template-versions | List template versions |
| [**PromoteTemplateVersion**](TemplateVersionsApi.md#promotetemplateversion) | **POST** /v1/campaigns/{campaign_id}/template-versions/{version_id}/promote | Promote a template version |
| [**RollbackTemplateVersion**](TemplateVersionsApi.md#rollbacktemplateversion) | **POST** /v1/campaigns/{campaign_id}/template-versions/rollback | Rollback template version |
| [**UpdateTemplateVersion**](TemplateVersionsApi.md#updatetemplateversion) | **PUT** /v1/campaigns/{campaign_id}/template-versions/{version_id} | Update a template version |

<a id="canarytemplateversion"></a>
# **CanaryTemplateVersion**
> void CanaryTemplateVersion (string campaignId, string versionId)

Start canary deployment

Start a canary deployment for a template version with a specified traffic percentage.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |
| **versionId** | **string** |  |  |

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
| **200** | Start canary deployment |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createtemplateversion"></a>
# **CreateTemplateVersion**
> void CreateTemplateVersion (string campaignId)

Create a template version

Create a new template version for a campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |

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
| **201** | Create a template version |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettemplateversion"></a>
# **GetTemplateVersion**
> void GetTemplateVersion (string campaignId, string versionId)

Get a template version

Retrieve a specific template version by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |
| **versionId** | **string** |  |  |

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
| **200** | Get a template version |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtemplateversions"></a>
# **ListTemplateVersions**
> void ListTemplateVersions (string campaignId)

List template versions

List all template versions for a campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |

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
| **200** | List template versions |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="promotetemplateversion"></a>
# **PromoteTemplateVersion**
> void PromoteTemplateVersion (string campaignId, string versionId)

Promote a template version

Promote a template version to active for the campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |
| **versionId** | **string** |  |  |

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
| **200** | Promote a template version |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rollbacktemplateversion"></a>
# **RollbackTemplateVersion**
> void RollbackTemplateVersion (string campaignId)

Rollback template version

Rollback the canary deployment and revert to the previous active version.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |

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
| **200** | Rollback template version |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetemplateversion"></a>
# **UpdateTemplateVersion**
> void UpdateTemplateVersion (string campaignId, string versionId)

Update a template version

Update an existing template version.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** |  |  |
| **versionId** | **string** |  |  |

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
| **200** | Update a template version |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

