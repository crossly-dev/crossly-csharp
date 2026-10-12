# net.crossly.Api.DefaultApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCosmDesignerChainAutoUnlock**](DefaultApi.md#createcosmdesignerchainautounlock) | **POST** /v1/cosm/designer/chain-auto-unlock | 
[**CreateCosmDesignerChainUnlock**](DefaultApi.md#createcosmdesignerchainunlock) | **POST** /v1/cosm/designer/chain-unlock | 
[**CreateCosmDesignerMaterialise**](DefaultApi.md#createcosmdesignermaterialise) | **POST** /v1/cosm/designer/materialise | 
[**CreateCosmDesignerMaterialiseConfirm**](DefaultApi.md#createcosmdesignermaterialiseconfirm) | **POST** /v1/cosm/designer/materialise/confirm | 
[**CreateCosmDesignerMaterialiseRelease**](DefaultApi.md#createcosmdesignermaterialiserelease) | **POST** /v1/cosm/designer/materialise/release | 
[**CreateCosmDesignerSubmitForReview**](DefaultApi.md#createcosmdesignersubmitforreview) | **POST** /v1/cosm/designer/submit-for-review | 
[**CreateCosmDesignerTerm**](DefaultApi.md#createcosmdesignerterm) | **POST** /v1/cosm/designer/terms | 
[**GetCosmDesignerCopyState**](DefaultApi.md#getcosmdesignercopystate) | **GET** /v1/cosm/designer/copy-state | 
[**GetCosmDesignerEarning**](DefaultApi.md#getcosmdesignerearning) | **GET** /v1/cosm/designer/earnings | 
[**GetCosmDesignerTerm**](DefaultApi.md#getcosmdesignerterm) | **GET** /v1/cosm/designer/terms | 
[**GetListingVariationGroup**](DefaultApi.md#getlistingvariationgroup) | **GET** /v1/listings/{id}/variation-group | 
[**GetMarketMetalSpotHistory**](DefaultApi.md#getmarketmetalspothistory) | **GET** /v1/market/metals/spot/history | 
[**GetMarketProduct**](DefaultApi.md#getmarketproduct) | **GET** /v1/market/products/{id} | 
[**GetMarketProductRelated**](DefaultApi.md#getmarketproductrelated) | **GET** /v1/market/products/{id}/related | 
[**GetMarketScrapQuote**](DefaultApi.md#getmarketscrapquote) | **GET** /v1/market/scrap/quote | 
[**GetMarketVariantBook**](DefaultApi.md#getmarketvariantbook) | **GET** /v1/market/variants/{id}/book | 
[**GetVariationGroup**](DefaultApi.md#getvariationgroup) | **GET** /v1/variation-groups/{id} | 
[**GetVariationGroupPublishPlan**](DefaultApi.md#getvariationgrouppublishplan) | **GET** /v1/variation-groups/{id}/publish-plan | 
[**ListMarketBullion**](DefaultApi.md#listmarketbullion) | **GET** /v1/market/bullion | 
[**ListMarketGraders**](DefaultApi.md#listmarketgraders) | **GET** /v1/market/graders | 
[**ListMarketMetalSpot**](DefaultApi.md#listmarketmetalspot) | **GET** /v1/market/metals/spot | 
[**ListMarketProducts**](DefaultApi.md#listmarketproducts) | **GET** /v1/market/products | 
[**ListMarketVariantTiers**](DefaultApi.md#listmarketvarianttiers) | **GET** /v1/market/variants/{id}/tiers | 
[**ListVariationGroups**](DefaultApi.md#listvariationgroups) | **GET** /v1/variation-groups | 


<a name="createcosmdesignerchainautounlock"></a>
# **CreateCosmDesignerChainAutoUnlock**
> CreateCosmDesignerChainAutoUnlockResponse CreateCosmDesignerChainAutoUnlock (Dictionary<string, Object> requestBody)



Opt a design in or out of the free chain unlock a popular limited design earns (on by default). Designer-only. Answers the popularity of the design toward the bar.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerChainAutoUnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerChainAutoUnlockResponse result = apiInstance.CreateCosmDesignerChainAutoUnlock(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerChainAutoUnlock: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerChainAutoUnlockResponse**

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

<a name="createcosmdesignerchainunlock"></a>
# **CreateCosmDesignerChainUnlock**
> CreateCosmDesignerChainUnlockResponse CreateCosmDesignerChainUnlock (Dictionary<string, Object> requestBody)



Burn COSM to make a design mintable on chain. Designer-only and idempotent: paying twice is impossible, and a second call returns the existing unlock without charging. The fee is DESTROYED rather than collected. Limited editions only. Once unlocked, any holder may take their own copy on chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerChainUnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerChainUnlockResponse result = apiInstance.CreateCosmDesignerChainUnlock(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerChainUnlock: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerChainUnlockResponse**

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

<a name="createcosmdesignermaterialise"></a>
# **CreateCosmDesignerMaterialise**
> CreateCosmDesignerMaterialiseResponse CreateCosmDesignerMaterialise (Dictionary<string, Object> requestBody)



Lock a copy and return an UNSIGNED Metaplex Core mint for the holder to sign. One call: it resolves the designer royalty, locks the copy, publishes immutable content-addressed metadata and builds the transaction — so a lock is never taken without a transaction to go with it, and a failure after the lock releases it. Does NOT void the copy; call confirm once the chain reaches FINALIZED commitment. Every royalty recipient needs a connected wallet first, and the designer must have unlocked the design.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerMaterialiseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerMaterialiseResponse result = apiInstance.CreateCosmDesignerMaterialise(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerMaterialise: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerMaterialiseResponse**

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

<a name="createcosmdesignermaterialiseconfirm"></a>
# **CreateCosmDesignerMaterialiseConfirm**
> CreateCosmDesignerMaterialiseConfirmResponse CreateCosmDesignerMaterialiseConfirm (Dictionary<string, Object> requestBody)



Record a confirmed mint and void the in-world copy, in one transaction. The caller MUST have verified the transaction at finalized commitment first — an NFT recorded against a transaction that never landed cannot be recalled, and the copy it voided is gone. Idempotent on an already-confirmed request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerMaterialiseConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerMaterialiseConfirmResponse result = apiInstance.CreateCosmDesignerMaterialiseConfirm(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerMaterialiseConfirm: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerMaterialiseConfirmResponse**

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

<a name="createcosmdesignermaterialiserelease"></a>
# **CreateCosmDesignerMaterialiseRelease**
> CreateWorldJobShiftReleaseResponse CreateCosmDesignerMaterialiseRelease (Dictionary<string, Object> requestBody)



Release a mint lock that was never signed. The ordinary outcome of somebody closing a wallet prompt, and it leaves the copy exactly as it was. Refuses a request that has already minted, because releasing one would unlock a copy that is on chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerMaterialiseReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateWorldJobShiftReleaseResponse result = apiInstance.CreateCosmDesignerMaterialiseRelease(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerMaterialiseRelease: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateWorldJobShiftReleaseResponse**

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

<a name="createcosmdesignersubmitforreview"></a>
# **CreateCosmDesignerSubmitForReview**
> CreateCosmDesignerSubmitForReviewResponse CreateCosmDesignerSubmitForReview (Dictionary<string, Object> requestBody)



Submit a user-authored design for moderation. Designer-only, and refuses a design with no preview image HERE rather than at approval so the designer learns what is missing while they can still fix it. Submitting twice returns the existing pending review instead of queueing a second one — a moderator facing two reviews of one piece does not know which they are deciding. A design already on sale is refused.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerSubmitForReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerSubmitForReviewResponse result = apiInstance.CreateCosmDesignerSubmitForReview(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerSubmitForReview: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerSubmitForReviewResponse**

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

<a name="createcosmdesignerterm"></a>
# **CreateCosmDesignerTerm**
> CreateCosmDesignerTermResponse CreateCosmDesignerTerm (Dictionary<string, Object> requestBody)



Publish terms for a design. Never edits: every change is a new version, and a copy sold under an earlier one keeps those terms forever. Only the designer may call it. Collaborator shares are of the ROYALTY rather than the sale price and may total at most 100%, with the remainder staying with the designer; a total above 100% is refused rather than scaled down.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmDesignerTermExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                CreateCosmDesignerTermResponse result = apiInstance.CreateCosmDesignerTerm(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCosmDesignerTerm: " + e.Message );
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
 **requestBody** | **Dictionary&lt;string, Object&gt;**|  | 

### Return type

**CreateCosmDesignerTermResponse**

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

<a name="getcosmdesignercopystate"></a>
# **GetCosmDesignerCopyState**
> GetCosmDesignerCopyStateResponse GetCosmDesignerCopyState (Guid ownershipId)



Where a copy currently is: held (in-world, wearable, listable for COSM), minting (locked while a mint is in flight) or materialised (an NFT in the holder wallet). A copy is in exactly one of these, never two.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmDesignerCopyStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ownershipId = "ownershipId_example";  // Guid | 

            try
            {
                GetCosmDesignerCopyStateResponse result = apiInstance.GetCosmDesignerCopyState(ownershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCosmDesignerCopyState: " + e.Message );
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
 **ownershipId** | **Guid**|  | 

### Return type

**GetCosmDesignerCopyStateResponse**

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

<a name="getcosmdesignerearning"></a>
# **GetCosmDesignerEarning**
> GetCosmDesignerEarningResponse GetCosmDesignerEarning (Guid subjectId)



What a designer has earned, in both denominations. COSM royalties come from COSM-priced sales; cash earnings come from cash-priced sales and are funded by the buyer payment itself. The two are never converted into one another, and COSM is never cashed out.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmDesignerEarningExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var subjectId = "subjectId_example";  // Guid | 

            try
            {
                GetCosmDesignerEarningResponse result = apiInstance.GetCosmDesignerEarning(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCosmDesignerEarning: " + e.Message );
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
 **subjectId** | **Guid**|  | 

### Return type

**GetCosmDesignerEarningResponse**

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

<a name="getcosmdesignerterm"></a>
# **GetCosmDesignerTerm**
> GetCosmDesignerTermResponse GetCosmDesignerTerm (Guid cosmeticId)



The published terms for a design: resale, price window, secondary royalty and collaborator splits. Also reports the platform rates a designer does not control, and whether the terms are enforceable on chain — inside Crossly every rule is enforced, but a third-party marketplace honours a royalty voluntarily at best.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmDesignerTermExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var cosmeticId = "cosmeticId_example";  // Guid | 

            try
            {
                GetCosmDesignerTermResponse result = apiInstance.GetCosmDesignerTerm(cosmeticId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCosmDesignerTerm: " + e.Message );
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
 **cosmeticId** | **Guid**|  | 

### Return type

**GetCosmDesignerTermResponse**

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

<a name="getlistingvariationgroup"></a>
# **GetListingVariationGroup**
> GetListingVariationGroupResponse GetListingVariationGroup (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetListingVariationGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                GetListingVariationGroupResponse result = apiInstance.GetListingVariationGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetListingVariationGroup: " + e.Message );
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

**GetListingVariationGroupResponse**

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

<a name="getmarketmetalspothistory"></a>
# **GetMarketMetalSpotHistory**
> GetMarketMetalSpotHistoryResponse GetMarketMetalSpotHistory ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMarketMetalSpotHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                GetMarketMetalSpotHistoryResponse result = apiInstance.GetMarketMetalSpotHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMarketMetalSpotHistory: " + e.Message );
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

**GetMarketMetalSpotHistoryResponse**

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

<a name="getmarketproduct"></a>
# **GetMarketProduct**
> GetMarketProductResponse GetMarketProduct (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMarketProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                GetMarketProductResponse result = apiInstance.GetMarketProduct(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMarketProduct: " + e.Message );
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

**GetMarketProductResponse**

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

<a name="getmarketproductrelated"></a>
# **GetMarketProductRelated**
> GetMarketProductRelatedResponse GetMarketProductRelated (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMarketProductRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                GetMarketProductRelatedResponse result = apiInstance.GetMarketProductRelated(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMarketProductRelated: " + e.Message );
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

**GetMarketProductRelatedResponse**

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

<a name="getmarketscrapquote"></a>
# **GetMarketScrapQuote**
> GetMarketScrapQuoteResponse GetMarketScrapQuote ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMarketScrapQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                GetMarketScrapQuoteResponse result = apiInstance.GetMarketScrapQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMarketScrapQuote: " + e.Message );
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

**GetMarketScrapQuoteResponse**

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

<a name="getmarketvariantbook"></a>
# **GetMarketVariantBook**
> GetMarketVariantBookResponse GetMarketVariantBook (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMarketVariantBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                GetMarketVariantBookResponse result = apiInstance.GetMarketVariantBook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMarketVariantBook: " + e.Message );
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

**GetMarketVariantBookResponse**

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

<a name="getvariationgroup"></a>
# **GetVariationGroup**
> ListVariationGroupsItem GetVariationGroup (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetVariationGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                ListVariationGroupsItem result = apiInstance.GetVariationGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVariationGroup: " + e.Message );
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

**ListVariationGroupsItem**

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

<a name="getvariationgrouppublishplan"></a>
# **GetVariationGroupPublishPlan**
> GetVariationGroupPublishPlanResponse GetVariationGroupPublishPlan (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetVariationGroupPublishPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                GetVariationGroupPublishPlanResponse result = apiInstance.GetVariationGroupPublishPlan(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVariationGroupPublishPlan: " + e.Message );
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

**GetVariationGroupPublishPlanResponse**

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

<a name="listmarketbullion"></a>
# **ListMarketBullion**
> ListMarketBullionResponse ListMarketBullion ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMarketBullionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                ListMarketBullionResponse result = apiInstance.ListMarketBullion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarketBullion: " + e.Message );
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

**ListMarketBullionResponse**

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

<a name="listmarketgraders"></a>
# **ListMarketGraders**
> ListMarketGradersResponse ListMarketGraders ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMarketGradersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                ListMarketGradersResponse result = apiInstance.ListMarketGraders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarketGraders: " + e.Message );
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

**ListMarketGradersResponse**

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

<a name="listmarketmetalspot"></a>
# **ListMarketMetalSpot**
> ListMarketMetalSpotResponse ListMarketMetalSpot ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMarketMetalSpotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                ListMarketMetalSpotResponse result = apiInstance.ListMarketMetalSpot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarketMetalSpot: " + e.Message );
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

**ListMarketMetalSpotResponse**

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

<a name="listmarketproducts"></a>
# **ListMarketProducts**
> ListMarketProductsResponse ListMarketProducts ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMarketProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                ListMarketProductsResponse result = apiInstance.ListMarketProducts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarketProducts: " + e.Message );
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

**ListMarketProductsResponse**

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

<a name="listmarketvarianttiers"></a>
# **ListMarketVariantTiers**
> ListMarketVariantTiersResponse ListMarketVariantTiers (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMarketVariantTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                ListMarketVariantTiersResponse result = apiInstance.ListMarketVariantTiers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarketVariantTiers: " + e.Message );
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

**ListMarketVariantTiersResponse**

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

<a name="listvariationgroups"></a>
# **ListVariationGroups**
> ListVariationGroupsResponse ListVariationGroups ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListVariationGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                ListVariationGroupsResponse result = apiInstance.ListVariationGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListVariationGroups: " + e.Message );
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

**ListVariationGroupsResponse**

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

