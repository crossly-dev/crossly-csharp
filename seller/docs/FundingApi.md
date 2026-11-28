# net.crossly.Api.FundingApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFundingApply**](FundingApi.md#createfundingapply) | **POST** /v1/funding/apply | Apply for Crossly Funding. Decided at once on the checklist rules: approved opens your line (limit &#x3D; 25% of 90 days of settled Crossly payouts), declined lists why, needs_review goes to a person.
[**CreateFundingDraw**](FundingApi.md#createfundingdraw) | **POST** /v1/funding/draws | Draw on your line for a supplier order. Send the supplier, the invoice (an uploaded invoiceFileId from POST /v1/funding/invoice-files, a reference, or a URL) and the APR from the quote you accepted (acceptedAprBps); refused if your rate changed. The advance is held as in-platform Crossly balance, never cash. Idempotent on idempotencyKey.
[**CreateFundingDrawApprove**](FundingApi.md#createfundingdrawapprove) | **POST** /v1/funding/draws/{id}/approve | Approve a held draw. The two-person rule needs two distinct approvers; the requester never approves their own.
[**CreateFundingDrawQuote**](FundingApi.md#createfundingdrawquote) | **POST** /v1/funding/draws/quote | The disclosure for a draw of amountCents: APR, the simple-interest fee for the full term, the total and the due date, plus your available headroom. Nothing is drawn.
[**CreateFundingDrawReject**](FundingApi.md#createfundingdrawreject) | **POST** /v1/funding/draws/{id}/reject | Reject a held draw. Nothing was drawn, so nothing is owed.
[**CreateFundingDrawUse**](FundingApi.md#createfundingdrawuse) | **POST** /v1/funding/draws/use | Request a draw for an approved use. Refused by the spend controls, held for approval (stage requested — no debt until disbursed), or disbursed at once as restricted funding CBX. A DEBT with interest: show the disclosure first.
[**CreateFundingInvoiceFile**](FundingApi.md#createfundinginvoicefile) | **POST** /v1/funding/invoice-files | Sign an upload for a supplier invoice: a PDF or image (application/pdf, image/jpeg, image/png, image/webp, image/heic) of at most 15 MB. PUT the bytes to uploadUrl with the same Content-Type and exactly contentLength bytes, then draw with invoiceFileId &#x3D; file.id. Stored privately; one draw per file.
[**CreateFundingPayCrosslyFee**](FundingApi.md#createfundingpaycrosslyfee) | **POST** /v1/funding/pay/crossly-fees | Pay an open invoice of your Crossly plan with restricted funding CBX (no card is charged; the invoice is marked paid). Idempotent per invoice.
[**CreateFundingPayShippingLabel**](FundingApi.md#createfundingpayshippinglabel) | **POST** /v1/funding/pay/shipping-labels | Top up your shipping wallet with restricted funding CBX; labels you buy are then debited from it. Idempotent on idempotencyKey. Refused when the spend controls forbid shipping labels or it is over your approval threshold with no approved draw.
[**CreateFundingPayVaultFee**](FundingApi.md#createfundingpayvaultfee) | **POST** /v1/funding/pay/vault-fees | Ship a stored Vault unit home and pay its fee (shipping, storage owed, early withdrawal) with restricted funding CBX instead of your card.
[**CreateFundingPoolStake**](FundingApi.md#createfundingpoolstake) | **POST** /v1/funding/pool/stake | Stake earned CBX into the funding pool. Refused, with the reason, until the pool is live and staking is open.
[**CreateFundingPoolUnstake**](FundingApi.md#createfundingpoolunstake) | **POST** /v1/funding/pool/unstake | Queue an unstake. Paid first-in first-out once your lockup has passed.
[**CreateFundingPoolUnstakeCancel**](FundingApi.md#createfundingpoolunstakecancel) | **POST** /v1/funding/pool/unstake/{id}/cancel | Cancel a queued unstake that has not been paid yet.
[**CreateFundingPoolWaitlist**](FundingApi.md#createfundingpoolwaitlist) | **POST** /v1/funding/pool/waitlist | Join the staker waitlist: told the moment staking into the funding pool opens.
[**CreateFundingRepay**](FundingApi.md#createfundingrepay) | **POST** /v1/funding/repay | Repay. source \&quot;balance\&quot; (default) takes it from your available Stripe payout balance and applies it at once. source \&quot;card\&quot; returns a PaymentIntent client secret to confirm with Stripe; source \&quot;checkout\&quot; returns checkoutUrl, a hosted Stripe Checkout page the seller pays on (no Stripe SDK needed). source \&quot;cbx\&quot; pays early from your EARNED CBX at the obligation rate (granted and funding CBX never repay a line) and applies at once. Card and checkout apply when the payment succeeds. Never more than you owe; idempotent on idempotencyKey.
[**DeleteFundingMember**](FundingApi.md#deletefundingmember) | **DELETE** /v1/funding/members/{memberUserId} | Remove a team member’s funding limit: they can no longer draw.
[**GetFundingControl**](FundingApi.md#getfundingcontrol) | **GET** /v1/funding/controls | Your funding spend controls: approved uses, supplier allow/block lists, the approval threshold, the two-person rule and each team member’s funding limit.
[**GetFundingDraw**](FundingApi.md#getfundingdraw) | **GET** /v1/funding/draws/{id} | One draw: amount, use, supplier, stage and its timeline (requested → approved → disbursed → spent → repaid).
[**GetFundingDrawInvoice**](FundingApi.md#getfundingdrawinvoice) | **GET** /v1/funding/draws/{id}/invoice | A 15-minute signed link to a draw&#39;s uploaded supplier invoice, with the file&#39;s name, type and size. 404 when the draw has no uploaded file.
[**GetFundingInvoiceAdvanceEligibility**](FundingApi.md#getfundinginvoiceadvanceeligibility) | **GET** /v1/funding/invoice-advance-eligibility | What your Crossly Funding line could advance against your open wholesale invoices: per invoice its balance due, the advance at the rate (80%), what the line can cover now within its headroom (earliest due first), and why not (overdue, no line, line unavailable, over headroom). Eligibility only: an advance cannot be drawn against an invoice yet. X-Storefront-Id narrows to one store.
[**GetFundingLine**](FundingApi.md#getfundingline) | **GET** /v1/funding/line | Your line: limit, available, outstanding (principal + interest), APR, interest accrued since the last posting, the payoff figure, next due date, anything overdue, the per-draw schedule and your auto-repay share.
[**GetFundingOffer**](FundingApi.md#getfundingoffer) | **GET** /v1/funding/offer | Your pre-qualified Crossly Funding limit and the eligibility checklist: each rule, whether you pass it, and what to do if not. Works with or without a line.
[**GetFundingPool**](FundingApi.md#getfundingpool) | **GET** /v1/funding/pool | The Crossly Funding pool: live or not and why (no token yet, no pool, no price, no capacity), capacity, utilisation, the reserve, and the uses and suppliers it allows.
[**GetFundingPoolStake**](FundingApi.md#getfundingpoolstake) | **GET** /v1/funding/pool/stake | Your position in the funding pool, the trailing APY reading (never a promise), lockup, unstake queue, history and the risk disclosure.
[**GetFundingSpendable**](FundingApi.md#getfundingspendable) | **GET** /v1/funding/spendable | What your restricted funding CBX can pay right now, in cents, for each Crossly use (shipping labels, Crossly fees, ads, Vault fees). 0 &#x3D; none, or your spend controls refuse that use.
[**GetFundingStatement**](FundingApi.md#getfundingstatement) | **GET** /v1/funding/statements | A monthly statement (?month&#x3D;YYYY-MM, default the latest): opening balance, every draw, interest posting and payment, and the closing balance; plus the months available.
[**ListFundingApprovals**](FundingApi.md#listfundingapprovals) | **GET** /v1/funding/approvals | Draws your spend controls hold for approval, with the approvals so far and how many are needed.
[**ListFundingDraws**](FundingApi.md#listfundingdraws) | **GET** /v1/funding/draws | Every draw on your line: what it paid for (a supplier order, or a Crossly checkout), its APR, estimated fee and due date.
[**ListFundingReceipts**](FundingApi.md#listfundingreceipts) | **GET** /v1/funding/receipts | Your funding payments to Crossly, newest first: the use, what it paid for, cents, status (pending, paid, failed) and the draw it was stamped against.
[**ListFundingRepayments**](FundingApi.md#listfundingrepayments) | **GET** /v1/funding/repayments | Manual repayments (card / bank, or from your payout balance), newest first.
[**UpdateFundingAutorepay**](FundingApi.md#updatefundingautorepay) | **PUT** /v1/funding/autorepay | Set the share of each Crossly payout applied to what you owe: a whole percent from 10 to 100 (default 20). Never more than you owe is taken.
[**UpdateFundingControl**](FundingApi.md#updatefundingcontrol) | **PUT** /v1/funding/controls | Change your funding spend controls. Enforced at every spend: wholesale checkout, labels, ads, Crossly and Vault fees.
[**UpdateFundingMember**](FundingApi.md#updatefundingmember) | **PUT** /v1/funding/members/{memberUserId} | Set a team member’s funding limit (per draw or per month).


<a name="createfundingapply"></a>
# **CreateFundingApply**
> CreateFundingApplyResponse CreateFundingApply (CreateFundingApplyRequest createFundingApplyRequest)

Apply for Crossly Funding. Decided at once on the checklist rules: approved opens your line (limit = 25% of 90 days of settled Crossly payouts), declined lists why, needs_review goes to a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingApplyRequest = new CreateFundingApplyRequest(); // CreateFundingApplyRequest | 

            try
            {
                // Apply for Crossly Funding. Decided at once on the checklist rules: approved opens your line (limit = 25% of 90 days of settled Crossly payouts), declined lists why, needs_review goes to a person.
                CreateFundingApplyResponse result = apiInstance.CreateFundingApply(createFundingApplyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingApply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingApplyRequest** | **CreateFundingApplyRequest**|  | 

### Return type

**CreateFundingApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingdraw"></a>
# **CreateFundingDraw**
> CreateFundingDrawResponse CreateFundingDraw (CreateFundingDrawRequest createFundingDrawRequest)

Draw on your line for a supplier order. Send the supplier, the invoice (an uploaded invoiceFileId from POST /v1/funding/invoice-files, a reference, or a URL) and the APR from the quote you accepted (acceptedAprBps); refused if your rate changed. The advance is held as in-platform Crossly balance, never cash. Idempotent on idempotencyKey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingDrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingDrawRequest = new CreateFundingDrawRequest(); // CreateFundingDrawRequest | 

            try
            {
                // Draw on your line for a supplier order. Send the supplier, the invoice (an uploaded invoiceFileId from POST /v1/funding/invoice-files, a reference, or a URL) and the APR from the quote you accepted (acceptedAprBps); refused if your rate changed. The advance is held as in-platform Crossly balance, never cash. Idempotent on idempotencyKey.
                CreateFundingDrawResponse result = apiInstance.CreateFundingDraw(createFundingDrawRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingDraw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingDrawRequest** | **CreateFundingDrawRequest**|  | 

### Return type

**CreateFundingDrawResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingdrawapprove"></a>
# **CreateFundingDrawApprove**
> CreateFundingDrawRejectResponse CreateFundingDrawApprove (string id, NoteRequest noteRequest = null)

Approve a held draw. The two-person rule needs two distinct approvers; the requester never approves their own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingDrawApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var id = "id_example";  // string | 
            var noteRequest = new NoteRequest(); // NoteRequest |  (optional) 

            try
            {
                // Approve a held draw. The two-person rule needs two distinct approvers; the requester never approves their own.
                CreateFundingDrawRejectResponse result = apiInstance.CreateFundingDrawApprove(id, noteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingDrawApprove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **noteRequest** | **NoteRequest**|  | [optional] 

### Return type

**CreateFundingDrawRejectResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingdrawquote"></a>
# **CreateFundingDrawQuote**
> CreateFundingDrawQuoteResponse CreateFundingDrawQuote (CreateFundingDrawQuoteRequest createFundingDrawQuoteRequest)

The disclosure for a draw of amountCents: APR, the simple-interest fee for the full term, the total and the due date, plus your available headroom. Nothing is drawn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingDrawQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingDrawQuoteRequest = new CreateFundingDrawQuoteRequest(); // CreateFundingDrawQuoteRequest | 

            try
            {
                // The disclosure for a draw of amountCents: APR, the simple-interest fee for the full term, the total and the due date, plus your available headroom. Nothing is drawn.
                CreateFundingDrawQuoteResponse result = apiInstance.CreateFundingDrawQuote(createFundingDrawQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingDrawQuote: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingDrawQuoteRequest** | **CreateFundingDrawQuoteRequest**|  | 

### Return type

**CreateFundingDrawQuoteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingdrawreject"></a>
# **CreateFundingDrawReject**
> CreateFundingDrawRejectResponse CreateFundingDrawReject (string id, NoteRequest noteRequest = null)

Reject a held draw. Nothing was drawn, so nothing is owed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingDrawRejectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var id = "id_example";  // string | 
            var noteRequest = new NoteRequest(); // NoteRequest |  (optional) 

            try
            {
                // Reject a held draw. Nothing was drawn, so nothing is owed.
                CreateFundingDrawRejectResponse result = apiInstance.CreateFundingDrawReject(id, noteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingDrawReject: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **noteRequest** | **NoteRequest**|  | [optional] 

### Return type

**CreateFundingDrawRejectResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingdrawuse"></a>
# **CreateFundingDrawUse**
> CreateFundingDrawUseResponse CreateFundingDrawUse (CreateFundingDrawUseRequest createFundingDrawUseRequest)

Request a draw for an approved use. Refused by the spend controls, held for approval (stage requested — no debt until disbursed), or disbursed at once as restricted funding CBX. A DEBT with interest: show the disclosure first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingDrawUseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingDrawUseRequest = new CreateFundingDrawUseRequest(); // CreateFundingDrawUseRequest | 

            try
            {
                // Request a draw for an approved use. Refused by the spend controls, held for approval (stage requested — no debt until disbursed), or disbursed at once as restricted funding CBX. A DEBT with interest: show the disclosure first.
                CreateFundingDrawUseResponse result = apiInstance.CreateFundingDrawUse(createFundingDrawUseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingDrawUse: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingDrawUseRequest** | **CreateFundingDrawUseRequest**|  | 

### Return type

**CreateFundingDrawUseResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundinginvoicefile"></a>
# **CreateFundingInvoiceFile**
> CreateFundingInvoiceFileResponse CreateFundingInvoiceFile (CreateFundingInvoiceFileRequest createFundingInvoiceFileRequest)

Sign an upload for a supplier invoice: a PDF or image (application/pdf, image/jpeg, image/png, image/webp, image/heic) of at most 15 MB. PUT the bytes to uploadUrl with the same Content-Type and exactly contentLength bytes, then draw with invoiceFileId = file.id. Stored privately; one draw per file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingInvoiceFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingInvoiceFileRequest = new CreateFundingInvoiceFileRequest(); // CreateFundingInvoiceFileRequest | 

            try
            {
                // Sign an upload for a supplier invoice: a PDF or image (application/pdf, image/jpeg, image/png, image/webp, image/heic) of at most 15 MB. PUT the bytes to uploadUrl with the same Content-Type and exactly contentLength bytes, then draw with invoiceFileId = file.id. Stored privately; one draw per file.
                CreateFundingInvoiceFileResponse result = apiInstance.CreateFundingInvoiceFile(createFundingInvoiceFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingInvoiceFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingInvoiceFileRequest** | **CreateFundingInvoiceFileRequest**|  | 

### Return type

**CreateFundingInvoiceFileResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpaycrosslyfee"></a>
# **CreateFundingPayCrosslyFee**
> CreateFundingPayCrosslyFeeResponse CreateFundingPayCrosslyFee (CreateFundingPayCrosslyFeeRequest createFundingPayCrosslyFeeRequest)

Pay an open invoice of your Crossly plan with restricted funding CBX (no card is charged; the invoice is marked paid). Idempotent per invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPayCrosslyFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingPayCrosslyFeeRequest = new CreateFundingPayCrosslyFeeRequest(); // CreateFundingPayCrosslyFeeRequest | 

            try
            {
                // Pay an open invoice of your Crossly plan with restricted funding CBX (no card is charged; the invoice is marked paid). Idempotent per invoice.
                CreateFundingPayCrosslyFeeResponse result = apiInstance.CreateFundingPayCrosslyFee(createFundingPayCrosslyFeeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPayCrosslyFee: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingPayCrosslyFeeRequest** | **CreateFundingPayCrosslyFeeRequest**|  | 

### Return type

**CreateFundingPayCrosslyFeeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpayshippinglabel"></a>
# **CreateFundingPayShippingLabel**
> CreateFundingPayShippingLabelResponse CreateFundingPayShippingLabel (CreateFundingPayShippingLabelRequest createFundingPayShippingLabelRequest)

Top up your shipping wallet with restricted funding CBX; labels you buy are then debited from it. Idempotent on idempotencyKey. Refused when the spend controls forbid shipping labels or it is over your approval threshold with no approved draw.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPayShippingLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingPayShippingLabelRequest = new CreateFundingPayShippingLabelRequest(); // CreateFundingPayShippingLabelRequest | 

            try
            {
                // Top up your shipping wallet with restricted funding CBX; labels you buy are then debited from it. Idempotent on idempotencyKey. Refused when the spend controls forbid shipping labels or it is over your approval threshold with no approved draw.
                CreateFundingPayShippingLabelResponse result = apiInstance.CreateFundingPayShippingLabel(createFundingPayShippingLabelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPayShippingLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingPayShippingLabelRequest** | **CreateFundingPayShippingLabelRequest**|  | 

### Return type

**CreateFundingPayShippingLabelResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpayvaultfee"></a>
# **CreateFundingPayVaultFee**
> CreateFundingPayVaultFeeResponse CreateFundingPayVaultFee (CreateFundingPayVaultFeeRequest createFundingPayVaultFeeRequest)

Ship a stored Vault unit home and pay its fee (shipping, storage owed, early withdrawal) with restricted funding CBX instead of your card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPayVaultFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingPayVaultFeeRequest = new CreateFundingPayVaultFeeRequest(); // CreateFundingPayVaultFeeRequest | 

            try
            {
                // Ship a stored Vault unit home and pay its fee (shipping, storage owed, early withdrawal) with restricted funding CBX instead of your card.
                CreateFundingPayVaultFeeResponse result = apiInstance.CreateFundingPayVaultFee(createFundingPayVaultFeeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPayVaultFee: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingPayVaultFeeRequest** | **CreateFundingPayVaultFeeRequest**|  | 

### Return type

**CreateFundingPayVaultFeeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpoolstake"></a>
# **CreateFundingPoolStake**
> CreateFundingPoolStakeResponse CreateFundingPoolStake (CreateFundingPoolStakeRequest createFundingPoolStakeRequest)

Stake earned CBX into the funding pool. Refused, with the reason, until the pool is live and staking is open.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPoolStakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingPoolStakeRequest = new CreateFundingPoolStakeRequest(); // CreateFundingPoolStakeRequest | 

            try
            {
                // Stake earned CBX into the funding pool. Refused, with the reason, until the pool is live and staking is open.
                CreateFundingPoolStakeResponse result = apiInstance.CreateFundingPoolStake(createFundingPoolStakeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPoolStake: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingPoolStakeRequest** | **CreateFundingPoolStakeRequest**|  | 

### Return type

**CreateFundingPoolStakeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpoolunstake"></a>
# **CreateFundingPoolUnstake**
> FundingPoolResponse CreateFundingPoolUnstake (CreateFundingPoolUnstakeRequest createFundingPoolUnstakeRequest)

Queue an unstake. Paid first-in first-out once your lockup has passed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPoolUnstakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingPoolUnstakeRequest = new CreateFundingPoolUnstakeRequest(); // CreateFundingPoolUnstakeRequest | 

            try
            {
                // Queue an unstake. Paid first-in first-out once your lockup has passed.
                FundingPoolResponse result = apiInstance.CreateFundingPoolUnstake(createFundingPoolUnstakeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPoolUnstake: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingPoolUnstakeRequest** | **CreateFundingPoolUnstakeRequest**|  | 

### Return type

**FundingPoolResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpoolunstakecancel"></a>
# **CreateFundingPoolUnstakeCancel**
> FundingPoolResponse CreateFundingPoolUnstakeCancel (string id)

Cancel a queued unstake that has not been paid yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPoolUnstakeCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a queued unstake that has not been paid yet.
                FundingPoolResponse result = apiInstance.CreateFundingPoolUnstakeCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPoolUnstakeCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**FundingPoolResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingpoolwaitlist"></a>
# **CreateFundingPoolWaitlist**
> FundingPoolResponse CreateFundingPoolWaitlist ()

Join the staker waitlist: told the moment staking into the funding pool opens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingPoolWaitlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Join the staker waitlist: told the moment staking into the funding pool opens.
                FundingPoolResponse result = apiInstance.CreateFundingPoolWaitlist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingPoolWaitlist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**FundingPoolResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createfundingrepay"></a>
# **CreateFundingRepay**
> CreateFundingRepayResponse CreateFundingRepay (CreateFundingRepayRequest createFundingRepayRequest)

Repay. source \"balance\" (default) takes it from your available Stripe payout balance and applies it at once. source \"card\" returns a PaymentIntent client secret to confirm with Stripe; source \"checkout\" returns checkoutUrl, a hosted Stripe Checkout page the seller pays on (no Stripe SDK needed). source \"cbx\" pays early from your EARNED CBX at the obligation rate (granted and funding CBX never repay a line) and applies at once. Card and checkout apply when the payment succeeds. Never more than you owe; idempotent on idempotencyKey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateFundingRepayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var createFundingRepayRequest = new CreateFundingRepayRequest(); // CreateFundingRepayRequest | 

            try
            {
                // Repay. source \"balance\" (default) takes it from your available Stripe payout balance and applies it at once. source \"card\" returns a PaymentIntent client secret to confirm with Stripe; source \"checkout\" returns checkoutUrl, a hosted Stripe Checkout page the seller pays on (no Stripe SDK needed). source \"cbx\" pays early from your EARNED CBX at the obligation rate (granted and funding CBX never repay a line) and applies at once. Card and checkout apply when the payment succeeds. Never more than you owe; idempotent on idempotencyKey.
                CreateFundingRepayResponse result = apiInstance.CreateFundingRepay(createFundingRepayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.CreateFundingRepay: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFundingRepayRequest** | **CreateFundingRepayRequest**|  | 

### Return type

**CreateFundingRepayResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletefundingmember"></a>
# **DeleteFundingMember**
> DeleteFundingMemberResponse DeleteFundingMember (string memberUserId)

Remove a team member’s funding limit: they can no longer draw.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteFundingMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var memberUserId = "memberUserId_example";  // string | 

            try
            {
                // Remove a team member’s funding limit: they can no longer draw.
                DeleteFundingMemberResponse result = apiInstance.DeleteFundingMember(memberUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.DeleteFundingMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberUserId** | **string**|  | 

### Return type

**DeleteFundingMemberResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingcontrol"></a>
# **GetFundingControl**
> GetFundingControlResponse GetFundingControl ()

Your funding spend controls: approved uses, supplier allow/block lists, the approval threshold, the two-person rule and each team member’s funding limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Your funding spend controls: approved uses, supplier allow/block lists, the approval threshold, the two-person rule and each team member’s funding limit.
                GetFundingControlResponse result = apiInstance.GetFundingControl();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingControl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingControlResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingdraw"></a>
# **GetFundingDraw**
> GetFundingDrawResponse GetFundingDraw (string id)

One draw: amount, use, supplier, stage and its timeline (requested → approved → disbursed → spent → repaid).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingDrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One draw: amount, use, supplier, stage and its timeline (requested → approved → disbursed → spent → repaid).
                GetFundingDrawResponse result = apiInstance.GetFundingDraw(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingDraw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**GetFundingDrawResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingdrawinvoice"></a>
# **GetFundingDrawInvoice**
> GetFundingDrawInvoiceResponse GetFundingDrawInvoice (string id)

A 15-minute signed link to a draw's uploaded supplier invoice, with the file's name, type and size. 404 when the draw has no uploaded file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingDrawInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A 15-minute signed link to a draw's uploaded supplier invoice, with the file's name, type and size. 404 when the draw has no uploaded file.
                GetFundingDrawInvoiceResponse result = apiInstance.GetFundingDrawInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingDrawInvoice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**GetFundingDrawInvoiceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundinginvoiceadvanceeligibility"></a>
# **GetFundingInvoiceAdvanceEligibility**
> GetFundingInvoiceAdvanceEligibilityResponse GetFundingInvoiceAdvanceEligibility ()

What your Crossly Funding line could advance against your open wholesale invoices: per invoice its balance due, the advance at the rate (80%), what the line can cover now within its headroom (earliest due first), and why not (overdue, no line, line unavailable, over headroom). Eligibility only: an advance cannot be drawn against an invoice yet. X-Storefront-Id narrows to one store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingInvoiceAdvanceEligibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // What your Crossly Funding line could advance against your open wholesale invoices: per invoice its balance due, the advance at the rate (80%), what the line can cover now within its headroom (earliest due first), and why not (overdue, no line, line unavailable, over headroom). Eligibility only: an advance cannot be drawn against an invoice yet. X-Storefront-Id narrows to one store.
                GetFundingInvoiceAdvanceEligibilityResponse result = apiInstance.GetFundingInvoiceAdvanceEligibility();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingInvoiceAdvanceEligibility: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingInvoiceAdvanceEligibilityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingline"></a>
# **GetFundingLine**
> GetFundingLineResponse GetFundingLine ()

Your line: limit, available, outstanding (principal + interest), APR, interest accrued since the last posting, the payoff figure, next due date, anything overdue, the per-draw schedule and your auto-repay share.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Your line: limit, available, outstanding (principal + interest), APR, interest accrued since the last posting, the payoff figure, next due date, anything overdue, the per-draw schedule and your auto-repay share.
                GetFundingLineResponse result = apiInstance.GetFundingLine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingLine: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingLineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingoffer"></a>
# **GetFundingOffer**
> GetFundingOfferResponse GetFundingOffer ()

Your pre-qualified Crossly Funding limit and the eligibility checklist: each rule, whether you pass it, and what to do if not. Works with or without a line.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Your pre-qualified Crossly Funding limit and the eligibility checklist: each rule, whether you pass it, and what to do if not. Works with or without a line.
                GetFundingOfferResponse result = apiInstance.GetFundingOffer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingOffer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingOfferResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingpool"></a>
# **GetFundingPool**
> GetFundingPoolResponse GetFundingPool ()

The Crossly Funding pool: live or not and why (no token yet, no pool, no price, no capacity), capacity, utilisation, the reserve, and the uses and suppliers it allows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingPoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // The Crossly Funding pool: live or not and why (no token yet, no pool, no price, no capacity), capacity, utilisation, the reserve, and the uses and suppliers it allows.
                GetFundingPoolResponse result = apiInstance.GetFundingPool();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingPool: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingPoolResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingpoolstake"></a>
# **GetFundingPoolStake**
> FundingPoolResponse GetFundingPoolStake ()

Your position in the funding pool, the trailing APY reading (never a promise), lockup, unstake queue, history and the risk disclosure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingPoolStakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Your position in the funding pool, the trailing APY reading (never a promise), lockup, unstake queue, history and the risk disclosure.
                FundingPoolResponse result = apiInstance.GetFundingPoolStake();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingPoolStake: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**FundingPoolResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingspendable"></a>
# **GetFundingSpendable**
> GetFundingSpendableResponse GetFundingSpendable ()

What your restricted funding CBX can pay right now, in cents, for each Crossly use (shipping labels, Crossly fees, ads, Vault fees). 0 = none, or your spend controls refuse that use.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingSpendableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // What your restricted funding CBX can pay right now, in cents, for each Crossly use (shipping labels, Crossly fees, ads, Vault fees). 0 = none, or your spend controls refuse that use.
                GetFundingSpendableResponse result = apiInstance.GetFundingSpendable();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingSpendable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingSpendableResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getfundingstatement"></a>
# **GetFundingStatement**
> GetFundingStatementResponse GetFundingStatement ()

A monthly statement (?month=YYYY-MM, default the latest): opening balance, every draw, interest posting and payment, and the closing balance; plus the months available.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetFundingStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // A monthly statement (?month=YYYY-MM, default the latest): opening balance, every draw, interest posting and payment, and the closing balance; plus the months available.
                GetFundingStatementResponse result = apiInstance.GetFundingStatement();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.GetFundingStatement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetFundingStatementResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listfundingapprovals"></a>
# **ListFundingApprovals**
> ListFundingApprovalsResponse ListFundingApprovals ()

Draws your spend controls hold for approval, with the approvals so far and how many are needed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFundingApprovalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Draws your spend controls hold for approval, with the approvals so far and how many are needed.
                ListFundingApprovalsResponse result = apiInstance.ListFundingApprovals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.ListFundingApprovals: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListFundingApprovalsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listfundingdraws"></a>
# **ListFundingDraws**
> ListFundingDrawsResponse ListFundingDraws ()

Every draw on your line: what it paid for (a supplier order, or a Crossly checkout), its APR, estimated fee and due date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFundingDrawsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Every draw on your line: what it paid for (a supplier order, or a Crossly checkout), its APR, estimated fee and due date.
                ListFundingDrawsResponse result = apiInstance.ListFundingDraws();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.ListFundingDraws: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListFundingDrawsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listfundingreceipts"></a>
# **ListFundingReceipts**
> ListFundingReceiptsResponse ListFundingReceipts (decimal? limit = null)

Your funding payments to Crossly, newest first: the use, what it paid for, cents, status (pending, paid, failed) and the draw it was stamped against.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFundingReceiptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Your funding payments to Crossly, newest first: the use, what it paid for, cents, status (pending, paid, failed) and the draw it was stamped against.
                ListFundingReceiptsResponse result = apiInstance.ListFundingReceipts(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.ListFundingReceipts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListFundingReceiptsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listfundingrepayments"></a>
# **ListFundingRepayments**
> ListFundingRepaymentsResponse ListFundingRepayments ()

Manual repayments (card / bank, or from your payout balance), newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListFundingRepaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);

            try
            {
                // Manual repayments (card / bank, or from your payout balance), newest first.
                ListFundingRepaymentsResponse result = apiInstance.ListFundingRepayments();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.ListFundingRepayments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListFundingRepaymentsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatefundingautorepay"></a>
# **UpdateFundingAutorepay**
> UpdateFundingAutorepayResponse UpdateFundingAutorepay (UpdateFundingAutorepayRequest updateFundingAutorepayRequest)

Set the share of each Crossly payout applied to what you owe: a whole percent from 10 to 100 (default 20). Never more than you owe is taken.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateFundingAutorepayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var updateFundingAutorepayRequest = new UpdateFundingAutorepayRequest(); // UpdateFundingAutorepayRequest | 

            try
            {
                // Set the share of each Crossly payout applied to what you owe: a whole percent from 10 to 100 (default 20). Never more than you owe is taken.
                UpdateFundingAutorepayResponse result = apiInstance.UpdateFundingAutorepay(updateFundingAutorepayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.UpdateFundingAutorepay: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateFundingAutorepayRequest** | **UpdateFundingAutorepayRequest**|  | 

### Return type

**UpdateFundingAutorepayResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatefundingcontrol"></a>
# **UpdateFundingControl**
> UpdateFundingControlResponse UpdateFundingControl (UpdateFundingControlRequest updateFundingControlRequest)

Change your funding spend controls. Enforced at every spend: wholesale checkout, labels, ads, Crossly and Vault fees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateFundingControlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var updateFundingControlRequest = new UpdateFundingControlRequest(); // UpdateFundingControlRequest | 

            try
            {
                // Change your funding spend controls. Enforced at every spend: wholesale checkout, labels, ads, Crossly and Vault fees.
                UpdateFundingControlResponse result = apiInstance.UpdateFundingControl(updateFundingControlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.UpdateFundingControl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateFundingControlRequest** | **UpdateFundingControlRequest**|  | 

### Return type

**UpdateFundingControlResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatefundingmember"></a>
# **UpdateFundingMember**
> UpdateFundingMemberResponse UpdateFundingMember (string memberUserId, UpdateFundingMemberRequest updateFundingMemberRequest)

Set a team member’s funding limit (per draw or per month).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateFundingMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FundingApi(config);
            var memberUserId = "memberUserId_example";  // string | 
            var updateFundingMemberRequest = new UpdateFundingMemberRequest(); // UpdateFundingMemberRequest | 

            try
            {
                // Set a team member’s funding limit (per draw or per month).
                UpdateFundingMemberResponse result = apiInstance.UpdateFundingMember(memberUserId, updateFundingMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundingApi.UpdateFundingMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberUserId** | **string**|  | 
 **updateFundingMemberRequest** | **UpdateFundingMemberRequest**|  | 

### Return type

**UpdateFundingMemberResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

