# MailOdds.Model.Job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Name** | **string** | Job name (from metadata or auto-generated) | 
**Status** | **string** |  | 
**TotalCount** | **int** |  | 
**ProcessedCount** | **int** |  | 
**CreatedAt** | **DateTime** |  | 
**ResultsExpireAt** | **DateTime** | When job results will be purged | 
**Summary** | [**JobSummary**](JobSummary.md) |  | [optional] 
**StartedAt** | **DateTime** | When processing began. Omitted if not yet started. | [optional] 
**CompletedAt** | **DateTime** | Omitted if not yet completed. | [optional] 
**Metadata** | **Object** | Custom metadata attached at creation | [optional] 
**ErrorMessage** | **string** | Error details. Present only for failed jobs. | [optional] 
**RequestId** | **string** | Request ID from the job creation request | [optional] 
**Artifacts** | [**JobArtifacts**](JobArtifacts.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

