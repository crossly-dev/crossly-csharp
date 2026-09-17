# net.crossly.buyer.Model.GetActionLogResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**CreatedAt** | **DateTime** |  | 
**UserId** | **string** |  | [optional] 
**Status** | **string** |  | 
**Source** | **string** |  | 
**Platform** | **string** |  | [optional] 
**Action** | **string** |  | 
**LatencyMs** | **decimal?** |  | [optional] 
**ErrorClass** | **string** |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**IpAddress** | **string** |  | [optional] 
**UserAgent** | **string** |  | [optional] 
**OauthAppId** | **string** |  | [optional] 
**Category** | **string** |  | 
**ActorUserId** | **string** |  | [optional] 
**FinishedAt** | **DateTime?** |  | [optional] 
**CorrelationId** | **string** |  | 
**Track** | **string** |  | [optional] 
**TargetType** | **string** |  | [optional] 
**TargetId** | **string** |  | [optional] 
**HttpStatus** | **decimal?** |  | [optional] 
**ActorEmail** | **string** | Resolved from actorUserId so the UI can say \&quot;Jane relisted this\&quot; rather than printing a UUID. Null for worker/system actions, which genuinely had no human actor. | [optional] 
**ActorDisplayName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

