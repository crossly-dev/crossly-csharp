# net.crossly.Model.GetPlatformLimitResponseEbaySellingCap
eBay-imposed monthly selling cap (quantity + $$) fetched from Trading API GetMyeBaySelling. These are HARD blocks — past them, `publishOffer` returns an error. Distinct from the free-tier `limit` (which is just a fee threshold). Null when seller has no caps (established accounts) or the Trading call failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountLimit** | **decimal?** | Monthly $$ ceiling — null when seller has no $$ cap set. | [optional] 
**AmountUsed** | **decimal?** |  | [optional] 
**QuantityLimit** | **decimal?** | Monthly item-count ceiling — null when seller has no qty cap. | [optional] 
**QuantityUsed** | **decimal?** |  | [optional] 
**Currency** | **string** |  | 
**FetchedAt** | **string** | ISO timestamp this was fetched (used for cache freshness display). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

