# net.crossly.Api.BrandDropsApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrandDrop**](BrandDropsApi.md#createbranddrop) | **POST** /v1/brand-drops | Create a brand drop as a draft (name, dropAt in the future, optional description, cover image and Crossly platform-listing ids). Approved partners only (403 drop_partner_required); counts against your monthly allowance (403 drop_quota_exhausted).
[**GetBrandDrop**](BrandDropsApi.md#getbranddrop) | **GET** /v1/brand-drops/{id} | One of your brand drops, with its status and any note from Crossly’s review.
[**GetBrandDropPartner**](BrandDropsApi.md#getbranddroppartner) | **GET** /v1/brand-drops/partner | Your drop-partner terms (fee, promotion tier, monthly allowance, whether you may schedule without review) and how many drops you have created this month. partner is null when you are not an approved partner — apply at crossly.net/drops/apply.
[**ListBrandDropListings**](BrandDropsApi.md#listbranddroplistings) | **GET** /v1/brand-drops/{id}/listings | The listings a brand drop releases when it goes live.
[**ListBrandDrops**](BrandDropsApi.md#listbranddrops) | **GET** /v1/brand-drops | Your brand drops, newest start time first. Filter with ?status&#x3D;draft|pending_review|scheduled|live|sold_out|ended|cancelled. Empty when you are not a partner.
[**UpdateBrandDrop**](BrandDropsApi.md#updatebranddrop) | **PATCH** /v1/brand-drops/{id} | Edit a brand drop and/or change its status: draft (withdraw / unschedule), pending_review (submit for review), scheduled (only with canSelfPublish — 403 drop_review_required otherwise), cancelled. Editing name, time or description of a reviewed drop sends it back to review. Live and finished drops cannot be changed.
[**UpdateBrandDropListing**](BrandDropsApi.md#updatebranddroplisting) | **PUT** /v1/brand-drops/{id}/listings | Replace the listings a brand drop releases, by master listing id (up to 100). Each must already be listed on Crossly — otherwise 400 listing_not_on_crossly naming them. Not allowed once the drop is live or finished.


<a name="createbranddrop"></a>
# **CreateBrandDrop**
> BrandDropResponse CreateBrandDrop ()

Create a brand drop as a draft (name, dropAt in the future, optional description, cover image and Crossly platform-listing ids). Approved partners only (403 drop_partner_required); counts against your monthly allowance (403 drop_quota_exhausted).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateBrandDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);

            try
            {
                // Create a brand drop as a draft (name, dropAt in the future, optional description, cover image and Crossly platform-listing ids). Approved partners only (403 drop_partner_required); counts against your monthly allowance (403 drop_quota_exhausted).
                BrandDropResponse result = apiInstance.CreateBrandDrop();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.CreateBrandDrop: " + e.Message );
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

**BrandDropResponse**

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

<a name="getbranddrop"></a>
# **GetBrandDrop**
> BrandDropResponse GetBrandDrop (Guid id)

One of your brand drops, with its status and any note from Crossly’s review.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One of your brand drops, with its status and any note from Crossly’s review.
                BrandDropResponse result = apiInstance.GetBrandDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.GetBrandDrop: " + e.Message );
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

**BrandDropResponse**

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

<a name="getbranddroppartner"></a>
# **GetBrandDropPartner**
> GetBrandDropPartnerResponse GetBrandDropPartner ()

Your drop-partner terms (fee, promotion tier, monthly allowance, whether you may schedule without review) and how many drops you have created this month. partner is null when you are not an approved partner — apply at crossly.net/drops/apply.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetBrandDropPartnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);

            try
            {
                // Your drop-partner terms (fee, promotion tier, monthly allowance, whether you may schedule without review) and how many drops you have created this month. partner is null when you are not an approved partner — apply at crossly.net/drops/apply.
                GetBrandDropPartnerResponse result = apiInstance.GetBrandDropPartner();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.GetBrandDropPartner: " + e.Message );
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

**GetBrandDropPartnerResponse**

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

<a name="listbranddroplistings"></a>
# **ListBrandDropListings**
> ListBrandDropListingsResponse ListBrandDropListings (Guid id)

The listings a brand drop releases when it goes live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandDropListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // The listings a brand drop releases when it goes live.
                ListBrandDropListingsResponse result = apiInstance.ListBrandDropListings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.ListBrandDropListings: " + e.Message );
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

**ListBrandDropListingsResponse**

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

<a name="listbranddrops"></a>
# **ListBrandDrops**
> ListBrandDropsResponse ListBrandDrops ()

Your brand drops, newest start time first. Filter with ?status=draft|pending_review|scheduled|live|sold_out|ended|cancelled. Empty when you are not a partner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListBrandDropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);

            try
            {
                // Your brand drops, newest start time first. Filter with ?status=draft|pending_review|scheduled|live|sold_out|ended|cancelled. Empty when you are not a partner.
                ListBrandDropsResponse result = apiInstance.ListBrandDrops();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.ListBrandDrops: " + e.Message );
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

**ListBrandDropsResponse**

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

<a name="updatebranddrop"></a>
# **UpdateBrandDrop**
> BrandDropResponse UpdateBrandDrop (Guid id)

Edit a brand drop and/or change its status: draft (withdraw / unschedule), pending_review (submit for review), scheduled (only with canSelfPublish — 403 drop_review_required otherwise), cancelled. Editing name, time or description of a reviewed drop sends it back to review. Live and finished drops cannot be changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Edit a brand drop and/or change its status: draft (withdraw / unschedule), pending_review (submit for review), scheduled (only with canSelfPublish — 403 drop_review_required otherwise), cancelled. Editing name, time or description of a reviewed drop sends it back to review. Live and finished drops cannot be changed.
                BrandDropResponse result = apiInstance.UpdateBrandDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.UpdateBrandDrop: " + e.Message );
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

**BrandDropResponse**

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

<a name="updatebranddroplisting"></a>
# **UpdateBrandDropListing**
> ListBrandDropListingsResponse UpdateBrandDropListing (Guid id)

Replace the listings a brand drop releases, by master listing id (up to 100). Each must already be listed on Crossly — otherwise 400 listing_not_on_crossly naming them. Not allowed once the drop is live or finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateBrandDropListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BrandDropsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Replace the listings a brand drop releases, by master listing id (up to 100). Each must already be listed on Crossly — otherwise 400 listing_not_on_crossly naming them. Not allowed once the drop is live or finished.
                ListBrandDropListingsResponse result = apiInstance.UpdateBrandDropListing(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandDropsApi.UpdateBrandDropListing: " + e.Message );
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

**ListBrandDropListingsResponse**

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

