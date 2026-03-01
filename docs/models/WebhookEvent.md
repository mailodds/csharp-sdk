# MailOdds.Model.WebhookEvent
Webhook payload delivered to your endpoint. Fields vary by event type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | Event type | 
**Timestamp** | **DateTime** | When the event occurred | 
**Job** | [**Job**](Job.md) |  | [optional] 
**MessageId** | **string** | Message ID (present for message.* and delivery events) | [optional] 
**AccountId** | **int** | Account ID (present for delivery events) | [optional] 
**DomainId** | **string** | Sending domain UUID (present for delivery events) | [optional] 
**To** | **string** | Recipient email (present for delivery events) | [optional] 
**Status** | **string** | Delivery status (present for delivery events) | [optional] 
**SmtpCode** | **int** | SMTP response code (present for bounced/deferred/failed) | [optional] 
**SmtpResponse** | **string** | SMTP diagnostic string (present for bounced/deferred/failed) | [optional] 
**MxHost** | **string** | MX host that handled delivery | [optional] 
**BounceType** | **string** | Bounce classification (present for message.bounced) | [optional] 
**EnhancedStatusCode** | **string** | Enhanced SMTP status code (e.g., 5.1.1) | [optional] 
**Attempts** | **int** | Number of delivery attempts | [optional] 
**Isp** | **string** | Receiving ISP name | [optional] 
**IsMpp** | **bool** | Whether the open was from Apple Mail Privacy Protection | [optional] 
**IpAddress** | **string** | Client IP (present for message.opened/clicked) | [optional] 
**UserAgent** | **string** | Client user agent (present for message.opened/clicked) | [optional] 
**IsBot** | **bool** | Whether the event was triggered by a bot (present for message.opened/clicked) | [optional] 
**LinkUrl** | **string** | Clicked URL (present for message.clicked) | [optional] 
**LinkIndex** | **int** | Position of clicked link in message (present for message.clicked) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

