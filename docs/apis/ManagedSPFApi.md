# MailOdds.Api.ManagedSPFApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManagedSpf**](ManagedSPFApi.md#createmanagedspf) | **POST** /v1/sending-domains/{domain_id}/managed-spf | Create managed SPF record |
| [**GetManagedSpf**](ManagedSPFApi.md#getmanagedspf) | **GET** /v1/sending-domains/{domain_id}/managed-spf | Get managed SPF record |
| [**RefreshManagedSpf**](ManagedSPFApi.md#refreshmanagedspf) | **POST** /v1/sending-domains/{domain_id}/managed-spf/refresh | Refresh managed SPF record |
| [**UpdateManagedSpf**](ManagedSPFApi.md#updatemanagedspf) | **PUT** /v1/sending-domains/{domain_id}/managed-spf | Update managed SPF settings |

<a id="createmanagedspf"></a>
# **CreateManagedSpf**
> void CreateManagedSpf (string domainId)

Create managed SPF record

Create a managed SPF record for a sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

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
| **201** | Create managed SPF record |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmanagedspf"></a>
# **GetManagedSpf**
> void GetManagedSpf (string domainId)

Get managed SPF record

Retrieve the managed SPF record for a sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

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
| **200** | Get managed SPF record |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="refreshmanagedspf"></a>
# **RefreshManagedSpf**
> void RefreshManagedSpf (string domainId)

Refresh managed SPF record

Re-resolve DNS and refresh the managed SPF record for a sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

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
| **200** | Refresh managed SPF record |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatemanagedspf"></a>
# **UpdateManagedSpf**
> void UpdateManagedSpf (string domainId)

Update managed SPF settings

Update managed SPF settings such as enabling or disabling for a sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

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
| **200** | Update managed SPF settings |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

