# MailOdds.Api.SendingDomainsApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSendingDomain**](SendingDomainsApi.md#createsendingdomain) | **POST** /v1/sending-domains | Add a sending domain |
| [**DeleteSendingDomain**](SendingDomainsApi.md#deletesendingdomain) | **DELETE** /v1/sending-domains/{domain_id} | Delete a sending domain |
| [**GetReplyForwarding**](SendingDomainsApi.md#getreplyforwarding) | **GET** /v1/sending-domains/{domain_id}/reply-forwarding | Get reply forwarding config |
| [**GetSendingDomain**](SendingDomainsApi.md#getsendingdomain) | **GET** /v1/sending-domains/{domain_id} | Get a sending domain |
| [**GetSendingDomainIdentityScore**](SendingDomainsApi.md#getsendingdomainidentityscore) | **GET** /v1/sending-domains/{domain_id}/identity-score | Get domain identity score |
| [**GetSendingStats**](SendingDomainsApi.md#getsendingstats) | **GET** /v1/sending-stats | Get sending statistics |
| [**ListSendingDomains**](SendingDomainsApi.md#listsendingdomains) | **GET** /v1/sending-domains | List sending domains |
| [**UpdateReplyForwarding**](SendingDomainsApi.md#updatereplyforwarding) | **PATCH** /v1/sending-domains/{domain_id}/reply-forwarding | Update reply forwarding config |
| [**VerifySendingDomain**](SendingDomainsApi.md#verifysendingdomain) | **POST** /v1/sending-domains/{domain_id}/verify | Verify domain DNS records |

<a id="createsendingdomain"></a>
# **CreateSendingDomain**
> CreateSendingDomain201Response CreateSendingDomain (CreateSendingDomainRequest createSendingDomainRequest)

Add a sending domain

Register a new sending domain with NS delegation. After adding, configure DNS records and verify.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSendingDomainRequest** | [**CreateSendingDomainRequest**](CreateSendingDomainRequest.md) |  |  |

### Return type

[**CreateSendingDomain201Response**](CreateSendingDomain201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Domain created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesendingdomain"></a>
# **DeleteSendingDomain**
> DeletePolicyRule200Response DeleteSendingDomain (string domainId)

Delete a sending domain

Permanently remove a sending domain from the account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

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
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreplyforwarding"></a>
# **GetReplyForwarding**
> GetReplyForwarding200Response GetReplyForwarding (string domainId)

Get reply forwarding config

Get the reply forwarding configuration for a sending domain. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Sending domain ID |  |

### Return type

[**GetReplyForwarding200Response**](GetReplyForwarding200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reply forwarding configuration |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsendingdomain"></a>
# **GetSendingDomain**
> CreateSendingDomain201Response GetSendingDomain (string domainId)

Get a sending domain

Get details of a specific sending domain including DNS verification status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

### Return type

[**CreateSendingDomain201Response**](CreateSendingDomain201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Domain details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsendingdomainidentityscore"></a>
# **GetSendingDomainIdentityScore**
> GetSendingDomainIdentityScore200Response GetSendingDomainIdentityScore (string domainId)

Get domain identity score

Get a composite DNS health score for the sending domain, checking DKIM, SPF, DMARC, MX, and return path configuration.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

### Return type

[**GetSendingDomainIdentityScore200Response**](GetSendingDomainIdentityScore200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Identity score |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsendingstats"></a>
# **GetSendingStats**
> GetSendingStats200Response GetSendingStats (string period = null, string domainId = null)

Get sending statistics

Get aggregate sending statistics across all domains for the account, including delivery rates, open rates, and click rates.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | Time period | [optional] [default to 7d] |
| **domainId** | **string** | Filter by domain | [optional]  |

### Return type

[**GetSendingStats200Response**](GetSendingStats200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sending statistics |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listsendingdomains"></a>
# **ListSendingDomains**
> ListSendingDomains200Response ListSendingDomains ()

List sending domains

List all sending domains for the authenticated account.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListSendingDomains200Response**](ListSendingDomains200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of sending domains |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatereplyforwarding"></a>
# **UpdateReplyForwarding**
> GetReplyForwarding200Response UpdateReplyForwarding (string domainId, UpdateReplyForwardingRequest updateReplyForwardingRequest)

Update reply forwarding config

Configure reply forwarding for a sending domain. Set forward_replies_to to null to disable. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | Sending domain ID |  |
| **updateReplyForwardingRequest** | [**UpdateReplyForwardingRequest**](UpdateReplyForwardingRequest.md) |  |  |

### Return type

[**GetReplyForwarding200Response**](GetReplyForwarding200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reply forwarding updated |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="verifysendingdomain"></a>
# **VerifySendingDomain**
> CreateSendingDomain201Response VerifySendingDomain (string domainId)

Verify domain DNS records

Check and verify all DNS records (DKIM, SPF, DMARC, MX, return path) for the sending domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |

### Return type

[**CreateSendingDomain201Response**](CreateSendingDomain201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Verification result |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

