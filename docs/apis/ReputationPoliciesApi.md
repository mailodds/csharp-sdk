# MailOdds.Api.ReputationPoliciesApi

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReputationPolicy**](ReputationPoliciesApi.md#createreputationpolicy) | **POST** /v1/reputation-policies | Create a reputation policy |
| [**CreateReputationPolicyFromPreset**](ReputationPoliciesApi.md#createreputationpolicyfrompreset) | **POST** /v1/reputation-policies/from-preset | Create a reputation policy from preset |
| [**DeleteReputationPolicy**](ReputationPoliciesApi.md#deletereputationpolicy) | **DELETE** /v1/reputation-policies/{policy_id} | Delete a reputation policy |
| [**GetReputationPolicy**](ReputationPoliciesApi.md#getreputationpolicy) | **GET** /v1/reputation-policies/{policy_id} | Get a reputation policy |
| [**GetReputationPolicyStatus**](ReputationPoliciesApi.md#getreputationpolicystatus) | **GET** /v1/reputation-policies/{policy_id}/status | Get reputation policy status |
| [**ListReputationPolicies**](ReputationPoliciesApi.md#listreputationpolicies) | **GET** /v1/reputation-policies | List reputation policies |
| [**TestReputationPolicy**](ReputationPoliciesApi.md#testreputationpolicy) | **POST** /v1/reputation-policies/{policy_id}/test | Test a reputation policy |
| [**UpdateReputationPolicy**](ReputationPoliciesApi.md#updatereputationpolicy) | **PUT** /v1/reputation-policies/{policy_id} | Update a reputation policy |

<a id="createreputationpolicy"></a>
# **CreateReputationPolicy**
> void CreateReputationPolicy ()

Create a reputation policy

Create a new reputation policy with custom rules and thresholds.


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
| **201** | Create a reputation policy |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createreputationpolicyfrompreset"></a>
# **CreateReputationPolicyFromPreset**
> void CreateReputationPolicyFromPreset ()

Create a reputation policy from preset

Create a reputation policy from a predefined preset template.


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
| **201** | Create a reputation policy from preset |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereputationpolicy"></a>
# **DeleteReputationPolicy**
> void DeleteReputationPolicy (string policyId)

Delete a reputation policy

Soft-delete a reputation policy.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** |  |  |

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
| **200** | Delete a reputation policy |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreputationpolicy"></a>
# **GetReputationPolicy**
> void GetReputationPolicy (string policyId)

Get a reputation policy

Retrieve a single reputation policy by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** |  |  |

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
| **200** | Get a reputation policy |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreputationpolicystatus"></a>
# **GetReputationPolicyStatus**
> void GetReputationPolicyStatus (string policyId)

Get reputation policy status

Evaluate a policy and return per-domain status results.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** |  |  |

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
| **200** | Get reputation policy status |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listreputationpolicies"></a>
# **ListReputationPolicies**
> void ListReputationPolicies ()

List reputation policies

List all reputation policies for the account.


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
| **200** | List reputation policies |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="testreputationpolicy"></a>
# **TestReputationPolicy**
> void TestReputationPolicy (string policyId)

Test a reputation policy

Dry-run evaluation of a reputation policy without applying actions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** |  |  |

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
| **200** | Test a reputation policy |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatereputationpolicy"></a>
# **UpdateReputationPolicy**
> void UpdateReputationPolicy (string policyId)

Update a reputation policy

Update an existing reputation policy.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** |  |  |

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
| **200** | Update a reputation policy |  -  |
| **401** | Unauthorized - Invalid or missing API key |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

