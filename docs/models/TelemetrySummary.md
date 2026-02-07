# MailOdds.Model.TelemetrySummary
Validation metrics for building dashboards and monitoring.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** |  | [optional] 
**Window** | **string** |  | [optional] 
**GeneratedAt** | **DateTime** |  | [optional] 
**Timezone** | **string** |  | [optional] 
**Totals** | [**TelemetrySummaryTotals**](TelemetrySummaryTotals.md) |  | [optional] 
**Rates** | [**TelemetrySummaryRates**](TelemetrySummaryRates.md) |  | [optional] 
**TopReasons** | [**List&lt;TelemetrySummaryTopReasonsInner&gt;**](TelemetrySummaryTopReasonsInner.md) | Top rejection/status reasons | [optional] 
**TopDomains** | [**List&lt;TelemetrySummaryTopDomainsInner&gt;**](TelemetrySummaryTopDomainsInner.md) | Top domains by volume | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

