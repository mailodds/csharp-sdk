# MailOdds.Api.PipelineSimulationApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SimulatePipeline**](PipelineSimulationApi.md#simulatepipeline) | **POST** /v1/simulate | Simulate sending pipeline |

<a id="simulatepipeline"></a>
# **SimulatePipeline**
> void SimulatePipeline ()

Simulate sending pipeline

Dry-run the sending or receiving pipeline to preview what would happen without side effects.


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
| **200** | Simulate sending pipeline |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

