# MailOdds.Model.SendingDomain

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Domain UUID | [optional] 
**Domain** | **string** | Domain name | [optional] 
**DomainType** | **string** | Domain type (ns_delegated) | [optional] 
**Status** | **string** | Domain verification status | [optional] 
**DkimSelector** | **string** | DKIM selector (e.g. mo1) | [optional] 
**DnsRecords** | [**SendingDomainDnsRecords**](SendingDomainDnsRecords.md) |  | [optional] 
**BimiSvgUrl** | **string** | BIMI SVG logo URL | [optional] 
**BimiVmcUrl** | **string** | BIMI VMC certificate URL | [optional] 
**BimiEnabled** | **bool** | Whether BIMI is enabled | [optional] 
**ForwardRepliesTo** | **string** | Reply forwarding address | [optional] 
**IsPrimary** | **bool** | Whether this is the account primary/default sending domain | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

