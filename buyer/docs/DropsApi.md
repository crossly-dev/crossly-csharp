# net.crossly.buyer.Api.DropsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuyerDropJoin**](DropsApi.md#createbuyerdropjoin) | **POST** /v1/buyer/drops/{id}/join | Join a drop&#39;s line while it is open: one entry per account, the same odds as joining in the world. Repeating it returns the same entry.
[**DeleteBuyerDropJoin**](DropsApi.md#deletebuyerdropjoin) | **DELETE** /v1/buyer/drops/{id}/join | Leave a drop&#39;s line before the draw.
[**GetBuyerDropMe**](DropsApi.md#getbuyerdropme) | **GET** /v1/buyer/drops/{id}/me | Your entry in a drop: in line or not, your draw rank and outcome, and the checkout path while your 15-minute hold is live.


<a name="createbuyerdropjoin"></a>
# **CreateBuyerDropJoin**
> CreateBuyerDropJoinResponse CreateBuyerDropJoin (Guid id)

Join a drop's line while it is open: one entry per account, the same odds as joining in the world. Repeating it returns the same entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerDropJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Join a drop's line while it is open: one entry per account, the same odds as joining in the world. Repeating it returns the same entry.
                CreateBuyerDropJoinResponse result = apiInstance.CreateBuyerDropJoin(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DropsApi.CreateBuyerDropJoin: " + e.Message );
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

**CreateBuyerDropJoinResponse**

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

<a name="deletebuyerdropjoin"></a>
# **DeleteBuyerDropJoin**
> DeleteBuyerDropJoinResponse DeleteBuyerDropJoin (Guid id)

Leave a drop's line before the draw.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerDropJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Leave a drop's line before the draw.
                DeleteBuyerDropJoinResponse result = apiInstance.DeleteBuyerDropJoin(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DropsApi.DeleteBuyerDropJoin: " + e.Message );
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

**DeleteBuyerDropJoinResponse**

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

<a name="getbuyerdropme"></a>
# **GetBuyerDropMe**
> GetBuyerDropMeResponse GetBuyerDropMe (Guid id)

Your entry in a drop: in line or not, your draw rank and outcome, and the checkout path while your 15-minute hold is live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerDropMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Your entry in a drop: in line or not, your draw rank and outcome, and the checkout path while your 15-minute hold is live.
                GetBuyerDropMeResponse result = apiInstance.GetBuyerDropMe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DropsApi.GetBuyerDropMe: " + e.Message );
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

**GetBuyerDropMeResponse**

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

