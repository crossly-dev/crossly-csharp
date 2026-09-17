# net.crossly.Api.ConnectionsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConnectionHealth**](ConnectionsApi.md#getconnectionhealth) | **GET** /v1/connection-health | Health of each connected marketplace account, with a plain-English diagnosis.
[**ListDevices**](ConnectionsApi.md#listdevices) | **GET** /v1/devices | Machines paired to this account, and what each can do.


<a name="getconnectionhealth"></a>
# **GetConnectionHealth**
> GetConnectionHealthResponse GetConnectionHealth (bool? includeUnconnected = null)

Health of each connected marketplace account, with a plain-English diagnosis.

One entry per ACCOUNT, not per platform — a healthy slot 1 must not speak for a dead slot 2. States that were never measured are reported as \"unknown\" rather than as failures.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetConnectionHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var includeUnconnected = true;  // bool? |  (optional) 

            try
            {
                // Health of each connected marketplace account, with a plain-English diagnosis.
                GetConnectionHealthResponse result = apiInstance.GetConnectionHealth(includeUnconnected);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetConnectionHealth: " + e.Message );
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
 **includeUnconnected** | **bool?**|  | [optional] 

### Return type

[**GetConnectionHealthResponse**](GetConnectionHealthResponse.md)

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

<a name="listdevices"></a>
# **ListDevices**
> V1List ListDevices ()

Machines paired to this account, and what each can do.

Capabilities are what the machine DECLARED it can do at pairing — print, scan_watch, browser, cookie_jar, proxy_bind, scale. A machine only declares \"scale\" when one actually answered, never on the assumption that one might.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ConnectionsApi(config);

            try
            {
                // Machines paired to this account, and what each can do.
                V1List result = apiInstance.ListDevices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.ListDevices: " + e.Message );
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

