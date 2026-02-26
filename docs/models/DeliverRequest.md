# MailOdds.Model.DeliverRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | [**List&lt;DeliverRequestToInner&gt;**](DeliverRequestToInner.md) | List of recipient email addresses | 
**From** | **string** | Sender email address (must match sending domain) | 
**Subject** | **string** | Email subject line | 
**DomainId** | **string** | Sending domain UUID | 
**Html** | **string** | HTML email body | [optional] 
**Text** | **string** | Plain text email body | [optional] 
**ReplyTo** | **string** | Reply-to address | [optional] 
**Headers** | **Object** | Extra email headers | [optional] 
**Tags** | **List&lt;string&gt;** | Tags for categorization | [optional] 
**CampaignType** | **string** | Campaign type for JSON-LD auto-generation | [optional] 
**StructuredData** | [**DeliverRequestStructuredData**](DeliverRequestStructuredData.md) |  | [optional] 
**Options** | [**DeliverRequestOptions**](DeliverRequestOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

