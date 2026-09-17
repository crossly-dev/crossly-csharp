# net.crossly.Model.CreateMagicScanResponseEbayHits

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** |  | 
**LegacyItemId** | **string** |  | [optional] 
**Title** | **string** |  | 
**Brand** | **string** |  | [optional] 
**PriceCents** | **decimal?** | Normalized cents. eBay returns string + currency on &#x60;price.value&#x60;. | [optional] 
**Currency** | **string** |  | [optional] 
**Condition** | **string** |  | [optional] 
**CategoryId** | **string** | Top-level category eBay assigned to the match (id + path). | [optional] 
**CategoryPath** | **string** |  | [optional] 
**ItemUrl** | **string** |  | 
**ThumbnailUrl** | **string** |  | [optional] 
**Aspects** | **Object** | Loosely-typed aspect bag — Brand, Color, Material, etc. when eBay inlines them. Always inspected defensively by the synthesizer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

