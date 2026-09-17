# net.crossly.buyer.Model.CreateBuyerLockonConfirmResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockonId** | **string** |  | 
**Status** | **string** |  | 
**Identifier** | [**CreateBuyerIdentifyResponseIdentifier**](CreateBuyerIdentifyResponseIdentifier.md) |  | [optional] 
**Candidates** | [**List&lt;CreateBuyerLockonObserveResponseCandidates&gt;**](CreateBuyerLockonObserveResponseCandidates.md) | Present when we could not settle it alone. Show them; a pinch on one is the cheapest, strongest disambiguation available. | 
**ObservationCount** | **decimal** |  | 
**VisionCalls** | **decimal** |  | 
**VisionQuotaExhausted** | **bool** |  | 
**Verdict** | **string** |  | 
**Crossly** | [**GetBuyerAnywhereResponseCrossly**](GetBuyerAnywhereResponseCrossly.md) |  | [optional] 
**Offsite** | [**GetBuyerAnywhereResponseOffsite**](GetBuyerAnywhereResponseOffsite.md) |  | [optional] 
**Alternates** | [**List&lt;GetBuyerAnywhereResponseAlternates&gt;**](GetBuyerAnywhereResponseAlternates.md) |  | 
**SavingCents** | **decimal?** |  | [optional] 
**ShippingUnknown** | **bool** |  | 
**Hud** | [**CreateBuyerIdentifyResponseHud**](CreateBuyerIdentifyResponseHud.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

