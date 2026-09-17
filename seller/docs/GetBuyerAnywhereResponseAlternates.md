# net.crossly.Model.GetBuyerAnywhereResponseAlternates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** |  | 
**Host** | **string** | The retailer&#39;s hostname, e.g. &#x60;rei.com&#x60;. | 
**StoreName** | **string** |  | 
**Title** | **string** |  | 
**PriceCents** | **decimal** |  | 
**ShippingCents** | **decimal?** | Null &#x3D; UNKNOWN, never free. | [optional] 
**Currency** | **string** |  | 
**Condition** | **string** |  | [optional] 
**Url** | **string** |  | 
**ImageUrl** | **string** |  | [optional] 
**BuyerCashbackCents** | **decimal** | What the buyer gets back, in cents, if they buy through us.  Shown because a cashback figure the buyer cannot see is a figure they have no reason to believe. Derived from the store&#39;s rate, never stored per offer — rates change and a copied one goes stale silently. | 
**DeliveredCents** | **decimal** | Item + shipping when known; item alone otherwise. See &#x60;shippingUnknown&#x60;. | 
**ShippingUnknown** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

