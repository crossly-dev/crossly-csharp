# net.crossly.Api.AccountsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /v1/accounts | Connect a new platform account (kicks off OAuth or extension handshake).
[**CreateConnectionCardnexusApiKey**](AccountsApi.md#createconnectioncardnexusapikey) | **POST** /v1/connections/cardnexus/api-key | Connect CardNexus with a personal API key (validated live before it is stored).
[**CreateConnectionEmailCheck**](AccountsApi.md#createconnectionemailcheck) | **POST** /v1/connections/email/{id}/check | Check an email connection now: sign in to it live (IMAP login, or a working Gmail / Outlook token) and, when that works and it is not paused, scan it straight away. data.ok false carries a plain reason.
[**CreateConnectionEmailImap**](AccountsApi.md#createconnectionemailimap) | **POST** /v1/connections/email/imap | Add an IMAP mailbox. The sign-in is verified before it is saved; most providers need an app password. watchedPlatforms picks the marketplaces it is read for (null &#x3D; all).
[**CreateConnectionEmailImapTest**](AccountsApi.md#createconnectionemailimaptest) | **POST** /v1/connections/email/imap/test | Check IMAP credentials without saving them. A failure is a 400 with a plain reason.
[**CreateConnectionLightspeedXToken**](AccountsApi.md#createconnectionlightspeedxtoken) | **POST** /v1/connections/lightspeed_x/token | Connect Lightspeed X-Series with a personal token (Setup → Personal tokens, Plus plan) and the store prefix.
[**CreateConnectionStoreAttach**](AccountsApi.md#createconnectionstoreattach) | **POST** /v1/connections/stores/attach | Let this store (X-Storefront-Id) use one of your marketplace accounts.
[**CreateConnectionStoreCopy**](AccountsApi.md#createconnectionstorecopy) | **POST** /v1/connections/stores/copy | Let several of your stores use a marketplace account at once.
[**CreateConnectionStoreDetach**](AccountsApi.md#createconnectionstoredetach) | **POST** /v1/connections/stores/detach | Stop this store using a marketplace account. The account stays connected for your other stores.
[**CreatePlatformAccountConnect**](AccountsApi.md#createplatformaccountconnect) | **POST** /v1/platform-accounts/{platform}/connect | Revive or initiate connection for a cookie platform.
[**CreatePlatformAccountDisconnect**](AccountsApi.md#createplatformaccountdisconnect) | **POST** /v1/platform-accounts/{platform}/disconnect | Disconnect every account of a platform (archives the rows and deletes their stored sessions).
[**CreatePlatformAccountHistoryImport**](AccountsApi.md#createplatformaccounthistoryimport) | **POST** /v1/platform-accounts/{platform}/history-import | Set how far back to backfill order history + active listings for a platform account (or every pending account of the platform), and run it now.
[**CreatePlatformAccountRefreshStatus**](AccountsApi.md#createplatformaccountrefreshstatus) | **POST** /v1/platform-accounts/refresh-status | Run on-demand healthchecks across cookie accounts.
[**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /v1/accounts/{id} | Disconnect a platform account.
[**DeleteConnectionById**](AccountsApi.md#deleteconnectionbyid) | **DELETE** /v1/connections/by-id/{id} | Disconnect a specific OAuth connection by id.
[**DeleteConnectionEmail**](AccountsApi.md#deleteconnectionemail) | **DELETE** /v1/connections/email/{id} | Disconnect an email connection.
[**DeleteConnectionEmailImap**](AccountsApi.md#deleteconnectionemailimap) | **DELETE** /v1/connections/email/imap/{id} | Disconnect an email connection.
[**DeleteConnectionOwnApp**](AccountsApi.md#deleteconnectionownapp) | **DELETE** /v1/connections/own-apps/{platform} | Remove your own developer app for a marketplace; the connections it authorized are switched off.
[**GetChannelAccountHistoryImport**](AccountsApi.md#getchannelaccounthistoryimport) | **GET** /v1/channel-accounts/{accountId}/history-import | Get one platform account&#39;s order-history import window (how far back its past sales and active listings import): days null &#x3D; All time, 0 &#x3D; None, N &#x3D; the last N days; chosen&#x3D;false &#x3D; never chosen.
[**GetConnectionEmail**](AccountsApi.md#getconnectionemail) | **GET** /v1/connections/email/{id} | One email connection: health, last scan, the marketplaces it watches and its 7-day counts.
[**GetConnectionExtensionOnline**](AccountsApi.md#getconnectionextensiononline) | **GET** /v1/connections/extension-online | Check if the browser extension is online.
[**GetConnectionPolicyManagementOption**](AccountsApi.md#getconnectionpolicymanagementoption) | **GET** /v1/connections/policy-management/{connectionId}/options/{source} | List the live options a marketplace policy field offers (e.g. Allegro delivery methods).
[**GetConnectionStore**](AccountsApi.md#getconnectionstore) | **GET** /v1/connections/stores | Your stores and which marketplace accounts each may use (its default per platform, and the store each account was connected from).
[**GetOauthInit**](AccountsApi.md#getoauthinit) | **GET** /v1/oauth/{platform}/init | Return the OAuth authorize URL for an API-track platform.
[**GetPlatformLimit**](AccountsApi.md#getplatformlimit) | **GET** /v1/platforms/limits | eBay free-tier + Etsy fees aggregate.
[**ListAccounts**](AccountsApi.md#listaccounts) | **GET** /v1/accounts | List your connected platform accounts.
[**ListConnectionEmail**](AccountsApi.md#listconnectionemail) | **GET** /v1/connections/email | List email connections (mailboxes Crossly reads marketplace email from).
[**ListConnectionEmailEmails**](AccountsApi.md#listconnectionemailemails) | **GET** /v1/connections/email/{id}/emails | An email connection&#39;s inbox: the marketplace emails Crossly picked up from it and what it did with each, newest first. Filter by platform, type, matched/unmatched and date; page with next_cursor.
[**ListConnectionOwnApps**](AccountsApi.md#listconnectionownapps) | **GET** /v1/connections/own-apps | List the marketplaces you can connect with your own developer app, and what you&#39;ve saved.
[**ListConnectionPolicyManagement**](AccountsApi.md#listconnectionpolicymanagement) | **GET** /v1/connections/policy-management | List eBay and Etsy accounts with whether Crossly manages their policies.
[**ListConnections**](AccountsApi.md#listconnections) | **GET** /v1/connections | List OAuth-connected API platforms, each flagged with whether this store (X-Storefront-Id) uses it.
[**ListPlatforms**](AccountsApi.md#listplatforms) | **GET** /v1/platforms | List marketplaces with their availability (connect, own_app, coming_soon) and capability chips.
[**UpdateChannelAccountHistoryImport**](AccountsApi.md#updatechannelaccounthistoryimport) | **PUT** /v1/channel-accounts/{accountId}/history-import | Set one platform account&#39;s order-history import window (how far back its past sales and active listings import). Runs the one-time backfill now when the account has not had it yet.
[**UpdateConnectionEmail**](AccountsApi.md#updateconnectionemail) | **PATCH** /v1/connections/email/{id} | Change an email connection: label, watchedPlatforms (null &#x3D; every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).
[**UpdateConnectionEmailImap**](AccountsApi.md#updateconnectionemailimap) | **PATCH** /v1/connections/email/imap/{id} | Change an email connection: label, watchedPlatforms (null &#x3D; every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).
[**UpdateConnectionOwnApp**](AccountsApi.md#updateconnectionownapp) | **PUT** /v1/connections/own-apps/{platform} | Save your own developer app for a marketplace (client id, secret and any required parameters).
[**UpdateConnectionPolicyManagement**](AccountsApi.md#updateconnectionpolicymanagement) | **PUT** /v1/connections/policy-management/{connectionId} | Turn Crossly policy management on or off for one eBay or Etsy account.
[**UpdatePlatformPreference**](AccountsApi.md#updateplatformpreference) | **PATCH** /v1/platforms/{platform}/preferences | Update per-platform connection preferences.


<a name="createaccount"></a>
# **CreateAccount**
> CreateAccountResponse CreateAccount (CreateAccountRequest createAccountRequest)

Connect a new platform account (kicks off OAuth or extension handshake).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createAccountRequest = new CreateAccountRequest(); // CreateAccountRequest | 

            try
            {
                // Connect a new platform account (kicks off OAuth or extension handshake).
                CreateAccountResponse result = apiInstance.CreateAccount(createAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateAccount: " + e.Message );
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
 **createAccountRequest** | **CreateAccountRequest**|  | 

### Return type

**CreateAccountResponse**

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

<a name="createconnectioncardnexusapikey"></a>
# **CreateConnectionCardnexusApiKey**
> CreateConnectionCardnexusApiKeyResponse CreateConnectionCardnexusApiKey (UpdateWeb3MarketplaceKeyRequest updateWeb3MarketplaceKeyRequest)

Connect CardNexus with a personal API key (validated live before it is stored).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionCardnexusApiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var updateWeb3MarketplaceKeyRequest = new UpdateWeb3MarketplaceKeyRequest(); // UpdateWeb3MarketplaceKeyRequest | 

            try
            {
                // Connect CardNexus with a personal API key (validated live before it is stored).
                CreateConnectionCardnexusApiKeyResponse result = apiInstance.CreateConnectionCardnexusApiKey(updateWeb3MarketplaceKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionCardnexusApiKey: " + e.Message );
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
 **updateWeb3MarketplaceKeyRequest** | **UpdateWeb3MarketplaceKeyRequest**|  | 

### Return type

**CreateConnectionCardnexusApiKeyResponse**

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

<a name="createconnectionemailcheck"></a>
# **CreateConnectionEmailCheck**
> CreateConnectionEmailCheckResponse CreateConnectionEmailCheck (Guid id)

Check an email connection now: sign in to it live (IMAP login, or a working Gmail / Outlook token) and, when that works and it is not paused, scan it straight away. data.ok false carries a plain reason.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionEmailCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Check an email connection now: sign in to it live (IMAP login, or a working Gmail / Outlook token) and, when that works and it is not paused, scan it straight away. data.ok false carries a plain reason.
                CreateConnectionEmailCheckResponse result = apiInstance.CreateConnectionEmailCheck(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionEmailCheck: " + e.Message );
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

**CreateConnectionEmailCheckResponse**

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

<a name="createconnectionemailimap"></a>
# **CreateConnectionEmailImap**
> CreateConnectionEmailImapResponse CreateConnectionEmailImap (CreateConnectionEmailImapRequest createConnectionEmailImapRequest)

Add an IMAP mailbox. The sign-in is verified before it is saved; most providers need an app password. watchedPlatforms picks the marketplaces it is read for (null = all).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionEmailImapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionEmailImapRequest = new CreateConnectionEmailImapRequest(); // CreateConnectionEmailImapRequest | 

            try
            {
                // Add an IMAP mailbox. The sign-in is verified before it is saved; most providers need an app password. watchedPlatforms picks the marketplaces it is read for (null = all).
                CreateConnectionEmailImapResponse result = apiInstance.CreateConnectionEmailImap(createConnectionEmailImapRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionEmailImap: " + e.Message );
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
 **createConnectionEmailImapRequest** | **CreateConnectionEmailImapRequest**|  | 

### Return type

**CreateConnectionEmailImapResponse**

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

<a name="createconnectionemailimaptest"></a>
# **CreateConnectionEmailImapTest**
> CreateConnectionEmailImapTestResponse CreateConnectionEmailImapTest (CreateConnectionEmailImapTestRequest createConnectionEmailImapTestRequest)

Check IMAP credentials without saving them. A failure is a 400 with a plain reason.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionEmailImapTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionEmailImapTestRequest = new CreateConnectionEmailImapTestRequest(); // CreateConnectionEmailImapTestRequest | 

            try
            {
                // Check IMAP credentials without saving them. A failure is a 400 with a plain reason.
                CreateConnectionEmailImapTestResponse result = apiInstance.CreateConnectionEmailImapTest(createConnectionEmailImapTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionEmailImapTest: " + e.Message );
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
 **createConnectionEmailImapTestRequest** | **CreateConnectionEmailImapTestRequest**|  | 

### Return type

**CreateConnectionEmailImapTestResponse**

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

<a name="createconnectionlightspeedxtoken"></a>
# **CreateConnectionLightspeedXToken**
> CreateConnectionLightspeedXTokenResponse CreateConnectionLightspeedXToken (CreateConnectionLightspeedXTokenRequest createConnectionLightspeedXTokenRequest)

Connect Lightspeed X-Series with a personal token (Setup → Personal tokens, Plus plan) and the store prefix.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionLightspeedXTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionLightspeedXTokenRequest = new CreateConnectionLightspeedXTokenRequest(); // CreateConnectionLightspeedXTokenRequest | 

            try
            {
                // Connect Lightspeed X-Series with a personal token (Setup → Personal tokens, Plus plan) and the store prefix.
                CreateConnectionLightspeedXTokenResponse result = apiInstance.CreateConnectionLightspeedXToken(createConnectionLightspeedXTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionLightspeedXToken: " + e.Message );
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
 **createConnectionLightspeedXTokenRequest** | **CreateConnectionLightspeedXTokenRequest**|  | 

### Return type

**CreateConnectionLightspeedXTokenResponse**

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

<a name="createconnectionstoreattach"></a>
# **CreateConnectionStoreAttach**
> CreateConnectionStoreAttachResponse CreateConnectionStoreAttach (CreateConnectionStoreAttachRequest createConnectionStoreAttachRequest = null)

Let this store (X-Storefront-Id) use one of your marketplace accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionStoreAttachExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionStoreAttachRequest = new CreateConnectionStoreAttachRequest(); // CreateConnectionStoreAttachRequest |  (optional) 

            try
            {
                // Let this store (X-Storefront-Id) use one of your marketplace accounts.
                CreateConnectionStoreAttachResponse result = apiInstance.CreateConnectionStoreAttach(createConnectionStoreAttachRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionStoreAttach: " + e.Message );
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
 **createConnectionStoreAttachRequest** | **CreateConnectionStoreAttachRequest**|  | [optional] 

### Return type

**CreateConnectionStoreAttachResponse**

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

<a name="createconnectionstorecopy"></a>
# **CreateConnectionStoreCopy**
> CreateConnectionStoreCopyResponse CreateConnectionStoreCopy (CreateConnectionStoreCopyRequest createConnectionStoreCopyRequest = null)

Let several of your stores use a marketplace account at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionStoreCopyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionStoreCopyRequest = new CreateConnectionStoreCopyRequest(); // CreateConnectionStoreCopyRequest |  (optional) 

            try
            {
                // Let several of your stores use a marketplace account at once.
                CreateConnectionStoreCopyResponse result = apiInstance.CreateConnectionStoreCopy(createConnectionStoreCopyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionStoreCopy: " + e.Message );
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
 **createConnectionStoreCopyRequest** | **CreateConnectionStoreCopyRequest**|  | [optional] 

### Return type

**CreateConnectionStoreCopyResponse**

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

<a name="createconnectionstoredetach"></a>
# **CreateConnectionStoreDetach**
> CreateConnectionStoreDetachResponse CreateConnectionStoreDetach (CreateConnectionStoreAttachRequest createConnectionStoreAttachRequest = null)

Stop this store using a marketplace account. The account stays connected for your other stores.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateConnectionStoreDetachExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var createConnectionStoreAttachRequest = new CreateConnectionStoreAttachRequest(); // CreateConnectionStoreAttachRequest |  (optional) 

            try
            {
                // Stop this store using a marketplace account. The account stays connected for your other stores.
                CreateConnectionStoreDetachResponse result = apiInstance.CreateConnectionStoreDetach(createConnectionStoreAttachRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateConnectionStoreDetach: " + e.Message );
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
 **createConnectionStoreAttachRequest** | **CreateConnectionStoreAttachRequest**|  | [optional] 

### Return type

**CreateConnectionStoreDetachResponse**

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

<a name="createplatformaccountconnect"></a>
# **CreatePlatformAccountConnect**
> CreatePlatformAccountConnectResponse CreatePlatformAccountConnect (string platform, CreatePlatformAccountConnectRequest createPlatformAccountConnectRequest = null)

Revive or initiate connection for a cookie platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePlatformAccountConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 
            var createPlatformAccountConnectRequest = new CreatePlatformAccountConnectRequest(); // CreatePlatformAccountConnectRequest |  (optional) 

            try
            {
                // Revive or initiate connection for a cookie platform.
                CreatePlatformAccountConnectResponse result = apiInstance.CreatePlatformAccountConnect(platform, createPlatformAccountConnectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePlatformAccountConnect: " + e.Message );
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
 **platform** | **string**|  | 
 **createPlatformAccountConnectRequest** | **CreatePlatformAccountConnectRequest**|  | [optional] 

### Return type

**CreatePlatformAccountConnectResponse**

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

<a name="createplatformaccountdisconnect"></a>
# **CreatePlatformAccountDisconnect**
> CreatePlatformAccountDisconnectResponse CreatePlatformAccountDisconnect (string platform)

Disconnect every account of a platform (archives the rows and deletes their stored sessions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePlatformAccountDisconnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 

            try
            {
                // Disconnect every account of a platform (archives the rows and deletes their stored sessions).
                CreatePlatformAccountDisconnectResponse result = apiInstance.CreatePlatformAccountDisconnect(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePlatformAccountDisconnect: " + e.Message );
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
 **platform** | **string**|  | 

### Return type

**CreatePlatformAccountDisconnectResponse**

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

<a name="createplatformaccounthistoryimport"></a>
# **CreatePlatformAccountHistoryImport**
> CreatePlatformAccountHistoryImportResponse CreatePlatformAccountHistoryImport (string platform, CreatePlatformAccountHistoryImportRequest createPlatformAccountHistoryImportRequest)

Set how far back to backfill order history + active listings for a platform account (or every pending account of the platform), and run it now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePlatformAccountHistoryImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 
            var createPlatformAccountHistoryImportRequest = new CreatePlatformAccountHistoryImportRequest(); // CreatePlatformAccountHistoryImportRequest | 

            try
            {
                // Set how far back to backfill order history + active listings for a platform account (or every pending account of the platform), and run it now.
                CreatePlatformAccountHistoryImportResponse result = apiInstance.CreatePlatformAccountHistoryImport(platform, createPlatformAccountHistoryImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePlatformAccountHistoryImport: " + e.Message );
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
 **platform** | **string**|  | 
 **createPlatformAccountHistoryImportRequest** | **CreatePlatformAccountHistoryImportRequest**|  | 

### Return type

**CreatePlatformAccountHistoryImportResponse**

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

<a name="createplatformaccountrefreshstatus"></a>
# **CreatePlatformAccountRefreshStatus**
> CreatePlatformAccountRefreshStatusResponse CreatePlatformAccountRefreshStatus ()

Run on-demand healthchecks across cookie accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePlatformAccountRefreshStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // Run on-demand healthchecks across cookie accounts.
                CreatePlatformAccountRefreshStatusResponse result = apiInstance.CreatePlatformAccountRefreshStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePlatformAccountRefreshStatus: " + e.Message );
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

**CreatePlatformAccountRefreshStatusResponse**

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

<a name="deleteaccount"></a>
# **DeleteAccount**
> OkResponse DeleteAccount (Guid id)

Disconnect a platform account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Disconnect a platform account.
                OkResponse result = apiInstance.DeleteAccount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAccount: " + e.Message );
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

<a name="deleteconnectionbyid"></a>
# **DeleteConnectionById**
> SuccessResponse DeleteConnectionById (Guid id)

Disconnect a specific OAuth connection by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteConnectionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Disconnect a specific OAuth connection by id.
                SuccessResponse result = apiInstance.DeleteConnectionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteConnectionById: " + e.Message );
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

**SuccessResponse**

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

<a name="deleteconnectionemail"></a>
# **DeleteConnectionEmail**
> DeleteConnectionEmailResponse DeleteConnectionEmail (Guid id)

Disconnect an email connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteConnectionEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Disconnect an email connection.
                DeleteConnectionEmailResponse result = apiInstance.DeleteConnectionEmail(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteConnectionEmail: " + e.Message );
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

**DeleteConnectionEmailResponse**

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

<a name="deleteconnectionemailimap"></a>
# **DeleteConnectionEmailImap**
> DeleteConnectionEmailResponse DeleteConnectionEmailImap (Guid id)

Disconnect an email connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteConnectionEmailImapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Disconnect an email connection.
                DeleteConnectionEmailResponse result = apiInstance.DeleteConnectionEmailImap(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteConnectionEmailImap: " + e.Message );
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

**DeleteConnectionEmailResponse**

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

<a name="deleteconnectionownapp"></a>
# **DeleteConnectionOwnApp**
> DeleteConnectionOwnAppResponse DeleteConnectionOwnApp (string platform)

Remove your own developer app for a marketplace; the connections it authorized are switched off.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteConnectionOwnAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 

            try
            {
                // Remove your own developer app for a marketplace; the connections it authorized are switched off.
                DeleteConnectionOwnAppResponse result = apiInstance.DeleteConnectionOwnApp(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteConnectionOwnApp: " + e.Message );
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
 **platform** | **string**|  | 

### Return type

**DeleteConnectionOwnAppResponse**

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

<a name="getchannelaccounthistoryimport"></a>
# **GetChannelAccountHistoryImport**
> GetChannelAccountHistoryImportResponse GetChannelAccountHistoryImport (Guid accountId)

Get one platform account's order-history import window (how far back its past sales and active listings import): days null = All time, 0 = None, N = the last N days; chosen=false = never chosen.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetChannelAccountHistoryImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Get one platform account's order-history import window (how far back its past sales and active listings import): days null = All time, 0 = None, N = the last N days; chosen=false = never chosen.
                GetChannelAccountHistoryImportResponse result = apiInstance.GetChannelAccountHistoryImport(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetChannelAccountHistoryImport: " + e.Message );
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
 **accountId** | **Guid**|  | 

### Return type

**GetChannelAccountHistoryImportResponse**

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

<a name="getconnectionemail"></a>
# **GetConnectionEmail**
> GetConnectionEmailResponse GetConnectionEmail (Guid id)

One email connection: health, last scan, the marketplaces it watches and its 7-day counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetConnectionEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One email connection: health, last scan, the marketplaces it watches and its 7-day counts.
                GetConnectionEmailResponse result = apiInstance.GetConnectionEmail(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConnectionEmail: " + e.Message );
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

**GetConnectionEmailResponse**

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

<a name="getconnectionextensiononline"></a>
# **GetConnectionExtensionOnline**
> GetConnectionExtensionOnlineResponse GetConnectionExtensionOnline ()

Check if the browser extension is online.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetConnectionExtensionOnlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // Check if the browser extension is online.
                GetConnectionExtensionOnlineResponse result = apiInstance.GetConnectionExtensionOnline();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConnectionExtensionOnline: " + e.Message );
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

**GetConnectionExtensionOnlineResponse**

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

<a name="getconnectionpolicymanagementoption"></a>
# **GetConnectionPolicyManagementOption**
> GetConnectionPolicyManagementOptionResponse GetConnectionPolicyManagementOption (string connectionId, string source)

List the live options a marketplace policy field offers (e.g. Allegro delivery methods).

For one of your managed connections, the choices a preset's `platformFields` picker offers, from the marketplace (`source` is the field's `optionsSource`, e.g. `delivery-methods`). An unknown connection or source is a 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetConnectionPolicyManagementOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var connectionId = "connectionId_example";  // string | 
            var source = "source_example";  // string | 

            try
            {
                // List the live options a marketplace policy field offers (e.g. Allegro delivery methods).
                GetConnectionPolicyManagementOptionResponse result = apiInstance.GetConnectionPolicyManagementOption(connectionId, source);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConnectionPolicyManagementOption: " + e.Message );
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
 **connectionId** | **string**|  | 
 **source** | **string**|  | 

### Return type

**GetConnectionPolicyManagementOptionResponse**

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

<a name="getconnectionstore"></a>
# **GetConnectionStore**
> GetConnectionStoreResponse GetConnectionStore ()

Your stores and which marketplace accounts each may use (its default per platform, and the store each account was connected from).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetConnectionStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // Your stores and which marketplace accounts each may use (its default per platform, and the store each account was connected from).
                GetConnectionStoreResponse result = apiInstance.GetConnectionStore();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConnectionStore: " + e.Message );
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

**GetConnectionStoreResponse**

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

<a name="getoauthinit"></a>
# **GetOauthInit**
> GetOauthInitResponse GetOauthInit (string platform, string shop = null, string region = null, string siteUrl = null)

Return the OAuth authorize URL for an API-track platform.

Most platforms return `{ url }` (Shopify, Etsy, Amazon and the other marketplaces Atlas Connections connects: the URL Atlas returns for this seller). Bonanza adds `{ oneShot: true }`. WooCommerce requires `?siteUrl=...`. Walmart (and CardNexus before its approval link) returns `{ status: \"own_credentials\", connectWith, docsUrl, message }`: connect with your own keys. An own_app marketplace (GET /api/v1/platforms) needs your app saved first (PUT /api/v1/connections/own-apps/:platform), else 400 own_app_required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetOauthInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 
            var shop = "shop_example";  // string |  (optional) 
            var region = "region_example";  // string |  (optional) 
            var siteUrl = "siteUrl_example";  // string |  (optional) 

            try
            {
                // Return the OAuth authorize URL for an API-track platform.
                GetOauthInitResponse result = apiInstance.GetOauthInit(platform, shop, region, siteUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetOauthInit: " + e.Message );
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
 **platform** | **string**|  | 
 **shop** | **string**|  | [optional] 
 **region** | **string**|  | [optional] 
 **siteUrl** | **string**|  | [optional] 

### Return type

**GetOauthInitResponse**

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

<a name="getplatformlimit"></a>
# **GetPlatformLimit**
> GetPlatformLimitResponse GetPlatformLimit ()

eBay free-tier + Etsy fees aggregate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPlatformLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // eBay free-tier + Etsy fees aggregate.
                GetPlatformLimitResponse result = apiInstance.GetPlatformLimit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetPlatformLimit: " + e.Message );
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

**GetPlatformLimitResponse**

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

<a name="listaccounts"></a>
# **ListAccounts**
> ListAccountsResponse ListAccounts ()

List your connected platform accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List your connected platform accounts.
                ListAccountsResponse result = apiInstance.ListAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAccounts: " + e.Message );
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

**ListAccountsResponse**

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

<a name="listconnectionemail"></a>
# **ListConnectionEmail**
> ListConnectionEmailResponse ListConnectionEmail ()

List email connections (mailboxes Crossly reads marketplace email from).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectionEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List email connections (mailboxes Crossly reads marketplace email from).
                ListConnectionEmailResponse result = apiInstance.ListConnectionEmail();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListConnectionEmail: " + e.Message );
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

**ListConnectionEmailResponse**

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

<a name="listconnectionemailemails"></a>
# **ListConnectionEmailEmails**
> ListConnectionEmailEmailsResponse ListConnectionEmailEmails (Guid id, string q = null, string platform = null, string type = null, string match = null, DateTime? from = null, DateTime? to = null, string cursor = null, int? limit = null)

An email connection's inbox: the marketplace emails Crossly picked up from it and what it did with each, newest first. Filter by platform, type, matched/unmatched and date; page with next_cursor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectionEmailEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 
            var q = "q_example";  // string |  (optional) 
            var platform = "platform_example";  // string |  (optional) 
            var type = "sale";  // string |  (optional) 
            var match = "matched";  // string |  (optional) 
            var from = DateTime.Parse("2013-10-20");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20");  // DateTime? |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // An email connection's inbox: the marketplace emails Crossly picked up from it and what it did with each, newest first. Filter by platform, type, matched/unmatched and date; page with next_cursor.
                ListConnectionEmailEmailsResponse result = apiInstance.ListConnectionEmailEmails(id, q, platform, type, match, from, to, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListConnectionEmailEmails: " + e.Message );
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
 **q** | **string**|  | [optional] 
 **platform** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **match** | **string**|  | [optional] 
 **from** | **DateTime?**|  | [optional] 
 **to** | **DateTime?**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListConnectionEmailEmailsResponse**

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

<a name="listconnectionownapps"></a>
# **ListConnectionOwnApps**
> ListConnectionOwnAppsResponse ListConnectionOwnApps ()

List the marketplaces you can connect with your own developer app, and what you've saved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectionOwnAppsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List the marketplaces you can connect with your own developer app, and what you've saved.
                ListConnectionOwnAppsResponse result = apiInstance.ListConnectionOwnApps();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListConnectionOwnApps: " + e.Message );
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

**ListConnectionOwnAppsResponse**

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

<a name="listconnectionpolicymanagement"></a>
# **ListConnectionPolicyManagement**
> ListConnectionPolicyManagementResponse ListConnectionPolicyManagement ()

List eBay and Etsy accounts with whether Crossly manages their policies.

One row per connected eBay or Etsy account: `eligible` (eBay only on EBAY_US), `managed` (Crossly keeps its policies / shipping profiles in step with your default presets) and sync `notes`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectionPolicyManagementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List eBay and Etsy accounts with whether Crossly manages their policies.
                ListConnectionPolicyManagementResponse result = apiInstance.ListConnectionPolicyManagement();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListConnectionPolicyManagement: " + e.Message );
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

**ListConnectionPolicyManagementResponse**

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

<a name="listconnections"></a>
# **ListConnections**
> ListConnectionsResponse ListConnections ()

List OAuth-connected API platforms, each flagged with whether this store (X-Storefront-Id) uses it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List OAuth-connected API platforms, each flagged with whether this store (X-Storefront-Id) uses it.
                ListConnectionsResponse result = apiInstance.ListConnections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListConnections: " + e.Message );
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

**ListConnectionsResponse**

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

<a name="listplatforms"></a>
# **ListPlatforms**
> ListPlatformsResponse ListPlatforms ()

List marketplaces with their availability (connect, own_app, coming_soon) and capability chips.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPlatformsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);

            try
            {
                // List marketplaces with their availability (connect, own_app, coming_soon) and capability chips.
                ListPlatformsResponse result = apiInstance.ListPlatforms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListPlatforms: " + e.Message );
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

**ListPlatformsResponse**

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

<a name="updatechannelaccounthistoryimport"></a>
# **UpdateChannelAccountHistoryImport**
> UpdateChannelAccountHistoryImportResponse UpdateChannelAccountHistoryImport (Guid accountId, UpdateChannelAccountHistoryImportRequest updateChannelAccountHistoryImportRequest)

Set one platform account's order-history import window (how far back its past sales and active listings import). Runs the one-time backfill now when the account has not had it yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateChannelAccountHistoryImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var accountId = "accountId_example";  // Guid | 
            var updateChannelAccountHistoryImportRequest = new UpdateChannelAccountHistoryImportRequest(); // UpdateChannelAccountHistoryImportRequest | 

            try
            {
                // Set one platform account's order-history import window (how far back its past sales and active listings import). Runs the one-time backfill now when the account has not had it yet.
                UpdateChannelAccountHistoryImportResponse result = apiInstance.UpdateChannelAccountHistoryImport(accountId, updateChannelAccountHistoryImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateChannelAccountHistoryImport: " + e.Message );
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
 **accountId** | **Guid**|  | 
 **updateChannelAccountHistoryImportRequest** | **UpdateChannelAccountHistoryImportRequest**|  | 

### Return type

**UpdateChannelAccountHistoryImportResponse**

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

<a name="updateconnectionemail"></a>
# **UpdateConnectionEmail**
> UpdateConnectionEmailResponse UpdateConnectionEmail (Guid id, UpdateConnectionEmailImapRequest updateConnectionEmailImapRequest)

Change an email connection: label, watchedPlatforms (null = every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateConnectionEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 
            var updateConnectionEmailImapRequest = new UpdateConnectionEmailImapRequest(); // UpdateConnectionEmailImapRequest | 

            try
            {
                // Change an email connection: label, watchedPlatforms (null = every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).
                UpdateConnectionEmailResponse result = apiInstance.UpdateConnectionEmail(id, updateConnectionEmailImapRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateConnectionEmail: " + e.Message );
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
 **updateConnectionEmailImapRequest** | **UpdateConnectionEmailImapRequest**|  | 

### Return type

**UpdateConnectionEmailResponse**

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

<a name="updateconnectionemailimap"></a>
# **UpdateConnectionEmailImap**
> UpdateConnectionEmailResponse UpdateConnectionEmailImap (Guid id, UpdateConnectionEmailImapRequest updateConnectionEmailImapRequest)

Change an email connection: label, watchedPlatforms (null = every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateConnectionEmailImapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var id = "id_example";  // Guid | 
            var updateConnectionEmailImapRequest = new UpdateConnectionEmailImapRequest(); // UpdateConnectionEmailImapRequest | 

            try
            {
                // Change an email connection: label, watchedPlatforms (null = every marketplace), isActive (false pauses it), or an IMAP server / username / password (the sign-in is verified first).
                UpdateConnectionEmailResponse result = apiInstance.UpdateConnectionEmailImap(id, updateConnectionEmailImapRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateConnectionEmailImap: " + e.Message );
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
 **updateConnectionEmailImapRequest** | **UpdateConnectionEmailImapRequest**|  | 

### Return type

**UpdateConnectionEmailResponse**

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

<a name="updateconnectionownapp"></a>
# **UpdateConnectionOwnApp**
> UpdateConnectionOwnAppResponse UpdateConnectionOwnApp (string platform, UpdateConnectionOwnAppRequest updateConnectionOwnAppRequest)

Save your own developer app for a marketplace (client id, secret and any required parameters).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateConnectionOwnAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 
            var updateConnectionOwnAppRequest = new UpdateConnectionOwnAppRequest(); // UpdateConnectionOwnAppRequest | 

            try
            {
                // Save your own developer app for a marketplace (client id, secret and any required parameters).
                UpdateConnectionOwnAppResponse result = apiInstance.UpdateConnectionOwnApp(platform, updateConnectionOwnAppRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateConnectionOwnApp: " + e.Message );
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
 **platform** | **string**|  | 
 **updateConnectionOwnAppRequest** | **UpdateConnectionOwnAppRequest**|  | 

### Return type

**UpdateConnectionOwnAppResponse**

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

<a name="updateconnectionpolicymanagement"></a>
# **UpdateConnectionPolicyManagement**
> ListConnectionPolicyManagementItem UpdateConnectionPolicyManagement (string connectionId, UpdateConnectionPolicyManagementRequest updateConnectionPolicyManagementRequest)

Turn Crossly policy management on or off for one eBay or Etsy account.

Body `{ managed: boolean }`. On: Crossly may overwrite that account's own policies with your default presets and queues a sync now (409 for an ineligible account, e.g. non-US eBay). Off: Crossly stops touching them. A connection that is not yours (or not eBay/Etsy) is a 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateConnectionPolicyManagementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var connectionId = "connectionId_example";  // string | 
            var updateConnectionPolicyManagementRequest = new UpdateConnectionPolicyManagementRequest(); // UpdateConnectionPolicyManagementRequest | 

            try
            {
                // Turn Crossly policy management on or off for one eBay or Etsy account.
                ListConnectionPolicyManagementItem result = apiInstance.UpdateConnectionPolicyManagement(connectionId, updateConnectionPolicyManagementRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateConnectionPolicyManagement: " + e.Message );
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
 **connectionId** | **string**|  | 
 **updateConnectionPolicyManagementRequest** | **UpdateConnectionPolicyManagementRequest**|  | 

### Return type

**ListConnectionPolicyManagementItem**

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

<a name="updateplatformpreference"></a>
# **UpdatePlatformPreference**
> UpdatePlatformPreferenceResponse UpdatePlatformPreference (string platform, UpdatePlatformPreferenceRequest updatePlatformPreferenceRequest, Guid? connectionId = null)

Update per-platform connection preferences.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePlatformPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var platform = "platform_example";  // string | 
            var updatePlatformPreferenceRequest = new UpdatePlatformPreferenceRequest(); // UpdatePlatformPreferenceRequest | 
            var connectionId = "connectionId_example";  // Guid? |  (optional) 

            try
            {
                // Update per-platform connection preferences.
                UpdatePlatformPreferenceResponse result = apiInstance.UpdatePlatformPreference(platform, updatePlatformPreferenceRequest, connectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdatePlatformPreference: " + e.Message );
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
 **platform** | **string**|  | 
 **updatePlatformPreferenceRequest** | **UpdatePlatformPreferenceRequest**|  | 
 **connectionId** | **Guid?**|  | [optional] 

### Return type

**UpdatePlatformPreferenceResponse**

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

