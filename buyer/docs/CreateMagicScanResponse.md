# net.crossly.buyer.Model.CreateMagicScanResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** |  | 
**EbayMatch** | [**CreateMagicScanResponseEbayMatch**](CreateMagicScanResponseEbayMatch.md) |  | [optional] 
**TopHits** | [**List&lt;CreateMagicScanResponseTopHits&gt;**](CreateMagicScanResponseTopHits.md) | Unified top-10-globally list, ranked by CLIP visual similarity to  the seller&#39;s source photo. Each hit carries its origin platform. | 
**EbayHits** | [**List&lt;CreateMagicScanResponseEbayHits&gt;**](CreateMagicScanResponseEbayHits.md) | Legacy compat — UI&#39;s existing render. ebayHits now &#x3D;&#x3D; visually-  validated eBay subset; otherMatches is re-grouped from topHits. | 
**OtherMatches** | **Object** |  | 
**ImageUrls** | **List&lt;string&gt;** | Every photo the seller uploaded for this scan, primary first. | 
**VisionAspects** | **Object** | Vision-LLM aspects extracted across all photos. Populated only  when the seller has magic-list-vision-aspects enabled + a vision  provider configured. Empty otherwise. | 
**PossibleDuplicates** | [**List&lt;CreateMagicScanResponsePossibleDuplicates&gt;**](CreateMagicScanResponsePossibleDuplicates.md) | The seller&#39;s OWN listings/inventory that this scan probably duplicates  (image + fuzzy-title self-dedup). Empty when nothing matched. Drives the  \&quot;you may already have this\&quot; prompt. | 
**Cached** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

