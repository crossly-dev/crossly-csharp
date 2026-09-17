# net.crossly.buyer.Model.CreateInventoryCsvImportResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Problems** | [**List&lt;CreateInventoryCsvImportResponseProblems&gt;**](CreateInventoryCsvImportResponseProblems.md) |  | 
**ProblemCount** | **decimal** |  | 
**MaxRows** | **decimal** |  | 
**Created** | **decimal** |  | 
**Updated** | **decimal** |  | 
**Usable** | **decimal** | Rows that mapped cleanly. &#x60;created + updated&#x60; when not a dry run. | 
**TotalRows** | **decimal** |  | 
**ListingsCreated** | **decimal** |  | 
**DryRun** | **bool** | True when nothing was written — a preview pass. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

