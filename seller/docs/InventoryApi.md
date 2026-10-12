# net.crossly.Api.InventoryApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCatalogMatchConfirm**](InventoryApi.md#createcatalogmatchconfirm) | **POST** /v1/catalog-matches/{id}/confirm | Confirm a catalog-match suggestion: links the item to the catalog product (sets its market_sku_id), so sold comps and market pricing apply to it.
[**CreateCatalogMatchDismiss**](InventoryApi.md#createcatalogmatchdismiss) | **POST** /v1/catalog-matches/{id}/dismiss | Dismiss a catalog-match suggestion. That product is never suggested for this item again.
[**CreateInventory**](InventoryApi.md#createinventory) | **POST** /v1/inventory | Create a new inventory item.
[**CreateInventoryBulkArchive**](InventoryApi.md#createinventorybulkarchive) | **POST** /v1/inventory/bulk-archive | Bulk archive inventory items (soft).
[**CreateInventoryBulkDelete**](InventoryApi.md#createinventorybulkdelete) | **POST** /v1/inventory/bulk-delete | Bulk delete inventory items (delinks listings).
[**CreateInventoryBulkLabel**](InventoryApi.md#createinventorybulklabel) | **POST** /v1/inventory/bulk-labels | Bulk add/remove labels on inventory items.
[**CreateInventoryBulkQuantity**](InventoryApi.md#createinventorybulkquantity) | **POST** /v1/inventory/bulk-quantity | Set / add / subtract stock across many items, syncing live listings.
[**CreateInventoryCatalogMatchRefresh**](InventoryApi.md#createinventorycatalogmatchrefresh) | **POST** /v1/inventory/{id}/catalog-matches/refresh | Run catalog matching for one item now. An identifier (UPC, style code, catalogue number) that resolves to exactly one product links it; otherwise likely products are returned as suggestions to confirm.
[**CreateInventoryCsvExport**](InventoryApi.md#createinventorycsvexport) | **POST** /v1/inventory/csv/export | Export inventory as CSV. Round-trips back through csv/import.
[**CreateInventoryCsvImport**](InventoryApi.md#createinventorycsvimport) | **POST** /v1/inventory/csv/import | Import a CSV. Rows whose sku matches an existing item update it; others are added. Pass dryRun to preview.
[**CreateInventoryLabelRename**](InventoryApi.md#createinventorylabelrename) | **POST** /v1/inventory/labels/rename | Rename a label across every inventory item.
[**CreateInventoryMerge**](InventoryApi.md#createinventorymerge) | **POST** /v1/inventory/merge | Merge inventory items that are the same physical item into one (stock is not summed).
[**CreateInventoryUnitIdentifier**](InventoryApi.md#createinventoryunitidentifier) | **POST** /v1/inventory/{id}/units/identifiers | Record a serial, IMEI, or licence key against an inventory item.
[**CreateInventoryUnitLookup**](InventoryApi.md#createinventoryunitlookup) | **POST** /v1/inventory/units/lookup | Find a unit by identifier.
[**CreateSpatialPropertyDeedLease**](InventoryApi.md#createspatialpropertydeedlease) | **POST** /v1/spatial/property/deeds/{id}/lease | Offer your plot for lease.
[**CreateSpatialPropertyDeedList**](InventoryApi.md#createspatialpropertydeedlist) | **POST** /v1/spatial/property/deeds/{id}/list | List your plot for resale.
[**CreateSpatialPropertyDeedMaintenance**](InventoryApi.md#createspatialpropertydeedmaintenance) | **POST** /v1/spatial/property/deeds/{id}/maintenance | Pay a plot&#39;s maintenance forward.
[**CreateSpatialPropertyLeaseAccept**](InventoryApi.md#createspatialpropertyleaseaccept) | **POST** /v1/spatial/property/leases/{id}/accept | Take a plot on lease.
[**CreateSpatialPropertyLeaseEnd**](InventoryApi.md#createspatialpropertyleaseend) | **POST** /v1/spatial/property/leases/{id}/end | End a lease (owner or tenant).
[**CreateSpatialPropertyLeaseRent**](InventoryApi.md#createspatialpropertyleaserent) | **POST** /v1/spatial/property/leases/{id}/rent | Pay rent forward.
[**CreateSpatialPropertyListingBuy**](InventoryApi.md#createspatialpropertylistingbuy) | **POST** /v1/spatial/property/listings/{id}/buy | Buy a plot on the resale market, in CBX.
[**CreateSpatialPropertyListingCancel**](InventoryApi.md#createspatialpropertylistingcancel) | **POST** /v1/spatial/property/listings/{id}/cancel | Take your plot off the market.
[**CreateSpatialShopStaffPay**](InventoryApi.md#createspatialshopstaffpay) | **POST** /v1/spatial/shop/staff/{grantId}/pay | Pay a staff member&#39;s wage forward.
[**CreateSpatialStreetClaim**](InventoryApi.md#createspatialstreetclaim) | **POST** /v1/spatial/streets/{slug}/claim | Put your shop on a street.
[**CreateSpatialStreetOwnedUpkeep**](InventoryApi.md#createspatialstreetownedupkeep) | **POST** /v1/spatial/streets/owned/{id}/upkeep | Pay a street&#39;s upkeep forward.
[**CreateSpatialStreetPlotBuy**](InventoryApi.md#createspatialstreetplotbuy) | **POST** /v1/spatial/streets/{slug}/plots/{number}/buy | Buy a vacant plot from Crossly, in CBX.
[**CreateSpatialStreetRequest**](InventoryApi.md#createspatialstreetrequest) | **POST** /v1/spatial/streets/requests | Ask to found a street.
[**CreateSpatialStreetRequestFound**](InventoryApi.md#createspatialstreetrequestfound) | **POST** /v1/spatial/streets/requests/{id}/found | Found an approved street, in CBX.
[**DeleteInventory**](InventoryApi.md#deleteinventory) | **DELETE** /v1/inventory/{id} | Soft-archive an inventory item.
[**DeleteSpatialStreetPlot**](InventoryApi.md#deletespatialstreetplot) | **DELETE** /v1/spatial/streets/{slug}/plot | Take your shop off a street.
[**GetGameLeaderboard**](InventoryApi.md#getgameleaderboard) | **GET** /v1/games/leaderboards | Game leaderboards: for each of Price Guess (wins, then points), scavenger hunts (finished) and speed trades (won), the top ten this week (Monday 00:00 UTC on) under week and of all time under all - - rank, name, named, value and, for Price Guess, score. A name appears only for somebody who chose to be seen by name in Crossly World; everyone else is \&quot;A player\&quot; in their place.
[**GetHome**](InventoryApi.md#gethome) | **GET** /v1/homes/{slug} | A home by its address, as you may see it: open homes to anybody, friends-only homes to mutual follows, locked homes to their owner. 404 when you may not enter.
[**GetHomeMine**](InventoryApi.md#gethomemine) | **GET** /v1/homes/mine | Your Crossly World home: its address, privacy (open / friends / locked), theme, the room, the layout (each piece with what it shows - - things you no longer own are left out at read time) and the guestbook. Made on first read.
[**GetInventory**](InventoryApi.md#getinventory) | **GET** /v1/inventory/{id} | Get one inventory item with platform listings.
[**GetInventoryAging**](InventoryApi.md#getinventoryaging) | **GET** /v1/inventory/aging | Unsold stock by age (0-7, 7-30, 30-90, 90+ days, unlisted), each bucket with a recommendation.
[**GetInventoryCatalogMatch**](InventoryApi.md#getinventorycatalogmatch) | **GET** /v1/inventory/{id}/catalog-matches | One inventory item&#39;s catalog binding (if confirmed) and its pending match suggestions.
[**GetInventoryFacet**](InventoryApi.md#getinventoryfacet) | **GET** /v1/inventory/facets | Distinct brands + categories across this user&#39;s inventory.
[**GetInventoryLabel**](InventoryApi.md#getinventorylabel) | **GET** /v1/inventory/labels | List every distinct label across this user&#39;s inventory.
[**GetInventoryLabelStat**](InventoryApi.md#getinventorylabelstat) | **GET** /v1/inventory/labels/stats | List distinct labels with usage counts + colors.
[**GetInventorySellThrough**](InventoryApi.md#getinventorysellthrough) | **GET** /v1/inventory/sell-through | Cohort sell-through for a window (default: the 30 days ending 30 days ago) against the previous window of the same length.
[**GetInventorySkuExist**](InventoryApi.md#getinventoryskuexist) | **GET** /v1/inventory/sku-exists | Check whether a SKU is already in use on this user&#39;s inventory.
[**GetInventoryValueHistory**](InventoryApi.md#getinventoryvaluehistory) | **GET** /v1/inventory/value-history | Portfolio value of unsold stock over time, oldest first (one point per nightly snapshot).
[**GetMainStage**](InventoryApi.md#getmainstage) | **GET** /v1/main-stage | The Crossly World Main Stage right now: the live show (title, kind, host lineup), the stream on its big screen while a lineup host is on air, how many people are there (it holds 64 per copy and opens copies as it fills) and what is on next.
[**GetPetMine**](InventoryApi.md#getpetmine) | **GET** /v1/pets/mine | Your Crossly World pets: every kind (cat, dog, slab bot) with whether you own it, when it was earned and the ways to earn it (a quest or a reputation level - - pets are never sold), plus the pet walking beside you and the one greeting visitors at your shop door.
[**GetReputation**](InventoryApi.md#getreputation) | **GET** /v1/reputation/{profile} | Somebody&#39;s public reputation levels by their storefront handle: the level on each track and their nameplate badge. 404 for an unknown handle.
[**GetReputationMine**](InventoryApi.md#getreputationmine) | **GET** /v1/reputation/mine | Your Crossly World reputation: four tracks (trader, collector, seller, host) with points, level, what each level has unlocked and the next unlock, and how the points were earned (recency-weighted; a lost dispute or a failed authentication costs points). Earned from real activity only; nothing buys a level.
[**GetSpatialAddress**](InventoryApi.md#getspatialaddress) | **GET** /v1/spatial/address/{street}/{number} | The shop at an address.
[**GetSpatialAuctionPublic**](InventoryApi.md#getspatialauctionpublic) | **GET** /v1/spatial/auction/public/{slug} | A shared saleroom, opened by its public share handle.
[**GetSpatialAuctionRoom**](InventoryApi.md#getspatialauctionroom) | **GET** /v1/spatial/auction/rooms/{sceneId} | What the rostrum says in this room, right now.
[**GetSpatialEmote**](InventoryApi.md#getspatialemote) | **GET** /v1/spatial/emotes | Your Crossly World emotes: every emote pack (unlocked or not, with the quest that unlocks it), your 8-slot emote wheel as stored and as it shows (labels, locks, ready dots), and the moments earned and not yet played.
[**GetSpatialEmployeeConfig**](InventoryApi.md#getspatialemployeeconfig) | **GET** /v1/spatial/employee/config | How the shop employee in one of your rooms is configured.
[**GetSpatialParty**](InventoryApi.md#getspatialparty) | **GET** /v1/spatial/party | Your Crossly World party: party is null when you are in none, else its id, leader and up to 8 members (each with the place and copy they are in right now, or null), plus the invites it has out. invites lists the invites waiting for you.
[**GetSpatialProperty**](InventoryApi.md#getspatialproperty) | **GET** /v1/spatial/property | Your plots and tenancies.
[**GetSpatialPublic**](InventoryApi.md#getspatialpublic) | **GET** /v1/spatial/public/{slug} | A shared room, as a visitor sees it.
[**GetSpatialScene**](InventoryApi.md#getspatialscene) | **GET** /v1/spatial/scenes/{id} | A solved room: every item, where it sits, and why.
[**GetSpatialSceneWarehouse**](InventoryApi.md#getspatialscenewarehouse) | **GET** /v1/spatial/scenes/{id}/warehouse | A warehouse room: your racks, where they stand, and what is on each.
[**GetSpatialShopStaff**](InventoryApi.md#getspatialshopstaff) | **GET** /v1/spatial/shop/staff | Your shop&#39;s staff and their wages.
[**GetSpatialStreet**](InventoryApi.md#getspatialstreet) | **GET** /v1/spatial/streets/{slug} | A street: every plot and the shop open on each.
[**GetSpatialStreetFounding**](InventoryApi.md#getspatialstreetfounding) | **GET** /v1/spatial/streets/founding | What founding a street costs.
[**GetSpatialStreetPlotQuote**](InventoryApi.md#getspatialstreetplotquote) | **GET** /v1/spatial/streets/{slug}/plots/{number}/quote | What a plot costs.
[**GetWorldRoomFunnel**](InventoryApi.md#getworldroomfunnel) | **GET** /v1/world/rooms/{sceneId}/funnel | Your room&#39;s funnel over the last &#x60;days&#x60; (1-35, default 30): visitors (people, once a day), looks, items opened, checkouts started from the room, paid sales and revenueCents. Sales count only lines the room itself put in a cart.
[**GetWorldShelf**](InventoryApi.md#getworldshelf) | **GET** /v1/world/shelf/{listingSlug} | Where a Crossly listing sits on a shelf in a public room right now (roomSlug, roomName, itemId), or data:null when it is in no room.
[**GetWorldSkusCheapest**](InventoryApi.md#getworldskuscheapest) | **GET** /v1/world/skus/{skuId}/cheapest | The cheapest copy of a catalogue piece for sale on Crossly now, matched by the catalogue id (listingSlug, priceCents, and the room and item when it stands on a shelf), or data:null.
[**ListCatalogMatches**](InventoryApi.md#listcatalogmatches) | **GET** /v1/catalog-matches | Pending catalog-match suggestions: inventory items that look like a catalog product, awaiting your confirm.
[**ListFestivals**](InventoryApi.md#listfestivals) | **GET** /v1/festivals | Live and upcoming Crossly World festivals, soonest first: a weekend when every street wears one decor and the festival quest line (limited pins) counts. meta.live is the festival on now, if any.
[**ListGameBreakUpcoming**](InventoryApi.md#listgamebreakupcoming) | **GET** /v1/games/breaks/upcoming | Pack breaks staged on shop stages in Crossly World, live first then soonest: the break, its shop, start time, spots (taken or not, buyer masked), hits revealed so far, and buyUrl - - the break&#39;s page on crossly.net, the only place a spot is bought (null once every spot has sold).
[**ListGameHunts**](InventoryApi.md#listgamehunts) | **GET** /v1/games/hunts | Scavenger hunts running now in Crossly World shops and pop-up stalls, ending soonest first: title, shop (name and slug - - for a hunt at a stall, the street slug, with stall.bookingId set), how many tokens, what finishing unlocks (\&quot;10% off\&quot; - - never the code), when it ends and how many people have finished. Optional place filters to one shop or street slug.
[**ListGameResultMine**](InventoryApi.md#listgameresultmine) | **GET** /v1/games/results/mine | Your market-game results, newest first: game (price_guess, price_guess_solo, hunt, speed_trade, break_host), the round/hunt/trade/break id, score, whether you won, Bucks prize in cents (0 while prizes are pins only) and detail. meta.unlocks lists the hunt coupons you earned (with their codes); meta.hits the break hits pulled for spots you bought, with the order each ships with.
[**ListHomeMineBuilders**](InventoryApi.md#listhomeminebuilders) | **GET** /v1/homes/mine/builders | Your co-builders: friends you let rearrange your home in the world (move, turn, take out your things, add free furniture; never your bought pieces). Each: userId, name, friends (false once the friendship ended: listed but powerless).
[**ListHomeOfTheWeek**](InventoryApi.md#listhomeoftheweek) | **GET** /v1/homes/of-the-week | Home of the week: open homes by how many different people signed their guestbook in the last 7 days, most first.
[**ListInventory**](InventoryApi.md#listinventory) | **GET** /v1/inventory | List inventory items.
[**ListInventoryActivity**](InventoryApi.md#listinventoryactivity) | **GET** /v1/inventory/{id}/activity | Activity log for an inventory item (created/sold/edited/etc.).
[**ListInventoryIds**](InventoryApi.md#listinventoryids) | **GET** /v1/inventory/ids | Filter inventory → return matching id list.
[**ListInventoryUnits**](InventoryApi.md#listinventoryunits) | **GET** /v1/inventory/{id}/units | List the individually identified units of an inventory item.
[**ListJobAppraisals**](InventoryApi.md#listjobappraisals) | **GET** /v1/jobs/appraisals | Open price checks appraisers can answer (Collector level 3+ holding 3+ pieces in the category), newest first, optionally one market category. Each has its bounty; meta.payOn says whether bounties are paid yet.
[**ListJobShifts**](InventoryApi.md#listjobshifts) | **GET** /v1/jobs/shifts | Open shifts on the Crossly World Jobs board, soonest first: shop staff shifts in boutiques and grading-desk helper shifts, each with its window, place and pay. meta.payOn says whether Crossly is paying jobs yet.
[**ListMainStageEvents**](InventoryApi.md#listmainstageevents) | **GET** /v1/main-stage/events | Live and upcoming Main Stage events, soonest first: brand launches, creator meetups, talks, live sales and festival shows, each with its window and host lineup.
[**ListSpatialAuctionRoomLots**](InventoryApi.md#listspatialauctionroomlots) | **GET** /v1/spatial/auction/rooms/{sceneId}/lots | The catalogue: every lot in the session this room is hosting.
[**ListSpatialAuctionRooms**](InventoryApi.md#listspatialauctionrooms) | **GET** /v1/spatial/auction/rooms | Rooms of yours that are hosting an auction.
[**ListSpatialDeedListings**](InventoryApi.md#listspatialdeedlistings) | **GET** /v1/spatial/deeds/listings | Plots for resale.
[**ListSpatialEmployeeSessions**](InventoryApi.md#listspatialemployeesessions) | **GET** /v1/spatial/employee/sessions | The itemised bill: one row per customer-conversation.
[**ListSpatialEmployeeUsage**](InventoryApi.md#listspatialemployeeusage) | **GET** /v1/spatial/employee/usage | What your shop employees cost over a period, per room.
[**ListSpatialMoments**](InventoryApi.md#listspatialmoments) | **GET** /v1/spatial/moments | Your moment emotes, newest first: unbox (a Crossly purchase delivered), slab_flip (a card graded through Crossly Grading), handshake (a trade-table shake settled). Each plays once in a room; playedAt is null until then. ready&#x3D;true lists only the unplayed ones.
[**ListSpatialPartyWishlist**](InventoryApi.md#listspatialpartywishlist) | **GET** /v1/spatial/party/wishlist | Your party&#39;s shared wishlist, newest first: each listing (title, price in cents, image, shop slug while it is live), who added it, and every member&#39;s thumb up or down with the totals. Empty when you are in no party.
[**ListSpatialPublic**](InventoryApi.md#listspatialpublic) | **GET** /v1/spatial/public | Public rooms anyone can walk into.
[**ListSpatialPublicOffers**](InventoryApi.md#listspatialpublicoffers) | **GET** /v1/spatial/public/{slug}/offers | What is for sale in a shared room.
[**ListSpatialSceneMovements**](InventoryApi.md#listspatialscenemovements) | **GET** /v1/spatial/scenes/{id}/movements | Stock movements in a room over a time window.
[**ListSpatialScenes**](InventoryApi.md#listspatialscenes) | **GET** /v1/spatial/scenes | The rooms this account has.
[**ListSpatialShopAddresses**](InventoryApi.md#listspatialshopaddresses) | **GET** /v1/spatial/shop/addresses | Your shop&#39;s addresses.
[**ListSpatialStaffing**](InventoryApi.md#listspatialstaffing) | **GET** /v1/spatial/staffing | Shops you work in.
[**ListSpatialStreetMine**](InventoryApi.md#listspatialstreetmine) | **GET** /v1/spatial/streets/mine | Your streets.
[**ListSpatialStreets**](InventoryApi.md#listspatialstreets) | **GET** /v1/spatial/streets | Every street in the world.
[**ListWorldBlocks**](InventoryApi.md#listworldblocks) | **GET** /v1/world/blocks | The people you blocked in Crossly World, as you saw them (label, never the account behind a pseudonym), oldest first. Blocks are made in a room, on the person.
[**ListWorldItemSearch**](InventoryApi.md#listworlditemsearch) | **GET** /v1/world/items/search | Find an item on a shelf anywhere in Crossly World: what public rooms have for sale now, by title or catalogue name (q, 2+ characters). Each hit names the room (roomSlug) and the item (itemId); /c/&lt;roomSlug&gt;?item&#x3D;&lt;itemId&gt; opens it there.
[**ListWorldRoomWants**](InventoryApi.md#listworldroomwants) | **GET** /v1/world/rooms/{sceneId}/wants | Items your room shows but does not sell that visitors said they would buy (\&quot;I&#39;d buy this\&quot;), most wanted first: itemId and how many people.
[**UpdateInventory**](InventoryApi.md#updateinventory) | **PATCH** /v1/inventory/{id} | Update an inventory item (partial).
[**UpdateSpatialEmployeeConfig**](InventoryApi.md#updatespatialemployeeconfig) | **PUT** /v1/spatial/employee/config | Create or replace the shop employee in one of your rooms.
[**UpdateSpatialShopStaffWage**](InventoryApi.md#updatespatialshopstaffwage) | **PUT** /v1/spatial/shop/staff/{grantId}/wage | Set a staff member&#39;s weekly wage.


<a name="createcatalogmatchconfirm"></a>
# **CreateCatalogMatchConfirm**
> CreateCatalogMatchConfirmResponse CreateCatalogMatchConfirm (Guid id)

Confirm a catalog-match suggestion: links the item to the catalog product (sets its market_sku_id), so sold comps and market pricing apply to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCatalogMatchConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Confirm a catalog-match suggestion: links the item to the catalog product (sets its market_sku_id), so sold comps and market pricing apply to it.
                CreateCatalogMatchConfirmResponse result = apiInstance.CreateCatalogMatchConfirm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateCatalogMatchConfirm: " + e.Message );
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

**CreateCatalogMatchConfirmResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createcatalogmatchdismiss"></a>
# **CreateCatalogMatchDismiss**
> CreateCatalogMatchConfirmResponse CreateCatalogMatchDismiss (Guid id)

Dismiss a catalog-match suggestion. That product is never suggested for this item again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCatalogMatchDismissExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Dismiss a catalog-match suggestion. That product is never suggested for this item again.
                CreateCatalogMatchConfirmResponse result = apiInstance.CreateCatalogMatchDismiss(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateCatalogMatchDismiss: " + e.Message );
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

**CreateCatalogMatchConfirmResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createinventory"></a>
# **CreateInventory**
> CreateInventoryResponse CreateInventory ()

Create a new inventory item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Create a new inventory item.
                CreateInventoryResponse result = apiInstance.CreateInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventory: " + e.Message );
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

**CreateInventoryResponse**

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

<a name="createinventorybulkarchive"></a>
# **CreateInventoryBulkArchive**
> CreateInventoryBulkArchiveResponse CreateInventoryBulkArchive ()

Bulk archive inventory items (soft).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryBulkArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Bulk archive inventory items (soft).
                CreateInventoryBulkArchiveResponse result = apiInstance.CreateInventoryBulkArchive();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryBulkArchive: " + e.Message );
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

**CreateInventoryBulkArchiveResponse**

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

<a name="createinventorybulkdelete"></a>
# **CreateInventoryBulkDelete**
> CreateInventoryBulkDeleteResponse CreateInventoryBulkDelete ()

Bulk delete inventory items (delinks listings).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryBulkDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Bulk delete inventory items (delinks listings).
                CreateInventoryBulkDeleteResponse result = apiInstance.CreateInventoryBulkDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryBulkDelete: " + e.Message );
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

**CreateInventoryBulkDeleteResponse**

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

<a name="createinventorybulklabel"></a>
# **CreateInventoryBulkLabel**
> CreateListingBulkUpdateResponse CreateInventoryBulkLabel ()

Bulk add/remove labels on inventory items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryBulkLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Bulk add/remove labels on inventory items.
                CreateListingBulkUpdateResponse result = apiInstance.CreateInventoryBulkLabel();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryBulkLabel: " + e.Message );
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

**CreateListingBulkUpdateResponse**

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

<a name="createinventorybulkquantity"></a>
# **CreateInventoryBulkQuantity**
> CreateInventoryBulkQuantityResponse CreateInventoryBulkQuantity ()

Set / add / subtract stock across many items, syncing live listings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryBulkQuantityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Set / add / subtract stock across many items, syncing live listings.
                CreateInventoryBulkQuantityResponse result = apiInstance.CreateInventoryBulkQuantity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryBulkQuantity: " + e.Message );
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

**CreateInventoryBulkQuantityResponse**

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

<a name="createinventorycatalogmatchrefresh"></a>
# **CreateInventoryCatalogMatchRefresh**
> CreateInventoryCatalogMatchRefreshResponse CreateInventoryCatalogMatchRefresh (Guid id)

Run catalog matching for one item now. An identifier (UPC, style code, catalogue number) that resolves to exactly one product links it; otherwise likely products are returned as suggestions to confirm.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryCatalogMatchRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Run catalog matching for one item now. An identifier (UPC, style code, catalogue number) that resolves to exactly one product links it; otherwise likely products are returned as suggestions to confirm.
                CreateInventoryCatalogMatchRefreshResponse result = apiInstance.CreateInventoryCatalogMatchRefresh(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryCatalogMatchRefresh: " + e.Message );
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

**CreateInventoryCatalogMatchRefreshResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createinventorycsvexport"></a>
# **CreateInventoryCsvExport**
> string CreateInventoryCsvExport ()

Export inventory as CSV. Round-trips back through csv/import.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryCsvExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Export inventory as CSV. Round-trips back through csv/import.
                string result = apiInstance.CreateInventoryCsvExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryCsvExport: " + e.Message );
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

**string**

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

<a name="createinventorycsvimport"></a>
# **CreateInventoryCsvImport**
> CreateInventoryCsvImportResponse CreateInventoryCsvImport ()

Import a CSV. Rows whose sku matches an existing item update it; others are added. Pass dryRun to preview.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryCsvImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Import a CSV. Rows whose sku matches an existing item update it; others are added. Pass dryRun to preview.
                CreateInventoryCsvImportResponse result = apiInstance.CreateInventoryCsvImport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryCsvImport: " + e.Message );
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

**CreateInventoryCsvImportResponse**

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

<a name="createinventorylabelrename"></a>
# **CreateInventoryLabelRename**
> CreateInventoryLabelRenameResponse CreateInventoryLabelRename ()

Rename a label across every inventory item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryLabelRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Rename a label across every inventory item.
                CreateInventoryLabelRenameResponse result = apiInstance.CreateInventoryLabelRename();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryLabelRename: " + e.Message );
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

**CreateInventoryLabelRenameResponse**

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

<a name="createinventorymerge"></a>
# **CreateInventoryMerge**
> CreateInventoryMergeResponse CreateInventoryMerge ()

Merge inventory items that are the same physical item into one (stock is not summed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryMergeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Merge inventory items that are the same physical item into one (stock is not summed).
                CreateInventoryMergeResponse result = apiInstance.CreateInventoryMerge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryMerge: " + e.Message );
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

**CreateInventoryMergeResponse**

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

<a name="createinventoryunitidentifier"></a>
# **CreateInventoryUnitIdentifier**
> CreateInventoryUnitIdentifierResponse CreateInventoryUnitIdentifier (string id)

Record a serial, IMEI, or licence key against an inventory item.

Creates the unit lazily if no `unitId` is given. Recording BEFORE the item sells is what makes the identifier usable as evidence on a return — one first recorded after a dispute opens is graded `weak` and says so.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryUnitIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Record a serial, IMEI, or licence key against an inventory item.
                CreateInventoryUnitIdentifierResponse result = apiInstance.CreateInventoryUnitIdentifier(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryUnitIdentifier: " + e.Message );
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

**CreateInventoryUnitIdentifierResponse**

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

<a name="createinventoryunitlookup"></a>
# **CreateInventoryUnitLookup**
> CreateInventoryUnitLookupResponse CreateInventoryUnitLookup ()

Find a unit by identifier.

\"Have I ever seen this serial?\" — for when something arrives back and nobody knows which order it belongs to. Scoped to the caller, so it can never be used to probe another seller's stock.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateInventoryUnitLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Find a unit by identifier.
                CreateInventoryUnitLookupResponse result = apiInstance.CreateInventoryUnitLookup();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateInventoryUnitLookup: " + e.Message );
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

**CreateInventoryUnitLookupResponse**

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

<a name="createspatialpropertydeedlease"></a>
# **CreateSpatialPropertyDeedLease**
> CreateSpatialPropertyDeedLeaseResponse CreateSpatialPropertyDeedLease (string id)

Offer your plot for lease.

Body `{ rentWeeklyCents }` ($1-$5,000). The plot must be vacant and its maintenance current. Terms freeze when a tenant accepts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyDeedLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Offer your plot for lease.
                CreateSpatialPropertyDeedLeaseResponse result = apiInstance.CreateSpatialPropertyDeedLease(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyDeedLease: " + e.Message );
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

**CreateSpatialPropertyDeedLeaseResponse**

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

<a name="createspatialpropertydeedlist"></a>
# **CreateSpatialPropertyDeedList**
> CreateSpatialPropertyDeedListResponse CreateSpatialPropertyDeedList (string id)

List your plot for resale.

Body `{ priceCents }` ($1-$100,000). The deed's maintenance must be current. A lease on it carries on with the buyer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyDeedListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // List your plot for resale.
                CreateSpatialPropertyDeedListResponse result = apiInstance.CreateSpatialPropertyDeedList(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyDeedList: " + e.Message );
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

**CreateSpatialPropertyDeedListResponse**

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

<a name="createspatialpropertydeedmaintenance"></a>
# **CreateSpatialPropertyDeedMaintenance**
> CreateSpatialPropertyDeedMaintenanceResponse CreateSpatialPropertyDeedMaintenance (string id)

Pay a plot's maintenance forward.

Body `{ weeks }` (1-12). Extends `paidThrough` from the later of now and the current date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyDeedMaintenanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pay a plot's maintenance forward.
                CreateSpatialPropertyDeedMaintenanceResponse result = apiInstance.CreateSpatialPropertyDeedMaintenance(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyDeedMaintenance: " + e.Message );
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

**CreateSpatialPropertyDeedMaintenanceResponse**

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

<a name="createspatialpropertyleaseaccept"></a>
# **CreateSpatialPropertyLeaseAccept**
> CreateSpatialPropertyLeaseAcceptResponse CreateSpatialPropertyLeaseAccept (string id)

Take a plot on lease.

Pays the first week to the owner from your EARNED CBX and moves your (public) shop onto the plot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyLeaseAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take a plot on lease.
                CreateSpatialPropertyLeaseAcceptResponse result = apiInstance.CreateSpatialPropertyLeaseAccept(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyLeaseAccept: " + e.Message );
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

**CreateSpatialPropertyLeaseAcceptResponse**

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

<a name="createspatialpropertyleaseend"></a>
# **CreateSpatialPropertyLeaseEnd**
> CreateSpatialPropertyLeaseEndResponse CreateSpatialPropertyLeaseEnd (string id)

End a lease (owner or tenant).

The tenant's shop gets a free Main Street address again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyLeaseEndExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // End a lease (owner or tenant).
                CreateSpatialPropertyLeaseEndResponse result = apiInstance.CreateSpatialPropertyLeaseEnd(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyLeaseEnd: " + e.Message );
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

**CreateSpatialPropertyLeaseEndResponse**

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

<a name="createspatialpropertyleaserent"></a>
# **CreateSpatialPropertyLeaseRent**
> CreateSpatialPropertyLeaseRentResponse CreateSpatialPropertyLeaseRent (string id)

Pay rent forward.

Body `{ weeks }` (1-12). While the owner's deed is delinquent rent is WAIVED (`waived: true`), never collected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyLeaseRentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pay rent forward.
                CreateSpatialPropertyLeaseRentResponse result = apiInstance.CreateSpatialPropertyLeaseRent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyLeaseRent: " + e.Message );
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

**CreateSpatialPropertyLeaseRentResponse**

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

<a name="createspatialpropertylistingbuy"></a>
# **CreateSpatialPropertyListingBuy**
> CreateSpatialPropertyListingBuyResponse CreateSpatialPropertyListingBuy (string id)

Buy a plot on the resale market, in CBX.

Pays the asking price from your EARNED CBX to the seller (Crossly takes the 2% skim). The deed, its maintenance clock and any lease pass to you; your shop moves onto the plot if it is vacant. 409 if it has just sold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyListingBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Buy a plot on the resale market, in CBX.
                CreateSpatialPropertyListingBuyResponse result = apiInstance.CreateSpatialPropertyListingBuy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyListingBuy: " + e.Message );
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

**CreateSpatialPropertyListingBuyResponse**

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

<a name="createspatialpropertylistingcancel"></a>
# **CreateSpatialPropertyListingCancel**
> DeleteWorldJobShiftResponse CreateSpatialPropertyListingCancel (string id)

Take your plot off the market.

Only a listing nobody is buying right now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyListingCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take your plot off the market.
                DeleteWorldJobShiftResponse result = apiInstance.CreateSpatialPropertyListingCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialPropertyListingCancel: " + e.Message );
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

**DeleteWorldJobShiftResponse**

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

<a name="createspatialshopstaffpay"></a>
# **CreateSpatialShopStaffPay**
> CreateSpatialShopStaffPayResponse CreateSpatialShopStaffPay (string grantId)

Pay a staff member's wage forward.

Body `{ weeks }` (1-4). Paid from your EARNED CBX to theirs. 403 while paying staff is not open.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialShopStaffPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var grantId = "grantId_example";  // string | 

            try
            {
                // Pay a staff member's wage forward.
                CreateSpatialShopStaffPayResponse result = apiInstance.CreateSpatialShopStaffPay(grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialShopStaffPay: " + e.Message );
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
 **grantId** | **string**|  | 

### Return type

**CreateSpatialShopStaffPayResponse**

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

<a name="createspatialstreetclaim"></a>
# **CreateSpatialStreetClaim**
> CreateSpatialStreetClaimResponse CreateSpatialStreetClaim (string slug)

Put your shop on a street.

Seats your shop on the lowest vacant plot of an OPEN street and returns its `index` and `address`; calling it again returns the plot you already have. Your shop must be public (400 otherwise). A street that takes shops by application or invitation answers 400; a full street you do not own answers 409. Main Street grows instead of filling.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Put your shop on a street.
                CreateSpatialStreetClaimResponse result = apiInstance.CreateSpatialStreetClaim(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialStreetClaim: " + e.Message );
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

**CreateSpatialStreetClaimResponse**

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

<a name="createspatialstreetownedupkeep"></a>
# **CreateSpatialStreetOwnedUpkeep**
> CreateSpatialStreetOwnedUpkeepResponse CreateSpatialStreetOwnedUpkeep (Guid id)

Pay a street's upkeep forward.

Body `{ weeks }` (1-12). Extends `paidThrough` from the later of now and the current date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetOwnedUpkeepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Pay a street's upkeep forward.
                CreateSpatialStreetOwnedUpkeepResponse result = apiInstance.CreateSpatialStreetOwnedUpkeep(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialStreetOwnedUpkeep: " + e.Message );
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

**CreateSpatialStreetOwnedUpkeepResponse**

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

<a name="createspatialstreetplotbuy"></a>
# **CreateSpatialStreetPlotBuy**
> CreateSpatialStreetPlotBuyResponse CreateSpatialStreetPlotBuy (string slug, string number)

Buy a vacant plot from Crossly, in CBX.

Pays the quoted price from your EARNED CBX at spot and moves your shop onto the plot. Includes the first weeks of maintenance. 409 if the plot is taken or was just bought; 403 while property is not open.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetPlotBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 
            var number = "number_example";  // string | 

            try
            {
                // Buy a vacant plot from Crossly, in CBX.
                CreateSpatialStreetPlotBuyResponse result = apiInstance.CreateSpatialStreetPlotBuy(slug, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialStreetPlotBuy: " + e.Message );
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
 **number** | **string**|  | 

### Return type

**CreateSpatialStreetPlotBuyResponse**

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

<a name="createspatialstreetrequest"></a>
# **CreateSpatialStreetRequest**
> SpatialStreetResponse CreateSpatialStreetRequest ()

Ask to found a street.

Body `{ name, slug?, admission? }`. Free: the name (3-32 letters, numbers, spaces and ' & . -) and its web address (derived from the name when omitted) are held for Crossly's review. Crossly's own streets and room addresses are never available. You need a public shop, and hold one street at most. 409 when the address is taken or you already hold one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Ask to found a street.
                SpatialStreetResponse result = apiInstance.CreateSpatialStreetRequest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialStreetRequest: " + e.Message );
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

**SpatialStreetResponse**

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

<a name="createspatialstreetrequestfound"></a>
# **CreateSpatialStreetRequestFound**
> SpatialStreetResponse CreateSpatialStreetRequestFound (Guid id)

Found an approved street, in CBX.

Pays the founding premium from your EARNED CBX at spot and opens the street: its plots exist, the first weeks of upkeep are included, and your shop stands on it. 403 \"CBX opens at mint\" until the token is live; 409 before approval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetRequestFoundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Found an approved street, in CBX.
                SpatialStreetResponse result = apiInstance.CreateSpatialStreetRequestFound(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateSpatialStreetRequestFound: " + e.Message );
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

**SpatialStreetResponse**

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

<a name="deleteinventory"></a>
# **DeleteInventory**
> OkResponse DeleteInventory (Guid id)

Soft-archive an inventory item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Soft-archive an inventory item.
                OkResponse result = apiInstance.DeleteInventory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteInventory: " + e.Message );
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

<a name="deletespatialstreetplot"></a>
# **DeleteSpatialStreetPlot**
> CreateWorldCrewLeaveResponse DeleteSpatialStreetPlot (string slug)

Take your shop off a street.

The plot goes vacant and its address may be taken by another shop. `left: false` when your shop was not on it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSpatialStreetPlotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Take your shop off a street.
                CreateWorldCrewLeaveResponse result = apiInstance.DeleteSpatialStreetPlot(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteSpatialStreetPlot: " + e.Message );
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

**CreateWorldCrewLeaveResponse**

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

<a name="getgameleaderboard"></a>
# **GetGameLeaderboard**
> GetGameLeaderboardResponse GetGameLeaderboard ()

Game leaderboards: for each of Price Guess (wins, then points), scavenger hunts (finished) and speed trades (won), the top ten this week (Monday 00:00 UTC on) under week and of all time under all - - rank, name, named, value and, for Price Guess, score. A name appears only for somebody who chose to be seen by name in Crossly World; everyone else is \"A player\" in their place.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGameLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Game leaderboards: for each of Price Guess (wins, then points), scavenger hunts (finished) and speed trades (won), the top ten this week (Monday 00:00 UTC on) under week and of all time under all - - rank, name, named, value and, for Price Guess, score. A name appears only for somebody who chose to be seen by name in Crossly World; everyone else is \"A player\" in their place.
                GetGameLeaderboardResponse result = apiInstance.GetGameLeaderboard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetGameLeaderboard: " + e.Message );
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

**GetGameLeaderboardResponse**

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

<a name="gethome"></a>
# **GetHome**
> GetHomeResponse GetHome (string slug)

A home by its address, as you may see it: open homes to anybody, friends-only homes to mutual follows, locked homes to their owner. 404 when you may not enter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetHomeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A home by its address, as you may see it: open homes to anybody, friends-only homes to mutual follows, locked homes to their owner. 404 when you may not enter.
                GetHomeResponse result = apiInstance.GetHome(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetHome: " + e.Message );
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

**GetHomeResponse**

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

<a name="gethomemine"></a>
# **GetHomeMine**
> GetHomeResponse GetHomeMine ()

Your Crossly World home: its address, privacy (open / friends / locked), theme, the room, the layout (each piece with what it shows - - things you no longer own are left out at read time) and the guestbook. Made on first read.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetHomeMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your Crossly World home: its address, privacy (open / friends / locked), theme, the room, the layout (each piece with what it shows - - things you no longer own are left out at read time) and the guestbook. Made on first read.
                GetHomeResponse result = apiInstance.GetHomeMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetHomeMine: " + e.Message );
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

**GetHomeResponse**

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

<a name="getinventory"></a>
# **GetInventory**
> GetInventoryResponse GetInventory (Guid id)

Get one inventory item with platform listings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one inventory item with platform listings.
                GetInventoryResponse result = apiInstance.GetInventory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventory: " + e.Message );
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

**GetInventoryResponse**

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

<a name="getinventoryaging"></a>
# **GetInventoryAging**
> GetInventoryAgingResponse GetInventoryAging ()

Unsold stock by age (0-7, 7-30, 30-90, 90+ days, unlisted), each bucket with a recommendation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryAgingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Unsold stock by age (0-7, 7-30, 30-90, 90+ days, unlisted), each bucket with a recommendation.
                GetInventoryAgingResponse result = apiInstance.GetInventoryAging();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryAging: " + e.Message );
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

**GetInventoryAgingResponse**

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

<a name="getinventorycatalogmatch"></a>
# **GetInventoryCatalogMatch**
> GetInventoryCatalogMatchResponse GetInventoryCatalogMatch (Guid id)

One inventory item's catalog binding (if confirmed) and its pending match suggestions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryCatalogMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One inventory item's catalog binding (if confirmed) and its pending match suggestions.
                GetInventoryCatalogMatchResponse result = apiInstance.GetInventoryCatalogMatch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryCatalogMatch: " + e.Message );
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

**GetInventoryCatalogMatchResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getinventoryfacet"></a>
# **GetInventoryFacet**
> GetListingFacetResponse GetInventoryFacet ()

Distinct brands + categories across this user's inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryFacetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Distinct brands + categories across this user's inventory.
                GetListingFacetResponse result = apiInstance.GetInventoryFacet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryFacet: " + e.Message );
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

<a name="getinventorylabel"></a>
# **GetInventoryLabel**
> GetInventoryLabelResponse GetInventoryLabel ()

List every distinct label across this user's inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // List every distinct label across this user's inventory.
                GetInventoryLabelResponse result = apiInstance.GetInventoryLabel();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryLabel: " + e.Message );
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

**GetInventoryLabelResponse**

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

<a name="getinventorylabelstat"></a>
# **GetInventoryLabelStat**
> GetInventoryLabelStatResponse GetInventoryLabelStat ()

List distinct labels with usage counts + colors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryLabelStatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // List distinct labels with usage counts + colors.
                GetInventoryLabelStatResponse result = apiInstance.GetInventoryLabelStat();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryLabelStat: " + e.Message );
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

**GetInventoryLabelStatResponse**

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

<a name="getinventorysellthrough"></a>
# **GetInventorySellThrough**
> GetInventorySellThroughResponse GetInventorySellThrough ()

Cohort sell-through for a window (default: the 30 days ending 30 days ago) against the previous window of the same length.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventorySellThroughExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Cohort sell-through for a window (default: the 30 days ending 30 days ago) against the previous window of the same length.
                GetInventorySellThroughResponse result = apiInstance.GetInventorySellThrough();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventorySellThrough: " + e.Message );
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

**GetInventorySellThroughResponse**

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

<a name="getinventoryskuexist"></a>
# **GetInventorySkuExist**
> GetListingSkuExistResponse GetInventorySkuExist (string sku)

Check whether a SKU is already in use on this user's inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventorySkuExistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sku = "sku_example";  // string | 

            try
            {
                // Check whether a SKU is already in use on this user's inventory.
                GetListingSkuExistResponse result = apiInstance.GetInventorySkuExist(sku);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventorySkuExist: " + e.Message );
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

<a name="getinventoryvaluehistory"></a>
# **GetInventoryValueHistory**
> GetInventoryValueHistoryResponse GetInventoryValueHistory ()

Portfolio value of unsold stock over time, oldest first (one point per nightly snapshot).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetInventoryValueHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Portfolio value of unsold stock over time, oldest first (one point per nightly snapshot).
                GetInventoryValueHistoryResponse result = apiInstance.GetInventoryValueHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetInventoryValueHistory: " + e.Message );
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

**GetInventoryValueHistoryResponse**

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

<a name="getmainstage"></a>
# **GetMainStage**
> GetMainStageResponse GetMainStage ()

The Crossly World Main Stage right now: the live show (title, kind, host lineup), the stream on its big screen while a lineup host is on air, how many people are there (it holds 64 per copy and opens copies as it fills) and what is on next.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMainStageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // The Crossly World Main Stage right now: the live show (title, kind, host lineup), the stream on its big screen while a lineup host is on air, how many people are there (it holds 64 per copy and opens copies as it fills) and what is on next.
                GetMainStageResponse result = apiInstance.GetMainStage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetMainStage: " + e.Message );
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

**GetMainStageResponse**

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

<a name="getpetmine"></a>
# **GetPetMine**
> GetPetMineResponse GetPetMine ()

Your Crossly World pets: every kind (cat, dog, slab bot) with whether you own it, when it was earned and the ways to earn it (a quest or a reputation level - - pets are never sold), plus the pet walking beside you and the one greeting visitors at your shop door.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPetMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your Crossly World pets: every kind (cat, dog, slab bot) with whether you own it, when it was earned and the ways to earn it (a quest or a reputation level - - pets are never sold), plus the pet walking beside you and the one greeting visitors at your shop door.
                GetPetMineResponse result = apiInstance.GetPetMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetPetMine: " + e.Message );
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

**GetPetMineResponse**

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

<a name="getreputation"></a>
# **GetReputation**
> GetReputationResponse GetReputation (string profile)

Somebody's public reputation levels by their storefront handle: the level on each track and their nameplate badge. 404 for an unknown handle.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetReputationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var profile = "profile_example";  // string | 

            try
            {
                // Somebody's public reputation levels by their storefront handle: the level on each track and their nameplate badge. 404 for an unknown handle.
                GetReputationResponse result = apiInstance.GetReputation(profile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetReputation: " + e.Message );
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
 **profile** | **string**|  | 

### Return type

**GetReputationResponse**

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

<a name="getreputationmine"></a>
# **GetReputationMine**
> GetReputationMineResponse GetReputationMine ()

Your Crossly World reputation: four tracks (trader, collector, seller, host) with points, level, what each level has unlocked and the next unlock, and how the points were earned (recency-weighted; a lost dispute or a failed authentication costs points). Earned from real activity only; nothing buys a level.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetReputationMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your Crossly World reputation: four tracks (trader, collector, seller, host) with points, level, what each level has unlocked and the next unlock, and how the points were earned (recency-weighted; a lost dispute or a failed authentication costs points). Earned from real activity only; nothing buys a level.
                GetReputationMineResponse result = apiInstance.GetReputationMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetReputationMine: " + e.Message );
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

**GetReputationMineResponse**

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

<a name="getspatialaddress"></a>
# **GetSpatialAddress**
> GetSpatialAddressResponse GetSpatialAddress (string street, string number)

The shop at an address.

Resolves `<street>/<number>` to the shop's `publicSlug` and `name`. 404 when the plot is vacant or its shop is not public.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var street = "street_example";  // string | 
            var number = "number_example";  // string | 

            try
            {
                // The shop at an address.
                GetSpatialAddressResponse result = apiInstance.GetSpatialAddress(street, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialAddress: " + e.Message );
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
 **street** | **string**|  | 
 **number** | **string**|  | 

### Return type

**GetSpatialAddressResponse**

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

<a name="getspatialauctionpublic"></a>
# **GetSpatialAuctionPublic**
> GetSpatialAuctionPublicResponse GetSpatialAuctionPublic (string slug)

A shared saleroom, opened by its public share handle.

The bridge between the public room directory and this auction surface: /api/v1/spatial/public hands out SLUGS, while everything else here is keyed by scene id, and the two are deliberately not interchangeable. Resolves `public` rooms ONLY — an `unlisted` room is a bearer link, and crowd-shaped features stay off in those — so a slug that works on /api/v1/spatial/public/{slug} may still answer 404 here. The reply carries the `sceneId` you then pass to the room state, lots and bid endpoints. Same reading rules as the room state: amounts in CENTS, `minimumNextBidCents` rather than your own arithmetic, no reserve amount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialAuctionPublicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A shared saleroom, opened by its public share handle.
                GetSpatialAuctionPublicResponse result = apiInstance.GetSpatialAuctionPublic(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialAuctionPublic: " + e.Message );
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

**GetSpatialAuctionPublicResponse**

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

<a name="getspatialauctionroom"></a>
# **GetSpatialAuctionRoom**
> GetSpatialAuctionRoomResponse GetSpatialAuctionRoom (Guid sceneId)

What the rostrum says in this room, right now.

Serves whoever may ENTER the room, not only its owner — a saleroom restricted to the host would leave every visitor polling a 404 while standing in it. `hosting: false` with a null `auction` is a described empty answer, not an error. READ `currentLot.minimumNextBidCents`, never `currentBidCents + bidIncrementCents`: the first bid on a lot is floored at the START price rather than start + step, so deriving it locally raises the entry price on any lot with a real increment. All amounts are CENTS. `reserveMet` says whether the seller's floor has been cleared; the floor ITSELF is never published, because a crowd that can read it bids to it and stops. `serverTime` is this server's clock, handed over so you can age the session without trusting your own — there is no per-lot deadline to report, because a lot closes when a human drops the hammer and not when a timer expires. A room you may not enter answers 404, the same as one that does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialAuctionRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sceneId = "sceneId_example";  // Guid | 

            try
            {
                // What the rostrum says in this room, right now.
                GetSpatialAuctionRoomResponse result = apiInstance.GetSpatialAuctionRoom(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialAuctionRoom: " + e.Message );
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
 **sceneId** | **Guid**|  | 

### Return type

**GetSpatialAuctionRoomResponse**

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

<a name="getspatialemote"></a>
# **GetSpatialEmote**
> GetSpatialEmoteResponse GetSpatialEmote ()

Your Crossly World emotes: every emote pack (unlocked or not, with the quest that unlocks it), your 8-slot emote wheel as stored and as it shows (labels, locks, ready dots), and the moments earned and not yet played.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialEmoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your Crossly World emotes: every emote pack (unlocked or not, with the quest that unlocks it), your 8-slot emote wheel as stored and as it shows (labels, locks, ready dots), and the moments earned and not yet played.
                GetSpatialEmoteResponse result = apiInstance.GetSpatialEmote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialEmote: " + e.Message );
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

**GetSpatialEmoteResponse**

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

<a name="getspatialemployeeconfig"></a>
# **GetSpatialEmployeeConfig**
> GetSpatialEmployeeConfigResponse GetSpatialEmployeeConfig (Guid sceneId)

How the shop employee in one of your rooms is configured.

Owner-only, and 404 for a room this account does not own — the same answer a room that does not exist gives, so this cannot be used to discover scene ids. `config: null` means the room has never had an employee configured, which is different from one that exists and is switched off (`enabled: false`). THE SIGNING SECRET IS NEVER RETURNED, here or anywhere else. It is encrypted at rest and handed back in plaintext exactly once, in the response to the PUT that minted it; `hasAgentSecret` is the only thing any read path will say about it, and re-reading it is impossible by construction rather than by omission. `suspendedAt` non-null means the employee is off the floor because a charge was refused — `suspendedReason` says which — and saving the config again clears it. `brainKind` is idle (stands there), rules (the list in `rules`, evaluated in order, first match wins) or agent (your own endpoint decides).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialEmployeeConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sceneId = "sceneId_example";  // Guid | 

            try
            {
                // How the shop employee in one of your rooms is configured.
                GetSpatialEmployeeConfigResponse result = apiInstance.GetSpatialEmployeeConfig(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialEmployeeConfig: " + e.Message );
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
 **sceneId** | **Guid**|  | 

### Return type

**GetSpatialEmployeeConfigResponse**

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

<a name="getspatialparty"></a>
# **GetSpatialParty**
> GetSpatialPartyResponse GetSpatialParty ()

Your Crossly World party: party is null when you are in none, else its id, leader and up to 8 members (each with the place and copy they are in right now, or null), plus the invites it has out. invites lists the invites waiting for you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialPartyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your Crossly World party: party is null when you are in none, else its id, leader and up to 8 members (each with the place and copy they are in right now, or null), plus the invites it has out. invites lists the invites waiting for you.
                GetSpatialPartyResponse result = apiInstance.GetSpatialParty();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialParty: " + e.Message );
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

**GetSpatialPartyResponse**

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

<a name="getspatialproperty"></a>
# **GetSpatialProperty**
> GetSpatialPropertyResponse GetSpatialProperty ()

Your plots and tenancies.

Each deed with its address, price, weekly maintenance, `paidThrough`, `status` (active, grace, delinquent — a delinquent owner cannot collect rent; past three weeks late a deed is foreclosed) and any lease; plus the leases you rent as a tenant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your plots and tenancies.
                GetSpatialPropertyResponse result = apiInstance.GetSpatialProperty();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialProperty: " + e.Message );
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

**GetSpatialPropertyResponse**

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

<a name="getspatialpublic"></a>
# **GetSpatialPublic**
> GetSpatialPublicResponse GetSpatialPublic (string slug)

A shared room, as a visitor sees it.

The room behind a share link: container geometry in METRES matching the real physical object, the solved arrangement, and one row per object on the shelves. REDACTED relative to the owner's view — no cost, no storage location, no listing status — so do not expect the fields /v1/spatial/scenes/{id} returns. Each placement carries `pinned`: true means a HUMAN put it there and it will not move; false means a layout SOLVER chose, and it may choose differently once the stock changes, so an unpinned placement is never a statement about where something physically is. `solved.overflow` lists what did not fit — a non-empty array means the room is INCOMPLETE and `stats.itemCount` exceeds what is on screen. Resolves rooms shared as `unlisted` as well as `public`: holding the link is the permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialPublicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A shared room, as a visitor sees it.
                GetSpatialPublicResponse result = apiInstance.GetSpatialPublic(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialPublic: " + e.Message );
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

**GetSpatialPublicResponse**

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

<a name="getspatialscene"></a>
# **GetSpatialScene**
> GetSpatialSceneResponse GetSpatialScene (string id)

A solved room: every item, where it sits, and why.

Returns the space profile (container geometry in METRES, matching the real physical object), the solved placements, and the items. Placements carry a `pinned` flag: true means a human put it there and the layout solver will not move it; false means the solver chose, and it may choose differently once the stock changes. `overflow` lists anything that did not fit — it is reported, never silently dropped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A solved room: every item, where it sits, and why.
                GetSpatialSceneResponse result = apiInstance.GetSpatialScene(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialScene: " + e.Message );
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

**GetSpatialSceneResponse**

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

<a name="getspatialscenewarehouse"></a>
# **GetSpatialSceneWarehouse**
> GetSpatialSceneWarehouseResponse GetSpatialSceneWarehouse (string id)

A warehouse room: your racks, where they stand, and what is on each.

For a room of kind `warehouse`. Racks are your own storage units (pallet racks, shelving, garment rails, floor totes) with their location `code` (the one written to each item's storage location when stock is placed), a floor position in METRES, and `capacity` / `stocked` / `fill`. `positioned: false` means you never stood the rack anywhere and it was laid out for you. Each rack lists the items on it with the full code of the level or bin they sit in. A non-warehouse room is a 400.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialSceneWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A warehouse room: your racks, where they stand, and what is on each.
                GetSpatialSceneWarehouseResponse result = apiInstance.GetSpatialSceneWarehouse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialSceneWarehouse: " + e.Message );
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

**GetSpatialSceneWarehouseResponse**

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

<a name="getspatialshopstaff"></a>
# **GetSpatialShopStaff**
> GetSpatialShopStaffResponse GetSpatialShopStaff ()

Your shop's staff and their wages.

Staff are people holding a `staff` grant on your shop (invite them through the room-sharing flow). They may arrange the shop and move its stock, nothing else. `wageWeeklyCents` is paid by you in CBX; `pending` is an invite not yet accepted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialShopStaffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your shop's staff and their wages.
                GetSpatialShopStaffResponse result = apiInstance.GetSpatialShopStaff();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialShopStaff: " + e.Message );
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

**GetSpatialShopStaffResponse**

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

<a name="getspatialstreet"></a>
# **GetSpatialStreet**
> GetSpatialStreetResponse GetSpatialStreet (string slug)

A street: every plot and the shop open on each.

Plots in order from the entrance. Each has its `index` (0-based), house `number` (1-based), `address` (`<street>/<number>`, stable for as long as the shop stands there) and `label` (\"12 Main Street\"). `shop` is the open shop's directory entry, or null for a vacant plot; `shuttered: true` is a plot whose shop is not public right now — it keeps its address. `reserved` plots are newcomer plots: occupiable, never sold or leased. Each open shop's plot carries `life`: `soldToday` (the seller's sales today, America/New_York) and `window` (up to three live listings: listingId, slug, title, priceCents, imageUrl). The street carries `life.billboards` (promoted listings, paid per sale, then Crossly house ads) and `life.buskers` (shop owners on it who are live now).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialStreetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A street: every plot and the shop open on each.
                GetSpatialStreetResponse result = apiInstance.GetSpatialStreet(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialStreet: " + e.Message );
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

**GetSpatialStreetResponse**

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

<a name="getspatialstreetfounding"></a>
# **GetSpatialStreetFounding**
> GetSpatialStreetFoundingResponse GetSpatialStreetFounding ()

What founding a street costs.

The founding premium `priceCents` (paid in CBX at spot, from EARNED balance), weekly upkeep `maintenanceWeeklyCents`, `includedWeeks` of upkeep included, `plots` on a founded street, `maxPerOwner`, the `admissions` an owner may pick (open | apply | invite), `cbx` {open, reason} - - closed until mint - - and, for the token owner, `refusal`: why they cannot ask yet (no public shop, already holding a street), or null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialStreetFoundingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // What founding a street costs.
                GetSpatialStreetFoundingResponse result = apiInstance.GetSpatialStreetFounding();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialStreetFounding: " + e.Message );
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

**GetSpatialStreetFoundingResponse**

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

<a name="getspatialstreetplotquote"></a>
# **GetSpatialStreetPlotQuote**
> GetSpatialStreetPlotQuoteResponse GetSpatialStreetPlotQuote (string slug, string number)

What a plot costs.

Price in CENTS (paid in CBX at spot), weekly maintenance in cents, weeks included with a purchase, and whether it can be bought now. Newcomer plots (1-2) are never sold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialStreetPlotQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 
            var number = "number_example";  // string | 

            try
            {
                // What a plot costs.
                GetSpatialStreetPlotQuoteResponse result = apiInstance.GetSpatialStreetPlotQuote(slug, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSpatialStreetPlotQuote: " + e.Message );
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
 **number** | **string**|  | 

### Return type

**GetSpatialStreetPlotQuoteResponse**

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

<a name="getworldroomfunnel"></a>
# **GetWorldRoomFunnel**
> GetWorldRoomFunnelResponse GetWorldRoomFunnel (Guid sceneId, int? days = null)

Your room's funnel over the last `days` (1-35, default 30): visitors (people, once a day), looks, items opened, checkouts started from the room, paid sales and revenueCents. Sales count only lines the room itself put in a cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldRoomFunnelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sceneId = "sceneId_example";  // Guid | 
            var days = 56;  // int? |  (optional) 

            try
            {
                // Your room's funnel over the last `days` (1-35, default 30): visitors (people, once a day), looks, items opened, checkouts started from the room, paid sales and revenueCents. Sales count only lines the room itself put in a cart.
                GetWorldRoomFunnelResponse result = apiInstance.GetWorldRoomFunnel(sceneId, days);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetWorldRoomFunnel: " + e.Message );
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
 **sceneId** | **Guid**|  | 
 **days** | **int?**|  | [optional] 

### Return type

**GetWorldRoomFunnelResponse**

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

<a name="getworldshelf"></a>
# **GetWorldShelf**
> GetWorldShelfResponse GetWorldShelf (string listingSlug)

Where a Crossly listing sits on a shelf in a public room right now (roomSlug, roomName, itemId), or data:null when it is in no room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldShelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var listingSlug = "listingSlug_example";  // string | 

            try
            {
                // Where a Crossly listing sits on a shelf in a public room right now (roomSlug, roomName, itemId), or data:null when it is in no room.
                GetWorldShelfResponse result = apiInstance.GetWorldShelf(listingSlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetWorldShelf: " + e.Message );
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
 **listingSlug** | **string**|  | 

### Return type

**GetWorldShelfResponse**

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

<a name="getworldskuscheapest"></a>
# **GetWorldSkusCheapest**
> GetWorldSkusCheapestResponse GetWorldSkusCheapest (Guid skuId)

The cheapest copy of a catalogue piece for sale on Crossly now, matched by the catalogue id (listingSlug, priceCents, and the room and item when it stands on a shelf), or data:null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldSkusCheapestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var skuId = "skuId_example";  // Guid | 

            try
            {
                // The cheapest copy of a catalogue piece for sale on Crossly now, matched by the catalogue id (listingSlug, priceCents, and the room and item when it stands on a shelf), or data:null.
                GetWorldSkusCheapestResponse result = apiInstance.GetWorldSkusCheapest(skuId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.GetWorldSkusCheapest: " + e.Message );
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
 **skuId** | **Guid**|  | 

### Return type

**GetWorldSkusCheapestResponse**

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

<a name="listcatalogmatches"></a>
# **ListCatalogMatches**
> ListCatalogMatchesResponse ListCatalogMatches (int? limit = null, DateTime? before = null)

Pending catalog-match suggestions: inventory items that look like a catalog product, awaiting your confirm.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCatalogMatchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var limit = 56;  // int? |  (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Keyset cursor: createdAt of the last row seen. (optional) 

            try
            {
                // Pending catalog-match suggestions: inventory items that look like a catalog product, awaiting your confirm.
                ListCatalogMatchesResponse result = apiInstance.ListCatalogMatches(limit, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListCatalogMatches: " + e.Message );
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
 **limit** | **int?**|  | [optional] 
 **before** | **DateTime?**| Keyset cursor: createdAt of the last row seen. | [optional] 

### Return type

**ListCatalogMatchesResponse**

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

<a name="listfestivals"></a>
# **ListFestivals**
> ListFestivalsResponse ListFestivals ()

Live and upcoming Crossly World festivals, soonest first: a weekend when every street wears one decor and the festival quest line (limited pins) counts. meta.live is the festival on now, if any.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFestivalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Live and upcoming Crossly World festivals, soonest first: a weekend when every street wears one decor and the festival quest line (limited pins) counts. meta.live is the festival on now, if any.
                ListFestivalsResponse result = apiInstance.ListFestivals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListFestivals: " + e.Message );
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

**ListFestivalsResponse**

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

<a name="listgamebreakupcoming"></a>
# **ListGameBreakUpcoming**
> ListGameBreakUpcomingResponse ListGameBreakUpcoming ()

Pack breaks staged on shop stages in Crossly World, live first then soonest: the break, its shop, start time, spots (taken or not, buyer masked), hits revealed so far, and buyUrl - - the break's page on crossly.net, the only place a spot is bought (null once every spot has sold).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGameBreakUpcomingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Pack breaks staged on shop stages in Crossly World, live first then soonest: the break, its shop, start time, spots (taken or not, buyer masked), hits revealed so far, and buyUrl - - the break's page on crossly.net, the only place a spot is bought (null once every spot has sold).
                ListGameBreakUpcomingResponse result = apiInstance.ListGameBreakUpcoming();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListGameBreakUpcoming: " + e.Message );
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

**ListGameBreakUpcomingResponse**

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

<a name="listgamehunts"></a>
# **ListGameHunts**
> ListGameHuntsResponse ListGameHunts (string place = null)

Scavenger hunts running now in Crossly World shops and pop-up stalls, ending soonest first: title, shop (name and slug - - for a hunt at a stall, the street slug, with stall.bookingId set), how many tokens, what finishing unlocks (\"10% off\" - - never the code), when it ends and how many people have finished. Optional place filters to one shop or street slug.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGameHuntsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var place = "place_example";  // string |  (optional) 

            try
            {
                // Scavenger hunts running now in Crossly World shops and pop-up stalls, ending soonest first: title, shop (name and slug - - for a hunt at a stall, the street slug, with stall.bookingId set), how many tokens, what finishing unlocks (\"10% off\" - - never the code), when it ends and how many people have finished. Optional place filters to one shop or street slug.
                ListGameHuntsResponse result = apiInstance.ListGameHunts(place);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListGameHunts: " + e.Message );
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
 **place** | **string**|  | [optional] 

### Return type

**ListGameHuntsResponse**

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

<a name="listgameresultmine"></a>
# **ListGameResultMine**
> ListGameResultMineResponse ListGameResultMine ()

Your market-game results, newest first: game (price_guess, price_guess_solo, hunt, speed_trade, break_host), the round/hunt/trade/break id, score, whether you won, Bucks prize in cents (0 while prizes are pins only) and detail. meta.unlocks lists the hunt coupons you earned (with their codes); meta.hits the break hits pulled for spots you bought, with the order each ships with.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGameResultMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your market-game results, newest first: game (price_guess, price_guess_solo, hunt, speed_trade, break_host), the round/hunt/trade/break id, score, whether you won, Bucks prize in cents (0 while prizes are pins only) and detail. meta.unlocks lists the hunt coupons you earned (with their codes); meta.hits the break hits pulled for spots you bought, with the order each ships with.
                ListGameResultMineResponse result = apiInstance.ListGameResultMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListGameResultMine: " + e.Message );
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

**ListGameResultMineResponse**

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

<a name="listhomeminebuilders"></a>
# **ListHomeMineBuilders**
> ListHomeMineBuildersResponse ListHomeMineBuilders ()

Your co-builders: friends you let rearrange your home in the world (move, turn, take out your things, add free furniture; never your bought pieces). Each: userId, name, friends (false once the friendship ended: listed but powerless).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListHomeMineBuildersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your co-builders: friends you let rearrange your home in the world (move, turn, take out your things, add free furniture; never your bought pieces). Each: userId, name, friends (false once the friendship ended: listed but powerless).
                ListHomeMineBuildersResponse result = apiInstance.ListHomeMineBuilders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListHomeMineBuilders: " + e.Message );
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

**ListHomeMineBuildersResponse**

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

<a name="listhomeoftheweek"></a>
# **ListHomeOfTheWeek**
> ListHomeOfTheWeekResponse ListHomeOfTheWeek ()

Home of the week: open homes by how many different people signed their guestbook in the last 7 days, most first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListHomeOfTheWeekExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Home of the week: open homes by how many different people signed their guestbook in the last 7 days, most first.
                ListHomeOfTheWeekResponse result = apiInstance.ListHomeOfTheWeek();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListHomeOfTheWeek: " + e.Message );
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

**ListHomeOfTheWeekResponse**

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

<a name="listinventory"></a>
# **ListInventory**
> ListInventoryResponse ListInventory (int? page = null, int? limit = null, string search = null, string status = null, string kind = null, string platforms = null, string platformMode = null)

List inventory items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var page = 1;  // int? |  (optional)  (default to 1)
            var limit = 25;  // int? |  (optional)  (default to 25)
            var search = "search_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var kind = "physical";  // string | Physical goods or Web3 assets (NFTs). Omit for both. (optional) 
            var platforms = "platforms_example";  // string | Comma-separated marketplaces, e.g. \"ebay,vinted\". Items live (an active listing) on any of them. (optional) 
            var platformMode = "listed";  // string | \"not_listed\" inverts `platforms`: items live on none of them. Default \"listed\". (optional) 

            try
            {
                // List inventory items.
                ListInventoryResponse result = apiInstance.ListInventory(page, limit, search, status, kind, platforms, platformMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInventory: " + e.Message );
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
 **search** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **kind** | **string**| Physical goods or Web3 assets (NFTs). Omit for both. | [optional] 
 **platforms** | **string**| Comma-separated marketplaces, e.g. \&quot;ebay,vinted\&quot;. Items live (an active listing) on any of them. | [optional] 
 **platformMode** | **string**| \&quot;not_listed\&quot; inverts &#x60;platforms&#x60;: items live on none of them. Default \&quot;listed\&quot;. | [optional] 

### Return type

**ListInventoryResponse**

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

<a name="listinventoryactivity"></a>
# **ListInventoryActivity**
> ListInventoryActivityResponse ListInventoryActivity (Guid id, int? limit = null)

Activity log for an inventory item (created/sold/edited/etc.).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListInventoryActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 
            var limit = 50;  // int? |  (optional)  (default to 50)

            try
            {
                // Activity log for an inventory item (created/sold/edited/etc.).
                ListInventoryActivityResponse result = apiInstance.ListInventoryActivity(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInventoryActivity: " + e.Message );
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
 **limit** | **int?**|  | [optional] [default to 50]

### Return type

**ListInventoryActivityResponse**

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

<a name="listinventoryids"></a>
# **ListInventoryIds**
> ListListingIdsResponse ListInventoryIds ()

Filter inventory → return matching id list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListInventoryIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Filter inventory → return matching id list.
                ListListingIdsResponse result = apiInstance.ListInventoryIds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInventoryIds: " + e.Message );
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

<a name="listinventoryunits"></a>
# **ListInventoryUnits**
> ListInventoryUnitsResponse ListInventoryUnits (string id)

List the individually identified units of an inventory item.

Each identifier carries a `strength` describing what it proves: `strong` was recorded before the item sold, `good` at packing, `weak` only after it shipped. The grade is derived from when it was recorded, never from the value itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListInventoryUnitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // List the individually identified units of an inventory item.
                ListInventoryUnitsResponse result = apiInstance.ListInventoryUnits(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInventoryUnits: " + e.Message );
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

**ListInventoryUnitsResponse**

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

<a name="listjobappraisals"></a>
# **ListJobAppraisals**
> ListJobAppraisalsResponse ListJobAppraisals (string category = null, int? limit = null)

Open price checks appraisers can answer (Collector level 3+ holding 3+ pieces in the category), newest first, optionally one market category. Each has its bounty; meta.payOn says whether bounties are paid yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListJobAppraisalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var category = "category_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Open price checks appraisers can answer (Collector level 3+ holding 3+ pieces in the category), newest first, optionally one market category. Each has its bounty; meta.payOn says whether bounties are paid yet.
                ListJobAppraisalsResponse result = apiInstance.ListJobAppraisals(category, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListJobAppraisals: " + e.Message );
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
 **category** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListJobAppraisalsResponse**

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

<a name="listjobshifts"></a>
# **ListJobShifts**
> ListJobShiftsResponse ListJobShifts (int? limit = null)

Open shifts on the Crossly World Jobs board, soonest first: shop staff shifts in boutiques and grading-desk helper shifts, each with its window, place and pay. meta.payOn says whether Crossly is paying jobs yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListJobShiftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Open shifts on the Crossly World Jobs board, soonest first: shop staff shifts in boutiques and grading-desk helper shifts, each with its window, place and pay. meta.payOn says whether Crossly is paying jobs yet.
                ListJobShiftsResponse result = apiInstance.ListJobShifts(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListJobShifts: " + e.Message );
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
 **limit** | **int?**|  | [optional] 

### Return type

**ListJobShiftsResponse**

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

<a name="listmainstageevents"></a>
# **ListMainStageEvents**
> ListMainStageEventsResponse ListMainStageEvents ()

Live and upcoming Main Stage events, soonest first: brand launches, creator meetups, talks, live sales and festival shows, each with its window and host lineup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMainStageEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Live and upcoming Main Stage events, soonest first: brand launches, creator meetups, talks, live sales and festival shows, each with its window and host lineup.
                ListMainStageEventsResponse result = apiInstance.ListMainStageEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListMainStageEvents: " + e.Message );
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

**ListMainStageEventsResponse**

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

<a name="listspatialauctionroomlots"></a>
# **ListSpatialAuctionRoomLots**
> ListSpatialAuctionRoomLotsResponse ListSpatialAuctionRoomLots (Guid sceneId)

The catalogue: every lot in the session this room is hosting.

In lot-number order, which is the order the auctioneer reaches them. Each row carries the same fields as the current lot — `minimumNextBidCents` is the figure the bid transaction evaluates against, and every amount is CENTS. A lot with a `hammerAt` has been sold and one with `skipped: true` failed its reserve; neither takes further bids. The reserve AMOUNT is absent by design and `reserveMet` is the only thing said about it. Which lot is UP is not derivable from this list — the auctioneer is the authority and may skip ahead — so take that from the room state endpoint rather than from the lowest open lot number. A room hosting nothing answers an empty list, not a 404: 404 here means the room does not exist or you may not enter it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialAuctionRoomLotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sceneId = "sceneId_example";  // Guid | 

            try
            {
                // The catalogue: every lot in the session this room is hosting.
                ListSpatialAuctionRoomLotsResponse result = apiInstance.ListSpatialAuctionRoomLots(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialAuctionRoomLots: " + e.Message );
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
 **sceneId** | **Guid**|  | 

### Return type

**ListSpatialAuctionRoomLotsResponse**

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

<a name="listspatialauctionrooms"></a>
# **ListSpatialAuctionRooms**
> ListSpatialAuctionRoomsResponse ListSpatialAuctionRooms ()

Rooms of yours that are hosting an auction.

One row per room you OWN that currently has a live-auction session bound into it, with that session's title, status and schedule joined in so you do not have to fetch each one to find out whether anything is running. Empty is the ordinary answer: hosting nothing is the normal state of every room on the platform. This is deliberately not \"rooms I could bid in\" — that is the public directory at /api/v1/spatial/public, and enumerating every stranger's saleroom here would be a different endpoint wearing this one's name. `topics.auction` is the WebSocket topic the price moves on; `topics.room` is null until the room has been shared.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialAuctionRoomsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Rooms of yours that are hosting an auction.
                ListSpatialAuctionRoomsResponse result = apiInstance.ListSpatialAuctionRooms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialAuctionRooms: " + e.Message );
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

**ListSpatialAuctionRoomsResponse**

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

<a name="listspatialdeedlistings"></a>
# **ListSpatialDeedListings**
> ListSpatialDeedListingsResponse ListSpatialDeedListings ()

Plots for resale.

Live resale listings, cheapest first: address, `priceCents` (paid in CBX at spot), Crossly's `feeCents` (the 2% CBX skim), weekly maintenance, and the deed's `status` and `paidThrough` — a buyer inherits the maintenance clock. `?street=` narrows to one street.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialDeedListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Plots for resale.
                ListSpatialDeedListingsResponse result = apiInstance.ListSpatialDeedListings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialDeedListings: " + e.Message );
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

**ListSpatialDeedListingsResponse**

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

<a name="listspatialemployeesessions"></a>
# **ListSpatialEmployeeSessions**
> ListSpatialEmployeeSessionsResponse ListSpatialEmployeeSessions (string since = null, string until = null, Guid? sceneId = null, bool? unpaidOnly = null, int? page = null, int? limit = null)

The itemised bill: one row per customer-conversation.

Newest first, filtered by `since`/`until` (ISO 8601, default 30 days, max 366) and optionally by `sceneId`. `unpaidOnly` narrows to the conversations that settled without payment. This is what makes a usage total checkable by hand: each row carries the interval it was priced from. `engagedMs` is SERVER-measured, from two timestamps this server wrote — no client reports its own duration anywhere in this feature — and it is null, not zero, while the conversation is still running. `settledAt` null with an `endedAt` set means billing has not yet run; `unpaidReason` set means it ran and moved nothing. Base units are STRINGS (64-bit integers). THE CUSTOMER IS NOT NAMED. Billing is per customer, but no row here carries a visitor identity — a bill is an account of what was spent, not a list of who walked in, and publishing the user ids of strangers through a seller API key is a different feature with a different consent question.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialEmployeeSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var since = "since_example";  // string |  (optional) 
            var until = "until_example";  // string |  (optional) 
            var sceneId = "sceneId_example";  // Guid? |  (optional) 
            var unpaidOnly = false;  // bool? |  (optional)  (default to false)
            var page = 1;  // int? |  (optional)  (default to 1)
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // The itemised bill: one row per customer-conversation.
                ListSpatialEmployeeSessionsResponse result = apiInstance.ListSpatialEmployeeSessions(since, until, sceneId, unpaidOnly, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialEmployeeSessions: " + e.Message );
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
 **since** | **string**|  | [optional] 
 **until** | **string**|  | [optional] 
 **sceneId** | **Guid?**|  | [optional] 
 **unpaidOnly** | **bool?**|  | [optional] [default to false]
 **page** | **int?**|  | [optional] [default to 1]
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListSpatialEmployeeSessionsResponse**

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

<a name="listspatialemployeeusage"></a>
# **ListSpatialEmployeeUsage**
> ListSpatialEmployeeUsageResponse ListSpatialEmployeeUsage (string since = null, string until = null, Guid? sceneId = null)

What your shop employees cost over a period, per room.

One row per room that had at least one conversation in the window; rooms with none are ABSENT rather than reported as zero. `since`/`until` are ISO 8601 and default to the last 30 days, and a window may span at most 366 days — longer is a 400, not a silently shortened period. Money: `billedCents` is COSM cents that were actually charged, and it is the figure to report. `burnBaseUnits` and `poolBaseUnits` are COSM base units as STRINGS because they are 64-bit integers — half the fee is destroyed and half moves to the employee-tax pool. `openConversations` are running right now: measured, not yet billed, and contributing 0 to every money field until they settle, so a total read mid-conversation is a floor rather than a final figure. `unpaidConversations` were settled WITHOUT payment — the seller was short of COSM or COSM is not live on this deployment — and each of those also suspended the employee in that room; they are not a debt and will never be retried. `meta.totals` is the same window summed in the database, not the sum of the rows. `meta.rate` restates the price so a figure can be checked by hand: billing is per STARTED minute, per CUSTOMER, only while somebody is engaged. An employee standing in an empty shop costs nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialEmployeeUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var since = "since_example";  // string |  (optional) 
            var until = "until_example";  // string |  (optional) 
            var sceneId = "sceneId_example";  // Guid? |  (optional) 

            try
            {
                // What your shop employees cost over a period, per room.
                ListSpatialEmployeeUsageResponse result = apiInstance.ListSpatialEmployeeUsage(since, until, sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialEmployeeUsage: " + e.Message );
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
 **since** | **string**|  | [optional] 
 **until** | **string**|  | [optional] 
 **sceneId** | **Guid?**|  | [optional] 

### Return type

**ListSpatialEmployeeUsageResponse**

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

<a name="listspatialmoments"></a>
# **ListSpatialMoments**
> ListSpatialMomentsResponse ListSpatialMoments (int? limit = null, string ready = null)

Your moment emotes, newest first: unbox (a Crossly purchase delivered), slab_flip (a card graded through Crossly Grading), handshake (a trade-table shake settled). Each plays once in a room; playedAt is null until then. ready=true lists only the unplayed ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialMomentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var limit = 56;  // int? |  (optional) 
            var ready = "true";  // string |  (optional) 

            try
            {
                // Your moment emotes, newest first: unbox (a Crossly purchase delivered), slab_flip (a card graded through Crossly Grading), handshake (a trade-table shake settled). Each plays once in a room; playedAt is null until then. ready=true lists only the unplayed ones.
                ListSpatialMomentsResponse result = apiInstance.ListSpatialMoments(limit, ready);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialMoments: " + e.Message );
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
 **limit** | **int?**|  | [optional] 
 **ready** | **string**|  | [optional] 

### Return type

**ListSpatialMomentsResponse**

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

<a name="listspatialpartywishlist"></a>
# **ListSpatialPartyWishlist**
> CreateWorldPartyWishlistResponse ListSpatialPartyWishlist ()

Your party's shared wishlist, newest first: each listing (title, price in cents, image, shop slug while it is live), who added it, and every member's thumb up or down with the totals. Empty when you are in no party.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialPartyWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your party's shared wishlist, newest first: each listing (title, price in cents, image, shop slug while it is live), who added it, and every member's thumb up or down with the totals. Empty when you are in no party.
                CreateWorldPartyWishlistResponse result = apiInstance.ListSpatialPartyWishlist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialPartyWishlist: " + e.Message );
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

**CreateWorldPartyWishlistResponse**

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

<a name="listspatialpublic"></a>
# **ListSpatialPublic**
> ListSpatialPublicResponse ListSpatialPublic ()

Public rooms anyone can walk into.

The directory behind world-hopping. A room becomes public when its owner shares it; this lists those, newest first, with enough to draw a doorway AND enough to choose one — name, slug, category, itemCount, up to four previewImages, forSaleCount, a priceFromCents/priceToCents band and updatedAt. The band is the cheapest and dearest thing for sale in the room, never a quote for one object: /api/public/spatial/{slug}/offers is the authority on that. Fetch the room itself from /api/public/spatial/{slug}. Rooms with no items are omitted: an empty room is not a destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialPublicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Public rooms anyone can walk into.
                ListSpatialPublicResponse result = apiInstance.ListSpatialPublic();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialPublic: " + e.Message );
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

**ListSpatialPublicResponse**

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

<a name="listspatialpublicoffers"></a>
# **ListSpatialPublicOffers**
> ListSpatialPublicOffersResponse ListSpatialPublicOffers (string slug)

What is for sale in a shared room.

Price, stock, condition and grade for everything in the room its owner is actually selling. Correlate to the room by `itemId`, which is the SAME id the scene payload publishes per item — never by title. An item in the room with no row here is not for sale; an empty array means the owner is showing the collection rather than selling it, which is a different answer from a 404 (no such shared room). SEPARATE CALL ON PURPOSE: the room's geometry is stable for minutes, a price is not — it changes whenever the seller edits a listing. Re-read this before quoting, and do not cache a price alongside a cached room. `priceCents` is CENTS. `available` is remaining stock, or null when the listing declares none; null is unknown, not zero. Where an item sits inside more than one active listing, the offer quoted is the one for that item alone rather than a bundle it belongs to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialPublicOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // What is for sale in a shared room.
                ListSpatialPublicOffersResponse result = apiInstance.ListSpatialPublicOffers(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialPublicOffers: " + e.Message );
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

**ListSpatialPublicOffersResponse**

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

<a name="listspatialscenemovements"></a>
# **ListSpatialSceneMovements**
> ListSpatialSceneMovementsResponse ListSpatialSceneMovements (string id)

Stock movements in a room over a time window.

One row per physical transition: which item, from which node, to which node, when, and of what kind (placed/moved/picked/shipped/received/removed). Nodes are referenced by id; the `fromCode`/`toCode` strings are display snapshots of the location code AT THE TIME and are not stable identifiers — correlate on the node ids. `since`/`until` are ISO timestamps, defaulting to the last seven days and clamped to 90. Movements are NOT attributed to individual team members on this surface: a token has no team role, so there is no honest way to decide whether its holder may see who did the work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialSceneMovementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Stock movements in a room over a time window.
                ListSpatialSceneMovementsResponse result = apiInstance.ListSpatialSceneMovements(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialSceneMovements: " + e.Message );
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

**ListSpatialSceneMovementsResponse**

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

<a name="listspatialscenes"></a>
# **ListSpatialScenes**
> ListSpatialScenesResponse ListSpatialScenes ()

The rooms this account has.

The seller's ONE shop (kind `shop`, every display in one boutique) and their warehouse. Both are created on first read rather than requiring setup, so this call is safe to treat as the entry point. Older per-category rooms may also be listed as kind `collection`; they are no longer created or shown to visitors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialScenesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // The rooms this account has.
                ListSpatialScenesResponse result = apiInstance.ListSpatialScenes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialScenes: " + e.Message );
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

**ListSpatialScenesResponse**

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

<a name="listspatialshopaddresses"></a>
# **ListSpatialShopAddresses**
> ListSpatialShopAddressesResponse ListSpatialShopAddresses ()

Your shop's addresses.

One per street your shop stands on, Main Street first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialShopAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your shop's addresses.
                ListSpatialShopAddressesResponse result = apiInstance.ListSpatialShopAddresses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialShopAddresses: " + e.Message );
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

**ListSpatialShopAddressesResponse**

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

<a name="listspatialstaffing"></a>
# **ListSpatialStaffing**
> ListSpatialStaffingResponse ListSpatialStaffing ()

Shops you work in.

Each shop you hold a live staff grant on, with your wage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialStaffingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Shops you work in.
                ListSpatialStaffingResponse result = apiInstance.ListSpatialStaffing();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialStaffing: " + e.Message );
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

**ListSpatialStaffingResponse**

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

<a name="listspatialstreetmine"></a>
# **ListSpatialStreetMine**
> ListSpatialStreetMineResponse ListSpatialStreetMine ()

Your streets.

Streets you hold or asked to found, newest first: `status` (pending review, approved, founding, active, dormant, rejected, released), `upkeep` (active, grace, delinquent - - a delinquent owner collects no stall rent; three weeks late the street is foreclosed and closed), `paidThrough`, `admission`, `occupied` of `plotCount`, `pendingApplications`, and Crossly's `reviewNote`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialStreetMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Your streets.
                ListSpatialStreetMineResponse result = apiInstance.ListSpatialStreetMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialStreetMine: " + e.Message );
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

**ListSpatialStreetMineResponse**

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

<a name="listspatialstreets"></a>
# **ListSpatialStreets**
> ListSpatialStreetsResponse ListSpatialStreets ()

Every street in the world.

Active streets with `plotCount` and how many plots are `occupied`. `platform: true` is Crossly's own street (Main Street), where every public shop has a plot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialStreetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Every street in the world.
                ListSpatialStreetsResponse result = apiInstance.ListSpatialStreets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSpatialStreets: " + e.Message );
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

**ListSpatialStreetsResponse**

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

<a name="listworldblocks"></a>
# **ListWorldBlocks**
> ListWorldBlocksResponse ListWorldBlocks ()

The people you blocked in Crossly World, as you saw them (label, never the account behind a pseudonym), oldest first. Blocks are made in a room, on the person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // The people you blocked in Crossly World, as you saw them (label, never the account behind a pseudonym), oldest first. Blocks are made in a room, on the person.
                ListWorldBlocksResponse result = apiInstance.ListWorldBlocks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListWorldBlocks: " + e.Message );
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

**ListWorldBlocksResponse**

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

<a name="listworlditemsearch"></a>
# **ListWorldItemSearch**
> ListWorldItemSearchResponse ListWorldItemSearch (string q = null)

Find an item on a shelf anywhere in Crossly World: what public rooms have for sale now, by title or catalogue name (q, 2+ characters). Each hit names the room (roomSlug) and the item (itemId); /c/<roomSlug>?item=<itemId> opens it there.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldItemSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var q = "q_example";  // string |  (optional) 

            try
            {
                // Find an item on a shelf anywhere in Crossly World: what public rooms have for sale now, by title or catalogue name (q, 2+ characters). Each hit names the room (roomSlug) and the item (itemId); /c/<roomSlug>?item=<itemId> opens it there.
                ListWorldItemSearchResponse result = apiInstance.ListWorldItemSearch(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListWorldItemSearch: " + e.Message );
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

### Return type

**ListWorldItemSearchResponse**

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

<a name="listworldroomwants"></a>
# **ListWorldRoomWants**
> ListWorldRoomWantsResponse ListWorldRoomWants (Guid sceneId)

Items your room shows but does not sell that visitors said they would buy (\"I'd buy this\"), most wanted first: itemId and how many people.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldRoomWantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var sceneId = "sceneId_example";  // Guid | 

            try
            {
                // Items your room shows but does not sell that visitors said they would buy (\"I'd buy this\"), most wanted first: itemId and how many people.
                ListWorldRoomWantsResponse result = apiInstance.ListWorldRoomWants(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.ListWorldRoomWants: " + e.Message );
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
 **sceneId** | **Guid**|  | 

### Return type

**ListWorldRoomWantsResponse**

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

<a name="updateinventory"></a>
# **UpdateInventory**
> CreateInventoryResponse UpdateInventory (Guid id)

Update an inventory item (partial).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Update an inventory item (partial).
                CreateInventoryResponse result = apiInstance.UpdateInventory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.UpdateInventory: " + e.Message );
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

**CreateInventoryResponse**

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

<a name="updatespatialemployeeconfig"></a>
# **UpdateSpatialEmployeeConfig**
> UpdateSpatialEmployeeConfigResponse UpdateSpatialEmployeeConfig ()

Create or replace the shop employee in one of your rooms.

A full replace, not a patch: every field is written from this body, so read GET /api/v1/spatial/employee/config first and send it back changed. Owner-only — a room this account does not own answers 404, the same as one that does not exist. `brainKind` is idle (stands there), rules (`rules` evaluated in order, first match wins, max 12) or agent (your endpoint decides, and an endpoint URL is then required). A rule is `{ when, afterSeconds?, do: { act, line?, offerId?, itemId? } }`; `when` and `do.act` must come from the published vocabularies and anything else is a 400. NOTHING IN A RULE CARRIES A PRICE — `do.offerId` is a key into your own offers and the server prices it, so an employee can propose a discount it cannot grant. `displayName` and `do.line` must be printable ASCII: they are drawn in the room from a fixed glyph atlas and anything else renders as a floating box, so they are refused rather than silently rewritten. `agentEndpointUrl` is resolved and validated before it is stored — a public-looking hostname that answers with a private address is refused here rather than accepted and then never called. THE SIGNING SECRET IS RETURNED AT MOST ONCE, in the response that MINTS it: when you pass `rotateSecret: true`, or when you set an agent endpoint on a room that had no secret. Store it then — there is no read path that will ever return it again, and `hasAgentSecret` is all any GET will say. Send an Idempotency-Key if you might retry a rotation: without one, a retried rotate mints a SECOND secret and invalidates the one you just received. Saving anything also CLEARS a suspension — if the employee was paused for want of COSM it is back on the floor, and will be paused again by the next refused charge. Note what this endpoint cannot do: it cannot start a conversation. Engagements are emitted by the room as it is drawn, and they are what costs money.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialEmployeeConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);

            try
            {
                // Create or replace the shop employee in one of your rooms.
                UpdateSpatialEmployeeConfigResponse result = apiInstance.UpdateSpatialEmployeeConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.UpdateSpatialEmployeeConfig: " + e.Message );
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

**UpdateSpatialEmployeeConfigResponse**

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

<a name="updatespatialshopstaffwage"></a>
# **UpdateSpatialShopStaffWage**
> UpdateSpatialShopStaffWageResponse UpdateSpatialShopStaffWage (string grantId)

Set a staff member's weekly wage.

Body `{ wageWeeklyCents }` ($1-$2,000), or null to clear it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialShopStaffWageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InventoryApi(config);
            var grantId = "grantId_example";  // string | 

            try
            {
                // Set a staff member's weekly wage.
                UpdateSpatialShopStaffWageResponse result = apiInstance.UpdateSpatialShopStaffWage(grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryApi.UpdateSpatialShopStaffWage: " + e.Message );
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
 **grantId** | **string**|  | 

### Return type

**UpdateSpatialShopStaffWageResponse**

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

