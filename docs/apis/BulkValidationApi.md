# MailOdds.Api.BulkValidationApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelJob**](BulkValidationApi.md#canceljob) | **POST** /v1/jobs/{job_id}/cancel | Cancel a job |
| [**CreateJob**](BulkValidationApi.md#createjob) | **POST** /v1/jobs | Create bulk validation job (JSON) |
| [**CreateJobFromS3**](BulkValidationApi.md#createjobfroms3) | **POST** /v1/jobs/upload/s3 | Create job from S3 upload |
| [**CreateJobUpload**](BulkValidationApi.md#createjobupload) | **POST** /v1/jobs/upload | Create bulk validation job (file upload) |
| [**DeleteJob**](BulkValidationApi.md#deletejob) | **DELETE** /v1/jobs/{job_id} | Delete a job |
| [**GetJob**](BulkValidationApi.md#getjob) | **GET** /v1/jobs/{job_id} | Get job status |
| [**GetJobResults**](BulkValidationApi.md#getjobresults) | **GET** /v1/jobs/{job_id}/results | Get job results |
| [**GetPresignedUpload**](BulkValidationApi.md#getpresignedupload) | **POST** /v1/jobs/upload/presigned | Get S3 presigned upload URL |
| [**ListJobs**](BulkValidationApi.md#listjobs) | **GET** /v1/jobs | List validation jobs |

<a id="canceljob"></a>
# **CancelJob**
> JobResponse CancelJob (string jobId)

Cancel a job

Cancel a pending or processing job. Partial results are preserved.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** |  |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Job cancelled |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createjob"></a>
# **CreateJob**
> JobResponse CreateJob (CreateJobRequest createJobRequest)

Create bulk validation job (JSON)

Create a new bulk validation job by submitting a JSON array of emails.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createJobRequest** | [**CreateJobRequest**](CreateJobRequest.md) |  |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Job created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createjobfroms3"></a>
# **CreateJobFromS3**
> JobResponse CreateJobFromS3 (CreateJobFromS3Request createJobFromS3Request)

Create job from S3 upload

Create a validation job from a file previously uploaded to S3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createJobFromS3Request** | [**CreateJobFromS3Request**](CreateJobFromS3Request.md) |  |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Job created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createjobupload"></a>
# **CreateJobUpload**
> JobResponse CreateJobUpload (System.IO.Stream file, bool dedup = null, string metadata = null)

Create bulk validation job (file upload)

Create a new bulk validation job by uploading a CSV, Excel, or TXT file.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | CSV, Excel (.xlsx, .xls), ODS, or TXT file |  |
| **dedup** | **bool** | Remove duplicate emails | [optional] [default to false] |
| **metadata** | **string** | JSON metadata for the job | [optional]  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Job created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletejob"></a>
# **DeleteJob**
> DeleteJob200Response DeleteJob (string jobId)

Delete a job

Permanently delete a completed or cancelled job and its results.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** |  |  |

### Return type

[**DeleteJob200Response**](DeleteJob200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Job deleted |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getjob"></a>
# **GetJob**
> JobResponse GetJob (string jobId)

Get job status

Get the status and details of a specific validation job.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** |  |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Job details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getjobresults"></a>
# **GetJobResults**
> ResultsResponse GetJobResults (string jobId, string format = null, string filter = null, int page = null, int perPage = null)

Get job results

Download validation results in JSON, CSV, or NDJSON format.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** |  |  |
| **format** | **string** |  | [optional] [default to json] |
| **filter** | **string** |  | [optional]  |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 1000] |

### Return type

[**ResultsResponse**](ResultsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/x-ndjson


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Validation results |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpresignedupload"></a>
# **GetPresignedUpload**
> PresignedUploadResponse GetPresignedUpload (GetPresignedUploadRequest getPresignedUploadRequest)

Get S3 presigned upload URL

Get a presigned URL for uploading large files (>10MB) directly to S3.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPresignedUploadRequest** | [**GetPresignedUploadRequest**](GetPresignedUploadRequest.md) |  |  |

### Return type

[**PresignedUploadResponse**](PresignedUploadResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Presigned upload credentials |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **503** | S3 not configured |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listjobs"></a>
# **ListJobs**
> JobListResponse ListJobs (int page = null, int perPage = null, string status = null)

List validation jobs

List all validation jobs for the authenticated account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |
| **status** | **string** |  | [optional]  |

### Return type

[**JobListResponse**](JobListResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of jobs |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

