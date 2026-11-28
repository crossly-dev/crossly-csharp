# net.crossly.Api.BulkBatchesApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBulkBatch**](BulkBatchesApi.md#createbulkbatch) | **POST** /v1/bulk-batches | Open an empty capture batch for a preset.
[**CreateBulkBatchIdentify**](BulkBatchesApi.md#createbulkbatchidentify) | **POST** /v1/bulk-batches/{id}/identify | Identify items: match to Crossly Market, Magic List, or auto (by preset). Runs in the background.
[**CreateBulkBatchItem**](BulkBatchesApi.md#createbulkbatchitem) | **POST** /v1/bulk-batches/{id}/items | Append one item (every photo of it, primary first).
[**CreateBulkBatchItemBulk**](BulkBatchesApi.md#createbulkbatchitembulk) | **POST** /v1/bulk-batches/{id}/items/bulk | Set price/quantity/condition/status on many items.
[**CreateBulkBatchPublish**](BulkBatchesApi.md#createbulkbatchpublish) | **POST** /v1/bulk-batches/{id}/publish | Publish reviewed items: drafts only (default) or live on destinations; adds quantity to an existing matching listing.
[**DeleteBulkBatch**](BulkBatchesApi.md#deletebulkbatch) | **DELETE** /v1/bulk-batches/{id} | Discard a batch (listings it produced stay).
[**DeleteBulkBatchItem**](BulkBatchesApi.md#deletebulkbatchitem) | **DELETE** /v1/bulk-batches/items/{id} | Remove one unpublished item.
[**GetBulkBatch**](BulkBatchesApi.md#getbulkbatch) | **GET** /v1/bulk-batches/{id} | Get one bulk batch with its items (capture order) and matched catalog rows.
[**ListBulkBatches**](BulkBatchesApi.md#listbulkbatches) | **GET** /v1/bulk-batches | List recent bulk list batches, newest first.
[**UpdateBulkBatch**](BulkBatchesApi.md#updatebulkbatch) | **PATCH** /v1/bulk-batches/{id} | Change batch settings, or set stage \&quot;identify\&quot; when capture is done.
[**UpdateBulkBatchItem**](BulkBatchesApi.md#updatebulkbatchitem) | **PATCH** /v1/bulk-batches/items/{id} | Correct one item (match, title, price, photos…).


<a name="createbulkbatch"></a>
# **CreateBulkBatch**
> ListBulkBatchesItem CreateBulkBatch ()

Open an empty capture batch for a preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBulkBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);

            try
            {
                // Open an empty capture batch for a preset.
                ListBulkBatchesItem result = apiInstance.CreateBulkBatch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.CreateBulkBatch: " + e.Message );
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

**ListBulkBatchesItem**

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

<a name="createbulkbatchidentify"></a>
# **CreateBulkBatchIdentify**
> CreateBulkBatchIdentifyResponse CreateBulkBatchIdentify (Guid id, CreateBulkBatchIdentifyRequest createBulkBatchIdentifyRequest = null)

Identify items: match to Crossly Market, Magic List, or auto (by preset). Runs in the background.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBulkBatchIdentifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var createBulkBatchIdentifyRequest = new CreateBulkBatchIdentifyRequest(); // CreateBulkBatchIdentifyRequest |  (optional) 

            try
            {
                // Identify items: match to Crossly Market, Magic List, or auto (by preset). Runs in the background.
                CreateBulkBatchIdentifyResponse result = apiInstance.CreateBulkBatchIdentify(id, createBulkBatchIdentifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.CreateBulkBatchIdentify: " + e.Message );
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
 **createBulkBatchIdentifyRequest** | **CreateBulkBatchIdentifyRequest**|  | [optional] 

### Return type

**CreateBulkBatchIdentifyResponse**

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

<a name="createbulkbatchitem"></a>
# **CreateBulkBatchItem**
> CreateBulkBatchItemResponse CreateBulkBatchItem (Guid id, CreateBulkBatchItemRequest createBulkBatchItemRequest)

Append one item (every photo of it, primary first).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBulkBatchItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var createBulkBatchItemRequest = new CreateBulkBatchItemRequest(); // CreateBulkBatchItemRequest | 

            try
            {
                // Append one item (every photo of it, primary first).
                CreateBulkBatchItemResponse result = apiInstance.CreateBulkBatchItem(id, createBulkBatchItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.CreateBulkBatchItem: " + e.Message );
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
 **createBulkBatchItemRequest** | **CreateBulkBatchItemRequest**|  | 

### Return type

**CreateBulkBatchItemResponse**

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

<a name="createbulkbatchitembulk"></a>
# **CreateBulkBatchItemBulk**
> UpdatedResponse CreateBulkBatchItemBulk (Guid id, CreateBulkBatchItemBulkRequest createBulkBatchItemBulkRequest)

Set price/quantity/condition/status on many items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBulkBatchItemBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var createBulkBatchItemBulkRequest = new CreateBulkBatchItemBulkRequest(); // CreateBulkBatchItemBulkRequest | 

            try
            {
                // Set price/quantity/condition/status on many items.
                UpdatedResponse result = apiInstance.CreateBulkBatchItemBulk(id, createBulkBatchItemBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.CreateBulkBatchItemBulk: " + e.Message );
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
 **createBulkBatchItemBulkRequest** | **CreateBulkBatchItemBulkRequest**|  | 

### Return type

**UpdatedResponse**

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

<a name="createbulkbatchpublish"></a>
# **CreateBulkBatchPublish**
> CreateBulkBatchPublishResponse CreateBulkBatchPublish (Guid id, CreateBulkBatchPublishRequest createBulkBatchPublishRequest = null)

Publish reviewed items: drafts only (default) or live on destinations; adds quantity to an existing matching listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBulkBatchPublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var createBulkBatchPublishRequest = new CreateBulkBatchPublishRequest(); // CreateBulkBatchPublishRequest |  (optional) 

            try
            {
                // Publish reviewed items: drafts only (default) or live on destinations; adds quantity to an existing matching listing.
                CreateBulkBatchPublishResponse result = apiInstance.CreateBulkBatchPublish(id, createBulkBatchPublishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.CreateBulkBatchPublish: " + e.Message );
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
 **createBulkBatchPublishRequest** | **CreateBulkBatchPublishRequest**|  | [optional] 

### Return type

**CreateBulkBatchPublishResponse**

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

<a name="deletebulkbatch"></a>
# **DeleteBulkBatch**
> OkResponse DeleteBulkBatch (Guid id)

Discard a batch (listings it produced stay).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteBulkBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Discard a batch (listings it produced stay).
                OkResponse result = apiInstance.DeleteBulkBatch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.DeleteBulkBatch: " + e.Message );
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

<a name="deletebulkbatchitem"></a>
# **DeleteBulkBatchItem**
> OkResponse DeleteBulkBatchItem (Guid id)

Remove one unpublished item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteBulkBatchItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Remove one unpublished item.
                OkResponse result = apiInstance.DeleteBulkBatchItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.DeleteBulkBatchItem: " + e.Message );
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

<a name="getbulkbatch"></a>
# **GetBulkBatch**
> GetBulkBatchResponse GetBulkBatch (Guid id)

Get one bulk batch with its items (capture order) and matched catalog rows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBulkBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one bulk batch with its items (capture order) and matched catalog rows.
                GetBulkBatchResponse result = apiInstance.GetBulkBatch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.GetBulkBatch: " + e.Message );
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

**GetBulkBatchResponse**

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

<a name="listbulkbatches"></a>
# **ListBulkBatches**
> ListBulkBatchesResponse ListBulkBatches (int? limit = null)

List recent bulk list batches, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBulkBatchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List recent bulk list batches, newest first.
                ListBulkBatchesResponse result = apiInstance.ListBulkBatches(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.ListBulkBatches: " + e.Message );
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
 **limit** | **int?**|  | [optional] 

### Return type

**ListBulkBatchesResponse**

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

<a name="updatebulkbatch"></a>
# **UpdateBulkBatch**
> ListBulkBatchesItem UpdateBulkBatch (Guid id, UpdateBulkBatchRequest updateBulkBatchRequest)

Change batch settings, or set stage \"identify\" when capture is done.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBulkBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var updateBulkBatchRequest = new UpdateBulkBatchRequest(); // UpdateBulkBatchRequest | 

            try
            {
                // Change batch settings, or set stage \"identify\" when capture is done.
                ListBulkBatchesItem result = apiInstance.UpdateBulkBatch(id, updateBulkBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.UpdateBulkBatch: " + e.Message );
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
 **updateBulkBatchRequest** | **UpdateBulkBatchRequest**|  | 

### Return type

**ListBulkBatchesItem**

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

<a name="updatebulkbatchitem"></a>
# **UpdateBulkBatchItem**
> CreateBulkBatchItemResponse UpdateBulkBatchItem (Guid id, UpdateBulkBatchItemRequest updateBulkBatchItemRequest)

Correct one item (match, title, price, photos…).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBulkBatchItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BulkBatchesApi(config);
            var id = "id_example";  // Guid | 
            var updateBulkBatchItemRequest = new UpdateBulkBatchItemRequest(); // UpdateBulkBatchItemRequest | 

            try
            {
                // Correct one item (match, title, price, photos…).
                CreateBulkBatchItemResponse result = apiInstance.UpdateBulkBatchItem(id, updateBulkBatchItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkBatchesApi.UpdateBulkBatchItem: " + e.Message );
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
 **updateBulkBatchItemRequest** | **UpdateBulkBatchItemRequest**|  | 

### Return type

**CreateBulkBatchItemResponse**

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

