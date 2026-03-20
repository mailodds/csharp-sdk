# MailOdds.Api.InboundRulesApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateInboundRule**](InboundRulesApi.md#createinboundrule) | **POST** /v1/sending-domains/{domain_id}/inbound-rules | Create an inbound rule |
| [**DeleteInboundRule**](InboundRulesApi.md#deleteinboundrule) | **DELETE** /v1/sending-domains/{domain_id}/inbound-rules/{rule_id} | Delete an inbound rule |
| [**DryRunInboundRules**](InboundRulesApi.md#dryruninboundrules) | **POST** /v1/sending-domains/{domain_id}/inbound-rules/dry-run | Dry-run inbound rules |
| [**GetInboundRule**](InboundRulesApi.md#getinboundrule) | **GET** /v1/sending-domains/{domain_id}/inbound-rules/{rule_id} | Get an inbound rule |
| [**ListInboundRules**](InboundRulesApi.md#listinboundrules) | **GET** /v1/sending-domains/{domain_id}/inbound-rules | List inbound rules |
| [**UpdateInboundRule**](InboundRulesApi.md#updateinboundrule) | **PUT** /v1/sending-domains/{domain_id}/inbound-rules/{rule_id} | Update an inbound rule |

<a id="createinboundrule"></a>
# **CreateInboundRule**
> void CreateInboundRule (string domainId)

Create an inbound rule

Create an inbound routing rule for a sending domain.


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
| **201** | Create an inbound rule |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteinboundrule"></a>
# **DeleteInboundRule**
> void DeleteInboundRule (string domainId, string ruleId)

Delete an inbound rule

Delete an inbound routing rule.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |
| **ruleId** | **string** |  |  |

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
| **200** | Delete an inbound rule |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="dryruninboundrules"></a>
# **DryRunInboundRules**
> void DryRunInboundRules (string domainId)

Dry-run inbound rules

Evaluate inbound rules against a test message without side effects.


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
| **200** | Dry-run inbound rules |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getinboundrule"></a>
# **GetInboundRule**
> void GetInboundRule (string domainId, string ruleId)

Get an inbound rule

Retrieve a specific inbound routing rule by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |
| **ruleId** | **string** |  |  |

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
| **200** | Get an inbound rule |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listinboundrules"></a>
# **ListInboundRules**
> void ListInboundRules (string domainId)

List inbound rules

List all inbound routing rules for a sending domain.


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
| **200** | List inbound rules |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateinboundrule"></a>
# **UpdateInboundRule**
> void UpdateInboundRule (string domainId, string ruleId)

Update an inbound rule

Update an existing inbound routing rule.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** |  |  |
| **ruleId** | **string** |  |  |

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
| **200** | Update an inbound rule |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

