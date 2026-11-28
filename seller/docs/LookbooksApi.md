# net.crossly.Api.LookbooksApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLookbook**](LookbooksApi.md#createlookbook) | **POST** /v1/lookbooks | Create a lookbook. Pass templateId (classic, editorial, hero, magazine, drop, sale, postcard) to start it from a template styled with your storefront brand kit.
[**CreateLookbookCampaign**](LookbooksApi.md#createlookbookcampaign) | **POST** /v1/lookbook-campaigns | Email a lookbook to customers now or at scheduledAt. Audience kind subscribers | all | repeat | segment {filters} | handles {handles}; only people with marketing consent who have not unsubscribed receive it.
[**CreateLookbookCampaignCancel**](LookbooksApi.md#createlookbookcampaigncancel) | **POST** /v1/lookbook-campaigns/{id}/cancel | Cancel a scheduled campaign or stop one that is sending (emails already sent stay sent).
[**CreateLookbookCampaignPreview**](LookbooksApi.md#createlookbookcampaignpreview) | **POST** /v1/lookbook-campaigns/preview | Preview a lookbook email campaign without sending: how many of the audience can receive it (opted in, not suppressed) and the rendered HTML/text.
[**CreateLookbookShareLink**](LookbooksApi.md#createlookbooksharelink) | **POST** /v1/lookbooks/{id}/share-links | Make a share link for someone without a Crossly login: role view, comment or edit; expires after ttlHours (1 to 2160, default 168). The url is shown once.
[**CreatePrintMailJob**](LookbooksApi.md#createprintmailjob) | **POST** /v1/print-mail/jobs | Draft a printed lookbook mailing (beta): renders the print-ready PDF with bleed and estimates the cost from your per-piece price. Mails nothing until confirmed.
[**CreatePrintMailJobConfirm**](LookbooksApi.md#createprintmailjobconfirm) | **POST** /v1/print-mail/jobs/{id}/confirm | Confirm a drafted print job: acknowledgeCharges must be true and pieces must equal the job&#39;s piece count. Your Lob or PostGrid account is billed.
[**GetLookbookCampaign**](LookbooksApi.md#getlookbookcampaign) | **GET** /v1/lookbook-campaigns/{id} | One lookbook campaign and its counts.
[**GetLookbookDesign**](LookbooksApi.md#getlookbookdesign) | **GET** /v1/lookbooks/{id}/design | A lookbook design document (pages of text, photo, listing, shape and sticker elements) with live listing title/price/photo, your brand kit and rendered page images.
[**ListEmailProviders**](LookbooksApi.md#listemailproviders) | **GET** /v1/email-providers | Your BYOK email providers (SMTP, Mailgun, SendGrid, SES, Resend, Postmark, Brevo, Mailjet, SparkPost, MailerSend, Mandrill, Plunk and more): label, from address, default, last test. Secrets are never returned.
[**ListLookbookCampaignRecipients**](LookbooksApi.md#listlookbookcampaignrecipients) | **GET** /v1/lookbook-campaigns/{id}/recipients | Per-recipient results for a campaign: status (queued, sent, failed, skipped + reason), provider message id, opens, clicks, bounce, unsubscribe.
[**ListLookbookCampaigns**](LookbooksApi.md#listlookbookcampaigns) | **GET** /v1/lookbook-campaigns | Your lookbook campaigns, newest first, with sent / failed / skipped / opened / clicked / bounced / unsubscribed counts.
[**ListLookbooks**](LookbooksApi.md#listlookbooks) | **GET** /v1/lookbooks | Your lookbooks: id, slug, title, published, current design version and item count.
[**ListPrintMailJobs**](LookbooksApi.md#listprintmailjobs) | **GET** /v1/print-mail/jobs | Print-and-mail jobs (beta): provider, format, pieces, estimate, status and per-piece results.
[**UpdateEmailProviderUs**](LookbooksApi.md#updateemailproviderus) | **PUT** /v1/email-providers/{id}/uses | Set what an email provider sends: uses ⊆ [lookbooks, invoices, receipts]. lookbooks is always on; invoices &#x3D; wholesale invoices and quotes, receipts &#x3D; other buyer notices, sent from this address instead of from Crossly.
[**UpdateLookbookDesign**](LookbooksApi.md#updatelookbookdesign) | **PUT** /v1/lookbooks/{id}/design | Save a new design version. Images must already be on the Crossly CDN; listings must be your own Crossly listings. Pass baseVersion to get a 409 instead of overwriting a newer save.


<a name="createlookbook"></a>
# **CreateLookbook**
> CreateLookbookResponse CreateLookbook (CreateLookbookRequest createLookbookRequest = null)

Create a lookbook. Pass templateId (classic, editorial, hero, magazine, drop, sale, postcard) to start it from a template styled with your storefront brand kit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLookbookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var createLookbookRequest = new CreateLookbookRequest(); // CreateLookbookRequest |  (optional) 

            try
            {
                // Create a lookbook. Pass templateId (classic, editorial, hero, magazine, drop, sale, postcard) to start it from a template styled with your storefront brand kit.
                CreateLookbookResponse result = apiInstance.CreateLookbook(createLookbookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreateLookbook: " + e.Message );
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
 **createLookbookRequest** | **CreateLookbookRequest**|  | [optional] 

### Return type

**CreateLookbookResponse**

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

<a name="createlookbookcampaign"></a>
# **CreateLookbookCampaign**
> LookbookCampaignResponse CreateLookbookCampaign (CreateLookbookCampaignRequest createLookbookCampaignRequest = null)

Email a lookbook to customers now or at scheduledAt. Audience kind subscribers | all | repeat | segment {filters} | handles {handles}; only people with marketing consent who have not unsubscribed receive it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLookbookCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var createLookbookCampaignRequest = new CreateLookbookCampaignRequest(); // CreateLookbookCampaignRequest |  (optional) 

            try
            {
                // Email a lookbook to customers now or at scheduledAt. Audience kind subscribers | all | repeat | segment {filters} | handles {handles}; only people with marketing consent who have not unsubscribed receive it.
                LookbookCampaignResponse result = apiInstance.CreateLookbookCampaign(createLookbookCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreateLookbookCampaign: " + e.Message );
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
 **createLookbookCampaignRequest** | **CreateLookbookCampaignRequest**|  | [optional] 

### Return type

**LookbookCampaignResponse**

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

<a name="createlookbookcampaigncancel"></a>
# **CreateLookbookCampaignCancel**
> LookbookCampaignResponse CreateLookbookCampaignCancel (string id)

Cancel a scheduled campaign or stop one that is sending (emails already sent stay sent).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLookbookCampaignCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a scheduled campaign or stop one that is sending (emails already sent stay sent).
                LookbookCampaignResponse result = apiInstance.CreateLookbookCampaignCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreateLookbookCampaignCancel: " + e.Message );
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

**LookbookCampaignResponse**

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

<a name="createlookbookcampaignpreview"></a>
# **CreateLookbookCampaignPreview**
> CreateLookbookCampaignPreviewResponse CreateLookbookCampaignPreview (CreateLookbookCampaignRequest createLookbookCampaignRequest = null)

Preview a lookbook email campaign without sending: how many of the audience can receive it (opted in, not suppressed) and the rendered HTML/text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLookbookCampaignPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var createLookbookCampaignRequest = new CreateLookbookCampaignRequest(); // CreateLookbookCampaignRequest |  (optional) 

            try
            {
                // Preview a lookbook email campaign without sending: how many of the audience can receive it (opted in, not suppressed) and the rendered HTML/text.
                CreateLookbookCampaignPreviewResponse result = apiInstance.CreateLookbookCampaignPreview(createLookbookCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreateLookbookCampaignPreview: " + e.Message );
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
 **createLookbookCampaignRequest** | **CreateLookbookCampaignRequest**|  | [optional] 

### Return type

**CreateLookbookCampaignPreviewResponse**

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

<a name="createlookbooksharelink"></a>
# **CreateLookbookShareLink**
> CreateLookbookShareLinkResponse CreateLookbookShareLink (string id, CreateLookbookShareLinkRequest createLookbookShareLinkRequest = null)

Make a share link for someone without a Crossly login: role view, comment or edit; expires after ttlHours (1 to 2160, default 168). The url is shown once.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateLookbookShareLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 
            var createLookbookShareLinkRequest = new CreateLookbookShareLinkRequest(); // CreateLookbookShareLinkRequest |  (optional) 

            try
            {
                // Make a share link for someone without a Crossly login: role view, comment or edit; expires after ttlHours (1 to 2160, default 168). The url is shown once.
                CreateLookbookShareLinkResponse result = apiInstance.CreateLookbookShareLink(id, createLookbookShareLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreateLookbookShareLink: " + e.Message );
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
 **createLookbookShareLinkRequest** | **CreateLookbookShareLinkRequest**|  | [optional] 

### Return type

**CreateLookbookShareLinkResponse**

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

<a name="createprintmailjob"></a>
# **CreatePrintMailJob**
> CreatePrintMailJobResponse CreatePrintMailJob (CreatePrintMailJobRequest createPrintMailJobRequest = null)

Draft a printed lookbook mailing (beta): renders the print-ready PDF with bleed and estimates the cost from your per-piece price. Mails nothing until confirmed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePrintMailJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var createPrintMailJobRequest = new CreatePrintMailJobRequest(); // CreatePrintMailJobRequest |  (optional) 

            try
            {
                // Draft a printed lookbook mailing (beta): renders the print-ready PDF with bleed and estimates the cost from your per-piece price. Mails nothing until confirmed.
                CreatePrintMailJobResponse result = apiInstance.CreatePrintMailJob(createPrintMailJobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreatePrintMailJob: " + e.Message );
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
 **createPrintMailJobRequest** | **CreatePrintMailJobRequest**|  | [optional] 

### Return type

**CreatePrintMailJobResponse**

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

<a name="createprintmailjobconfirm"></a>
# **CreatePrintMailJobConfirm**
> CreatePrintMailJobConfirmResponse CreatePrintMailJobConfirm (string id, CreatePrintMailJobConfirmRequest createPrintMailJobConfirmRequest = null)

Confirm a drafted print job: acknowledgeCharges must be true and pieces must equal the job's piece count. Your Lob or PostGrid account is billed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePrintMailJobConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 
            var createPrintMailJobConfirmRequest = new CreatePrintMailJobConfirmRequest(); // CreatePrintMailJobConfirmRequest |  (optional) 

            try
            {
                // Confirm a drafted print job: acknowledgeCharges must be true and pieces must equal the job's piece count. Your Lob or PostGrid account is billed.
                CreatePrintMailJobConfirmResponse result = apiInstance.CreatePrintMailJobConfirm(id, createPrintMailJobConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.CreatePrintMailJobConfirm: " + e.Message );
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
 **createPrintMailJobConfirmRequest** | **CreatePrintMailJobConfirmRequest**|  | [optional] 

### Return type

**CreatePrintMailJobConfirmResponse**

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

<a name="getlookbookcampaign"></a>
# **GetLookbookCampaign**
> LookbookCampaignResponse GetLookbookCampaign (string id)

One lookbook campaign and its counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLookbookCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One lookbook campaign and its counts.
                LookbookCampaignResponse result = apiInstance.GetLookbookCampaign(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.GetLookbookCampaign: " + e.Message );
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

**LookbookCampaignResponse**

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

<a name="getlookbookdesign"></a>
# **GetLookbookDesign**
> GetLookbookDesignResponse GetLookbookDesign (string id)

A lookbook design document (pages of text, photo, listing, shape and sticker elements) with live listing title/price/photo, your brand kit and rendered page images.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLookbookDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A lookbook design document (pages of text, photo, listing, shape and sticker elements) with live listing title/price/photo, your brand kit and rendered page images.
                GetLookbookDesignResponse result = apiInstance.GetLookbookDesign(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.GetLookbookDesign: " + e.Message );
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

**GetLookbookDesignResponse**

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

<a name="listemailproviders"></a>
# **ListEmailProviders**
> ListEmailProvidersResponse ListEmailProviders ()

Your BYOK email providers (SMTP, Mailgun, SendGrid, SES, Resend, Postmark, Brevo, Mailjet, SparkPost, MailerSend, Mandrill, Plunk and more): label, from address, default, last test. Secrets are never returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListEmailProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);

            try
            {
                // Your BYOK email providers (SMTP, Mailgun, SendGrid, SES, Resend, Postmark, Brevo, Mailjet, SparkPost, MailerSend, Mandrill, Plunk and more): label, from address, default, last test. Secrets are never returned.
                ListEmailProvidersResponse result = apiInstance.ListEmailProviders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.ListEmailProviders: " + e.Message );
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

**ListEmailProvidersResponse**

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

<a name="listlookbookcampaignrecipients"></a>
# **ListLookbookCampaignRecipients**
> ListLookbookCampaignRecipientsResponse ListLookbookCampaignRecipients (string id, string status = null, decimal? page = null, decimal? limit = null)

Per-recipient results for a campaign: status (queued, sent, failed, skipped + reason), provider message id, opens, clicks, bounce, unsubscribe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLookbookCampaignRecipientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 
            var status = "skipped";  // string |  (optional) 
            var page = 8.14D;  // decimal? |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Per-recipient results for a campaign: status (queued, sent, failed, skipped + reason), provider message id, opens, clicks, bounce, unsubscribe.
                ListLookbookCampaignRecipientsResponse result = apiInstance.ListLookbookCampaignRecipients(id, status, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.ListLookbookCampaignRecipients: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **page** | **decimal?**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListLookbookCampaignRecipientsResponse**

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

<a name="listlookbookcampaigns"></a>
# **ListLookbookCampaigns**
> ListLookbookCampaignsResponse ListLookbookCampaigns (string collectionId = null)

Your lookbook campaigns, newest first, with sent / failed / skipped / opened / clicked / bounced / unsubscribed counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLookbookCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var collectionId = "collectionId_example";  // string |  (optional) 

            try
            {
                // Your lookbook campaigns, newest first, with sent / failed / skipped / opened / clicked / bounced / unsubscribed counts.
                ListLookbookCampaignsResponse result = apiInstance.ListLookbookCampaigns(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.ListLookbookCampaigns: " + e.Message );
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
 **collectionId** | **string**|  | [optional] 

### Return type

**ListLookbookCampaignsResponse**

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

<a name="listlookbooks"></a>
# **ListLookbooks**
> ListLookbooksResponse ListLookbooks ()

Your lookbooks: id, slug, title, published, current design version and item count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLookbooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);

            try
            {
                // Your lookbooks: id, slug, title, published, current design version and item count.
                ListLookbooksResponse result = apiInstance.ListLookbooks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.ListLookbooks: " + e.Message );
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

**ListLookbooksResponse**

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

<a name="listprintmailjobs"></a>
# **ListPrintMailJobs**
> ListPrintMailJobsResponse ListPrintMailJobs ()

Print-and-mail jobs (beta): provider, format, pieces, estimate, status and per-piece results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPrintMailJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);

            try
            {
                // Print-and-mail jobs (beta): provider, format, pieces, estimate, status and per-piece results.
                ListPrintMailJobsResponse result = apiInstance.ListPrintMailJobs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.ListPrintMailJobs: " + e.Message );
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

**ListPrintMailJobsResponse**

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

<a name="updateemailproviderus"></a>
# **UpdateEmailProviderUs**
> UpdateEmailProviderUsResponse UpdateEmailProviderUs (Guid id, UpdateEmailProviderUsRequest updateEmailProviderUsRequest = null)

Set what an email provider sends: uses ⊆ [lookbooks, invoices, receipts]. lookbooks is always on; invoices = wholesale invoices and quotes, receipts = other buyer notices, sent from this address instead of from Crossly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateEmailProviderUsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // Guid | 
            var updateEmailProviderUsRequest = new UpdateEmailProviderUsRequest(); // UpdateEmailProviderUsRequest |  (optional) 

            try
            {
                // Set what an email provider sends: uses ⊆ [lookbooks, invoices, receipts]. lookbooks is always on; invoices = wholesale invoices and quotes, receipts = other buyer notices, sent from this address instead of from Crossly.
                UpdateEmailProviderUsResponse result = apiInstance.UpdateEmailProviderUs(id, updateEmailProviderUsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.UpdateEmailProviderUs: " + e.Message );
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
 **updateEmailProviderUsRequest** | **UpdateEmailProviderUsRequest**|  | [optional] 

### Return type

**UpdateEmailProviderUsResponse**

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

<a name="updatelookbookdesign"></a>
# **UpdateLookbookDesign**
> UpdateLookbookDesignResponse UpdateLookbookDesign (string id, UpdateLookbookDesignRequest updateLookbookDesignRequest = null)

Save a new design version. Images must already be on the Crossly CDN; listings must be your own Crossly listings. Pass baseVersion to get a 409 instead of overwriting a newer save.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLookbookDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LookbooksApi(config);
            var id = "id_example";  // string | 
            var updateLookbookDesignRequest = new UpdateLookbookDesignRequest(); // UpdateLookbookDesignRequest |  (optional) 

            try
            {
                // Save a new design version. Images must already be on the Crossly CDN; listings must be your own Crossly listings. Pass baseVersion to get a 409 instead of overwriting a newer save.
                UpdateLookbookDesignResponse result = apiInstance.UpdateLookbookDesign(id, updateLookbookDesignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LookbooksApi.UpdateLookbookDesign: " + e.Message );
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
 **updateLookbookDesignRequest** | **UpdateLookbookDesignRequest**|  | [optional] 

### Return type

**UpdateLookbookDesignResponse**

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

