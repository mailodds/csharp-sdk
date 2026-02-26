# MailOdds.Model.DeliverResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** |  | [optional] 
**RequestId** | **string** | Unique request identifier | [optional] 
**MessageId** | **string** | Unique message identifier | [optional] 
**Status** | **string** | Delivery status | [optional] 
**Delivery** | [**DeliverResponseDelivery**](DeliverResponseDelivery.md) |  | [optional] 
**Validation** | **Object** | Pre-send validation results (when validate_first is true) | [optional] 
**ContentScan** | **Object** | Content scan results | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

