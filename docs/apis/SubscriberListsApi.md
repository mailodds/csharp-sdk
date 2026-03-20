# MailOdds.Api.SubscriberListsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfirmSubscription**](SubscriberListsApi.md#confirmsubscription) | **GET** /v1/confirm/{token} | Confirm subscription |
| [**CreateList**](SubscriberListsApi.md#createlist) | **POST** /v1/lists | Create a subscriber list |
| [**DeleteList**](SubscriberListsApi.md#deletelist) | **DELETE** /v1/lists/{list_id} | Delete a subscriber list |
| [**GetList**](SubscriberListsApi.md#getlist) | **GET** /v1/lists/{list_id} | Get a subscriber list |
| [**GetLists**](SubscriberListsApi.md#getlists) | **GET** /v1/lists | List subscriber lists |
| [**GetSubscribers**](SubscriberListsApi.md#getsubscribers) | **GET** /v1/lists/{list_id}/subscribers | List subscribers |
| [**Subscribe**](SubscriberListsApi.md#subscribe) | **POST** /v1/subscribe/{list_id} | Subscribe to a list |
| [**UnsubscribeSubscriber**](SubscriberListsApi.md#unsubscribesubscriber) | **DELETE** /v1/lists/{list_id}/subscribers/{subscriber_id} | Unsubscribe a subscriber |

<a id="confirmsubscription"></a>
# **ConfirmSubscription**
> ConfirmSubscription200Response ConfirmSubscription (string token)

Confirm subscription

Confirm a pending subscription via the token sent in the confirmation email. No authentication required. Redirects to the list's configured redirect URL if set, otherwise returns JSON. Tokens expire after 72 hours.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Confirmation token from email |  |

### Return type

[**ConfirmSubscription200Response**](ConfirmSubscription200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription confirmed |  -  |
| **302** | Redirect to configured confirmation URL |  -  |
| **400** | Bad request |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createlist"></a>
# **CreateList**
> CreateList201Response CreateList (CreateListRequest createListRequest)

Create a subscriber list

Create a new subscriber list. Use lists to organize subscribers and manage double opt-in confirmation flows.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createListRequest** | [**CreateListRequest**](CreateListRequest.md) |  |  |

### Return type

[**CreateList201Response**](CreateList201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | List created |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletelist"></a>
# **DeleteList**
> DeletePolicyRule200Response DeleteList (string listId)

Delete a subscriber list

Soft-delete a subscriber list. Existing subscribers are retained but the list is no longer usable.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | List UUID |  |

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
| **200** | List deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlist"></a>
# **GetList**
> CreateList201Response GetList (string listId)

Get a subscriber list

Get details of a specific subscriber list including subscriber and confirmed counts.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | List UUID |  |

### Return type

[**CreateList201Response**](CreateList201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscriber list details |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlists"></a>
# **GetLists**
> GetLists200Response GetLists (int page = null, int perPage = null)

List subscriber lists

List all subscriber lists for the authenticated account with pagination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Page number | [optional] [default to 1] |
| **perPage** | **int** | Items per page | [optional] [default to 25] |

### Return type

[**GetLists200Response**](GetLists200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of subscriber lists |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubscribers"></a>
# **GetSubscribers**
> GetSubscribers200Response GetSubscribers (string listId, int page = null, int perPage = null, string status = null)

List subscribers

List paginated subscribers for a specific list. Optionally filter by status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | List UUID |  |
| **page** | **int** | Page number | [optional] [default to 1] |
| **perPage** | **int** | Items per page | [optional] [default to 50] |
| **status** | **string** | Filter by subscriber status | [optional]  |

### Return type

[**GetSubscribers200Response**](GetSubscribers200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of subscribers |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="subscribe"></a>
# **Subscribe**
> UnsubscribeSubscriber200Response Subscribe (string listId, SubscribeRequest subscribeRequest)

Subscribe to a list

Add a subscriber to a list and initiate the double opt-in confirmation flow. The subscriber receives a confirmation email and must click the link to confirm. Rate limited to 10 requests/min per IP and 1000/hour per account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | List UUID |  |
| **subscribeRequest** | [**SubscribeRequest**](SubscribeRequest.md) |  |  |

### Return type

[**UnsubscribeSubscriber200Response**](UnsubscribeSubscriber200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Subscriber created (pending confirmation) |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **422** | Invalid email address |  -  |
| **429** | Rate limit exceeded |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="unsubscribesubscriber"></a>
# **UnsubscribeSubscriber**
> UnsubscribeSubscriber200Response UnsubscribeSubscriber (string listId, string subscriberId)

Unsubscribe a subscriber

Set a subscriber's status to unsubscribed. The consent record is retained for compliance.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** | List UUID |  |
| **subscriberId** | **string** | Subscriber UUID |  |

### Return type

[**UnsubscribeSubscriber200Response**](UnsubscribeSubscriber200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscriber unsubscribed |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

