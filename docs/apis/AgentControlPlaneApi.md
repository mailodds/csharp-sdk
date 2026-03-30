# MailOdds.Api.AgentControlPlaneApi

All URIs are relative to *https://api.mailodds.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMcpCapabilities**](AgentControlPlaneApi.md#getmcpcapabilities) | **GET** /v1/mcp/capabilities | Get MCP capabilities |

<a id="getmcpcapabilities"></a>
# **GetMcpCapabilities**
> McpCapabilities GetMcpCapabilities ()

Get MCP capabilities

Returns a static capability manifest listing all MCP tools organized by pillar. Used by AI agents for tool discovery and scope-based self-correction.


### Parameters
This endpoint does not need any parameter.
### Return type

[**McpCapabilities**](McpCapabilities.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MCP capability manifest |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

