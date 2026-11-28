# net.crossly.Api.WorkflowsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorkflow**](WorkflowsApi.md#createworkflow) | **POST** /v1/workflows | Create a workflow: from blank ({ name, graph? }), from a template ({ from: \&quot;template\&quot;, templateId, setup?, activate? }) or from an export document ({ from: \&quot;import\&quot;, document }). New workflows start paused; activate one with POST /v1/workflows/{id}/activate. Returns the workflow and its validation issues.
[**CreateWorkflowActivate**](WorkflowsApi.md#createworkflowactivate) | **POST** /v1/workflows/{id}/activate | Activate a workflow: its triggers start firing. A graph with blocking issues is refused (422, details.issues).
[**CreateWorkflowApprovalDecide**](WorkflowsApi.md#createworkflowapprovaldecide) | **POST** /v1/workflow-approvals/{id}/decide | Approve or reject a pending flow.approval request: the waiting run resumes down the approved or rejected port. 409 when it was already decided (another device, Telegram, or the timeout).
[**CreateWorkflowChain**](WorkflowsApi.md#createworkflowchain) | **POST** /v1/workflow-chains | Create a multi-step workflow chain.
[**CreateWorkflowChainRunNow**](WorkflowsApi.md#createworkflowchainrunnow) | **POST** /v1/workflow-chains/{id}/run-now | Enqueue an ad-hoc run of a workflow chain.
[**CreateWorkflowChainToggle**](WorkflowsApi.md#createworkflowchaintoggle) | **POST** /v1/workflow-chains/{id}/toggle | Flip a workflow chain between active and inactive.
[**CreateWorkflowDeactivate**](WorkflowsApi.md#createworkflowdeactivate) | **POST** /v1/workflows/{id}/deactivate | Pause a workflow: its triggers stop firing. Runs already started finish.
[**CreateWorkflowDuplicate**](WorkflowsApi.md#createworkflowduplicate) | **POST** /v1/workflows/{id}/duplicate | Copy a workflow (graph, description, tags) into a new paused workflow.
[**CreateWorkflowExpressionPreview**](WorkflowsApi.md#createworkflowexpressionpreview) | **POST** /v1/workflows/expressions/preview | Resolve one param value (\&quot;{{ $json.priceCents * 0.9 }}\&quot;) with the engine&#39;s evaluator against an item, the trigger item, earlier nodes&#39; items or a stored run. A bad expression is an answer (ok&#x3D;false with the message), not an HTTP error. Changes nothing.
[**CreateWorkflowImport**](WorkflowsApi.md#createworkflowimport) | **POST** /v1/workflows/import | Import a crossly.workflow export document (or { document, name }) as a new, paused workflow. Integration and workflow references are cleared (they belong to the exporting account) and listed in stripped.
[**CreateWorkflowRun**](WorkflowsApi.md#createworkflowrun) | **POST** /v1/workflows/{id}/run | Run a workflow (active or paused) live now, on items you pass or on selected listings / orders / inventory items (one kind per call, up to 1,000). The graph must validate (422 with issues otherwise).
[**CreateWorkflowRunCancel**](WorkflowsApi.md#createworkflowruncancel) | **POST** /v1/workflow-runs/{runId}/cancel | Cancel a queued, running or waiting run. 409 when it already finished.
[**CreateWorkflowRunOn**](WorkflowsApi.md#createworkflowrunon) | **POST** /v1/workflows/run-on | \&quot;Run workflow on…\&quot;: the same as POST /v1/workflows/{id}/run with the workflow named in the body.
[**CreateWorkflowRunRetry**](WorkflowsApi.md#createworkflowrunretry) | **POST** /v1/workflow-runs/{runId}/retry | Retry a failed run from the node that failed: a new run (retryOfRunId) seeded from the failed run&#39;s checkpoint, so nodes that succeeded are not repeated. 409 unless the run failed.
[**CreateWorkflowSaleEnd**](WorkflowsApi.md#createworkflowsaleend) | **POST** /v1/workflows/sales/{saleEventId}/end | End a sale now. A sale that has not started is cancelled; a live one closes and every discounted price is put back now (reverted &#x3D; how many listings were restored). 404 for a sale that is not yours.
[**CreateWorkflowTemplateUse**](WorkflowsApi.md#createworkflowtemplateuse) | **POST** /v1/workflows/templates/{id}/use | Create a workflow from a template, filling its setup fields; activate&#x3D;true activates it when it validates.
[**CreateWorkflowTest**](WorkflowsApi.md#createworkflowtest) | **POST** /v1/workflows/{id}/test | Test a workflow (the saved graph, or a draft graph you pass). mode&#x3D;test runs it for real, using pinned data where a node has it; mode&#x3D;dry is a safe test: write, destructive and money nodes report what they would do and change nothing. Trigger items: the ones you pass, else pinned, else the last real ones, else the trigger sample.
[**CreateWorkflowValidate**](WorkflowsApi.md#createworkflowvalidate) | **POST** /v1/workflows/validate | Validate a graph without saving it: unknown node types, missing required params, bad ports, cycles, expression errors. blocking&#x3D;true means activation would be refused.
[**CreateWorkflowVersionRestore**](WorkflowsApi.md#createworkflowversionrestore) | **POST** /v1/workflows/{id}/versions/{v}/restore | Restore an earlier version&#39;s graph as a new version. Pass version (the current one you read) to refuse the restore when someone saved meanwhile (409). Body optional: { version?: integer }.
[**CreateWorkflowWebhookRotate**](WorkflowsApi.md#createworkflowwebhookrotate) | **POST** /v1/workflows/{id}/webhooks/{nodeId}/rotate | Issue a new inbound URL for an on.webhook trigger node (the old one stops working). The URL, and the signing secret when withSecret&#x3D;true, are returned ONCE: store them now.
[**DeleteWorkflow**](WorkflowsApi.md#deleteworkflow) | **DELETE** /v1/workflows/{id} | Delete (archive) a workflow: its triggers stop, open runs are cancelled, run history stays readable.
[**DeleteWorkflowChain**](WorkflowsApi.md#deleteworkflowchain) | **DELETE** /v1/workflow-chains/{id} | Delete a workflow chain (cascades steps + runs).
[**GetWorkflow**](WorkflowsApi.md#getworkflow) | **GET** /v1/workflows/{id} | Get one workflow with its full graph and current version.
[**GetWorkflowCatalog**](WorkflowsApi.md#getworkflowcatalog) | **GET** /v1/workflows/catalog | Everything needed to build a workflow: every node type (params, ports, output fields, risk, platforms capability), which platforms each capability covers and which of those you have connected, the expression helpers and bindings ({{ $json.listingId }}…) and the condition operators. Read this before composing a graph rather than guessing node types or param keys.
[**GetWorkflowChain**](WorkflowsApi.md#getworkflowchain) | **GET** /v1/workflow-chains/{id} | Get one workflow chain with its steps.
[**GetWorkflowExport**](WorkflowsApi.md#getworkflowexport) | **GET** /v1/workflows/{id}/export | Export a workflow as a portable document (format crossly.workflow) that POST /v1/workflows/import accepts. Credentials and account handles are stripped; pinned test data only with pinnedData&#x3D;true.
[**GetWorkflowRun**](WorkflowsApi.md#getworkflowrun) | **GET** /v1/workflow-runs/{runId} | One run: its summary, the graph version it ran, and every node execution (status, item counts per port, timing, errors). Item data per node: GET …/nodes/{nodeId}.
[**GetWorkflowRunNode**](WorkflowsApi.md#getworkflowrunnode) | **GET** /v1/workflow-runs/{runId}/nodes/{nodeId} | Every execution of one node in a run with its input and output items (each port keeps the first 50 items, 16 KB per item; truncated&#x3D;true when cut). Data older than the retention window, or not kept by settings.saveSuccessData&#x3D;false, is pruned: that execution has input/output null and pruned&#x3D;true, and when every execution is pruned the response is { data: null, meta: { pruned: true } } (never an empty list).
[**ListWorkflowApprovals**](WorkflowsApi.md#listworkflowapprovals) | **GET** /v1/workflow-approvals | Approval requests from flow.approval nodes, newest first (pending only unless status says otherwise). Decide one with POST /v1/workflow-approvals/{id}/decide.
[**ListWorkflowChains**](WorkflowsApi.md#listworkflowchains) | **GET** /v1/workflow-chains | List workflow chains with their step graph.
[**ListWorkflowRuns**](WorkflowsApi.md#listworkflowruns) | **GET** /v1/workflows/{id}/runs | Run history of one workflow, newest first, with per-node status and item counts.
[**ListWorkflowRuns2**](WorkflowsApi.md#listworkflowruns2) | **GET** /v1/workflow-runs | Runs of every workflow, newest first. Filter by workflow, status, mode and time.
[**ListWorkflowSaleActive**](WorkflowsApi.md#listworkflowsaleactive) | **GET** /v1/workflows/sales/active | Every live or upcoming sale (a sales event started by a sale.start node) with the workflow that runs it: percent off, window, and how many listings it applies to.
[**ListWorkflowTemplates**](WorkflowsApi.md#listworkflowtemplates) | **GET** /v1/workflows/templates | Ready-made workflows (weekend sale, stale-listing markdowns, offer responder, ship-by alerts…), each a complete graph plus the setup fields its \&quot;use\&quot; call asks for.
[**ListWorkflowVersions**](WorkflowsApi.md#listworkflowversions) | **GET** /v1/workflows/{id}/versions | The saved versions of a workflow, newest first (restore one with POST …/versions/{v}/restore).
[**ListWorkflows**](WorkflowsApi.md#listworkflows) | **GET** /v1/workflows | List workflows, newest change first. A workflow is a graph of nodes: one or more triggers, then actions, lookups and flow nodes (if, switch, wait, approval…). Each row carries its trigger and node types and a 7-day run sparkline, not the graph (GET /v1/workflows/{id} has it).
[**UpdateWorkflow**](WorkflowsApi.md#updateworkflow) | **PUT** /v1/workflows/{id} | Save a workflow. Pass the version you edited: a save over a newer version is 409 version_conflict (re-read and merge). Saving an active workflow validates it like activation does (422 with issues).
[**UpdateWorkflowChain**](WorkflowsApi.md#updateworkflowchain) | **PUT** /v1/workflow-chains/{id} | Replace a workflow chain wholesale.


<a name="createworkflow"></a>
# **CreateWorkflow**
> CreateWorkflowResponse CreateWorkflow (CreateWorkflowRequest createWorkflowRequest)

Create a workflow: from blank ({ name, graph? }), from a template ({ from: \"template\", templateId, setup?, activate? }) or from an export document ({ from: \"import\", document }). New workflows start paused; activate one with POST /v1/workflows/{id}/activate. Returns the workflow and its validation issues.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowRequest = new CreateWorkflowRequest(); // CreateWorkflowRequest | 

            try
            {
                // Create a workflow: from blank ({ name, graph? }), from a template ({ from: \"template\", templateId, setup?, activate? }) or from an export document ({ from: \"import\", document }). New workflows start paused; activate one with POST /v1/workflows/{id}/activate. Returns the workflow and its validation issues.
                CreateWorkflowResponse result = apiInstance.CreateWorkflow(createWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflow: " + e.Message );
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
 **createWorkflowRequest** | **CreateWorkflowRequest**|  | 

### Return type

**CreateWorkflowResponse**

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

<a name="createworkflowactivate"></a>
# **CreateWorkflowActivate**
> WorkflowResponse CreateWorkflowActivate (Guid id)

Activate a workflow: its triggers start firing. A graph with blocking issues is refused (422, details.issues).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowActivateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.

            try
            {
                // Activate a workflow: its triggers start firing. A graph with blocking issues is refused (422, details.issues).
                WorkflowResponse result = apiInstance.CreateWorkflowActivate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowActivate: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 

### Return type

**WorkflowResponse**

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

<a name="createworkflowapprovaldecide"></a>
# **CreateWorkflowApprovalDecide**
> CreateWorkflowApprovalDecideResponse CreateWorkflowApprovalDecide (Guid id, CreateWorkflowApprovalDecideRequest createWorkflowApprovalDecideRequest)

Approve or reject a pending flow.approval request: the waiting run resumes down the approved or rejected port. 409 when it was already decided (another device, Telegram, or the timeout).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowApprovalDecideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Approval id from GET /v1/workflow-approvals.
            var createWorkflowApprovalDecideRequest = new CreateWorkflowApprovalDecideRequest(); // CreateWorkflowApprovalDecideRequest | 

            try
            {
                // Approve or reject a pending flow.approval request: the waiting run resumes down the approved or rejected port. 409 when it was already decided (another device, Telegram, or the timeout).
                CreateWorkflowApprovalDecideResponse result = apiInstance.CreateWorkflowApprovalDecide(id, createWorkflowApprovalDecideRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowApprovalDecide: " + e.Message );
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
 **id** | **Guid**| Approval id from GET /v1/workflow-approvals. | 
 **createWorkflowApprovalDecideRequest** | **CreateWorkflowApprovalDecideRequest**|  | 

### Return type

**CreateWorkflowApprovalDecideResponse**

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

<a name="createworkflowchain"></a>
# **CreateWorkflowChain**
> IdResponse CreateWorkflowChain (CreateWorkflowChainRequest createWorkflowChainRequest)

Create a multi-step workflow chain.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowChainRequest = new CreateWorkflowChainRequest(); // CreateWorkflowChainRequest | 

            try
            {
                // Create a multi-step workflow chain.
                IdResponse result = apiInstance.CreateWorkflowChain(createWorkflowChainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowChain: " + e.Message );
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
 **createWorkflowChainRequest** | **CreateWorkflowChainRequest**|  | 

### Return type

**IdResponse**

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

<a name="createworkflowchainrunnow"></a>
# **CreateWorkflowChainRunNow**
> CreateWorkflowChainRunNowResponse CreateWorkflowChainRunNow (Guid id)

Enqueue an ad-hoc run of a workflow chain.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowChainRunNowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Enqueue an ad-hoc run of a workflow chain.
                CreateWorkflowChainRunNowResponse result = apiInstance.CreateWorkflowChainRunNow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowChainRunNow: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**CreateWorkflowChainRunNowResponse**

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

<a name="createworkflowchaintoggle"></a>
# **CreateWorkflowChainToggle**
> CreateWorkflowChainToggleResponse CreateWorkflowChainToggle (Guid id)

Flip a workflow chain between active and inactive.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowChainToggleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Flip a workflow chain between active and inactive.
                CreateWorkflowChainToggleResponse result = apiInstance.CreateWorkflowChainToggle(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowChainToggle: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**CreateWorkflowChainToggleResponse**

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

<a name="createworkflowdeactivate"></a>
# **CreateWorkflowDeactivate**
> WorkflowResponse CreateWorkflowDeactivate (Guid id)

Pause a workflow: its triggers stop firing. Runs already started finish.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowDeactivateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.

            try
            {
                // Pause a workflow: its triggers stop firing. Runs already started finish.
                WorkflowResponse result = apiInstance.CreateWorkflowDeactivate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowDeactivate: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 

### Return type

**WorkflowResponse**

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

<a name="createworkflowduplicate"></a>
# **CreateWorkflowDuplicate**
> CreateWorkflowDuplicateResponse CreateWorkflowDuplicate (Guid id, CreateWorkflowDuplicateRequest createWorkflowDuplicateRequest)

Copy a workflow (graph, description, tags) into a new paused workflow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowDuplicateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var createWorkflowDuplicateRequest = new CreateWorkflowDuplicateRequest(); // CreateWorkflowDuplicateRequest | 

            try
            {
                // Copy a workflow (graph, description, tags) into a new paused workflow.
                CreateWorkflowDuplicateResponse result = apiInstance.CreateWorkflowDuplicate(id, createWorkflowDuplicateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowDuplicate: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **createWorkflowDuplicateRequest** | **CreateWorkflowDuplicateRequest**|  | 

### Return type

**CreateWorkflowDuplicateResponse**

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

<a name="createworkflowexpressionpreview"></a>
# **CreateWorkflowExpressionPreview**
> CreateWorkflowExpressionPreviewResponse CreateWorkflowExpressionPreview (CreateWorkflowExpressionPreviewRequest createWorkflowExpressionPreviewRequest)

Resolve one param value (\"{{ $json.priceCents * 0.9 }}\") with the engine's evaluator against an item, the trigger item, earlier nodes' items or a stored run. A bad expression is an answer (ok=false with the message), not an HTTP error. Changes nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowExpressionPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowExpressionPreviewRequest = new CreateWorkflowExpressionPreviewRequest(); // CreateWorkflowExpressionPreviewRequest | 

            try
            {
                // Resolve one param value (\"{{ $json.priceCents * 0.9 }}\") with the engine's evaluator against an item, the trigger item, earlier nodes' items or a stored run. A bad expression is an answer (ok=false with the message), not an HTTP error. Changes nothing.
                CreateWorkflowExpressionPreviewResponse result = apiInstance.CreateWorkflowExpressionPreview(createWorkflowExpressionPreviewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowExpressionPreview: " + e.Message );
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
 **createWorkflowExpressionPreviewRequest** | **CreateWorkflowExpressionPreviewRequest**|  | 

### Return type

**CreateWorkflowExpressionPreviewResponse**

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

<a name="createworkflowimport"></a>
# **CreateWorkflowImport**
> CreateWorkflowImportResponse CreateWorkflowImport (CreateWorkflowImportRequest createWorkflowImportRequest = null)

Import a crossly.workflow export document (or { document, name }) as a new, paused workflow. Integration and workflow references are cleared (they belong to the exporting account) and listed in stripped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowImportRequest = new CreateWorkflowImportRequest(); // CreateWorkflowImportRequest |  (optional) 

            try
            {
                // Import a crossly.workflow export document (or { document, name }) as a new, paused workflow. Integration and workflow references are cleared (they belong to the exporting account) and listed in stripped.
                CreateWorkflowImportResponse result = apiInstance.CreateWorkflowImport(createWorkflowImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowImport: " + e.Message );
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
 **createWorkflowImportRequest** | **CreateWorkflowImportRequest**|  | [optional] 

### Return type

**CreateWorkflowImportResponse**

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

<a name="createworkflowrun"></a>
# **CreateWorkflowRun**
> CreateWorkflowRunResponse CreateWorkflowRun (Guid id, CreateWorkflowRunRequest createWorkflowRunRequest)

Run a workflow (active or paused) live now, on items you pass or on selected listings / orders / inventory items (one kind per call, up to 1,000). The graph must validate (422 with issues otherwise).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var createWorkflowRunRequest = new CreateWorkflowRunRequest(); // CreateWorkflowRunRequest | 

            try
            {
                // Run a workflow (active or paused) live now, on items you pass or on selected listings / orders / inventory items (one kind per call, up to 1,000). The graph must validate (422 with issues otherwise).
                CreateWorkflowRunResponse result = apiInstance.CreateWorkflowRun(id, createWorkflowRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowRun: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **createWorkflowRunRequest** | **CreateWorkflowRunRequest**|  | 

### Return type

**CreateWorkflowRunResponse**

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

<a name="createworkflowruncancel"></a>
# **CreateWorkflowRunCancel**
> CreateWorkflowRunCancelResponse CreateWorkflowRunCancel (Guid runId)

Cancel a queued, running or waiting run. 409 when it already finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowRunCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var runId = "runId_example";  // Guid | Workflow run id.

            try
            {
                // Cancel a queued, running or waiting run. 409 when it already finished.
                CreateWorkflowRunCancelResponse result = apiInstance.CreateWorkflowRunCancel(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowRunCancel: " + e.Message );
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
 **runId** | **Guid**| Workflow run id. | 

### Return type

**CreateWorkflowRunCancelResponse**

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

<a name="createworkflowrunon"></a>
# **CreateWorkflowRunOn**
> CreateWorkflowRunOnResponse CreateWorkflowRunOn (CreateWorkflowRunOnRequest createWorkflowRunOnRequest)

\"Run workflow on…\": the same as POST /v1/workflows/{id}/run with the workflow named in the body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowRunOnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowRunOnRequest = new CreateWorkflowRunOnRequest(); // CreateWorkflowRunOnRequest | 

            try
            {
                // \"Run workflow on…\": the same as POST /v1/workflows/{id}/run with the workflow named in the body.
                CreateWorkflowRunOnResponse result = apiInstance.CreateWorkflowRunOn(createWorkflowRunOnRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowRunOn: " + e.Message );
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
 **createWorkflowRunOnRequest** | **CreateWorkflowRunOnRequest**|  | 

### Return type

**CreateWorkflowRunOnResponse**

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

<a name="createworkflowrunretry"></a>
# **CreateWorkflowRunRetry**
> CreateWorkflowRunRetryResponse CreateWorkflowRunRetry (Guid runId)

Retry a failed run from the node that failed: a new run (retryOfRunId) seeded from the failed run's checkpoint, so nodes that succeeded are not repeated. 409 unless the run failed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowRunRetryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var runId = "runId_example";  // Guid | Workflow run id.

            try
            {
                // Retry a failed run from the node that failed: a new run (retryOfRunId) seeded from the failed run's checkpoint, so nodes that succeeded are not repeated. 409 unless the run failed.
                CreateWorkflowRunRetryResponse result = apiInstance.CreateWorkflowRunRetry(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowRunRetry: " + e.Message );
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
 **runId** | **Guid**| Workflow run id. | 

### Return type

**CreateWorkflowRunRetryResponse**

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

<a name="createworkflowsaleend"></a>
# **CreateWorkflowSaleEnd**
> CreateWorkflowSaleEndResponse CreateWorkflowSaleEnd (Guid saleEventId)

End a sale now. A sale that has not started is cancelled; a live one closes and every discounted price is put back now (reverted = how many listings were restored). 404 for a sale that is not yours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowSaleEndExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var saleEventId = "saleEventId_example";  // Guid | Sale id from GET /v1/workflows/sales/active.

            try
            {
                // End a sale now. A sale that has not started is cancelled; a live one closes and every discounted price is put back now (reverted = how many listings were restored). 404 for a sale that is not yours.
                CreateWorkflowSaleEndResponse result = apiInstance.CreateWorkflowSaleEnd(saleEventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowSaleEnd: " + e.Message );
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
 **saleEventId** | **Guid**| Sale id from GET /v1/workflows/sales/active. | 

### Return type

**CreateWorkflowSaleEndResponse**

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

<a name="createworkflowtemplateuse"></a>
# **CreateWorkflowTemplateUse**
> CreateWorkflowResponse CreateWorkflowTemplateUse (string id, CreateWorkflowTemplateUseRequest createWorkflowTemplateUseRequest)

Create a workflow from a template, filling its setup fields; activate=true activates it when it validates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowTemplateUseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // string | Template id from GET /v1/workflows/templates.
            var createWorkflowTemplateUseRequest = new CreateWorkflowTemplateUseRequest(); // CreateWorkflowTemplateUseRequest | 

            try
            {
                // Create a workflow from a template, filling its setup fields; activate=true activates it when it validates.
                CreateWorkflowResponse result = apiInstance.CreateWorkflowTemplateUse(id, createWorkflowTemplateUseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowTemplateUse: " + e.Message );
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
 **id** | **string**| Template id from GET /v1/workflows/templates. | 
 **createWorkflowTemplateUseRequest** | **CreateWorkflowTemplateUseRequest**|  | 

### Return type

**CreateWorkflowResponse**

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

<a name="createworkflowtest"></a>
# **CreateWorkflowTest**
> CreateWorkflowTestResponse CreateWorkflowTest (Guid id, CreateWorkflowTestRequest createWorkflowTestRequest)

Test a workflow (the saved graph, or a draft graph you pass). mode=test runs it for real, using pinned data where a node has it; mode=dry is a safe test: write, destructive and money nodes report what they would do and change nothing. Trigger items: the ones you pass, else pinned, else the last real ones, else the trigger sample.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var createWorkflowTestRequest = new CreateWorkflowTestRequest(); // CreateWorkflowTestRequest | 

            try
            {
                // Test a workflow (the saved graph, or a draft graph you pass). mode=test runs it for real, using pinned data where a node has it; mode=dry is a safe test: write, destructive and money nodes report what they would do and change nothing. Trigger items: the ones you pass, else pinned, else the last real ones, else the trigger sample.
                CreateWorkflowTestResponse result = apiInstance.CreateWorkflowTest(id, createWorkflowTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowTest: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **createWorkflowTestRequest** | **CreateWorkflowTestRequest**|  | 

### Return type

**CreateWorkflowTestResponse**

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

<a name="createworkflowvalidate"></a>
# **CreateWorkflowValidate**
> CreateWorkflowValidateResponse CreateWorkflowValidate (CreateWorkflowValidateRequest createWorkflowValidateRequest)

Validate a graph without saving it: unknown node types, missing required params, bad ports, cycles, expression errors. blocking=true means activation would be refused.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var createWorkflowValidateRequest = new CreateWorkflowValidateRequest(); // CreateWorkflowValidateRequest | 

            try
            {
                // Validate a graph without saving it: unknown node types, missing required params, bad ports, cycles, expression errors. blocking=true means activation would be refused.
                CreateWorkflowValidateResponse result = apiInstance.CreateWorkflowValidate(createWorkflowValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowValidate: " + e.Message );
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
 **createWorkflowValidateRequest** | **CreateWorkflowValidateRequest**|  | 

### Return type

**CreateWorkflowValidateResponse**

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

<a name="createworkflowversionrestore"></a>
# **CreateWorkflowVersionRestore**
> WorkflowResponse CreateWorkflowVersionRestore (Guid id, int v, CreateWorkflowVersionRestoreRequest createWorkflowVersionRestoreRequest = null)

Restore an earlier version's graph as a new version. Pass version (the current one you read) to refuse the restore when someone saved meanwhile (409). Body optional: { version?: integer }.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowVersionRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var v = 56;  // int | The version number to restore.
            var createWorkflowVersionRestoreRequest = new CreateWorkflowVersionRestoreRequest(); // CreateWorkflowVersionRestoreRequest |  (optional) 

            try
            {
                // Restore an earlier version's graph as a new version. Pass version (the current one you read) to refuse the restore when someone saved meanwhile (409). Body optional: { version?: integer }.
                WorkflowResponse result = apiInstance.CreateWorkflowVersionRestore(id, v, createWorkflowVersionRestoreRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowVersionRestore: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **v** | **int**| The version number to restore. | 
 **createWorkflowVersionRestoreRequest** | **CreateWorkflowVersionRestoreRequest**|  | [optional] 

### Return type

**WorkflowResponse**

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

<a name="createworkflowwebhookrotate"></a>
# **CreateWorkflowWebhookRotate**
> CreateWorkflowWebhookRotateResponse CreateWorkflowWebhookRotate (Guid id, string nodeId, CreateWorkflowWebhookRotateRequest createWorkflowWebhookRotateRequest)

Issue a new inbound URL for an on.webhook trigger node (the old one stops working). The URL, and the signing secret when withSecret=true, are returned ONCE: store them now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorkflowWebhookRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var nodeId = "nodeId_example";  // string | The on.webhook trigger node id.
            var createWorkflowWebhookRotateRequest = new CreateWorkflowWebhookRotateRequest(); // CreateWorkflowWebhookRotateRequest | 

            try
            {
                // Issue a new inbound URL for an on.webhook trigger node (the old one stops working). The URL, and the signing secret when withSecret=true, are returned ONCE: store them now.
                CreateWorkflowWebhookRotateResponse result = apiInstance.CreateWorkflowWebhookRotate(id, nodeId, createWorkflowWebhookRotateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowWebhookRotate: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **nodeId** | **string**| The on.webhook trigger node id. | 
 **createWorkflowWebhookRotateRequest** | **CreateWorkflowWebhookRotateRequest**|  | 

### Return type

**CreateWorkflowWebhookRotateResponse**

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

<a name="deleteworkflow"></a>
# **DeleteWorkflow**
> DeleteWorkflowResponse DeleteWorkflow (Guid id)

Delete (archive) a workflow: its triggers stop, open runs are cancelled, run history stays readable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.

            try
            {
                // Delete (archive) a workflow: its triggers stop, open runs are cancelled, run history stays readable.
                DeleteWorkflowResponse result = apiInstance.DeleteWorkflow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.DeleteWorkflow: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 

### Return type

**DeleteWorkflowResponse**

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

<a name="deleteworkflowchain"></a>
# **DeleteWorkflowChain**
> OkResponse DeleteWorkflowChain (Guid id)

Delete a workflow chain (cascades steps + runs).

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorkflowChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a workflow chain (cascades steps + runs).
                OkResponse result = apiInstance.DeleteWorkflowChain(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.DeleteWorkflowChain: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**OkResponse**

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

<a name="getworkflow"></a>
# **GetWorkflow**
> GetWorkflowResponse GetWorkflow (Guid id)

Get one workflow with its full graph and current version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.

            try
            {
                // Get one workflow with its full graph and current version.
                GetWorkflowResponse result = apiInstance.GetWorkflow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflow: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 

### Return type

**GetWorkflowResponse**

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

<a name="getworkflowcatalog"></a>
# **GetWorkflowCatalog**
> GetWorkflowCatalogResponse GetWorkflowCatalog ()

Everything needed to build a workflow: every node type (params, ports, output fields, risk, platforms capability), which platforms each capability covers and which of those you have connected, the expression helpers and bindings ({{ $json.listingId }}…) and the condition operators. Read this before composing a graph rather than guessing node types or param keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);

            try
            {
                // Everything needed to build a workflow: every node type (params, ports, output fields, risk, platforms capability), which platforms each capability covers and which of those you have connected, the expression helpers and bindings ({{ $json.listingId }}…) and the condition operators. Read this before composing a graph rather than guessing node types or param keys.
                GetWorkflowCatalogResponse result = apiInstance.GetWorkflowCatalog();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowCatalog: " + e.Message );
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

**GetWorkflowCatalogResponse**

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

<a name="getworkflowchain"></a>
# **GetWorkflowChain**
> GetWorkflowChainResponse GetWorkflowChain (Guid id)

Get one workflow chain with its steps.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one workflow chain with its steps.
                GetWorkflowChainResponse result = apiInstance.GetWorkflowChain(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowChain: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**GetWorkflowChainResponse**

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

<a name="getworkflowexport"></a>
# **GetWorkflowExport**
> GetWorkflowExportResponse GetWorkflowExport (Guid id, string pinnedData = null)

Export a workflow as a portable document (format crossly.workflow) that POST /v1/workflows/import accepts. Credentials and account handles are stripped; pinned test data only with pinnedData=true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var pinnedData = "true";  // string | Keep the nodes' pinned test data. (optional) 

            try
            {
                // Export a workflow as a portable document (format crossly.workflow) that POST /v1/workflows/import accepts. Credentials and account handles are stripped; pinned test data only with pinnedData=true.
                GetWorkflowExportResponse result = apiInstance.GetWorkflowExport(id, pinnedData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowExport: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **pinnedData** | **string**| Keep the nodes&#39; pinned test data. | [optional] 

### Return type

**GetWorkflowExportResponse**

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

<a name="getworkflowrun"></a>
# **GetWorkflowRun**
> GetWorkflowRunResponse GetWorkflowRun (Guid runId)

One run: its summary, the graph version it ran, and every node execution (status, item counts per port, timing, errors). Item data per node: GET …/nodes/{nodeId}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var runId = "runId_example";  // Guid | Workflow run id.

            try
            {
                // One run: its summary, the graph version it ran, and every node execution (status, item counts per port, timing, errors). Item data per node: GET …/nodes/{nodeId}.
                GetWorkflowRunResponse result = apiInstance.GetWorkflowRun(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowRun: " + e.Message );
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
 **runId** | **Guid**| Workflow run id. | 

### Return type

**GetWorkflowRunResponse**

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

<a name="getworkflowrunnode"></a>
# **GetWorkflowRunNode**
> GetWorkflowRunNodeResponse GetWorkflowRunNode (Guid runId, string nodeId)

Every execution of one node in a run with its input and output items (each port keeps the first 50 items, 16 KB per item; truncated=true when cut). Data older than the retention window, or not kept by settings.saveSuccessData=false, is pruned: that execution has input/output null and pruned=true, and when every execution is pruned the response is { data: null, meta: { pruned: true } } (never an empty list).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorkflowRunNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var runId = "runId_example";  // Guid | Workflow run id.
            var nodeId = "nodeId_example";  // string | Node id within the run's graph.

            try
            {
                // Every execution of one node in a run with its input and output items (each port keeps the first 50 items, 16 KB per item; truncated=true when cut). Data older than the retention window, or not kept by settings.saveSuccessData=false, is pruned: that execution has input/output null and pruned=true, and when every execution is pruned the response is { data: null, meta: { pruned: true } } (never an empty list).
                GetWorkflowRunNodeResponse result = apiInstance.GetWorkflowRunNode(runId, nodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowRunNode: " + e.Message );
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
 **runId** | **Guid**| Workflow run id. | 
 **nodeId** | **string**| Node id within the run&#39;s graph. | 

### Return type

**GetWorkflowRunNodeResponse**

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

<a name="listworkflowapprovals"></a>
# **ListWorkflowApprovals**
> ListWorkflowApprovalsResponse ListWorkflowApprovals (string status = null, Guid? workflowId = null, int? page = null, int? limit = null)

Approval requests from flow.approval nodes, newest first (pending only unless status says otherwise). Decide one with POST /v1/workflow-approvals/{id}/decide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowApprovalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var status = "status_example";  // string | Comma-separated: pending, approved, rejected, expired. Default pending. (optional) 
            var workflowId = "workflowId_example";  // Guid? | Only approvals of this workflow. (optional) 
            var page = 1;  // int? | 1-indexed page. (optional)  (default to 1)
            var limit = 25;  // int? | Rows per page (1-100). (optional)  (default to 25)

            try
            {
                // Approval requests from flow.approval nodes, newest first (pending only unless status says otherwise). Decide one with POST /v1/workflow-approvals/{id}/decide.
                ListWorkflowApprovalsResponse result = apiInstance.ListWorkflowApprovals(status, workflowId, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowApprovals: " + e.Message );
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
 **status** | **string**| Comma-separated: pending, approved, rejected, expired. Default pending. | [optional] 
 **workflowId** | **Guid?**| Only approvals of this workflow. | [optional] 
 **page** | **int?**| 1-indexed page. | [optional] [default to 1]
 **limit** | **int?**| Rows per page (1-100). | [optional] [default to 25]

### Return type

**ListWorkflowApprovalsResponse**

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

<a name="listworkflowchains"></a>
# **ListWorkflowChains**
> ListWorkflowChainsResponse ListWorkflowChains ()

List workflow chains with their step graph.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowChainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);

            try
            {
                // List workflow chains with their step graph.
                ListWorkflowChainsResponse result = apiInstance.ListWorkflowChains();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowChains: " + e.Message );
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

**ListWorkflowChainsResponse**

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

<a name="listworkflowruns"></a>
# **ListWorkflowRuns**
> ListWorkflowRunsResponse ListWorkflowRuns (Guid id, string status = null, string mode = null, DateTime? since = null, DateTime? until = null, int? page = null, int? limit = null)

Run history of one workflow, newest first, with per-node status and item counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var status = "status_example";  // string | Comma-separated run statuses: queued, running, waiting, succeeded, failed, cancelled. (optional) 
            var mode = "live";  // string | live (triggers), test (editor test run) or dry (safe test: no writes). (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Runs queued at or after this time (ISO 8601). (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Runs queued at or before this time (ISO 8601). (optional) 
            var page = 1;  // int? | 1-indexed page. (optional)  (default to 1)
            var limit = 25;  // int? | Rows per page (1-100). (optional)  (default to 25)

            try
            {
                // Run history of one workflow, newest first, with per-node status and item counts.
                ListWorkflowRunsResponse result = apiInstance.ListWorkflowRuns(id, status, mode, since, until, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowRuns: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **status** | **string**| Comma-separated run statuses: queued, running, waiting, succeeded, failed, cancelled. | [optional] 
 **mode** | **string**| live (triggers), test (editor test run) or dry (safe test: no writes). | [optional] 
 **since** | **DateTime?**| Runs queued at or after this time (ISO 8601). | [optional] 
 **until** | **DateTime?**| Runs queued at or before this time (ISO 8601). | [optional] 
 **page** | **int?**| 1-indexed page. | [optional] [default to 1]
 **limit** | **int?**| Rows per page (1-100). | [optional] [default to 25]

### Return type

**ListWorkflowRunsResponse**

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

<a name="listworkflowruns2"></a>
# **ListWorkflowRuns2**
> ListWorkflowRunsResponse ListWorkflowRuns2 (Guid? workflowId = null, string status = null, string mode = null, DateTime? since = null, DateTime? until = null, int? page = null, int? limit = null)

Runs of every workflow, newest first. Filter by workflow, status, mode and time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowRuns2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var workflowId = "workflowId_example";  // Guid? | Only runs of this workflow. (optional) 
            var status = "status_example";  // string | Comma-separated run statuses: queued, running, waiting, succeeded, failed, cancelled. (optional) 
            var mode = "live";  // string | live (triggers), test (editor test run) or dry (safe test: no writes). (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Runs queued at or after this time (ISO 8601). (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Runs queued at or before this time (ISO 8601). (optional) 
            var page = 1;  // int? | 1-indexed page. (optional)  (default to 1)
            var limit = 25;  // int? | Rows per page (1-100). (optional)  (default to 25)

            try
            {
                // Runs of every workflow, newest first. Filter by workflow, status, mode and time.
                ListWorkflowRunsResponse result = apiInstance.ListWorkflowRuns2(workflowId, status, mode, since, until, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowRuns2: " + e.Message );
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
 **workflowId** | **Guid?**| Only runs of this workflow. | [optional] 
 **status** | **string**| Comma-separated run statuses: queued, running, waiting, succeeded, failed, cancelled. | [optional] 
 **mode** | **string**| live (triggers), test (editor test run) or dry (safe test: no writes). | [optional] 
 **since** | **DateTime?**| Runs queued at or after this time (ISO 8601). | [optional] 
 **until** | **DateTime?**| Runs queued at or before this time (ISO 8601). | [optional] 
 **page** | **int?**| 1-indexed page. | [optional] [default to 1]
 **limit** | **int?**| Rows per page (1-100). | [optional] [default to 25]

### Return type

**ListWorkflowRunsResponse**

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

<a name="listworkflowsaleactive"></a>
# **ListWorkflowSaleActive**
> ListWorkflowSaleActiveResponse ListWorkflowSaleActive ()

Every live or upcoming sale (a sales event started by a sale.start node) with the workflow that runs it: percent off, window, and how many listings it applies to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowSaleActiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);

            try
            {
                // Every live or upcoming sale (a sales event started by a sale.start node) with the workflow that runs it: percent off, window, and how many listings it applies to.
                ListWorkflowSaleActiveResponse result = apiInstance.ListWorkflowSaleActive();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowSaleActive: " + e.Message );
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

**ListWorkflowSaleActiveResponse**

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

<a name="listworkflowtemplates"></a>
# **ListWorkflowTemplates**
> ListWorkflowTemplatesResponse ListWorkflowTemplates (string category = null, string q = null)

Ready-made workflows (weekend sale, stale-listing markdowns, offer responder, ship-by alerts…), each a complete graph plus the setup fields its \"use\" call asks for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var category = "category_example";  // string | Exact template category, e.g. \"Sales & markdowns\". (optional) 
            var q = "q_example";  // string | Matches name, description, category or tags. (optional) 

            try
            {
                // Ready-made workflows (weekend sale, stale-listing markdowns, offer responder, ship-by alerts…), each a complete graph plus the setup fields its \"use\" call asks for.
                ListWorkflowTemplatesResponse result = apiInstance.ListWorkflowTemplates(category, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowTemplates: " + e.Message );
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
 **category** | **string**| Exact template category, e.g. \&quot;Sales &amp; markdowns\&quot;. | [optional] 
 **q** | **string**| Matches name, description, category or tags. | [optional] 

### Return type

**ListWorkflowTemplatesResponse**

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

<a name="listworkflowversions"></a>
# **ListWorkflowVersions**
> ListWorkflowVersionsResponse ListWorkflowVersions (Guid id)

The saved versions of a workflow, newest first (restore one with POST …/versions/{v}/restore).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.

            try
            {
                // The saved versions of a workflow, newest first (restore one with POST …/versions/{v}/restore).
                ListWorkflowVersionsResponse result = apiInstance.ListWorkflowVersions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflowVersions: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 

### Return type

**ListWorkflowVersionsResponse**

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

<a name="listworkflows"></a>
# **ListWorkflows**
> ListWorkflowsResponse ListWorkflows (string active = null, string tag = null, string trigger = null, string q = null, string legacyRef = null)

List workflows, newest change first. A workflow is a graph of nodes: one or more triggers, then actions, lookups and flow nodes (if, switch, wait, approval…). Each row carries its trigger and node types and a 7-day run sparkline, not the graph (GET /v1/workflows/{id} has it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorkflowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var active = "true";  // string | Only active (true) or paused (false) workflows. (optional) 
            var tag = "tag_example";  // string | Only workflows carrying this tag. (optional) 
            var trigger = "trigger_example";  // string | Only workflows started by this trigger node type, e.g. on.listing.sold. (optional) 
            var q = "q_example";  // string | Name contains (case-insensitive). (optional) 
            var legacyRef = "legacyRef_example";  // string | The workflow an old automation became: rule:<id>, chain:<id> or sale_event:<id>. (optional) 

            try
            {
                // List workflows, newest change first. A workflow is a graph of nodes: one or more triggers, then actions, lookups and flow nodes (if, switch, wait, approval…). Each row carries its trigger and node types and a 7-day run sparkline, not the graph (GET /v1/workflows/{id} has it).
                ListWorkflowsResponse result = apiInstance.ListWorkflows(active, tag, trigger, q, legacyRef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.ListWorkflows: " + e.Message );
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
 **active** | **string**| Only active (true) or paused (false) workflows. | [optional] 
 **tag** | **string**| Only workflows carrying this tag. | [optional] 
 **trigger** | **string**| Only workflows started by this trigger node type, e.g. on.listing.sold. | [optional] 
 **q** | **string**| Name contains (case-insensitive). | [optional] 
 **legacyRef** | **string**| The workflow an old automation became: rule:&lt;id&gt;, chain:&lt;id&gt; or sale_event:&lt;id&gt;. | [optional] 

### Return type

**ListWorkflowsResponse**

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

<a name="updateworkflow"></a>
# **UpdateWorkflow**
> WorkflowResponse UpdateWorkflow (Guid id, UpdateWorkflowRequest updateWorkflowRequest)

Save a workflow. Pass the version you edited: a save over a newer version is 409 version_conflict (re-read and merge). Saving an active workflow validates it like activation does (422 with issues).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | Workflow id.
            var updateWorkflowRequest = new UpdateWorkflowRequest(); // UpdateWorkflowRequest | 

            try
            {
                // Save a workflow. Pass the version you edited: a save over a newer version is 409 version_conflict (re-read and merge). Saving an active workflow validates it like activation does (422 with issues).
                WorkflowResponse result = apiInstance.UpdateWorkflow(id, updateWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.UpdateWorkflow: " + e.Message );
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
 **id** | **Guid**| Workflow id. | 
 **updateWorkflowRequest** | **UpdateWorkflowRequest**|  | 

### Return type

**WorkflowResponse**

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

<a name="updateworkflowchain"></a>
# **UpdateWorkflowChain**
> OkResponse UpdateWorkflowChain (Guid id, CreateWorkflowChainRequest createWorkflowChainRequest)

Replace a workflow chain wholesale.

Deprecated: workflow chains are workflows now. Use /v1/workflows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorkflowChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorkflowsApi(config);
            var id = "id_example";  // Guid | 
            var createWorkflowChainRequest = new CreateWorkflowChainRequest(); // CreateWorkflowChainRequest | 

            try
            {
                // Replace a workflow chain wholesale.
                OkResponse result = apiInstance.UpdateWorkflowChain(id, createWorkflowChainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowsApi.UpdateWorkflowChain: " + e.Message );
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
 **id** | **Guid**|  | 
 **createWorkflowChainRequest** | **CreateWorkflowChainRequest**|  | 

### Return type

**OkResponse**

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

