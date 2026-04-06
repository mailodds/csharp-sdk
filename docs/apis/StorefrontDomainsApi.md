# MailOdds.Api.StorefrontDomainsApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateStorefrontDomain**](StorefrontDomainsApi.md#createstorefrontdomain) | **POST** /v1/storefront-domains | Add a custom storefront domain |
| [**DeleteStorefrontDomain**](StorefrontDomainsApi.md#deletestorefrontdomain) | **DELETE** /v1/storefront-domains/{domain_id} | Delete a storefront domain |
| [**GetStorefrontDomain**](StorefrontDomainsApi.md#getstorefrontdomain) | **GET** /v1/storefront-domains/{domain_id} | Get storefront domain details |
| [**ListStorefrontDomains**](StorefrontDomainsApi.md#liststorefrontdomains) | **GET** /v1/storefront-domains | List storefront domains |
| [**VerifyStorefrontDomain**](StorefrontDomainsApi.md#verifystorefrontdomain) | **POST** /v1/storefront-domains/{domain_id}/verify | Verify storefront domain DNS |

<a id="createstorefrontdomain"></a>
# **CreateStorefrontDomain**
> void CreateStorefrontDomain (CreateStorefrontDomainRequest createStorefrontDomainRequest)

Add a custom storefront domain

Register a custom domain (e.g., shop.merchant.com) for a storefront store. If a Cloudflare DNS provider is connected, NS records are auto-configured.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createStorefrontDomainRequest** | [**CreateStorefrontDomainRequest**](CreateStorefrontDomainRequest.md) |  |  |

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
| **201** | Add a custom storefront domain |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletestorefrontdomain"></a>
# **DeleteStorefrontDomain**
> void DeleteStorefrontDomain (string domainId)

Delete a storefront domain

Remove a custom storefront domain. Cleans up DNS records (if auto-configured), TLS certificates, and edge node config.


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
| **200** | Delete a storefront domain |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstorefrontdomain"></a>
# **GetStorefrontDomain**
> void GetStorefrontDomain (string domainId)

Get storefront domain details

Get a custom domain with status, NS record instructions, and certificate info.


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
| **200** | Get storefront domain details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="liststorefrontdomains"></a>
# **ListStorefrontDomains**
> void ListStorefrontDomains ()

List storefront domains

List all custom storefront domains for the account.


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
| **200** | List storefront domains |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="verifystorefrontdomain"></a>
# **VerifyStorefrontDomain**
> void VerifyStorefrontDomain (string domainId)

Verify storefront domain DNS

Trigger manual DNS verification for a custom domain. Rate limited to 5 per hour per domain.


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
| **200** | Verify storefront domain DNS |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

