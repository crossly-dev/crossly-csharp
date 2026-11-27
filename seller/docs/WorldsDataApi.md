# net.crossly.Api.WorldsDataApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorldExperienceDatastoreEntryIncrement**](WorldsDataApi.md#createworldexperiencedatastoreentryincrement) | **POST** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key}/increment | Atomically add &#x60;by&#x60; to a numeric key (absent counts as 0).
[**CreateWorldExperienceMemoryQueueItem**](WorldsDataApi.md#createworldexperiencememoryqueueitem) | **POST** /v1/worlds/experiences/{experienceId}/memory/queues/{queue}/items | Add an item to a MemoryStore queue (ttlSeconds ≤ 45 days, priority 0-1000).
[**CreateWorldExperienceMemoryQueueRead**](WorldsDataApi.md#createworldexperiencememoryqueueread) | **POST** /v1/worlds/experiences/{experienceId}/memory/queues/{queue}/read | Read and hide up to &#x60;count&#x60; queue items for invisibilitySeconds; remove them with the readId.
[**CreateWorldExperienceMessaging**](WorldsDataApi.md#createworldexperiencemessaging) | **POST** /v1/worlds/experiences/{experienceId}/messaging/{topic} | Publish a message (≤ 1 KB) to every live server of the experience subscribed to the topic.
[**CreateWorldExperienceOrderedEntryIncrement**](WorldsDataApi.md#createworldexperienceorderedentryincrement) | **POST** /v1/worlds/experiences/{experienceId}/ordered/{store}/entries/{key}/increment | Atomically add &#x60;by&#x60; to an OrderedStore entry.
[**DeleteWorldExperienceDatastoreEntry**](WorldsDataApi.md#deleteworldexperiencedatastoreentry) | **DELETE** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key} | Remove a key (a tombstone version; history stays readable for 30 days). Honours If-Match.
[**DeleteWorldExperienceMemoryMap**](WorldsDataApi.md#deleteworldexperiencememorymap) | **DELETE** /v1/worlds/experiences/{experienceId}/memory/maps/{map}/{key} | Remove a hash map item.
[**DeleteWorldExperienceMemoryQueueRead**](WorldsDataApi.md#deleteworldexperiencememoryqueueread) | **DELETE** /v1/worlds/experiences/{experienceId}/memory/queues/{queue}/reads/{readId} | Remove the items of one read (409 if the read lapsed).
[**DeleteWorldExperienceMemorySorted**](WorldsDataApi.md#deleteworldexperiencememorysorted) | **DELETE** /v1/worlds/experiences/{experienceId}/memory/sorted/{map}/{key} | Remove a sorted map item.
[**DeleteWorldExperienceOrderedEntry**](WorldsDataApi.md#deleteworldexperienceorderedentry) | **DELETE** /v1/worlds/experiences/{experienceId}/ordered/{store}/entries/{key} | Remove an OrderedStore entry.
[**GetWorldExperienceDataUsage**](WorldsDataApi.md#getworldexperiencedatausage) | **GET** /v1/worlds/experiences/{experienceId}/data/usage | Live quotas and usage: CCU, request budgets per minute, DataStore storage, MemoryStore memory.
[**GetWorldExperienceDatastoreEntry**](WorldsDataApi.md#getworldexperiencedatastoreentry) | **GET** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key} | The current value of a key: version (ETag \&quot;v&lt;n&gt;\&quot;), userIds and attributes.
[**GetWorldExperienceDatastoreEntryVersion**](WorldsDataApi.md#getworldexperiencedatastoreentryversion) | **GET** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key}/versions/{version} | One version of a key, including a removed one.
[**GetWorldExperienceMemoryMap**](WorldsDataApi.md#getworldexperiencememorymap) | **GET** /v1/worlds/experiences/{experienceId}/memory/maps/{map} | Items of a MemoryStore hash map (cursor-paged, unordered).
[**GetWorldExperienceMemoryMapByKey**](WorldsDataApi.md#getworldexperiencememorymapbykey) | **GET** /v1/worlds/experiences/{experienceId}/memory/maps/{map}/{key} | One MemoryStore hash map item with its version and expiry.
[**GetWorldExperienceMemoryQueue**](WorldsDataApi.md#getworldexperiencememoryqueue) | **GET** /v1/worlds/experiences/{experienceId}/memory/queues/{queue} | Queue length (visible, in flight) and the head, without hiding anything.
[**GetWorldExperienceMemorySorted**](WorldsDataApi.md#getworldexperiencememorysorted) | **GET** /v1/worlds/experiences/{experienceId}/memory/sorted/{map} | A MemoryStore sorted map in order (sortKey, then key); ?order&#x3D;&amp;cursor&#x3D;&amp;limit&#x3D;.
[**GetWorldExperienceMemorySortedByKey**](WorldsDataApi.md#getworldexperiencememorysortedbykey) | **GET** /v1/worlds/experiences/{experienceId}/memory/sorted/{map}/{key} | One sorted map item.
[**GetWorldExperienceOrdered**](WorldsDataApi.md#getworldexperienceordered) | **GET** /v1/worlds/experiences/{experienceId}/ordered/{store} | An OrderedStore page ranked by value; ?order&#x3D;desc|asc&amp;min&#x3D;&amp;max&#x3D;&amp;cursor&#x3D;&amp;limit&#x3D;.
[**GetWorldExperienceOrderedEntry**](WorldsDataApi.md#getworldexperienceorderedentry) | **GET** /v1/worlds/experiences/{experienceId}/ordered/{store}/entries/{key} | One OrderedStore entry.
[**ListWorldExperienceDatastoreEntries**](WorldsDataApi.md#listworldexperiencedatastoreentries) | **GET** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries | Keys of a DataStore in key order; ?prefix&#x3D;&amp;scope&#x3D;&amp;cursor&#x3D;&amp;limit&#x3D;.
[**ListWorldExperienceDatastoreEntryVersions**](WorldsDataApi.md#listworldexperiencedatastoreentryversions) | **GET** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key}/versions | Versions of a key, newest first (30-day history; the current version is kept).
[**ListWorldExperienceDatastores**](WorldsDataApi.md#listworldexperiencedatastores) | **GET** /v1/worlds/experiences/{experienceId}/datastores | The DataStores of an experience, with key counts and bytes.
[**UpdateWorldExperienceDatastoreEntry**](WorldsDataApi.md#updateworldexperiencedatastoreentry) | **PUT** /v1/worlds/experiences/{experienceId}/datastores/{store}/entries/{key} | Write a new version. If-Match \&quot;v&lt;n&gt;\&quot; (or ifVersion) writes only at that version; If-None-Match: * only if absent. 412 on a mismatch.
[**UpdateWorldExperienceMemoryMap**](WorldsDataApi.md#updateworldexperiencememorymap) | **PUT** /v1/worlds/experiences/{experienceId}/memory/maps/{map}/{key} | Set a hash map item (ttlSeconds required; ifVersion for compare-and-set).
[**UpdateWorldExperienceMemorySorted**](WorldsDataApi.md#updateworldexperiencememorysorted) | **PUT** /v1/worlds/experiences/{experienceId}/memory/sorted/{map}/{key} | Set a sorted map item (ttlSeconds, optional sortKey and ifVersion).
[**UpdateWorldExperienceOrderedEntry**](WorldsDataApi.md#updateworldexperienceorderedentry) | **PUT** /v1/worlds/experiences/{experienceId}/ordered/{store}/entries/{key} | Set an OrderedStore entry to a whole number.


<a name="createworldexperiencedatastoreentryincrement"></a>
# **CreateWorldExperienceDatastoreEntryIncrement**
> CreateWorldExperienceDatastoreEntryIncrementResponse CreateWorldExperienceDatastoreEntryIncrement (string experienceId, string store, string key)

Atomically add `by` to a numeric key (absent counts as 0).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceDatastoreEntryIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Atomically add `by` to a numeric key (absent counts as 0).
                CreateWorldExperienceDatastoreEntryIncrementResponse result = apiInstance.CreateWorldExperienceDatastoreEntryIncrement(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.CreateWorldExperienceDatastoreEntryIncrement: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**CreateWorldExperienceDatastoreEntryIncrementResponse**

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

<a name="createworldexperiencememoryqueueitem"></a>
# **CreateWorldExperienceMemoryQueueItem**
> CreateWorldPartyInviteResponse CreateWorldExperienceMemoryQueueItem (string experienceId, string queue)

Add an item to a MemoryStore queue (ttlSeconds ≤ 45 days, priority 0-1000).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceMemoryQueueItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var queue = "queue_example";  // string | 

            try
            {
                // Add an item to a MemoryStore queue (ttlSeconds ≤ 45 days, priority 0-1000).
                CreateWorldPartyInviteResponse result = apiInstance.CreateWorldExperienceMemoryQueueItem(experienceId, queue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.CreateWorldExperienceMemoryQueueItem: " + e.Message );
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
 **experienceId** | **string**|  | 
 **queue** | **string**|  | 

### Return type

**CreateWorldPartyInviteResponse**

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

<a name="createworldexperiencememoryqueueread"></a>
# **CreateWorldExperienceMemoryQueueRead**
> CreateWorldExperienceMemoryQueueReadResponse CreateWorldExperienceMemoryQueueRead (string experienceId, string queue)

Read and hide up to `count` queue items for invisibilitySeconds; remove them with the readId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceMemoryQueueReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var queue = "queue_example";  // string | 

            try
            {
                // Read and hide up to `count` queue items for invisibilitySeconds; remove them with the readId.
                CreateWorldExperienceMemoryQueueReadResponse result = apiInstance.CreateWorldExperienceMemoryQueueRead(experienceId, queue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.CreateWorldExperienceMemoryQueueRead: " + e.Message );
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
 **experienceId** | **string**|  | 
 **queue** | **string**|  | 

### Return type

**CreateWorldExperienceMemoryQueueReadResponse**

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

<a name="createworldexperiencemessaging"></a>
# **CreateWorldExperienceMessaging**
> CreateWorldExperienceMessagingResponse CreateWorldExperienceMessaging (string experienceId, string topic)

Publish a message (≤ 1 KB) to every live server of the experience subscribed to the topic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceMessagingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var topic = "topic_example";  // string | 

            try
            {
                // Publish a message (≤ 1 KB) to every live server of the experience subscribed to the topic.
                CreateWorldExperienceMessagingResponse result = apiInstance.CreateWorldExperienceMessaging(experienceId, topic);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.CreateWorldExperienceMessaging: " + e.Message );
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
 **experienceId** | **string**|  | 
 **topic** | **string**|  | 

### Return type

**CreateWorldExperienceMessagingResponse**

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

<a name="createworldexperienceorderedentryincrement"></a>
# **CreateWorldExperienceOrderedEntryIncrement**
> WorldExperienceOrderedEntryResponse CreateWorldExperienceOrderedEntryIncrement (string experienceId, string store, string key)

Atomically add `by` to an OrderedStore entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperienceOrderedEntryIncrementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Atomically add `by` to an OrderedStore entry.
                WorldExperienceOrderedEntryResponse result = apiInstance.CreateWorldExperienceOrderedEntryIncrement(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.CreateWorldExperienceOrderedEntryIncrement: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**WorldExperienceOrderedEntryResponse**

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

<a name="deleteworldexperiencedatastoreentry"></a>
# **DeleteWorldExperienceDatastoreEntry**
> DeleteWorldExperienceDatastoreEntryResponse DeleteWorldExperienceDatastoreEntry (string experienceId, string store, string key)

Remove a key (a tombstone version; history stays readable for 30 days). Honours If-Match.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceDatastoreEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Remove a key (a tombstone version; history stays readable for 30 days). Honours If-Match.
                DeleteWorldExperienceDatastoreEntryResponse result = apiInstance.DeleteWorldExperienceDatastoreEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.DeleteWorldExperienceDatastoreEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**DeleteWorldExperienceDatastoreEntryResponse**

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

<a name="deleteworldexperiencememorymap"></a>
# **DeleteWorldExperienceMemoryMap**
> DeleteSpatialSceneGrantResponse DeleteWorldExperienceMemoryMap (string experienceId, string map, string key)

Remove a hash map item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceMemoryMapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Remove a hash map item.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteWorldExperienceMemoryMap(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.DeleteWorldExperienceMemoryMap: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**DeleteSpatialSceneGrantResponse**

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

<a name="deleteworldexperiencememoryqueueread"></a>
# **DeleteWorldExperienceMemoryQueueRead**
> DeleteSpatialSceneNodeResponse DeleteWorldExperienceMemoryQueueRead (string experienceId, string queue, string readId)

Remove the items of one read (409 if the read lapsed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceMemoryQueueReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var queue = "queue_example";  // string | 
            var readId = "readId_example";  // string | 

            try
            {
                // Remove the items of one read (409 if the read lapsed).
                DeleteSpatialSceneNodeResponse result = apiInstance.DeleteWorldExperienceMemoryQueueRead(experienceId, queue, readId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.DeleteWorldExperienceMemoryQueueRead: " + e.Message );
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
 **experienceId** | **string**|  | 
 **queue** | **string**|  | 
 **readId** | **string**|  | 

### Return type

**DeleteSpatialSceneNodeResponse**

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

<a name="deleteworldexperiencememorysorted"></a>
# **DeleteWorldExperienceMemorySorted**
> DeleteSpatialSceneGrantResponse DeleteWorldExperienceMemorySorted (string experienceId, string map, string key)

Remove a sorted map item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceMemorySortedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Remove a sorted map item.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteWorldExperienceMemorySorted(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.DeleteWorldExperienceMemorySorted: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**DeleteSpatialSceneGrantResponse**

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

<a name="deleteworldexperienceorderedentry"></a>
# **DeleteWorldExperienceOrderedEntry**
> DeleteWorldExperienceOrderedEntryResponse DeleteWorldExperienceOrderedEntry (string experienceId, string store, string key)

Remove an OrderedStore entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldExperienceOrderedEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Remove an OrderedStore entry.
                DeleteWorldExperienceOrderedEntryResponse result = apiInstance.DeleteWorldExperienceOrderedEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.DeleteWorldExperienceOrderedEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**DeleteWorldExperienceOrderedEntryResponse**

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

<a name="getworldexperiencedatausage"></a>
# **GetWorldExperienceDataUsage**
> GetWorldExperienceDataUsageResponse GetWorldExperienceDataUsage (string experienceId)

Live quotas and usage: CCU, request budgets per minute, DataStore storage, MemoryStore memory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceDataUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // Live quotas and usage: CCU, request budgets per minute, DataStore storage, MemoryStore memory.
                GetWorldExperienceDataUsageResponse result = apiInstance.GetWorldExperienceDataUsage(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceDataUsage: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**GetWorldExperienceDataUsageResponse**

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

<a name="getworldexperiencedatastoreentry"></a>
# **GetWorldExperienceDatastoreEntry**
> GetWorldExperienceDatastoreEntryResponse GetWorldExperienceDatastoreEntry (string experienceId, string store, string key)

The current value of a key: version (ETag \"v<n>\"), userIds and attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceDatastoreEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // The current value of a key: version (ETag \"v<n>\"), userIds and attributes.
                GetWorldExperienceDatastoreEntryResponse result = apiInstance.GetWorldExperienceDatastoreEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceDatastoreEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**GetWorldExperienceDatastoreEntryResponse**

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

<a name="getworldexperiencedatastoreentryversion"></a>
# **GetWorldExperienceDatastoreEntryVersion**
> GetWorldExperienceDatastoreEntryResponse GetWorldExperienceDatastoreEntryVersion (string experienceId, string store, string key, string version)

One version of a key, including a removed one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceDatastoreEntryVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 
            var version = "version_example";  // string | 

            try
            {
                // One version of a key, including a removed one.
                GetWorldExperienceDatastoreEntryResponse result = apiInstance.GetWorldExperienceDatastoreEntryVersion(experienceId, store, key, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceDatastoreEntryVersion: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 
 **version** | **string**|  | 

### Return type

**GetWorldExperienceDatastoreEntryResponse**

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

<a name="getworldexperiencememorymap"></a>
# **GetWorldExperienceMemoryMap**
> GetWorldExperienceMemoryMapResponse GetWorldExperienceMemoryMap (string experienceId, string map)

Items of a MemoryStore hash map (cursor-paged, unordered).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceMemoryMapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 

            try
            {
                // Items of a MemoryStore hash map (cursor-paged, unordered).
                GetWorldExperienceMemoryMapResponse result = apiInstance.GetWorldExperienceMemoryMap(experienceId, map);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceMemoryMap: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 

### Return type

**GetWorldExperienceMemoryMapResponse**

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

<a name="getworldexperiencememorymapbykey"></a>
# **GetWorldExperienceMemoryMapByKey**
> GetWorldExperienceMemoryMapByKeyResponse GetWorldExperienceMemoryMapByKey (string experienceId, string map, string key)

One MemoryStore hash map item with its version and expiry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceMemoryMapByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // One MemoryStore hash map item with its version and expiry.
                GetWorldExperienceMemoryMapByKeyResponse result = apiInstance.GetWorldExperienceMemoryMapByKey(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceMemoryMapByKey: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**GetWorldExperienceMemoryMapByKeyResponse**

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

<a name="getworldexperiencememoryqueue"></a>
# **GetWorldExperienceMemoryQueue**
> GetWorldExperienceMemoryQueueResponse GetWorldExperienceMemoryQueue (string experienceId, string queue)

Queue length (visible, in flight) and the head, without hiding anything.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceMemoryQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var queue = "queue_example";  // string | 

            try
            {
                // Queue length (visible, in flight) and the head, without hiding anything.
                GetWorldExperienceMemoryQueueResponse result = apiInstance.GetWorldExperienceMemoryQueue(experienceId, queue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceMemoryQueue: " + e.Message );
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
 **experienceId** | **string**|  | 
 **queue** | **string**|  | 

### Return type

**GetWorldExperienceMemoryQueueResponse**

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

<a name="getworldexperiencememorysorted"></a>
# **GetWorldExperienceMemorySorted**
> GetWorldExperienceMemoryMapResponse GetWorldExperienceMemorySorted (string experienceId, string map)

A MemoryStore sorted map in order (sortKey, then key); ?order=&cursor=&limit=.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceMemorySortedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 

            try
            {
                // A MemoryStore sorted map in order (sortKey, then key); ?order=&cursor=&limit=.
                GetWorldExperienceMemoryMapResponse result = apiInstance.GetWorldExperienceMemorySorted(experienceId, map);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceMemorySorted: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 

### Return type

**GetWorldExperienceMemoryMapResponse**

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

<a name="getworldexperiencememorysortedbykey"></a>
# **GetWorldExperienceMemorySortedByKey**
> GetWorldExperienceMemoryMapByKeyResponse GetWorldExperienceMemorySortedByKey (string experienceId, string map, string key)

One sorted map item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceMemorySortedByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // One sorted map item.
                GetWorldExperienceMemoryMapByKeyResponse result = apiInstance.GetWorldExperienceMemorySortedByKey(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceMemorySortedByKey: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**GetWorldExperienceMemoryMapByKeyResponse**

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

<a name="getworldexperienceordered"></a>
# **GetWorldExperienceOrdered**
> GetWorldExperienceOrderedResponse GetWorldExperienceOrdered (string experienceId, string store)

An OrderedStore page ranked by value; ?order=desc|asc&min=&max=&cursor=&limit=.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceOrderedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 

            try
            {
                // An OrderedStore page ranked by value; ?order=desc|asc&min=&max=&cursor=&limit=.
                GetWorldExperienceOrderedResponse result = apiInstance.GetWorldExperienceOrdered(experienceId, store);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceOrdered: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 

### Return type

**GetWorldExperienceOrderedResponse**

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

<a name="getworldexperienceorderedentry"></a>
# **GetWorldExperienceOrderedEntry**
> WorldExperienceOrderedEntryResponse GetWorldExperienceOrderedEntry (string experienceId, string store, string key)

One OrderedStore entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldExperienceOrderedEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // One OrderedStore entry.
                WorldExperienceOrderedEntryResponse result = apiInstance.GetWorldExperienceOrderedEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.GetWorldExperienceOrderedEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**WorldExperienceOrderedEntryResponse**

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

<a name="listworldexperiencedatastoreentries"></a>
# **ListWorldExperienceDatastoreEntries**
> ListWorldExperienceDatastoreEntriesResponse ListWorldExperienceDatastoreEntries (string experienceId, string store)

Keys of a DataStore in key order; ?prefix=&scope=&cursor=&limit=.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceDatastoreEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 

            try
            {
                // Keys of a DataStore in key order; ?prefix=&scope=&cursor=&limit=.
                ListWorldExperienceDatastoreEntriesResponse result = apiInstance.ListWorldExperienceDatastoreEntries(experienceId, store);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.ListWorldExperienceDatastoreEntries: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 

### Return type

**ListWorldExperienceDatastoreEntriesResponse**

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

<a name="listworldexperiencedatastoreentryversions"></a>
# **ListWorldExperienceDatastoreEntryVersions**
> ListWorldExperienceDatastoreEntryVersionsResponse ListWorldExperienceDatastoreEntryVersions (string experienceId, string store, string key)

Versions of a key, newest first (30-day history; the current version is kept).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceDatastoreEntryVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Versions of a key, newest first (30-day history; the current version is kept).
                ListWorldExperienceDatastoreEntryVersionsResponse result = apiInstance.ListWorldExperienceDatastoreEntryVersions(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.ListWorldExperienceDatastoreEntryVersions: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**ListWorldExperienceDatastoreEntryVersionsResponse**

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

<a name="listworldexperiencedatastores"></a>
# **ListWorldExperienceDatastores**
> ListWorldExperienceDatastoresResponse ListWorldExperienceDatastores (string experienceId)

The DataStores of an experience, with key counts and bytes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperienceDatastoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 

            try
            {
                // The DataStores of an experience, with key counts and bytes.
                ListWorldExperienceDatastoresResponse result = apiInstance.ListWorldExperienceDatastores(experienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.ListWorldExperienceDatastores: " + e.Message );
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
 **experienceId** | **string**|  | 

### Return type

**ListWorldExperienceDatastoresResponse**

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

<a name="updateworldexperiencedatastoreentry"></a>
# **UpdateWorldExperienceDatastoreEntry**
> UpdateWorldExperienceDatastoreEntryResponse UpdateWorldExperienceDatastoreEntry (string experienceId, string store, string key)

Write a new version. If-Match \"v<n>\" (or ifVersion) writes only at that version; If-None-Match: * only if absent. 412 on a mismatch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceDatastoreEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Write a new version. If-Match \"v<n>\" (or ifVersion) writes only at that version; If-None-Match: * only if absent. 412 on a mismatch.
                UpdateWorldExperienceDatastoreEntryResponse result = apiInstance.UpdateWorldExperienceDatastoreEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.UpdateWorldExperienceDatastoreEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**UpdateWorldExperienceDatastoreEntryResponse**

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

<a name="updateworldexperiencememorymap"></a>
# **UpdateWorldExperienceMemoryMap**
> UpdateWorldExperienceMemoryMapResponse UpdateWorldExperienceMemoryMap (string experienceId, string map, string key)

Set a hash map item (ttlSeconds required; ifVersion for compare-and-set).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceMemoryMapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Set a hash map item (ttlSeconds required; ifVersion for compare-and-set).
                UpdateWorldExperienceMemoryMapResponse result = apiInstance.UpdateWorldExperienceMemoryMap(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.UpdateWorldExperienceMemoryMap: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**UpdateWorldExperienceMemoryMapResponse**

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

<a name="updateworldexperiencememorysorted"></a>
# **UpdateWorldExperienceMemorySorted**
> UpdateWorldExperienceMemoryMapResponse UpdateWorldExperienceMemorySorted (string experienceId, string map, string key)

Set a sorted map item (ttlSeconds, optional sortKey and ifVersion).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceMemorySortedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var map = "map_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Set a sorted map item (ttlSeconds, optional sortKey and ifVersion).
                UpdateWorldExperienceMemoryMapResponse result = apiInstance.UpdateWorldExperienceMemorySorted(experienceId, map, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.UpdateWorldExperienceMemorySorted: " + e.Message );
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
 **experienceId** | **string**|  | 
 **map** | **string**|  | 
 **key** | **string**|  | 

### Return type

**UpdateWorldExperienceMemoryMapResponse**

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

<a name="updateworldexperienceorderedentry"></a>
# **UpdateWorldExperienceOrderedEntry**
> WorldExperienceOrderedEntryResponse UpdateWorldExperienceOrderedEntry (string experienceId, string store, string key)

Set an OrderedStore entry to a whole number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperienceOrderedEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsDataApi(config);
            var experienceId = "experienceId_example";  // string | 
            var store = "store_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Set an OrderedStore entry to a whole number.
                WorldExperienceOrderedEntryResponse result = apiInstance.UpdateWorldExperienceOrderedEntry(experienceId, store, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsDataApi.UpdateWorldExperienceOrderedEntry: " + e.Message );
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
 **experienceId** | **string**|  | 
 **store** | **string**|  | 
 **key** | **string**|  | 

### Return type

**WorldExperienceOrderedEntryResponse**

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

