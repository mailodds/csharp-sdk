# MailOdds.Model.PolicyRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Rule type determines how condition is evaluated | 
**Condition** | **Object** | Condition depends on rule type. status_override: {status}, domain_filter: {domain_mode, domains}, check_requirement: {check, required}, sub_status_override: {sub_status} | 
**Action** | [**PolicyRuleAction**](PolicyRuleAction.md) |  | 
**Id** | **int** |  | [optional] 
**Sequence** | **int** |  | [optional] 
**IsEnabled** | **bool** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

