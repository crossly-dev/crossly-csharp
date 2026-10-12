# net.crossly.Api.NeighbourhoodsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNeighbourhood**](NeighbourhoodsApi.md#getneighbourhood) | **GET** /v1/neighbourhoods/{slug} | One neighbourhood street by slug.
[**ListNeighbourhoods**](NeighbourhoodsApi.md#listneighbourhoods) | **GET** /v1/neighbourhoods | Every neighbourhood street (Sneaker Row, Card District, Vintage Alley, Vinyl Lane): open or \&quot;opening soon\&quot; (6 shops + open stalls, or a live street event), shops, stalls today, the next street event and its /c/&lt;slug&gt; URL.


<a name="getneighbourhood"></a>
# **GetNeighbourhood**
> GetNeighbourhoodResponse GetNeighbourhood (string slug)

One neighbourhood street by slug.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetNeighbourhoodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NeighbourhoodsApi(config);
            var slug = "sneaker-row";  // string | 

            try
            {
                // One neighbourhood street by slug.
                GetNeighbourhoodResponse result = apiInstance.GetNeighbourhood(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NeighbourhoodsApi.GetNeighbourhood: " + e.Message );
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

**GetNeighbourhoodResponse**

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

<a name="listneighbourhoods"></a>
# **ListNeighbourhoods**
> ListNeighbourhoodsResponse ListNeighbourhoods ()

Every neighbourhood street (Sneaker Row, Card District, Vintage Alley, Vinyl Lane): open or \"opening soon\" (6 shops + open stalls, or a live street event), shops, stalls today, the next street event and its /c/<slug> URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListNeighbourhoodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NeighbourhoodsApi(config);

            try
            {
                // Every neighbourhood street (Sneaker Row, Card District, Vintage Alley, Vinyl Lane): open or \"opening soon\" (6 shops + open stalls, or a live street event), shops, stalls today, the next street event and its /c/<slug> URL.
                ListNeighbourhoodsResponse result = apiInstance.ListNeighbourhoods();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NeighbourhoodsApi.ListNeighbourhoods: " + e.Message );
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

**ListNeighbourhoodsResponse**

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

