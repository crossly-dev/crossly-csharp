# net.crossly.Model.GetConnectionHealthResponseLiveness

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastBrowserPushAt** | **string** | The clean \&quot;the browser pushed cookies\&quot; signal. | [optional] 
**LastBrowserPushAgo** | **string** |  | 
**LastSyncedAt** | **string** | Also stamped by the executor on any successful server-side call, so it is NOT evidence the extension is alive. Exposed for debugging only. | [optional] 
**LastUsedAt** | **string** | Last server-exec attempt, success or fail. | [optional] 
**LastUsedAgo** | **string** |  | 
**AuthFailureStreak** | **decimal** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

