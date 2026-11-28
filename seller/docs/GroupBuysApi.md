# net.crossly.Api.GroupBuysApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroupBuy**](GroupBuysApi.md#creategroupbuy) | **POST** /v1/group-buys | Run a group buy on a listing with stock: price tiers by committed quantity, a goal and minimum to proceed, a per-buyer max, a deadline, authorize-now or pay-now-refund-the-difference, a goal-miss policy (cancel, proceed, extend once), visibility, placement and share copy. The original body (tiers by buyer count, minBuyers, days) is still accepted.
[**CreateGroupBuyCancel**](GroupBuysApi.md#creategroupbuycancel) | **POST** /v1/group-buys/{id}/cancel | Cancel a group buy: every hold is released and every charge refunded.
[**CreateGroupBuyClose**](GroupBuysApi.md#creategroupbuyclose) | **POST** /v1/group-buys/{id}/close | Close a group buy now: every buyer pays the price reached (the minimum and goal-miss policy still apply).
[**CreateGroupBuyExtend**](GroupBuysApi.md#creategroupbuyextend) | **POST** /v1/group-buys/{id}/extend | Move the deadline later by N days (authorize-now pools run at most 6 days, pay-now pools 30).
[**CreateGroupBuyMessage**](GroupBuysApi.md#creategroupbuymessage) | **POST** /v1/group-buys/{id}/message | Send a notification to every buyer committed to the group buy.
[**GetGroupBuy**](GroupBuysApi.md#getgroupbuy) | **GET** /v1/group-buys/{id} | One group buy: progress towards each tier, committed buyers (masked), time left, revenue at the current tier and the activity feed.
[**GetGroupBuyParticipantsCsv**](GroupBuysApi.md#getgroupbuyparticipantscsv) | **GET** /v1/group-buys/{id}/participants.csv | Every participant of a group buy as CSV: quantity, status, amounts and ship-to.
[**ListGroupBuys**](GroupBuysApi.md#listgroupbuys) | **GET** /v1/group-buys | Your group buys, open ones first: tiers, buyers joined, the price reached and when it ends.
[**UpdateGroupBuy**](GroupBuysApi.md#updategroupbuy) | **PATCH** /v1/group-buys/{id} | Edit a group buy. Copy, visibility, placement and the per-buyer max change any time; tiers, goal, minimum, payment mode and goal-miss policy only before anyone commits.


<a name="creategroupbuy"></a>
# **CreateGroupBuy**
> CreateBreakResponse CreateGroupBuy (CreateGroupBuyRequest createGroupBuyRequest)

Run a group buy on a listing with stock: price tiers by committed quantity, a goal and minimum to proceed, a per-buyer max, a deadline, authorize-now or pay-now-refund-the-difference, a goal-miss policy (cancel, proceed, extend once), visibility, placement and share copy. The original body (tiers by buyer count, minBuyers, days) is still accepted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGroupBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var createGroupBuyRequest = new CreateGroupBuyRequest(); // CreateGroupBuyRequest | 

            try
            {
                // Run a group buy on a listing with stock: price tiers by committed quantity, a goal and minimum to proceed, a per-buyer max, a deadline, authorize-now or pay-now-refund-the-difference, a goal-miss policy (cancel, proceed, extend once), visibility, placement and share copy. The original body (tiers by buyer count, minBuyers, days) is still accepted.
                CreateBreakResponse result = apiInstance.CreateGroupBuy(createGroupBuyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.CreateGroupBuy: " + e.Message );
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
 **createGroupBuyRequest** | **CreateGroupBuyRequest**|  | 

### Return type

**CreateBreakResponse**

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

<a name="creategroupbuycancel"></a>
# **CreateGroupBuyCancel**
> CreateGroupBuyCancelResponse CreateGroupBuyCancel (string id)

Cancel a group buy: every hold is released and every charge refunded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGroupBuyCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a group buy: every hold is released and every charge refunded.
                CreateGroupBuyCancelResponse result = apiInstance.CreateGroupBuyCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.CreateGroupBuyCancel: " + e.Message );
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

**CreateGroupBuyCancelResponse**

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

<a name="creategroupbuyclose"></a>
# **CreateGroupBuyClose**
> CreateGroupBuyCloseResponse CreateGroupBuyClose (string id)

Close a group buy now: every buyer pays the price reached (the minimum and goal-miss policy still apply).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGroupBuyCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Close a group buy now: every buyer pays the price reached (the minimum and goal-miss policy still apply).
                CreateGroupBuyCloseResponse result = apiInstance.CreateGroupBuyClose(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.CreateGroupBuyClose: " + e.Message );
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

**CreateGroupBuyCloseResponse**

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

<a name="creategroupbuyextend"></a>
# **CreateGroupBuyExtend**
> CreateGroupBuyExtendResponse CreateGroupBuyExtend (string id, CreateGroupBuyExtendRequest createGroupBuyExtendRequest = null)

Move the deadline later by N days (authorize-now pools run at most 6 days, pay-now pools 30).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGroupBuyExtendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 
            var createGroupBuyExtendRequest = new CreateGroupBuyExtendRequest(); // CreateGroupBuyExtendRequest |  (optional) 

            try
            {
                // Move the deadline later by N days (authorize-now pools run at most 6 days, pay-now pools 30).
                CreateGroupBuyExtendResponse result = apiInstance.CreateGroupBuyExtend(id, createGroupBuyExtendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.CreateGroupBuyExtend: " + e.Message );
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
 **createGroupBuyExtendRequest** | **CreateGroupBuyExtendRequest**|  | [optional] 

### Return type

**CreateGroupBuyExtendResponse**

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

<a name="creategroupbuymessage"></a>
# **CreateGroupBuyMessage**
> CreateGroupBuyMessageResponse CreateGroupBuyMessage (string id, CreateGroupBuyMessageRequest createGroupBuyMessageRequest = null)

Send a notification to every buyer committed to the group buy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGroupBuyMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 
            var createGroupBuyMessageRequest = new CreateGroupBuyMessageRequest(); // CreateGroupBuyMessageRequest |  (optional) 

            try
            {
                // Send a notification to every buyer committed to the group buy.
                CreateGroupBuyMessageResponse result = apiInstance.CreateGroupBuyMessage(id, createGroupBuyMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.CreateGroupBuyMessage: " + e.Message );
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
 **createGroupBuyMessageRequest** | **CreateGroupBuyMessageRequest**|  | [optional] 

### Return type

**CreateGroupBuyMessageResponse**

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

<a name="getgroupbuy"></a>
# **GetGroupBuy**
> GetGroupBuyResponse GetGroupBuy (string id)

One group buy: progress towards each tier, committed buyers (masked), time left, revenue at the current tier and the activity feed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGroupBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One group buy: progress towards each tier, committed buyers (masked), time left, revenue at the current tier and the activity feed.
                GetGroupBuyResponse result = apiInstance.GetGroupBuy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.GetGroupBuy: " + e.Message );
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

**GetGroupBuyResponse**

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

<a name="getgroupbuyparticipantscsv"></a>
# **GetGroupBuyParticipantsCsv**
> string GetGroupBuyParticipantsCsv (string id)

Every participant of a group buy as CSV: quantity, status, amounts and ship-to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGroupBuyParticipantsCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Every participant of a group buy as CSV: quantity, status, amounts and ship-to.
                string result = apiInstance.GetGroupBuyParticipantsCsv(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.GetGroupBuyParticipantsCsv: " + e.Message );
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

**string**

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

<a name="listgroupbuys"></a>
# **ListGroupBuys**
> ListGroupBuysResponse ListGroupBuys ()

Your group buys, open ones first: tiers, buyers joined, the price reached and when it ends.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGroupBuysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);

            try
            {
                // Your group buys, open ones first: tiers, buyers joined, the price reached and when it ends.
                ListGroupBuysResponse result = apiInstance.ListGroupBuys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.ListGroupBuys: " + e.Message );
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

**ListGroupBuysResponse**

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

<a name="updategroupbuy"></a>
# **UpdateGroupBuy**
> UpdateGroupBuyResponse UpdateGroupBuy (string id, UpdateGroupBuyRequest updateGroupBuyRequest = null)

Edit a group buy. Copy, visibility, placement and the per-buyer max change any time; tiers, goal, minimum, payment mode and goal-miss policy only before anyone commits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateGroupBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupBuysApi(config);
            var id = "id_example";  // string | 
            var updateGroupBuyRequest = new UpdateGroupBuyRequest(); // UpdateGroupBuyRequest |  (optional) 

            try
            {
                // Edit a group buy. Copy, visibility, placement and the per-buyer max change any time; tiers, goal, minimum, payment mode and goal-miss policy only before anyone commits.
                UpdateGroupBuyResponse result = apiInstance.UpdateGroupBuy(id, updateGroupBuyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupBuysApi.UpdateGroupBuy: " + e.Message );
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
 **updateGroupBuyRequest** | **UpdateGroupBuyRequest**|  | [optional] 

### Return type

**UpdateGroupBuyResponse**

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

