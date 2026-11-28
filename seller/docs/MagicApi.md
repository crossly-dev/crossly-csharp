# net.crossly.Api.MagicApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMagicAutoDecisionUndo**](MagicApi.md#createmagicautodecisionundo) | **POST** /v1/magic/auto/decisions/{decisionId}/undo | Undo an automated Magic List decision, deleting its unpublished draft.
[**CreateMagicAutoItem**](MagicApi.md#createmagicautoitem) | **POST** /v1/magic/auto/items | Scan one item and match it automatically (drafts only, never publishes).
[**CreateMagicAutoRun**](MagicApi.md#createmagicautorun) | **POST** /v1/magic/auto/runs/{runId} | Score a Magic List run automatically; a confident match in auto mode becomes a draft.
[**CreateMagicAutoRunSwipe**](MagicApi.md#createmagicautorunswipe) | **POST** /v1/magic/auto/runs/{runId}/swipes | Record a seller swipe session (kept and rejected match keys) for a Magic List run.
[**CreateMagicScan**](MagicApi.md#createmagicscan) | **POST** /v1/magic/scan | Run a Magic List image scan. Optional matchMode (off | auto | review_all) sets this scan&#39;s automated matching; omitted &#x3D; your remembered default.
[**CreateMagicScanSynthesize**](MagicApi.md#createmagicscansynthesize) | **POST** /v1/magic/scan/{runId}/synthesize | Synthesize a draft from confirmed matches.
[**GetMagicAutoSetting**](MagicApi.md#getmagicautosetting) | **GET** /v1/magic/auto/settings | The seller’s Magic List automated-matching mode.
[**GetMagicDraft**](MagicApi.md#getmagicdraft) | **GET** /v1/magic/drafts/{draftId} | Get a synthesized Magic List draft.
[**ListMagicAutoRunDecisions**](MagicApi.md#listmagicautorundecisions) | **GET** /v1/magic/auto/runs/{runId}/decisions | Every match decision round (automated and seller) for a Magic List run.
[**ListMagicRecent**](MagicApi.md#listmagicrecent) | **GET** /v1/magic/recent | Recent Magic List scans for this seller.
[**UpdateMagicAutoSetting**](MagicApi.md#updatemagicautosetting) | **PUT** /v1/magic/auto/settings | Set the Magic List automated-matching mode (off | auto | review_all).


<a name="createmagicautodecisionundo"></a>
# **CreateMagicAutoDecisionUndo**
> CreateMagicAutoDecisionUndoResponse CreateMagicAutoDecisionUndo (Guid decisionId)

Undo an automated Magic List decision, deleting its unpublished draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicAutoDecisionUndoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var decisionId = "decisionId_example";  // Guid | 

            try
            {
                // Undo an automated Magic List decision, deleting its unpublished draft.
                CreateMagicAutoDecisionUndoResponse result = apiInstance.CreateMagicAutoDecisionUndo(decisionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicAutoDecisionUndo: " + e.Message );
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
 **decisionId** | **Guid**|  | 

### Return type

**CreateMagicAutoDecisionUndoResponse**

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

<a name="createmagicautoitem"></a>
# **CreateMagicAutoItem**
> CreateMagicAutoItemResponse CreateMagicAutoItem (CreateMagicAutoItemRequest createMagicAutoItemRequest)

Scan one item and match it automatically (drafts only, never publishes).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicAutoItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var createMagicAutoItemRequest = new CreateMagicAutoItemRequest(); // CreateMagicAutoItemRequest | 

            try
            {
                // Scan one item and match it automatically (drafts only, never publishes).
                CreateMagicAutoItemResponse result = apiInstance.CreateMagicAutoItem(createMagicAutoItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicAutoItem: " + e.Message );
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
 **createMagicAutoItemRequest** | **CreateMagicAutoItemRequest**|  | 

### Return type

**CreateMagicAutoItemResponse**

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

<a name="createmagicautorun"></a>
# **CreateMagicAutoRun**
> CreateMagicAutoRunResponse CreateMagicAutoRun (Guid runId, CreateMagicAutoRunRequest createMagicAutoRunRequest = null)

Score a Magic List run automatically; a confident match in auto mode becomes a draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicAutoRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var runId = "runId_example";  // Guid | 
            var createMagicAutoRunRequest = new CreateMagicAutoRunRequest(); // CreateMagicAutoRunRequest |  (optional) 

            try
            {
                // Score a Magic List run automatically; a confident match in auto mode becomes a draft.
                CreateMagicAutoRunResponse result = apiInstance.CreateMagicAutoRun(runId, createMagicAutoRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicAutoRun: " + e.Message );
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
 **runId** | **Guid**|  | 
 **createMagicAutoRunRequest** | **CreateMagicAutoRunRequest**|  | [optional] 

### Return type

**CreateMagicAutoRunResponse**

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

<a name="createmagicautorunswipe"></a>
# **CreateMagicAutoRunSwipe**
> CreateMagicAutoRunSwipeResponse CreateMagicAutoRunSwipe (Guid runId, CreateMagicAutoRunSwipeRequest createMagicAutoRunSwipeRequest = null)

Record a seller swipe session (kept and rejected match keys) for a Magic List run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicAutoRunSwipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var runId = "runId_example";  // Guid | 
            var createMagicAutoRunSwipeRequest = new CreateMagicAutoRunSwipeRequest(); // CreateMagicAutoRunSwipeRequest |  (optional) 

            try
            {
                // Record a seller swipe session (kept and rejected match keys) for a Magic List run.
                CreateMagicAutoRunSwipeResponse result = apiInstance.CreateMagicAutoRunSwipe(runId, createMagicAutoRunSwipeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicAutoRunSwipe: " + e.Message );
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
 **runId** | **Guid**|  | 
 **createMagicAutoRunSwipeRequest** | **CreateMagicAutoRunSwipeRequest**|  | [optional] 

### Return type

**CreateMagicAutoRunSwipeResponse**

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

<a name="createmagicscan"></a>
# **CreateMagicScan**
> CreateMagicScanResponse CreateMagicScan (CreateMagicScanRequest createMagicScanRequest)

Run a Magic List image scan. Optional matchMode (off | auto | review_all) sets this scan's automated matching; omitted = your remembered default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var createMagicScanRequest = new CreateMagicScanRequest(); // CreateMagicScanRequest | 

            try
            {
                // Run a Magic List image scan. Optional matchMode (off | auto | review_all) sets this scan's automated matching; omitted = your remembered default.
                CreateMagicScanResponse result = apiInstance.CreateMagicScan(createMagicScanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicScan: " + e.Message );
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
 **createMagicScanRequest** | **CreateMagicScanRequest**|  | 

### Return type

**CreateMagicScanResponse**

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

<a name="createmagicscansynthesize"></a>
# **CreateMagicScanSynthesize**
> CreateMagicScanSynthesizeResponse CreateMagicScanSynthesize (Guid runId, CreateMagicScanSynthesizeRequest createMagicScanSynthesizeRequest)

Synthesize a draft from confirmed matches.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMagicScanSynthesizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var runId = "runId_example";  // Guid | 
            var createMagicScanSynthesizeRequest = new CreateMagicScanSynthesizeRequest(); // CreateMagicScanSynthesizeRequest | 

            try
            {
                // Synthesize a draft from confirmed matches.
                CreateMagicScanSynthesizeResponse result = apiInstance.CreateMagicScanSynthesize(runId, createMagicScanSynthesizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.CreateMagicScanSynthesize: " + e.Message );
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
 **runId** | **Guid**|  | 
 **createMagicScanSynthesizeRequest** | **CreateMagicScanSynthesizeRequest**|  | 

### Return type

**CreateMagicScanSynthesizeResponse**

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

<a name="getmagicautosetting"></a>
# **GetMagicAutoSetting**
> GetMagicAutoSettingResponse GetMagicAutoSetting ()

The seller’s Magic List automated-matching mode.

mode: off (every match is swiped by hand), auto (confident matches become DRAFTS on their own, never published, always undoable) or review_all (Crossly pre-marks its picks; the seller confirms). Default review_all.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMagicAutoSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);

            try
            {
                // The seller’s Magic List automated-matching mode.
                GetMagicAutoSettingResponse result = apiInstance.GetMagicAutoSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.GetMagicAutoSetting: " + e.Message );
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

**GetMagicAutoSettingResponse**

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

<a name="getmagicdraft"></a>
# **GetMagicDraft**
> GetMagicDraftResponse GetMagicDraft (Guid draftId)

Get a synthesized Magic List draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMagicDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var draftId = "draftId_example";  // Guid | 

            try
            {
                // Get a synthesized Magic List draft.
                GetMagicDraftResponse result = apiInstance.GetMagicDraft(draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.GetMagicDraft: " + e.Message );
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
 **draftId** | **Guid**|  | 

### Return type

**GetMagicDraftResponse**

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

<a name="listmagicautorundecisions"></a>
# **ListMagicAutoRunDecisions**
> ListMagicAutoRunDecisionsResponse ListMagicAutoRunDecisions (Guid runId)

Every match decision round (automated and seller) for a Magic List run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMagicAutoRunDecisionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var runId = "runId_example";  // Guid | 

            try
            {
                // Every match decision round (automated and seller) for a Magic List run.
                ListMagicAutoRunDecisionsResponse result = apiInstance.ListMagicAutoRunDecisions(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.ListMagicAutoRunDecisions: " + e.Message );
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
 **runId** | **Guid**|  | 

### Return type

**ListMagicAutoRunDecisionsResponse**

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

<a name="listmagicrecent"></a>
# **ListMagicRecent**
> ListMagicRecentResponse ListMagicRecent ()

Recent Magic List scans for this seller.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMagicRecentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);

            try
            {
                // Recent Magic List scans for this seller.
                ListMagicRecentResponse result = apiInstance.ListMagicRecent();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.ListMagicRecent: " + e.Message );
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

**ListMagicRecentResponse**

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

<a name="updatemagicautosetting"></a>
# **UpdateMagicAutoSetting**
> GetMagicAutoSettingResponse UpdateMagicAutoSetting (UpdateMagicAutoSettingRequest updateMagicAutoSettingRequest)

Set the Magic List automated-matching mode (off | auto | review_all).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateMagicAutoSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MagicApi(config);
            var updateMagicAutoSettingRequest = new UpdateMagicAutoSettingRequest(); // UpdateMagicAutoSettingRequest | 

            try
            {
                // Set the Magic List automated-matching mode (off | auto | review_all).
                GetMagicAutoSettingResponse result = apiInstance.UpdateMagicAutoSetting(updateMagicAutoSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagicApi.UpdateMagicAutoSetting: " + e.Message );
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
 **updateMagicAutoSettingRequest** | **UpdateMagicAutoSettingRequest**|  | 

### Return type

**GetMagicAutoSettingResponse**

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

