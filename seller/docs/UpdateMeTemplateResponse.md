# net.crossly.Model.UpdateMeTemplateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**UserId** | **string** |  | 
**Scope** | **string** |  | 
**Name** | **string** |  | 
**Notes** | **string** | Optional short blurb the seller can attach to remember what it&#39;s for. | [optional] 
**Description** | **string** | Primary description body. For scope&#x3D;&#39;description&#39; this is the  snippet body; for scope&#x3D;&#39;listing&#39; this is the default description  the seller wants pre-filled. | [optional] 
**DescriptionVariants** | **List&lt;string&gt;** | A/B variants for description. Populated for scope&#x3D;&#39;listing&#39;;  typically null for scope&#x3D;&#39;description&#39; (a snippet is one string). | [optional] 
**Title** | **string** |  | [optional] 
**TitleVariants** | **List&lt;string&gt;** |  | [optional] 
**Brand** | **string** |  | [optional] 
**Condition** | **string** | Master condition enum — new/like_new/good/fair/poor. | [optional] 
**Color** | **string** |  | [optional] 
**Material** | **string** |  | [optional] 
**Size** | **string** |  | [optional] 
**SizeSystem** | **string** |  | [optional] 
**WeightOz** | **decimal?** |  | [optional] 
**Department** | **string** |  | [optional] 
**Gender** | **string** |  | [optional] 
**Style** | **string** |  | [optional] 
**Pattern** | **string** |  | [optional] 
**ItemType** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**DefaultForCategory** | **string** | When set, form&#39;s category picker prompts \&quot;Use your default for  this category\&quot; on match. | [optional] 
**IsDefault** | **bool** |  | 
**ShareToken** | **string** | URL-safe random token. Populated by POST /me/templates/:id/share;  the /public/templates/:token route surfaces a read-only view any  visitor can browse + import. | [optional] 
**SortOrder** | **decimal** | Snippet ordering — kept for scope&#x3D;&#39;description&#39; back-compat with  the description_templates.sort_order behavior. | 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

