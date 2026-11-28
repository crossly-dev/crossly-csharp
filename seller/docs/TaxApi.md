# net.crossly.Api.TaxApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMileage**](TaxApi.md#createmileage) | **POST** /v1/mileage | Create a mileage entry.
[**DeleteMileage**](TaxApi.md#deletemileage) | **DELETE** /v1/mileage/{id} | Delete a mileage entry.
[**GetMileageSummary**](TaxApi.md#getmileagesummary) | **GET** /v1/mileage/summary | Annual mileage totals + IRS deduction. Each trip is priced at the IRS rate on its own date (2026 has two rates, listed in &#x60;rates&#x60;); &#x60;ratePerMile&#x60; is the January rate.
[**GetTaxSalesTax**](TaxApi.md#gettaxsalestax) | **GET** /v1/tax/sales-tax | Crossly marketplace sales Crossly did not collect sales tax on, by jurisdiction.
[**GetTaxScheduleC**](TaxApi.md#gettaxschedulec) | **GET** /v1/tax/schedule-c | Schedule C JSON for a tax year (default the current year), from the same P&amp;L as GET /v1/books: line 1 gross receipts before refunds, line 2 refunds, COGS in Part III, completed sales only. GET /v1/books has the full P&amp;L by period.
[**ListMileage**](TaxApi.md#listmileage) | **GET** /v1/mileage | List mileage entries, newest trip first, paged (limit up to 500). Narrow by year and/or an inclusive from/to date range.
[**ListTaxCrosslyCollects**](TaxApi.md#listtaxcrosslycollects) | **GET** /v1/tax/crossly-collects | Where Crossly collects sales tax today (its active Stripe Tax registrations).
[**ListTaxSalesTaxNotCollected**](TaxApi.md#listtaxsalestaxnotcollected) | **GET** /v1/tax/sales-tax/not-collected | The individual Crossly sales Crossly did not collect sales tax on, newest first.
[**UpdateMileage**](TaxApi.md#updatemileage) | **PATCH** /v1/mileage/{id} | Update a mileage entry.


<a name="createmileage"></a>
# **CreateMileage**
> CreateMileageResponse CreateMileage (CreateMileageRequest createMileageRequest)

Create a mileage entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateMileageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var createMileageRequest = new CreateMileageRequest(); // CreateMileageRequest | 

            try
            {
                // Create a mileage entry.
                CreateMileageResponse result = apiInstance.CreateMileage(createMileageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.CreateMileage: " + e.Message );
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
 **createMileageRequest** | **CreateMileageRequest**|  | 

### Return type

**CreateMileageResponse**

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

<a name="deletemileage"></a>
# **DeleteMileage**
> OkResponse DeleteMileage (Guid id)

Delete a mileage entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteMileageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a mileage entry.
                OkResponse result = apiInstance.DeleteMileage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.DeleteMileage: " + e.Message );
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

<a name="getmileagesummary"></a>
# **GetMileageSummary**
> GetMileageSummaryResponse GetMileageSummary (int? year = null)

Annual mileage totals + IRS deduction. Each trip is priced at the IRS rate on its own date (2026 has two rates, listed in `rates`); `ratePerMile` is the January rate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetMileageSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var year = 56;  // int? | Calendar tax year. Default the current year. (optional) 

            try
            {
                // Annual mileage totals + IRS deduction. Each trip is priced at the IRS rate on its own date (2026 has two rates, listed in `rates`); `ratePerMile` is the January rate.
                GetMileageSummaryResponse result = apiInstance.GetMileageSummary(year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.GetMileageSummary: " + e.Message );
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
 **year** | **int?**| Calendar tax year. Default the current year. | [optional] 

### Return type

**GetMileageSummaryResponse**

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

<a name="gettaxsalestax"></a>
# **GetTaxSalesTax**
> GetTaxSalesTaxResponse GetTaxSalesTax (string from = null, string to = null)

Crossly marketplace sales Crossly did not collect sales tax on, by jurisdiction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxSalesTaxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var from = "from_example";  // string | YYYY-MM-DD, inclusive. Default 1 January this year. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive. Default now. (optional) 

            try
            {
                // Crossly marketplace sales Crossly did not collect sales tax on, by jurisdiction.
                GetTaxSalesTaxResponse result = apiInstance.GetTaxSalesTax(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.GetTaxSalesTax: " + e.Message );
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
 **from** | **string**| YYYY-MM-DD, inclusive. Default 1 January this year. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive. Default now. | [optional] 

### Return type

**GetTaxSalesTaxResponse**

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

<a name="gettaxschedulec"></a>
# **GetTaxScheduleC**
> GetTaxScheduleCResponse GetTaxScheduleC (decimal? year = null)

Schedule C JSON for a tax year (default the current year), from the same P&L as GET /v1/books: line 1 gross receipts before refunds, line 2 refunds, COGS in Part III, completed sales only. GET /v1/books has the full P&L by period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetTaxScheduleCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var year = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Schedule C JSON for a tax year (default the current year), from the same P&L as GET /v1/books: line 1 gross receipts before refunds, line 2 refunds, COGS in Part III, completed sales only. GET /v1/books has the full P&L by period.
                GetTaxScheduleCResponse result = apiInstance.GetTaxScheduleC(year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.GetTaxScheduleC: " + e.Message );
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

**GetTaxScheduleCResponse**

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

<a name="listmileage"></a>
# **ListMileage**
> ListMileageResponse ListMileage (int? year = null, string from = null, string to = null, int? page = null, int? limit = null)

List mileage entries, newest trip first, paged (limit up to 500). Narrow by year and/or an inclusive from/to date range.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListMileageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var year = 56;  // int? | Only trips dated in this calendar year. (optional) 
            var from = "from_example";  // string | YYYY-MM-DD, inclusive. Only trips on or after this date. Combines with year. (optional) 
            var to = "to_example";  // string | YYYY-MM-DD, inclusive. Only trips on or before this date; from <= to. (optional) 
            var page = 56;  // int? | 1-indexed page. Default 1. (optional) 
            var limit = 56;  // int? | Rows per page, default 100, clamped to 500. (optional) 

            try
            {
                // List mileage entries, newest trip first, paged (limit up to 500). Narrow by year and/or an inclusive from/to date range.
                ListMileageResponse result = apiInstance.ListMileage(year, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.ListMileage: " + e.Message );
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
 **year** | **int?**| Only trips dated in this calendar year. | [optional] 
 **from** | **string**| YYYY-MM-DD, inclusive. Only trips on or after this date. Combines with year. | [optional] 
 **to** | **string**| YYYY-MM-DD, inclusive. Only trips on or before this date; from &lt;&#x3D; to. | [optional] 
 **page** | **int?**| 1-indexed page. Default 1. | [optional] 
 **limit** | **int?**| Rows per page, default 100, clamped to 500. | [optional] 

### Return type

**ListMileageResponse**

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

<a name="listtaxcrosslycollects"></a>
# **ListTaxCrosslyCollects**
> ListTaxCrosslyCollectsResponse ListTaxCrosslyCollects ()

Where Crossly collects sales tax today (its active Stripe Tax registrations).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTaxCrosslyCollectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);

            try
            {
                // Where Crossly collects sales tax today (its active Stripe Tax registrations).
                ListTaxCrosslyCollectsResponse result = apiInstance.ListTaxCrosslyCollects();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.ListTaxCrosslyCollects: " + e.Message );
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

**ListTaxCrosslyCollectsResponse**

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

<a name="listtaxsalestaxnotcollected"></a>
# **ListTaxSalesTaxNotCollected**
> ListTaxSalesTaxNotCollectedResponse ListTaxSalesTaxNotCollected (string from = null, string to = null, int? page = null, int? limit = null)

The individual Crossly sales Crossly did not collect sales tax on, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListTaxSalesTaxNotCollectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // The individual Crossly sales Crossly did not collect sales tax on, newest first.
                ListTaxSalesTaxNotCollectedResponse result = apiInstance.ListTaxSalesTaxNotCollected(from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.ListTaxSalesTaxNotCollected: " + e.Message );
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
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListTaxSalesTaxNotCollectedResponse**

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

<a name="updatemileage"></a>
# **UpdateMileage**
> CreateMileageResponse UpdateMileage (Guid id, UpdateMileageRequest updateMileageRequest)

Update a mileage entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateMileageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxApi(config);
            var id = "id_example";  // Guid | 
            var updateMileageRequest = new UpdateMileageRequest(); // UpdateMileageRequest | 

            try
            {
                // Update a mileage entry.
                CreateMileageResponse result = apiInstance.UpdateMileage(id, updateMileageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.UpdateMileage: " + e.Message );
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
 **updateMileageRequest** | **UpdateMileageRequest**|  | 

### Return type

**CreateMileageResponse**

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

