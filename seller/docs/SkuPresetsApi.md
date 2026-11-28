# net.crossly.Api.SkuPresetsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSkuPreset**](SkuPresetsApi.md#createskupreset) | **POST** /v1/sku-presets | Create a named SKU preset in the store (optionally the default).
[**CreateSkuPresetPreview**](SkuPresetsApi.md#createskupresetpreview) | **POST** /v1/sku-presets/preview | Generate a SKU from a saved preset (presetId) or an unsaved template, for the given listing fields (or a sample listing when fields is omitted). Nothing is written.
[**DeleteSkuPreset**](SkuPresetsApi.md#deleteskupreset) | **DELETE** /v1/sku-presets/{id} | Delete a SKU preset of the store.
[**GetSkuPreset**](SkuPresetsApi.md#getskupreset) | **GET** /v1/sku-presets/{id} | Get one SKU preset of the store.
[**ListSkuPresets**](SkuPresetsApi.md#listskupresets) | **GET** /v1/sku-presets | List the store&#39;s SKU presets, which one is the default, and the template new listings auto-fill their SKU from (meta.autoFill).
[**UpdateSkuPreset**](SkuPresetsApi.md#updateskupreset) | **PATCH** /v1/sku-presets/{id} | Rename a SKU preset, change its template, or make it the store&#39;s default.
[**UpdateSkuPresetDefault**](SkuPresetsApi.md#updateskupresetdefault) | **PUT** /v1/sku-presets/default | Choose the store&#39;s default SKU preset, which auto-fills the SKU of new listings created without one. presetId null clears it (manual SKUs).


<a name="createskupreset"></a>
# **CreateSkuPreset**
> ListSkuPresetsItem CreateSkuPreset (CreateSkuPresetRequest createSkuPresetRequest)

Create a named SKU preset in the store (optionally the default).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSkuPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var createSkuPresetRequest = new CreateSkuPresetRequest(); // CreateSkuPresetRequest | 

            try
            {
                // Create a named SKU preset in the store (optionally the default).
                ListSkuPresetsItem result = apiInstance.CreateSkuPreset(createSkuPresetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.CreateSkuPreset: " + e.Message );
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
 **createSkuPresetRequest** | **CreateSkuPresetRequest**|  | 

### Return type

**ListSkuPresetsItem**

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

<a name="createskupresetpreview"></a>
# **CreateSkuPresetPreview**
> CreateSkuPresetPreviewResponse CreateSkuPresetPreview (CreateSkuPresetPreviewRequest createSkuPresetPreviewRequest)

Generate a SKU from a saved preset (presetId) or an unsaved template, for the given listing fields (or a sample listing when fields is omitted). Nothing is written.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSkuPresetPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var createSkuPresetPreviewRequest = new CreateSkuPresetPreviewRequest(); // CreateSkuPresetPreviewRequest | 

            try
            {
                // Generate a SKU from a saved preset (presetId) or an unsaved template, for the given listing fields (or a sample listing when fields is omitted). Nothing is written.
                CreateSkuPresetPreviewResponse result = apiInstance.CreateSkuPresetPreview(createSkuPresetPreviewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.CreateSkuPresetPreview: " + e.Message );
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
 **createSkuPresetPreviewRequest** | **CreateSkuPresetPreviewRequest**|  | 

### Return type

**CreateSkuPresetPreviewResponse**

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

<a name="deleteskupreset"></a>
# **DeleteSkuPreset**
> DeleteSkuPresetResponse DeleteSkuPreset (Guid id)

Delete a SKU preset of the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSkuPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a SKU preset of the store.
                DeleteSkuPresetResponse result = apiInstance.DeleteSkuPreset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.DeleteSkuPreset: " + e.Message );
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

**DeleteSkuPresetResponse**

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

<a name="getskupreset"></a>
# **GetSkuPreset**
> ListSkuPresetsItem GetSkuPreset (Guid id)

Get one SKU preset of the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSkuPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one SKU preset of the store.
                ListSkuPresetsItem result = apiInstance.GetSkuPreset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.GetSkuPreset: " + e.Message );
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

**ListSkuPresetsItem**

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

<a name="listskupresets"></a>
# **ListSkuPresets**
> ListSkuPresetsResponse ListSkuPresets ()

List the store's SKU presets, which one is the default, and the template new listings auto-fill their SKU from (meta.autoFill).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSkuPresetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);

            try
            {
                // List the store's SKU presets, which one is the default, and the template new listings auto-fill their SKU from (meta.autoFill).
                ListSkuPresetsResponse result = apiInstance.ListSkuPresets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.ListSkuPresets: " + e.Message );
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

**ListSkuPresetsResponse**

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

<a name="updateskupreset"></a>
# **UpdateSkuPreset**
> ListSkuPresetsItem UpdateSkuPreset (Guid id, UpdateSkuPresetRequest updateSkuPresetRequest)

Rename a SKU preset, change its template, or make it the store's default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSkuPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var id = "id_example";  // Guid | 
            var updateSkuPresetRequest = new UpdateSkuPresetRequest(); // UpdateSkuPresetRequest | 

            try
            {
                // Rename a SKU preset, change its template, or make it the store's default.
                ListSkuPresetsItem result = apiInstance.UpdateSkuPreset(id, updateSkuPresetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.UpdateSkuPreset: " + e.Message );
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
 **updateSkuPresetRequest** | **UpdateSkuPresetRequest**|  | 

### Return type

**ListSkuPresetsItem**

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

<a name="updateskupresetdefault"></a>
# **UpdateSkuPresetDefault**
> UpdateSkuPresetDefaultResponse UpdateSkuPresetDefault (UpdateSkuPresetDefaultRequest updateSkuPresetDefaultRequest)

Choose the store's default SKU preset, which auto-fills the SKU of new listings created without one. presetId null clears it (manual SKUs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSkuPresetDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SkuPresetsApi(config);
            var updateSkuPresetDefaultRequest = new UpdateSkuPresetDefaultRequest(); // UpdateSkuPresetDefaultRequest | 

            try
            {
                // Choose the store's default SKU preset, which auto-fills the SKU of new listings created without one. presetId null clears it (manual SKUs).
                UpdateSkuPresetDefaultResponse result = apiInstance.UpdateSkuPresetDefault(updateSkuPresetDefaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SkuPresetsApi.UpdateSkuPresetDefault: " + e.Message );
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
 **updateSkuPresetDefaultRequest** | **UpdateSkuPresetDefaultRequest**|  | 

### Return type

**UpdateSkuPresetDefaultResponse**

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

