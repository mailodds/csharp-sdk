# MailOdds.Model.BatchDeliverResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** |  | [optional] 
**RequestId** | **string** | Unique request identifier | [optional] 
**Total** | **int** | Total recipients submitted | [optional] 
**Accepted** | **int** | Number of recipients accepted for delivery | [optional] 
**Rejected** | [**List&lt;BatchDeliverResponseRejectedInner&gt;**](BatchDeliverResponseRejectedInner.md) | Recipients that were rejected (suppressed or failed validation) | [optional] 
**Status** | **string** | Batch status | [optional] 
**Delivery** | [**BatchDeliverResponseDelivery**](BatchDeliverResponseDelivery.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

