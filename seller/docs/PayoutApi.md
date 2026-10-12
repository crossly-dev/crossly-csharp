# net.crossly.Api.PayoutApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayoutConnectOnboard**](PayoutApi.md#createpayoutconnectonboard) | **POST** /v1/payout/connect/onboard | Start or resume payout-account onboarding; returns a Stripe-hosted URL.
[**GetPayoutConnect**](PayoutApi.md#getpayoutconnect) | **GET** /v1/payout/connect | Your Stripe payout account: status, country, agreement and payout currency.
[**GetPayoutEstimate**](PayoutApi.md#getpayoutestimate) | **GET** /v1/payout/estimate | What one platform nets at a given price, after fees and shipping.
[**GetPayoutGrossForNet**](PayoutApi.md#getpayoutgrossfornet) | **GET** /v1/payout/gross-for-net | The gross price needed to clear a target net on one platform.
[**ListPayoutCompare**](PayoutApi.md#listpayoutcompare) | **GET** /v1/payout/compare | Rank platforms by what they net at a given price. Defaults to connected ones.


<a name="createpayoutconnectonboard"></a>
# **CreatePayoutConnectOnboard**
> CreatePayoutConnectOnboardResponse CreatePayoutConnectOnboard (CreatePayoutConnectOnboardRequest createPayoutConnectOnboardRequest)

Start or resume payout-account onboarding; returns a Stripe-hosted URL.

country (ISO 3166-1 alpha-2) defaults to the storefront ship-from country, then US. Fixed once the account exists. Nothing is set up until a person completes the link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePayoutConnectOnboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayoutApi(config);
            var createPayoutConnectOnboardRequest = new CreatePayoutConnectOnboardRequest(); // CreatePayoutConnectOnboardRequest | 

            try
            {
                // Start or resume payout-account onboarding; returns a Stripe-hosted URL.
                CreatePayoutConnectOnboardResponse result = apiInstance.CreatePayoutConnectOnboard(createPayoutConnectOnboardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutApi.CreatePayoutConnectOnboard: " + e.Message );
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
 **createPayoutConnectOnboardRequest** | **CreatePayoutConnectOnboardRequest**|  | 

### Return type

**CreatePayoutConnectOnboardResponse**

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

<a name="getpayoutconnect"></a>
# **GetPayoutConnect**
> GetPayoutConnectResponse GetPayoutConnect ()

Your Stripe payout account: status, country, agreement and payout currency.

status is not_started (with defaultCountry), pending, active, restricted or payouts_unavailable. Only active can be paid; payouts_unavailable means Stripe offers no payout path to the account's country yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPayoutConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayoutApi(config);

            try
            {
                // Your Stripe payout account: status, country, agreement and payout currency.
                GetPayoutConnectResponse result = apiInstance.GetPayoutConnect();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutApi.GetPayoutConnect: " + e.Message );
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

**GetPayoutConnectResponse**

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

<a name="getpayoutestimate"></a>
# **GetPayoutEstimate**
> GetPayoutEstimateResponse GetPayoutEstimate ()

What one platform nets at a given price, after fees and shipping.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPayoutEstimateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayoutApi(config);

            try
            {
                // What one platform nets at a given price, after fees and shipping.
                GetPayoutEstimateResponse result = apiInstance.GetPayoutEstimate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutApi.GetPayoutEstimate: " + e.Message );
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

**GetPayoutEstimateResponse**

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

<a name="getpayoutgrossfornet"></a>
# **GetPayoutGrossForNet**
> GetPayoutGrossForNetResponse GetPayoutGrossForNet ()

The gross price needed to clear a target net on one platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPayoutGrossForNetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayoutApi(config);

            try
            {
                // The gross price needed to clear a target net on one platform.
                GetPayoutGrossForNetResponse result = apiInstance.GetPayoutGrossForNet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutApi.GetPayoutGrossForNet: " + e.Message );
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

**GetPayoutGrossForNetResponse**

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

<a name="listpayoutcompare"></a>
# **ListPayoutCompare**
> ListPayoutCompareResponse ListPayoutCompare ()

Rank platforms by what they net at a given price. Defaults to connected ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPayoutCompareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayoutApi(config);

            try
            {
                // Rank platforms by what they net at a given price. Defaults to connected ones.
                ListPayoutCompareResponse result = apiInstance.ListPayoutCompare();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutApi.ListPayoutCompare: " + e.Message );
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

**ListPayoutCompareResponse**

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

