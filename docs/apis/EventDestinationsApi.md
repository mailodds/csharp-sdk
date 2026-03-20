# MailOdds.Api.EventDestinationsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEventDestination**](EventDestinationsApi.md#createeventdestination) | **POST** /v1/event-destinations | Create an event destination |
| [**DeleteEventDestination**](EventDestinationsApi.md#deleteeventdestination) | **DELETE** /v1/event-destinations/{destination_id} | Delete an event destination |
| [**GetEventDestination**](EventDestinationsApi.md#geteventdestination) | **GET** /v1/event-destinations/{destination_id} | Get an event destination |
| [**ListEventDestinationTemplates**](EventDestinationsApi.md#listeventdestinationtemplates) | **GET** /v1/event-destinations/templates | List event destination templates |
| [**ListEventDestinations**](EventDestinationsApi.md#listeventdestinations) | **GET** /v1/event-destinations | List event destinations |
| [**ListEventSchemas**](EventDestinationsApi.md#listeventschemas) | **GET** /v1/event-destinations/schemas | List event schemas |
| [**UpdateEventDestination**](EventDestinationsApi.md#updateeventdestination) | **PUT** /v1/event-destinations/{destination_id} | Update an event destination |

<a id="createeventdestination"></a>
# **CreateEventDestination**
> void CreateEventDestination ()

Create an event destination

Create a new event destination for receiving webhook callbacks.


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
| **201** | Create an event destination |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteeventdestination"></a>
# **DeleteEventDestination**
> void DeleteEventDestination (int destinationId)

Delete an event destination

Delete an event destination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **int** |  |  |

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
| **200** | Delete an event destination |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteventdestination"></a>
# **GetEventDestination**
> void GetEventDestination (int destinationId)

Get an event destination

Retrieve a single event destination by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **int** |  |  |

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
| **200** | Get an event destination |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listeventdestinationtemplates"></a>
# **ListEventDestinationTemplates**
> void ListEventDestinationTemplates ()

List event destination templates

List pre-built payload templates for event destinations.


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
| **200** | List event destination templates |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listeventdestinations"></a>
# **ListEventDestinations**
> void ListEventDestinations ()

List event destinations

List all event destinations for the account.


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
| **200** | List event destinations |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listeventschemas"></a>
# **ListEventSchemas**
> void ListEventSchemas ()

List event schemas

List JSON schemas for each event type.


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
| **200** | List event schemas |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateeventdestination"></a>
# **UpdateEventDestination**
> void UpdateEventDestination (int destinationId)

Update an event destination

Update an existing event destination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **int** |  |  |

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
| **200** | Update an event destination |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

