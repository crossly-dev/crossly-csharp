# net.crossly.buyer.Api.BuyerCheckoutApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuyerCheckout**](BuyerCheckoutApi.md#createbuyercheckout) | **POST** /v1/buyer/checkout | Buy a listing without being present.
[**GetBuyerCheckoutControl**](BuyerCheckoutApi.md#getbuyercheckoutcontrol) | **GET** /v1/buyer/checkout/controls | What this key is allowed to spend.
[**UpdateBuyerCheckoutControl**](BuyerCheckoutApi.md#updatebuyercheckoutcontrol) | **PUT** /v1/buyer/checkout/controls | Switch this key on for spending, and set its limits.


<a name="createbuyercheckout"></a>
# **CreateBuyerCheckout**
> CreateBuyerCheckoutResponse CreateBuyerCheckout ()

Buy a listing without being present.

An Idempotency-Key header is REQUIRED — this endpoint refuses without one, because a retried request would otherwise buy the item twice and a retry is the most likely thing an automated buyer does. Derive the key from what you are buying and reuse it across retries; a fresh random value per attempt satisfies the check and keeps the bug. The item is QUOTED first and the delivered total is checked against both your maxTotalCents and this key's limits before anything is charged. A card that demands 3-D Secure cannot be charged unattended; that answers 402 with `authentication_required` and the purchase must be finished on Crossly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCheckoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCheckoutApi(config);

            try
            {
                // Buy a listing without being present.
                CreateBuyerCheckoutResponse result = apiInstance.CreateBuyerCheckout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCheckoutApi.CreateBuyerCheckout: " + e.Message );
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

[**CreateBuyerCheckoutResponse**](CreateBuyerCheckoutResponse.md)

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuyercheckoutcontrol"></a>
# **GetBuyerCheckoutControl**
> GetBuyerCheckoutControlResponse GetBuyerCheckoutControl ()

What this key is allowed to spend.

Reports the controls for the key making the call — not for your account. Every key has its own switch and its own limits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCheckoutControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCheckoutApi(config);

            try
            {
                // What this key is allowed to spend.
                GetBuyerCheckoutControlResponse result = apiInstance.GetBuyerCheckoutControl();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCheckoutApi.GetBuyerCheckoutControl: " + e.Message );
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

[**GetBuyerCheckoutControlResponse**](GetBuyerCheckoutControlResponse.md)

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebuyercheckoutcontrol"></a>
# **UpdateBuyerCheckoutControl**
> UpdateBuyerCheckoutControlResponse UpdateBuyerCheckoutControl ()

Switch this key on for spending, and set its limits.

A key can only ever raise or lower ITS OWN limits, and only if the token already carries buyer:checkout:write. Turning it off takes effect immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerCheckoutControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerCheckoutApi(config);

            try
            {
                // Switch this key on for spending, and set its limits.
                UpdateBuyerCheckoutControlResponse result = apiInstance.UpdateBuyerCheckoutControl();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerCheckoutApi.UpdateBuyerCheckoutControl: " + e.Message );
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

[**UpdateBuyerCheckoutControlResponse**](UpdateBuyerCheckoutControlResponse.md)

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

