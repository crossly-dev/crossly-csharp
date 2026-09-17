# net.crossly.Api.OffersApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOfferRespond**](OffersApi.md#createofferrespond) | **POST** /v1/offers/{id}/respond | Accept, decline, or counter a buyer offer on a Crossly marketplace listing.
[**GetOffer**](OffersApi.md#getoffer) | **GET** /v1/offers | List buyer offers on your Crossly marketplace listings, including bundles.


<a name="createofferrespond"></a>
# **CreateOfferRespond**
> CreateOfferRespondResponse CreateOfferRespond (string id, InlineObject2 inlineObject2)

Accept, decline, or counter a buyer offer on a Crossly marketplace listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateOfferRespondExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OffersApi(config);
            var id = "id_example";  // string | Offer UUID.
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Accept, decline, or counter a buyer offer on a Crossly marketplace listing.
                CreateOfferRespondResponse result = apiInstance.CreateOfferRespond(id, inlineObject2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferRespond: " + e.Message );
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
 **id** | **string**| Offer UUID. | 
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

[**CreateOfferRespondResponse**](CreateOfferRespondResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoffer"></a>
# **GetOffer**
> GetOfferResponse GetOffer (string status = null, int? limit = null)

List buyer offers on your Crossly marketplace listings, including bundles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OffersApi(config);
            var status = "pending";  // string | Filter to one status. Omit for all. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)

            try
            {
                // List buyer offers on your Crossly marketplace listings, including bundles.
                GetOfferResponse result = apiInstance.GetOffer(status, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffer: " + e.Message );
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
 **status** | **string**| Filter to one status. Omit for all. | [optional] 
 **limit** | **int?**|  | [optional] [default to 50]

### Return type

[**GetOfferResponse**](GetOfferResponse.md)

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

