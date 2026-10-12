# net.crossly.Api.GradingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGradingDirect**](GradingApi.md#creategradingdirect) | **POST** /v1/grading/direct | Track a card you sent on your own grader account (Direct). Crossly takes no money; it verifies the cert when it comes back.
[**CreateGradingRunReserve**](GradingApi.md#creategradingrunreserve) | **POST** /v1/grading/runs/{id}/reserve | Hold a slot in a Grading Run. Free now; charged on your saved card only if the run locks. Full-access token and Idempotency-Key required.
[**CreateGradingSubmissionCancel**](GradingApi.md#creategradingsubmissioncancel) | **POST** /v1/grading/submissions/{id}/cancel | Pull a reserved card out of its run. Only while it is reserved; nothing was charged.
[**CreateGradingSubmissionResult**](GradingApi.md#creategradingsubmissionresult) | **POST** /v1/grading/submissions/{id}/result | Direct only: enter the grade that came back. Writes it to the item and its listings, verified when the cert agrees.
[**CreateGradingSubmissionShipped**](GradingApi.md#creategradingsubmissionshipped) | **POST** /v1/grading/submissions/{id}/shipped | Say you mailed a charged card to the hub, with optional tracking.
[**CreateGradingVerifyCert**](GradingApi.md#creategradingverifycert) | **POST** /v1/grading/verify-cert | Look a cert number up with its grader. found&#x3D;false when the grader has no record.
[**GetGradingWorth**](GradingApi.md#getgradingworth) | **GET** /v1/grading/worth/{inventoryItemId} | Worth grading? Raw value vs what each grade is worth at each grader, against the cost. Never predicts the grade.
[**ListGradingRateCard**](GradingApi.md#listgradingratecard) | **GET** /v1/grading/rate-card | Every grader and tier Crossly can send to, with the per-card price in cents (null &#x3D; paused at the grader).
[**ListGradingRuns**](GradingApi.md#listgradingruns) | **GET** /v1/grading/runs | Grading Runs taking reservations now, soonest cutoff first. meta.open is false while runs are switched off.
[**ListGradingSubmissions**](GradingApi.md#listgradingsubmissions) | **GET** /v1/grading/submissions | Your cards out for grading (runs and Direct), newest first. active&#x3D;1 keeps only the ones still in flight.


<a name="creategradingdirect"></a>
# **CreateGradingDirect**
> IdResponse CreateGradingDirect ()

Track a card you sent on your own grader account (Direct). Crossly takes no money; it verifies the cert when it comes back.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingDirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);

            try
            {
                // Track a card you sent on your own grader account (Direct). Crossly takes no money; it verifies the cert when it comes back.
                IdResponse result = apiInstance.CreateGradingDirect();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingDirect: " + e.Message );
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

**IdResponse**

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

<a name="creategradingrunreserve"></a>
# **CreateGradingRunReserve**
> IdResponse CreateGradingRunReserve (string id)

Hold a slot in a Grading Run. Free now; charged on your saved card only if the run locks. Full-access token and Idempotency-Key required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingRunReserveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Hold a slot in a Grading Run. Free now; charged on your saved card only if the run locks. Full-access token and Idempotency-Key required.
                IdResponse result = apiInstance.CreateGradingRunReserve(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingRunReserve: " + e.Message );
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

**IdResponse**

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

<a name="creategradingsubmissioncancel"></a>
# **CreateGradingSubmissionCancel**
> OkResponse CreateGradingSubmissionCancel (string id)

Pull a reserved card out of its run. Only while it is reserved; nothing was charged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingSubmissionCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pull a reserved card out of its run. Only while it is reserved; nothing was charged.
                OkResponse result = apiInstance.CreateGradingSubmissionCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingSubmissionCancel: " + e.Message );
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

<a name="creategradingsubmissionresult"></a>
# **CreateGradingSubmissionResult**
> CreateGradingSubmissionResultResponse CreateGradingSubmissionResult (string id)

Direct only: enter the grade that came back. Writes it to the item and its listings, verified when the cert agrees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingSubmissionResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Direct only: enter the grade that came back. Writes it to the item and its listings, verified when the cert agrees.
                CreateGradingSubmissionResultResponse result = apiInstance.CreateGradingSubmissionResult(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingSubmissionResult: " + e.Message );
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

**CreateGradingSubmissionResultResponse**

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

<a name="creategradingsubmissionshipped"></a>
# **CreateGradingSubmissionShipped**
> OkResponse CreateGradingSubmissionShipped (string id)

Say you mailed a charged card to the hub, with optional tracking.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingSubmissionShippedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Say you mailed a charged card to the hub, with optional tracking.
                OkResponse result = apiInstance.CreateGradingSubmissionShipped(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingSubmissionShipped: " + e.Message );
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

<a name="creategradingverifycert"></a>
# **CreateGradingVerifyCert**
> CreateGradingVerifyCertResponse CreateGradingVerifyCert ()

Look a cert number up with its grader. found=false when the grader has no record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGradingVerifyCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);

            try
            {
                // Look a cert number up with its grader. found=false when the grader has no record.
                CreateGradingVerifyCertResponse result = apiInstance.CreateGradingVerifyCert();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateGradingVerifyCert: " + e.Message );
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

**CreateGradingVerifyCertResponse**

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

<a name="getgradingworth"></a>
# **GetGradingWorth**
> GetGradingWorthResponse GetGradingWorth (string inventoryItemId)

Worth grading? Raw value vs what each grade is worth at each grader, against the cost. Never predicts the grade.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGradingWorthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Worth grading? Raw value vs what each grade is worth at each grader, against the cost. Never predicts the grade.
                GetGradingWorthResponse result = apiInstance.GetGradingWorth(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.GetGradingWorth: " + e.Message );
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
 **inventoryItemId** | **string**|  | 

### Return type

**GetGradingWorthResponse**

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

<a name="listgradingratecard"></a>
# **ListGradingRateCard**
> ListGradingRateCardResponse ListGradingRateCard ()

Every grader and tier Crossly can send to, with the per-card price in cents (null = paused at the grader).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGradingRateCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);

            try
            {
                // Every grader and tier Crossly can send to, with the per-card price in cents (null = paused at the grader).
                ListGradingRateCardResponse result = apiInstance.ListGradingRateCard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.ListGradingRateCard: " + e.Message );
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

**ListGradingRateCardResponse**

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

<a name="listgradingruns"></a>
# **ListGradingRuns**
> ListGradingRunsResponse ListGradingRuns ()

Grading Runs taking reservations now, soonest cutoff first. meta.open is false while runs are switched off.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGradingRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);

            try
            {
                // Grading Runs taking reservations now, soonest cutoff first. meta.open is false while runs are switched off.
                ListGradingRunsResponse result = apiInstance.ListGradingRuns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.ListGradingRuns: " + e.Message );
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

**ListGradingRunsResponse**

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

<a name="listgradingsubmissions"></a>
# **ListGradingSubmissions**
> ListGradingSubmissionsResponse ListGradingSubmissions (string active = null)

Your cards out for grading (runs and Direct), newest first. active=1 keeps only the ones still in flight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListGradingSubmissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var active = "0";  // string | Only cards that have not finished. (optional) 

            try
            {
                // Your cards out for grading (runs and Direct), newest first. active=1 keeps only the ones still in flight.
                ListGradingSubmissionsResponse result = apiInstance.ListGradingSubmissions(active);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.ListGradingSubmissions: " + e.Message );
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
 **active** | **string**| Only cards that have not finished. | [optional] 

### Return type

**ListGradingSubmissionsResponse**

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

