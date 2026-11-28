# net.crossly.Api.WorldsPackagesApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorldExperiencePlacePackage**](WorldsPackagesApi.md#createworldexperienceplacepackage) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/packages | Insert a copy of a package (default: the newest version, auto-update on).
[**CreateWorldExperiencePlacePackageUpdate**](WorldsPackagesApi.md#createworldexperienceplacepackageupdate) | **POST** /v1/worlds/experiences/{experienceId}/places/{placeId}/packages/{nodeId}/update | Update a copy to a version (default newest). A copy edited in the place needs force: true (its edits are replaced).
[**CreateWorldPackage**](WorldsPackagesApi.md#createworldpackage) | **POST** /v1/worlds/packages | Create a package (v1) from one node (place JSON) or from a node in a place — which then becomes copy v1, auto-updating.
[**CreateWorldPackageToolbox**](WorldsPackagesApi.md#createworldpackagetoolbox) | **POST** /v1/worlds/packages/{packageId}/toolbox | List the latest version in the Toolbox as an asset of kind package (Toolbox review and pricing rules apply).
[**CreateWorldPackageVersion**](WorldsPackagesApi.md#createworldpackageversion) | **POST** /v1/worlds/packages/{packageId}/versions | Publish a new version; every auto-updating, unmodified copy in your places is updated through its co-editing session. Returns what happened per place.
[**DeleteWorldPackage**](WorldsPackagesApi.md#deleteworldpackage) | **DELETE** /v1/worlds/packages/{packageId} | Archive a package. Copies in places keep working; they just stop receiving updates.
[**GetWorldPackage**](WorldsPackagesApi.md#getworldpackage) | **GET** /v1/worlds/packages/{packageId} | A package with its versions.
[**GetWorldPackageVersion**](WorldsPackagesApi.md#getworldpackageversion) | **GET** /v1/worlds/packages/{packageId}/versions/{number} | One version, with its payload (one root node in place JSON).
[**ListWorldExperiencePlacePackages**](WorldsPackagesApi.md#listworldexperienceplacepackages) | **GET** /v1/worlds/experiences/{experienceId}/places/{placeId}/packages | Package copies in a place: version, newest version, modified, auto-update.
[**ListWorldPackages**](WorldsPackagesApi.md#listworldpackages) | **GET** /v1/worlds/packages | Your package library: reusable models and modules, newest first, with how many places hold copies.
[**UpdateWorldExperiencePlacePackage**](WorldsPackagesApi.md#updateworldexperienceplacepackage) | **PATCH** /v1/worlds/experiences/{experienceId}/places/{placeId}/packages/{nodeId} | Turn auto-update on or off for one copy.
[**UpdateWorldPackage**](WorldsPackagesApi.md#updateworldpackage) | **PATCH** /v1/worlds/packages/{packageId} | Rename a package or change its description.


<a name="createworldexperienceplacepackage"></a>
# **CreateWorldExperiencePlacePackage**
> CreateWorldExperiencePlacePackageResponse CreateWorldExperiencePlacePackage (string experienceId, string placeId, CreateWorldExperiencePlacePackageRequest createWorldExperiencePlacePackageRequest = null)

Insert a copy of a package (default: the newest version, auto-update on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlacePackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var createWorldExperiencePlacePackageRequest = new CreateWorldExperiencePlacePackageRequest(); // CreateWorldExperiencePlacePackageRequest |  (optional) 

            try
            {
                // Insert a copy of a package (default: the newest version, auto-update on).
                CreateWorldExperiencePlacePackageResponse result = apiInstance.CreateWorldExperiencePlacePackage(experienceId, placeId, createWorldExperiencePlacePackageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.CreateWorldExperiencePlacePackage: " + e.Message );
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
 **placeId** | **string**|  | 
 **createWorldExperiencePlacePackageRequest** | **CreateWorldExperiencePlacePackageRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlacePackageResponse**

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

<a name="createworldexperienceplacepackageupdate"></a>
# **CreateWorldExperiencePlacePackageUpdate**
> CreateWorldExperiencePlacePackageUpdateResponse CreateWorldExperiencePlacePackageUpdate (string experienceId, string placeId, string nodeId, CreateWorldExperiencePlacePackageUpdateRequest createWorldExperiencePlacePackageUpdateRequest = null)

Update a copy to a version (default newest). A copy edited in the place needs force: true (its edits are replaced).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldExperiencePlacePackageUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var nodeId = "nodeId_example";  // string | 
            var createWorldExperiencePlacePackageUpdateRequest = new CreateWorldExperiencePlacePackageUpdateRequest(); // CreateWorldExperiencePlacePackageUpdateRequest |  (optional) 

            try
            {
                // Update a copy to a version (default newest). A copy edited in the place needs force: true (its edits are replaced).
                CreateWorldExperiencePlacePackageUpdateResponse result = apiInstance.CreateWorldExperiencePlacePackageUpdate(experienceId, placeId, nodeId, createWorldExperiencePlacePackageUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.CreateWorldExperiencePlacePackageUpdate: " + e.Message );
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
 **placeId** | **string**|  | 
 **nodeId** | **string**|  | 
 **createWorldExperiencePlacePackageUpdateRequest** | **CreateWorldExperiencePlacePackageUpdateRequest**|  | [optional] 

### Return type

**CreateWorldExperiencePlacePackageUpdateResponse**

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

<a name="createworldpackage"></a>
# **CreateWorldPackage**
> GetWorldPackageResponse CreateWorldPackage (CreateWorldPackageRequest createWorldPackageRequest = null)

Create a package (v1) from one node (place JSON) or from a node in a place — which then becomes copy v1, auto-updating.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var createWorldPackageRequest = new CreateWorldPackageRequest(); // CreateWorldPackageRequest |  (optional) 

            try
            {
                // Create a package (v1) from one node (place JSON) or from a node in a place — which then becomes copy v1, auto-updating.
                GetWorldPackageResponse result = apiInstance.CreateWorldPackage(createWorldPackageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.CreateWorldPackage: " + e.Message );
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
 **createWorldPackageRequest** | **CreateWorldPackageRequest**|  | [optional] 

### Return type

**GetWorldPackageResponse**

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

<a name="createworldpackagetoolbox"></a>
# **CreateWorldPackageToolbox**
> CreateWorldPackageToolboxResponse CreateWorldPackageToolbox (string packageId, CreateWorldPackageToolboxRequest createWorldPackageToolboxRequest = null)

List the latest version in the Toolbox as an asset of kind package (Toolbox review and pricing rules apply).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPackageToolboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 
            var createWorldPackageToolboxRequest = new CreateWorldPackageToolboxRequest(); // CreateWorldPackageToolboxRequest |  (optional) 

            try
            {
                // List the latest version in the Toolbox as an asset of kind package (Toolbox review and pricing rules apply).
                CreateWorldPackageToolboxResponse result = apiInstance.CreateWorldPackageToolbox(packageId, createWorldPackageToolboxRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.CreateWorldPackageToolbox: " + e.Message );
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
 **packageId** | **string**|  | 
 **createWorldPackageToolboxRequest** | **CreateWorldPackageToolboxRequest**|  | [optional] 

### Return type

**CreateWorldPackageToolboxResponse**

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

<a name="createworldpackageversion"></a>
# **CreateWorldPackageVersion**
> CreateWorldPackageVersionResponse CreateWorldPackageVersion (string packageId, CreateWorldPackageVersionRequest createWorldPackageVersionRequest = null)

Publish a new version; every auto-updating, unmodified copy in your places is updated through its co-editing session. Returns what happened per place.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPackageVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 
            var createWorldPackageVersionRequest = new CreateWorldPackageVersionRequest(); // CreateWorldPackageVersionRequest |  (optional) 

            try
            {
                // Publish a new version; every auto-updating, unmodified copy in your places is updated through its co-editing session. Returns what happened per place.
                CreateWorldPackageVersionResponse result = apiInstance.CreateWorldPackageVersion(packageId, createWorldPackageVersionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.CreateWorldPackageVersion: " + e.Message );
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
 **packageId** | **string**|  | 
 **createWorldPackageVersionRequest** | **CreateWorldPackageVersionRequest**|  | [optional] 

### Return type

**CreateWorldPackageVersionResponse**

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

<a name="deleteworldpackage"></a>
# **DeleteWorldPackage**
> DeleteWorldPackageResponse DeleteWorldPackage (string packageId)

Archive a package. Copies in places keep working; they just stop receiving updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 

            try
            {
                // Archive a package. Copies in places keep working; they just stop receiving updates.
                DeleteWorldPackageResponse result = apiInstance.DeleteWorldPackage(packageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.DeleteWorldPackage: " + e.Message );
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
 **packageId** | **string**|  | 

### Return type

**DeleteWorldPackageResponse**

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

<a name="getworldpackage"></a>
# **GetWorldPackage**
> GetWorldPackageResponse GetWorldPackage (string packageId)

A package with its versions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 

            try
            {
                // A package with its versions.
                GetWorldPackageResponse result = apiInstance.GetWorldPackage(packageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.GetWorldPackage: " + e.Message );
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
 **packageId** | **string**|  | 

### Return type

**GetWorldPackageResponse**

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

<a name="getworldpackageversion"></a>
# **GetWorldPackageVersion**
> GetWorldPackageVersionResponse GetWorldPackageVersion (string packageId, string number)

One version, with its payload (one root node in place JSON).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPackageVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 
            var number = "number_example";  // string | 

            try
            {
                // One version, with its payload (one root node in place JSON).
                GetWorldPackageVersionResponse result = apiInstance.GetWorldPackageVersion(packageId, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.GetWorldPackageVersion: " + e.Message );
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
 **packageId** | **string**|  | 
 **number** | **string**|  | 

### Return type

**GetWorldPackageVersionResponse**

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

<a name="listworldexperienceplacepackages"></a>
# **ListWorldExperiencePlacePackages**
> ListWorldExperiencePlacePackagesResponse ListWorldExperiencePlacePackages (string experienceId, string placeId)

Package copies in a place: version, newest version, modified, auto-update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldExperiencePlacePackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 

            try
            {
                // Package copies in a place: version, newest version, modified, auto-update.
                ListWorldExperiencePlacePackagesResponse result = apiInstance.ListWorldExperiencePlacePackages(experienceId, placeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.ListWorldExperiencePlacePackages: " + e.Message );
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
 **placeId** | **string**|  | 

### Return type

**ListWorldExperiencePlacePackagesResponse**

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

<a name="listworldpackages"></a>
# **ListWorldPackages**
> ListWorldPackagesResponse ListWorldPackages (string archived = null)

Your package library: reusable models and modules, newest first, with how many places hold copies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var archived = "true";  // string |  (optional) 

            try
            {
                // Your package library: reusable models and modules, newest first, with how many places hold copies.
                ListWorldPackagesResponse result = apiInstance.ListWorldPackages(archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.ListWorldPackages: " + e.Message );
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

**ListWorldPackagesResponse**

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

<a name="updateworldexperienceplacepackage"></a>
# **UpdateWorldExperiencePlacePackage**
> UpdateWorldExperiencePlacePackageResponse UpdateWorldExperiencePlacePackage (string experienceId, string placeId, string nodeId, UpdateWorldExperiencePlacePackageRequest updateWorldExperiencePlacePackageRequest = null)

Turn auto-update on or off for one copy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldExperiencePlacePackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var experienceId = "experienceId_example";  // string | 
            var placeId = "placeId_example";  // string | 
            var nodeId = "nodeId_example";  // string | 
            var updateWorldExperiencePlacePackageRequest = new UpdateWorldExperiencePlacePackageRequest(); // UpdateWorldExperiencePlacePackageRequest |  (optional) 

            try
            {
                // Turn auto-update on or off for one copy.
                UpdateWorldExperiencePlacePackageResponse result = apiInstance.UpdateWorldExperiencePlacePackage(experienceId, placeId, nodeId, updateWorldExperiencePlacePackageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.UpdateWorldExperiencePlacePackage: " + e.Message );
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
 **placeId** | **string**|  | 
 **nodeId** | **string**|  | 
 **updateWorldExperiencePlacePackageRequest** | **UpdateWorldExperiencePlacePackageRequest**|  | [optional] 

### Return type

**UpdateWorldExperiencePlacePackageResponse**

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

<a name="updateworldpackage"></a>
# **UpdateWorldPackage**
> DeleteWorldPackageResponse UpdateWorldPackage (string packageId, UpdateWorldPackageRequest updateWorldPackageRequest = null)

Rename a package or change its description.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldsPackagesApi(config);
            var packageId = "packageId_example";  // string | 
            var updateWorldPackageRequest = new UpdateWorldPackageRequest(); // UpdateWorldPackageRequest |  (optional) 

            try
            {
                // Rename a package or change its description.
                DeleteWorldPackageResponse result = apiInstance.UpdateWorldPackage(packageId, updateWorldPackageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldsPackagesApi.UpdateWorldPackage: " + e.Message );
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
 **packageId** | **string**|  | 
 **updateWorldPackageRequest** | **UpdateWorldPackageRequest**|  | [optional] 

### Return type

**DeleteWorldPackageResponse**

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

