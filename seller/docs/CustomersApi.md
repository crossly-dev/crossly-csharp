# net.crossly.Api.CustomersApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomerBulkDelete**](CustomersApi.md#createcustomerbulkdelete) | **POST** /v1/customers/bulk-delete | Bulk blocklist customer handles.
[**CreateCustomerBulkExport**](CustomersApi.md#createcustomerbulkexport) | **POST** /v1/customers/bulk-export | Bulk export aggregated customers as CSV.
[**CreateCustomerRefreshProfile**](CustomersApi.md#createcustomerrefreshprofile) | **POST** /v1/customers/{handle}/refresh-profile | Queue a fresh read of a customer&#39;s buyer profiles on every platform they ordered on.
[**CreateLoyaltyAirdropCancel**](CustomersApi.md#createloyaltyairdropcancel) | **POST** /v1/loyalty/airdrops/{id}/cancel | Cancel a queued or failed airdrop (one already sent is the member’s).
[**CreateLoyaltyAirdropCheck**](CustomersApi.md#createloyaltyairdropcheck) | **POST** /v1/loyalty/airdrops/{id}/check | Read a submitted airdrop’s receipt again now.
[**CreateLoyaltyAirdropPrepare**](CustomersApi.md#createloyaltyairdropprepare) | **POST** /v1/loyalty/airdrops/{id}/prepare | The mint transaction for your launch owner wallet to send: chain, from, to (your launch contract) and calldata, to the member’s verified wallet. Refused airdrop_not_sendable with a reason when it cannot be built.
[**CreateLoyaltyAirdropSubmit**](CustomersApi.md#createloyaltyairdropsubmit) | **POST** /v1/loyalty/airdrops/{id}/submit | Record the hash your wallet broadcast; Crossly reads the receipt (now, then on a schedule) and marks it sent or failed.
[**CreateLoyaltyProgramInvite**](CustomersApi.md#createloyaltyprograminvite) | **POST** /v1/loyalty/program/invite | Invite Crossly buyers to your loyalty program by user id (up to 500); returns how many were newly invited.
[**CreateLoyaltyProgramMemberOverride**](CustomersApi.md#createloyaltyprogrammemberoverride) | **POST** /v1/loyalty/program/members/{id}/override | Pin a member to a tier (tierId null clears the pin), with a reason.
[**CreateLoyaltyProgramMemberPoint**](CustomersApi.md#createloyaltyprogrammemberpoint) | **POST** /v1/loyalty/program/members/{id}/points | Give a member points by hand (Idempotency-Key required: the same key awards once). Fires loyalty.points_awarded.
[**CreateLoyaltyTier**](CustomersApi.md#createloyaltytier) | **POST** /v1/loyalty/tiers | Add a tier: name, look, threshold and typed perks (% off, free shipping, early access, members-only listings, wholesale access, token gates, airdrops, Bucks, World items, event tickets, …).
[**DeleteLoyaltyReward**](CustomersApi.md#deleteloyaltyreward) | **DELETE** /v1/loyalty/rewards/{rewardId} | Take a reward off the shelf. Perks already redeemed stay with their buyers.
[**DeleteLoyaltyTier**](CustomersApi.md#deleteloyaltytier) | **DELETE** /v1/loyalty/tiers/{id} | Delete a tier; its members are re-evaluated.
[**GetCustomer**](CustomersApi.md#getcustomer) | **GET** /v1/customers/{handle} | Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.
[**GetCustomerNote**](CustomersApi.md#getcustomernote) | **GET** /v1/customers/{handle}/notes | Your private notes on a customer (empty when none). Works before their first order.
[**GetLoyaltyAirdrop**](CustomersApi.md#getloyaltyairdrop) | **GET** /v1/loyalty/airdrops/{id} | One loyalty NFT airdrop: member, collection, recipient wallet, transaction hash and status.
[**GetLoyaltyClub**](CustomersApi.md#getloyaltyclub) | **GET** /v1/loyalty/club | Your loyalty club: tiers and how many members are in each.
[**GetLoyaltyProgram**](CustomersApi.md#getloyaltyprogram) | **GET** /v1/loyalty/program | Your loyalty program: qualification (spend, orders, points), window, joining, downgrade and grace, and its tiers with typed perks.
[**GetLoyaltyProgramMember**](CustomersApi.md#getloyaltyprogrammember) | **GET** /v1/loyalty/program/members/{id} | One member: standing, tier, progress, perks held, history and any override.
[**ListCustomers**](CustomersApi.md#listcustomers) | **GET** /v1/customers | List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.
[**ListLoyaltyAirdrops**](CustomersApi.md#listloyaltyairdrops) | **GET** /v1/loyalty/airdrops | NFT airdrops your loyalty tiers earned members: queued to send, submitted (waiting on the receipt), sent, failed (with why) or cancelled.
[**ListLoyaltyMembers**](CustomersApi.md#listloyaltymembers) | **GET** /v1/loyalty/members | Your loyalty club’s members, by spend with you.
[**ListLoyaltyProgramInviteCandidates**](CustomersApi.md#listloyaltyprograminvitecandidates) | **GET** /v1/loyalty/program/invite-candidates | Crossly buyers who bought from you and are not loyalty members yet (q searches by name): who you can invite.
[**ListLoyaltyProgramMemberPoints**](CustomersApi.md#listloyaltyprogrammemberpoints) | **GET** /v1/loyalty/program/members/{id}/points | A member’s points history: purchases, hunts, event check-ins, photo reviews, group buys, manual grants and redeemed rewards.
[**ListLoyaltyProgramMembers**](CustomersApi.md#listloyaltyprogrammembers) | **GET** /v1/loyalty/program/members | Your loyalty members with tier, standing, grace and overrides; search, tier, status and sort filters.
[**ListLoyaltyRewards**](CustomersApi.md#listloyaltyrewards) | **GET** /v1/loyalty/rewards | Your loyalty rewards shelf: typed perks members buy with points, each with its cost, stock left, per-member limit and how many were redeemed.
[**UpdateCustomerNote**](CustomersApi.md#updatecustomernote) | **PUT** /v1/customers/{handle}/notes | Save your private notes on a customer (an empty string clears them).
[**UpdateLoyaltyClub**](CustomersApi.md#updateloyaltyclub) | **PUT** /v1/loyalty/club | Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.
[**UpdateLoyaltyProgram**](CustomersApi.md#updateloyaltyprogram) | **PUT** /v1/loyalty/program | Create or update your loyalty program settings.
[**UpdateLoyaltyReward**](CustomersApi.md#updateloyaltyreward) | **PUT** /v1/loyalty/rewards | Replace the rewards shelf (up to 50 rewards). A price perk (% off, $ off, free shipping) is redeemed as a single-use code.
[**UpdateLoyaltyRewardByRewardId**](CustomersApi.md#updateloyaltyrewardbyrewardid) | **PUT** /v1/loyalty/rewards/{rewardId} | Add a reward to the shelf, or replace the one with this id.
[**UpdateLoyaltyTier**](CustomersApi.md#updateloyaltytier) | **PUT** /v1/loyalty/tiers/{id} | Replace a tier. Members holding it get the edited perks.


<a name="createcustomerbulkdelete"></a>
# **CreateCustomerBulkDelete**
> CreateCustomerBulkDeleteResponse CreateCustomerBulkDelete (CreateCustomerBulkDeleteRequest createCustomerBulkDeleteRequest)

Bulk blocklist customer handles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerBulkDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var createCustomerBulkDeleteRequest = new CreateCustomerBulkDeleteRequest(); // CreateCustomerBulkDeleteRequest | 

            try
            {
                // Bulk blocklist customer handles.
                CreateCustomerBulkDeleteResponse result = apiInstance.CreateCustomerBulkDelete(createCustomerBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerBulkDelete: " + e.Message );
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
 **createCustomerBulkDeleteRequest** | **CreateCustomerBulkDeleteRequest**|  | 

### Return type

**CreateCustomerBulkDeleteResponse**

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

<a name="createcustomerbulkexport"></a>
# **CreateCustomerBulkExport**
> string CreateCustomerBulkExport (CreateCustomerBulkDeleteRequest createCustomerBulkDeleteRequest)

Bulk export aggregated customers as CSV.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerBulkExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var createCustomerBulkDeleteRequest = new CreateCustomerBulkDeleteRequest(); // CreateCustomerBulkDeleteRequest | 

            try
            {
                // Bulk export aggregated customers as CSV.
                string result = apiInstance.CreateCustomerBulkExport(createCustomerBulkDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerBulkExport: " + e.Message );
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
 **createCustomerBulkDeleteRequest** | **CreateCustomerBulkDeleteRequest**|  | 

### Return type

**string**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A CSV file. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createcustomerrefreshprofile"></a>
# **CreateCustomerRefreshProfile**
> CreateCustomerRefreshProfileResponse CreateCustomerRefreshProfile (string handle)

Queue a fresh read of a customer's buyer profiles on every platform they ordered on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerRefreshProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Queue a fresh read of a customer's buyer profiles on every platform they ordered on.
                CreateCustomerRefreshProfileResponse result = apiInstance.CreateCustomerRefreshProfile(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerRefreshProfile: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**CreateCustomerRefreshProfileResponse**

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

<a name="createloyaltyairdropcancel"></a>
# **CreateLoyaltyAirdropCancel**
> LoyaltyAirdropResponse CreateLoyaltyAirdropCancel (string id)

Cancel a queued or failed airdrop (one already sent is the member’s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyAirdropCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a queued or failed airdrop (one already sent is the member’s).
                LoyaltyAirdropResponse result = apiInstance.CreateLoyaltyAirdropCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyAirdropCancel: " + e.Message );
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

**LoyaltyAirdropResponse**

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

<a name="createloyaltyairdropcheck"></a>
# **CreateLoyaltyAirdropCheck**
> LoyaltyAirdropResponse CreateLoyaltyAirdropCheck (string id)

Read a submitted airdrop’s receipt again now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyAirdropCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Read a submitted airdrop’s receipt again now.
                LoyaltyAirdropResponse result = apiInstance.CreateLoyaltyAirdropCheck(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyAirdropCheck: " + e.Message );
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

**LoyaltyAirdropResponse**

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

<a name="createloyaltyairdropprepare"></a>
# **CreateLoyaltyAirdropPrepare**
> CreateLoyaltyAirdropPrepareResponse CreateLoyaltyAirdropPrepare (string id)

The mint transaction for your launch owner wallet to send: chain, from, to (your launch contract) and calldata, to the member’s verified wallet. Refused airdrop_not_sendable with a reason when it cannot be built.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyAirdropPrepareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The mint transaction for your launch owner wallet to send: chain, from, to (your launch contract) and calldata, to the member’s verified wallet. Refused airdrop_not_sendable with a reason when it cannot be built.
                CreateLoyaltyAirdropPrepareResponse result = apiInstance.CreateLoyaltyAirdropPrepare(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyAirdropPrepare: " + e.Message );
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

**CreateLoyaltyAirdropPrepareResponse**

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

<a name="createloyaltyairdropsubmit"></a>
# **CreateLoyaltyAirdropSubmit**
> LoyaltyAirdropResponse CreateLoyaltyAirdropSubmit (string id, CreateLoyaltyAirdropSubmitRequest createLoyaltyAirdropSubmitRequest)

Record the hash your wallet broadcast; Crossly reads the receipt (now, then on a schedule) and marks it sent or failed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyAirdropSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 
            var createLoyaltyAirdropSubmitRequest = new CreateLoyaltyAirdropSubmitRequest(); // CreateLoyaltyAirdropSubmitRequest | 

            try
            {
                // Record the hash your wallet broadcast; Crossly reads the receipt (now, then on a schedule) and marks it sent or failed.
                LoyaltyAirdropResponse result = apiInstance.CreateLoyaltyAirdropSubmit(id, createLoyaltyAirdropSubmitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyAirdropSubmit: " + e.Message );
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
 **createLoyaltyAirdropSubmitRequest** | **CreateLoyaltyAirdropSubmitRequest**|  | 

### Return type

**LoyaltyAirdropResponse**

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

<a name="createloyaltyprograminvite"></a>
# **CreateLoyaltyProgramInvite**
> CreateLoyaltyProgramInviteResponse CreateLoyaltyProgramInvite (CreateLoyaltyProgramInviteRequest createLoyaltyProgramInviteRequest)

Invite Crossly buyers to your loyalty program by user id (up to 500); returns how many were newly invited.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyProgramInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var createLoyaltyProgramInviteRequest = new CreateLoyaltyProgramInviteRequest(); // CreateLoyaltyProgramInviteRequest | 

            try
            {
                // Invite Crossly buyers to your loyalty program by user id (up to 500); returns how many were newly invited.
                CreateLoyaltyProgramInviteResponse result = apiInstance.CreateLoyaltyProgramInvite(createLoyaltyProgramInviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyProgramInvite: " + e.Message );
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
 **createLoyaltyProgramInviteRequest** | **CreateLoyaltyProgramInviteRequest**|  | 

### Return type

**CreateLoyaltyProgramInviteResponse**

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

<a name="createloyaltyprogrammemberoverride"></a>
# **CreateLoyaltyProgramMemberOverride**
> GetLoyaltyProgramMemberResponse CreateLoyaltyProgramMemberOverride (string id, CreateLoyaltyProgramMemberOverrideRequest createLoyaltyProgramMemberOverrideRequest)

Pin a member to a tier (tierId null clears the pin), with a reason.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyProgramMemberOverrideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 
            var createLoyaltyProgramMemberOverrideRequest = new CreateLoyaltyProgramMemberOverrideRequest(); // CreateLoyaltyProgramMemberOverrideRequest | 

            try
            {
                // Pin a member to a tier (tierId null clears the pin), with a reason.
                GetLoyaltyProgramMemberResponse result = apiInstance.CreateLoyaltyProgramMemberOverride(id, createLoyaltyProgramMemberOverrideRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyProgramMemberOverride: " + e.Message );
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
 **createLoyaltyProgramMemberOverrideRequest** | **CreateLoyaltyProgramMemberOverrideRequest**|  | 

### Return type

**GetLoyaltyProgramMemberResponse**

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

<a name="createloyaltyprogrammemberpoint"></a>
# **CreateLoyaltyProgramMemberPoint**
> CreateLoyaltyProgramMemberPointResponse CreateLoyaltyProgramMemberPoint (string id, CreateLoyaltyProgramMemberPointRequest createLoyaltyProgramMemberPointRequest)

Give a member points by hand (Idempotency-Key required: the same key awards once). Fires loyalty.points_awarded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyProgramMemberPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 
            var createLoyaltyProgramMemberPointRequest = new CreateLoyaltyProgramMemberPointRequest(); // CreateLoyaltyProgramMemberPointRequest | 

            try
            {
                // Give a member points by hand (Idempotency-Key required: the same key awards once). Fires loyalty.points_awarded.
                CreateLoyaltyProgramMemberPointResponse result = apiInstance.CreateLoyaltyProgramMemberPoint(id, createLoyaltyProgramMemberPointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyProgramMemberPoint: " + e.Message );
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
 **createLoyaltyProgramMemberPointRequest** | **CreateLoyaltyProgramMemberPointRequest**|  | 

### Return type

**CreateLoyaltyProgramMemberPointResponse**

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

<a name="createloyaltytier"></a>
# **CreateLoyaltyTier**
> CreateLoyaltyTierResponse CreateLoyaltyTier ()

Add a tier: name, look, threshold and typed perks (% off, free shipping, early access, members-only listings, wholesale access, token gates, airdrops, Bucks, World items, event tickets, …).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLoyaltyTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Add a tier: name, look, threshold and typed perks (% off, free shipping, early access, members-only listings, wholesale access, token gates, airdrops, Bucks, World items, event tickets, …).
                CreateLoyaltyTierResponse result = apiInstance.CreateLoyaltyTier();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateLoyaltyTier: " + e.Message );
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

**CreateLoyaltyTierResponse**

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

<a name="deleteloyaltyreward"></a>
# **DeleteLoyaltyReward**
> UpdateGroupBuyResponse DeleteLoyaltyReward (string rewardId)

Take a reward off the shelf. Perks already redeemed stay with their buyers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteLoyaltyRewardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var rewardId = "rewardId_example";  // string | 

            try
            {
                // Take a reward off the shelf. Perks already redeemed stay with their buyers.
                UpdateGroupBuyResponse result = apiInstance.DeleteLoyaltyReward(rewardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteLoyaltyReward: " + e.Message );
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
 **rewardId** | **string**|  | 

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

<a name="deleteloyaltytier"></a>
# **DeleteLoyaltyTier**
> UpdateGroupBuyResponse DeleteLoyaltyTier (string id)

Delete a tier; its members are re-evaluated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteLoyaltyTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a tier; its members are re-evaluated.
                UpdateGroupBuyResponse result = apiInstance.DeleteLoyaltyTier(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteLoyaltyTier: " + e.Message );
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

<a name="getcustomer"></a>
# **GetCustomer**
> GetCustomerResponse GetCustomer (string handle)

Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.
                GetCustomerResponse result = apiInstance.GetCustomer(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomer: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetCustomerResponse**

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

<a name="getcustomernote"></a>
# **GetCustomerNote**
> GetCustomerNoteResponse GetCustomerNote (string handle)

Your private notes on a customer (empty when none). Works before their first order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCustomerNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Your private notes on a customer (empty when none). Works before their first order.
                GetCustomerNoteResponse result = apiInstance.GetCustomerNote(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerNote: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetCustomerNoteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getloyaltyairdrop"></a>
# **GetLoyaltyAirdrop**
> LoyaltyAirdropResponse GetLoyaltyAirdrop (string id)

One loyalty NFT airdrop: member, collection, recipient wallet, transaction hash and status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLoyaltyAirdropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One loyalty NFT airdrop: member, collection, recipient wallet, transaction hash and status.
                LoyaltyAirdropResponse result = apiInstance.GetLoyaltyAirdrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetLoyaltyAirdrop: " + e.Message );
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

**LoyaltyAirdropResponse**

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

<a name="getloyaltyclub"></a>
# **GetLoyaltyClub**
> GetLoyaltyClubResponse GetLoyaltyClub ()

Your loyalty club: tiers and how many members are in each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLoyaltyClubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty club: tiers and how many members are in each.
                GetLoyaltyClubResponse result = apiInstance.GetLoyaltyClub();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetLoyaltyClub: " + e.Message );
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

**GetLoyaltyClubResponse**

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

<a name="getloyaltyprogram"></a>
# **GetLoyaltyProgram**
> GetLoyaltyProgramResponse GetLoyaltyProgram ()

Your loyalty program: qualification (spend, orders, points), window, joining, downgrade and grace, and its tiers with typed perks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLoyaltyProgramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty program: qualification (spend, orders, points), window, joining, downgrade and grace, and its tiers with typed perks.
                GetLoyaltyProgramResponse result = apiInstance.GetLoyaltyProgram();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetLoyaltyProgram: " + e.Message );
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

**GetLoyaltyProgramResponse**

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

<a name="getloyaltyprogrammember"></a>
# **GetLoyaltyProgramMember**
> GetLoyaltyProgramMemberResponse GetLoyaltyProgramMember (string id)

One member: standing, tier, progress, perks held, history and any override.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLoyaltyProgramMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One member: standing, tier, progress, perks held, history and any override.
                GetLoyaltyProgramMemberResponse result = apiInstance.GetLoyaltyProgramMember(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetLoyaltyProgramMember: " + e.Message );
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

**GetLoyaltyProgramMemberResponse**

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

<a name="listcustomers"></a>
# **ListCustomers**
> ListCustomersResponse ListCustomers ()

List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCustomersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.
                ListCustomersResponse result = apiInstance.ListCustomers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomers: " + e.Message );
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

**ListCustomersResponse**

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

<a name="listloyaltyairdrops"></a>
# **ListLoyaltyAirdrops**
> ListLoyaltyAirdropsResponse ListLoyaltyAirdrops (string status = null, decimal? limit = null)

NFT airdrops your loyalty tiers earned members: queued to send, submitted (waiting on the receipt), sent, failed (with why) or cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyAirdropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var status = "cancelled";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // NFT airdrops your loyalty tiers earned members: queued to send, submitted (waiting on the receipt), sent, failed (with why) or cancelled.
                ListLoyaltyAirdropsResponse result = apiInstance.ListLoyaltyAirdrops(status, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyAirdrops: " + e.Message );
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

**ListLoyaltyAirdropsResponse**

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

<a name="listloyaltymembers"></a>
# **ListLoyaltyMembers**
> ListLoyaltyMembersResponse ListLoyaltyMembers ()

Your loyalty club’s members, by spend with you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty club’s members, by spend with you.
                ListLoyaltyMembersResponse result = apiInstance.ListLoyaltyMembers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyMembers: " + e.Message );
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

**ListLoyaltyMembersResponse**

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

<a name="listloyaltyprograminvitecandidates"></a>
# **ListLoyaltyProgramInviteCandidates**
> ListLoyaltyProgramInviteCandidatesResponse ListLoyaltyProgramInviteCandidates ()

Crossly buyers who bought from you and are not loyalty members yet (q searches by name): who you can invite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyProgramInviteCandidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Crossly buyers who bought from you and are not loyalty members yet (q searches by name): who you can invite.
                ListLoyaltyProgramInviteCandidatesResponse result = apiInstance.ListLoyaltyProgramInviteCandidates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyProgramInviteCandidates: " + e.Message );
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

**ListLoyaltyProgramInviteCandidatesResponse**

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

<a name="listloyaltyprogrammemberpoints"></a>
# **ListLoyaltyProgramMemberPoints**
> ListLoyaltyProgramMemberPointsResponse ListLoyaltyProgramMemberPoints (string id)

A member’s points history: purchases, hunts, event check-ins, photo reviews, group buys, manual grants and redeemed rewards.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyProgramMemberPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A member’s points history: purchases, hunts, event check-ins, photo reviews, group buys, manual grants and redeemed rewards.
                ListLoyaltyProgramMemberPointsResponse result = apiInstance.ListLoyaltyProgramMemberPoints(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyProgramMemberPoints: " + e.Message );
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

**ListLoyaltyProgramMemberPointsResponse**

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

<a name="listloyaltyprogrammembers"></a>
# **ListLoyaltyProgramMembers**
> ListLoyaltyProgramMembersResponse ListLoyaltyProgramMembers ()

Your loyalty members with tier, standing, grace and overrides; search, tier, status and sort filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyProgramMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty members with tier, standing, grace and overrides; search, tier, status and sort filters.
                ListLoyaltyProgramMembersResponse result = apiInstance.ListLoyaltyProgramMembers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyProgramMembers: " + e.Message );
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

**ListLoyaltyProgramMembersResponse**

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

<a name="listloyaltyrewards"></a>
# **ListLoyaltyRewards**
> ListLoyaltyRewardsResponse ListLoyaltyRewards ()

Your loyalty rewards shelf: typed perks members buy with points, each with its cost, stock left, per-member limit and how many were redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty rewards shelf: typed perks members buy with points, each with its cost, stock left, per-member limit and how many were redeemed.
                ListLoyaltyRewardsResponse result = apiInstance.ListLoyaltyRewards();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyRewards: " + e.Message );
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

**ListLoyaltyRewardsResponse**

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

<a name="updatecustomernote"></a>
# **UpdateCustomerNote**
> GetCustomerNoteResponse UpdateCustomerNote (string handle, UpdateCustomerNoteRequest updateCustomerNoteRequest)

Save your private notes on a customer (an empty string clears them).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateCustomerNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 
            var updateCustomerNoteRequest = new UpdateCustomerNoteRequest(); // UpdateCustomerNoteRequest | 

            try
            {
                // Save your private notes on a customer (an empty string clears them).
                GetCustomerNoteResponse result = apiInstance.UpdateCustomerNote(handle, updateCustomerNoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerNote: " + e.Message );
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
 **handle** | **string**|  | 
 **updateCustomerNoteRequest** | **UpdateCustomerNoteRequest**|  | 

### Return type

**GetCustomerNoteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateloyaltyclub"></a>
# **UpdateLoyaltyClub**
> GetLoyaltyClubResponse UpdateLoyaltyClub (UpdateLoyaltyClubRequest updateLoyaltyClubRequest)

Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyClubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var updateLoyaltyClubRequest = new UpdateLoyaltyClubRequest(); // UpdateLoyaltyClubRequest | 

            try
            {
                // Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.
                GetLoyaltyClubResponse result = apiInstance.UpdateLoyaltyClub(updateLoyaltyClubRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyClub: " + e.Message );
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
 **updateLoyaltyClubRequest** | **UpdateLoyaltyClubRequest**|  | 

### Return type

**GetLoyaltyClubResponse**

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

<a name="updateloyaltyprogram"></a>
# **UpdateLoyaltyProgram**
> UpdateLoyaltyProgramResponse UpdateLoyaltyProgram ()

Create or update your loyalty program settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyProgramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Create or update your loyalty program settings.
                UpdateLoyaltyProgramResponse result = apiInstance.UpdateLoyaltyProgram();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyProgram: " + e.Message );
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

**UpdateLoyaltyProgramResponse**

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

<a name="updateloyaltyreward"></a>
# **UpdateLoyaltyReward**
> ListLoyaltyRewardsResponse UpdateLoyaltyReward (UpdateLoyaltyRewardRequest updateLoyaltyRewardRequest)

Replace the rewards shelf (up to 50 rewards). A price perk (% off, $ off, free shipping) is redeemed as a single-use code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyRewardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var updateLoyaltyRewardRequest = new UpdateLoyaltyRewardRequest(); // UpdateLoyaltyRewardRequest | 

            try
            {
                // Replace the rewards shelf (up to 50 rewards). A price perk (% off, $ off, free shipping) is redeemed as a single-use code.
                ListLoyaltyRewardsResponse result = apiInstance.UpdateLoyaltyReward(updateLoyaltyRewardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyReward: " + e.Message );
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
 **updateLoyaltyRewardRequest** | **UpdateLoyaltyRewardRequest**|  | 

### Return type

**ListLoyaltyRewardsResponse**

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

<a name="updateloyaltyrewardbyrewardid"></a>
# **UpdateLoyaltyRewardByRewardId**
> UpdateLoyaltyRewardByRewardIdResponse UpdateLoyaltyRewardByRewardId (string rewardId)

Add a reward to the shelf, or replace the one with this id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyRewardByRewardIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var rewardId = "rewardId_example";  // string | 

            try
            {
                // Add a reward to the shelf, or replace the one with this id.
                UpdateLoyaltyRewardByRewardIdResponse result = apiInstance.UpdateLoyaltyRewardByRewardId(rewardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyRewardByRewardId: " + e.Message );
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
 **rewardId** | **string**|  | 

### Return type

**UpdateLoyaltyRewardByRewardIdResponse**

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

<a name="updateloyaltytier"></a>
# **UpdateLoyaltyTier**
> CreateLoyaltyTierResponse UpdateLoyaltyTier (string id)

Replace a tier. Members holding it get the edited perks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Replace a tier. Members holding it get the edited perks.
                CreateLoyaltyTierResponse result = apiInstance.UpdateLoyaltyTier(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyTier: " + e.Message );
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

**CreateLoyaltyTierResponse**

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

