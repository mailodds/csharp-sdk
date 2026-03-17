# MailOdds.Api.EventsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TrackEvent**](EventsApi.md#trackevent) | **POST** /v1/events/track | Track a commerce event |

<a id="trackevent"></a>
# **TrackEvent**
> TrackEventResponse TrackEvent (TrackEventRequest trackEventRequest)

Track a commerce event

Ingest a commerce event (purchase, cart abandonment, browse, wishlist, review, etc.). Supports idempotency via the idempotency_key field (5 minute Redis TTL + DB unique constraint).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackEventRequest** | [**TrackEventRequest**](TrackEventRequest.md) |  |  |

### Return type

[**TrackEventResponse**](TrackEventResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Event created |  -  |
| **200** | Idempotent duplicate (event already exists) |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

