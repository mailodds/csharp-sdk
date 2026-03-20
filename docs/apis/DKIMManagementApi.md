# MailOdds.Api.DKIMManagementApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDkimDnsRecord**](DKIMManagementApi.md#getdkimdnsrecord) | **GET** /v1/sending-domains/{domain_id}/dkim/dns-record | Get DKIM DNS record |
| [**RotateDkim**](DKIMManagementApi.md#rotatedkim) | **POST** /v1/sending-domains/{domain_id}/dkim/rotate | Rotate DKIM keys |

<a id="getdkimdnsrecord"></a>
# **GetDkimDnsRecord**
> void GetDkimDnsRecord (string domainId)

Get DKIM DNS record

Retrieve the current DKIM DNS record and selector for a sending domain.


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
| **200** | Get DKIM DNS record |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rotatedkim"></a>
# **RotateDkim**
> void RotateDkim (string domainId)

Rotate DKIM keys

Generate a new DKIM key pair and rotate the selector for a sending domain.


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
| **200** | Rotate DKIM keys |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

