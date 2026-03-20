# MailOdds.Api.ContactListsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddContact**](ContactListsApi.md#addcontact) | **POST** /v1/contact-lists/{list_id}/contacts | Add contact to list |
| [**AppendToContactList**](ContactListsApi.md#appendtocontactlist) | **POST** /v1/contact-lists/{list_id}/append | Append to contact list |
| [**CreateContactList**](ContactListsApi.md#createcontactlist) | **POST** /v1/contact-lists | Create contact list |
| [**DeleteContact**](ContactListsApi.md#deletecontact) | **DELETE** /v1/contact-lists/{list_id}/contacts/{contact_id} | Delete contact |
| [**DeleteContactList**](ContactListsApi.md#deletecontactlist) | **DELETE** /v1/contact-lists/{list_id} | Delete a contact list |
| [**ExportContactList**](ContactListsApi.md#exportcontactlist) | **GET** /v1/contact-lists/{list_id}/export | Export contact list |
| [**GetInactiveContactsReport**](ContactListsApi.md#getinactivecontactsreport) | **GET** /v1/contacts/inactive-report | Get inactive contacts report |
| [**ImportContactList**](ContactListsApi.md#importcontactlist) | **POST** /v1/contact-lists/{list_id}/import | Import contacts from CSV |
| [**ListContactLists**](ContactListsApi.md#listcontactlists) | **GET** /v1/contact-lists | List contact lists |
| [**QueryContactList**](ContactListsApi.md#querycontactlist) | **POST** /v1/contact-lists/{list_id}/query | Query contact list |
| [**UpdateContact**](ContactListsApi.md#updatecontact) | **PATCH** /v1/contact-lists/{list_id}/contacts/{contact_id} | Update contact |

<a id="addcontact"></a>
# **AddContact**
> AddContact201Response AddContact (string listId, AddContactRequest addContactRequest)

Add contact to list

Add a single contact to a contact list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **addContactRequest** | [**AddContactRequest**](AddContactRequest.md) |  |  |

### Return type

[**AddContact201Response**](AddContact201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Contact added |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appendtocontactlist"></a>
# **AppendToContactList**
> AppendToContactList200Response AppendToContactList (string listId, AppendToContactListRequest appendToContactListRequest)

Append to contact list

Append validated emails from additional jobs to an existing contact list. Duplicates are automatically skipped.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
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
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

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
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecontact"></a>
# **DeleteContact**
> DeletePolicyRule200Response DeleteContact (string listId, string contactId)

Delete contact

Remove a single contact from a contact list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contactId** | **string** |  |  |

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
| **200** | Contact deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecontactlist"></a>
# **DeleteContactList**
> DeletePolicyRule200Response DeleteContactList (string listId)

Delete a contact list

Permanently delete a contact list and all its entries.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |

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
| **200** | Contact list deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcontactlist"></a>
# **ExportContactList**
> string ExportContactList (string listId)

Export contact list

Export a contact list as CSV.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |

### Return type

**string**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CSV export |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

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
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importcontactlist"></a>
# **ImportContactList**
> ImportContactList200Response ImportContactList (string listId, System.IO.Stream file, string columnMapping = null, string consentSource = null, string tags = null)

Import contacts from CSV

Import contacts into a list from a CSV file (max 10MB).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | CSV file (max 10MB) |  |
| **columnMapping** | **string** | JSON mapping of CSV columns to contact fields | [optional]  |
| **consentSource** | **string** | Source of consent for imported contacts | [optional]  |
| **tags** | **string** | JSON array of tags to apply | [optional]  |

### Return type

[**ImportContactList200Response**](ImportContactList200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Import results |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

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
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="querycontactlist"></a>
# **QueryContactList**
> QueryContactList200Response QueryContactList (string listId, QueryContactListRequest queryContactListRequest)

Query contact list

Query contact list entries with structured filters. Supports filtering by validation status, domain, and other attributes.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
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
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> AddContact201Response UpdateContact (string listId, string contactId, UpdateContactRequest updateContactRequest)

Update contact

Update a single contact in a contact list.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **updateContactRequest** | [**UpdateContactRequest**](UpdateContactRequest.md) |  |  |

### Return type

[**AddContact201Response**](AddContact201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact updated |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

