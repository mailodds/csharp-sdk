# MailOdds.Api.EngagementApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDisengagedContacts**](EngagementApi.md#getdisengagedcontacts) | **GET** /v1/engagement/disengaged | List disengaged contacts |
| [**GetEngagementScore**](EngagementApi.md#getengagementscore) | **GET** /v1/engagement/score/{email} | Get engagement score |
| [**GetEngagementSummary**](EngagementApi.md#getengagementsummary) | **GET** /v1/engagement/summary | Get engagement summary |
| [**SuppressDisengaged**](EngagementApi.md#suppressdisengaged) | **POST** /v1/engagement/suppress-disengaged | Suppress disengaged contacts |

<a id="getdisengagedcontacts"></a>
# **GetDisengagedContacts**
> GetDisengagedContacts200Response GetDisengagedContacts (int inactiveDays = null, int minSends = null, string domainId = null, int page = null, int perPage = null)

List disengaged contacts

List contacts that have not engaged within the specified period. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inactiveDays** | **int** | Days of inactivity | [optional] [default to 90] |
| **minSends** | **int** | Minimum emails sent to qualify | [optional] [default to 5] |
| **domainId** | **string** | Filter by sending domain ID | [optional]  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 100] |

### Return type

[**GetDisengagedContacts200Response**](GetDisengagedContacts200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of disengaged contacts |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getengagementscore"></a>
# **GetEngagementScore**
> GetEngagementScore200Response GetEngagementScore (string email)

Get engagement score

Get the engagement score for a specific email address. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email address |  |

### Return type

[**GetEngagementScore200Response**](GetEngagementScore200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Engagement score |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getengagementsummary"></a>
# **GetEngagementSummary**
> GetBounceStatsSummary200Response GetEngagementSummary (string domainId = null)

Get engagement summary

Get aggregate engagement metrics across all contacts. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Filter by sending domain ID | [optional]  |

### Return type

[**GetBounceStatsSummary200Response**](GetBounceStatsSummary200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Engagement summary |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="suppressdisengaged"></a>
# **SuppressDisengaged**
> SuppressDisengaged200Response SuppressDisengaged (SuppressDisengagedRequest suppressDisengagedRequest)

Suppress disengaged contacts

Add disengaged contacts to the suppression list. Supports dry_run mode. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **suppressDisengagedRequest** | [**SuppressDisengagedRequest**](SuppressDisengagedRequest.md) |  |  |

### Return type

[**SuppressDisengaged200Response**](SuppressDisengaged200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Suppression result or dry-run preview |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

