# net.crossly.Api.ProfileApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProfileMilestoneCelebrate**](ProfileApi.md#createprofilemilestonecelebrate) | **POST** /v1/profile/milestones/{key}/celebrate | Celebrate an earned milestone with a storefront code: percentOff (default 10) off, ending hours (default 48) from now, with a storefront banner (bannerText, default like \&quot;We just hit 1,000 sales\&quot;). One code per milestone: a second call returns the same code (200, existing: true). A milestone you have not earned is a 404.
[**CreateProfilePublish**](ProfileApi.md#createprofilepublish) | **POST** /v1/profile/publish | Publish the draft: crossly.net/seller/&lt;handle&gt;, its share cards and link previews switch to it, and a version is kept (label optional, up to 80 characters).
[**CreateProfileShareCard**](ProfileApi.md#createprofilesharecard) | **POST** /v1/profile/share-cards | Make a share card for your profile, one stat (ref.key + ref.timeframe) or one earned milestone (ref.key). Returns pageUrl (the link to post: Discord, X and iMessage unfurl it with the card), imageUrl (the 1200x630 PNG) and discordText (a ready line ending in the link). A stat you do not show, or a milestone you have not earned, is a 404. settings overrides the card design (template, background, accent…).
[**GetProfile**](ProfileApi.md#getprofile) | **GET** /v1/profile | Your seller profile: the @handle, the PUBLISHED document (what crossly.net/seller/&lt;handle&gt; shows), the DRAFT the editor is working on, when it was last published and whether the draft has unpublished changes. A profile never edited reads as the default profile built from your account.
[**GetSellerProfile**](ProfileApi.md#getsellerprofile) | **GET** /v1/sellers/{handle}/profile | Any seller&#39;s public profile: the person, the published document, resolved stats (a rounded or tier stat never carries its exact value), shown marketplaces, stores, milestones and the share card URLs. 404 when the handle does not exist or the profile is private.
[**ListProfileMilestones**](ProfileApi.md#listprofilemilestones) | **GET** /v1/profile/milestones | Milestones you earned (first sale, $100k verified sales, 1-year streak, 10 countries…) with when, and whether each is verified. Earned only from verified data; each has its own share page and card.
[**ListProfileSources**](ProfileApi.md#listprofilesources) | **GET** /v1/profile/sources | The accounts, stores and marketplace connections your profile may show: your own account, plus every team you belong to whose owner granted you profile:showcase. Toggle them in document.sources.
[**ListProfileStats**](ProfileApi.md#listprofilestats) | **GET** /v1/profile/stats | Profile stats in the OWNER view: exact values and coverage, whatever display mode the public page uses. keys is a comma list (gmv, items_sold, orders, avg_sale_price, best_sale, sell_through_rate, median_days_to_sale, rating, vault_value, …); timeframe is a rolling token (7d 30d 90d 6mo 12mo ytd all) or a custom range cYYYYMMDD-YYYYMMDD in your time zone. Money is USD cents, rates bps, durations days. verified is true only for numbers backed by marketplace-reported or Crossly-checkout sales.
[**UpdateMe**](ProfileApi.md#updateme) | **PATCH** /v1/me | Update the authenticated user&#39;s profile (display name, etc).
[**UpdateProfileDocument**](ProfileApi.md#updateprofiledocument) | **PUT** /v1/profile/document | Replace your profile DRAFT with a whole ProfileDocument (theme, hero, ordered sections, socials, sources, share card, privacy). Nothing public changes until you publish. Read the current draft from GET /v1/profile, change it, and send it back. A 400 lists every invalid field.


<a name="createprofilemilestonecelebrate"></a>
# **CreateProfileMilestoneCelebrate**
> CreateProfileMilestoneCelebrateResponse CreateProfileMilestoneCelebrate (string key, CreateProfileMilestoneCelebrateRequest createProfileMilestoneCelebrateRequest)

Celebrate an earned milestone with a storefront code: percentOff (default 10) off, ending hours (default 48) from now, with a storefront banner (bannerText, default like \"We just hit 1,000 sales\"). One code per milestone: a second call returns the same code (200, existing: true). A milestone you have not earned is a 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProfileMilestoneCelebrateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var key = "key_example";  // string | 
            var createProfileMilestoneCelebrateRequest = new CreateProfileMilestoneCelebrateRequest(); // CreateProfileMilestoneCelebrateRequest | 

            try
            {
                // Celebrate an earned milestone with a storefront code: percentOff (default 10) off, ending hours (default 48) from now, with a storefront banner (bannerText, default like \"We just hit 1,000 sales\"). One code per milestone: a second call returns the same code (200, existing: true). A milestone you have not earned is a 404.
                CreateProfileMilestoneCelebrateResponse result = apiInstance.CreateProfileMilestoneCelebrate(key, createProfileMilestoneCelebrateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.CreateProfileMilestoneCelebrate: " + e.Message );
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
 **key** | **string**|  | 
 **createProfileMilestoneCelebrateRequest** | **CreateProfileMilestoneCelebrateRequest**|  | 

### Return type

**CreateProfileMilestoneCelebrateResponse**

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

<a name="createprofilepublish"></a>
# **CreateProfilePublish**
> CreateProfilePublishResponse CreateProfilePublish (CreateProfilePublishRequest createProfilePublishRequest)

Publish the draft: crossly.net/seller/<handle>, its share cards and link previews switch to it, and a version is kept (label optional, up to 80 characters).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProfilePublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var createProfilePublishRequest = new CreateProfilePublishRequest(); // CreateProfilePublishRequest | 

            try
            {
                // Publish the draft: crossly.net/seller/<handle>, its share cards and link previews switch to it, and a version is kept (label optional, up to 80 characters).
                CreateProfilePublishResponse result = apiInstance.CreateProfilePublish(createProfilePublishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.CreateProfilePublish: " + e.Message );
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
 **createProfilePublishRequest** | **CreateProfilePublishRequest**|  | 

### Return type

**CreateProfilePublishResponse**

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

<a name="createprofilesharecard"></a>
# **CreateProfileShareCard**
> CreateProfileShareCardResponse CreateProfileShareCard (CreateProfileShareCardRequest createProfileShareCardRequest)

Make a share card for your profile, one stat (ref.key + ref.timeframe) or one earned milestone (ref.key). Returns pageUrl (the link to post: Discord, X and iMessage unfurl it with the card), imageUrl (the 1200x630 PNG) and discordText (a ready line ending in the link). A stat you do not show, or a milestone you have not earned, is a 404. settings overrides the card design (template, background, accent…).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateProfileShareCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var createProfileShareCardRequest = new CreateProfileShareCardRequest(); // CreateProfileShareCardRequest | 

            try
            {
                // Make a share card for your profile, one stat (ref.key + ref.timeframe) or one earned milestone (ref.key). Returns pageUrl (the link to post: Discord, X and iMessage unfurl it with the card), imageUrl (the 1200x630 PNG) and discordText (a ready line ending in the link). A stat you do not show, or a milestone you have not earned, is a 404. settings overrides the card design (template, background, accent…).
                CreateProfileShareCardResponse result = apiInstance.CreateProfileShareCard(createProfileShareCardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.CreateProfileShareCard: " + e.Message );
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
 **createProfileShareCardRequest** | **CreateProfileShareCardRequest**|  | 

### Return type

**CreateProfileShareCardResponse**

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

<a name="getprofile"></a>
# **GetProfile**
> GetProfileResponse GetProfile ()

Your seller profile: the @handle, the PUBLISHED document (what crossly.net/seller/<handle> shows), the DRAFT the editor is working on, when it was last published and whether the draft has unpublished changes. A profile never edited reads as the default profile built from your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                // Your seller profile: the @handle, the PUBLISHED document (what crossly.net/seller/<handle> shows), the DRAFT the editor is working on, when it was last published and whether the draft has unpublished changes. A profile never edited reads as the default profile built from your account.
                GetProfileResponse result = apiInstance.GetProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.GetProfile: " + e.Message );
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

**GetProfileResponse**

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

<a name="getsellerprofile"></a>
# **GetSellerProfile**
> GetSellerProfileResponse GetSellerProfile (string handle)

Any seller's public profile: the person, the published document, resolved stats (a rounded or tier stat never carries its exact value), shown marketplaces, stores, milestones and the share card URLs. 404 when the handle does not exist or the profile is private.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSellerProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Any seller's public profile: the person, the published document, resolved stats (a rounded or tier stat never carries its exact value), shown marketplaces, stores, milestones and the share card URLs. 404 when the handle does not exist or the profile is private.
                GetSellerProfileResponse result = apiInstance.GetSellerProfile(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.GetSellerProfile: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetSellerProfileResponse**

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

<a name="listprofilemilestones"></a>
# **ListProfileMilestones**
> ListProfileMilestonesResponse ListProfileMilestones ()

Milestones you earned (first sale, $100k verified sales, 1-year streak, 10 countries…) with when, and whether each is verified. Earned only from verified data; each has its own share page and card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProfileMilestonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                // Milestones you earned (first sale, $100k verified sales, 1-year streak, 10 countries…) with when, and whether each is verified. Earned only from verified data; each has its own share page and card.
                ListProfileMilestonesResponse result = apiInstance.ListProfileMilestones();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ListProfileMilestones: " + e.Message );
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

**ListProfileMilestonesResponse**

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

<a name="listprofilesources"></a>
# **ListProfileSources**
> ListProfileSourcesResponse ListProfileSources ()

The accounts, stores and marketplace connections your profile may show: your own account, plus every team you belong to whose owner granted you profile:showcase. Toggle them in document.sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProfileSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);

            try
            {
                // The accounts, stores and marketplace connections your profile may show: your own account, plus every team you belong to whose owner granted you profile:showcase. Toggle them in document.sources.
                ListProfileSourcesResponse result = apiInstance.ListProfileSources();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ListProfileSources: " + e.Message );
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

**ListProfileSourcesResponse**

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

<a name="listprofilestats"></a>
# **ListProfileStats**
> ListProfileStatsResponse ListProfileStats (string keys, string timeframe = null, string display = null, string basis = null)

Profile stats in the OWNER view: exact values and coverage, whatever display mode the public page uses. keys is a comma list (gmv, items_sold, orders, avg_sale_price, best_sale, sell_through_rate, median_days_to_sale, rating, vault_value, …); timeframe is a rolling token (7d 30d 90d 6mo 12mo ytd all) or a custom range cYYYYMMDD-YYYYMMDD in your time zone. Money is USD cents, rates bps, durations days. verified is true only for numbers backed by marketplace-reported or Crossly-checkout sales.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListProfileStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var keys = "keys_example";  // string | Comma-separated stat keys, at most 30.
            var timeframe = "\"all\"";  // string |  (optional)  (default to "all")
            var display = "exact";  // string |  (optional) 
            var basis = "verified";  // string |  (optional) 

            try
            {
                // Profile stats in the OWNER view: exact values and coverage, whatever display mode the public page uses. keys is a comma list (gmv, items_sold, orders, avg_sale_price, best_sale, sell_through_rate, median_days_to_sale, rating, vault_value, …); timeframe is a rolling token (7d 30d 90d 6mo 12mo ytd all) or a custom range cYYYYMMDD-YYYYMMDD in your time zone. Money is USD cents, rates bps, durations days. verified is true only for numbers backed by marketplace-reported or Crossly-checkout sales.
                ListProfileStatsResponse result = apiInstance.ListProfileStats(keys, timeframe, display, basis);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ListProfileStats: " + e.Message );
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
 **keys** | **string**| Comma-separated stat keys, at most 30. | 
 **timeframe** | **string**|  | [optional] [default to &quot;all&quot;]
 **display** | **string**|  | [optional] 
 **basis** | **string**|  | [optional] 

### Return type

**ListProfileStatsResponse**

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

<a name="updateme"></a>
# **UpdateMe**
> OkResponse UpdateMe (UpdateMeRequest updateMeRequest)

Update the authenticated user's profile (display name, etc).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var updateMeRequest = new UpdateMeRequest(); // UpdateMeRequest | 

            try
            {
                // Update the authenticated user's profile (display name, etc).
                OkResponse result = apiInstance.UpdateMe(updateMeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.UpdateMe: " + e.Message );
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
 **updateMeRequest** | **UpdateMeRequest**|  | 

### Return type

**OkResponse**

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

<a name="updateprofiledocument"></a>
# **UpdateProfileDocument**
> UpdateProfileDocumentResponse UpdateProfileDocument (UpdateProfileDocumentRequest updateProfileDocumentRequest)

Replace your profile DRAFT with a whole ProfileDocument (theme, hero, ordered sections, socials, sources, share card, privacy). Nothing public changes until you publish. Read the current draft from GET /v1/profile, change it, and send it back. A 400 lists every invalid field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateProfileDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfileApi(config);
            var updateProfileDocumentRequest = new UpdateProfileDocumentRequest(); // UpdateProfileDocumentRequest | 

            try
            {
                // Replace your profile DRAFT with a whole ProfileDocument (theme, hero, ordered sections, socials, sources, share card, privacy). Nothing public changes until you publish. Read the current draft from GET /v1/profile, change it, and send it back. A 400 lists every invalid field.
                UpdateProfileDocumentResponse result = apiInstance.UpdateProfileDocument(updateProfileDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.UpdateProfileDocument: " + e.Message );
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
 **updateProfileDocumentRequest** | **UpdateProfileDocumentRequest**|  | 

### Return type

**UpdateProfileDocumentResponse**

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

