# net.crossly.Api.StorefrontApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStorefrontHighlight**](StorefrontApi.md#createstorefronthighlight) | **POST** /v1/storefront/highlights | Create a highlight: title (up to 24 characters), optional coverUrl, and optional storyIds (your live or archived stories) to save into it. Up to 50 per store.
[**CreateStorefrontHighlightItem**](StorefrontApi.md#createstorefronthighlightitem) | **POST** /v1/storefront/highlights/{id}/items | Save stories into a highlight (appended in the order given). Each is copied, so it stays after the story expires. A story already in the highlight is skipped.
[**CreateStorefrontProfileSuggestShelve**](StorefrontApi.md#createstorefrontprofilesuggestshelve) | **POST** /v1/storefront/profile/suggest-shelves | Profile shelves proposed from your top tags and categories (not saved).
[**CreateStorefrontSection**](StorefrontApi.md#createstorefrontsection) | **POST** /v1/storefront/sections | Add a section at the bottom: kind hero | listings | collections | about | policies | social | announcement | faq (default listings), with its config.
[**CreateStorefrontSitePreview**](StorefrontApi.md#createstorefrontsitepreview) | **POST** /v1/storefront/site/preview | Resolve an unsaved design page like the live site would: every section with its listings and extras (preview: true).
[**CreateStorefrontSitePublish**](StorefrontApi.md#createstorefrontsitepublish) | **POST** /v1/storefront/site/publish | Publish the draft: it becomes the live site and a publish version is kept (the last 30 versions are kept).
[**CreateStorefrontSiteResolve**](StorefrontApi.md#createstorefrontsiteresolve) | **POST** /v1/storefront/site/resolve | The live listings a ListingSource (manual, tags, category, smart rule or all) selects from your store, and how many match.
[**CreateStorefrontSiteStarter**](StorefrontApi.md#createstorefrontsitestarter) | **POST** /v1/storefront/site/starter | Replace the draft with a starter site (vintage, sneakers, streetwear, collectibles, boutique, home, minimal, drop, general). The current draft is kept as a version first.
[**CreateStorefrontSiteSuggest**](StorefrontApi.md#createstorefrontsitesuggest) | **POST** /v1/storefront/site/suggest | Auto-build: website sections proposed from your top tags and categories (not saved).
[**CreateStorefrontSiteVersionRestore**](StorefrontApi.md#createstorefrontsiteversionrestore) | **POST** /v1/storefront/site/versions/{id}/restore | Copy a saved version into the draft (the current draft is kept as a version first). Publish to make it live.
[**CreateStorefrontTradeSitePublish**](StorefrontApi.md#createstorefronttradesitepublish) | **POST** /v1/storefront/trade-site/publish | Publish the trade site draft (a version is kept).
[**CreateStorefrontTradeSiteResolve**](StorefrontApi.md#createstorefronttradesiteresolve) | **POST** /v1/storefront/trade-site/resolve | The listings a ListingSource selects on your trade site: only items in your active wholesale catalogs (narrowed further by source.catalogIds), and how many match.
[**CreateStorefrontTradeSiteStarter**](StorefrontApi.md#createstorefronttradesitestarter) | **POST** /v1/storefront/trade-site/starter | Replace the trade site draft with a trade starter (trade_classic, trade_line_sheet, trade_brand_house, trade_apply_first). The current draft is kept as a version first.
[**CreateStorefrontTradeSiteSuggest**](StorefrontApi.md#createstorefronttradesitesuggest) | **POST** /v1/storefront/trade-site/suggest | Trade Auto-build: trade site sections proposed from your wholesale catalogs (a spotlight, a rail per catalog, terms, apply banner). Not saved.
[**DeleteStorefrontHighlight**](StorefrontApi.md#deletestorefronthighlight) | **DELETE** /v1/storefront/highlights/{id} | Delete a highlight and its saved stories. The original stories are unaffected.
[**DeleteStorefrontHighlightItem**](StorefrontApi.md#deletestorefronthighlightitem) | **DELETE** /v1/storefront/highlights/{id}/items/{itemId} | Remove one saved story from a highlight.
[**DeleteStorefrontSection**](StorefrontApi.md#deletestorefrontsection) | **DELETE** /v1/storefront/sections/{id} | Remove a section. Listings on a removed shelf stay live.
[**GetStorefront**](StorefrontApi.md#getstorefront) | **GET** /v1/storefront | Your storefront design: banner, logo, tagline, bio, theme, SEO title and description, social links, and whether it is published.
[**GetStorefrontMerch**](StorefrontApi.md#getstorefrontmerch) | **GET** /v1/storefront/merch | Your store&#39;s live listings by tag, category, condition and brand, with the price range: what product sources can select.
[**GetStorefrontProfile**](StorefrontApi.md#getstorefrontprofile) | **GET** /v1/storefront/profile | Your shop profile (the Crossly Shop page): banner, logo, tagline, bio, accent, announcement, shelves, blocks and All items options.
[**GetStorefrontShipping**](StorefrontApi.md#getstorefrontshipping) | **GET** /v1/storefront/shipping | Your Crossly shipping policy (domestic and international services, which countries you ship to) and the default ship-from address of the store named by X-Storefront-Id (else your default store).
[**GetStorefrontSite**](StorefrontApi.md#getstorefrontsite) | **GET** /v1/storefront/site | Your store website: the draft design, what is live, when each changed, whether the site is switched on, and its custom domain.
[**GetStorefrontTradeSite**](StorefrontApi.md#getstorefronttradesite) | **GET** /v1/storefront/trade-site | Your store&#39;s trade (wholesale) site at /site/:slug/trade: the draft, what is live, whether it is on and its gating (public | prices_private | approved_only).
[**ListStorefrontHighlights**](StorefrontApi.md#liststorefronthighlights) | **GET** /v1/storefront/highlights | Your store’s story highlights in display order, each with its saved stories (media, overlays, product tie-in, when posted). Empty highlights included.
[**ListStorefrontSections**](StorefrontApi.md#liststorefrontsections) | **GET** /v1/storefront/sections | Your storefront sections in display order: kind, title, visible, config, and listing ids for listings shelves.
[**ListStorefrontSiteVersions**](StorefrontApi.md#liststorefrontsiteversions) | **GET** /v1/storefront/site/versions | Saved versions of the website, newest first (publish, restore and template points; up to 30).
[**ListStorefrontStoryArchive**](StorefrontApi.md#liststorefrontstoryarchive) | **GET** /v1/storefront/stories/archive | Your stories, live and expired, newest first: what can be saved to a highlight. Paginated: pass before &#x3D; meta.nextCursor of the previous page.
[**UpdateStorefront**](StorefrontApi.md#updatestorefront) | **PUT** /v1/storefront | Update your storefront design. Omitted fields are unchanged, null clears. published&#x3D;false keeps the design as a draft and buyers see the standard storefront.
[**UpdateStorefrontHighlight**](StorefrontApi.md#updatestorefronthighlight) | **PATCH** /v1/storefront/highlights/{id} | Rename a highlight or change its cover (coverUrl null &#x3D; use the first story).
[**UpdateStorefrontHighlightItemOrder**](StorefrontApi.md#updatestorefronthighlightitemorder) | **PUT** /v1/storefront/highlights/{id}/items/order | Set the order of a highlight’s saved stories: every item id, first to last.
[**UpdateStorefrontHighlightOrder**](StorefrontApi.md#updatestorefronthighlightorder) | **PUT** /v1/storefront/highlights/order | Set the highlight order in one call: every highlight id, first to last.
[**UpdateStorefrontProfile**](StorefrontApi.md#updatestorefrontprofile) | **PUT** /v1/storefront/profile | Replace your shop profile (a complete ShopProfile). Saved straight away.
[**UpdateStorefrontSection**](StorefrontApi.md#updatestorefrontsection) | **PATCH** /v1/storefront/sections/{id} | Rename, show/hide, refill (listings shelves) or reconfigure a section.
[**UpdateStorefrontSectionReorder**](StorefrontApi.md#updatestorefrontsectionreorder) | **PUT** /v1/storefront/sections/reorder | Set the section order in one atomic call: every section id, top to bottom.
[**UpdateStorefrontShipping**](StorefrontApi.md#updatestorefrontshipping) | **PUT** /v1/storefront/shipping | Set your shipping policy (international.enabled, shipsTo worldwide or ISO codes, excludes) and/or the default ship-from address of the store named by X-Storefront-Id, else your default store (any country; 422 for a sanctioned origin).
[**UpdateStorefrontSiteDraft**](StorefrontApi.md#updatestorefrontsitedraft) | **PUT** /v1/storefront/site/draft | Save the website draft (a complete SiteDesign). Validated strictly (a bad field is a 400 naming its path) and sanitized; buyers see nothing until you publish.
[**UpdateStorefrontSiteEnabled**](StorefrontApi.md#updatestorefrontsiteenabled) | **PUT** /v1/storefront/site/enabled | Switch the website on or off. On requires a publish first; off makes /site/:slug 404 and the custom domain show the shop profile.
[**UpdateStorefrontTradeSiteDraft**](StorefrontApi.md#updatestorefronttradesitedraft) | **PUT** /v1/storefront/trade-site/draft | Save the trade site draft (a complete SiteDesign; trade sections included). Validated strictly and sanitized.
[**UpdateStorefrontTradeSiteEnabled**](StorefrontApi.md#updatestorefronttradesiteenabled) | **PUT** /v1/storefront/trade-site/enabled | Switch the trade site on (needs a publish first) or off.
[**UpdateStorefrontTradeSiteGating**](StorefrontApi.md#updatestorefronttradesitegating) | **PUT** /v1/storefront/trade-site/gating | Who sees the trade site: public (everyone, with prices), prices_private (everyone, prices for approved buyers) or approved_only (approved buyers; others get the apply page).


<a name="createstorefronthighlight"></a>
# **CreateStorefrontHighlight**
> CreateStorefrontHighlightResponse CreateStorefrontHighlight (CreateStorefrontHighlightRequest createStorefrontHighlightRequest = null)

Create a highlight: title (up to 24 characters), optional coverUrl, and optional storyIds (your live or archived stories) to save into it. Up to 50 per store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontHighlightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createStorefrontHighlightRequest = new CreateStorefrontHighlightRequest(); // CreateStorefrontHighlightRequest |  (optional) 

            try
            {
                // Create a highlight: title (up to 24 characters), optional coverUrl, and optional storyIds (your live or archived stories) to save into it. Up to 50 per store.
                CreateStorefrontHighlightResponse result = apiInstance.CreateStorefrontHighlight(createStorefrontHighlightRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontHighlight: " + e.Message );
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
 **createStorefrontHighlightRequest** | **CreateStorefrontHighlightRequest**|  | [optional] 

### Return type

**CreateStorefrontHighlightResponse**

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

<a name="createstorefronthighlightitem"></a>
# **CreateStorefrontHighlightItem**
> StorefrontHighlightResponse CreateStorefrontHighlightItem (string id, CreateStorefrontHighlightItemRequest createStorefrontHighlightItemRequest = null)

Save stories into a highlight (appended in the order given). Each is copied, so it stays after the story expires. A story already in the highlight is skipped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontHighlightItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 
            var createStorefrontHighlightItemRequest = new CreateStorefrontHighlightItemRequest(); // CreateStorefrontHighlightItemRequest |  (optional) 

            try
            {
                // Save stories into a highlight (appended in the order given). Each is copied, so it stays after the story expires. A story already in the highlight is skipped.
                StorefrontHighlightResponse result = apiInstance.CreateStorefrontHighlightItem(id, createStorefrontHighlightItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontHighlightItem: " + e.Message );
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
 **createStorefrontHighlightItemRequest** | **CreateStorefrontHighlightItemRequest**|  | [optional] 

### Return type

**StorefrontHighlightResponse**

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

<a name="createstorefrontprofilesuggestshelve"></a>
# **CreateStorefrontProfileSuggestShelve**
> CreateStorefrontProfileSuggestShelveResponse CreateStorefrontProfileSuggestShelve ()

Profile shelves proposed from your top tags and categories (not saved).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontProfileSuggestShelveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Profile shelves proposed from your top tags and categories (not saved).
                CreateStorefrontProfileSuggestShelveResponse result = apiInstance.CreateStorefrontProfileSuggestShelve();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontProfileSuggestShelve: " + e.Message );
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

**CreateStorefrontProfileSuggestShelveResponse**

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

<a name="createstorefrontsection"></a>
# **CreateStorefrontSection**
> StorefrontSectionResponse CreateStorefrontSection (CreateStorefrontSectionRequest createStorefrontSectionRequest = null)

Add a section at the bottom: kind hero | listings | collections | about | policies | social | announcement | faq (default listings), with its config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createStorefrontSectionRequest = new CreateStorefrontSectionRequest(); // CreateStorefrontSectionRequest |  (optional) 

            try
            {
                // Add a section at the bottom: kind hero | listings | collections | about | policies | social | announcement | faq (default listings), with its config.
                StorefrontSectionResponse result = apiInstance.CreateStorefrontSection(createStorefrontSectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSection: " + e.Message );
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
 **createStorefrontSectionRequest** | **CreateStorefrontSectionRequest**|  | [optional] 

### Return type

**StorefrontSectionResponse**

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

<a name="createstorefrontsitepreview"></a>
# **CreateStorefrontSitePreview**
> CreateStorefrontSitePreviewResponse CreateStorefrontSitePreview ()

Resolve an unsaved design page like the live site would: every section with its listings and extras (preview: true).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSitePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Resolve an unsaved design page like the live site would: every section with its listings and extras (preview: true).
                CreateStorefrontSitePreviewResponse result = apiInstance.CreateStorefrontSitePreview();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSitePreview: " + e.Message );
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

**CreateStorefrontSitePreviewResponse**

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

<a name="createstorefrontsitepublish"></a>
# **CreateStorefrontSitePublish**
> StorefrontResponse2 CreateStorefrontSitePublish ()

Publish the draft: it becomes the live site and a publish version is kept (the last 30 versions are kept).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSitePublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Publish the draft: it becomes the live site and a publish version is kept (the last 30 versions are kept).
                StorefrontResponse2 result = apiInstance.CreateStorefrontSitePublish();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSitePublish: " + e.Message );
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

**StorefrontResponse2**

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

<a name="createstorefrontsiteresolve"></a>
# **CreateStorefrontSiteResolve**
> CreateStorefrontSiteResolveResponse CreateStorefrontSiteResolve ()

The live listings a ListingSource (manual, tags, category, smart rule or all) selects from your store, and how many match.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSiteResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // The live listings a ListingSource (manual, tags, category, smart rule or all) selects from your store, and how many match.
                CreateStorefrontSiteResolveResponse result = apiInstance.CreateStorefrontSiteResolve();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSiteResolve: " + e.Message );
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

**CreateStorefrontSiteResolveResponse**

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

<a name="createstorefrontsitestarter"></a>
# **CreateStorefrontSiteStarter**
> StorefrontResponse2 CreateStorefrontSiteStarter ()

Replace the draft with a starter site (vintage, sneakers, streetwear, collectibles, boutique, home, minimal, drop, general). The current draft is kept as a version first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSiteStarterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Replace the draft with a starter site (vintage, sneakers, streetwear, collectibles, boutique, home, minimal, drop, general). The current draft is kept as a version first.
                StorefrontResponse2 result = apiInstance.CreateStorefrontSiteStarter();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSiteStarter: " + e.Message );
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

**StorefrontResponse2**

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

<a name="createstorefrontsitesuggest"></a>
# **CreateStorefrontSiteSuggest**
> CreateStorefrontSiteSuggestResponse CreateStorefrontSiteSuggest ()

Auto-build: website sections proposed from your top tags and categories (not saved).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSiteSuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Auto-build: website sections proposed from your top tags and categories (not saved).
                CreateStorefrontSiteSuggestResponse result = apiInstance.CreateStorefrontSiteSuggest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSiteSuggest: " + e.Message );
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

**CreateStorefrontSiteSuggestResponse**

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

<a name="createstorefrontsiteversionrestore"></a>
# **CreateStorefrontSiteVersionRestore**
> StorefrontResponse3 CreateStorefrontSiteVersionRestore (string id)

Copy a saved version into the draft (the current draft is kept as a version first). Publish to make it live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontSiteVersionRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Copy a saved version into the draft (the current draft is kept as a version first). Publish to make it live.
                StorefrontResponse3 result = apiInstance.CreateStorefrontSiteVersionRestore(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontSiteVersionRestore: " + e.Message );
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

**StorefrontResponse3**

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

<a name="createstorefronttradesitepublish"></a>
# **CreateStorefrontTradeSitePublish**
> StorefrontResponse2 CreateStorefrontTradeSitePublish (CreateStorefrontTradeSitePublishRequest createStorefrontTradeSitePublishRequest = null)

Publish the trade site draft (a version is kept).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontTradeSitePublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createStorefrontTradeSitePublishRequest = new CreateStorefrontTradeSitePublishRequest(); // CreateStorefrontTradeSitePublishRequest |  (optional) 

            try
            {
                // Publish the trade site draft (a version is kept).
                StorefrontResponse2 result = apiInstance.CreateStorefrontTradeSitePublish(createStorefrontTradeSitePublishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontTradeSitePublish: " + e.Message );
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
 **createStorefrontTradeSitePublishRequest** | **CreateStorefrontTradeSitePublishRequest**|  | [optional] 

### Return type

**StorefrontResponse2**

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

<a name="createstorefronttradesiteresolve"></a>
# **CreateStorefrontTradeSiteResolve**
> CreateStorefrontSiteResolveResponse CreateStorefrontTradeSiteResolve (CreateStorefrontTradeSiteResolveRequest createStorefrontTradeSiteResolveRequest = null)

The listings a ListingSource selects on your trade site: only items in your active wholesale catalogs (narrowed further by source.catalogIds), and how many match.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontTradeSiteResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createStorefrontTradeSiteResolveRequest = new CreateStorefrontTradeSiteResolveRequest(); // CreateStorefrontTradeSiteResolveRequest |  (optional) 

            try
            {
                // The listings a ListingSource selects on your trade site: only items in your active wholesale catalogs (narrowed further by source.catalogIds), and how many match.
                CreateStorefrontSiteResolveResponse result = apiInstance.CreateStorefrontTradeSiteResolve(createStorefrontTradeSiteResolveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontTradeSiteResolve: " + e.Message );
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
 **createStorefrontTradeSiteResolveRequest** | **CreateStorefrontTradeSiteResolveRequest**|  | [optional] 

### Return type

**CreateStorefrontSiteResolveResponse**

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

<a name="createstorefronttradesitestarter"></a>
# **CreateStorefrontTradeSiteStarter**
> StorefrontResponse2 CreateStorefrontTradeSiteStarter (CreateStorefrontTradeSiteStarterRequest createStorefrontTradeSiteStarterRequest = null)

Replace the trade site draft with a trade starter (trade_classic, trade_line_sheet, trade_brand_house, trade_apply_first). The current draft is kept as a version first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontTradeSiteStarterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createStorefrontTradeSiteStarterRequest = new CreateStorefrontTradeSiteStarterRequest(); // CreateStorefrontTradeSiteStarterRequest |  (optional) 

            try
            {
                // Replace the trade site draft with a trade starter (trade_classic, trade_line_sheet, trade_brand_house, trade_apply_first). The current draft is kept as a version first.
                StorefrontResponse2 result = apiInstance.CreateStorefrontTradeSiteStarter(createStorefrontTradeSiteStarterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontTradeSiteStarter: " + e.Message );
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
 **createStorefrontTradeSiteStarterRequest** | **CreateStorefrontTradeSiteStarterRequest**|  | [optional] 

### Return type

**StorefrontResponse2**

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

<a name="createstorefronttradesitesuggest"></a>
# **CreateStorefrontTradeSiteSuggest**
> CreateStorefrontSiteSuggestResponse CreateStorefrontTradeSiteSuggest ()

Trade Auto-build: trade site sections proposed from your wholesale catalogs (a spotlight, a rail per catalog, terms, apply banner). Not saved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStorefrontTradeSiteSuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Trade Auto-build: trade site sections proposed from your wholesale catalogs (a spotlight, a rail per catalog, terms, apply banner). Not saved.
                CreateStorefrontSiteSuggestResponse result = apiInstance.CreateStorefrontTradeSiteSuggest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.CreateStorefrontTradeSiteSuggest: " + e.Message );
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

**CreateStorefrontSiteSuggestResponse**

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

<a name="deletestorefronthighlight"></a>
# **DeleteStorefrontHighlight**
> DeleteStoryResponse DeleteStorefrontHighlight (string id)

Delete a highlight and its saved stories. The original stories are unaffected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteStorefrontHighlightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a highlight and its saved stories. The original stories are unaffected.
                DeleteStoryResponse result = apiInstance.DeleteStorefrontHighlight(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteStorefrontHighlight: " + e.Message );
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

**DeleteStoryResponse**

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

<a name="deletestorefronthighlightitem"></a>
# **DeleteStorefrontHighlightItem**
> StorefrontHighlightResponse DeleteStorefrontHighlightItem (string id, string itemId)

Remove one saved story from a highlight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteStorefrontHighlightItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 
            var itemId = "itemId_example";  // string | 

            try
            {
                // Remove one saved story from a highlight.
                StorefrontHighlightResponse result = apiInstance.DeleteStorefrontHighlightItem(id, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteStorefrontHighlightItem: " + e.Message );
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
 **itemId** | **string**|  | 

### Return type

**StorefrontHighlightResponse**

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

<a name="deletestorefrontsection"></a>
# **DeleteStorefrontSection**
> UpdateGroupBuyResponse DeleteStorefrontSection (string id)

Remove a section. Listings on a removed shelf stay live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteStorefrontSectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Remove a section. Listings on a removed shelf stay live.
                UpdateGroupBuyResponse result = apiInstance.DeleteStorefrontSection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.DeleteStorefrontSection: " + e.Message );
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

**UpdateGroupBuyResponse**

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

<a name="getstorefront"></a>
# **GetStorefront**
> GetStorefrontResponse GetStorefront ()

Your storefront design: banner, logo, tagline, bio, theme, SEO title and description, social links, and whether it is published.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your storefront design: banner, logo, tagline, bio, theme, SEO title and description, social links, and whether it is published.
                GetStorefrontResponse result = apiInstance.GetStorefront();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefront: " + e.Message );
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

**GetStorefrontResponse**

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

<a name="getstorefrontmerch"></a>
# **GetStorefrontMerch**
> GetStorefrontMerchResponse GetStorefrontMerch ()

Your store's live listings by tag, category, condition and brand, with the price range: what product sources can select.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontMerchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your store's live listings by tag, category, condition and brand, with the price range: what product sources can select.
                GetStorefrontMerchResponse result = apiInstance.GetStorefrontMerch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontMerch: " + e.Message );
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

**GetStorefrontMerchResponse**

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

<a name="getstorefrontprofile"></a>
# **GetStorefrontProfile**
> GetStorefrontProfileResponse GetStorefrontProfile ()

Your shop profile (the Crossly Shop page): banner, logo, tagline, bio, accent, announcement, shelves, blocks and All items options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your shop profile (the Crossly Shop page): banner, logo, tagline, bio, accent, announcement, shelves, blocks and All items options.
                GetStorefrontProfileResponse result = apiInstance.GetStorefrontProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontProfile: " + e.Message );
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

**GetStorefrontProfileResponse**

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

<a name="getstorefrontshipping"></a>
# **GetStorefrontShipping**
> GetStorefrontShippingResponse GetStorefrontShipping ()

Your Crossly shipping policy (domestic and international services, which countries you ship to) and the default ship-from address of the store named by X-Storefront-Id (else your default store).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontShippingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your Crossly shipping policy (domestic and international services, which countries you ship to) and the default ship-from address of the store named by X-Storefront-Id (else your default store).
                GetStorefrontShippingResponse result = apiInstance.GetStorefrontShipping();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontShipping: " + e.Message );
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

**GetStorefrontShippingResponse**

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

<a name="getstorefrontsite"></a>
# **GetStorefrontSite**
> StorefrontResponse3 GetStorefrontSite ()

Your store website: the draft design, what is live, when each changed, whether the site is switched on, and its custom domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontSiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your store website: the draft design, what is live, when each changed, whether the site is switched on, and its custom domain.
                StorefrontResponse3 result = apiInstance.GetStorefrontSite();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontSite: " + e.Message );
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

**StorefrontResponse3**

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

<a name="getstorefronttradesite"></a>
# **GetStorefrontTradeSite**
> StorefrontResponse3 GetStorefrontTradeSite ()

Your store's trade (wholesale) site at /site/:slug/trade: the draft, what is live, whether it is on and its gating (public | prices_private | approved_only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStorefrontTradeSiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your store's trade (wholesale) site at /site/:slug/trade: the draft, what is live, whether it is on and its gating (public | prices_private | approved_only).
                StorefrontResponse3 result = apiInstance.GetStorefrontTradeSite();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontTradeSite: " + e.Message );
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

**StorefrontResponse3**

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

<a name="liststorefronthighlights"></a>
# **ListStorefrontHighlights**
> ListStorefrontHighlightsResponse ListStorefrontHighlights ()

Your store’s story highlights in display order, each with its saved stories (media, overlays, product tie-in, when posted). Empty highlights included.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStorefrontHighlightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your store’s story highlights in display order, each with its saved stories (media, overlays, product tie-in, when posted). Empty highlights included.
                ListStorefrontHighlightsResponse result = apiInstance.ListStorefrontHighlights();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.ListStorefrontHighlights: " + e.Message );
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

**ListStorefrontHighlightsResponse**

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

<a name="liststorefrontsections"></a>
# **ListStorefrontSections**
> StorefrontResponse4 ListStorefrontSections ()

Your storefront sections in display order: kind, title, visible, config, and listing ids for listings shelves.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStorefrontSectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Your storefront sections in display order: kind, title, visible, config, and listing ids for listings shelves.
                StorefrontResponse4 result = apiInstance.ListStorefrontSections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.ListStorefrontSections: " + e.Message );
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

**StorefrontResponse4**

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

<a name="liststorefrontsiteversions"></a>
# **ListStorefrontSiteVersions**
> ListStorefrontSiteVersionsResponse ListStorefrontSiteVersions ()

Saved versions of the website, newest first (publish, restore and template points; up to 30).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStorefrontSiteVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Saved versions of the website, newest first (publish, restore and template points; up to 30).
                ListStorefrontSiteVersionsResponse result = apiInstance.ListStorefrontSiteVersions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.ListStorefrontSiteVersions: " + e.Message );
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

**ListStorefrontSiteVersionsResponse**

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

<a name="liststorefrontstoryarchive"></a>
# **ListStorefrontStoryArchive**
> ListStorefrontStoryArchiveResponse ListStorefrontStoryArchive (string before = null, decimal? limit = null)

Your stories, live and expired, newest first: what can be saved to a highlight. Paginated: pass before = meta.nextCursor of the previous page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStorefrontStoryArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var before = "before_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Your stories, live and expired, newest first: what can be saved to a highlight. Paginated: pass before = meta.nextCursor of the previous page.
                ListStorefrontStoryArchiveResponse result = apiInstance.ListStorefrontStoryArchive(before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.ListStorefrontStoryArchive: " + e.Message );
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
 **before** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListStorefrontStoryArchiveResponse**

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

<a name="updatestorefront"></a>
# **UpdateStorefront**
> GetStorefrontResponse UpdateStorefront (UpdateStorefrontRequest updateStorefrontRequest = null)

Update your storefront design. Omitted fields are unchanged, null clears. published=false keeps the design as a draft and buyers see the standard storefront.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var updateStorefrontRequest = new UpdateStorefrontRequest(); // UpdateStorefrontRequest |  (optional) 

            try
            {
                // Update your storefront design. Omitted fields are unchanged, null clears. published=false keeps the design as a draft and buyers see the standard storefront.
                GetStorefrontResponse result = apiInstance.UpdateStorefront(updateStorefrontRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefront: " + e.Message );
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
 **updateStorefrontRequest** | **UpdateStorefrontRequest**|  | [optional] 

### Return type

**GetStorefrontResponse**

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

<a name="updatestorefronthighlight"></a>
# **UpdateStorefrontHighlight**
> StorefrontHighlightResponse UpdateStorefrontHighlight (string id, UpdateStorefrontHighlightRequest updateStorefrontHighlightRequest = null)

Rename a highlight or change its cover (coverUrl null = use the first story).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontHighlightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 
            var updateStorefrontHighlightRequest = new UpdateStorefrontHighlightRequest(); // UpdateStorefrontHighlightRequest |  (optional) 

            try
            {
                // Rename a highlight or change its cover (coverUrl null = use the first story).
                StorefrontHighlightResponse result = apiInstance.UpdateStorefrontHighlight(id, updateStorefrontHighlightRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontHighlight: " + e.Message );
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
 **updateStorefrontHighlightRequest** | **UpdateStorefrontHighlightRequest**|  | [optional] 

### Return type

**StorefrontHighlightResponse**

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

<a name="updatestorefronthighlightitemorder"></a>
# **UpdateStorefrontHighlightItemOrder**
> StorefrontHighlightResponse UpdateStorefrontHighlightItemOrder (string id, CreateListingByIdRequest createListingByIdRequest = null)

Set the order of a highlight’s saved stories: every item id, first to last.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontHighlightItemOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 
            var createListingByIdRequest = new CreateListingByIdRequest(); // CreateListingByIdRequest |  (optional) 

            try
            {
                // Set the order of a highlight’s saved stories: every item id, first to last.
                StorefrontHighlightResponse result = apiInstance.UpdateStorefrontHighlightItemOrder(id, createListingByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontHighlightItemOrder: " + e.Message );
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
 **createListingByIdRequest** | **CreateListingByIdRequest**|  | [optional] 

### Return type

**StorefrontHighlightResponse**

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

<a name="updatestorefronthighlightorder"></a>
# **UpdateStorefrontHighlightOrder**
> ListStorefrontHighlightsResponse UpdateStorefrontHighlightOrder (CreateListingByIdRequest createListingByIdRequest = null)

Set the highlight order in one call: every highlight id, first to last.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontHighlightOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createListingByIdRequest = new CreateListingByIdRequest(); // CreateListingByIdRequest |  (optional) 

            try
            {
                // Set the highlight order in one call: every highlight id, first to last.
                ListStorefrontHighlightsResponse result = apiInstance.UpdateStorefrontHighlightOrder(createListingByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontHighlightOrder: " + e.Message );
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
 **createListingByIdRequest** | **CreateListingByIdRequest**|  | [optional] 

### Return type

**ListStorefrontHighlightsResponse**

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

<a name="updatestorefrontprofile"></a>
# **UpdateStorefrontProfile**
> UpdateStorefrontProfileResponse UpdateStorefrontProfile ()

Replace your shop profile (a complete ShopProfile). Saved straight away.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Replace your shop profile (a complete ShopProfile). Saved straight away.
                UpdateStorefrontProfileResponse result = apiInstance.UpdateStorefrontProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontProfile: " + e.Message );
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

**UpdateStorefrontProfileResponse**

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

<a name="updatestorefrontsection"></a>
# **UpdateStorefrontSection**
> StorefrontSectionResponse UpdateStorefrontSection (string id, UpdateStorefrontSectionRequest updateStorefrontSectionRequest = null)

Rename, show/hide, refill (listings shelves) or reconfigure a section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontSectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var id = "id_example";  // string | 
            var updateStorefrontSectionRequest = new UpdateStorefrontSectionRequest(); // UpdateStorefrontSectionRequest |  (optional) 

            try
            {
                // Rename, show/hide, refill (listings shelves) or reconfigure a section.
                StorefrontSectionResponse result = apiInstance.UpdateStorefrontSection(id, updateStorefrontSectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontSection: " + e.Message );
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
 **updateStorefrontSectionRequest** | **UpdateStorefrontSectionRequest**|  | [optional] 

### Return type

**StorefrontSectionResponse**

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

<a name="updatestorefrontsectionreorder"></a>
# **UpdateStorefrontSectionReorder**
> StorefrontResponse4 UpdateStorefrontSectionReorder (CreateListingByIdRequest createListingByIdRequest)

Set the section order in one atomic call: every section id, top to bottom.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontSectionReorderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var createListingByIdRequest = new CreateListingByIdRequest(); // CreateListingByIdRequest | 

            try
            {
                // Set the section order in one atomic call: every section id, top to bottom.
                StorefrontResponse4 result = apiInstance.UpdateStorefrontSectionReorder(createListingByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontSectionReorder: " + e.Message );
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
 **createListingByIdRequest** | **CreateListingByIdRequest**|  | 

### Return type

**StorefrontResponse4**

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

<a name="updatestorefrontshipping"></a>
# **UpdateStorefrontShipping**
> GetStorefrontShippingResponse UpdateStorefrontShipping (UpdateStorefrontShippingRequest updateStorefrontShippingRequest)

Set your shipping policy (international.enabled, shipsTo worldwide or ISO codes, excludes) and/or the default ship-from address of the store named by X-Storefront-Id, else your default store (any country; 422 for a sanctioned origin).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontShippingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var updateStorefrontShippingRequest = new UpdateStorefrontShippingRequest(); // UpdateStorefrontShippingRequest | 

            try
            {
                // Set your shipping policy (international.enabled, shipsTo worldwide or ISO codes, excludes) and/or the default ship-from address of the store named by X-Storefront-Id, else your default store (any country; 422 for a sanctioned origin).
                GetStorefrontShippingResponse result = apiInstance.UpdateStorefrontShipping(updateStorefrontShippingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontShipping: " + e.Message );
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
 **updateStorefrontShippingRequest** | **UpdateStorefrontShippingRequest**|  | 

### Return type

**GetStorefrontShippingResponse**

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

<a name="updatestorefrontsitedraft"></a>
# **UpdateStorefrontSiteDraft**
> StorefrontResponse2 UpdateStorefrontSiteDraft ()

Save the website draft (a complete SiteDesign). Validated strictly (a bad field is a 400 naming its path) and sanitized; buyers see nothing until you publish.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontSiteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Save the website draft (a complete SiteDesign). Validated strictly (a bad field is a 400 naming its path) and sanitized; buyers see nothing until you publish.
                StorefrontResponse2 result = apiInstance.UpdateStorefrontSiteDraft();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontSiteDraft: " + e.Message );
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

**StorefrontResponse2**

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

<a name="updatestorefrontsiteenabled"></a>
# **UpdateStorefrontSiteEnabled**
> StorefrontResponse3 UpdateStorefrontSiteEnabled ()

Switch the website on or off. On requires a publish first; off makes /site/:slug 404 and the custom domain show the shop profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontSiteEnabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);

            try
            {
                // Switch the website on or off. On requires a publish first; off makes /site/:slug 404 and the custom domain show the shop profile.
                StorefrontResponse3 result = apiInstance.UpdateStorefrontSiteEnabled();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontSiteEnabled: " + e.Message );
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

**StorefrontResponse3**

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

<a name="updatestorefronttradesitedraft"></a>
# **UpdateStorefrontTradeSiteDraft**
> StorefrontResponse2 UpdateStorefrontTradeSiteDraft (UpdateStorefrontTradeSiteDraftRequest updateStorefrontTradeSiteDraftRequest = null)

Save the trade site draft (a complete SiteDesign; trade sections included). Validated strictly and sanitized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontTradeSiteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var updateStorefrontTradeSiteDraftRequest = new UpdateStorefrontTradeSiteDraftRequest(); // UpdateStorefrontTradeSiteDraftRequest |  (optional) 

            try
            {
                // Save the trade site draft (a complete SiteDesign; trade sections included). Validated strictly and sanitized.
                StorefrontResponse2 result = apiInstance.UpdateStorefrontTradeSiteDraft(updateStorefrontTradeSiteDraftRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontTradeSiteDraft: " + e.Message );
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
 **updateStorefrontTradeSiteDraftRequest** | **UpdateStorefrontTradeSiteDraftRequest**|  | [optional] 

### Return type

**StorefrontResponse2**

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

<a name="updatestorefronttradesiteenabled"></a>
# **UpdateStorefrontTradeSiteEnabled**
> StorefrontResponse3 UpdateStorefrontTradeSiteEnabled (EnabledRequest enabledRequest = null)

Switch the trade site on (needs a publish first) or off.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontTradeSiteEnabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var enabledRequest = new EnabledRequest(); // EnabledRequest |  (optional) 

            try
            {
                // Switch the trade site on (needs a publish first) or off.
                StorefrontResponse3 result = apiInstance.UpdateStorefrontTradeSiteEnabled(enabledRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontTradeSiteEnabled: " + e.Message );
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
 **enabledRequest** | **EnabledRequest**|  | [optional] 

### Return type

**StorefrontResponse3**

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

<a name="updatestorefronttradesitegating"></a>
# **UpdateStorefrontTradeSiteGating**
> StorefrontResponse3 UpdateStorefrontTradeSiteGating (UpdateStorefrontTradeSiteGatingRequest updateStorefrontTradeSiteGatingRequest = null)

Who sees the trade site: public (everyone, with prices), prices_private (everyone, prices for approved buyers) or approved_only (approved buyers; others get the apply page).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStorefrontTradeSiteGatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorefrontApi(config);
            var updateStorefrontTradeSiteGatingRequest = new UpdateStorefrontTradeSiteGatingRequest(); // UpdateStorefrontTradeSiteGatingRequest |  (optional) 

            try
            {
                // Who sees the trade site: public (everyone, with prices), prices_private (everyone, prices for approved buyers) or approved_only (approved buyers; others get the apply page).
                StorefrontResponse3 result = apiInstance.UpdateStorefrontTradeSiteGating(updateStorefrontTradeSiteGatingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorefrontApi.UpdateStorefrontTradeSiteGating: " + e.Message );
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
 **updateStorefrontTradeSiteGatingRequest** | **UpdateStorefrontTradeSiteGatingRequest**|  | [optional] 

### Return type

**StorefrontResponse3**

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

