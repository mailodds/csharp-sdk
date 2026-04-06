# MailOdds.Api.DNSProviderApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConnectDnsProvider**](DNSProviderApi.md#connectdnsprovider) | **POST** /v1/account/dns-provider | Connect DNS provider |
| [**DisconnectDnsProvider**](DNSProviderApi.md#disconnectdnsprovider) | **DELETE** /v1/account/dns-provider | Disconnect DNS provider |
| [**GetDnsProvider**](DNSProviderApi.md#getdnsprovider) | **GET** /v1/account/dns-provider | Get DNS provider status |

<a id="connectdnsprovider"></a>
# **ConnectDnsProvider**
> void ConnectDnsProvider (ConnectDnsProviderRequest connectDnsProviderRequest)

Connect DNS provider

Store a Cloudflare API token on the account for automated DNS configuration. Token is validated, zones are discovered, and write permission is tested before storage.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectDnsProviderRequest** | [**ConnectDnsProviderRequest**](ConnectDnsProviderRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Connect DNS provider |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectdnsprovider"></a>
# **DisconnectDnsProvider**
> void DisconnectDnsProvider ()

Disconnect DNS provider

Remove the stored DNS provider token and clear zone cache.


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
| **200** | Disconnect DNS provider |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdnsprovider"></a>
# **GetDnsProvider**
> void GetDnsProvider ()

Get DNS provider status

Get the DNS provider connection status. Token is never exposed in the response.


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
| **200** | Get DNS provider status |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

