# MailOdds.Model.ValidationResult
Individual result from a bulk validation job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | 
**Status** | **string** |  | 
**Action** | **string** |  | 
**Domain** | **string** | Email domain | 
**ProcessedAt** | **DateTime** |  | 
**SubStatus** | **string** | Detailed reason. Omitted when none. | [optional] 
**MxHost** | **string** | Primary MX hostname. Omitted when not resolved. | [optional] 
**Checks** | **Dictionary&lt;string, Object&gt;** | Detailed check results (JSONB). Omitted when not available. | [optional] 
**Suppression** | [**ValidationResultSuppression**](ValidationResultSuppression.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

