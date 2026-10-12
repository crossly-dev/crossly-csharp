# net.crossly.Api.StallsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStallBook**](StallsApi.md#createstallbook) | **POST** /v1/stalls/book | Book and pay for a pop-up stall: { street, spotIndex, rail, unit: \&quot;day\&quot;, startDate, days } or { ..., unit: \&quot;event\&quot;, eventIds }, optional booth { canopy, pattern, lights, counter, piece } (premium values need holding; checked before paying). Paid up front; full-access token and Idempotency-Key required.
[**CreateStallBookingCancel**](StallsApi.md#createstallbookingcancel) | **POST** /v1/stalls/bookings/{id}/cancel | Cancel a stall before it opens: a full refund on the rail it was paid on. Final once it has opened.
[**GetStallQuote**](StallsApi.md#getstallquote) | **GET** /v1/stalls/quote | Quote a stall: street, spot, and either unit&#x3D;day with start (YYYY-MM-DD) and days, or unit&#x3D;event with events (comma-separated event ids). Returns the line items in cents, the rails the spot accepts and whether it is bookable.
[**ListStallMine**](StallsApi.md#liststallmine) | **GET** /v1/stalls/mine | Your stall bookings, newest first, with visits, offers and sales while the stall was up.
[**ListStreetEvents**](StallsApi.md#liststreetevents) | **GET** /v1/streets/{slug}/events | Current and upcoming street events (Night Market, Swap Meet) on a street, soonest first.
[**ListStreetStalls**](StallsApi.md#liststreetstalls) | **GET** /v1/streets/{slug}/stalls | Today&#39;s pop-up stalls on a street (each with its live listings, awning, sign and seller), plus the spots still free today. meta carries the street, the phase (day / night_market / swap_meet) and the free spots.
[**UpdateStallBooking**](StallsApi.md#updatestallbooking) | **PATCH** /v1/stalls/bookings/{id} | Change a booked stall before or while it is up: listingIds (up to 6 of your live listings), awning { colour, pattern }, booth { canopy, pattern, lights, counter, piece } (premium values need holding), sign, attendant.


<a name="createstallbook"></a>
# **CreateStallBook**
> CreateStallBookResponse CreateStallBook ()

Book and pay for a pop-up stall: { street, spotIndex, rail, unit: \"day\", startDate, days } or { ..., unit: \"event\", eventIds }, optional booth { canopy, pattern, lights, counter, piece } (premium values need holding; checked before paying). Paid up front; full-access token and Idempotency-Key required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStallBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);

            try
            {
                // Book and pay for a pop-up stall: { street, spotIndex, rail, unit: \"day\", startDate, days } or { ..., unit: \"event\", eventIds }, optional booth { canopy, pattern, lights, counter, piece } (premium values need holding; checked before paying). Paid up front; full-access token and Idempotency-Key required.
                CreateStallBookResponse result = apiInstance.CreateStallBook();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.CreateStallBook: " + e.Message );
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

**CreateStallBookResponse**

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

<a name="createstallbookingcancel"></a>
# **CreateStallBookingCancel**
> CreateStallBookingCancelResponse CreateStallBookingCancel (string id)

Cancel a stall before it opens: a full refund on the rail it was paid on. Final once it has opened.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateStallBookingCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a stall before it opens: a full refund on the rail it was paid on. Final once it has opened.
                CreateStallBookingCancelResponse result = apiInstance.CreateStallBookingCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.CreateStallBookingCancel: " + e.Message );
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

**CreateStallBookingCancelResponse**

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

<a name="getstallquote"></a>
# **GetStallQuote**
> GetStallQuoteResponse GetStallQuote (string street, int spot, string unit = null, string start = null, int? days = null, string events = null)

Quote a stall: street, spot, and either unit=day with start (YYYY-MM-DD) and days, or unit=event with events (comma-separated event ids). Returns the line items in cents, the rails the spot accepts and whether it is bookable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetStallQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);
            var street = "street_example";  // string | 
            var spot = 56;  // int | 
            var unit = "day";  // string |  (optional) 
            var start = "start_example";  // string | YYYY-MM-DD (unit=day). (optional) 
            var days = 56;  // int? | How many days (unit=day). (optional) 
            var events = "events_example";  // string | Comma-separated street event ids (unit=event). (optional) 

            try
            {
                // Quote a stall: street, spot, and either unit=day with start (YYYY-MM-DD) and days, or unit=event with events (comma-separated event ids). Returns the line items in cents, the rails the spot accepts and whether it is bookable.
                GetStallQuoteResponse result = apiInstance.GetStallQuote(street, spot, unit, start, days, events);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.GetStallQuote: " + e.Message );
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
 **street** | **string**|  | 
 **spot** | **int**|  | 
 **unit** | **string**|  | [optional] 
 **start** | **string**| YYYY-MM-DD (unit&#x3D;day). | [optional] 
 **days** | **int?**| How many days (unit&#x3D;day). | [optional] 
 **events** | **string**| Comma-separated street event ids (unit&#x3D;event). | [optional] 

### Return type

**GetStallQuoteResponse**

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

<a name="liststallmine"></a>
# **ListStallMine**
> ListStallMineResponse ListStallMine ()

Your stall bookings, newest first, with visits, offers and sales while the stall was up.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStallMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);

            try
            {
                // Your stall bookings, newest first, with visits, offers and sales while the stall was up.
                ListStallMineResponse result = apiInstance.ListStallMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.ListStallMine: " + e.Message );
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

**ListStallMineResponse**

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

<a name="liststreetevents"></a>
# **ListStreetEvents**
> ListStreetEventsResponse ListStreetEvents (string slug)

Current and upcoming street events (Night Market, Swap Meet) on a street, soonest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStreetEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Current and upcoming street events (Night Market, Swap Meet) on a street, soonest first.
                ListStreetEventsResponse result = apiInstance.ListStreetEvents(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.ListStreetEvents: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ListStreetEventsResponse**

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

<a name="liststreetstalls"></a>
# **ListStreetStalls**
> ListStreetStallsResponse ListStreetStalls (string slug)

Today's pop-up stalls on a street (each with its live listings, awning, sign and seller), plus the spots still free today. meta carries the street, the phase (day / night_market / swap_meet) and the free spots.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListStreetStallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Today's pop-up stalls on a street (each with its live listings, awning, sign and seller), plus the spots still free today. meta carries the street, the phase (day / night_market / swap_meet) and the free spots.
                ListStreetStallsResponse result = apiInstance.ListStreetStalls(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.ListStreetStalls: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ListStreetStallsResponse**

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

<a name="updatestallbooking"></a>
# **UpdateStallBooking**
> CreateStallBookResponse UpdateStallBooking (string id)

Change a booked stall before or while it is up: listingIds (up to 6 of your live listings), awning { colour, pattern }, booth { canopy, pattern, lights, counter, piece } (premium values need holding), sign, attendant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateStallBookingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StallsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Change a booked stall before or while it is up: listingIds (up to 6 of your live listings), awning { colour, pattern }, booth { canopy, pattern, lights, counter, piece } (premium values need holding), sign, attendant.
                CreateStallBookResponse result = apiInstance.UpdateStallBooking(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StallsApi.UpdateStallBooking: " + e.Message );
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

**CreateStallBookResponse**

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

