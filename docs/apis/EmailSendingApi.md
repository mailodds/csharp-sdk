# MailOdds.Api.EmailSendingApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeliverBatch**](EmailSendingApi.md#deliverbatch) | **POST** /v1/deliver/batch | Send to multiple recipients (max 100) |
| [**DeliverEmail**](EmailSendingApi.md#deliveremail) | **POST** /v1/deliver | Send a single email |

<a id="deliverbatch"></a>
# **DeliverBatch**
> BatchDeliverResponse DeliverBatch (BatchDeliverRequest batchDeliverRequest)

Send to multiple recipients (max 100)

Send a single message to up to 100 recipients. Shares the same message body across all recipients. Each recipient is processed independently.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchDeliverRequest** | [**BatchDeliverRequest**](BatchDeliverRequest.md) |  |  |

### Return type

[**BatchDeliverResponse**](BatchDeliverResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Batch accepted for delivery |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deliveremail"></a>
# **DeliverEmail**
> DeliverResponse DeliverEmail (DeliverRequest deliverRequest)

Send a single email

Send a transactional email through the safety pipeline. Validates recipients, checks domain ownership, and queues for delivery. Requires a verified sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliverRequest** | [**DeliverRequest**](DeliverRequest.md) |  |  |

### Return type

[**DeliverResponse**](DeliverResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Email accepted for delivery |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

