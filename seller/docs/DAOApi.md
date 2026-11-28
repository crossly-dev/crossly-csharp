# net.crossly.Api.DAOApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDaoProposal**](DAOApi.md#createdaoproposal) | **POST** /v1/dao/proposals | Raise a proposal. Starts as a draft.
[**CreateDaoProposalFinalise**](DAOApi.md#createdaoproposalfinalise) | **POST** /v1/dao/proposals/{id}/finalise | Close a proposal whose window has passed and record the outcome.
[**CreateDaoProposalOpen**](DAOApi.md#createdaoproposalopen) | **POST** /v1/dao/proposals/{id}/open | Put your draft to a vote. Snapshots voting power.
[**CreateDaoProposalVeto**](DAOApi.md#createdaoproposalveto) | **POST** /v1/dao/proposals/{id}/veto | Operator block. There is no matching power to PASS.
[**CreateDaoProposalVote**](DAOApi.md#createdaoproposalvote) | **POST** /v1/dao/proposals/{id}/vote | Cast or change a vote while the window is open.
[**DeleteDaoProposal**](DAOApi.md#deletedaoproposal) | **DELETE** /v1/dao/proposals/{id} | Withdraw your own DRAFT.
[**GetDaoProposalTally**](DAOApi.md#getdaoproposaltally) | **GET** /v1/dao/proposals/{id}/tally | The live count.
[**GetDaoSubjectParticipation**](DAOApi.md#getdaosubjectparticipation) | **GET** /v1/dao/subjects/{subjectId}/participation | One holder&#39;s participation: votes, voting power over time, share.
[**ListDaoProposals**](DAOApi.md#listdaoproposals) | **GET** /v1/dao/proposals | The proposal queue.


<a name="createdaoproposal"></a>
# **CreateDaoProposal**
> CreateDaoProposalResponse CreateDaoProposal (CreateDaoProposalRequest createDaoProposalRequest)

Raise a proposal. Starts as a draft.

Requires staked CBX above `minProposeWeight`, and one in-flight proposal at a time. The limits bound a denial of ATTENTION rather than of service — attention is the resource a DAO actually runs on. `beneficiaryKind` is a CLOSED set and there is deliberately no stakers, holders, airdrop or distribution option. A proposal whose beneficiaries are the voters would be a self-payment, and a distribution decided by its own recipients is a dividend whatever it is called. The DAO decides WHAT to fund, never WHO gets paid. A `policy` proposal requests no funds and must omit the amount; every other kind must supply one. proposalKind (default spend) raises a Crossly Funding pool proposal instead: pool_allocation (beneficiary funding_pool, an amount), pool_parameter, spend_category or supplier_allowlist (beneficiary policy, with params). A passed pool proposal is applied by the operator; it never pays the voters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDaoProposalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var createDaoProposalRequest = new CreateDaoProposalRequest(); // CreateDaoProposalRequest | 

            try
            {
                // Raise a proposal. Starts as a draft.
                CreateDaoProposalResponse result = apiInstance.CreateDaoProposal(createDaoProposalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.CreateDaoProposal: " + e.Message );
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
 **createDaoProposalRequest** | **CreateDaoProposalRequest**|  | 

### Return type

**CreateDaoProposalResponse**

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

<a name="createdaoproposalfinalise"></a>
# **CreateDaoProposalFinalise**
> CreateDaoProposalFinaliseResponse CreateDaoProposalFinalise (string id)

Close a proposal whose window has passed and record the outcome.

Normally unnecessary — the hourly sweep does it. Exposed so a result can be published immediately after a window closes rather than waiting for a tick. FINALISING RECORDS AN OUTCOME AND NOTHING ELSE. A passed proposal sets a status; disbursing still requires a campaign with a preview and a human approval, and there is no endpoint here that can move value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDaoProposalFinaliseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Close a proposal whose window has passed and record the outcome.
                CreateDaoProposalFinaliseResponse result = apiInstance.CreateDaoProposalFinalise(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.CreateDaoProposalFinalise: " + e.Message );
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
 **id** | **string**|  | 

### Return type

**CreateDaoProposalFinaliseResponse**

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

<a name="createdaoproposalopen"></a>
# **CreateDaoProposalOpen**
> CreateDaoProposalOpenResponse CreateDaoProposalOpen (string id, CreateDaoProposalOpenRequest createDaoProposalOpenRequest)

Put your draft to a vote. Snapshots voting power.

ONLY THE PROPOSER may open their own draft. Opening puts something to a binding vote in somebody's name, and authorship and that decision both belong to them. Opening writes a per-subject voting-power snapshot and freezes the quorum denominator. Nothing recomputes either afterwards, which is what stops acquire-vote-sell. Refuses when nobody holds enough staked CBX to vote — opening then would guarantee a failed quorum, waste a week and read as the feature being broken.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDaoProposalOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 
            var createDaoProposalOpenRequest = new CreateDaoProposalOpenRequest(); // CreateDaoProposalOpenRequest | 

            try
            {
                // Put your draft to a vote. Snapshots voting power.
                CreateDaoProposalOpenResponse result = apiInstance.CreateDaoProposalOpen(id, createDaoProposalOpenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.CreateDaoProposalOpen: " + e.Message );
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
 **id** | **string**|  | 
 **createDaoProposalOpenRequest** | **CreateDaoProposalOpenRequest**|  | 

### Return type

**CreateDaoProposalOpenResponse**

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

<a name="createdaoproposalveto"></a>
# **CreateDaoProposalVeto**
> CreateDaoProposalVetoResponse CreateDaoProposalVeto (string id, CreateDaoProposalVetoRequest createDaoProposalVetoRequest)

Operator block. There is no matching power to PASS.

DELIBERATELY ASYMMETRIC. A veto exists for the illegal and the ruinous — funding something unlawful, or emptying the pool in a week. A power to pass would make every vote advisory theatre, because the outcome would always be whatever the operator preferred. An operator who can only say no cannot manufacture an outcome. The reason is MANDATORY and stored: an unexplained veto is indistinguishable from disliking the result, which is exactly what would destroy confidence in the mechanism. Expect it to be read.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDaoProposalVetoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 
            var createDaoProposalVetoRequest = new CreateDaoProposalVetoRequest(); // CreateDaoProposalVetoRequest | 

            try
            {
                // Operator block. There is no matching power to PASS.
                CreateDaoProposalVetoResponse result = apiInstance.CreateDaoProposalVeto(id, createDaoProposalVetoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.CreateDaoProposalVeto: " + e.Message );
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
 **id** | **string**|  | 
 **createDaoProposalVetoRequest** | **CreateDaoProposalVetoRequest**|  | 

### Return type

**CreateDaoProposalVetoResponse**

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

<a name="createdaoproposalvote"></a>
# **CreateDaoProposalVote**
> CreateDaoProposalVoteResponse CreateDaoProposalVote (string id, CreateDaoProposalVoteRequest createDaoProposalVoteRequest)

Cast or change a vote while the window is open.

Weight comes from the snapshot taken when the proposal opened, so staking afterwards grants no vote on it. Changing your mind is an UPDATE, not a second vote — a unique index makes double-counting impossible even if this logic were wrong. ABSTAIN counts toward turnout and not toward approval, which is the whole reason to offer it: it lets you help a proposal clear quorum without taking a side.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDaoProposalVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 
            var createDaoProposalVoteRequest = new CreateDaoProposalVoteRequest(); // CreateDaoProposalVoteRequest | 

            try
            {
                // Cast or change a vote while the window is open.
                CreateDaoProposalVoteResponse result = apiInstance.CreateDaoProposalVote(id, createDaoProposalVoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.CreateDaoProposalVote: " + e.Message );
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
 **id** | **string**|  | 
 **createDaoProposalVoteRequest** | **CreateDaoProposalVoteRequest**|  | 

### Return type

**CreateDaoProposalVoteResponse**

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

<a name="deletedaoproposal"></a>
# **DeleteDaoProposal**
> DeleteDaoProposalResponse DeleteDaoProposal (string id, SubjectIdRequest subjectIdRequest = null)

Withdraw your own DRAFT.

Drafts only. Withdrawing an OPEN proposal would discard votes already cast, which is the proposer overruling the electorate — the thing the whole mechanism exists to prevent. An open proposal runs its window and gets a result. This exists so the one-in-flight limit is not a trap: without it a typo would lock somebody out of governance until the draft expired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteDaoProposalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 
            var subjectIdRequest = new SubjectIdRequest(); // SubjectIdRequest |  (optional) 

            try
            {
                // Withdraw your own DRAFT.
                DeleteDaoProposalResponse result = apiInstance.DeleteDaoProposal(id, subjectIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.DeleteDaoProposal: " + e.Message );
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
 **id** | **string**|  | 
 **subjectIdRequest** | **SubjectIdRequest**|  | [optional] 

### Return type

**DeleteDaoProposalResponse**

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

<a name="getdaoproposaltally"></a>
# **GetDaoProposalTally**
> GetDaoProposalTallyResponse GetDaoProposalTally (string id)

The live count.

`turnoutBps` is cast power over the frozen total, and counts abstentions. `approvalBps` is FOR over decisive votes, and does not. A proposal that misses quorum reports `expired` rather than `rejected` when finalised — \"nobody turned up\" and \"the room said no\" are different outcomes and a proposer deserves to know which happened.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDaoProposalTallyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The live count.
                GetDaoProposalTallyResponse result = apiInstance.GetDaoProposalTally(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.GetDaoProposalTally: " + e.Message );
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
 **id** | **string**|  | 

### Return type

**GetDaoProposalTallyResponse**

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

<a name="getdaosubjectparticipation"></a>
# **GetDaoSubjectParticipation**
> GetDaoSubjectParticipationResponse GetDaoSubjectParticipation (string subjectId)

One holder's participation: votes, voting power over time, share.

Every vote the subject cast (with the frozen weight it carried), the voting power snapshotted for it at each proposal open (oldest first) with that proposal total, and the latest snapshot share of the total in bps. Amounts are strings of base units. Read-only; the subject must belong to the calling merchant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDaoSubjectParticipationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // One holder's participation: votes, voting power over time, share.
                GetDaoSubjectParticipationResponse result = apiInstance.GetDaoSubjectParticipation(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.GetDaoSubjectParticipation: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

**GetDaoSubjectParticipationResponse**

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

<a name="listdaoproposals"></a>
# **ListDaoProposals**
> ListDaoProposalsResponse ListDaoProposals (string status = null, decimal? limit = null)

The proposal queue.

Staked CBX decides what the events pool funds. Voting power is size x tenure — the same weighting the earn multiplier uses — and it is SNAPSHOTTED when a proposal opens, so staking after seeing one grants no vote on it. `totalVotingPower` is the frozen quorum denominator; recomputing it would let somebody move the bar after votes were cast. Amounts are strings of base units.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDaoProposalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DAOApi(config);
            var status = "expired";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // The proposal queue.
                ListDaoProposalsResponse result = apiInstance.ListDaoProposals(status, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DAOApi.ListDaoProposals: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListDaoProposalsResponse**

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

