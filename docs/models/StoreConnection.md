# MailOdds.Model.StoreConnection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Store connection UUID | [optional] 
**AccountId** | **int** |  | [optional] 
**Platform** | **string** | E-commerce platform | [optional] 
**StoreName** | **string** |  | [optional] 
**StoreUrl** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**AuthMethod** | **string** |  | [optional] 
**ProductCount** | **int** | Number of active products | [optional] 
**LastSyncedAt** | **DateTime** |  | [optional] 
**LastError** | **string** | Last sync error message | [optional] 
**SyncIntervalSeconds** | **int** | Auto-sync interval in seconds | [optional] [default to 3600]
**Settings** | **Object** | Platform-specific settings | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

