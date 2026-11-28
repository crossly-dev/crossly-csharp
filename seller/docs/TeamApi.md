# net.crossly.Api.TeamApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTeamAccept**](TeamApi.md#createteamaccept) | **POST** /v1/team/accept | Accept a team invitation by the raw token from its link.
[**CreateTeamInvite**](TeamApi.md#createteaminvite) | **POST** /v1/team/invites | Invite someone to one or more stores, each with its permissions; returns the one-time accept URL.
[**CreateTeamInvite2**](TeamApi.md#createteaminvite2) | **POST** /v1/team/invite | Issue a team invitation; returns the one-time accept URL (nothing is emailed).
[**CreateTeamLeave**](TeamApi.md#createteamleave) | **POST** /v1/team/leave | Leave every team this user is currently a member of.
[**CreateTeamMemberStore**](TeamApi.md#createteammemberstore) | **POST** /v1/team/members/{id}/stores | Add a team member to a store with its permissions.
[**CreateTeamRevoke**](TeamApi.md#createteamrevoke) | **POST** /v1/team/revoke | Revoke a pending invite OR an active team member.
[**DeleteTeamMemberStore**](TeamApi.md#deleteteammemberstore) | **DELETE** /v1/team/members/{id}/stores/{store} | Remove a team member from one store (their other stores stay).
[**GetAssignee**](TeamApi.md#getassignee) | **GET** /v1/assignees | The teammates work can be assigned to (active seats; isMe marks yours).
[**GetTeam**](TeamApi.md#getteam) | **GET** /v1/team | List pending team invitations + active members.
[**GetTeamMember**](TeamApi.md#getteammember) | **GET** /v1/team/members/{id} | One team member: added, last active and the stores they staff.
[**GetTeamMemberStore**](TeamApi.md#getteammemberstore) | **GET** /v1/team/members/{id}/stores/{store} | A member&#39;s permissions and limits in one store (&#x60;all&#x60; &#x3D; all current and future stores).
[**ListTeamInvites**](TeamApi.md#listteaminvites) | **GET** /v1/team/invites | List team invitations with the stores each adds the person to.
[**ListTeamMembers**](TeamApi.md#listteammembers) | **GET** /v1/team/members | List team members with the stores each staffs (search, store, preset, permission, status, last active).
[**ListTeamStores**](TeamApi.md#listteamstores) | **GET** /v1/team/stores | The stores whose team you may see, invite to and manage.
[**UpdateTeam**](TeamApi.md#updateteam) | **PATCH** /v1/team/{memberId} | Update a team member&#39;s scopes (owner only).
[**UpdateTeamMemberStore**](TeamApi.md#updateteammemberstore) | **PUT** /v1/team/members/{id}/stores/{store} | Set a member&#39;s permissions and limits in one store.


<a name="createteamaccept"></a>
# **CreateTeamAccept**
> CreateTeamAcceptResponse CreateTeamAccept (TokenObject tokenObject)

Accept a team invitation by the raw token from its link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var tokenObject = new TokenObject(); // TokenObject | 

            try
            {
                // Accept a team invitation by the raw token from its link.
                CreateTeamAcceptResponse result = apiInstance.CreateTeamAccept(tokenObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamAccept: " + e.Message );
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
 **tokenObject** | **TokenObject**|  | 

### Return type

**CreateTeamAcceptResponse**

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

<a name="createteaminvite"></a>
# **CreateTeamInvite**
> CreateTeamInviteResponse CreateTeamInvite (CreateTeamInviteRequest createTeamInviteRequest)

Invite someone to one or more stores, each with its permissions; returns the one-time accept URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var createTeamInviteRequest = new CreateTeamInviteRequest(); // CreateTeamInviteRequest | 

            try
            {
                // Invite someone to one or more stores, each with its permissions; returns the one-time accept URL.
                CreateTeamInviteResponse result = apiInstance.CreateTeamInvite(createTeamInviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamInvite: " + e.Message );
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
 **createTeamInviteRequest** | **CreateTeamInviteRequest**|  | 

### Return type

**CreateTeamInviteResponse**

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

<a name="createteaminvite2"></a>
# **CreateTeamInvite2**
> CreateTeamInvite2Response CreateTeamInvite2 (CreateTeamInvite2Request createTeamInvite2Request)

Issue a team invitation; returns the one-time accept URL (nothing is emailed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamInvite2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var createTeamInvite2Request = new CreateTeamInvite2Request(); // CreateTeamInvite2Request | 

            try
            {
                // Issue a team invitation; returns the one-time accept URL (nothing is emailed).
                CreateTeamInvite2Response result = apiInstance.CreateTeamInvite2(createTeamInvite2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamInvite2: " + e.Message );
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
 **createTeamInvite2Request** | **CreateTeamInvite2Request**|  | 

### Return type

**CreateTeamInvite2Response**

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

<a name="createteamleave"></a>
# **CreateTeamLeave**
> CreateTeamLeaveResponse CreateTeamLeave ()

Leave every team this user is currently a member of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);

            try
            {
                // Leave every team this user is currently a member of.
                CreateTeamLeaveResponse result = apiInstance.CreateTeamLeave();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamLeave: " + e.Message );
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

**CreateTeamLeaveResponse**

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

<a name="createteammemberstore"></a>
# **CreateTeamMemberStore**
> TeamMemberStoreResponse CreateTeamMemberStore (string id, CreateTeamMemberStoreRequest createTeamMemberStoreRequest)

Add a team member to a store with its permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamMemberStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var id = "id_example";  // string | 
            var createTeamMemberStoreRequest = new CreateTeamMemberStoreRequest(); // CreateTeamMemberStoreRequest | 

            try
            {
                // Add a team member to a store with its permissions.
                TeamMemberStoreResponse result = apiInstance.CreateTeamMemberStore(id, createTeamMemberStoreRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamMemberStore: " + e.Message );
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
 **createTeamMemberStoreRequest** | **CreateTeamMemberStoreRequest**|  | 

### Return type

**TeamMemberStoreResponse**

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

<a name="createteamrevoke"></a>
# **CreateTeamRevoke**
> CreateTeamRevokeResponse CreateTeamRevoke (CreateTeamRevokeRequest createTeamRevokeRequest)

Revoke a pending invite OR an active team member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateTeamRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var createTeamRevokeRequest = new CreateTeamRevokeRequest(); // CreateTeamRevokeRequest | 

            try
            {
                // Revoke a pending invite OR an active team member.
                CreateTeamRevokeResponse result = apiInstance.CreateTeamRevoke(createTeamRevokeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.CreateTeamRevoke: " + e.Message );
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
 **createTeamRevokeRequest** | **CreateTeamRevokeRequest**|  | 

### Return type

**CreateTeamRevokeResponse**

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

<a name="deleteteammemberstore"></a>
# **DeleteTeamMemberStore**
> UpdateGroupBuyResponse DeleteTeamMemberStore (string id, string store)

Remove a team member from one store (their other stores stay).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteTeamMemberStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var id = "id_example";  // string | 
            var store = "store_example";  // string | 

            try
            {
                // Remove a team member from one store (their other stores stay).
                UpdateGroupBuyResponse result = apiInstance.DeleteTeamMemberStore(id, store);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.DeleteTeamMemberStore: " + e.Message );
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
 **store** | **string**|  | 

### Return type

**UpdateGroupBuyResponse**

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

<a name="getassignee"></a>
# **GetAssignee**
> GetAssigneeResponse GetAssignee ()

The teammates work can be assigned to (active seats; isMe marks yours).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAssigneeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);

            try
            {
                // The teammates work can be assigned to (active seats; isMe marks yours).
                GetAssigneeResponse result = apiInstance.GetAssignee();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.GetAssignee: " + e.Message );
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

**GetAssigneeResponse**

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

<a name="getteam"></a>
# **GetTeam**
> GetTeamResponse GetTeam ()

List pending team invitations + active members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);

            try
            {
                // List pending team invitations + active members.
                GetTeamResponse result = apiInstance.GetTeam();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeam: " + e.Message );
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

**GetTeamResponse**

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

<a name="getteammember"></a>
# **GetTeamMember**
> GetTeamMemberResponse GetTeamMember (string id)

One team member: added, last active and the stores they staff.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTeamMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One team member: added, last active and the stores they staff.
                GetTeamMemberResponse result = apiInstance.GetTeamMember(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMember: " + e.Message );
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

**GetTeamMemberResponse**

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

<a name="getteammemberstore"></a>
# **GetTeamMemberStore**
> TeamMemberStoreResponse GetTeamMemberStore (string id, string store)

A member's permissions and limits in one store (`all` = all current and future stores).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTeamMemberStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var id = "id_example";  // string | 
            var store = "store_example";  // string | 

            try
            {
                // A member's permissions and limits in one store (`all` = all current and future stores).
                TeamMemberStoreResponse result = apiInstance.GetTeamMemberStore(id, store);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.GetTeamMemberStore: " + e.Message );
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
 **store** | **string**|  | 

### Return type

**TeamMemberStoreResponse**

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

<a name="listteaminvites"></a>
# **ListTeamInvites**
> ListTeamInvitesResponse ListTeamInvites (string store = null, string status = null, string sort = null, string q = null, decimal? page = null, decimal? pageSize = null)

List team invitations with the stores each adds the person to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTeamInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var store = "store_example";  // string |  (optional) 
            var status = "all";  // string |  (optional) 
            var sort = "email";  // string |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var page = 8.14D;  // decimal? |  (optional) 
            var pageSize = 8.14D;  // decimal? |  (optional) 

            try
            {
                // List team invitations with the stores each adds the person to.
                ListTeamInvitesResponse result = apiInstance.ListTeamInvites(store, status, sort, q, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.ListTeamInvites: " + e.Message );
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
 **store** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **page** | **decimal?**|  | [optional] 
 **pageSize** | **decimal?**|  | [optional] 

### Return type

**ListTeamInvitesResponse**

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

<a name="listteammembers"></a>
# **ListTeamMembers**
> ListTeamMembersResponse ListTeamMembers (string store = null, string role = null, string permission = null, string status = null, string lastActive = null, string sort = null, string q = null, decimal? page = null, decimal? pageSize = null)

List team members with the stores each staffs (search, store, preset, permission, status, last active).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTeamMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var store = "store_example";  // string | A store id, or 'all' (members holding the all-stores entry). (optional) 
            var role = "role_example";  // string | A preset id (viewer…admin), 'custom', or the account role 'account_admin'. (optional) 
            var permission = "permission_example";  // string |  (optional) 
            var status = "active";  // string | active = reaches at least one store; no_stores = a seat with no store yet. (optional) 
            var lastActive = "never";  // string |  (optional) 
            var sort = "name";  // string |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var page = 8.14D;  // decimal? |  (optional) 
            var pageSize = 8.14D;  // decimal? |  (optional) 

            try
            {
                // List team members with the stores each staffs (search, store, preset, permission, status, last active).
                ListTeamMembersResponse result = apiInstance.ListTeamMembers(store, role, permission, status, lastActive, sort, q, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.ListTeamMembers: " + e.Message );
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
 **store** | **string**| A store id, or &#39;all&#39; (members holding the all-stores entry). | [optional] 
 **role** | **string**| A preset id (viewer…admin), &#39;custom&#39;, or the account role &#39;account_admin&#39;. | [optional] 
 **permission** | **string**|  | [optional] 
 **status** | **string**| active &#x3D; reaches at least one store; no_stores &#x3D; a seat with no store yet. | [optional] 
 **lastActive** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **page** | **decimal?**|  | [optional] 
 **pageSize** | **decimal?**|  | [optional] 

### Return type

**ListTeamMembersResponse**

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

<a name="listteamstores"></a>
# **ListTeamStores**
> ListTeamStoresResponse ListTeamStores ()

The stores whose team you may see, invite to and manage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTeamStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);

            try
            {
                // The stores whose team you may see, invite to and manage.
                ListTeamStoresResponse result = apiInstance.ListTeamStores();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.ListTeamStores: " + e.Message );
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

**ListTeamStoresResponse**

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

<a name="updateteam"></a>
# **UpdateTeam**
> OkResponse UpdateTeam (Guid memberId, UpdateTeamRequest updateTeamRequest)

Update a team member's scopes (owner only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var memberId = "memberId_example";  // Guid | 
            var updateTeamRequest = new UpdateTeamRequest(); // UpdateTeamRequest | 

            try
            {
                // Update a team member's scopes (owner only).
                OkResponse result = apiInstance.UpdateTeam(memberId, updateTeamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.UpdateTeam: " + e.Message );
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
 **memberId** | **Guid**|  | 
 **updateTeamRequest** | **UpdateTeamRequest**|  | 

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

<a name="updateteammemberstore"></a>
# **UpdateTeamMemberStore**
> TeamMemberStoreResponse UpdateTeamMemberStore (string id, string store, UpdateTeamMemberStoreRequest updateTeamMemberStoreRequest)

Set a member's permissions and limits in one store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateTeamMemberStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamApi(config);
            var id = "id_example";  // string | 
            var store = "store_example";  // string | 
            var updateTeamMemberStoreRequest = new UpdateTeamMemberStoreRequest(); // UpdateTeamMemberStoreRequest | 

            try
            {
                // Set a member's permissions and limits in one store.
                TeamMemberStoreResponse result = apiInstance.UpdateTeamMemberStore(id, store, updateTeamMemberStoreRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamApi.UpdateTeamMemberStore: " + e.Message );
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
 **store** | **string**|  | 
 **updateTeamMemberStoreRequest** | **UpdateTeamMemberStoreRequest**|  | 

### Return type

**TeamMemberStoreResponse**

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

