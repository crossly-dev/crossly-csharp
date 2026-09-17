# net.crossly.buyer.Model.CreateListingImportByUrlResponseListing

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlatformListingId** | **string** |  | 
**Title** | **string** |  | 
**Description** | **string** |  | [optional] 
**Price** | **decimal?** |  | [optional] 
**Images** | **List&lt;string&gt;** |  | [optional] 
**Brand** | **string** |  | [optional] 
**Condition** | **string** |  | [optional] 
**Size** | **string** |  | [optional] 
**Color** | **List&lt;string&gt;** | Color(s) the platform&#39;s own response exposes (e.g. Poshmark&#39;s  &#x60;colors&#x60; array). Only set when actually present in the scrape. | [optional] 
**Sku** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 
**Category** | **List&lt;string&gt;** | The platform&#39;s OWN category, as a top-down path (e.g. Poshmark&#39;s  [\&quot;Kids\&quot;, \&quot;Toys\&quot;, \&quot;Dolls &amp; Accessories\&quot;] from department → category →  feature). Only set when the platform&#39;s list/scrape response actually  carries this — never guessed. Mapped onto Crossly&#39;s category.main/  sub/sub2 (listings) or categoryMain/categorySub (inventory_items) at  create/enrich time. | [optional] 
**CategoryId** | **string** | The platform&#39;s raw numeric category id, same space as  overrides.&lt;platform&gt;.categoryId — distinct from &#x60;category&#x60;&#39;s  human-readable path. Only set by platforms whose id space is directly  comparable to what we publish (currently eBay&#39;s drift-check second  call — see diff-fields/second-call.ts&#39;s ebayRemoteFields). eBay&#39;s own  CategoryName wording/depth is a different vocabulary from Crossly&#39;s  master taxonomy breadcrumb and will essentially never string-match  it, so drift-detection compares ids instead of names. | [optional] 
**Tags** | **List&lt;string&gt;** | Tag-like strings the platform&#39;s own response exposes (e.g. Poshmark&#39;s  marketing \&quot;experience\&quot; tags). Distinct from a full search-tag  generator — just whatever real tag data the scrape already carries. | [optional] 
**Material** | **string** | Structured item aspects — the same shape the listing form&#39;s Item  Details section captures (and templates already persist), now sourced  from the platform&#39;s own data instead of only manual entry. Only set  when the platform&#39;s response genuinely carries a semantically-matching  field (eBay item specifics, Facebook attributes, Poshmark catalog,  Depop&#39;s detail-call ride-along) — never derived or guessed. | [optional] 
**Style** | **string** |  | [optional] 
**Pattern** | **string** |  | [optional] 
**Department** | **string** |  | [optional] 
**Gender** | **string** |  | [optional] 
**ItemType** | **string** |  | [optional] 
**SizeSystem** | **string** |  | [optional] 
**ItemSpecifics** | **Object** | Category-specific facets from a per-item DETAIL call (e.g. Facebook&#39;s  Age Range/Character/Age Group), keyed the same way eBay item-specifics  are: aspect name -&gt; value array. Only set by platforms with a genuine  per-item attribute source — costs one extra call per listing, so  populated by a dedicated enrichment pass, not the main list mapper.  Maps onto listings.itemSpecifics; inventory_items has no equivalent  column. | [optional] 
**ListedAt** | **DateTime?** | When the listing was first published on the platform. Used by  the Advanced filter&#39;s listedAfter / listedBefore knobs. Optional  because not every platform returns it on the listing endpoint. | [optional] 
**Quantity** | **decimal?** | Units this platform reports. Only meaningful for platforms  &#x60;PLATFORM_QUANTITY_SYNC&#x60; marks &#39;native&#39; — relist platforms show one item  and say 1 forever, so they leave this undefined rather than voting with  a number they cannot actually express. See &#x60;_quantity.ts&#x60;. | [optional] 
**AccountSlot** | **decimal?** | Which of the user&#39;s connected accounts on this platform this listing  was scraped from — stamped by fetchCookieListings as it loops each  connected account (see listActiveForPlatform in  user-platform-accounts/read.ts). Undefined for API-track platforms  (single connection, no multi-account concept) and for any cookie path  that hasn&#39;t been threaded yet; importOne treats undefined as slot 1,  matching the historical single-account default. | [optional] 
**WeightOz** | **decimal?** | Total item weight in ounces (already summed, not split lb+oz —  the write path converts to the DB&#39;s weightLb+weightOz split). | [optional] 
**DimensionLIn** | **decimal?** |  | [optional] 
**DimensionWIn** | **decimal?** |  | [optional] 
**DimensionHIn** | **decimal?** |  | [optional] 
**HandlingTimeDays** | **decimal?** | Max days the platform&#39;s own listing commits to ship within (eBay&#39;s  DispatchTimeMax, Etsy&#39;s processing_max). | [optional] 
**BestOfferAutoAcceptCents** | **decimal?** |  | [optional] 
**BestOfferAutoDeclineCents** | **decimal?** |  | [optional] 
**ItemLocation** | **string** | Free text as the platform itself expresses it (e.g. eBay&#39;s &#x60;Location&#x60;  is a single seller-typed string like \&quot;Austin, TX\&quot;, not a structured  address) — never parsed into city/state. | [optional] 
**ItemLocationZip** | **string** |  | [optional] 
**ItemLocationCountry** | **string** |  | [optional] 
**DeclaredShippingCost** | **decimal?** | What the platform&#39;s OWN listing declares shipping costs — reference  only, distinct from a realized post-sale shipping cost. | [optional] 
**ReturnPolicyText** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

