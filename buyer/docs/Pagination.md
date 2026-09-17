# net.crossly.buyer.Model.Pagination
Present only when the endpoint pages. Absent — not null — when it returns everything.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Page** | **int** | 1-indexed page number. | 
**Limit** | **int** | Rows per page. | 
**Total** | **int** | Total matching rows, when the endpoint counts them. | [optional] 
**TotalPages** | **int** | Derived from total and limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

