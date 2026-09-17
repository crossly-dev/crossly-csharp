# net.crossly.buyer.Model.ListSpatialPublicItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**PublicSlug** | **string** |  | 
**CategorySlug** | **string** |  | 
**ItemCount** | **decimal** | Unsold stock that lands in this room. The same predicate the room uses. | 
**ForSaleCount** | **decimal** | How many of those a visitor could buy right now. | 
**PriceFromCents** | **decimal?** | The cheapest and dearest thing for sale, in cents.  A BAND, deliberately, and never a quote: &#x60;listPublicSceneOffers&#x60; is the only authority on what a given object costs. Null when nothing is for sale — zero would read as free. | [optional] 
**PriceToCents** | **decimal?** |  | [optional] 
**PreviewImages** | **List&lt;string&gt;** | Up to PREVIEW_IMAGES item images. Catalog art first, seller photo else. | 
**UpdatedAt** | **string** | Last time the room itself changed. ISO, or null if the row has no date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

