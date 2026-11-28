# net.crossly.Api.ToolboxApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateToolboxAsset**](ToolboxApi.md#createtoolboxasset) | **POST** /v1/toolbox/assets | Publish an asset (place nodes). Scanned (lint, text, credits, uploads) then reviewed. Free by default; paid needs Pro and a verified identity.
[**CreateToolboxAssetPurchase**](ToolboxApi.md#createtoolboxassetpurchase) | **POST** /v1/toolbox/assets/{assetId}/purchase | Open a Crossly checkout for a paid asset. Nothing is charged here: a person pays at checkoutUrl. The author earns 80% of net; the licence is use in your own experiences.
[**CreateToolboxAssetRetire**](ToolboxApi.md#createtoolboxassetretire) | **POST** /v1/toolbox/assets/{assetId}/retire | Take an asset off the store for good. Licences already sold keep working.
[**CreateToolboxAssetUse**](ToolboxApi.md#createtoolboxassetuse) | **POST** /v1/toolbox/assets/{assetId}/use | Get the asset&#39;s nodes stamped with its id for a place you can edit; insert:true also inserts them into the place&#39;s live session. Paid assets need the experience owner&#39;s licence.
[**CreateToolboxAssetVersion**](ToolboxApi.md#createtoolboxassetversion) | **POST** /v1/toolbox/assets/{assetId}/versions | A new version (reviewed); the live one keeps serving until it is approved.
[**CreateToolboxPurchaseRefund**](ToolboxApi.md#createtoolboxpurchaserefund) | **POST** /v1/toolbox/purchases/{purchaseId}/refund | Refund a licence within 14 days while no published version of yours uses the asset. Ends the licence; the author&#39;s share is reversed.
[**DeleteToolboxAssetRatingMine**](ToolboxApi.md#deletetoolboxassetratingmine) | **DELETE** /v1/toolbox/assets/{assetId}/ratings/mine | Remove your rating of an asset.
[**GetToolboxAsset**](ToolboxApi.md#gettoolboxasset) | **GET** /v1/toolbox/assets/{assetId} | One asset: versions, credits (assets it includes), licence, contents, your purchase.
[**GetToolboxAssetRating**](ToolboxApi.md#gettoolboxassetrating) | **GET** /v1/toolbox/assets/{assetId}/ratings | Ratings of an asset: average stars, breakdown, recent reviews, yours, and whether you may rate it.
[**GetToolboxPurchase**](ToolboxApi.md#gettoolboxpurchase) | **GET** /v1/toolbox/purchases/{purchaseId} | A purchase: status, price, tax, refundable until.
[**ListToolboxAssets**](ToolboxApi.md#listtoolboxassets) | **GET** /v1/toolbox/assets | Search the Toolbox: models, scripts, sounds, images, packages. Free and paid; &#x60;owned&#x60; says whether you may insert it now.
[**ListToolboxLibrary**](ToolboxApi.md#listtoolboxlibrary) | **GET** /v1/toolbox/library | Assets you may insert: licences you bought, your own, free ones you used.
[**ListToolboxMine**](ToolboxApi.md#listtoolboxmine) | **GET** /v1/toolbox/mine | Your published assets: review state, reviewer note, what each earned you.
[**ListToolboxSales**](ToolboxApi.md#listtoolboxsales) | **GET** /v1/toolbox/sales | Your Toolbox sales: gross, net, your 80% share after refunds. Never who bought.
[**UpdateToolboxAsset**](ToolboxApi.md#updatetoolboxasset) | **PATCH** /v1/toolbox/assets/{assetId} | Edit name, description, tags, thumbnail or price.
[**UpdateToolboxAssetRatingMine**](ToolboxApi.md#updatetoolboxassetratingmine) | **PUT** /v1/toolbox/assets/{assetId}/ratings/mine | Rate an asset you bought or installed: 1–5 stars and an optional review (1000 characters). Not your own.


<a name="createtoolboxasset"></a>
# **CreateToolboxAsset**
> ToolboxAssetResponse CreateToolboxAsset (CreateToolboxAssetRequest createToolboxAssetRequest = null)

Publish an asset (place nodes). Scanned (lint, text, credits, uploads) then reviewed. Free by default; paid needs Pro and a verified identity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var createToolboxAssetRequest = new CreateToolboxAssetRequest(); // CreateToolboxAssetRequest |  (optional) 

            try
            {
                // Publish an asset (place nodes). Scanned (lint, text, credits, uploads) then reviewed. Free by default; paid needs Pro and a verified identity.
                ToolboxAssetResponse result = apiInstance.CreateToolboxAsset(createToolboxAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxAsset: " + e.Message );
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
 **createToolboxAssetRequest** | **CreateToolboxAssetRequest**|  | [optional] 

### Return type

**ToolboxAssetResponse**

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

<a name="createtoolboxassetpurchase"></a>
# **CreateToolboxAssetPurchase**
> GetToolboxPurchaseResponse CreateToolboxAssetPurchase (string assetId)

Open a Crossly checkout for a paid asset. Nothing is charged here: a person pays at checkoutUrl. The author earns 80% of net; the licence is use in your own experiences.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxAssetPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 

            try
            {
                // Open a Crossly checkout for a paid asset. Nothing is charged here: a person pays at checkoutUrl. The author earns 80% of net; the licence is use in your own experiences.
                GetToolboxPurchaseResponse result = apiInstance.CreateToolboxAssetPurchase(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxAssetPurchase: " + e.Message );
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
 **assetId** | **string**|  | 

### Return type

**GetToolboxPurchaseResponse**

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

<a name="createtoolboxassetretire"></a>
# **CreateToolboxAssetRetire**
> ToolboxAssetResponse CreateToolboxAssetRetire (string assetId)

Take an asset off the store for good. Licences already sold keep working.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxAssetRetireExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 

            try
            {
                // Take an asset off the store for good. Licences already sold keep working.
                ToolboxAssetResponse result = apiInstance.CreateToolboxAssetRetire(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxAssetRetire: " + e.Message );
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
 **assetId** | **string**|  | 

### Return type

**ToolboxAssetResponse**

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

<a name="createtoolboxassetuse"></a>
# **CreateToolboxAssetUse**
> CreateToolboxAssetUseResponse CreateToolboxAssetUse (string assetId, CreateToolboxAssetUseRequest createToolboxAssetUseRequest = null)

Get the asset's nodes stamped with its id for a place you can edit; insert:true also inserts them into the place's live session. Paid assets need the experience owner's licence.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxAssetUseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 
            var createToolboxAssetUseRequest = new CreateToolboxAssetUseRequest(); // CreateToolboxAssetUseRequest |  (optional) 

            try
            {
                // Get the asset's nodes stamped with its id for a place you can edit; insert:true also inserts them into the place's live session. Paid assets need the experience owner's licence.
                CreateToolboxAssetUseResponse result = apiInstance.CreateToolboxAssetUse(assetId, createToolboxAssetUseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxAssetUse: " + e.Message );
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
 **assetId** | **string**|  | 
 **createToolboxAssetUseRequest** | **CreateToolboxAssetUseRequest**|  | [optional] 

### Return type

**CreateToolboxAssetUseResponse**

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

<a name="createtoolboxassetversion"></a>
# **CreateToolboxAssetVersion**
> ToolboxAssetResponse CreateToolboxAssetVersion (string assetId, CreateToolboxAssetVersionRequest createToolboxAssetVersionRequest = null)

A new version (reviewed); the live one keeps serving until it is approved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxAssetVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 
            var createToolboxAssetVersionRequest = new CreateToolboxAssetVersionRequest(); // CreateToolboxAssetVersionRequest |  (optional) 

            try
            {
                // A new version (reviewed); the live one keeps serving until it is approved.
                ToolboxAssetResponse result = apiInstance.CreateToolboxAssetVersion(assetId, createToolboxAssetVersionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxAssetVersion: " + e.Message );
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
 **assetId** | **string**|  | 
 **createToolboxAssetVersionRequest** | **CreateToolboxAssetVersionRequest**|  | [optional] 

### Return type

**ToolboxAssetResponse**

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

<a name="createtoolboxpurchaserefund"></a>
# **CreateToolboxPurchaseRefund**
> CreateWorldMeReceiptRefundResponse CreateToolboxPurchaseRefund (string purchaseId, ReasonRequest2 reasonRequest2 = null)

Refund a licence within 14 days while no published version of yours uses the asset. Ends the licence; the author's share is reversed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateToolboxPurchaseRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var purchaseId = "purchaseId_example";  // string | 
            var reasonRequest2 = new ReasonRequest2(); // ReasonRequest2 |  (optional) 

            try
            {
                // Refund a licence within 14 days while no published version of yours uses the asset. Ends the licence; the author's share is reversed.
                CreateWorldMeReceiptRefundResponse result = apiInstance.CreateToolboxPurchaseRefund(purchaseId, reasonRequest2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.CreateToolboxPurchaseRefund: " + e.Message );
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
 **purchaseId** | **string**|  | 
 **reasonRequest2** | **ReasonRequest2**|  | [optional] 

### Return type

**CreateWorldMeReceiptRefundResponse**

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

<a name="deletetoolboxassetratingmine"></a>
# **DeleteToolboxAssetRatingMine**
> DeleteSpatialSceneGrantResponse DeleteToolboxAssetRatingMine (string assetId)

Remove your rating of an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteToolboxAssetRatingMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 

            try
            {
                // Remove your rating of an asset.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteToolboxAssetRatingMine(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.DeleteToolboxAssetRatingMine: " + e.Message );
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
 **assetId** | **string**|  | 

### Return type

**DeleteSpatialSceneGrantResponse**

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

<a name="gettoolboxasset"></a>
# **GetToolboxAsset**
> GetToolboxAssetResponse GetToolboxAsset (string assetId)

One asset: versions, credits (assets it includes), licence, contents, your purchase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetToolboxAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 

            try
            {
                // One asset: versions, credits (assets it includes), licence, contents, your purchase.
                GetToolboxAssetResponse result = apiInstance.GetToolboxAsset(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.GetToolboxAsset: " + e.Message );
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
 **assetId** | **string**|  | 

### Return type

**GetToolboxAssetResponse**

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

<a name="gettoolboxassetrating"></a>
# **GetToolboxAssetRating**
> GetToolboxAssetRatingResponse GetToolboxAssetRating (string assetId)

Ratings of an asset: average stars, breakdown, recent reviews, yours, and whether you may rate it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetToolboxAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 

            try
            {
                // Ratings of an asset: average stars, breakdown, recent reviews, yours, and whether you may rate it.
                GetToolboxAssetRatingResponse result = apiInstance.GetToolboxAssetRating(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.GetToolboxAssetRating: " + e.Message );
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
 **assetId** | **string**|  | 

### Return type

**GetToolboxAssetRatingResponse**

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

<a name="gettoolboxpurchase"></a>
# **GetToolboxPurchase**
> GetToolboxPurchaseResponse GetToolboxPurchase (string purchaseId)

A purchase: status, price, tax, refundable until.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetToolboxPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var purchaseId = "purchaseId_example";  // string | 

            try
            {
                // A purchase: status, price, tax, refundable until.
                GetToolboxPurchaseResponse result = apiInstance.GetToolboxPurchase(purchaseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.GetToolboxPurchase: " + e.Message );
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
 **purchaseId** | **string**|  | 

### Return type

**GetToolboxPurchaseResponse**

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

<a name="listtoolboxassets"></a>
# **ListToolboxAssets**
> ListToolboxAssetsResponse ListToolboxAssets (string q = null, string kind = null, string price = null, string sort = null, decimal? minRating = null, string cursor = null, decimal? limit = null)

Search the Toolbox: models, scripts, sounds, images, packages. Free and paid; `owned` says whether you may insert it now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListToolboxAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var q = "q_example";  // string |  (optional) 
            var kind = "package";  // string |  (optional) 
            var price = "free";  // string |  (optional) 
            var sort = "price";  // string |  (optional) 
            var minRating = 8.14D;  // decimal? |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Search the Toolbox: models, scripts, sounds, images, packages. Free and paid; `owned` says whether you may insert it now.
                ListToolboxAssetsResponse result = apiInstance.ListToolboxAssets(q, kind, price, sort, minRating, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.ListToolboxAssets: " + e.Message );
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
 **q** | **string**|  | [optional] 
 **kind** | **string**|  | [optional] 
 **price** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **minRating** | **decimal?**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListToolboxAssetsResponse**

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

<a name="listtoolboxlibrary"></a>
# **ListToolboxLibrary**
> ListToolboxLibraryResponse ListToolboxLibrary ()

Assets you may insert: licences you bought, your own, free ones you used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListToolboxLibraryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);

            try
            {
                // Assets you may insert: licences you bought, your own, free ones you used.
                ListToolboxLibraryResponse result = apiInstance.ListToolboxLibrary();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.ListToolboxLibrary: " + e.Message );
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

**ListToolboxLibraryResponse**

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

<a name="listtoolboxmine"></a>
# **ListToolboxMine**
> ListToolboxMineResponse ListToolboxMine ()

Your published assets: review state, reviewer note, what each earned you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListToolboxMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);

            try
            {
                // Your published assets: review state, reviewer note, what each earned you.
                ListToolboxMineResponse result = apiInstance.ListToolboxMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.ListToolboxMine: " + e.Message );
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

**ListToolboxMineResponse**

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

<a name="listtoolboxsales"></a>
# **ListToolboxSales**
> ListToolboxSalesResponse ListToolboxSales (string cursor = null, decimal? limit = null)

Your Toolbox sales: gross, net, your 80% share after refunds. Never who bought.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListToolboxSalesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Your Toolbox sales: gross, net, your 80% share after refunds. Never who bought.
                ListToolboxSalesResponse result = apiInstance.ListToolboxSales(cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.ListToolboxSales: " + e.Message );
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
 **cursor** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListToolboxSalesResponse**

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

<a name="updatetoolboxasset"></a>
# **UpdateToolboxAsset**
> ToolboxAssetResponse UpdateToolboxAsset (string assetId, UpdateToolboxAssetRequest updateToolboxAssetRequest = null)

Edit name, description, tags, thumbnail or price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateToolboxAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 
            var updateToolboxAssetRequest = new UpdateToolboxAssetRequest(); // UpdateToolboxAssetRequest |  (optional) 

            try
            {
                // Edit name, description, tags, thumbnail or price.
                ToolboxAssetResponse result = apiInstance.UpdateToolboxAsset(assetId, updateToolboxAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.UpdateToolboxAsset: " + e.Message );
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
 **assetId** | **string**|  | 
 **updateToolboxAssetRequest** | **UpdateToolboxAssetRequest**|  | [optional] 

### Return type

**ToolboxAssetResponse**

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

<a name="updatetoolboxassetratingmine"></a>
# **UpdateToolboxAssetRatingMine**
> UpdateToolboxAssetRatingMineResponse UpdateToolboxAssetRatingMine (string assetId, UpdateToolboxAssetRatingMineRequest updateToolboxAssetRatingMineRequest = null)

Rate an asset you bought or installed: 1–5 stars and an optional review (1000 characters). Not your own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateToolboxAssetRatingMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolboxApi(config);
            var assetId = "assetId_example";  // string | 
            var updateToolboxAssetRatingMineRequest = new UpdateToolboxAssetRatingMineRequest(); // UpdateToolboxAssetRatingMineRequest |  (optional) 

            try
            {
                // Rate an asset you bought or installed: 1–5 stars and an optional review (1000 characters). Not your own.
                UpdateToolboxAssetRatingMineResponse result = apiInstance.UpdateToolboxAssetRatingMine(assetId, updateToolboxAssetRatingMineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolboxApi.UpdateToolboxAssetRatingMine: " + e.Message );
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
 **assetId** | **string**|  | 
 **updateToolboxAssetRatingMineRequest** | **UpdateToolboxAssetRatingMineRequest**|  | [optional] 

### Return type

**UpdateToolboxAssetRatingMineResponse**

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

