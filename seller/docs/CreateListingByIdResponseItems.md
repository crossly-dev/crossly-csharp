# net.crossly.Model.CreateListingByIdResponseItems

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveTitle** | **string** |  | 
**EffectivePrice** | **string** |  | [optional] 
**EffectiveDescription** | **string** |  | [optional] 
**EffectiveImages** | **List&lt;string&gt;** |  | 
**EffectiveBrand** | **string** |  | [optional] 
**EffectiveCondition** | **string** |  | [optional] 
**EffectiveSize** | **string** |  | [optional] 
**EffectiveSku** | **string** |  | [optional] 
**EffectiveColor** | **List&lt;string&gt;** |  | 
**EffectiveTags** | **List&lt;string&gt;** |  | 
**PlatformListings** | **List&lt;Object&gt;** |  | 
**InventoryItemId** | **string** |  | [optional] 
**Id** | **string** |  | 
**UserId** | **string** |  | 
**Name** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**DescriptionHtml** | **string** |  | [optional] 
**Price** | **string** |  | [optional] 
**Images** | **List&lt;string&gt;** |  | [optional] 
**VideoUrl** | **string** | Optional single product video (R2/CDN URL). Shown on the Crossly buyer page. | [optional] 
**Status** | **string** |  | 
**Condition** | **string** |  | [optional] 
**GradeKey** | **string** | Third-party grading, when the item is slabbed. Migration 0277.    Separate from &#x60;condition&#x60; on purpose and never derived from it: a grade  is a claim about what a GRADING COMPANY certified, and inferring \&quot;PSA 10\&quot;  from a coarse condition would be a false authenticity claim. It is also  never filled from our own AI estimate (&#x60;bulk_market_items.grade&#x60;), which  carries an explicit \&quot;not a professional grade\&quot; disclaimer.    &#x60;gradeKey&#x60; is the canonical form from &#x60;gradeKey()&#x60; in  shared/constants/graders.ts; &#x60;grading&#x60; holds the full GradingInfo  including the cert number and whether a cert lookup verified it. | [optional] 
**Grading** | [**ListListingsItemGrading**](ListListingsItemGrading.md) |  | [optional] 
**Brand** | **string** |  | [optional] 
**Size** | **string** |  | [optional] 
**Material** | **string** | Migration 0179 — see the matching fields on inventory_items above. | [optional] 
**Style** | **string** |  | [optional] 
**Pattern** | **string** |  | [optional] 
**Department** | **string** |  | [optional] 
**Gender** | **string** |  | [optional] 
**ItemType** | **string** |  | [optional] 
**SizeSystem** | **string** |  | [optional] 
**Color** | **List&lt;string&gt;** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**Sku** | **string** |  | [optional] 
**Quantity** | **decimal** |  | 
**QuantityAvailable** | **decimal** |  | 
**WeightLb** | **string** |  | [optional] 
**WeightOz** | **string** |  | [optional] 
**DimensionLIn** | **string** |  | [optional] 
**DimensionWIn** | **string** |  | [optional] 
**DimensionHIn** | **string** |  | [optional] 
**PublishAt** | **DateTime?** | Scheduled go-live time. When set on a draft, the listing-scheduler  worker waits until this passes then dispatches the crosspost to  scheduledPlatforms and flips status from &#39;draft&#39; to &#39;active&#39;. | [optional] 
**ScheduledPlatforms** | **List&lt;string&gt;** | Which platforms to publish to when publishAt fires. JSON array of  platform ids. Null/empty &#x3D; scheduler skips (listing won&#39;t auto-  publish, even after publishAt — gives the seller an escape hatch). | [optional] 
**ParentListingId** | **string** | Parent listing when this row is a CHILD in a listing chain. Null &#x3D;  standalone. What being a child means depends on the parent&#39;s  &#x60;groupKind&#x60; — see it. | [optional] 
**IsBundle** | **bool** |  | 
**AutomationAssignedRuleIds** | **List&lt;string&gt;** | Per-listing automation overrides. See migration 0098.     automationAssignedRuleIds  — force-include for these rules   automationBlockedRuleIds   — exempt from these rules   automationAssignedChainIds — force-include for these workflow chains   automationBlockedChainIds  — exempt from these workflow chains | 
**AutomationBlockedRuleIds** | **List&lt;string&gt;** |  | 
**AutomationAssignedChainIds** | **List&lt;string&gt;** |  | 
**AutomationBlockedChainIds** | **List&lt;string&gt;** |  | 
**HsCode** | **string** | Harmonised System customs code — international shipping declarations. | [optional] 
**CountryOfOrigin** | **string** | Customs country of origin. Distinct from the seller&#39;s location. | [optional] 
**PriceFloorCents** | **decimal?** | Never let a repricing rule go below this. On the ITEM because it is a  fact about the thing owned, not about any one rule — \&quot;this jacket never  goes below $45\&quot; should apply to every rule, and before this it was  expressible only as one rule per jacket. Listings inherit when null. | [optional] 
**FloorIsNet** | **bool** | When true the floor is a TAKE-HOME target, converted to a per-platform  gross at reprice time. A gross floor is four different promises across  four platforms; this is the one number a seller actually cares about. | 
**DelistedAt** | **DateTime?** |  | [optional] 
**SoldAt** | **DateTime?** |  | [optional] 
**Source** | **string** | Mirrors inventory_items.source. &#39;manual&#39; for every seller-created  listing; external-stub.ts sets &#39;external_sale&#39; on the synthetic  listing it fabricates for a sale detected on a platform id Crossly  never listed — those rows have no real photos/description of their  own (everything is lifted from the platform&#39;s sale payload) and are  otherwise indistinguishable from a real listing in the UI. | 
**DuplicateOfListingId** | **string** | Set when import&#39;s bin-packing (see _import-one.ts) created THIS  listing to hold a same-platform straggler it couldn&#39;t fit onto an  existing candidate listing for the same physical item — points at  the primary/first candidate. Purely informational: this listing  is a real, independently listable/delistable row, not a shadow.  Null for every ordinarily-created listing. | [optional] 
**ClientDraftId** | **string** | UUID minted on a seller&#39;s machine for a draft written offline.    The idempotency key for desktop sync. The failure it guards is a POST  that succeeds server-side whose reply is lost — the client cannot tell  that from a failure, retries, and one item becomes two live listings  against one piece of stock. Unique per user (partial index, migration  0268); null for every listing that did not come from an offline draft. | [optional] 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

