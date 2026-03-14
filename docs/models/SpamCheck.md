# MailOdds.Model.SpamCheck

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Spam check UUID | [optional] 
**FromDomain** | **string** |  | [optional] 
**Score** | **decimal** | Overall spam score (0-10, lower is better) | [optional] 
**Verdict** | **string** | Overall verdict | [optional] 
**Checks** | [**SpamCheckChecks**](SpamCheckChecks.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

