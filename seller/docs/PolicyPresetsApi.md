# net.crossly.Api.PolicyPresetsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePolicyPreset**](PolicyPresetsApi.md#createpolicypreset) | **POST** /v1/policy-presets | Create a return / shipping / payment policy preset.
[**DeletePolicyPreset**](PolicyPresetsApi.md#deletepolicypreset) | **DELETE** /v1/policy-presets/{id} | Delete a policy preset.
[**ListPolicyPresets**](PolicyPresetsApi.md#listpolicypresets) | **GET** /v1/policy-presets | List the seller&#39;s return / shipping / payment policy presets.
[**UpdatePolicyPreset**](PolicyPresetsApi.md#updatepolicypreset) | **PATCH** /v1/policy-presets/{id} | Update a policy preset.


<a name="createpolicypreset"></a>
# **CreatePolicyPreset**
> ListPolicyPresetsItem CreatePolicyPreset ()

Create a return / shipping / payment policy preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePolicyPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);

            try
            {
                // Create a return / shipping / payment policy preset.
                ListPolicyPresetsItem result = apiInstance.CreatePolicyPreset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.CreatePolicyPreset: " + e.Message );
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

**ListPolicyPresetsItem**

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

<a name="deletepolicypreset"></a>
# **DeletePolicyPreset**
> OkResponse DeletePolicyPreset (Guid id)

Delete a policy preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeletePolicyPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a policy preset.
                OkResponse result = apiInstance.DeletePolicyPreset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.DeletePolicyPreset: " + e.Message );
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

<a name="listpolicypresets"></a>
# **ListPolicyPresets**
> ListPolicyPresetsResponse ListPolicyPresets (string kind = null)

List the seller's return / shipping / payment policy presets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPolicyPresetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var kind = "return";  // string |  (optional) 

            try
            {
                // List the seller's return / shipping / payment policy presets.
                ListPolicyPresetsResponse result = apiInstance.ListPolicyPresets(kind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.ListPolicyPresets: " + e.Message );
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
 **kind** | **string**|  | [optional] 

### Return type

**ListPolicyPresetsResponse**

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

<a name="updatepolicypreset"></a>
# **UpdatePolicyPreset**
> ListPolicyPresetsItem UpdatePolicyPreset (Guid id)

Update a policy preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePolicyPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Update a policy preset.
                ListPolicyPresetsItem result = apiInstance.UpdatePolicyPreset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.UpdatePolicyPreset: " + e.Message );
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

**ListPolicyPresetsItem**

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

