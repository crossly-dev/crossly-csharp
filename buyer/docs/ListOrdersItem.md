# net.crossly.buyer.Model.ListOrdersItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 
**UserId** | **string** |  | 
**Quantity** | **decimal** |  | 
**Notes** | **string** |  | [optional] 
**Status** | **string** |  | 
**Platform** | **string** |  | 
**CancelledAt** | **DateTime?** |  | [optional] 
**ListingId** | **string** |  | [optional] 
**InventoryItemId** | **string** |  | [optional] 
**PlatformListingId** | **string** |  | [optional] 
**HandlingTimeDays** | **decimal?** |  | [optional] 
**PlatformOrderId** | **string** |  | [optional] 
**BuyerUsername** | **string** |  | [optional] 
**SalesChannel** | **string** |  | 
**ChannelLocationId** | **string** |  | [optional] 
**PackagePresetId** | **string** |  | [optional] 
**Carrier** | **string** |  | [optional] 
**Service** | **string** |  | [optional] 
**TrackingNumber** | **string** |  | [optional] 
**EasypostShipmentId** | **string** |  | [optional] 
**EasypostTrackerId** | **string** |  | [optional] 
**EasypostRateId** | **string** |  | [optional] 
**ShippingLabelUrl** | **string** |  | [optional] 
**LabelPurchasedAt** | **DateTime?** |  | [optional] 
**ShippedAt** | **DateTime?** |  | [optional] 
**EstimatedDelivery** | **string** |  | [optional] 
**DeliveredAt** | **DateTime?** |  | [optional] 
**CarrierStatus** | **string** |  | [optional] 
**CarrierStatusDetail** | **string** |  | [optional] 
**TrackingHistory** | [**List&lt;ListOrdersItemTrackingHistory&gt;**](ListOrdersItemTrackingHistory.md) |  | [optional] 
**DeliveryLocation** | **string** |  | [optional] 
**DeliverySignature** | **string** |  | [optional] 
**TrackingSubmittedAt** | **DateTime?** |  | [optional] 
**TrackingSubmitStatus** | **string** |  | [optional] 
**LabelCost** | **string** |  | [optional] 
**CostOfGoods** | **string** |  | [optional] 
**RequestedCarrier** | **string** |  | [optional] 
**RequestedService** | **string** |  | [optional] 
**ShipByAt** | **DateTime?** |  | [optional] 
**ShipByAlertedAt** | **DateTime?** |  | [optional] 
**OversoldBy** | **decimal** |  | 
**LastStatusCheckAt** | **DateTime?** |  | [optional] 
**LastChatCheckAt** | **DateTime?** |  | [optional] 
**IsDisputed** | **bool** |  | 
**DisputeReason** | **string** |  | [optional] 
**DisputePlatformCaseId** | **string** |  | [optional] 
**DisputeResolvedAt** | **DateTime?** |  | [optional] 
**RefundAmount** | **string** |  | [optional] 
**RefundReason** | **string** |  | [optional] 
**RefundPlatformId** | **string** |  | [optional] 
**RefundedAt** | **DateTime?** |  | [optional] 
**CancellationReason** | **string** |  | [optional] 
**ArrivalConditionRequestedAt** | **DateTime?** |  | [optional] 
**ArrivalConditionSubmittedAt** | **DateTime?** |  | [optional] 
**ArrivalConditionDeclinedAt** | **DateTime?** |  | [optional] 
**DeliveryPhotoUrl** | **string** |  | [optional] 
**PurchaseOrderRef** | **string** |  | [optional] 
**ArrivalConditionPhotos** | **List&lt;string&gt;** |  | 
**BuyerEmail** | **string** |  | [optional] 
**FulfillmentMethod** | **string** |  | 
**DeletedAt** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

