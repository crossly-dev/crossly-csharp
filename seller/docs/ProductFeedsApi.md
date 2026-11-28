# net.crossly.Api.ProductFeedsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductFeed**](ProductFeedsApi.md#createproductfeed) | **POST** /v1/product-feeds | Create a hosted product feed in the store for a channel. Returns its secret URL.
[**CreateProductFeedCopy**](ProductFeedsApi.md#createproductfeedcopy) | **POST** /v1/product-feeds/{id}/copy | Copy the feed’s settings to other stores as new feeds, each with its own URL.
[**CreateProductFeedRefresh**](ProductFeedsApi.md#createproductfeedrefresh) | **POST** /v1/product-feeds/{id}/refresh | Drop a scheduled feed’s stored copy so the next fetch builds it fresh.
[**CreateProductFeedRevokePrevious**](ProductFeedsApi.md#createproductfeedrevokeprevious) | **POST** /v1/product-feeds/{id}/revoke-previous | End a rotation’s grace window now: the previous URL stops answering.
[**CreateProductFeedRotate**](ProductFeedsApi.md#createproductfeedrotate) | **POST** /v1/product-feeds/{id}/rotate | Give the feed a new secret URL. The old URL keeps answering for graceHours (default: the feed’s setting; 0 &#x3D; stops at once).
[**DeleteProductFeed**](ProductFeedsApi.md#deleteproductfeed) | **DELETE** /v1/product-feeds/{id} | Delete a feed. Its URL stops answering immediately.
[**DeleteProductFeedItem**](ProductFeedsApi.md#deleteproductfeeditem) | **DELETE** /v1/product-feeds/{id}/items/{listingId} | Remove one listing’s override from this feed.
[**GetProductFeed**](ProductFeedsApi.md#getproductfeed) | **GET** /v1/product-feeds/{id} | One feed: its settings, URLs, store and domain, and when it was last fetched and by whom.
[**GetProductFeedFetch**](ProductFeedsApi.md#getproductfeedfetch) | **GET** /v1/product-feeds/{id}/fetches | Who fetched the feed and when (90 days): the channel, status, served from copy or live, item count, size.
[**GetProductFeedIssue**](ProductFeedsApi.md#getproductfeedissue) | **GET** /v1/product-feeds/{id}/issues | The feed’s flagged items one page at a time, by issue code and severity. Pass nextCursor back as after.
[**GetProductFeedItem**](ProductFeedsApi.md#getproductfeeditem) | **GET** /v1/product-feeds/{id}/items | The feed’s per-item overrides (title, GTIN, category, custom labels… for this feed only).
[**GetProductFeedPreview**](ProductFeedsApi.md#getproductfeedpreview) | **GET** /v1/product-feeds/{id}/preview | A page of the feed exactly as the channel reads it: every column per item, and the raw document text.
[**GetProductFeedReport**](ProductFeedsApi.md#getproductfeedreport) | **GET** /v1/product-feeds/{id}/report | Validate a feed: counts per issue, items with errors (held back) and warnings (sent, limited reach), sample items, store domain and currency.
[**ListProductFeeds**](ProductFeedsApi.md#listproductfeeds) | **GET** /v1/product-feeds | List the store’s hosted product feeds (Google, Meta, TikTok, Pinterest, Bing, Snapchat, RSS/Atom, JSON, CSV) with their URLs and last-fetch stats.
[**UpdateProductFeed**](ProductFeedsApi.md#updateproductfeed) | **PATCH** /v1/product-feeds/{id} | Edit a feed: name, format, on/paused, which listings (filters), field mapping, currency and region, images, UTM, refresh schedule.
[**UpdateProductFeedItem**](ProductFeedsApi.md#updateproductfeeditem) | **PUT** /v1/product-feeds/{id}/items/{listingId} | Set one listing’s override in this feed (the listing itself is unchanged). All fields empty removes it.


<a name="createproductfeed"></a>
# **CreateProductFeed**
> ListProductFeedsItem CreateProductFeed (CreateProductFeedRequest createProductFeedRequest)

Create a hosted product feed in the store for a channel. Returns its secret URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var createProductFeedRequest = new CreateProductFeedRequest(); // CreateProductFeedRequest | 

            try
            {
                // Create a hosted product feed in the store for a channel. Returns its secret URL.
                ListProductFeedsItem result = apiInstance.CreateProductFeed(createProductFeedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.CreateProductFeed: " + e.Message );
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
 **createProductFeedRequest** | **CreateProductFeedRequest**|  | 

### Return type

**ListProductFeedsItem**

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

<a name="createproductfeedcopy"></a>
# **CreateProductFeedCopy**
> CreateProductFeedCopyResponse CreateProductFeedCopy (Guid id, CreateProductFeedCopyRequest createProductFeedCopyRequest)

Copy the feed’s settings to other stores as new feeds, each with its own URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductFeedCopyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var createProductFeedCopyRequest = new CreateProductFeedCopyRequest(); // CreateProductFeedCopyRequest | 

            try
            {
                // Copy the feed’s settings to other stores as new feeds, each with its own URL.
                CreateProductFeedCopyResponse result = apiInstance.CreateProductFeedCopy(id, createProductFeedCopyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.CreateProductFeedCopy: " + e.Message );
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
 **createProductFeedCopyRequest** | **CreateProductFeedCopyRequest**|  | 

### Return type

**CreateProductFeedCopyResponse**

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

<a name="createproductfeedrefresh"></a>
# **CreateProductFeedRefresh**
> ListProductFeedsItem CreateProductFeedRefresh (Guid id)

Drop a scheduled feed’s stored copy so the next fetch builds it fresh.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductFeedRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Drop a scheduled feed’s stored copy so the next fetch builds it fresh.
                ListProductFeedsItem result = apiInstance.CreateProductFeedRefresh(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.CreateProductFeedRefresh: " + e.Message );
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

**ListProductFeedsItem**

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

<a name="createproductfeedrevokeprevious"></a>
# **CreateProductFeedRevokePrevious**
> ListProductFeedsItem CreateProductFeedRevokePrevious (Guid id)

End a rotation’s grace window now: the previous URL stops answering.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductFeedRevokePreviousExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // End a rotation’s grace window now: the previous URL stops answering.
                ListProductFeedsItem result = apiInstance.CreateProductFeedRevokePrevious(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.CreateProductFeedRevokePrevious: " + e.Message );
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

**ListProductFeedsItem**

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

<a name="createproductfeedrotate"></a>
# **CreateProductFeedRotate**
> ListProductFeedsItem CreateProductFeedRotate (Guid id, CreateProductFeedRotateRequest createProductFeedRotateRequest = null)

Give the feed a new secret URL. The old URL keeps answering for graceHours (default: the feed’s setting; 0 = stops at once).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductFeedRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var createProductFeedRotateRequest = new CreateProductFeedRotateRequest(); // CreateProductFeedRotateRequest |  (optional) 

            try
            {
                // Give the feed a new secret URL. The old URL keeps answering for graceHours (default: the feed’s setting; 0 = stops at once).
                ListProductFeedsItem result = apiInstance.CreateProductFeedRotate(id, createProductFeedRotateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.CreateProductFeedRotate: " + e.Message );
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
 **createProductFeedRotateRequest** | **CreateProductFeedRotateRequest**|  | [optional] 

### Return type

**ListProductFeedsItem**

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

<a name="deleteproductfeed"></a>
# **DeleteProductFeed**
> OkResponse DeleteProductFeed (Guid id)

Delete a feed. Its URL stops answering immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteProductFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a feed. Its URL stops answering immediately.
                OkResponse result = apiInstance.DeleteProductFeed(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.DeleteProductFeed: " + e.Message );
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

**OkResponse**

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

<a name="deleteproductfeeditem"></a>
# **DeleteProductFeedItem**
> OkResponse DeleteProductFeedItem (Guid id, Guid listingId)

Remove one listing’s override from this feed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteProductFeedItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var listingId = "listingId_example";  // Guid | 

            try
            {
                // Remove one listing’s override from this feed.
                OkResponse result = apiInstance.DeleteProductFeedItem(id, listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.DeleteProductFeedItem: " + e.Message );
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
 **listingId** | **Guid**|  | 

### Return type

**OkResponse**

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

<a name="getproductfeed"></a>
# **GetProductFeed**
> GetProductFeedResponse GetProductFeed (Guid id)

One feed: its settings, URLs, store and domain, and when it was last fetched and by whom.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One feed: its settings, URLs, store and domain, and when it was last fetched and by whom.
                GetProductFeedResponse result = apiInstance.GetProductFeed(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeed: " + e.Message );
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

**GetProductFeedResponse**

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

<a name="getproductfeedfetch"></a>
# **GetProductFeedFetch**
> GetProductFeedFetchResponse GetProductFeedFetch (Guid id, DateTime? before = null, int? limit = null)

Who fetched the feed and when (90 days): the channel, status, served from copy or live, item count, size.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedFetchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Who fetched the feed and when (90 days): the channel, status, served from copy or live, item count, size.
                GetProductFeedFetchResponse result = apiInstance.GetProductFeedFetch(id, before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeedFetch: " + e.Message );
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
 **before** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**GetProductFeedFetchResponse**

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

<a name="getproductfeedissue"></a>
# **GetProductFeedIssue**
> GetProductFeedIssueResponse GetProductFeedIssue (Guid id, string code = null, string severity = null, Guid? after = null, int? limit = null)

The feed’s flagged items one page at a time, by issue code and severity. Pass nextCursor back as after.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var code = "code_example";  // string |  (optional) 
            var severity = "error";  // string |  (optional) 
            var after = "after_example";  // Guid? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // The feed’s flagged items one page at a time, by issue code and severity. Pass nextCursor back as after.
                GetProductFeedIssueResponse result = apiInstance.GetProductFeedIssue(id, code, severity, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeedIssue: " + e.Message );
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
 **code** | **string**|  | [optional] 
 **severity** | **string**|  | [optional] 
 **after** | **Guid?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**GetProductFeedIssueResponse**

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

<a name="getproductfeeditem"></a>
# **GetProductFeedItem**
> GetProductFeedItemResponse GetProductFeedItem (Guid id)

The feed’s per-item overrides (title, GTIN, category, custom labels… for this feed only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // The feed’s per-item overrides (title, GTIN, category, custom labels… for this feed only).
                GetProductFeedItemResponse result = apiInstance.GetProductFeedItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeedItem: " + e.Message );
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

**GetProductFeedItemResponse**

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

<a name="getproductfeedpreview"></a>
# **GetProductFeedPreview**
> GetProductFeedPreviewResponse GetProductFeedPreview (Guid id, string format = null, Guid? after = null, int? limit = null)

A page of the feed exactly as the channel reads it: every column per item, and the raw document text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var format = "xml";  // string |  (optional) 
            var after = "after_example";  // Guid? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // A page of the feed exactly as the channel reads it: every column per item, and the raw document text.
                GetProductFeedPreviewResponse result = apiInstance.GetProductFeedPreview(id, format, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeedPreview: " + e.Message );
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
 **format** | **string**|  | [optional] 
 **after** | **Guid?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**GetProductFeedPreviewResponse**

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

<a name="getproductfeedreport"></a>
# **GetProductFeedReport**
> GetProductFeedReportResponse GetProductFeedReport (Guid id)

Validate a feed: counts per issue, items with errors (held back) and warnings (sent, limited reach), sample items, store domain and currency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductFeedReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Validate a feed: counts per issue, items with errors (held back) and warnings (sent, limited reach), sample items, store domain and currency.
                GetProductFeedReportResponse result = apiInstance.GetProductFeedReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.GetProductFeedReport: " + e.Message );
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

**GetProductFeedReportResponse**

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

<a name="listproductfeeds"></a>
# **ListProductFeeds**
> ListProductFeedsResponse ListProductFeeds ()

List the store’s hosted product feeds (Google, Meta, TikTok, Pinterest, Bing, Snapchat, RSS/Atom, JSON, CSV) with their URLs and last-fetch stats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProductFeedsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);

            try
            {
                // List the store’s hosted product feeds (Google, Meta, TikTok, Pinterest, Bing, Snapchat, RSS/Atom, JSON, CSV) with their URLs and last-fetch stats.
                ListProductFeedsResponse result = apiInstance.ListProductFeeds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.ListProductFeeds: " + e.Message );
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

**ListProductFeedsResponse**

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

<a name="updateproductfeed"></a>
# **UpdateProductFeed**
> ListProductFeedsItem UpdateProductFeed (Guid id, UpdateProductFeedRequest updateProductFeedRequest)

Edit a feed: name, format, on/paused, which listings (filters), field mapping, currency and region, images, UTM, refresh schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateProductFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var updateProductFeedRequest = new UpdateProductFeedRequest(); // UpdateProductFeedRequest | 

            try
            {
                // Edit a feed: name, format, on/paused, which listings (filters), field mapping, currency and region, images, UTM, refresh schedule.
                ListProductFeedsItem result = apiInstance.UpdateProductFeed(id, updateProductFeedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.UpdateProductFeed: " + e.Message );
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
 **updateProductFeedRequest** | **UpdateProductFeedRequest**|  | 

### Return type

**ListProductFeedsItem**

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

<a name="updateproductfeeditem"></a>
# **UpdateProductFeedItem**
> UpdateProductFeedItemResponse UpdateProductFeedItem (Guid id, Guid listingId, UpdateProductFeedItemRequest updateProductFeedItemRequest)

Set one listing’s override in this feed (the listing itself is unchanged). All fields empty removes it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateProductFeedItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductFeedsApi(config);
            var id = "id_example";  // Guid | 
            var listingId = "listingId_example";  // Guid | 
            var updateProductFeedItemRequest = new UpdateProductFeedItemRequest(); // UpdateProductFeedItemRequest | 

            try
            {
                // Set one listing’s override in this feed (the listing itself is unchanged). All fields empty removes it.
                UpdateProductFeedItemResponse result = apiInstance.UpdateProductFeedItem(id, listingId, updateProductFeedItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFeedsApi.UpdateProductFeedItem: " + e.Message );
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
 **listingId** | **Guid**|  | 
 **updateProductFeedItemRequest** | **UpdateProductFeedItemRequest**|  | 

### Return type

**UpdateProductFeedItemResponse**

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

