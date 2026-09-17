# net.crossly.buyer.Model.ListBuyerCatalogSearchItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Slug** | **string** |  | 
**Title** | **string** |  | 
**PriceCents** | **decimal** |  | 
**CompareAtCents** | **decimal?** | MSRP above the ask, or null. Never fabricated from a stale value. | [optional] 
**Currency** | **string** |  | 
**Condition** | **string** |  | [optional] 
**Brand** | **string** |  | [optional] 
**CategoryMain** | **string** |  | [optional] 
**CategorySub** | **string** |  | [optional] 
**Thumbnail** | **string** |  | [optional] 
**Images** | **List&lt;string&gt;** |  | 
**SellerUsername** | **string** |  | [optional] 
**SellerDisplayName** | **string** |  | [optional] 
**QuantityAvailable** | **decimal** | Units a buyer can actually take right now. Reserved units are excluded. | 
**ListedAt** | **string** |  | [optional] 
**Url** | **string** | Canonical buyer-facing URL, so a client never has to build one. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

