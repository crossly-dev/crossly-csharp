# net.crossly.Api.BrandingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrandingDrop**](BrandingApi.md#createbrandingdrop) | **POST** /v1/branding/drops | Create a drop as a draft. &#x60;config&#x60; is the full drop config (what, where: shop|world|live|storefront|featured, format, access, limits, pricing, schedule, promotion, fulfilment). Returns rule problems to fix before publishing.
[**CreateBrandingDropControl**](BrandingApi.md#createbrandingdropcontrol) | **POST** /v1/branding/drops/{id}/controls/{control} | Live controls: pause, resume, extend (body endsAt), release-wave, end, draw (raffle).
[**CreateBrandingDropPublish**](BrandingApi.md#createbrandingdroppublish) | **POST** /v1/branding/drops/{id}/publish | Publish: scheduled, or pending_review for a brand partner without self-publish. Brand partners need a verified business on Stripe (403 business_verification_required).
[**CreateBrandingDropRestockRun**](BrandingApi.md#createbrandingdroprestockrun) | **POST** /v1/branding/drops/{id}/restock-run | Restock run for a sold-out or ended drop: a link-only group buy on one of its restocked listings ({ platformListingId?, tiers, goalQty?, minQtyToProceed?, perBuyerMax?, days?, paymentMode?, priorityHours?, title?, description?, shareCopy? }). Waitlisted, raffle-losing and notify entrants of the drop are told and join first for priorityHours. One run per drop (409 after).
[**CreateBrandingEventCancel**](BrandingApi.md#createbrandingeventcancel) | **POST** /v1/branding/events/{id}/cancel | Cancel a published event with the reason attendees see.
[**CreateBrandingEventCheckIn**](BrandingApi.md#createbrandingeventcheckin) | **POST** /v1/branding/events/{id}/check-in | Check a ticket in at the door by its QR token.
[**CreateBrandingEventMessage**](BrandingApi.md#createbrandingeventmessage) | **POST** /v1/branding/events/{id}/messages | Message the event&#39;s attendees: all, going, or ticketed.
[**DeleteBrandingDrop**](BrandingApi.md#deletebrandingdrop) | **DELETE** /v1/branding/drops/{id} | Delete a draft, or cancel a scheduled drop. A live drop is ended with the end control.
[**GetBrandingBrand**](BrandingApi.md#getbrandingbrand) | **GET** /v1/branding/brand | Your brand profile (approved brand partners).
[**GetBrandingBrandTerm**](BrandingApi.md#getbrandingbrandterm) | **GET** /v1/branding/brand/terms | Your partner terms (fee, drops per month, units per drop, self-publish, pre-bids, promotion tier), this month&#39;s drop usage and the terms history.
[**GetBrandingBusinessVerification**](BrandingApi.md#getbrandingbusinessverification) | **GET** /v1/branding/business-verification | Whether your Stripe account is a verified business (company, EIN/tax id verified, payouts on), with reasons and the page to fix it.
[**GetBrandingDrop**](BrandingApi.md#getbrandingdrop) | **GET** /v1/branding/drops/{id} | One of your drops.
[**GetBrandingEvent**](BrandingApi.md#getbrandingevent) | **GET** /v1/branding/events | Your events: upcoming grouped by date (today, this_week, later), or past.
[**GetBrandingSetting**](BrandingApi.md#getbrandingsetting) | **GET** /v1/branding/settings | The store’s Branding defaults new drops start from: timezone, notifyFollowers, botQueue, botCaptcha, cartHoldMinutes, leftovers.
[**ListBrandingBrandSellerSearch**](BrandingApi.md#listbrandingbrandsellersearch) | **GET** /v1/branding/brand/sellers/search | Find a store to authorise by its name or slug (?q&#x3D;, at least 2 characters).
[**ListBrandingBrandSellers**](BrandingApi.md#listbrandingbrandsellers) | **GET** /v1/branding/brand/sellers | Your authorised sellers (approved brand partners), each with its store name and status.
[**ListBrandingDropBuyers**](BrandingApi.md#listbrandingdropbuyers) | **GET** /v1/branding/drops/{id}/buyers | A drop&#39;s buyers: public username, units claimed, order id and when, oldest first.
[**ListBrandingDrops**](BrandingApi.md#listbrandingdrops) | **GET** /v1/branding/drops | Your drops, newest first, with config, waves, counts (entries, holding, sold, buyers) and phase. ?scope&#x3D;upcoming|live|past|drafts|all.
[**UpdateBrandingBrand**](BrandingApi.md#updatebrandingbrand) | **PATCH** /v1/branding/brand | Edit your brand profile: logoUrl, bannerUrl, story, links.
[**UpdateBrandingBrandSeller**](BrandingApi.md#updatebrandingbrandseller) | **PUT** /v1/branding/brand/sellers | Authorise a seller to sell your brand, or revoke them: { sellerUserId, status: active|revoked, note? }.
[**UpdateBrandingDrop**](BrandingApi.md#updatebrandingdrop) | **PATCH** /v1/branding/drops/{id} | Edit a drop that is not live yet. A published drop refuses rule problems (400 drop_config_problems).
[**UpdateBrandingEventSetting**](BrandingApi.md#updatebrandingeventsetting) | **PUT** /v1/branding/events/{id}/settings | Save an event&#39;s full settings (where, access, reminders, check-in, recording, linked drops) and ticket tiers.
[**UpdateBrandingSetting**](BrandingApi.md#updatebrandingsetting) | **PATCH** /v1/branding/settings | Change the store’s Branding defaults (any subset of the fields).


<a name="createbrandingdrop"></a>
# **CreateBrandingDrop**
> CreateBrandingDropResponse CreateBrandingDrop (CreateBrandingDropRequest createBrandingDropRequest)

Create a drop as a draft. `config` is the full drop config (what, where: shop|world|live|storefront|featured, format, access, limits, pricing, schedule, promotion, fulfilment). Returns rule problems to fix before publishing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var createBrandingDropRequest = new CreateBrandingDropRequest(); // CreateBrandingDropRequest | 

            try
            {
                // Create a drop as a draft. `config` is the full drop config (what, where: shop|world|live|storefront|featured, format, access, limits, pricing, schedule, promotion, fulfilment). Returns rule problems to fix before publishing.
                CreateBrandingDropResponse result = apiInstance.CreateBrandingDrop(createBrandingDropRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingDrop: " + e.Message );
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
 **createBrandingDropRequest** | **CreateBrandingDropRequest**|  | 

### Return type

**CreateBrandingDropResponse**

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

<a name="createbrandingdropcontrol"></a>
# **CreateBrandingDropControl**
> GetBrandingDropResponse CreateBrandingDropControl (string id, string control, CreateBrandingDropControlRequest createBrandingDropControlRequest = null)

Live controls: pause, resume, extend (body endsAt), release-wave, end, draw (raffle).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingDropControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // string | 
            var control = "control_example";  // string | 
            var createBrandingDropControlRequest = new CreateBrandingDropControlRequest(); // CreateBrandingDropControlRequest |  (optional) 

            try
            {
                // Live controls: pause, resume, extend (body endsAt), release-wave, end, draw (raffle).
                GetBrandingDropResponse result = apiInstance.CreateBrandingDropControl(id, control, createBrandingDropControlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingDropControl: " + e.Message );
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
 **control** | **string**|  | 
 **createBrandingDropControlRequest** | **CreateBrandingDropControlRequest**|  | [optional] 

### Return type

**GetBrandingDropResponse**

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

<a name="createbrandingdroppublish"></a>
# **CreateBrandingDropPublish**
> CreateBrandingDropPublishResponse CreateBrandingDropPublish (Guid id)

Publish: scheduled, or pending_review for a brand partner without self-publish. Brand partners need a verified business on Stripe (403 business_verification_required).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingDropPublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Publish: scheduled, or pending_review for a brand partner without self-publish. Brand partners need a verified business on Stripe (403 business_verification_required).
                CreateBrandingDropPublishResponse result = apiInstance.CreateBrandingDropPublish(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingDropPublish: " + e.Message );
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

**CreateBrandingDropPublishResponse**

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

<a name="createbrandingdroprestockrun"></a>
# **CreateBrandingDropRestockRun**
> CreateBrandingDropRestockRunResponse CreateBrandingDropRestockRun (Guid id, CreateBrandingDropRestockRunRequest createBrandingDropRestockRunRequest = null)

Restock run for a sold-out or ended drop: a link-only group buy on one of its restocked listings ({ platformListingId?, tiers, goalQty?, minQtyToProceed?, perBuyerMax?, days?, paymentMode?, priorityHours?, title?, description?, shareCopy? }). Waitlisted, raffle-losing and notify entrants of the drop are told and join first for priorityHours. One run per drop (409 after).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingDropRestockRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var createBrandingDropRestockRunRequest = new CreateBrandingDropRestockRunRequest(); // CreateBrandingDropRestockRunRequest |  (optional) 

            try
            {
                // Restock run for a sold-out or ended drop: a link-only group buy on one of its restocked listings ({ platformListingId?, tiers, goalQty?, minQtyToProceed?, perBuyerMax?, days?, paymentMode?, priorityHours?, title?, description?, shareCopy? }). Waitlisted, raffle-losing and notify entrants of the drop are told and join first for priorityHours. One run per drop (409 after).
                CreateBrandingDropRestockRunResponse result = apiInstance.CreateBrandingDropRestockRun(id, createBrandingDropRestockRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingDropRestockRun: " + e.Message );
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
 **createBrandingDropRestockRunRequest** | **CreateBrandingDropRestockRunRequest**|  | [optional] 

### Return type

**CreateBrandingDropRestockRunResponse**

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

<a name="createbrandingeventcancel"></a>
# **CreateBrandingEventCancel**
> CreateBrandingEventCancelResponse CreateBrandingEventCancel (Guid id, ReasonRequest reasonRequest)

Cancel a published event with the reason attendees see.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingEventCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var reasonRequest = new ReasonRequest(); // ReasonRequest | 

            try
            {
                // Cancel a published event with the reason attendees see.
                CreateBrandingEventCancelResponse result = apiInstance.CreateBrandingEventCancel(id, reasonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingEventCancel: " + e.Message );
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
 **reasonRequest** | **ReasonRequest**|  | 

### Return type

**CreateBrandingEventCancelResponse**

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

<a name="createbrandingeventcheckin"></a>
# **CreateBrandingEventCheckIn**
> CreateBrandingEventCheckInResponse CreateBrandingEventCheckIn (Guid id, CreateBrandingEventCheckInRequest createBrandingEventCheckInRequest)

Check a ticket in at the door by its QR token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingEventCheckInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var createBrandingEventCheckInRequest = new CreateBrandingEventCheckInRequest(); // CreateBrandingEventCheckInRequest | 

            try
            {
                // Check a ticket in at the door by its QR token.
                CreateBrandingEventCheckInResponse result = apiInstance.CreateBrandingEventCheckIn(id, createBrandingEventCheckInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingEventCheckIn: " + e.Message );
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
 **createBrandingEventCheckInRequest** | **CreateBrandingEventCheckInRequest**|  | 

### Return type

**CreateBrandingEventCheckInResponse**

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

<a name="createbrandingeventmessage"></a>
# **CreateBrandingEventMessage**
> CreateBrandingEventMessageResponse CreateBrandingEventMessage (Guid id, CreateBrandingEventMessageRequest createBrandingEventMessageRequest)

Message the event's attendees: all, going, or ticketed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandingEventMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var createBrandingEventMessageRequest = new CreateBrandingEventMessageRequest(); // CreateBrandingEventMessageRequest | 

            try
            {
                // Message the event's attendees: all, going, or ticketed.
                CreateBrandingEventMessageResponse result = apiInstance.CreateBrandingEventMessage(id, createBrandingEventMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.CreateBrandingEventMessage: " + e.Message );
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
 **createBrandingEventMessageRequest** | **CreateBrandingEventMessageRequest**|  | 

### Return type

**CreateBrandingEventMessageResponse**

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

<a name="deletebrandingdrop"></a>
# **DeleteBrandingDrop**
> DeleteBrandingDropResponse DeleteBrandingDrop (Guid id)

Delete a draft, or cancel a scheduled drop. A live drop is ended with the end control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteBrandingDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a draft, or cancel a scheduled drop. A live drop is ended with the end control.
                DeleteBrandingDropResponse result = apiInstance.DeleteBrandingDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.DeleteBrandingDrop: " + e.Message );
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

**DeleteBrandingDropResponse**

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

<a name="getbrandingbrand"></a>
# **GetBrandingBrand**
> GetBrandingBrandResponse GetBrandingBrand ()

Your brand profile (approved brand partners).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // Your brand profile (approved brand partners).
                GetBrandingBrandResponse result = apiInstance.GetBrandingBrand();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingBrand: " + e.Message );
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

**GetBrandingBrandResponse**

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

<a name="getbrandingbrandterm"></a>
# **GetBrandingBrandTerm**
> GetBrandingBrandTermResponse GetBrandingBrandTerm ()

Your partner terms (fee, drops per month, units per drop, self-publish, pre-bids, promotion tier), this month's drop usage and the terms history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingBrandTermExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // Your partner terms (fee, drops per month, units per drop, self-publish, pre-bids, promotion tier), this month's drop usage and the terms history.
                GetBrandingBrandTermResponse result = apiInstance.GetBrandingBrandTerm();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingBrandTerm: " + e.Message );
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

**GetBrandingBrandTermResponse**

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

<a name="getbrandingbusinessverification"></a>
# **GetBrandingBusinessVerification**
> GetBrandingBusinessVerificationResponse GetBrandingBusinessVerification ()

Whether your Stripe account is a verified business (company, EIN/tax id verified, payouts on), with reasons and the page to fix it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingBusinessVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // Whether your Stripe account is a verified business (company, EIN/tax id verified, payouts on), with reasons and the page to fix it.
                GetBrandingBusinessVerificationResponse result = apiInstance.GetBrandingBusinessVerification();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingBusinessVerification: " + e.Message );
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

**GetBrandingBusinessVerificationResponse**

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

<a name="getbrandingdrop"></a>
# **GetBrandingDrop**
> GetBrandingDropResponse GetBrandingDrop (Guid id)

One of your drops.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One of your drops.
                GetBrandingDropResponse result = apiInstance.GetBrandingDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingDrop: " + e.Message );
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

**GetBrandingDropResponse**

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

<a name="getbrandingevent"></a>
# **GetBrandingEvent**
> GetBrandingEventResponse GetBrandingEvent (string scope = null)

Your events: upcoming grouped by date (today, this_week, later), or past.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var scope = "upcoming";  // string |  (optional) 

            try
            {
                // Your events: upcoming grouped by date (today, this_week, later), or past.
                GetBrandingEventResponse result = apiInstance.GetBrandingEvent(scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingEvent: " + e.Message );
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
 **scope** | **string**|  | [optional] 

### Return type

**GetBrandingEventResponse**

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

<a name="getbrandingsetting"></a>
# **GetBrandingSetting**
> GetBrandingSettingResponse GetBrandingSetting ()

The store’s Branding defaults new drops start from: timezone, notifyFollowers, botQueue, botCaptcha, cartHoldMinutes, leftovers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandingSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // The store’s Branding defaults new drops start from: timezone, notifyFollowers, botQueue, botCaptcha, cartHoldMinutes, leftovers.
                GetBrandingSettingResponse result = apiInstance.GetBrandingSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.GetBrandingSetting: " + e.Message );
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

**GetBrandingSettingResponse**

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

<a name="listbrandingbrandsellersearch"></a>
# **ListBrandingBrandSellerSearch**
> ListBrandingBrandSellerSearchResponse ListBrandingBrandSellerSearch (string q = null)

Find a store to authorise by its name or slug (?q=, at least 2 characters).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandingBrandSellerSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var q = "q_example";  // string |  (optional) 

            try
            {
                // Find a store to authorise by its name or slug (?q=, at least 2 characters).
                ListBrandingBrandSellerSearchResponse result = apiInstance.ListBrandingBrandSellerSearch(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.ListBrandingBrandSellerSearch: " + e.Message );
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

### Return type

**ListBrandingBrandSellerSearchResponse**

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

<a name="listbrandingbrandsellers"></a>
# **ListBrandingBrandSellers**
> ListBrandingBrandSellersResponse ListBrandingBrandSellers ()

Your authorised sellers (approved brand partners), each with its store name and status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandingBrandSellersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // Your authorised sellers (approved brand partners), each with its store name and status.
                ListBrandingBrandSellersResponse result = apiInstance.ListBrandingBrandSellers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.ListBrandingBrandSellers: " + e.Message );
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

**ListBrandingBrandSellersResponse**

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

<a name="listbrandingdropbuyers"></a>
# **ListBrandingDropBuyers**
> ListBrandingDropBuyersResponse ListBrandingDropBuyers (Guid id)

A drop's buyers: public username, units claimed, order id and when, oldest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandingDropBuyersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // A drop's buyers: public username, units claimed, order id and when, oldest first.
                ListBrandingDropBuyersResponse result = apiInstance.ListBrandingDropBuyers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.ListBrandingDropBuyers: " + e.Message );
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

**ListBrandingDropBuyersResponse**

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

<a name="listbrandingdrops"></a>
# **ListBrandingDrops**
> ListBrandingDropsResponse ListBrandingDrops (string scope = null, decimal? limit = null, string cursor = null)

Your drops, newest first, with config, waves, counts (entries, holding, sold, buyers) and phase. ?scope=upcoming|live|past|drafts|all.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandingDropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var scope = "all";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 

            try
            {
                // Your drops, newest first, with config, waves, counts (entries, holding, sold, buyers) and phase. ?scope=upcoming|live|past|drafts|all.
                ListBrandingDropsResponse result = apiInstance.ListBrandingDrops(scope, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.ListBrandingDrops: " + e.Message );
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
 **scope** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **cursor** | **string**|  | [optional] 

### Return type

**ListBrandingDropsResponse**

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

<a name="updatebrandingbrand"></a>
# **UpdateBrandingBrand**
> GetBrandingBrandResponse UpdateBrandingBrand ()

Edit your brand profile: logoUrl, bannerUrl, story, links.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandingBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);

            try
            {
                // Edit your brand profile: logoUrl, bannerUrl, story, links.
                GetBrandingBrandResponse result = apiInstance.UpdateBrandingBrand();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.UpdateBrandingBrand: " + e.Message );
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

**GetBrandingBrandResponse**

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

<a name="updatebrandingbrandseller"></a>
# **UpdateBrandingBrandSeller**
> UpdateBrandingBrandSellerResponse UpdateBrandingBrandSeller (UpdateBrandingBrandSellerRequest updateBrandingBrandSellerRequest)

Authorise a seller to sell your brand, or revoke them: { sellerUserId, status: active|revoked, note? }.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandingBrandSellerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var updateBrandingBrandSellerRequest = new UpdateBrandingBrandSellerRequest(); // UpdateBrandingBrandSellerRequest | 

            try
            {
                // Authorise a seller to sell your brand, or revoke them: { sellerUserId, status: active|revoked, note? }.
                UpdateBrandingBrandSellerResponse result = apiInstance.UpdateBrandingBrandSeller(updateBrandingBrandSellerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.UpdateBrandingBrandSeller: " + e.Message );
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
 **updateBrandingBrandSellerRequest** | **UpdateBrandingBrandSellerRequest**|  | 

### Return type

**UpdateBrandingBrandSellerResponse**

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

<a name="updatebrandingdrop"></a>
# **UpdateBrandingDrop**
> CreateBrandingDropResponse UpdateBrandingDrop (Guid id, UpdateBrandingDropRequest updateBrandingDropRequest)

Edit a drop that is not live yet. A published drop refuses rule problems (400 drop_config_problems).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandingDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var updateBrandingDropRequest = new UpdateBrandingDropRequest(); // UpdateBrandingDropRequest | 

            try
            {
                // Edit a drop that is not live yet. A published drop refuses rule problems (400 drop_config_problems).
                CreateBrandingDropResponse result = apiInstance.UpdateBrandingDrop(id, updateBrandingDropRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.UpdateBrandingDrop: " + e.Message );
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
 **updateBrandingDropRequest** | **UpdateBrandingDropRequest**|  | 

### Return type

**CreateBrandingDropResponse**

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

<a name="updatebrandingeventsetting"></a>
# **UpdateBrandingEventSetting**
> UpdateBrandingEventSettingResponse UpdateBrandingEventSetting (Guid id, UpdateBrandingEventSettingRequest updateBrandingEventSettingRequest)

Save an event's full settings (where, access, reminders, check-in, recording, linked drops) and ticket tiers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandingEventSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var id = "id_example";  // Guid | 
            var updateBrandingEventSettingRequest = new UpdateBrandingEventSettingRequest(); // UpdateBrandingEventSettingRequest | 

            try
            {
                // Save an event's full settings (where, access, reminders, check-in, recording, linked drops) and ticket tiers.
                UpdateBrandingEventSettingResponse result = apiInstance.UpdateBrandingEventSetting(id, updateBrandingEventSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.UpdateBrandingEventSetting: " + e.Message );
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
 **updateBrandingEventSettingRequest** | **UpdateBrandingEventSettingRequest**|  | 

### Return type

**UpdateBrandingEventSettingResponse**

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

<a name="updatebrandingsetting"></a>
# **UpdateBrandingSetting**
> GetBrandingSettingResponse UpdateBrandingSetting (UpdateBrandingSettingRequest updateBrandingSettingRequest = null)

Change the store’s Branding defaults (any subset of the fields).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandingSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandingApi(config);
            var updateBrandingSettingRequest = new UpdateBrandingSettingRequest(); // UpdateBrandingSettingRequest |  (optional) 

            try
            {
                // Change the store’s Branding defaults (any subset of the fields).
                GetBrandingSettingResponse result = apiInstance.UpdateBrandingSetting(updateBrandingSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingApi.UpdateBrandingSetting: " + e.Message );
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
 **updateBrandingSettingRequest** | **UpdateBrandingSettingRequest**|  | [optional] 

### Return type

**GetBrandingSettingResponse**

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

