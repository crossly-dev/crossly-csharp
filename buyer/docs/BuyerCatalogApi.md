# net.crossly.buyer.Api.BuyerCatalogApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuyerIdentify**](BuyerCatalogApi.md#createbuyeridentify) | **POST** /v1/buyer/identify | Identify a held object and return a HUD-ready answer.
[**CreateBuyerLockon**](BuyerCatalogApi.md#createbuyerlockon) | **POST** /v1/buyer/lockons | Lock on to an object the buyer is holding.
[**CreateBuyerLockonConfirm**](BuyerCatalogApi.md#createbuyerlockonconfirm) | **POST** /v1/buyer/lockons/{id}/confirm | The buyer picked one of the candidates.
[**CreateBuyerLockonObserve**](BuyerCatalogApi.md#createbuyerlockonobserve) | **POST** /v1/buyer/lockons/{id}/observe | Add what this frame revealed, and get the current best answer.
[**CreateBuyerScan**](BuyerCatalogApi.md#createbuyerscan) | **POST** /v1/buyer/scan | Identify a physical item and find the cheapest place to buy it.
[**CreateBuyerScanSession**](BuyerCatalogApi.md#createbuyerscansession) | **POST** /v1/buyer/scan/sessions | Open a Live Shop session.
[**CreateBuyerScanSessionEnd**](BuyerCatalogApi.md#createbuyerscansessionend) | **POST** /v1/buyer/scan/sessions/{id}/end | Close a Live Shop session.
[**GetBuyerAnywhere**](BuyerCatalogApi.md#getbuyeranywhere) | **GET** /v1/buyer/anywhere | Cheapest source for an item — Crossly first, then other retailers.
[**GetBuyerCatalogFacet**](BuyerCatalogApi.md#getbuyercatalogfacet) | **GET** /v1/buyer/catalog/facets | Brands, categories and conditions that currently have stock.
[**GetBuyerCatalogFx**](BuyerCatalogApi.md#getbuyercatalogfx) | **GET** /v1/buyer/catalog/fx | Display-only exchange rates (units per 1 USD).
[**GetBuyerCatalogListing**](BuyerCatalogApi.md#getbuyercataloglisting) | **GET** /v1/buyer/catalog/listings/{slug} | One listing, in full.
[**GetBuyerCatalogListingAvailability**](BuyerCatalogApi.md#getbuyercataloglistingavailability) | **GET** /v1/buyer/catalog/listings/{slug}/availability | Is it still buyable, and at what price.
[**GetBuyerCatalogListingShipping**](BuyerCatalogApi.md#getbuyercataloglistingshipping) | **GET** /v1/buyer/catalog/listings/{slug}/shipping | Shipping services and prices to a destination.
[**GetBuyerListingLandedCost**](BuyerCatalogApi.md#getbuyerlistinglandedcost) | **GET** /v1/buyer/listings/{slug}/landed-cost | Import duties, taxes and fees to a country (landed cost).
[**GetBuyerScanSession**](BuyerCatalogApi.md#getbuyerscansession) | **GET** /v1/buyer/scan/sessions/{id} | One trip and everything it found.
[**ListBuyerCatalogBrowse**](BuyerCatalogApi.md#listbuyercatalogbrowse) | **GET** /v1/buyer/catalog/browse | Browse the way the shop does — buying format, returns, size, color, sold items, Best Match.
[**ListBuyerCatalogListingSoldHistory**](BuyerCatalogApi.md#listbuyercataloglistingsoldhistory) | **GET** /v1/buyer/catalog/listings/{slug}/sold-history | What THIS listing has sold for, newest first (last 50), with the median.
[**ListBuyerCatalogSearch**](BuyerCatalogApi.md#listbuyercatalogsearch) | **GET** /v1/buyer/catalog/search | Search the Crossly catalogue.
[**ListBuyerCatalogSellers**](BuyerCatalogApi.md#listbuyercatalogsellers) | **GET** /v1/buyer/catalog/sellers | Find a seller by shop handle or shop name.
[**ListBuyerScanSessions**](BuyerCatalogApi.md#listbuyerscansessions) | **GET** /v1/buyer/scan/sessions | Your scanning trips, newest first.


<a name="createbuyeridentify"></a>
# **CreateBuyerIdentify**
> CreateBuyerIdentifyResponse CreateBuyerIdentify (CreateBuyerIdentifyRequest createBuyerIdentifyRequest)

Identify a held object and return a HUD-ready answer.

The gesture endpoint for Live Shop. Runs a cost ladder: a decoded BARCODE resolves in ~50ms for nothing; failing that, self-hosted CLIP matches the catalogue; failing that, a vision model names it (the only rung that costs anything, capped per buyer per day). `hud` is pre-formatted for a 600×600 lens — one headline, one subline, up to three fact chips and exactly ONE action, because a pinch cannot choose between buttons. A vision label is WORDS, never an identity: it names the thing so the buyer can search, and never drives a price comparison.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerIdentifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var createBuyerIdentifyRequest = new CreateBuyerIdentifyRequest(); // CreateBuyerIdentifyRequest | 

            try
            {
                // Identify a held object and return a HUD-ready answer.
                CreateBuyerIdentifyResponse result = apiInstance.CreateBuyerIdentify(createBuyerIdentifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerIdentify: " + e.Message );
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
 **createBuyerIdentifyRequest** | **CreateBuyerIdentifyRequest**|  | 

### Return type

**CreateBuyerIdentifyResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerlockon"></a>
# **CreateBuyerLockon**
> CreateBuyerLockonResponse CreateBuyerLockon (CreateBuyerLockonRequest createBuyerLockonRequest)

Lock on to an object the buyer is holding.

Open this when on-device tracking acquires an object, then post observations to it as the buyer turns the thing over. The answer improves as evidence arrives — the style code inside a shoe settles what the front of it could not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerLockonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var createBuyerLockonRequest = new CreateBuyerLockonRequest(); // CreateBuyerLockonRequest | 

            try
            {
                // Lock on to an object the buyer is holding.
                CreateBuyerLockonResponse result = apiInstance.CreateBuyerLockon(createBuyerLockonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerLockon: " + e.Message );
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
 **createBuyerLockonRequest** | **CreateBuyerLockonRequest**|  | 

### Return type

**CreateBuyerLockonResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerlockonconfirm"></a>
# **CreateBuyerLockonConfirm**
> CreateBuyerLockonConfirmResponse CreateBuyerLockonConfirm (Guid id, CreateBuyerLockonConfirmRequest createBuyerLockonConfirmRequest)

The buyer picked one of the candidates.

Promotes a text match to a CONFIRMED identity — the strongest evidence in the system, because a person holding the object said yes. Validated against the candidates we actually offered, so it cannot be claimed about an arbitrary product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerLockonConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var id = "id_example";  // Guid | 
            var createBuyerLockonConfirmRequest = new CreateBuyerLockonConfirmRequest(); // CreateBuyerLockonConfirmRequest | 

            try
            {
                // The buyer picked one of the candidates.
                CreateBuyerLockonConfirmResponse result = apiInstance.CreateBuyerLockonConfirm(id, createBuyerLockonConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerLockonConfirm: " + e.Message );
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
 **createBuyerLockonConfirmRequest** | **CreateBuyerLockonConfirmRequest**|  | 

### Return type

**CreateBuyerLockonConfirmResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerlockonobserve"></a>
# **CreateBuyerLockonObserve**
> CreateBuyerLockonConfirmResponse CreateBuyerLockonObserve (Guid id, CreateBuyerLockonObserveRequest createBuyerLockonObserveRequest = null)

Add what this frame revealed, and get the current best answer.

Send only what you LEARNED: a decoded barcode, newly-read OCR text, or a frame when neither settled it. Do not post every frame — tracking and decoding happen on-device for free, and this endpoint is for evidence, not video. Evidence is RANKED (confirmed > barcode > ocr > visual), so a late weak reading can never overwrite a strong early one. When text evidence finds several products, `candidates` comes back for the buyer to pick from — a vision label is words, and only a human confirmation turns it into an identity we will price against.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerLockonObserveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var id = "id_example";  // Guid | 
            var createBuyerLockonObserveRequest = new CreateBuyerLockonObserveRequest(); // CreateBuyerLockonObserveRequest |  (optional) 

            try
            {
                // Add what this frame revealed, and get the current best answer.
                CreateBuyerLockonConfirmResponse result = apiInstance.CreateBuyerLockonObserve(id, createBuyerLockonObserveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerLockonObserve: " + e.Message );
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
 **createBuyerLockonObserveRequest** | **CreateBuyerLockonObserveRequest**|  | [optional] 

### Return type

**CreateBuyerLockonConfirmResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerscan"></a>
# **CreateBuyerScan**
> CreateBuyerScanResponse CreateBuyerScan (CreateBuyerScanRequest createBuyerScanRequest)

Identify a physical item and find the cheapest place to buy it.

Send a barcode identifier OR a photo. A BARCODE establishes identity, so the response carries a full price verdict across Crossly and other retailers. A PHOTO establishes resemblance only: you get visual matches from the Crossly catalogue, and a price verdict ONLY if the matched listing carries a real identifier. When it does not, `comparable` is false and there is no verdict — a price comparison built on a visual guess is a claim about a different product. Most second-hand items have no identifier by nature, so this is expected rather than a failure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var createBuyerScanRequest = new CreateBuyerScanRequest(); // CreateBuyerScanRequest | 

            try
            {
                // Identify a physical item and find the cheapest place to buy it.
                CreateBuyerScanResponse result = apiInstance.CreateBuyerScan(createBuyerScanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerScan: " + e.Message );
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
 **createBuyerScanRequest** | **CreateBuyerScanRequest**|  | 

### Return type

**CreateBuyerScanResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerscansession"></a>
# **CreateBuyerScanSession**
> CreateBuyerScanSessionResponse CreateBuyerScanSession (CreateBuyerScanSessionRequest createBuyerScanSessionRequest = null)

Open a Live Shop session.

Call this when the glasses connect, then pass the returned id as `sessionId` on each scan. Opening a session CLOSES any other live one — a person is in one shop at a time, and two live sessions split a trip across both.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerScanSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var createBuyerScanSessionRequest = new CreateBuyerScanSessionRequest(); // CreateBuyerScanSessionRequest |  (optional) 

            try
            {
                // Open a Live Shop session.
                CreateBuyerScanSessionResponse result = apiInstance.CreateBuyerScanSession(createBuyerScanSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerScanSession: " + e.Message );
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
 **createBuyerScanSessionRequest** | **CreateBuyerScanSessionRequest**|  | [optional] 

### Return type

**CreateBuyerScanSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerscansessionend"></a>
# **CreateBuyerScanSessionEnd**
> CreateBuyerScanSessionEndResponse CreateBuyerScanSessionEnd (Guid id)

Close a Live Shop session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerScanSessionEndExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Close a Live Shop session.
                CreateBuyerScanSessionEndResponse result = apiInstance.CreateBuyerScanSessionEnd(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.CreateBuyerScanSessionEnd: " + e.Message );
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

**CreateBuyerScanSessionEndResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyeranywhere"></a>
# **GetBuyerAnywhere**
> GetBuyerAnywhereResponse GetBuyerAnywhere (string ns, string value, decimal? pagePriceCents = null, string currency = null)

Cheapest source for an item — Crossly first, then other retailers.

Answers with a VERDICT, not a list: crossly_best, offsite_cheaper, offsite_only or no_match. Offsite offers come from licensed affiliate product feeds, are ranked CHEAPEST-FIRST — commission only ever breaks a sub-$1 tie — and only appear when they beat the price you passed in. `shippingUnknown: true` means a compared price omitted postage, so present the result as \"before postage\" rather than as a delivered total. Crossly wins ties within $1; beyond that the honest answer wins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerAnywhereExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var ns = "discogs";  // string | An identifier the item actually carries. No free-text fallback, ever — see docs/IDENTIFIER-FIRST.md. A title-matched \"cheaper elsewhere\" is a claim about a different product.  The ALLOW-LIST, not a free string. `compare.ts` explains why: the namespace goes straight into a query, and an open passthrough lets a caller enumerate every namespace we hold — a map of the catalogue's provenance. Reusing the same list here keeps the two from drifting.
            var value = "value_example";  // string | 
            var pagePriceCents = 8.14D;  // decimal? | What the buyer is looking at, so \"cheaper\" means cheaper than THAT. (optional) 
            var currency = "currency_example";  // string |  (optional) 

            try
            {
                // Cheapest source for an item — Crossly first, then other retailers.
                GetBuyerAnywhereResponse result = apiInstance.GetBuyerAnywhere(ns, value, pagePriceCents, currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerAnywhere: " + e.Message );
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
 **ns** | **string**| An identifier the item actually carries. No free-text fallback, ever — see docs/IDENTIFIER-FIRST.md. A title-matched \&quot;cheaper elsewhere\&quot; is a claim about a different product.  The ALLOW-LIST, not a free string. &#x60;compare.ts&#x60; explains why: the namespace goes straight into a query, and an open passthrough lets a caller enumerate every namespace we hold — a map of the catalogue&#39;s provenance. Reusing the same list here keeps the two from drifting. | 
 **value** | **string**|  | 
 **pagePriceCents** | **decimal?**| What the buyer is looking at, so \&quot;cheaper\&quot; means cheaper than THAT. | [optional] 
 **currency** | **string**|  | [optional] 

### Return type

**GetBuyerAnywhereResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyercatalogfacet"></a>
# **GetBuyerCatalogFacet**
> GetBuyerCatalogFacetResponse GetBuyerCatalogFacet ()

Brands, categories and conditions that currently have stock.

The vocabulary the search filters accept. Counts are live, so a filter built from this will never return an empty page for a value that has since sold out.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogFacetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);

            try
            {
                // Brands, categories and conditions that currently have stock.
                GetBuyerCatalogFacetResponse result = apiInstance.GetBuyerCatalogFacet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerCatalogFacet: " + e.Message );
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

**GetBuyerCatalogFacetResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyercatalogfx"></a>
# **GetBuyerCatalogFx**
> GetBuyerCatalogFxResponse GetBuyerCatalogFx ()

Display-only exchange rates (units per 1 USD).

ECB daily reference rates rebased to US dollars: `rates.EUR = 0.92` means $1 ≈ €0.92. `asOf` is the ECB publication date (null until the first refresh). For showing an approximate price only — every Crossly price and charge is in USD, and the card issuer sets the final exchange rate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogFxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);

            try
            {
                // Display-only exchange rates (units per 1 USD).
                GetBuyerCatalogFxResponse result = apiInstance.GetBuyerCatalogFx();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerCatalogFx: " + e.Message );
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

**GetBuyerCatalogFxResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyercataloglisting"></a>
# **GetBuyerCatalogListing**
> GetBuyerCatalogListingResponse GetBuyerCatalogListing (string slug)

One listing, in full.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One listing, in full.
                GetBuyerCatalogListingResponse result = apiInstance.GetBuyerCatalogListing(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerCatalogListing: " + e.Message );
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

**GetBuyerCatalogListingResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyercataloglistingavailability"></a>
# **GetBuyerCatalogListingAvailability**
> GetBuyerCatalogListingAvailabilityResponse GetBuyerCatalogListingAvailability (string slug)

Is it still buyable, and at what price.

The cheapest endpoint here, and the one to poll if you are going to poll — a single indexed row, no joins beyond stock, and an ETag so an unchanged answer is a 304. If you want to be TOLD instead of asking, create a monitor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingAvailabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Is it still buyable, and at what price.
                GetBuyerCatalogListingAvailabilityResponse result = apiInstance.GetBuyerCatalogListingAvailability(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerCatalogListingAvailability: " + e.Message );
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

**GetBuyerCatalogListingAvailabilityResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyercataloglistingshipping"></a>
# **GetBuyerCatalogListingShipping**
> GetBuyerCatalogListingShippingResponse GetBuyerCatalogListingShipping (string slug, string zip = null, string state = null, string country = null, int? quantity = null)

Shipping services and prices to a destination.

Lists every shipping service the seller offers to `country` (default: the seller’s own country) with its price for `quantity` units and its delivery window in business days (handling included). `zip` is required for a domestic quote; `state` is optional. `shipsToCountry: false` means the seller does not ship there (`noShipMessage` says why); `partial: true` means a ZIP or postcode could change the answer. Pass a service `id` as `shippingServiceId` to POST /api/v1/buyer/checkout, or in `shippingServiceBySeller` to POST /api/v1/buyer/cart/quote. A seller on \"buyer pays: calculated\" prices each allowed carrier service from the live label rate for this parcel plus their handling fee (rates cached 15 minutes): those services carry `carrier` and `carrierService`, and `calculatedAtCheckout: true` means a ZIP is needed first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingShippingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var slug = "slug_example";  // string | 
            var zip = "zip_example";  // string |  (optional) 
            var state = "state_example";  // string |  (optional) 
            var country = "country_example";  // string |  (optional) 
            var quantity = 56;  // int? |  (optional) 

            try
            {
                // Shipping services and prices to a destination.
                GetBuyerCatalogListingShippingResponse result = apiInstance.GetBuyerCatalogListingShipping(slug, zip, state, country, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerCatalogListingShipping: " + e.Message );
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
 **zip** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 
 **country** | **string**|  | [optional] 
 **quantity** | **int?**|  | [optional] 

### Return type

**GetBuyerCatalogListingShippingResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyerlistinglandedcost"></a>
# **GetBuyerListingLandedCost**
> GetBuyerListingLandedCostResponse GetBuyerListingLandedCost (string country, string slug, string postalCode = null, int? quantity = null)

Import duties, taxes and fees to a country (landed cost).

Quotes the import duties, import taxes and fees for this listing shipped to `country` (ISO 3166-1 alpha-2), using the cheapest shipping service the seller offers there. `status: included` means checkout charges them now and the parcel ships DDP — no bill at the door; `unavailable` means it ships DDU and `notice` says the carrier or customs may charge on delivery; `none` means the parcel does not cross a border. Amounts are US-dollar cents. Answers 503 with `missingEnv` when landed-cost quoting is not configured on this deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingLandedCostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var country = "country_example";  // string | 
            var slug = "slug_example";  // string | 
            var postalCode = "postalCode_example";  // string |  (optional) 
            var quantity = 56;  // int? |  (optional) 

            try
            {
                // Import duties, taxes and fees to a country (landed cost).
                GetBuyerListingLandedCostResponse result = apiInstance.GetBuyerListingLandedCost(country, slug, postalCode, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerListingLandedCost: " + e.Message );
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
 **country** | **string**|  | 
 **slug** | **string**|  | 
 **postalCode** | **string**|  | [optional] 
 **quantity** | **int?**|  | [optional] 

### Return type

**GetBuyerListingLandedCostResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="getbuyerscansession"></a>
# **GetBuyerScanSession**
> GetBuyerScanSessionResponse GetBuyerScanSession (Guid id)

One trip and everything it found.

Verdicts are returned EXACTLY as they were given at the time, not re-priced. A history screen that silently refreshes old prices shows a saving that was never actually on offer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerScanSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One trip and everything it found.
                GetBuyerScanSessionResponse result = apiInstance.GetBuyerScanSession(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.GetBuyerScanSession: " + e.Message );
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

**GetBuyerScanSessionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="listbuyercatalogbrowse"></a>
# **ListBuyerCatalogBrowse**
> ListBuyerCatalogBrowseResponse ListBuyerCatalogBrowse (string q = null, string format = null, string returns = null, string sold = null, string size = null, string color = null, string shipsTo = null, string sort = null, int? minPriceCents = null, int? maxPriceCents = null, int? page = null, int? limit = null, string brand = null, string condition = null, string category = null, string subcategory = null, string freeShipping = null, string localPickup = null, string deals = null, string state = null, string zip = null)

Browse the way the shop does — buying format, returns, size, color, sold items, Best Match.

Page-numbered and capped at 50 pages of up to 60, like the storefront. For walking the whole catalogue use /v1/buyer/catalog/search, which pages by cursor. Prices are integer CENTS (`minPriceCents=2500` is $25.00). `sold=true` returns recent sales of matching listings (last 90 days) with `soldPriceCents` and `soldAt`, instead of live stock.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCatalogBrowseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var q = "q_example";  // string | Free text; every word must appear in the title or brand. (optional) 
            var format = "auction";  // string | auction, buy_it_now, or offers (accepts offers). (optional) 
            var returns = "true";  // string | true = only listings that accept returns. (optional) 
            var sold = "true";  // string | true = recent sales instead of live listings. (optional) 
            var size = "size_example";  // string | Exact size, case-insensitive (M does not match XL). (optional) 
            var color = "color_example";  // string | Exact colour, case-insensitive. (optional) 
            var shipsTo = "shipsTo_example";  // string | ISO 3166-1 alpha-2 destination (e.g. GB): only listings whose seller ships there, decided as checkout decides it (the listing's shipping policy and its own restricted countries). An embargoed destination matches nothing. Omitted, or `any`, means no destination filter — the storefront grid defaults to the buyer's country, this endpoint does not. (optional) 
            var sort = "best_match";  // string | Default best_match with q, newest without. (optional) 
            var minPriceCents = 56;  // int? | Lowest price, in cents. (optional) 
            var maxPriceCents = 56;  // int? | Highest price, in cents. (optional) 
            var page = 1;  // int? | 1-indexed page. (optional)  (default to 1)
            var limit = 24;  // int? | Rows per page. (optional)  (default to 24)
            var brand = "brand_example";  // string |  (optional) 
            var condition = "condition_example";  // string |  (optional) 
            var category = "category_example";  // string |  (optional) 
            var subcategory = "subcategory_example";  // string |  (optional) 
            var freeShipping = "true";  // string |  (optional) 
            var localPickup = "true";  // string |  (optional) 
            var deals = "true";  // string |  (optional) 
            var state = "state_example";  // string |  (optional) 
            var zip = "zip_example";  // string |  (optional) 

            try
            {
                // Browse the way the shop does — buying format, returns, size, color, sold items, Best Match.
                ListBuyerCatalogBrowseResponse result = apiInstance.ListBuyerCatalogBrowse(q, format, returns, sold, size, color, shipsTo, sort, minPriceCents, maxPriceCents, page, limit, brand, condition, category, subcategory, freeShipping, localPickup, deals, state, zip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.ListBuyerCatalogBrowse: " + e.Message );
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
 **q** | **string**| Free text; every word must appear in the title or brand. | [optional] 
 **format** | **string**| auction, buy_it_now, or offers (accepts offers). | [optional] 
 **returns** | **string**| true &#x3D; only listings that accept returns. | [optional] 
 **sold** | **string**| true &#x3D; recent sales instead of live listings. | [optional] 
 **size** | **string**| Exact size, case-insensitive (M does not match XL). | [optional] 
 **color** | **string**| Exact colour, case-insensitive. | [optional] 
 **shipsTo** | **string**| ISO 3166-1 alpha-2 destination (e.g. GB): only listings whose seller ships there, decided as checkout decides it (the listing&#39;s shipping policy and its own restricted countries). An embargoed destination matches nothing. Omitted, or &#x60;any&#x60;, means no destination filter — the storefront grid defaults to the buyer&#39;s country, this endpoint does not. | [optional] 
 **sort** | **string**| Default best_match with q, newest without. | [optional] 
 **minPriceCents** | **int?**| Lowest price, in cents. | [optional] 
 **maxPriceCents** | **int?**| Highest price, in cents. | [optional] 
 **page** | **int?**| 1-indexed page. | [optional] [default to 1]
 **limit** | **int?**| Rows per page. | [optional] [default to 24]
 **brand** | **string**|  | [optional] 
 **condition** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **subcategory** | **string**|  | [optional] 
 **freeShipping** | **string**|  | [optional] 
 **localPickup** | **string**|  | [optional] 
 **deals** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 
 **zip** | **string**|  | [optional] 

### Return type

**ListBuyerCatalogBrowseResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="listbuyercataloglistingsoldhistory"></a>
# **ListBuyerCatalogListingSoldHistory**
> ListBuyerCatalogListingSoldHistoryResponse ListBuyerCatalogListingSoldHistory (string slug)

What THIS listing has sold for, newest first (last 50), with the median.

This listing only — never \"similar items\", which would mean matching other listings by resemblance. Prices are per unit, in cents, excluding shipping and tax.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCatalogListingSoldHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var slug = "slug_example";  // string | The listing slug.

            try
            {
                // What THIS listing has sold for, newest first (last 50), with the median.
                ListBuyerCatalogListingSoldHistoryResponse result = apiInstance.ListBuyerCatalogListingSoldHistory(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.ListBuyerCatalogListingSoldHistory: " + e.Message );
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
 **slug** | **string**| The listing slug. | 

### Return type

**ListBuyerCatalogListingSoldHistoryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="listbuyercatalogsearch"></a>
# **ListBuyerCatalogSearch**
> ListBuyerCatalogSearchResponse ListBuyerCatalogSearch (string q = null, string brand = null, string category = null, string condition = null, string seller = null, decimal? minPriceCents = null, decimal? maxPriceCents = null, string listedAfter = null, string inStockOnly = null, string sort = null, decimal? limit = null, string cursor = null)

Search the Crossly catalogue.

Keyset-paginated. Pass the `nextCursor` you were given back as `cursor`; page 500 costs the same as page 1. Cursors are opaque — do not parse them. Responses carry an ETag: send it back as If-None-Match and an unchanged page answers 304, which is free. `sort=popular` is deliberately unavailable, because a cursor into a continuously-reordering list silently skips rows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCatalogSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var q = "q_example";  // string |  (optional) 
            var brand = "brand_example";  // string |  (optional) 
            var category = "category_example";  // string |  (optional) 
            var condition = "condition_example";  // string |  (optional) 
            var seller = "seller_example";  // string |  (optional) 
            var minPriceCents = 8.14D;  // decimal? |  (optional) 
            var maxPriceCents = 8.14D;  // decimal? |  (optional) 
            var listedAfter = "listedAfter_example";  // string |  (optional) 
            var inStockOnly = "true";  // string |  (optional) 
            var sort = "newest";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 

            try
            {
                // Search the Crossly catalogue.
                ListBuyerCatalogSearchResponse result = apiInstance.ListBuyerCatalogSearch(q, brand, category, condition, seller, minPriceCents, maxPriceCents, listedAfter, inStockOnly, sort, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.ListBuyerCatalogSearch: " + e.Message );
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
 **brand** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **condition** | **string**|  | [optional] 
 **seller** | **string**|  | [optional] 
 **minPriceCents** | **decimal?**|  | [optional] 
 **maxPriceCents** | **decimal?**|  | [optional] 
 **listedAfter** | **string**|  | [optional] 
 **inStockOnly** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **cursor** | **string**|  | [optional] 

### Return type

**ListBuyerCatalogSearchResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="listbuyercatalogsellers"></a>
# **ListBuyerCatalogSellers**
> ListBuyerCatalogSellersResponse ListBuyerCatalogSellers (string q, int? limit = null)

Find a seller by shop handle or shop name.

Only shops that have listed on Crossly. Exact matches first, then prefix, then by live listing count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCatalogSellersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);
            var q = "q_example";  // string | At least two characters of a handle or shop name.
            var limit = 12;  // int? | How many shops to return. (optional)  (default to 12)

            try
            {
                // Find a seller by shop handle or shop name.
                ListBuyerCatalogSellersResponse result = apiInstance.ListBuyerCatalogSellers(q, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.ListBuyerCatalogSellers: " + e.Message );
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
 **q** | **string**| At least two characters of a handle or shop name. | 
 **limit** | **int?**| How many shops to return. | [optional] [default to 12]

### Return type

**ListBuyerCatalogSellersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="listbuyerscansessions"></a>
# **ListBuyerScanSessions**
> ListBuyerScanSessionsResponse ListBuyerScanSessions ()

Your scanning trips, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerScanSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCatalogApi(config);

            try
            {
                // Your scanning trips, newest first.
                ListBuyerScanSessionsResponse result = apiInstance.ListBuyerScanSessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCatalogApi.ListBuyerScanSessions: " + e.Message );
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

**ListBuyerScanSessionsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

