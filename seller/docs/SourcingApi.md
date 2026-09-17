# net.crossly.Api.SourcingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSourcingReceipt**](SourcingApi.md#createsourcingreceipt) | **POST** /v1/sourcing/receipts | Append a parsed receipt to the sourcing ledger.
[**GetSourcingReceipt**](SourcingApi.md#getsourcingreceipt) | **GET** /v1/sourcing/receipts | List parsed sourcing receipts in this user&#39;s ledger.
[**ListSourcingDemand**](SourcingApi.md#listsourcingdemand) | **GET** /v1/sourcing/demand | Items buyers looked for on other sites that Crossly did not have.
[**ListSourcingDemandMine**](SourcingApi.md#listsourcingdemandmine) | **GET** /v1/sourcing/demand/mine | Unmet buyer demand for items you hold or have sold before.


<a name="createsourcingreceipt"></a>
# **CreateSourcingReceipt**
> CreateSourcingReceiptResponse CreateSourcingReceipt ()

Append a parsed receipt to the sourcing ledger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSourcingReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcingApi(config);

            try
            {
                // Append a parsed receipt to the sourcing ledger.
                CreateSourcingReceiptResponse result = apiInstance.CreateSourcingReceipt();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcingApi.CreateSourcingReceipt: " + e.Message );
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

[**CreateSourcingReceiptResponse**](CreateSourcingReceiptResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsourcingreceipt"></a>
# **GetSourcingReceipt**
> GetSourcingReceiptResponse GetSourcingReceipt ()

List parsed sourcing receipts in this user's ledger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSourcingReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcingApi(config);

            try
            {
                // List parsed sourcing receipts in this user's ledger.
                GetSourcingReceiptResponse result = apiInstance.GetSourcingReceipt();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcingApi.GetSourcingReceipt: " + e.Message );
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

[**GetSourcingReceiptResponse**](GetSourcingReceiptResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsourcingdemand"></a>
# **ListSourcingDemand**
> V1List ListSourcingDemand (int? days = null, int? minLooks = null, int? limit = null)

Items buyers looked for on other sites that Crossly did not have.

Aggregate demand observed by the Scout extension, ranked by MISSES — the times somebody asked and we had nothing. `medianPageCents` is what the retailers were charging, which is the number to source against. Anonymous in every case; there is no per-buyer view of this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSourcingDemandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcingApi(config);
            var days = 30;  // int? |  (optional)  (default to 30)
            var minLooks = 3;  // int? |  (optional)  (default to 3)
            var limit = 50;  // int? |  (optional)  (default to 50)

            try
            {
                // Items buyers looked for on other sites that Crossly did not have.
                V1List result = apiInstance.ListSourcingDemand(days, minLooks, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcingApi.ListSourcingDemand: " + e.Message );
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
 **days** | **int?**|  | [optional] [default to 30]
 **minLooks** | **int?**|  | [optional] [default to 3]
 **limit** | **int?**|  | [optional] [default to 50]

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsourcingdemandmine"></a>
# **ListSourcingDemandMine**
> V1List ListSourcingDemandMine (int? days = null, int? minLookers = null, int? limit = null)

Unmet buyer demand for items you hold or have sold before.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSourcingDemandMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcingApi(config);
            var days = 60;  // int? |  (optional)  (default to 60)
            var minLookers = 2;  // int? |  (optional)  (default to 2)
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // Unmet buyer demand for items you hold or have sold before.
                V1List result = apiInstance.ListSourcingDemandMine(days, minLookers, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcingApi.ListSourcingDemandMine: " + e.Message );
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
 **days** | **int?**|  | [optional] [default to 60]
 **minLookers** | **int?**|  | [optional] [default to 2]
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

