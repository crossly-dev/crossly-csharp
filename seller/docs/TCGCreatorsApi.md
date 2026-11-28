# net.crossly.Api.TCGCreatorsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTcgCreatorGame**](TCGCreatorsApi.md#createtcgcreatorgame) | **POST** /v1/tcg/creator/games | Submit a card-game package version for review: game.json, cards.json, rules/game.js, thumb.png, art/_*.png as { path, base64 }. Checked, conformance-run, art quarantined, then reviewed by a person.
[**CreateTcgCreatorGameCheck**](TCGCreatorsApi.md#createtcgcreatorgamecheck) | **POST** /v1/tcg/creator/games/check | Check a card-game package exactly as a submission is checked - - the static report and bot games played against your rules in the sandbox - - storing nothing. Files as { path, base64 }.
[**CreateTcgCreatorGamePackOpen**](TCGCreatorsApi.md#createtcgcreatorgamepackopen) | **POST** /v1/tcg/creator/games/{id}/packs/{packId}/open | Open a booster you hold: the game&#39;s rules pick the pulls, the pack is used up, and one COSM copy per card joins your collection (logged with its seed).
[**CreateTcgCreatorGameStarter**](TCGCreatorsApi.md#createtcgcreatorgamestarter) | **POST** /v1/tcg/creator/games/{id}/starter | Claim a creator game&#39;s free starter deck by its key (once per account; account-bound, never tradeable).
[**CreateTcgCreatorGameVersionWithdraw**](TCGCreatorsApi.md#createtcgcreatorgameversionwithdraw) | **POST** /v1/tcg/creator/games/{id}/versions/{v}/withdraw | Withdraw one of your versions that is still waiting for review.
[**GetTcgCreatorGame**](TCGCreatorsApi.md#gettcgcreatorgame) | **GET** /v1/tcg/creator/games/{id} | One live creator card game: its set, every card (rules text, rarity, art URL, game data) and its COSM prices.
[**GetTcgCreatorGameCollection**](TCGCreatorsApi.md#gettcgcreatorgamecollection) | **GET** /v1/tcg/creator/games/{id}/collection | Your playable copies of a creator game: card id -&gt; copies (free starter plus every COSM copy you hold).
[**GetTcgCreatorGamePopularity**](TCGCreatorsApi.md#gettcgcreatorgamepopularity) | **GET** /v1/tcg/creator/games/{id}/popularity | The set&#39;s progress toward going on chain: distinct collectors, packs opened and resales against the bar; when it passes, every holder may mint their cards as NFTs.
[**GetTcgCreatorGameShelf**](TCGCreatorsApi.md#gettcgcreatorgameshelf) | **GET** /v1/tcg/creator/games/{id}/shelf | The game&#39;s COSM shelf: the booster and every single, each with its COSM design id (buy via /api/v1/cosm/cosmetics/:id/buy), price, edition cap and copies issued.
[**ListTcgCreatorGamePacks**](TCGCreatorsApi.md#listtcgcreatorgamepacks) | **GET** /v1/tcg/creator/games/{id}/packs | Your unopened boosters of a creator game.
[**ListTcgCreatorGames**](TCGCreatorsApi.md#listtcgcreatorgames) | **GET** /v1/tcg/creator/games | Live creator card games: name, set, description, typical match length, frame colours, thumbnail.
[**ListTcgCreatorMine**](TCGCreatorsApi.md#listtcgcreatormine) | **GET** /v1/tcg/creator/mine | Your creator card games and every version with its review state and note.


<a name="createtcgcreatorgame"></a>
# **CreateTcgCreatorGame**
> CreateTcgCreatorGameResponse CreateTcgCreatorGame (CreateTcgCreatorGameRequest createTcgCreatorGameRequest)

Submit a card-game package version for review: game.json, cards.json, rules/game.js, thumb.png, art/_*.png as { path, base64 }. Checked, conformance-run, art quarantined, then reviewed by a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTcgCreatorGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var createTcgCreatorGameRequest = new CreateTcgCreatorGameRequest(); // CreateTcgCreatorGameRequest | 

            try
            {
                // Submit a card-game package version for review: game.json, cards.json, rules/game.js, thumb.png, art/_*.png as { path, base64 }. Checked, conformance-run, art quarantined, then reviewed by a person.
                CreateTcgCreatorGameResponse result = apiInstance.CreateTcgCreatorGame(createTcgCreatorGameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.CreateTcgCreatorGame: " + e.Message );
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
 **createTcgCreatorGameRequest** | **CreateTcgCreatorGameRequest**|  | 

### Return type

**CreateTcgCreatorGameResponse**

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

<a name="createtcgcreatorgamecheck"></a>
# **CreateTcgCreatorGameCheck**
> CreateTcgCreatorGameCheckResponse CreateTcgCreatorGameCheck (CreateTcgCreatorGameRequest createTcgCreatorGameRequest)

Check a card-game package exactly as a submission is checked - - the static report and bot games played against your rules in the sandbox - - storing nothing. Files as { path, base64 }.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTcgCreatorGameCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var createTcgCreatorGameRequest = new CreateTcgCreatorGameRequest(); // CreateTcgCreatorGameRequest | 

            try
            {
                // Check a card-game package exactly as a submission is checked - - the static report and bot games played against your rules in the sandbox - - storing nothing. Files as { path, base64 }.
                CreateTcgCreatorGameCheckResponse result = apiInstance.CreateTcgCreatorGameCheck(createTcgCreatorGameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.CreateTcgCreatorGameCheck: " + e.Message );
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
 **createTcgCreatorGameRequest** | **CreateTcgCreatorGameRequest**|  | 

### Return type

**CreateTcgCreatorGameCheckResponse**

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

<a name="createtcgcreatorgamepackopen"></a>
# **CreateTcgCreatorGamePackOpen**
> CreateTcgCreatorGamePackOpenResponse CreateTcgCreatorGamePackOpen (string id, string packId)

Open a booster you hold: the game's rules pick the pulls, the pack is used up, and one COSM copy per card joins your collection (logged with its seed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTcgCreatorGamePackOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 
            var packId = "packId_example";  // string | 

            try
            {
                // Open a booster you hold: the game's rules pick the pulls, the pack is used up, and one COSM copy per card joins your collection (logged with its seed).
                CreateTcgCreatorGamePackOpenResponse result = apiInstance.CreateTcgCreatorGamePackOpen(id, packId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.CreateTcgCreatorGamePackOpen: " + e.Message );
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
 **packId** | **string**|  | 

### Return type

**CreateTcgCreatorGamePackOpenResponse**

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

<a name="createtcgcreatorgamestarter"></a>
# **CreateTcgCreatorGameStarter**
> CreateTcgStarterResponse CreateTcgCreatorGameStarter (string id, CreateTcgCreatorGameStarterRequest createTcgCreatorGameStarterRequest = null)

Claim a creator game's free starter deck by its key (once per account; account-bound, never tradeable).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTcgCreatorGameStarterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 
            var createTcgCreatorGameStarterRequest = new CreateTcgCreatorGameStarterRequest(); // CreateTcgCreatorGameStarterRequest |  (optional) 

            try
            {
                // Claim a creator game's free starter deck by its key (once per account; account-bound, never tradeable).
                CreateTcgStarterResponse result = apiInstance.CreateTcgCreatorGameStarter(id, createTcgCreatorGameStarterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.CreateTcgCreatorGameStarter: " + e.Message );
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
 **createTcgCreatorGameStarterRequest** | **CreateTcgCreatorGameStarterRequest**|  | [optional] 

### Return type

**CreateTcgStarterResponse**

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

<a name="createtcgcreatorgameversionwithdraw"></a>
# **CreateTcgCreatorGameVersionWithdraw**
> void CreateTcgCreatorGameVersionWithdraw (string id, string v)

Withdraw one of your versions that is still waiting for review.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTcgCreatorGameVersionWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 
            var v = "v_example";  // string | 

            try
            {
                // Withdraw one of your versions that is still waiting for review.
                apiInstance.CreateTcgCreatorGameVersionWithdraw(id, v);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.CreateTcgCreatorGameVersionWithdraw: " + e.Message );
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
 **v** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content — the request succeeded and there is no body. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="gettcgcreatorgame"></a>
# **GetTcgCreatorGame**
> GetTcgCreatorGameResponse GetTcgCreatorGame (string id)

One live creator card game: its set, every card (rules text, rarity, art URL, game data) and its COSM prices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTcgCreatorGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One live creator card game: its set, every card (rules text, rarity, art URL, game data) and its COSM prices.
                GetTcgCreatorGameResponse result = apiInstance.GetTcgCreatorGame(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.GetTcgCreatorGame: " + e.Message );
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

**GetTcgCreatorGameResponse**

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

<a name="gettcgcreatorgamecollection"></a>
# **GetTcgCreatorGameCollection**
> GetTcgCreatorGameCollectionResponse GetTcgCreatorGameCollection (string id)

Your playable copies of a creator game: card id -> copies (free starter plus every COSM copy you hold).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTcgCreatorGameCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Your playable copies of a creator game: card id -> copies (free starter plus every COSM copy you hold).
                GetTcgCreatorGameCollectionResponse result = apiInstance.GetTcgCreatorGameCollection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.GetTcgCreatorGameCollection: " + e.Message );
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

**GetTcgCreatorGameCollectionResponse**

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

<a name="gettcgcreatorgamepopularity"></a>
# **GetTcgCreatorGamePopularity**
> GetTcgCreatorGamePopularityResponse GetTcgCreatorGamePopularity (string id)

The set's progress toward going on chain: distinct collectors, packs opened and resales against the bar; when it passes, every holder may mint their cards as NFTs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTcgCreatorGamePopularityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The set's progress toward going on chain: distinct collectors, packs opened and resales against the bar; when it passes, every holder may mint their cards as NFTs.
                GetTcgCreatorGamePopularityResponse result = apiInstance.GetTcgCreatorGamePopularity(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.GetTcgCreatorGamePopularity: " + e.Message );
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

**GetTcgCreatorGamePopularityResponse**

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

<a name="gettcgcreatorgameshelf"></a>
# **GetTcgCreatorGameShelf**
> GetTcgCreatorGameShelfResponse GetTcgCreatorGameShelf (string id)

The game's COSM shelf: the booster and every single, each with its COSM design id (buy via /api/v1/cosm/cosmetics/:id/buy), price, edition cap and copies issued.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTcgCreatorGameShelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The game's COSM shelf: the booster and every single, each with its COSM design id (buy via /api/v1/cosm/cosmetics/:id/buy), price, edition cap and copies issued.
                GetTcgCreatorGameShelfResponse result = apiInstance.GetTcgCreatorGameShelf(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.GetTcgCreatorGameShelf: " + e.Message );
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

**GetTcgCreatorGameShelfResponse**

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

<a name="listtcgcreatorgamepacks"></a>
# **ListTcgCreatorGamePacks**
> ListTcgCreatorGamePacksResponse ListTcgCreatorGamePacks (string id)

Your unopened boosters of a creator game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTcgCreatorGamePacksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Your unopened boosters of a creator game.
                ListTcgCreatorGamePacksResponse result = apiInstance.ListTcgCreatorGamePacks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.ListTcgCreatorGamePacks: " + e.Message );
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

**ListTcgCreatorGamePacksResponse**

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

<a name="listtcgcreatorgames"></a>
# **ListTcgCreatorGames**
> ListTcgCreatorGamesResponse ListTcgCreatorGames ()

Live creator card games: name, set, description, typical match length, frame colours, thumbnail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTcgCreatorGamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);

            try
            {
                // Live creator card games: name, set, description, typical match length, frame colours, thumbnail.
                ListTcgCreatorGamesResponse result = apiInstance.ListTcgCreatorGames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.ListTcgCreatorGames: " + e.Message );
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

**ListTcgCreatorGamesResponse**

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

<a name="listtcgcreatormine"></a>
# **ListTcgCreatorMine**
> ListTcgCreatorMineResponse ListTcgCreatorMine ()

Your creator card games and every version with its review state and note.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTcgCreatorMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TCGCreatorsApi(config);

            try
            {
                // Your creator card games and every version with its review state and note.
                ListTcgCreatorMineResponse result = apiInstance.ListTcgCreatorMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TCGCreatorsApi.ListTcgCreatorMine: " + e.Message );
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

**ListTcgCreatorMineResponse**

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

