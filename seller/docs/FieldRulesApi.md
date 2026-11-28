# net.crossly.Api.FieldRulesApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFieldRule**](FieldRulesApi.md#createfieldrule) | **POST** /v1/field-rules | Create a per-channel field rule.
[**CreateFieldRulePreview**](FieldRulesApi.md#createfieldrulepreview) | **POST** /v1/field-rules/preview | Preview field-rule output for a listing on one channel.
[**CreateFieldRuleReorder**](FieldRulesApi.md#createfieldrulereorder) | **POST** /v1/field-rules/reorder | Set the run order of several field rules.
[**DeleteFieldRule**](FieldRulesApi.md#deletefieldrule) | **DELETE** /v1/field-rules/{id} | Delete a field rule.
[**GetFieldRule**](FieldRulesApi.md#getfieldrule) | **GET** /v1/field-rules/{id} | Get one field rule.
[**ListFieldRules**](FieldRulesApi.md#listfieldrules) | **GET** /v1/field-rules | List the seller&#39;s per-channel field rules.
[**UpdateFieldRule**](FieldRulesApi.md#updatefieldrule) | **PATCH** /v1/field-rules/{id} | Update a field rule.


<a name="createfieldrule"></a>
# **CreateFieldRule**
> ListFieldRulesItem CreateFieldRule (CreateFieldRuleRequest createFieldRuleRequest)

Create a per-channel field rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFieldRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var createFieldRuleRequest = new CreateFieldRuleRequest(); // CreateFieldRuleRequest | 

            try
            {
                // Create a per-channel field rule.
                ListFieldRulesItem result = apiInstance.CreateFieldRule(createFieldRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.CreateFieldRule: " + e.Message );
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
 **createFieldRuleRequest** | **CreateFieldRuleRequest**|  | 

### Return type

**ListFieldRulesItem**

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

<a name="createfieldrulepreview"></a>
# **CreateFieldRulePreview**
> CreateFieldRulePreviewResponse CreateFieldRulePreview (CreateFieldRulePreviewRequest createFieldRulePreviewRequest)

Preview field-rule output for a listing on one channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFieldRulePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var createFieldRulePreviewRequest = new CreateFieldRulePreviewRequest(); // CreateFieldRulePreviewRequest | 

            try
            {
                // Preview field-rule output for a listing on one channel.
                CreateFieldRulePreviewResponse result = apiInstance.CreateFieldRulePreview(createFieldRulePreviewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.CreateFieldRulePreview: " + e.Message );
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
 **createFieldRulePreviewRequest** | **CreateFieldRulePreviewRequest**|  | 

### Return type

**CreateFieldRulePreviewResponse**

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

<a name="createfieldrulereorder"></a>
# **CreateFieldRuleReorder**
> OkResponse CreateFieldRuleReorder (CreateFieldRuleReorderRequest createFieldRuleReorderRequest)

Set the run order of several field rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFieldRuleReorderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var createFieldRuleReorderRequest = new CreateFieldRuleReorderRequest(); // CreateFieldRuleReorderRequest | 

            try
            {
                // Set the run order of several field rules.
                OkResponse result = apiInstance.CreateFieldRuleReorder(createFieldRuleReorderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.CreateFieldRuleReorder: " + e.Message );
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
 **createFieldRuleReorderRequest** | **CreateFieldRuleReorderRequest**|  | 

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

<a name="deletefieldrule"></a>
# **DeleteFieldRule**
> OkResponse DeleteFieldRule (Guid id)

Delete a field rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteFieldRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a field rule.
                OkResponse result = apiInstance.DeleteFieldRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.DeleteFieldRule: " + e.Message );
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

<a name="getfieldrule"></a>
# **GetFieldRule**
> ListFieldRulesItem GetFieldRule (Guid id)

Get one field rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFieldRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get one field rule.
                ListFieldRulesItem result = apiInstance.GetFieldRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.GetFieldRule: " + e.Message );
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

**ListFieldRulesItem**

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

<a name="listfieldrules"></a>
# **ListFieldRules**
> ListFieldRulesResponse ListFieldRules (string platform = null)

List the seller's per-channel field rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFieldRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var platform = "platform_example";  // string |  (optional) 

            try
            {
                // List the seller's per-channel field rules.
                ListFieldRulesResponse result = apiInstance.ListFieldRules(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.ListFieldRules: " + e.Message );
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
 **platform** | **string**|  | [optional] 

### Return type

**ListFieldRulesResponse**

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

<a name="updatefieldrule"></a>
# **UpdateFieldRule**
> ListFieldRulesItem UpdateFieldRule (Guid id, UpdateFieldRuleRequest updateFieldRuleRequest)

Update a field rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateFieldRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FieldRulesApi(config);
            var id = "id_example";  // Guid | 
            var updateFieldRuleRequest = new UpdateFieldRuleRequest(); // UpdateFieldRuleRequest | 

            try
            {
                // Update a field rule.
                ListFieldRulesItem result = apiInstance.UpdateFieldRule(id, updateFieldRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FieldRulesApi.UpdateFieldRule: " + e.Message );
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
 **updateFieldRuleRequest** | **UpdateFieldRuleRequest**|  | 

### Return type

**ListFieldRulesItem**

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

