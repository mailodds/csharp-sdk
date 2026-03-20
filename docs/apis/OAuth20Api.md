# MailOdds.Api.OAuth20Api

All URIs are relative to *https://api.mailodds.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateToken**](OAuth20Api.md#createtoken) | **POST** /oauth/token | Create token |
| [**GetJwks**](OAuth20Api.md#getjwks) | **GET** /.well-known/jwks.json | Get JSON Web Key Set |
| [**IntrospectToken**](OAuth20Api.md#introspecttoken) | **POST** /oauth/introspect | Introspect token |
| [**OauthServerMetadata**](OAuth20Api.md#oauthservermetadata) | **GET** /.well-known/oauth-authorization-server | OAuth server metadata |
| [**RevokeToken**](OAuth20Api.md#revoketoken) | **POST** /oauth/revoke | Revoke token |

<a id="createtoken"></a>
# **CreateToken**
> CreateToken200Response CreateToken (string grantType, string code = null, string redirectUri = null, string clientId = null, string clientSecret = null, string refreshToken = null, string scope = null, string codeVerifier = null)

Create token

Exchange an authorization code, client credentials, or refresh token for access and refresh tokens. Authenticate via client_secret_post or client_secret_basic.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string** |  |  |
| **code** | **string** | Authorization code (for authorization_code grant) | [optional]  |
| **redirectUri** | **string** | Must match the original redirect_uri | [optional]  |
| **clientId** | **string** |  | [optional]  |
| **clientSecret** | **string** |  | [optional]  |
| **refreshToken** | **string** | Refresh token (for refresh_token grant) | [optional]  |
| **scope** | **string** | Space-separated scopes | [optional]  |
| **codeVerifier** | **string** | PKCE code verifier | [optional]  |

### Return type

[**CreateToken200Response**](CreateToken200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token response |  -  |
| **400** | Invalid request or grant |  -  |
| **401** | Invalid client credentials |  -  |
| **429** | Rate limited (20 req/min per client) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getjwks"></a>
# **GetJwks**
> JwksResponse GetJwks ()

Get JSON Web Key Set

Public key set for verifying JWT access tokens issued by this server.


### Parameters
This endpoint does not need any parameter.
### Return type

[**JwksResponse**](JwksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JWKS response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="introspecttoken"></a>
# **IntrospectToken**
> IntrospectToken200Response IntrospectToken (string token, string tokenTypeHint = null, string clientId = null, string clientSecret = null)

Introspect token

Introspect a token to determine its active state and metadata (RFC 7662). Requires client authentication.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Token to introspect |  |
| **tokenTypeHint** | **string** |  | [optional]  |
| **clientId** | **string** |  | [optional]  |
| **clientSecret** | **string** |  | [optional]  |

### Return type

[**IntrospectToken200Response**](IntrospectToken200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Introspection result |  -  |
| **401** | Invalid client credentials |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="oauthservermetadata"></a>
# **OauthServerMetadata**
> OAuthServerMetadata OauthServerMetadata ()

OAuth server metadata

OAuth 2.0 Authorization Server Metadata (RFC 8414). Returns server configuration including supported grant types, scopes, and endpoints.


### Parameters
This endpoint does not need any parameter.
### Return type

[**OAuthServerMetadata**](OAuthServerMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Server metadata |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="revoketoken"></a>
# **RevokeToken**
> void RevokeToken (string token, string tokenTypeHint = null, string clientId = null, string clientSecret = null)

Revoke token

Revoke an access or refresh token (RFC 7009). Requires client authentication. Always returns 200 per spec to prevent token scanning.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Token to revoke |  |
| **tokenTypeHint** | **string** |  | [optional]  |
| **clientId** | **string** |  | [optional]  |
| **clientSecret** | **string** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token revoked (or not found, per RFC 7009) |  -  |
| **401** | Invalid client credentials |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

