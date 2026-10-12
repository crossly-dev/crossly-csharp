# net.crossly.Api.BillingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBillingUpgrade**](BillingApi.md#createbillingupgrade) | **POST** /v1/billing/upgrade | Start an upgrade to a higher plan.


<a name="createbillingupgrade"></a>
# **CreateBillingUpgrade**
> CreateBillingUpgradeResponse CreateBillingUpgrade (CreateBillingUpgradeRequest createBillingUpgradeRequest)

Start an upgrade to a higher plan.

Returns a Stripe Checkout URL. Nothing is charged by this call — a person completes the payment. Downgrades and cancellation are not available to a token at all; they stay with the account owner.

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
                // Start an upgrade to a higher plan.
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

