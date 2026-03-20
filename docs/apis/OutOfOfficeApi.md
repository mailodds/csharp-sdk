# MailOdds.Api.OutOfOfficeApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchCheckOoo**](OutOfOfficeApi.md#batchcheckooo) | **POST** /v1/out-of-office/batch-check | Batch check OOO status |
| [**DeleteOooContact**](OutOfOfficeApi.md#deleteooocontact) | **DELETE** /v1/out-of-office/{email} | Delete OOO contact |
| [**GetOooStatus**](OutOfOfficeApi.md#getooostatus) | **GET** /v1/out-of-office/{email}/status | Get OOO status for email |
| [**ListOooContacts**](OutOfOfficeApi.md#listooocontacts) | **GET** /v1/out-of-office | List out-of-office contacts |
| [**UpdateOooContact**](OutOfOfficeApi.md#updateooocontact) | **PATCH** /v1/out-of-office/{email} | Update OOO contact |

<a id="batchcheckooo"></a>
# **BatchCheckOoo**
> BatchCheckOoo200Response BatchCheckOoo (BatchCheckOooRequest batchCheckOooRequest)

Batch check OOO status

Check OOO status for up to 1000 email addresses at once. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchCheckOooRequest** | [**BatchCheckOooRequest**](BatchCheckOooRequest.md) |  |  |

### Return type

[**BatchCheckOoo200Response**](BatchCheckOoo200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch OOO check results |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteooocontact"></a>
# **DeleteOooContact**
> DeleteOooContact200Response DeleteOooContact (string email)

Delete OOO contact

Clear out-of-office status for an email address. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** |  |  |

### Return type

[**DeleteOooContact200Response**](DeleteOooContact200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OOO status cleared |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getooostatus"></a>
# **GetOooStatus**
> GetOooStatus200Response GetOooStatus (string email)

Get OOO status for email

Check if a specific email address is currently out-of-office. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** |  |  |

### Return type

[**GetOooStatus200Response**](GetOooStatus200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OOO status |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listooocontacts"></a>
# **ListOooContacts**
> ListOooContacts200Response ListOooContacts (bool activeOnly = null, int page = null, int perPage = null)

List out-of-office contacts

List contacts detected as out-of-office. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activeOnly** | **bool** | Only return currently active OOO contacts | [optional] [default to true] |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 100] |

### Return type

[**ListOooContacts200Response**](ListOooContacts200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of OOO contacts |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateooocontact"></a>
# **UpdateOooContact**
> Object UpdateOooContact (string email, UpdateOooContactRequest updateOooContactRequest)

Update OOO contact

Manually set or clear out-of-office status for an email. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** |  |  |
| **updateOooContactRequest** | [**UpdateOooContactRequest**](UpdateOooContactRequest.md) |  |  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OOO contact updated |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

