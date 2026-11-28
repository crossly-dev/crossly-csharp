# net.crossly.Api.SandboxApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSandboxReset**](SandboxApi.md#createsandboxreset) | **POST** /v1/sandbox/reset | Restore the sandbox seller to its seed. Your grant and webhook subscriptions are kept.
[**CreateSandboxSimulateInventory**](SandboxApi.md#createsandboxsimulateinventory) | **POST** /v1/sandbox/simulate/inventory | Change stock (set, increase or decrease); the new quantity is pushed to every channel.
[**CreateSandboxSimulateListingSoldOut**](SandboxApi.md#createsandboxsimulatelistingsoldout) | **POST** /v1/sandbox/simulate/listing.sold_out | A listing sells out on a marketplace with no order (stock moves, other channels delist).
[**CreateSandboxSimulateOrder**](SandboxApi.md#createsandboxsimulateorder) | **POST** /v1/sandbox/simulate/order | Simulate a sale through the real sale pipeline (order.created, sale.detected, stock and cross-channel updates).
[**CreateSandboxSimulateOrderAddress**](SandboxApi.md#createsandboxsimulateorderaddress) | **POST** /v1/sandbox/simulate/order.address | The buyer address of an order simulated with address \&quot;delayed\&quot; arrives now (order.address_available).
[**CreateSandboxSimulateOrderCancelled**](SandboxApi.md#createsandboxsimulateordercancelled) | **POST** /v1/sandbox/simulate/order.cancelled | The buyer or the marketplace cancels an order (order.cancelled).
[**CreateSandboxSimulateOrderDelivered**](SandboxApi.md#createsandboxsimulateorderdelivered) | **POST** /v1/sandbox/simulate/order.delivered | The carrier delivers a shipped order (order.delivered).
[**CreateSandboxSimulateRefund**](SandboxApi.md#createsandboxsimulaterefund) | **POST** /v1/sandbox/simulate/refund | Refund an order in full or in part (refund.issued).
[**GetSandbox**](SandboxApi.md#getsandbox) | **GET** /v1/sandbox | The sandbox seller this token acts on, its simulated channels and the failure modes.
[**ListSandboxEvents**](SandboxApi.md#listsandboxevents) | **GET** /v1/sandbox/events | The simulated marketplaces&#39; call log: verb, channel, outcome, latency.


<a name="createsandboxreset"></a>
# **CreateSandboxReset**
> CreateSandboxResetResponse CreateSandboxReset ()

Restore the sandbox seller to its seed. Your grant and webhook subscriptions are kept.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxResetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);

            try
            {
                // Restore the sandbox seller to its seed. Your grant and webhook subscriptions are kept.
                CreateSandboxResetResponse result = apiInstance.CreateSandboxReset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxReset: " + e.Message );
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

**CreateSandboxResetResponse**

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

<a name="createsandboxsimulateinventory"></a>
# **CreateSandboxSimulateInventory**
> CreateInboxConversationBulkResponse CreateSandboxSimulateInventory (CreateSandboxSimulateInventoryRequest createSandboxSimulateInventoryRequest)

Change stock (set, increase or decrease); the new quantity is pushed to every channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var createSandboxSimulateInventoryRequest = new CreateSandboxSimulateInventoryRequest(); // CreateSandboxSimulateInventoryRequest | 

            try
            {
                // Change stock (set, increase or decrease); the new quantity is pushed to every channel.
                CreateInboxConversationBulkResponse result = apiInstance.CreateSandboxSimulateInventory(createSandboxSimulateInventoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateInventory: " + e.Message );
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
 **createSandboxSimulateInventoryRequest** | **CreateSandboxSimulateInventoryRequest**|  | 

### Return type

**CreateInboxConversationBulkResponse**

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

<a name="createsandboxsimulatelistingsoldout"></a>
# **CreateSandboxSimulateListingSoldOut**
> CreateSandboxSimulateListingSoldOutResponse CreateSandboxSimulateListingSoldOut (CreateSandboxSimulateListingSoldOutRequest createSandboxSimulateListingSoldOutRequest)

A listing sells out on a marketplace with no order (stock moves, other channels delist).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateListingSoldOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var createSandboxSimulateListingSoldOutRequest = new CreateSandboxSimulateListingSoldOutRequest(); // CreateSandboxSimulateListingSoldOutRequest | 

            try
            {
                // A listing sells out on a marketplace with no order (stock moves, other channels delist).
                CreateSandboxSimulateListingSoldOutResponse result = apiInstance.CreateSandboxSimulateListingSoldOut(createSandboxSimulateListingSoldOutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateListingSoldOut: " + e.Message );
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
 **createSandboxSimulateListingSoldOutRequest** | **CreateSandboxSimulateListingSoldOutRequest**|  | 

### Return type

**CreateSandboxSimulateListingSoldOutResponse**

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

<a name="createsandboxsimulateorder"></a>
# **CreateSandboxSimulateOrder**
> CreateSandboxSimulateOrderResponse CreateSandboxSimulateOrder (CreateSandboxSimulateOrderRequest createSandboxSimulateOrderRequest)

Simulate a sale through the real sale pipeline (order.created, sale.detected, stock and cross-channel updates).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var createSandboxSimulateOrderRequest = new CreateSandboxSimulateOrderRequest(); // CreateSandboxSimulateOrderRequest | 

            try
            {
                // Simulate a sale through the real sale pipeline (order.created, sale.detected, stock and cross-channel updates).
                CreateSandboxSimulateOrderResponse result = apiInstance.CreateSandboxSimulateOrder(createSandboxSimulateOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateOrder: " + e.Message );
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
 **createSandboxSimulateOrderRequest** | **CreateSandboxSimulateOrderRequest**|  | 

### Return type

**CreateSandboxSimulateOrderResponse**

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

<a name="createsandboxsimulateorderaddress"></a>
# **CreateSandboxSimulateOrderAddress**
> CreateSandboxSimulateOrderAddressResponse CreateSandboxSimulateOrderAddress (CreateSandboxSimulateOrderAddressRequest createSandboxSimulateOrderAddressRequest)

The buyer address of an order simulated with address \"delayed\" arrives now (order.address_available).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateOrderAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var createSandboxSimulateOrderAddressRequest = new CreateSandboxSimulateOrderAddressRequest(); // CreateSandboxSimulateOrderAddressRequest | 

            try
            {
                // The buyer address of an order simulated with address \"delayed\" arrives now (order.address_available).
                CreateSandboxSimulateOrderAddressResponse result = apiInstance.CreateSandboxSimulateOrderAddress(createSandboxSimulateOrderAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateOrderAddress: " + e.Message );
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
 **createSandboxSimulateOrderAddressRequest** | **CreateSandboxSimulateOrderAddressRequest**|  | 

### Return type

**CreateSandboxSimulateOrderAddressResponse**

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

<a name="createsandboxsimulateordercancelled"></a>
# **CreateSandboxSimulateOrderCancelled**
> CreateSandboxSimulateOrderCancelledResponse CreateSandboxSimulateOrderCancelled (OrderIdReasonRequest orderIdReasonRequest)

The buyer or the marketplace cancels an order (order.cancelled).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateOrderCancelledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var orderIdReasonRequest = new OrderIdReasonRequest(); // OrderIdReasonRequest | 

            try
            {
                // The buyer or the marketplace cancels an order (order.cancelled).
                CreateSandboxSimulateOrderCancelledResponse result = apiInstance.CreateSandboxSimulateOrderCancelled(orderIdReasonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateOrderCancelled: " + e.Message );
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
 **orderIdReasonRequest** | **OrderIdReasonRequest**|  | 

### Return type

**CreateSandboxSimulateOrderCancelledResponse**

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

<a name="createsandboxsimulateorderdelivered"></a>
# **CreateSandboxSimulateOrderDelivered**
> CreateSandboxSimulateOrderDeliveredResponse CreateSandboxSimulateOrderDelivered (OrderIdReasonRequest orderIdReasonRequest)

The carrier delivers a shipped order (order.delivered).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateOrderDeliveredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var orderIdReasonRequest = new OrderIdReasonRequest(); // OrderIdReasonRequest | 

            try
            {
                // The carrier delivers a shipped order (order.delivered).
                CreateSandboxSimulateOrderDeliveredResponse result = apiInstance.CreateSandboxSimulateOrderDelivered(orderIdReasonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateOrderDelivered: " + e.Message );
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
 **orderIdReasonRequest** | **OrderIdReasonRequest**|  | 

### Return type

**CreateSandboxSimulateOrderDeliveredResponse**

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

<a name="createsandboxsimulaterefund"></a>
# **CreateSandboxSimulateRefund**
> CreateSandboxSimulateRefundResponse CreateSandboxSimulateRefund (CreateSandboxSimulateRefundRequest createSandboxSimulateRefundRequest)

Refund an order in full or in part (refund.issued).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSandboxSimulateRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var createSandboxSimulateRefundRequest = new CreateSandboxSimulateRefundRequest(); // CreateSandboxSimulateRefundRequest | 

            try
            {
                // Refund an order in full or in part (refund.issued).
                CreateSandboxSimulateRefundResponse result = apiInstance.CreateSandboxSimulateRefund(createSandboxSimulateRefundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.CreateSandboxSimulateRefund: " + e.Message );
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
 **createSandboxSimulateRefundRequest** | **CreateSandboxSimulateRefundRequest**|  | 

### Return type

**CreateSandboxSimulateRefundResponse**

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

<a name="getsandbox"></a>
# **GetSandbox**
> GetSandboxResponse GetSandbox ()

The sandbox seller this token acts on, its simulated channels and the failure modes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSandboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);

            try
            {
                // The sandbox seller this token acts on, its simulated channels and the failure modes.
                GetSandboxResponse result = apiInstance.GetSandbox();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.GetSandbox: " + e.Message );
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

**GetSandboxResponse**

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

<a name="listsandboxevents"></a>
# **ListSandboxEvents**
> ListSandboxEventsResponse ListSandboxEvents (decimal? limit = null)

The simulated marketplaces' call log: verb, channel, outcome, latency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSandboxEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SandboxApi(config);
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // The simulated marketplaces' call log: verb, channel, outcome, latency.
                ListSandboxEventsResponse result = apiInstance.ListSandboxEvents(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxApi.ListSandboxEvents: " + e.Message );
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
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListSandboxEventsResponse**

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

