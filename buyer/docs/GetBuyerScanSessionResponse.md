# net.crossly.buyer.Model.GetBuyerScanSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Device** | **string** |  | 
**Label** | **string** |  | [optional] 
**StartedAt** | **string** |  | 
**EndedAt** | **string** |  | [optional] 
**Live** | **bool** |  | 
**CaptureCount** | **decimal** |  | 
**SavedCents** | **decimal** | Sum of measured savings. Unmeasured captures contribute 0, not null. | 
**Captures** | [**List&lt;GetBuyerScanSessionResponseCaptures&gt;**](GetBuyerScanSessionResponseCaptures.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

