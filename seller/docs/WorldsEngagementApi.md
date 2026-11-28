# net.crossly.Api.WorldsEngagementApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorldExperienceExperienceEvent**](WorldsEngagementApi.md#createworldexperienceexperienceevent) | **POST** /v1/worlds/experiences/{experienceId}/experience-events | Schedule an Experience Event shown on the game&#39;s card: title, description, start/end (5 min–14 days, ≤ 180 days ahead), thumbnail, place. With liveEventId it follows that live-ops event&#39;s schedule.
[**CreateWorldExperienceExperienceEventCancel**](WorldsEngagementApi.md#createworldexperienceexperienceeventcancel) | **POST** /v1/worlds/experiences/{experienceId}/experience-events/{eventId}/cancel | Cancel an event (it disappears from the game&#39;s card; no reminder goes out).
[**CreateWorldExperienceExperienceEventRsvp**](WorldsEngagementApi.md#createworldexperienceexperienceeventrsvp) | **POST** /v1/worlds/experiences/{experienceId}/experience-events/{eventId}/rsvp | RSVP (going: true) or take it back. remind: true also turns the experience&#39;s notifications on, so the 15-minute reminder can reach you.
[**CreateWorldExperienceNotification**](WorldsEngagementApi.md#createworldexperiencenotification) | **POST** /v1/worlds/experiences/{experienceId}/notifications | Send an approved template to one player (sub) or up to 100 (subs). Only players who turned notifications on, 13+, not banned, at most 2 a day per player and outside their quiet hours receive it; every other send is logged as suppressed with its reason.
[**CreateWorldExperienceNotificationTemplateRetire**](WorldsEngagementApi.md#createworldexperiencenotificationtemplateretire) | **POST** /v1/worlds/experiences/{experienceId}/notification-templates/{key}/retire | Retire a template: sends by its key stop.
[**GetWorldExperienceNotificationOptIn**](WorldsEngagementApi.md#getworldexperiencenotificationoptin) | **GET** /v1/worlds/experiences/{experienceId}/notifications/opt-in | Whether you turned this experience&#39;s notifications on.
[**GetWorldExperienceNotificationReport**](WorldsEngagementApi.md#getworldexperiencenotificationreport) | **GET** /v1/worlds/experiences/{experienceId}/notifications/report | Sends over the last N days (default 7, max 90): delivered, suppressed by reason, per template, and how many players turned notifications on.
[**ListWorldExperienceEventUpcoming**](WorldsEngagementApi.md#listworldexperienceeventupcoming) | **GET** /v1/worlds/experience-events/upcoming | Events across public experiences in the next 7 days (and live now), soonest first — the Carnival Plaza&#39;s \&quot;Coming up\&quot; board.
[**ListWorldExperienceExperienceEventUpcoming**](WorldsEngagementApi.md#listworldexperienceexperienceeventupcoming) | **GET** /v1/worlds/experiences/{experienceId}/experience-events/upcoming | An experience&#39;s upcoming and live events as players see them, with whether you are going.
[**ListWorldExperienceExperienceEvents**](WorldsEngagementApi.md#listworldexperienceexperienceevents) | **GET** /v1/worlds/experiences/{experienceId}/experience-events | Your scheduled Experience Events (upcoming, live and the last 30 days) with RSVP counts.
[**ListWorldExperienceNotificationTemplates**](WorldsEngagementApi.md#listworldexperiencenotificationtemplates) | **GET** /v1/worlds/experiences/{experienceId}/notification-templates | Notification templates: key, title and body with {placeholders}, review status (approved ones can be sent).
[**ListWorldMeExperienceEvents**](WorldsEngagementApi.md#listworldmeexperienceevents) | **GET** /v1/worlds/me/experience-events | Events you are going to that have not ended.
[**ListWorldMeNotificationOptIns**](WorldsEngagementApi.md#listworldmenotificationoptins) | **GET** /v1/worlds/me/notification-opt-ins | Every experience whose notifications you turned on.
[**UpdateWorldExperienceExperienceEvent**](WorldsEngagementApi.md#updateworldexperienceexperienceevent) | **PATCH** /v1/worlds/experiences/{experienceId}/experience-events/{eventId} | Change an event. A started event keeps its start; a new start time earns RSVPs a new reminder.
[**UpdateWorldExperienceNotificationOptIn**](WorldsEngagementApi.md#updateworldexperiencenotificationoptin) | **PUT** /v1/worlds/experiences/{experienceId}/notifications/opt-in | Turn this experience&#39;s notifications on or off for you. timeZone (IANA) keeps them out of your night.
[**UpdateWorldExperienceNotificationTemplate**](WorldsEngagementApi.md#updateworldexperiencenotificationtemplate) | **PUT** /v1/worlds/experiences/{experienceId}/notification-templates/{key} | Create or reword a template. Clean words with no link are approved at once; anything the text filter flags, or any link, waits for Crossly review (24 h). Rewording re-reviews.


<a name="createworldexperienceexperienceevent"></a>
# **CreateWorldExperienceExperienceEvent**
> WorldExperienceExperienceEventResponse CreateWorldExperienceExperienceEvent (string experienceId, CreateWorldExperienceExperienceEventRequest createWorldExperienceExperienceEventRequest = null)

Schedule an Experience Event shown on the game's card: title, description, start/end (5 min–14 days, ≤ 180 days ahead), thumbnail, place. With liveEventId it follows that live-ops event's schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceExperienceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var createWorldExperienceExperienceEventRequest = new CreateWorldExperienceExperienceEventRequest(); // CreateWorldExperienceExperienceEventRequest |  (optional) 

            try
            {
                // Schedule an Experience Event shown on the game's card: title, description, start/end (5 min–14 days, ≤ 180 days ahead), thumbnail, place. With liveEventId it follows that live-ops event's schedule.
                WorldExperienceExperienceEventResponse result = apiInstance.CreateWorldExperienceExperienceEvent(experienceId, createWorldExperienceExperienceEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.CreateWorldExperienceExperienceEvent: " + e.Message );
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
 **experienceId** | **string**|  | 
 **createWorldExperienceExperienceEventRequest** | **CreateWorldExperienceExperienceEventRequest**|  | [optional] 

### Return type

**WorldExperienceExperienceEventResponse**

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

<a name="createworldexperienceexperienceeventcancel"></a>
# **CreateWorldExperienceExperienceEventCancel**
> WorldExperienceExperienceEventResponse CreateWorldExperienceExperienceEventCancel (string experienceId, string eventId)

Cancel an event (it disappears from the game's card; no reminder goes out).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceExperienceEventCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var eventId = "eventId_example";  // string | 

            try
            {
                // Cancel an event (it disappears from the game's card; no reminder goes out).
                WorldExperienceExperienceEventResponse result = apiInstance.CreateWorldExperienceExperienceEventCancel(experienceId, eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.CreateWorldExperienceExperienceEventCancel: " + e.Message );
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
 **experienceId** | **string**|  | 
 **eventId** | **string**|  | 

### Return type

**WorldExperienceExperienceEventResponse**

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

<a name="createworldexperienceexperienceeventrsvp"></a>
# **CreateWorldExperienceExperienceEventRsvp**
> WorldExperienceExperienceEventResponse CreateWorldExperienceExperienceEventRsvp (string experienceId, string eventId, CreateWorldExperienceExperienceEventRsvpRequest createWorldExperienceExperienceEventRsvpRequest = null)

RSVP (going: true) or take it back. remind: true also turns the experience's notifications on, so the 15-minute reminder can reach you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceExperienceEventRsvpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var eventId = "eventId_example";  // string | 
            var createWorldExperienceExperienceEventRsvpRequest = new CreateWorldExperienceExperienceEventRsvpRequest(); // CreateWorldExperienceExperienceEventRsvpRequest |  (optional) 

            try
            {
                // RSVP (going: true) or take it back. remind: true also turns the experience's notifications on, so the 15-minute reminder can reach you.
                WorldExperienceExperienceEventResponse result = apiInstance.CreateWorldExperienceExperienceEventRsvp(experienceId, eventId, createWorldExperienceExperienceEventRsvpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.CreateWorldExperienceExperienceEventRsvp: " + e.Message );
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
 **experienceId** | **string**|  | 
 **eventId** | **string**|  | 
 **createWorldExperienceExperienceEventRsvpRequest** | **CreateWorldExperienceExperienceEventRsvpRequest**|  | [optional] 

### Return type

**WorldExperienceExperienceEventResponse**

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

<a name="createworldexperiencenotification"></a>
# **CreateWorldExperienceNotification**
> CreateWorldExperienceNotificationResponse CreateWorldExperienceNotification (string experienceId, CreateWorldExperienceNotificationRequest createWorldExperienceNotificationRequest = null)

Send an approved template to one player (sub) or up to 100 (subs). Only players who turned notifications on, 13+, not banned, at most 2 a day per player and outside their quiet hours receive it; every other send is logged as suppressed with its reason.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var createWorldExperienceNotificationRequest = new CreateWorldExperienceNotificationRequest(); // CreateWorldExperienceNotificationRequest |  (optional) 

            try
            {
                // Send an approved template to one player (sub) or up to 100 (subs). Only players who turned notifications on, 13+, not banned, at most 2 a day per player and outside their quiet hours receive it; every other send is logged as suppressed with its reason.
                CreateWorldExperienceNotificationResponse result = apiInstance.CreateWorldExperienceNotification(experienceId, createWorldExperienceNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.CreateWorldExperienceNotification: " + e.Message );
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
 **experienceId** | **string**|  | 
 **createWorldExperienceNotificationRequest** | **CreateWorldExperienceNotificationRequest**|  | [optional] 

### Return type

**CreateWorldExperienceNotificationResponse**

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

<a name="createworldexperiencenotificationtemplateretire"></a>
# **CreateWorldExperienceNotificationTemplateRetire**
> UpdateWorldExperienceNotificationTemplateResponse CreateWorldExperienceNotificationTemplateRetire (string experienceId, string key)

Retire a template: sends by its key stop.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceNotificationTemplateRetireExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Retire a template: sends by its key stop.
                UpdateWorldExperienceNotificationTemplateResponse result = apiInstance.CreateWorldExperienceNotificationTemplateRetire(experienceId, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.CreateWorldExperienceNotificationTemplateRetire: " + e.Message );
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
 **experienceId** | **string**|  | 
 **key** | **string**|  | 

### Return type

**UpdateWorldExperienceNotificationTemplateResponse**

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

<a name="getworldexperiencenotificationoptin"></a>
# **GetWorldExperienceNotificationOptIn**
> GetWorldExperienceNotificationOptInResponse GetWorldExperienceNotificationOptIn (string experienceId)

Whether you turned this experience's notifications on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceNotificationOptInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Whether you turned this experience's notifications on.
                GetWorldExperienceNotificationOptInResponse result = apiInstance.GetWorldExperienceNotificationOptIn(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.GetWorldExperienceNotificationOptIn: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**GetWorldExperienceNotificationOptInResponse**

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

<a name="getworldexperiencenotificationreport"></a>
# **GetWorldExperienceNotificationReport**
> GetWorldExperienceNotificationReportResponse GetWorldExperienceNotificationReport (string experienceId, decimal? days = null)

Sends over the last N days (default 7, max 90): delivered, suppressed by reason, per template, and how many players turned notifications on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceNotificationReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var days = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Sends over the last N days (default 7, max 90): delivered, suppressed by reason, per template, and how many players turned notifications on.
                GetWorldExperienceNotificationReportResponse result = apiInstance.GetWorldExperienceNotificationReport(experienceId, days);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.GetWorldExperienceNotificationReport: " + e.Message );
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
 **experienceId** | **string**|  | 
 **days** | **decimal?**|  | [optional] 

### Return type

**GetWorldExperienceNotificationReportResponse**

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

<a name="listworldexperienceeventupcoming"></a>
# **ListWorldExperienceEventUpcoming**
> ListWorldExperienceEventUpcomingResponse ListWorldExperienceEventUpcoming (decimal? limit = null)

Events across public experiences in the next 7 days (and live now), soonest first — the Carnival Plaza's \"Coming up\" board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceEventUpcomingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Events across public experiences in the next 7 days (and live now), soonest first — the Carnival Plaza's \"Coming up\" board.
                ListWorldExperienceEventUpcomingResponse result = apiInstance.ListWorldExperienceEventUpcoming(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldExperienceEventUpcoming: " + e.Message );
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
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListWorldExperienceEventUpcomingResponse**

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

<a name="listworldexperienceexperienceeventupcoming"></a>
# **ListWorldExperienceExperienceEventUpcoming**
> ListWorldExperienceExperienceEventsResponse ListWorldExperienceExperienceEventUpcoming (string experienceId)

An experience's upcoming and live events as players see them, with whether you are going.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceExperienceEventUpcomingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // An experience's upcoming and live events as players see them, with whether you are going.
                ListWorldExperienceExperienceEventsResponse result = apiInstance.ListWorldExperienceExperienceEventUpcoming(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldExperienceExperienceEventUpcoming: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**ListWorldExperienceExperienceEventsResponse**

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

<a name="listworldexperienceexperienceevents"></a>
# **ListWorldExperienceExperienceEvents**
> ListWorldExperienceExperienceEventsResponse ListWorldExperienceExperienceEvents (string experienceId)

Your scheduled Experience Events (upcoming, live and the last 30 days) with RSVP counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceExperienceEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Your scheduled Experience Events (upcoming, live and the last 30 days) with RSVP counts.
                ListWorldExperienceExperienceEventsResponse result = apiInstance.ListWorldExperienceExperienceEvents(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldExperienceExperienceEvents: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**ListWorldExperienceExperienceEventsResponse**

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

<a name="listworldexperiencenotificationtemplates"></a>
# **ListWorldExperienceNotificationTemplates**
> ListWorldExperienceNotificationTemplatesResponse ListWorldExperienceNotificationTemplates (string experienceId)

Notification templates: key, title and body with {placeholders}, review status (approved ones can be sent).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceNotificationTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Notification templates: key, title and body with {placeholders}, review status (approved ones can be sent).
                ListWorldExperienceNotificationTemplatesResponse result = apiInstance.ListWorldExperienceNotificationTemplates(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldExperienceNotificationTemplates: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**ListWorldExperienceNotificationTemplatesResponse**

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

<a name="listworldmeexperienceevents"></a>
# **ListWorldMeExperienceEvents**
> ListWorldMeExperienceEventsResponse ListWorldMeExperienceEvents ()

Events you are going to that have not ended.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldMeExperienceEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);

            try
            {
                // Events you are going to that have not ended.
                ListWorldMeExperienceEventsResponse result = apiInstance.ListWorldMeExperienceEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldMeExperienceEvents: " + e.Message );
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

**ListWorldMeExperienceEventsResponse**

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

<a name="listworldmenotificationoptins"></a>
# **ListWorldMeNotificationOptIns**
> ListWorldMeNotificationOptInsResponse ListWorldMeNotificationOptIns ()

Every experience whose notifications you turned on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldMeNotificationOptInsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);

            try
            {
                // Every experience whose notifications you turned on.
                ListWorldMeNotificationOptInsResponse result = apiInstance.ListWorldMeNotificationOptIns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.ListWorldMeNotificationOptIns: " + e.Message );
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

**ListWorldMeNotificationOptInsResponse**

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

<a name="updateworldexperienceexperienceevent"></a>
# **UpdateWorldExperienceExperienceEvent**
> WorldExperienceExperienceEventResponse UpdateWorldExperienceExperienceEvent (string experienceId, string eventId, UpdateWorldExperienceExperienceEventRequest updateWorldExperienceExperienceEventRequest = null)

Change an event. A started event keeps its start; a new start time earns RSVPs a new reminder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceExperienceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var eventId = "eventId_example";  // string | 
            var updateWorldExperienceExperienceEventRequest = new UpdateWorldExperienceExperienceEventRequest(); // UpdateWorldExperienceExperienceEventRequest |  (optional) 

            try
            {
                // Change an event. A started event keeps its start; a new start time earns RSVPs a new reminder.
                WorldExperienceExperienceEventResponse result = apiInstance.UpdateWorldExperienceExperienceEvent(experienceId, eventId, updateWorldExperienceExperienceEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.UpdateWorldExperienceExperienceEvent: " + e.Message );
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
 **experienceId** | **string**|  | 
 **eventId** | **string**|  | 
 **updateWorldExperienceExperienceEventRequest** | **UpdateWorldExperienceExperienceEventRequest**|  | [optional] 

### Return type

**WorldExperienceExperienceEventResponse**

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

<a name="updateworldexperiencenotificationoptin"></a>
# **UpdateWorldExperienceNotificationOptIn**
> GetWorldExperienceNotificationOptInResponse UpdateWorldExperienceNotificationOptIn (string experienceId, UpdateWorldExperienceNotificationOptInRequest updateWorldExperienceNotificationOptInRequest = null)

Turn this experience's notifications on or off for you. timeZone (IANA) keeps them out of your night.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceNotificationOptInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var updateWorldExperienceNotificationOptInRequest = new UpdateWorldExperienceNotificationOptInRequest(); // UpdateWorldExperienceNotificationOptInRequest |  (optional) 

            try
            {
                // Turn this experience's notifications on or off for you. timeZone (IANA) keeps them out of your night.
                GetWorldExperienceNotificationOptInResponse result = apiInstance.UpdateWorldExperienceNotificationOptIn(experienceId, updateWorldExperienceNotificationOptInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.UpdateWorldExperienceNotificationOptIn: " + e.Message );
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
 **experienceId** | **string**|  | 
 **updateWorldExperienceNotificationOptInRequest** | **UpdateWorldExperienceNotificationOptInRequest**|  | [optional] 

### Return type

**GetWorldExperienceNotificationOptInResponse**

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

<a name="updateworldexperiencenotificationtemplate"></a>
# **UpdateWorldExperienceNotificationTemplate**
> UpdateWorldExperienceNotificationTemplateResponse UpdateWorldExperienceNotificationTemplate (string experienceId, string key, CreateGroupBuyMessageRequest createGroupBuyMessageRequest = null)

Create or reword a template. Clean words with no link are approved at once; anything the text filter flags, or any link, waits for Crossly review (24 h). Rewording re-reviews.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceNotificationTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsEngagementApi(config);
            var experienceId = "experienceId_example";  // string | 
            var key = "key_example";  // string | 
            var createGroupBuyMessageRequest = new CreateGroupBuyMessageRequest(); // CreateGroupBuyMessageRequest |  (optional) 

            try
            {
                // Create or reword a template. Clean words with no link are approved at once; anything the text filter flags, or any link, waits for Crossly review (24 h). Rewording re-reviews.
                UpdateWorldExperienceNotificationTemplateResponse result = apiInstance.UpdateWorldExperienceNotificationTemplate(experienceId, key, createGroupBuyMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsEngagementApi.UpdateWorldExperienceNotificationTemplate: " + e.Message );
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
 **experienceId** | **string**|  | 
 **key** | **string**|  | 
 **createGroupBuyMessageRequest** | **CreateGroupBuyMessageRequest**|  | [optional] 

### Return type

**UpdateWorldExperienceNotificationTemplateResponse**

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

