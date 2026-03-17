# MailOdds.Model.TrackEventRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | Type of commerce event | 
**Email** | **string** | Email address associated with the event | 
**Properties** | **Object** | Event-specific data (e.g., order_id, value, product_url) | [optional] 
**OccurredAt** | **DateTime** | When the event occurred (defaults to now) | [optional] 
**IdempotencyKey** | **string** | Unique key to prevent duplicate events (5 min TTL) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

