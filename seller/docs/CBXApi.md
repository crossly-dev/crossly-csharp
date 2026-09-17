# net.crossly.Api.CBXApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCbxAccrual**](CBXApi.md#createcbxaccrual) | **POST** /v1/cbx/accruals | Record cashback a user earned, in cents.
[**CreateCbxAccrualPurchase**](CBXApi.md#createcbxaccrualpurchase) | **POST** /v1/cbx/accruals/purchase | Accrue cashback for an order at the resolved rate.
[**CreateCbxAccrualReverse**](CBXApi.md#createcbxaccrualreverse) | **POST** /v1/cbx/accruals/{accrualId}/reverse | Claw back a pending accrual — a refund, a cancellation, fraud.
[**CreateCbxAdCreditPurchase**](CBXApi.md#createcbxadcreditpurchase) | **POST** /v1/cbx/ad-credit/purchase | Claim ad credit against a CBX transfer you sent.
[**CreateCbxAdCreditQuote**](CBXApi.md#createcbxadcreditquote) | **POST** /v1/cbx/ad-credit/quote | What a given number of tokens buys in ad credit.
[**CreateCbxAdCreditSpend**](CBXApi.md#createcbxadcreditspend) | **POST** /v1/cbx/ad-credit/spend | Consume credit for a billing period.
[**CreateCbxBoost**](CBXApi.md#createcbxboost) | **POST** /v1/cbx/boosts | Fund elevated cashback on matching items.
[**CreateCbxBoostPause**](CBXApi.md#createcbxboostpause) | **POST** /v1/cbx/boosts/{boostId}/pause | Stop a boost from matching further orders.
[**CreateCbxCampaign**](CBXApi.md#createcbxcampaign) | **POST** /v1/cbx/campaigns | Create a campaign in draft.
[**CreateCbxCampaignApprove**](CBXApi.md#createcbxcampaignapprove) | **POST** /v1/cbx/campaigns/{campaignId}/approve | Approve the previewed recipient list.
[**CreateCbxCampaignExecute**](CBXApi.md#createcbxcampaignexecute) | **POST** /v1/cbx/campaigns/{campaignId}/execute | Pay an approved campaign.
[**CreateCbxCampaignPreview**](CBXApi.md#createcbxcampaignpreview) | **POST** /v1/cbx/campaigns/{campaignId}/preview | Compute the recipient list without paying it.
[**CreateCbxClaim**](CBXApi.md#createcbxclaim) | **POST** /v1/cbx/claims | Reserve a claim. Debits the balance and queues the transfer.
[**CreateCbxClaimQuote**](CBXApi.md#createcbxclaimquote) | **POST** /v1/cbx/claims/quote | What a claim would cost, without committing to it.
[**CreateCbxClaimSend**](CBXApi.md#createcbxclaimsend) | **POST** /v1/cbx/claims/{claimId}/send | Send a reserved claim on chain.
[**CreateCbxCreditDraw**](CBXApi.md#createcbxcreditdraw) | **POST** /v1/cbx/credit/draw | Draw against a line, receiving grant credit.
[**CreateCbxCreditFreeze**](CBXApi.md#createcbxcreditfreeze) | **POST** /v1/cbx/credit/freeze | Stop new draws. Leaves the drawn balance on its terms.
[**CreateCbxCreditRefresh**](CBXApi.md#createcbxcreditrefresh) | **POST** /v1/cbx/credit/refresh | Recompute a limit from trading history and stake.
[**CreateCbxCreditRepay**](CBXApi.md#createcbxcreditrepay) | **POST** /v1/cbx/credit/repay | Apply a repayment to a line.
[**CreateCbxDisbursementRule**](CBXApi.md#createcbxdisbursementrule) | **POST** /v1/cbx/disbursement-rules | Fire a distribution when the events pool crosses a threshold.
[**CreateCbxDisbursementRuleActive**](CBXApi.md#createcbxdisbursementruleactive) | **POST** /v1/cbx/disbursement-rules/{ruleId}/active | Enable or disable a rule.
[**CreateCbxDisbursementRuleCheck**](CBXApi.md#createcbxdisbursementrulecheck) | **POST** /v1/cbx/disbursement-rules/{ruleId}/check | Evaluate a rule now. Fires it if every gate passes.
[**CreateCbxEarnTier**](CBXApi.md#createcbxearntier) | **POST** /v1/cbx/earn-tiers | Define an earn term.
[**CreateCbxRateQuote**](CBXApi.md#createcbxratequote) | **POST** /v1/cbx/rates/quote | What would this order earn, and why.
[**CreateCbxRedemption**](CBXApi.md#createcbxredemption) | **POST** /v1/cbx/redemptions | Pay for a service in CBX.
[**CreateCbxRedemptionQuote**](CBXApi.md#createcbxredemptionquote) | **POST** /v1/cbx/redemptions/quote | What a service costs in tokens right now.
[**CreateCbxRevenueSweep**](CBXApi.md#createcbxrevenuesweep) | **POST** /v1/cbx/revenue/sweep | Move accrued revenue from the reserve to your revenue wallet.
[**CreateCbxSpend**](CBXApi.md#createcbxspend) | **POST** /v1/cbx/spends | Redeem a user&#39;s CBX against an order.
[**CreateCbxSpendReverse**](CBXApi.md#createcbxspendreverse) | **POST** /v1/cbx/spends/{externalId}/reverse | Refund a spend — give the tokens back and claw the skim back.
[**CreateCbxStakeTier**](CBXApi.md#createcbxstaketier) | **POST** /v1/cbx/stake-tiers | Define a staking tier.
[**CreateCbxSubject**](CBXApi.md#createcbxsubject) | **POST** /v1/cbx/subjects | Map one of your user ids to a CBX subject.
[**CreateCbxSubjectGrant**](CBXApi.md#createcbxsubjectgrant) | **POST** /v1/cbx/subjects/{subjectId}/grants | Issue grant credit — in-platform, non-withdrawable.
[**CreateCbxSubjectSpendPlan**](CBXApi.md#createcbxsubjectspendplan) | **POST** /v1/cbx/subjects/{subjectId}/spend-plan | Which balances would pay for a spend, and in what order.
[**CreateCbxSubjectStake**](CBXApi.md#createcbxsubjectstake) | **POST** /v1/cbx/subjects/{subjectId}/stake | Lock a subject&#39;s tokens for a tier.
[**CreateCbxSubjectStakeUnstake**](CBXApi.md#createcbxsubjectstakeunstake) | **POST** /v1/cbx/subjects/{subjectId}/stake/unstake | Start the cooldown. Tokens unlock when it elapses.
[**CreateCbxWalletChallenge**](CBXApi.md#createcbxwalletchallenge) | **POST** /v1/cbx/wallets/challenge | Start wallet verification. Returns a message for the user to sign.
[**CreateCbxWalletPaymentConfirm**](CBXApi.md#createcbxwalletpaymentconfirm) | **POST** /v1/cbx/wallet-payments/confirm | Present the signature. Returns a ship / do-not-ship decision.
[**CreateCbxWalletPaymentQuote**](CBXApi.md#createcbxwalletpaymentquote) | **POST** /v1/cbx/wallet-payments/quote | Build a transfer for the buyer to sign themselves.
[**CreateCbxWalletPaymentResolve**](CBXApi.md#createcbxwalletpaymentresolve) | **POST** /v1/cbx/wallet-payments/{paymentId}/resolve | A human decides on a held payment.
[**CreateCbxWalletVerify**](CBXApi.md#createcbxwalletverify) | **POST** /v1/cbx/wallets/verify | Complete wallet verification with the user&#39;s signature.
[**GetCbxAdCredit**](CBXApi.md#getcbxadcredit) | **GET** /v1/cbx/ad-credit | Unspent advertising credit, in cents.
[**GetCbxClaim**](CBXApi.md#getcbxclaim) | **GET** /v1/cbx/claims/{claimId} | A claim&#39;s current state.
[**GetCbxCredit**](CBXApi.md#getcbxcredit) | **GET** /v1/cbx/credit | A seller&#39;s wholesale credit line.
[**GetCbxMe**](CBXApi.md#getcbxme) | **GET** /v1/cbx/me | Identity check — which merchant this key belongs to, and its terms.
[**GetCbxPool**](CBXApi.md#getcbxpool) | **GET** /v1/cbx/pool | Your events-pool balance.
[**GetCbxRevenue**](CBXApi.md#getcbxrevenue) | **GET** /v1/cbx/revenue | Operator revenue accrued and not yet withdrawn.
[**GetCbxSubjectBalance**](CBXApi.md#getcbxsubjectbalance) | **GET** /v1/cbx/subjects/{subjectId}/balance | What a subject holds: pending cents and available CBX.
[**GetCbxSubjectBalanceBySubjectId**](CBXApi.md#getcbxsubjectbalancebysubjectid) | **GET** /v1/cbx/subjects/{subjectId}/balances | All three balances a subject holds.
[**GetCbxSubjectSpent**](CBXApi.md#getcbxsubjectspent) | **GET** /v1/cbx/subjects/{subjectId}/spent | Total CBX a subject has spent in your marketplace.
[**GetCbxSubjectStake**](CBXApi.md#getcbxsubjectstake) | **GET** /v1/cbx/subjects/{subjectId}/stake | A subject&#39;s staking state and spendable balance.
[**GetCbxSubjectWallet**](CBXApi.md#getcbxsubjectwallet) | **GET** /v1/cbx/subjects/{subjectId}/wallet | The verified payout address for a subject, if any.
[**GetCbxTreasury**](CBXApi.md#getcbxtreasury) | **GET** /v1/cbx/treasury | Your most recent reserve reconciliation.
[**ListCbxAdCreditLedger**](CBXApi.md#listcbxadcreditledger) | **GET** /v1/cbx/ad-credit/ledger | Ad-credit movements, newest first.
[**ListCbxBoosts**](CBXApi.md#listcbxboosts) | **GET** /v1/cbx/boosts | Your funded cashback boosts, newest first.
[**ListCbxCampaignPayouts**](CBXApi.md#listcbxcampaignpayouts) | **GET** /v1/cbx/campaigns/{campaignId}/payouts | What a campaign actually paid, with the weight behind each amount.
[**ListCbxCampaigns**](CBXApi.md#listcbxcampaigns) | **GET** /v1/cbx/campaigns | Your campaigns, newest first.
[**ListCbxDisbursementProgress**](CBXApi.md#listcbxdisbursementprogress) | **GET** /v1/cbx/disbursement-progress | How close each rule is to firing — the public counter.
[**ListCbxDisbursementRules**](CBXApi.md#listcbxdisbursementrules) | **GET** /v1/cbx/disbursement-rules | Threshold rules that fire community distributions.
[**ListCbxEarnTiers**](CBXApi.md#listcbxearntiers) | **GET** /v1/cbx/earn-tiers | Earn terms on offer — longer maturation, higher rate.
[**ListCbxRedemptionServices**](CBXApi.md#listcbxredemptionservices) | **GET** /v1/cbx/redemptions/services | Services payable in CBX, and the discount each carries.
[**ListCbxStakeTiers**](CBXApi.md#listcbxstaketiers) | **GET** /v1/cbx/stake-tiers | Staking tiers — what locking tokens buys.
[**ListCbxSubjectGrants**](CBXApi.md#listcbxsubjectgrants) | **GET** /v1/cbx/subjects/{subjectId}/grants | Live grants, soonest-expiring first.
[**ListCbxSubjectLedger**](CBXApi.md#listcbxsubjectledger) | **GET** /v1/cbx/subjects/{subjectId}/ledger | A subject&#39;s CBX ledger, newest first.
[**ListCbxWalletPaymentReview**](CBXApi.md#listcbxwalletpaymentreview) | **GET** /v1/cbx/wallet-payments/review | Payments held for a human — the ops queue.


<a name="createcbxaccrual"></a>
# **CreateCbxAccrual**
> CreateCbxAccrualResponse CreateCbxAccrual ()

Record cashback a user earned, in cents.

The accrual is PENDING until its maturation window closes, then converts to CBX at that moment's market price. It is denominated in cents the whole time it is pending, deliberately: quoting a token quantity up front and buying later would leave the reserve short for the length of the window. Send sourceExternalId and a retry is a no-op rather than a double credit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAccrualExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Record cashback a user earned, in cents.
                CreateCbxAccrualResponse result = apiInstance.CreateCbxAccrual();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAccrual: " + e.Message );
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

[**CreateCbxAccrualResponse**](CreateCbxAccrualResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxaccrualpurchase"></a>
# **CreateCbxAccrualPurchase**
> CreateCbxAccrualPurchaseResponse CreateCbxAccrualPurchase ()

Accrue cashback for an order at the resolved rate.

Prefer this over POST /accruals when you want us to do the rate maths — it resolves the tier, the boost and the stake boost, charges your boost budget in the same transaction, and records what rate was actually granted. If a matching boost cannot fund the order, the accrual falls back to your un-boosted rate and `boostBudgetExhausted` is true. Idempotent on externalId: a retried webhook neither accrues twice nor charges your budget twice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAccrualPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Accrue cashback for an order at the resolved rate.
                CreateCbxAccrualPurchaseResponse result = apiInstance.CreateCbxAccrualPurchase();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAccrualPurchase: " + e.Message );
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

[**CreateCbxAccrualPurchaseResponse**](CreateCbxAccrualPurchaseResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxaccrualreverse"></a>
# **CreateCbxAccrualReverse**
> CreateCbxAccrualReverseResponse CreateCbxAccrualReverse (string accrualId)

Claw back a pending accrual — a refund, a cancellation, fraud.

Only works while the accrual is still pending. Once it has converted, the value is tokens in somebody's balance and this is the wrong operation: reversing then is a debit against that balance, which is a different act with different consequences and is not something an integration key can do. This is why the maturation window has to be at least as long as your refund window.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAccrualReverseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var accrualId = "accrualId_example";  // string | 

            try
            {
                // Claw back a pending accrual — a refund, a cancellation, fraud.
                CreateCbxAccrualReverseResponse result = apiInstance.CreateCbxAccrualReverse(accrualId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAccrualReverse: " + e.Message );
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
 **accrualId** | **string**|  | 

### Return type

[**CreateCbxAccrualReverseResponse**](CreateCbxAccrualReverseResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxadcreditpurchase"></a>
# **CreateCbxAdCreditPurchase**
> CreateCbxAdCreditPurchaseResponse CreateCbxAdCreditPurchase ()

Claim ad credit against a CBX transfer you sent.

Send CBX to our revenue wallet yourself, then present the signature. We read the actual balance delta at FINALIZED commitment — a confirmed transaction can still be dropped by a fork, and this grants real credit. One signature can be claimed exactly once. Priced at the spot when the claim is processed, not when you signed: pricing at send time would let somebody hold signed transfers and claim only the ones that moved in their favour. A 409 means the transaction has not finalized yet and you should retry; a 400 means it will never be claimable (failed, wrong mint, wrong destination).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAdCreditPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Claim ad credit against a CBX transfer you sent.
                CreateCbxAdCreditPurchaseResponse result = apiInstance.CreateCbxAdCreditPurchase();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAdCreditPurchase: " + e.Message );
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

[**CreateCbxAdCreditPurchaseResponse**](CreateCbxAdCreditPurchaseResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxadcreditquote"></a>
# **CreateCbxAdCreditQuote**
> CreateCbxAdCreditQuoteResponse CreateCbxAdCreditQuote ()

What a given number of tokens buys in ad credit.

Credit is 1:1 with the market value of the tokens at confirmation. Refuses with 409 when there is no fresh price — pricing an entire prepaid budget off a guess is not something to do quietly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAdCreditQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // What a given number of tokens buys in ad credit.
                CreateCbxAdCreditQuoteResponse result = apiInstance.CreateCbxAdCreditQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAdCreditQuote: " + e.Message );
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

[**CreateCbxAdCreditQuoteResponse**](CreateCbxAdCreditQuoteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxadcreditspend"></a>
# **CreateCbxAdCreditSpend**
> CreateCbxAdCreditSpendResponse CreateCbxAdCreditSpend ()

Consume credit for a billing period.

Spends what the balance covers and reports the rest as `shortfallCents` — the campaign should stop there rather than running on credit that does not exist. 20% of what is spent moves to the community events pool and 80% is operator revenue; the split happens on SPEND rather than at purchase, because the pool's share is earned when the advertising is actually delivered. Idempotent on externalId: pass your billing-period id so a retried run does not consume the same credit twice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxAdCreditSpendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Consume credit for a billing period.
                CreateCbxAdCreditSpendResponse result = apiInstance.CreateCbxAdCreditSpend();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxAdCreditSpend: " + e.Message );
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

[**CreateCbxAdCreditSpendResponse**](CreateCbxAdCreditSpendResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxboost"></a>
# **CreateCbxBoost**
> CreateCbxBoostResponse CreateCbxBoost ()

Fund elevated cashback on matching items.

Performance marketing priced in CBX: the spend lands as a durable balance the buyer returns to use, rather than a one-time price cut they pocket. A boost REPLACES the base or tier rate rather than adding to it — you are stating the total you will pay, and it is priced against your margin. Targeting is matched by equality on one facet; most specific wins (sku > collection > category > all). Kinds: all, category, sku, collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxBoostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Fund elevated cashback on matching items.
                CreateCbxBoostResponse result = apiInstance.CreateCbxBoost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxBoost: " + e.Message );
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

[**CreateCbxBoostResponse**](CreateCbxBoostResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxboostpause"></a>
# **CreateCbxBoostPause**
> CreateCbxBoostPauseResponse CreateCbxBoostPause (string boostId)

Stop a boost from matching further orders.

Pausing does not refund anything — already-accrued cashback is a promise already made to a buyer, and unwinding it would take back cashback somebody was shown at checkout. The remaining budget simply stops being spendable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxBoostPauseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var boostId = "boostId_example";  // string | 

            try
            {
                // Stop a boost from matching further orders.
                CreateCbxBoostPauseResponse result = apiInstance.CreateCbxBoostPause(boostId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxBoostPause: " + e.Message );
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
 **boostId** | **string**|  | 

### Return type

[**CreateCbxBoostPauseResponse**](CreateCbxBoostPauseResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcampaign"></a>
# **CreateCbxCampaign**
> CreateCbxCampaignResponse CreateCbxCampaign ()

Create a campaign in draft.

Nothing is paid until it is previewed, approved and executed. Available metrics: accruals_count, accrued_cents, spend_count, spend_base_units — all of them measure activity inside the window. `capPerSubject` is worth setting on a proportional campaign: without it one large participant can take almost the whole pool, which makes the event pointless for everybody else.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Create a campaign in draft.
                CreateCbxCampaignResponse result = apiInstance.CreateCbxCampaign();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCampaign: " + e.Message );
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

[**CreateCbxCampaignResponse**](CreateCbxCampaignResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcampaignapprove"></a>
# **CreateCbxCampaignApprove**
> CreateCbxCampaignApproveResponse CreateCbxCampaignApprove (string campaignId)

Approve the previewed recipient list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCampaignApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var campaignId = "campaignId_example";  // string | 

            try
            {
                // Approve the previewed recipient list.
                CreateCbxCampaignApproveResponse result = apiInstance.CreateCbxCampaignApprove(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCampaignApprove: " + e.Message );
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
 **campaignId** | **string**|  | 

### Return type

[**CreateCbxCampaignApproveResponse**](CreateCbxCampaignApproveResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcampaignexecute"></a>
# **CreateCbxCampaignExecute**
> CreateCbxCampaignExecuteResponse CreateCbxCampaignExecute (string campaignId)

Pay an approved campaign.

Recomputes the list and refuses if the hash no longer matches the approved one. Payouts credit balances directly rather than transferring on chain, so a distribution to ten thousand recipients costs one internal move and is reversible if it was computed wrong.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCampaignExecuteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var campaignId = "campaignId_example";  // string | 

            try
            {
                // Pay an approved campaign.
                CreateCbxCampaignExecuteResponse result = apiInstance.CreateCbxCampaignExecute(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCampaignExecute: " + e.Message );
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
 **campaignId** | **string**|  | 

### Return type

[**CreateCbxCampaignExecuteResponse**](CreateCbxCampaignExecuteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcampaignpreview"></a>
# **CreateCbxCampaignPreview**
> CreateCbxCampaignPreviewResponse CreateCbxCampaignPreview (string campaignId)

Compute the recipient list without paying it.

Returns every recipient and amount, plus a hash of the list. Re-previewing invalidates any prior approval by design — the approver signed off on a specific list, and if it has changed they have not approved what would now happen.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCampaignPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var campaignId = "campaignId_example";  // string | 

            try
            {
                // Compute the recipient list without paying it.
                CreateCbxCampaignPreviewResponse result = apiInstance.CreateCbxCampaignPreview(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCampaignPreview: " + e.Message );
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
 **campaignId** | **string**|  | 

### Return type

[**CreateCbxCampaignPreviewResponse**](CreateCbxCampaignPreviewResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxclaim"></a>
# **CreateCbxClaim**
> CreateCbxClaimResponse CreateCbxClaim ()

Reserve a claim. Debits the balance and queues the transfer.

The balance is debited here, before anything is sent, which is the only safe order: sending first and debiting after means a crash between the two pays somebody and never charges them, and that is unrecoverable. A crash after this leaves a reserved balance and a pending claim, which is recoverable by looking at the chain. Send the same idempotencyKey to retry safely.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Reserve a claim. Debits the balance and queues the transfer.
                CreateCbxClaimResponse result = apiInstance.CreateCbxClaim();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxClaim: " + e.Message );
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

[**CreateCbxClaimResponse**](CreateCbxClaimResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxclaimquote"></a>
# **CreateCbxClaimQuote**
> CreateCbxClaimQuoteResponse CreateCbxClaimQuote ()

What a claim would cost, without committing to it.

Every fee at cost, so a confirm screen can show the breakdown before the user agrees. The network fee is passed through at actual cost and includes the one-time account rent when the recipient has no token account yet — that rent is a recoverable deposit on an account the USER owns, not a fee we keep.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxClaimQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // What a claim would cost, without committing to it.
                CreateCbxClaimQuoteResponse result = apiInstance.CreateCbxClaimQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxClaimQuote: " + e.Message );
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

[**CreateCbxClaimQuoteResponse**](CreateCbxClaimQuoteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxclaimsend"></a>
# **CreateCbxClaimSend**
> CreateCbxClaimSendResponse CreateCbxClaimSend (string claimId)

Send a reserved claim on chain.

Re-checks every precondition rather than trusting the reservation: the delegation may have been revoked, the fee payer may have run dry, the address may have been flagged since. A response of `unconfirmed` means the transfer may have landed but confirmation was not observed — do NOT retry it, it needs reconciliation against the chain first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxClaimSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var claimId = "claimId_example";  // string | 

            try
            {
                // Send a reserved claim on chain.
                CreateCbxClaimSendResponse result = apiInstance.CreateCbxClaimSend(claimId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxClaimSend: " + e.Message );
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
 **claimId** | **string**|  | 

### Return type

[**CreateCbxClaimSendResponse**](CreateCbxClaimSendResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcreditdraw"></a>
# **CreateCbxCreditDraw**
> CreateCbxCreditDrawResponse CreateCbxCreditDraw ()

Draw against a line, receiving grant credit.

The advance lands as GRANT balance: in-platform only, so it cannot be withdrawn, cannot be turned into cash and absconded with, and adds nothing to the float that could hit an order book. Restricted to wholesale channels — the limit was sized on the theory that the advance buys goods that get sold and generate the payout stream repaying it, and credit spent on a subscription does not create that stream. Refuses if the reserve has no unallocated tokens: credit is real value and cannot be advanced against tokens that do not exist. Idempotent on externalId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCreditDrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Draw against a line, receiving grant credit.
                CreateCbxCreditDrawResponse result = apiInstance.CreateCbxCreditDraw();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCreditDraw: " + e.Message );
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

[**CreateCbxCreditDrawResponse**](CreateCbxCreditDrawResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcreditfreeze"></a>
# **CreateCbxCreditFreeze**
> CreateCbxCreditFreezeResponse CreateCbxCreditFreeze ()

Stop new draws. Leaves the drawn balance on its terms.

The only lever over a line, and deliberately the only one. A seller who took inventory on Tuesday keeps Tuesday's terms whatever the token does on Wednesday — the only way a credit product sits next to a volatile asset without transmitting its volatility.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCreditFreezeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Stop new draws. Leaves the drawn balance on its terms.
                CreateCbxCreditFreezeResponse result = apiInstance.CreateCbxCreditFreeze();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCreditFreeze: " + e.Message );
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

[**CreateCbxCreditFreezeResponse**](CreateCbxCreditFreezeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcreditrefresh"></a>
# **CreateCbxCreditRefresh**
> CreateCbxCreditRefreshResponse CreateCbxCreditRefresh ()

Recompute a limit from trading history and stake.

The earned limit is a share of trailing SETTLED payout volume — money that actually reached the seller, not listed inventory or projected sales. The stake bonus is capped at a share of that, so a seller with no history gets nothing however much they stake. A frozen line stays frozen: freezing is a credit decision somebody made, and a recompute must not quietly undo it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCreditRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Recompute a limit from trading history and stake.
                CreateCbxCreditRefreshResponse result = apiInstance.CreateCbxCreditRefresh();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCreditRefresh: " + e.Message );
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

[**CreateCbxCreditRefreshResponse**](CreateCbxCreditRefreshResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxcreditrepay"></a>
# **CreateCbxCreditRepay**
> CreateCbxCreditRepayResponse CreateCbxCreditRepay ()

Apply a repayment to a line.

`treasury` scope, which looks backwards next to a draw needing only `spend` and is deliberate: a forged repayment writes off real money owed to us, while a forged draw hands out credit spendable only in our own marketplace. The scope follows the loss. Clamped to what is outstanding — a payout larger than the debt would otherwise push the balance negative and read as credit nobody underwrote.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxCreditRepayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Apply a repayment to a line.
                CreateCbxCreditRepayResponse result = apiInstance.CreateCbxCreditRepay();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxCreditRepay: " + e.Message );
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

[**CreateCbxCreditRepayResponse**](CreateCbxCreditRepayResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxdisbursementrule"></a>
# **CreateCbxDisbursementRule**
> CreateCbxDisbursementRuleResponse CreateCbxDisbursementRule ()

Fire a distribution when the events pool crosses a threshold.

Applies to the EVENTS POOL only — never free reserve surplus. Reserve surplus is the recirculation buffer that funds the next accrual without touching the market, so distributing it would force us to buy the same tokens back at spread plus MEV. `checkCadenceHours` bounds how often the rule may fire even when the pool is over the line: a pure threshold fires at an unpredictable moment, and the pool jumps most after a lapse sweep — precisely when engagement was worst. `distributeBps` is capped under 100% because draining the pool removes the standing balance that makes the next event credible. The rule decides WHEN only: firing opens a campaign that still needs preview, approval and execution. Metrics: accruals_count, accrued_cents, spend_count, spend_base_units.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxDisbursementRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Fire a distribution when the events pool crosses a threshold.
                CreateCbxDisbursementRuleResponse result = apiInstance.CreateCbxDisbursementRule();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxDisbursementRule: " + e.Message );
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

[**CreateCbxDisbursementRuleResponse**](CreateCbxDisbursementRuleResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxdisbursementruleactive"></a>
# **CreateCbxDisbursementRuleActive**
> CreateCbxDisbursementRuleActiveResponse CreateCbxDisbursementRuleActive (string ruleId)

Enable or disable a rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxDisbursementRuleActiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var ruleId = "ruleId_example";  // string | 

            try
            {
                // Enable or disable a rule.
                CreateCbxDisbursementRuleActiveResponse result = apiInstance.CreateCbxDisbursementRuleActive(ruleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxDisbursementRuleActive: " + e.Message );
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
 **ruleId** | **string**|  | 

### Return type

[**CreateCbxDisbursementRuleActiveResponse**](CreateCbxDisbursementRuleActiveResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxdisbursementrulecheck"></a>
# **CreateCbxDisbursementRuleCheck**
> CreateCbxDisbursementRuleCheckResponse CreateCbxDisbursementRuleCheck (string ruleId)

Evaluate a rule now. Fires it if every gate passes.

Gates in order: cadence, threshold, coverage. `outcome` names the one that stopped it — every evaluation is recorded including the declines, because \"why didn't the event happen\" is the question people ask and the answer is always a check that ran and said no. A missing or stale treasury snapshot declines on `coverage`: unknown coverage is not healthy coverage. Send dryRun to evaluate without opening a campaign or writing anything.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxDisbursementRuleCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var ruleId = "ruleId_example";  // string | 

            try
            {
                // Evaluate a rule now. Fires it if every gate passes.
                CreateCbxDisbursementRuleCheckResponse result = apiInstance.CreateCbxDisbursementRuleCheck(ruleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxDisbursementRuleCheck: " + e.Message );
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
 **ruleId** | **string**|  | 

### Return type

[**CreateCbxDisbursementRuleCheckResponse**](CreateCbxDisbursementRuleCheckResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxearntier"></a>
# **CreateCbxEarnTier**
> CreateCbxEarnTierResponse CreateCbxEarnTier ()

Define an earn term.

Setting `isDefault` moves the default off whatever held it — exactly one active default per merchant is enforced by a unique index, because two would make \"what rate did this user get\" depend on row order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxEarnTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Define an earn term.
                CreateCbxEarnTierResponse result = apiInstance.CreateCbxEarnTier();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxEarnTier: " + e.Message );
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

[**CreateCbxEarnTierResponse**](CreateCbxEarnTierResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxratequote"></a>
# **CreateCbxRateQuote**
> CreateCbxRateQuoteResponse CreateCbxRateQuote ()

What would this order earn, and why.

Resolve the rate without accruing anything, so a checkout can show the real number and its reason. `source` tells you whether it came from your base rate, a tier, or a boost; `stakeBoostBps` is the part the user's own stake contributed. Quoting does NOT reserve boost budget — a quote and the subsequent accrual can differ if the budget runs out in between, which is why the accrual response repeats the rate it actually granted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxRateQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // What would this order earn, and why.
                CreateCbxRateQuoteResponse result = apiInstance.CreateCbxRateQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxRateQuote: " + e.Message );
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

[**CreateCbxRateQuoteResponse**](CreateCbxRateQuoteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxredemption"></a>
# **CreateCbxRedemption**
> CreateCbxRedemptionResponse CreateCbxRedemption ()

Pay for a service in CBX.

Idempotent on (serviceKind, externalId) rather than externalId alone: a grading submission and a listing boost can legitimately share an id because they refer to the same item, and without the service in the key, boosting a listing you had already graded would return the grading receipt and never charge for the boost. Staked tokens cannot pay — the debit checks spendable balance, not total.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxRedemptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Pay for a service in CBX.
                CreateCbxRedemptionResponse result = apiInstance.CreateCbxRedemption();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxRedemption: " + e.Message );
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

[**CreateCbxRedemptionResponse**](CreateCbxRedemptionResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxredemptionquote"></a>
# **CreateCbxRedemptionQuote**
> CreateCbxRedemptionQuoteResponse CreateCbxRedemptionQuote ()

What a service costs in tokens right now.

Refuses with 409 when there is no fresh price. A dollar-priced service has no honest token quantity without a spot, and there is no safe direction to guess in — a guess either overcharges the user or undercharges us.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxRedemptionQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // What a service costs in tokens right now.
                CreateCbxRedemptionQuoteResponse result = apiInstance.CreateCbxRedemptionQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxRedemptionQuote: " + e.Message );
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

[**CreateCbxRedemptionQuoteResponse**](CreateCbxRedemptionQuoteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxrevenuesweep"></a>
# **CreateCbxRevenueSweep**
> CreateCbxRevenueSweepResponse CreateCbxRevenueSweep ()

Move accrued revenue from the reserve to your revenue wallet.

Computes what is genuinely free — reserve minus outstanding balances, minus claims in flight, minus the pool, minus unswept revenue — and moves at most that. If the reserve is short it moves NOTHING, whatever the ledger says: an under-covered reserve is not a reason to stop paying users, it is a reason to stop paying yourself. Send dryRun to see the arithmetic without moving tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxRevenueSweepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Move accrued revenue from the reserve to your revenue wallet.
                CreateCbxRevenueSweepResponse result = apiInstance.CreateCbxRevenueSweep();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxRevenueSweep: " + e.Message );
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

[**CreateCbxRevenueSweepResponse**](CreateCbxRevenueSweepResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxspend"></a>
# **CreateCbxSpend**
> CreateCbxSpendResponse CreateCbxSpend ()

Redeem a user's CBX against an order.

Debits the user exactly what they spent — the skim is never added on top, because making CBX worth less when used than when sold would invert the whole reason to spend rather than liquidate. The skim comes out of YOUR fee on the order and is capped against it, so an order paid entirely in saved-up CBX does not have its whole margin eaten. Idempotent on externalId: a retried checkout returns the original spend rather than debiting twice. Spending is always free and has no minimum — that asymmetry against the withdrawal fee is what steers toward spending without ever telling anyone they cannot have their money.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSpendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Redeem a user's CBX against an order.
                CreateCbxSpendResponse result = apiInstance.CreateCbxSpend();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSpend: " + e.Message );
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

[**CreateCbxSpendResponse**](CreateCbxSpendResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxspendreverse"></a>
# **CreateCbxSpendReverse**
> CreateCbxSpendReverseResponse CreateCbxSpendReverse (string externalId)

Refund a spend — give the tokens back and claw the skim back.

Returns the user's tokens AND reverses the skim out of both the community pool and operator revenue. All three move together: returning the tokens while the pool and operator kept their shares would count the same tokens twice against one reserve. The spend also stops counting as activity for campaign weighting, so buy-then-refund cannot farm distributions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSpendReverseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var externalId = "externalId_example";  // string | 

            try
            {
                // Refund a spend — give the tokens back and claw the skim back.
                CreateCbxSpendReverseResponse result = apiInstance.CreateCbxSpendReverse(externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSpendReverse: " + e.Message );
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
 **externalId** | **string**|  | 

### Return type

[**CreateCbxSpendReverseResponse**](CreateCbxSpendReverseResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxstaketier"></a>
# **CreateCbxStakeTier**
> CreateCbxStakeTierResponse CreateCbxStakeTier ()

Define a staking tier.

A user gets the highest tier their amount clears. `cooldownDays` is what makes the discount real: without a wait, a user stakes for the discount and unstakes the moment they want to withdraw, so the commitment it was priced against never existed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxStakeTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Define a staking tier.
                CreateCbxStakeTierResponse result = apiInstance.CreateCbxStakeTier();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxStakeTier: " + e.Message );
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

[**CreateCbxStakeTierResponse**](CreateCbxStakeTierResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxsubject"></a>
# **CreateCbxSubject**
> CreateCbxSubjectResponse CreateCbxSubject ()

Map one of your user ids to a CBX subject.

Idempotent. Call it whenever you need a subject id; repeated calls with the same externalUserId return the same subject. Your user ids are opaque to us and unique only within your merchant, so two marketplaces can both have a user \"1\" without collision.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Map one of your user ids to a CBX subject.
                CreateCbxSubjectResponse result = apiInstance.CreateCbxSubject();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSubject: " + e.Message );
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

[**CreateCbxSubjectResponse**](CreateCbxSubjectResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxsubjectgrant"></a>
# **CreateCbxSubjectGrant**
> CreateCbxSubjectGrantResponse CreateCbxSubjectGrant (string subjectId)

Issue grant credit — in-platform, non-withdrawable.

Requires a funding `batchId` for every kind except `grant_makegood`. Grant credit is spendable at merchants who receive real value, so the tokens have to exist — the same rule earned balance obeys. A makegood is exempt because compensating somebody for our failure must not be blocked on treasury state. There is no path that converts a grant to earned balance or pays it to an address, and the database enforces that rather than a comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSubjectGrantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Issue grant credit — in-platform, non-withdrawable.
                CreateCbxSubjectGrantResponse result = apiInstance.CreateCbxSubjectGrant(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSubjectGrant: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**CreateCbxSubjectGrantResponse**](CreateCbxSubjectGrantResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxsubjectspendplan"></a>
# **CreateCbxSubjectSpendPlan**
> CreateCbxSubjectSpendPlanResponse CreateCbxSubjectSpendPlan (string subjectId)

Which balances would pay for a spend, and in what order.

The order is granted → earned → connected and you do not get to choose it. Granted first is a security property, not a preference: if earned spent first, a subject holding both would spend their withdrawable balance down while their non-withdrawable grant sat untouched — converting a grant into a withdrawable balance one purchase at a time. Returns a `shortfallBaseUnits` rather than failing, so a checkout can charge the remainder to a card. Send excludeConnected on a flow that cannot wait for an on-chain transfer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSubjectSpendPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Which balances would pay for a spend, and in what order.
                CreateCbxSubjectSpendPlanResponse result = apiInstance.CreateCbxSubjectSpendPlan(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSubjectSpendPlan: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**CreateCbxSubjectSpendPlanResponse**](CreateCbxSubjectSpendPlanResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxsubjectstake"></a>
# **CreateCbxSubjectStake**
> CreateCbxSubjectStakeResponse CreateCbxSubjectStake (string subjectId)

Lock a subject's tokens for a tier.

Refuses an amount that clears no tier — locking tokens for no benefit is never what somebody meant to do. One stake per subject: to change the amount, unstake and wait out the cooldown first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSubjectStakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Lock a subject's tokens for a tier.
                CreateCbxSubjectStakeResponse result = apiInstance.CreateCbxSubjectStake(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSubjectStake: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**CreateCbxSubjectStakeResponse**](CreateCbxSubjectStakeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxsubjectstakeunstake"></a>
# **CreateCbxSubjectStakeUnstake**
> CreateCbxSubjectStakeUnstakeResponse CreateCbxSubjectStakeUnstake (string subjectId)

Start the cooldown. Tokens unlock when it elapses.

The earn boost stops immediately; the tokens stay locked until `unlocksAt`. The cooldown is read from the tier as configured NOW, which is the one place a later config change is allowed to matter — holding somebody to a longer wait the merchant has since abandoned would be the worse behaviour.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxSubjectStakeUnstakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Start the cooldown. Tokens unlock when it elapses.
                CreateCbxSubjectStakeUnstakeResponse result = apiInstance.CreateCbxSubjectStakeUnstake(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxSubjectStakeUnstake: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**CreateCbxSubjectStakeUnstakeResponse**](CreateCbxSubjectStakeUnstakeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxwalletchallenge"></a>
# **CreateCbxWalletChallenge**
> CreateCbxWalletChallengeResponse CreateCbxWalletChallenge ()

Start wallet verification. Returns a message for the user to sign.

Present the returned `message` verbatim to the user's wallet for signing. It binds your merchant, their subject, the address and a single-use nonce, so the resulting signature is not transferable to another address or account. A signature is required because there is no custody here: a send cannot be undone, so a typo or a swapped address is permanent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxWalletChallengeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Start wallet verification. Returns a message for the user to sign.
                CreateCbxWalletChallengeResponse result = apiInstance.CreateCbxWalletChallenge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxWalletChallenge: " + e.Message );
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

[**CreateCbxWalletChallengeResponse**](CreateCbxWalletChallengeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxwalletpaymentconfirm"></a>
# **CreateCbxWalletPaymentConfirm**
> CreateCbxWalletPaymentConfirmResponse CreateCbxWalletPaymentConfirm ()

Present the signature. Returns a ship / do-not-ship decision.

Everything is read from the CHAIN at finalized commitment — the amount, the payer, the destination. Nothing you assert about the payment is trusted, because a client that can state its own payment amount can state a larger one. The response `releaseDecision` is about the ORDER, not the payment: by the time we see a signature the tokens have moved and cannot be un-moved, so the only decision left is whether to hand over goods. `release` means ship. `review` means hold — a person needs to look, and that includes the case where no screening provider is configured. `refuse` means do not ship; the payment is still recorded, because we received the tokens and that fact does not go away. Idempotent twice over: on txSig globally, so one payment cannot pay two orders, and on (merchant, externalId), so one order is not paid twice. A 409 means the transaction has not finalized yet and you should retry; a 400 means it never will be claimable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxWalletPaymentConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Present the signature. Returns a ship / do-not-ship decision.
                CreateCbxWalletPaymentConfirmResponse result = apiInstance.CreateCbxWalletPaymentConfirm();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxWalletPaymentConfirm: " + e.Message );
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

[**CreateCbxWalletPaymentConfirmResponse**](CreateCbxWalletPaymentConfirmResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxwalletpaymentquote"></a>
# **CreateCbxWalletPaymentQuote**
> CreateCbxWalletPaymentQuoteResponse CreateCbxWalletPaymentQuote ()

Build a transfer for the buyer to sign themselves.

Returns an unsigned, base64 transaction. The buyer's wallet signs and submits it; we never hold a key or a delegation and never submit anything, so the platform has no authority over their tokens at any point. RESERVES NOTHING — no row, no hold, no balance change. The buyer may never sign it. The SIGNATURE is the event, so treat this as a convenience and not a commitment. `lastValidBlockHeight` is when it expires: a wallet prompt left open for a couple of minutes produces a transaction the chain will reject, and you should re-quote rather than retry. `payerCanCover` is a courtesy read of their balance so you can warn before a prompt rather than after a failure; null means we could not read it, which is not the same as \"no\". The buyer needs no prior wallet registration: a payment proves control of the tokens, which is what a connect-and-verify step would have been proving.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxWalletPaymentQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Build a transfer for the buyer to sign themselves.
                CreateCbxWalletPaymentQuoteResponse result = apiInstance.CreateCbxWalletPaymentQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxWalletPaymentQuote: " + e.Message );
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

[**CreateCbxWalletPaymentQuoteResponse**](CreateCbxWalletPaymentQuoteResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxwalletpaymentresolve"></a>
# **CreateCbxWalletPaymentResolve**
> CreateCbxWalletPaymentResolveResponse CreateCbxWalletPaymentResolve (string paymentId)

A human decides on a held payment.

Only moves a payment OUT of `review`, never between the other two. A refusal that could later be flipped to a release is an approval control with no teeth, and a release re-decided as a refusal after the goods shipped is a record that no longer describes what happened. The reviewer and their note are stored on the row, because this is the decision somebody will be asked to justify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxWalletPaymentResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var paymentId = "paymentId_example";  // string | 

            try
            {
                // A human decides on a held payment.
                CreateCbxWalletPaymentResolveResponse result = apiInstance.CreateCbxWalletPaymentResolve(paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxWalletPaymentResolve: " + e.Message );
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
 **paymentId** | **string**|  | 

### Return type

[**CreateCbxWalletPaymentResolveResponse**](CreateCbxWalletPaymentResolveResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcbxwalletverify"></a>
# **CreateCbxWalletVerify**
> CreateCbxWalletVerifyResponse CreateCbxWalletVerify ()

Complete wallet verification with the user's signature.

The signature is checked against the message WE issued and stored, never one supplied here. The nonce is single-use, so the same signature cannot re-verify an address later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCbxWalletVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Complete wallet verification with the user's signature.
                CreateCbxWalletVerifyResponse result = apiInstance.CreateCbxWalletVerify();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.CreateCbxWalletVerify: " + e.Message );
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

[**CreateCbxWalletVerifyResponse**](CreateCbxWalletVerifyResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxadcredit"></a>
# **GetCbxAdCredit**
> GetCbxAdCreditResponse GetCbxAdCredit ()

Unspent advertising credit, in cents.

Advertising is payable in CBX and nothing else. Your budget is denominated in dollars, priced at the spot when your payment finalized — deliberately NOT held as a token quantity, since a price move would otherwise silently change the budget you prepaid, making you a market participant because you bought ads. Credit is 1:1 with market value: with CBX the only way to pay there is nothing to discount against. Spendable on advertising only, and not refundable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxAdCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Unspent advertising credit, in cents.
                GetCbxAdCreditResponse result = apiInstance.GetCbxAdCredit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxAdCredit: " + e.Message );
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

[**GetCbxAdCreditResponse**](GetCbxAdCreditResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxclaim"></a>
# **GetCbxClaim**
> GetCbxClaimResponse GetCbxClaim (string claimId)

A claim's current state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var claimId = "claimId_example";  // string | 

            try
            {
                // A claim's current state.
                GetCbxClaimResponse result = apiInstance.GetCbxClaim(claimId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxClaim: " + e.Message );
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
 **claimId** | **string**|  | 

### Return type

[**GetCbxClaimResponse**](GetCbxClaimResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxcredit"></a>
# **GetCbxCredit**
> GetCbxCreditResponse GetCbxCredit ()

A seller's wholesale credit line.

Trade credit, not token-collateralized lending. The line is secured by receivables we already hold — the payout stream sits under a hold with an exposure ceiling — and secondarily by goods bought from our own wholesale channel. CBX is the alignment mechanism, not the collateral: a stake raises the limit and lowers the rate, bounded to a share of the earned limit so a price collapse can never remove the majority of a facility. The limit may FALL. A drawn balance is never accelerated or margin-called — there is no liquidation engine, no keeper and no oracle trigger anywhere in it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // A seller's wholesale credit line.
                GetCbxCreditResponse result = apiInstance.GetCbxCredit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxCredit: " + e.Message );
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

[**GetCbxCreditResponse**](GetCbxCreditResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxme"></a>
# **GetCbxMe**
> GetCbxMeResponse GetCbxMe ()

Identity check — which merchant this key belongs to, and its terms.

Returns the economics your merchant is configured with, so an integration can display accurate terms rather than hard-coding ours. Note `claimsEnabled`: off means balances are store credit that cannot leave, which is the default and the smaller regulatory posture.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Identity check — which merchant this key belongs to, and its terms.
                GetCbxMeResponse result = apiInstance.GetCbxMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxMe: " + e.Message );
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

[**GetCbxMeResponse**](GetCbxMeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxpool"></a>
# **GetCbxPool**
> GetCbxPoolResponse GetCbxPool ()

Your events-pool balance.

Funded by the skim on in-marketplace CBX spending, the community share of withdrawal fees, and lapsed balances. Sponsor budgets are tracked separately and are not included here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxPoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Your events-pool balance.
                GetCbxPoolResponse result = apiInstance.GetCbxPool();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxPool: " + e.Message );
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

[**GetCbxPoolResponse**](GetCbxPoolResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxrevenue"></a>
# **GetCbxRevenue**
> GetCbxRevenueResponse GetCbxRevenue ()

Operator revenue accrued and not yet withdrawn.

Your share of the spend skim plus your half of withdrawal fees, denominated in CBX. It sits inside the reserve until swept, which is why it is tracked here rather than inferred: without a number saying how much of the reserve is yours, there is no safe amount to take out.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxRevenueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Operator revenue accrued and not yet withdrawn.
                GetCbxRevenueResponse result = apiInstance.GetCbxRevenue();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxRevenue: " + e.Message );
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

[**GetCbxRevenueResponse**](GetCbxRevenueResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxsubjectbalance"></a>
# **GetCbxSubjectBalance**
> GetCbxSubjectBalanceResponse GetCbxSubjectBalance (string subjectId)

What a subject holds: pending cents and available CBX.

Two numbers because they are two different things. `pendingCents` is cashback earned but still inside its window — reversible, denominated in dollars, not yet tokens. `availableBaseUnits` is CBX they hold now. Amounts are strings because a token balance can exceed what a JSON number represents exactly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxSubjectBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // What a subject holds: pending cents and available CBX.
                GetCbxSubjectBalanceResponse result = apiInstance.GetCbxSubjectBalance(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxSubjectBalance: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**GetCbxSubjectBalanceResponse**](GetCbxSubjectBalanceResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxsubjectbalancebysubjectid"></a>
# **GetCbxSubjectBalanceBySubjectId**
> GetCbxSubjectBalanceBySubjectIdResponse GetCbxSubjectBalanceBySubjectId (string subjectId)

All three balances a subject holds.

EARNED is cashback and affiliate accruals — withdrawable once matured and above the claim floor. GRANTED is ad credit, wholesale draws and promos — spendable in your marketplace only, never withdrawable, so it creates no sell pressure. CONNECTED is the subject's own self-custodied CBX, reachable through a bounded delegation; it was never our liability and does not enter the reserve invariant. `connectedAvailableBaseUnits` is delegation HEADROOM, not a wallet balance — the subject may hold less than they approved, or have revoked on chain without telling us, so treat it as a ceiling and let the spend re-read the chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxSubjectBalanceBySubjectIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // All three balances a subject holds.
                GetCbxSubjectBalanceBySubjectIdResponse result = apiInstance.GetCbxSubjectBalanceBySubjectId(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxSubjectBalanceBySubjectId: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**GetCbxSubjectBalanceBySubjectIdResponse**](GetCbxSubjectBalanceBySubjectIdResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxsubjectspent"></a>
# **GetCbxSubjectSpent**
> GetCbxSubjectSpentResponse GetCbxSubjectSpent (string subjectId)

Total CBX a subject has spent in your marketplace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxSubjectSpentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Total CBX a subject has spent in your marketplace.
                GetCbxSubjectSpentResponse result = apiInstance.GetCbxSubjectSpent(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxSubjectSpent: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**GetCbxSubjectSpentResponse**](GetCbxSubjectSpentResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxsubjectstake"></a>
# **GetCbxSubjectStake**
> GetCbxSubjectStakeResponse GetCbxSubjectStake (string subjectId)

A subject's staking state and spendable balance.

`availableBaseUnits` is the number a checkout must use — balance minus anything locked. `earnBoostBps` reads zero once an unstake has been requested, because the boost ends with the commitment; `feeDiscountBps` survives the cooldown, since withdrawing is exactly what somebody in cooldown is trying to do.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxSubjectStakeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // A subject's staking state and spendable balance.
                GetCbxSubjectStakeResponse result = apiInstance.GetCbxSubjectStake(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxSubjectStake: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**GetCbxSubjectStakeResponse**](GetCbxSubjectStakeResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxsubjectwallet"></a>
# **GetCbxSubjectWallet**
> GetCbxSubjectWalletResponse GetCbxSubjectWallet (string subjectId)

The verified payout address for a subject, if any.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxSubjectWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // The verified payout address for a subject, if any.
                GetCbxSubjectWalletResponse result = apiInstance.GetCbxSubjectWallet(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxSubjectWallet: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**GetCbxSubjectWalletResponse**](GetCbxSubjectWalletResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcbxtreasury"></a>
# **GetCbxTreasury**
> GetCbxTreasuryResponse GetCbxTreasury ()

Your most recent reserve reconciliation.

Coverage is your reserve measured against what you owe your users, including claims already in flight. Below 100% your conversions stop — we will not credit balances that nothing backs. Claims and spends keep working, because those move value out and improve coverage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCbxTreasuryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Your most recent reserve reconciliation.
                GetCbxTreasuryResponse result = apiInstance.GetCbxTreasury();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.GetCbxTreasury: " + e.Message );
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

[**GetCbxTreasuryResponse**](GetCbxTreasuryResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxadcreditledger"></a>
# **ListCbxAdCreditLedger**
> V1List ListCbxAdCreditLedger ()

Ad-credit movements, newest first.

Append-only. `purchase_cbx` and `grant` add; `ad_spend` and `expire` subtract. There is no refund kind and there will not be one: advertising credit exists to buy advertising, and any exit at face value turns it into a currency exchange.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxAdCreditLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Ad-credit movements, newest first.
                V1List result = apiInstance.ListCbxAdCreditLedger();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxAdCreditLedger: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxboosts"></a>
# **ListCbxBoosts**
> V1List ListCbxBoosts ()

Your funded cashback boosts, newest first.

`spentCents` against `budgetCents` is the live burn. The budget is a hard ceiling enforced inside the accrual transaction, so a boost cannot overspend — when it runs out, matching orders quietly fall back to your base rate rather than failing or accruing zero.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxBoostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Your funded cashback boosts, newest first.
                V1List result = apiInstance.ListCbxBoosts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxBoosts: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxcampaignpayouts"></a>
# **ListCbxCampaignPayouts**
> V1List ListCbxCampaignPayouts (string campaignId)

What a campaign actually paid, with the weight behind each amount.

The weight is kept so a payout can be explained to the person who received it. \"Why did I get this much\" should have an answer that is not \"the algorithm\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxCampaignPayoutsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var campaignId = "campaignId_example";  // string | 

            try
            {
                // What a campaign actually paid, with the weight behind each amount.
                V1List result = apiInstance.ListCbxCampaignPayouts(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxCampaignPayouts: " + e.Message );
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
 **campaignId** | **string**|  | 

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxcampaigns"></a>
# **ListCbxCampaigns**
> V1List ListCbxCampaigns ()

Your campaigns, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Your campaigns, newest first.
                V1List result = apiInstance.ListCbxCampaigns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxCampaigns: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxdisbursementprogress"></a>
# **ListCbxDisbursementProgress**
> V1List ListCbxDisbursementProgress ()

How close each rule is to firing — the public counter.

Safe to show users. A climbing counter toward a known number is the reason to prefer cadence-plus-threshold over a pure threshold: people can see the pool rising and know roughly when the next event is possible. A trigger nobody can anticipate generates suspicion rather than anticipation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxDisbursementProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // How close each rule is to firing — the public counter.
                V1List result = apiInstance.ListCbxDisbursementProgress();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxDisbursementProgress: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxdisbursementrules"></a>
# **ListCbxDisbursementRules**
> V1List ListCbxDisbursementRules ()

Threshold rules that fire community distributions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxDisbursementRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Threshold rules that fire community distributions.
                V1List result = apiInstance.ListCbxDisbursementRules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxDisbursementRules: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxearntiers"></a>
# **ListCbxEarnTiers**
> V1List ListCbxEarnTiers ()

Earn terms on offer — longer maturation, higher rate.

A term structure on a rebate, not a yield: the user chooses WHEN to be paid for a purchase they already made, and a longer wait earns more. Nothing accrues to a balance for being held. Show these at checkout so the choice is the user's — the rate is snapshot onto the accrual, so a tier edited later never reprices a promise already made.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxEarnTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Earn terms on offer — longer maturation, higher rate.
                V1List result = apiInstance.ListCbxEarnTiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxEarnTiers: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxredemptionservices"></a>
# **ListCbxRedemptionServices**
> V1List ListCbxRedemptionServices ()

Services payable in CBX, and the discount each carries.

Paying in CBX costs less than paying in dollars, which is what makes anybody choose it. These are real services with real cost behind them rather than a sink invented to soak up supply — and sinks matter: supply is fixed, so tokens that only ever accumulate starve the market the protocol has to buy from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxRedemptionServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Services payable in CBX, and the discount each carries.
                V1List result = apiInstance.ListCbxRedemptionServices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxRedemptionServices: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxstaketiers"></a>
# **ListCbxStakeTiers**
> V1List ListCbxStakeTiers ()

Staking tiers — what locking tokens buys.

Staking pays NOTHING. It confers a lower withdrawal fee and a higher earn rate on future purchases: a discount for commitment, not a return on a holding. Staked tokens never leave the user — they stay in their balance and stay backed by the reserve — they simply become unspendable until unstaked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxStakeTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Staking tiers — what locking tokens buys.
                V1List result = apiInstance.ListCbxStakeTiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxStakeTiers: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxsubjectgrants"></a>
# **ListCbxSubjectGrants**
> V1List ListCbxSubjectGrants (string subjectId)

Live grants, soonest-expiring first.

That ordering is the allocation order: a spend consumes the grant closest to lapsing, so value about to expire is used before value that will not. Grants with no expiry sort last.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxSubjectGrantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 

            try
            {
                // Live grants, soonest-expiring first.
                V1List result = apiInstance.ListCbxSubjectGrants(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxSubjectGrants: " + e.Message );
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
 **subjectId** | **string**|  | 

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxsubjectledger"></a>
# **ListCbxSubjectLedger**
> V1List ListCbxSubjectLedger (string subjectId, int? limit = null)

A subject's CBX ledger, newest first.

Append-only. The balance is the sum of these rows and there is no cached balance anywhere that could disagree with them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxSubjectLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);
            var subjectId = "subjectId_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)

            try
            {
                // A subject's CBX ledger, newest first.
                V1List result = apiInstance.ListCbxSubjectLedger(subjectId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxSubjectLedger: " + e.Message );
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
 **subjectId** | **string**|  | 
 **limit** | **int?**|  | [optional] [default to 50]

### Return type

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcbxwalletpaymentreview"></a>
# **ListCbxWalletPaymentReview**
> V1List ListCbxWalletPaymentReview ()

Payments held for a human — the ops queue.

Every row here is money taken and goods not shipped, which is not a state to leave a buyer in without it appearing on a list. `riskLevel` and `riskExposures` are the verdict as recorded at the time, not re-derived — asking a provider again next month answers a different question than the one already decided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCbxWalletPaymentReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CBXApi(config);

            try
            {
                // Payments held for a human — the ops queue.
                V1List result = apiInstance.ListCbxWalletPaymentReview();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CBXApi.ListCbxWalletPaymentReview: " + e.Message );
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

[**V1List**](V1List.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

