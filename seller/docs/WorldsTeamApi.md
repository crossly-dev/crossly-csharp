# net.crossly.Api.WorldsTeamApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorldCollaborationAccept**](WorldsTeamApi.md#createworldcollaborationaccept) | **POST** /v1/worlds/collaborations/{experienceId}/accept | Accept an invitation.
[**CreateWorldCollaborationDecline**](WorldsTeamApi.md#createworldcollaborationdecline) | **POST** /v1/worlds/collaborations/{experienceId}/decline | Decline an invitation.
[**CreateWorldExperienceActivityRevert**](WorldsTeamApi.md#createworldexperienceactivityrevert) | **POST** /v1/worlds/experiences/{experienceId}/activity/{activityId}/revert | Revert an instance change: its undo is applied as a new edit by you; anything changed since by others is left alone.
[**CreateWorldExperienceCollaborator**](WorldsTeamApi.md#createworldexperiencecollaborator) | **POST** /v1/worlds/experiences/{experienceId}/collaborators | Invite a Crossly handle with a role. Owner or admin; only the owner makes admins. Counts against the owner&#39;s plan cap.
[**CreateWorldExperiencePlaceCollabOp**](WorldsTeamApi.md#createworldexperienceplacecollabop) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/ops | Apply a batch of ops (insert, delete, move, prop, attr, name, tags, world) in server order. Each op is checked against your role; a retried batch id is answered, not re-applied.
[**CreateWorldExperiencePlaceCollabSave**](WorldsTeamApi.md#createworldexperienceplacecollabsave) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/save | Write the session into the place draft now (publishing and cloud tests do this themselves).
[**CreateWorldExperiencePlaceCollabScriptCommit**](WorldsTeamApi.md#createworldexperienceplacecollabscriptcommit) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/scripts/{nodeId}/commit | Commit your draft with a three-way merge. 409 merge_conflict carries the merged text with conflict blocks and the current source.
[**DeleteWorldExperienceCollaborator**](WorldsTeamApi.md#deleteworldexperiencecollaborator) | **DELETE** /v1/worlds/experiences/{experienceId}/collaborators/{userId} | Remove a collaborator, or leave (your own user id). Their revenue share returns to the owner from next month.
[**DeleteWorldExperiencePlaceCollabScript**](WorldsTeamApi.md#deleteworldexperienceplacecollabscript) | **DELETE** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/scripts/{nodeId} | Discard your draft of a script.
[**GetWorldExperiencePlaceCollab**](WorldsTeamApi.md#getworldexperienceplacecollab) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab | The live co-editing document of a place (node ids every editor shares), its op sequence and your role.
[**GetWorldExperiencePlaceCollabOp**](WorldsTeamApi.md#getworldexperienceplacecollabop) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/ops | Ops after a sequence number, grouped by batch. 409 resync when they are no longer kept: reload the session.
[**GetWorldExperienceSplit**](WorldsTeamApi.md#getworldexperiencesplit) | **GET** /v1/worlds/experiences/{experienceId}/splits | Revenue split of the creator share: current, scheduled, history.
[**GetWorldExperienceTeam**](WorldsTeamApi.md#getworldexperienceteam) | **GET** /v1/worlds/experiences/{experienceId}/team | The team: owner, collaborators with roles (owner, admin, editor, scripter, builder, tester, analyst), your role and permissions, the plan cap.
[**ListWorldCollaborations**](WorldsTeamApi.md#listworldcollaborations) | **GET** /v1/worlds/collaborations | Experiences you are invited to or work on, with your role.
[**ListWorldExperienceActivity**](WorldsTeamApi.md#listworldexperienceactivity) | **GET** /v1/worlds/experiences/{experienceId}/activity | Activity history, newest first: who changed what, when, from where (studio, api, mcp, cli); instance changes are revertible.
[**ListWorldExperiencePlaceCollabScripts**](WorldsTeamApi.md#listworldexperienceplacecollabscripts) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/scripts | Your script drafts in this place, with whether someone committed since you started.
[**UpdateWorldExperienceCollaborator**](WorldsTeamApi.md#updateworldexperiencecollaborator) | **PATCH** /v1/worlds/experiences/{experienceId}/collaborators/{userId} | Change a collaborator&#39;s role.
[**UpdateWorldExperiencePlaceCollabScript**](WorldsTeamApi.md#updateworldexperienceplacecollabscript) | **PUT** /v1/worlds/experiences/{experienceId}/places/{placeId}/collab/scripts/{nodeId} | Save your own draft of a script (needs edit scripts).
[**UpdateWorldExperienceSplit**](WorldsTeamApi.md#updateworldexperiencesplit) | **PUT** /v1/worlds/experiences/{experienceId}/splits | Owner only: split the creator share (70% of net) in basis points summing to 10000. Takes effect the 1st of next month; every party is notified. The 70% total never changes.


<a name="createworldcollaborationaccept"></a>
# **CreateWorldCollaborationAccept**
> CreateWorldCollaborationAcceptResponse CreateWorldCollaborationAccept (string experienceId)

Accept an invitation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCollaborationAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Accept an invitation.
                CreateWorldCollaborationAcceptResponse result = apiInstance.CreateWorldCollaborationAccept(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldCollaborationAccept: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**CreateWorldCollaborationAcceptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldcollaborationdecline"></a>
# **CreateWorldCollaborationDecline**
> CreateWorldCollaborationDeclineResponse CreateWorldCollaborationDecline (string experienceId)

Decline an invitation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCollaborationDeclineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Decline an invitation.
                CreateWorldCollaborationDeclineResponse result = apiInstance.CreateWorldCollaborationDecline(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldCollaborationDecline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**CreateWorldCollaborationDeclineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldexperienceactivityrevert"></a>
# **CreateWorldExperienceActivityRevert**
> CreateWorldExperienceActivityRevertResponse CreateWorldExperienceActivityRevert (string experienceId, string activityId)

Revert an instance change: its undo is applied as a new edit by you; anything changed since by others is left alone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceActivityRevertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var activityId = "activityId_example";  // string | 

            try
            {
                // Revert an instance change: its undo is applied as a new edit by you; anything changed since by others is left alone.
                CreateWorldExperienceActivityRevertResponse result = apiInstance.CreateWorldExperienceActivityRevert(experienceId, activityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldExperienceActivityRevert: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **activityId** | **string**|  | 

### Return type

**CreateWorldExperienceActivityRevertResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldexperiencecollaborator"></a>
# **CreateWorldExperienceCollaborator**
> CreateWorldExperienceCollaboratorResponse CreateWorldExperienceCollaborator (string experienceId)

Invite a Crossly handle with a role. Owner or admin; only the owner makes admins. Counts against the owner's plan cap.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceCollaboratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Invite a Crossly handle with a role. Owner or admin; only the owner makes admins. Counts against the owner's plan cap.
                CreateWorldExperienceCollaboratorResponse result = apiInstance.CreateWorldExperienceCollaborator(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldExperienceCollaborator: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**CreateWorldExperienceCollaboratorResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldexperienceplacecollabop"></a>
# **CreateWorldExperiencePlaceCollabOp**
> CreateWorldExperiencePlaceCollabOpResponse CreateWorldExperiencePlaceCollabOp (string experienceId, string placeId)

Apply a batch of ops (insert, delete, move, prop, attr, name, tags, world) in server order. Each op is checked against your role; a retried batch id is answered, not re-applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceCollabOpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Apply a batch of ops (insert, delete, move, prop, attr, name, tags, world) in server order. Each op is checked against your role; a retried batch id is answered, not re-applied.
                CreateWorldExperiencePlaceCollabOpResponse result = apiInstance.CreateWorldExperiencePlaceCollabOp(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldExperiencePlaceCollabOp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 

### Return type

**CreateWorldExperiencePlaceCollabOpResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldexperienceplacecollabsave"></a>
# **CreateWorldExperiencePlaceCollabSave**
> CreateWorldExperiencePlaceCollabSaveResponse CreateWorldExperiencePlaceCollabSave (string experienceId, string placeId)

Write the session into the place draft now (publishing and cloud tests do this themselves).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceCollabSaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Write the session into the place draft now (publishing and cloud tests do this themselves).
                CreateWorldExperiencePlaceCollabSaveResponse result = apiInstance.CreateWorldExperiencePlaceCollabSave(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldExperiencePlaceCollabSave: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 

### Return type

**CreateWorldExperiencePlaceCollabSaveResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldexperienceplacecollabscriptcommit"></a>
# **CreateWorldExperiencePlaceCollabScriptCommit**
> CreateWorldExperiencePlaceCollabScriptCommitResponse CreateWorldExperiencePlaceCollabScriptCommit (string experienceId, string placeId, string nodeId)

Commit your draft with a three-way merge. 409 merge_conflict carries the merged text with conflict blocks and the current source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceCollabScriptCommitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var nodeId = "nodeId_example";  // string | 

            try
            {
                // Commit your draft with a three-way merge. 409 merge_conflict carries the merged text with conflict blocks and the current source.
                CreateWorldExperiencePlaceCollabScriptCommitResponse result = apiInstance.CreateWorldExperiencePlaceCollabScriptCommit(experienceId, placeId, nodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.CreateWorldExperiencePlaceCollabScriptCommit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 
 **nodeId** | **string**|  | 

### Return type

**CreateWorldExperiencePlaceCollabScriptCommitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldexperiencecollaborator"></a>
# **DeleteWorldExperienceCollaborator**
> DeleteSpatialSceneGrantResponse DeleteWorldExperienceCollaborator (string experienceId, string userId)

Remove a collaborator, or leave (your own user id). Their revenue share returns to the owner from next month.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceCollaboratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Remove a collaborator, or leave (your own user id). Their revenue share returns to the owner from next month.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteWorldExperienceCollaborator(experienceId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.DeleteWorldExperienceCollaborator: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

**DeleteSpatialSceneGrantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldexperienceplacecollabscript"></a>
# **DeleteWorldExperiencePlaceCollabScript**
> DeleteWorldExperiencePlaceCollabScriptResponse DeleteWorldExperiencePlaceCollabScript (string experienceId, string placeId, string nodeId)

Discard your draft of a script.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperiencePlaceCollabScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var nodeId = "nodeId_example";  // string | 

            try
            {
                // Discard your draft of a script.
                DeleteWorldExperiencePlaceCollabScriptResponse result = apiInstance.DeleteWorldExperiencePlaceCollabScript(experienceId, placeId, nodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.DeleteWorldExperiencePlaceCollabScript: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 
 **nodeId** | **string**|  | 

### Return type

**DeleteWorldExperiencePlaceCollabScriptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldexperienceplacecollab"></a>
# **GetWorldExperiencePlaceCollab**
> GetWorldExperiencePlaceCollabResponse GetWorldExperiencePlaceCollab (string experienceId, string placeId)

The live co-editing document of a place (node ids every editor shares), its op sequence and your role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceCollabExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // The live co-editing document of a place (node ids every editor shares), its op sequence and your role.
                GetWorldExperiencePlaceCollabResponse result = apiInstance.GetWorldExperiencePlaceCollab(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.GetWorldExperiencePlaceCollab: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 

### Return type

**GetWorldExperiencePlaceCollabResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldexperienceplacecollabop"></a>
# **GetWorldExperiencePlaceCollabOp**
> GetWorldExperiencePlaceCollabOpResponse GetWorldExperiencePlaceCollabOp (string experienceId, string placeId)

Ops after a sequence number, grouped by batch. 409 resync when they are no longer kept: reload the session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceCollabOpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Ops after a sequence number, grouped by batch. 409 resync when they are no longer kept: reload the session.
                GetWorldExperiencePlaceCollabOpResponse result = apiInstance.GetWorldExperiencePlaceCollabOp(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.GetWorldExperiencePlaceCollabOp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 

### Return type

**GetWorldExperiencePlaceCollabOpResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldexperiencesplit"></a>
# **GetWorldExperienceSplit**
> GetWorldExperienceSplitResponse GetWorldExperienceSplit (string experienceId)

Revenue split of the creator share: current, scheduled, history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceSplitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Revenue split of the creator share: current, scheduled, history.
                GetWorldExperienceSplitResponse result = apiInstance.GetWorldExperienceSplit(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.GetWorldExperienceSplit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**GetWorldExperienceSplitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldexperienceteam"></a>
# **GetWorldExperienceTeam**
> GetWorldExperienceTeamResponse GetWorldExperienceTeam (string experienceId)

The team: owner, collaborators with roles (owner, admin, editor, scripter, builder, tester, analyst), your role and permissions, the plan cap.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // The team: owner, collaborators with roles (owner, admin, editor, scripter, builder, tester, analyst), your role and permissions, the plan cap.
                GetWorldExperienceTeamResponse result = apiInstance.GetWorldExperienceTeam(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.GetWorldExperienceTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**GetWorldExperienceTeamResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldcollaborations"></a>
# **ListWorldCollaborations**
> ListWorldCollaborationsResponse ListWorldCollaborations ()

Experiences you are invited to or work on, with your role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldCollaborationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);

            try
            {
                // Experiences you are invited to or work on, with your role.
                ListWorldCollaborationsResponse result = apiInstance.ListWorldCollaborations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.ListWorldCollaborations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListWorldCollaborationsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldexperienceactivity"></a>
# **ListWorldExperienceActivity**
> ListWorldExperienceActivityResponse ListWorldExperienceActivity (string experienceId)

Activity history, newest first: who changed what, when, from where (studio, api, mcp, cli); instance changes are revertible.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Activity history, newest first: who changed what, when, from where (studio, api, mcp, cli); instance changes are revertible.
                ListWorldExperienceActivityResponse result = apiInstance.ListWorldExperienceActivity(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.ListWorldExperienceActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**ListWorldExperienceActivityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldexperienceplacecollabscripts"></a>
# **ListWorldExperiencePlaceCollabScripts**
> ListWorldExperiencePlaceCollabScriptsResponse ListWorldExperiencePlaceCollabScripts (string experienceId, string placeId)

Your script drafts in this place, with whether someone committed since you started.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperiencePlaceCollabScriptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Your script drafts in this place, with whether someone committed since you started.
                ListWorldExperiencePlaceCollabScriptsResponse result = apiInstance.ListWorldExperiencePlaceCollabScripts(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.ListWorldExperiencePlaceCollabScripts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 

### Return type

**ListWorldExperiencePlaceCollabScriptsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldexperiencecollaborator"></a>
# **UpdateWorldExperienceCollaborator**
> CreateWorldExperienceCollaboratorResponse UpdateWorldExperienceCollaborator (string experienceId, string userId)

Change a collaborator's role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceCollaboratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Change a collaborator's role.
                CreateWorldExperienceCollaboratorResponse result = apiInstance.UpdateWorldExperienceCollaborator(experienceId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.UpdateWorldExperienceCollaborator: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

**CreateWorldExperienceCollaboratorResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldexperienceplacecollabscript"></a>
# **UpdateWorldExperiencePlaceCollabScript**
> UpdateWorldExperiencePlaceCollabScriptResponse UpdateWorldExperiencePlaceCollabScript (string experienceId, string placeId, string nodeId)

Save your own draft of a script (needs edit scripts).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperiencePlaceCollabScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var nodeId = "nodeId_example";  // string | 

            try
            {
                // Save your own draft of a script (needs edit scripts).
                UpdateWorldExperiencePlaceCollabScriptResponse result = apiInstance.UpdateWorldExperiencePlaceCollabScript(experienceId, placeId, nodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.UpdateWorldExperiencePlaceCollabScript: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 
 **placeId** | **string**|  | 
 **nodeId** | **string**|  | 

### Return type

**UpdateWorldExperiencePlaceCollabScriptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldexperiencesplit"></a>
# **UpdateWorldExperienceSplit**
> GetWorldExperienceSplitResponse UpdateWorldExperienceSplit (string experienceId)

Owner only: split the creator share (70% of net) in basis points summing to 10000. Takes effect the 1st of next month; every party is notified. The 70% total never changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceSplitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsTeamApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Owner only: split the creator share (70% of net) in basis points summing to 10000. Takes effect the 1st of next month; every party is notified. The 70% total never changes.
                GetWorldExperienceSplitResponse result = apiInstance.UpdateWorldExperienceSplit(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsTeamApi.UpdateWorldExperienceSplit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **experienceId** | **string**|  | 

### Return type

**GetWorldExperienceSplitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

