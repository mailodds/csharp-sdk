# MailOdds.Model.DeliverRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | [**List&lt;DeliverRequestToInner&gt;**](DeliverRequestToInner.md) | List of recipient email addresses | 
**From** | **string** | Sender email address (must match sending domain) | 
**Subject** | **string** | Email subject line | 
**Html** | **string** | HTML email body | [optional] 
**Text** | **string** | Plain text email body | [optional] 
**DomainId** | **string** | Sending domain UUID. Optional - - auto-resolved from the from address, or falls back to primary domain. | [optional] 
**ReplyTo** | **string** | Reply-to address | [optional] 
**Headers** | **Object** | Extra email headers | [optional] 
**Tags** | **List&lt;string&gt;** | Tags for categorization | [optional] 
**CampaignType** | **string** | Campaign type for JSON-LD auto-generation | [optional] 
**StructuredData** | [**DeliverRequestStructuredData**](DeliverRequestStructuredData.md) |  | [optional] 
**SchemaData** | **Dictionary&lt;string, string&gt;** | Key-value pairs for campaign_type JSON-LD resolution (e.g., order_number, tracking_url) | [optional] 
**AutoDetectSchema** | **bool** | Auto-detect JSON-LD structured data type from subject line | [optional] [default to false]
**AiSummary** | **string** | Hidden text summary for AI email assistants (max 500 characters) | [optional] 
**Options** | [**DeliverRequestOptions**](DeliverRequestOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

