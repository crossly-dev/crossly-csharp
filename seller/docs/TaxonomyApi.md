# net.crossly.Api.TaxonomyApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTaxonomyCategory**](TaxonomyApi.md#gettaxonomycategory) | **GET** /v1/taxonomy/{platform}/categories | Categories for a platform. Default is top-level; pass &#x60;?parent&#x3D;&lt;categoryId&gt;&#x60; to drill down one level (supported on cookie platforms whose recipe returns flat parent_id-linked rows).
[**GetTaxonomyCategoryAspect**](TaxonomyApi.md#gettaxonomycategoryaspect) | **GET** /v1/taxonomy/{platform}/categories/{id}/aspects | Item-specific aspects (eBay) / properties (Etsy) / hard-coded enums (cookie platforms) for a category.
[**GetTaxonomyCategoryChildren**](TaxonomyApi.md#gettaxonomycategorychildren) | **GET** /v1/taxonomy/{platform}/categories/{id}/children | Direct children of a category node.
[**GetTaxonomyRequiredField**](TaxonomyApi.md#gettaxonomyrequiredfield) | **GET** /v1/taxonomy/{platform}/required-fields | Normalized field schema the seller needs to fill before crossposting to this platform. Combines master fields (title/description/price/condition) with platform-specific overrides.
[**ListTaxonomySuggest**](TaxonomyApi.md#listtaxonomysuggest) | **GET** /v1/taxonomy/{platform}/suggest | Reverse lookup — suggest categories matching a search phrase. eBay-only today.


<a name="gettaxonomycategory"></a>
# **GetTaxonomyCategory**
> GetTaxonomyCategoryResponse GetTaxonomyCategory (string platform, string parent = null)

Categories for a platform. Default is top-level; pass `?parent=<categoryId>` to drill down one level (supported on cookie platforms whose recipe returns flat parent_id-linked rows).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxonomyCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxonomyApi(config);
            var platform = "platform_example";  // string | 
            var parent = "parent_example";  // string |  (optional) 

            try
            {
                // Categories for a platform. Default is top-level; pass `?parent=<categoryId>` to drill down one level (supported on cookie platforms whose recipe returns flat parent_id-linked rows).
                GetTaxonomyCategoryResponse result = apiInstance.GetTaxonomyCategory(platform, parent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxonomyApi.GetTaxonomyCategory: " + e.Message );
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
 **parent** | **string**|  | [optional] 

### Return type

[**GetTaxonomyCategoryResponse**](GetTaxonomyCategoryResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxonomycategoryaspect"></a>
# **GetTaxonomyCategoryAspect**
> GetTaxonomyCategoryAspectResponse GetTaxonomyCategoryAspect (string platform, string id)

Item-specific aspects (eBay) / properties (Etsy) / hard-coded enums (cookie platforms) for a category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxonomyCategoryAspectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxonomyApi(config);
            var platform = "platform_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Item-specific aspects (eBay) / properties (Etsy) / hard-coded enums (cookie platforms) for a category.
                GetTaxonomyCategoryAspectResponse result = apiInstance.GetTaxonomyCategoryAspect(platform, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxonomyApi.GetTaxonomyCategoryAspect: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**GetTaxonomyCategoryAspectResponse**](GetTaxonomyCategoryAspectResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxonomycategorychildren"></a>
# **GetTaxonomyCategoryChildren**
> GetTaxonomyCategoryChildrenResponse GetTaxonomyCategoryChildren (string platform, string id)

Direct children of a category node.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxonomyCategoryChildrenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxonomyApi(config);
            var platform = "platform_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Direct children of a category node.
                GetTaxonomyCategoryChildrenResponse result = apiInstance.GetTaxonomyCategoryChildren(platform, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxonomyApi.GetTaxonomyCategoryChildren: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**GetTaxonomyCategoryChildrenResponse**](GetTaxonomyCategoryChildrenResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaxonomyrequiredfield"></a>
# **GetTaxonomyRequiredField**
> GetTaxonomyRequiredFieldResponse GetTaxonomyRequiredField (string platform, string categoryId = null)

Normalized field schema the seller needs to fill before crossposting to this platform. Combines master fields (title/description/price/condition) with platform-specific overrides.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxonomyRequiredFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxonomyApi(config);
            var platform = "platform_example";  // string | 
            var categoryId = "categoryId_example";  // string | Optional — used to inline aspects when present. (optional) 

            try
            {
                // Normalized field schema the seller needs to fill before crossposting to this platform. Combines master fields (title/description/price/condition) with platform-specific overrides.
                GetTaxonomyRequiredFieldResponse result = apiInstance.GetTaxonomyRequiredField(platform, categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxonomyApi.GetTaxonomyRequiredField: " + e.Message );
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
 **categoryId** | **string**| Optional — used to inline aspects when present. | [optional] 

### Return type

[**GetTaxonomyRequiredFieldResponse**](GetTaxonomyRequiredFieldResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtaxonomysuggest"></a>
# **ListTaxonomySuggest**
> V1List ListTaxonomySuggest (string platform, string q = null)

Reverse lookup — suggest categories matching a search phrase. eBay-only today.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTaxonomySuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxonomyApi(config);
            var platform = "platform_example";  // string | 
            var q = "q_example";  // string |  (optional) 

            try
            {
                // Reverse lookup — suggest categories matching a search phrase. eBay-only today.
                V1List result = apiInstance.ListTaxonomySuggest(platform, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxonomyApi.ListTaxonomySuggest: " + e.Message );
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
 **q** | **string**|  | [optional] 

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

