# net.crossly.Api.GroupBuysApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroupBuy**](GroupBuysApi.md#creategroupbuy) | **POST** /v1/group-buys | Run a group buy on a listing with stock: price tiers by buyer count, a minimum, up to 6 days. Below the minimum nobody pays.


<a name="creategroupbuy"></a>
# **CreateGroupBuy**
> CreateBreakResponse CreateGroupBuy ()

Run a group buy on a listing with stock: price tiers by buyer count, a minimum, up to 6 days. Below the minimum nobody pays.

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

            try
            {
                // Run a group buy on a listing with stock: price tiers by buyer count, a minimum, up to 6 days. Below the minimum nobody pays.
                CreateBreakResponse result = apiInstance.CreateGroupBuy();
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
This endpoint does not need any parameter.

### Return type

**CreateBreakResponse**

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

