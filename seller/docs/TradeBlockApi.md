# net.crossly.Api.TradeBlockApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTradeBlockEvolutionClaim**](TradeBlockApi.md#createtradeblockevolutionclaim) | **POST** /v1/trade-block/evolutions/{id}/claim | Burn COSM and mint the evolved (or set-master) NFT for one of your unlocks.
[**CreateTradeBlockEvolutionRecipe**](TradeBlockApi.md#createtradeblockevolutionrecipe) | **POST** /v1/trade-block/evolution-recipes | Author a Trade Evolution recipe (a graded item or pair that, when swapped, unlocks a cosmetic you designed). Born unreviewed until ops approves.
[**CreateTradeBlockOfferRespond**](TradeBlockApi.md#createtradeblockofferrespond) | **POST** /v1/trade-block/offers/{id}/respond | Accept, decline, counter, or withdraw a Trade Block offer.
[**CreateTradeBlockPostClose**](TradeBlockApi.md#createtradeblockpostclose) | **POST** /v1/trade-block/posts/{id}/close | Close one of your posts so it stops taking offers.
[**CreateTradeBlockPostOffer**](TradeBlockApi.md#createtradeblockpostoffer) | **POST** /v1/trade-block/posts/{id}/offers | Respond to a post with a concrete swap: items on each side (0..N), optional cash.
[**CreateTradeBlockSetRecipe**](TradeBlockApi.md#createtradeblocksetrecipe) | **POST** /v1/trade-block/set-recipes | Author a set-completion recipe (a set of items that, once assembled through trading, unlocks a set-master cosmetic you designed). Born unreviewed until ops approves.
[**GetTradeBlockEvolution**](TradeBlockApi.md#gettradeblockevolution) | **GET** /v1/trade-block/evolutions | List your Trade Evolution unlocks — completed swaps that unlocked an evolved or set-master NFT you can mint by burning COSM.
[**GetTradeBlockPost**](TradeBlockApi.md#gettradeblockpost) | **GET** /v1/trade-block/posts | Browse open Trade Block posts (wants + offers) on the Crossly Market.
[**GetTradeBlockPostById**](TradeBlockApi.md#gettradeblockpostbyid) | **GET** /v1/trade-block/posts/{id} | Get one Trade Block post with its items and open-offer count.
[**GetTradeBlockTrade**](TradeBlockApi.md#gettradeblocktrade) | **GET** /v1/trade-block/trades | List the trades you are a party to, newest first.


<a name="createtradeblockevolutionclaim"></a>
# **CreateTradeBlockEvolutionClaim**
> CreateTradeBlockEvolutionClaimResponse CreateTradeBlockEvolutionClaim (string id)

Burn COSM and mint the evolved (or set-master) NFT for one of your unlocks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockEvolutionClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Burn COSM and mint the evolved (or set-master) NFT for one of your unlocks.
                CreateTradeBlockEvolutionClaimResponse result = apiInstance.CreateTradeBlockEvolutionClaim(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockEvolutionClaim: " + e.Message );
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

**CreateTradeBlockEvolutionClaimResponse**

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

<a name="createtradeblockevolutionrecipe"></a>
# **CreateTradeBlockEvolutionRecipe**
> CreateTradeBlockEvolutionRecipeResponse CreateTradeBlockEvolutionRecipe ()

Author a Trade Evolution recipe (a graded item or pair that, when swapped, unlocks a cosmetic you designed). Born unreviewed until ops approves.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockEvolutionRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);

            try
            {
                // Author a Trade Evolution recipe (a graded item or pair that, when swapped, unlocks a cosmetic you designed). Born unreviewed until ops approves.
                CreateTradeBlockEvolutionRecipeResponse result = apiInstance.CreateTradeBlockEvolutionRecipe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockEvolutionRecipe: " + e.Message );
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

**CreateTradeBlockEvolutionRecipeResponse**

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

<a name="createtradeblockofferrespond"></a>
# **CreateTradeBlockOfferRespond**
> CreateTradeBlockOfferRespondResponse CreateTradeBlockOfferRespond (string id)

Accept, decline, counter, or withdraw a Trade Block offer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockOfferRespondExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Accept, decline, counter, or withdraw a Trade Block offer.
                CreateTradeBlockOfferRespondResponse result = apiInstance.CreateTradeBlockOfferRespond(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockOfferRespond: " + e.Message );
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

**CreateTradeBlockOfferRespondResponse**

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

<a name="createtradeblockpostclose"></a>
# **CreateTradeBlockPostClose**
> OkResponse CreateTradeBlockPostClose (string id)

Close one of your posts so it stops taking offers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockPostCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Close one of your posts so it stops taking offers.
                OkResponse result = apiInstance.CreateTradeBlockPostClose(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockPostClose: " + e.Message );
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

<a name="createtradeblockpostoffer"></a>
# **CreateTradeBlockPostOffer**
> IdResponse CreateTradeBlockPostOffer (string id)

Respond to a post with a concrete swap: items on each side (0..N), optional cash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockPostOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Respond to a post with a concrete swap: items on each side (0..N), optional cash.
                IdResponse result = apiInstance.CreateTradeBlockPostOffer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockPostOffer: " + e.Message );
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

**IdResponse**

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

<a name="createtradeblocksetrecipe"></a>
# **CreateTradeBlockSetRecipe**
> CreateTradeBlockSetRecipeResponse CreateTradeBlockSetRecipe ()

Author a set-completion recipe (a set of items that, once assembled through trading, unlocks a set-master cosmetic you designed). Born unreviewed until ops approves.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTradeBlockSetRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);

            try
            {
                // Author a set-completion recipe (a set of items that, once assembled through trading, unlocks a set-master cosmetic you designed). Born unreviewed until ops approves.
                CreateTradeBlockSetRecipeResponse result = apiInstance.CreateTradeBlockSetRecipe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.CreateTradeBlockSetRecipe: " + e.Message );
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

**CreateTradeBlockSetRecipeResponse**

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

<a name="gettradeblockevolution"></a>
# **GetTradeBlockEvolution**
> GetTradeBlockEvolutionResponse GetTradeBlockEvolution ()

List your Trade Evolution unlocks — completed swaps that unlocked an evolved or set-master NFT you can mint by burning COSM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTradeBlockEvolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);

            try
            {
                // List your Trade Evolution unlocks — completed swaps that unlocked an evolved or set-master NFT you can mint by burning COSM.
                GetTradeBlockEvolutionResponse result = apiInstance.GetTradeBlockEvolution();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.GetTradeBlockEvolution: " + e.Message );
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

**GetTradeBlockEvolutionResponse**

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

<a name="gettradeblockpost"></a>
# **GetTradeBlockPost**
> GetTradeBlockPostResponse GetTradeBlockPost (string kind = null, string categorySlug = null, string brand = null, string model = null, string q = null, int? limit = null, int? offset = null)

Browse open Trade Block posts (wants + offers) on the Crossly Market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTradeBlockPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var kind = "want";  // string | Filter to wants or offers. (optional) 
            var categorySlug = "categorySlug_example";  // string | Filter to a market category. (optional) 
            var brand = "brand_example";  // string | Filter to posts with a product of this brand (case-insensitive). (optional) 
            var model = "model_example";  // string | Filter to posts with a product of this catalogue model (case-insensitive). (optional) 
            var q = "q_example";  // string | Search title + want text. (optional) 
            var limit = 40;  // int? |  (optional)  (default to 40)
            var offset = 0;  // int? |  (optional)  (default to 0)

            try
            {
                // Browse open Trade Block posts (wants + offers) on the Crossly Market.
                GetTradeBlockPostResponse result = apiInstance.GetTradeBlockPost(kind, categorySlug, brand, model, q, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.GetTradeBlockPost: " + e.Message );
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
 **kind** | **string**| Filter to wants or offers. | [optional] 
 **categorySlug** | **string**| Filter to a market category. | [optional] 
 **brand** | **string**| Filter to posts with a product of this brand (case-insensitive). | [optional] 
 **model** | **string**| Filter to posts with a product of this catalogue model (case-insensitive). | [optional] 
 **q** | **string**| Search title + want text. | [optional] 
 **limit** | **int?**|  | [optional] [default to 40]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

**GetTradeBlockPostResponse**

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

<a name="gettradeblockpostbyid"></a>
# **GetTradeBlockPostById**
> GetTradeBlockPostByIdResponse GetTradeBlockPostById (string id)

Get one Trade Block post with its items and open-offer count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTradeBlockPostByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Get one Trade Block post with its items and open-offer count.
                GetTradeBlockPostByIdResponse result = apiInstance.GetTradeBlockPostById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.GetTradeBlockPostById: " + e.Message );
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

**GetTradeBlockPostByIdResponse**

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

<a name="gettradeblocktrade"></a>
# **GetTradeBlockTrade**
> GetTradeBlockTradeResponse GetTradeBlockTrade ()

List the trades you are a party to, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTradeBlockTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeBlockApi(config);

            try
            {
                // List the trades you are a party to, newest first.
                GetTradeBlockTradeResponse result = apiInstance.GetTradeBlockTrade();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeBlockApi.GetTradeBlockTrade: " + e.Message );
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

**GetTradeBlockTradeResponse**

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

