# net.crossly.Api.AdsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAdOffsiteCampaign**](AdsApi.md#createadoffsitecampaign) | **POST** /v1/ads/offsite/campaigns | Launch an offsite campaign for an item.
[**CreateAdOffsiteResume**](AdsApi.md#createadoffsiteresume) | **POST** /v1/ads/offsite/resume | Clear an auto-pause and resume offsite spend.
[**CreateListingAdBulkAdd**](AdsApi.md#createlistingadbulkadd) | **POST** /v1/listing-ads/bulk-add | Add listings to a campaign by master listing id: each listing&#39;s live row on &#x60;platform&#x60; joins campaignId (a Crossly campaign uuid, or the marketplace&#39;s campaign id). A listing not live there is its own failed result.
[**CreateListingAdCampaign**](AdsApi.md#createlistingadcampaign) | **POST** /v1/listing-ads/{platform}/campaigns | Create a campaign on the marketplace: program (promoted_listing_rate &#x3D; eBay General, a % of the sale; cpc_campaign &#x3D; eBay Priority, a daily budget), name, ratePct or dailyBudgetCents, startsAt/endsAt, and the program fields. Idempotency-Key supported.
[**CreateListingAdCampaignListing**](AdsApi.md#createlistingadcampaignlisting) | **POST** /v1/listing-ads/{platform}/campaigns/{campaignId}/listings | Promote listings in a marketplace campaign. platformListingIds are Crossly platform-listing ids on that marketplace; ratePct sets the ad rate (eBay General). One result per listing.
[**CreateListingAdCampaignListingRemove**](AdsApi.md#createlistingadcampaignlistingremove) | **POST** /v1/listing-ads/{platform}/campaigns/{campaignId}/listings/remove | Stop promoting listings in a marketplace campaign. One result per listing.
[**CreateSponsoredAdBillingTopupLink**](AdsApi.md#createsponsoredadbillingtopuplink) | **POST** /v1/sponsored-ads/billing/topup-link | A Stripe Checkout link that adds amountCents ($5–$10,000) to the ad balance when the seller pays it. Nothing is charged until they do. Use an Idempotency-Key to get the same link back on a retry.
[**CreateSponsoredAdBoostRemove**](AdsApi.md#createsponsoredadboostremove) | **POST** /v1/sponsored-ads/boosts/remove | Stop boosting listings in bulk.
[**CreateSponsoredAdCampaign**](AdsApi.md#createsponsoredadcampaign) | **POST** /v1/sponsored-ads/campaigns | Create a Sponsored Listings campaign: name, dailyBudgetCents (≥100), optional totalBudgetCents, defaultBidCents (5–10000; the max bid under bidStrategy \&quot;auto\&quot;), placements (search, browse, product_page, home_rail, storefront, worlds_surface), goal (sales | visits), optional targetCategories / targetRegions (ISO countries) / targetDevices (mobile, desktop, app), optional startsAt/endsAt, listings [{platformListingId, bidCents?, boostBps? (100–2000, pay-on-sale Boost; null clears)}], keywords [{keyword, matchType broad|phrase|exact, negative?, bidCents?}], worldTargets [{kind showroom|convention, id, bidCents?, status?}] (your showroom or a convention you host, promoted in the Crossly World directory; at least one listing or world target), status active|draft. A catalog boost: targetType \&quot;wholesale_catalog\&quot; + targetCatalogId (your catalog), no listings, keywords or world targets; it ranks Sponsored in the wholesale directory. bidStrategy defaults to your account default. Clicks are charged from your ad funds (ad balance and/or CBX, ad credit first); with none it waits as out_of_budget.
[**CreateSponsoredAdCampaignDuplicate**](AdsApi.md#createsponsoredadcampaignduplicate) | **POST** /v1/sponsored-ads/campaigns/{id}/duplicate | Copy a campaign (settings, listings, keywords) as a new draft.
[**CreateSponsoredAdCampaignStatus**](AdsApi.md#createsponsoredadcampaignstatus) | **POST** /v1/sponsored-ads/campaigns/{id}/status | Set a campaign active (launch/resume), paused, or ended (final). Resuming with no ad funds to pay for clicks leaves it out_of_budget until you top up.
[**GetAdOffsite**](AdsApi.md#getadoffsite) | **GET** /v1/ads/offsite | Your offsite-ads opt-in and its terms.
[**GetAdOffsiteEligibility**](AdsApi.md#getadoffsiteeligibility) | **GET** /v1/ads/offsite/eligibility | Whether an item can run offsite, and why not.
[**GetAdOffsiteReport**](AdsApi.md#getadoffsitereport) | **GET** /v1/ads/offsite/report | What your offsite budget bought — including the misses.
[**GetListingAdListing**](AdsApi.md#getlistingadlisting) | **GET** /v1/listing-ads/listings/{listingId} | Every promotion of one listing: its Crossly campaigns and Boost, and each marketplace ad with status, campaign, rate and last sync.
[**GetSponsoredAdBilling**](AdsApi.md#getsponsoredadbilling) | **GET** /v1/sponsored-ads/billing | What pays for your ads: headroom across the billing rails (ad balance and/or CBX), unbilled click spend, settlement charges, daily spend, Boost fees and CBX ad-credit grants; funds is the full funds summary (same as /v1/sponsored-ads/funds). refresh&#x3D;true re-reads the balance.
[**GetSponsoredAdBillingStatement**](AdsApi.md#getsponsoredadbillingstatement) | **GET** /v1/sponsored-ads/billing/statements/{month} | One month&#39;s ads statement: opening and closing ad balance, top-ups, click spend by campaign, how clicks were paid, credits, refunds and Boost fees.
[**GetSponsoredAdBillingStatementPdf**](AdsApi.md#getsponsoredadbillingstatementpdf) | **GET** /v1/sponsored-ads/billing/statements/{month}/pdf | One month&#39;s ads statement as a PDF.
[**GetSponsoredAdBillingTopupReceipt**](AdsApi.md#getsponsoredadbillingtopupreceipt) | **GET** /v1/sponsored-ads/billing/topups/{id}/receipt | One ad balance top-up&#39;s receipt as a PDF (each top-up in the billing history carries its id and receipt number).
[**GetSponsoredAdCampaign**](AdsApi.md#getsponsoredadcampaign) | **GET** /v1/sponsored-ads/campaigns/{id} | One campaign: settings, its listings (bid, suggested bid, live, per-listing stats) and keywords. A catalog boost (targetType wholesale_catalog) has &#x60;catalogs&#x60;: per boosted catalog impressions, clicks, spend, attributed trade orders and revenue, CTR and ROAS.
[**GetSponsoredAdFund**](AdsApi.md#getsponsoredadfund) | **GET** /v1/sponsored-ads/funds | What can pay for clicks now: the billing rails in effect (ad balance and/or CBX), the ad balance and ad credit, CBX headroom, unbilled clicks, available cents, auto top-up, the saved payment method and the refundable balance. refresh&#x3D;true re-reads CBX.
[**GetSponsoredAdReport**](AdsApi.md#getsponsoredadreport) | **GET** /v1/sponsored-ads/report | Sponsored report for a range: totals (spend, impressions, clicks, CTR, average CPC, attributed orders and revenue, ROAS), a zero-filled daily series, per-campaign rows (targetType listings | wholesale_catalog) and &#x60;catalogs&#x60;, one row per boosted catalog. Listing orders are Crossly purchases of the advertised listing within 7 days of a click by the same buyer; catalog orders are trade orders with that seller within 7 days of a catalog click by the same buyer. Catalog impressions count once per viewer per day.
[**GetSponsoredAdSetting**](AdsApi.md#getsponsoredadsetting) | **GET** /v1/sponsored-ads/settings | Ads quick settings: adsPaused, accountDailyCapCents and spentTodayCents, defaultBidStrategy, autoTopup.
[**ListListingAdCampaigns**](AdsApi.md#listlistingadcampaigns) | **GET** /v1/listing-ads/{platform}/campaigns | Your ad campaigns on one marketplace (cached up to 15 minutes; refresh&#x3D;true asks the marketplace now).
[**ListListingAdPlatforms**](AdsApi.md#listlistingadplatforms) | **GET** /v1/listing-ads/platforms | The ads registry: each marketplace that sells promotion, its programs (kind, scope, campaign and listing fields), which verbs are wired / need a capture / are unsupported, and whether you are connected there.
[**ListSponsoredAdBillingHistory**](AdsApi.md#listsponsoredadbillinghistory) | **GET** /v1/sponsored-ads/billing/history | Billing history newest first: top-ups (status, receipt number), click charges (how each was paid: ad balance, credit, CBX, written off), credits, refunds and Boost fees. kind filters; before (ISO time) pages; limit ≤ 100.
[**ListSponsoredAdBillingStatements**](AdsApi.md#listsponsoredadbillingstatements) | **GET** /v1/sponsored-ads/billing/statements | Months (YYYY-MM) with any ad billing activity, newest first.
[**ListSponsoredAdBoosts**](AdsApi.md#listsponsoredadboosts) | **GET** /v1/sponsored-ads/boosts | Boosted (pay-on-sale) listings: the rate, sales and fees taken so far. A boost lifts organic ranking by up to 10% and costs its rate only when the listing sells on Crossly.
[**ListSponsoredAdCampaigns**](AdsApi.md#listsponsoredadcampaigns) | **GET** /v1/sponsored-ads/campaigns | Your Sponsored Listings campaigns with status, pacing (spent today, daily cap reached), budgets, bids, placements and stats for the range (from/to, YYYY-MM-DD; default last 30 days).
[**ListSponsoredAdListings**](AdsApi.md#listsponsoredadlistings) | **GET** /v1/sponsored-ads/listings | Per-listing ad performance across campaigns for a range, plus suggestions: live listings with views but few sales that are not sponsored yet, with a suggested bid.
[**UpdateAdOffsite**](AdsApi.md#updateadoffsite) | **PUT** /v1/ads/offsite | Turn offsite ads on or off. Yours alone to set.
[**UpdateListingAdCampaign**](AdsApi.md#updatelistingadcampaign) | **PATCH** /v1/listing-ads/{platform}/campaigns/{campaignId} | Change a marketplace campaign: name, dailyBudgetCents, endsAt (null clears), status paused | running | ended.
[**UpdateListingAdListingRate**](AdsApi.md#updatelistingadlistingrate) | **PUT** /v1/listing-ads/{platform}/listings/{platformListingId}/rate | Change one promoted listing&#39;s ad rate (percent of the sale) in the campaign it is in.
[**UpdateSponsoredAdBillingAutoTopup**](AdsApi.md#updatesponsoredadbillingautotopup) | **PUT** /v1/sponsored-ads/billing/auto-topup | Auto top-up: enabled, thresholdCents (top up when the ad balance drops below it), amountCents (how much). Needs a saved payment method (the first top-up saves it).
[**UpdateSponsoredAdBoost**](AdsApi.md#updatesponsoredadboost) | **PUT** /v1/sponsored-ads/boosts | Boost listings in bulk (platformListingIds, upliftBps 100–2000 &#x3D; 1–20%), or change their rate. Your own live Crossly listings only.
[**UpdateSponsoredAdCampaign**](AdsApi.md#updatesponsoredadcampaign) | **PATCH** /v1/sponsored-ads/campaigns/{id} | Edit a campaign. Any of the create fields; listings and keywords, when given, replace the current set. Raising the total budget resumes a campaign stopped by it.
[**UpdateSponsoredAdSetting**](AdsApi.md#updatesponsoredadsetting) | **PATCH** /v1/sponsored-ads/settings | Change ads quick settings: adsPaused (pause / resume every ad), accountDailyCapCents (null &#x3D; no cap), defaultBidStrategy (auto | manual) for new campaigns, autoTopup {enabled, thresholdCents?, amountCents?}, railPreference (cash_first | cbx_first, both rails live only).


<a name="createadoffsitecampaign"></a>
# **CreateAdOffsiteCampaign**
> CreateAdOffsiteCampaignResponse CreateAdOffsiteCampaign (CreateAdOffsiteCampaignRequest createAdOffsiteCampaignRequest)

Launch an offsite campaign for an item.

Creative is built from the structured fields you pass — title, condition as you recorded it, price, image. We generate no prose and invent no claims about condition or authenticity: an ad saying \"mint\" or \"authenticated\" when your listing says neither is a misrepresentation we authored and YOU would take the dispute for. Refuses with 403 when no ad network is wired, rather than returning a campaign that does not exist — a campaign row marked live with nothing behind it would read as spending your money when it is not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAdOffsiteCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var createAdOffsiteCampaignRequest = new CreateAdOffsiteCampaignRequest(); // CreateAdOffsiteCampaignRequest | 

            try
            {
                // Launch an offsite campaign for an item.
                CreateAdOffsiteCampaignResponse result = apiInstance.CreateAdOffsiteCampaign(createAdOffsiteCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateAdOffsiteCampaign: " + e.Message );
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
 **createAdOffsiteCampaignRequest** | **CreateAdOffsiteCampaignRequest**|  | 

### Return type

**CreateAdOffsiteCampaignResponse**

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

<a name="createadoffsiteresume"></a>
# **CreateAdOffsiteResume**
> CreateAdOffsiteResumeResponse CreateAdOffsiteResume ()

Clear an auto-pause and resume offsite spend.

Returns 409 when you are not actually paused. The pause reason is worth reading first — resuming without changing anything will usually just trip the floor again over the next window.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAdOffsiteResumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Clear an auto-pause and resume offsite spend.
                CreateAdOffsiteResumeResponse result = apiInstance.CreateAdOffsiteResume();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateAdOffsiteResume: " + e.Message );
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

**CreateAdOffsiteResumeResponse**

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

<a name="createlistingadbulkadd"></a>
# **CreateListingAdBulkAdd**
> CreateListingAdBulkAddResponse CreateListingAdBulkAdd (CreateListingAdBulkAddRequest createListingAdBulkAddRequest)

Add listings to a campaign by master listing id: each listing's live row on `platform` joins campaignId (a Crossly campaign uuid, or the marketplace's campaign id). A listing not live there is its own failed result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAdBulkAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var createListingAdBulkAddRequest = new CreateListingAdBulkAddRequest(); // CreateListingAdBulkAddRequest | 

            try
            {
                // Add listings to a campaign by master listing id: each listing's live row on `platform` joins campaignId (a Crossly campaign uuid, or the marketplace's campaign id). A listing not live there is its own failed result.
                CreateListingAdBulkAddResponse result = apiInstance.CreateListingAdBulkAdd(createListingAdBulkAddRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateListingAdBulkAdd: " + e.Message );
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
 **createListingAdBulkAddRequest** | **CreateListingAdBulkAddRequest**|  | 

### Return type

**CreateListingAdBulkAddResponse**

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

<a name="createlistingadcampaign"></a>
# **CreateListingAdCampaign**
> CreateListingAdCampaignResponse CreateListingAdCampaign (string platform, CreateListingAdCampaignRequest createListingAdCampaignRequest)

Create a campaign on the marketplace: program (promoted_listing_rate = eBay General, a % of the sale; cpc_campaign = eBay Priority, a daily budget), name, ratePct or dailyBudgetCents, startsAt/endsAt, and the program fields. Idempotency-Key supported.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAdCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var createListingAdCampaignRequest = new CreateListingAdCampaignRequest(); // CreateListingAdCampaignRequest | 

            try
            {
                // Create a campaign on the marketplace: program (promoted_listing_rate = eBay General, a % of the sale; cpc_campaign = eBay Priority, a daily budget), name, ratePct or dailyBudgetCents, startsAt/endsAt, and the program fields. Idempotency-Key supported.
                CreateListingAdCampaignResponse result = apiInstance.CreateListingAdCampaign(platform, createListingAdCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateListingAdCampaign: " + e.Message );
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
 **platform** | **string**|  | 
 **createListingAdCampaignRequest** | **CreateListingAdCampaignRequest**|  | 

### Return type

**CreateListingAdCampaignResponse**

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

<a name="createlistingadcampaignlisting"></a>
# **CreateListingAdCampaignListing**
> CreateListingAdCampaignListingResponse CreateListingAdCampaignListing (string platform, string campaignId, CreateListingAdCampaignListingRequest createListingAdCampaignListingRequest)

Promote listings in a marketplace campaign. platformListingIds are Crossly platform-listing ids on that marketplace; ratePct sets the ad rate (eBay General). One result per listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAdCampaignListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var campaignId = "campaignId_example";  // string | 
            var createListingAdCampaignListingRequest = new CreateListingAdCampaignListingRequest(); // CreateListingAdCampaignListingRequest | 

            try
            {
                // Promote listings in a marketplace campaign. platformListingIds are Crossly platform-listing ids on that marketplace; ratePct sets the ad rate (eBay General). One result per listing.
                CreateListingAdCampaignListingResponse result = apiInstance.CreateListingAdCampaignListing(platform, campaignId, createListingAdCampaignListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateListingAdCampaignListing: " + e.Message );
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
 **platform** | **string**|  | 
 **campaignId** | **string**|  | 
 **createListingAdCampaignListingRequest** | **CreateListingAdCampaignListingRequest**|  | 

### Return type

**CreateListingAdCampaignListingResponse**

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

<a name="createlistingadcampaignlistingremove"></a>
# **CreateListingAdCampaignListingRemove**
> CreateListingAdCampaignListingResponse CreateListingAdCampaignListingRemove (string platform, string campaignId, UpdateLiveStreamLineupRequest updateLiveStreamLineupRequest)

Stop promoting listings in a marketplace campaign. One result per listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAdCampaignListingRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var campaignId = "campaignId_example";  // string | 
            var updateLiveStreamLineupRequest = new UpdateLiveStreamLineupRequest(); // UpdateLiveStreamLineupRequest | 

            try
            {
                // Stop promoting listings in a marketplace campaign. One result per listing.
                CreateListingAdCampaignListingResponse result = apiInstance.CreateListingAdCampaignListingRemove(platform, campaignId, updateLiveStreamLineupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateListingAdCampaignListingRemove: " + e.Message );
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
 **platform** | **string**|  | 
 **campaignId** | **string**|  | 
 **updateLiveStreamLineupRequest** | **UpdateLiveStreamLineupRequest**|  | 

### Return type

**CreateListingAdCampaignListingResponse**

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

<a name="createsponsoredadbillingtopuplink"></a>
# **CreateSponsoredAdBillingTopupLink**
> CreateSponsoredAdBillingTopupLinkResponse CreateSponsoredAdBillingTopupLink (CreateSponsoredAdBillingTopupLinkRequest createSponsoredAdBillingTopupLinkRequest)

A Stripe Checkout link that adds amountCents ($5–$10,000) to the ad balance when the seller pays it. Nothing is charged until they do. Use an Idempotency-Key to get the same link back on a retry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSponsoredAdBillingTopupLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var createSponsoredAdBillingTopupLinkRequest = new CreateSponsoredAdBillingTopupLinkRequest(); // CreateSponsoredAdBillingTopupLinkRequest | 

            try
            {
                // A Stripe Checkout link that adds amountCents ($5–$10,000) to the ad balance when the seller pays it. Nothing is charged until they do. Use an Idempotency-Key to get the same link back on a retry.
                CreateSponsoredAdBillingTopupLinkResponse result = apiInstance.CreateSponsoredAdBillingTopupLink(createSponsoredAdBillingTopupLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateSponsoredAdBillingTopupLink: " + e.Message );
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
 **createSponsoredAdBillingTopupLinkRequest** | **CreateSponsoredAdBillingTopupLinkRequest**|  | 

### Return type

**CreateSponsoredAdBillingTopupLinkResponse**

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

<a name="createsponsoredadboostremove"></a>
# **CreateSponsoredAdBoostRemove**
> CreateSponsoredAdBoostRemoveResponse CreateSponsoredAdBoostRemove (UpdateLiveStreamLineupRequest updateLiveStreamLineupRequest)

Stop boosting listings in bulk.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSponsoredAdBoostRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var updateLiveStreamLineupRequest = new UpdateLiveStreamLineupRequest(); // UpdateLiveStreamLineupRequest | 

            try
            {
                // Stop boosting listings in bulk.
                CreateSponsoredAdBoostRemoveResponse result = apiInstance.CreateSponsoredAdBoostRemove(updateLiveStreamLineupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateSponsoredAdBoostRemove: " + e.Message );
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
 **updateLiveStreamLineupRequest** | **UpdateLiveStreamLineupRequest**|  | 

### Return type

**CreateSponsoredAdBoostRemoveResponse**

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

<a name="createsponsoredadcampaign"></a>
# **CreateSponsoredAdCampaign**
> SponsoredAdCampaignResponse CreateSponsoredAdCampaign ()

Create a Sponsored Listings campaign: name, dailyBudgetCents (≥100), optional totalBudgetCents, defaultBidCents (5–10000; the max bid under bidStrategy \"auto\"), placements (search, browse, product_page, home_rail, storefront, worlds_surface), goal (sales | visits), optional targetCategories / targetRegions (ISO countries) / targetDevices (mobile, desktop, app), optional startsAt/endsAt, listings [{platformListingId, bidCents?, boostBps? (100–2000, pay-on-sale Boost; null clears)}], keywords [{keyword, matchType broad|phrase|exact, negative?, bidCents?}], worldTargets [{kind showroom|convention, id, bidCents?, status?}] (your showroom or a convention you host, promoted in the Crossly World directory; at least one listing or world target), status active|draft. A catalog boost: targetType \"wholesale_catalog\" + targetCatalogId (your catalog), no listings, keywords or world targets; it ranks Sponsored in the wholesale directory. bidStrategy defaults to your account default. Clicks are charged from your ad funds (ad balance and/or CBX, ad credit first); with none it waits as out_of_budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSponsoredAdCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Create a Sponsored Listings campaign: name, dailyBudgetCents (≥100), optional totalBudgetCents, defaultBidCents (5–10000; the max bid under bidStrategy \"auto\"), placements (search, browse, product_page, home_rail, storefront, worlds_surface), goal (sales | visits), optional targetCategories / targetRegions (ISO countries) / targetDevices (mobile, desktop, app), optional startsAt/endsAt, listings [{platformListingId, bidCents?, boostBps? (100–2000, pay-on-sale Boost; null clears)}], keywords [{keyword, matchType broad|phrase|exact, negative?, bidCents?}], worldTargets [{kind showroom|convention, id, bidCents?, status?}] (your showroom or a convention you host, promoted in the Crossly World directory; at least one listing or world target), status active|draft. A catalog boost: targetType \"wholesale_catalog\" + targetCatalogId (your catalog), no listings, keywords or world targets; it ranks Sponsored in the wholesale directory. bidStrategy defaults to your account default. Clicks are charged from your ad funds (ad balance and/or CBX, ad credit first); with none it waits as out_of_budget.
                SponsoredAdCampaignResponse result = apiInstance.CreateSponsoredAdCampaign();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateSponsoredAdCampaign: " + e.Message );
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

**SponsoredAdCampaignResponse**

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

<a name="createsponsoredadcampaignduplicate"></a>
# **CreateSponsoredAdCampaignDuplicate**
> SponsoredAdCampaignResponse CreateSponsoredAdCampaignDuplicate (string id)

Copy a campaign (settings, listings, keywords) as a new draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSponsoredAdCampaignDuplicateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Copy a campaign (settings, listings, keywords) as a new draft.
                SponsoredAdCampaignResponse result = apiInstance.CreateSponsoredAdCampaignDuplicate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateSponsoredAdCampaignDuplicate: " + e.Message );
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

**SponsoredAdCampaignResponse**

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

<a name="createsponsoredadcampaignstatus"></a>
# **CreateSponsoredAdCampaignStatus**
> SponsoredAdCampaignResponse CreateSponsoredAdCampaignStatus (string id)

Set a campaign active (launch/resume), paused, or ended (final). Resuming with no ad funds to pay for clicks leaves it out_of_budget until you top up.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSponsoredAdCampaignStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Set a campaign active (launch/resume), paused, or ended (final). Resuming with no ad funds to pay for clicks leaves it out_of_budget until you top up.
                SponsoredAdCampaignResponse result = apiInstance.CreateSponsoredAdCampaignStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.CreateSponsoredAdCampaignStatus: " + e.Message );
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

**SponsoredAdCampaignResponse**

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

<a name="getadoffsite"></a>
# **GetAdOffsite**
> GetAdOffsiteResponse GetAdOffsite ()

Your offsite-ads opt-in and its terms.

Offsite ads spend your CBX advertising budget on external networks — Google, Meta and similar — at our discretion. Your item gets promoted, and the traffic lands on Crossly. OFF unless you turn it on, and there is no path that enables it on your behalf. Media is passed through AT COST with a separate, disclosed management fee, so you can always see how much of your budget reached the auction. `minReturnBps` is a STOP, not a guarantee: below it, offsite spend auto-pauses and the rest of your budget reverts to on-platform placement. Nobody can honestly promise ad performance; what we can promise is that it stops.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAdOffsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Your offsite-ads opt-in and its terms.
                GetAdOffsiteResponse result = apiInstance.GetAdOffsite();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetAdOffsite: " + e.Message );
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

**GetAdOffsiteResponse**

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

<a name="getadoffsiteeligibility"></a>
# **GetAdOffsiteEligibility**
> GetAdOffsiteEligibilityResponse GetAdOffsiteEligibility (string network, string category)

Whether an item can run offsite, and why not.

Reasons: `not_opted_in`, `auto_paused`, `network_not_allowed`, `category_not_allowlisted`, `no_adapter`, `no_budget`. The category check is an ALLOWLIST, so an unclassified category is not eligible. That is not bureaucracy: ad networks suspend the ACCOUNT over a prohibited item, and the account is one shared resource across every merchant using this — so one listing could take offsite ads away from all of them. A blocklist would fail open on the first category nobody thought of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAdOffsiteEligibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var network = "google";  // string | 
            var category = "category_example";  // string | 

            try
            {
                // Whether an item can run offsite, and why not.
                GetAdOffsiteEligibilityResponse result = apiInstance.GetAdOffsiteEligibility(network, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetAdOffsiteEligibility: " + e.Message );
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
 **network** | **string**|  | 
 **category** | **string**|  | 

### Return type

**GetAdOffsiteEligibilityResponse**

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

<a name="getadoffsitereport"></a>
# **GetAdOffsiteReport**
> GetAdOffsiteReportResponse GetAdOffsiteReport ()

What your offsite budget bought — including the misses.

Spend, impressions and clicks are reported whether or not anything converted. A report showing only conversions is a report nobody can audit, and this is a feature where you handed over discretion over your money. `mediaCostCents` versus `managementFeeCents` answers \"how much of my budget reached the auction\" — the two are recorded separately so the answer survives. `spilloverConversions` is sales your ads produced on OTHER sellers' items. Reported so you can see whether offsite traffic is reaching buyers who want your item — a high spillover rate is the signal to turn it off. `returnBps` is attributed revenue as bps of spend; compare it with your `minReturnBps` floor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAdOffsiteReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // What your offsite budget bought — including the misses.
                GetAdOffsiteReportResponse result = apiInstance.GetAdOffsiteReport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetAdOffsiteReport: " + e.Message );
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

**GetAdOffsiteReportResponse**

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

<a name="getlistingadlisting"></a>
# **GetListingAdListing**
> GetListingAdListingResponse GetListingAdListing (string listingId)

Every promotion of one listing: its Crossly campaigns and Boost, and each marketplace ad with status, campaign, rate and last sync.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetListingAdListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var listingId = "listingId_example";  // string | 

            try
            {
                // Every promotion of one listing: its Crossly campaigns and Boost, and each marketplace ad with status, campaign, rate and last sync.
                GetListingAdListingResponse result = apiInstance.GetListingAdListing(listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetListingAdListing: " + e.Message );
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
 **listingId** | **string**|  | 

### Return type

**GetListingAdListingResponse**

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

<a name="getsponsoredadbilling"></a>
# **GetSponsoredAdBilling**
> GetSponsoredAdBillingResponse GetSponsoredAdBilling (string refresh = null)

What pays for your ads: headroom across the billing rails (ad balance and/or CBX), unbilled click spend, settlement charges, daily spend, Boost fees and CBX ad-credit grants; funds is the full funds summary (same as /v1/sponsored-ads/funds). refresh=true re-reads the balance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdBillingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var refresh = "true";  // string |  (optional) 

            try
            {
                // What pays for your ads: headroom across the billing rails (ad balance and/or CBX), unbilled click spend, settlement charges, daily spend, Boost fees and CBX ad-credit grants; funds is the full funds summary (same as /v1/sponsored-ads/funds). refresh=true re-reads the balance.
                GetSponsoredAdBillingResponse result = apiInstance.GetSponsoredAdBilling(refresh);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdBilling: " + e.Message );
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
 **refresh** | **string**|  | [optional] 

### Return type

**GetSponsoredAdBillingResponse**

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

<a name="getsponsoredadbillingstatement"></a>
# **GetSponsoredAdBillingStatement**
> GetSponsoredAdBillingStatementResponse GetSponsoredAdBillingStatement (string month)

One month's ads statement: opening and closing ad balance, top-ups, click spend by campaign, how clicks were paid, credits, refunds and Boost fees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdBillingStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var month = "month_example";  // string | 

            try
            {
                // One month's ads statement: opening and closing ad balance, top-ups, click spend by campaign, how clicks were paid, credits, refunds and Boost fees.
                GetSponsoredAdBillingStatementResponse result = apiInstance.GetSponsoredAdBillingStatement(month);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdBillingStatement: " + e.Message );
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
 **month** | **string**|  | 

### Return type

**GetSponsoredAdBillingStatementResponse**

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

<a name="getsponsoredadbillingstatementpdf"></a>
# **GetSponsoredAdBillingStatementPdf**
> System.IO.Stream GetSponsoredAdBillingStatementPdf (string month)

One month's ads statement as a PDF.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdBillingStatementPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var month = "month_example";  // string | 

            try
            {
                // One month's ads statement as a PDF.
                System.IO.Stream result = apiInstance.GetSponsoredAdBillingStatementPdf(month);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdBillingStatementPdf: " + e.Message );
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
 **month** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PDF document. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getsponsoredadbillingtopupreceipt"></a>
# **GetSponsoredAdBillingTopupReceipt**
> System.IO.Stream GetSponsoredAdBillingTopupReceipt (string id)

One ad balance top-up's receipt as a PDF (each top-up in the billing history carries its id and receipt number).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdBillingTopupReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One ad balance top-up's receipt as a PDF (each top-up in the billing history carries its id and receipt number).
                System.IO.Stream result = apiInstance.GetSponsoredAdBillingTopupReceipt(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdBillingTopupReceipt: " + e.Message );
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

**System.IO.Stream**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PDF document. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getsponsoredadcampaign"></a>
# **GetSponsoredAdCampaign**
> SponsoredAdCampaignResponse GetSponsoredAdCampaign (string id, string from = null, string to = null)

One campaign: settings, its listings (bid, suggested bid, live, per-listing stats) and keywords. A catalog boost (targetType wholesale_catalog) has `catalogs`: per boosted catalog impressions, clicks, spend, attributed trade orders and revenue, CTR and ROAS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var id = "id_example";  // string | 
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 

            try
            {
                // One campaign: settings, its listings (bid, suggested bid, live, per-listing stats) and keywords. A catalog boost (targetType wholesale_catalog) has `catalogs`: per boosted catalog impressions, clicks, spend, attributed trade orders and revenue, CTR and ROAS.
                SponsoredAdCampaignResponse result = apiInstance.GetSponsoredAdCampaign(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdCampaign: " + e.Message );
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
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

**SponsoredAdCampaignResponse**

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

<a name="getsponsoredadfund"></a>
# **GetSponsoredAdFund**
> GetSponsoredAdFundResponse GetSponsoredAdFund (string refresh = null)

What can pay for clicks now: the billing rails in effect (ad balance and/or CBX), the ad balance and ad credit, CBX headroom, unbilled clicks, available cents, auto top-up, the saved payment method and the refundable balance. refresh=true re-reads CBX.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var refresh = "true";  // string |  (optional) 

            try
            {
                // What can pay for clicks now: the billing rails in effect (ad balance and/or CBX), the ad balance and ad credit, CBX headroom, unbilled clicks, available cents, auto top-up, the saved payment method and the refundable balance. refresh=true re-reads CBX.
                GetSponsoredAdFundResponse result = apiInstance.GetSponsoredAdFund(refresh);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdFund: " + e.Message );
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
 **refresh** | **string**|  | [optional] 

### Return type

**GetSponsoredAdFundResponse**

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

<a name="getsponsoredadreport"></a>
# **GetSponsoredAdReport**
> GetSponsoredAdReportResponse GetSponsoredAdReport (string from = null, string to = null)

Sponsored report for a range: totals (spend, impressions, clicks, CTR, average CPC, attributed orders and revenue, ROAS), a zero-filled daily series, per-campaign rows (targetType listings | wholesale_catalog) and `catalogs`, one row per boosted catalog. Listing orders are Crossly purchases of the advertised listing within 7 days of a click by the same buyer; catalog orders are trade orders with that seller within 7 days of a catalog click by the same buyer. Catalog impressions count once per viewer per day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 

            try
            {
                // Sponsored report for a range: totals (spend, impressions, clicks, CTR, average CPC, attributed orders and revenue, ROAS), a zero-filled daily series, per-campaign rows (targetType listings | wholesale_catalog) and `catalogs`, one row per boosted catalog. Listing orders are Crossly purchases of the advertised listing within 7 days of a click by the same buyer; catalog orders are trade orders with that seller within 7 days of a catalog click by the same buyer. Catalog impressions count once per viewer per day.
                GetSponsoredAdReportResponse result = apiInstance.GetSponsoredAdReport(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdReport: " + e.Message );
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
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

**GetSponsoredAdReportResponse**

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

<a name="getsponsoredadsetting"></a>
# **GetSponsoredAdSetting**
> SponsoredAdResponse GetSponsoredAdSetting ()

Ads quick settings: adsPaused, accountDailyCapCents and spentTodayCents, defaultBidStrategy, autoTopup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSponsoredAdSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Ads quick settings: adsPaused, accountDailyCapCents and spentTodayCents, defaultBidStrategy, autoTopup.
                SponsoredAdResponse result = apiInstance.GetSponsoredAdSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.GetSponsoredAdSetting: " + e.Message );
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

**SponsoredAdResponse**

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

<a name="listlistingadcampaigns"></a>
# **ListListingAdCampaigns**
> ListListingAdCampaignsResponse ListListingAdCampaigns (string platform, string refresh = null)

Your ad campaigns on one marketplace (cached up to 15 minutes; refresh=true asks the marketplace now).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingAdCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var refresh = "0";  // string |  (optional) 

            try
            {
                // Your ad campaigns on one marketplace (cached up to 15 minutes; refresh=true asks the marketplace now).
                ListListingAdCampaignsResponse result = apiInstance.ListListingAdCampaigns(platform, refresh);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListListingAdCampaigns: " + e.Message );
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
 **platform** | **string**|  | 
 **refresh** | **string**|  | [optional] 

### Return type

**ListListingAdCampaignsResponse**

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

<a name="listlistingadplatforms"></a>
# **ListListingAdPlatforms**
> ListListingAdPlatformsResponse ListListingAdPlatforms ()

The ads registry: each marketplace that sells promotion, its programs (kind, scope, campaign and listing fields), which verbs are wired / need a capture / are unsupported, and whether you are connected there.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingAdPlatformsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // The ads registry: each marketplace that sells promotion, its programs (kind, scope, campaign and listing fields), which verbs are wired / need a capture / are unsupported, and whether you are connected there.
                ListListingAdPlatformsResponse result = apiInstance.ListListingAdPlatforms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListListingAdPlatforms: " + e.Message );
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

**ListListingAdPlatformsResponse**

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

<a name="listsponsoredadbillinghistory"></a>
# **ListSponsoredAdBillingHistory**
> ListSponsoredAdBillingHistoryResponse ListSponsoredAdBillingHistory (string kind = null, string before = null, decimal? limit = null)

Billing history newest first: top-ups (status, receipt number), click charges (how each was paid: ad balance, credit, CBX, written off), credits, refunds and Boost fees. kind filters; before (ISO time) pages; limit ≤ 100.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSponsoredAdBillingHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var kind = "topup";  // string |  (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Billing history newest first: top-ups (status, receipt number), click charges (how each was paid: ad balance, credit, CBX, written off), credits, refunds and Boost fees. kind filters; before (ISO time) pages; limit ≤ 100.
                ListSponsoredAdBillingHistoryResponse result = apiInstance.ListSponsoredAdBillingHistory(kind, before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListSponsoredAdBillingHistory: " + e.Message );
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
 **kind** | **string**|  | [optional] 
 **before** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListSponsoredAdBillingHistoryResponse**

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

<a name="listsponsoredadbillingstatements"></a>
# **ListSponsoredAdBillingStatements**
> ListSponsoredAdBillingStatementsResponse ListSponsoredAdBillingStatements ()

Months (YYYY-MM) with any ad billing activity, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSponsoredAdBillingStatementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Months (YYYY-MM) with any ad billing activity, newest first.
                ListSponsoredAdBillingStatementsResponse result = apiInstance.ListSponsoredAdBillingStatements();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListSponsoredAdBillingStatements: " + e.Message );
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

**ListSponsoredAdBillingStatementsResponse**

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

<a name="listsponsoredadboosts"></a>
# **ListSponsoredAdBoosts**
> ListSponsoredAdBoostsResponse ListSponsoredAdBoosts ()

Boosted (pay-on-sale) listings: the rate, sales and fees taken so far. A boost lifts organic ranking by up to 10% and costs its rate only when the listing sells on Crossly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSponsoredAdBoostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Boosted (pay-on-sale) listings: the rate, sales and fees taken so far. A boost lifts organic ranking by up to 10% and costs its rate only when the listing sells on Crossly.
                ListSponsoredAdBoostsResponse result = apiInstance.ListSponsoredAdBoosts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListSponsoredAdBoosts: " + e.Message );
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

**ListSponsoredAdBoostsResponse**

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

<a name="listsponsoredadcampaigns"></a>
# **ListSponsoredAdCampaigns**
> ListSponsoredAdCampaignsResponse ListSponsoredAdCampaigns (string from = null, string to = null)

Your Sponsored Listings campaigns with status, pacing (spent today, daily cap reached), budgets, bids, placements and stats for the range (from/to, YYYY-MM-DD; default last 30 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSponsoredAdCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 

            try
            {
                // Your Sponsored Listings campaigns with status, pacing (spent today, daily cap reached), budgets, bids, placements and stats for the range (from/to, YYYY-MM-DD; default last 30 days).
                ListSponsoredAdCampaignsResponse result = apiInstance.ListSponsoredAdCampaigns(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListSponsoredAdCampaigns: " + e.Message );
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
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

**ListSponsoredAdCampaignsResponse**

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

<a name="listsponsoredadlistings"></a>
# **ListSponsoredAdListings**
> ListSponsoredAdListingsResponse ListSponsoredAdListings (string from = null, string to = null)

Per-listing ad performance across campaigns for a range, plus suggestions: live listings with views but few sales that are not sponsored yet, with a suggested bid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSponsoredAdListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 

            try
            {
                // Per-listing ad performance across campaigns for a range, plus suggestions: live listings with views but few sales that are not sponsored yet, with a suggested bid.
                ListSponsoredAdListingsResponse result = apiInstance.ListSponsoredAdListings(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.ListSponsoredAdListings: " + e.Message );
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
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

**ListSponsoredAdListingsResponse**

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

<a name="updateadoffsite"></a>
# **UpdateAdOffsite**
> UpdateAdOffsiteResponse UpdateAdOffsite (UpdateAdOffsiteRequest updateAdOffsiteRequest)

Turn offsite ads on or off. Yours alone to set.

The toggle. Nothing else in the system sets `enabled` — no onboarding default, no bulk enable, no admin override. `maxOffsiteShareBps` caps how much of your budget may leave the platform, so opting in does not mean discovering the whole thing went to Google. `minReturnBps` sets the floor below which offsite spend auto-pauses: 20000 means we must return $2 of attributed revenue per $1 spent over the window. Toggling either way clears any existing auto-pause, so turning it back on later does not inherit a pause from months ago. When one of your ads brings a buyer who purchases somebody ELSE's item, that is reported to you as spillover so you can judge whether offsite traffic is reaching buyers who want YOUR item, and switch it off if not. It is not credited back — you bought clicks, which is how every ad market works.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAdOffsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var updateAdOffsiteRequest = new UpdateAdOffsiteRequest(); // UpdateAdOffsiteRequest | 

            try
            {
                // Turn offsite ads on or off. Yours alone to set.
                UpdateAdOffsiteResponse result = apiInstance.UpdateAdOffsite(updateAdOffsiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateAdOffsite: " + e.Message );
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
 **updateAdOffsiteRequest** | **UpdateAdOffsiteRequest**|  | 

### Return type

**UpdateAdOffsiteResponse**

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

<a name="updatelistingadcampaign"></a>
# **UpdateListingAdCampaign**
> CreateListingAdCampaignResponse UpdateListingAdCampaign (string platform, string campaignId, UpdateListingAdCampaignRequest updateListingAdCampaignRequest)

Change a marketplace campaign: name, dailyBudgetCents, endsAt (null clears), status paused | running | ended.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingAdCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var campaignId = "campaignId_example";  // string | 
            var updateListingAdCampaignRequest = new UpdateListingAdCampaignRequest(); // UpdateListingAdCampaignRequest | 

            try
            {
                // Change a marketplace campaign: name, dailyBudgetCents, endsAt (null clears), status paused | running | ended.
                CreateListingAdCampaignResponse result = apiInstance.UpdateListingAdCampaign(platform, campaignId, updateListingAdCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateListingAdCampaign: " + e.Message );
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
 **platform** | **string**|  | 
 **campaignId** | **string**|  | 
 **updateListingAdCampaignRequest** | **UpdateListingAdCampaignRequest**|  | 

### Return type

**CreateListingAdCampaignResponse**

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

<a name="updatelistingadlistingrate"></a>
# **UpdateListingAdListingRate**
> UpdateListingAdListingRateResponse UpdateListingAdListingRate (string platform, string platformListingId, UpdateListingAdListingRateRequest updateListingAdListingRateRequest)

Change one promoted listing's ad rate (percent of the sale) in the campaign it is in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingAdListingRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var platform = "platform_example";  // string | 
            var platformListingId = "platformListingId_example";  // string | 
            var updateListingAdListingRateRequest = new UpdateListingAdListingRateRequest(); // UpdateListingAdListingRateRequest | 

            try
            {
                // Change one promoted listing's ad rate (percent of the sale) in the campaign it is in.
                UpdateListingAdListingRateResponse result = apiInstance.UpdateListingAdListingRate(platform, platformListingId, updateListingAdListingRateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateListingAdListingRate: " + e.Message );
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
 **platform** | **string**|  | 
 **platformListingId** | **string**|  | 
 **updateListingAdListingRateRequest** | **UpdateListingAdListingRateRequest**|  | 

### Return type

**UpdateListingAdListingRateResponse**

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

<a name="updatesponsoredadbillingautotopup"></a>
# **UpdateSponsoredAdBillingAutoTopup**
> SponsoredAdResponse UpdateSponsoredAdBillingAutoTopup (UpdateSponsoredAdBillingAutoTopupRequest updateSponsoredAdBillingAutoTopupRequest)

Auto top-up: enabled, thresholdCents (top up when the ad balance drops below it), amountCents (how much). Needs a saved payment method (the first top-up saves it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSponsoredAdBillingAutoTopupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var updateSponsoredAdBillingAutoTopupRequest = new UpdateSponsoredAdBillingAutoTopupRequest(); // UpdateSponsoredAdBillingAutoTopupRequest | 

            try
            {
                // Auto top-up: enabled, thresholdCents (top up when the ad balance drops below it), amountCents (how much). Needs a saved payment method (the first top-up saves it).
                SponsoredAdResponse result = apiInstance.UpdateSponsoredAdBillingAutoTopup(updateSponsoredAdBillingAutoTopupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateSponsoredAdBillingAutoTopup: " + e.Message );
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
 **updateSponsoredAdBillingAutoTopupRequest** | **UpdateSponsoredAdBillingAutoTopupRequest**|  | 

### Return type

**SponsoredAdResponse**

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

<a name="updatesponsoredadboost"></a>
# **UpdateSponsoredAdBoost**
> UpdateSponsoredAdBoostResponse UpdateSponsoredAdBoost (UpdateSponsoredAdBoostRequest updateSponsoredAdBoostRequest)

Boost listings in bulk (platformListingIds, upliftBps 100–2000 = 1–20%), or change their rate. Your own live Crossly listings only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSponsoredAdBoostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var updateSponsoredAdBoostRequest = new UpdateSponsoredAdBoostRequest(); // UpdateSponsoredAdBoostRequest | 

            try
            {
                // Boost listings in bulk (platformListingIds, upliftBps 100–2000 = 1–20%), or change their rate. Your own live Crossly listings only.
                UpdateSponsoredAdBoostResponse result = apiInstance.UpdateSponsoredAdBoost(updateSponsoredAdBoostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateSponsoredAdBoost: " + e.Message );
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
 **updateSponsoredAdBoostRequest** | **UpdateSponsoredAdBoostRequest**|  | 

### Return type

**UpdateSponsoredAdBoostResponse**

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

<a name="updatesponsoredadcampaign"></a>
# **UpdateSponsoredAdCampaign**
> SponsoredAdCampaignResponse UpdateSponsoredAdCampaign (string id)

Edit a campaign. Any of the create fields; listings and keywords, when given, replace the current set. Raising the total budget resumes a campaign stopped by it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSponsoredAdCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Edit a campaign. Any of the create fields; listings and keywords, when given, replace the current set. Raising the total budget resumes a campaign stopped by it.
                SponsoredAdCampaignResponse result = apiInstance.UpdateSponsoredAdCampaign(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateSponsoredAdCampaign: " + e.Message );
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

**SponsoredAdCampaignResponse**

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

<a name="updatesponsoredadsetting"></a>
# **UpdateSponsoredAdSetting**
> SponsoredAdResponse UpdateSponsoredAdSetting ()

Change ads quick settings: adsPaused (pause / resume every ad), accountDailyCapCents (null = no cap), defaultBidStrategy (auto | manual) for new campaigns, autoTopup {enabled, thresholdCents?, amountCents?}, railPreference (cash_first | cbx_first, both rails live only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSponsoredAdSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdsApi(config);

            try
            {
                // Change ads quick settings: adsPaused (pause / resume every ad), accountDailyCapCents (null = no cap), defaultBidStrategy (auto | manual) for new campaigns, autoTopup {enabled, thresholdCents?, amountCents?}, railPreference (cash_first | cbx_first, both rails live only).
                SponsoredAdResponse result = apiInstance.UpdateSponsoredAdSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdsApi.UpdateSponsoredAdSetting: " + e.Message );
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

**SponsoredAdResponse**

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

