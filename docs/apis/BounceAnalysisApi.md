# MailOdds.Api.BounceAnalysisApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBounceAnalysis**](BounceAnalysisApi.md#createbounceanalysis) | **POST** /v1/bounce-analyses | Analyze bounce logs |
| [**CrossReferenceBounces**](BounceAnalysisApi.md#crossreferencebounces) | **GET** /v1/bounce-analyses/{analysis_id}/cross-reference | Cross-reference bounces with validation logs |
| [**GetBounceAnalysis**](BounceAnalysisApi.md#getbounceanalysis) | **GET** /v1/bounce-analyses/{analysis_id} | Get bounce analysis |
| [**GetBounceRecords**](BounceAnalysisApi.md#getbouncerecords) | **GET** /v1/bounce-analyses/{analysis_id}/records | Get bounce records |

<a id="createbounceanalysis"></a>
# **CreateBounceAnalysis**
> BounceAnalysisResponse CreateBounceAnalysis (CreateBounceAnalysisRequest createBounceAnalysisRequest)

Analyze bounce logs

Submit bounce log data for analysis. Identifies patterns, categorizes bounce types, and provides remediation recommendations.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBounceAnalysisRequest** | [**CreateBounceAnalysisRequest**](CreateBounceAnalysisRequest.md) |  |  |

### Return type

[**BounceAnalysisResponse**](BounceAnalysisResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Bounce analysis created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="crossreferencebounces"></a>
# **CrossReferenceBounces**
> CrossReferenceBounces200Response CrossReferenceBounces (string analysisId)

Cross-reference bounces with validation logs

Match bounced emails against your validation history to identify emails that were validated as deliverable but later bounced.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **analysisId** | **string** | Bounce analysis UUID |  |

### Return type

[**CrossReferenceBounces200Response**](CrossReferenceBounces200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cross-reference results |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbounceanalysis"></a>
# **GetBounceAnalysis**
> BounceAnalysisResponse GetBounceAnalysis (string analysisId)

Get bounce analysis

Get the results of a bounce analysis including category breakdown, top offenders, and recommendations.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **analysisId** | **string** | Bounce analysis UUID |  |

### Return type

[**BounceAnalysisResponse**](BounceAnalysisResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bounce analysis results |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbouncerecords"></a>
# **GetBounceRecords**
> GetBounceRecords200Response GetBounceRecords (string analysisId, int page = null, int perPage = null, string type = null)

Get bounce records

Get individual bounce records from an analysis with pagination.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **analysisId** | **string** | Bounce analysis UUID |  |
| **page** | **int** | Page number | [optional] [default to 1] |
| **perPage** | **int** | Items per page | [optional] [default to 50] |
| **type** | **string** | Filter by bounce type | [optional]  |

### Return type

[**GetBounceRecords200Response**](GetBounceRecords200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bounce records |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

