# MailOdds.Api.StoreConnectionsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateStore**](StoreConnectionsApi.md#createstore) | **POST** /v1/stores | Create a store connection |
| [**DisconnectStore**](StoreConnectionsApi.md#disconnectstore) | **DELETE** /v1/stores/{store_id} | Disconnect a store |
| [**GetStore**](StoreConnectionsApi.md#getstore) | **GET** /v1/stores/{store_id} | Get a store connection |
| [**GetSyncJobErrors**](StoreConnectionsApi.md#getsyncjoberrors) | **GET** /v1/stores/{store_id}/sync-jobs/{job_id}/errors | Get sync job errors |
| [**ListStores**](StoreConnectionsApi.md#liststores) | **GET** /v1/stores | List store connections |
| [**ListSyncJobs**](StoreConnectionsApi.md#listsyncjobs) | **GET** /v1/stores/{store_id}/sync-jobs | List sync jobs |
| [**TriggerSync**](StoreConnectionsApi.md#triggersync) | **POST** /v1/stores/{store_id}/sync | Trigger product sync |
| [**UpdateStore**](StoreConnectionsApi.md#updatestore) | **PUT** /v1/stores/{store_id} | Update a store connection |

<a id="createstore"></a>
# **CreateStore**
> CreateStore201Response CreateStore (CreateStoreRequest createStoreRequest)

Create a store connection

Connect an e-commerce store (WooCommerce, PrestaShop, Shopify, or product feed). After creation, trigger a sync to import products.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createStoreRequest** | [**CreateStoreRequest**](CreateStoreRequest.md) |  |  |

### Return type

[**CreateStore201Response**](CreateStore201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Store connection created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectstore"></a>
# **DisconnectStore**
> DisconnectStore200Response DisconnectStore (string storeId)

Disconnect a store

Disconnect a store and deactivate its products. Products are retained but marked inactive.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store connection UUID |  |

### Return type

[**DisconnectStore200Response**](DisconnectStore200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Store disconnected |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstore"></a>
# **GetStore**
> CreateStore201Response GetStore (string storeId)

Get a store connection

Get details of a specific store connection including sync status and product count.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store connection UUID |  |

### Return type

[**CreateStore201Response**](CreateStore201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Store connection details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsyncjoberrors"></a>
# **GetSyncJobErrors**
> GetSyncJobErrors200Response GetSyncJobErrors (string storeId, string jobId, int page = null, int perPage = null)

Get sync job errors

Get error details for a sync job.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store ID |  |
| **jobId** | **string** | Sync job ID |  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 50] |

### Return type

[**GetSyncJobErrors200Response**](GetSyncJobErrors200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sync job errors |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="liststores"></a>
# **ListStores**
> ListStores200Response ListStores (string status = null)

List store connections

List all store connections for the authenticated account. Optionally filter by status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Filter by connection status | [optional]  |

### Return type

[**ListStores200Response**](ListStores200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of store connections |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsyncjobs"></a>
# **ListSyncJobs**
> ListSyncJobs200Response ListSyncJobs (string storeId, int page = null, int perPage = null)

List sync jobs

List sync job history for a store.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store ID |  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**ListSyncJobs200Response**](ListSyncJobs200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of sync jobs |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="triggersync"></a>
# **TriggerSync**
> SyncResponse TriggerSync (string storeId, string idempotencyKey = null)

Trigger product sync

Trigger a manual product sync for a store. Supports idempotency via the Idempotency-Key header (5 minute TTL).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store connection UUID |  |
| **idempotencyKey** | **string** | Idempotency key to prevent duplicate syncs (5 min TTL) | [optional]  |

### Return type

[**SyncResponse**](SyncResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sync scheduled |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatestore"></a>
# **UpdateStore**
> CreateStore201Response UpdateStore (string storeId, UpdateStoreRequest updateStoreRequest)

Update a store connection

Update store settings such as name, sync interval, or credentials.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store connection UUID |  |
| **updateStoreRequest** | [**UpdateStoreRequest**](UpdateStoreRequest.md) |  |  |

### Return type

[**CreateStore201Response**](CreateStore201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Store connection updated |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

