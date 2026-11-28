# net.crossly.Api.BillingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBillingUpgrade**](BillingApi.md#createbillingupgrade) | **POST** /v1/billing/upgrade | Start an upgrade of a store&#39;s plan.
[**GetBillingUsage**](BillingApi.md#getbillingusage) | **GET** /v1/billing/usage | A store&#39;s plan and its usage against the plan&#39;s limits (used of limit, per metered limit).
[**ListBillingAppAllowances**](BillingApi.md#listbillingappallowances) | **GET** /v1/billing/app-allowances | Your listing allowances through OAuth apps (used of limit, per app, with its platform scope).
[**ListBillingInvoices**](BillingApi.md#listbillinginvoices) | **GET** /v1/billing/invoices | List a store&#39;s plan invoices, newest first, with search and filters.
[**ListBillingPlans**](BillingApi.md#listbillingplans) | **GET** /v1/billing/plans | List the plans with their prices, limits and features.


<a name="createbillingupgrade"></a>
# **CreateBillingUpgrade**
> CreateBillingUpgradeResponse CreateBillingUpgrade (CreateBillingUpgradeRequest createBillingUpgradeRequest)

Start an upgrade of a store's plan.

Returns a Stripe Checkout URL. Nothing is charged by this call — a person completes the payment. Downgrades and cancellation are not available to a token at all; they stay with the account owner. Every store has its own plan: the store is `X-Storefront-Id` (omitted: the default store). A store already on a plan answers 409 (change it in Billing); a store sharing a grandfathered plan can pass `separate: true` to take its own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBillingUpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillingApi(config);
            var createBillingUpgradeRequest = new CreateBillingUpgradeRequest(); // CreateBillingUpgradeRequest | 

            try
            {
                // Start an upgrade of a store's plan.
                CreateBillingUpgradeResponse result = apiInstance.CreateBillingUpgrade(createBillingUpgradeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.CreateBillingUpgrade: " + e.Message );
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
 **createBillingUpgradeRequest** | **CreateBillingUpgradeRequest**|  | 

### Return type

**CreateBillingUpgradeResponse**

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

<a name="getbillingusage"></a>
# **GetBillingUsage**
> GetBillingUsageResponse GetBillingUsage ()

A store's plan and its usage against the plan's limits (used of limit, per metered limit).

The store is `X-Storefront-Id` (omitted: the default store). `pooled` is true when one plan covers several stores and its limits are shared by them; `used` is then the sum across those stores. A null `limit` means no cap. `upgradeTier` is the cheapest plan that raises a limit; `resetsAt` is when a monthly count starts again (null for a standing count). A teammate's token needs a billing grant on that store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBillingUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillingApi(config);

            try
            {
                // A store's plan and its usage against the plan's limits (used of limit, per metered limit).
                GetBillingUsageResponse result = apiInstance.GetBillingUsage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingUsage: " + e.Message );
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

**GetBillingUsageResponse**

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

<a name="listbillingappallowances"></a>
# **ListBillingAppAllowances**
> ListBillingAppAllowancesResponse ListBillingAppAllowances ()

Your listing allowances through OAuth apps (used of limit, per app, with its platform scope).

Staff can let an OAuth app list above a seller's plan, counted apart from the plan's itemsPerMonth and only on the allowance's platforms. `label` is the sentence to show (12 of 10,000 managed by Infinity; ... this month via Infinity (resets Dec 1); or counts toward your plan for limitMode shared).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBillingAppAllowancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillingApi(config);

            try
            {
                // Your listing allowances through OAuth apps (used of limit, per app, with its platform scope).
                ListBillingAppAllowancesResponse result = apiInstance.ListBillingAppAllowances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.ListBillingAppAllowances: " + e.Message );
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

**ListBillingAppAllowancesResponse**

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

<a name="listbillinginvoices"></a>
# **ListBillingInvoices**
> ListBillingInvoicesResponse ListBillingInvoices (string cursor = null, string status = null, string from = null, string to = null, int? min = null, int? max = null, string q = null, int? limit = null)

List a store's plan invoices, newest first, with search and filters.

The store is `X-Storefront-Id` (omitted: the default store). Filters: `status`, `from`/`to` (YYYY-MM-DD, inclusive, UTC), `min`/`max` (amount in cents), `q` (part of the invoice number). Paged by `cursor`: pass `meta.nextCursor` of the previous page; null means the last page. Amounts are cents in `currency`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBillingInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillingApi(config);
            var cursor = "cursor_example";  // string |  (optional) 
            var status = "draft";  // string |  (optional) 
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 
            var min = 56;  // int? |  (optional) 
            var max = 56;  // int? |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // List a store's plan invoices, newest first, with search and filters.
                ListBillingInvoicesResponse result = apiInstance.ListBillingInvoices(cursor, status, from, to, min, max, q, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.ListBillingInvoices: " + e.Message );
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
 **cursor** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 
 **min** | **int?**|  | [optional] 
 **max** | **int?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListBillingInvoicesResponse**

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

<a name="listbillingplans"></a>
# **ListBillingPlans**
> ListBillingPlansResponse ListBillingPlans ()

List the plans with their prices, limits and features.

Prices are the Stripe Prices checkout charges (whole USD). A null limit means no cap.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBillingPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillingApi(config);

            try
            {
                // List the plans with their prices, limits and features.
                ListBillingPlansResponse result = apiInstance.ListBillingPlans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.ListBillingPlans: " + e.Message );
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

**ListBillingPlansResponse**

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

