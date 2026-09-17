# net.crossly.Model.CreateBuyerCartQuoteResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** |  | 
**TaxCents** | **decimal** |  | 
**ShippingCents** | **decimal** |  | 
**TotalCents** | **decimal** |  | 
**Currency** | **string** |  | 
**ItemsTotalCents** | **decimal** |  | 
**PickupCartItemIds** | **List&lt;string&gt;** | Lines being collected in person, so a summary can name what ships free. | 
**TaxComplete** | **bool** | False means there is no saved delivery address, so &#x60;taxCents&#x60; is a floor rather than a final figure — not that tax is zero. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

