# MailOdds.Api.ConfigurationSetsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateConfigurationSet**](ConfigurationSetsApi.md#createconfigurationset) | **POST** /v1/configuration-sets | Create a configuration set |
| [**DeleteConfigurationSet**](ConfigurationSetsApi.md#deleteconfigurationset) | **DELETE** /v1/configuration-sets/{name} | Delete a configuration set |
| [**GetConfigurationSet**](ConfigurationSetsApi.md#getconfigurationset) | **GET** /v1/configuration-sets/{name} | Get a configuration set |
| [**GetConfigurationSetMetrics**](ConfigurationSetsApi.md#getconfigurationsetmetrics) | **GET** /v1/configuration-sets/{name}/metrics | Get configuration set metrics |
| [**ListConfigurationSets**](ConfigurationSetsApi.md#listconfigurationsets) | **GET** /v1/configuration-sets | List configuration sets |
| [**UpdateConfigurationSet**](ConfigurationSetsApi.md#updateconfigurationset) | **PUT** /v1/configuration-sets/{name} | Update a configuration set |

<a id="createconfigurationset"></a>
# **CreateConfigurationSet**
> void CreateConfigurationSet ()

Create a configuration set

Create a new configuration set for grouping sending behavior.


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
| **201** | Create a configuration set |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteconfigurationset"></a>
# **DeleteConfigurationSet**
> void DeleteConfigurationSet (string name)

Delete a configuration set

Delete a configuration set by name.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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
| **200** | Delete a configuration set |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getconfigurationset"></a>
# **GetConfigurationSet**
> void GetConfigurationSet (string name)

Get a configuration set

Retrieve a configuration set by name.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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
| **200** | Get a configuration set |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getconfigurationsetmetrics"></a>
# **GetConfigurationSetMetrics**
> void GetConfigurationSetMetrics (string name)

Get configuration set metrics

Retrieve sending metrics for a configuration set.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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
| **200** | Get configuration set metrics |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listconfigurationsets"></a>
# **ListConfigurationSets**
> void ListConfigurationSets ()

List configuration sets

List all configuration sets for the account.


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
| **200** | List configuration sets |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateconfigurationset"></a>
# **UpdateConfigurationSet**
> void UpdateConfigurationSet (string name)

Update a configuration set

Update an existing configuration set by name.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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
| **200** | Update a configuration set |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

