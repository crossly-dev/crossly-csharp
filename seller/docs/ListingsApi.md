# net.crossly.Api.ListingsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAiDetectionDispute**](ListingsApi.md#createaidetectiondispute) | **POST** /v1/ai-detections/{id}/dispute | Dispute an AI-image detection on your photo (sends it to Crossly review).
[**CreateEvent**](ListingsApi.md#createevent) | **POST** /v1/events | Create an event. A draft unless publish:true. Linked listings, the live show, the drop and the discount code must all be yours.
[**CreateEventPublish**](ListingsApi.md#createeventpublish) | **POST** /v1/events/{id}/publish | Publish an event: its page goes live, and with notifyFollowers your followers are told once.
[**CreateListing**](ListingsApi.md#createlisting) | **POST** /v1/listings | Create a listing and fan out crosspost jobs across platforms.
[**CreateListingBulk**](ListingsApi.md#createlistingbulk) | **POST** /v1/listings/bulk | Create up to 50 listings in one call, with a result per item.
[**CreateListingBulkCheckStatus**](ListingsApi.md#createlistingbulkcheckstatus) | **POST** /v1/listings/bulk-check-status | Check listing status on platforms
[**CreateListingBulkCrosspost**](ListingsApi.md#createlistingbulkcrosspost) | **POST** /v1/listings/bulk-crosspost | Bulk crosspost (no delist phase)
[**CreateListingBulkDelete**](ListingsApi.md#createlistingbulkdelete) | **POST** /v1/listings/bulk-delete | Bulk archive + delist
[**CreateListingBulkDelist**](ListingsApi.md#createlistingbulkdelist) | **POST** /v1/listings/bulk-delist | Bulk delist from platforms
[**CreateListingBulkDelistPreview**](ListingsApi.md#createlistingbulkdelistpreview) | **POST** /v1/listings/bulk-delist-preview | Preview which marketplaces a delist would touch
[**CreateListingBulkHardDelete**](ListingsApi.md#createlistingbulkharddelete) | **POST** /v1/listings/bulk-hard-delete | Permanently delete listings (live ones need allowLive)
[**CreateListingBulkRelist**](ListingsApi.md#createlistingbulkrelist) | **POST** /v1/listings/bulk-relist | Bulk relist across platforms
[**CreateListingBulkUpdate**](ListingsApi.md#createlistingbulkupdate) | **POST** /v1/listings/bulk-update | Bulk update listing fields
[**CreateListingById**](ListingsApi.md#createlistingbyid) | **POST** /v1/listings/by-ids | Fetch hydrated listings by ID
[**CreateListingCheckDuplicate**](ListingsApi.md#createlistingcheckduplicate) | **POST** /v1/listings/check-duplicates | Check whether the seller already owns something matching this title/photo, and what to do about it.
[**CreateListingCombine**](ListingsApi.md#createlistingcombine) | **POST** /v1/listings/combine | Combine duplicate listings into one: sums their stock, delists and archives the rest.
[**CreateListingDiscrepancyResolve**](ListingsApi.md#createlistingdiscrepancyresolve) | **POST** /v1/listings/{id}/discrepancies/{discrepancyId}/resolve | Resolve a detected marketplace-drift discrepancy: accept the platform value, push ours back, relist to apply it, or dismiss.
[**CreateListingImportByUrl**](ListingsApi.md#createlistingimportbyurl) | **POST** /v1/listings/{id}/import-by-url | Attach a real platform listing to this listing by pasting its live URL.
[**CreateListingMagicFill**](ListingsApi.md#createlistingmagicfill) | **POST** /v1/listings/{id}/magic-fill | Auto-fill empty fields on one platform tab from the master listing + AI/deterministic taxonomy resolution.
[**CreateListingMerge**](ListingsApi.md#createlistingmerge) | **POST** /v1/listings/merge | Merge the same item listed on different marketplaces into one listing; all stay live.
[**CreateListingTagBulk**](ListingsApi.md#createlistingtagbulk) | **POST** /v1/listings/tags/bulk | Add and/or remove tags on many listings (yours only; max 30 tags a listing, 40 chars a tag). &#x60;dryRun&#x60; reports what would change.
[**CreateListingTagRename**](ListingsApi.md#createlistingtagrename) | **POST** /v1/listings/tags/rename | Rename a tag on every listing; merges into &#x60;to&#x60; when it already exists.
[**CreateLiveStream**](ListingsApi.md#createlivestream) | **POST** /v1/live-streams | Schedule a live show: title, start time, optional cover, category and the listings to feature (becomes the lineup, in order).
[**CreateLiveStreamConnection**](ListingsApi.md#createlivestreamconnection) | **POST** /v1/live-streams/{id}/connection | The show’s video connection, minted on first call and identical after: RTMP(S) server + stream key, SRT URL, WHIP URL for browser publishing (null where the ingest has none) and the HLS playback URL. configured&#x3D;false (with a reason) when the deployment has no streaming provider.
[**CreateLiveStreamConnectionRotate**](ListingsApi.md#createlivestreamconnectionrotate) | **POST** /v1/live-streams/{id}/connection/rotate | Replace the show’s stream key (e.g. after it was shown on screen). Refused while the show is live.
[**CreateLiveStreamEnd**](ListingsApi.md#createlivestreamend) | **POST** /v1/live-streams/{id}/end | End the show. Idempotent.
[**CreateLiveStreamPinLaunch**](ListingsApi.md#createlivestreampinlaunch) | **POST** /v1/live-streams/{id}/pin-launch | Pin one of your live NFT launches on your live show; viewers mint it from the stream. Returns &#x60;{ ok }&#x60;.
[**CreateLiveStreamStart**](ListingsApi.md#createlivestreamstart) | **POST** /v1/live-streams/{id}/start | Go live: the show’s status becomes live and followers are notified once. Idempotent while live; refused once ended.
[**CreatePassport**](ListingsApi.md#createpassport) | **POST** /v1/passports | Register a product passport for a Crossly listing or an inventory item you sell, optionally bound to an NFC tag UID (hex). Active at once. Returns the URL to write to the NFC tag or print as a QR; ownership then follows the item’s sales. For several items with photos and labels, use the drafts flow (POST /passports/drafts).
[**CreatePassportDraft**](ListingsApi.md#createpassportdraft) | **POST** /v1/passports/drafts | Start a passport draft for up to 100 inventory items (or Crossly listings): one draft passport per item with its code reserved. Items whose every unit already has a passport come back in skipped.
[**CreatePassportDraftActivate**](ListingsApi.md#createpassportdraftactivate) | **POST** /v1/passports/drafts/{id}/activate | Activate every passport of a draft: their pages open for anyone who scans the tag or QR. Closes the draft’s capture link.
[**CreatePassportDraftCaptureLink**](ListingsApi.md#createpassportdraftcapturelink) | **POST** /v1/passports/drafts/{id}/capture-link | A link (and its QR as SVG) any phone opens with no sign-in to add photos, serials and NFC tags to this draft. Open 30 minutes after its last use, 4 hours at most; minting a new one closes the old.
[**CreatePassportPrint**](ListingsApi.md#createpassportprint) | **POST** /v1/passports/print | Print passport labels: sent to your printer agent (the Crossly desktop app includes one) when it is online and prints the template, else a signed PDF link with the reason. Templates: sticker-2in, sticker-1in, label-4x6, hang-tag, sheet-letter, sheet-a4, transfer-card.
[**CreatePassportRevoke**](ListingsApi.md#createpassportrevoke) | **POST** /v1/passports/{id}/revoke | Revoke a passport (a lost or misprinted tag). Refused once the item has sold — the passport is then part of its history.
[**CreatePassportTag**](ListingsApi.md#createpassporttag) | **POST** /v1/passports/{id}/tag | Bind (or re-bind) a passport to the NFC tag you wrote its nfcUrl to: the tag UID (hex), and whether you locked the tag read-only. Refused once the item has sold, for a locked tag, or a tag already on another item.
[**CreateRentalBulkRentable**](ListingsApi.md#createrentalbulkrentable) | **POST** /v1/rentals/bulk-rentable | Make up to 200 Crossly listings rentable with the same options (a day rate, or a share of each price).
[**CreateShopLimitRequest**](ListingsApi.md#createshoplimitrequest) | **POST** /v1/shop-limits/requests | Ask for a higher Crossly Shop selling limit.
[**CreateStory**](ListingsApi.md#createstory) | **POST** /v1/stories | Share a story: 1–10 slides played in order. Each slide is a photo or video plus optional overlays (positions are fractions of the 9:16 frame). Listing stickers must be your own Crossly listings and also tag the slide; @mentions must be real shops. audience: everyone | followers; expiresInHours: 6, 12, 24 or 48.
[**CreateVariationGroup**](ListingsApi.md#createvariationgroup) | **POST** /v1/variation-groups | Group listings you already have: a variation (one product, an axis such as Size) or a purchase-rule group (\&quot;buy any 3\&quot;).
[**CreateVariationGroupGenerate**](ListingsApi.md#createvariationgroupgenerate) | **POST** /v1/variation-groups/generate | Turn one listing into a variation group: each new value becomes its own listing (a copy, with its own price, quantity and SKU) and all of them one group.
[**CreateVariationGroupGenerateMatrix**](ListingsApi.md#createvariationgroupgeneratematrix) | **POST** /v1/variation-groups/generate-matrix | Turn one listing into a variation group over up to three axes (Size × Color): each other cell is a listing you already have (listingId) or a new copy of this one with its own price, quantity and SKU.
[**CreateVariationGroupPublish**](ListingsApi.md#createvariationgrouppublish) | **POST** /v1/variation-groups/{id}/publish | Publish a variation group per platform: one listing with a variation picker where the platform supports it (eBay, Shopify, Etsy), one per option elsewhere. Each platform reports its own outcome.
[**CreateVideoStudioFinalize**](ListingsApi.md#createvideostudiofinalize) | **POST** /v1/video-studio/finalize | Check an uploaded listing video (exists, MP4, size) and, with listingId, set it as that listing&#39;s video.
[**CreateVideoStudioUploadUrl**](ListingsApi.md#createvideostudiouploadurl) | **POST** /v1/video-studio/upload-url | Presign an R2 PUT (video/mp4, 15 min) for a listing video; finalize it after the upload.
[**DeleteEvent**](ListingsApi.md#deleteevent) | **DELETE** /v1/events/{id} | Delete a draft, or cancel a published event (its page then says it was called off).
[**DeleteListing**](ListingsApi.md#deletelisting) | **DELETE** /v1/listings/{id} | Delist a listing (optionally narrowed to specific platforms via ?platforms&#x3D;).
[**DeleteListingTag**](ListingsApi.md#deletelistingtag) | **DELETE** /v1/listings/tags/{tag} | Remove a tag (any case) from every listing.
[**DeleteLiveStreamPinLaunch**](ListingsApi.md#deletelivestreampinlaunch) | **DELETE** /v1/live-streams/{id}/pin-launch | Unpin the launch from your live show. Returns &#x60;{ ok }&#x60;.
[**DeleteRentalOffer**](ListingsApi.md#deleterentaloffer) | **DELETE** /v1/rentals/offers/{platformListingId} | Stop offering a listing for rent (existing bookings stand).
[**DeleteStory**](ListingsApi.md#deletestory) | **DELETE** /v1/stories/{id} | Take one story slide down before it expires.
[**DeleteVariationGroup**](ListingsApi.md#deletevariationgroup) | **DELETE** /v1/variation-groups/{id} | Dissolve a group. Its options stay as ordinary listings.
[**GetEvent**](ListingsApi.md#getevent) | **GET** /v1/events/{id} | One of your events.
[**GetEventAnalytic**](ListingsApi.md#geteventanalytic) | **GET** /v1/events/{id}/analytics | Views, RSVPs, and what the linked listings sold on Crossly during the event (orders, units, revenue in cents).
[**GetListing**](ListingsApi.md#getlisting) | **GET** /v1/listings/{id} | Get one listing with its platform rows.
[**GetListingFacet**](ListingsApi.md#getlistingfacet) | **GET** /v1/listings/facets | Distinct brands + categories across listings + inventory.
[**GetListingSkuExist**](ListingsApi.md#getlistingskuexist) | **GET** /v1/listings/sku-exists | Check whether a SKU is already used by one of this user&#39;s items.
[**GetLiveStreamRecap**](ListingsApi.md#getlivestreamrecap) | **GET** /v1/live-streams/{id}/recap | The show’s numbers: duration, peak viewers, items sold and gross, tips, chat messages, auctions run, lineup size and the replay URL.
[**GetPassport**](ListingsApi.md#getpassport) | **GET** /v1/passports/{id} | One passport: its item and every listing of it, the event history (created, printed, tag bound, transferred, claimed…), scans per day for 30 days, custody, grading.
[**GetPassportDraft**](ListingsApi.md#getpassportdraft) | **GET** /v1/passports/drafts/{id} | A passport draft and its passports (photos, serial, tag and label state of each).
[**GetPassportPrint**](ListingsApi.md#getpassportprint) | **GET** /v1/passports/print/{jobId} | Where a passport print job sent to your agent is: queued, sent, done, failed, expired or duplicate.
[**GetPricingSetting**](ListingsApi.md#getpricingsetting) | **GET** /v1/pricing/settings | Selling options: own-price match (Crossly sells your items at your own lower price for the same item on another marketplace; dollar-priced copies only) and layaway (buyers may put items on layaway). Both on by default.
[**GetPricingSoldComp**](ListingsApi.md#getpricingsoldcomp) | **GET** /v1/pricing/sold-comps | What one catalog product (market_sku_id, in one condition) actually sold for across Crossly in the last 180 days: median, p25/p75, p10/p90 (null under 10 sales), sale count, last sold, and days from listing to sale (median, p25, p75). Pass marketSkuId (+ optional condition) or one of your listingIds. comps is null until there are 3+ sales from 2+ sellers; holdCode says why there is nothing (no_market_sku, mixed_inventory, below_privacy_floor) — the same reasons a sold_median reprice rule holds.
[**GetRentalPolicy**](ListingsApi.md#getrentalpolicy) | **GET** /v1/rentals/policy | The return and payment policies a rental inherits from Settings › Policies, resolved for the store (or for one listing with ?listingId): preset ids and names, the level each came from, the return line, protections, arrival photos, the deposit claim window in days, a required deposit in basis points, accepted methods, and editPath.
[**GetRentalSetting**](ListingsApi.md#getrentalsetting) | **GET** /v1/rentals/settings | The store’s rental defaults (every item inherits them) and its payout timing.
[**GetShopLimit**](ListingsApi.md#getshoplimit) | **GET** /v1/shop-limits | Your Crossly Shop selling limit: live listings and listed value, used of limit, per store, and the next step.
[**GetStockxCatalog**](ListingsApi.md#getstockxcatalog) | **GET** /v1/stockx/catalog | Search the StockX catalog (style code, SKU or words) to pick the product a StockX ask is on.
[**GetStockxCatalogVariantMarketData**](ListingsApi.md#getstockxcatalogvariantmarketdata) | **GET** /v1/stockx/catalog/{productId}/variants/{variantId}/market-data | Lowest ask, highest bid and suggested prices for one StockX size.
[**ListEventAttendees**](ListingsApi.md#listeventattendees) | **GET** /v1/events/{id}/attendees | Who RSVPd: display name, avatar, going or interested, and when. No contact details.
[**ListEvents**](ListingsApi.md#listevents) | **GET** /v1/events | Your events (launches, sales, live shows, drops, meetups, pop-ups, workshops, parties): schedule, status, phase, and going/interested counts.
[**ListListingAiDetections**](ListingsApi.md#listlistingaidetections) | **GET** /v1/listings/{id}/ai-detections | Crossly&#39;s AI-image detections for a listing&#39;s photos.
[**ListListingDiscrepancies**](ListingsApi.md#listlistingdiscrepancies) | **GET** /v1/listings/{id}/discrepancies | List detected marketplace-drift discrepancies for a listing.
[**ListListingIds**](ListingsApi.md#listlistingids) | **GET** /v1/listings/ids | Filter listings → return matching id list (no pagination).
[**ListListingTagSuggest**](ListingsApi.md#listlistingtagsuggest) | **GET** /v1/listings/tags/suggest | Deterministic tag suggestions for one listing (brand, category, size, condition, colors, style tags, era words in the title); &#x60;known&#x60; &#x3D; you already use the tag.
[**ListListingTags**](ListingsApi.md#listlistingtags) | **GET** /v1/listings/tags | Your listing tags with how many listings carry each, most used first (case-insensitive; &#x60;q&#x60; filters).
[**ListListings**](ListingsApi.md#listlistings) | **GET** /v1/listings | List active platform listings.
[**ListLiveStreams**](ListingsApi.md#listlivestreams) | **GET** /v1/live-streams | Your live shows, newest scheduled first: status, cover, category, connection method and peak viewers.
[**ListPassportEvents**](ListingsApi.md#listpassportevents) | **GET** /v1/passports/{id}/events | A passport’s event history, newest first (never a buyer or a price).
[**ListPassportPrintTargets**](ListingsApi.md#listpassportprinttargets) | **GET** /v1/passports/print-targets | Your printer agents (online, printers, default) and the passport label templates each can print.
[**ListPassports**](ListingsApi.md#listpassports) | **GET** /v1/passports | Product passports you registered (optionally for one Crossly listing): the code and URL each tag carries.
[**ListRentalOffers**](ListingsApi.md#listrentaloffers) | **GET** /v1/rentals/offers | What you offer for rent. Each offer carries &#x60;policy&#x60;: the return and payment policies it inherits from Settings › Policies, resolved (preset ids and names, the level they came from, protections, claim window, deposit, accepted methods, and editPath), with &#x60;returnPolicyOverride&#x60; when the offer writes its own return text.
[**ListStockxCatalogVariants**](ListingsApi.md#liststockxcatalogvariants) | **GET** /v1/stockx/catalog/{productId}/variants | List the sizes (variants) of a StockX catalog product.
[**ListStories**](ListingsApi.md#liststories) | **GET** /v1/stories | Your active story slides (newest run first, each run in play order), with their overlays: text, listing stickers, @mentions, links, emoji and drawing.
[**UpdateEvent**](ListingsApi.md#updateevent) | **PATCH** /v1/events/{id} | Edit an event. Omitted fields are unchanged; null clears.
[**UpdateHotspot**](ListingsApi.md#updatehotspot) | **PUT** /v1/hotspots | Tag your listings at points on a story or lookbook photo (shop the look). Replaces that photo’s tags; at most 12.
[**UpdateListing**](ListingsApi.md#updatelisting) | **PATCH** /v1/listings/{id} | Edit a listing and fan out update jobs to existing platform listings.
[**UpdateListingAssignee**](ListingsApi.md#updatelistingassignee) | **PATCH** /v1/listings/assignee | Assign many listings to a teammate, round robin across several, or unassign them (null).
[**UpdateListingAssigneeById**](ListingsApi.md#updatelistingassigneebyid) | **PATCH** /v1/listings/{id}/assignee | Assign one listing to a teammate, or unassign it (null).
[**UpdateListingCustom**](ListingsApi.md#updatelistingcustom) | **PUT** /v1/listings/{id}/customs | Set a listing’s customs: HS code (6–10 digits), country of origin, and countries this item must not ship to on Crossly. Omitted fields are left alone; null (or [] for restrictedCountries) clears.
[**UpdateListingPlatformListing**](ListingsApi.md#updatelistingplatformlisting) | **PATCH** /v1/listings/{id}/platform-listings/{plId} | Set one marketplace copy&#39;s price (e.g. the ebay.com copy of a listing also live on ebay.co.uk), in that copy&#39;s own currency.
[**UpdateLiveStream**](ListingsApi.md#updatelivestream) | **PATCH** /v1/live-streams/{id} | Edit a show that has not ended: title, description, cover, category, start time (not once live) or connection method (browser | phone | encoder).
[**UpdateLiveStreamLineup**](ListingsApi.md#updatelivestreamlineup) | **PUT** /v1/live-streams/{id}/lineup | Set a live show’s lineup: your Crossly listings, in the order you will sell them. Buyers see it before they join; a sale of a lineup item while the show is live is recorded at its replay moment.
[**UpdatePassport**](ListingsApi.md#updatepassport) | **PATCH** /v1/passports/{id} | Change what a passport says (title, condition, maker, year, materials, notes) or add photo URLs (photos append: a passport keeps the ones it was registered with).
[**UpdatePassportDraft**](ListingsApi.md#updatepassportdraft) | **PATCH** /v1/passports/drafts/{id} | Move a draft to a step, pick its label template, add items or remove draft passports.
[**UpdatePricingSetting**](ListingsApi.md#updatepricingsetting) | **PUT** /v1/pricing/settings | Turn own-price match and/or layaway on or off for every one of your stores. One store: PUT /v1/storefronts/{id}/settings.
[**UpdateRentalOffer**](ListingsApi.md#updaterentaloffer) | **PUT** /v1/rentals/offers/{platformListingId} | Offer a Crossly listing for rent: day rate, optional week rate, deposit, min/max days, turnaround buffer, rent-only (off sale while offered), seller approval, unavailable date ranges (blackoutRanges, inclusive YYYY-MM-DD) and a return policy. Keeps the listing’s own rental terms in step. Needs a ship-from address.
[**UpdateRentalSetting**](ListingsApi.md#updaterentalsetting) | **PUT** /v1/rentals/settings | Set the store’s rental defaults and payout timing (on_start needs 3 rentals that came back).
[**UpdateVariationGroup**](ListingsApi.md#updatevariationgroup) | **PATCH** /v1/variation-groups/{id} | Retitle a group, rename its axis, or change a group&#39;s purchase rule (written into every member&#39;s description).


<a name="createaidetectiondispute"></a>
# **CreateAiDetectionDispute**
> CreateAiDetectionDisputeResponse CreateAiDetectionDispute (string id)

Dispute an AI-image detection on your photo (sends it to Crossly review).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiDetectionDisputeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Dispute an AI-image detection on your photo (sends it to Crossly review).
                CreateAiDetectionDisputeResponse result = apiInstance.CreateAiDetectionDispute(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateAiDetectionDispute: " + e.Message );
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

**CreateAiDetectionDisputeResponse**

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

<a name="createevent"></a>
# **CreateEvent**
> EventResponse CreateEvent (CreateEventRequest createEventRequest)

Create an event. A draft unless publish:true. Linked listings, the live show, the drop and the discount code must all be yours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createEventRequest = new CreateEventRequest(); // CreateEventRequest | 

            try
            {
                // Create an event. A draft unless publish:true. Linked listings, the live show, the drop and the discount code must all be yours.
                EventResponse result = apiInstance.CreateEvent(createEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateEvent: " + e.Message );
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
 **createEventRequest** | **CreateEventRequest**|  | 

### Return type

**EventResponse**

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

<a name="createeventpublish"></a>
# **CreateEventPublish**
> EventResponse CreateEventPublish (string id)

Publish an event: its page goes live, and with notifyFollowers your followers are told once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEventPublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Publish an event: its page goes live, and with notifyFollowers your followers are told once.
                EventResponse result = apiInstance.CreateEventPublish(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateEventPublish: " + e.Message );
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

**EventResponse**

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

<a name="createlisting"></a>
# **CreateListing**
> CreateListingResponse CreateListing (CreateListingRequest createListingRequest)

Create a listing and fan out crosspost jobs across platforms.

Listing fields go in `data`. Channel apps can also send `categoryId` (GET /v1/categories/search), `itemSpecifics` (validated against GET /v1/categories/:id/aspects; `warnings` lists soft problems), `condition`, `brand`, per-marketplace `overrides` and `policies` (preset ids from GET /v1/policies), folded in the way the web form does: an override replaces the master value on that marketplace, anything derived only fills blanks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingRequest = new CreateListingRequest(); // CreateListingRequest | 

            try
            {
                // Create a listing and fan out crosspost jobs across platforms.
                CreateListingResponse result = apiInstance.CreateListing(createListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListing: " + e.Message );
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
 **createListingRequest** | **CreateListingRequest**|  | 

### Return type

**CreateListingResponse**

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

<a name="createlistingbulk"></a>
# **CreateListingBulk**
> CreateListingBulkResponse CreateListingBulk (CreateListingBulkRequest createListingBulkRequest)

Create up to 50 listings in one call, with a result per item.

Each item is a POST /v1/listings body plus a required `clientReferenceId` (your id for it). Items run in order and independently: `data[i].status` is `created`, `existing` (that reference was already used — the listing is returned, nothing is created) or `error` with the code the single route would give. `error` means no listing exists for the item. A listing that was saved but could not be sent to a platform (e.g. no weight) is `created`, with that platform in `skipped` (reason, code, details). `meta` counts each. Retrying a batch only creates what is missing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkRequest = new CreateListingBulkRequest(); // CreateListingBulkRequest | 

            try
            {
                // Create up to 50 listings in one call, with a result per item.
                CreateListingBulkResponse result = apiInstance.CreateListingBulk(createListingBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulk: " + e.Message );
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
 **createListingBulkRequest** | **CreateListingBulkRequest**|  | 

### Return type

**CreateListingBulkResponse**

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

<a name="createlistingbulkcheckstatus"></a>
# **CreateListingBulkCheckStatus**
> CreateListingBulkDeleteResponse CreateListingBulkCheckStatus (CreateListingBulkDeleteRequest createListingBulkDeleteRequest)

Check listing status on platforms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkCheckStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkDeleteRequest = new CreateListingBulkDeleteRequest(); // CreateListingBulkDeleteRequest | 

            try
            {
                // Check listing status on platforms
                CreateListingBulkDeleteResponse result = apiInstance.CreateListingBulkCheckStatus(createListingBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkCheckStatus: " + e.Message );
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
 **createListingBulkDeleteRequest** | **CreateListingBulkDeleteRequest**|  | 

### Return type

**CreateListingBulkDeleteResponse**

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

<a name="createlistingbulkcrosspost"></a>
# **CreateListingBulkCrosspost**
> CreateListingBulkDeleteResponse CreateListingBulkCrosspost (CreateListingBulkRelistRequest createListingBulkRelistRequest)

Bulk crosspost (no delist phase)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkCrosspostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkRelistRequest = new CreateListingBulkRelistRequest(); // CreateListingBulkRelistRequest | 

            try
            {
                // Bulk crosspost (no delist phase)
                CreateListingBulkDeleteResponse result = apiInstance.CreateListingBulkCrosspost(createListingBulkRelistRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkCrosspost: " + e.Message );
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
 **createListingBulkRelistRequest** | **CreateListingBulkRelistRequest**|  | 

### Return type

**CreateListingBulkDeleteResponse**

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

<a name="createlistingbulkdelete"></a>
# **CreateListingBulkDelete**
> CreateListingBulkDeleteResponse CreateListingBulkDelete (CreateListingBulkDeleteRequest createListingBulkDeleteRequest)

Bulk archive + delist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkDeleteRequest = new CreateListingBulkDeleteRequest(); // CreateListingBulkDeleteRequest | 

            try
            {
                // Bulk archive + delist
                CreateListingBulkDeleteResponse result = apiInstance.CreateListingBulkDelete(createListingBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkDelete: " + e.Message );
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
 **createListingBulkDeleteRequest** | **CreateListingBulkDeleteRequest**|  | 

### Return type

**CreateListingBulkDeleteResponse**

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

<a name="createlistingbulkdelist"></a>
# **CreateListingBulkDelist**
> CreateListingBulkDeleteResponse CreateListingBulkDelist (CreateListingBulkDeleteRequest createListingBulkDeleteRequest)

Bulk delist from platforms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkDelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkDeleteRequest = new CreateListingBulkDeleteRequest(); // CreateListingBulkDeleteRequest | 

            try
            {
                // Bulk delist from platforms
                CreateListingBulkDeleteResponse result = apiInstance.CreateListingBulkDelist(createListingBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkDelist: " + e.Message );
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
 **createListingBulkDeleteRequest** | **CreateListingBulkDeleteRequest**|  | 

### Return type

**CreateListingBulkDeleteResponse**

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

<a name="createlistingbulkdelistpreview"></a>
# **CreateListingBulkDelistPreview**
> CreateListingBulkDelistPreviewResponse CreateListingBulkDelistPreview (CreateListingBulkDeleteRequest createListingBulkDeleteRequest)

Preview which marketplaces a delist would touch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkDelistPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkDeleteRequest = new CreateListingBulkDeleteRequest(); // CreateListingBulkDeleteRequest | 

            try
            {
                // Preview which marketplaces a delist would touch
                CreateListingBulkDelistPreviewResponse result = apiInstance.CreateListingBulkDelistPreview(createListingBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkDelistPreview: " + e.Message );
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
 **createListingBulkDeleteRequest** | **CreateListingBulkDeleteRequest**|  | 

### Return type

**CreateListingBulkDelistPreviewResponse**

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

<a name="createlistingbulkharddelete"></a>
# **CreateListingBulkHardDelete**
> CreateListingBulkHardDeleteResponse CreateListingBulkHardDelete (CreateListingBulkDeleteRequest createListingBulkDeleteRequest)

Permanently delete listings (live ones need allowLive)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkHardDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkDeleteRequest = new CreateListingBulkDeleteRequest(); // CreateListingBulkDeleteRequest | 

            try
            {
                // Permanently delete listings (live ones need allowLive)
                CreateListingBulkHardDeleteResponse result = apiInstance.CreateListingBulkHardDelete(createListingBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkHardDelete: " + e.Message );
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
 **createListingBulkDeleteRequest** | **CreateListingBulkDeleteRequest**|  | 

### Return type

**CreateListingBulkHardDeleteResponse**

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

<a name="createlistingbulkrelist"></a>
# **CreateListingBulkRelist**
> CreateListingBulkDeleteResponse CreateListingBulkRelist (CreateListingBulkRelistRequest createListingBulkRelistRequest)

Bulk relist across platforms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkRelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkRelistRequest = new CreateListingBulkRelistRequest(); // CreateListingBulkRelistRequest | 

            try
            {
                // Bulk relist across platforms
                CreateListingBulkDeleteResponse result = apiInstance.CreateListingBulkRelist(createListingBulkRelistRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkRelist: " + e.Message );
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
 **createListingBulkRelistRequest** | **CreateListingBulkRelistRequest**|  | 

### Return type

**CreateListingBulkDeleteResponse**

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

<a name="createlistingbulkupdate"></a>
# **CreateListingBulkUpdate**
> CreateListingBulkUpdateResponse CreateListingBulkUpdate (CreateListingBulkUpdateRequest createListingBulkUpdateRequest)

Bulk update listing fields

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingBulkUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingBulkUpdateRequest = new CreateListingBulkUpdateRequest(); // CreateListingBulkUpdateRequest | 

            try
            {
                // Bulk update listing fields
                CreateListingBulkUpdateResponse result = apiInstance.CreateListingBulkUpdate(createListingBulkUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingBulkUpdate: " + e.Message );
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
 **createListingBulkUpdateRequest** | **CreateListingBulkUpdateRequest**|  | 

### Return type

**CreateListingBulkUpdateResponse**

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

<a name="createlistingbyid"></a>
# **CreateListingById**
> CreateListingByIdResponse CreateListingById (CreateListingByIdRequest createListingByIdRequest)

Fetch hydrated listings by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingByIdRequest = new CreateListingByIdRequest(); // CreateListingByIdRequest | 

            try
            {
                // Fetch hydrated listings by ID
                CreateListingByIdResponse result = apiInstance.CreateListingById(createListingByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingById: " + e.Message );
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

**CreateListingByIdResponse**

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

<a name="createlistingcheckduplicate"></a>
# **CreateListingCheckDuplicate**
> CreateListingCheckDuplicateResponse CreateListingCheckDuplicate (CreateListingCheckDuplicateRequest createListingCheckDuplicateRequest = null)

Check whether the seller already owns something matching this title/photo, and what to do about it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingCheckDuplicateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingCheckDuplicateRequest = new CreateListingCheckDuplicateRequest(); // CreateListingCheckDuplicateRequest |  (optional) 

            try
            {
                // Check whether the seller already owns something matching this title/photo, and what to do about it.
                CreateListingCheckDuplicateResponse result = apiInstance.CreateListingCheckDuplicate(createListingCheckDuplicateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingCheckDuplicate: " + e.Message );
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
 **createListingCheckDuplicateRequest** | **CreateListingCheckDuplicateRequest**|  | [optional] 

### Return type

**CreateListingCheckDuplicateResponse**

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

<a name="createlistingcombine"></a>
# **CreateListingCombine**
> CreateListingCombineResponse CreateListingCombine (CreateListingMergeRequest createListingMergeRequest)

Combine duplicate listings into one: sums their stock, delists and archives the rest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingCombineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingMergeRequest = new CreateListingMergeRequest(); // CreateListingMergeRequest | 

            try
            {
                // Combine duplicate listings into one: sums their stock, delists and archives the rest.
                CreateListingCombineResponse result = apiInstance.CreateListingCombine(createListingMergeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingCombine: " + e.Message );
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
 **createListingMergeRequest** | **CreateListingMergeRequest**|  | 

### Return type

**CreateListingCombineResponse**

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

<a name="createlistingdiscrepancyresolve"></a>
# **CreateListingDiscrepancyResolve**
> CreateListingDiscrepancyResolveResponse CreateListingDiscrepancyResolve (Guid id, Guid discrepancyId, CreateListingDiscrepancyResolveRequest createListingDiscrepancyResolveRequest)

Resolve a detected marketplace-drift discrepancy: accept the platform value, push ours back, relist to apply it, or dismiss.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingDiscrepancyResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var discrepancyId = "discrepancyId_example";  // Guid | 
            var createListingDiscrepancyResolveRequest = new CreateListingDiscrepancyResolveRequest(); // CreateListingDiscrepancyResolveRequest | 

            try
            {
                // Resolve a detected marketplace-drift discrepancy: accept the platform value, push ours back, relist to apply it, or dismiss.
                CreateListingDiscrepancyResolveResponse result = apiInstance.CreateListingDiscrepancyResolve(id, discrepancyId, createListingDiscrepancyResolveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingDiscrepancyResolve: " + e.Message );
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
 **discrepancyId** | **Guid**|  | 
 **createListingDiscrepancyResolveRequest** | **CreateListingDiscrepancyResolveRequest**|  | 

### Return type

**CreateListingDiscrepancyResolveResponse**

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

<a name="createlistingimportbyurl"></a>
# **CreateListingImportByUrl**
> CreateListingImportByUrlResponse CreateListingImportByUrl (Guid id, CreateListingImportByUrlRequest createListingImportByUrlRequest)

Attach a real platform listing to this listing by pasting its live URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingImportByUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var createListingImportByUrlRequest = new CreateListingImportByUrlRequest(); // CreateListingImportByUrlRequest | 

            try
            {
                // Attach a real platform listing to this listing by pasting its live URL.
                CreateListingImportByUrlResponse result = apiInstance.CreateListingImportByUrl(id, createListingImportByUrlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingImportByUrl: " + e.Message );
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
 **createListingImportByUrlRequest** | **CreateListingImportByUrlRequest**|  | 

### Return type

**CreateListingImportByUrlResponse**

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

<a name="createlistingmagicfill"></a>
# **CreateListingMagicFill**
> CreateListingMagicFillResponse CreateListingMagicFill (Guid id, CreateListingMagicFillRequest createListingMagicFillRequest)

Auto-fill empty fields on one platform tab from the master listing + AI/deterministic taxonomy resolution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingMagicFillExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var createListingMagicFillRequest = new CreateListingMagicFillRequest(); // CreateListingMagicFillRequest | 

            try
            {
                // Auto-fill empty fields on one platform tab from the master listing + AI/deterministic taxonomy resolution.
                CreateListingMagicFillResponse result = apiInstance.CreateListingMagicFill(id, createListingMagicFillRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingMagicFill: " + e.Message );
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
 **createListingMagicFillRequest** | **CreateListingMagicFillRequest**|  | 

### Return type

**CreateListingMagicFillResponse**

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

<a name="createlistingmerge"></a>
# **CreateListingMerge**
> CreateListingMergeResponse CreateListingMerge (CreateListingMergeRequest createListingMergeRequest)

Merge the same item listed on different marketplaces into one listing; all stay live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingMergeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingMergeRequest = new CreateListingMergeRequest(); // CreateListingMergeRequest | 

            try
            {
                // Merge the same item listed on different marketplaces into one listing; all stay live.
                CreateListingMergeResponse result = apiInstance.CreateListingMerge(createListingMergeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingMerge: " + e.Message );
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
 **createListingMergeRequest** | **CreateListingMergeRequest**|  | 

### Return type

**CreateListingMergeResponse**

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

<a name="createlistingtagbulk"></a>
# **CreateListingTagBulk**
> CreateListingTagBulkResponse CreateListingTagBulk (CreateListingTagBulkRequest createListingTagBulkRequest)

Add and/or remove tags on many listings (yours only; max 30 tags a listing, 40 chars a tag). `dryRun` reports what would change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingTagBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingTagBulkRequest = new CreateListingTagBulkRequest(); // CreateListingTagBulkRequest | 

            try
            {
                // Add and/or remove tags on many listings (yours only; max 30 tags a listing, 40 chars a tag). `dryRun` reports what would change.
                CreateListingTagBulkResponse result = apiInstance.CreateListingTagBulk(createListingTagBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingTagBulk: " + e.Message );
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
 **createListingTagBulkRequest** | **CreateListingTagBulkRequest**|  | 

### Return type

**CreateListingTagBulkResponse**

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

<a name="createlistingtagrename"></a>
# **CreateListingTagRename**
> CreateListingTagRenameResponse CreateListingTagRename (CreateListingTagRenameRequest createListingTagRenameRequest)

Rename a tag on every listing; merges into `to` when it already exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingTagRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createListingTagRenameRequest = new CreateListingTagRenameRequest(); // CreateListingTagRenameRequest | 

            try
            {
                // Rename a tag on every listing; merges into `to` when it already exists.
                CreateListingTagRenameResponse result = apiInstance.CreateListingTagRename(createListingTagRenameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateListingTagRename: " + e.Message );
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
 **createListingTagRenameRequest** | **CreateListingTagRenameRequest**|  | 

### Return type

**CreateListingTagRenameResponse**

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

<a name="createlivestream"></a>
# **CreateLiveStream**
> LiveStreamResponse CreateLiveStream (CreateLiveStreamRequest createLiveStreamRequest)

Schedule a live show: title, start time, optional cover, category and the listings to feature (becomes the lineup, in order).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createLiveStreamRequest = new CreateLiveStreamRequest(); // CreateLiveStreamRequest | 

            try
            {
                // Schedule a live show: title, start time, optional cover, category and the listings to feature (becomes the lineup, in order).
                LiveStreamResponse result = apiInstance.CreateLiveStream(createLiveStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStream: " + e.Message );
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
 **createLiveStreamRequest** | **CreateLiveStreamRequest**|  | 

### Return type

**LiveStreamResponse**

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

<a name="createlivestreamconnection"></a>
# **CreateLiveStreamConnection**
> CreateLiveStreamConnectionResponse CreateLiveStreamConnection (string id)

The show’s video connection, minted on first call and identical after: RTMP(S) server + stream key, SRT URL, WHIP URL for browser publishing (null where the ingest has none) and the HLS playback URL. configured=false (with a reason) when the deployment has no streaming provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The show’s video connection, minted on first call and identical after: RTMP(S) server + stream key, SRT URL, WHIP URL for browser publishing (null where the ingest has none) and the HLS playback URL. configured=false (with a reason) when the deployment has no streaming provider.
                CreateLiveStreamConnectionResponse result = apiInstance.CreateLiveStreamConnection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStreamConnection: " + e.Message );
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

**CreateLiveStreamConnectionResponse**

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

<a name="createlivestreamconnectionrotate"></a>
# **CreateLiveStreamConnectionRotate**
> CreateLiveStreamConnectionResponse CreateLiveStreamConnectionRotate (string id)

Replace the show’s stream key (e.g. after it was shown on screen). Refused while the show is live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamConnectionRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Replace the show’s stream key (e.g. after it was shown on screen). Refused while the show is live.
                CreateLiveStreamConnectionResponse result = apiInstance.CreateLiveStreamConnectionRotate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStreamConnectionRotate: " + e.Message );
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

**CreateLiveStreamConnectionResponse**

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

<a name="createlivestreamend"></a>
# **CreateLiveStreamEnd**
> LiveStreamResponse CreateLiveStreamEnd (string id)

End the show. Idempotent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamEndExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // End the show. Idempotent.
                LiveStreamResponse result = apiInstance.CreateLiveStreamEnd(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStreamEnd: " + e.Message );
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

**LiveStreamResponse**

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

<a name="createlivestreampinlaunch"></a>
# **CreateLiveStreamPinLaunch**
> OkResponse CreateLiveStreamPinLaunch (string id)

Pin one of your live NFT launches on your live show; viewers mint it from the stream. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamPinLaunchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pin one of your live NFT launches on your live show; viewers mint it from the stream. Returns `{ ok }`.
                OkResponse result = apiInstance.CreateLiveStreamPinLaunch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStreamPinLaunch: " + e.Message );
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

<a name="createlivestreamstart"></a>
# **CreateLiveStreamStart**
> LiveStreamResponse CreateLiveStreamStart (string id)

Go live: the show’s status becomes live and followers are notified once. Idempotent while live; refused once ended.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLiveStreamStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Go live: the show’s status becomes live and followers are notified once. Idempotent while live; refused once ended.
                LiveStreamResponse result = apiInstance.CreateLiveStreamStart(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateLiveStreamStart: " + e.Message );
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

**LiveStreamResponse**

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

<a name="createpassport"></a>
# **CreatePassport**
> PassportResponse CreatePassport (CreatePassportRequest createPassportRequest)

Register a product passport for a Crossly listing or an inventory item you sell, optionally bound to an NFC tag UID (hex). Active at once. Returns the URL to write to the NFC tag or print as a QR; ownership then follows the item’s sales. For several items with photos and labels, use the drafts flow (POST /passports/drafts).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createPassportRequest = new CreatePassportRequest(); // CreatePassportRequest | 

            try
            {
                // Register a product passport for a Crossly listing or an inventory item you sell, optionally bound to an NFC tag UID (hex). Active at once. Returns the URL to write to the NFC tag or print as a QR; ownership then follows the item’s sales. For several items with photos and labels, use the drafts flow (POST /passports/drafts).
                PassportResponse result = apiInstance.CreatePassport(createPassportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassport: " + e.Message );
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
 **createPassportRequest** | **CreatePassportRequest**|  | 

### Return type

**PassportResponse**

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

<a name="createpassportdraft"></a>
# **CreatePassportDraft**
> PassportDraftResponse CreatePassportDraft (CreatePassportDraftRequest createPassportDraftRequest = null)

Start a passport draft for up to 100 inventory items (or Crossly listings): one draft passport per item with its code reserved. Items whose every unit already has a passport come back in skipped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createPassportDraftRequest = new CreatePassportDraftRequest(); // CreatePassportDraftRequest |  (optional) 

            try
            {
                // Start a passport draft for up to 100 inventory items (or Crossly listings): one draft passport per item with its code reserved. Items whose every unit already has a passport come back in skipped.
                PassportDraftResponse result = apiInstance.CreatePassportDraft(createPassportDraftRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportDraft: " + e.Message );
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
 **createPassportDraftRequest** | **CreatePassportDraftRequest**|  | [optional] 

### Return type

**PassportDraftResponse**

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

<a name="createpassportdraftactivate"></a>
# **CreatePassportDraftActivate**
> PassportDraftResponse CreatePassportDraftActivate (string id)

Activate every passport of a draft: their pages open for anyone who scans the tag or QR. Closes the draft’s capture link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportDraftActivateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Activate every passport of a draft: their pages open for anyone who scans the tag or QR. Closes the draft’s capture link.
                PassportDraftResponse result = apiInstance.CreatePassportDraftActivate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportDraftActivate: " + e.Message );
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

**PassportDraftResponse**

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

<a name="createpassportdraftcapturelink"></a>
# **CreatePassportDraftCaptureLink**
> CreatePassportDraftCaptureLinkResponse CreatePassportDraftCaptureLink (string id)

A link (and its QR as SVG) any phone opens with no sign-in to add photos, serials and NFC tags to this draft. Open 30 minutes after its last use, 4 hours at most; minting a new one closes the old.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportDraftCaptureLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A link (and its QR as SVG) any phone opens with no sign-in to add photos, serials and NFC tags to this draft. Open 30 minutes after its last use, 4 hours at most; minting a new one closes the old.
                CreatePassportDraftCaptureLinkResponse result = apiInstance.CreatePassportDraftCaptureLink(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportDraftCaptureLink: " + e.Message );
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

**CreatePassportDraftCaptureLinkResponse**

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

<a name="createpassportprint"></a>
# **CreatePassportPrint**
> CreatePassportPrintResponse CreatePassportPrint (CreatePassportPrintRequest createPassportPrintRequest = null)

Print passport labels: sent to your printer agent (the Crossly desktop app includes one) when it is online and prints the template, else a signed PDF link with the reason. Templates: sticker-2in, sticker-1in, label-4x6, hang-tag, sheet-letter, sheet-a4, transfer-card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportPrintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createPassportPrintRequest = new CreatePassportPrintRequest(); // CreatePassportPrintRequest |  (optional) 

            try
            {
                // Print passport labels: sent to your printer agent (the Crossly desktop app includes one) when it is online and prints the template, else a signed PDF link with the reason. Templates: sticker-2in, sticker-1in, label-4x6, hang-tag, sheet-letter, sheet-a4, transfer-card.
                CreatePassportPrintResponse result = apiInstance.CreatePassportPrint(createPassportPrintRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportPrint: " + e.Message );
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
 **createPassportPrintRequest** | **CreatePassportPrintRequest**|  | [optional] 

### Return type

**CreatePassportPrintResponse**

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

<a name="createpassportrevoke"></a>
# **CreatePassportRevoke**
> PassportResponse CreatePassportRevoke (string id)

Revoke a passport (a lost or misprinted tag). Refused once the item has sold — the passport is then part of its history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Revoke a passport (a lost or misprinted tag). Refused once the item has sold — the passport is then part of its history.
                PassportResponse result = apiInstance.CreatePassportRevoke(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportRevoke: " + e.Message );
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

**PassportResponse**

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

<a name="createpassporttag"></a>
# **CreatePassportTag**
> PassportResponse CreatePassportTag (string id, CreatePassportTagRequest createPassportTagRequest)

Bind (or re-bind) a passport to the NFC tag you wrote its nfcUrl to: the tag UID (hex), and whether you locked the tag read-only. Refused once the item has sold, for a locked tag, or a tag already on another item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePassportTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var createPassportTagRequest = new CreatePassportTagRequest(); // CreatePassportTagRequest | 

            try
            {
                // Bind (or re-bind) a passport to the NFC tag you wrote its nfcUrl to: the tag UID (hex), and whether you locked the tag read-only. Refused once the item has sold, for a locked tag, or a tag already on another item.
                PassportResponse result = apiInstance.CreatePassportTag(id, createPassportTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreatePassportTag: " + e.Message );
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
 **createPassportTagRequest** | **CreatePassportTagRequest**|  | 

### Return type

**PassportResponse**

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

<a name="createrentalbulkrentable"></a>
# **CreateRentalBulkRentable**
> CreateRentalBulkRentableResponse CreateRentalBulkRentable (CreateRentalBulkRentableRequest createRentalBulkRentableRequest)

Make up to 200 Crossly listings rentable with the same options (a day rate, or a share of each price).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateRentalBulkRentableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createRentalBulkRentableRequest = new CreateRentalBulkRentableRequest(); // CreateRentalBulkRentableRequest | 

            try
            {
                // Make up to 200 Crossly listings rentable with the same options (a day rate, or a share of each price).
                CreateRentalBulkRentableResponse result = apiInstance.CreateRentalBulkRentable(createRentalBulkRentableRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateRentalBulkRentable: " + e.Message );
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
 **createRentalBulkRentableRequest** | **CreateRentalBulkRentableRequest**|  | 

### Return type

**CreateRentalBulkRentableResponse**

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

<a name="createshoplimitrequest"></a>
# **CreateShopLimitRequest**
> CreateShopLimitRequestResponse CreateShopLimitRequest (CreateShopLimitRequestRequest createShopLimitRequestRequest)

Ask for a higher Crossly Shop selling limit.

One pending request at a time (409 otherwise). Approved on the spot when your last 90 days are clean (no auto-cancelled orders, disputes lost or chargebacks lost) and every number asked is at most twice your current limit; otherwise Crossly staff review it. `valueCents` is US cents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateShopLimitRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createShopLimitRequestRequest = new CreateShopLimitRequestRequest(); // CreateShopLimitRequestRequest | 

            try
            {
                // Ask for a higher Crossly Shop selling limit.
                CreateShopLimitRequestResponse result = apiInstance.CreateShopLimitRequest(createShopLimitRequestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateShopLimitRequest: " + e.Message );
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
 **createShopLimitRequestRequest** | **CreateShopLimitRequestRequest**|  | 

### Return type

**CreateShopLimitRequestResponse**

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

<a name="createstory"></a>
# **CreateStory**
> CreateStoryResponse CreateStory (CreateStoryRequest createStoryRequest)

Share a story: 1–10 slides played in order. Each slide is a photo or video plus optional overlays (positions are fractions of the 9:16 frame). Listing stickers must be your own Crossly listings and also tag the slide; @mentions must be real shops. audience: everyone | followers; expiresInHours: 6, 12, 24 or 48.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createStoryRequest = new CreateStoryRequest(); // CreateStoryRequest | 

            try
            {
                // Share a story: 1–10 slides played in order. Each slide is a photo or video plus optional overlays (positions are fractions of the 9:16 frame). Listing stickers must be your own Crossly listings and also tag the slide; @mentions must be real shops. audience: everyone | followers; expiresInHours: 6, 12, 24 or 48.
                CreateStoryResponse result = apiInstance.CreateStory(createStoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateStory: " + e.Message );
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
 **createStoryRequest** | **CreateStoryRequest**|  | 

### Return type

**CreateStoryResponse**

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

<a name="createvariationgroup"></a>
# **CreateVariationGroup**
> CreateVariationGroupResponse CreateVariationGroup (CreateVariationGroupRequest createVariationGroupRequest)

Group listings you already have: a variation (one product, an axis such as Size) or a purchase-rule group (\"buy any 3\").

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVariationGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createVariationGroupRequest = new CreateVariationGroupRequest(); // CreateVariationGroupRequest | 

            try
            {
                // Group listings you already have: a variation (one product, an axis such as Size) or a purchase-rule group (\"buy any 3\").
                CreateVariationGroupResponse result = apiInstance.CreateVariationGroup(createVariationGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVariationGroup: " + e.Message );
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
 **createVariationGroupRequest** | **CreateVariationGroupRequest**|  | 

### Return type

**CreateVariationGroupResponse**

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

<a name="createvariationgroupgenerate"></a>
# **CreateVariationGroupGenerate**
> CreateVariationGroupGenerateResponse CreateVariationGroupGenerate (CreateVariationGroupGenerateRequest createVariationGroupGenerateRequest)

Turn one listing into a variation group: each new value becomes its own listing (a copy, with its own price, quantity and SKU) and all of them one group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVariationGroupGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createVariationGroupGenerateRequest = new CreateVariationGroupGenerateRequest(); // CreateVariationGroupGenerateRequest | 

            try
            {
                // Turn one listing into a variation group: each new value becomes its own listing (a copy, with its own price, quantity and SKU) and all of them one group.
                CreateVariationGroupGenerateResponse result = apiInstance.CreateVariationGroupGenerate(createVariationGroupGenerateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVariationGroupGenerate: " + e.Message );
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
 **createVariationGroupGenerateRequest** | **CreateVariationGroupGenerateRequest**|  | 

### Return type

**CreateVariationGroupGenerateResponse**

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

<a name="createvariationgroupgeneratematrix"></a>
# **CreateVariationGroupGenerateMatrix**
> CreateVariationGroupGenerateMatrixResponse CreateVariationGroupGenerateMatrix (CreateVariationGroupGenerateMatrixRequest createVariationGroupGenerateMatrixRequest)

Turn one listing into a variation group over up to three axes (Size × Color): each other cell is a listing you already have (listingId) or a new copy of this one with its own price, quantity and SKU.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVariationGroupGenerateMatrixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createVariationGroupGenerateMatrixRequest = new CreateVariationGroupGenerateMatrixRequest(); // CreateVariationGroupGenerateMatrixRequest | 

            try
            {
                // Turn one listing into a variation group over up to three axes (Size × Color): each other cell is a listing you already have (listingId) or a new copy of this one with its own price, quantity and SKU.
                CreateVariationGroupGenerateMatrixResponse result = apiInstance.CreateVariationGroupGenerateMatrix(createVariationGroupGenerateMatrixRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVariationGroupGenerateMatrix: " + e.Message );
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
 **createVariationGroupGenerateMatrixRequest** | **CreateVariationGroupGenerateMatrixRequest**|  | 

### Return type

**CreateVariationGroupGenerateMatrixResponse**

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

<a name="createvariationgrouppublish"></a>
# **CreateVariationGroupPublish**
> CreateVariationGroupPublishResponse CreateVariationGroupPublish (string id, CreateVariationGroupPublishRequest createVariationGroupPublishRequest)

Publish a variation group per platform: one listing with a variation picker where the platform supports it (eBay, Shopify, Etsy), one per option elsewhere. Each platform reports its own outcome.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVariationGroupPublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var createVariationGroupPublishRequest = new CreateVariationGroupPublishRequest(); // CreateVariationGroupPublishRequest | 

            try
            {
                // Publish a variation group per platform: one listing with a variation picker where the platform supports it (eBay, Shopify, Etsy), one per option elsewhere. Each platform reports its own outcome.
                CreateVariationGroupPublishResponse result = apiInstance.CreateVariationGroupPublish(id, createVariationGroupPublishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVariationGroupPublish: " + e.Message );
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
 **createVariationGroupPublishRequest** | **CreateVariationGroupPublishRequest**|  | 

### Return type

**CreateVariationGroupPublishResponse**

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

<a name="createvideostudiofinalize"></a>
# **CreateVideoStudioFinalize**
> CreateVideoStudioFinalizeResponse CreateVideoStudioFinalize (CreateVideoStudioFinalizeRequest createVideoStudioFinalizeRequest = null)

Check an uploaded listing video (exists, MP4, size) and, with listingId, set it as that listing's video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVideoStudioFinalizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var createVideoStudioFinalizeRequest = new CreateVideoStudioFinalizeRequest(); // CreateVideoStudioFinalizeRequest |  (optional) 

            try
            {
                // Check an uploaded listing video (exists, MP4, size) and, with listingId, set it as that listing's video.
                CreateVideoStudioFinalizeResponse result = apiInstance.CreateVideoStudioFinalize(createVideoStudioFinalizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVideoStudioFinalize: " + e.Message );
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
 **createVideoStudioFinalizeRequest** | **CreateVideoStudioFinalizeRequest**|  | [optional] 

### Return type

**CreateVideoStudioFinalizeResponse**

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

<a name="createvideostudiouploadurl"></a>
# **CreateVideoStudioUploadUrl**
> CreateVideoStudioUploadUrlResponse CreateVideoStudioUploadUrl ()

Presign an R2 PUT (video/mp4, 15 min) for a listing video; finalize it after the upload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVideoStudioUploadUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Presign an R2 PUT (video/mp4, 15 min) for a listing video; finalize it after the upload.
                CreateVideoStudioUploadUrlResponse result = apiInstance.CreateVideoStudioUploadUrl();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.CreateVideoStudioUploadUrl: " + e.Message );
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

**CreateVideoStudioUploadUrlResponse**

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

<a name="deleteevent"></a>
# **DeleteEvent**
> DeleteEventResponse DeleteEvent (string id)

Delete a draft, or cancel a published event (its page then says it was called off).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a draft, or cancel a published event (its page then says it was called off).
                DeleteEventResponse result = apiInstance.DeleteEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteEvent: " + e.Message );
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

**DeleteEventResponse**

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

<a name="deletelisting"></a>
# **DeleteListing**
> DeleteListingResponse DeleteListing (Guid id, string platforms = null, string platformListingIds = null)

Delist a listing (optionally narrowed to specific platforms via ?platforms=).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var platforms = "platforms_example";  // string | Comma-separated platform slugs to limit the delist fan-out. (optional) 
            var platformListingIds = "platformListingIds_example";  // string | Comma-separated platform listing ids — end only those copies (e.g. one eBay site's copy). (optional) 

            try
            {
                // Delist a listing (optionally narrowed to specific platforms via ?platforms=).
                DeleteListingResponse result = apiInstance.DeleteListing(id, platforms, platformListingIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteListing: " + e.Message );
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
 **platforms** | **string**| Comma-separated platform slugs to limit the delist fan-out. | [optional] 
 **platformListingIds** | **string**| Comma-separated platform listing ids — end only those copies (e.g. one eBay site&#39;s copy). | [optional] 

### Return type

**DeleteListingResponse**

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

<a name="deletelistingtag"></a>
# **DeleteListingTag**
> UpdatedResponse DeleteListingTag (string tag)

Remove a tag (any case) from every listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteListingTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var tag = "tag_example";  // string | 

            try
            {
                // Remove a tag (any case) from every listing.
                UpdatedResponse result = apiInstance.DeleteListingTag(tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteListingTag: " + e.Message );
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
 **tag** | **string**|  | 

### Return type

**UpdatedResponse**

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

<a name="deletelivestreampinlaunch"></a>
# **DeleteLiveStreamPinLaunch**
> OkResponse DeleteLiveStreamPinLaunch (string id)

Unpin the launch from your live show. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteLiveStreamPinLaunchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Unpin the launch from your live show. Returns `{ ok }`.
                OkResponse result = apiInstance.DeleteLiveStreamPinLaunch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteLiveStreamPinLaunch: " + e.Message );
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

<a name="deleterentaloffer"></a>
# **DeleteRentalOffer**
> UpdateGroupBuyResponse DeleteRentalOffer (string platformListingId)

Stop offering a listing for rent (existing bookings stand).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteRentalOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var platformListingId = "platformListingId_example";  // string | 

            try
            {
                // Stop offering a listing for rent (existing bookings stand).
                UpdateGroupBuyResponse result = apiInstance.DeleteRentalOffer(platformListingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteRentalOffer: " + e.Message );
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
 **platformListingId** | **string**|  | 

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

<a name="deletestory"></a>
# **DeleteStory**
> DeleteStoryResponse DeleteStory (string id)

Take one story slide down before it expires.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteStoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take one story slide down before it expires.
                DeleteStoryResponse result = apiInstance.DeleteStory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteStory: " + e.Message );
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

<a name="deletevariationgroup"></a>
# **DeleteVariationGroup**
> UpdateGroupBuyResponse DeleteVariationGroup (string id)

Dissolve a group. Its options stay as ordinary listings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteVariationGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Dissolve a group. Its options stay as ordinary listings.
                UpdateGroupBuyResponse result = apiInstance.DeleteVariationGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.DeleteVariationGroup: " + e.Message );
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

<a name="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string id)

One of your events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One of your events.
                EventResponse result = apiInstance.GetEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetEvent: " + e.Message );
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

**EventResponse**

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

<a name="geteventanalytic"></a>
# **GetEventAnalytic**
> GetEventAnalyticResponse GetEventAnalytic (string id)

Views, RSVPs, and what the linked listings sold on Crossly during the event (orders, units, revenue in cents).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetEventAnalyticExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Views, RSVPs, and what the linked listings sold on Crossly during the event (orders, units, revenue in cents).
                GetEventAnalyticResponse result = apiInstance.GetEventAnalytic(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetEventAnalytic: " + e.Message );
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

**GetEventAnalyticResponse**

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

<a name="getlisting"></a>
# **GetListing**
> GetListingResponse GetListing (Guid id)

Get one listing with its platform rows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one listing with its platform rows.
                GetListingResponse result = apiInstance.GetListing(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetListing: " + e.Message );
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

**GetListingResponse**

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

<a name="getlistingfacet"></a>
# **GetListingFacet**
> GetListingFacetResponse GetListingFacet ()

Distinct brands + categories across listings + inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetListingFacetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Distinct brands + categories across listings + inventory.
                GetListingFacetResponse result = apiInstance.GetListingFacet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetListingFacet: " + e.Message );
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

**GetListingFacetResponse**

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

<a name="getlistingskuexist"></a>
# **GetListingSkuExist**
> GetListingSkuExistResponse GetListingSkuExist (string sku)

Check whether a SKU is already used by one of this user's items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetListingSkuExistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var sku = "sku_example";  // string | 

            try
            {
                // Check whether a SKU is already used by one of this user's items.
                GetListingSkuExistResponse result = apiInstance.GetListingSkuExist(sku);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetListingSkuExist: " + e.Message );
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
 **sku** | **string**|  | 

### Return type

**GetListingSkuExistResponse**

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

<a name="getlivestreamrecap"></a>
# **GetLiveStreamRecap**
> GetLiveStreamRecapResponse GetLiveStreamRecap (string id)

The show’s numbers: duration, peak viewers, items sold and gross, tips, chat messages, auctions run, lineup size and the replay URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLiveStreamRecapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The show’s numbers: duration, peak viewers, items sold and gross, tips, chat messages, auctions run, lineup size and the replay URL.
                GetLiveStreamRecapResponse result = apiInstance.GetLiveStreamRecap(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetLiveStreamRecap: " + e.Message );
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

**GetLiveStreamRecapResponse**

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

<a name="getpassport"></a>
# **GetPassport**
> GetPassportResponse GetPassport (string id)

One passport: its item and every listing of it, the event history (created, printed, tag bound, transferred, claimed…), scans per day for 30 days, custody, grading.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPassportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One passport: its item and every listing of it, the event history (created, printed, tag bound, transferred, claimed…), scans per day for 30 days, custody, grading.
                GetPassportResponse result = apiInstance.GetPassport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetPassport: " + e.Message );
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

**GetPassportResponse**

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

<a name="getpassportdraft"></a>
# **GetPassportDraft**
> PassportDraftResponse GetPassportDraft (string id)

A passport draft and its passports (photos, serial, tag and label state of each).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPassportDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A passport draft and its passports (photos, serial, tag and label state of each).
                PassportDraftResponse result = apiInstance.GetPassportDraft(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetPassportDraft: " + e.Message );
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

**PassportDraftResponse**

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

<a name="getpassportprint"></a>
# **GetPassportPrint**
> GetPassportPrintResponse GetPassportPrint (string jobId)

Where a passport print job sent to your agent is: queued, sent, done, failed, expired or duplicate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPassportPrintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var jobId = "jobId_example";  // string | 

            try
            {
                // Where a passport print job sent to your agent is: queued, sent, done, failed, expired or duplicate.
                GetPassportPrintResponse result = apiInstance.GetPassportPrint(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetPassportPrint: " + e.Message );
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
 **jobId** | **string**|  | 

### Return type

**GetPassportPrintResponse**

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

<a name="getpricingsetting"></a>
# **GetPricingSetting**
> GetPricingSettingResponse GetPricingSetting ()

Selling options: own-price match (Crossly sells your items at your own lower price for the same item on another marketplace; dollar-priced copies only) and layaway (buyers may put items on layaway). Both on by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPricingSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Selling options: own-price match (Crossly sells your items at your own lower price for the same item on another marketplace; dollar-priced copies only) and layaway (buyers may put items on layaway). Both on by default.
                GetPricingSettingResponse result = apiInstance.GetPricingSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetPricingSetting: " + e.Message );
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

**GetPricingSettingResponse**

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

<a name="getpricingsoldcomp"></a>
# **GetPricingSoldComp**
> GetPricingSoldCompResponse GetPricingSoldComp (string marketSkuId = null, string condition = null, string listingId = null)

What one catalog product (market_sku_id, in one condition) actually sold for across Crossly in the last 180 days: median, p25/p75, p10/p90 (null under 10 sales), sale count, last sold, and days from listing to sale (median, p25, p75). Pass marketSkuId (+ optional condition) or one of your listingIds. comps is null until there are 3+ sales from 2+ sellers; holdCode says why there is nothing (no_market_sku, mixed_inventory, below_privacy_floor) — the same reasons a sold_median reprice rule holds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPricingSoldCompExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var marketSkuId = "marketSkuId_example";  // string |  (optional) 
            var condition = "condition_example";  // string |  (optional) 
            var listingId = "listingId_example";  // string |  (optional) 

            try
            {
                // What one catalog product (market_sku_id, in one condition) actually sold for across Crossly in the last 180 days: median, p25/p75, p10/p90 (null under 10 sales), sale count, last sold, and days from listing to sale (median, p25, p75). Pass marketSkuId (+ optional condition) or one of your listingIds. comps is null until there are 3+ sales from 2+ sellers; holdCode says why there is nothing (no_market_sku, mixed_inventory, below_privacy_floor) — the same reasons a sold_median reprice rule holds.
                GetPricingSoldCompResponse result = apiInstance.GetPricingSoldComp(marketSkuId, condition, listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetPricingSoldComp: " + e.Message );
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
 **marketSkuId** | **string**|  | [optional] 
 **condition** | **string**|  | [optional] 
 **listingId** | **string**|  | [optional] 

### Return type

**GetPricingSoldCompResponse**

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

<a name="getrentalpolicy"></a>
# **GetRentalPolicy**
> GetRentalPolicyResponse GetRentalPolicy (string listingId = null)

The return and payment policies a rental inherits from Settings › Policies, resolved for the store (or for one listing with ?listingId): preset ids and names, the level each came from, the return line, protections, arrival photos, the deposit claim window in days, a required deposit in basis points, accepted methods, and editPath.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetRentalPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var listingId = "listingId_example";  // string |  (optional) 

            try
            {
                // The return and payment policies a rental inherits from Settings › Policies, resolved for the store (or for one listing with ?listingId): preset ids and names, the level each came from, the return line, protections, arrival photos, the deposit claim window in days, a required deposit in basis points, accepted methods, and editPath.
                GetRentalPolicyResponse result = apiInstance.GetRentalPolicy(listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetRentalPolicy: " + e.Message );
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
 **listingId** | **string**|  | [optional] 

### Return type

**GetRentalPolicyResponse**

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

<a name="getrentalsetting"></a>
# **GetRentalSetting**
> GetRentalSettingResponse GetRentalSetting ()

The store’s rental defaults (every item inherits them) and its payout timing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetRentalSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // The store’s rental defaults (every item inherits them) and its payout timing.
                GetRentalSettingResponse result = apiInstance.GetRentalSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetRentalSetting: " + e.Message );
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

**GetRentalSettingResponse**

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

<a name="getshoplimit"></a>
# **GetShopLimit**
> GetShopLimitResponse GetShopLimit ()

Your Crossly Shop selling limit: live listings and listed value, used of limit, per store, and the next step.

Per seller account, shared by all your stores. Counts live + scheduled Crossly Shop listings once each; value is the US-dollar shop price x quantity (an auction at max(start, reserve, buy-now)). Drafts, sold/ended listings and Trade Block posts are not counted, and selling frees space at once. `unlimited` is true for sandbox sellers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetShopLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Your Crossly Shop selling limit: live listings and listed value, used of limit, per store, and the next step.
                GetShopLimitResponse result = apiInstance.GetShopLimit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetShopLimit: " + e.Message );
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

**GetShopLimitResponse**

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

<a name="getstockxcatalog"></a>
# **GetStockxCatalog**
> GetStockxCatalogResponse GetStockxCatalog (string q, int? page = null, int? pageSize = null)

Search the StockX catalog (style code, SKU or words) to pick the product a StockX ask is on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStockxCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var q = "q_example";  // string | 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Search the StockX catalog (style code, SKU or words) to pick the product a StockX ask is on.
                GetStockxCatalogResponse result = apiInstance.GetStockxCatalog(q, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetStockxCatalog: " + e.Message );
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
 **q** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

**GetStockxCatalogResponse**

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

<a name="getstockxcatalogvariantmarketdata"></a>
# **GetStockxCatalogVariantMarketData**
> GetStockxCatalogVariantMarketDataResponse GetStockxCatalogVariantMarketData (string productId, string variantId, string currency = null)

Lowest ask, highest bid and suggested prices for one StockX size.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStockxCatalogVariantMarketDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var productId = "productId_example";  // string | 
            var variantId = "variantId_example";  // string | 
            var currency = "currency_example";  // string |  (optional) 

            try
            {
                // Lowest ask, highest bid and suggested prices for one StockX size.
                GetStockxCatalogVariantMarketDataResponse result = apiInstance.GetStockxCatalogVariantMarketData(productId, variantId, currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.GetStockxCatalogVariantMarketData: " + e.Message );
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
 **productId** | **string**|  | 
 **variantId** | **string**|  | 
 **currency** | **string**|  | [optional] 

### Return type

**GetStockxCatalogVariantMarketDataResponse**

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

<a name="listeventattendees"></a>
# **ListEventAttendees**
> ListEventAttendeesResponse ListEventAttendees (string id)

Who RSVPd: display name, avatar, going or interested, and when. No contact details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListEventAttendeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Who RSVPd: display name, avatar, going or interested, and when. No contact details.
                ListEventAttendeesResponse result = apiInstance.ListEventAttendees(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListEventAttendees: " + e.Message );
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

**ListEventAttendeesResponse**

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

<a name="listevents"></a>
# **ListEvents**
> ListEventsResponse ListEvents ()

Your events (launches, sales, live shows, drops, meetups, pop-ups, workshops, parties): schedule, status, phase, and going/interested counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Your events (launches, sales, live shows, drops, meetups, pop-ups, workshops, parties): schedule, status, phase, and going/interested counts.
                ListEventsResponse result = apiInstance.ListEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListEvents: " + e.Message );
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

**ListEventsResponse**

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

<a name="listlistingaidetections"></a>
# **ListListingAiDetections**
> ListListingAiDetectionsResponse ListListingAiDetections (string id)

Crossly's AI-image detections for a listing's photos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingAiDetectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Crossly's AI-image detections for a listing's photos.
                ListListingAiDetectionsResponse result = apiInstance.ListListingAiDetections(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListingAiDetections: " + e.Message );
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

**ListListingAiDetectionsResponse**

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

<a name="listlistingdiscrepancies"></a>
# **ListListingDiscrepancies**
> ListListingDiscrepanciesResponse ListListingDiscrepancies (Guid id)

List detected marketplace-drift discrepancies for a listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingDiscrepanciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // List detected marketplace-drift discrepancies for a listing.
                ListListingDiscrepanciesResponse result = apiInstance.ListListingDiscrepancies(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListingDiscrepancies: " + e.Message );
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

**ListListingDiscrepanciesResponse**

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

<a name="listlistingids"></a>
# **ListListingIds**
> ListListingIdsResponse ListListingIds ()

Filter listings → return matching id list (no pagination).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Filter listings → return matching id list (no pagination).
                ListListingIdsResponse result = apiInstance.ListListingIds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListingIds: " + e.Message );
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

**ListListingIdsResponse**

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

<a name="listlistingtagsuggest"></a>
# **ListListingTagSuggest**
> ListListingTagSuggestResponse ListListingTagSuggest (Guid listingId)

Deterministic tag suggestions for one listing (brand, category, size, condition, colors, style tags, era words in the title); `known` = you already use the tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingTagSuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var listingId = "listingId_example";  // Guid | 

            try
            {
                // Deterministic tag suggestions for one listing (brand, category, size, condition, colors, style tags, era words in the title); `known` = you already use the tag.
                ListListingTagSuggestResponse result = apiInstance.ListListingTagSuggest(listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListingTagSuggest: " + e.Message );
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
 **listingId** | **Guid**|  | 

### Return type

**ListListingTagSuggestResponse**

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

<a name="listlistingtags"></a>
# **ListListingTags**
> ListListingTagsResponse ListListingTags (string q = null, int? limit = null)

Your listing tags with how many listings carry each, most used first (case-insensitive; `q` filters).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var q = "q_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Your listing tags with how many listings carry each, most used first (case-insensitive; `q` filters).
                ListListingTagsResponse result = apiInstance.ListListingTags(q, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListingTags: " + e.Message );
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
 **limit** | **int?**|  | [optional] 

### Return type

**ListListingTagsResponse**

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

<a name="listlistings"></a>
# **ListListings**
> ListListingsResponse ListListings (int? page = null, int? limit = null, string platform = null, string status = null, string sku = null, DateTime? updatedSince = null, string kind = null, List<string> tag = null, bool? stillLive = null, string assignee = null)

List active platform listings.

Each row carries `pricing`: `avgAsking` (average price across its active marketplace rows, per-platform overrides and price rules applied) and `avgSale` (average price per unit sold, refunds netted), each `{ amount, currency, count }` or null. Never averaged across currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var page = 1;  // int? |  (optional)  (default to 1)
            var limit = 25;  // int? |  (optional)  (default to 25)
            var platform = "platform_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var sku = "sku_example";  // string | Exact SKU match: look up the row a supplier product maps to. (optional) 
            var updatedSince = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only rows created or changed at or after this time (ISO 8601), oldest change first. Poll with the updatedAt of the last row you saw. (optional) 
            var kind = "physical";  // string | Physical goods or Web3 assets (NFT listings). Omit for both. (optional) 
            var tag = new List<string>(); // List<string> | Only listings carrying ANY of these tags (case-insensitive): repeat `tag` or comma-separate. (optional) 
            var stillLive = true;  // bool? | Only listings still active on at least one marketplace. With status=sold: sold items still buyable somewhere (a delist failed, is pending or never ran). (optional) 
            var assignee = "assignee_example";  // string | Work assignment: 'me' (your own seat), 'none' (unassigned), 'any' (assigned to someone) or a team member id. (optional) 

            try
            {
                // List active platform listings.
                ListListingsResponse result = apiInstance.ListListings(page, limit, platform, status, sku, updatedSince, kind, tag, stillLive, assignee);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListListings: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **limit** | **int?**|  | [optional] [default to 25]
 **platform** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **sku** | **string**| Exact SKU match: look up the row a supplier product maps to. | [optional] 
 **updatedSince** | **DateTime?**| Only rows created or changed at or after this time (ISO 8601), oldest change first. Poll with the updatedAt of the last row you saw. | [optional] 
 **kind** | **string**| Physical goods or Web3 assets (NFT listings). Omit for both. | [optional] 
 **tag** | **List&lt;string&gt;**| Only listings carrying ANY of these tags (case-insensitive): repeat &#x60;tag&#x60; or comma-separate. | [optional] 
 **stillLive** | **bool?**| Only listings still active on at least one marketplace. With status&#x3D;sold: sold items still buyable somewhere (a delist failed, is pending or never ran). | [optional] 
 **assignee** | **string**| Work assignment: &#39;me&#39; (your own seat), &#39;none&#39; (unassigned), &#39;any&#39; (assigned to someone) or a team member id. | [optional] 

### Return type

**ListListingsResponse**

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

<a name="listlivestreams"></a>
# **ListLiveStreams**
> ListLiveStreamsResponse ListLiveStreams ()

Your live shows, newest scheduled first: status, cover, category, connection method and peak viewers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLiveStreamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Your live shows, newest scheduled first: status, cover, category, connection method and peak viewers.
                ListLiveStreamsResponse result = apiInstance.ListLiveStreams();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListLiveStreams: " + e.Message );
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

**ListLiveStreamsResponse**

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

<a name="listpassportevents"></a>
# **ListPassportEvents**
> ListPassportEventsResponse ListPassportEvents (string id)

A passport’s event history, newest first (never a buyer or a price).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPassportEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A passport’s event history, newest first (never a buyer or a price).
                ListPassportEventsResponse result = apiInstance.ListPassportEvents(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListPassportEvents: " + e.Message );
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

**ListPassportEventsResponse**

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

<a name="listpassportprinttargets"></a>
# **ListPassportPrintTargets**
> ListPassportPrintTargetsResponse ListPassportPrintTargets ()

Your printer agents (online, printers, default) and the passport label templates each can print.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPassportPrintTargetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Your printer agents (online, printers, default) and the passport label templates each can print.
                ListPassportPrintTargetsResponse result = apiInstance.ListPassportPrintTargets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListPassportPrintTargets: " + e.Message );
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

**ListPassportPrintTargetsResponse**

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

<a name="listpassports"></a>
# **ListPassports**
> ListPassportsResponse ListPassports (string q = null, string status = null, string custody = null, string tag = null, string printed = null, string itemId = null, string platformListingId = null, string cursor = null, decimal? limit = null)

Product passports you registered (optionally for one Crossly listing): the code and URL each tag carries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPassportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var q = "q_example";  // string |  (optional) 
            var status = "active";  // string |  (optional) 
            var custody = "in_vault";  // string |  (optional) 
            var tag = "none";  // string |  (optional) 
            var printed = "no";  // string |  (optional) 
            var itemId = "itemId_example";  // string |  (optional) 
            var platformListingId = "platformListingId_example";  // string |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Product passports you registered (optionally for one Crossly listing): the code and URL each tag carries.
                ListPassportsResponse result = apiInstance.ListPassports(q, status, custody, tag, printed, itemId, platformListingId, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListPassports: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **custody** | **string**|  | [optional] 
 **tag** | **string**|  | [optional] 
 **printed** | **string**|  | [optional] 
 **itemId** | **string**|  | [optional] 
 **platformListingId** | **string**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListPassportsResponse**

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

<a name="listrentaloffers"></a>
# **ListRentalOffers**
> ListRentalOffersResponse ListRentalOffers ()

What you offer for rent. Each offer carries `policy`: the return and payment policies it inherits from Settings › Policies, resolved (preset ids and names, the level they came from, protections, claim window, deposit, accepted methods, and editPath), with `returnPolicyOverride` when the offer writes its own return text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListRentalOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // What you offer for rent. Each offer carries `policy`: the return and payment policies it inherits from Settings › Policies, resolved (preset ids and names, the level they came from, protections, claim window, deposit, accepted methods, and editPath), with `returnPolicyOverride` when the offer writes its own return text.
                ListRentalOffersResponse result = apiInstance.ListRentalOffers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListRentalOffers: " + e.Message );
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

**ListRentalOffersResponse**

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

<a name="liststockxcatalogvariants"></a>
# **ListStockxCatalogVariants**
> ListStockxCatalogVariantsResponse ListStockxCatalogVariants (string productId)

List the sizes (variants) of a StockX catalog product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStockxCatalogVariantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var productId = "productId_example";  // string | 

            try
            {
                // List the sizes (variants) of a StockX catalog product.
                ListStockxCatalogVariantsResponse result = apiInstance.ListStockxCatalogVariants(productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListStockxCatalogVariants: " + e.Message );
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
 **productId** | **string**|  | 

### Return type

**ListStockxCatalogVariantsResponse**

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

<a name="liststories"></a>
# **ListStories**
> ListStoriesResponse ListStories ()

Your active story slides (newest run first, each run in play order), with their overlays: text, listing stickers, @mentions, links, emoji and drawing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Your active story slides (newest run first, each run in play order), with their overlays: text, listing stickers, @mentions, links, emoji and drawing.
                ListStoriesResponse result = apiInstance.ListStories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListStories: " + e.Message );
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

**ListStoriesResponse**

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

<a name="updateevent"></a>
# **UpdateEvent**
> EventResponse UpdateEvent (string id, UpdateEventRequest updateEventRequest)

Edit an event. Omitted fields are unchanged; null clears.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updateEventRequest = new UpdateEventRequest(); // UpdateEventRequest | 

            try
            {
                // Edit an event. Omitted fields are unchanged; null clears.
                EventResponse result = apiInstance.UpdateEvent(id, updateEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateEvent: " + e.Message );
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
 **updateEventRequest** | **UpdateEventRequest**|  | 

### Return type

**EventResponse**

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

<a name="updatehotspot"></a>
# **UpdateHotspot**
> UpdateHotspotResponse UpdateHotspot (UpdateHotspotRequest updateHotspotRequest)

Tag your listings at points on a story or lookbook photo (shop the look). Replaces that photo’s tags; at most 12.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateHotspotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var updateHotspotRequest = new UpdateHotspotRequest(); // UpdateHotspotRequest | 

            try
            {
                // Tag your listings at points on a story or lookbook photo (shop the look). Replaces that photo’s tags; at most 12.
                UpdateHotspotResponse result = apiInstance.UpdateHotspot(updateHotspotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateHotspot: " + e.Message );
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
 **updateHotspotRequest** | **UpdateHotspotRequest**|  | 

### Return type

**UpdateHotspotResponse**

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

<a name="updatelisting"></a>
# **UpdateListing**
> UpdateListingResponse UpdateListing (Guid id)

Edit a listing and fan out update jobs to existing platform listings.

The fields to change go in `changes` (a sparse object, e.g. `{ \"changes\": { \"price\": 24.99 } }`). `data` is accepted as an alias of `changes` (the name create and bulk create use); sending both is a 400. Omit `platforms` to push the edit everywhere the listing is live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Edit a listing and fan out update jobs to existing platform listings.
                UpdateListingResponse result = apiInstance.UpdateListing(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateListing: " + e.Message );
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

**UpdateListingResponse**

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

<a name="updatelistingassignee"></a>
# **UpdateListingAssignee**
> UpdateOrderAssigneeResponse UpdateListingAssignee ()

Assign many listings to a teammate, round robin across several, or unassign them (null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingAssigneeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);

            try
            {
                // Assign many listings to a teammate, round robin across several, or unassign them (null).
                UpdateOrderAssigneeResponse result = apiInstance.UpdateListingAssignee();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateListingAssignee: " + e.Message );
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

**UpdateOrderAssigneeResponse**

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

<a name="updatelistingassigneebyid"></a>
# **UpdateListingAssigneeById**
> UpdateOrderAssigneeByIdResponse UpdateListingAssigneeById (string id)

Assign one listing to a teammate, or unassign it (null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingAssigneeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Assign one listing to a teammate, or unassign it (null).
                UpdateOrderAssigneeByIdResponse result = apiInstance.UpdateListingAssigneeById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateListingAssigneeById: " + e.Message );
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

**UpdateOrderAssigneeByIdResponse**

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

<a name="updatelistingcustom"></a>
# **UpdateListingCustom**
> UpdateListingCustomResponse UpdateListingCustom (Guid id, UpdateListingCustomRequest updateListingCustomRequest)

Set a listing’s customs: HS code (6–10 digits), country of origin, and countries this item must not ship to on Crossly. Omitted fields are left alone; null (or [] for restrictedCountries) clears.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingCustomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var updateListingCustomRequest = new UpdateListingCustomRequest(); // UpdateListingCustomRequest | 

            try
            {
                // Set a listing’s customs: HS code (6–10 digits), country of origin, and countries this item must not ship to on Crossly. Omitted fields are left alone; null (or [] for restrictedCountries) clears.
                UpdateListingCustomResponse result = apiInstance.UpdateListingCustom(id, updateListingCustomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateListingCustom: " + e.Message );
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
 **updateListingCustomRequest** | **UpdateListingCustomRequest**|  | 

### Return type

**UpdateListingCustomResponse**

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

<a name="updatelistingplatformlisting"></a>
# **UpdateListingPlatformListing**
> UpdateListingPlatformListingResponse UpdateListingPlatformListing (Guid id, Guid plId, UpdateListingPlatformListingRequest updateListingPlatformListingRequest)

Set one marketplace copy's price (e.g. the ebay.com copy of a listing also live on ebay.co.uk), in that copy's own currency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateListingPlatformListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // Guid | 
            var plId = "plId_example";  // Guid | 
            var updateListingPlatformListingRequest = new UpdateListingPlatformListingRequest(); // UpdateListingPlatformListingRequest | 

            try
            {
                // Set one marketplace copy's price (e.g. the ebay.com copy of a listing also live on ebay.co.uk), in that copy's own currency.
                UpdateListingPlatformListingResponse result = apiInstance.UpdateListingPlatformListing(id, plId, updateListingPlatformListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateListingPlatformListing: " + e.Message );
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
 **plId** | **Guid**|  | 
 **updateListingPlatformListingRequest** | **UpdateListingPlatformListingRequest**|  | 

### Return type

**UpdateListingPlatformListingResponse**

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

<a name="updatelivestream"></a>
# **UpdateLiveStream**
> LiveStreamResponse UpdateLiveStream (string id, UpdateLiveStreamRequest updateLiveStreamRequest = null)

Edit a show that has not ended: title, description, cover, category, start time (not once live) or connection method (browser | phone | encoder).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updateLiveStreamRequest = new UpdateLiveStreamRequest(); // UpdateLiveStreamRequest |  (optional) 

            try
            {
                // Edit a show that has not ended: title, description, cover, category, start time (not once live) or connection method (browser | phone | encoder).
                LiveStreamResponse result = apiInstance.UpdateLiveStream(id, updateLiveStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateLiveStream: " + e.Message );
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
 **updateLiveStreamRequest** | **UpdateLiveStreamRequest**|  | [optional] 

### Return type

**LiveStreamResponse**

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

<a name="updatelivestreamlineup"></a>
# **UpdateLiveStreamLineup**
> UpdateLiveStreamLineupResponse UpdateLiveStreamLineup (string id, UpdateLiveStreamLineupRequest updateLiveStreamLineupRequest)

Set a live show’s lineup: your Crossly listings, in the order you will sell them. Buyers see it before they join; a sale of a lineup item while the show is live is recorded at its replay moment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLiveStreamLineupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updateLiveStreamLineupRequest = new UpdateLiveStreamLineupRequest(); // UpdateLiveStreamLineupRequest | 

            try
            {
                // Set a live show’s lineup: your Crossly listings, in the order you will sell them. Buyers see it before they join; a sale of a lineup item while the show is live is recorded at its replay moment.
                UpdateLiveStreamLineupResponse result = apiInstance.UpdateLiveStreamLineup(id, updateLiveStreamLineupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateLiveStreamLineup: " + e.Message );
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
 **updateLiveStreamLineupRequest** | **UpdateLiveStreamLineupRequest**|  | 

### Return type

**UpdateLiveStreamLineupResponse**

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

<a name="updatepassport"></a>
# **UpdatePassport**
> UpdatePassportResponse UpdatePassport (string id, UpdatePassportRequest updatePassportRequest = null)

Change what a passport says (title, condition, maker, year, materials, notes) or add photo URLs (photos append: a passport keeps the ones it was registered with).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePassportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updatePassportRequest = new UpdatePassportRequest(); // UpdatePassportRequest |  (optional) 

            try
            {
                // Change what a passport says (title, condition, maker, year, materials, notes) or add photo URLs (photos append: a passport keeps the ones it was registered with).
                UpdatePassportResponse result = apiInstance.UpdatePassport(id, updatePassportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdatePassport: " + e.Message );
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
 **updatePassportRequest** | **UpdatePassportRequest**|  | [optional] 

### Return type

**UpdatePassportResponse**

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

<a name="updatepassportdraft"></a>
# **UpdatePassportDraft**
> PassportDraftResponse UpdatePassportDraft (string id, UpdatePassportDraftRequest updatePassportDraftRequest = null)

Move a draft to a step, pick its label template, add items or remove draft passports.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePassportDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updatePassportDraftRequest = new UpdatePassportDraftRequest(); // UpdatePassportDraftRequest |  (optional) 

            try
            {
                // Move a draft to a step, pick its label template, add items or remove draft passports.
                PassportDraftResponse result = apiInstance.UpdatePassportDraft(id, updatePassportDraftRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdatePassportDraft: " + e.Message );
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
 **updatePassportDraftRequest** | **UpdatePassportDraftRequest**|  | [optional] 

### Return type

**PassportDraftResponse**

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

<a name="updatepricingsetting"></a>
# **UpdatePricingSetting**
> GetPricingSettingResponse UpdatePricingSetting (UpdatePricingSettingRequest updatePricingSettingRequest)

Turn own-price match and/or layaway on or off for every one of your stores. One store: PUT /v1/storefronts/{id}/settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePricingSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var updatePricingSettingRequest = new UpdatePricingSettingRequest(); // UpdatePricingSettingRequest | 

            try
            {
                // Turn own-price match and/or layaway on or off for every one of your stores. One store: PUT /v1/storefronts/{id}/settings.
                GetPricingSettingResponse result = apiInstance.UpdatePricingSetting(updatePricingSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdatePricingSetting: " + e.Message );
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
 **updatePricingSettingRequest** | **UpdatePricingSettingRequest**|  | 

### Return type

**GetPricingSettingResponse**

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

<a name="updaterentaloffer"></a>
# **UpdateRentalOffer**
> UpdateRentalOfferResponse UpdateRentalOffer (string platformListingId, UpdateRentalOfferRequest updateRentalOfferRequest)

Offer a Crossly listing for rent: day rate, optional week rate, deposit, min/max days, turnaround buffer, rent-only (off sale while offered), seller approval, unavailable date ranges (blackoutRanges, inclusive YYYY-MM-DD) and a return policy. Keeps the listing’s own rental terms in step. Needs a ship-from address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateRentalOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var platformListingId = "platformListingId_example";  // string | 
            var updateRentalOfferRequest = new UpdateRentalOfferRequest(); // UpdateRentalOfferRequest | 

            try
            {
                // Offer a Crossly listing for rent: day rate, optional week rate, deposit, min/max days, turnaround buffer, rent-only (off sale while offered), seller approval, unavailable date ranges (blackoutRanges, inclusive YYYY-MM-DD) and a return policy. Keeps the listing’s own rental terms in step. Needs a ship-from address.
                UpdateRentalOfferResponse result = apiInstance.UpdateRentalOffer(platformListingId, updateRentalOfferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateRentalOffer: " + e.Message );
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
 **platformListingId** | **string**|  | 
 **updateRentalOfferRequest** | **UpdateRentalOfferRequest**|  | 

### Return type

**UpdateRentalOfferResponse**

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

<a name="updaterentalsetting"></a>
# **UpdateRentalSetting**
> GetRentalSettingResponse UpdateRentalSetting (UpdateRentalSettingRequest updateRentalSettingRequest = null)

Set the store’s rental defaults and payout timing (on_start needs 3 rentals that came back).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateRentalSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var updateRentalSettingRequest = new UpdateRentalSettingRequest(); // UpdateRentalSettingRequest |  (optional) 

            try
            {
                // Set the store’s rental defaults and payout timing (on_start needs 3 rentals that came back).
                GetRentalSettingResponse result = apiInstance.UpdateRentalSetting(updateRentalSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateRentalSetting: " + e.Message );
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
 **updateRentalSettingRequest** | **UpdateRentalSettingRequest**|  | [optional] 

### Return type

**GetRentalSettingResponse**

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

<a name="updatevariationgroup"></a>
# **UpdateVariationGroup**
> CreateVariationGroupResponse UpdateVariationGroup (string id, UpdateVariationGroupRequest updateVariationGroupRequest = null)

Retitle a group, rename its axis, or change a group's purchase rule (written into every member's description).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateVariationGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListingsApi(config);
            var id = "id_example";  // string | 
            var updateVariationGroupRequest = new UpdateVariationGroupRequest(); // UpdateVariationGroupRequest |  (optional) 

            try
            {
                // Retitle a group, rename its axis, or change a group's purchase rule (written into every member's description).
                CreateVariationGroupResponse result = apiInstance.UpdateVariationGroup(id, updateVariationGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.UpdateVariationGroup: " + e.Message );
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
 **updateVariationGroupRequest** | **UpdateVariationGroupRequest**|  | [optional] 

### Return type

**CreateVariationGroupResponse**

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

