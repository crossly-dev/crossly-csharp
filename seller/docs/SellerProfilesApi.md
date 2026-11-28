# net.crossly.Api.SellerProfilesApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProfileInsight**](SellerProfilesApi.md#getprofileinsight) | **GET** /v1/profile/insights/{timeframe} | Your seller profile&#39;s views, share actions and link previews (Discord, X, iMessage…) per day.
[**GetSellerShareTarget**](SellerProfilesApi.md#getsellersharetarget) | **GET** /v1/sellers/{handle}/share-targets | What a public seller profile can be shared as: its shown stats and earned milestones, each with its share page and card image.


<a name="getprofileinsight"></a>
# **GetProfileInsight**
> GetProfileInsightResponse GetProfileInsight (string timeframe)

Your seller profile's views, share actions and link previews (Discord, X, iMessage…) per day.

Counts only: no viewer, IP or referrer is stored. Bots and your own visits are not views; a link preview is counted by the app that fetched the card. `topRefs` names the profile (\"\"), a stat page (`stat:<key>:<timeframe>`) or a milestone page (`milestone:<key>`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProfileInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SellerProfilesApi(config);
            var timeframe = "7d";  // string | 

            try
            {
                // Your seller profile's views, share actions and link previews (Discord, X, iMessage…) per day.
                GetProfileInsightResponse result = apiInstance.GetProfileInsight(timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SellerProfilesApi.GetProfileInsight: " + e.Message );
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
 **timeframe** | **string**|  | 

### Return type

**GetProfileInsightResponse**

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

<a name="getsellersharetarget"></a>
# **GetSellerShareTarget**
> GetSellerShareTargetResponse GetSellerShareTarget (string handle)

What a public seller profile can be shared as: its shown stats and earned milestones, each with its share page and card image.

Only what the seller shows publicly. `text` is the public display text (\"$100k+\"); a rounded or tier stat never carries its real number. `verified` is true only when the number comes from sales Crossly recorded through connected marketplaces. A private or unknown profile is a 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSellerShareTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SellerProfilesApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // What a public seller profile can be shared as: its shown stats and earned milestones, each with its share page and card image.
                GetSellerShareTargetResponse result = apiInstance.GetSellerShareTarget(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SellerProfilesApi.GetSellerShareTarget: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetSellerShareTargetResponse**

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

