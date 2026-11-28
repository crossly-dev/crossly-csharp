# net.crossly.Api.ReturnsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePolicyReturnReceived**](ReturnsApi.md#createpolicyreturnreceived) | **POST** /v1/policy-returns/{id}/received | Mark a return received: refunds the buyer, less the restocking or try fee you keep.
[**CreateReturn**](ReturnsApi.md#createreturn) | **POST** /v1/returns | Open a return record on an order (rejects if another open return exists).
[**CreateReturnAccept**](ReturnsApi.md#createreturnaccept) | **POST** /v1/returns/{id}/accept | Accept a Crossly-marketplace return request: a prepaid return label to your return address (the buyer has 14 days to ship), a return record linked to it, and optionally a refund now (refund: { amount? } in dollars; needs orders:refund). Without one, the rest is refunded when the return is delivered. Safe to repeat. Crossposted orders: not_supported_on_platform.
[**CreateReturnDecline**](ReturnsApi.md#createreturndecline) | **POST** /v1/returns/{id}/decline | Decline a Crossly-marketplace return request with a reason (required, 8-2000 chars), posted to the buyer as your response. It does not close the request: the buyer can reply or ask Crossly to decide. Not after the label is issued.
[**GetReturn**](ReturnsApi.md#getreturn) | **GET** /v1/returns/{id} | Get one return record.
[**ListPolicyReturns**](ReturnsApi.md#listpolicyreturns) | **GET** /v1/policy-returns | Returns Crossly buyers opened under your return policy or try at home; filter by orderId.
[**ListReturns**](ReturnsApi.md#listreturns) | **GET** /v1/returns | List returns. Default: your return records (the physical-return workflow), status&#x3D;open|closed|&lt;exact&gt;. source&#x3D;request: the OPEN return requests buyers made on the Crossly marketplace, newest first; accept or decline each with POST /v1/returns/{id}/accept | decline.
[**UpdateReturn**](ReturnsApi.md#updatereturn) | **PATCH** /v1/returns/{id} | Transition return status (received/inspected/restocked) and bump inventory on restock.
[**UpdateReturnAssignee**](ReturnsApi.md#updatereturnassignee) | **PATCH** /v1/returns/assignee | Assign many returns to a teammate, round robin across several, or unassign them (null).
[**UpdateReturnAssigneeById**](ReturnsApi.md#updatereturnassigneebyid) | **PATCH** /v1/returns/{id}/assignee | Assign one return to a teammate, or unassign it (null).


<a name="createpolicyreturnreceived"></a>
# **CreatePolicyReturnReceived**
> CreatePolicyReturnReceivedResponse CreatePolicyReturnReceived (string id)

Mark a return received: refunds the buyer, less the restocking or try fee you keep.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePolicyReturnReceivedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Mark a return received: refunds the buyer, less the restocking or try fee you keep.
                CreatePolicyReturnReceivedResponse result = apiInstance.CreatePolicyReturnReceived(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.CreatePolicyReturnReceived: " + e.Message );
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

**CreatePolicyReturnReceivedResponse**

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

<a name="createreturn"></a>
# **CreateReturn**
> GetReturnResponse CreateReturn (OrderIdReasonRequest orderIdReasonRequest)

Open a return record on an order (rejects if another open return exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var orderIdReasonRequest = new OrderIdReasonRequest(); // OrderIdReasonRequest | 

            try
            {
                // Open a return record on an order (rejects if another open return exists).
                GetReturnResponse result = apiInstance.CreateReturn(orderIdReasonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.CreateReturn: " + e.Message );
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

**GetReturnResponse**

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

<a name="createreturnaccept"></a>
# **CreateReturnAccept**
> CreateReturnAcceptResponse CreateReturnAccept (Guid id, CreateReturnAcceptRequest createReturnAcceptRequest = null)

Accept a Crossly-marketplace return request: a prepaid return label to your return address (the buyer has 14 days to ship), a return record linked to it, and optionally a refund now (refund: { amount? } in dollars; needs orders:refund). Without one, the rest is refunded when the return is delivered. Safe to repeat. Crossposted orders: not_supported_on_platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateReturnAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // Guid | 
            var createReturnAcceptRequest = new CreateReturnAcceptRequest(); // CreateReturnAcceptRequest |  (optional) 

            try
            {
                // Accept a Crossly-marketplace return request: a prepaid return label to your return address (the buyer has 14 days to ship), a return record linked to it, and optionally a refund now (refund: { amount? } in dollars; needs orders:refund). Without one, the rest is refunded when the return is delivered. Safe to repeat. Crossposted orders: not_supported_on_platform.
                CreateReturnAcceptResponse result = apiInstance.CreateReturnAccept(id, createReturnAcceptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.CreateReturnAccept: " + e.Message );
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
 **createReturnAcceptRequest** | **CreateReturnAcceptRequest**|  | [optional] 

### Return type

**CreateReturnAcceptResponse**

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

<a name="createreturndecline"></a>
# **CreateReturnDecline**
> ListReturnsItem CreateReturnDecline (Guid id, CreateReturnDeclineRequest createReturnDeclineRequest)

Decline a Crossly-marketplace return request with a reason (required, 8-2000 chars), posted to the buyer as your response. It does not close the request: the buyer can reply or ask Crossly to decide. Not after the label is issued.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateReturnDeclineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // Guid | 
            var createReturnDeclineRequest = new CreateReturnDeclineRequest(); // CreateReturnDeclineRequest | 

            try
            {
                // Decline a Crossly-marketplace return request with a reason (required, 8-2000 chars), posted to the buyer as your response. It does not close the request: the buyer can reply or ask Crossly to decide. Not after the label is issued.
                ListReturnsItem result = apiInstance.CreateReturnDecline(id, createReturnDeclineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.CreateReturnDecline: " + e.Message );
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
 **createReturnDeclineRequest** | **CreateReturnDeclineRequest**|  | 

### Return type

**ListReturnsItem**

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

<a name="getreturn"></a>
# **GetReturn**
> GetReturnResponse GetReturn (Guid id)

Get one return record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one return record.
                GetReturnResponse result = apiInstance.GetReturn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.GetReturn: " + e.Message );
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

**GetReturnResponse**

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

<a name="listpolicyreturns"></a>
# **ListPolicyReturns**
> ListPolicyReturnsResponse ListPolicyReturns (string orderId = null)

Returns Crossly buyers opened under your return policy or try at home; filter by orderId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPolicyReturnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var orderId = "orderId_example";  // string |  (optional) 

            try
            {
                // Returns Crossly buyers opened under your return policy or try at home; filter by orderId.
                ListPolicyReturnsResponse result = apiInstance.ListPolicyReturns(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.ListPolicyReturns: " + e.Message );
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
 **orderId** | **string**|  | [optional] 

### Return type

**ListPolicyReturnsResponse**

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

<a name="listreturns"></a>
# **ListReturns**
> ListReturnsResponse ListReturns (string assignee = null)

List returns. Default: your return records (the physical-return workflow), status=open|closed|<exact>. source=request: the OPEN return requests buyers made on the Crossly marketplace, newest first; accept or decline each with POST /v1/returns/{id}/accept | decline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListReturnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var assignee = "assignee_example";  // string | Work assignment: 'me' (your own seat), 'none' (unassigned), 'any' (assigned to someone) or a team member id. (optional) 

            try
            {
                // List returns. Default: your return records (the physical-return workflow), status=open|closed|<exact>. source=request: the OPEN return requests buyers made on the Crossly marketplace, newest first; accept or decline each with POST /v1/returns/{id}/accept | decline.
                ListReturnsResponse result = apiInstance.ListReturns(assignee);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.ListReturns: " + e.Message );
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
 **assignee** | **string**| Work assignment: &#39;me&#39; (your own seat), &#39;none&#39; (unassigned), &#39;any&#39; (assigned to someone) or a team member id. | [optional] 

### Return type

**ListReturnsResponse**

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

<a name="updatereturn"></a>
# **UpdateReturn**
> GetReturnResponse UpdateReturn (Guid id, UpdateReturnRequest updateReturnRequest)

Transition return status (received/inspected/restocked) and bump inventory on restock.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // Guid | 
            var updateReturnRequest = new UpdateReturnRequest(); // UpdateReturnRequest | 

            try
            {
                // Transition return status (received/inspected/restocked) and bump inventory on restock.
                GetReturnResponse result = apiInstance.UpdateReturn(id, updateReturnRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.UpdateReturn: " + e.Message );
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
 **updateReturnRequest** | **UpdateReturnRequest**|  | 

### Return type

**GetReturnResponse**

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

<a name="updatereturnassignee"></a>
# **UpdateReturnAssignee**
> UpdateOrderAssigneeResponse UpdateReturnAssignee ()

Assign many returns to a teammate, round robin across several, or unassign them (null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateReturnAssigneeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);

            try
            {
                // Assign many returns to a teammate, round robin across several, or unassign them (null).
                UpdateOrderAssigneeResponse result = apiInstance.UpdateReturnAssignee();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.UpdateReturnAssignee: " + e.Message );
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

**UpdateOrderAssigneeResponse**

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

<a name="updatereturnassigneebyid"></a>
# **UpdateReturnAssigneeById**
> UpdateOrderAssigneeByIdResponse UpdateReturnAssigneeById (string id)

Assign one return to a teammate, or unassign it (null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateReturnAssigneeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReturnsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Assign one return to a teammate, or unassign it (null).
                UpdateOrderAssigneeByIdResponse result = apiInstance.UpdateReturnAssigneeById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.UpdateReturnAssigneeById: " + e.Message );
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

**UpdateOrderAssigneeByIdResponse**

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

