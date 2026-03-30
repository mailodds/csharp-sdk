# MailOdds.Api.MessageEventsApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMessageEvents**](MessageEventsApi.md#getmessageevents) | **GET** /v1/message-events | Get message events |

<a id="getmessageevents"></a>
# **GetMessageEvents**
> GetMessageEvents200Response GetMessageEvents (string messageId)

Get message events

Get delivery and engagement events for a specific sent message. Returns events in chronological order with bot detection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | UUID of the sent message |  |

### Return type

[**GetMessageEvents200Response**](GetMessageEvents200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message events with summary |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

