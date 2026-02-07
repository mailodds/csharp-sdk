# MailOdds.Model.CreateJobRequest
Bulk jobs use the account's default validation policy. To use a specific policy, set it as default via the Policies API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Emails** | **List&lt;string&gt;** | List of emails to validate | 
**Dedup** | **bool** | Remove duplicate emails | [optional] [default to false]
**Metadata** | **Object** | Custom metadata for the job | [optional] 
**WebhookUrl** | **string** | URL for completion webhook | [optional] 
**IdempotencyKey** | **string** | Unique key for idempotent requests | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

