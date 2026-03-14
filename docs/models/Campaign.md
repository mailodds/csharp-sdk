# MailOdds.Model.Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Campaign UUID | 
**Name** | **string** | Campaign name | 
**Status** | **string** |  | 
**ListId** | **string** | Target subscriber list UUID | 
**DomainId** | **string** | Sending domain UUID | 
**FromEmail** | **string** |  | 
**CreatedAt** | **DateTime** |  | 
**FromName** | **string** |  | [optional] 
**ReplyTo** | **string** |  | [optional] 
**ScheduledAt** | **DateTime** |  | [optional] 
**SentAt** | **DateTime** |  | [optional] 
**CancelledAt** | **DateTime** |  | [optional] 
**VariantCount** | **int** | Number of A/B variants | [optional] 
**Stats** | [**CampaignStats**](CampaignStats.md) |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

