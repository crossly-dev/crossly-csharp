# net.crossly.Api.WholesaleApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWholesaleBuyerInvite**](WholesaleApi.md#createwholesalebuyerinvite) | **POST** /v1/wholesale/buyers/invite | Invite a buyer by email to one or more of your catalogs. Binds to their account now if they have one, or when they sign up.
[**CreateWholesaleBuyerRemove**](WholesaleApi.md#createwholesalebuyerremove) | **POST** /v1/wholesale/buyers/remove | Revoke every catalog grant a buyer (or invited email) has with you. Their terms and invoices are kept.
[**CreateWholesaleCatalog**](WholesaleApi.md#createwholesalecatalog) | **POST** /v1/wholesale/catalogs | Create a catalog. visibility public | public_prices_private (prices for approved buyers) | private_discoverable (listed, opened on approval) | link (anyone with the URL) | invite (named buyers only; \&quot;private\&quot; is accepted as invite); autoApprove never | verified | all; the cascade terms (minOrderQuantity, casePack, leadTimeDays, verifiedOnly, priceVisibility, maxPerOrder, backorder, restockEta, preset ids) default every item; listed advertises a public catalog in the wholesale directory (never its prices).
[**CreateWholesaleCatalogAccessResend**](WholesaleApi.md#createwholesalecatalogaccessresend) | **POST** /v1/wholesale/catalogs/{id}/access/{grantId}/resend | Email a pending catalog invite again (an invited address with no Crossly account yet). One send per invite every 15 minutes: 429 with Retry-After inside that window. grantId is the catalogs[].grantId of GET /wholesale/buyers. Uses the X-Storefront-Id store.
[**CreateWholesaleCatalogItem**](WholesaleApi.md#createwholesalecatalogitem) | **POST** /v1/wholesale/catalogs/{id}/items | Add your Crossly listings to a catalog (up to 500), each with an optional wholesalePriceCents, minOrderQuantity and casePack. Items already in the catalog have their terms updated.
[**CreateWholesaleDrop**](WholesaleApi.md#createwholesaledrop) | **POST** /v1/wholesale/drops | Create a draft trade drop: name, dropAt (ISO; when it opens), audience trade|catalog (+ audienceCatalogId), kind release|prebook. A pre-book needs depositBps (100-9900) and shipBy (YYYY-MM-DD), and takes balanceNetDays (0-90) for the balance invoice. listingIds are your listing ids, each on Crossly. A pre-book makes its listings pre-orders, so buyers pay the deposit at checkout. Schedule it with PATCH status \&quot;scheduled\&quot;.
[**CreateWholesaleDropRelease**](WholesaleApi.md#createwholesaledroprelease) | **POST** /v1/wholesale/drops/{id}/release | Release a live pre-book: every reserved balance becomes an invoice on account to its buyer (due in the drop balanceNetDays), emailed, and the drop ends. Safe to retry: only balances not yet invoiced are invoiced. Returns { invoiced, balanceCents, invoiceIds }.
[**CreateWholesaleFreightRequestAnswer**](WholesaleApi.md#createwholesalefreightrequestanswer) | **POST** /v1/wholesale/freight-requests/{id}/answer | Answer an open freight request with a figure in CENTS (and an optional note).
[**CreateWholesaleGroup**](WholesaleApi.md#createwholesalegroup) | **POST** /v1/wholesale/groups | Create a customer group with a discount in basis points (up to 9000). A buyer in several groups gets the best rate, never a stacked one.
[**CreateWholesaleGroupMember**](WholesaleApi.md#createwholesalegroupmember) | **POST** /v1/wholesale/groups/{id}/members | Add a buyer to a group by account id or by the email of an existing Crossly account.
[**CreateWholesaleInvoiceCreditNote**](WholesaleApi.md#createwholesaleinvoicecreditnote) | **POST** /v1/wholesale/invoices/{id}/credit-notes | Issue a credit note on an on-account invoice (short shipment, damaged, pricing error, returned, goodwill, other): at most the balance due. Numbered &lt;invoice&gt;-CN&lt;n&gt;; settling the rest closes the invoice paid. Not a refund.
[**CreateWholesaleInvoiceLateFee**](WholesaleApi.md#createwholesaleinvoicelatefee) | **POST** /v1/wholesale/invoices/{id}/late-fee | Add your late fee (invoice settings lateFeeBps) to an invoice by hand, once. The hourly sweep adds it automatically when an invoice goes overdue.
[**CreateWholesaleInvoiceMarkPaid**](WholesaleApi.md#createwholesaleinvoicemarkpaid) | **POST** /v1/wholesale/invoices/{id}/mark-paid | Record a payment the buyer made to you directly: method ach | check | wire | card | other, a reference, and amountCents (omit for the whole balance). When the invoice is settled, Crossly&#39;s fee and the tax it remits are charged to your billing card.
[**CreateWholesaleInvoiceSend**](WholesaleApi.md#createwholesaleinvoicesend) | **POST** /v1/wholesale/invoices/{id}/send | Email the invoice to the buyer again (an overdue one goes as an overdue notice), with the link to pay it.
[**CreateWholesaleInvoiceVoid**](WholesaleApi.md#createwholesaleinvoicevoid) | **POST** /v1/wholesale/invoices/{id}/void | Void an invoice nobody has paid anything on (e.g. the order was cancelled). It stops counting against the buyer&#39;s credit limit.
[**CreateWholesaleInvoiceWriteOff**](WholesaleApi.md#createwholesaleinvoicewriteoff) | **POST** /v1/wholesale/invoices/{id}/write-off | Write off what is left on an invoice (bad debt): it closes as written_off and stops counting against the buyer&#39;s credit.
[**CreateWholesaleProfileShipsFromValidate**](WholesaleApi.md#createwholesaleprofileshipsfromvalidate) | **POST** /v1/wholesale/profile/ships-from/validate | Check a ships-from origin ({ postalCode, country, city?, region? }) with the shipping validator without saving it. 400 invalid_ships_from with the issues; 422 for an embargoed origin.
[**CreateWholesaleQuoteAnswer**](WholesaleApi.md#createwholesalequoteanswer) | **POST** /v1/wholesale/quotes/{id}/answer | Answer (or revise) a quote: a unit price in CENTS per item you quote, an expiresAt (ISO, at most 90 days out) and an optional note. Items left out are not quoted. The buyer is notified and can accept until expiry.
[**CreateWholesaleQuoteDecline**](WholesaleApi.md#createwholesalequotedecline) | **POST** /v1/wholesale/quotes/{id}/decline | Decline a quote request, with an optional reason the buyer sees.
[**CreateWholesaleRequestDecide**](WholesaleApi.md#createwholesalerequestdecide) | **POST** /v1/wholesale/requests/{id}/decide | Approve (grants access to that catalog; optional groupId adds the buyer to a customer group) or decline (optional reason) an access request.
[**CreateWholesaleTierBulk**](WholesaleApi.md#createwholesaletierbulk) | **POST** /v1/wholesale/tiers/bulk | One ladder for many listings: breaks as [{ minQuantity, discountBps }] off each listing&#39;s own price. Returns how many were updated and which were skipped and why.
[**DeleteWholesaleBuyerTerm**](WholesaleApi.md#deletewholesalebuyerterm) | **DELETE** /v1/wholesale/buyers/{buyerUserId}/terms | Switch a buyer&#39;s account terms off. Invoices already issued are unaffected.
[**DeleteWholesaleCatalog**](WholesaleApi.md#deletewholesalecatalog) | **DELETE** /v1/wholesale/catalogs/{id} | Delete a catalog with its items, grants and access requests. Orders and invoices are untouched.
[**DeleteWholesaleCatalogAccess**](WholesaleApi.md#deletewholesalecatalogaccess) | **DELETE** /v1/wholesale/catalogs/{id}/access/{grantId} | Revoke one buyer&#39;s (or invited address&#39;s) access to this ONE catalog; their other catalogs, terms, groups and invoices are kept. /wholesale/buyers/remove revokes every catalog. Uses the X-Storefront-Id store.
[**DeleteWholesaleCatalogItem**](WholesaleApi.md#deletewholesalecatalogitem) | **DELETE** /v1/wholesale/catalogs/{id}/items/{platformListingId} | Take an item out of a catalog. The listing itself is untouched.
[**DeleteWholesaleGroup**](WholesaleApi.md#deletewholesalegroup) | **DELETE** /v1/wholesale/groups/{id} | Delete a customer group. Its members keep any other group or account rate.
[**DeleteWholesaleGroupMember**](WholesaleApi.md#deletewholesalegroupmember) | **DELETE** /v1/wholesale/groups/{id}/members/{buyerUserId} | Take a buyer out of a group.
[**GetWholesaleCatalogLineSheet**](WholesaleApi.md#getwholesalecataloglinesheet) | **GET** /v1/wholesale/catalogs/{id}/line-sheet | The catalog&#39;s line sheet: your company details and terms, then every item with retail and trade price, minimum, case pack and quantity breaks.
[**GetWholesaleCatalogShare**](WholesaleApi.md#getwholesalecatalogshare) | **GET** /v1/wholesale/catalogs/{id}/share | The catalog&#39;s buyer link (null until you have a shop username), to share or print as a QR code.
[**GetWholesaleCategory**](WholesaleApi.md#getwholesalecategory) | **GET** /v1/wholesale/categories | The wholesale category taxonomy (id, label, group). A catalog or trade profile takes up to 12 ids, or \&quot;other:&lt;words&gt;\&quot;.
[**GetWholesaleDrop**](WholesaleApi.md#getwholesaledrop) | **GET** /v1/wholesale/drops/{id} | One trade drop with its listings and, for a pre-book, every reservation: buyer, item, quantity, deposit, balance, status and the balance invoice once released.
[**GetWholesaleInvoice**](WholesaleApi.md#getwholesaleinvoice) | **GET** /v1/wholesale/invoices/{id} | One invoice with its lines, PO reference, payments and whether Crossly dues on it are collected.
[**GetWholesaleOverview**](WholesaleApi.md#getwholesaleoverview) | **GET** /v1/wholesale/overview | Your wholesale store at a glance: the setup checklist, 30-day wholesale revenue, open orders, outstanding invoices, active buyers and pending access requests.
[**GetWholesaleProfile**](WholesaleApi.md#getwholesaleprofile) | **GET** /v1/wholesale/profile | A store&#39;s trade profile (X-Storefront-Id; default store when omitted): company, tagline, logo and banner, contact, ships-from origin, lead time, order minimums (opening, first order, reorder), the default MOQ / case pack / max per order / backorder / price visibility, return, payment and shipping preset ids, invoicing and its settings, buyer requirements and the directory defaults.
[**GetWholesaleQuote**](WholesaleApi.md#getwholesalequote) | **GET** /v1/wholesale/quotes/{id} | One quote request.
[**GetWholesaleReserve**](WholesaleApi.md#getwholesalereserve) | **GET** /v1/wholesale/reserve/{inventoryItemId} | How many units of an inventory item are held back for wholesale, and what retail channels advertise.
[**GetWholesaleTermPreview**](WholesaleApi.md#getwholesaletermpreview) | **GET** /v1/wholesale/terms/preview | The trade terms that apply to a catalog item (?catalogId&amp;platformListingId), a catalog (?catalogId) or the trade profile alone, each with its source (item, catalog, profile, default), plus the return, payment and shipping policies they resolve to.
[**ListWholesaleBuyers**](WholesaleApi.md#listwholesalebuyers) | **GET** /v1/wholesale/buyers | Your trade buyers: catalogs they can open, customer groups, account terms, outstanding balance, wholesale spend, business verification and resale-certificate status (read-only — Crossly reviews those).
[**ListWholesaleCatalogItems**](WholesaleApi.md#listwholesalecatalogitems) | **GET** /v1/wholesale/catalogs/{id}/items | A catalog&#39;s items in merchandising order, each with its retail price, trade price, minimum order quantity, case pack and quantity breaks.
[**ListWholesaleCatalogs**](WholesaleApi.md#listwholesalecatalogs) | **GET** /v1/wholesale/catalogs | Your wholesale catalogs with item, buyer-grant and pending-request counts.
[**ListWholesaleDrops**](WholesaleApi.md#listwholesaledrops) | **GET** /v1/wholesale/drops | Your trade drops and pre-books: audience (trade &#x3D; your approved trade buyers, catalog &#x3D; whoever can open audienceCatalogId), kind (release | prebook), deposit, ship date, status, and for a pre-book its reservation totals (buyers, units, deposits taken, balances still to invoice).
[**ListWholesaleFreightRequests**](WholesaleApi.md#listwholesalefreightrequests) | **GET** /v1/wholesale/freight-requests | Freight (LTL) quote requests from buyers whose order is over your pallet threshold.
[**ListWholesaleGroups**](WholesaleApi.md#listwholesalegroups) | **GET** /v1/wholesale/groups | Your customer groups with their discount and members.
[**ListWholesaleInvoices**](WholesaleApi.md#listwholesaleinvoices) | **GET** /v1/wholesale/invoices | On-account invoices, newest first, with balance due. ?status&#x3D;unpaid for open, partial and overdue together.
[**ListWholesaleOrders**](WholesaleApi.md#listwholesaleorders) | **GET** /v1/wholesale/orders | Wholesale orders: Crossly orders priced through your trade terms (catalog price, quantity break or account rate) or placed on account. Fulfil them like any order.
[**ListWholesaleQuotes**](WholesaleApi.md#listwholesalequotes) | **GET** /v1/wholesale/quotes | Quote requests (RFQ) from trade buyers: items with quantity and target price, your quoted prices and expiry. ?status&#x3D;open lists the ones waiting on you or the buyer.
[**ListWholesaleRequests**](WholesaleApi.md#listwholesalerequests) | **GET** /v1/wholesale/requests | Requests from buyers to open your private or trade-only catalogs, with each buyer&#39;s business-verification and tax-exempt status. ?status&#x3D;all includes decided ones.
[**ListWholesaleSetupSteps**](WholesaleApi.md#listwholesalesetupsteps) | **GET** /v1/wholesale/setup-steps | The wholesale setup checklist for a store: profile, ships-from, payment, returns, a catalog with items, visibility chosen, live. Each step is done because the thing exists.
[**UpdateWholesaleBuyerTerm**](WholesaleApi.md#updatewholesalebuyerterm) | **PUT** /v1/wholesale/buyers/{buyerUserId}/terms | Set a buyer&#39;s account terms: netDays (0-120) for paying on account, creditLimitCents (the most they may owe you at once; null &#x3D; no limit) and discountPercentBps (their negotiated rate).
[**UpdateWholesaleCatalog**](WholesaleApi.md#updatewholesalecatalog) | **PATCH** /v1/wholesale/catalogs/{id} | Edit a catalog: name, slug, description, cover image, visibility, opening-order minimum, trade gate, directory listing, active.
[**UpdateWholesaleCatalogItem**](WholesaleApi.md#updatewholesalecatalogitem) | **PATCH** /v1/wholesale/catalogs/{id}/items | Change many catalog items at once: items[] sets each row (trade price, MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids); or platformListingIds + set applies the same values to each, set.pctOffRetailBps pricing each from its retail price.
[**UpdateWholesaleCatalogItemByPlatformListingId**](WholesaleApi.md#updatewholesalecatalogitembyplatformlistingid) | **PATCH** /v1/wholesale/catalogs/{id}/items/{platformListingId} | Change one item&#39;s trade price and its own trade terms in this catalog (MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids). null clears &#x3D; inherit from the catalog.
[**UpdateWholesaleCatalogItemOrder**](WholesaleApi.md#updatewholesalecatalogitemorder) | **PUT** /v1/wholesale/catalogs/{id}/items/order | Set the merchandising order: platform listing ids, first to last. Items left out keep their relative order after these.
[**UpdateWholesaleDrop**](WholesaleApi.md#updatewholesaledrop) | **PATCH** /v1/wholesale/drops/{id} | Edit a trade drop (any create field but kind), schedule it (status \&quot;scheduled\&quot;, with dropAt in the future) or cancel it. A live drop can only be cancelled or have endsAt / perCustomerLimit changed.
[**UpdateWholesaleGroup**](WholesaleApi.md#updatewholesalegroup) | **PATCH** /v1/wholesale/groups/{id} | Rename a group, change its discount, or pause it (active&#x3D;false).
[**UpdateWholesaleListingTier**](WholesaleApi.md#updatewholesalelistingtier) | **PUT** /v1/wholesale/listings/{platformListingId}/tiers | Replace one listing&#39;s quantity breaks: [{ minQuantity ≥ 2, unitPriceCents }], each cheaper than the last and than the list price. An empty list removes them. Applies to every buyer at checkout.
[**UpdateWholesaleProfile**](WholesaleApi.md#updatewholesaleprofile) | **PUT** /v1/wholesale/profile | Save a store&#39;s trade profile. Omitted fields are unchanged; null clears. shipsFrom is checked by the shipping validator (400 invalid_ships_from). The profile is the bottom of the trade-terms cascade: catalogs and items that leave a term empty inherit it — saving never rewrites catalogs. Preset ids must be your own presets of that kind.
[**UpdateWholesaleReserve**](WholesaleApi.md#updatewholesalereserve) | **PUT** /v1/wholesale/reserve/{inventoryItemId} | Reserve N units of an inventory item for wholesale: retail channels advertise the rest and come down when only the reserve is left. 0 clears it.


<a name="createwholesalebuyerinvite"></a>
# **CreateWholesaleBuyerInvite**
> CreateWholesaleBuyerInviteResponse CreateWholesaleBuyerInvite (CreateWholesaleBuyerInviteRequest createWholesaleBuyerInviteRequest = null)

Invite a buyer by email to one or more of your catalogs. Binds to their account now if they have one, or when they sign up.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleBuyerInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleBuyerInviteRequest = new CreateWholesaleBuyerInviteRequest(); // CreateWholesaleBuyerInviteRequest |  (optional) 

            try
            {
                // Invite a buyer by email to one or more of your catalogs. Binds to their account now if they have one, or when they sign up.
                CreateWholesaleBuyerInviteResponse result = apiInstance.CreateWholesaleBuyerInvite(createWholesaleBuyerInviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleBuyerInvite: " + e.Message );
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
 **createWholesaleBuyerInviteRequest** | **CreateWholesaleBuyerInviteRequest**|  | [optional] 

### Return type

**CreateWholesaleBuyerInviteResponse**

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

<a name="createwholesalebuyerremove"></a>
# **CreateWholesaleBuyerRemove**
> CreateWholesaleBuyerRemoveResponse CreateWholesaleBuyerRemove (CreateWholesaleBuyerRemoveRequest createWholesaleBuyerRemoveRequest = null)

Revoke every catalog grant a buyer (or invited email) has with you. Their terms and invoices are kept.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleBuyerRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleBuyerRemoveRequest = new CreateWholesaleBuyerRemoveRequest(); // CreateWholesaleBuyerRemoveRequest |  (optional) 

            try
            {
                // Revoke every catalog grant a buyer (or invited email) has with you. Their terms and invoices are kept.
                CreateWholesaleBuyerRemoveResponse result = apiInstance.CreateWholesaleBuyerRemove(createWholesaleBuyerRemoveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleBuyerRemove: " + e.Message );
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
 **createWholesaleBuyerRemoveRequest** | **CreateWholesaleBuyerRemoveRequest**|  | [optional] 

### Return type

**CreateWholesaleBuyerRemoveResponse**

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

<a name="createwholesalecatalog"></a>
# **CreateWholesaleCatalog**
> CreateWholesaleCatalogResponse CreateWholesaleCatalog (CreateWholesaleCatalogRequest createWholesaleCatalogRequest = null)

Create a catalog. visibility public | public_prices_private (prices for approved buyers) | private_discoverable (listed, opened on approval) | link (anyone with the URL) | invite (named buyers only; \"private\" is accepted as invite); autoApprove never | verified | all; the cascade terms (minOrderQuantity, casePack, leadTimeDays, verifiedOnly, priceVisibility, maxPerOrder, backorder, restockEta, preset ids) default every item; listed advertises a public catalog in the wholesale directory (never its prices).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleCatalogRequest = new CreateWholesaleCatalogRequest(); // CreateWholesaleCatalogRequest |  (optional) 

            try
            {
                // Create a catalog. visibility public | public_prices_private (prices for approved buyers) | private_discoverable (listed, opened on approval) | link (anyone with the URL) | invite (named buyers only; \"private\" is accepted as invite); autoApprove never | verified | all; the cascade terms (minOrderQuantity, casePack, leadTimeDays, verifiedOnly, priceVisibility, maxPerOrder, backorder, restockEta, preset ids) default every item; listed advertises a public catalog in the wholesale directory (never its prices).
                CreateWholesaleCatalogResponse result = apiInstance.CreateWholesaleCatalog(createWholesaleCatalogRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleCatalog: " + e.Message );
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
 **createWholesaleCatalogRequest** | **CreateWholesaleCatalogRequest**|  | [optional] 

### Return type

**CreateWholesaleCatalogResponse**

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

<a name="createwholesalecatalogaccessresend"></a>
# **CreateWholesaleCatalogAccessResend**
> CreateWholesaleCatalogAccessResendResponse CreateWholesaleCatalogAccessResend (string id, string grantId)

Email a pending catalog invite again (an invited address with no Crossly account yet). One send per invite every 15 minutes: 429 with Retry-After inside that window. grantId is the catalogs[].grantId of GET /wholesale/buyers. Uses the X-Storefront-Id store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleCatalogAccessResendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var grantId = "grantId_example";  // string | 

            try
            {
                // Email a pending catalog invite again (an invited address with no Crossly account yet). One send per invite every 15 minutes: 429 with Retry-After inside that window. grantId is the catalogs[].grantId of GET /wholesale/buyers. Uses the X-Storefront-Id store.
                CreateWholesaleCatalogAccessResendResponse result = apiInstance.CreateWholesaleCatalogAccessResend(id, grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleCatalogAccessResend: " + e.Message );
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
 **grantId** | **string**|  | 

### Return type

**CreateWholesaleCatalogAccessResendResponse**

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

<a name="createwholesalecatalogitem"></a>
# **CreateWholesaleCatalogItem**
> CreateWholesaleCatalogItemResponse CreateWholesaleCatalogItem (string id, CreateWholesaleCatalogItemRequest createWholesaleCatalogItemRequest = null)

Add your Crossly listings to a catalog (up to 500), each with an optional wholesalePriceCents, minOrderQuantity and casePack. Items already in the catalog have their terms updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleCatalogItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleCatalogItemRequest = new CreateWholesaleCatalogItemRequest(); // CreateWholesaleCatalogItemRequest |  (optional) 

            try
            {
                // Add your Crossly listings to a catalog (up to 500), each with an optional wholesalePriceCents, minOrderQuantity and casePack. Items already in the catalog have their terms updated.
                CreateWholesaleCatalogItemResponse result = apiInstance.CreateWholesaleCatalogItem(id, createWholesaleCatalogItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleCatalogItem: " + e.Message );
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
 **createWholesaleCatalogItemRequest** | **CreateWholesaleCatalogItemRequest**|  | [optional] 

### Return type

**CreateWholesaleCatalogItemResponse**

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

<a name="createwholesaledrop"></a>
# **CreateWholesaleDrop**
> CreateWholesaleDropResponse CreateWholesaleDrop (CreateWholesaleDropRequest createWholesaleDropRequest = null)

Create a draft trade drop: name, dropAt (ISO; when it opens), audience trade|catalog (+ audienceCatalogId), kind release|prebook. A pre-book needs depositBps (100-9900) and shipBy (YYYY-MM-DD), and takes balanceNetDays (0-90) for the balance invoice. listingIds are your listing ids, each on Crossly. A pre-book makes its listings pre-orders, so buyers pay the deposit at checkout. Schedule it with PATCH status \"scheduled\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleDropRequest = new CreateWholesaleDropRequest(); // CreateWholesaleDropRequest |  (optional) 

            try
            {
                // Create a draft trade drop: name, dropAt (ISO; when it opens), audience trade|catalog (+ audienceCatalogId), kind release|prebook. A pre-book needs depositBps (100-9900) and shipBy (YYYY-MM-DD), and takes balanceNetDays (0-90) for the balance invoice. listingIds are your listing ids, each on Crossly. A pre-book makes its listings pre-orders, so buyers pay the deposit at checkout. Schedule it with PATCH status \"scheduled\".
                CreateWholesaleDropResponse result = apiInstance.CreateWholesaleDrop(createWholesaleDropRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleDrop: " + e.Message );
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
 **createWholesaleDropRequest** | **CreateWholesaleDropRequest**|  | [optional] 

### Return type

**CreateWholesaleDropResponse**

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

<a name="createwholesaledroprelease"></a>
# **CreateWholesaleDropRelease**
> CreateWholesaleDropReleaseResponse CreateWholesaleDropRelease (string id)

Release a live pre-book: every reserved balance becomes an invoice on account to its buyer (due in the drop balanceNetDays), emailed, and the drop ends. Safe to retry: only balances not yet invoiced are invoiced. Returns { invoiced, balanceCents, invoiceIds }.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleDropReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Release a live pre-book: every reserved balance becomes an invoice on account to its buyer (due in the drop balanceNetDays), emailed, and the drop ends. Safe to retry: only balances not yet invoiced are invoiced. Returns { invoiced, balanceCents, invoiceIds }.
                CreateWholesaleDropReleaseResponse result = apiInstance.CreateWholesaleDropRelease(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleDropRelease: " + e.Message );
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

**CreateWholesaleDropReleaseResponse**

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

<a name="createwholesalefreightrequestanswer"></a>
# **CreateWholesaleFreightRequestAnswer**
> CreateWholesaleFreightRequestAnswerResponse CreateWholesaleFreightRequestAnswer (string id, CreateWholesaleFreightRequestAnswerRequest createWholesaleFreightRequestAnswerRequest = null)

Answer an open freight request with a figure in CENTS (and an optional note).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleFreightRequestAnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleFreightRequestAnswerRequest = new CreateWholesaleFreightRequestAnswerRequest(); // CreateWholesaleFreightRequestAnswerRequest |  (optional) 

            try
            {
                // Answer an open freight request with a figure in CENTS (and an optional note).
                CreateWholesaleFreightRequestAnswerResponse result = apiInstance.CreateWholesaleFreightRequestAnswer(id, createWholesaleFreightRequestAnswerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleFreightRequestAnswer: " + e.Message );
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
 **createWholesaleFreightRequestAnswerRequest** | **CreateWholesaleFreightRequestAnswerRequest**|  | [optional] 

### Return type

**CreateWholesaleFreightRequestAnswerResponse**

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

<a name="createwholesalegroup"></a>
# **CreateWholesaleGroup**
> CreateWholesaleGroupResponse CreateWholesaleGroup (CreateWholesaleGroupRequest createWholesaleGroupRequest = null)

Create a customer group with a discount in basis points (up to 9000). A buyer in several groups gets the best rate, never a stacked one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleGroupRequest = new CreateWholesaleGroupRequest(); // CreateWholesaleGroupRequest |  (optional) 

            try
            {
                // Create a customer group with a discount in basis points (up to 9000). A buyer in several groups gets the best rate, never a stacked one.
                CreateWholesaleGroupResponse result = apiInstance.CreateWholesaleGroup(createWholesaleGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleGroup: " + e.Message );
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
 **createWholesaleGroupRequest** | **CreateWholesaleGroupRequest**|  | [optional] 

### Return type

**CreateWholesaleGroupResponse**

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

<a name="createwholesalegroupmember"></a>
# **CreateWholesaleGroupMember**
> CreateWholesaleGroupMemberResponse CreateWholesaleGroupMember (string id, CreateWholesaleBuyerRemoveRequest createWholesaleBuyerRemoveRequest = null)

Add a buyer to a group by account id or by the email of an existing Crossly account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleBuyerRemoveRequest = new CreateWholesaleBuyerRemoveRequest(); // CreateWholesaleBuyerRemoveRequest |  (optional) 

            try
            {
                // Add a buyer to a group by account id or by the email of an existing Crossly account.
                CreateWholesaleGroupMemberResponse result = apiInstance.CreateWholesaleGroupMember(id, createWholesaleBuyerRemoveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleGroupMember: " + e.Message );
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
 **createWholesaleBuyerRemoveRequest** | **CreateWholesaleBuyerRemoveRequest**|  | [optional] 

### Return type

**CreateWholesaleGroupMemberResponse**

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

<a name="createwholesaleinvoicecreditnote"></a>
# **CreateWholesaleInvoiceCreditNote**
> CreateWholesaleInvoiceCreditNoteResponse CreateWholesaleInvoiceCreditNote (string id, CreateWholesaleInvoiceCreditNoteRequest createWholesaleInvoiceCreditNoteRequest = null)

Issue a credit note on an on-account invoice (short shipment, damaged, pricing error, returned, goodwill, other): at most the balance due. Numbered <invoice>-CN<n>; settling the rest closes the invoice paid. Not a refund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleInvoiceCreditNoteRequest = new CreateWholesaleInvoiceCreditNoteRequest(); // CreateWholesaleInvoiceCreditNoteRequest |  (optional) 

            try
            {
                // Issue a credit note on an on-account invoice (short shipment, damaged, pricing error, returned, goodwill, other): at most the balance due. Numbered <invoice>-CN<n>; settling the rest closes the invoice paid. Not a refund.
                CreateWholesaleInvoiceCreditNoteResponse result = apiInstance.CreateWholesaleInvoiceCreditNote(id, createWholesaleInvoiceCreditNoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceCreditNote: " + e.Message );
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
 **createWholesaleInvoiceCreditNoteRequest** | **CreateWholesaleInvoiceCreditNoteRequest**|  | [optional] 

### Return type

**CreateWholesaleInvoiceCreditNoteResponse**

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

<a name="createwholesaleinvoicelatefee"></a>
# **CreateWholesaleInvoiceLateFee**
> WholesaleInvoiceResponse CreateWholesaleInvoiceLateFee (string id)

Add your late fee (invoice settings lateFeeBps) to an invoice by hand, once. The hourly sweep adds it automatically when an invoice goes overdue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceLateFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Add your late fee (invoice settings lateFeeBps) to an invoice by hand, once. The hourly sweep adds it automatically when an invoice goes overdue.
                WholesaleInvoiceResponse result = apiInstance.CreateWholesaleInvoiceLateFee(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceLateFee: " + e.Message );
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

**WholesaleInvoiceResponse**

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

<a name="createwholesaleinvoicemarkpaid"></a>
# **CreateWholesaleInvoiceMarkPaid**
> WholesaleInvoiceResponse CreateWholesaleInvoiceMarkPaid (string id, CreateWholesaleInvoiceMarkPaidRequest createWholesaleInvoiceMarkPaidRequest = null)

Record a payment the buyer made to you directly: method ach | check | wire | card | other, a reference, and amountCents (omit for the whole balance). When the invoice is settled, Crossly's fee and the tax it remits are charged to your billing card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceMarkPaidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleInvoiceMarkPaidRequest = new CreateWholesaleInvoiceMarkPaidRequest(); // CreateWholesaleInvoiceMarkPaidRequest |  (optional) 

            try
            {
                // Record a payment the buyer made to you directly: method ach | check | wire | card | other, a reference, and amountCents (omit for the whole balance). When the invoice is settled, Crossly's fee and the tax it remits are charged to your billing card.
                WholesaleInvoiceResponse result = apiInstance.CreateWholesaleInvoiceMarkPaid(id, createWholesaleInvoiceMarkPaidRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceMarkPaid: " + e.Message );
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
 **createWholesaleInvoiceMarkPaidRequest** | **CreateWholesaleInvoiceMarkPaidRequest**|  | [optional] 

### Return type

**WholesaleInvoiceResponse**

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

<a name="createwholesaleinvoicesend"></a>
# **CreateWholesaleInvoiceSend**
> CreateWholesaleInvoiceSendResponse CreateWholesaleInvoiceSend (string id)

Email the invoice to the buyer again (an overdue one goes as an overdue notice), with the link to pay it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Email the invoice to the buyer again (an overdue one goes as an overdue notice), with the link to pay it.
                CreateWholesaleInvoiceSendResponse result = apiInstance.CreateWholesaleInvoiceSend(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceSend: " + e.Message );
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

**CreateWholesaleInvoiceSendResponse**

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

<a name="createwholesaleinvoicevoid"></a>
# **CreateWholesaleInvoiceVoid**
> WholesaleInvoiceResponse CreateWholesaleInvoiceVoid (string id)

Void an invoice nobody has paid anything on (e.g. the order was cancelled). It stops counting against the buyer's credit limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceVoidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Void an invoice nobody has paid anything on (e.g. the order was cancelled). It stops counting against the buyer's credit limit.
                WholesaleInvoiceResponse result = apiInstance.CreateWholesaleInvoiceVoid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceVoid: " + e.Message );
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

**WholesaleInvoiceResponse**

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

<a name="createwholesaleinvoicewriteoff"></a>
# **CreateWholesaleInvoiceWriteOff**
> WholesaleInvoiceResponse CreateWholesaleInvoiceWriteOff (string id, NoteRequest noteRequest = null)

Write off what is left on an invoice (bad debt): it closes as written_off and stops counting against the buyer's credit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleInvoiceWriteOffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var noteRequest = new NoteRequest(); // NoteRequest |  (optional) 

            try
            {
                // Write off what is left on an invoice (bad debt): it closes as written_off and stops counting against the buyer's credit.
                WholesaleInvoiceResponse result = apiInstance.CreateWholesaleInvoiceWriteOff(id, noteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleInvoiceWriteOff: " + e.Message );
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

**WholesaleInvoiceResponse**

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

<a name="createwholesaleprofileshipsfromvalidate"></a>
# **CreateWholesaleProfileShipsFromValidate**
> CreateWholesaleProfileShipsFromValidateResponse CreateWholesaleProfileShipsFromValidate (CreateWholesaleProfileShipsFromValidateRequest createWholesaleProfileShipsFromValidateRequest = null)

Check a ships-from origin ({ postalCode, country, city?, region? }) with the shipping validator without saving it. 400 invalid_ships_from with the issues; 422 for an embargoed origin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleProfileShipsFromValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleProfileShipsFromValidateRequest = new CreateWholesaleProfileShipsFromValidateRequest(); // CreateWholesaleProfileShipsFromValidateRequest |  (optional) 

            try
            {
                // Check a ships-from origin ({ postalCode, country, city?, region? }) with the shipping validator without saving it. 400 invalid_ships_from with the issues; 422 for an embargoed origin.
                CreateWholesaleProfileShipsFromValidateResponse result = apiInstance.CreateWholesaleProfileShipsFromValidate(createWholesaleProfileShipsFromValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleProfileShipsFromValidate: " + e.Message );
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
 **createWholesaleProfileShipsFromValidateRequest** | **CreateWholesaleProfileShipsFromValidateRequest**|  | [optional] 

### Return type

**CreateWholesaleProfileShipsFromValidateResponse**

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

<a name="createwholesalequoteanswer"></a>
# **CreateWholesaleQuoteAnswer**
> WholesaleQuoteResponse CreateWholesaleQuoteAnswer (string id, CreateWholesaleQuoteAnswerRequest createWholesaleQuoteAnswerRequest = null)

Answer (or revise) a quote: a unit price in CENTS per item you quote, an expiresAt (ISO, at most 90 days out) and an optional note. Items left out are not quoted. The buyer is notified and can accept until expiry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleQuoteAnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleQuoteAnswerRequest = new CreateWholesaleQuoteAnswerRequest(); // CreateWholesaleQuoteAnswerRequest |  (optional) 

            try
            {
                // Answer (or revise) a quote: a unit price in CENTS per item you quote, an expiresAt (ISO, at most 90 days out) and an optional note. Items left out are not quoted. The buyer is notified and can accept until expiry.
                WholesaleQuoteResponse result = apiInstance.CreateWholesaleQuoteAnswer(id, createWholesaleQuoteAnswerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleQuoteAnswer: " + e.Message );
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
 **createWholesaleQuoteAnswerRequest** | **CreateWholesaleQuoteAnswerRequest**|  | [optional] 

### Return type

**WholesaleQuoteResponse**

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

<a name="createwholesalequotedecline"></a>
# **CreateWholesaleQuoteDecline**
> WholesaleQuoteResponse CreateWholesaleQuoteDecline (string id, ReasonRequest2 reasonRequest2 = null)

Decline a quote request, with an optional reason the buyer sees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleQuoteDeclineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var reasonRequest2 = new ReasonRequest2(); // ReasonRequest2 |  (optional) 

            try
            {
                // Decline a quote request, with an optional reason the buyer sees.
                WholesaleQuoteResponse result = apiInstance.CreateWholesaleQuoteDecline(id, reasonRequest2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleQuoteDecline: " + e.Message );
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
 **reasonRequest2** | **ReasonRequest2**|  | [optional] 

### Return type

**WholesaleQuoteResponse**

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

<a name="createwholesalerequestdecide"></a>
# **CreateWholesaleRequestDecide**
> CreateWholesaleRequestDecideResponse CreateWholesaleRequestDecide (string id, CreateWholesaleRequestDecideRequest createWholesaleRequestDecideRequest = null)

Approve (grants access to that catalog; optional groupId adds the buyer to a customer group) or decline (optional reason) an access request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleRequestDecideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var createWholesaleRequestDecideRequest = new CreateWholesaleRequestDecideRequest(); // CreateWholesaleRequestDecideRequest |  (optional) 

            try
            {
                // Approve (grants access to that catalog; optional groupId adds the buyer to a customer group) or decline (optional reason) an access request.
                CreateWholesaleRequestDecideResponse result = apiInstance.CreateWholesaleRequestDecide(id, createWholesaleRequestDecideRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleRequestDecide: " + e.Message );
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
 **createWholesaleRequestDecideRequest** | **CreateWholesaleRequestDecideRequest**|  | [optional] 

### Return type

**CreateWholesaleRequestDecideResponse**

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

<a name="createwholesaletierbulk"></a>
# **CreateWholesaleTierBulk**
> CreateWholesaleTierBulkResponse CreateWholesaleTierBulk (CreateWholesaleTierBulkRequest createWholesaleTierBulkRequest = null)

One ladder for many listings: breaks as [{ minQuantity, discountBps }] off each listing's own price. Returns how many were updated and which were skipped and why.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWholesaleTierBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var createWholesaleTierBulkRequest = new CreateWholesaleTierBulkRequest(); // CreateWholesaleTierBulkRequest |  (optional) 

            try
            {
                // One ladder for many listings: breaks as [{ minQuantity, discountBps }] off each listing's own price. Returns how many were updated and which were skipped and why.
                CreateWholesaleTierBulkResponse result = apiInstance.CreateWholesaleTierBulk(createWholesaleTierBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.CreateWholesaleTierBulk: " + e.Message );
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
 **createWholesaleTierBulkRequest** | **CreateWholesaleTierBulkRequest**|  | [optional] 

### Return type

**CreateWholesaleTierBulkResponse**

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

<a name="deletewholesalebuyerterm"></a>
# **DeleteWholesaleBuyerTerm**
> UpdateGroupBuyResponse DeleteWholesaleBuyerTerm (string buyerUserId)

Switch a buyer's account terms off. Invoices already issued are unaffected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleBuyerTermExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var buyerUserId = "buyerUserId_example";  // string | 

            try
            {
                // Switch a buyer's account terms off. Invoices already issued are unaffected.
                UpdateGroupBuyResponse result = apiInstance.DeleteWholesaleBuyerTerm(buyerUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleBuyerTerm: " + e.Message );
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
 **buyerUserId** | **string**|  | 

### Return type

**UpdateGroupBuyResponse**

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

<a name="deletewholesalecatalog"></a>
# **DeleteWholesaleCatalog**
> UpdateGroupBuyResponse DeleteWholesaleCatalog (string id)

Delete a catalog with its items, grants and access requests. Orders and invoices are untouched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a catalog with its items, grants and access requests. Orders and invoices are untouched.
                UpdateGroupBuyResponse result = apiInstance.DeleteWholesaleCatalog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleCatalog: " + e.Message );
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

**UpdateGroupBuyResponse**

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

<a name="deletewholesalecatalogaccess"></a>
# **DeleteWholesaleCatalogAccess**
> DeleteWholesaleCatalogAccessResponse DeleteWholesaleCatalogAccess (string id, string grantId)

Revoke one buyer's (or invited address's) access to this ONE catalog; their other catalogs, terms, groups and invoices are kept. /wholesale/buyers/remove revokes every catalog. Uses the X-Storefront-Id store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleCatalogAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var grantId = "grantId_example";  // string | 

            try
            {
                // Revoke one buyer's (or invited address's) access to this ONE catalog; their other catalogs, terms, groups and invoices are kept. /wholesale/buyers/remove revokes every catalog. Uses the X-Storefront-Id store.
                DeleteWholesaleCatalogAccessResponse result = apiInstance.DeleteWholesaleCatalogAccess(id, grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleCatalogAccess: " + e.Message );
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
 **grantId** | **string**|  | 

### Return type

**DeleteWholesaleCatalogAccessResponse**

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

<a name="deletewholesalecatalogitem"></a>
# **DeleteWholesaleCatalogItem**
> UpdateGroupBuyResponse DeleteWholesaleCatalogItem (string id, string platformListingId)

Take an item out of a catalog. The listing itself is untouched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleCatalogItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var platformListingId = "platformListingId_example";  // string | 

            try
            {
                // Take an item out of a catalog. The listing itself is untouched.
                UpdateGroupBuyResponse result = apiInstance.DeleteWholesaleCatalogItem(id, platformListingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleCatalogItem: " + e.Message );
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
 **platformListingId** | **string**|  | 

### Return type

**UpdateGroupBuyResponse**

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

<a name="deletewholesalegroup"></a>
# **DeleteWholesaleGroup**
> UpdateGroupBuyResponse DeleteWholesaleGroup (string id)

Delete a customer group. Its members keep any other group or account rate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a customer group. Its members keep any other group or account rate.
                UpdateGroupBuyResponse result = apiInstance.DeleteWholesaleGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleGroup: " + e.Message );
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

**UpdateGroupBuyResponse**

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

<a name="deletewholesalegroupmember"></a>
# **DeleteWholesaleGroupMember**
> UpdateGroupBuyResponse DeleteWholesaleGroupMember (string id, string buyerUserId)

Take a buyer out of a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWholesaleGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var buyerUserId = "buyerUserId_example";  // string | 

            try
            {
                // Take a buyer out of a group.
                UpdateGroupBuyResponse result = apiInstance.DeleteWholesaleGroupMember(id, buyerUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.DeleteWholesaleGroupMember: " + e.Message );
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
 **buyerUserId** | **string**|  | 

### Return type

**UpdateGroupBuyResponse**

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

<a name="getwholesalecataloglinesheet"></a>
# **GetWholesaleCatalogLineSheet**
> GetWholesaleCatalogLineSheetResponse GetWholesaleCatalogLineSheet (string id)

The catalog's line sheet: your company details and terms, then every item with retail and trade price, minimum, case pack and quantity breaks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleCatalogLineSheetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The catalog's line sheet: your company details and terms, then every item with retail and trade price, minimum, case pack and quantity breaks.
                GetWholesaleCatalogLineSheetResponse result = apiInstance.GetWholesaleCatalogLineSheet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleCatalogLineSheet: " + e.Message );
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

**GetWholesaleCatalogLineSheetResponse**

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

<a name="getwholesalecatalogshare"></a>
# **GetWholesaleCatalogShare**
> GetWholesaleCatalogShareResponse GetWholesaleCatalogShare (string id)

The catalog's buyer link (null until you have a shop username), to share or print as a QR code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleCatalogShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The catalog's buyer link (null until you have a shop username), to share or print as a QR code.
                GetWholesaleCatalogShareResponse result = apiInstance.GetWholesaleCatalogShare(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleCatalogShare: " + e.Message );
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

**GetWholesaleCatalogShareResponse**

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

<a name="getwholesalecategory"></a>
# **GetWholesaleCategory**
> GetWholesaleCategoryResponse GetWholesaleCategory ()

The wholesale category taxonomy (id, label, group). A catalog or trade profile takes up to 12 ids, or \"other:<words>\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // The wholesale category taxonomy (id, label, group). A catalog or trade profile takes up to 12 ids, or \"other:<words>\".
                GetWholesaleCategoryResponse result = apiInstance.GetWholesaleCategory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleCategory: " + e.Message );
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

**GetWholesaleCategoryResponse**

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

<a name="getwholesaledrop"></a>
# **GetWholesaleDrop**
> GetWholesaleDropResponse GetWholesaleDrop (string id)

One trade drop with its listings and, for a pre-book, every reservation: buyer, item, quantity, deposit, balance, status and the balance invoice once released.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One trade drop with its listings and, for a pre-book, every reservation: buyer, item, quantity, deposit, balance, status and the balance invoice once released.
                GetWholesaleDropResponse result = apiInstance.GetWholesaleDrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleDrop: " + e.Message );
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

**GetWholesaleDropResponse**

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

<a name="getwholesaleinvoice"></a>
# **GetWholesaleInvoice**
> WholesaleInvoiceResponse GetWholesaleInvoice (string id)

One invoice with its lines, PO reference, payments and whether Crossly dues on it are collected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One invoice with its lines, PO reference, payments and whether Crossly dues on it are collected.
                WholesaleInvoiceResponse result = apiInstance.GetWholesaleInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleInvoice: " + e.Message );
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

**WholesaleInvoiceResponse**

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

<a name="getwholesaleoverview"></a>
# **GetWholesaleOverview**
> GetWholesaleOverviewResponse GetWholesaleOverview ()

Your wholesale store at a glance: the setup checklist, 30-day wholesale revenue, open orders, outstanding invoices, active buyers and pending access requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Your wholesale store at a glance: the setup checklist, 30-day wholesale revenue, open orders, outstanding invoices, active buyers and pending access requests.
                GetWholesaleOverviewResponse result = apiInstance.GetWholesaleOverview();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleOverview: " + e.Message );
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

**GetWholesaleOverviewResponse**

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

<a name="getwholesaleprofile"></a>
# **GetWholesaleProfile**
> GetWholesaleProfileResponse GetWholesaleProfile ()

A store's trade profile (X-Storefront-Id; default store when omitted): company, tagline, logo and banner, contact, ships-from origin, lead time, order minimums (opening, first order, reorder), the default MOQ / case pack / max per order / backorder / price visibility, return, payment and shipping preset ids, invoicing and its settings, buyer requirements and the directory defaults.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // A store's trade profile (X-Storefront-Id; default store when omitted): company, tagline, logo and banner, contact, ships-from origin, lead time, order minimums (opening, first order, reorder), the default MOQ / case pack / max per order / backorder / price visibility, return, payment and shipping preset ids, invoicing and its settings, buyer requirements and the directory defaults.
                GetWholesaleProfileResponse result = apiInstance.GetWholesaleProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleProfile: " + e.Message );
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

**GetWholesaleProfileResponse**

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

<a name="getwholesalequote"></a>
# **GetWholesaleQuote**
> WholesaleQuoteResponse GetWholesaleQuote (string id)

One quote request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One quote request.
                WholesaleQuoteResponse result = apiInstance.GetWholesaleQuote(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleQuote: " + e.Message );
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

**WholesaleQuoteResponse**

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

<a name="getwholesalereserve"></a>
# **GetWholesaleReserve**
> GetWholesaleReserveResponse GetWholesaleReserve (string inventoryItemId)

How many units of an inventory item are held back for wholesale, and what retail channels advertise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleReserveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // How many units of an inventory item are held back for wholesale, and what retail channels advertise.
                GetWholesaleReserveResponse result = apiInstance.GetWholesaleReserve(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleReserve: " + e.Message );
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
 **inventoryItemId** | **string**|  | 

### Return type

**GetWholesaleReserveResponse**

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

<a name="getwholesaletermpreview"></a>
# **GetWholesaleTermPreview**
> GetWholesaleTermPreviewResponse GetWholesaleTermPreview (string catalogId = null, string platformListingId = null, string storefrontId = null)

The trade terms that apply to a catalog item (?catalogId&platformListingId), a catalog (?catalogId) or the trade profile alone, each with its source (item, catalog, profile, default), plus the return, payment and shipping policies they resolve to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWholesaleTermPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var catalogId = "catalogId_example";  // string |  (optional) 
            var platformListingId = "platformListingId_example";  // string |  (optional) 
            var storefrontId = "storefrontId_example";  // string |  (optional) 

            try
            {
                // The trade terms that apply to a catalog item (?catalogId&platformListingId), a catalog (?catalogId) or the trade profile alone, each with its source (item, catalog, profile, default), plus the return, payment and shipping policies they resolve to.
                GetWholesaleTermPreviewResponse result = apiInstance.GetWholesaleTermPreview(catalogId, platformListingId, storefrontId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.GetWholesaleTermPreview: " + e.Message );
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
 **catalogId** | **string**|  | [optional] 
 **platformListingId** | **string**|  | [optional] 
 **storefrontId** | **string**|  | [optional] 

### Return type

**GetWholesaleTermPreviewResponse**

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

<a name="listwholesalebuyers"></a>
# **ListWholesaleBuyers**
> ListWholesaleBuyersResponse ListWholesaleBuyers ()

Your trade buyers: catalogs they can open, customer groups, account terms, outstanding balance, wholesale spend, business verification and resale-certificate status (read-only — Crossly reviews those).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleBuyersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Your trade buyers: catalogs they can open, customer groups, account terms, outstanding balance, wholesale spend, business verification and resale-certificate status (read-only — Crossly reviews those).
                ListWholesaleBuyersResponse result = apiInstance.ListWholesaleBuyers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleBuyers: " + e.Message );
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

**ListWholesaleBuyersResponse**

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

<a name="listwholesalecatalogitems"></a>
# **ListWholesaleCatalogItems**
> ListWholesaleCatalogItemsResponse ListWholesaleCatalogItems (string id)

A catalog's items in merchandising order, each with its retail price, trade price, minimum order quantity, case pack and quantity breaks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleCatalogItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A catalog's items in merchandising order, each with its retail price, trade price, minimum order quantity, case pack and quantity breaks.
                ListWholesaleCatalogItemsResponse result = apiInstance.ListWholesaleCatalogItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleCatalogItems: " + e.Message );
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

**ListWholesaleCatalogItemsResponse**

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

<a name="listwholesalecatalogs"></a>
# **ListWholesaleCatalogs**
> ListWholesaleCatalogsResponse ListWholesaleCatalogs ()

Your wholesale catalogs with item, buyer-grant and pending-request counts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleCatalogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Your wholesale catalogs with item, buyer-grant and pending-request counts.
                ListWholesaleCatalogsResponse result = apiInstance.ListWholesaleCatalogs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleCatalogs: " + e.Message );
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

**ListWholesaleCatalogsResponse**

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

<a name="listwholesaledrops"></a>
# **ListWholesaleDrops**
> ListWholesaleDropsResponse ListWholesaleDrops (string status = null)

Your trade drops and pre-books: audience (trade = your approved trade buyers, catalog = whoever can open audienceCatalogId), kind (release | prebook), deposit, ship date, status, and for a pre-book its reservation totals (buyers, units, deposits taken, balances still to invoice).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleDropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var status = "draft";  // string |  (optional) 

            try
            {
                // Your trade drops and pre-books: audience (trade = your approved trade buyers, catalog = whoever can open audienceCatalogId), kind (release | prebook), deposit, ship date, status, and for a pre-book its reservation totals (buyers, units, deposits taken, balances still to invoice).
                ListWholesaleDropsResponse result = apiInstance.ListWholesaleDrops(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleDrops: " + e.Message );
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
 **status** | **string**|  | [optional] 

### Return type

**ListWholesaleDropsResponse**

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

<a name="listwholesalefreightrequests"></a>
# **ListWholesaleFreightRequests**
> ListWholesaleFreightRequestsResponse ListWholesaleFreightRequests ()

Freight (LTL) quote requests from buyers whose order is over your pallet threshold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleFreightRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Freight (LTL) quote requests from buyers whose order is over your pallet threshold.
                ListWholesaleFreightRequestsResponse result = apiInstance.ListWholesaleFreightRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleFreightRequests: " + e.Message );
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

**ListWholesaleFreightRequestsResponse**

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

<a name="listwholesalegroups"></a>
# **ListWholesaleGroups**
> ListWholesaleGroupsResponse ListWholesaleGroups ()

Your customer groups with their discount and members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Your customer groups with their discount and members.
                ListWholesaleGroupsResponse result = apiInstance.ListWholesaleGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleGroups: " + e.Message );
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

**ListWholesaleGroupsResponse**

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

<a name="listwholesaleinvoices"></a>
# **ListWholesaleInvoices**
> ListWholesaleInvoicesResponse ListWholesaleInvoices (string status = null, string buyerUserId = null, decimal? limit = null)

On-account invoices, newest first, with balance due. ?status=unpaid for open, partial and overdue together.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var status = "partial";  // string |  (optional) 
            var buyerUserId = "buyerUserId_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // On-account invoices, newest first, with balance due. ?status=unpaid for open, partial and overdue together.
                ListWholesaleInvoicesResponse result = apiInstance.ListWholesaleInvoices(status, buyerUserId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleInvoices: " + e.Message );
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
 **status** | **string**|  | [optional] 
 **buyerUserId** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

**ListWholesaleInvoicesResponse**

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

<a name="listwholesaleorders"></a>
# **ListWholesaleOrders**
> ListWholesaleOrdersResponse ListWholesaleOrders ()

Wholesale orders: Crossly orders priced through your trade terms (catalog price, quantity break or account rate) or placed on account. Fulfil them like any order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Wholesale orders: Crossly orders priced through your trade terms (catalog price, quantity break or account rate) or placed on account. Fulfil them like any order.
                ListWholesaleOrdersResponse result = apiInstance.ListWholesaleOrders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleOrders: " + e.Message );
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

**ListWholesaleOrdersResponse**

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

<a name="listwholesalequotes"></a>
# **ListWholesaleQuotes**
> ListWholesaleQuotesResponse ListWholesaleQuotes (string status = null)

Quote requests (RFQ) from trade buyers: items with quantity and target price, your quoted prices and expiry. ?status=open lists the ones waiting on you or the buyer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleQuotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var status = "all";  // string |  (optional) 

            try
            {
                // Quote requests (RFQ) from trade buyers: items with quantity and target price, your quoted prices and expiry. ?status=open lists the ones waiting on you or the buyer.
                ListWholesaleQuotesResponse result = apiInstance.ListWholesaleQuotes(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleQuotes: " + e.Message );
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
 **status** | **string**|  | [optional] 

### Return type

**ListWholesaleQuotesResponse**

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

<a name="listwholesalerequests"></a>
# **ListWholesaleRequests**
> ListWholesaleRequestsResponse ListWholesaleRequests ()

Requests from buyers to open your private or trade-only catalogs, with each buyer's business-verification and tax-exempt status. ?status=all includes decided ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // Requests from buyers to open your private or trade-only catalogs, with each buyer's business-verification and tax-exempt status. ?status=all includes decided ones.
                ListWholesaleRequestsResponse result = apiInstance.ListWholesaleRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleRequests: " + e.Message );
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

**ListWholesaleRequestsResponse**

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

<a name="listwholesalesetupsteps"></a>
# **ListWholesaleSetupSteps**
> ListWholesaleSetupStepsResponse ListWholesaleSetupSteps ()

The wholesale setup checklist for a store: profile, ships-from, payment, returns, a catalog with items, visibility chosen, live. Each step is done because the thing exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWholesaleSetupStepsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);

            try
            {
                // The wholesale setup checklist for a store: profile, ships-from, payment, returns, a catalog with items, visibility chosen, live. Each step is done because the thing exists.
                ListWholesaleSetupStepsResponse result = apiInstance.ListWholesaleSetupSteps();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.ListWholesaleSetupSteps: " + e.Message );
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

**ListWholesaleSetupStepsResponse**

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

<a name="updatewholesalebuyerterm"></a>
# **UpdateWholesaleBuyerTerm**
> UpdateWholesaleBuyerTermResponse UpdateWholesaleBuyerTerm (string buyerUserId, UpdateWholesaleBuyerTermRequest updateWholesaleBuyerTermRequest = null)

Set a buyer's account terms: netDays (0-120) for paying on account, creditLimitCents (the most they may owe you at once; null = no limit) and discountPercentBps (their negotiated rate).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleBuyerTermExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var buyerUserId = "buyerUserId_example";  // string | 
            var updateWholesaleBuyerTermRequest = new UpdateWholesaleBuyerTermRequest(); // UpdateWholesaleBuyerTermRequest |  (optional) 

            try
            {
                // Set a buyer's account terms: netDays (0-120) for paying on account, creditLimitCents (the most they may owe you at once; null = no limit) and discountPercentBps (their negotiated rate).
                UpdateWholesaleBuyerTermResponse result = apiInstance.UpdateWholesaleBuyerTerm(buyerUserId, updateWholesaleBuyerTermRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleBuyerTerm: " + e.Message );
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
 **buyerUserId** | **string**|  | 
 **updateWholesaleBuyerTermRequest** | **UpdateWholesaleBuyerTermRequest**|  | [optional] 

### Return type

**UpdateWholesaleBuyerTermResponse**

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

<a name="updatewholesalecatalog"></a>
# **UpdateWholesaleCatalog**
> CreateWholesaleCatalogResponse UpdateWholesaleCatalog (string id, UpdateWholesaleCatalogRequest updateWholesaleCatalogRequest = null)

Edit a catalog: name, slug, description, cover image, visibility, opening-order minimum, trade gate, directory listing, active.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var updateWholesaleCatalogRequest = new UpdateWholesaleCatalogRequest(); // UpdateWholesaleCatalogRequest |  (optional) 

            try
            {
                // Edit a catalog: name, slug, description, cover image, visibility, opening-order minimum, trade gate, directory listing, active.
                CreateWholesaleCatalogResponse result = apiInstance.UpdateWholesaleCatalog(id, updateWholesaleCatalogRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleCatalog: " + e.Message );
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
 **updateWholesaleCatalogRequest** | **UpdateWholesaleCatalogRequest**|  | [optional] 

### Return type

**CreateWholesaleCatalogResponse**

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

<a name="updatewholesalecatalogitem"></a>
# **UpdateWholesaleCatalogItem**
> UpdateWholesaleCatalogItemResponse UpdateWholesaleCatalogItem (string id, UpdateWholesaleCatalogItemRequest updateWholesaleCatalogItemRequest = null)

Change many catalog items at once: items[] sets each row (trade price, MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids); or platformListingIds + set applies the same values to each, set.pctOffRetailBps pricing each from its retail price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleCatalogItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var updateWholesaleCatalogItemRequest = new UpdateWholesaleCatalogItemRequest(); // UpdateWholesaleCatalogItemRequest |  (optional) 

            try
            {
                // Change many catalog items at once: items[] sets each row (trade price, MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids); or platformListingIds + set applies the same values to each, set.pctOffRetailBps pricing each from its retail price.
                UpdateWholesaleCatalogItemResponse result = apiInstance.UpdateWholesaleCatalogItem(id, updateWholesaleCatalogItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleCatalogItem: " + e.Message );
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
 **updateWholesaleCatalogItemRequest** | **UpdateWholesaleCatalogItemRequest**|  | [optional] 

### Return type

**UpdateWholesaleCatalogItemResponse**

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

<a name="updatewholesalecatalogitembyplatformlistingid"></a>
# **UpdateWholesaleCatalogItemByPlatformListingId**
> UpdateGroupBuyResponse UpdateWholesaleCatalogItemByPlatformListingId (string id, string platformListingId, UpdateWholesaleCatalogItemByPlatformListingIdRequest updateWholesaleCatalogItemByPlatformListingIdRequest = null)

Change one item's trade price and its own trade terms in this catalog (MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids). null clears = inherit from the catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleCatalogItemByPlatformListingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var platformListingId = "platformListingId_example";  // string | 
            var updateWholesaleCatalogItemByPlatformListingIdRequest = new UpdateWholesaleCatalogItemByPlatformListingIdRequest(); // UpdateWholesaleCatalogItemByPlatformListingIdRequest |  (optional) 

            try
            {
                // Change one item's trade price and its own trade terms in this catalog (MOQ, case pack, lead time, max per order, backorder, restock date, verified-only, price visibility, preset ids). null clears = inherit from the catalog.
                UpdateGroupBuyResponse result = apiInstance.UpdateWholesaleCatalogItemByPlatformListingId(id, platformListingId, updateWholesaleCatalogItemByPlatformListingIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleCatalogItemByPlatformListingId: " + e.Message );
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
 **platformListingId** | **string**|  | 
 **updateWholesaleCatalogItemByPlatformListingIdRequest** | **UpdateWholesaleCatalogItemByPlatformListingIdRequest**|  | [optional] 

### Return type

**UpdateGroupBuyResponse**

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

<a name="updatewholesalecatalogitemorder"></a>
# **UpdateWholesaleCatalogItemOrder**
> ListWholesaleCatalogItemsResponse UpdateWholesaleCatalogItemOrder (string id, UpdateLiveStreamLineupRequest updateLiveStreamLineupRequest = null)

Set the merchandising order: platform listing ids, first to last. Items left out keep their relative order after these.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleCatalogItemOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var updateLiveStreamLineupRequest = new UpdateLiveStreamLineupRequest(); // UpdateLiveStreamLineupRequest |  (optional) 

            try
            {
                // Set the merchandising order: platform listing ids, first to last. Items left out keep their relative order after these.
                ListWholesaleCatalogItemsResponse result = apiInstance.UpdateWholesaleCatalogItemOrder(id, updateLiveStreamLineupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleCatalogItemOrder: " + e.Message );
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
 **updateLiveStreamLineupRequest** | **UpdateLiveStreamLineupRequest**|  | [optional] 

### Return type

**ListWholesaleCatalogItemsResponse**

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

<a name="updatewholesaledrop"></a>
# **UpdateWholesaleDrop**
> CreateWholesaleDropResponse UpdateWholesaleDrop (string id, UpdateWholesaleDropRequest updateWholesaleDropRequest = null)

Edit a trade drop (any create field but kind), schedule it (status \"scheduled\", with dropAt in the future) or cancel it. A live drop can only be cancelled or have endsAt / perCustomerLimit changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var updateWholesaleDropRequest = new UpdateWholesaleDropRequest(); // UpdateWholesaleDropRequest |  (optional) 

            try
            {
                // Edit a trade drop (any create field but kind), schedule it (status \"scheduled\", with dropAt in the future) or cancel it. A live drop can only be cancelled or have endsAt / perCustomerLimit changed.
                CreateWholesaleDropResponse result = apiInstance.UpdateWholesaleDrop(id, updateWholesaleDropRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleDrop: " + e.Message );
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
 **updateWholesaleDropRequest** | **UpdateWholesaleDropRequest**|  | [optional] 

### Return type

**CreateWholesaleDropResponse**

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

<a name="updatewholesalegroup"></a>
# **UpdateWholesaleGroup**
> CreateWholesaleGroupResponse UpdateWholesaleGroup (string id, UpdateWholesaleGroupRequest updateWholesaleGroupRequest = null)

Rename a group, change its discount, or pause it (active=false).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var id = "id_example";  // string | 
            var updateWholesaleGroupRequest = new UpdateWholesaleGroupRequest(); // UpdateWholesaleGroupRequest |  (optional) 

            try
            {
                // Rename a group, change its discount, or pause it (active=false).
                CreateWholesaleGroupResponse result = apiInstance.UpdateWholesaleGroup(id, updateWholesaleGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleGroup: " + e.Message );
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
 **updateWholesaleGroupRequest** | **UpdateWholesaleGroupRequest**|  | [optional] 

### Return type

**CreateWholesaleGroupResponse**

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

<a name="updatewholesalelistingtier"></a>
# **UpdateWholesaleListingTier**
> UpdateWholesaleListingTierResponse UpdateWholesaleListingTier (string platformListingId, UpdateWholesaleListingTierRequest updateWholesaleListingTierRequest = null)

Replace one listing's quantity breaks: [{ minQuantity ≥ 2, unitPriceCents }], each cheaper than the last and than the list price. An empty list removes them. Applies to every buyer at checkout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleListingTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var platformListingId = "platformListingId_example";  // string | 
            var updateWholesaleListingTierRequest = new UpdateWholesaleListingTierRequest(); // UpdateWholesaleListingTierRequest |  (optional) 

            try
            {
                // Replace one listing's quantity breaks: [{ minQuantity ≥ 2, unitPriceCents }], each cheaper than the last and than the list price. An empty list removes them. Applies to every buyer at checkout.
                UpdateWholesaleListingTierResponse result = apiInstance.UpdateWholesaleListingTier(platformListingId, updateWholesaleListingTierRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleListingTier: " + e.Message );
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
 **platformListingId** | **string**|  | 
 **updateWholesaleListingTierRequest** | **UpdateWholesaleListingTierRequest**|  | [optional] 

### Return type

**UpdateWholesaleListingTierResponse**

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

<a name="updatewholesaleprofile"></a>
# **UpdateWholesaleProfile**
> UpdateWholesaleProfileResponse UpdateWholesaleProfile (UpdateWholesaleProfileRequest updateWholesaleProfileRequest = null)

Save a store's trade profile. Omitted fields are unchanged; null clears. shipsFrom is checked by the shipping validator (400 invalid_ships_from). The profile is the bottom of the trade-terms cascade: catalogs and items that leave a term empty inherit it — saving never rewrites catalogs. Preset ids must be your own presets of that kind.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var updateWholesaleProfileRequest = new UpdateWholesaleProfileRequest(); // UpdateWholesaleProfileRequest |  (optional) 

            try
            {
                // Save a store's trade profile. Omitted fields are unchanged; null clears. shipsFrom is checked by the shipping validator (400 invalid_ships_from). The profile is the bottom of the trade-terms cascade: catalogs and items that leave a term empty inherit it — saving never rewrites catalogs. Preset ids must be your own presets of that kind.
                UpdateWholesaleProfileResponse result = apiInstance.UpdateWholesaleProfile(updateWholesaleProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleProfile: " + e.Message );
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
 **updateWholesaleProfileRequest** | **UpdateWholesaleProfileRequest**|  | [optional] 

### Return type

**UpdateWholesaleProfileResponse**

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

<a name="updatewholesalereserve"></a>
# **UpdateWholesaleReserve**
> GetWholesaleReserveResponse UpdateWholesaleReserve (string inventoryItemId, UpdateWholesaleReserveRequest updateWholesaleReserveRequest = null)

Reserve N units of an inventory item for wholesale: retail channels advertise the rest and come down when only the reserve is left. 0 clears it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWholesaleReserveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WholesaleApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 
            var updateWholesaleReserveRequest = new UpdateWholesaleReserveRequest(); // UpdateWholesaleReserveRequest |  (optional) 

            try
            {
                // Reserve N units of an inventory item for wholesale: retail channels advertise the rest and come down when only the reserve is left. 0 clears it.
                GetWholesaleReserveResponse result = apiInstance.UpdateWholesaleReserve(inventoryItemId, updateWholesaleReserveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WholesaleApi.UpdateWholesaleReserve: " + e.Message );
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
 **inventoryItemId** | **string**|  | 
 **updateWholesaleReserveRequest** | **UpdateWholesaleReserveRequest**|  | [optional] 

### Return type

**GetWholesaleReserveResponse**

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

