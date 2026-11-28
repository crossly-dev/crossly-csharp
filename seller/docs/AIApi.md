# net.crossly.Api.AIApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAiCategorize**](AIApi.md#createaicategorize) | **POST** /v1/ai/categorize | Taxonomy guess from a single image URL.
[**CreateAiCategorizeFromImage**](AIApi.md#createaicategorizefromimage) | **POST** /v1/ai/categorize-from-image | Taxonomy guess from a single base64 image.
[**CreateAiCopy**](AIApi.md#createaicopy) | **POST** /v1/ai/copy | Draft store copy (ads, branding, policy wording, lookbook copy) from the facts you give, on your AI key.
[**CreateAiEnhanceDescription**](AIApi.md#createaienhancedescription) | **POST** /v1/ai/enhance-description | SEO-rewrite a listing description.
[**CreateAiEnhanceListing**](AIApi.md#createaienhancelisting) | **POST** /v1/ai/enhance-listing | Rewrite title + description + tags in one call.
[**CreateAiEnhanceTitle**](AIApi.md#createaienhancetitle) | **POST** /v1/ai/enhance-title | SEO-rewrite a listing title.
[**CreateAiExtractReceipt**](AIApi.md#createaiextractreceipt) | **POST** /v1/ai/extract-receipt | Structured data extraction from a receipt photo.
[**CreateAiGenerateListing**](AIApi.md#createaigeneratelisting) | **POST** /v1/ai/generate-listing | Generate full listing fields from up to 4 image URLs.
[**CreateAiHelp**](AIApi.md#createaihelp) | **POST** /v1/ai/help | In-app help Q&amp;A grounded in supplied docs.
[**CreateAiKey**](AIApi.md#createaikey) | **POST** /v1/ai/keys | Connect an AI provider key to the store, with scopes and priority.
[**CreateAiKeyTest**](AIApi.md#createaikeytest) | **POST** /v1/ai/keys/test | Test an AI provider key before saving it.
[**CreateAiKeyTestById**](AIApi.md#createaikeytestbyid) | **POST** /v1/ai/keys/{id}/test | Re-test a saved AI key.
[**CreateAiMagicListing**](AIApi.md#createaimagiclisting) | **POST** /v1/ai/magic-listing | Generate full listing fields from base64 photos.
[**CreateAiTestKey**](AIApi.md#createaitestkey) | **POST** /v1/ai/test-key | Live-ping a candidate BYO-key.
[**CreateListingAiImage**](AIApi.md#createlistingaiimage) | **POST** /v1/listings/ai-image | Generate a listing photo with the caller&#39;s own image-provider key; the result is marked AI-generated.
[**CreateListingAiImagePrompt**](AIApi.md#createlistingaiimageprompt) | **POST** /v1/listings/ai-image/prompt | Build the AI product-photo prompt for a listing (no image is generated).
[**DeleteAiKey**](AIApi.md#deleteaikey) | **DELETE** /v1/ai/key | Remove the store&#39;s BYO-key for a provider.
[**DeleteAiKeyById**](AIApi.md#deleteaikeybyid) | **DELETE** /v1/ai/keys/{id} | Disconnect an AI provider key.
[**GetAiKey**](AIApi.md#getaikey) | **GET** /v1/ai/keys | The store&#39;s AI provider keys with their scopes and priority (never the key).
[**GetAiProvider**](AIApi.md#getaiprovider) | **GET** /v1/ai/providers | Static catalog of supported AI providers.
[**GetAiRouting**](AIApi.md#getairouting) | **GET** /v1/ai/routing | Which AI provider serves each feature of the store, in order, and whether it is on.
[**GetAiStatus**](AIApi.md#getaistatus) | **GET** /v1/ai/status | BYO-key state for the calling user.
[**UpdateAiImageConfig**](AIApi.md#updateaiimageconfig) | **PUT** /v1/ai/image-config | Choose the AI image provider/model, independently of the text provider.
[**UpdateAiKey**](AIApi.md#updateaikey) | **PUT** /v1/ai/key | Save a BYO-key for an AI provider on the store and make it the store&#39;s default.
[**UpdateAiKeyById**](AIApi.md#updateaikeybyid) | **PATCH** /v1/ai/keys/{id} | Edit an AI key: replace it, rename it, or change its scopes, priority and models.
[**UpdateAiRouting**](AIApi.md#updateairouting) | **PUT** /v1/ai/routing/{scope} | Set one AI feature&#39;s provider chain, model or on/off.


<a name="createaicategorize"></a>
# **CreateAiCategorize**
> CreateAiCategorizeResponse CreateAiCategorize (CreateAiCategorizeRequest createAiCategorizeRequest)

Taxonomy guess from a single image URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiCategorizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiCategorizeRequest = new CreateAiCategorizeRequest(); // CreateAiCategorizeRequest | 

            try
            {
                // Taxonomy guess from a single image URL.
                CreateAiCategorizeResponse result = apiInstance.CreateAiCategorize(createAiCategorizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiCategorize: " + e.Message );
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
 **createAiCategorizeRequest** | **CreateAiCategorizeRequest**|  | 

### Return type

**CreateAiCategorizeResponse**

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

<a name="createaicategorizefromimage"></a>
# **CreateAiCategorizeFromImage**
> CreateAiCategorizeResponse CreateAiCategorizeFromImage (CreateAiExtractReceiptRequest createAiExtractReceiptRequest)

Taxonomy guess from a single base64 image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiCategorizeFromImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiExtractReceiptRequest = new CreateAiExtractReceiptRequest(); // CreateAiExtractReceiptRequest | 

            try
            {
                // Taxonomy guess from a single base64 image.
                CreateAiCategorizeResponse result = apiInstance.CreateAiCategorizeFromImage(createAiExtractReceiptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiCategorizeFromImage: " + e.Message );
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
 **createAiExtractReceiptRequest** | **CreateAiExtractReceiptRequest**|  | 

### Return type

**CreateAiCategorizeResponse**

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

<a name="createaicopy"></a>
# **CreateAiCopy**
> CreateAiCopyResponse CreateAiCopy (CreateAiCopyRequest createAiCopyRequest = null)

Draft store copy (ads, branding, policy wording, lookbook copy) from the facts you give, on your AI key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiCopyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiCopyRequest = new CreateAiCopyRequest(); // CreateAiCopyRequest |  (optional) 

            try
            {
                // Draft store copy (ads, branding, policy wording, lookbook copy) from the facts you give, on your AI key.
                CreateAiCopyResponse result = apiInstance.CreateAiCopy(createAiCopyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiCopy: " + e.Message );
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
 **createAiCopyRequest** | **CreateAiCopyRequest**|  | [optional] 

### Return type

**CreateAiCopyResponse**

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

<a name="createaienhancedescription"></a>
# **CreateAiEnhanceDescription**
> CreateAiEnhanceDescriptionResponse CreateAiEnhanceDescription (CreateAiEnhanceDescriptionRequest createAiEnhanceDescriptionRequest)

SEO-rewrite a listing description.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiEnhanceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiEnhanceDescriptionRequest = new CreateAiEnhanceDescriptionRequest(); // CreateAiEnhanceDescriptionRequest | 

            try
            {
                // SEO-rewrite a listing description.
                CreateAiEnhanceDescriptionResponse result = apiInstance.CreateAiEnhanceDescription(createAiEnhanceDescriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiEnhanceDescription: " + e.Message );
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
 **createAiEnhanceDescriptionRequest** | **CreateAiEnhanceDescriptionRequest**|  | 

### Return type

**CreateAiEnhanceDescriptionResponse**

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

<a name="createaienhancelisting"></a>
# **CreateAiEnhanceListing**
> CreateAiEnhanceListingResponse CreateAiEnhanceListing (CreateAiEnhanceListingRequest createAiEnhanceListingRequest)

Rewrite title + description + tags in one call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiEnhanceListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiEnhanceListingRequest = new CreateAiEnhanceListingRequest(); // CreateAiEnhanceListingRequest | 

            try
            {
                // Rewrite title + description + tags in one call.
                CreateAiEnhanceListingResponse result = apiInstance.CreateAiEnhanceListing(createAiEnhanceListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiEnhanceListing: " + e.Message );
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
 **createAiEnhanceListingRequest** | **CreateAiEnhanceListingRequest**|  | 

### Return type

**CreateAiEnhanceListingResponse**

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

<a name="createaienhancetitle"></a>
# **CreateAiEnhanceTitle**
> CreateAiEnhanceTitleResponse CreateAiEnhanceTitle (CreateAiEnhanceTitleRequest createAiEnhanceTitleRequest)

SEO-rewrite a listing title.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiEnhanceTitleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiEnhanceTitleRequest = new CreateAiEnhanceTitleRequest(); // CreateAiEnhanceTitleRequest | 

            try
            {
                // SEO-rewrite a listing title.
                CreateAiEnhanceTitleResponse result = apiInstance.CreateAiEnhanceTitle(createAiEnhanceTitleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiEnhanceTitle: " + e.Message );
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
 **createAiEnhanceTitleRequest** | **CreateAiEnhanceTitleRequest**|  | 

### Return type

**CreateAiEnhanceTitleResponse**

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

<a name="createaiextractreceipt"></a>
# **CreateAiExtractReceipt**
> CreateAiExtractReceiptResponse CreateAiExtractReceipt (CreateAiExtractReceiptRequest createAiExtractReceiptRequest)

Structured data extraction from a receipt photo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiExtractReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiExtractReceiptRequest = new CreateAiExtractReceiptRequest(); // CreateAiExtractReceiptRequest | 

            try
            {
                // Structured data extraction from a receipt photo.
                CreateAiExtractReceiptResponse result = apiInstance.CreateAiExtractReceipt(createAiExtractReceiptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiExtractReceipt: " + e.Message );
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
 **createAiExtractReceiptRequest** | **CreateAiExtractReceiptRequest**|  | 

### Return type

**CreateAiExtractReceiptResponse**

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

<a name="createaigeneratelisting"></a>
# **CreateAiGenerateListing**
> CreateAiMagicListingResponse CreateAiGenerateListing (CreateAiGenerateListingRequest createAiGenerateListingRequest)

Generate full listing fields from up to 4 image URLs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiGenerateListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiGenerateListingRequest = new CreateAiGenerateListingRequest(); // CreateAiGenerateListingRequest | 

            try
            {
                // Generate full listing fields from up to 4 image URLs.
                CreateAiMagicListingResponse result = apiInstance.CreateAiGenerateListing(createAiGenerateListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiGenerateListing: " + e.Message );
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
 **createAiGenerateListingRequest** | **CreateAiGenerateListingRequest**|  | 

### Return type

**CreateAiMagicListingResponse**

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

<a name="createaihelp"></a>
# **CreateAiHelp**
> CreateAiHelpResponse CreateAiHelp (CreateAiHelpRequest createAiHelpRequest)

In-app help Q&A grounded in supplied docs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiHelpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiHelpRequest = new CreateAiHelpRequest(); // CreateAiHelpRequest | 

            try
            {
                // In-app help Q&A grounded in supplied docs.
                CreateAiHelpResponse result = apiInstance.CreateAiHelp(createAiHelpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiHelp: " + e.Message );
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
 **createAiHelpRequest** | **CreateAiHelpRequest**|  | 

### Return type

**CreateAiHelpResponse**

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

<a name="createaikey"></a>
# **CreateAiKey**
> CreateAiKeyResponse CreateAiKey (CreateAiKeyRequest createAiKeyRequest = null)

Connect an AI provider key to the store, with scopes and priority.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiKeyRequest = new CreateAiKeyRequest(); // CreateAiKeyRequest |  (optional) 

            try
            {
                // Connect an AI provider key to the store, with scopes and priority.
                CreateAiKeyResponse result = apiInstance.CreateAiKey(createAiKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiKey: " + e.Message );
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
 **createAiKeyRequest** | **CreateAiKeyRequest**|  | [optional] 

### Return type

**CreateAiKeyResponse**

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

<a name="createaikeytest"></a>
# **CreateAiKeyTest**
> CreateAiKeyTestResponse CreateAiKeyTest (CreateAiKeyTestRequest createAiKeyTestRequest = null)

Test an AI provider key before saving it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiKeyTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiKeyTestRequest = new CreateAiKeyTestRequest(); // CreateAiKeyTestRequest |  (optional) 

            try
            {
                // Test an AI provider key before saving it.
                CreateAiKeyTestResponse result = apiInstance.CreateAiKeyTest(createAiKeyTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiKeyTest: " + e.Message );
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
 **createAiKeyTestRequest** | **CreateAiKeyTestRequest**|  | [optional] 

### Return type

**CreateAiKeyTestResponse**

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

<a name="createaikeytestbyid"></a>
# **CreateAiKeyTestById**
> CreateAiKeyTestResponse CreateAiKeyTestById (string id)

Re-test a saved AI key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiKeyTestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Re-test a saved AI key.
                CreateAiKeyTestResponse result = apiInstance.CreateAiKeyTestById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiKeyTestById: " + e.Message );
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

**CreateAiKeyTestResponse**

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

<a name="createaimagiclisting"></a>
# **CreateAiMagicListing**
> CreateAiMagicListingResponse CreateAiMagicListing (CreateAiMagicListingRequest createAiMagicListingRequest)

Generate full listing fields from base64 photos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiMagicListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createAiMagicListingRequest = new CreateAiMagicListingRequest(); // CreateAiMagicListingRequest | 

            try
            {
                // Generate full listing fields from base64 photos.
                CreateAiMagicListingResponse result = apiInstance.CreateAiMagicListing(createAiMagicListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiMagicListing: " + e.Message );
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
 **createAiMagicListingRequest** | **CreateAiMagicListingRequest**|  | 

### Return type

**CreateAiMagicListingResponse**

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

<a name="createaitestkey"></a>
# **CreateAiTestKey**
> CreateAiTestKeyResponse CreateAiTestKey (UpdateAiKeyRequest updateAiKeyRequest)

Live-ping a candidate BYO-key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateAiTestKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var updateAiKeyRequest = new UpdateAiKeyRequest(); // UpdateAiKeyRequest | 

            try
            {
                // Live-ping a candidate BYO-key.
                CreateAiTestKeyResponse result = apiInstance.CreateAiTestKey(updateAiKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateAiTestKey: " + e.Message );
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
 **updateAiKeyRequest** | **UpdateAiKeyRequest**|  | 

### Return type

**CreateAiTestKeyResponse**

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

<a name="createlistingaiimage"></a>
# **CreateListingAiImage**
> CreateListingAiImageResponse CreateListingAiImage (CreateListingAiImageRequest createListingAiImageRequest = null)

Generate a listing photo with the caller's own image-provider key; the result is marked AI-generated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAiImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createListingAiImageRequest = new CreateListingAiImageRequest(); // CreateListingAiImageRequest |  (optional) 

            try
            {
                // Generate a listing photo with the caller's own image-provider key; the result is marked AI-generated.
                CreateListingAiImageResponse result = apiInstance.CreateListingAiImage(createListingAiImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateListingAiImage: " + e.Message );
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
 **createListingAiImageRequest** | **CreateListingAiImageRequest**|  | [optional] 

### Return type

**CreateListingAiImageResponse**

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

<a name="createlistingaiimageprompt"></a>
# **CreateListingAiImagePrompt**
> CreateListingAiImagePromptResponse CreateListingAiImagePrompt (CreateListingAiImagePromptRequest createListingAiImagePromptRequest = null)

Build the AI product-photo prompt for a listing (no image is generated).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateListingAiImagePromptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var createListingAiImagePromptRequest = new CreateListingAiImagePromptRequest(); // CreateListingAiImagePromptRequest |  (optional) 

            try
            {
                // Build the AI product-photo prompt for a listing (no image is generated).
                CreateListingAiImagePromptResponse result = apiInstance.CreateListingAiImagePrompt(createListingAiImagePromptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.CreateListingAiImagePrompt: " + e.Message );
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
 **createListingAiImagePromptRequest** | **CreateListingAiImagePromptRequest**|  | [optional] 

### Return type

**CreateListingAiImagePromptResponse**

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

<a name="deleteaikey"></a>
# **DeleteAiKey**
> SuccessResponse DeleteAiKey (string provider = null)

Remove the store's BYO-key for a provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var provider = "custom";  // string |  (optional) 

            try
            {
                // Remove the store's BYO-key for a provider.
                SuccessResponse result = apiInstance.DeleteAiKey(provider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.DeleteAiKey: " + e.Message );
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
 **provider** | **string**|  | [optional] 

### Return type

**SuccessResponse**

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

<a name="deleteaikeybyid"></a>
# **DeleteAiKeyById**
> SuccessResponse DeleteAiKeyById (string id)

Disconnect an AI provider key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteAiKeyByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Disconnect an AI provider key.
                SuccessResponse result = apiInstance.DeleteAiKeyById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.DeleteAiKeyById: " + e.Message );
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

**SuccessResponse**

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

<a name="getaikey"></a>
# **GetAiKey**
> GetAiKeyResponse GetAiKey ()

The store's AI provider keys with their scopes and priority (never the key).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);

            try
            {
                // The store's AI provider keys with their scopes and priority (never the key).
                GetAiKeyResponse result = apiInstance.GetAiKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.GetAiKey: " + e.Message );
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

**GetAiKeyResponse**

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

<a name="getaiprovider"></a>
# **GetAiProvider**
> GetAiProviderResponse GetAiProvider ()

Static catalog of supported AI providers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAiProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);

            try
            {
                // Static catalog of supported AI providers.
                GetAiProviderResponse result = apiInstance.GetAiProvider();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.GetAiProvider: " + e.Message );
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

**GetAiProviderResponse**

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

<a name="getairouting"></a>
# **GetAiRouting**
> GetAiRoutingResponse GetAiRouting ()

Which AI provider serves each feature of the store, in order, and whether it is on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAiRoutingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);

            try
            {
                // Which AI provider serves each feature of the store, in order, and whether it is on.
                GetAiRoutingResponse result = apiInstance.GetAiRouting();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.GetAiRouting: " + e.Message );
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

**GetAiRoutingResponse**

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

<a name="getaistatus"></a>
# **GetAiStatus**
> GetAiStatusResponse GetAiStatus ()

BYO-key state for the calling user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetAiStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);

            try
            {
                // BYO-key state for the calling user.
                GetAiStatusResponse result = apiInstance.GetAiStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.GetAiStatus: " + e.Message );
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

**GetAiStatusResponse**

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

<a name="updateaiimageconfig"></a>
# **UpdateAiImageConfig**
> UpdateAiImageConfigResponse UpdateAiImageConfig (UpdateAiImageConfigRequest updateAiImageConfigRequest = null)

Choose the AI image provider/model, independently of the text provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAiImageConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var updateAiImageConfigRequest = new UpdateAiImageConfigRequest(); // UpdateAiImageConfigRequest |  (optional) 

            try
            {
                // Choose the AI image provider/model, independently of the text provider.
                UpdateAiImageConfigResponse result = apiInstance.UpdateAiImageConfig(updateAiImageConfigRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.UpdateAiImageConfig: " + e.Message );
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
 **updateAiImageConfigRequest** | **UpdateAiImageConfigRequest**|  | [optional] 

### Return type

**UpdateAiImageConfigResponse**

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

<a name="updateaikey"></a>
# **UpdateAiKey**
> SuccessResponse UpdateAiKey (UpdateAiKeyRequest updateAiKeyRequest)

Save a BYO-key for an AI provider on the store and make it the store's default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var updateAiKeyRequest = new UpdateAiKeyRequest(); // UpdateAiKeyRequest | 

            try
            {
                // Save a BYO-key for an AI provider on the store and make it the store's default.
                SuccessResponse result = apiInstance.UpdateAiKey(updateAiKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.UpdateAiKey: " + e.Message );
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
 **updateAiKeyRequest** | **UpdateAiKeyRequest**|  | 

### Return type

**SuccessResponse**

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

<a name="updateaikeybyid"></a>
# **UpdateAiKeyById**
> CreateAiKeyResponse UpdateAiKeyById (string id, UpdateAiKeyByIdRequest updateAiKeyByIdRequest = null)

Edit an AI key: replace it, rename it, or change its scopes, priority and models.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAiKeyByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var id = "id_example";  // string | 
            var updateAiKeyByIdRequest = new UpdateAiKeyByIdRequest(); // UpdateAiKeyByIdRequest |  (optional) 

            try
            {
                // Edit an AI key: replace it, rename it, or change its scopes, priority and models.
                CreateAiKeyResponse result = apiInstance.UpdateAiKeyById(id, updateAiKeyByIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.UpdateAiKeyById: " + e.Message );
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
 **updateAiKeyByIdRequest** | **UpdateAiKeyByIdRequest**|  | [optional] 

### Return type

**CreateAiKeyResponse**

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

<a name="updateairouting"></a>
# **UpdateAiRouting**
> UpdateAiRoutingResponse UpdateAiRouting (string scope, UpdateAiRoutingRequest updateAiRoutingRequest = null)

Set one AI feature's provider chain, model or on/off.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateAiRoutingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AIApi(config);
            var scope = "scope_example";  // string | 
            var updateAiRoutingRequest = new UpdateAiRoutingRequest(); // UpdateAiRoutingRequest |  (optional) 

            try
            {
                // Set one AI feature's provider chain, model or on/off.
                UpdateAiRoutingResponse result = apiInstance.UpdateAiRouting(scope, updateAiRoutingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.UpdateAiRouting: " + e.Message );
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
 **scope** | **string**|  | 
 **updateAiRoutingRequest** | **UpdateAiRoutingRequest**|  | [optional] 

### Return type

**UpdateAiRoutingResponse**

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

