# net.crossly.Api.SourceSyncApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSourceSyncSync**](SourceSyncApi.md#createsourcesyncsync) | **POST** /v1/source-sync/{platform}/sync | Reconcile a store now: re-read its whole catalogue and apply every change (runs in the background; 202).
[**GetSourceSyncLocation**](SourceSyncApi.md#getsourcesynclocation) | **GET** /v1/source-sync/{platform}/locations | POS only (lightspeed_r, lightspeed_x, square): the shops/outlets/locations on the account and which one Crossly syncs stock and sales with.
[**ListSourceSync**](SourceSyncApi.md#listsourcesync) | **GET** /v1/source-sync | List source-capable stores with their continuous-sync settings and status.
[**ListSourceSyncEvents**](SourceSyncApi.md#listsourcesyncevents) | **GET** /v1/source-sync/events | Recent source-sync activity: each webhook delivery and reconcile change, with its outcome.
[**UpdateSourceSync**](SourceSyncApi.md#updatesourcesync) | **PATCH** /v1/source-sync/{platform} | Update a store&#39;s source-sync settings: on/off, source-owned fields, deletion handling, auto-export channels.
[**UpdateSourceSyncLocation**](SourceSyncApi.md#updatesourcesynclocation) | **PUT** /v1/source-sync/{platform}/location | POS only: choose the shop (R-Series) / outlet (X-Series) / Square location whose stock and sales Crossly syncs. Must be one GET .../locations lists.


<a name="createsourcesyncsync"></a>
# **CreateSourceSyncSync**
> CreateSourceSyncSyncResponse CreateSourceSyncSync (string platform)

Reconcile a store now: re-read its whole catalogue and apply every change (runs in the background; 202).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSourceSyncSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);
            var platform = "shopify";  // string | 

            try
            {
                // Reconcile a store now: re-read its whole catalogue and apply every change (runs in the background; 202).
                CreateSourceSyncSyncResponse result = apiInstance.CreateSourceSyncSync(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.CreateSourceSyncSync: " + e.Message );
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
 **platform** | **string**|  | 

### Return type

**CreateSourceSyncSyncResponse**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getsourcesynclocation"></a>
# **GetSourceSyncLocation**
> GetSourceSyncLocationResponse GetSourceSyncLocation (string platform)

POS only (lightspeed_r, lightspeed_x, square): the shops/outlets/locations on the account and which one Crossly syncs stock and sales with.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSourceSyncLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);
            var platform = "lightspeed_r";  // string | 

            try
            {
                // POS only (lightspeed_r, lightspeed_x, square): the shops/outlets/locations on the account and which one Crossly syncs stock and sales with.
                GetSourceSyncLocationResponse result = apiInstance.GetSourceSyncLocation(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.GetSourceSyncLocation: " + e.Message );
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
 **platform** | **string**|  | 

### Return type

**GetSourceSyncLocationResponse**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listsourcesync"></a>
# **ListSourceSync**
> ListSourceSyncResponse ListSourceSync ()

List source-capable stores with their continuous-sync settings and status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSourceSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);

            try
            {
                // List source-capable stores with their continuous-sync settings and status.
                ListSourceSyncResponse result = apiInstance.ListSourceSync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.ListSourceSync: " + e.Message );
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

**ListSourceSyncResponse**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listsourcesyncevents"></a>
# **ListSourceSyncEvents**
> ListSourceSyncEventsResponse ListSourceSyncEvents (string platform = null, int? limit = null)

Recent source-sync activity: each webhook delivery and reconcile change, with its outcome.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSourceSyncEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);
            var platform = "shopify";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Recent source-sync activity: each webhook delivery and reconcile change, with its outcome.
                ListSourceSyncEventsResponse result = apiInstance.ListSourceSyncEvents(platform, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.ListSourceSyncEvents: " + e.Message );
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
 **limit** | **int?**|  | [optional] 

### Return type

**ListSourceSyncEventsResponse**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatesourcesync"></a>
# **UpdateSourceSync**
> ListSourceSyncItem UpdateSourceSync (string platform, UpdateSourceSyncRequest updateSourceSyncRequest = null)

Update a store's source-sync settings: on/off, source-owned fields, deletion handling, auto-export channels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSourceSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);
            var platform = "shopify";  // string | 
            var updateSourceSyncRequest = new UpdateSourceSyncRequest(); // UpdateSourceSyncRequest |  (optional) 

            try
            {
                // Update a store's source-sync settings: on/off, source-owned fields, deletion handling, auto-export channels.
                ListSourceSyncItem result = apiInstance.UpdateSourceSync(platform, updateSourceSyncRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.UpdateSourceSync: " + e.Message );
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
 **platform** | **string**|  | 
 **updateSourceSyncRequest** | **UpdateSourceSyncRequest**|  | [optional] 

### Return type

**ListSourceSyncItem**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="updatesourcesynclocation"></a>
# **UpdateSourceSyncLocation**
> GetSourceSyncLocationResponse UpdateSourceSyncLocation (string platform, UpdateSourceSyncLocationRequest updateSourceSyncLocationRequest)

POS only: choose the shop (R-Series) / outlet (X-Series) / Square location whose stock and sales Crossly syncs. Must be one GET .../locations lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSourceSyncLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourceSyncApi(config);
            var platform = "lightspeed_r";  // string | 
            var updateSourceSyncLocationRequest = new UpdateSourceSyncLocationRequest(); // UpdateSourceSyncLocationRequest | 

            try
            {
                // POS only: choose the shop (R-Series) / outlet (X-Series) / Square location whose stock and sales Crossly syncs. Must be one GET .../locations lists.
                GetSourceSyncLocationResponse result = apiInstance.UpdateSourceSyncLocation(platform, updateSourceSyncLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourceSyncApi.UpdateSourceSyncLocation: " + e.Message );
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
 **platform** | **string**|  | 
 **updateSourceSyncLocationRequest** | **UpdateSourceSyncLocationRequest**|  | 

### Return type

**GetSourceSyncLocationResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

