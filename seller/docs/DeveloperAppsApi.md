# net.crossly.Api.DeveloperAppsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeveloperApp**](DeveloperAppsApi.md#createdeveloperapp) | **POST** /v1/developer/apps | Register an OAuth app for one of your stores (storefrontId; default: the store in X-Storefront-Id, else your default store). The store is paid what the app earns. clientSecret is returned ONCE.
[**CreateDeveloperAppCertificationSubmit**](DeveloperAppsApi.md#createdeveloperappcertificationsubmit) | **POST** /v1/developer/apps/{appId}/certification/submit | Send the application to Crossly review. Needs a passing conformance run on this client version and report-menu evidence.
[**CreateDeveloperAppCertificationWithdraw**](DeveloperAppsApi.md#createdeveloperappcertificationwithdraw) | **POST** /v1/developer/apps/{appId}/certification/withdraw | Take the application out of review to edit it.
[**CreateDeveloperAppClientVersion**](DeveloperAppsApi.md#createdeveloperappclientversion) | **POST** /v1/developer/apps/{appId}/client-versions | Register a new release of your certified client and start its conformance run. A pass on the same major version carries the certification automatically; a new major version goes to Crossly review; a failure keeps your previous certified version.
[**CreateDeveloperAppClientVersionRun**](DeveloperAppsApi.md#createdeveloperappclientversionrun) | **POST** /v1/developer/apps/{appId}/client-versions/{versionId}/run | Start a new conformance run for a release whose run failed, expired or was aborted.
[**CreateDeveloperAppConformanceRun**](DeveloperAppsApi.md#createdeveloperappconformancerun) | **POST** /v1/developer/apps/{appId}/conformance-runs | Start a conformance run: a test experience only your app, signed in as you, can join. Join it with POST /v1/worlds/experiences/{experienceId}/join and follow the instruction.
[**CreateDeveloperAppConformanceRunAbort**](DeveloperAppsApi.md#createdeveloperappconformancerunabort) | **POST** /v1/developer/apps/{appId}/conformance-runs/{runId}/abort | Abort an open run.
[**CreateDeveloperAppVerificationCheckDomain**](DeveloperAppsApi.md#createdeveloperappverificationcheckdomain) | **POST** /v1/developer/apps/{appId}/verification/check-domain | Look up the DNS TXT record crossly-app-verification&#x3D;&lt;token&gt; on your domain (or _crossly.&lt;domain&gt;) now.
[**CreateDeveloperAppVerificationSubmit**](DeveloperAppsApi.md#createdeveloperappverificationsubmit) | **POST** /v1/developer/apps/{appId}/verification/submit | Send the verification to Crossly review (each scope is decided separately).
[**CreateDeveloperAppVerificationWithdraw**](DeveloperAppsApi.md#createdeveloperappverificationwithdraw) | **POST** /v1/developer/apps/{appId}/verification/withdraw | Take the verification out of review to edit it.
[**GetDeveloperApp**](DeveloperAppsApi.md#getdeveloperapp) | **GET** /v1/developer/apps/{appId} | One of your OAuth apps, with the store that owns it.
[**GetDeveloperAppCertification**](DeveloperAppsApi.md#getdeveloperappcertification) | **GET** /v1/developer/apps/{appId}/certification | The Crossly Carnival client certification application (null until you create it): status, client, evidence, the passing run and what still blocks submission.
[**GetDeveloperAppClientVersion**](DeveloperAppsApi.md#getdeveloperappclientversion) | **GET** /v1/developer/apps/{appId}/client-versions/{versionId} | One client release and its re-certification.
[**GetDeveloperAppConformanceRun**](DeveloperAppsApi.md#getdeveloperappconformancerun) | **GET** /v1/developer/apps/{appId}/conformance-runs/{runId} | A run&#39;s step, instruction and every check with its verdict.
[**GetDeveloperAppHealth**](DeveloperAppsApi.md#getdeveloperapphealth) | **GET** /v1/developer/apps/{appId}/health | Your app&#39;s API health: write-request counts by status class (24 h, 7 d) across every seller using it, top error codes with advice, a retry-storm flag, the last 50 failed requests (message and correlation id only on requests made with your own account), and from Atlas: how many people authorized the app and with which scopes (counts, never who) and the token endpoint&#39;s OAuth errors by code (e.g. invalid_grant) with the latest one.
[**GetDeveloperAppProfile**](DeveloperAppsApi.md#getdeveloperappprofile) | **GET** /v1/developer/apps/{appId}/profile | Your app&#39;s public directory profile: every editable field, the listing status, what still needs review, and &#x60;preview&#x60; — the profile exactly as /seller-apps or /buyer-apps will show it.
[**GetDeveloperAppReview**](DeveloperAppsApi.md#getdeveloperappreview) | **GET** /v1/developer/apps/{appId}/review | Your app&#39;s Crossly Carnival client certification, verification and review history in one read.
[**GetDeveloperAppVerification**](DeveloperAppsApi.md#getdeveloperappverification) | **GET** /v1/developer/apps/{appId}/verification | The app verification for worlds:publish / worlds:monetize (null until created): domain proof, policies, justifications and per-scope decisions.
[**ListDeveloperAppClientVersions**](DeveloperAppsApi.md#listdeveloperappclientversions) | **GET** /v1/developer/apps/{appId}/client-versions | Releases of your certified client, newest first: the re-certification status (awaiting_run, running, carried, ops_review, approved, rejected, failed, superseded), the rule that decided it and its checks.
[**ListDeveloperAppConformanceRuns**](DeveloperAppsApi.md#listdeveloperappconformanceruns) | **GET** /v1/developer/apps/{appId}/conformance-runs | Your app&#39;s conformance runs, newest first.
[**ListDeveloperApps**](DeveloperAppsApi.md#listdeveloperapps) | **GET** /v1/developer/apps | Your stores&#39; OAuth apps (and any of yours still waiting for a store): filter by storefrontId, status or q; page with page + pageSize. meta.stores lists the stores you may register apps for.
[**UpdateDeveloperApp**](DeveloperAppsApi.md#updatedeveloperapp) | **PATCH** /v1/developer/apps/{appId} | Edit an app&#39;s name, redirect URIs, scopes and revenue share. Existing installs keep the terms they agreed to.
[**UpdateDeveloperAppCertification**](DeveloperAppsApi.md#updatedeveloperappcertification) | **PUT** /v1/developer/apps/{appId}/certification | Create or edit the application: client name, platform, version, build and source URLs, description and evidence (report menu, chat, Policy UI). Changing the client clears the passing run.
[**UpdateDeveloperAppListing**](DeveloperAppsApi.md#updatedeveloperapplisting) | **PUT** /v1/developer/apps/{appId}/listing | Turn \&quot;Listed publicly\&quot; on or off. On: an app Crossly approved whose name, scopes and audience are unchanged is listed at once; anything else goes to review (pending_review). Off: unlisted immediately.
[**UpdateDeveloperAppProfile**](DeveloperAppsApi.md#updatedeveloperappprofile) | **PATCH** /v1/developer/apps/{appId}/profile | Edit your app&#39;s directory profile: name, slug, tagline, description, longDescription (markdown), category, audience (auto|seller|buyer|both), logoUrl, bannerUrl (4:1, 1600×400), screenshots (≤6), demoVideoUrl, homepageUrl, installUrl, support/privacy/terms links, docsLinks [{label,url}] and pricingNote. Absent keys are kept, null clears. Images not on Crossly&#39;s CDN are copied onto it. Renaming a listed app or changing its audience sends it back to review.
[**UpdateDeveloperAppStore**](DeveloperAppsApi.md#updatedeveloperappstore) | **PUT** /v1/developer/apps/{appId}/store | Choose (or change) the store that owns an app: a store of the same business. Its unpaid earnings move with it; client id, secret, installs and webhooks don&#39;t change.
[**UpdateDeveloperAppVerification**](DeveloperAppsApi.md#updatedeveloperappverification) | **PUT** /v1/developer/apps/{appId}/verification | Create or edit the verification: domain, requested scopes with a justification each, privacy policy, terms, support email, demo.


<a name="createdeveloperapp"></a>
# **CreateDeveloperApp**
> CreateDeveloperAppResponse CreateDeveloperApp ()

Register an OAuth app for one of your stores (storefrontId; default: the store in X-Storefront-Id, else your default store). The store is paid what the app earns. clientSecret is returned ONCE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);

            try
            {
                // Register an OAuth app for one of your stores (storefrontId; default: the store in X-Storefront-Id, else your default store). The store is paid what the app earns. clientSecret is returned ONCE.
                CreateDeveloperAppResponse result = apiInstance.CreateDeveloperApp();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperApp: " + e.Message );
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

**CreateDeveloperAppResponse**

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

<a name="createdeveloperappcertificationsubmit"></a>
# **CreateDeveloperAppCertificationSubmit**
> DeveloperAppCertificationResponse CreateDeveloperAppCertificationSubmit (string appId)

Send the application to Crossly review. Needs a passing conformance run on this client version and report-menu evidence.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppCertificationSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Send the application to Crossly review. Needs a passing conformance run on this client version and report-menu evidence.
                DeveloperAppCertificationResponse result = apiInstance.CreateDeveloperAppCertificationSubmit(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppCertificationSubmit: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppCertificationResponse**

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

<a name="createdeveloperappcertificationwithdraw"></a>
# **CreateDeveloperAppCertificationWithdraw**
> DeveloperAppCertificationResponse CreateDeveloperAppCertificationWithdraw (string appId)

Take the application out of review to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppCertificationWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Take the application out of review to edit it.
                DeveloperAppCertificationResponse result = apiInstance.CreateDeveloperAppCertificationWithdraw(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppCertificationWithdraw: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppCertificationResponse**

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

<a name="createdeveloperappclientversion"></a>
# **CreateDeveloperAppClientVersion**
> CreateDeveloperAppClientVersionResponse CreateDeveloperAppClientVersion (string appId)

Register a new release of your certified client and start its conformance run. A pass on the same major version carries the certification automatically; a new major version goes to Crossly review; a failure keeps your previous certified version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppClientVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Register a new release of your certified client and start its conformance run. A pass on the same major version carries the certification automatically; a new major version goes to Crossly review; a failure keeps your previous certified version.
                CreateDeveloperAppClientVersionResponse result = apiInstance.CreateDeveloperAppClientVersion(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppClientVersion: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**CreateDeveloperAppClientVersionResponse**

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

<a name="createdeveloperappclientversionrun"></a>
# **CreateDeveloperAppClientVersionRun**
> CreateDeveloperAppClientVersionResponse CreateDeveloperAppClientVersionRun (string appId, string versionId)

Start a new conformance run for a release whose run failed, expired or was aborted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppClientVersionRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 
            var versionId = "versionId_example";  // string | 

            try
            {
                // Start a new conformance run for a release whose run failed, expired or was aborted.
                CreateDeveloperAppClientVersionResponse result = apiInstance.CreateDeveloperAppClientVersionRun(appId, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppClientVersionRun: " + e.Message );
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
 **appId** | **string**|  | 
 **versionId** | **string**|  | 

### Return type

**CreateDeveloperAppClientVersionResponse**

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

<a name="createdeveloperappconformancerun"></a>
# **CreateDeveloperAppConformanceRun**
> GetDeveloperAppConformanceRunResponse CreateDeveloperAppConformanceRun (string appId)

Start a conformance run: a test experience only your app, signed in as you, can join. Join it with POST /v1/worlds/experiences/{experienceId}/join and follow the instruction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppConformanceRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Start a conformance run: a test experience only your app, signed in as you, can join. Join it with POST /v1/worlds/experiences/{experienceId}/join and follow the instruction.
                GetDeveloperAppConformanceRunResponse result = apiInstance.CreateDeveloperAppConformanceRun(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppConformanceRun: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppConformanceRunResponse**

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

<a name="createdeveloperappconformancerunabort"></a>
# **CreateDeveloperAppConformanceRunAbort**
> CreateDeveloperAppConformanceRunAbortResponse CreateDeveloperAppConformanceRunAbort (string appId, string runId)

Abort an open run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppConformanceRunAbortExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 
            var runId = "runId_example";  // string | 

            try
            {
                // Abort an open run.
                CreateDeveloperAppConformanceRunAbortResponse result = apiInstance.CreateDeveloperAppConformanceRunAbort(appId, runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppConformanceRunAbort: " + e.Message );
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
 **appId** | **string**|  | 
 **runId** | **string**|  | 

### Return type

**CreateDeveloperAppConformanceRunAbortResponse**

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

<a name="createdeveloperappverificationcheckdomain"></a>
# **CreateDeveloperAppVerificationCheckDomain**
> DeveloperAppVerificationResponse CreateDeveloperAppVerificationCheckDomain (string appId)

Look up the DNS TXT record crossly-app-verification=<token> on your domain (or _crossly.<domain>) now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppVerificationCheckDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Look up the DNS TXT record crossly-app-verification=<token> on your domain (or _crossly.<domain>) now.
                DeveloperAppVerificationResponse result = apiInstance.CreateDeveloperAppVerificationCheckDomain(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppVerificationCheckDomain: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppVerificationResponse**

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

<a name="createdeveloperappverificationsubmit"></a>
# **CreateDeveloperAppVerificationSubmit**
> DeveloperAppVerificationResponse CreateDeveloperAppVerificationSubmit (string appId)

Send the verification to Crossly review (each scope is decided separately).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppVerificationSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Send the verification to Crossly review (each scope is decided separately).
                DeveloperAppVerificationResponse result = apiInstance.CreateDeveloperAppVerificationSubmit(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppVerificationSubmit: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppVerificationResponse**

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

<a name="createdeveloperappverificationwithdraw"></a>
# **CreateDeveloperAppVerificationWithdraw**
> DeveloperAppVerificationResponse CreateDeveloperAppVerificationWithdraw (string appId)

Take the verification out of review to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDeveloperAppVerificationWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Take the verification out of review to edit it.
                DeveloperAppVerificationResponse result = apiInstance.CreateDeveloperAppVerificationWithdraw(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.CreateDeveloperAppVerificationWithdraw: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppVerificationResponse**

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

<a name="getdeveloperapp"></a>
# **GetDeveloperApp**
> GetDeveloperAppResponse GetDeveloperApp (Guid appId)

One of your OAuth apps, with the store that owns it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // Guid | 

            try
            {
                // One of your OAuth apps, with the store that owns it.
                GetDeveloperAppResponse result = apiInstance.GetDeveloperApp(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperApp: " + e.Message );
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
 **appId** | **Guid**|  | 

### Return type

**GetDeveloperAppResponse**

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

<a name="getdeveloperappcertification"></a>
# **GetDeveloperAppCertification**
> GetDeveloperAppCertificationResponse GetDeveloperAppCertification (string appId)

The Crossly Carnival client certification application (null until you create it): status, client, evidence, the passing run and what still blocks submission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppCertificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // The Crossly Carnival client certification application (null until you create it): status, client, evidence, the passing run and what still blocks submission.
                GetDeveloperAppCertificationResponse result = apiInstance.GetDeveloperAppCertification(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppCertification: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppCertificationResponse**

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

<a name="getdeveloperappclientversion"></a>
# **GetDeveloperAppClientVersion**
> GetDeveloperAppClientVersionResponse GetDeveloperAppClientVersion (string appId, string versionId)

One client release and its re-certification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppClientVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 
            var versionId = "versionId_example";  // string | 

            try
            {
                // One client release and its re-certification.
                GetDeveloperAppClientVersionResponse result = apiInstance.GetDeveloperAppClientVersion(appId, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppClientVersion: " + e.Message );
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
 **appId** | **string**|  | 
 **versionId** | **string**|  | 

### Return type

**GetDeveloperAppClientVersionResponse**

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

<a name="getdeveloperappconformancerun"></a>
# **GetDeveloperAppConformanceRun**
> GetDeveloperAppConformanceRunResponse GetDeveloperAppConformanceRun (string appId, string runId)

A run's step, instruction and every check with its verdict.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppConformanceRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 
            var runId = "runId_example";  // string | 

            try
            {
                // A run's step, instruction and every check with its verdict.
                GetDeveloperAppConformanceRunResponse result = apiInstance.GetDeveloperAppConformanceRun(appId, runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppConformanceRun: " + e.Message );
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
 **appId** | **string**|  | 
 **runId** | **string**|  | 

### Return type

**GetDeveloperAppConformanceRunResponse**

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

<a name="getdeveloperapphealth"></a>
# **GetDeveloperAppHealth**
> GetDeveloperAppHealthResponse GetDeveloperAppHealth (string appId)

Your app's API health: write-request counts by status class (24 h, 7 d) across every seller using it, top error codes with advice, a retry-storm flag, the last 50 failed requests (message and correlation id only on requests made with your own account), and from Atlas: how many people authorized the app and with which scopes (counts, never who) and the token endpoint's OAuth errors by code (e.g. invalid_grant) with the latest one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Your app's API health: write-request counts by status class (24 h, 7 d) across every seller using it, top error codes with advice, a retry-storm flag, the last 50 failed requests (message and correlation id only on requests made with your own account), and from Atlas: how many people authorized the app and with which scopes (counts, never who) and the token endpoint's OAuth errors by code (e.g. invalid_grant) with the latest one.
                GetDeveloperAppHealthResponse result = apiInstance.GetDeveloperAppHealth(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppHealth: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppHealthResponse**

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

<a name="getdeveloperappprofile"></a>
# **GetDeveloperAppProfile**
> GetDeveloperAppProfileResponse GetDeveloperAppProfile (string appId)

Your app's public directory profile: every editable field, the listing status, what still needs review, and `preview` — the profile exactly as /seller-apps or /buyer-apps will show it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Your app's public directory profile: every editable field, the listing status, what still needs review, and `preview` — the profile exactly as /seller-apps or /buyer-apps will show it.
                GetDeveloperAppProfileResponse result = apiInstance.GetDeveloperAppProfile(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppProfile: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppProfileResponse**

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

<a name="getdeveloperappreview"></a>
# **GetDeveloperAppReview**
> GetDeveloperAppReviewResponse GetDeveloperAppReview (string appId)

Your app's Crossly Carnival client certification, verification and review history in one read.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Your app's Crossly Carnival client certification, verification and review history in one read.
                GetDeveloperAppReviewResponse result = apiInstance.GetDeveloperAppReview(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppReview: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppReviewResponse**

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

<a name="getdeveloperappverification"></a>
# **GetDeveloperAppVerification**
> GetDeveloperAppVerificationResponse GetDeveloperAppVerification (string appId)

The app verification for worlds:publish / worlds:monetize (null until created): domain proof, policies, justifications and per-scope decisions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDeveloperAppVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // The app verification for worlds:publish / worlds:monetize (null until created): domain proof, policies, justifications and per-scope decisions.
                GetDeveloperAppVerificationResponse result = apiInstance.GetDeveloperAppVerification(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.GetDeveloperAppVerification: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**GetDeveloperAppVerificationResponse**

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

<a name="listdeveloperappclientversions"></a>
# **ListDeveloperAppClientVersions**
> ListDeveloperAppClientVersionsResponse ListDeveloperAppClientVersions (string appId)

Releases of your certified client, newest first: the re-certification status (awaiting_run, running, carried, ops_review, approved, rejected, failed, superseded), the rule that decided it and its checks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDeveloperAppClientVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Releases of your certified client, newest first: the re-certification status (awaiting_run, running, carried, ops_review, approved, rejected, failed, superseded), the rule that decided it and its checks.
                ListDeveloperAppClientVersionsResponse result = apiInstance.ListDeveloperAppClientVersions(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.ListDeveloperAppClientVersions: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**ListDeveloperAppClientVersionsResponse**

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

<a name="listdeveloperappconformanceruns"></a>
# **ListDeveloperAppConformanceRuns**
> ListDeveloperAppConformanceRunsResponse ListDeveloperAppConformanceRuns (string appId)

Your app's conformance runs, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDeveloperAppConformanceRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Your app's conformance runs, newest first.
                ListDeveloperAppConformanceRunsResponse result = apiInstance.ListDeveloperAppConformanceRuns(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.ListDeveloperAppConformanceRuns: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**ListDeveloperAppConformanceRunsResponse**

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

<a name="listdeveloperapps"></a>
# **ListDeveloperApps**
> ListDeveloperAppsResponse ListDeveloperApps (Guid? storefrontId = null, string q = null, string status = null, int? page = null, int? pageSize = null)

Your stores' OAuth apps (and any of yours still waiting for a store): filter by storefrontId, status or q; page with page + pageSize. meta.stores lists the stores you may register apps for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDeveloperAppsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var storefrontId = "storefrontId_example";  // Guid? |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var status = "live";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Your stores' OAuth apps (and any of yours still waiting for a store): filter by storefrontId, status or q; page with page + pageSize. meta.stores lists the stores you may register apps for.
                ListDeveloperAppsResponse result = apiInstance.ListDeveloperApps(storefrontId, q, status, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.ListDeveloperApps: " + e.Message );
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
 **storefrontId** | **Guid?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

**ListDeveloperAppsResponse**

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

<a name="updatedeveloperapp"></a>
# **UpdateDeveloperApp**
> UpdateDeveloperAppResponse UpdateDeveloperApp (Guid appId)

Edit an app's name, redirect URIs, scopes and revenue share. Existing installs keep the terms they agreed to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // Guid | 

            try
            {
                // Edit an app's name, redirect URIs, scopes and revenue share. Existing installs keep the terms they agreed to.
                UpdateDeveloperAppResponse result = apiInstance.UpdateDeveloperApp(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperApp: " + e.Message );
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
 **appId** | **Guid**|  | 

### Return type

**UpdateDeveloperAppResponse**

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

<a name="updatedeveloperappcertification"></a>
# **UpdateDeveloperAppCertification**
> DeveloperAppCertificationResponse UpdateDeveloperAppCertification (string appId)

Create or edit the application: client name, platform, version, build and source URLs, description and evidence (report menu, chat, Policy UI). Changing the client clears the passing run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppCertificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Create or edit the application: client name, platform, version, build and source URLs, description and evidence (report menu, chat, Policy UI). Changing the client clears the passing run.
                DeveloperAppCertificationResponse result = apiInstance.UpdateDeveloperAppCertification(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperAppCertification: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppCertificationResponse**

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

<a name="updatedeveloperapplisting"></a>
# **UpdateDeveloperAppListing**
> UpdateDeveloperAppListingResponse UpdateDeveloperAppListing (string appId, UpdateDeveloperAppListingRequest updateDeveloperAppListingRequest = null)

Turn \"Listed publicly\" on or off. On: an app Crossly approved whose name, scopes and audience are unchanged is listed at once; anything else goes to review (pending_review). Off: unlisted immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 
            var updateDeveloperAppListingRequest = new UpdateDeveloperAppListingRequest(); // UpdateDeveloperAppListingRequest |  (optional) 

            try
            {
                // Turn \"Listed publicly\" on or off. On: an app Crossly approved whose name, scopes and audience are unchanged is listed at once; anything else goes to review (pending_review). Off: unlisted immediately.
                UpdateDeveloperAppListingResponse result = apiInstance.UpdateDeveloperAppListing(appId, updateDeveloperAppListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperAppListing: " + e.Message );
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
 **appId** | **string**|  | 
 **updateDeveloperAppListingRequest** | **UpdateDeveloperAppListingRequest**|  | [optional] 

### Return type

**UpdateDeveloperAppListingResponse**

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

<a name="updatedeveloperappprofile"></a>
# **UpdateDeveloperAppProfile**
> UpdateDeveloperAppProfileResponse UpdateDeveloperAppProfile (string appId)

Edit your app's directory profile: name, slug, tagline, description, longDescription (markdown), category, audience (auto|seller|buyer|both), logoUrl, bannerUrl (4:1, 1600×400), screenshots (≤6), demoVideoUrl, homepageUrl, installUrl, support/privacy/terms links, docsLinks [{label,url}] and pricingNote. Absent keys are kept, null clears. Images not on Crossly's CDN are copied onto it. Renaming a listed app or changing its audience sends it back to review.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Edit your app's directory profile: name, slug, tagline, description, longDescription (markdown), category, audience (auto|seller|buyer|both), logoUrl, bannerUrl (4:1, 1600×400), screenshots (≤6), demoVideoUrl, homepageUrl, installUrl, support/privacy/terms links, docsLinks [{label,url}] and pricingNote. Absent keys are kept, null clears. Images not on Crossly's CDN are copied onto it. Renaming a listed app or changing its audience sends it back to review.
                UpdateDeveloperAppProfileResponse result = apiInstance.UpdateDeveloperAppProfile(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperAppProfile: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**UpdateDeveloperAppProfileResponse**

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

<a name="updatedeveloperappstore"></a>
# **UpdateDeveloperAppStore**
> UpdateDeveloperAppStoreResponse UpdateDeveloperAppStore (Guid appId, UpdateDeveloperAppStoreRequest updateDeveloperAppStoreRequest)

Choose (or change) the store that owns an app: a store of the same business. Its unpaid earnings move with it; client id, secret, installs and webhooks don't change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // Guid | 
            var updateDeveloperAppStoreRequest = new UpdateDeveloperAppStoreRequest(); // UpdateDeveloperAppStoreRequest | 

            try
            {
                // Choose (or change) the store that owns an app: a store of the same business. Its unpaid earnings move with it; client id, secret, installs and webhooks don't change.
                UpdateDeveloperAppStoreResponse result = apiInstance.UpdateDeveloperAppStore(appId, updateDeveloperAppStoreRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperAppStore: " + e.Message );
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
 **appId** | **Guid**|  | 
 **updateDeveloperAppStoreRequest** | **UpdateDeveloperAppStoreRequest**|  | 

### Return type

**UpdateDeveloperAppStoreResponse**

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

<a name="updatedeveloperappverification"></a>
# **UpdateDeveloperAppVerification**
> DeveloperAppVerificationResponse UpdateDeveloperAppVerification (string appId)

Create or edit the verification: domain, requested scopes with a justification each, privacy policy, terms, support email, demo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDeveloperAppVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeveloperAppsApi(config);
            var appId = "appId_example";  // string | 

            try
            {
                // Create or edit the verification: domain, requested scopes with a justification each, privacy policy, terms, support email, demo.
                DeveloperAppVerificationResponse result = apiInstance.UpdateDeveloperAppVerification(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperAppsApi.UpdateDeveloperAppVerification: " + e.Message );
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
 **appId** | **string**|  | 

### Return type

**DeveloperAppVerificationResponse**

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

