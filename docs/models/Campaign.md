# MailOdds.Model.Campaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Campaign UUID | 
**Name** | **string** | Campaign name | 
**Status** | **string** |  | 
**DomainId** | **string** | Sending domain UUID | 
**FromAddress** | **string** | Sender email address | 
**CreatedAt** | **DateTime** |  | 
**AccountId** | **int** |  | [optional] 
**Subject** | **string** |  | [optional] 
**ReplyTo** | **string** |  | [optional] 
**HtmlBody** | **string** |  | [optional] 
**TextBody** | **string** |  | [optional] 
**HtmlBodyDark** | **string** |  | [optional] 
**TextBodyDark** | **string** |  | [optional] 
**CampaignType** | **string** |  | [optional] 
**AutoDetectSchema** | **bool** |  | [optional] 
**PromoAnnotations** | **Object** |  | [optional] 
**ThrowawayPolicy** | **string** |  | [optional] 
**ScheduledAt** | **DateTime** |  | [optional] 
**StartedAt** | **DateTime** |  | [optional] 
**CompletedAt** | **DateTime** |  | [optional] 
**RecipientCount** | **int** |  | [optional] 
**IsAbTest** | **bool** |  | [optional] 
**WinningVariantId** | **string** |  | [optional] 
**AbTestConfig** | **Object** |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**Stats** | [**CampaignStats**](CampaignStats.md) |  | [optional] 
**OpenRate** | **decimal** |  | [optional] 
**ClickRate** | **decimal** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

