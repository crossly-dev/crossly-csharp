# net.crossly.Api.ProductSetsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductSet**](ProductSetsApi.md#createproductset) | **POST** /v1/product-sets | Create a product set (filters, explicit picks, or both).
[**CreateProductSetBulk**](ProductSetsApi.md#createproductsetbulk) | **POST** /v1/product-sets/{id}/bulk | Run a bulk action (delist / relist / check-status) against the set&#39;s current members.
[**CreateProductSetMember**](ProductSetsApi.md#createproductsetmember) | **POST** /v1/product-sets/{id}/members | Add / exclude / remove explicit picks for a set.
[**DeleteProductSet**](ProductSetsApi.md#deleteproductset) | **DELETE** /v1/product-sets/{id} | Delete a product set (its id is also dropped from any channel exclusion lists).
[**GetProductSet**](ProductSetsApi.md#getproductset) | **GET** /v1/product-sets/{id} | Get one product set (its filters and pick counts).
[**ListProductSetMembers**](ProductSetsApi.md#listproductsetmembers) | **GET** /v1/product-sets/{id}/members | Evaluate a set now and return a page of its member listings.
[**ListProductSets**](ProductSetsApi.md#listproductsets) | **GET** /v1/product-sets | List your saved product sets with their live member counts.
[**UpdateProductSet**](ProductSetsApi.md#updateproductset) | **PATCH** /v1/product-sets/{id} | Update a set: rename, description, or replace its filters.


<a name="createproductset"></a>
# **CreateProductSet**
> ListProductSetsItem CreateProductSet (CreateProductSetRequest createProductSetRequest)

Create a product set (filters, explicit picks, or both).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var createProductSetRequest = new CreateProductSetRequest(); // CreateProductSetRequest | 

            try
            {
                // Create a product set (filters, explicit picks, or both).
                ListProductSetsItem result = apiInstance.CreateProductSet(createProductSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.CreateProductSet: " + e.Message );
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
 **createProductSetRequest** | **CreateProductSetRequest**|  | 

### Return type

**ListProductSetsItem**

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

<a name="createproductsetbulk"></a>
# **CreateProductSetBulk**
> CreateProductSetBulkResponse CreateProductSetBulk (Guid id, CreateProductSetBulkRequest createProductSetBulkRequest)

Run a bulk action (delist / relist / check-status) against the set's current members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductSetBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 
            var createProductSetBulkRequest = new CreateProductSetBulkRequest(); // CreateProductSetBulkRequest | 

            try
            {
                // Run a bulk action (delist / relist / check-status) against the set's current members.
                CreateProductSetBulkResponse result = apiInstance.CreateProductSetBulk(id, createProductSetBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.CreateProductSetBulk: " + e.Message );
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
 **createProductSetBulkRequest** | **CreateProductSetBulkRequest**|  | 

### Return type

**CreateProductSetBulkResponse**

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

<a name="createproductsetmember"></a>
# **CreateProductSetMember**
> ListProductSetsItem CreateProductSetMember (Guid id, CreateProductSetMemberRequest createProductSetMemberRequest)

Add / exclude / remove explicit picks for a set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductSetMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 
            var createProductSetMemberRequest = new CreateProductSetMemberRequest(); // CreateProductSetMemberRequest | 

            try
            {
                // Add / exclude / remove explicit picks for a set.
                ListProductSetsItem result = apiInstance.CreateProductSetMember(id, createProductSetMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.CreateProductSetMember: " + e.Message );
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
 **createProductSetMemberRequest** | **CreateProductSetMemberRequest**|  | 

### Return type

**ListProductSetsItem**

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

<a name="deleteproductset"></a>
# **DeleteProductSet**
> OkResponse DeleteProductSet (Guid id)

Delete a product set (its id is also dropped from any channel exclusion lists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteProductSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a product set (its id is also dropped from any channel exclusion lists).
                OkResponse result = apiInstance.DeleteProductSet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.DeleteProductSet: " + e.Message );
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

<a name="getproductset"></a>
# **GetProductSet**
> ListProductSetsItem GetProductSet (Guid id)

Get one product set (its filters and pick counts).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one product set (its filters and pick counts).
                ListProductSetsItem result = apiInstance.GetProductSet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.GetProductSet: " + e.Message );
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

**ListProductSetsItem**

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

<a name="listproductsetmembers"></a>
# **ListProductSetMembers**
> ListProductSetMembersResponse ListProductSetMembers (Guid id, int? page = null, int? limit = null)

Evaluate a set now and return a page of its member listings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProductSetMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Evaluate a set now and return a page of its member listings.
                ListProductSetMembersResponse result = apiInstance.ListProductSetMembers(id, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.ListProductSetMembers: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListProductSetMembersResponse**

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

<a name="listproductsets"></a>
# **ListProductSets**
> ListProductSetsResponse ListProductSets ()

List your saved product sets with their live member counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProductSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);

            try
            {
                // List your saved product sets with their live member counts.
                ListProductSetsResponse result = apiInstance.ListProductSets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.ListProductSets: " + e.Message );
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

**ListProductSetsResponse**

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

<a name="updateproductset"></a>
# **UpdateProductSet**
> ListProductSetsItem UpdateProductSet (Guid id, UpdateProductSetRequest updateProductSetRequest)

Update a set: rename, description, or replace its filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateProductSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductSetsApi(config);
            var id = "id_example";  // Guid | 
            var updateProductSetRequest = new UpdateProductSetRequest(); // UpdateProductSetRequest | 

            try
            {
                // Update a set: rename, description, or replace its filters.
                ListProductSetsItem result = apiInstance.UpdateProductSet(id, updateProductSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductSetsApi.UpdateProductSet: " + e.Message );
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
 **updateProductSetRequest** | **UpdateProductSetRequest**|  | 

### Return type

**ListProductSetsItem**

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

