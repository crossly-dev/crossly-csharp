# net.crossly.Api.NFTMarketApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNftMarketExternalResale**](NFTMarketApi.md#createnftmarketexternalresale) | **POST** /v1/nft-market/external-resale | Ops: record a Crossly NFT resold on ANY marketplace — maps mint → design and funds the pot. Admin PAT only.
[**CreateNftMarketListing**](NFTMarketApi.md#createnftmarketlisting) | **POST** /v1/nft-market/listings | List an NFT you own for resale on the Crossly marketplace.
[**CreateNftMarketListingCancel**](NFTMarketApi.md#createnftmarketlistingcancel) | **POST** /v1/nft-market/listings/{id}/cancel | Cancel one of your open NFT listings.
[**CreateNftMarketListingConfirmSale**](NFTMarketApi.md#createnftmarketlistingconfirmsale) | **POST** /v1/nft-market/listings/{id}/confirm-sale | Ops: record a finalized on-Crossly NFT sale (verifies the royalty landed, funds the pot). Admin PAT only.
[**GetNftMarketListing**](NFTMarketApi.md#getnftmarketlisting) | **GET** /v1/nft-market/listings | Browse open on-platform NFT listings (Crossly cosmetics for resale in CBX/SOL).


<a name="createnftmarketexternalresale"></a>
# **CreateNftMarketExternalResale**
> CreateNftMarketExternalResaleResponse CreateNftMarketExternalResale ()

Ops: record a Crossly NFT resold on ANY marketplace — maps mint → design and funds the pot. Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNftMarketExternalResaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NFTMarketApi(config);

            try
            {
                // Ops: record a Crossly NFT resold on ANY marketplace — maps mint → design and funds the pot. Admin PAT only.
                CreateNftMarketExternalResaleResponse result = apiInstance.CreateNftMarketExternalResale();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NFTMarketApi.CreateNftMarketExternalResale: " + e.Message );
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

**CreateNftMarketExternalResaleResponse**

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

<a name="createnftmarketlisting"></a>
# **CreateNftMarketListing**
> CreateNftMarketListingResponse CreateNftMarketListing ()

List an NFT you own for resale on the Crossly marketplace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNftMarketListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NFTMarketApi(config);

            try
            {
                // List an NFT you own for resale on the Crossly marketplace.
                CreateNftMarketListingResponse result = apiInstance.CreateNftMarketListing();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NFTMarketApi.CreateNftMarketListing: " + e.Message );
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

**CreateNftMarketListingResponse**

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

<a name="createnftmarketlistingcancel"></a>
# **CreateNftMarketListingCancel**
> OkResponse CreateNftMarketListingCancel (string id)

Cancel one of your open NFT listings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNftMarketListingCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NFTMarketApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel one of your open NFT listings.
                OkResponse result = apiInstance.CreateNftMarketListingCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NFTMarketApi.CreateNftMarketListingCancel: " + e.Message );
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

<a name="createnftmarketlistingconfirmsale"></a>
# **CreateNftMarketListingConfirmSale**
> OkResponse CreateNftMarketListingConfirmSale (string id)

Ops: record a finalized on-Crossly NFT sale (verifies the royalty landed, funds the pot). Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNftMarketListingConfirmSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NFTMarketApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Ops: record a finalized on-Crossly NFT sale (verifies the royalty landed, funds the pot). Admin PAT only.
                OkResponse result = apiInstance.CreateNftMarketListingConfirmSale(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NFTMarketApi.CreateNftMarketListingConfirmSale: " + e.Message );
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

<a name="getnftmarketlisting"></a>
# **GetNftMarketListing**
> GetNftMarketListingResponse GetNftMarketListing ()

Browse open on-platform NFT listings (Crossly cosmetics for resale in CBX/SOL).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetNftMarketListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NFTMarketApi(config);

            try
            {
                // Browse open on-platform NFT listings (Crossly cosmetics for resale in CBX/SOL).
                GetNftMarketListingResponse result = apiInstance.GetNftMarketListing();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NFTMarketApi.GetNftMarketListing: " + e.Message );
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

**GetNftMarketListingResponse**

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

