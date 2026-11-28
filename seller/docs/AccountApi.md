# net.crossly.Api.AccountApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccountCancelDeletion**](AccountApi.md#createaccountcanceldeletion) | **POST** /v1/account/cancel-deletion | Cancel a pending account deletion.
[**CreateAccountIdentityVerificationStart**](AccountApi.md#createaccountidentityverificationstart) | **POST** /v1/account/identity-verification/start | Start the identity check (photo ID + selfie). Returns a Stripe-hosted URL the person completes.
[**CreateAccountLogoutAll**](AccountApi.md#createaccountlogoutall) | **POST** /v1/account/logout-all | Revoke every browser auth session for this user.
[**CreateAccountReconfirmDeletion**](AccountApi.md#createaccountreconfirmdeletion) | **POST** /v1/account/reconfirm-deletion | Confirm again a deletion paused because the account was in use.
[**CreateAccountRequestDeletion**](AccountApi.md#createaccountrequestdeletion) | **POST** /v1/account/request-deletion | Schedule account deletion after a grace period. Requires confirmEmail.
[**CreateAuthSessionSignOut**](AccountApi.md#createauthsessionsignout) | **POST** /v1/auth/sessions/sign-out | Sign out several sessions at once.
[**DeleteAuthSession**](AccountApi.md#deleteauthsession) | **DELETE** /v1/auth/sessions | Revoke all active browser sessions.
[**DeleteAuthSessionBySessionId**](AccountApi.md#deleteauthsessionbysessionid) | **DELETE** /v1/auth/sessions/{sessionId} | Revoke a single browser session by id.
[**DeleteConnectedApp**](AccountApi.md#deleteconnectedapp) | **DELETE** /v1/connected-apps/{grantId} | Disconnect a third-party app. Its tokens stop working immediately.
[**GetAccountClosureChecklist**](AccountApi.md#getaccountclosurechecklist) | **GET** /v1/account/closure-checklist | What closing the account will and will not do, before you request it.
[**GetAccountDeletionStatus**](AccountApi.md#getaccountdeletionstatus) | **GET** /v1/account/deletion-status | Get the currently-pending deletion request, if any.
[**GetAccountIdentityVerification**](AccountApi.md#getaccountidentityverification) | **GET** /v1/account/identity-verification | Your identity verification: one status for the whole account, read by every feature that needs ID.
[**GetAccountNotificationPreference**](AccountApi.md#getaccountnotificationpreference) | **GET** /v1/account/notification-preferences | Which notifications reach you, per event and channel (email, push, in-app).
[**GetAccountSignInIdentity**](AccountApi.md#getaccountsigninidentity) | **GET** /v1/account/sign-in-identity | How you sign in (Atlas): linked providers, password, passkeys, two-step.
[**GetMe**](AccountApi.md#getme) | **GET** /v1/me | Identity check — authenticated user + PAT scopes + account state.
[**GetMembership**](AccountApi.md#getmembership) | **GET** /v1/membership | The caller&#39;s Crossly One membership status and benefits.
[**ListAuthSessions**](AccountApi.md#listauthsessions) | **GET** /v1/auth/sessions | List, search and filter your sign-in sessions.
[**ListConnectedApps**](AccountApi.md#listconnectedapps) | **GET** /v1/connected-apps | List third-party OAuth apps with access to this account, each with its publisher (the store that owns it). Optional: q, scope, lastUsed (7d|30d|90d|never|stale), page, pageSize.
[**UpdateAccountNotificationPreference**](AccountApi.md#updateaccountnotificationpreference) | **PUT** /v1/account/notification-preferences | Turn notifications on or off per event and channel (email, push, in-app).


<a name="createaccountcanceldeletion"></a>
# **CreateAccountCancelDeletion**
> CreateAccountCancelDeletionResponse CreateAccountCancelDeletion ()

Cancel a pending account deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountCancelDeletionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Cancel a pending account deletion.
                CreateAccountCancelDeletionResponse result = apiInstance.CreateAccountCancelDeletion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountCancelDeletion: " + e.Message );
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

**CreateAccountCancelDeletionResponse**

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

<a name="createaccountidentityverificationstart"></a>
# **CreateAccountIdentityVerificationStart**
> CreateWorldMatureVerifyResponse CreateAccountIdentityVerificationStart (CreateAccountIdentityVerificationStartRequest createAccountIdentityVerificationStartRequest)

Start the identity check (photo ID + selfie). Returns a Stripe-hosted URL the person completes.

alreadyVerified:true when there is nothing to do. Nothing is verified until a person completes the link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountIdentityVerificationStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var createAccountIdentityVerificationStartRequest = new CreateAccountIdentityVerificationStartRequest(); // CreateAccountIdentityVerificationStartRequest | 

            try
            {
                // Start the identity check (photo ID + selfie). Returns a Stripe-hosted URL the person completes.
                CreateWorldMatureVerifyResponse result = apiInstance.CreateAccountIdentityVerificationStart(createAccountIdentityVerificationStartRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountIdentityVerificationStart: " + e.Message );
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
 **createAccountIdentityVerificationStartRequest** | **CreateAccountIdentityVerificationStartRequest**|  | 

### Return type

**CreateWorldMatureVerifyResponse**

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

<a name="createaccountlogoutall"></a>
# **CreateAccountLogoutAll**
> CreateAccountLogoutAllResponse CreateAccountLogoutAll ()

Revoke every browser auth session for this user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountLogoutAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Revoke every browser auth session for this user.
                CreateAccountLogoutAllResponse result = apiInstance.CreateAccountLogoutAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountLogoutAll: " + e.Message );
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

**CreateAccountLogoutAllResponse**

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

<a name="createaccountreconfirmdeletion"></a>
# **CreateAccountReconfirmDeletion**
> CreateAccountReconfirmDeletionResponse CreateAccountReconfirmDeletion (CreateAccountReconfirmDeletionRequest createAccountReconfirmDeletionRequest = null)

Confirm again a deletion paused because the account was in use.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountReconfirmDeletionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var createAccountReconfirmDeletionRequest = new CreateAccountReconfirmDeletionRequest(); // CreateAccountReconfirmDeletionRequest |  (optional) 

            try
            {
                // Confirm again a deletion paused because the account was in use.
                CreateAccountReconfirmDeletionResponse result = apiInstance.CreateAccountReconfirmDeletion(createAccountReconfirmDeletionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountReconfirmDeletion: " + e.Message );
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
 **createAccountReconfirmDeletionRequest** | **CreateAccountReconfirmDeletionRequest**|  | [optional] 

### Return type

**CreateAccountReconfirmDeletionResponse**

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

<a name="createaccountrequestdeletion"></a>
# **CreateAccountRequestDeletion**
> CreateAccountRequestDeletionResponse CreateAccountRequestDeletion (CreateAccountRequestDeletionRequest createAccountRequestDeletionRequest = null)

Schedule account deletion after a grace period. Requires confirmEmail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAccountRequestDeletionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var createAccountRequestDeletionRequest = new CreateAccountRequestDeletionRequest(); // CreateAccountRequestDeletionRequest |  (optional) 

            try
            {
                // Schedule account deletion after a grace period. Requires confirmEmail.
                CreateAccountRequestDeletionResponse result = apiInstance.CreateAccountRequestDeletion(createAccountRequestDeletionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountRequestDeletion: " + e.Message );
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
 **createAccountRequestDeletionRequest** | **CreateAccountRequestDeletionRequest**|  | [optional] 

### Return type

**CreateAccountRequestDeletionResponse**

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

<a name="createauthsessionsignout"></a>
# **CreateAuthSessionSignOut**
> CreateAuthSessionSignOutResponse CreateAuthSessionSignOut (CreateAuthSessionSignOutRequest createAuthSessionSignOutRequest)

Sign out several sessions at once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAuthSessionSignOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var createAuthSessionSignOutRequest = new CreateAuthSessionSignOutRequest(); // CreateAuthSessionSignOutRequest | 

            try
            {
                // Sign out several sessions at once.
                CreateAuthSessionSignOutResponse result = apiInstance.CreateAuthSessionSignOut(createAuthSessionSignOutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAuthSessionSignOut: " + e.Message );
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
 **createAuthSessionSignOutRequest** | **CreateAuthSessionSignOutRequest**|  | 

### Return type

**CreateAuthSessionSignOutResponse**

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

<a name="deleteauthsession"></a>
# **DeleteAuthSession**
> DeleteAuthSessionResponse DeleteAuthSession ()

Revoke all active browser sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAuthSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Revoke all active browser sessions.
                DeleteAuthSessionResponse result = apiInstance.DeleteAuthSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteAuthSession: " + e.Message );
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

**DeleteAuthSessionResponse**

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

<a name="deleteauthsessionbysessionid"></a>
# **DeleteAuthSessionBySessionId**
> SuccessResponse DeleteAuthSessionBySessionId (string sessionId)

Revoke a single browser session by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAuthSessionBySessionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var sessionId = "sessionId_example";  // string | 

            try
            {
                // Revoke a single browser session by id.
                SuccessResponse result = apiInstance.DeleteAuthSessionBySessionId(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteAuthSessionBySessionId: " + e.Message );
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
 **sessionId** | **string**|  | 

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

<a name="deleteconnectedapp"></a>
# **DeleteConnectedApp**
> OkResponse DeleteConnectedApp (string grantId)

Disconnect a third-party app. Its tokens stop working immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteConnectedAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var grantId = "grantId_example";  // string | 

            try
            {
                // Disconnect a third-party app. Its tokens stop working immediately.
                OkResponse result = apiInstance.DeleteConnectedApp(grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteConnectedApp: " + e.Message );
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
 **grantId** | **string**|  | 

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

<a name="getaccountclosurechecklist"></a>
# **GetAccountClosureChecklist**
> GetAccountClosureChecklistResponse GetAccountClosureChecklist ()

What closing the account will and will not do, before you request it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAccountClosureChecklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // What closing the account will and will not do, before you request it.
                GetAccountClosureChecklistResponse result = apiInstance.GetAccountClosureChecklist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountClosureChecklist: " + e.Message );
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

**GetAccountClosureChecklistResponse**

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

<a name="getaccountdeletionstatus"></a>
# **GetAccountDeletionStatus**
> GetAccountDeletionStatusResponse GetAccountDeletionStatus ()

Get the currently-pending deletion request, if any.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAccountDeletionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Get the currently-pending deletion request, if any.
                GetAccountDeletionStatusResponse result = apiInstance.GetAccountDeletionStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountDeletionStatus: " + e.Message );
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

**GetAccountDeletionStatusResponse**

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

<a name="getaccountidentityverification"></a>
# **GetAccountIdentityVerification**
> GetAccountIdentityVerificationResponse GetAccountIdentityVerification ()

Your identity verification: one status for the whole account, read by every feature that needs ID.

status is unverified, requires_input, processing, verified or canceled. requires_input with a lastError { code, reason } is a failed try the person can redo on the same link (start returns it); processing is being reviewed; neither is a decline, only canceled is. attempts counts the failed tries. ageVerified passes the age-restricted checkout gate. message is the next step in words (null once verified).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAccountIdentityVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Your identity verification: one status for the whole account, read by every feature that needs ID.
                GetAccountIdentityVerificationResponse result = apiInstance.GetAccountIdentityVerification();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountIdentityVerification: " + e.Message );
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

**GetAccountIdentityVerificationResponse**

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

<a name="getaccountnotificationpreference"></a>
# **GetAccountNotificationPreference**
> GetAccountNotificationPreferenceResponse GetAccountNotificationPreference ()

Which notifications reach you, per event and channel (email, push, in-app).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAccountNotificationPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Which notifications reach you, per event and channel (email, push, in-app).
                GetAccountNotificationPreferenceResponse result = apiInstance.GetAccountNotificationPreference();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountNotificationPreference: " + e.Message );
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

**GetAccountNotificationPreferenceResponse**

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

<a name="getaccountsigninidentity"></a>
# **GetAccountSignInIdentity**
> GetAccountSignInIdentityResponse GetAccountSignInIdentity ()

How you sign in (Atlas): linked providers, password, passkeys, two-step.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAccountSignInIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // How you sign in (Atlas): linked providers, password, passkeys, two-step.
                GetAccountSignInIdentityResponse result = apiInstance.GetAccountSignInIdentity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountSignInIdentity: " + e.Message );
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

**GetAccountSignInIdentityResponse**

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

<a name="getme"></a>
# **GetMe**
> GetMeResponse GetMe ()

Identity check — authenticated user + PAT scopes + account state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // Identity check — authenticated user + PAT scopes + account state.
                GetMeResponse result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetMe: " + e.Message );
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

**GetMeResponse**

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

<a name="getmembership"></a>
# **GetMembership**
> GetMembershipResponse GetMembership ()

The caller's Crossly One membership status and benefits.

Returns the active tier (or null), the period end, and the concrete benefit values for that tier. Benefits are the single source of truth shared with the web and mobile clients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMembershipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // The caller's Crossly One membership status and benefits.
                GetMembershipResponse result = apiInstance.GetMembership();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetMembership: " + e.Message );
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

**GetMembershipResponse**

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

<a name="listauthsessions"></a>
# **ListAuthSessions**
> ListAuthSessionsResponse ListAuthSessions (string q = null, string status = null, string deviceType = null, string from = null, string to = null, int? page = null, int? limit = null)

List, search and filter your sign-in sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListAuthSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var q = "q_example";  // string |  (optional) 
            var status = "active";  // string |  (optional) 
            var deviceType = "all";  // string |  (optional) 
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List, search and filter your sign-in sessions.
                ListAuthSessionsResponse result = apiInstance.ListAuthSessions(q, status, deviceType, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ListAuthSessions: " + e.Message );
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
 **q** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **deviceType** | **string**|  | [optional] 
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListAuthSessionsResponse**

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

<a name="listconnectedapps"></a>
# **ListConnectedApps**
> ListConnectedAppsResponse ListConnectedApps ()

List third-party OAuth apps with access to this account, each with its publisher (the store that owns it). Optional: q, scope, lastUsed (7d|30d|90d|never|stale), page, pageSize.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListConnectedAppsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // List third-party OAuth apps with access to this account, each with its publisher (the store that owns it). Optional: q, scope, lastUsed (7d|30d|90d|never|stale), page, pageSize.
                ListConnectedAppsResponse result = apiInstance.ListConnectedApps();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ListConnectedApps: " + e.Message );
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

**ListConnectedAppsResponse**

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

<a name="updateaccountnotificationpreference"></a>
# **UpdateAccountNotificationPreference**
> GetAccountNotificationPreferenceResponse UpdateAccountNotificationPreference (UpdateAccountNotificationPreferenceRequest updateAccountNotificationPreferenceRequest)

Turn notifications on or off per event and channel (email, push, in-app).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAccountNotificationPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var updateAccountNotificationPreferenceRequest = new UpdateAccountNotificationPreferenceRequest(); // UpdateAccountNotificationPreferenceRequest | 

            try
            {
                // Turn notifications on or off per event and channel (email, push, in-app).
                GetAccountNotificationPreferenceResponse result = apiInstance.UpdateAccountNotificationPreference(updateAccountNotificationPreferenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateAccountNotificationPreference: " + e.Message );
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
 **updateAccountNotificationPreferenceRequest** | **UpdateAccountNotificationPreferenceRequest**|  | 

### Return type

**GetAccountNotificationPreferenceResponse**

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

