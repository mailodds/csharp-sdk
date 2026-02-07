# MailOdds.Api.ValidationPoliciesApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPolicyRule**](ValidationPoliciesApi.md#addpolicyrule) | **POST** /v1/policies/{policy_id}/rules | Add rule to policy |
| [**CreatePolicy**](ValidationPoliciesApi.md#createpolicy) | **POST** /v1/policies | Create policy |
| [**CreatePolicyFromPreset**](ValidationPoliciesApi.md#createpolicyfrompreset) | **POST** /v1/policies/from-preset | Create policy from preset |
| [**DeletePolicy**](ValidationPoliciesApi.md#deletepolicy) | **DELETE** /v1/policies/{policy_id} | Delete policy |
| [**DeletePolicyRule**](ValidationPoliciesApi.md#deletepolicyrule) | **DELETE** /v1/policies/{policy_id}/rules/{rule_id} | Delete rule |
| [**GetPolicy**](ValidationPoliciesApi.md#getpolicy) | **GET** /v1/policies/{policy_id} | Get policy |
| [**GetPolicyPresets**](ValidationPoliciesApi.md#getpolicypresets) | **GET** /v1/policies/presets | Get policy presets |
| [**ListPolicies**](ValidationPoliciesApi.md#listpolicies) | **GET** /v1/policies | List policies |
| [**TestPolicy**](ValidationPoliciesApi.md#testpolicy) | **POST** /v1/policies/test | Test policy evaluation |
| [**UpdatePolicy**](ValidationPoliciesApi.md#updatepolicy) | **PUT** /v1/policies/{policy_id} | Update policy |

<a id="addpolicyrule"></a>
# **AddPolicyRule**
> AddPolicyRule201Response AddPolicyRule (int policyId, PolicyRule policyRule)

Add rule to policy

Add a new rule to an existing policy.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **int** |  |  |
| **policyRule** | [**PolicyRule**](PolicyRule.md) |  |  |

### Return type

[**AddPolicyRule201Response**](AddPolicyRule201Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Rule added |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Rule limit exceeded |  -  |
| **404** | Policy not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpolicy"></a>
# **CreatePolicy**
> PolicyResponse CreatePolicy (CreatePolicyRequest createPolicyRequest)

Create policy

Create a new validation policy with rules.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPolicyRequest** | [**CreatePolicyRequest**](CreatePolicyRequest.md) |  |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Policy created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **403** | Plan limit exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpolicyfrompreset"></a>
# **CreatePolicyFromPreset**
> PolicyResponse CreatePolicyFromPreset (CreatePolicyFromPresetRequest createPolicyFromPresetRequest)

Create policy from preset

Create a policy using a preset template.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPolicyFromPresetRequest** | [**CreatePolicyFromPresetRequest**](CreatePolicyFromPresetRequest.md) |  |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Policy created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletepolicy"></a>
# **DeletePolicy**
> DeletePolicy200Response DeletePolicy (int policyId)

Delete policy

Delete a policy and all its rules.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **int** |  |  |

### Return type

[**DeletePolicy200Response**](DeletePolicy200Response.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Policy deleted |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Policy not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletepolicyrule"></a>
# **DeletePolicyRule**
> DeletePolicyRule200Response DeletePolicyRule (int policyId, int ruleId)

Delete rule

Delete a rule from a policy.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **int** |  |  |
| **ruleId** | **int** |  |  |

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
| **200** | Rule deleted |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Policy or rule not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpolicy"></a>
# **GetPolicy**
> PolicyResponse GetPolicy (int policyId)

Get policy

Get a single policy with its rules.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **int** |  |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Policy details |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Policy not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpolicypresets"></a>
# **GetPolicyPresets**
> PolicyPresetsResponse GetPolicyPresets ()

Get policy presets

Get available preset templates for quick policy creation.


### Parameters
This endpoint does not need any parameter.
### Return type

[**PolicyPresetsResponse**](PolicyPresetsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available presets |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpolicies"></a>
# **ListPolicies**
> PolicyListResponse ListPolicies (bool includeRules = null)

List policies

List all validation policies for your account. Includes plan limits.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeRules** | **bool** | Include full rules in response | [optional] [default to false] |

### Return type

[**PolicyListResponse**](PolicyListResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of policies |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="testpolicy"></a>
# **TestPolicy**
> PolicyTestResponse TestPolicy (TestPolicyRequest testPolicyRequest)

Test policy evaluation

Test how a policy would evaluate a validation result without affecting production.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testPolicyRequest** | [**TestPolicyRequest**](TestPolicyRequest.md) |  |  |

### Return type

[**PolicyTestResponse**](PolicyTestResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Test result |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Policy not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepolicy"></a>
# **UpdatePolicy**
> PolicyResponse UpdatePolicy (int policyId, UpdatePolicyRequest updatePolicyRequest)

Update policy

Update a policy's settings (name, enabled, default).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **int** |  |  |
| **updatePolicyRequest** | [**UpdatePolicyRequest**](UpdatePolicyRequest.md) |  |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Policy updated |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |
| **404** | Policy not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

