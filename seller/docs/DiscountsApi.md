# net.crossly.Api.DiscountsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAutomaticDiscount**](DiscountsApi.md#createautomaticdiscount) | **POST** /v1/automatic-discounts | Create an automatic discount.
[**CreateAutomaticDiscountPreview**](DiscountsApi.md#createautomaticdiscountpreview) | **POST** /v1/automatic-discounts/preview | Preview a hypothetical cart of your listings against your automatic discounts (or an unsaved draft): what each line gets.
[**CreateDiscountCode**](DiscountsApi.md#creatediscountcode) | **POST** /v1/discount-codes | Create a discount code: percent, fixed, free shipping, buy X get Y, spend tiers or a set price, with requirements, item scope, limits (total, per buyer, per day, budget, regions), schedule and stacking.
[**CreateDiscountCodeGenerate**](DiscountsApi.md#creatediscountcodegenerate) | **POST** /v1/discount-codes/{id}/generate | Generate up to 5,000 unique single-use codes with this code’s rules (their uses count toward its limits).
[**CreateDiscountCodePauseAll**](DiscountsApi.md#creatediscountcodepauseall) | **POST** /v1/discount-codes/pause-all | Pause every active discount code of the store at once (paused: true), or resume every paused one (paused: false). Archived codes are left alone; returns how many changed.
[**CreateDiscountCodeStatus**](DiscountsApi.md#creatediscountcodestatus) | **POST** /v1/discount-codes/{id}/status | Pause, resume (active) or archive a discount code.
[**CreateDiscountHolder**](DiscountsApi.md#creatediscountholder) | **POST** /v1/discounts/holders | Create a Collection holders deal in the store (X-Storefront-Id; default store when omitted).
[**DeleteAutomaticDiscount**](DiscountsApi.md#deleteautomaticdiscount) | **DELETE** /v1/automatic-discounts/{id} | Delete an automatic discount.
[**DeleteDiscountHolder**](DiscountsApi.md#deletediscountholder) | **DELETE** /v1/discounts/holders/{id} | Delete a Collection holders deal. Returns &#x60;{ ok }&#x60;.
[**GetDiscountCode**](DiscountsApi.md#getdiscountcode) | **GET** /v1/discount-codes/{id} | One discount code with its rules and usage.
[**GetDiscountCodeShare**](DiscountsApi.md#getdiscountcodeshare) | **GET** /v1/discount-codes/{id}/share | The share link that pre-applies the code at checkout (the store page with ?code&#x3D;) and a QR code of it as a PNG data URL.
[**GetDiscountHolder**](DiscountsApi.md#getdiscountholder) | **GET** /v1/discounts/holders/{id} | One Collection holders deal with its usage (uses, cents given).
[**ListAutomaticDiscounts**](DiscountsApi.md#listautomaticdiscounts) | **GET** /v1/automatic-discounts | Your automatic discounts (buy more, save more): quantity and mixed-item tiers, scope, channels and schedule.
[**ListDiscountCodeRedemptions**](DiscountsApi.md#listdiscountcoderedemptions) | **GET** /v1/discount-codes/{id}/redemptions | A code’s usage history: orders, masked buyers, region, channel and the amount given, newest first.
[**ListDiscountCodes**](DiscountsApi.md#listdiscountcodes) | **GET** /v1/discount-codes | Your discount codes: kind, status (active, scheduled, paused, expired, exhausted, archived), every rule, and usage.
[**ListDiscountHolders**](DiscountsApi.md#listdiscountholders) | **GET** /v1/discounts/holders | The store’s Collection holders deals: a percent off for buyers holding any token of a collection (by chain + contract), with scope, channels, schedule, stacking and limits.
[**UpdateAutomaticDiscount**](DiscountsApi.md#updateautomaticdiscount) | **PUT** /v1/automatic-discounts/{id} | Replace an automatic discount.
[**UpdateDiscountCode**](DiscountsApi.md#updatediscountcode) | **PATCH** /v1/discount-codes/{id} | Update a discount code. The code itself can be renamed only until it is first used.
[**UpdateDiscountHolder**](DiscountsApi.md#updatediscountholder) | **PUT** /v1/discounts/holders/{id} | Replace a Collection holders deal.


<a name="createautomaticdiscount"></a>
# **CreateAutomaticDiscount**
> CreateAutomaticDiscountResponse CreateAutomaticDiscount (CreateAutomaticDiscountRequest createAutomaticDiscountRequest)

Create an automatic discount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomaticDiscountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var createAutomaticDiscountRequest = new CreateAutomaticDiscountRequest(); // CreateAutomaticDiscountRequest | 

            try
            {
                // Create an automatic discount.
                CreateAutomaticDiscountResponse result = apiInstance.CreateAutomaticDiscount(createAutomaticDiscountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateAutomaticDiscount: " + e.Message );
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
 **createAutomaticDiscountRequest** | **CreateAutomaticDiscountRequest**|  | 

### Return type

**CreateAutomaticDiscountResponse**

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

<a name="createautomaticdiscountpreview"></a>
# **CreateAutomaticDiscountPreview**
> CreateAutomaticDiscountPreviewResponse CreateAutomaticDiscountPreview (CreateAutomaticDiscountPreviewRequest createAutomaticDiscountPreviewRequest)

Preview a hypothetical cart of your listings against your automatic discounts (or an unsaved draft): what each line gets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAutomaticDiscountPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var createAutomaticDiscountPreviewRequest = new CreateAutomaticDiscountPreviewRequest(); // CreateAutomaticDiscountPreviewRequest | 

            try
            {
                // Preview a hypothetical cart of your listings against your automatic discounts (or an unsaved draft): what each line gets.
                CreateAutomaticDiscountPreviewResponse result = apiInstance.CreateAutomaticDiscountPreview(createAutomaticDiscountPreviewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateAutomaticDiscountPreview: " + e.Message );
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
 **createAutomaticDiscountPreviewRequest** | **CreateAutomaticDiscountPreviewRequest**|  | 

### Return type

**CreateAutomaticDiscountPreviewResponse**

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

<a name="creatediscountcode"></a>
# **CreateDiscountCode**
> DiscountCodeResponse CreateDiscountCode (CreateDiscountCodeRequest createDiscountCodeRequest)

Create a discount code: percent, fixed, free shipping, buy X get Y, spend tiers or a set price, with requirements, item scope, limits (total, per buyer, per day, budget, regions), schedule and stacking.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDiscountCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var createDiscountCodeRequest = new CreateDiscountCodeRequest(); // CreateDiscountCodeRequest | 

            try
            {
                // Create a discount code: percent, fixed, free shipping, buy X get Y, spend tiers or a set price, with requirements, item scope, limits (total, per buyer, per day, budget, regions), schedule and stacking.
                DiscountCodeResponse result = apiInstance.CreateDiscountCode(createDiscountCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateDiscountCode: " + e.Message );
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
 **createDiscountCodeRequest** | **CreateDiscountCodeRequest**|  | 

### Return type

**DiscountCodeResponse**

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

<a name="creatediscountcodegenerate"></a>
# **CreateDiscountCodeGenerate**
> CreateDiscountCodeGenerateResponse CreateDiscountCodeGenerate (string id, CreateDiscountCodeGenerateRequest createDiscountCodeGenerateRequest)

Generate up to 5,000 unique single-use codes with this code’s rules (their uses count toward its limits).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDiscountCodeGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 
            var createDiscountCodeGenerateRequest = new CreateDiscountCodeGenerateRequest(); // CreateDiscountCodeGenerateRequest | 

            try
            {
                // Generate up to 5,000 unique single-use codes with this code’s rules (their uses count toward its limits).
                CreateDiscountCodeGenerateResponse result = apiInstance.CreateDiscountCodeGenerate(id, createDiscountCodeGenerateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateDiscountCodeGenerate: " + e.Message );
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
 **createDiscountCodeGenerateRequest** | **CreateDiscountCodeGenerateRequest**|  | 

### Return type

**CreateDiscountCodeGenerateResponse**

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

<a name="creatediscountcodepauseall"></a>
# **CreateDiscountCodePauseAll**
> CreateDiscountCodePauseAllResponse CreateDiscountCodePauseAll (CreateDiscountCodePauseAllRequest createDiscountCodePauseAllRequest)

Pause every active discount code of the store at once (paused: true), or resume every paused one (paused: false). Archived codes are left alone; returns how many changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDiscountCodePauseAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var createDiscountCodePauseAllRequest = new CreateDiscountCodePauseAllRequest(); // CreateDiscountCodePauseAllRequest | 

            try
            {
                // Pause every active discount code of the store at once (paused: true), or resume every paused one (paused: false). Archived codes are left alone; returns how many changed.
                CreateDiscountCodePauseAllResponse result = apiInstance.CreateDiscountCodePauseAll(createDiscountCodePauseAllRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateDiscountCodePauseAll: " + e.Message );
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
 **createDiscountCodePauseAllRequest** | **CreateDiscountCodePauseAllRequest**|  | 

### Return type

**CreateDiscountCodePauseAllResponse**

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

<a name="creatediscountcodestatus"></a>
# **CreateDiscountCodeStatus**
> DiscountCodeResponse CreateDiscountCodeStatus (string id, CreateDiscountCodeStatusRequest createDiscountCodeStatusRequest)

Pause, resume (active) or archive a discount code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDiscountCodeStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 
            var createDiscountCodeStatusRequest = new CreateDiscountCodeStatusRequest(); // CreateDiscountCodeStatusRequest | 

            try
            {
                // Pause, resume (active) or archive a discount code.
                DiscountCodeResponse result = apiInstance.CreateDiscountCodeStatus(id, createDiscountCodeStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateDiscountCodeStatus: " + e.Message );
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
 **createDiscountCodeStatusRequest** | **CreateDiscountCodeStatusRequest**|  | 

### Return type

**DiscountCodeResponse**

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

<a name="creatediscountholder"></a>
# **CreateDiscountHolder**
> CreateDiscountHolderResponse CreateDiscountHolder ()

Create a Collection holders deal in the store (X-Storefront-Id; default store when omitted).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDiscountHolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);

            try
            {
                // Create a Collection holders deal in the store (X-Storefront-Id; default store when omitted).
                CreateDiscountHolderResponse result = apiInstance.CreateDiscountHolder();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.CreateDiscountHolder: " + e.Message );
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

**CreateDiscountHolderResponse**

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

<a name="deleteautomaticdiscount"></a>
# **DeleteAutomaticDiscount**
> UpdateGroupBuyResponse DeleteAutomaticDiscount (string id)

Delete an automatic discount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAutomaticDiscountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete an automatic discount.
                UpdateGroupBuyResponse result = apiInstance.DeleteAutomaticDiscount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.DeleteAutomaticDiscount: " + e.Message );
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

**UpdateGroupBuyResponse**

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

<a name="deletediscountholder"></a>
# **DeleteDiscountHolder**
> OkResponse DeleteDiscountHolder (Guid id)

Delete a Collection holders deal. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteDiscountHolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a Collection holders deal. Returns `{ ok }`.
                OkResponse result = apiInstance.DeleteDiscountHolder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.DeleteDiscountHolder: " + e.Message );
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

<a name="getdiscountcode"></a>
# **GetDiscountCode**
> GetDiscountCodeResponse GetDiscountCode (string id)

One discount code with its rules and usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDiscountCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One discount code with its rules and usage.
                GetDiscountCodeResponse result = apiInstance.GetDiscountCode(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.GetDiscountCode: " + e.Message );
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

**GetDiscountCodeResponse**

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

<a name="getdiscountcodeshare"></a>
# **GetDiscountCodeShare**
> GetDiscountCodeShareResponse GetDiscountCodeShare (string id)

The share link that pre-applies the code at checkout (the store page with ?code=) and a QR code of it as a PNG data URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDiscountCodeShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The share link that pre-applies the code at checkout (the store page with ?code=) and a QR code of it as a PNG data URL.
                GetDiscountCodeShareResponse result = apiInstance.GetDiscountCodeShare(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.GetDiscountCodeShare: " + e.Message );
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

**GetDiscountCodeShareResponse**

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

<a name="getdiscountholder"></a>
# **GetDiscountHolder**
> GetDiscountHolderResponse GetDiscountHolder (Guid id)

One Collection holders deal with its usage (uses, cents given).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDiscountHolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One Collection holders deal with its usage (uses, cents given).
                GetDiscountHolderResponse result = apiInstance.GetDiscountHolder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.GetDiscountHolder: " + e.Message );
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

**GetDiscountHolderResponse**

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

<a name="listautomaticdiscounts"></a>
# **ListAutomaticDiscounts**
> ListAutomaticDiscountsResponse ListAutomaticDiscounts ()

Your automatic discounts (buy more, save more): quantity and mixed-item tiers, scope, channels and schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListAutomaticDiscountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);

            try
            {
                // Your automatic discounts (buy more, save more): quantity and mixed-item tiers, scope, channels and schedule.
                ListAutomaticDiscountsResponse result = apiInstance.ListAutomaticDiscounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.ListAutomaticDiscounts: " + e.Message );
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

**ListAutomaticDiscountsResponse**

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

<a name="listdiscountcoderedemptions"></a>
# **ListDiscountCodeRedemptions**
> ListDiscountCodeRedemptionsResponse ListDiscountCodeRedemptions (string id, decimal? limit = null, decimal? offset = null)

A code’s usage history: orders, masked buyers, region, channel and the amount given, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDiscountCodeRedemptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 
            var limit = 8.14D;  // decimal? |  (optional) 
            var offset = 8.14D;  // decimal? |  (optional) 

            try
            {
                // A code’s usage history: orders, masked buyers, region, channel and the amount given, newest first.
                ListDiscountCodeRedemptionsResponse result = apiInstance.ListDiscountCodeRedemptions(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.ListDiscountCodeRedemptions: " + e.Message );
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
 **limit** | **decimal?**|  | [optional] 
 **offset** | **decimal?**|  | [optional] 

### Return type

**ListDiscountCodeRedemptionsResponse**

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

<a name="listdiscountcodes"></a>
# **ListDiscountCodes**
> ListDiscountCodesResponse ListDiscountCodes (string archived = null)

Your discount codes: kind, status (active, scheduled, paused, expired, exhausted, archived), every rule, and usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDiscountCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var archived = "true";  // string |  (optional) 

            try
            {
                // Your discount codes: kind, status (active, scheduled, paused, expired, exhausted, archived), every rule, and usage.
                ListDiscountCodesResponse result = apiInstance.ListDiscountCodes(archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.ListDiscountCodes: " + e.Message );
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
 **archived** | **string**|  | [optional] 

### Return type

**ListDiscountCodesResponse**

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

<a name="listdiscountholders"></a>
# **ListDiscountHolders**
> ListDiscountHoldersResponse ListDiscountHolders ()

The store’s Collection holders deals: a percent off for buyers holding any token of a collection (by chain + contract), with scope, channels, schedule, stacking and limits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDiscountHoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);

            try
            {
                // The store’s Collection holders deals: a percent off for buyers holding any token of a collection (by chain + contract), with scope, channels, schedule, stacking and limits.
                ListDiscountHoldersResponse result = apiInstance.ListDiscountHolders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.ListDiscountHolders: " + e.Message );
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

**ListDiscountHoldersResponse**

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

<a name="updateautomaticdiscount"></a>
# **UpdateAutomaticDiscount**
> CreateAutomaticDiscountResponse UpdateAutomaticDiscount (string id, CreateAutomaticDiscountRequest createAutomaticDiscountRequest)

Replace an automatic discount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAutomaticDiscountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 
            var createAutomaticDiscountRequest = new CreateAutomaticDiscountRequest(); // CreateAutomaticDiscountRequest | 

            try
            {
                // Replace an automatic discount.
                CreateAutomaticDiscountResponse result = apiInstance.UpdateAutomaticDiscount(id, createAutomaticDiscountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.UpdateAutomaticDiscount: " + e.Message );
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
 **createAutomaticDiscountRequest** | **CreateAutomaticDiscountRequest**|  | 

### Return type

**CreateAutomaticDiscountResponse**

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

<a name="updatediscountcode"></a>
# **UpdateDiscountCode**
> DiscountCodeResponse UpdateDiscountCode (string id, UpdateDiscountCodeRequest updateDiscountCodeRequest)

Update a discount code. The code itself can be renamed only until it is first used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDiscountCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // string | 
            var updateDiscountCodeRequest = new UpdateDiscountCodeRequest(); // UpdateDiscountCodeRequest | 

            try
            {
                // Update a discount code. The code itself can be renamed only until it is first used.
                DiscountCodeResponse result = apiInstance.UpdateDiscountCode(id, updateDiscountCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.UpdateDiscountCode: " + e.Message );
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
 **updateDiscountCodeRequest** | **UpdateDiscountCodeRequest**|  | 

### Return type

**DiscountCodeResponse**

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

<a name="updatediscountholder"></a>
# **UpdateDiscountHolder**
> CreateDiscountHolderResponse UpdateDiscountHolder (Guid id)

Replace a Collection holders deal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDiscountHolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Replace a Collection holders deal.
                CreateDiscountHolderResponse result = apiInstance.UpdateDiscountHolder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.UpdateDiscountHolder: " + e.Message );
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

**CreateDiscountHolderResponse**

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

