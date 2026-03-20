# MailOdds.Api.DMARCMonitoringApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDmarcDomain**](DMARCMonitoringApi.md#adddmarcdomain) | **POST** /v1/dmarc-domains | Add DMARC domain |
| [**DeleteDmarcDomain**](DMARCMonitoringApi.md#deletedmarcdomain) | **DELETE** /v1/dmarc-domains/{domain_id} | Delete a DMARC domain |
| [**GetDmarcDomain**](DMARCMonitoringApi.md#getdmarcdomain) | **GET** /v1/dmarc-domains/{domain_id} | Get DMARC domain |
| [**GetDmarcRecommendation**](DMARCMonitoringApi.md#getdmarcrecommendation) | **GET** /v1/dmarc-domains/{domain_id}/recommendation | Get DMARC policy recommendation |
| [**GetDmarcSources**](DMARCMonitoringApi.md#getdmarcsources) | **GET** /v1/dmarc-domains/{domain_id}/sources | Get DMARC sending sources |
| [**GetDmarcTrend**](DMARCMonitoringApi.md#getdmarctrend) | **GET** /v1/dmarc-domains/{domain_id}/trend | Get DMARC trend |
| [**ListDmarcDomains**](DMARCMonitoringApi.md#listdmarcdomains) | **GET** /v1/dmarc-domains | List DMARC domains |
| [**VerifyDmarcDomain**](DMARCMonitoringApi.md#verifydmarcdomain) | **POST** /v1/dmarc-domains/{domain_id}/verify | Verify DMARC DNS records |

<a id="adddmarcdomain"></a>
# **AddDmarcDomain**
> AddDmarcDomain201Response AddDmarcDomain (AddDmarcDomainRequest addDmarcDomainRequest)

Add DMARC domain

Add a domain for DMARC monitoring. A unique reporting address is generated for receiving aggregate DMARC reports.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addDmarcDomainRequest** | [**AddDmarcDomainRequest**](AddDmarcDomainRequest.md) |  |  |

### Return type

[**AddDmarcDomain201Response**](AddDmarcDomain201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Domain added |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletedmarcdomain"></a>
# **DeleteDmarcDomain**
> DeletePolicyRule200Response DeleteDmarcDomain (string domainId)

Delete a DMARC domain

Delete a DMARC domain and all its associated reports.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |

### Return type

[**DeletePolicyRule200Response**](DeletePolicyRule200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Domain deleted |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdmarcdomain"></a>
# **GetDmarcDomain**
> GetDmarcDomain200Response GetDmarcDomain (string domainId, int days = null)

Get DMARC domain

Get a single DMARC domain with summary statistics including pass/fail rates.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |
| **days** | **int** | Number of days for summary stats | [optional] [default to 30] |

### Return type

[**GetDmarcDomain200Response**](GetDmarcDomain200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Domain with summary stats |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdmarcrecommendation"></a>
# **GetDmarcRecommendation**
> GetDmarcRecommendation200Response GetDmarcRecommendation (string domainId)

Get DMARC policy recommendation

Get a recommendation for upgrading the domain's DMARC policy based on alignment data.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |

### Return type

[**GetDmarcRecommendation200Response**](GetDmarcRecommendation200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Policy recommendation |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdmarcsources"></a>
# **GetDmarcSources**
> GetDmarcSources200Response GetDmarcSources (string domainId, int days = null, int page = null, int perPage = null)

Get DMARC sending sources

Get sending IPs that have sent email for this domain with their DKIM/SPF alignment status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |
| **days** | **int** | Number of days to look back | [optional] [default to 30] |
| **page** | **int** |  | [optional] [default to 1] |
| **perPage** | **int** |  | [optional] [default to 20] |

### Return type

[**GetDmarcSources200Response**](GetDmarcSources200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sending sources with alignment status |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdmarctrend"></a>
# **GetDmarcTrend**
> GetDmarcTrend200Response GetDmarcTrend (string domainId, int days = null)

Get DMARC trend

Get daily pass/fail trend data for DMARC authentication over the specified period.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |
| **days** | **int** | Number of days of trend data | [optional] [default to 30] |

### Return type

[**GetDmarcTrend200Response**](GetDmarcTrend200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Daily trend data |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listdmarcdomains"></a>
# **ListDmarcDomains**
> ListDmarcDomains200Response ListDmarcDomains ()

List DMARC domains

List all domains being monitored for DMARC compliance.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListDmarcDomains200Response**](ListDmarcDomains200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of monitored domains |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="verifydmarcdomain"></a>
# **VerifyDmarcDomain**
> AddDmarcDomain201Response VerifyDmarcDomain (string domainId)

Verify DMARC DNS records

Check that the domain has the correct DMARC TXT record pointing to the MailOdds reporting address.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | DMARC domain UUID |  |

### Return type

[**AddDmarcDomain201Response**](AddDmarcDomain201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Verification result |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

