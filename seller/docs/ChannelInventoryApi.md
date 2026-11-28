# net.crossly.Api.ChannelInventoryApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteChannelAccountSetting**](ChannelInventoryApi.md#deletechannelaccountsetting) | **DELETE** /v1/channel-accounts/{accountId}/settings | Reset a platform account&#39;s settings in the store to the defaults (no cap, no buffer, sync on, end on sell-out, republish automatically).
[**DeleteChannelInventory**](ChannelInventoryApi.md#deletechannelinventory) | **DELETE** /v1/channel-inventory/{platform}/{slot} | Deprecated alias of DELETE /api/v1/channel-accounts/:accountId/settings (removed next release).
[**GetChannelAccountSetting**](ChannelInventoryApi.md#getchannelaccountsetting) | **GET** /v1/channel-accounts/{accountId}/settings | Get one platform account&#39;s inventory and restock settings in the store.
[**GetChannelInventory**](ChannelInventoryApi.md#getchannelinventory) | **GET** /v1/channel-inventory/{platform}/{slot} | Deprecated alias of GET /api/v1/channel-accounts/:accountId/settings (removed next release).
[**ListChannelAccounts**](ChannelInventoryApi.md#listchannelaccounts) | **GET** /v1/channel-accounts | List every platform account of the store with its inventory and restock settings.
[**ListChannelInventory**](ChannelInventoryApi.md#listchannelinventory) | **GET** /v1/channel-inventory | Deprecated alias of GET /api/v1/channel-accounts (removed next release).
[**UpdateChannelAccountSetting**](ChannelInventoryApi.md#updatechannelaccountsetting) | **PUT** /v1/channel-accounts/{accountId}/settings | Set a platform account&#39;s quantity cap, buffer, sync toggle, out-of-stock action, exclusions and restock auto-republish in the store (merge write).
[**UpdateChannelInventory**](ChannelInventoryApi.md#updatechannelinventory) | **PUT** /v1/channel-inventory/{platform}/{slot} | Deprecated alias of PUT /api/v1/channel-accounts/:accountId/settings (removed next release).


<a name="deletechannelaccountsetting"></a>
# **DeleteChannelAccountSetting**
> ListChannelAccountsItem DeleteChannelAccountSetting (Guid accountId)

Reset a platform account's settings in the store to the defaults (no cap, no buffer, sync on, end on sell-out, republish automatically).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteChannelAccountSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Reset a platform account's settings in the store to the defaults (no cap, no buffer, sync on, end on sell-out, republish automatically).
                ListChannelAccountsItem result = apiInstance.DeleteChannelAccountSetting(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.DeleteChannelAccountSetting: " + e.Message );
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
 **accountId** | **Guid**|  | 

### Return type

**ListChannelAccountsItem**

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

<a name="deletechannelinventory"></a>
# **DeleteChannelInventory**
> ListChannelAccountsItem DeleteChannelInventory (string platform, int slot)

Deprecated alias of DELETE /api/v1/channel-accounts/:accountId/settings (removed next release).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteChannelInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var platform = "platform_example";  // string | 
            var slot = 56;  // int | 

            try
            {
                // Deprecated alias of DELETE /api/v1/channel-accounts/:accountId/settings (removed next release).
                ListChannelAccountsItem result = apiInstance.DeleteChannelInventory(platform, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.DeleteChannelInventory: " + e.Message );
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
 **platform** | **string**|  | 
 **slot** | **int**|  | 

### Return type

**ListChannelAccountsItem**

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

<a name="getchannelaccountsetting"></a>
# **GetChannelAccountSetting**
> ListChannelAccountsItem GetChannelAccountSetting (Guid accountId)

Get one platform account's inventory and restock settings in the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetChannelAccountSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Get one platform account's inventory and restock settings in the store.
                ListChannelAccountsItem result = apiInstance.GetChannelAccountSetting(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.GetChannelAccountSetting: " + e.Message );
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
 **accountId** | **Guid**|  | 

### Return type

**ListChannelAccountsItem**

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

<a name="getchannelinventory"></a>
# **GetChannelInventory**
> ListChannelAccountsItem GetChannelInventory (string platform, int slot)

Deprecated alias of GET /api/v1/channel-accounts/:accountId/settings (removed next release).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetChannelInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var platform = "platform_example";  // string | 
            var slot = 56;  // int | 

            try
            {
                // Deprecated alias of GET /api/v1/channel-accounts/:accountId/settings (removed next release).
                ListChannelAccountsItem result = apiInstance.GetChannelInventory(platform, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.GetChannelInventory: " + e.Message );
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
 **platform** | **string**|  | 
 **slot** | **int**|  | 

### Return type

**ListChannelAccountsItem**

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

<a name="listchannelaccounts"></a>
# **ListChannelAccounts**
> ListChannelAccountsResponse ListChannelAccounts ()

List every platform account of the store with its inventory and restock settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListChannelAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);

            try
            {
                // List every platform account of the store with its inventory and restock settings.
                ListChannelAccountsResponse result = apiInstance.ListChannelAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.ListChannelAccounts: " + e.Message );
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

**ListChannelAccountsResponse**

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

<a name="listchannelinventory"></a>
# **ListChannelInventory**
> ListChannelAccountsResponse ListChannelInventory ()

Deprecated alias of GET /api/v1/channel-accounts (removed next release).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListChannelInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);

            try
            {
                // Deprecated alias of GET /api/v1/channel-accounts (removed next release).
                ListChannelAccountsResponse result = apiInstance.ListChannelInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.ListChannelInventory: " + e.Message );
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

**ListChannelAccountsResponse**

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

<a name="updatechannelaccountsetting"></a>
# **UpdateChannelAccountSetting**
> ListChannelAccountsItem UpdateChannelAccountSetting (Guid accountId, UpdateChannelInventoryRequest updateChannelInventoryRequest)

Set a platform account's quantity cap, buffer, sync toggle, out-of-stock action, exclusions and restock auto-republish in the store (merge write).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateChannelAccountSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var accountId = "accountId_example";  // Guid | 
            var updateChannelInventoryRequest = new UpdateChannelInventoryRequest(); // UpdateChannelInventoryRequest | 

            try
            {
                // Set a platform account's quantity cap, buffer, sync toggle, out-of-stock action, exclusions and restock auto-republish in the store (merge write).
                ListChannelAccountsItem result = apiInstance.UpdateChannelAccountSetting(accountId, updateChannelInventoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.UpdateChannelAccountSetting: " + e.Message );
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
 **accountId** | **Guid**|  | 
 **updateChannelInventoryRequest** | **UpdateChannelInventoryRequest**|  | 

### Return type

**ListChannelAccountsItem**

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

<a name="updatechannelinventory"></a>
# **UpdateChannelInventory**
> ListChannelAccountsItem UpdateChannelInventory (string platform, int slot, UpdateChannelInventoryRequest updateChannelInventoryRequest)

Deprecated alias of PUT /api/v1/channel-accounts/:accountId/settings (removed next release).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateChannelInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChannelInventoryApi(config);
            var platform = "platform_example";  // string | 
            var slot = 56;  // int | 
            var updateChannelInventoryRequest = new UpdateChannelInventoryRequest(); // UpdateChannelInventoryRequest | 

            try
            {
                // Deprecated alias of PUT /api/v1/channel-accounts/:accountId/settings (removed next release).
                ListChannelAccountsItem result = apiInstance.UpdateChannelInventory(platform, slot, updateChannelInventoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelInventoryApi.UpdateChannelInventory: " + e.Message );
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
 **platform** | **string**|  | 
 **slot** | **int**|  | 
 **updateChannelInventoryRequest** | **UpdateChannelInventoryRequest**|  | 

### Return type

**ListChannelAccountsItem**

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

