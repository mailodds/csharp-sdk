# MailOdds.Api.ContactListsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppendToContactList**](ContactListsApi.md#appendtocontactlist) | **POST** /v1/contact-lists/{list_id}/append | Append to contact list |
| [**CreateContactList**](ContactListsApi.md#createcontactlist) | **POST** /v1/contact-lists | Create contact list |
| [**GetInactiveContactsReport**](ContactListsApi.md#getinactivecontactsreport) | **GET** /v1/contacts/inactive-report | Get inactive contacts report |
| [**ListContactLists**](ContactListsApi.md#listcontactlists) | **GET** /v1/contact-lists | List contact lists |
| [**QueryContactList**](ContactListsApi.md#querycontactlist) | **POST** /v1/contact-lists/{list_id}/query | Query contact list |

<a id="appendtocontactlist"></a>
# **AppendToContactList**
> AppendToContactList200Response AppendToContactList (string listId, AppendToContactListRequest appendToContactListRequest)

Append to contact list

Append validated emails from additional jobs to an existing contact list. Duplicates are automatically skipped.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | Contact list UUID |  |
| **appendToContactListRequest** | [**AppendToContactListRequest**](AppendToContactListRequest.md) |  |  |

### Return type

[**AppendToContactList200Response**](AppendToContactList200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Append result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcontactlist"></a>
# **CreateContactList**
> CreateContactList201Response CreateContactList (CreateContactListRequest createContactListRequest)

Create contact list

Create a new contact list from one or more completed validation jobs. Only accepted (valid) emails are included.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createContactListRequest** | [**CreateContactListRequest**](CreateContactListRequest.md) |  |  |

### Return type

[**CreateContactList201Response**](CreateContactList201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Contact list created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getinactivecontactsreport"></a>
# **GetInactiveContactsReport**
> GetInactiveContactsReport200Response GetInactiveContactsReport (int days = null)

Get inactive contacts report

Get a report of contacts across all lists with no engagement activity (opens, clicks) in the specified period.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **days** | **int** | Inactivity threshold in days | [optional] [default to 90] |

### Return type

[**GetInactiveContactsReport200Response**](GetInactiveContactsReport200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inactive contacts report |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcontactlists"></a>
# **ListContactLists**
> ListContactLists200Response ListContactLists (int page = null, int perPage = null)

List contact lists

List contact lists for the authenticated account. Contact lists are built from validated email jobs.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**ListContactLists200Response**](ListContactLists200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of contact lists |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="querycontactlist"></a>
# **QueryContactList**
> QueryContactList200Response QueryContactList (string listId, QueryContactListRequest queryContactListRequest)

Query contact list

Query contact list entries with structured filters. Supports filtering by validation status, domain, and other attributes.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | Contact list UUID |  |
| **queryContactListRequest** | [**QueryContactListRequest**](QueryContactListRequest.md) |  |  |

### Return type

[**QueryContactList200Response**](QueryContactList200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query results |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

