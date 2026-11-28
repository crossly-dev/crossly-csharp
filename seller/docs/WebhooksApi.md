# net.crossly.Api.WebhooksApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](WebhooksApi.md#createwebhook) | **POST** /v1/webhooks | Register a webhook of any type (kind: json|slack|discord|teams|telegram|google_chat|mattermost|zapier; default json). eventDelivery false &#x3D; automation only (notify.* steps). Returns the signing secret once (json).
[**CreateWebhookDeliveryRedeliver**](WebhooksApi.md#createwebhookdeliveryredeliver) | **POST** /v1/webhooks/{id}/deliveries/{deliveryId}/redeliver | Redeliver one past delivery: a new delivery (new Crossly-Delivery-Id) of the same event id and payload.
[**CreateWebhookRotateSecret**](WebhooksApi.md#createwebhookrotatesecret) | **POST** /v1/webhooks/{id}/rotate-secret | Rotate the signing secret of a webhook, keeping its id, events and delivery history.
[**CreateWebhookTest**](WebhooksApi.md#createwebhooktest) | **POST** /v1/webhooks/{id}/test | Fire a test to one webhook: test.ping (json/zapier) or a test message (chat types), or a sample of any event (body {\&quot;event\&quot;:\&quot;order.created\&quot;}, payload marked test: true).
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /v1/webhooks/{id} | Delete a webhook endpoint.
[**GetWebhookStream**](WebhooksApi.md#getwebhookstream) | **GET** /v1/webhooks/stream | Stream this account&#39;s webhook events as they happen (SSE).
[**ListWebhookDeliveries**](WebhooksApi.md#listwebhookdeliveries) | **GET** /v1/webhooks/{id}/deliveries | List deliveries to one webhook (30 days, newest first): event, status, attempts, last HTTP status and error, payload.
[**ListWebhookEvents**](WebhooksApi.md#listwebhookevents) | **GET** /v1/webhooks/events | List every webhook event you can subscribe to: id, group (family), label, description, and whether a workflow can start on it.
[**ListWebhookTypes**](WebhooksApi.md#listwebhooktypes) | **GET** /v1/webhooks/types | List webhook types (json, slack, discord, teams, telegram, google_chat, mattermost, zapier) with their fields and hosts.
[**ListWebhooks**](WebhooksApi.md#listwebhooks) | **GET** /v1/webhooks | List your webhooks of every type. Optional: q (url, name, label or app), status (healthy|failing|disabled), event, kind, failing&#x3D;true, page, pageSize.
[**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PATCH** /v1/webhooks/{id} | Edit a webhook: name, description, events, enabled, eventDelivery, and its destination fields (url, botToken, chatId, channel, headers). The type never changes.


<a name="createwebhook"></a>
# **CreateWebhook**
> CreateWebhookResponse CreateWebhook (CreateWebhookRequest createWebhookRequest)

Register a webhook of any type (kind: json|slack|discord|teams|telegram|google_chat|mattermost|zapier; default json). eventDelivery false = automation only (notify.* steps). Returns the signing secret once (json).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var createWebhookRequest = new CreateWebhookRequest(); // CreateWebhookRequest | 

            try
            {
                // Register a webhook of any type (kind: json|slack|discord|teams|telegram|google_chat|mattermost|zapier; default json). eventDelivery false = automation only (notify.* steps). Returns the signing secret once (json).
                CreateWebhookResponse result = apiInstance.CreateWebhook(createWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhook: " + e.Message );
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
 **createWebhookRequest** | **CreateWebhookRequest**|  | 

### Return type

**CreateWebhookResponse**

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

<a name="createwebhookdeliveryredeliver"></a>
# **CreateWebhookDeliveryRedeliver**
> CreateWebhookDeliveryRedeliverResponse CreateWebhookDeliveryRedeliver (Guid id, Guid deliveryId)

Redeliver one past delivery: a new delivery (new Crossly-Delivery-Id) of the same event id and payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWebhookDeliveryRedeliverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 
            var deliveryId = "deliveryId_example";  // Guid | 

            try
            {
                // Redeliver one past delivery: a new delivery (new Crossly-Delivery-Id) of the same event id and payload.
                CreateWebhookDeliveryRedeliverResponse result = apiInstance.CreateWebhookDeliveryRedeliver(id, deliveryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhookDeliveryRedeliver: " + e.Message );
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
 **deliveryId** | **Guid**|  | 

### Return type

**CreateWebhookDeliveryRedeliverResponse**

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

<a name="createwebhookrotatesecret"></a>
# **CreateWebhookRotateSecret**
> CreateWebhookRotateSecretResponse CreateWebhookRotateSecret (Guid id)

Rotate the signing secret of a webhook, keeping its id, events and delivery history.

Returns the new `secret` once. Every delivery from this moment on, retries of earlier deliveries included, is signed with it: update the receiver as soon as you have it. Only signed (json) webhooks have a secret; other types answer 400.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWebhookRotateSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Rotate the signing secret of a webhook, keeping its id, events and delivery history.
                CreateWebhookRotateSecretResponse result = apiInstance.CreateWebhookRotateSecret(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhookRotateSecret: " + e.Message );
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

**CreateWebhookRotateSecretResponse**

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

<a name="createwebhooktest"></a>
# **CreateWebhookTest**
> CreateWebhookTestResponse CreateWebhookTest (Guid id, CreateWebhookTestRequest createWebhookTestRequest = null)

Fire a test to one webhook: test.ping (json/zapier) or a test message (chat types), or a sample of any event (body {\"event\":\"order.created\"}, payload marked test: true).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWebhookTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 
            var createWebhookTestRequest = new CreateWebhookTestRequest(); // CreateWebhookTestRequest |  (optional) 

            try
            {
                // Fire a test to one webhook: test.ping (json/zapier) or a test message (chat types), or a sample of any event (body {\"event\":\"order.created\"}, payload marked test: true).
                CreateWebhookTestResponse result = apiInstance.CreateWebhookTest(id, createWebhookTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhookTest: " + e.Message );
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
 **createWebhookTestRequest** | **CreateWebhookTestRequest**|  | [optional] 

### Return type

**CreateWebhookTestResponse**

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

<a name="deletewebhook"></a>
# **DeleteWebhook**
> OkResponse DeleteWebhook (Guid id)

Delete a webhook endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a webhook endpoint.
                OkResponse result = apiInstance.DeleteWebhook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
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

<a name="getwebhookstream"></a>
# **GetWebhookStream**
> string GetWebhookStream ()

Stream this account's webhook events as they happen (SSE).

A long-lived text/event-stream. Each event is one `data:` line of JSON: {eventName, eventId, createdAt, payload}. Used by `crossly dev` to forward live events to a local URL without exposing the machine to the internet. Does not replay history — you see what happens from the moment you connect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWebhookStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);

            try
            {
                // Stream this account's webhook events as they happen (SSE).
                string result = apiInstance.GetWebhookStream();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookStream: " + e.Message );
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
 - **Accept**: text/event-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A server-sent event stream. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listwebhookdeliveries"></a>
# **ListWebhookDeliveries**
> ListWebhookDeliveriesResponse ListWebhookDeliveries (Guid id, string status = null, int? limit = null)

List deliveries to one webhook (30 days, newest first): event, status, attempts, last HTTP status and error, payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWebhookDeliveriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 
            var status = "pending";  // string |  (optional) 
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // List deliveries to one webhook (30 days, newest first): event, status, attempts, last HTTP status and error, payload.
                ListWebhookDeliveriesResponse result = apiInstance.ListWebhookDeliveries(id, status, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhookDeliveries: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListWebhookDeliveriesResponse**

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

<a name="listwebhookevents"></a>
# **ListWebhookEvents**
> ListWebhookEventsResponse ListWebhookEvents ()

List every webhook event you can subscribe to: id, group (family), label, description, and whether a workflow can start on it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWebhookEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);

            try
            {
                // List every webhook event you can subscribe to: id, group (family), label, description, and whether a workflow can start on it.
                ListWebhookEventsResponse result = apiInstance.ListWebhookEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhookEvents: " + e.Message );
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

**ListWebhookEventsResponse**

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

<a name="listwebhooktypes"></a>
# **ListWebhookTypes**
> ListWebhookTypesResponse ListWebhookTypes ()

List webhook types (json, slack, discord, teams, telegram, google_chat, mattermost, zapier) with their fields and hosts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWebhookTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);

            try
            {
                // List webhook types (json, slack, discord, teams, telegram, google_chat, mattermost, zapier) with their fields and hosts.
                ListWebhookTypesResponse result = apiInstance.ListWebhookTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhookTypes: " + e.Message );
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

**ListWebhookTypesResponse**

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

<a name="listwebhooks"></a>
# **ListWebhooks**
> ListWebhooksResponse ListWebhooks ()

List your webhooks of every type. Optional: q (url, name, label or app), status (healthy|failing|disabled), event, kind, failing=true, page, pageSize.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);

            try
            {
                // List your webhooks of every type. Optional: q (url, name, label or app), status (healthy|failing|disabled), event, kind, failing=true, page, pageSize.
                ListWebhooksResponse result = apiInstance.ListWebhooks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhooks: " + e.Message );
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

**ListWebhooksResponse**

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

<a name="updatewebhook"></a>
# **UpdateWebhook**
> UpdateWebhookResponse UpdateWebhook (Guid id, UpdateWebhookRequest updateWebhookRequest = null)

Edit a webhook: name, description, events, enabled, eventDelivery, and its destination fields (url, botToken, chatId, channel, headers). The type never changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 
            var updateWebhookRequest = new UpdateWebhookRequest(); // UpdateWebhookRequest |  (optional) 

            try
            {
                // Edit a webhook: name, description, events, enabled, eventDelivery, and its destination fields (url, botToken, chatId, channel, headers). The type never changes.
                UpdateWebhookResponse result = apiInstance.UpdateWebhook(id, updateWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhook: " + e.Message );
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
 **updateWebhookRequest** | **UpdateWebhookRequest**|  | [optional] 

### Return type

**UpdateWebhookResponse**

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

