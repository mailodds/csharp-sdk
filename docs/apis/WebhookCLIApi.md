# MailOdds.Api.WebhookCLIApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhookCliSession**](WebhookCLIApi.md#createwebhookclisession) | **POST** /v1/webhook-cli/sessions | Create CLI forwarding session |
| [**DeleteWebhookCliSession**](WebhookCLIApi.md#deletewebhookclisession) | **DELETE** /v1/webhook-cli/sessions/{session_id} | Close CLI session |
| [**ListWebhookDeliveries**](WebhookCLIApi.md#listwebhookdeliveries) | **GET** /v1/webhook-cli/deliveries | List recent webhook deliveries |
| [**ReplayWebhookDelivery**](WebhookCLIApi.md#replaywebhookdelivery) | **POST** /v1/webhook-cli/deliveries/{delivery_id}/replay | Replay webhook delivery |

<a id="createwebhookclisession"></a>
# **CreateWebhookCliSession**
> CreateWebhookCliSession201Response CreateWebhookCliSession (CreateWebhookCliSessionRequest createWebhookCliSessionRequest = null)

Create CLI forwarding session

Register a new session for receiving webhook events via SSE.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWebhookCliSessionRequest** | [**CreateWebhookCliSessionRequest**](CreateWebhookCliSessionRequest.md) |  | [optional]  |

### Return type

[**CreateWebhookCliSession201Response**](CreateWebhookCliSession201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Session created |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewebhookclisession"></a>
# **DeleteWebhookCliSession**
> DeleteWebhookCliSession200Response DeleteWebhookCliSession (string sessionId)

Close CLI session

Close a webhook CLI forwarding session.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string** | Session ID |  |

### Return type

[**DeleteWebhookCliSession200Response**](DeleteWebhookCliSession200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session closed |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listwebhookdeliveries"></a>
# **ListWebhookDeliveries**
> ListWebhookDeliveries200Response ListWebhookDeliveries (int limit = null)

List recent webhook deliveries

List recent webhook deliveries for replay.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Maximum deliveries to return | [optional] [default to 50] |

### Return type

[**ListWebhookDeliveries200Response**](ListWebhookDeliveries200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of recent webhook deliveries |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="replaywebhookdelivery"></a>
# **ReplayWebhookDelivery**
> ReplayWebhookDelivery200Response ReplayWebhookDelivery (int deliveryId)

Replay webhook delivery

Replay a historical webhook delivery to active CLI sessions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliveryId** | **int** | Delivery ID |  |

### Return type

[**ReplayWebhookDelivery200Response**](ReplayWebhookDelivery200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delivery replayed |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

