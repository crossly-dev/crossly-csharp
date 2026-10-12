# net.crossly.Api.AutomationApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAutomationRule**](AutomationApi.md#createautomationrule) | **POST** /v1/automation/rules | Create an automation rule.
[**CreateAutomationRuleImport**](AutomationApi.md#createautomationruleimport) | **POST** /v1/automation/rules/import | Import one or more rules from recipe JSON (single or bundle).
[**CreateAutomationRuleRunNow**](AutomationApi.md#createautomationrulerunnow) | **POST** /v1/automation/rules/{id}/run-now | Fire an automation rule immediately.
[**CreateAutomationRuleToggle**](AutomationApi.md#createautomationruletoggle) | **POST** /v1/automation/rules/{id}/toggle | Flip an automation rule between active and inactive.
[**CreateAutomationRuleValidateRecipe**](AutomationApi.md#createautomationrulevalidaterecipe) | **POST** /v1/automation/rules/validate-recipe | Dry-run validate one or more recipes against the live catalog.
[**CreateRepriceEventApprove**](AutomationApi.md#createrepriceeventapprove) | **POST** /v1/reprice-events/{id}/approve | Apply a pending reprice proposal: the recorded price goes to the recorded platform listing. Proposals older than three days expire instead.
[**CreateRepriceEventSkip**](AutomationApi.md#createrepriceeventskip) | **POST** /v1/reprice-events/{id}/skip | Skip a pending reprice proposal; the price stays as it is.
[**DeleteAutomationRule**](AutomationApi.md#deleteautomationrule) | **DELETE** /v1/automation/rules/{id} | Delete an automation rule.
[**GetAutomationCatalog**](AutomationApi.md#getautomationcatalog) | **GET** /v1/automation/catalog | Supported triggerType / actionType / conditionType values for automation rules.
[**GetAutomationRule**](AutomationApi.md#getautomationrule) | **GET** /v1/automation/rules/{id} | Get a single automation rule.
[**GetAutomationRuleExport**](AutomationApi.md#getautomationruleexport) | **GET** /v1/automation/rules/export | Export the user&#39;s full rule library as a portable recipe bundle.
[**GetAutomationRuleExportById**](AutomationApi.md#getautomationruleexportbyid) | **GET** /v1/automation/rules/{id}/export | Export a single automation rule as a portable recipe.
[**ListAutomationRules**](AutomationApi.md#listautomationrules) | **GET** /v1/automation/rules | List automation rules.
[**ListAutomationRuns**](AutomationApi.md#listautomationruns) | **GET** /v1/automation/runs | Per-fire history for automation rules and workflow chain runs.
[**ListRepriceEvents**](AutomationApi.md#listrepriceevents) | **GET** /v1/reprice-events | Reprice decisions, newest first: applied, held at a floor, or pending approval (pending&#x3D;true for only those waiting).
[**UpdateAutomationRule**](AutomationApi.md#updateautomationrule) | **PUT** /v1/automation/rules/{id} | Update an automation rule (full replace).


<a name="createautomationrule"></a>
# **CreateAutomationRule**
> ListAutomationRulesItem CreateAutomationRule ()

Create an automation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // Create an automation rule.
                ListAutomationRulesItem result = apiInstance.CreateAutomationRule();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateAutomationRule: " + e.Message );
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

**ListAutomationRulesItem**

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

<a name="createautomationruleimport"></a>
# **CreateAutomationRuleImport**
> CreateAutomationRuleImportResponse CreateAutomationRuleImport (bool? activate = null)

Import one or more rules from recipe JSON (single or bundle).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomationRuleImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var activate = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Import one or more rules from recipe JSON (single or bundle).
                CreateAutomationRuleImportResponse result = apiInstance.CreateAutomationRuleImport(activate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateAutomationRuleImport: " + e.Message );
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
 **activate** | **bool?**|  | [optional] [default to false]

### Return type

**CreateAutomationRuleImportResponse**

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

<a name="createautomationrulerunnow"></a>
# **CreateAutomationRuleRunNow**
> CreateAutomationRuleRunNowResponse CreateAutomationRuleRunNow (Guid id)

Fire an automation rule immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomationRuleRunNowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Fire an automation rule immediately.
                CreateAutomationRuleRunNowResponse result = apiInstance.CreateAutomationRuleRunNow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateAutomationRuleRunNow: " + e.Message );
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

**CreateAutomationRuleRunNowResponse**

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

<a name="createautomationruletoggle"></a>
# **CreateAutomationRuleToggle**
> UpdateAutomationRuleResponse CreateAutomationRuleToggle (Guid id)

Flip an automation rule between active and inactive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomationRuleToggleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Flip an automation rule between active and inactive.
                UpdateAutomationRuleResponse result = apiInstance.CreateAutomationRuleToggle(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateAutomationRuleToggle: " + e.Message );
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

**UpdateAutomationRuleResponse**

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

<a name="createautomationrulevalidaterecipe"></a>
# **CreateAutomationRuleValidateRecipe**
> CreateAutomationRuleValidateRecipeResponse CreateAutomationRuleValidateRecipe ()

Dry-run validate one or more recipes against the live catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomationRuleValidateRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // Dry-run validate one or more recipes against the live catalog.
                CreateAutomationRuleValidateRecipeResponse result = apiInstance.CreateAutomationRuleValidateRecipe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateAutomationRuleValidateRecipe: " + e.Message );
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

**CreateAutomationRuleValidateRecipeResponse**

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

<a name="createrepriceeventapprove"></a>
# **CreateRepriceEventApprove**
> CreateRepriceEventSkipResponse CreateRepriceEventApprove (string id)

Apply a pending reprice proposal: the recorded price goes to the recorded platform listing. Proposals older than three days expire instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateRepriceEventApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Apply a pending reprice proposal: the recorded price goes to the recorded platform listing. Proposals older than three days expire instead.
                CreateRepriceEventSkipResponse result = apiInstance.CreateRepriceEventApprove(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateRepriceEventApprove: " + e.Message );
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

**CreateRepriceEventSkipResponse**

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

<a name="createrepriceeventskip"></a>
# **CreateRepriceEventSkip**
> CreateRepriceEventSkipResponse CreateRepriceEventSkip (string id)

Skip a pending reprice proposal; the price stays as it is.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateRepriceEventSkipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Skip a pending reprice proposal; the price stays as it is.
                CreateRepriceEventSkipResponse result = apiInstance.CreateRepriceEventSkip(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateRepriceEventSkip: " + e.Message );
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

**CreateRepriceEventSkipResponse**

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

<a name="deleteautomationrule"></a>
# **DeleteAutomationRule**
> OkResponse DeleteAutomationRule (Guid id)

Delete an automation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAutomationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete an automation rule.
                OkResponse result = apiInstance.DeleteAutomationRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteAutomationRule: " + e.Message );
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

<a name="getautomationcatalog"></a>
# **GetAutomationCatalog**
> GetAutomationCatalogResponse GetAutomationCatalog ()

Supported triggerType / actionType / conditionType values for automation rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAutomationCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // Supported triggerType / actionType / conditionType values for automation rules.
                GetAutomationCatalogResponse result = apiInstance.GetAutomationCatalog();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAutomationCatalog: " + e.Message );
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

**GetAutomationCatalogResponse**

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

<a name="getautomationrule"></a>
# **GetAutomationRule**
> GetAutomationRuleResponse GetAutomationRule (Guid id)

Get a single automation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAutomationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get a single automation rule.
                GetAutomationRuleResponse result = apiInstance.GetAutomationRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAutomationRule: " + e.Message );
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

**GetAutomationRuleResponse**

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

<a name="getautomationruleexport"></a>
# **GetAutomationRuleExport**
> GetAutomationRuleExportResponse GetAutomationRuleExport ()

Export the user's full rule library as a portable recipe bundle.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAutomationRuleExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // Export the user's full rule library as a portable recipe bundle.
                GetAutomationRuleExportResponse result = apiInstance.GetAutomationRuleExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAutomationRuleExport: " + e.Message );
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

**GetAutomationRuleExportResponse**

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

<a name="getautomationruleexportbyid"></a>
# **GetAutomationRuleExportById**
> GetAutomationRuleExportByIdResponse GetAutomationRuleExportById (Guid id)

Export a single automation rule as a portable recipe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAutomationRuleExportByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Export a single automation rule as a portable recipe.
                GetAutomationRuleExportByIdResponse result = apiInstance.GetAutomationRuleExportById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAutomationRuleExportById: " + e.Message );
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

**GetAutomationRuleExportByIdResponse**

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

<a name="listautomationrules"></a>
# **ListAutomationRules**
> ListAutomationRulesResponse ListAutomationRules ()

List automation rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListAutomationRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // List automation rules.
                ListAutomationRulesResponse result = apiInstance.ListAutomationRules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.ListAutomationRules: " + e.Message );
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

**ListAutomationRulesResponse**

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

<a name="listautomationruns"></a>
# **ListAutomationRuns**
> ListAutomationRunsResponse ListAutomationRuns (Guid? ruleId = null, Guid? chainId = null, int? limit = null)

Per-fire history for automation rules and workflow chain runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListAutomationRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var ruleId = "ruleId_example";  // Guid? |  (optional) 
            var chainId = "chainId_example";  // Guid? |  (optional) 
            var limit = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // Per-fire history for automation rules and workflow chain runs.
                ListAutomationRunsResponse result = apiInstance.ListAutomationRuns(ruleId, chainId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.ListAutomationRuns: " + e.Message );
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
 **ruleId** | **Guid?**|  | [optional] 
 **chainId** | **Guid?**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 100]

### Return type

**ListAutomationRunsResponse**

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

<a name="listrepriceevents"></a>
# **ListRepriceEvents**
> ListRepriceEventsResponse ListRepriceEvents ()

Reprice decisions, newest first: applied, held at a floor, or pending approval (pending=true for only those waiting).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListRepriceEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);

            try
            {
                // Reprice decisions, newest first: applied, held at a floor, or pending approval (pending=true for only those waiting).
                ListRepriceEventsResponse result = apiInstance.ListRepriceEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.ListRepriceEvents: " + e.Message );
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

**ListRepriceEventsResponse**

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

<a name="updateautomationrule"></a>
# **UpdateAutomationRule**
> UpdateAutomationRuleResponse UpdateAutomationRule (Guid id)

Update an automation rule (full replace).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAutomationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AutomationApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Update an automation rule (full replace).
                UpdateAutomationRuleResponse result = apiInstance.UpdateAutomationRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.UpdateAutomationRule: " + e.Message );
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

**UpdateAutomationRuleResponse**

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

