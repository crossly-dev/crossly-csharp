# net.crossly.Api.CustomersApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomerBulkDelete**](CustomersApi.md#createcustomerbulkdelete) | **POST** /v1/customers/bulk-delete | Bulk blocklist customer handles.
[**CreateCustomerBulkExport**](CustomersApi.md#createcustomerbulkexport) | **POST** /v1/customers/bulk-export | Bulk export aggregated customers as CSV.
[**CreateCustomerRefreshProfile**](CustomersApi.md#createcustomerrefreshprofile) | **POST** /v1/customers/{handle}/refresh-profile | Queue a fresh read of a customer&#39;s buyer profiles on every platform they ordered on.
[**GetCustomer**](CustomersApi.md#getcustomer) | **GET** /v1/customers/{handle} | Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.
[**GetLoyaltyClub**](CustomersApi.md#getloyaltyclub) | **GET** /v1/loyalty/club | Your loyalty club: tiers and how many members are in each.
[**ListCustomers**](CustomersApi.md#listcustomers) | **GET** /v1/customers | List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.
[**ListLoyaltyMembers**](CustomersApi.md#listloyaltymembers) | **GET** /v1/loyalty/members | Your loyalty club’s members, by spend with you.
[**UpdateLoyaltyClub**](CustomersApi.md#updateloyaltyclub) | **PUT** /v1/loyalty/club | Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.


<a name="createcustomerbulkdelete"></a>
# **CreateCustomerBulkDelete**
> CreateCustomerBulkDeleteResponse CreateCustomerBulkDelete ()

Bulk blocklist customer handles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerBulkDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Bulk blocklist customer handles.
                CreateCustomerBulkDeleteResponse result = apiInstance.CreateCustomerBulkDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerBulkDelete: " + e.Message );
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

**CreateCustomerBulkDeleteResponse**

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

<a name="createcustomerbulkexport"></a>
# **CreateCustomerBulkExport**
> string CreateCustomerBulkExport ()

Bulk export aggregated customers as CSV.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerBulkExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Bulk export aggregated customers as CSV.
                string result = apiInstance.CreateCustomerBulkExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerBulkExport: " + e.Message );
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

**string**

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

<a name="createcustomerrefreshprofile"></a>
# **CreateCustomerRefreshProfile**
> CreateCustomerRefreshProfileResponse CreateCustomerRefreshProfile (string handle)

Queue a fresh read of a customer's buyer profiles on every platform they ordered on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCustomerRefreshProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Queue a fresh read of a customer's buyer profiles on every platform they ordered on.
                CreateCustomerRefreshProfileResponse result = apiInstance.CreateCustomerRefreshProfile(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerRefreshProfile: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**CreateCustomerRefreshProfileResponse**

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

<a name="getcustomer"></a>
# **GetCustomer**
> GetCustomerResponse GetCustomer (string handle)

Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Get one customer: recent 50 orders, buyer profiles per platform, and stats over all of their orders.
                GetCustomerResponse result = apiInstance.GetCustomer(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomer: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetCustomerResponse**

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

<a name="getloyaltyclub"></a>
# **GetLoyaltyClub**
> GetLoyaltyClubResponse GetLoyaltyClub ()

Your loyalty club: tiers and how many members are in each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetLoyaltyClubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty club: tiers and how many members are in each.
                GetLoyaltyClubResponse result = apiInstance.GetLoyaltyClub();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetLoyaltyClub: " + e.Message );
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

**GetLoyaltyClubResponse**

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

<a name="listcustomers"></a>
# **ListCustomers**
> ListCustomersResponse ListCustomers ()

List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCustomersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // List aggregated customers (group-by lower(buyer_username)), each with its best avatar, display name and star rating.
                ListCustomersResponse result = apiInstance.ListCustomers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomers: " + e.Message );
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

**ListCustomersResponse**

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

<a name="listloyaltymembers"></a>
# **ListLoyaltyMembers**
> ListLoyaltyMembersResponse ListLoyaltyMembers ()

Your loyalty club’s members, by spend with you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListLoyaltyMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Your loyalty club’s members, by spend with you.
                ListLoyaltyMembersResponse result = apiInstance.ListLoyaltyMembers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListLoyaltyMembers: " + e.Message );
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

**ListLoyaltyMembersResponse**

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

<a name="updateloyaltyclub"></a>
# **UpdateLoyaltyClub**
> GetLoyaltyClubResponse UpdateLoyaltyClub ()

Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateLoyaltyClubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);

            try
            {
                // Create or update your loyalty club: name, on/off, and up to 6 spend tiers each with a discount (≤ 30%) and perks.
                GetLoyaltyClubResponse result = apiInstance.UpdateLoyaltyClub();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateLoyaltyClub: " + e.Message );
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

**GetLoyaltyClubResponse**

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

