# MailOdds.Model.BatchDeliverRequest
Same fields as DeliverRequest but 'to' accepts up to 100 recipients.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **List&lt;string&gt;** | List of recipient email addresses (max 100) | 
**From** | **string** |  | 
**Subject** | **string** |  | 
**Html** | **string** |  | [optional] 
**Text** | **string** |  | [optional] 
**DomainId** | **string** | Sending domain UUID. Optional - - auto-resolved from the from address, or falls back to primary domain. | [optional] 
**ReplyTo** | **string** |  | [optional] 
**Headers** | **Object** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**CampaignType** | **string** |  | [optional] 
**StructuredData** | [**BatchDeliverRequestStructuredData**](BatchDeliverRequestStructuredData.md) |  | [optional] 
**Options** | **Object** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

