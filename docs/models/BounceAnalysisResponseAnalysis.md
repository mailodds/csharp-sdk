# MailOdds.Model.BounceAnalysisResponseAnalysis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Analysis UUID | [optional] 
**DomainId** | **string** |  | [optional] 
**Period** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**TotalBounces** | **int** |  | [optional] 
**HardBounces** | **int** |  | [optional] 
**SoftBounces** | **int** |  | [optional] 
**Categories** | [**BounceAnalysisResponseAnalysisCategories**](BounceAnalysisResponseAnalysisCategories.md) |  | [optional] 
**TopDomains** | [**List&lt;BounceAnalysisResponseAnalysisTopDomainsInner&gt;**](BounceAnalysisResponseAnalysisTopDomainsInner.md) | Top bouncing recipient domains | [optional] 
**Recommendations** | **List&lt;string&gt;** | Actionable recommendations to reduce bounces | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

