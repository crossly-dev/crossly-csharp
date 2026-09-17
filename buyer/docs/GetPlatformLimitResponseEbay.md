# net.crossly.buyer.Model.GetPlatformLimitResponseEbay

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Platform** | **string** |  | 
**Used** | **decimal** |  | 
**Limit** | **decimal** |  | 
**Remaining** | **decimal** |  | 
**TierConfigured** | **bool** | False if the user hasn&#39;t picked a tier (we default to 250 but flag it so the UI can prompt). | 
**RespectQuota** | **bool** |  | 
**PeriodStart** | **string** |  | 
**PerOverageFeeUsd** | **decimal** | Approximate cost if &#x60;used&#x60; overflows &#x60;limit&#x60; — informational. | 
**SellingCap** | [**GetPlatformLimitResponseEbaySellingCap**](GetPlatformLimitResponseEbaySellingCap.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

