# net.crossly.Api.GradingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGradingRunReserve**](GradingApi.md#creategradingrunreserve) | **POST** /v1/grading/runs/{id}/reserve | Hold a slot in a Grading Run. Free now; charged on your saved card only if the run locks. Full-access token and Idempotency-Key required.
[**CreateGradingSubmissionCancel**](GradingApi.md#creategradingsubmissioncancel) | **POST** /v1/grading/submissions/{id}/cancel | Pull a reserved card out of its run. Only while it is reserved; nothing was charged.
[**CreateGradingSubmissionShipped**](GradingApi.md#creategradingsubmissionshipped) | **POST** /v1/grading/submissions/{id}/shipped | Say you mailed a charged card to the hub, with optional tracking.
[**CreateGradingVerifyCert**](GradingApi.md#creategradingverifycert) | **POST** /v1/grading/verify-cert | Look a cert number up with its grader. found&#x3D;false when the grader has no record.
[**CreateVaultMarketGradingOrder**](GradingApi.md#createvaultmarketgradingorder) | **POST** /v1/vault-markets/grading/orders | Start a grading submission: cards (vault units or inventory items) to one grader at one service. Priced from the price book; vault units are held. Nothing is charged until you pay.
[**CreateVaultMarketGradingOrderCancel**](GradingApi.md#createvaultmarketgradingordercancel) | **POST** /v1/vault-markets/grading/orders/{id}/cancel | Cancel a draft submission; its vault units go back on their shelf. A paid submission cannot be cancelled here.
[**CreateVaultMarketGradingOrderPay**](GradingApi.md#createvaultmarketgradingorderpay) | **POST** /v1/vault-markets/grading/orders/{id}/pay | Pay for a draft submission. savedCard: true charges your saved card (paid, or requires_action with a client secret for 3-D Secure). Full-access token and Idempotency-Key required.
[**CreateVaultMarketGradingOrderPayConfirm**](GradingApi.md#createvaultmarketgradingorderpayconfirm) | **POST** /v1/vault-markets/grading/orders/{id}/pay/confirm | After a 3-D Secure step or a card form: confirm the PaymentIntent with Stripe and mark the submission paid.
[**GetGradingPriceBook**](GradingApi.md#getgradingpricebook) | **GET** /v1/grading/price-book | The grading price book: every grader, its services (per-card price, minimum cards, max declared value, turnaround) and add-ons, plus Crossly handling. The same data the dashboard prices from.
[**GetGradingSetting**](GradingApi.md#getgradingsetting) | **GET** /v1/grading/settings | Your grading defaults: defaultGrader (null &#x3D; ask each time), defaultMissMode (roll_over | release, if a run does not fill), defaultReturnMode (always vault: every graded card goes into your vault) and defaultPrescreen.
[**GetGradingWorth**](GradingApi.md#getgradingworth) | **GET** /v1/grading/worth/{inventoryItemId} | Worth grading? Raw value vs what each grade is worth at each grader, against the cost. Never predicts the grade.
[**GetVaultMarketGradingOrder**](GradingApi.md#getvaultmarketgradingorder) | **GET** /v1/vault-markets/grading/orders/{id} | One grading submission: its timeline, every card with its grade, cert number and photos, the costs and the tracking.
[**ListGradingRateCard**](GradingApi.md#listgradingratecard) | **GET** /v1/grading/rate-card | Every grader and tier Crossly can send to, with the per-card price in cents (null &#x3D; paused at the grader).
[**ListGradingRuns**](GradingApi.md#listgradingruns) | **GET** /v1/grading/runs | Grading Runs taking reservations now, soonest cutoff first. meta.open is false while runs are switched off.
[**ListGradingSubmissions**](GradingApi.md#listgradingsubmissions) | **GET** /v1/grading/submissions | Your cards out for grading (runs and Direct), newest first. active&#x3D;1 keeps only the ones still in flight.
[**ListVaultMarketGradingCandidates**](GradingApi.md#listvaultmarketgradingcandidates) | **GET** /v1/vault-markets/grading/candidates | What you can send to grading: raw units already in your vault and inventory items, each with a declared value to start from and the reason when one cannot go.
[**ListVaultMarketGradingOrders**](GradingApi.md#listvaultmarketgradingorders) | **GET** /v1/vault-markets/grading/orders | Your grading submissions, newest first. Filter by status, active, grader, tier and dates; q searches the number, card names and cert numbers.
[**UpdateGradingSetting**](GradingApi.md#updategradingsetting) | **PUT** /v1/grading/settings | Change your grading defaults (any of defaultGrader, defaultMissMode, defaultPrescreen; defaultReturnMode is always vault, and an old \&quot;return\&quot; is saved as vault). Logged to Activity. Returns the saved defaults.


<a name="creategradingrunreserve"></a>
# **CreateGradingRunReserve**
> IdResponse CreateGradingRunReserve (string id, CreateGradingRunReserveRequest createGradingRunReserveRequest = null)

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
            var createGradingRunReserveRequest = new CreateGradingRunReserveRequest(); // CreateGradingRunReserveRequest |  (optional) 

            try
            {
                // Hold a slot in a Grading Run. Free now; charged on your saved card only if the run locks. Full-access token and Idempotency-Key required.
                IdResponse result = apiInstance.CreateGradingRunReserve(id, createGradingRunReserveRequest);
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
 **createGradingRunReserveRequest** | **CreateGradingRunReserveRequest**|  | [optional] 

### Return type

**IdResponse**

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

<a name="creategradingsubmissionshipped"></a>
# **CreateGradingSubmissionShipped**
> OkResponse CreateGradingSubmissionShipped (string id, CreateGradingSubmissionShippedRequest createGradingSubmissionShippedRequest = null)

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
            var createGradingSubmissionShippedRequest = new CreateGradingSubmissionShippedRequest(); // CreateGradingSubmissionShippedRequest |  (optional) 

            try
            {
                // Say you mailed a charged card to the hub, with optional tracking.
                OkResponse result = apiInstance.CreateGradingSubmissionShipped(id, createGradingSubmissionShippedRequest);
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
 **createGradingSubmissionShippedRequest** | **CreateGradingSubmissionShippedRequest**|  | [optional] 

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

<a name="creategradingverifycert"></a>
# **CreateGradingVerifyCert**
> CreateGradingVerifyCertResponse CreateGradingVerifyCert (CreateGradingVerifyCertRequest createGradingVerifyCertRequest = null)

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
            var createGradingVerifyCertRequest = new CreateGradingVerifyCertRequest(); // CreateGradingVerifyCertRequest |  (optional) 

            try
            {
                // Look a cert number up with its grader. found=false when the grader has no record.
                CreateGradingVerifyCertResponse result = apiInstance.CreateGradingVerifyCert(createGradingVerifyCertRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createGradingVerifyCertRequest** | **CreateGradingVerifyCertRequest**|  | [optional] 

### Return type

**CreateGradingVerifyCertResponse**

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

<a name="createvaultmarketgradingorder"></a>
# **CreateVaultMarketGradingOrder**
> CreateVaultMarketGradingOrderResponse CreateVaultMarketGradingOrder (CreateVaultMarketGradingOrderRequest createVaultMarketGradingOrderRequest = null)

Start a grading submission: cards (vault units or inventory items) to one grader at one service. Priced from the price book; vault units are held. Nothing is charged until you pay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVaultMarketGradingOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var createVaultMarketGradingOrderRequest = new CreateVaultMarketGradingOrderRequest(); // CreateVaultMarketGradingOrderRequest |  (optional) 

            try
            {
                // Start a grading submission: cards (vault units or inventory items) to one grader at one service. Priced from the price book; vault units are held. Nothing is charged until you pay.
                CreateVaultMarketGradingOrderResponse result = apiInstance.CreateVaultMarketGradingOrder(createVaultMarketGradingOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateVaultMarketGradingOrder: " + e.Message );
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
 **createVaultMarketGradingOrderRequest** | **CreateVaultMarketGradingOrderRequest**|  | [optional] 

### Return type

**CreateVaultMarketGradingOrderResponse**

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

<a name="createvaultmarketgradingordercancel"></a>
# **CreateVaultMarketGradingOrderCancel**
> StatusResponse CreateVaultMarketGradingOrderCancel (string id)

Cancel a draft submission; its vault units go back on their shelf. A paid submission cannot be cancelled here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVaultMarketGradingOrderCancelExample
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
                // Cancel a draft submission; its vault units go back on their shelf. A paid submission cannot be cancelled here.
                StatusResponse result = apiInstance.CreateVaultMarketGradingOrderCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateVaultMarketGradingOrderCancel: " + e.Message );
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

**StatusResponse**

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

<a name="createvaultmarketgradingorderpay"></a>
# **CreateVaultMarketGradingOrderPay**
> CreateVaultMarketGradingOrderPayResponse CreateVaultMarketGradingOrderPay (string id, CreateVaultMarketGradingOrderPayRequest createVaultMarketGradingOrderPayRequest = null)

Pay for a draft submission. savedCard: true charges your saved card (paid, or requires_action with a client secret for 3-D Secure). Full-access token and Idempotency-Key required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVaultMarketGradingOrderPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 
            var createVaultMarketGradingOrderPayRequest = new CreateVaultMarketGradingOrderPayRequest(); // CreateVaultMarketGradingOrderPayRequest |  (optional) 

            try
            {
                // Pay for a draft submission. savedCard: true charges your saved card (paid, or requires_action with a client secret for 3-D Secure). Full-access token and Idempotency-Key required.
                CreateVaultMarketGradingOrderPayResponse result = apiInstance.CreateVaultMarketGradingOrderPay(id, createVaultMarketGradingOrderPayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateVaultMarketGradingOrderPay: " + e.Message );
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
 **createVaultMarketGradingOrderPayRequest** | **CreateVaultMarketGradingOrderPayRequest**|  | [optional] 

### Return type

**CreateVaultMarketGradingOrderPayResponse**

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

<a name="createvaultmarketgradingorderpayconfirm"></a>
# **CreateVaultMarketGradingOrderPayConfirm**
> StatusResponse CreateVaultMarketGradingOrderPayConfirm (string id, CreateVaultMarketGradingOrderPayConfirmRequest createVaultMarketGradingOrderPayConfirmRequest = null)

After a 3-D Secure step or a card form: confirm the PaymentIntent with Stripe and mark the submission paid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateVaultMarketGradingOrderPayConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var id = "id_example";  // string | 
            var createVaultMarketGradingOrderPayConfirmRequest = new CreateVaultMarketGradingOrderPayConfirmRequest(); // CreateVaultMarketGradingOrderPayConfirmRequest |  (optional) 

            try
            {
                // After a 3-D Secure step or a card form: confirm the PaymentIntent with Stripe and mark the submission paid.
                StatusResponse result = apiInstance.CreateVaultMarketGradingOrderPayConfirm(id, createVaultMarketGradingOrderPayConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.CreateVaultMarketGradingOrderPayConfirm: " + e.Message );
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
 **createVaultMarketGradingOrderPayConfirmRequest** | **CreateVaultMarketGradingOrderPayConfirmRequest**|  | [optional] 

### Return type

**StatusResponse**

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

<a name="getgradingpricebook"></a>
# **GetGradingPriceBook**
> GetGradingPriceBookResponse GetGradingPriceBook ()

The grading price book: every grader, its services (per-card price, minimum cards, max declared value, turnaround) and add-ons, plus Crossly handling. The same data the dashboard prices from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGradingPriceBookExample
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
                // The grading price book: every grader, its services (per-card price, minimum cards, max declared value, turnaround) and add-ons, plus Crossly handling. The same data the dashboard prices from.
                GetGradingPriceBookResponse result = apiInstance.GetGradingPriceBook();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.GetGradingPriceBook: " + e.Message );
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

**GetGradingPriceBookResponse**

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

<a name="getgradingsetting"></a>
# **GetGradingSetting**
> GetGradingSettingResponse GetGradingSetting ()

Your grading defaults: defaultGrader (null = ask each time), defaultMissMode (roll_over | release, if a run does not fill), defaultReturnMode (always vault: every graded card goes into your vault) and defaultPrescreen.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetGradingSettingExample
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
                // Your grading defaults: defaultGrader (null = ask each time), defaultMissMode (roll_over | release, if a run does not fill), defaultReturnMode (always vault: every graded card goes into your vault) and defaultPrescreen.
                GetGradingSettingResponse result = apiInstance.GetGradingSetting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.GetGradingSetting: " + e.Message );
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

**GetGradingSettingResponse**

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

<a name="getvaultmarketgradingorder"></a>
# **GetVaultMarketGradingOrder**
> GetVaultMarketGradingOrderResponse GetVaultMarketGradingOrder (string id)

One grading submission: its timeline, every card with its grade, cert number and photos, the costs and the tracking.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetVaultMarketGradingOrderExample
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
                // One grading submission: its timeline, every card with its grade, cert number and photos, the costs and the tracking.
                GetVaultMarketGradingOrderResponse result = apiInstance.GetVaultMarketGradingOrder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.GetVaultMarketGradingOrder: " + e.Message );
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

**GetVaultMarketGradingOrderResponse**

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

<a name="listvaultmarketgradingcandidates"></a>
# **ListVaultMarketGradingCandidates**
> ListVaultMarketGradingCandidatesResponse ListVaultMarketGradingCandidates (string q = null)

What you can send to grading: raw units already in your vault and inventory items, each with a declared value to start from and the reason when one cannot go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListVaultMarketGradingCandidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var q = "q_example";  // string |  (optional) 

            try
            {
                // What you can send to grading: raw units already in your vault and inventory items, each with a declared value to start from and the reason when one cannot go.
                ListVaultMarketGradingCandidatesResponse result = apiInstance.ListVaultMarketGradingCandidates(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.ListVaultMarketGradingCandidates: " + e.Message );
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

**ListVaultMarketGradingCandidatesResponse**

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

<a name="listvaultmarketgradingorders"></a>
# **ListVaultMarketGradingOrders**
> ListVaultMarketGradingOrdersResponse ListVaultMarketGradingOrders (string status = null, string active = null, string grader = null, string tier = null, string q = null, string from = null, string to = null, decimal? limit = null, decimal? offset = null)

Your grading submissions, newest first. Filter by status, active, grader, tier and dates; q searches the number, card names and cert numbers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListVaultMarketGradingOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var status = "draft";  // string |  (optional) 
            var active = "0";  // string |  (optional) 
            var grader = "grader_example";  // string |  (optional) 
            var tier = "tier_example";  // string |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var from = "from_example";  // string |  (optional) 
            var to = "to_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var offset = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Your grading submissions, newest first. Filter by status, active, grader, tier and dates; q searches the number, card names and cert numbers.
                ListVaultMarketGradingOrdersResponse result = apiInstance.ListVaultMarketGradingOrders(status, active, grader, tier, q, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.ListVaultMarketGradingOrders: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **active** | **string**|  | [optional] 
 **grader** | **string**|  | [optional] 
 **tier** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **offset** | **decimal?**|  | [optional] 

### Return type

**ListVaultMarketGradingOrdersResponse**

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

<a name="updategradingsetting"></a>
# **UpdateGradingSetting**
> GetGradingSettingResponse UpdateGradingSetting (UpdateGradingSettingRequest updateGradingSettingRequest = null)

Change your grading defaults (any of defaultGrader, defaultMissMode, defaultPrescreen; defaultReturnMode is always vault, and an old \"return\" is saved as vault). Logged to Activity. Returns the saved defaults.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateGradingSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GradingApi(config);
            var updateGradingSettingRequest = new UpdateGradingSettingRequest(); // UpdateGradingSettingRequest |  (optional) 

            try
            {
                // Change your grading defaults (any of defaultGrader, defaultMissMode, defaultPrescreen; defaultReturnMode is always vault, and an old \"return\" is saved as vault). Logged to Activity. Returns the saved defaults.
                GetGradingSettingResponse result = apiInstance.UpdateGradingSetting(updateGradingSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GradingApi.UpdateGradingSetting: " + e.Message );
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
 **updateGradingSettingRequest** | **UpdateGradingSettingRequest**|  | [optional] 

### Return type

**GetGradingSettingResponse**

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

