# net.crossly.Api.WorldsStudioApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorldExperienceAssetMesh**](WorldsStudioApi.md#createworldexperienceassetmesh) | **POST** /v1/worlds/experiences/{experienceId}/assets/meshes | Import a .glb (base64) as a MeshPart: safety parse + budgets, stored on the Crossly CDN, a phone LOD over 5k triangles, collision Box or convex Hull. Returns the asset and the MeshPart node; with placeId it is inserted into that place through its co-editing session.
[**CreateWorldExperienceAssetMeshCheck**](WorldsStudioApi.md#createworldexperienceassetmeshcheck) | **POST** /v1/worlds/experiences/{experienceId}/assets/meshes/check | Check a .glb (base64) for import without storing it: the budget report per device, plain-English errors with a fix list, whether a phone LOD will be made, mesh bounds and hull points.
[**CreateWorldExperiencePlaceAssistant**](WorldsStudioApi.md#createworldexperienceplaceassistant) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/assistant | Ask the Studio Assistant (mode explain | edit | build): returns an explanation and a proposed change set (scripts, inserts, edits) checked against your role and linted. Nothing is applied.
[**CreateWorldExperiencePlaceAssistantApply**](WorldsStudioApi.md#createworldexperienceplaceassistantapply) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/assistant/apply | Apply accepted Assistant changes to the place as one co-editing batch (activity via assistant, revertible). Re-checked against the place as it is now.
[**CreateWorldExperiencePlaceStudioEdit**](WorldsStudioApi.md#createworldexperienceplacestudioedit) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/edits | Apply set / insert / move / delete steps by path as ONE batch through Team Create (live in every open Studio, one revertible activity entry). All-or-nothing: any bad step refuses the batch with every problem listed.
[**CreateWorldExperiencePlaceStudioInsertAsset**](WorldsStudioApi.md#createworldexperienceplacestudioinsertasset) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/insert-asset | Insert a Toolbox asset under a path (default Workspace; ServerScripts for scripts). Paid assets need the experience owner&#39;s licence.
[**CreateWorldExperiencePlaceStudioPlaytest**](WorldsStudioApi.md#createworldexperienceplacestudioplaytest) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/playtest | Cloud test: flush the session, freeze a private test version and start a fleet server for it. 201 ready (ticket) or 202 starting; outputCursor reads only this test&#39;s Output.
[**CreateWorldExperiencePlaceStudioPlaytestStop**](WorldsStudioApi.md#createworldexperienceplacestudioplayteststop) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/playtest/stop | Stop this place&#39;s cloud-test servers now.
[**CreateWorldExperiencePlaceStudioPublish**](WorldsStudioApi.md#createworldexperienceplacestudiopublish) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/publish | Prepare a publish from the live session: checks, details, rating answers, access. Never submits and never acknowledges the money review — the person does (or submit_worlds_publish).
[**CreateWorldExperiencePlaceStudioScriptCommit**](WorldsStudioApi.md#createworldexperienceplacestudioscriptcommit) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/script/commit | Commit your draft with a three-way merge onto the script as it is now (collaborators&#39; edits kept). 409 merge_conflict carries merged text with conflict blocks and theirs.
[**DeleteWorldExperiencePlaceStudioScript**](WorldsStudioApi.md#deleteworldexperienceplacestudioscript) | **DELETE** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/script | Discard your draft of a script.
[**GetWorldAssistantStatus**](WorldsStudioApi.md#getworldassistantstatus) | **GET** /v1/worlds/assistant/status | Studio Assistant status: whether Crossly&#39;s model key is configured, whether you have your own AI key, and your plan allowance (asks left today, budget left this month).
[**GetWorldExperiencePlaceStudioFind**](WorldsStudioApi.md#getworldexperienceplacestudiofind) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/find | Find instances by name (contains), exact class and/or tag.
[**GetWorldExperiencePlaceStudioInstance**](WorldsStudioApi.md#getworldexperienceplacestudioinstance) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/instance | One instance by path (or session id): class, properties, attributes, tags, children. Script source is read with …/studio/script.
[**GetWorldExperiencePlaceStudioOutput**](WorldsStudioApi.md#getworldexperienceplacestudiooutput) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/output | Server Output (print, warnings, errors) after a cursor: every line of cloud tests, errors of live servers (scope&#x3D;all). Kept 24 hours.
[**GetWorldExperiencePlaceStudioProblem**](WorldsStudioApi.md#getworldexperienceplacestudioproblem) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/problems | The publish checks on the place as the live session holds it: script lint, budgets per device, settings, shop listings, Toolbox licences. publishable &#x3D; no errors.
[**GetWorldExperiencePlaceStudioScript**](WorldsStudioApi.md#getworldexperienceplacestudioscript) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/script | A script&#39;s current source, your draft of it (if any, with whether someone committed since) and the lint of each.
[**GetWorldExperiencePlaceStudioSnapshot**](WorldsStudioApi.md#getworldexperienceplacestudiosnapshot) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/snapshot | A plan (top) or front drawing of the parts under a path as SVG, with bounds, spawns and unanchored parts that will fall.
[**GetWorldExperiencePlaceStudioTree**](WorldsStudioApi.md#getworldexperienceplacestudiotree) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/tree | The live instance tree (what every open Studio shows) by dotted path, depth levels down (default 3, max 12).
[**GetWorldStudioClass**](WorldsStudioApi.md#getworldstudioclass) | **GET** /v1/worlds/studio/classes | The engine&#39;s class table: insertable classes, services, and for ?name&#x3D; one class with every property, its type, default and the exact JSON a place (and a studio edit) takes.
[**ListWorldExperienceAssets**](WorldsStudioApi.md#listworldexperienceassets) | **GET** /v1/worlds/experiences/{experienceId}/assets | Meshes imported into this experience, newest first: paths, phone LOD, bounds, hull size, budget report, moderation (pending until a reviewed publish uses them) and a URL you can load now.
[**UpdateWorldExperiencePlaceStudioScript**](WorldsStudioApi.md#updateworldexperienceplacestudioscript) | **PUT** /v1/worlds/experiences/{experienceId}/places/{placeId}/studio/script | Save your draft of a script (the place does not change until you commit). Returns lint and the diff from the current source.


<a name="createworldexperienceassetmesh"></a>
# **CreateWorldExperienceAssetMesh**
> CreateWorldExperienceAssetMeshResponse CreateWorldExperienceAssetMesh (string experienceId, CreateWorldExperienceAssetMeshRequest createWorldExperienceAssetMeshRequest = null)

Import a .glb (base64) as a MeshPart: safety parse + budgets, stored on the Crossly CDN, a phone LOD over 5k triangles, collision Box or convex Hull. Returns the asset and the MeshPart node; with placeId it is inserted into that place through its co-editing session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceAssetMeshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var createWorldExperienceAssetMeshRequest = new CreateWorldExperienceAssetMeshRequest(); // CreateWorldExperienceAssetMeshRequest |  (optional) 

            try
            {
                // Import a .glb (base64) as a MeshPart: safety parse + budgets, stored on the Crossly CDN, a phone LOD over 5k triangles, collision Box or convex Hull. Returns the asset and the MeshPart node; with placeId it is inserted into that place through its co-editing session.
                CreateWorldExperienceAssetMeshResponse result = apiInstance.CreateWorldExperienceAssetMesh(experienceId, createWorldExperienceAssetMeshRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperienceAssetMesh: " + e.Message );
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
 **createWorldExperienceAssetMeshRequest** | **CreateWorldExperienceAssetMeshRequest**|  | [optional] 

### Return type

**CreateWorldExperienceAssetMeshResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceassetmeshcheck"></a>
# **CreateWorldExperienceAssetMeshCheck**
> CreateWorldExperienceAssetMeshCheckResponse CreateWorldExperienceAssetMeshCheck (string experienceId, CreateWorldExperienceAssetMeshCheckRequest createWorldExperienceAssetMeshCheckRequest = null)

Check a .glb (base64) for import without storing it: the budget report per device, plain-English errors with a fix list, whether a phone LOD will be made, mesh bounds and hull points.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceAssetMeshCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var createWorldExperienceAssetMeshCheckRequest = new CreateWorldExperienceAssetMeshCheckRequest(); // CreateWorldExperienceAssetMeshCheckRequest |  (optional) 

            try
            {
                // Check a .glb (base64) for import without storing it: the budget report per device, plain-English errors with a fix list, whether a phone LOD will be made, mesh bounds and hull points.
                CreateWorldExperienceAssetMeshCheckResponse result = apiInstance.CreateWorldExperienceAssetMeshCheck(experienceId, createWorldExperienceAssetMeshCheckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperienceAssetMeshCheck: " + e.Message );
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
 **createWorldExperienceAssetMeshCheckRequest** | **CreateWorldExperienceAssetMeshCheckRequest**|  | [optional] 

### Return type

**CreateWorldExperienceAssetMeshCheckResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplaceassistant"></a>
# **CreateWorldExperiencePlaceAssistant**
> CreateWorldExperiencePlaceAssistantResponse CreateWorldExperiencePlaceAssistant (string experienceId, string placeId, CreateWorldExperiencePlaceAssistantRequest createWorldExperiencePlaceAssistantRequest = null)

Ask the Studio Assistant (mode explain | edit | build): returns an explanation and a proposed change set (scripts, inserts, edits) checked against your role and linted. Nothing is applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceAssistantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceAssistantRequest = new CreateWorldExperiencePlaceAssistantRequest(); // CreateWorldExperiencePlaceAssistantRequest |  (optional) 

            try
            {
                // Ask the Studio Assistant (mode explain | edit | build): returns an explanation and a proposed change set (scripts, inserts, edits) checked against your role and linted. Nothing is applied.
                CreateWorldExperiencePlaceAssistantResponse result = apiInstance.CreateWorldExperiencePlaceAssistant(experienceId, placeId, createWorldExperiencePlaceAssistantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceAssistant: " + e.Message );
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
 **createWorldExperiencePlaceAssistantRequest** | **CreateWorldExperiencePlaceAssistantRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceAssistantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplaceassistantapply"></a>
# **CreateWorldExperiencePlaceAssistantApply**
> CreateWorldExperiencePlaceAssistantApplyResponse CreateWorldExperiencePlaceAssistantApply (string experienceId, string placeId, CreateWorldExperiencePlaceAssistantApplyRequest createWorldExperiencePlaceAssistantApplyRequest = null)

Apply accepted Assistant changes to the place as one co-editing batch (activity via assistant, revertible). Re-checked against the place as it is now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceAssistantApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceAssistantApplyRequest = new CreateWorldExperiencePlaceAssistantApplyRequest(); // CreateWorldExperiencePlaceAssistantApplyRequest |  (optional) 

            try
            {
                // Apply accepted Assistant changes to the place as one co-editing batch (activity via assistant, revertible). Re-checked against the place as it is now.
                CreateWorldExperiencePlaceAssistantApplyResponse result = apiInstance.CreateWorldExperiencePlaceAssistantApply(experienceId, placeId, createWorldExperiencePlaceAssistantApplyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceAssistantApply: " + e.Message );
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
 **createWorldExperiencePlaceAssistantApplyRequest** | **CreateWorldExperiencePlaceAssistantApplyRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceAssistantApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplacestudioedit"></a>
# **CreateWorldExperiencePlaceStudioEdit**
> CreateWorldExperiencePlaceStudioEditResponse CreateWorldExperiencePlaceStudioEdit (string experienceId, string placeId, CreateWorldExperiencePlaceStudioEditRequest createWorldExperiencePlaceStudioEditRequest = null)

Apply set / insert / move / delete steps by path as ONE batch through Team Create (live in every open Studio, one revertible activity entry). All-or-nothing: any bad step refuses the batch with every problem listed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioEditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceStudioEditRequest = new CreateWorldExperiencePlaceStudioEditRequest(); // CreateWorldExperiencePlaceStudioEditRequest |  (optional) 

            try
            {
                // Apply set / insert / move / delete steps by path as ONE batch through Team Create (live in every open Studio, one revertible activity entry). All-or-nothing: any bad step refuses the batch with every problem listed.
                CreateWorldExperiencePlaceStudioEditResponse result = apiInstance.CreateWorldExperiencePlaceStudioEdit(experienceId, placeId, createWorldExperiencePlaceStudioEditRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioEdit: " + e.Message );
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
 **createWorldExperiencePlaceStudioEditRequest** | **CreateWorldExperiencePlaceStudioEditRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceStudioEditResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplacestudioinsertasset"></a>
# **CreateWorldExperiencePlaceStudioInsertAsset**
> CreateWorldExperiencePlaceStudioInsertAssetResponse CreateWorldExperiencePlaceStudioInsertAsset (string experienceId, string placeId, CreateWorldExperiencePlaceStudioInsertAssetRequest createWorldExperiencePlaceStudioInsertAssetRequest = null)

Insert a Toolbox asset under a path (default Workspace; ServerScripts for scripts). Paid assets need the experience owner's licence.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioInsertAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceStudioInsertAssetRequest = new CreateWorldExperiencePlaceStudioInsertAssetRequest(); // CreateWorldExperiencePlaceStudioInsertAssetRequest |  (optional) 

            try
            {
                // Insert a Toolbox asset under a path (default Workspace; ServerScripts for scripts). Paid assets need the experience owner's licence.
                CreateWorldExperiencePlaceStudioInsertAssetResponse result = apiInstance.CreateWorldExperiencePlaceStudioInsertAsset(experienceId, placeId, createWorldExperiencePlaceStudioInsertAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioInsertAsset: " + e.Message );
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
 **createWorldExperiencePlaceStudioInsertAssetRequest** | **CreateWorldExperiencePlaceStudioInsertAssetRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceStudioInsertAssetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplacestudioplaytest"></a>
# **CreateWorldExperiencePlaceStudioPlaytest**
> CreateWorldExperiencePlaceStudioPlaytestResponse CreateWorldExperiencePlaceStudioPlaytest (string experienceId, string placeId)

Cloud test: flush the session, freeze a private test version and start a fleet server for it. 201 ready (ticket) or 202 starting; outputCursor reads only this test's Output.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioPlaytestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Cloud test: flush the session, freeze a private test version and start a fleet server for it. 201 ready (ticket) or 202 starting; outputCursor reads only this test's Output.
                CreateWorldExperiencePlaceStudioPlaytestResponse result = apiInstance.CreateWorldExperiencePlaceStudioPlaytest(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioPlaytest: " + e.Message );
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

**CreateWorldExperiencePlaceStudioPlaytestResponse**

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

<a name="createworldexperienceplacestudioplayteststop"></a>
# **CreateWorldExperiencePlaceStudioPlaytestStop**
> CreateWorldExperiencePlaceStudioPlaytestStopResponse CreateWorldExperiencePlaceStudioPlaytestStop (string experienceId, string placeId)

Stop this place's cloud-test servers now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioPlaytestStopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Stop this place's cloud-test servers now.
                CreateWorldExperiencePlaceStudioPlaytestStopResponse result = apiInstance.CreateWorldExperiencePlaceStudioPlaytestStop(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioPlaytestStop: " + e.Message );
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

**CreateWorldExperiencePlaceStudioPlaytestStopResponse**

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

<a name="createworldexperienceplacestudiopublish"></a>
# **CreateWorldExperiencePlaceStudioPublish**
> CreateWorldExperiencePlaceStudioPublishResponse CreateWorldExperiencePlaceStudioPublish (string experienceId, string placeId, CreateWorldExperiencePlaceStudioPublishRequest createWorldExperiencePlaceStudioPublishRequest = null)

Prepare a publish from the live session: checks, details, rating answers, access. Never submits and never acknowledges the money review — the person does (or submit_worlds_publish).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioPublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceStudioPublishRequest = new CreateWorldExperiencePlaceStudioPublishRequest(); // CreateWorldExperiencePlaceStudioPublishRequest |  (optional) 

            try
            {
                // Prepare a publish from the live session: checks, details, rating answers, access. Never submits and never acknowledges the money review — the person does (or submit_worlds_publish).
                CreateWorldExperiencePlaceStudioPublishResponse result = apiInstance.CreateWorldExperiencePlaceStudioPublish(experienceId, placeId, createWorldExperiencePlaceStudioPublishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioPublish: " + e.Message );
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
 **createWorldExperiencePlaceStudioPublishRequest** | **CreateWorldExperiencePlaceStudioPublishRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceStudioPublishResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="createworldexperienceplacestudioscriptcommit"></a>
# **CreateWorldExperiencePlaceStudioScriptCommit**
> CreateWorldExperiencePlaceStudioScriptCommitResponse CreateWorldExperiencePlaceStudioScriptCommit (string experienceId, string placeId, CreateWorldExperiencePlaceStudioScriptCommitRequest createWorldExperiencePlaceStudioScriptCommitRequest = null)

Commit your draft with a three-way merge onto the script as it is now (collaborators' edits kept). 409 merge_conflict carries merged text with conflict blocks and theirs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlaceStudioScriptCommitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlaceStudioScriptCommitRequest = new CreateWorldExperiencePlaceStudioScriptCommitRequest(); // CreateWorldExperiencePlaceStudioScriptCommitRequest |  (optional) 

            try
            {
                // Commit your draft with a three-way merge onto the script as it is now (collaborators' edits kept). 409 merge_conflict carries merged text with conflict blocks and theirs.
                CreateWorldExperiencePlaceStudioScriptCommitResponse result = apiInstance.CreateWorldExperiencePlaceStudioScriptCommit(experienceId, placeId, createWorldExperiencePlaceStudioScriptCommitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.CreateWorldExperiencePlaceStudioScriptCommit: " + e.Message );
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
 **createWorldExperiencePlaceStudioScriptCommitRequest** | **CreateWorldExperiencePlaceStudioScriptCommitRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlaceStudioScriptCommitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="deleteworldexperienceplacestudioscript"></a>
# **DeleteWorldExperiencePlaceStudioScript**
> DeleteWorldExperiencePlaceCollabScriptResponse DeleteWorldExperiencePlaceStudioScript (string experienceId, string placeId, string path)

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
    public class DeleteWorldExperiencePlaceStudioScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var path = "path_example";  // string | 

            try
            {
                // Discard your draft of a script.
                DeleteWorldExperiencePlaceCollabScriptResponse result = apiInstance.DeleteWorldExperiencePlaceStudioScript(experienceId, placeId, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.DeleteWorldExperiencePlaceStudioScript: " + e.Message );
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
 **path** | **string**|  | 

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

<a name="getworldassistantstatus"></a>
# **GetWorldAssistantStatus**
> GetWorldAssistantStatusResponse GetWorldAssistantStatus ()

Studio Assistant status: whether Crossly's model key is configured, whether you have your own AI key, and your plan allowance (asks left today, budget left this month).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAssistantStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);

            try
            {
                // Studio Assistant status: whether Crossly's model key is configured, whether you have your own AI key, and your plan allowance (asks left today, budget left this month).
                GetWorldAssistantStatusResponse result = apiInstance.GetWorldAssistantStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldAssistantStatus: " + e.Message );
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

**GetWorldAssistantStatusResponse**

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

<a name="getworldexperienceplacestudiofind"></a>
# **GetWorldExperiencePlaceStudioFind**
> GetWorldExperiencePlaceStudioFindResponse GetWorldExperiencePlaceStudioFind (string experienceId, string placeId, string name = null, string _class = null, string tag = null, decimal? limit = null)

Find instances by name (contains), exact class and/or tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioFindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var name = "name_example";  // string |  (optional) 
            var _class = "_class_example";  // string |  (optional) 
            var tag = "tag_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Find instances by name (contains), exact class and/or tag.
                GetWorldExperiencePlaceStudioFindResponse result = apiInstance.GetWorldExperiencePlaceStudioFind(experienceId, placeId, name, _class, tag, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioFind: " + e.Message );
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
 **name** | **string**|  | [optional] 
 **_class** | **string**|  | [optional] 
 **tag** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**GetWorldExperiencePlaceStudioFindResponse**

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

<a name="getworldexperienceplacestudioinstance"></a>
# **GetWorldExperiencePlaceStudioInstance**
> GetWorldExperiencePlaceStudioInstanceResponse GetWorldExperiencePlaceStudioInstance (string experienceId, string placeId, string path = null, string id = null)

One instance by path (or session id): class, properties, attributes, tags, children. Script source is read with …/studio/script.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var path = "path_example";  // string |  (optional) 
            var id = "id_example";  // string |  (optional) 

            try
            {
                // One instance by path (or session id): class, properties, attributes, tags, children. Script source is read with …/studio/script.
                GetWorldExperiencePlaceStudioInstanceResponse result = apiInstance.GetWorldExperiencePlaceStudioInstance(experienceId, placeId, path, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioInstance: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **id** | **string**|  | [optional] 

### Return type

**GetWorldExperiencePlaceStudioInstanceResponse**

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

<a name="getworldexperienceplacestudiooutput"></a>
# **GetWorldExperiencePlaceStudioOutput**
> GetWorldExperiencePlaceStudioOutputResponse GetWorldExperiencePlaceStudioOutput (string experienceId, string placeId, decimal? since = null, string serverId = null, string level = null, string scope = null, decimal? limit = null)

Server Output (print, warnings, errors) after a cursor: every line of cloud tests, errors of live servers (scope=all). Kept 24 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var since = 8.14D;  // decimal? |  (optional) 
            var serverId = "serverId_example";  // string |  (optional) 
            var level = "info";  // string |  (optional) 
            var scope = "all";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Server Output (print, warnings, errors) after a cursor: every line of cloud tests, errors of live servers (scope=all). Kept 24 hours.
                GetWorldExperiencePlaceStudioOutputResponse result = apiInstance.GetWorldExperiencePlaceStudioOutput(experienceId, placeId, since, serverId, level, scope, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioOutput: " + e.Message );
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
 **since** | **decimal?**|  | [optional] 
 **serverId** | **string**|  | [optional] 
 **level** | **string**|  | [optional] 
 **scope** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**GetWorldExperiencePlaceStudioOutputResponse**

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

<a name="getworldexperienceplacestudioproblem"></a>
# **GetWorldExperiencePlaceStudioProblem**
> GetWorldExperiencePlaceStudioProblemResponse GetWorldExperiencePlaceStudioProblem (string experienceId, string placeId)

The publish checks on the place as the live session holds it: script lint, budgets per device, settings, shop listings, Toolbox licences. publishable = no errors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioProblemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // The publish checks on the place as the live session holds it: script lint, budgets per device, settings, shop listings, Toolbox licences. publishable = no errors.
                GetWorldExperiencePlaceStudioProblemResponse result = apiInstance.GetWorldExperiencePlaceStudioProblem(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioProblem: " + e.Message );
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

**GetWorldExperiencePlaceStudioProblemResponse**

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

<a name="getworldexperienceplacestudioscript"></a>
# **GetWorldExperiencePlaceStudioScript**
> GetWorldExperiencePlaceStudioScriptResponse GetWorldExperiencePlaceStudioScript (string experienceId, string placeId, string path)

A script's current source, your draft of it (if any, with whether someone committed since) and the lint of each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var path = "path_example";  // string | 

            try
            {
                // A script's current source, your draft of it (if any, with whether someone committed since) and the lint of each.
                GetWorldExperiencePlaceStudioScriptResponse result = apiInstance.GetWorldExperiencePlaceStudioScript(experienceId, placeId, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioScript: " + e.Message );
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
 **path** | **string**|  | 

### Return type

**GetWorldExperiencePlaceStudioScriptResponse**

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

<a name="getworldexperienceplacestudiosnapshot"></a>
# **GetWorldExperiencePlaceStudioSnapshot**
> GetWorldExperiencePlaceStudioSnapshotResponse GetWorldExperiencePlaceStudioSnapshot (string experienceId, string placeId, string path = null, string view = null, string labels = null)

A plan (top) or front drawing of the parts under a path as SVG, with bounds, spawns and unanchored parts that will fall.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var path = "path_example";  // string |  (optional) 
            var view = "top";  // string |  (optional) 
            var labels = "true";  // string |  (optional) 

            try
            {
                // A plan (top) or front drawing of the parts under a path as SVG, with bounds, spawns and unanchored parts that will fall.
                GetWorldExperiencePlaceStudioSnapshotResponse result = apiInstance.GetWorldExperiencePlaceStudioSnapshot(experienceId, placeId, path, view, labels);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioSnapshot: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **view** | **string**|  | [optional] 
 **labels** | **string**|  | [optional] 

### Return type

**GetWorldExperiencePlaceStudioSnapshotResponse**

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

<a name="getworldexperienceplacestudiotree"></a>
# **GetWorldExperiencePlaceStudioTree**
> GetWorldExperiencePlaceStudioTreeResponse GetWorldExperiencePlaceStudioTree (string experienceId, string placeId, string path = null, decimal? depth = null)

The live instance tree (what every open Studio shows) by dotted path, depth levels down (default 3, max 12).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperiencePlaceStudioTreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var path = "path_example";  // string |  (optional) 
            var depth = 8.14D;  // decimal? |  (optional) 

            try
            {
                // The live instance tree (what every open Studio shows) by dotted path, depth levels down (default 3, max 12).
                GetWorldExperiencePlaceStudioTreeResponse result = apiInstance.GetWorldExperiencePlaceStudioTree(experienceId, placeId, path, depth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldExperiencePlaceStudioTree: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **depth** | **decimal?**|  | [optional] 

### Return type

**GetWorldExperiencePlaceStudioTreeResponse**

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

<a name="getworldstudioclass"></a>
# **GetWorldStudioClass**
> GetWorldStudioClassResponse GetWorldStudioClass (string name = null)

The engine's class table: insertable classes, services, and for ?name= one class with every property, its type, default and the exact JSON a place (and a studio edit) takes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldStudioClassExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var name = "name_example";  // string |  (optional) 

            try
            {
                // The engine's class table: insertable classes, services, and for ?name= one class with every property, its type, default and the exact JSON a place (and a studio edit) takes.
                GetWorldStudioClassResponse result = apiInstance.GetWorldStudioClass(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.GetWorldStudioClass: " + e.Message );
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
 **name** | **string**|  | [optional] 

### Return type

**GetWorldStudioClassResponse**

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

<a name="listworldexperienceassets"></a>
# **ListWorldExperienceAssets**
> ListWorldExperienceAssetsResponse ListWorldExperienceAssets (string experienceId, decimal? limit = null)

Meshes imported into this experience, newest first: paths, phone LOD, bounds, hull size, budget report, moderation (pending until a reviewed publish uses them) and a URL you can load now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Meshes imported into this experience, newest first: paths, phone LOD, bounds, hull size, budget report, moderation (pending until a reviewed publish uses them) and a URL you can load now.
                ListWorldExperienceAssetsResponse result = apiInstance.ListWorldExperienceAssets(experienceId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.ListWorldExperienceAssets: " + e.Message );
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
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListWorldExperienceAssetsResponse**

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

<a name="updateworldexperienceplacestudioscript"></a>
# **UpdateWorldExperiencePlaceStudioScript**
> UpdateWorldExperiencePlaceStudioScriptResponse UpdateWorldExperiencePlaceStudioScript (string experienceId, string placeId, UpdateWorldExperiencePlaceStudioScriptRequest updateWorldExperiencePlaceStudioScriptRequest = null)

Save your draft of a script (the place does not change until you commit). Returns lint and the diff from the current source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperiencePlaceStudioScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsStudioApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var updateWorldExperiencePlaceStudioScriptRequest = new UpdateWorldExperiencePlaceStudioScriptRequest(); // UpdateWorldExperiencePlaceStudioScriptRequest |  (optional) 

            try
            {
                // Save your draft of a script (the place does not change until you commit). Returns lint and the diff from the current source.
                UpdateWorldExperiencePlaceStudioScriptResponse result = apiInstance.UpdateWorldExperiencePlaceStudioScript(experienceId, placeId, updateWorldExperiencePlaceStudioScriptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsStudioApi.UpdateWorldExperiencePlaceStudioScript: " + e.Message );
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
 **updateWorldExperiencePlaceStudioScriptRequest** | **UpdateWorldExperiencePlaceStudioScriptRequest**|  | [optional] 

### Return type

**UpdateWorldExperiencePlaceStudioScriptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
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

