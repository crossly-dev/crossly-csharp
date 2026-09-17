# net.crossly.buyer.Model.GetConnectionHealthResponseAccounts

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlatformName** | **string** |  | 
**AccountId** | **string** |  | [optional] 
**AccountSlot** | **decimal?** |  | [optional] 
**Label** | **string** |  | [optional] 
**PlatformUsername** | **string** |  | [optional] 
**Summary** | **string** | Plain-English \&quot;what is true\&quot; + \&quot;what to do\&quot;. Never empty. | 
**Action** | **string** |  | 
**Liveness** | [**GetConnectionHealthResponseLiveness**](GetConnectionHealthResponseLiveness.md) |  | 
**Browser** | [**GetConnectionHealthResponseBrowser**](GetConnectionHealthResponseBrowser.md) |  | [optional] 
**Platform** | **string** |  | 
**State** | **string** |  | 
**Severity** | **string** |  | 
**Audience** | **string** |  | 
**Anchors** | [**GetConnectionHealthResponseAnchors**](GetConnectionHealthResponseAnchors.md) |  | [optional] 
**Notes** | **List&lt;string&gt;** | Secondary observations that do not change the verdict but change the debugging. Always safe to show; never the only thing shown. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

