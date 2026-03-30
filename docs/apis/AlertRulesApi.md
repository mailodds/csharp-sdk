# MailOdds.Api.AlertRulesApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAlertRule**](AlertRulesApi.md#createalertrule) | **POST** /v1/alert-rules | Create alert rule |
| [**DeleteAlertRule**](AlertRulesApi.md#deletealertrule) | **DELETE** /v1/alert-rules/{rule_id} | Delete alert rule |
| [**GetAlertRule**](AlertRulesApi.md#getalertrule) | **GET** /v1/alert-rules/{rule_id} | Get alert rule |
| [**ListAlertRules**](AlertRulesApi.md#listalertrules) | **GET** /v1/alert-rules | List alert rules |
| [**UpdateAlertRule**](AlertRulesApi.md#updatealertrule) | **PUT** /v1/alert-rules/{rule_id} | Update alert rule |

<a id="createalertrule"></a>
# **CreateAlertRule**
> CreateAlertRule201Response CreateAlertRule (CreateAlertRuleRequest createAlertRuleRequest)

Create alert rule

Create a new metric threshold alert rule. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAlertRuleRequest** | [**CreateAlertRuleRequest**](CreateAlertRuleRequest.md) |  |  |

### Return type

[**CreateAlertRule201Response**](CreateAlertRule201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Alert rule created |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletealertrule"></a>
# **DeleteAlertRule**
> DeletePolicyRule200Response DeleteAlertRule (string ruleId)

Delete alert rule

Delete an alert rule. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |

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
| **200** | Alert rule deleted |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getalertrule"></a>
# **GetAlertRule**
> CreateAlertRule201Response GetAlertRule (string ruleId)

Get alert rule

Get a single alert rule by ID. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |

### Return type

[**CreateAlertRule201Response**](CreateAlertRule201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Alert rule details |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listalertrules"></a>
# **ListAlertRules**
> ListAlertRules200Response ListAlertRules ()

List alert rules

List all configured alert rules. Requires Growth+ plan.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListAlertRules200Response**](ListAlertRules200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of alert rules |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatealertrule"></a>
# **UpdateAlertRule**
> CreateAlertRule201Response UpdateAlertRule (string ruleId, UpdateAlertRuleRequest updateAlertRuleRequest)

Update alert rule

Update an existing alert rule. Requires Growth+ plan.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **updateAlertRuleRequest** | [**UpdateAlertRuleRequest**](UpdateAlertRuleRequest.md) |  |  |

### Return type

[**CreateAlertRule201Response**](CreateAlertRule201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Alert rule updated |  -  |
| **403** | Forbidden - Insufficient permissions or no credits |  -  |
| **404** | Resource not found |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

