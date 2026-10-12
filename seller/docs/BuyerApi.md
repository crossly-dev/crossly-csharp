# net.crossly.Api.BuyerApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSpatialAuctionRoomBid**](BuyerApi.md#createspatialauctionroombid) | **POST** /v1/spatial/auction/rooms/{sceneId}/bid | Bid on the lot currently up in a room.


<a name="createspatialauctionroombid"></a>
# **CreateSpatialAuctionRoomBid**
> CreateSpatialAuctionRoomBidResponse CreateSpatialAuctionRoomBid (Guid sceneId)

Bid on the lot currently up in a room.

Bids on whatever the auctioneer has up RIGHT NOW. Pass `lotId` to say which lot you believe that is: it is checked against the rostrum rather than used in its place, and a mismatch answers 409 with the lot that is actually up, so a stale catalogue cannot buy you something you never looked at. `amountCents` is CENTS and must be at least the room state's `minimumNextBidCents` — do not compute that yourself, because the opening bid on a lot is floored at the START price rather than start + step. Below it you get 400 `bid_too_low` carrying `details.minimumNextBidCents`, which is the figure the transaction itself used; raise to that and retry. THIS AUCTION HOUSE SELLS DIGITAL GOODS ONLY. A physical lot is refused 403 `forbidden` with `details.reason: \"physical_lot\"`, checked against the listing on every single bid rather than once when the room was set up. Bids by one person on one lot are throttled to a few per second — 429 `bidding_too_fast` carries `retryInSeconds`. A hammered or skipped lot answers 409 `lot_closed`. A room you may not enter answers 404, the same as one that does not exist. Success is the bid RECORDED, not the lot won: the reply names the topic the price moves on, and somebody may outbid you on the next frame.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialAuctionRoomBidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var sceneId = "sceneId_example";  // Guid | 

            try
            {
                // Bid on the lot currently up in a room.
                CreateSpatialAuctionRoomBidResponse result = apiInstance.CreateSpatialAuctionRoomBid(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateSpatialAuctionRoomBid: " + e.Message );
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
 **sceneId** | **Guid**|  | 

### Return type

**CreateSpatialAuctionRoomBidResponse**

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

