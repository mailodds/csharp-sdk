# MailOdds.Model.ValidationResponse
Flat validation response. Conditional fields are omitted (not null) when not applicable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** |  | 
**Email** | **string** |  | 
**Status** | **string** | Validation status | 
**Action** | **string** | Recommended action | 
**Domain** | **string** |  | 
**MxFound** | **bool** | Whether MX records were found for the domain | 
**Disposable** | **bool** | Whether domain is a known disposable email provider | 
**RoleAccount** | **bool** | Whether address is a role account (e.g., info@, admin@) | 
**FreeProvider** | **bool** | Whether domain is a known free email provider (e.g., gmail.com) | 
**Depth** | **string** | Validation depth used for this check | 
**ProcessedAt** | **DateTime** | ISO 8601 timestamp of validation | 
**RequestId** | **string** | Unique request identifier | [optional] 
**SubStatus** | **string** | Detailed status reason. Omitted when none. | [optional] 
**MxHost** | **string** | Primary MX hostname. Omitted when MX not resolved. | [optional] 
**SmtpCheck** | **bool** | Whether SMTP verification passed. Omitted when SMTP not checked. | [optional] 
**CatchAll** | **bool** | Whether domain is catch-all. Omitted when SMTP not checked. | [optional] 
**SuggestedEmail** | **string** | Domain typo correction suggestion based on a static lookup table of common misspellings (e.g. gmial.com -&gt; gmail.com). Not validated via SMTP. Omitted when no match found. | [optional] 
**RetryAfterMs** | **int** | Suggested retry delay in milliseconds. Present only for retry_later action. | [optional] 
**HasSpf** | **bool** | Whether the domain has an SPF record. Omitted for standard depth. | [optional] 
**HasDmarc** | **bool** | Whether the domain has a DMARC record. Omitted for standard depth. | [optional] 
**DmarcPolicy** | **string** | The domain&#39;s DMARC policy. Omitted when no DMARC record found. | [optional] 
**DnsblListed** | **bool** | Whether the domain&#39;s MX IP is on a DNS blocklist (Spamhaus ZEN). Omitted for standard depth. | [optional] 
**SuppressionMatch** | [**ValidationResponseSuppressionMatch**](ValidationResponseSuppressionMatch.md) |  | [optional] 
**PolicyApplied** | [**ValidationResponsePolicyApplied**](ValidationResponsePolicyApplied.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

