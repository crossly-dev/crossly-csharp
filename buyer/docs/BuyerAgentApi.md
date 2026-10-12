# net.crossly.buyer.Api.BuyerAgentApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuyerAgentSession**](BuyerAgentApi.md#createbuyeragentsession) | **POST** /v1/buyer/agent/sessions | Start a shopping agent conversation.
[**CreateBuyerAgentSessionAct**](BuyerAgentApi.md#createbuyeragentsessionact) | **POST** /v1/buyer/agent/sessions/{id}/act | Act on an option: save, cart, alert, registry, price (real-sales check), offer (prepare / confirm), or buy (quote — complete with POST /api/v1/buyer/checkout). Needs the action’s own scope too.
[**CreateBuyerAgentSessionReact**](BuyerAgentApi.md#createbuyeragentsessionreact) | **POST** /v1/buyer/agent/sessions/{id}/react | Like or dislike an option; the next search leans toward likes and drops dislikes.
[**CreateBuyerAgentSessionTurn**](BuyerAgentApi.md#createbuyeragentsessionturn) | **POST** /v1/buyer/agent/sessions/{id}/turns | Say something to the agent: what you want, a critique of the options (\&quot;cheaper\&quot;, \&quot;more like #2\&quot;), or send a photo (imageBase64) to find things like it. Returns its reply and the new numbered options.
[**DeleteBuyerAgentSession**](BuyerAgentApi.md#deletebuyeragentsession) | **DELETE** /v1/buyer/agent/sessions/{id} | Delete a conversation.
[**GetBuyerAgentSession**](BuyerAgentApi.md#getbuyeragentsession) | **GET** /v1/buyer/agent/sessions/{id} | A conversation: its brief and turns, with each turn’s options re-read live.
[**ListBuyerAgentSessions**](BuyerAgentApi.md#listbuyeragentsessions) | **GET** /v1/buyer/agent/sessions | Your shopping agent conversations, newest first.


<a name="createbuyeragentsession"></a>
# **CreateBuyerAgentSession**
> CreateBuyerAgentSessionResponse CreateBuyerAgentSession ()

Start a shopping agent conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAgentSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);

            try
            {
                // Start a shopping agent conversation.
                CreateBuyerAgentSessionResponse result = apiInstance.CreateBuyerAgentSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.CreateBuyerAgentSession: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**CreateBuyerAgentSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyeragentsessionact"></a>
# **CreateBuyerAgentSessionAct**
> CreateBuyerAgentSessionActResponse CreateBuyerAgentSessionAct (string id)

Act on an option: save, cart, alert, registry, price (real-sales check), offer (prepare / confirm), or buy (quote — complete with POST /api/v1/buyer/checkout). Needs the action’s own scope too.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAgentSessionActExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Act on an option: save, cart, alert, registry, price (real-sales check), offer (prepare / confirm), or buy (quote — complete with POST /api/v1/buyer/checkout). Needs the action’s own scope too.
                CreateBuyerAgentSessionActResponse result = apiInstance.CreateBuyerAgentSessionAct(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.CreateBuyerAgentSessionAct: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**CreateBuyerAgentSessionActResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyeragentsessionreact"></a>
# **CreateBuyerAgentSessionReact**
> DeleteBuyerAgentSessionResponse CreateBuyerAgentSessionReact (string id)

Like or dislike an option; the next search leans toward likes and drops dislikes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAgentSessionReactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Like or dislike an option; the next search leans toward likes and drops dislikes.
                DeleteBuyerAgentSessionResponse result = apiInstance.CreateBuyerAgentSessionReact(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.CreateBuyerAgentSessionReact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**DeleteBuyerAgentSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyeragentsessionturn"></a>
# **CreateBuyerAgentSessionTurn**
> CreateBuyerAgentSessionTurnResponse CreateBuyerAgentSessionTurn (string id)

Say something to the agent: what you want, a critique of the options (\"cheaper\", \"more like #2\"), or send a photo (imageBase64) to find things like it. Returns its reply and the new numbered options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAgentSessionTurnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Say something to the agent: what you want, a critique of the options (\"cheaper\", \"more like #2\"), or send a photo (imageBase64) to find things like it. Returns its reply and the new numbered options.
                CreateBuyerAgentSessionTurnResponse result = apiInstance.CreateBuyerAgentSessionTurn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.CreateBuyerAgentSessionTurn: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**CreateBuyerAgentSessionTurnResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyeragentsession"></a>
# **DeleteBuyerAgentSession**
> DeleteBuyerAgentSessionResponse DeleteBuyerAgentSession (string id)

Delete a conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerAgentSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a conversation.
                DeleteBuyerAgentSessionResponse result = apiInstance.DeleteBuyerAgentSession(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.DeleteBuyerAgentSession: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**DeleteBuyerAgentSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyeragentsession"></a>
# **GetBuyerAgentSession**
> GetBuyerAgentSessionResponse GetBuyerAgentSession (string id)

A conversation: its brief and turns, with each turn’s options re-read live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerAgentSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A conversation: its brief and turns, with each turn’s options re-read live.
                GetBuyerAgentSessionResponse result = apiInstance.GetBuyerAgentSession(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.GetBuyerAgentSession: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**GetBuyerAgentSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyeragentsessions"></a>
# **ListBuyerAgentSessions**
> ListBuyerAgentSessionsResponse ListBuyerAgentSessions ()

Your shopping agent conversations, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerAgentSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerAgentApi(config);

            try
            {
                // Your shopping agent conversations, newest first.
                ListBuyerAgentSessionsResponse result = apiInstance.ListBuyerAgentSessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerAgentApi.ListBuyerAgentSessions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListBuyerAgentSessionsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

