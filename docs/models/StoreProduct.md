# MailOdds.Model.StoreProduct

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Product UUID | [optional] 
**StoreId** | **string** | Store connection UUID | [optional] 
**ExternalId** | **string** | Product ID in the source store | [optional] 
**Sku** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**PriceCurrent** | **decimal** | Current price | [optional] 
**PriceOriginal** | **decimal** | Original price (before discount) | [optional] 
**Currency** | **string** |  | [optional] [default to "USD"]
**SaleStart** | **DateTime** |  | [optional] 
**SaleEnd** | **DateTime** |  | [optional] 
**StockStatus** | **string** |  | [optional] 
**StockQuantity** | **int** |  | [optional] 
**ImageUrl** | **string** |  | [optional] 
**AdditionalImages** | **List&lt;string&gt;** |  | [optional] 
**Categories** | **List&lt;string&gt;** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**ProductUrl** | **string** |  | [optional] 
**Variants** | **List&lt;Object&gt;** |  | [optional] 
**IsActive** | **bool** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

