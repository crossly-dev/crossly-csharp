# net.crossly.Model.ListSourcingDemandMineItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierValue** | **string** |  | 
**Lookers** | **decimal** | How many distinct shoppers looked, in the window. | 
**Misses** | **decimal** | How many of those looks Crossly could not answer at all. | 
**MedianRetailCents** | **decimal?** | What the retailers were charging, median of what Scout saw. | [optional] 
**Relation** | **string** | &#39;in_stock&#39; — it is in their inventory. &#39;sold_before&#39; — they have sold one. | 
**InventoryItemId** | **string** | Their own row, for the link. | [optional] 
**Title** | **string** |  | [optional] 
**LastSoldCents** | **decimal?** | What they got for it last time, when they have sold one. | [optional] 
**LastSoldAt** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

