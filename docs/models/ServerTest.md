# MailOdds.Model.ServerTest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Test UUID | [optional] 
**Domain** | **string** | Tested domain | [optional] 
**Status** | **string** | Test status | [optional] 
**MxRecords** | [**List&lt;ServerTestMxRecordsInner&gt;**](ServerTestMxRecordsInner.md) |  | [optional] 
**SmtpCheck** | [**ServerTestSmtpCheck**](ServerTestSmtpCheck.md) |  | [optional] 
**DnsChecks** | [**ServerTestDnsChecks**](ServerTestDnsChecks.md) |  | [optional] 
**Score** | **int** | Overall server configuration score (0-100) | [optional] 
**Recommendations** | **List&lt;string&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

