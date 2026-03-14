# MailOdds.Model.BlacklistMonitor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Monitor UUID | [optional] 
**Target** | **string** | IP address or domain being monitored | [optional] 
**TargetType** | **string** |  | [optional] 
**Status** | **string** | Current status (clean, listed) | [optional] 
**ListedCount** | **int** | Number of blacklists currently listing this target | [optional] 
**LastCheckedAt** | **DateTime** |  | [optional] 
**LatestCheck** | [**BlacklistMonitorLatestCheck**](BlacklistMonitorLatestCheck.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

