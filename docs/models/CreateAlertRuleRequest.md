# MailOdds.Model.CreateAlertRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metric** | **string** | Metric to monitor (e.g., bounce_rate, complaint_rate) | 
**Threshold** | **decimal** | Threshold value (0-1, e.g. 0.02 for 2%) | 
**Channel** | **string** | Notification channel (e.g., webhook) | 
**WindowMinutes** | **int** | Evaluation window in minutes (15, 60, 1440, or 2880) | [optional] [default to 60]
**Enabled** | **bool** |  | [optional] [default to true]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

