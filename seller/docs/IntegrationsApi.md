# net.crossly.Api.IntegrationsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCrmIntegration**](IntegrationsApi.md#createcrmintegration) | **POST** /v1/crm/integrations | Connect a custom webhook CRM or Mailchimp. HubSpot, Salesforce, Pipedrive and Zoho connect by signing in from the dashboard.
[**CreateCrmIntegrationTest**](IntegrationsApi.md#createcrmintegrationtest) | **POST** /v1/crm/integrations/{id}/test | Send a sample buyer to the CRM and report whether it arrived, in one sanitized line.
[**CreateDesignToolImport**](IntegrationsApi.md#createdesigntoolimport) | **POST** /v1/design-tools/import | Import Figma frames or Canva pages as images on the Crossly CDN, for the site editor, share cards, ad creatives, Branding drops or lookbooks.
[**CreateEmailProvider**](IntegrationsApi.md#createemailprovider) | **POST** /v1/email-providers | Connect an email sender (16 providers). The key is encrypted; the event webhook URL is returned once.
[**CreateEmailProviderTest**](IntegrationsApi.md#createemailprovidertest) | **POST** /v1/email-providers/{id}/test | Send a real test email through the sender; the result is one sanitized line.
[**CreateEmailProviderWebhookUrl**](IntegrationsApi.md#createemailproviderwebhookurl) | **POST** /v1/email-providers/{id}/webhook-url | Make a new event webhook URL for the sender (the old one stops working). It is returned once.
[**CreateNotificationIntegration**](IntegrationsApi.md#createnotificationintegration) | **POST** /v1/notification-integrations | Deprecated alias: add a Slack/Discord/JSON webhook for automations. Use POST /api/v1/webhooks with kind.
[**CreateNotificationIntegrationTest**](IntegrationsApi.md#createnotificationintegrationtest) | **POST** /v1/notification-integrations/{id}/test | Deprecated alias: send a test message to a destination. Use POST /api/v1/webhooks/{id}/test.
[**CreateNotifyAction**](IntegrationsApi.md#createnotifyaction) | **POST** /v1/notify/actions | Decide a notification action from its signed token (an offer, a reprice, a label buy, a workflow approval). Single use; the token must be your own. Errors: expired (410), already decided (409).
[**CreatePrintMailCredential**](IntegrationsApi.md#createprintmailcredential) | **POST** /v1/print-mail/credentials | Save a Lob or PostGrid key (tested against the provider first), with the return address and your per-piece prices.
[**CreatePrintMailCredentialTest**](IntegrationsApi.md#createprintmailcredentialtest) | **POST** /v1/print-mail/credentials/test | Check a Lob or PostGrid key with the provider before saving it. Saves nothing, mails nothing.
[**CreatePrintMailCredentialTestById**](IntegrationsApi.md#createprintmailcredentialtestbyid) | **POST** /v1/print-mail/credentials/{id}/test | Re-check a saved Lob or PostGrid key; the result is one sanitized line.
[**DeleteCrmIntegration**](IntegrationsApi.md#deletecrmintegration) | **DELETE** /v1/crm/integrations/{id} | Disconnect a CRM. Buyers stop flowing to it; its delivery log goes with it.
[**DeleteDesignTool**](IntegrationsApi.md#deletedesigntool) | **DELETE** /v1/design-tools/{tool} | Disconnect Figma or Canva for the store.
[**DeleteEmailProvider**](IntegrationsApi.md#deleteemailprovider) | **DELETE** /v1/email-providers/{id} | Disconnect an email sender. The next newest becomes the default.
[**DeleteNotificationIntegration**](IntegrationsApi.md#deletenotificationintegration) | **DELETE** /v1/notification-integrations/{id} | Deprecated alias: delete a notification destination. Use DELETE /api/v1/webhooks/{id}.
[**DeletePrintMailCredential**](IntegrationsApi.md#deleteprintmailcredential) | **DELETE** /v1/print-mail/credentials/{id} | Remove a print and mail account.
[**GetDesignTool**](IntegrationsApi.md#getdesigntool) | **GET** /v1/design-tools/{tool} | Whether Figma or Canva is connected for the store, and as whom. Never the token.
[**GetIntegration**](IntegrationsApi.md#getintegration) | **GET** /v1/integrations | Every connected integration of the store (AI, CRM, email senders, design apps) as uniform rows.
[**GetPrintMailEstimate**](IntegrationsApi.md#getprintmailestimate) | **GET** /v1/print-mail/estimate | Estimate a printed lookbook send: pieces × the seller&#39;s own per-piece price, per format the account&#39;s provider prints.
[**ListCrmIntegrationLogs**](IntegrationsApi.md#listcrmintegrationlogs) | **GET** /v1/crm/integrations/{id}/logs | A CRM connection&#39;s delivery log, newest first, paged; filter by status.
[**ListCrmIntegrations**](IntegrationsApi.md#listcrmintegrations) | **GET** /v1/crm/integrations | The store&#39;s CRM connections: provider, name, sync settings, health. Secrets are redacted.
[**ListNotificationIntegrations**](IntegrationsApi.md#listnotificationintegrations) | **GET** /v1/notification-integrations | Deprecated (one release; use GET /api/v1/webhooks): every webhook of the seller as an old-style notification destination (provider slack/discord/webhook, plus kind), and any destination not yet copied to webhooks.
[**ListPrintMailCredentials**](IntegrationsApi.md#listprintmailcredentials) | **GET** /v1/print-mail/credentials | The store&#39;s Lob and PostGrid accounts: mode, key as last 4, return address, per-piece prices.
[**UpdateCrmIntegration**](IntegrationsApi.md#updatecrmintegration) | **PATCH** /v1/crm/integrations/{id} | Rename, pause, re-key or change what a CRM receives (sources, opted-in only, field mapping). Blank secrets keep the stored ones.
[**UpdateDesignTool**](IntegrationsApi.md#updatedesigntool) | **PUT** /v1/design-tools/{tool} | Connect Figma with a personal access token, or save your own Canva Connect app (client id + secret; finish the Canva sign-in in the dashboard).
[**UpdateEmailProvider**](IntegrationsApi.md#updateemailprovider) | **PATCH** /v1/email-providers/{id} | Edit an email sender: label, from address, reply-to, default, settings. Blank secrets keep the stored ones.
[**UpdateNotificationIntegration**](IntegrationsApi.md#updatenotificationintegration) | **PATCH** /v1/notification-integrations/{id} | Deprecated alias: edit a notification destination. Use PATCH /api/v1/webhooks/{id}.
[**UpdatePrintMailCredential**](IntegrationsApi.md#updateprintmailcredential) | **PATCH** /v1/print-mail/credentials/{id} | Change a print and mail account: label, return address, per-piece prices (cents per format).


<a name="createcrmintegration"></a>
# **CreateCrmIntegration**
> CreateCrmIntegrationResponse CreateCrmIntegration (CreateCrmIntegrationRequest createCrmIntegrationRequest = null)

Connect a custom webhook CRM or Mailchimp. HubSpot, Salesforce, Pipedrive and Zoho connect by signing in from the dashboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCrmIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createCrmIntegrationRequest = new CreateCrmIntegrationRequest(); // CreateCrmIntegrationRequest |  (optional) 

            try
            {
                // Connect a custom webhook CRM or Mailchimp. HubSpot, Salesforce, Pipedrive and Zoho connect by signing in from the dashboard.
                CreateCrmIntegrationResponse result = apiInstance.CreateCrmIntegration(createCrmIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateCrmIntegration: " + e.Message );
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
 **createCrmIntegrationRequest** | **CreateCrmIntegrationRequest**|  | [optional] 

### Return type

**CreateCrmIntegrationResponse**

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

<a name="createcrmintegrationtest"></a>
# **CreateCrmIntegrationTest**
> CreateCrmIntegrationTestResponse CreateCrmIntegrationTest (string id)

Send a sample buyer to the CRM and report whether it arrived, in one sanitized line.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCrmIntegrationTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Send a sample buyer to the CRM and report whether it arrived, in one sanitized line.
                CreateCrmIntegrationTestResponse result = apiInstance.CreateCrmIntegrationTest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateCrmIntegrationTest: " + e.Message );
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

**CreateCrmIntegrationTestResponse**

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

<a name="createdesigntoolimport"></a>
# **CreateDesignToolImport**
> CreateDesignToolImportResponse CreateDesignToolImport (CreateDesignToolImportRequest createDesignToolImportRequest = null)

Import Figma frames or Canva pages as images on the Crossly CDN, for the site editor, share cards, ad creatives, Branding drops or lookbooks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDesignToolImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createDesignToolImportRequest = new CreateDesignToolImportRequest(); // CreateDesignToolImportRequest |  (optional) 

            try
            {
                // Import Figma frames or Canva pages as images on the Crossly CDN, for the site editor, share cards, ad creatives, Branding drops or lookbooks.
                CreateDesignToolImportResponse result = apiInstance.CreateDesignToolImport(createDesignToolImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateDesignToolImport: " + e.Message );
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
 **createDesignToolImportRequest** | **CreateDesignToolImportRequest**|  | [optional] 

### Return type

**CreateDesignToolImportResponse**

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

<a name="createemailprovider"></a>
# **CreateEmailProvider**
> CreateEmailProviderResponse CreateEmailProvider (CreateEmailProviderRequest createEmailProviderRequest = null)

Connect an email sender (16 providers). The key is encrypted; the event webhook URL is returned once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createEmailProviderRequest = new CreateEmailProviderRequest(); // CreateEmailProviderRequest |  (optional) 

            try
            {
                // Connect an email sender (16 providers). The key is encrypted; the event webhook URL is returned once.
                CreateEmailProviderResponse result = apiInstance.CreateEmailProvider(createEmailProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateEmailProvider: " + e.Message );
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
 **createEmailProviderRequest** | **CreateEmailProviderRequest**|  | [optional] 

### Return type

**CreateEmailProviderResponse**

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

<a name="createemailprovidertest"></a>
# **CreateEmailProviderTest**
> CreateEmailProviderTestResponse CreateEmailProviderTest (string id, CreateEmailProviderTestRequest createEmailProviderTestRequest = null)

Send a real test email through the sender; the result is one sanitized line.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailProviderTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 
            var createEmailProviderTestRequest = new CreateEmailProviderTestRequest(); // CreateEmailProviderTestRequest |  (optional) 

            try
            {
                // Send a real test email through the sender; the result is one sanitized line.
                CreateEmailProviderTestResponse result = apiInstance.CreateEmailProviderTest(id, createEmailProviderTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateEmailProviderTest: " + e.Message );
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
 **createEmailProviderTestRequest** | **CreateEmailProviderTestRequest**|  | [optional] 

### Return type

**CreateEmailProviderTestResponse**

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

<a name="createemailproviderwebhookurl"></a>
# **CreateEmailProviderWebhookUrl**
> CreateEmailProviderWebhookUrlResponse CreateEmailProviderWebhookUrl (string id)

Make a new event webhook URL for the sender (the old one stops working). It is returned once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailProviderWebhookUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Make a new event webhook URL for the sender (the old one stops working). It is returned once.
                CreateEmailProviderWebhookUrlResponse result = apiInstance.CreateEmailProviderWebhookUrl(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateEmailProviderWebhookUrl: " + e.Message );
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

**CreateEmailProviderWebhookUrlResponse**

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

<a name="createnotificationintegration"></a>
# **CreateNotificationIntegration**
> CreateNotificationIntegrationResponse CreateNotificationIntegration (CreateNotificationIntegrationRequest createNotificationIntegrationRequest)

Deprecated alias: add a Slack/Discord/JSON webhook for automations. Use POST /api/v1/webhooks with kind.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNotificationIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createNotificationIntegrationRequest = new CreateNotificationIntegrationRequest(); // CreateNotificationIntegrationRequest | 

            try
            {
                // Deprecated alias: add a Slack/Discord/JSON webhook for automations. Use POST /api/v1/webhooks with kind.
                CreateNotificationIntegrationResponse result = apiInstance.CreateNotificationIntegration(createNotificationIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateNotificationIntegration: " + e.Message );
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
 **createNotificationIntegrationRequest** | **CreateNotificationIntegrationRequest**|  | 

### Return type

**CreateNotificationIntegrationResponse**

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

<a name="createnotificationintegrationtest"></a>
# **CreateNotificationIntegrationTest**
> CreateNotificationIntegrationTestResponse CreateNotificationIntegrationTest (Guid id)

Deprecated alias: send a test message to a destination. Use POST /api/v1/webhooks/{id}/test.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNotificationIntegrationTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deprecated alias: send a test message to a destination. Use POST /api/v1/webhooks/{id}/test.
                CreateNotificationIntegrationTestResponse result = apiInstance.CreateNotificationIntegrationTest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateNotificationIntegrationTest: " + e.Message );
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

**CreateNotificationIntegrationTestResponse**

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

<a name="createnotifyaction"></a>
# **CreateNotifyAction**
> CreateNotifyActionResponse CreateNotifyAction (TokenObject tokenObject)

Decide a notification action from its signed token (an offer, a reprice, a label buy, a workflow approval). Single use; the token must be your own. Errors: expired (410), already decided (409).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateNotifyActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var tokenObject = new TokenObject(); // TokenObject | 

            try
            {
                // Decide a notification action from its signed token (an offer, a reprice, a label buy, a workflow approval). Single use; the token must be your own. Errors: expired (410), already decided (409).
                CreateNotifyActionResponse result = apiInstance.CreateNotifyAction(tokenObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateNotifyAction: " + e.Message );
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

**CreateNotifyActionResponse**

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

<a name="createprintmailcredential"></a>
# **CreatePrintMailCredential**
> CreatePrintMailCredentialResponse CreatePrintMailCredential (CreatePrintMailCredentialRequest createPrintMailCredentialRequest = null)

Save a Lob or PostGrid key (tested against the provider first), with the return address and your per-piece prices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePrintMailCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createPrintMailCredentialRequest = new CreatePrintMailCredentialRequest(); // CreatePrintMailCredentialRequest |  (optional) 

            try
            {
                // Save a Lob or PostGrid key (tested against the provider first), with the return address and your per-piece prices.
                CreatePrintMailCredentialResponse result = apiInstance.CreatePrintMailCredential(createPrintMailCredentialRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreatePrintMailCredential: " + e.Message );
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
 **createPrintMailCredentialRequest** | **CreatePrintMailCredentialRequest**|  | [optional] 

### Return type

**CreatePrintMailCredentialResponse**

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

<a name="createprintmailcredentialtest"></a>
# **CreatePrintMailCredentialTest**
> CreatePrintMailCredentialTestResponse CreatePrintMailCredentialTest (CreatePrintMailCredentialTestRequest createPrintMailCredentialTestRequest = null)

Check a Lob or PostGrid key with the provider before saving it. Saves nothing, mails nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePrintMailCredentialTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createPrintMailCredentialTestRequest = new CreatePrintMailCredentialTestRequest(); // CreatePrintMailCredentialTestRequest |  (optional) 

            try
            {
                // Check a Lob or PostGrid key with the provider before saving it. Saves nothing, mails nothing.
                CreatePrintMailCredentialTestResponse result = apiInstance.CreatePrintMailCredentialTest(createPrintMailCredentialTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreatePrintMailCredentialTest: " + e.Message );
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
 **createPrintMailCredentialTestRequest** | **CreatePrintMailCredentialTestRequest**|  | [optional] 

### Return type

**CreatePrintMailCredentialTestResponse**

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

<a name="createprintmailcredentialtestbyid"></a>
# **CreatePrintMailCredentialTestById**
> CreatePrintMailCredentialTestByIdResponse CreatePrintMailCredentialTestById (string id)

Re-check a saved Lob or PostGrid key; the result is one sanitized line.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePrintMailCredentialTestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Re-check a saved Lob or PostGrid key; the result is one sanitized line.
                CreatePrintMailCredentialTestByIdResponse result = apiInstance.CreatePrintMailCredentialTestById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreatePrintMailCredentialTestById: " + e.Message );
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

**CreatePrintMailCredentialTestByIdResponse**

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

<a name="deletecrmintegration"></a>
# **DeleteCrmIntegration**
> UpdateGroupBuyResponse DeleteCrmIntegration (string id)

Disconnect a CRM. Buyers stop flowing to it; its delivery log goes with it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteCrmIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Disconnect a CRM. Buyers stop flowing to it; its delivery log goes with it.
                UpdateGroupBuyResponse result = apiInstance.DeleteCrmIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteCrmIntegration: " + e.Message );
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

<a name="deletedesigntool"></a>
# **DeleteDesignTool**
> UpdateGroupBuyResponse DeleteDesignTool (string tool)

Disconnect Figma or Canva for the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteDesignToolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var tool = "tool_example";  // string | 

            try
            {
                // Disconnect Figma or Canva for the store.
                UpdateGroupBuyResponse result = apiInstance.DeleteDesignTool(tool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteDesignTool: " + e.Message );
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
 **tool** | **string**|  | 

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

<a name="deleteemailprovider"></a>
# **DeleteEmailProvider**
> UpdateGroupBuyResponse DeleteEmailProvider (string id)

Disconnect an email sender. The next newest becomes the default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteEmailProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Disconnect an email sender. The next newest becomes the default.
                UpdateGroupBuyResponse result = apiInstance.DeleteEmailProvider(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteEmailProvider: " + e.Message );
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

<a name="deletenotificationintegration"></a>
# **DeleteNotificationIntegration**
> OkResponse DeleteNotificationIntegration (Guid id)

Deprecated alias: delete a notification destination. Use DELETE /api/v1/webhooks/{id}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteNotificationIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deprecated alias: delete a notification destination. Use DELETE /api/v1/webhooks/{id}.
                OkResponse result = apiInstance.DeleteNotificationIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteNotificationIntegration: " + e.Message );
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

<a name="deleteprintmailcredential"></a>
# **DeletePrintMailCredential**
> UpdateGroupBuyResponse DeletePrintMailCredential (string id)

Remove a print and mail account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeletePrintMailCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Remove a print and mail account.
                UpdateGroupBuyResponse result = apiInstance.DeletePrintMailCredential(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeletePrintMailCredential: " + e.Message );
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

<a name="getdesigntool"></a>
# **GetDesignTool**
> GetDesignToolResponse GetDesignTool (string tool)

Whether Figma or Canva is connected for the store, and as whom. Never the token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDesignToolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var tool = "tool_example";  // string | 

            try
            {
                // Whether Figma or Canva is connected for the store, and as whom. Never the token.
                GetDesignToolResponse result = apiInstance.GetDesignTool(tool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetDesignTool: " + e.Message );
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
 **tool** | **string**|  | 

### Return type

**GetDesignToolResponse**

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

<a name="getintegration"></a>
# **GetIntegration**
> GetIntegrationResponse GetIntegration ()

Every connected integration of the store (AI, CRM, email senders, design apps) as uniform rows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // Every connected integration of the store (AI, CRM, email senders, design apps) as uniform rows.
                GetIntegrationResponse result = apiInstance.GetIntegration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegration: " + e.Message );
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

**GetIntegrationResponse**

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

<a name="getprintmailestimate"></a>
# **GetPrintMailEstimate**
> GetPrintMailEstimateResponse GetPrintMailEstimate (string lookbookId, decimal count, string credentialId = null, string format = null)

Estimate a printed lookbook send: pieces × the seller's own per-piece price, per format the account's provider prints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPrintMailEstimateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var lookbookId = "lookbookId_example";  // string | 
            var count = 8.14D;  // decimal | 
            var credentialId = "credentialId_example";  // string |  (optional) 
            var format = "postcard_4x6";  // string |  (optional) 

            try
            {
                // Estimate a printed lookbook send: pieces × the seller's own per-piece price, per format the account's provider prints.
                GetPrintMailEstimateResponse result = apiInstance.GetPrintMailEstimate(lookbookId, count, credentialId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetPrintMailEstimate: " + e.Message );
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
 **lookbookId** | **string**|  | 
 **count** | **decimal**|  | 
 **credentialId** | **string**|  | [optional] 
 **format** | **string**|  | [optional] 

### Return type

**GetPrintMailEstimateResponse**

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

<a name="listcrmintegrationlogs"></a>
# **ListCrmIntegrationLogs**
> ListCrmIntegrationLogsResponse ListCrmIntegrationLogs (string id, decimal? page = null, decimal? pageSize = null, string status = null)

A CRM connection's delivery log, newest first, paged; filter by status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCrmIntegrationLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 
            var page = 8.14D;  // decimal? |  (optional) 
            var pageSize = 8.14D;  // decimal? |  (optional) 
            var status = "pending";  // string |  (optional) 

            try
            {
                // A CRM connection's delivery log, newest first, paged; filter by status.
                ListCrmIntegrationLogsResponse result = apiInstance.ListCrmIntegrationLogs(id, page, pageSize, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListCrmIntegrationLogs: " + e.Message );
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
 **page** | **decimal?**|  | [optional] 
 **pageSize** | **decimal?**|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

**ListCrmIntegrationLogsResponse**

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

<a name="listcrmintegrations"></a>
# **ListCrmIntegrations**
> ListCrmIntegrationsResponse ListCrmIntegrations ()

The store's CRM connections: provider, name, sync settings, health. Secrets are redacted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCrmIntegrationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // The store's CRM connections: provider, name, sync settings, health. Secrets are redacted.
                ListCrmIntegrationsResponse result = apiInstance.ListCrmIntegrations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListCrmIntegrations: " + e.Message );
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

**ListCrmIntegrationsResponse**

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

<a name="listnotificationintegrations"></a>
# **ListNotificationIntegrations**
> ListNotificationIntegrationsResponse ListNotificationIntegrations ()

Deprecated (one release; use GET /api/v1/webhooks): every webhook of the seller as an old-style notification destination (provider slack/discord/webhook, plus kind), and any destination not yet copied to webhooks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListNotificationIntegrationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // Deprecated (one release; use GET /api/v1/webhooks): every webhook of the seller as an old-style notification destination (provider slack/discord/webhook, plus kind), and any destination not yet copied to webhooks.
                ListNotificationIntegrationsResponse result = apiInstance.ListNotificationIntegrations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListNotificationIntegrations: " + e.Message );
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

**ListNotificationIntegrationsResponse**

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

<a name="listprintmailcredentials"></a>
# **ListPrintMailCredentials**
> ListPrintMailCredentialsResponse ListPrintMailCredentials ()

The store's Lob and PostGrid accounts: mode, key as last 4, return address, per-piece prices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPrintMailCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // The store's Lob and PostGrid accounts: mode, key as last 4, return address, per-piece prices.
                ListPrintMailCredentialsResponse result = apiInstance.ListPrintMailCredentials();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListPrintMailCredentials: " + e.Message );
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

**ListPrintMailCredentialsResponse**

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

<a name="updatecrmintegration"></a>
# **UpdateCrmIntegration**
> CreateCrmIntegrationResponse UpdateCrmIntegration (string id, UpdateCrmIntegrationRequest updateCrmIntegrationRequest = null)

Rename, pause, re-key or change what a CRM receives (sources, opted-in only, field mapping). Blank secrets keep the stored ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateCrmIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 
            var updateCrmIntegrationRequest = new UpdateCrmIntegrationRequest(); // UpdateCrmIntegrationRequest |  (optional) 

            try
            {
                // Rename, pause, re-key or change what a CRM receives (sources, opted-in only, field mapping). Blank secrets keep the stored ones.
                CreateCrmIntegrationResponse result = apiInstance.UpdateCrmIntegration(id, updateCrmIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateCrmIntegration: " + e.Message );
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
 **updateCrmIntegrationRequest** | **UpdateCrmIntegrationRequest**|  | [optional] 

### Return type

**CreateCrmIntegrationResponse**

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

<a name="updatedesigntool"></a>
# **UpdateDesignTool**
> UpdateDesignToolResponse UpdateDesignTool (string tool, TokenObject tokenObject = null)

Connect Figma with a personal access token, or save your own Canva Connect app (client id + secret; finish the Canva sign-in in the dashboard).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDesignToolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var tool = "tool_example";  // string | 
            var tokenObject = new TokenObject(); // TokenObject |  (optional) 

            try
            {
                // Connect Figma with a personal access token, or save your own Canva Connect app (client id + secret; finish the Canva sign-in in the dashboard).
                UpdateDesignToolResponse result = apiInstance.UpdateDesignTool(tool, tokenObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateDesignTool: " + e.Message );
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
 **tool** | **string**|  | 
 **tokenObject** | **TokenObject**|  | [optional] 

### Return type

**UpdateDesignToolResponse**

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

<a name="updateemailprovider"></a>
# **UpdateEmailProvider**
> UpdateEmailProviderResponse UpdateEmailProvider (string id, UpdateEmailProviderRequest updateEmailProviderRequest = null)

Edit an email sender: label, from address, reply-to, default, settings. Blank secrets keep the stored ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateEmailProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 
            var updateEmailProviderRequest = new UpdateEmailProviderRequest(); // UpdateEmailProviderRequest |  (optional) 

            try
            {
                // Edit an email sender: label, from address, reply-to, default, settings. Blank secrets keep the stored ones.
                UpdateEmailProviderResponse result = apiInstance.UpdateEmailProvider(id, updateEmailProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateEmailProvider: " + e.Message );
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
 **updateEmailProviderRequest** | **UpdateEmailProviderRequest**|  | [optional] 

### Return type

**UpdateEmailProviderResponse**

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

<a name="updatenotificationintegration"></a>
# **UpdateNotificationIntegration**
> OkResponse UpdateNotificationIntegration (Guid id, UpdateNotificationIntegrationRequest updateNotificationIntegrationRequest)

Deprecated alias: edit a notification destination. Use PATCH /api/v1/webhooks/{id}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateNotificationIntegrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // Guid | 
            var updateNotificationIntegrationRequest = new UpdateNotificationIntegrationRequest(); // UpdateNotificationIntegrationRequest | 

            try
            {
                // Deprecated alias: edit a notification destination. Use PATCH /api/v1/webhooks/{id}.
                OkResponse result = apiInstance.UpdateNotificationIntegration(id, updateNotificationIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateNotificationIntegration: " + e.Message );
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
 **updateNotificationIntegrationRequest** | **UpdateNotificationIntegrationRequest**|  | 

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

<a name="updateprintmailcredential"></a>
# **UpdatePrintMailCredential**
> CreatePrintMailCredentialResponse UpdatePrintMailCredential (string id, UpdatePrintMailCredentialRequest updatePrintMailCredentialRequest = null)

Change a print and mail account: label, return address, per-piece prices (cents per format).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePrintMailCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var id = "id_example";  // string | 
            var updatePrintMailCredentialRequest = new UpdatePrintMailCredentialRequest(); // UpdatePrintMailCredentialRequest |  (optional) 

            try
            {
                // Change a print and mail account: label, return address, per-piece prices (cents per format).
                CreatePrintMailCredentialResponse result = apiInstance.UpdatePrintMailCredential(id, updatePrintMailCredentialRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdatePrintMailCredential: " + e.Message );
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
 **updatePrintMailCredentialRequest** | **UpdatePrintMailCredentialRequest**|  | [optional] 

### Return type

**CreatePrintMailCredentialResponse**

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

