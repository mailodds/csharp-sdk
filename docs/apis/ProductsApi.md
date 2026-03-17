# MailOdds.Api.ProductsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchProducts**](ProductsApi.md#batchproducts) | **POST** /v1/stores/{store_id}/products/batch | Batch push products |
| [**BulkUpdateProducts**](ProductsApi.md#bulkupdateproducts) | **PATCH** /v1/store-products/bulk | Bulk update products |
| [**GetProduct**](ProductsApi.md#getproduct) | **GET** /v1/store-products/{product_id} | Get a product |
| [**QueryProducts**](ProductsApi.md#queryproducts) | **GET** /v1/store-products | Query products |

<a id="batchproducts"></a>
# **BatchProducts**
> BatchProductsResponse BatchProducts (string storeId, BatchProductsRequest batchProductsRequest)

Batch push products

Push up to 100 products to a custom platform store. Creates new products or updates existing ones matched by external_id. Only available for stores with platform=custom.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Store connection UUID |  |
| **batchProductsRequest** | [**BatchProductsRequest**](BatchProductsRequest.md) |  |  |

### Return type

[**BatchProductsResponse**](BatchProductsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch results |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="bulkupdateproducts"></a>
# **BulkUpdateProducts**
> BulkUpdateProducts200Response BulkUpdateProducts (BulkUpdateProductsRequest bulkUpdateProductsRequest)

Bulk update products

Bulk update product visibility. Maximum 500 products per request.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bulkUpdateProductsRequest** | [**BulkUpdateProductsRequest**](BulkUpdateProductsRequest.md) |  |  |

### Return type

[**BulkUpdateProducts200Response**](BulkUpdateProducts200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bulk update result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getproduct"></a>
# **GetProduct**
> GetProduct200Response GetProduct (string productId)

Get a product

Get detailed information about a specific product.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Product UUID |  |

### Return type

[**GetProduct200Response**](GetProduct200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Product details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="queryproducts"></a>
# **QueryProducts**
> QueryProducts200Response QueryProducts (string storeId = null, string category = null, string stockStatus = null, bool onSale = null, string search = null, bool facets = null, bool groupBySku = null, int page = null, int perPage = null)

Query products

Search and filter products across all connected stores. Supports faceted search and cross-store SKU deduplication for unified inventory views.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Filter by store connection UUID | [optional]  |
| **category** | **string** | Filter by category name | [optional]  |
| **stockStatus** | **string** | Filter by stock status | [optional]  |
| **onSale** | **bool** | Filter to products currently on sale | [optional]  |
| **search** | **string** | Search by title or SKU | [optional]  |
| **facets** | **bool** | Include facet aggregations (categories, price ranges, stores) | [optional] [default to false] |
| **groupBySku** | **bool** | Merge products with same SKU across stores into unified entries | [optional] [default to false] |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**QueryProducts200Response**](QueryProducts200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Product query results |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

