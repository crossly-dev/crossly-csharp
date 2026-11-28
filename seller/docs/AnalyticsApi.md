# net.crossly.Api.AnalyticsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnalyticExperiment**](AnalyticsApi.md#createanalyticexperiment) | **POST** /v1/analytics/experiments | Start a listing experiment. split: 2-4 live platform listings observed over the same window; sequential: one platform listing, before vs after changeAt (optionally applying a new price).
[**CreateAnalyticExperimentDeclare**](AnalyticsApi.md#createanalyticexperimentdeclare) | **POST** /v1/analytics/experiments/{id}/declare | Record the outcome: a winning arm, no difference, or inconclusive. Concludes the experiment.
[**CreateAnalyticExperimentStop**](AnalyticsApi.md#createanalyticexperimentstop) | **POST** /v1/analytics/experiments/{id}/stop | Stop an experiment: no more data is counted after now.
[**DeleteAnalyticExperiment**](AnalyticsApi.md#deleteanalyticexperiment) | **DELETE** /v1/analytics/experiments/{id} | Delete an experiment. The listings are untouched.
[**GetAnalyticBookkeeping**](AnalyticsApi.md#getanalyticbookkeeping) | **GET** /v1/analytics/bookkeeping | Monthly P&amp;L + per-platform breakdown for a calendar year.
[**GetAnalyticByPlatform**](AnalyticsApi.md#getanalyticbyplatform) | **GET** /v1/analytics/by-platform | Sales, net sales, fees and net profit by platform for the last N days.
[**GetAnalyticCompare**](AnalyticsApi.md#getanalyticcompare) | **GET** /v1/analytics/compare | Compare 2-4 of your listings: columns of price, quality, channels, views, favorites, offers and outcome, engagement curves, the fields that differ, and observational tests of favorite rate, view-to-offer rate and views per day.
[**GetAnalyticDashboard**](AnalyticsApi.md#getanalyticdashboard) | **GET** /v1/analytics/dashboard | Composite dashboard: KPIs + breakdowns + recent activity.
[**GetAnalyticExperiment**](AnalyticsApi.md#getanalyticexperiment) | **GET** /v1/analytics/experiments | Your listing A/B experiments, newest first, with status, days running and the current verdict.
[**GetAnalyticExperimentById**](AnalyticsApi.md#getanalyticexperimentbyid) | **GET** /v1/analytics/experiments/{id} | One experiment: arms with their windows, exposure and rates, the primary-metric test per arm against A, guardrail tests, the daily series and what to do next.
[**GetAnalyticInventory**](AnalyticsApi.md#getanalyticinventory) | **GET** /v1/analytics/inventory | Unsold stock: aging buckets with cost, listed value and market value, the 20 listings most in need of attention, shelf value over time, cohort sell-through at the chosen maturity, listed vs sold velocity and data health.
[**GetAnalyticItem**](AnalyticsApi.md#getanalyticitem) | **GET** /v1/analytics/items | Per-item P&amp;L for sold inventory.
[**GetAnalyticItemByListingId**](AnalyticsApi.md#getanalyticitembylistingid) | **GET** /v1/analytics/items/{listingId} | One listing in depth: channels with views, favorites and offers, the merged timeline, engagement series, price history, comps, money waterfall, days on market, offers, messages, experiments and suggestions.
[**GetAnalyticMarketplace**](AnalyticsApi.md#getanalyticmarketplace) | **GET** /v1/analytics/marketplaces | Every marketplace side by side: net sales and profit, units, ASP, take rate, margin, shipping subsidy, days to sell, sell-through, cancel and return rates, offers and engagement; with vs&#x3D;2-3 platforms, a head-to-head over listings live on all of them.
[**GetAnalyticMarketplaceByPlatform**](AnalyticsApi.md#getanalyticmarketplacebyplatform) | **GET** /v1/analytics/marketplaces/{platform} | One marketplace in depth: its row, the money series, fee breakdown, days-to-sell and price-realization histograms, categories, top items, at-risk listings, a day-by-hour sales heatmap and offer stats.
[**GetAnalyticOverview**](AnalyticsApi.md#getanalyticoverview) | **GET** /v1/analytics/overview | KPIs with deltas (net sales, net profit, units, ASP, margin, sell-through, median days to sell, active listings, take rate), the trend series, by-marketplace split, top categories, brands and items, sell-through cohort, data health and insights.
[**GetAnalyticPerformance**](AnalyticsApi.md#getanalyticperformance) | **GET** /v1/analytics/performance | Per-listing performance: channels, views, favorites, offers and conversations in the period, units sold, net sales and profit, margin, days to sell and a 0-100 health score, paged and sortable.
[**GetAnalyticProgram**](AnalyticsApi.md#getanalyticprogram) | **GET** /v1/analytics/programs/{program} | One program&#39;s report over a date range (default the last 30 days, at most 366): KPIs, a daily trend and a breakdown table. Money in integer cents.
[**GetAnalyticSegment**](AnalyticsApi.md#getanalyticsegment) | **GET** /v1/analytics/segments | Niches along one dimension: listed and active counts, units sold, cohort sell-through, median days to sell, net sales and profit, margin, ROI, ASP and discount from ask; rows under minN are flagged lowSample.
[**GetAnalyticSegmentByKey**](AnalyticsApi.md#getanalyticsegmentbykey) | **GET** /v1/analytics/segments/{dim}/{key} | One niche in depth: its row, series, by-marketplace split, days-to-sell histogram, price bands, top items and the 10 oldest unsold listings in it.
[**GetAnalyticSummary**](AnalyticsApi.md#getanalyticsummary) | **GET** /v1/analytics/summary | Headline KPIs for the last N days (the same numbers as the analytics overview).
[**GetAnalyticTimesery**](AnalyticsApi.md#getanalytictimesery) | **GET** /v1/analytics/timeseries | Sales and net sales over the last N days, zero-filled, one row per calendar day.
[**GetAnalyticToday**](AnalyticsApi.md#getanalytictoday) | **GET** /v1/analytics/today | Today&#39;s checklist + 14-day activity streak.
[**ListInsightByPlatform**](AnalyticsApi.md#listinsightbyplatform) | **GET** /v1/insights/by-platform | Platform velocity + margin insight (90-day window): units, net sales, median days to sell, ASP and net after the real marketplace fees.
[**UpdateAnalyticExperiment**](AnalyticsApi.md#updateanalyticexperiment) | **PATCH** /v1/analytics/experiments/{id} | Rename an experiment or change its hypothesis, notes or planned end.


<a name="createanalyticexperiment"></a>
# **CreateAnalyticExperiment**
> AnalyticExperimentResponse CreateAnalyticExperiment ()

Start a listing experiment. split: 2-4 live platform listings observed over the same window; sequential: one platform listing, before vs after changeAt (optionally applying a new price).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAnalyticExperimentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);

            try
            {
                // Start a listing experiment. split: 2-4 live platform listings observed over the same window; sequential: one platform listing, before vs after changeAt (optionally applying a new price).
                AnalyticExperimentResponse result = apiInstance.CreateAnalyticExperiment();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateAnalyticExperiment: " + e.Message );
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

**AnalyticExperimentResponse**

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

<a name="createanalyticexperimentdeclare"></a>
# **CreateAnalyticExperimentDeclare**
> AnalyticExperimentResponse CreateAnalyticExperimentDeclare (string id)

Record the outcome: a winning arm, no difference, or inconclusive. Concludes the experiment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAnalyticExperimentDeclareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var id = "id_example";  // string | The experiment id (a uuid; any other id is a 404).

            try
            {
                // Record the outcome: a winning arm, no difference, or inconclusive. Concludes the experiment.
                AnalyticExperimentResponse result = apiInstance.CreateAnalyticExperimentDeclare(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateAnalyticExperimentDeclare: " + e.Message );
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
 **id** | **string**| The experiment id (a uuid; any other id is a 404). | 

### Return type

**AnalyticExperimentResponse**

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

<a name="createanalyticexperimentstop"></a>
# **CreateAnalyticExperimentStop**
> AnalyticExperimentResponse CreateAnalyticExperimentStop (string id)

Stop an experiment: no more data is counted after now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAnalyticExperimentStopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var id = "id_example";  // string | The experiment id (a uuid; any other id is a 404).

            try
            {
                // Stop an experiment: no more data is counted after now.
                AnalyticExperimentResponse result = apiInstance.CreateAnalyticExperimentStop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateAnalyticExperimentStop: " + e.Message );
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
 **id** | **string**| The experiment id (a uuid; any other id is a 404). | 

### Return type

**AnalyticExperimentResponse**

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

<a name="deleteanalyticexperiment"></a>
# **DeleteAnalyticExperiment**
> DeleteStoryResponse DeleteAnalyticExperiment (string id)

Delete an experiment. The listings are untouched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAnalyticExperimentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var id = "id_example";  // string | The experiment id (a uuid; any other id is a 404).

            try
            {
                // Delete an experiment. The listings are untouched.
                DeleteStoryResponse result = apiInstance.DeleteAnalyticExperiment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteAnalyticExperiment: " + e.Message );
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
 **id** | **string**| The experiment id (a uuid; any other id is a 404). | 

### Return type

**DeleteStoryResponse**

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

<a name="getanalyticbookkeeping"></a>
# **GetAnalyticBookkeeping**
> GetAnalyticBookkeepingResponse GetAnalyticBookkeeping (decimal? year = null)

Monthly P&L + per-platform breakdown for a calendar year.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticBookkeepingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var year = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Monthly P&L + per-platform breakdown for a calendar year.
                GetAnalyticBookkeepingResponse result = apiInstance.GetAnalyticBookkeeping(year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticBookkeeping: " + e.Message );
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
 **year** | **decimal?**|  | [optional] 

### Return type

**GetAnalyticBookkeepingResponse**

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

<a name="getanalyticbyplatform"></a>
# **GetAnalyticByPlatform**
> GetAnalyticByPlatformResponse GetAnalyticByPlatform (int? days = null, string tz = null)

Sales, net sales, fees and net profit by platform for the last N days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticByPlatformExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var days = 30;  // int? | Calendar days back, today included. Larger values are clamped to 365. (optional)  (default to 30)
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. (optional) 

            try
            {
                // Sales, net sales, fees and net profit by platform for the last N days.
                GetAnalyticByPlatformResponse result = apiInstance.GetAnalyticByPlatform(days, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticByPlatform: " + e.Message );
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
 **days** | **int?**| Calendar days back, today included. Larger values are clamped to 365. | [optional] [default to 30]
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. | [optional] 

### Return type

**GetAnalyticByPlatformResponse**

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

<a name="getanalyticcompare"></a>
# **GetAnalyticCompare**
> GetAnalyticCompareResponse GetAnalyticCompare (string ids, string align = null, string platform = null, string tz = null)

Compare 2-4 of your listings: columns of price, quality, channels, views, favorites, offers and outcome, engagement curves, the fields that differ, and observational tests of favorite rate, view-to-offer rate and views per day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticCompareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var ids = "ids_example";  // string | Comma-separated listing ids, 2 to 4. The first is arm A.
            var align = "age";  // string | age = x is days since first listed (default); calendar = x is the date. (optional) 
            var platform = "platform_example";  // string | Restrict engagement to one channel (platform id). (optional) 
            var tz = "tz_example";  // string | IANA time zone. Default UTC. (optional) 

            try
            {
                // Compare 2-4 of your listings: columns of price, quality, channels, views, favorites, offers and outcome, engagement curves, the fields that differ, and observational tests of favorite rate, view-to-offer rate and views per day.
                GetAnalyticCompareResponse result = apiInstance.GetAnalyticCompare(ids, align, platform, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticCompare: " + e.Message );
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
 **ids** | **string**| Comma-separated listing ids, 2 to 4. The first is arm A. | 
 **align** | **string**| age &#x3D; x is days since first listed (default); calendar &#x3D; x is the date. | [optional] 
 **platform** | **string**| Restrict engagement to one channel (platform id). | [optional] 
 **tz** | **string**| IANA time zone. Default UTC. | [optional] 

### Return type

**GetAnalyticCompareResponse**

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

<a name="getanalyticdashboard"></a>
# **GetAnalyticDashboard**
> GetAnalyticDashboardResponse GetAnalyticDashboard (string range = null, string startDate = null, string endDate = null, string labels = null, string tz = null)

Composite dashboard: KPIs + breakdowns + recent activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticDashboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "custom";  // string |  (optional) 
            var startDate = "startDate_example";  // string |  (optional) 
            var endDate = "endDate_example";  // string |  (optional) 
            var labels = "labels_example";  // string |  (optional) 
            var tz = "tz_example";  // string |  (optional) 

            try
            {
                // Composite dashboard: KPIs + breakdowns + recent activity.
                GetAnalyticDashboardResponse result = apiInstance.GetAnalyticDashboard(range, startDate, endDate, labels, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticDashboard: " + e.Message );
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
 **range** | **string**|  | [optional] 
 **startDate** | **string**|  | [optional] 
 **endDate** | **string**|  | [optional] 
 **labels** | **string**|  | [optional] 
 **tz** | **string**|  | [optional] 

### Return type

**GetAnalyticDashboardResponse**

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

<a name="getanalyticexperiment"></a>
# **GetAnalyticExperiment**
> GetAnalyticExperimentResponse GetAnalyticExperiment (string status = null, int? page = null, int? size = null)

Your listing A/B experiments, newest first, with status, days running and the current verdict.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticExperimentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var status = "all";  // string | Default all. (optional) 
            var page = 56;  // int? | 1-indexed page. Default 1. (optional) 
            var size = 56;  // int? | Rows per page. Default 20. (optional) 

            try
            {
                // Your listing A/B experiments, newest first, with status, days running and the current verdict.
                GetAnalyticExperimentResponse result = apiInstance.GetAnalyticExperiment(status, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticExperiment: " + e.Message );
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
 **status** | **string**| Default all. | [optional] 
 **page** | **int?**| 1-indexed page. Default 1. | [optional] 
 **size** | **int?**| Rows per page. Default 20. | [optional] 

### Return type

**GetAnalyticExperimentResponse**

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

<a name="getanalyticexperimentbyid"></a>
# **GetAnalyticExperimentById**
> GetAnalyticExperimentByIdResponse GetAnalyticExperimentById (string id)

One experiment: arms with their windows, exposure and rates, the primary-metric test per arm against A, guardrail tests, the daily series and what to do next.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticExperimentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var id = "id_example";  // string | The experiment id (a uuid).

            try
            {
                // One experiment: arms with their windows, exposure and rates, the primary-metric test per arm against A, guardrail tests, the daily series and what to do next.
                GetAnalyticExperimentByIdResponse result = apiInstance.GetAnalyticExperimentById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticExperimentById: " + e.Message );
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
 **id** | **string**| The experiment id (a uuid). | 

### Return type

**GetAnalyticExperimentByIdResponse**

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

<a name="getanalyticinventory"></a>
# **GetAnalyticInventory**
> GetAnalyticInventoryResponse GetAnalyticInventory (string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null, int? maturity = null)

Unsold stock: aging buckets with cost, listed value and market value, the 20 listings most in need of attention, shelf value over time, cohort sell-through at the chosen maturity, listed vs sold velocity and data health.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 
            var maturity = 30;  // int? | Days an item has to sell within to count as sold in the cohort. Default 30. (optional) 

            try
            {
                // Unsold stock: aging buckets with cost, listed value and market value, the 20 listings most in need of attention, shelf value over time, cohort sell-through at the chosen maturity, listed vs sold velocity and data health.
                GetAnalyticInventoryResponse result = apiInstance.GetAnalyticInventory(range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz, maturity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticInventory: " + e.Message );
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
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 
 **maturity** | **int?**| Days an item has to sell within to count as sold in the cohort. Default 30. | [optional] 

### Return type

**GetAnalyticInventoryResponse**

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

<a name="getanalyticitem"></a>
# **GetAnalyticItem**
> GetAnalyticItemResponse GetAnalyticItem (decimal? page = null, decimal? limit = null, string sortBy = null, string sortOrder = null)

Per-item P&L for sold inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var page = 8.14D;  // decimal? |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var sortBy = "platform";  // string |  (optional) 
            var sortOrder = "asc";  // string |  (optional) 

            try
            {
                // Per-item P&L for sold inventory.
                GetAnalyticItemResponse result = apiInstance.GetAnalyticItem(page, limit, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticItem: " + e.Message );
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
 **page** | **decimal?**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **sortBy** | **string**|  | [optional] 
 **sortOrder** | **string**|  | [optional] 

### Return type

**GetAnalyticItemResponse**

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

<a name="getanalyticitembylistingid"></a>
# **GetAnalyticItemByListingId**
> GetAnalyticItemByListingIdResponse GetAnalyticItemByListingId (string listingId, string by = null, string tz = null)

One listing in depth: channels with views, favorites and offers, the merged timeline, engagement series, price history, comps, money waterfall, days on market, offers, messages, experiments and suggestions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticItemByListingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var listingId = "listingId_example";  // string | A listings.id you own (or an inventory item id with by=inventory).
            var by = "listing";  // string | inventory = the id is an inventory item id; the answer is { redirectListingId }. Default listing. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. (optional) 

            try
            {
                // One listing in depth: channels with views, favorites and offers, the merged timeline, engagement series, price history, comps, money waterfall, days on market, offers, messages, experiments and suggestions.
                GetAnalyticItemByListingIdResponse result = apiInstance.GetAnalyticItemByListingId(listingId, by, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticItemByListingId: " + e.Message );
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
 **listingId** | **string**| A listings.id you own (or an inventory item id with by&#x3D;inventory). | 
 **by** | **string**| inventory &#x3D; the id is an inventory item id; the answer is { redirectListingId }. Default listing. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. | [optional] 

### Return type

**GetAnalyticItemByListingIdResponse**

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

<a name="getanalyticmarketplace"></a>
# **GetAnalyticMarketplace**
> GetAnalyticMarketplaceResponse GetAnalyticMarketplace (string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null, string vs = null, string sort = null, string dir = null)

Every marketplace side by side: net sales and profit, units, ASP, take rate, margin, shipping subsidy, days to sell, sell-through, cancel and return rates, offers and engagement; with vs=2-3 platforms, a head-to-head over listings live on all of them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticMarketplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 
            var vs = "vs_example";  // string | Comma-separated 2-3 platform ids for the head-to-head. (optional) 
            var sort = "netSales";  // string | Default netSales. (optional) 
            var dir = "asc";  // string | Default desc. (optional) 

            try
            {
                // Every marketplace side by side: net sales and profit, units, ASP, take rate, margin, shipping subsidy, days to sell, sell-through, cancel and return rates, offers and engagement; with vs=2-3 platforms, a head-to-head over listings live on all of them.
                GetAnalyticMarketplaceResponse result = apiInstance.GetAnalyticMarketplace(range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz, vs, sort, dir);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticMarketplace: " + e.Message );
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
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 
 **vs** | **string**| Comma-separated 2-3 platform ids for the head-to-head. | [optional] 
 **sort** | **string**| Default netSales. | [optional] 
 **dir** | **string**| Default desc. | [optional] 

### Return type

**GetAnalyticMarketplaceResponse**

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

<a name="getanalyticmarketplacebyplatform"></a>
# **GetAnalyticMarketplaceByPlatform**
> GetAnalyticMarketplaceByPlatformResponse GetAnalyticMarketplaceByPlatform (string platform, string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null)

One marketplace in depth: its row, the money series, fee breakdown, days-to-sell and price-realization histograms, categories, top items, at-risk listings, a day-by-hour sales heatmap and offer stats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticMarketplaceByPlatformExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var platform = "platform_example";  // string | A platform id, e.g. ebay, poshmark.
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 

            try
            {
                // One marketplace in depth: its row, the money series, fee breakdown, days-to-sell and price-realization histograms, categories, top items, at-risk listings, a day-by-hour sales heatmap and offer stats.
                GetAnalyticMarketplaceByPlatformResponse result = apiInstance.GetAnalyticMarketplaceByPlatform(platform, range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticMarketplaceByPlatform: " + e.Message );
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
 **platform** | **string**| A platform id, e.g. ebay, poshmark. | 
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 

### Return type

**GetAnalyticMarketplaceByPlatformResponse**

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

<a name="getanalyticoverview"></a>
# **GetAnalyticOverview**
> GetAnalyticOverviewResponse GetAnalyticOverview (string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null, string stores = null)

KPIs with deltas (net sales, net profit, units, ASP, margin, sell-through, median days to sell, active listings, take rate), the trend series, by-marketplace split, top categories, brands and items, sell-through cohort, data health and insights.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 
            var stores = "stores_example";  // string | Comma-separated store ids. (optional) 

            try
            {
                // KPIs with deltas (net sales, net profit, units, ASP, margin, sell-through, median days to sell, active listings, take rate), the trend series, by-marketplace split, top categories, brands and items, sell-through cohort, data health and insights.
                GetAnalyticOverviewResponse result = apiInstance.GetAnalyticOverview(range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz, stores);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticOverview: " + e.Message );
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
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 
 **stores** | **string**| Comma-separated store ids. | [optional] 

### Return type

**GetAnalyticOverviewResponse**

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

<a name="getanalyticperformance"></a>
# **GetAnalyticPerformance**
> GetAnalyticPerformanceResponse GetAnalyticPerformance (string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null, string status = null, string q = null, string sort = null, string dir = null, int? page = null, int? size = null, int? minDays = null)

Per-listing performance: channels, views, favorites, offers and conversations in the period, units sold, net sales and profit, margin, days to sell and a 0-100 health score, paged and sortable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticPerformanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 
            var status = "all";  // string | unsold = listed at least minDays with no completed sale. (optional) 
            var q = "q_example";  // string | Title, SKU or brand contains. (optional) 
            var sort = "lastActivity";  // string | Default lastActivity. (optional) 
            var dir = "asc";  // string | Default desc. (optional) 
            var page = 56;  // int? | 1-indexed page. Default 1. (optional) 
            var size = 25;  // int? | Rows per page. Default 50. (optional) 
            var minDays = 56;  // int? | Minimum days listed (for status=unsold). Default 0. (optional) 

            try
            {
                // Per-listing performance: channels, views, favorites, offers and conversations in the period, units sold, net sales and profit, margin, days to sell and a 0-100 health score, paged and sortable.
                GetAnalyticPerformanceResponse result = apiInstance.GetAnalyticPerformance(range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz, status, q, sort, dir, page, size, minDays);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticPerformance: " + e.Message );
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
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 
 **status** | **string**| unsold &#x3D; listed at least minDays with no completed sale. | [optional] 
 **q** | **string**| Title, SKU or brand contains. | [optional] 
 **sort** | **string**| Default lastActivity. | [optional] 
 **dir** | **string**| Default desc. | [optional] 
 **page** | **int?**| 1-indexed page. Default 1. | [optional] 
 **size** | **int?**| Rows per page. Default 50. | [optional] 
 **minDays** | **int?**| Minimum days listed (for status&#x3D;unsold). Default 0. | [optional] 

### Return type

**GetAnalyticPerformanceResponse**

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

<a name="getanalyticprogram"></a>
# **GetAnalyticProgram**
> GetAnalyticProgramResponse GetAnalyticProgram (string program, DateTime? from = null, DateTime? to = null, string by = null)

One program's report over a date range (default the last 30 days, at most 366): KPIs, a daily trend and a breakdown table. Money in integer cents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticProgramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var program = "wholesale";  // string | 
            var from = DateTime.Parse("2013-10-20");  // DateTime? | First UTC day (YYYY-MM-DD), inclusive. (optional) 
            var to = DateTime.Parse("2013-10-20");  // DateTime? | Last UTC day (YYYY-MM-DD), inclusive. Default today. (optional) 
            var by = "by_example";  // string | Breakdown dimension, when the program offers one (worlds: showroom, property, event). (optional) 

            try
            {
                // One program's report over a date range (default the last 30 days, at most 366): KPIs, a daily trend and a breakdown table. Money in integer cents.
                GetAnalyticProgramResponse result = apiInstance.GetAnalyticProgram(program, from, to, by);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticProgram: " + e.Message );
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
 **program** | **string**|  | 
 **from** | **DateTime?**| First UTC day (YYYY-MM-DD), inclusive. | [optional] 
 **to** | **DateTime?**| Last UTC day (YYYY-MM-DD), inclusive. Default today. | [optional] 
 **by** | **string**| Breakdown dimension, when the program offers one (worlds: showroom, property, event). | [optional] 

### Return type

**GetAnalyticProgramResponse**

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

<a name="getanalyticsegment"></a>
# **GetAnalyticSegment**
> GetAnalyticSegmentResponse GetAnalyticSegment (string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null, string dim = null, string sort = null, string dir = null, int? minN = null, string q = null)

Niches along one dimension: listed and active counts, units sold, cohort sell-through, median days to sell, net sales and profit, margin, ROI, ASP and discount from ask; rows under minN are flagged lowSample.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 
            var dim = "category";  // string | category = main category; subcategory = main > sub; brand; condition; size; source = where you acquired it; department; priceBand = ask in <$10, $10-25, $25-50, $50-100, $100-250, $250+; ageBand = days live at sale or now (<7, 7-30, 30-90, 90+). (optional) 
            var sort = "label";  // string | Default netSales. (optional) 
            var dir = "asc";  // string | Default desc. (optional) 
            var minN = 56;  // int? | Minimum sample for a row to count as a winner or loser. Default 3. (optional) 
            var q = "q_example";  // string | Segment label contains. (optional) 

            try
            {
                // Niches along one dimension: listed and active counts, units sold, cohort sell-through, median days to sell, net sales and profit, margin, ROI, ASP and discount from ask; rows under minN are flagged lowSample.
                GetAnalyticSegmentResponse result = apiInstance.GetAnalyticSegment(range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz, dim, sort, dir, minN, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticSegment: " + e.Message );
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
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 
 **dim** | **string**| category &#x3D; main category; subcategory &#x3D; main &gt; sub; brand; condition; size; source &#x3D; where you acquired it; department; priceBand &#x3D; ask in &lt;$10, $10-25, $25-50, $50-100, $100-250, $250+; ageBand &#x3D; days live at sale or now (&lt;7, 7-30, 30-90, 90+). | [optional] 
 **sort** | **string**| Default netSales. | [optional] 
 **dir** | **string**| Default desc. | [optional] 
 **minN** | **int?**| Minimum sample for a row to count as a winner or loser. Default 3. | [optional] 
 **q** | **string**| Segment label contains. | [optional] 

### Return type

**GetAnalyticSegmentResponse**

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

<a name="getanalyticsegmentbykey"></a>
# **GetAnalyticSegmentByKey**
> GetAnalyticSegmentByKeyResponse GetAnalyticSegmentByKey (string dim, string key, string range = null, string from = null, string to = null, string compare = null, string cmpFrom = null, string cmpTo = null, string labels = null, string platforms = null, string category = null, string brand = null, string tz = null)

One niche in depth: its row, series, by-marketplace split, days-to-sell histogram, price bands, top items and the 10 oldest unsold listings in it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticSegmentByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var dim = "dim_example";  // string | One of category, subcategory, brand, condition, size, source, department, priceBand, ageBand. category = main category; subcategory = main > sub; brand; condition; size; source = where you acquired it; department; priceBand = ask in <$10, $10-25, $25-50, $50-100, $100-250, $250+; ageBand = days live at sale or now (<7, 7-30, 30-90, 90+).
            var key = "key_example";  // string | The segment key from a segments row (URL-encoded). A key with no data in scope is a 404.
            var range = "7d";  // string | Reporting window. Default 30d. custom needs from and to. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive, in tz. Only with range=custom. (optional) 
            var compare = "prev";  // string | Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). (optional) 
            var cmpFrom = "cmpFrom_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var cmpTo = "cmpTo_example";  // string | YYYY-MM-DD. Only with compare=custom. (optional) 
            var labels = "labels_example";  // string | Comma-separated inventory labels (any of them). (optional) 
            var platforms = "platforms_example";  // string | Comma-separated platform ids. (optional) 
            var category = "category_example";  // string | Canonical main-category key. (optional) 
            var brand = "brand_example";  // string | Brand name. (optional) 
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. An invalid name is a 400. (optional) 

            try
            {
                // One niche in depth: its row, series, by-marketplace split, days-to-sell histogram, price bands, top items and the 10 oldest unsold listings in it.
                GetAnalyticSegmentByKeyResponse result = apiInstance.GetAnalyticSegmentByKey(dim, key, range, from, to, compare, cmpFrom, cmpTo, labels, platforms, category, brand, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticSegmentByKey: " + e.Message );
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
 **dim** | **string**| One of category, subcategory, brand, condition, size, source, department, priceBand, ageBand. category &#x3D; main category; subcategory &#x3D; main &gt; sub; brand; condition; size; source &#x3D; where you acquired it; department; priceBand &#x3D; ask in &lt;$10, $10-25, $25-50, $50-100, $100-250, $250+; ageBand &#x3D; days live at sale or now (&lt;7, 7-30, 30-90, 90+). | 
 **key** | **string**| The segment key from a segments row (URL-encoded). A key with no data in scope is a 404. | 
 **range** | **string**| Reporting window. Default 30d. custom needs from and to. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive, in tz. Only with range&#x3D;custom. | [optional] 
 **compare** | **string**| Comparison window for deltas: prev (same length just before), yoy, none, custom (cmpFrom/cmpTo). | [optional] 
 **cmpFrom** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **cmpTo** | **string**| YYYY-MM-DD. Only with compare&#x3D;custom. | [optional] 
 **labels** | **string**| Comma-separated inventory labels (any of them). | [optional] 
 **platforms** | **string**| Comma-separated platform ids. | [optional] 
 **category** | **string**| Canonical main-category key. | [optional] 
 **brand** | **string**| Brand name. | [optional] 
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. An invalid name is a 400. | [optional] 

### Return type

**GetAnalyticSegmentByKeyResponse**

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

<a name="getanalyticsummary"></a>
# **GetAnalyticSummary**
> GetAnalyticSummaryResponse GetAnalyticSummary (int? days = null, string tz = null)

Headline KPIs for the last N days (the same numbers as the analytics overview).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var days = 30;  // int? | Calendar days back, today included. Larger values are clamped to 365. (optional)  (default to 30)
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. (optional) 

            try
            {
                // Headline KPIs for the last N days (the same numbers as the analytics overview).
                GetAnalyticSummaryResponse result = apiInstance.GetAnalyticSummary(days, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticSummary: " + e.Message );
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
 **days** | **int?**| Calendar days back, today included. Larger values are clamped to 365. | [optional] [default to 30]
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. | [optional] 

### Return type

**GetAnalyticSummaryResponse**

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

<a name="getanalytictimesery"></a>
# **GetAnalyticTimesery**
> GetAnalyticTimeseryResponse GetAnalyticTimesery (int? days = null, string tz = null)

Sales and net sales over the last N days, zero-filled, one row per calendar day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticTimeseryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var days = 30;  // int? | Calendar days back, today included. Larger values are clamped to 365. (optional)  (default to 30)
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. (optional) 

            try
            {
                // Sales and net sales over the last N days, zero-filled, one row per calendar day.
                GetAnalyticTimeseryResponse result = apiInstance.GetAnalyticTimesery(days, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticTimesery: " + e.Message );
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
 **days** | **int?**| Calendar days back, today included. Larger values are clamped to 365. | [optional] [default to 30]
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. | [optional] 

### Return type

**GetAnalyticTimeseryResponse**

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

<a name="getanalytictoday"></a>
# **GetAnalyticToday**
> GetAnalyticTodayResponse GetAnalyticToday ()

Today's checklist + 14-day activity streak.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAnalyticTodayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);

            try
            {
                // Today's checklist + 14-day activity streak.
                GetAnalyticTodayResponse result = apiInstance.GetAnalyticToday();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticToday: " + e.Message );
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

**GetAnalyticTodayResponse**

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

<a name="listinsightbyplatform"></a>
# **ListInsightByPlatform**
> ListInsightByPlatformResponse ListInsightByPlatform (string tz = null)

Platform velocity + margin insight (90-day window): units, net sales, median days to sell, ASP and net after the real marketplace fees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListInsightByPlatformExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var tz = "tz_example";  // string | IANA time zone for day boundaries. Default UTC. (optional) 

            try
            {
                // Platform velocity + margin insight (90-day window): units, net sales, median days to sell, ASP and net after the real marketplace fees.
                ListInsightByPlatformResponse result = apiInstance.ListInsightByPlatform(tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.ListInsightByPlatform: " + e.Message );
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
 **tz** | **string**| IANA time zone for day boundaries. Default UTC. | [optional] 

### Return type

**ListInsightByPlatformResponse**

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

<a name="updateanalyticexperiment"></a>
# **UpdateAnalyticExperiment**
> AnalyticExperimentResponse UpdateAnalyticExperiment (string id)

Rename an experiment or change its hypothesis, notes or planned end.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAnalyticExperimentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var id = "id_example";  // string | The experiment id (a uuid; any other id is a 404).

            try
            {
                // Rename an experiment or change its hypothesis, notes or planned end.
                AnalyticExperimentResponse result = apiInstance.UpdateAnalyticExperiment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.UpdateAnalyticExperiment: " + e.Message );
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
 **id** | **string**| The experiment id (a uuid; any other id is a 404). | 

### Return type

**AnalyticExperimentResponse**

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

