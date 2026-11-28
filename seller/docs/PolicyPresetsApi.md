# net.crossly.Api.PolicyPresetsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGeoLocationCheck**](PolicyPresetsApi.md#creategeolocationcheck) | **POST** /v1/geo/location-check | Check whether a shipping policy ships to an address.
[**CreatePolicyPreset**](PolicyPresetsApi.md#createpolicypreset) | **POST** /v1/policy-presets | Create a return / shipping / payment / pricing policy preset.
[**CreatePolicyPresetDuplicate**](PolicyPresetsApi.md#createpolicypresetduplicate) | **POST** /v1/policy-presets/{id}/duplicate | Copy a policy preset (\&quot;&lt;name&gt; (copy)\&quot;, never the default; a pricing copy applies nowhere yet).
[**DeletePolicyPreset**](PolicyPresetsApi.md#deletepolicypreset) | **DELETE** /v1/policy-presets/{id} | Delete a policy preset. Listings that used it switch to the default preset of its kind.
[**GetPolicy**](PolicyPresetsApi.md#getpolicy) | **GET** /v1/policies | The store&#39;s shipping / return / payment policy presets by kind, with each kind&#39;s default (X-Storefront-Id, else the default store).
[**GetPolicyGeneral**](PolicyPresetsApi.md#getpolicygeneral) | **GET** /v1/policies/general | Settings that fit no policy kind: vacation mode (schedule, scope, message, auto-actions).
[**GetPolicyPreset**](PolicyPresetsApi.md#getpolicypreset) | **GET** /v1/policy-presets/{id} | One policy: its fields, how many listings use it, where it applies per platform account (use this policy / the marketplace&#39;s own setting / default for that marketplace) with what each marketplace receives, and its history.
[**ListPolicyPresetAccounts**](PolicyPresetsApi.md#listpolicypresetaccounts) | **GET** /v1/policy-presets/accounts | The connected platform accounts a policy can apply to (\&quot;Where this applies\&quot;).
[**ListPolicyPresets**](PolicyPresetsApi.md#listpolicypresets) | **GET** /v1/policy-presets | List the seller&#39;s return / shipping / payment / pricing policy presets (no kind &#x3D; the three listing kinds). meta.migrationNotices lists defaults the policy migration demoted (kind still has no default).
[**UpdatePolicyGeneral**](PolicyPresetsApi.md#updatepolicygeneral) | **PUT** /v1/policies/general | Save vacation mode: on now or scheduled, everywhere or chosen accounts, message, auto-actions.
[**UpdatePolicyPreset**](PolicyPresetsApi.md#updatepolicypreset) | **PATCH** /v1/policy-presets/{id} | Update a policy preset.
[**UpdatePolicyPresetApplication**](PolicyPresetsApi.md#updatepolicypresetapplication) | **PUT** /v1/policy-presets/{id}/applications | Replace where a policy applies: per platform account, push (use this policy), marketplace (the marketplace&#39;s own setting, optionally an eBay business policy id) or off (pricing), and isDefault (default for that marketplace).


<a name="creategeolocationcheck"></a>
# **CreateGeoLocationCheck**
> CreateGeoLocationCheckResponse CreateGeoLocationCheck (CreateGeoLocationCheckRequest createGeoLocationCheckRequest)

Check whether a shipping policy ships to an address.

Pass an unsaved `policy` draft or a `presetId` (neither = your default shipping policy), an `address`, and optionally `consolidateVia` (a ship-together hub). Returns `ships`, and when it does not: `reason`, `stage` (buyer | hub), `message` and the deciding `rule`. `partial` means a fuller address (state, ZIP) could change the answer. A draft that is not a valid shipping policy is a 422; a presetId that is not yours is a 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateGeoLocationCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var createGeoLocationCheckRequest = new CreateGeoLocationCheckRequest(); // CreateGeoLocationCheckRequest | 

            try
            {
                // Check whether a shipping policy ships to an address.
                CreateGeoLocationCheckResponse result = apiInstance.CreateGeoLocationCheck(createGeoLocationCheckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.CreateGeoLocationCheck: " + e.Message );
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
 **createGeoLocationCheckRequest** | **CreateGeoLocationCheckRequest**|  | 

### Return type

**CreateGeoLocationCheckResponse**

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

<a name="createpolicypreset"></a>
# **CreatePolicyPreset**
> CreatePolicyPresetResponse CreatePolicyPreset (CreatePolicyPresetRequest createPolicyPresetRequest)

Create a return / shipping / payment / pricing policy preset.

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
            var createPolicyPresetRequest = new CreatePolicyPresetRequest(); // CreatePolicyPresetRequest | 

            try
            {
                // Create a return / shipping / payment / pricing policy preset.
                CreatePolicyPresetResponse result = apiInstance.CreatePolicyPreset(createPolicyPresetRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPolicyPresetRequest** | **CreatePolicyPresetRequest**|  | 

### Return type

**CreatePolicyPresetResponse**

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

<a name="createpolicypresetduplicate"></a>
# **CreatePolicyPresetDuplicate**
> ListPolicyPresetsItem CreatePolicyPresetDuplicate (Guid id)

Copy a policy preset (\"<name> (copy)\", never the default; a pricing copy applies nowhere yet).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreatePolicyPresetDuplicateExample
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
                // Copy a policy preset (\"<name> (copy)\", never the default; a pricing copy applies nowhere yet).
                ListPolicyPresetsItem result = apiInstance.CreatePolicyPresetDuplicate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.CreatePolicyPresetDuplicate: " + e.Message );
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

<a name="deletepolicypreset"></a>
# **DeletePolicyPreset**
> DeletePolicyPresetResponse DeletePolicyPreset (Guid id)

Delete a policy preset. Listings that used it switch to the default preset of its kind.

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
                // Delete a policy preset. Listings that used it switch to the default preset of its kind.
                DeletePolicyPresetResponse result = apiInstance.DeletePolicyPreset(id);
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

**DeletePolicyPresetResponse**

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

<a name="getpolicy"></a>
# **GetPolicy**
> GetPolicyResponse GetPolicy ()

The store's shipping / return / payment policy presets by kind, with each kind's default (X-Storefront-Id, else the default store).

Pass a preset `id` as `policies.shippingPresetId` / `returnPresetId` / `paymentPresetId` on POST or PATCH /v1/listings (null = the marketplace's own default). A kind you omit uses `defaultPresetId`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPolicyExample
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
                // The store's shipping / return / payment policy presets by kind, with each kind's default (X-Storefront-Id, else the default store).
                GetPolicyResponse result = apiInstance.GetPolicy();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.GetPolicy: " + e.Message );
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

**GetPolicyResponse**

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

<a name="getpolicygeneral"></a>
# **GetPolicyGeneral**
> GetPolicyGeneralResponse GetPolicyGeneral ()

Settings that fit no policy kind: vacation mode (schedule, scope, message, auto-actions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPolicyGeneralExample
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
                // Settings that fit no policy kind: vacation mode (schedule, scope, message, auto-actions).
                GetPolicyGeneralResponse result = apiInstance.GetPolicyGeneral();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.GetPolicyGeneral: " + e.Message );
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

**GetPolicyGeneralResponse**

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

<a name="getpolicypreset"></a>
# **GetPolicyPreset**
> GetPolicyPresetResponse GetPolicyPreset (Guid id)

One policy: its fields, how many listings use it, where it applies per platform account (use this policy / the marketplace's own setting / default for that marketplace) with what each marketplace receives, and its history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetPolicyPresetExample
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
                // One policy: its fields, how many listings use it, where it applies per platform account (use this policy / the marketplace's own setting / default for that marketplace) with what each marketplace receives, and its history.
                GetPolicyPresetResponse result = apiInstance.GetPolicyPreset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.GetPolicyPreset: " + e.Message );
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

**GetPolicyPresetResponse**

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

<a name="listpolicypresetaccounts"></a>
# **ListPolicyPresetAccounts**
> ListPolicyPresetAccountsResponse ListPolicyPresetAccounts ()

The connected platform accounts a policy can apply to (\"Where this applies\").

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListPolicyPresetAccountsExample
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
                // The connected platform accounts a policy can apply to (\"Where this applies\").
                ListPolicyPresetAccountsResponse result = apiInstance.ListPolicyPresetAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.ListPolicyPresetAccounts: " + e.Message );
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

**ListPolicyPresetAccountsResponse**

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

List the seller's return / shipping / payment / pricing policy presets (no kind = the three listing kinds). meta.migrationNotices lists defaults the policy migration demoted (kind still has no default).

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
                // List the seller's return / shipping / payment / pricing policy presets (no kind = the three listing kinds). meta.migrationNotices lists defaults the policy migration demoted (kind still has no default).
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

<a name="updatepolicygeneral"></a>
# **UpdatePolicyGeneral**
> UpdatePolicyGeneralResponse UpdatePolicyGeneral (UpdatePolicyGeneralRequest updatePolicyGeneralRequest)

Save vacation mode: on now or scheduled, everywhere or chosen accounts, message, auto-actions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePolicyGeneralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var updatePolicyGeneralRequest = new UpdatePolicyGeneralRequest(); // UpdatePolicyGeneralRequest | 

            try
            {
                // Save vacation mode: on now or scheduled, everywhere or chosen accounts, message, auto-actions.
                UpdatePolicyGeneralResponse result = apiInstance.UpdatePolicyGeneral(updatePolicyGeneralRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.UpdatePolicyGeneral: " + e.Message );
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
 **updatePolicyGeneralRequest** | **UpdatePolicyGeneralRequest**|  | 

### Return type

**UpdatePolicyGeneralResponse**

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

<a name="updatepolicypreset"></a>
# **UpdatePolicyPreset**
> CreatePolicyPresetResponse UpdatePolicyPreset (Guid id, UpdatePolicyPresetRequest updatePolicyPresetRequest)

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
            var updatePolicyPresetRequest = new UpdatePolicyPresetRequest(); // UpdatePolicyPresetRequest | 

            try
            {
                // Update a policy preset.
                CreatePolicyPresetResponse result = apiInstance.UpdatePolicyPreset(id, updatePolicyPresetRequest);
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
 **updatePolicyPresetRequest** | **UpdatePolicyPresetRequest**|  | 

### Return type

**CreatePolicyPresetResponse**

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

<a name="updatepolicypresetapplication"></a>
# **UpdatePolicyPresetApplication**
> UpdatePolicyPresetApplicationResponse UpdatePolicyPresetApplication (Guid id, UpdatePolicyPresetApplicationRequest updatePolicyPresetApplicationRequest)

Replace where a policy applies: per platform account, push (use this policy), marketplace (the marketplace's own setting, optionally an eBay business policy id) or off (pricing), and isDefault (default for that marketplace).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdatePolicyPresetApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicyPresetsApi(config);
            var id = "id_example";  // Guid | 
            var updatePolicyPresetApplicationRequest = new UpdatePolicyPresetApplicationRequest(); // UpdatePolicyPresetApplicationRequest | 

            try
            {
                // Replace where a policy applies: per platform account, push (use this policy), marketplace (the marketplace's own setting, optionally an eBay business policy id) or off (pricing), and isDefault (default for that marketplace).
                UpdatePolicyPresetApplicationResponse result = apiInstance.UpdatePolicyPresetApplication(id, updatePolicyPresetApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyPresetsApi.UpdatePolicyPresetApplication: " + e.Message );
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
 **updatePolicyPresetApplicationRequest** | **UpdatePolicyPresetApplicationRequest**|  | 

### Return type

**UpdatePolicyPresetApplicationResponse**

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

