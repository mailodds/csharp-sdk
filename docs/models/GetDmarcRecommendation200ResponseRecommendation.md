# MailOdds.Model.GetDmarcRecommendation200ResponseRecommendation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentPolicy** | **string** | Current DMARC policy (none, quarantine, reject) | [optional] 
**RecommendedPolicy** | **string** | Recommended DMARC policy | [optional] 
**Confidence** | **decimal** | Confidence level (0-1) | [optional] 
**Reasons** | **List&lt;string&gt;** | Reasons for the recommendation | [optional] 
**ReadyToUpgrade** | **bool** | Whether it is safe to upgrade | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

