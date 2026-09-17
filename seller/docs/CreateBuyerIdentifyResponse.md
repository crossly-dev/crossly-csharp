# net.crossly.Model.CreateBuyerIdentifyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier** | **string** |  | 
**Confidence** | **decimal** |  | 
**Identifier** | [**CreateBuyerIdentifyResponseIdentifier**](CreateBuyerIdentifyResponseIdentifier.md) |  | [optional] 
**VisionLabel** | **string** |  | [optional] 
**VisionQuotaExhausted** | **bool** | Surfaced rather than hidden: \&quot;we could not look harder\&quot; and \&quot;we looked and found nothing\&quot; are different answers, and a client that cannot tell them apart shows the wrong message on both. | 
**VisualMatches** | [**List&lt;CreateBuyerIdentifyResponseVisualMatches&gt;**](CreateBuyerIdentifyResponseVisualMatches.md) |  | 
**Verdict** | **string** |  | 
**Crossly** | [**GetBuyerAnywhereResponseCrossly**](GetBuyerAnywhereResponseCrossly.md) |  | [optional] 
**Offsite** | [**GetBuyerAnywhereResponseOffsite**](GetBuyerAnywhereResponseOffsite.md) |  | [optional] 
**Alternates** | [**List&lt;GetBuyerAnywhereResponseAlternates&gt;**](GetBuyerAnywhereResponseAlternates.md) |  | 
**SavingCents** | **decimal?** |  | [optional] 
**ShippingUnknown** | **bool** |  | 
**Hud** | [**CreateBuyerIdentifyResponseHud**](CreateBuyerIdentifyResponseHud.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

