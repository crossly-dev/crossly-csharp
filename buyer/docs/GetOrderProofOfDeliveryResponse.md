# net.crossly.buyer.Model.GetOrderProofOfDeliveryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** |  | 
**Platform** | **string** |  | 
**PlatformOrderId** | **string** |  | [optional] 
**ItemTitle** | **string** |  | [optional] 
**BuyerUsername** | **string** |  | [optional] 
**ShipToPostalCode** | **string** | The ZIP we shipped to, for comparison against the delivery scan. | [optional] 
**ShipToCityState** | **string** |  | [optional] 
**Carrier** | **string** |  | [optional] 
**TrackingNumber** | **string** |  | [optional] 
**TrackingUrl** | **string** |  | [optional] 
**ShippedAt** | **string** |  | [optional] 
**DeliveredAt** | **string** |  | [optional] 
**DeliveryLocation** | **string** |  | [optional] 
**Signature** | **string** | Null means the carrier captured none — NOT that delivery is unproven. | [optional] 
**Scans** | [**List&lt;GetOrderProofOfDeliveryResponseScans&gt;**](GetOrderProofOfDeliveryResponseScans.md) |  | 
**Gaps** | **List&lt;string&gt;** | Why this document is weak, stated plainly so the seller isn&#39;t surprised  by the marketplace&#39;s response. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

