# net.crossly.Api.COSMApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCosmAttestationAnchor**](COSMApi.md#createcosmattestationanchor) | **POST** /v1/cosm/attestations/{id}/anchor | Record a signature for a commitment anchored BY HAND.
[**CreateCosmAuction**](COSMApi.md#createcosmauction) | **POST** /v1/cosm/auction | List an owned cosmetic for COSM.
[**CreateCosmAuctionBuy**](COSMApi.md#createcosmauctionbuy) | **POST** /v1/cosm/auction/{id}/buy | Buy an open listing.
[**CreateCosmCosmeticBuy**](COSMApi.md#createcosmcosmeticbuy) | **POST** /v1/cosm/cosmetics/{id}/buy | Buy an earned-tier cosmetic. The COSM is DESTROYED.
[**CreateCosmCosmeticBuyCbx**](COSMApi.md#createcosmcosmeticbuycbx) | **POST** /v1/cosm/cosmetics/{id}/buy-cbx | Buy a dollar-priced cosmetic, paying in CBX.
[**CreateCosmCosmeticClaim**](COSMApi.md#createcosmcosmeticclaim) | **POST** /v1/cosm/cosmetics/{id}/claim | Claim a stake-exclusive cosmetic once tenure qualifies.
[**CreateCosmFusion**](COSMApi.md#createcosmfusion) | **POST** /v1/cosm/fusion/{recipeId} | Fuse two cosmetics plus COSM into a rarer one.
[**CreateCosmHandle**](COSMApi.md#createcosmhandle) | **POST** /v1/cosm/handles | Claim a vanity handle, burning COSM.
[**CreateCosmWithdrawal**](COSMApi.md#createcosmwithdrawal) | **POST** /v1/cosm/withdrawals | Request a withdrawal to your own proven wallet. REFUSES today.
[**DeleteCosmHandle**](COSMApi.md#deletecosmhandle) | **DELETE** /v1/cosm/handles | Release a handle. NOTHING IS REFUNDED.
[**DeleteCosmPeg**](COSMApi.md#deletecosmpeg) | **DELETE** /v1/cosm/pegs/{listingId} | Stop repricing. The current ask stays where it is.
[**GetCosmAttestationProof**](COSMApi.md#getcosmattestationproof) | **GET** /v1/cosm/attestations/{id}/proof | A Merkle inclusion proof for one subject, against a published root.
[**GetCosmAuctionQuote**](COSMApi.md#getcosmauctionquote) | **GET** /v1/cosm/auction/quote | What an auction listing would cost in fees.
[**GetCosmBalance**](COSMApi.md#getcosmbalance) | **GET** /v1/cosm/balance | A subject&#39;s COSM balance and the earn rate in force.
[**GetCosmEmployeeFeeQuote**](COSMApi.md#getcosmemployeefeequote) | **GET** /v1/cosm/employee/fee-quote | What one shop-employee conversation will cost, in COSM.
[**GetCosmHandle**](COSMApi.md#getcosmhandle) | **GET** /v1/cosm/handles/{handle} | Is this handle available, and what does it cost?
[**GetCosmStakeTenure**](COSMApi.md#getcosmstaketenure) | **GET** /v1/cosm/stake-tenure | How long a subject has held a stake continuously, in days.
[**GetCosmSupply**](COSMApi.md#getcosmsupply) | **GET** /v1/cosm/supply | Total supply — minted, burned, circulating.
[**ListCosmAttestations**](COSMApi.md#listcosmattestations) | **GET** /v1/cosm/attestations | Published Merkle commitments. What you can check instead of trusting us.
[**ListCosmAuction**](COSMApi.md#listcosmauction) | **GET** /v1/cosm/auction | Open auction listings, priced in COSM.
[**ListCosmCosmetics**](COSMApi.md#listcosmcosmetics) | **GET** /v1/cosm/cosmetics | The cosmetics catalogue.
[**ListCosmGoals**](COSMApi.md#listcosmgoals) | **GET** /v1/cosm/goals | Community burn goal progress.
[**ListCosmInventory**](COSMApi.md#listcosminventory) | **GET** /v1/cosm/inventory | Cosmetics a subject holds.
[**ListCosmPegs**](COSMApi.md#listcosmpegs) | **GET** /v1/cosm/pegs | CBX-pegged listings and why each last moved.
[**ListCosmSupplyEpochs**](COSMApi.md#listcosmsupplyepochs) | **GET** /v1/cosm/supply/epochs | Per-epoch emission against the backstop.
[**ListCosmSupplySchedule**](COSMApi.md#listcosmsupplyschedule) | **GET** /v1/cosm/supply/schedule | The published emission taper. Fixed years ahead.
[**ListCosmUnlocks**](COSMApi.md#listcosmunlocks) | **GET** /v1/cosm/unlocks | Which spatial cosmetic values this subject may apply.
[**ListCosmWithdrawals**](COSMApi.md#listcosmwithdrawals) | **GET** /v1/cosm/withdrawals | Withdrawal history, and whether withdrawals are open at all.
[**UpdateCosmCosmeticUnlock**](COSMApi.md#updatecosmcosmeticunlock) | **PUT** /v1/cosm/cosmetics/{id}/unlock | Set (or clear) what a cosmetic unlocks spatially.
[**UpdateCosmPeg**](COSMApi.md#updatecosmpeg) | **PUT** /v1/cosm/pegs | Set or update a CBX price peg. OFF unless you turn it on.


<a name="createcosmattestationanchor"></a>
# **CreateCosmAttestationAnchor**
> CreateCosmAttestationAnchorResponse CreateCosmAttestationAnchor (string id)

Record a signature for a commitment anchored BY HAND.

An ops tool, not a trust boundary. Automated anchoring needs an RPC and a dedicated key; until those are wired, `attestationMemo()` emits exactly the bytes to publish, and this records the resulting signature so the verifiable story is available before the automation is. IT VERIFIES NOTHING beyond the signature’s shape — there is no RPC here to confirm the transaction exists or that its memo matches. A wrong signature recorded here produces a commitment that LOOKS anchored and is not, which is worse than unanchored. Refuses to overwrite an existing anchor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmAttestationAnchorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Record a signature for a commitment anchored BY HAND.
                CreateCosmAttestationAnchorResponse result = apiInstance.CreateCosmAttestationAnchor(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmAttestationAnchor: " + e.Message );
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

**CreateCosmAttestationAnchorResponse**

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

<a name="createcosmauction"></a>
# **CreateCosmAuction**
> CreateCosmAuctionResponse CreateCosmAuction ()

List an owned cosmetic for COSM.

Refuses a BOUND item with 403. The bound flag is CHECK-derived from how the item was acquired, so the refusal cannot be bypassed by writing a different flag. One open listing per item, enforced by a unique index — otherwise the same cosmetic could be listed twice and sold to two buyers. `askBaseUnits` is a STRING of base units and must exceed 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmAuctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // List an owned cosmetic for COSM.
                CreateCosmAuctionResponse result = apiInstance.CreateCosmAuction();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmAuction: " + e.Message );
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

**CreateCosmAuctionResponse**

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

<a name="createcosmauctionbuy"></a>
# **CreateCosmAuctionBuy**
> CreateCosmFusionResponse CreateCosmAuctionBuy (string id)

Buy an open listing.

Three ledger rows: the buyer is debited the ask, the seller is credited it, and the fee burns against the seller. Net supply falls by exactly the fee. The listing is claimed out of `open` BEFORE any COSM moves, so the loser of a race is refused rather than debited. Buying your own listing is refused by a database CHECK: it would burn the fee for nothing and is the obvious way to fake a market price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmAuctionBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Buy an open listing.
                CreateCosmFusionResponse result = apiInstance.CreateCosmAuctionBuy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmAuctionBuy: " + e.Message );
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

**CreateCosmFusionResponse**

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

<a name="createcosmcosmeticbuy"></a>
# **CreateCosmCosmeticBuy**
> CreateCosmCosmeticBuyResponse CreateCosmCosmeticBuy (string id)

Buy an earned-tier cosmetic. The COSM is DESTROYED.

Not credited to a treasury. Keeping it would make cosmetics a round trip rather than a sink, and the epoch backstop is computed FROM the burn — recycling would quietly uncouple emission from consumption. Refuses a premium or stake-exclusive SKU: those are not sold for COSM. Also counts toward any open community burn goal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmCosmeticBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Buy an earned-tier cosmetic. The COSM is DESTROYED.
                CreateCosmCosmeticBuyResponse result = apiInstance.CreateCosmCosmeticBuy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmCosmeticBuy: " + e.Message );
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

**CreateCosmCosmeticBuyResponse**

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

<a name="createcosmcosmeticbuycbx"></a>
# **CreateCosmCosmeticBuyCbx**
> CreateCosmCosmeticBuyCbxResponse CreateCosmCosmeticBuyCbx (string id)

Buy a dollar-priced cosmetic, paying in CBX.

The SKU's `priceCents` is paid from the subject's EARNED CBX at spot. `requestKey` (8-64 chars, one per purchase attempt) makes a retry the same purchase. If the grant fails after payment — sold out, already held — the CBX spend is reversed. Refuses an earned (COSM) or stake-exclusive SKU.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmCosmeticBuyCbxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Buy a dollar-priced cosmetic, paying in CBX.
                CreateCosmCosmeticBuyCbxResponse result = apiInstance.CreateCosmCosmeticBuyCbx(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmCosmeticBuyCbx: " + e.Message );
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

**CreateCosmCosmeticBuyCbxResponse**

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

<a name="createcosmcosmeticclaim"></a>
# **CreateCosmCosmeticClaim**
> CreateCosmCosmeticClaimResponse CreateCosmCosmeticClaim (string id)

Claim a stake-exclusive cosmetic once tenure qualifies.

Bound forever, and purchasable by nobody at any price in any currency. What people buy in cosmetics is STATUS, and anything purchasable is by definition available to anyone with money — an item money cannot buy is strictly rarer than an expensive one. Tenure is the LONGEST CONTINUOUS active stake, not time since first staking: somebody who staked, unstaked and staked again has not held continuously, and that is the whole claim the item makes. A cooling stake does not count, because the commitment is already being withdrawn. Returns `granted: false` with the tenure and the requirement when it is short — that is the normal answer, not an error. Idempotent: claiming twice while the first copy is held is a no-op.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmCosmeticClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Claim a stake-exclusive cosmetic once tenure qualifies.
                CreateCosmCosmeticClaimResponse result = apiInstance.CreateCosmCosmeticClaim(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmCosmeticClaim: " + e.Message );
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

**CreateCosmCosmeticClaimResponse**

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

<a name="createcosmfusion"></a>
# **CreateCosmFusion**
> CreateCosmFusionResponse CreateCosmFusion (string recipeId)

Fuse two cosmetics plus COSM into a rarer one.

The deepest sink available: it destroys on three axes at once — both input items AND the COSM cost — while producing something whose scarcity is real, because a recipe is the only route to it. Inputs must be owned, live, UNBOUND and flagged `fusable`. Stake-exclusive items can never be consumed: there is no way to reissue one without falsifying its scarcity, so the loss would be unrecoverable. An open listing on a consumed input is cancelled, since the owner has just chosen fusion over selling.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmFusionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var recipeId = "recipeId_example";  // string | 

            try
            {
                // Fuse two cosmetics plus COSM into a rarer one.
                CreateCosmFusionResponse result = apiInstance.CreateCosmFusion(recipeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmFusion: " + e.Message );
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
 **recipeId** | **string**|  | 

### Return type

**CreateCosmFusionResponse**

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

<a name="createcosmhandle"></a>
# **CreateCosmHandle**
> CreateCosmHandleResponse CreateCosmHandle ()

Claim a vanity handle, burning COSM.

One live handle per subject, enforced by a unique index. Collecting handles is a land grab that makes the good names unavailable, not a sink. A handle is released rather than deleted when given up, so the record of who held it survives — a handle that silently changed owner is the same impersonation problem from the other direction. There is no refund on release: the COSM was burned, and refunding would mean minting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Claim a vanity handle, burning COSM.
                CreateCosmHandleResponse result = apiInstance.CreateCosmHandle();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmHandle: " + e.Message );
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

**CreateCosmHandleResponse**

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

<a name="createcosmwithdrawal"></a>
# **CreateCosmWithdrawal**
> CreateCosmWithdrawalResponse CreateCosmWithdrawal ()

Request a withdrawal to your own proven wallet. REFUSES today.

Returns 409 with the outstanding preconditions until COSM is transferable. Built and switched off deliberately: a withdrawal rail written in a hurry the week it is cleared is the one that ships with mistakes. THE DESTINATION IS NOT A PARAMETER. It resolves to this subject’s own VERIFIED connected wallet, because a per-request destination is how a compromised session drains a balance to somebody else’s address. Idempotent on `externalId`. The debit lands before anything is minted, so a crash leaves a recoverable state rather than tokens in a wallet with no debit behind them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateCosmWithdrawalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Request a withdrawal to your own proven wallet. REFUSES today.
                CreateCosmWithdrawalResponse result = apiInstance.CreateCosmWithdrawal();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.CreateCosmWithdrawal: " + e.Message );
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

**CreateCosmWithdrawalResponse**

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

<a name="deletecosmhandle"></a>
# **DeleteCosmHandle**
> DeleteCosmHandleResponse DeleteCosmHandle ()

Release a handle. NOTHING IS REFUNDED.

The COSM paid for a handle was BURNED, so there is nothing to give back — refunding would mean minting, which no support flow should be able to do. Say that in the UI before calling this; a user who expects a refund will read silence as a bug. The handle returns to the pool and can be claimed by anyone, including somebody else, so releasing is not a way to park one. Returns `released: false` when the subject held none.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteCosmHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Release a handle. NOTHING IS REFUNDED.
                DeleteCosmHandleResponse result = apiInstance.DeleteCosmHandle();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.DeleteCosmHandle: " + e.Message );
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

**DeleteCosmHandleResponse**

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

<a name="deletecosmpeg"></a>
# **DeleteCosmPeg**
> DeleteCosmPegResponse DeleteCosmPeg (string listingId)

Stop repricing. The current ask stays where it is.

Disabling means “stop moving it”, not “revert to something the buyer never saw”. The terms are kept, so re-enabling later does not mean re-entering them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteCosmPegExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var listingId = "listingId_example";  // string | 

            try
            {
                // Stop repricing. The current ask stays where it is.
                DeleteCosmPegResponse result = apiInstance.DeleteCosmPeg(listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.DeleteCosmPeg: " + e.Message );
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
 **listingId** | **string**|  | 

### Return type

**DeleteCosmPegResponse**

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

<a name="getcosmattestationproof"></a>
# **GetCosmAttestationProof**
> GetCosmAttestationProofResponse GetCosmAttestationProof (string id)

A Merkle inclusion proof for one subject, against a published root.

Returns `canonicalLeaf`, a `proof` of sibling hashes, and the `root`. VERIFY IT YOURSELF rather than trusting `verified`: hash the leaf with a 0x00 prefix, then fold each proof step with a 0x01 prefix, ordering the two hashes lexicographically at each step, and compare to the root. That is sixteen lines in any language and needs nothing from us. The prefixes are not decoration — without them an internal node is indistinguishable from a leaf and membership of uncommitted data can be forged. Returns 409 if the underlying data no longer reproduces the published root. That is a disclosure event, not a retryable error: the published root stands and a proof against a rebuilt one would be worthless.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmAttestationProofExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A Merkle inclusion proof for one subject, against a published root.
                GetCosmAttestationProofResponse result = apiInstance.GetCosmAttestationProof(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmAttestationProof: " + e.Message );
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

**GetCosmAttestationProofResponse**

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

<a name="getcosmauctionquote"></a>
# **GetCosmAuctionQuote**
> GetCosmAuctionQuoteResponse GetCosmAuctionQuote ()

What an auction listing would cost in fees.

Quote before committing. The fee is 8% of the ask, rounded UP so a small listing can never pay nothing — a zero-fee listing would be a free transfer channel, which is the one thing the design forbids outright. The seller always nets something, and a database CHECK asserts the same bound.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmAuctionQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // What an auction listing would cost in fees.
                GetCosmAuctionQuoteResponse result = apiInstance.GetCosmAuctionQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmAuctionQuote: " + e.Message );
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

**GetCosmAuctionQuoteResponse**

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

<a name="getcosmbalance"></a>
# **GetCosmBalance**
> GetCosmBalanceResponse GetCosmBalance ()

A subject's COSM balance and the earn rate in force.

Balances are STRINGS of base units, and COSM has six decimals — divide by 1e6 to display. They are strings because a JSON number loses precision past 2^53, which is only about nine billion COSM: it would work in testing and corrupt balances at scale. `taper` is the emission step currently in force, which depends on lifetime supply rather than on anything about this subject — two sellers earning the same week always see the same taper.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // A subject's COSM balance and the earn rate in force.
                GetCosmBalanceResponse result = apiInstance.GetCosmBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmBalance: " + e.Message );
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

**GetCosmBalanceResponse**

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

<a name="getcosmemployeefeequote"></a>
# **GetCosmEmployeeFeeQuote**
> GetCosmEmployeeFeeQuoteResponse GetCosmEmployeeFeeQuote ()

What one shop-employee conversation will cost, in COSM.

A quote, priced with the SAME functions the charge uses, so the figure shown is the figure taken. Half of the fee BURNS and half moves to the market pool as a tax; the two always sum to the total exactly, because the split is applied in cents and the remainder is handed to the pool rather than derived from the complementary basis points. A pure burn would make the employee a deflation lever and nothing else; a pure transfer would make it a tax with no sink. Reads nothing and charges nothing — safe to call on every keystroke.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmEmployeeFeeQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // What one shop-employee conversation will cost, in COSM.
                GetCosmEmployeeFeeQuoteResponse result = apiInstance.GetCosmEmployeeFeeQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmEmployeeFeeQuote: " + e.Message );
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

**GetCosmEmployeeFeeQuoteResponse**

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

<a name="getcosmhandle"></a>
# **GetCosmHandle**
> GetCosmHandleResponse GetCosmHandle (string handle)

Is this handle available, and what does it cost?

Reasons for unavailability: `invalid_shape`, `reserved`, `taken`. Handles are lowercased and constrained to a narrow character class, because anything that can be made to LOOK like another handle is an impersonation vector rather than an expressive option. Priced by length: short names are scarcer. Uniqueness is platform-wide, not per merchant — it is a URL namespace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // Is this handle available, and what does it cost?
                GetCosmHandleResponse result = apiInstance.GetCosmHandle(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmHandle: " + e.Message );
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
 **handle** | **string**|  | 

### Return type

**GetCosmHandleResponse**

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

<a name="getcosmstaketenure"></a>
# **GetCosmStakeTenure**
> GetCosmStakeTenureResponse GetCosmStakeTenure ()

How long a subject has held a stake continuously, in days.

The figure every stake-exclusive grant is decided on, readable on its own so a UI can show progress rather than only reporting failure at claim time. LONGEST CONTINUOUS active stake — a gap resets it, and a cooling stake does not count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmStakeTenureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // How long a subject has held a stake continuously, in days.
                GetCosmStakeTenureResponse result = apiInstance.GetCosmStakeTenure();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmStakeTenure: " + e.Message );
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

**GetCosmStakeTenureResponse**

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

<a name="getcosmsupply"></a>
# **GetCosmSupply**
> GetCosmSupplyResponse GetCosmSupply ()

Total supply — minted, burned, circulating.

The one question a holder of an emitted currency cannot answer for themselves. Every figure is derived from the ledger rather than a cached counter, so it cannot drift from the rows it summarises. `reconciles` is the check you can run against us: minted minus burned minus reversed must equal the sum of every balance, and the auction debit/credit pair must cancel exactly. False means a bug on our side, not stale data. Once COSM is transferable the on-chain `total_minted` emitted by `cosm-minter` is the authoritative figure and this becomes the convenient one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetCosmSupplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Total supply — minted, burned, circulating.
                GetCosmSupplyResponse result = apiInstance.GetCosmSupply();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.GetCosmSupply: " + e.Message );
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

**GetCosmSupplyResponse**

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

<a name="listcosmattestations"></a>
# **ListCosmAttestations**
> ListCosmAttestationsResponse ListCosmAttestations ()

Published Merkle commitments. What you can check instead of trusting us.

Two claims become verifiable here. `cosm_emission` commits an epoch’s activity claims, so anybody can confirm emission never exceeded the sum of committed real activity — and every input is in the leaf, so the payout arithmetic can be rechecked, not just membership. `cbx_liability` commits every balance, which is the half of proof-of-reserve usually hand-waved. READ `anchoredAt` BEFORE RELYING ON A ROOT. Null means the commitment is computed and stored but NOT yet on chain — which makes it a row we could edit, so it proves nothing to somebody who does not already trust us. `totalBaseUnits` lets you check the sum without rebuilding the tree.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmAttestationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Published Merkle commitments. What you can check instead of trusting us.
                ListCosmAttestationsResponse result = apiInstance.ListCosmAttestations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmAttestations: " + e.Message );
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

**ListCosmAttestationsResponse**

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

<a name="listcosmauction"></a>
# **ListCosmAuction**
> ListCosmAuctionResponse ListCosmAuction ()

Open auction listings, priced in COSM.

A COSM-denominated peer market: buyers pay COSM, sellers receive COSM, and the 8% fee BURNS. It is not a cash market — a cash resale market for COSM-bought items would reintroduce the arbitrage between a fixed COSM price and a floating market price. `feeBaseUnits` was quoted when the listing was created and is held, because a fee recomputed at sale time is a quote nobody can rely on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmAuctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Open auction listings, priced in COSM.
                ListCosmAuctionResponse result = apiInstance.ListCosmAuction();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmAuction: " + e.Message );
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

**ListCosmAuctionResponse**

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

<a name="listcosmcosmetics"></a>
# **ListCosmCosmetics**
> ListCosmCosmeticsResponse ListCosmCosmetics ()

The cosmetics catalogue.

Tiers are DISJOINT and no SKU carries two prices: `premium` is cash only, `earned` is COSM only, `stake_exclusive` cannot be bought at any price in any currency. That is not a presentation choice — pricing one SKU in both currencies would expose a fixed COSM price to a floating market price, which is free money in the gap and hands limited editions to whoever automates it. `priceCents` is set only on premium, `priceBaseUnits` only on earned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmCosmeticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // The cosmetics catalogue.
                ListCosmCosmeticsResponse result = apiInstance.ListCosmCosmetics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmCosmetics: " + e.Message );
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

**ListCosmCosmeticsResponse**

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

<a name="listcosmgoals"></a>
# **ListCosmGoals**
> ListCosmGoalsResponse ListCosmGoals ()

Community burn goal progress.

Aggregate burn crossing a threshold unlocks a cosmetic for everyone who contributed — scoped to contributors, because a goal that rewarded non-participants makes contributing irrational. Only burns inside the window count; a goal counting all history would complete the moment it was created. `progressBps` is capped at 10000: the total is snapshotted on completion so a bar never reads over 100%.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmGoalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Community burn goal progress.
                ListCosmGoalsResponse result = apiInstance.ListCosmGoals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmGoals: " + e.Message );
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

**ListCosmGoalsResponse**

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

<a name="listcosminventory"></a>
# **ListCosmInventory**
> ListCosmInventoryResponse ListCosmInventory ()

Cosmetics a subject holds.

`bound` is derived from how it was acquired and is enforced by a database CHECK, not set by hand: a stake-exclusive grant and a make-good are bound forever, everything else trades. Bound items cannot be listed on the auction house or used as a fusion input. `editionNumber` identifies the ITEM and travels with it through a sale, because a reissued #7 would falsify every scarcity claim a market has priced.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Cosmetics a subject holds.
                ListCosmInventoryResponse result = apiInstance.ListCosmInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmInventory: " + e.Message );
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

**ListCosmInventoryResponse**

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

<a name="listcosmpegs"></a>
# **ListCosmPegs**
> ListCosmPegsResponse ListCosmPegs ()

CBX-pegged listings and why each last moved.

A peg holds a CBX ask at a dollar target. `lastReason` says what the last cycle did: repriced, no_rate, below_threshold, clamped_floor, clamped_ceiling or clamped_change. A seller asking why their price has not moved deserves an answer that is not “it should have”. The repricer reads a 24h MINIMUM rate, never spot — tracking spot would let somebody pump CBX, watch the ask drop, and pay with cheaply bought tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmPegsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // CBX-pegged listings and why each last moved.
                ListCosmPegsResponse result = apiInstance.ListCosmPegs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmPegs: " + e.Message );
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

**ListCosmPegsResponse**

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

<a name="listcosmsupplyepochs"></a>
# **ListCosmSupplyEpochs**
> ListCosmSupplyEpochsResponse ListCosmSupplyEpochs ()

Per-epoch emission against the backstop.

`demanded` is what activity would have earned at full rate; `emitted` is what was actually credited. Both are reported because storing only the second would make a refusal indistinguishable from a quiet rate cut. `ceilingBound` should be rare — the governor is the emission rate itself, which is a share of transaction value, so the ceiling binding means an anomaly rather than a busy week.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmSupplyEpochsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Per-epoch emission against the backstop.
                ListCosmSupplyEpochsResponse result = apiInstance.ListCosmSupplyEpochs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmSupplyEpochs: " + e.Message );
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

**ListCosmSupplyEpochsResponse**

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

<a name="listcosmsupplyschedule"></a>
# **ListCosmSupplySchedule**
> ListCosmSupplyScheduleResponse ListCosmSupplySchedule ()

The published emission taper. Fixed years ahead.

Indexed on CUMULATIVE MINTED, which is monotonic and which nothing anybody does can move backwards. Net circulating supply would be self-correcting against a healthy sink and would also be reflexive — burning to hold the taper back would become a strategy. A schedule nobody can game beats a clever loop. The final step is a floor, not zero: a terminating schedule is a loyalty programme with an expiry date, where the last cohort to join earns nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmSupplyScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // The published emission taper. Fixed years ahead.
                ListCosmSupplyScheduleResponse result = apiInstance.ListCosmSupplySchedule();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmSupplySchedule: " + e.Message );
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

**ListCosmSupplyScheduleResponse**

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

<a name="listcosmunlocks"></a>
# **ListCosmUnlocks**
> ListCosmUnlocksResponse ListCosmUnlocks ()

Which spatial cosmetic values this subject may apply.

Owning a cosmetic is what permits setting the room value it claims. Values no SKU claims — the stock walls, floors and themes — are free and are not listed here. Paint a picker from this rather than discovering a refusal on submit: the redecorate endpoint returns the locked items by name so a swatch can be greyed out instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmUnlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Which spatial cosmetic values this subject may apply.
                ListCosmUnlocksResponse result = apiInstance.ListCosmUnlocks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmUnlocks: " + e.Message );
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

**ListCosmUnlocksResponse**

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

<a name="listcosmwithdrawals"></a>
# **ListCosmWithdrawals**
> ListCosmWithdrawalsResponse ListCosmWithdrawals ()

Withdrawal history, and whether withdrawals are open at all.

COSM does not leave the platform yet. `open` is false and `outstanding` lists the preconditions still to be met: an audited minter, a securities opinion, a money-transmission review, and the emission invariant proven under real volume. None of them has a date, so do not present one. The endpoint exists so a client can show that state honestly rather than hiding the feature and surprising somebody later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListCosmWithdrawalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Withdrawal history, and whether withdrawals are open at all.
                ListCosmWithdrawalsResponse result = apiInstance.ListCosmWithdrawals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.ListCosmWithdrawals: " + e.Message );
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

**ListCosmWithdrawalsResponse**

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

<a name="updatecosmcosmeticunlock"></a>
# **UpdateCosmCosmeticUnlock**
> UpdateCosmCosmeticUnlockResponse UpdateCosmCosmeticUnlock (string id)

Set (or clear) what a cosmetic unlocks spatially.

A cosmetic can gate a spatial control — a theme, a prop, a room feature — by naming a key/value pair the scene reads. Both or neither: a key with no value would claim EVERY value of that key and silently gate the whole control, so passing one without the other clears both. Pass two nulls to remove the gate entirely, which makes the control free for everyone. Treasury scope — this changes what every holder can reach, not one subject.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateCosmCosmeticUnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Set (or clear) what a cosmetic unlocks spatially.
                UpdateCosmCosmeticUnlockResponse result = apiInstance.UpdateCosmCosmeticUnlock(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.UpdateCosmCosmeticUnlock: " + e.Message );
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

**UpdateCosmCosmeticUnlockResponse**

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

<a name="updatecosmpeg"></a>
# **UpdateCosmPeg**
> UpdateCosmPegResponse UpdateCosmPeg ()

Set or update a CBX price peg. OFF unless you turn it on.

Holds a CBX ask at a dollar target, repriced hourly against a 24h MINIMUM rate. Three bounds, each for a different failure: `maxChangeBps` stops one bad reading posting an absurd ask (it converges over cycles instead), `floorBaseUnits` and `ceilingBaseUnits` are YOUR limits so a sustained real move never posts a price you did not consider, and `minChangeBps` stops the ask being rewritten for a fraction of a percent. Accepting CBX means holding CBX. The peg protects the dollar value of the ASK; it cannot protect the value of tokens once you have them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateCosmPegExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new COSMApi(config);

            try
            {
                // Set or update a CBX price peg. OFF unless you turn it on.
                UpdateCosmPegResponse result = apiInstance.UpdateCosmPeg();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling COSMApi.UpdateCosmPeg: " + e.Message );
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

**UpdateCosmPegResponse**

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

