# net.crossly.Api.ProductionApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductionCandidateAccept**](ProductionApi.md#createproductioncandidateaccept) | **POST** /v1/production/candidates/{id}/accept | Accept a graduated design&#39;s production terms (edition size, cost, holder access).
[**CreateProductionCandidatePo**](ProductionApi.md#createproductioncandidatepo) | **POST** /v1/production/candidates/{id}/po | Ops: open a purchase order for a candidate. Admin PAT only.
[**CreateProductionCandidateVote**](ProductionApi.md#createproductioncandidatevote) | **POST** /v1/production/candidates/{id}/vote | Back (support: true) or un-back a design on the production ballot. One vote per person per design; voters must have bought on Crossly.
[**CreateProductionDesignBrief**](ProductionApi.md#createproductiondesignbrief) | **POST** /v1/production/designs/{cosmeticId}/brief | Set a design&#39;s production brief (materials, finish, box, reference images).
[**CreateProductionDesignConsent**](ProductionApi.md#createproductiondesignconsent) | **POST** /v1/production/designs/{cosmeticId}/consent | Opt a design in or out of physical production.
[**CreateProductionDesignSpec**](ProductionApi.md#createproductiondesignspec) | **POST** /v1/production/designs/{cosmeticId}/spec | Set a design&#39;s production spec (category, materials, complexity, packaging).
[**CreateProductionEstimate**](ProductionApi.md#createproductionestimate) | **POST** /v1/production/estimate | Estimate a run&#39;s landed cost from a spec + edition size (overshoots for safety).
[**CreateProductionRunPurchase**](ProductionApi.md#createproductionrunpurchase) | **POST** /v1/production/runs/{id}/purchase | Buy a limited-edition unit of a physical run (holder pricing applies).
[**CreateReceiptRelist**](ProductionApi.md#createreceiptrelist) | **POST** /v1/receipts/{id}/relist | Sell it again: a draft listing of something you bought on Crossly, carrying its purchase receipt so the next buyer inherits its provenance.
[**GetProductionBallot**](ProductionApi.md#getproductionballot) | **GET** /v1/production/ballot | The ballot: designs waiting for a physical run, most backed first, and whether you may vote.
[**GetProductionCandidate**](ProductionApi.md#getproductioncandidate) | **GET** /v1/production/candidates | Your designs that have graduated toward a physical run.
[**GetProductionDesignPref**](ProductionApi.md#getproductiondesignpref) | **GET** /v1/production/designs/{cosmeticId}/prefs | Read a design&#39;s production preferences (spec, brief, opt-out).
[**GetProductionDrop**](ProductionApi.md#getproductiondrop) | **GET** /v1/production/drops | Limited-edition units you own, with fulfillment status.
[**GetProductionEarning**](ProductionApi.md#getproductionearning) | **GET** /v1/production/earnings | Your CBX earnings from physical production (royalties + balance + lines).
[**GetProductionLine**](ProductionApi.md#getproductionline) | **GET** /v1/production/lines | Your production lines dashboard (candidate + run + inventory).
[**GetProductionPo**](ProductionApi.md#getproductionpo) | **GET** /v1/production/pos | Ops: list purchase orders (optionally for one candidate). Admin PAT only.
[**GetProductionPoReconcile**](ProductionApi.md#getproductionporeconcile) | **GET** /v1/production/pos/{poId}/reconcile | Ops: reconcile a PO&#39;s actuals against the estimate. Admin PAT only.
[**GetProductionRun**](ProductionApi.md#getproductionrun) | **GET** /v1/production/runs | Browse open limited-edition physical runs (graduated designs).
[**GetShopListingProvenance**](ProductionApi.md#getshoplistingprovenance) | **GET** /v1/shop/listings/{slug}/provenance | Crossly provenance behind a shop listing: owners on Crossly and since when (never who or for how much). Null when not bought here.
[**UpdateProductionPo**](ProductionApi.md#updateproductionpo) | **PATCH** /v1/production/pos/{poId} | Ops: update a PO (supplier, freight, actuals, QC, status). Admin PAT only.


<a name="createproductioncandidateaccept"></a>
# **CreateProductionCandidateAccept**
> CreateProductionCandidateAcceptResponse CreateProductionCandidateAccept (string id)

Accept a graduated design's production terms (edition size, cost, holder access).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionCandidateAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Accept a graduated design's production terms (edition size, cost, holder access).
                CreateProductionCandidateAcceptResponse result = apiInstance.CreateProductionCandidateAccept(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionCandidateAccept: " + e.Message );
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

**CreateProductionCandidateAcceptResponse**

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

<a name="createproductioncandidatepo"></a>
# **CreateProductionCandidatePo**
> UpdateProductionPoResponse CreateProductionCandidatePo (string id)

Ops: open a purchase order for a candidate. Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionCandidatePoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Ops: open a purchase order for a candidate. Admin PAT only.
                UpdateProductionPoResponse result = apiInstance.CreateProductionCandidatePo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionCandidatePo: " + e.Message );
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

**UpdateProductionPoResponse**

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

<a name="createproductioncandidatevote"></a>
# **CreateProductionCandidateVote**
> CreateProductionCandidateVoteResponse CreateProductionCandidateVote (string id)

Back (support: true) or un-back a design on the production ballot. One vote per person per design; voters must have bought on Crossly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionCandidateVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Back (support: true) or un-back a design on the production ballot. One vote per person per design; voters must have bought on Crossly.
                CreateProductionCandidateVoteResponse result = apiInstance.CreateProductionCandidateVote(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionCandidateVote: " + e.Message );
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

**CreateProductionCandidateVoteResponse**

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

<a name="createproductiondesignbrief"></a>
# **CreateProductionDesignBrief**
> CreateProductionDesignSpecResponse CreateProductionDesignBrief (string cosmeticId)

Set a design's production brief (materials, finish, box, reference images).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionDesignBriefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var cosmeticId = "cosmeticId_example";  // string | 

            try
            {
                // Set a design's production brief (materials, finish, box, reference images).
                CreateProductionDesignSpecResponse result = apiInstance.CreateProductionDesignBrief(cosmeticId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionDesignBrief: " + e.Message );
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
 **cosmeticId** | **string**|  | 

### Return type

**CreateProductionDesignSpecResponse**

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

<a name="createproductiondesignconsent"></a>
# **CreateProductionDesignConsent**
> CreateProductionDesignSpecResponse CreateProductionDesignConsent (string cosmeticId)

Opt a design in or out of physical production.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionDesignConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var cosmeticId = "cosmeticId_example";  // string | 

            try
            {
                // Opt a design in or out of physical production.
                CreateProductionDesignSpecResponse result = apiInstance.CreateProductionDesignConsent(cosmeticId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionDesignConsent: " + e.Message );
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
 **cosmeticId** | **string**|  | 

### Return type

**CreateProductionDesignSpecResponse**

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

<a name="createproductiondesignspec"></a>
# **CreateProductionDesignSpec**
> CreateProductionDesignSpecResponse CreateProductionDesignSpec (string cosmeticId)

Set a design's production spec (category, materials, complexity, packaging).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionDesignSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var cosmeticId = "cosmeticId_example";  // string | 

            try
            {
                // Set a design's production spec (category, materials, complexity, packaging).
                CreateProductionDesignSpecResponse result = apiInstance.CreateProductionDesignSpec(cosmeticId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionDesignSpec: " + e.Message );
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
 **cosmeticId** | **string**|  | 

### Return type

**CreateProductionDesignSpecResponse**

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

<a name="createproductionestimate"></a>
# **CreateProductionEstimate**
> CreateProductionEstimateResponse CreateProductionEstimate ()

Estimate a run's landed cost from a spec + edition size (overshoots for safety).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionEstimateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Estimate a run's landed cost from a spec + edition size (overshoots for safety).
                CreateProductionEstimateResponse result = apiInstance.CreateProductionEstimate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionEstimate: " + e.Message );
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

**CreateProductionEstimateResponse**

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

<a name="createproductionrunpurchase"></a>
# **CreateProductionRunPurchase**
> CreateProductionRunPurchaseResponse CreateProductionRunPurchase (string id)

Buy a limited-edition unit of a physical run (holder pricing applies).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProductionRunPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Buy a limited-edition unit of a physical run (holder pricing applies).
                CreateProductionRunPurchaseResponse result = apiInstance.CreateProductionRunPurchase(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateProductionRunPurchase: " + e.Message );
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

**CreateProductionRunPurchaseResponse**

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

<a name="createreceiptrelist"></a>
# **CreateReceiptRelist**
> CreateReceiptRelistResponse CreateReceiptRelist (string id)

Sell it again: a draft listing of something you bought on Crossly, carrying its purchase receipt so the next buyer inherits its provenance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateReceiptRelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Sell it again: a draft listing of something you bought on Crossly, carrying its purchase receipt so the next buyer inherits its provenance.
                CreateReceiptRelistResponse result = apiInstance.CreateReceiptRelist(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CreateReceiptRelist: " + e.Message );
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

**CreateReceiptRelistResponse**

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

<a name="getproductionballot"></a>
# **GetProductionBallot**
> GetProductionBallotResponse GetProductionBallot ()

The ballot: designs waiting for a physical run, most backed first, and whether you may vote.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionBallotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // The ballot: designs waiting for a physical run, most backed first, and whether you may vote.
                GetProductionBallotResponse result = apiInstance.GetProductionBallot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionBallot: " + e.Message );
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

**GetProductionBallotResponse**

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

<a name="getproductioncandidate"></a>
# **GetProductionCandidate**
> GetProductionCandidateResponse GetProductionCandidate ()

Your designs that have graduated toward a physical run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionCandidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Your designs that have graduated toward a physical run.
                GetProductionCandidateResponse result = apiInstance.GetProductionCandidate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionCandidate: " + e.Message );
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

**GetProductionCandidateResponse**

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

<a name="getproductiondesignpref"></a>
# **GetProductionDesignPref**
> GetProductionDesignPrefResponse GetProductionDesignPref (string cosmeticId)

Read a design's production preferences (spec, brief, opt-out).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionDesignPrefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var cosmeticId = "cosmeticId_example";  // string | 

            try
            {
                // Read a design's production preferences (spec, brief, opt-out).
                GetProductionDesignPrefResponse result = apiInstance.GetProductionDesignPref(cosmeticId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionDesignPref: " + e.Message );
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
 **cosmeticId** | **string**|  | 

### Return type

**GetProductionDesignPrefResponse**

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

<a name="getproductiondrop"></a>
# **GetProductionDrop**
> GetProductionDropResponse GetProductionDrop ()

Limited-edition units you own, with fulfillment status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Limited-edition units you own, with fulfillment status.
                GetProductionDropResponse result = apiInstance.GetProductionDrop();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionDrop: " + e.Message );
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

**GetProductionDropResponse**

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

<a name="getproductionearning"></a>
# **GetProductionEarning**
> GetProductionEarningResponse GetProductionEarning ()

Your CBX earnings from physical production (royalties + balance + lines).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionEarningExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Your CBX earnings from physical production (royalties + balance + lines).
                GetProductionEarningResponse result = apiInstance.GetProductionEarning();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionEarning: " + e.Message );
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

**GetProductionEarningResponse**

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

<a name="getproductionline"></a>
# **GetProductionLine**
> GetProductionLineResponse GetProductionLine ()

Your production lines dashboard (candidate + run + inventory).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Your production lines dashboard (candidate + run + inventory).
                GetProductionLineResponse result = apiInstance.GetProductionLine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionLine: " + e.Message );
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

**GetProductionLineResponse**

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

<a name="getproductionpo"></a>
# **GetProductionPo**
> GetProductionPoResponse GetProductionPo (string candidateId = null)

Ops: list purchase orders (optionally for one candidate). Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionPoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var candidateId = "candidateId_example";  // string |  (optional) 

            try
            {
                // Ops: list purchase orders (optionally for one candidate). Admin PAT only.
                GetProductionPoResponse result = apiInstance.GetProductionPo(candidateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionPo: " + e.Message );
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
 **candidateId** | **string**|  | [optional] 

### Return type

**GetProductionPoResponse**

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

<a name="getproductionporeconcile"></a>
# **GetProductionPoReconcile**
> GetProductionPoReconcileResponse GetProductionPoReconcile (string poId)

Ops: reconcile a PO's actuals against the estimate. Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionPoReconcileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var poId = "poId_example";  // string | 

            try
            {
                // Ops: reconcile a PO's actuals against the estimate. Admin PAT only.
                GetProductionPoReconcileResponse result = apiInstance.GetProductionPoReconcile(poId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionPoReconcile: " + e.Message );
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
 **poId** | **string**|  | 

### Return type

**GetProductionPoReconcileResponse**

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

<a name="getproductionrun"></a>
# **GetProductionRun**
> GetProductionRunResponse GetProductionRun ()

Browse open limited-edition physical runs (graduated designs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProductionRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);

            try
            {
                // Browse open limited-edition physical runs (graduated designs).
                GetProductionRunResponse result = apiInstance.GetProductionRun();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionRun: " + e.Message );
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

**GetProductionRunResponse**

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

<a name="getshoplistingprovenance"></a>
# **GetShopListingProvenance**
> GetShopListingProvenanceResponse GetShopListingProvenance (string slug)

Crossly provenance behind a shop listing: owners on Crossly and since when (never who or for how much). Null when not bought here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetShopListingProvenanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Crossly provenance behind a shop listing: owners on Crossly and since when (never who or for how much). Null when not bought here.
                GetShopListingProvenanceResponse result = apiInstance.GetShopListingProvenance(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetShopListingProvenance: " + e.Message );
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

**GetShopListingProvenanceResponse**

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

<a name="updateproductionpo"></a>
# **UpdateProductionPo**
> UpdateProductionPoResponse UpdateProductionPo (string poId)

Ops: update a PO (supplier, freight, actuals, QC, status). Admin PAT only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateProductionPoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductionApi(config);
            var poId = "poId_example";  // string | 

            try
            {
                // Ops: update a PO (supplier, freight, actuals, QC, status). Admin PAT only.
                UpdateProductionPoResponse result = apiInstance.UpdateProductionPo(poId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.UpdateProductionPo: " + e.Message );
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
 **poId** | **string**|  | 

### Return type

**UpdateProductionPoResponse**

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

