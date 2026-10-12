# net.crossly.Api.ScanApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListScanCaptures**](ScanApi.md#listscancaptures) | **GET** /v1/scan/captures | Your capture sessions and what they produced.
[**ListScanModels**](ScanApi.md#listscanmodels) | **GET** /v1/scan/models | Which items already have a 3D model.


<a name="listscancaptures"></a>
# **ListScanCaptures**
> ListScanCapturesResponse ListScanCaptures (string status = null, int? limit = null)

Your capture sessions and what they produced.

One row per scan, newest first. `status` is capturing | uploaded | processing | ready | failed | rejected; `rejectReason` says why in the same words the seller was shown. A capture that reports `ready` with no mesh is normal — most items are textured onto a known shape rather than having geometry generated, which is cheaper and looks the same. When an item that WOULD have been generated was not, `generationSkipped` says why: out of monthly allowance, too few distinct angles, or you had already had a model built from this object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListScanCapturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanApi(config);
            var status = "status_example";  // string | Filter to one status. (optional) 
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // Your capture sessions and what they produced.
                ListScanCapturesResponse result = apiInstance.ListScanCaptures(status, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ListScanCaptures: " + e.Message );
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
 **status** | **string**| Filter to one status. | [optional] 
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListScanCapturesResponse**

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

<a name="listscanmodels"></a>
# **ListScanModels**
> ListScanModelsResponse ListScanModels (string variantIds = null, string inventoryItemIds = null)

Which items already have a 3D model.

Ask by CATALOGUE variant (`variantIds`) or by your own inventory rows (`inventoryItemIds`), comma separated, up to 200 of each. At least one is required. Returns only the ones that have a model. The two are different KINDS of answer. A catalogue model belongs to the product and is shared: a hit means your listing gets it with nothing to capture, because somebody else already paid to generate it. An inventory model belongs to one of your rows, because an object with no catalogue identity — a lamp, a one-off — is not a product anyone else can claim. `longestEdgeMm` is present only when a capture MEASURED the item against something of known size; null means the mesh has correct proportions and no real-world scale.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListScanModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanApi(config);
            var variantIds = "variantIds_example";  // string | Comma-separated catalogue variant ids, max 200. (optional) 
            var inventoryItemIds = "inventoryItemIds_example";  // string | Comma-separated inventory item ids, max 200. (optional) 

            try
            {
                // Which items already have a 3D model.
                ListScanModelsResponse result = apiInstance.ListScanModels(variantIds, inventoryItemIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ListScanModels: " + e.Message );
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
 **variantIds** | **string**| Comma-separated catalogue variant ids, max 200. | [optional] 
 **inventoryItemIds** | **string**| Comma-separated inventory item ids, max 200. | [optional] 

### Return type

**ListScanModelsResponse**

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

