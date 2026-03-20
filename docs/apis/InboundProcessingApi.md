# MailOdds.Api.InboundProcessingApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CorrectInboundMessage**](InboundProcessingApi.md#correctinboundmessage) | **PATCH** /v1/inbound-messages/{message_id}/correction | Correct inbound message classification |
| [**GetBounceStats**](InboundProcessingApi.md#getbouncestats) | **GET** /v1/bounce-stats | Get bounce statistics |
| [**GetBounceStatsSummary**](InboundProcessingApi.md#getbouncestatssummary) | **GET** /v1/bounce-stats/summary | Get bounce statistics summary |
| [**GetComplaintAssessment**](InboundProcessingApi.md#getcomplaintassessment) | **GET** /v1/complaint-assessment | Get complaint assessment |
| [**GetInboundMessage**](InboundProcessingApi.md#getinboundmessage) | **GET** /v1/inbound-messages/{message_id} | Get inbound message |
| [**ListInboundMessages**](InboundProcessingApi.md#listinboundmessages) | **GET** /v1/inbound-messages | List inbound messages |

<a id="correctinboundmessage"></a>
# **CorrectInboundMessage**
> GetInboundMessage200Response CorrectInboundMessage (string messageId, CorrectInboundMessageRequest correctInboundMessageRequest)

Correct inbound message classification

Submit a human correction for an inbound message classification. Requires Pro+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |
| **correctInboundMessageRequest** | [**CorrectInboundMessageRequest**](CorrectInboundMessageRequest.md) |  |  |

### Return type

[**GetInboundMessage200Response**](GetInboundMessage200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message updated with correction |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbouncestats"></a>
# **GetBounceStats**
> GetBounceStats200Response GetBounceStats (string domainId = null, string period = null, string groupBy = null)

Get bounce statistics

Get bounce and complaint statistics grouped by time period. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Filter by sending domain ID | [optional]  |
| **period** | **string** | Time period | [optional] [default to 7d] |
| **groupBy** | **string** | Grouping interval | [optional] [default to day] |

### Return type

[**GetBounceStats200Response**](GetBounceStats200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bounce statistics |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbouncestatssummary"></a>
# **GetBounceStatsSummary**
> GetBounceStatsSummary200Response GetBounceStatsSummary (string domainId = null, string period = null)

Get bounce statistics summary

Get aggregated bounce and complaint statistics. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Filter by sending domain ID | [optional]  |
| **period** | **string** | Time period | [optional] [default to 30d] |

### Return type

[**GetBounceStatsSummary200Response**](GetBounceStatsSummary200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bounce statistics summary |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcomplaintassessment"></a>
# **GetComplaintAssessment**
> GetComplaintAssessment200Response GetComplaintAssessment (string domainId = null, string period = null)

Get complaint assessment

Assess complaint risk based on recent inbound data. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Filter by sending domain ID | [optional]  |
| **period** | **string** | Time period | [optional] [default to 30d] |

### Return type

[**GetComplaintAssessment200Response**](GetComplaintAssessment200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complaint assessment |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getinboundmessage"></a>
# **GetInboundMessage**
> GetInboundMessage200Response GetInboundMessage (string messageId)

Get inbound message

Get a single inbound message with full body content. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

### Return type

[**GetInboundMessage200Response**](GetInboundMessage200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inbound message details |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listinboundmessages"></a>
# **ListInboundMessages**
> ListInboundMessages200Response ListInboundMessages (string category = null, string domainId = null, DateTime since = null, DateTime until = null, bool isRead = null, string recipient = null, string search = null, int page = null, int perPage = null)

List inbound messages

List inbound messages (bounces, complaints, replies, OOO). Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **category** | **string** | Filter by category | [optional]  |
| **domainId** | **string** | Filter by sending domain ID | [optional]  |
| **since** | **DateTime** | Start date (ISO 8601) | [optional]  |
| **until** | **DateTime** | End date (ISO 8601) | [optional]  |
| **isRead** | **bool** | Filter by read status | [optional]  |
| **recipient** | **string** | Filter by original recipient | [optional]  |
| **search** | **string** | Search in subject and body | [optional]  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 50] |

### Return type

[**ListInboundMessages200Response**](ListInboundMessages200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of inbound messages |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

