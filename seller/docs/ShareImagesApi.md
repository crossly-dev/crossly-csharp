# net.crossly.Api.ShareImagesApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetShareImageDrop**](ShareImagesApi.md#getshareimagedrop) | **GET** /v1/share-images/drops/{id} | The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).
[**GetShareImageEvent**](ShareImagesApi.md#getshareimageevent) | **GET** /v1/share-images/events/{slug} | The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).
[**GetShareImageGroupBuy**](ShareImagesApi.md#getshareimagegroupbuy) | **GET** /v1/share-images/group-buys/{id} | The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).


<a name="getshareimagedrop"></a>
# **GetShareImageDrop**
> ShareImageResponse GetShareImageDrop (string id)

The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetShareImageDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShareImagesApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).
                ShareImageResponse result = apiInstance.GetShareImageDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShareImagesApi.GetShareImageDrop: " + e.Message );
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

**ShareImageResponse**

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

<a name="getshareimageevent"></a>
# **GetShareImageEvent**
> ShareImageResponse GetShareImageEvent (string slug)

The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetShareImageEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShareImagesApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).
                ShareImageResponse result = apiInstance.GetShareImageEvent(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShareImagesApi.GetShareImageEvent: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ShareImageResponse**

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

<a name="getshareimagegroupbuy"></a>
# **GetShareImageGroupBuy**
> ShareImageResponse GetShareImageGroupBuy (string id)

The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetShareImageGroupBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShareImagesApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The share card (og:image) of one of yours: { kind, imageUrl, pageUrl, bucket, title, description }. The image changes only when its state bucket does (progress in tenths, tier reached, time left, sold out).
                ShareImageResponse result = apiInstance.GetShareImageGroupBuy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShareImagesApi.GetShareImageGroupBuy: " + e.Message );
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

**ShareImageResponse**

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

