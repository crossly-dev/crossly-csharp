# net.crossly.Api.ActivityApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActionLog**](ActivityApi.md#getactionlog) | **GET** /v1/action-log/{id} | Get one action-log event by id (ownership-checked).
[**GetActionLogFacet**](ActivityApi.md#getactionlogfacet) | **GET** /v1/action-log/facets | Distinct platforms / actions / categories present in the caller&#39;s action log (last 90 days) — powers filter dropdowns before you query.
[**ListActionLog**](ActivityApi.md#listactionlog) | **GET** /v1/action-log | List action-log events — the semantic \&quot;what happened\&quot; record of every user + platform action. Filter by platform / action / category / status / source / target, and a since/until created_at window.
[**ListActionLogCalls**](ActivityApi.md#listactionlogcalls) | **GET** /v1/action-log/{id}/calls | The outbound platform HTTP calls under an event (oldest first) — url, method, status, latency, redacted request/response bodies, proxy + recipe/hash. Answers \&quot;what was sent / what went wrong\&quot;.


<a name="getactionlog"></a>
# **GetActionLog**
> GetActionLogResponse GetActionLog (Guid id)

Get one action-log event by id (ownership-checked).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one action-log event by id (ownership-checked).
                GetActionLogResponse result = apiInstance.GetActionLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLog: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

[**GetActionLogResponse**](GetActionLogResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactionlogfacet"></a>
# **GetActionLogFacet**
> GetActionLogFacetResponse GetActionLogFacet ()

Distinct platforms / actions / categories present in the caller's action log (last 90 days) — powers filter dropdowns before you query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogFacetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // Distinct platforms / actions / categories present in the caller's action log (last 90 days) — powers filter dropdowns before you query.
                GetActionLogFacetResponse result = apiInstance.GetActionLogFacet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLogFacet: " + e.Message );
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

[**GetActionLogFacetResponse**](GetActionLogFacetResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactionlog"></a>
# **ListActionLog**
> V1List ListActionLog (string platform = null, string action = null, string category = null, string status = null, string source = null, string targetType = null, string targetId = null, string since = null, string until = null, int? limit = null, int? offset = null)

List action-log events — the semantic \"what happened\" record of every user + platform action. Filter by platform / action / category / status / source / target, and a since/until created_at window.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListActionLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var platform = "platform_example";  // string |  (optional) 
            var action = "action_example";  // string |  (optional) 
            var category = "category_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var source = "source_example";  // string |  (optional) 
            var targetType = "targetType_example";  // string |  (optional) 
            var targetId = "targetId_example";  // string |  (optional) 
            var since = "since_example";  // string | ISO lower bound (inclusive) on created_at. (optional) 
            var until = "until_example";  // string | ISO upper bound (exclusive) on created_at. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var offset = 0;  // int? |  (optional)  (default to 0)

            try
            {
                // List action-log events — the semantic \"what happened\" record of every user + platform action. Filter by platform / action / category / status / source / target, and a since/until created_at window.
                V1List result = apiInstance.ListActionLog(platform, action, category, status, source, targetType, targetId, since, until, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListActionLog: " + e.Message );
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
 **platform** | **string**|  | [optional] 
 **action** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **source** | **string**|  | [optional] 
 **targetType** | **string**|  | [optional] 
 **targetId** | **string**|  | [optional] 
 **since** | **string**| ISO lower bound (inclusive) on created_at. | [optional] 
 **until** | **string**| ISO upper bound (exclusive) on created_at. | [optional] 
 **limit** | **int?**|  | [optional] [default to 50]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

[**V1List**](V1List.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactionlogcalls"></a>
# **ListActionLogCalls**
> V1List ListActionLogCalls (Guid id)

The outbound platform HTTP calls under an event (oldest first) — url, method, status, latency, redacted request/response bodies, proxy + recipe/hash. Answers \"what was sent / what went wrong\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListActionLogCallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // The outbound platform HTTP calls under an event (oldest first) — url, method, status, latency, redacted request/response bodies, proxy + recipe/hash. Answers \"what was sent / what went wrong\".
                V1List result = apiInstance.ListActionLogCalls(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListActionLogCalls: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

[**V1List**](V1List.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

