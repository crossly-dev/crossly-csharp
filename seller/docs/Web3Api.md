# net.crossly.Api.Web3Api

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWeb3Alert**](Web3Api.md#createweb3alert) | **POST** /v1/web3/alerts | Set a price alert on a token, or on a whole collection without tokenId: you are notified when one is listed at or below &#x60;price&#x60; (the chain&#39;s native coin). Setting it again moves the price.
[**CreateWeb3Auction**](Web3Api.md#createweb3auction) | **POST** /v1/web3/auctions | Start an English auction on a token in your linked wallet: &#x60;reserve&#x60; is the opening bid in the chain&#39;s native coin, &#x60;hours&#x60; its length (1–720). Bids must rise 5%; a late bid extends the end by 10 minutes.
[**CreateWeb3AuctionCancel**](Web3Api.md#createweb3auctioncancel) | **POST** /v1/web3/auctions/{id}/cancel | Call off your auction while it has no bids.
[**CreateWeb3CreatorClaim**](Web3Api.md#createweb3creatorclaim) | **POST** /v1/web3/creator/claims | Claim an EVM collection as its creator: its owner() must be one of your verified wallets. Returns &#x60;{ chain, contract }&#x60;.
[**CreateWeb3Crosslist**](Web3Api.md#createweb3crosslist) | **POST** /v1/web3/crosslist | Submit signed Seaport listings for several marketplaces at once (crossly, opensea); results per marketplace.
[**CreateWeb3DropRemind**](Web3Api.md#createweb3dropremind) | **POST** /v1/web3/drops/{id}/remind | Turn the 15-minute reminder for a drop on, or off if it already is. Returns &#x60;{ remindMe }&#x60;.
[**CreateWeb3Favorite**](Web3Api.md#createweb3favorite) | **POST** /v1/web3/favorites | Favourite an NFT, or unfavourite it if it already is. Returns &#x60;{ favorited }&#x60;.
[**CreateWeb3Launch**](Web3Api.md#createweb3launch) | **POST** /v1/web3/launches | Draft a launchpad collection: name, symbol, supply, mint price (wei of the chain’s native currency), schedule, optional holder phase and royalty. Crossly takes 5% of each mint inside the contract.
[**CreateWeb3LaunchAirdrop**](Web3Api.md#createweb3launchairdrop) | **POST** /v1/web3/launches/{id}/airdrop | Plan an airdrop (one free NFT each, up to 500) to &#x60;addresses&#x60; and/or the holders of &#x60;holdersOf&#x60;. Returns the transactions for the owner wallet; no payment moves.
[**CreateWeb3LaunchArt**](Web3Api.md#createweb3launchart) | **POST** /v1/web3/launches/{id}/art | Append per-token art (image URL, name, traits), up to the supply, before the reveal. Returns &#x60;{ count }&#x60;.
[**CreateWeb3LaunchConfirmDeploy**](Web3Api.md#createweb3launchconfirmdeploy) | **POST** /v1/web3/launches/{id}/confirm-deploy | Confirm a sent deploy transaction: the contract must be the Crossly launch contract with this draft’s settings; it then goes live.
[**CreateWeb3LaunchFollowCreator**](Web3Api.md#createweb3launchfollowcreator) | **POST** /v1/web3/launches/{id}/follow-creator | Follow the creator of a launch: their launches are announced to you, and again when each opens. Returns &#x60;{ following }&#x60;.
[**CreateWeb3LaunchReveal**](Web3Api.md#createweb3launchreveal) | **POST** /v1/web3/launches/{id}/reveal | Reveal the art: one random offset maps every token to its asset for good. Returns &#x60;{ revealedAt }&#x60;.
[**CreateWeb3Order**](Web3Api.md#createweb3order) | **POST** /v1/web3/orders | Place a signed Seaport 1.6 order (listing, offer or collection offer) in the Crossly book.
[**CreateWeb3OrderCancel**](Web3Api.md#createweb3ordercancel) | **POST** /v1/web3/orders/{chain}/{hash}/cancel | Take one of your orders out of the Crossly book.
[**CreateWeb3OrderFulfillmentBatch**](Web3Api.md#createweb3orderfulfillmentbatch) | **POST** /v1/web3/orders/fulfillment-batch | Fulfilments for sweeping several listings in one Seaport transaction; unfillable ones are skipped with a reason.
[**CreateWeb3Phygital**](Web3Api.md#createweb3phygital) | **POST** /v1/web3/phygitals | Make an NFT you hold redeemable for one of your physical inventory items.
[**CreateWeb3PhygitalRedeem**](Web3Api.md#createweb3phygitalredeem) | **POST** /v1/web3/phygitals/{id}/redeem | Redeem a phygital you hold (checked on-chain) for its physical item, with a shipping address. Once per phygital.
[**CreateWeb3PhygitalRedemptionShip**](Web3Api.md#createweb3phygitalredemptionship) | **POST** /v1/web3/phygitals/redemptions/{id}/ship | Mark a redemption shipped with its carrier and tracking number; the redeemer is notified.
[**CreateWeb3RaribleDraft**](Web3Api.md#createweb3raribledraft) | **POST** /v1/web3/rarible/draft | Draft a Rarible V2 listing for an NFT in your linked wallet: the EIP-712 order to sign and whether Rarible&#39;s transfer proxy is approved.
[**CreateWeb3RaribleListing**](Web3Api.md#createweb3rariblelisting) | **POST** /v1/web3/rarible/listings | Submit a signed Rarible V2 listing: the signature is verified, then the order is posted to Rarible and recorded.
[**CreateWeb3SolanaListTx**](Web3Api.md#createweb3solanalisttx) | **POST** /v1/web3/solana/{marketplace}/list-tx | Build an unsigned listing transaction on the Crossly book, Tensor or Magic Eden for a Solana NFT in your linked wallet.
[**CreateWeb3SolanaListing**](Web3Api.md#createweb3solanalisting) | **POST** /v1/web3/solana/{marketplace}/listings | Record a Crossly-book, Tensor or Magic Eden listing your wallet sent (read back from the chain first).
[**CreateWeb3SolanaOffer**](Web3Api.md#createweb3solanaoffer) | **POST** /v1/web3/solana/offers | Record a sent bid; it is recorded only once its trade state exists on chain.
[**CreateWeb3SolanaOfferAcceptTx**](Web3Api.md#createweb3solanaofferaccepttx) | **POST** /v1/web3/solana/offers/{hash}/accept-tx | Build the sale into a bid from your linked wallet that holds the NFT (sell + execute_sale, one transaction).
[**CreateWeb3SolanaOfferCancelTx**](Web3Api.md#createweb3solanaoffercanceltx) | **POST** /v1/web3/solana/offers/{hash}/cancel-tx | Build the cancel of your bid: the SOL your other bids do not need comes back.
[**CreateWeb3SolanaOfferConfirm**](Web3Api.md#createweb3solanaofferconfirm) | **POST** /v1/web3/solana/offers/{hash}/confirm | Apply a sent accept or cancel once the chain shows the bid closed.
[**CreateWeb3SolanaOfferTx**](Web3Api.md#createweb3solanaoffertx) | **POST** /v1/web3/solana/offers/tx | Build a bid on a Solana NFT on Crossly&#39;s book for your linked wallet to sign; the SOL goes into your Auction House escrow.
[**CreateWeb3SolanaOrderBuyTx**](Web3Api.md#createweb3solanaorderbuytx) | **POST** /v1/web3/solana/orders/{hash}/buy-tx | Build the unsigned transaction that buys a Solana listing (price capped at the listed price).
[**CreateWeb3SolanaOrderConfirm**](Web3Api.md#createweb3solanaorderconfirm) | **POST** /v1/web3/solana/orders/{hash}/confirm | Apply a sent Solana buy or delist to the book (the transaction is read back from the chain).
[**CreateWeb3SolanaOrderDelistTx**](Web3Api.md#createweb3solanaorderdelisttx) | **POST** /v1/web3/solana/orders/{hash}/delist-tx | Build the unsigned transaction that takes your Solana listing down.
[**CreateWeb3SolanaTensorBidAcceptTx**](Web3Api.md#createweb3solanatensorbidaccepttx) | **POST** /v1/web3/solana/tensor-bids/accept-tx | Build the transaction that sells your NFT into a Tensor bid, never below &#x60;minLamports&#x60;.
[**CreateWeb3SolanaTensorBidCancelTx**](Web3Api.md#createweb3solanatensorbidcanceltx) | **POST** /v1/web3/solana/tensor-bids/cancel-tx | Build the transaction that cancels your Tensor bid.
[**CreateWeb3SolanaTensorBidPlaceTx**](Web3Api.md#createweb3solanatensorbidplacetx) | **POST** /v1/web3/solana/tensor-bids/place-tx | Build a Tensor collection bid (or trait bid with &#x60;trait&#x60;) for your Solana wallet to sign. Price in lamports.
[**CreateWeb3TokenRefresh**](Web3Api.md#createweb3tokenrefresh) | **POST** /v1/web3/tokens/{chain}/{contract}/{tokenId}/refresh | Re-read a token&#39;s metadata from the chain&#39;s provider (name, traits, image — a new image is copied to Crossly&#39;s CDN). Once per token per 10 minutes.
[**CreateWeb3Transaction**](Web3Api.md#createweb3transaction) | **POST** /v1/web3/transactions | Apply a Seaport transaction&#39;s fills and cancels to the Crossly book (read from the receipt).
[**CreateWeb3WalletChallenge**](Web3Api.md#createweb3walletchallenge) | **POST** /v1/web3/wallets/challenge | Start linking a wallet: returns the message the wallet must sign.
[**CreateWeb3WalletSync**](Web3Api.md#createweb3walletsync) | **POST** /v1/web3/wallets/{id}/sync | Import a linked wallet&#39;s NFTs into inventory; archives ones that have left the wallet.
[**CreateWeb3WalletVerify**](Web3Api.md#createweb3walletverify) | **POST** /v1/web3/wallets/verify | Finish linking a wallet with its signature over the challenge message.
[**DeleteWeb3Alert**](Web3Api.md#deleteweb3alert) | **DELETE** /v1/web3/alerts/{id} | Delete a price alert.
[**DeleteWeb3HolderPerk**](Web3Api.md#deleteweb3holderperk) | **DELETE** /v1/web3/holder-perks/{id} | Remove a holder perk. Returns &#x60;{ ok }&#x60;.
[**DeleteWeb3Launch**](Web3Api.md#deleteweb3launch) | **DELETE** /v1/web3/launches/{id} | Delete a launch draft that never went live. Returns &#x60;{ ok }&#x60;.
[**DeleteWeb3LaunchFollowCreator**](Web3Api.md#deleteweb3launchfollowcreator) | **DELETE** /v1/web3/launches/{id}/follow-creator | Stop following the creator of a launch. Returns &#x60;{ following }&#x60;.
[**DeleteWeb3MarketplaceKey**](Web3Api.md#deleteweb3marketplacekey) | **DELETE** /v1/web3/marketplace-keys/{marketplace} | Remove your own key for a marketplace; Crossly&#39;s key is used again.
[**DeleteWeb3Wallet**](Web3Api.md#deleteweb3wallet) | **DELETE** /v1/web3/wallets/{id} | Unlink a wallet. Its NFTs stay in inventory but stop syncing.
[**GetWeb3Auction**](Web3Api.md#getweb3auction) | **GET** /v1/web3/auctions/{chain}/{contract}/{tokenId} | A token&#39;s live (or latest) auction: reserve, end, top bid, bid count and the minimum next bid.
[**GetWeb3Browse**](Web3Api.md#getweb3browse) | **GET** /v1/web3/browse | The Web3 directory&#39;s categories and chains, with how many collections each holds.
[**GetWeb3Collection**](Web3Api.md#getweb3collection) | **GET** /v1/web3/collections/{chain}/{contract} | A collection: metadata and Crossly stats (floor, listed, volume, best collection offer).
[**GetWeb3CollectionDepth**](Web3Api.md#getweb3collectiondepth) | **GET** /v1/web3/collections/{chain}/{contract}/depth | A collection&#39;s Crossly order book by price level — asks cheapest first, bids dearest first, with running totals — and the floor of every trait value.
[**GetWeb3CollectionInsight**](Web3Api.md#getweb3collectioninsight) | **GET** /v1/web3/collections/{chain}/{contract}/insights | On-chain insights for a collection: holders, trait counts across the whole collection, recent transfers and a 30-day activity series.
[**GetWeb3CollectionItem**](Web3Api.md#getweb3collectionitem) | **GET** /v1/web3/collections/{chain}/{contract}/items | A collection&#39;s NFTs: filter by traits (repeat trait&#x3D;Type:Value; OR within a type, AND across), search by name or token id, sort by id, rarity or Crossly price. Whole-collection once indexed.
[**GetWeb3CollectionTrait**](Web3Api.md#getweb3collectiontrait) | **GET** /v1/web3/collections/{chain}/{contract}/traits | Every trait type and value in a collection, with how many tokens have each.
[**GetWeb3CollectionTraitToken**](Web3Api.md#getweb3collectiontraittoken) | **GET** /v1/web3/collections/{chain}/{contract}/trait-tokens | Token ids in a collection with one trait — what a trait offer commits to.
[**GetWeb3Collector**](Web3Api.md#getweb3collector) | **GET** /v1/web3/collector | Your collector perks: how many different NFTs you bought through Crossly, your Collector pin tier, relist rewards paid, and each NFT you still hold with the Bought on Crossly mark.
[**GetWeb3Creator**](Web3Api.md#getweb3creator) | **GET** /v1/web3/creator/{chain}/{contract} | A collection’s creator dashboard: sales by marketplace and day, estimated royalties, holders, and for a launch the mint revenue and what is waiting to be withdrawn (wei of the chain’s native currency).
[**GetWeb3CrosslistQuote**](Web3Api.md#getweb3crosslistquote) | **GET** /v1/web3/crosslist/quote | Each marketplace&#39;s terms for listing a token: Crossly fee, OpenSea required fees and zone, Tensor availability.
[**GetWeb3Featured**](Web3Api.md#getweb3featured) | **GET** /v1/web3/featured | The NFT home&#39;s featured collections: chosen by Crossly, else the hottest.
[**GetWeb3Inventory**](Web3Api.md#getweb3inventory) | **GET** /v1/web3/inventory/{itemId} | The NFT behind an inventory item: its token, wallet, and open listings on every marketplace (null if it is not an NFT).
[**GetWeb3LaunchAllowlistRootTx**](Web3Api.md#getweb3launchallowlistroottx) | **GET** /v1/web3/launches/{id}/allowlist/root-tx | The setAllowlistRoot transaction for the allowlist Crossly holds (EVM, live): &#x60;{ chain, from, to, data }&#x60;.
[**GetWeb3LaunchDeployTx**](Web3Api.md#getweb3launchdeploytx) | **GET** /v1/web3/launches/{id}/deploy-tx | The contract-creation transaction for the draft: send it from the owner wallet, then confirm it. Returns &#x60;{ chain, from, data }&#x60;.
[**GetWeb3LaunchTool**](Web3Api.md#getweb3launchtool) | **GET** /v1/web3/launches/{id}/tools | A launch’s creator tools: allowlist size and root (and whether the contract has it yet), uploaded art and reveal, supply minted.
[**GetWeb3OrderFulfillment**](Web3Api.md#getweb3orderfulfillment) | **GET** /v1/web3/orders/{chain}/{hash}/fulfillment | The signed order a taker passes to Seaport, after re-checking it can still fill.
[**GetWeb3Phygital**](Web3Api.md#getweb3phygital) | **GET** /v1/web3/phygitals/{chain}/{contract}/{tokenId} | A token&#39;s phygital: the physical item it can be redeemed for, and whether it has been.
[**GetWeb3Phygital2**](Web3Api.md#getweb3phygital2) | **GET** /v1/web3/phygitals | Phygitals you linked (with each redemption and its shipping address) and ones you redeemed.
[**GetWeb3Portfolio**](Web3Api.md#getweb3portfolio) | **GET** /v1/web3/portfolio | Your NFTs with value (Crossly floor, else recent sales) and cost (what a linked wallet paid), realised sales, and USD totals at each day’s coin price.
[**GetWeb3PortfolioTax**](Web3Api.md#getweb3portfoliotax) | **GET** /v1/web3/portfolio/tax | One calendar year of NFT disposals from your linked wallets as CSV text: acquired, sold, proceeds, cost basis, gain (coin and USD).
[**GetWeb3Profile**](Web3Api.md#getweb3profile) | **GET** /v1/web3/profiles/{address} | A wallet&#39;s public profile: NFTs held, open Crossly listings, and activity.
[**GetWeb3Resolve**](Web3Api.md#getweb3resolve) | **GET** /v1/web3/resolve/{chain}/{slug} | A collection&#39;s chain and contract from its readable URL slug (e.g. eth / boredapeyachtclub).
[**GetWeb3SolanaCollectionTensorBid**](Web3Api.md#getweb3solanacollectiontensorbid) | **GET** /v1/web3/solana/collections/{collection}/tensor-bids | A Solana collection’s Tensor bids (collection-wide and by trait), best first; price in lamports. Needs your Tensor key.
[**GetWeb3Token**](Web3Api.md#getweb3token) | **GET** /v1/web3/tokens/{chain}/{contract}/{tokenId} | One NFT: metadata, traits, owner, open listings and offers, activity.
[**ListWeb3Activity**](Web3Api.md#listweb3activity) | **GET** /v1/web3/activity | Listings, offers, sales and cancels in the Crossly book, newest first.
[**ListWeb3Alerts**](Web3Api.md#listweb3alerts) | **GET** /v1/web3/alerts | Your NFT price alerts, with the cheapest open Crossly listing each one covers now.
[**ListWeb3Approvals**](Web3Api.md#listweb3approvals) | **GET** /v1/web3/approvals | Your collections the OpenSea conduit is approved to move, per linked wallet.
[**ListWeb3Auctions**](Web3Api.md#listweb3auctions) | **GET** /v1/web3/auctions | Live English auctions on the Crossly book, ending soonest first, each with its top bid and the least the next bid can be.
[**ListWeb3BrowseCollections**](Web3Api.md#listweb3browsecollections) | **GET** /v1/web3/browse/collections | Browse NFT collections by chain, category and name; sort hot (Crossly sales, listings, favourites), new, volume, floor or name.
[**ListWeb3BrowseTokens**](Web3Api.md#listweb3browsetokens) | **GET** /v1/web3/browse/tokens | Hot NFTs: what is for sale on Crossly first, then tokens from the hottest collections.
[**ListWeb3Bundles**](Web3Api.md#listweb3bundles) | **GET** /v1/web3/bundles | Open bundle listings (2–30 NFTs for one price), newest first, by chain or by a contract any item is from.
[**ListWeb3CollectionHistory**](Web3Api.md#listweb3collectionhistory) | **GET** /v1/web3/collections/{chain}/{contract}/history | Daily floor, sales, volume, holders and listed count for a collection, oldest first (up to 365 days).
[**ListWeb3Collections**](Web3Api.md#listweb3collections) | **GET** /v1/web3/collections | Collections ranked by 30-day Crossly volume, with floor and listed count.
[**ListWeb3CreatorCollections**](Web3Api.md#listweb3creatorcollections) | **GET** /v1/web3/creator/collections | Collections you are the creator of: your launches, and contracts you claimed by owning them.
[**ListWeb3Drops**](Web3Api.md#listweb3drops) | **GET** /v1/web3/drops | Upcoming and live NFT drops (curated mints on the creator&#39;s own page), soonest first, with whether you asked to be reminded.
[**ListWeb3HolderPerks**](Web3Api.md#listweb3holderperks) | **GET** /v1/web3/holder-perks | Your holder perks: percent off your Crossly shop for holders of an NFT collection, best first.
[**ListWeb3Launches**](Web3Api.md#listweb3launches) | **GET** /v1/web3/launches | Your launchpad collections (drafts and live), newest first, with minted count and phase.
[**ListWeb3Listings**](Web3Api.md#listweb3listings) | **GET** /v1/web3/listings | Open NFT listings in the Crossly book — the cheapest per token.
[**ListWeb3MarketplaceKeys**](Web3Api.md#listweb3marketplacekeys) | **GET** /v1/web3/marketplace-keys | Your own marketplace API keys (last four characters only) and whether Crossly&#39;s key covers each marketplace.
[**ListWeb3Nfts**](Web3Api.md#listweb3nfts) | **GET** /v1/web3/nfts | List the NFTs in your inventory, imported from your linked wallets.
[**ListWeb3Orders**](Web3Api.md#listweb3orders) | **GET** /v1/web3/orders | Your orders in the Crossly book (listings and offers), any status.
[**ListWeb3Purchases**](Web3Api.md#listweb3purchases) | **GET** /v1/web3/purchases | NFTs your linked wallets bought — on Crossly or any marketplace the chain feed saw — newest first, with price and whether you still hold each.
[**ListWeb3Rankings**](Web3Api.md#listweb3rankings) | **GET** /v1/web3/rankings | Collections by sales volume over 24h, 7d or 30d, in one coin: the ETH chains together, or Polygon / Solana on their own.
[**ListWeb3Reserved**](Web3Api.md#listweb3reserved) | **GET** /v1/web3/reserved | Private listings reserved for one of your linked wallets — only you can see or buy them.
[**ListWeb3Sales**](Web3Api.md#listweb3sales) | **GET** /v1/web3/sales | The latest NFT sales across the directory, from the chain (Seaport and Blur) and the Crossly book, newest first; page with &#x60;before&#x60;.
[**ListWeb3Search**](Web3Api.md#listweb3search) | **GET** /v1/web3/search | Find collections by contract address (every chain) or by name.
[**ListWeb3SearchTokens**](Web3Api.md#listweb3searchtokens) | **GET** /v1/web3/search/tokens | Find tokens by collection name and number: &#39;pudgy 42&#39;, &#39;Bored Ape #1234&#39;.
[**ListWeb3Wallets**](Web3Api.md#listweb3wallets) | **GET** /v1/web3/wallets | List your verified, linked wallets (EVM and Solana).
[**ListWeb3Watchlist**](Web3Api.md#listweb3watchlist) | **GET** /v1/web3/watchlist | Your favourited NFTs, with the cheapest open Crossly listing and the last sale of each.
[**UpdateWeb3HolderPerk**](Web3Api.md#updateweb3holderperk) | **PUT** /v1/web3/holder-perks | Set the percent off (100–5000 bps) holders of a collection get across your Crossly shop; one perk per collection.
[**UpdateWeb3LaunchAllowlist**](Web3Api.md#updateweb3launchallowlist) | **PUT** /v1/web3/launches/{id}/allowlist | Replace the early-phase allowlist (up to 10,000 wallets). EVM live launches get back &#x60;rootTx&#x60;, the setAllowlistRoot transaction for the owner wallet.
[**UpdateWeb3MarketplaceKey**](Web3Api.md#updateweb3marketplacekey) | **PUT** /v1/web3/marketplace-keys/{marketplace} | Save your own API key for a marketplace (checked against the marketplace first where it can be); stored encrypted.


<a name="createweb3alert"></a>
# **CreateWeb3Alert**
> IdResponse CreateWeb3Alert ()

Set a price alert on a token, or on a whole collection without tokenId: you are notified when one is listed at or below `price` (the chain's native coin). Setting it again moves the price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3AlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Set a price alert on a token, or on a whole collection without tokenId: you are notified when one is listed at or below `price` (the chain's native coin). Setting it again moves the price.
                IdResponse result = apiInstance.CreateWeb3Alert();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Alert: " + e.Message );
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

**IdResponse**

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

<a name="createweb3auction"></a>
# **CreateWeb3Auction**
> CreateWeb3AuctionResponse CreateWeb3Auction ()

Start an English auction on a token in your linked wallet: `reserve` is the opening bid in the chain's native coin, `hours` its length (1–720). Bids must rise 5%; a late bid extends the end by 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3AuctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Start an English auction on a token in your linked wallet: `reserve` is the opening bid in the chain's native coin, `hours` its length (1–720). Bids must rise 5%; a late bid extends the end by 10 minutes.
                CreateWeb3AuctionResponse result = apiInstance.CreateWeb3Auction();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Auction: " + e.Message );
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

**CreateWeb3AuctionResponse**

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

<a name="createweb3auctioncancel"></a>
# **CreateWeb3AuctionCancel**
> OkResponse CreateWeb3AuctionCancel (string id)

Call off your auction while it has no bids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3AuctionCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Call off your auction while it has no bids.
                OkResponse result = apiInstance.CreateWeb3AuctionCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3AuctionCancel: " + e.Message );
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

**OkResponse**

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

<a name="createweb3creatorclaim"></a>
# **CreateWeb3CreatorClaim**
> CreateWeb3CreatorClaimResponse CreateWeb3CreatorClaim ()

Claim an EVM collection as its creator: its owner() must be one of your verified wallets. Returns `{ chain, contract }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3CreatorClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Claim an EVM collection as its creator: its owner() must be one of your verified wallets. Returns `{ chain, contract }`.
                CreateWeb3CreatorClaimResponse result = apiInstance.CreateWeb3CreatorClaim();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3CreatorClaim: " + e.Message );
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

**CreateWeb3CreatorClaimResponse**

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

<a name="createweb3crosslist"></a>
# **CreateWeb3Crosslist**
> CreateWeb3CrosslistResponse CreateWeb3Crosslist ()

Submit signed Seaport listings for several marketplaces at once (crossly, opensea); results per marketplace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3CrosslistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Submit signed Seaport listings for several marketplaces at once (crossly, opensea); results per marketplace.
                CreateWeb3CrosslistResponse result = apiInstance.CreateWeb3Crosslist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Crosslist: " + e.Message );
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

**CreateWeb3CrosslistResponse**

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

<a name="createweb3dropremind"></a>
# **CreateWeb3DropRemind**
> CreateWeb3DropRemindResponse CreateWeb3DropRemind (string id)

Turn the 15-minute reminder for a drop on, or off if it already is. Returns `{ remindMe }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3DropRemindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Turn the 15-minute reminder for a drop on, or off if it already is. Returns `{ remindMe }`.
                CreateWeb3DropRemindResponse result = apiInstance.CreateWeb3DropRemind(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3DropRemind: " + e.Message );
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

**CreateWeb3DropRemindResponse**

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

<a name="createweb3favorite"></a>
# **CreateWeb3Favorite**
> CreateWeb3FavoriteResponse CreateWeb3Favorite ()

Favourite an NFT, or unfavourite it if it already is. Returns `{ favorited }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3FavoriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Favourite an NFT, or unfavourite it if it already is. Returns `{ favorited }`.
                CreateWeb3FavoriteResponse result = apiInstance.CreateWeb3Favorite();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Favorite: " + e.Message );
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

**CreateWeb3FavoriteResponse**

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

<a name="createweb3launch"></a>
# **CreateWeb3Launch**
> ListWeb3LaunchesItem CreateWeb3Launch ()

Draft a launchpad collection: name, symbol, supply, mint price (wei of the chain’s native currency), schedule, optional holder phase and royalty. Crossly takes 5% of each mint inside the contract.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Draft a launchpad collection: name, symbol, supply, mint price (wei of the chain’s native currency), schedule, optional holder phase and royalty. Crossly takes 5% of each mint inside the contract.
                ListWeb3LaunchesItem result = apiInstance.CreateWeb3Launch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Launch: " + e.Message );
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

**ListWeb3LaunchesItem**

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

<a name="createweb3launchairdrop"></a>
# **CreateWeb3LaunchAirdrop**
> CreateWeb3LaunchAirdropResponse CreateWeb3LaunchAirdrop (string id)

Plan an airdrop (one free NFT each, up to 500) to `addresses` and/or the holders of `holdersOf`. Returns the transactions for the owner wallet; no payment moves.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchAirdropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Plan an airdrop (one free NFT each, up to 500) to `addresses` and/or the holders of `holdersOf`. Returns the transactions for the owner wallet; no payment moves.
                CreateWeb3LaunchAirdropResponse result = apiInstance.CreateWeb3LaunchAirdrop(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3LaunchAirdrop: " + e.Message );
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

**CreateWeb3LaunchAirdropResponse**

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

<a name="createweb3launchart"></a>
# **CreateWeb3LaunchArt**
> CreateWeb3LaunchArtResponse CreateWeb3LaunchArt (string id)

Append per-token art (image URL, name, traits), up to the supply, before the reveal. Returns `{ count }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchArtExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Append per-token art (image URL, name, traits), up to the supply, before the reveal. Returns `{ count }`.
                CreateWeb3LaunchArtResponse result = apiInstance.CreateWeb3LaunchArt(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3LaunchArt: " + e.Message );
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

**CreateWeb3LaunchArtResponse**

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

<a name="createweb3launchconfirmdeploy"></a>
# **CreateWeb3LaunchConfirmDeploy**
> ListWeb3LaunchesItem CreateWeb3LaunchConfirmDeploy (string id)

Confirm a sent deploy transaction: the contract must be the Crossly launch contract with this draft’s settings; it then goes live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchConfirmDeployExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Confirm a sent deploy transaction: the contract must be the Crossly launch contract with this draft’s settings; it then goes live.
                ListWeb3LaunchesItem result = apiInstance.CreateWeb3LaunchConfirmDeploy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3LaunchConfirmDeploy: " + e.Message );
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

**ListWeb3LaunchesItem**

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

<a name="createweb3launchfollowcreator"></a>
# **CreateWeb3LaunchFollowCreator**
> CreateWeb3LaunchFollowCreatorResponse CreateWeb3LaunchFollowCreator (string id)

Follow the creator of a launch: their launches are announced to you, and again when each opens. Returns `{ following }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchFollowCreatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Follow the creator of a launch: their launches are announced to you, and again when each opens. Returns `{ following }`.
                CreateWeb3LaunchFollowCreatorResponse result = apiInstance.CreateWeb3LaunchFollowCreator(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3LaunchFollowCreator: " + e.Message );
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

**CreateWeb3LaunchFollowCreatorResponse**

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

<a name="createweb3launchreveal"></a>
# **CreateWeb3LaunchReveal**
> CreateWeb3LaunchRevealResponse CreateWeb3LaunchReveal (string id)

Reveal the art: one random offset maps every token to its asset for good. Returns `{ revealedAt }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3LaunchRevealExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Reveal the art: one random offset maps every token to its asset for good. Returns `{ revealedAt }`.
                CreateWeb3LaunchRevealResponse result = apiInstance.CreateWeb3LaunchReveal(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3LaunchReveal: " + e.Message );
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

**CreateWeb3LaunchRevealResponse**

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

<a name="createweb3order"></a>
# **CreateWeb3Order**
> CreateWeb3OrderResponse CreateWeb3Order ()

Place a signed Seaport 1.6 order (listing, offer or collection offer) in the Crossly book.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3OrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Place a signed Seaport 1.6 order (listing, offer or collection offer) in the Crossly book.
                CreateWeb3OrderResponse result = apiInstance.CreateWeb3Order();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Order: " + e.Message );
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

**CreateWeb3OrderResponse**

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

<a name="createweb3ordercancel"></a>
# **CreateWeb3OrderCancel**
> OkResponse CreateWeb3OrderCancel (string chain, string hash)

Take one of your orders out of the Crossly book.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3OrderCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var hash = "hash_example";  // string | 

            try
            {
                // Take one of your orders out of the Crossly book.
                OkResponse result = apiInstance.CreateWeb3OrderCancel(chain, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3OrderCancel: " + e.Message );
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
 **chain** | **string**|  | 
 **hash** | **string**|  | 

### Return type

**OkResponse**

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

<a name="createweb3orderfulfillmentbatch"></a>
# **CreateWeb3OrderFulfillmentBatch**
> CreateWeb3OrderFulfillmentBatchResponse CreateWeb3OrderFulfillmentBatch ()

Fulfilments for sweeping several listings in one Seaport transaction; unfillable ones are skipped with a reason.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3OrderFulfillmentBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Fulfilments for sweeping several listings in one Seaport transaction; unfillable ones are skipped with a reason.
                CreateWeb3OrderFulfillmentBatchResponse result = apiInstance.CreateWeb3OrderFulfillmentBatch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3OrderFulfillmentBatch: " + e.Message );
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

**CreateWeb3OrderFulfillmentBatchResponse**

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

<a name="createweb3phygital"></a>
# **CreateWeb3Phygital**
> CreateWeb3PhygitalResponse CreateWeb3Phygital ()

Make an NFT you hold redeemable for one of your physical inventory items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3PhygitalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Make an NFT you hold redeemable for one of your physical inventory items.
                CreateWeb3PhygitalResponse result = apiInstance.CreateWeb3Phygital();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Phygital: " + e.Message );
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

**CreateWeb3PhygitalResponse**

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

<a name="createweb3phygitalredeem"></a>
# **CreateWeb3PhygitalRedeem**
> CreateWeb3PhygitalRedeemResponse CreateWeb3PhygitalRedeem (string id)

Redeem a phygital you hold (checked on-chain) for its physical item, with a shipping address. Once per phygital.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3PhygitalRedeemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Redeem a phygital you hold (checked on-chain) for its physical item, with a shipping address. Once per phygital.
                CreateWeb3PhygitalRedeemResponse result = apiInstance.CreateWeb3PhygitalRedeem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3PhygitalRedeem: " + e.Message );
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

**CreateWeb3PhygitalRedeemResponse**

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

<a name="createweb3phygitalredemptionship"></a>
# **CreateWeb3PhygitalRedemptionShip**
> OkResponse CreateWeb3PhygitalRedemptionShip (string id)

Mark a redemption shipped with its carrier and tracking number; the redeemer is notified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3PhygitalRedemptionShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Mark a redemption shipped with its carrier and tracking number; the redeemer is notified.
                OkResponse result = apiInstance.CreateWeb3PhygitalRedemptionShip(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3PhygitalRedemptionShip: " + e.Message );
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

**OkResponse**

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

<a name="createweb3raribledraft"></a>
# **CreateWeb3RaribleDraft**
> CreateWeb3RaribleDraftResponse CreateWeb3RaribleDraft ()

Draft a Rarible V2 listing for an NFT in your linked wallet: the EIP-712 order to sign and whether Rarible's transfer proxy is approved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3RaribleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Draft a Rarible V2 listing for an NFT in your linked wallet: the EIP-712 order to sign and whether Rarible's transfer proxy is approved.
                CreateWeb3RaribleDraftResponse result = apiInstance.CreateWeb3RaribleDraft();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3RaribleDraft: " + e.Message );
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

**CreateWeb3RaribleDraftResponse**

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

<a name="createweb3rariblelisting"></a>
# **CreateWeb3RaribleListing**
> OrderHashResponse CreateWeb3RaribleListing ()

Submit a signed Rarible V2 listing: the signature is verified, then the order is posted to Rarible and recorded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3RaribleListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Submit a signed Rarible V2 listing: the signature is verified, then the order is posted to Rarible and recorded.
                OrderHashResponse result = apiInstance.CreateWeb3RaribleListing();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3RaribleListing: " + e.Message );
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

**OrderHashResponse**

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

<a name="createweb3solanalisttx"></a>
# **CreateWeb3SolanaListTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaListTx (string marketplace)

Build an unsigned listing transaction on the Crossly book, Tensor or Magic Eden for a Solana NFT in your linked wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaListTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var marketplace = "crossly";  // string | 

            try
            {
                // Build an unsigned listing transaction on the Crossly book, Tensor or Magic Eden for a Solana NFT in your linked wallet.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaListTx(marketplace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaListTx: " + e.Message );
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
 **marketplace** | **string**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanalisting"></a>
# **CreateWeb3SolanaListing**
> OrderHashResponse CreateWeb3SolanaListing (string marketplace)

Record a Crossly-book, Tensor or Magic Eden listing your wallet sent (read back from the chain first).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaListingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var marketplace = "crossly";  // string | 

            try
            {
                // Record a Crossly-book, Tensor or Magic Eden listing your wallet sent (read back from the chain first).
                OrderHashResponse result = apiInstance.CreateWeb3SolanaListing(marketplace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaListing: " + e.Message );
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
 **marketplace** | **string**|  | 

### Return type

**OrderHashResponse**

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

<a name="createweb3solanaoffer"></a>
# **CreateWeb3SolanaOffer**
> OrderHashResponse CreateWeb3SolanaOffer ()

Record a sent bid; it is recorded only once its trade state exists on chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Record a sent bid; it is recorded only once its trade state exists on chain.
                OrderHashResponse result = apiInstance.CreateWeb3SolanaOffer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOffer: " + e.Message );
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

**OrderHashResponse**

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

<a name="createweb3solanaofferaccepttx"></a>
# **CreateWeb3SolanaOfferAcceptTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOfferAcceptTx (string hash)

Build the sale into a bid from your linked wallet that holds the NFT (sell + execute_sale, one transaction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOfferAcceptTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Build the sale into a bid from your linked wallet that holds the NFT (sell + execute_sale, one transaction).
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOfferAcceptTx(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOfferAcceptTx: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanaoffercanceltx"></a>
# **CreateWeb3SolanaOfferCancelTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOfferCancelTx (string hash)

Build the cancel of your bid: the SOL your other bids do not need comes back.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOfferCancelTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Build the cancel of your bid: the SOL your other bids do not need comes back.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOfferCancelTx(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOfferCancelTx: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanaofferconfirm"></a>
# **CreateWeb3SolanaOfferConfirm**
> CreateWeb3SolanaOfferConfirmResponse CreateWeb3SolanaOfferConfirm (string hash)

Apply a sent accept or cancel once the chain shows the bid closed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOfferConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Apply a sent accept or cancel once the chain shows the bid closed.
                CreateWeb3SolanaOfferConfirmResponse result = apiInstance.CreateWeb3SolanaOfferConfirm(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOfferConfirm: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaOfferConfirmResponse**

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

<a name="createweb3solanaoffertx"></a>
# **CreateWeb3SolanaOfferTx**
> CreateWeb3SolanaOfferTxResponse CreateWeb3SolanaOfferTx ()

Build a bid on a Solana NFT on Crossly's book for your linked wallet to sign; the SOL goes into your Auction House escrow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOfferTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Build a bid on a Solana NFT on Crossly's book for your linked wallet to sign; the SOL goes into your Auction House escrow.
                CreateWeb3SolanaOfferTxResponse result = apiInstance.CreateWeb3SolanaOfferTx();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOfferTx: " + e.Message );
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

**CreateWeb3SolanaOfferTxResponse**

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

<a name="createweb3solanaorderbuytx"></a>
# **CreateWeb3SolanaOrderBuyTx**
> CreateWeb3SolanaOrderBuyTxResponse CreateWeb3SolanaOrderBuyTx (string hash)

Build the unsigned transaction that buys a Solana listing (price capped at the listed price).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOrderBuyTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Build the unsigned transaction that buys a Solana listing (price capped at the listed price).
                CreateWeb3SolanaOrderBuyTxResponse result = apiInstance.CreateWeb3SolanaOrderBuyTx(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOrderBuyTx: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaOrderBuyTxResponse**

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

<a name="createweb3solanaorderconfirm"></a>
# **CreateWeb3SolanaOrderConfirm**
> CreateWeb3SolanaOfferConfirmResponse CreateWeb3SolanaOrderConfirm (string hash)

Apply a sent Solana buy or delist to the book (the transaction is read back from the chain).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOrderConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Apply a sent Solana buy or delist to the book (the transaction is read back from the chain).
                CreateWeb3SolanaOfferConfirmResponse result = apiInstance.CreateWeb3SolanaOrderConfirm(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOrderConfirm: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaOfferConfirmResponse**

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

<a name="createweb3solanaorderdelisttx"></a>
# **CreateWeb3SolanaOrderDelistTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOrderDelistTx (string hash)

Build the unsigned transaction that takes your Solana listing down.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaOrderDelistTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var hash = "hash_example";  // string | 

            try
            {
                // Build the unsigned transaction that takes your Solana listing down.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOrderDelistTx(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaOrderDelistTx: " + e.Message );
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
 **hash** | **string**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanatensorbidaccepttx"></a>
# **CreateWeb3SolanaTensorBidAcceptTx**
> CreateWeb3SolanaTensorBidPlaceTxResponse CreateWeb3SolanaTensorBidAcceptTx ()

Build the transaction that sells your NFT into a Tensor bid, never below `minLamports`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaTensorBidAcceptTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Build the transaction that sells your NFT into a Tensor bid, never below `minLamports`.
                CreateWeb3SolanaTensorBidPlaceTxResponse result = apiInstance.CreateWeb3SolanaTensorBidAcceptTx();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaTensorBidAcceptTx: " + e.Message );
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

**CreateWeb3SolanaTensorBidPlaceTxResponse**

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

<a name="createweb3solanatensorbidcanceltx"></a>
# **CreateWeb3SolanaTensorBidCancelTx**
> CreateWeb3SolanaTensorBidPlaceTxResponse CreateWeb3SolanaTensorBidCancelTx ()

Build the transaction that cancels your Tensor bid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaTensorBidCancelTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Build the transaction that cancels your Tensor bid.
                CreateWeb3SolanaTensorBidPlaceTxResponse result = apiInstance.CreateWeb3SolanaTensorBidCancelTx();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaTensorBidCancelTx: " + e.Message );
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

**CreateWeb3SolanaTensorBidPlaceTxResponse**

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

<a name="createweb3solanatensorbidplacetx"></a>
# **CreateWeb3SolanaTensorBidPlaceTx**
> CreateWeb3SolanaTensorBidPlaceTxResponse CreateWeb3SolanaTensorBidPlaceTx ()

Build a Tensor collection bid (or trait bid with `trait`) for your Solana wallet to sign. Price in lamports.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaTensorBidPlaceTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Build a Tensor collection bid (or trait bid with `trait`) for your Solana wallet to sign. Price in lamports.
                CreateWeb3SolanaTensorBidPlaceTxResponse result = apiInstance.CreateWeb3SolanaTensorBidPlaceTx();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaTensorBidPlaceTx: " + e.Message );
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

**CreateWeb3SolanaTensorBidPlaceTxResponse**

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

<a name="createweb3tokenrefresh"></a>
# **CreateWeb3TokenRefresh**
> CreateWeb3TokenRefreshResponse CreateWeb3TokenRefresh (string chain, string contract, string tokenId)

Re-read a token's metadata from the chain's provider (name, traits, image — a new image is copied to Crossly's CDN). Once per token per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3TokenRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 
            var tokenId = "tokenId_example";  // string | 

            try
            {
                // Re-read a token's metadata from the chain's provider (name, traits, image — a new image is copied to Crossly's CDN). Once per token per 10 minutes.
                CreateWeb3TokenRefreshResponse result = apiInstance.CreateWeb3TokenRefresh(chain, contract, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3TokenRefresh: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

**CreateWeb3TokenRefreshResponse**

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

<a name="createweb3transaction"></a>
# **CreateWeb3Transaction**
> CreateWeb3TransactionResponse CreateWeb3Transaction ()

Apply a Seaport transaction's fills and cancels to the Crossly book (read from the receipt).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3TransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Apply a Seaport transaction's fills and cancels to the Crossly book (read from the receipt).
                CreateWeb3TransactionResponse result = apiInstance.CreateWeb3Transaction();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3Transaction: " + e.Message );
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

**CreateWeb3TransactionResponse**

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

<a name="createweb3walletchallenge"></a>
# **CreateWeb3WalletChallenge**
> CreateWeb3WalletChallengeResponse CreateWeb3WalletChallenge ()

Start linking a wallet: returns the message the wallet must sign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3WalletChallengeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Start linking a wallet: returns the message the wallet must sign.
                CreateWeb3WalletChallengeResponse result = apiInstance.CreateWeb3WalletChallenge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3WalletChallenge: " + e.Message );
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

**CreateWeb3WalletChallengeResponse**

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

<a name="createweb3walletsync"></a>
# **CreateWeb3WalletSync**
> CreateWeb3WalletSyncResponse CreateWeb3WalletSync (string id)

Import a linked wallet's NFTs into inventory; archives ones that have left the wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3WalletSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Import a linked wallet's NFTs into inventory; archives ones that have left the wallet.
                CreateWeb3WalletSyncResponse result = apiInstance.CreateWeb3WalletSync(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3WalletSync: " + e.Message );
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

**CreateWeb3WalletSyncResponse**

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

<a name="createweb3walletverify"></a>
# **CreateWeb3WalletVerify**
> CreateWeb3WalletVerifyResponse CreateWeb3WalletVerify ()

Finish linking a wallet with its signature over the challenge message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3WalletVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Finish linking a wallet with its signature over the challenge message.
                CreateWeb3WalletVerifyResponse result = apiInstance.CreateWeb3WalletVerify();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3WalletVerify: " + e.Message );
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

**CreateWeb3WalletVerifyResponse**

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

<a name="deleteweb3alert"></a>
# **DeleteWeb3Alert**
> OkResponse DeleteWeb3Alert (string id)

Delete a price alert.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3AlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a price alert.
                OkResponse result = apiInstance.DeleteWeb3Alert(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3Alert: " + e.Message );
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

**OkResponse**

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

<a name="deleteweb3holderperk"></a>
# **DeleteWeb3HolderPerk**
> OkResponse DeleteWeb3HolderPerk (string id)

Remove a holder perk. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3HolderPerkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Remove a holder perk. Returns `{ ok }`.
                OkResponse result = apiInstance.DeleteWeb3HolderPerk(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3HolderPerk: " + e.Message );
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

**OkResponse**

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

<a name="deleteweb3launch"></a>
# **DeleteWeb3Launch**
> OkResponse DeleteWeb3Launch (string id)

Delete a launch draft that never went live. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3LaunchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a launch draft that never went live. Returns `{ ok }`.
                OkResponse result = apiInstance.DeleteWeb3Launch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3Launch: " + e.Message );
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

**OkResponse**

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

<a name="deleteweb3launchfollowcreator"></a>
# **DeleteWeb3LaunchFollowCreator**
> CreateWeb3LaunchFollowCreatorResponse DeleteWeb3LaunchFollowCreator (string id)

Stop following the creator of a launch. Returns `{ following }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3LaunchFollowCreatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Stop following the creator of a launch. Returns `{ following }`.
                CreateWeb3LaunchFollowCreatorResponse result = apiInstance.DeleteWeb3LaunchFollowCreator(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3LaunchFollowCreator: " + e.Message );
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

**CreateWeb3LaunchFollowCreatorResponse**

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

<a name="deleteweb3marketplacekey"></a>
# **DeleteWeb3MarketplaceKey**
> void DeleteWeb3MarketplaceKey (string marketplace)

Remove your own key for a marketplace; Crossly's key is used again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3MarketplaceKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var marketplace = "opensea";  // string | 

            try
            {
                // Remove your own key for a marketplace; Crossly's key is used again.
                apiInstance.DeleteWeb3MarketplaceKey(marketplace);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3MarketplaceKey: " + e.Message );
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
 **marketplace** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content — the request succeeded and there is no body. |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteweb3wallet"></a>
# **DeleteWeb3Wallet**
> OkResponse DeleteWeb3Wallet (string id)

Unlink a wallet. Its NFTs stay in inventory but stop syncing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3WalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Unlink a wallet. Its NFTs stay in inventory but stop syncing.
                OkResponse result = apiInstance.DeleteWeb3Wallet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3Wallet: " + e.Message );
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

**OkResponse**

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

<a name="getweb3auction"></a>
# **GetWeb3Auction**
> GetWeb3AuctionResponse GetWeb3Auction (string chain, string contract, string tokenId)

A token's live (or latest) auction: reserve, end, top bid, bid count and the minimum next bid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3AuctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 
            var tokenId = "tokenId_example";  // string | 

            try
            {
                // A token's live (or latest) auction: reserve, end, top bid, bid count and the minimum next bid.
                GetWeb3AuctionResponse result = apiInstance.GetWeb3Auction(chain, contract, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Auction: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

**GetWeb3AuctionResponse**

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

<a name="getweb3browse"></a>
# **GetWeb3Browse**
> GetWeb3BrowseResponse GetWeb3Browse ()

The Web3 directory's categories and chains, with how many collections each holds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3BrowseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // The Web3 directory's categories and chains, with how many collections each holds.
                GetWeb3BrowseResponse result = apiInstance.GetWeb3Browse();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Browse: " + e.Message );
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

**GetWeb3BrowseResponse**

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

<a name="getweb3collection"></a>
# **GetWeb3Collection**
> GetWeb3CollectionResponse GetWeb3Collection (string chain, string contract)

A collection: metadata and Crossly stats (floor, listed, volume, best collection offer).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // A collection: metadata and Crossly stats (floor, listed, volume, best collection offer).
                GetWeb3CollectionResponse result = apiInstance.GetWeb3Collection(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Collection: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionResponse**

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

<a name="getweb3collectiondepth"></a>
# **GetWeb3CollectionDepth**
> GetWeb3CollectionDepthResponse GetWeb3CollectionDepth (string chain, string contract)

A collection's Crossly order book by price level — asks cheapest first, bids dearest first, with running totals — and the floor of every trait value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionDepthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // A collection's Crossly order book by price level — asks cheapest first, bids dearest first, with running totals — and the floor of every trait value.
                GetWeb3CollectionDepthResponse result = apiInstance.GetWeb3CollectionDepth(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CollectionDepth: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionDepthResponse**

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

<a name="getweb3collectioninsight"></a>
# **GetWeb3CollectionInsight**
> GetWeb3CollectionInsightResponse GetWeb3CollectionInsight (string chain, string contract)

On-chain insights for a collection: holders, trait counts across the whole collection, recent transfers and a 30-day activity series.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // On-chain insights for a collection: holders, trait counts across the whole collection, recent transfers and a 30-day activity series.
                GetWeb3CollectionInsightResponse result = apiInstance.GetWeb3CollectionInsight(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CollectionInsight: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionInsightResponse**

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

<a name="getweb3collectionitem"></a>
# **GetWeb3CollectionItem**
> GetWeb3CollectionItemResponse GetWeb3CollectionItem (string chain, string contract)

A collection's NFTs: filter by traits (repeat trait=Type:Value; OR within a type, AND across), search by name or token id, sort by id, rarity or Crossly price. Whole-collection once indexed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // A collection's NFTs: filter by traits (repeat trait=Type:Value; OR within a type, AND across), search by name or token id, sort by id, rarity or Crossly price. Whole-collection once indexed.
                GetWeb3CollectionItemResponse result = apiInstance.GetWeb3CollectionItem(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CollectionItem: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionItemResponse**

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

<a name="getweb3collectiontrait"></a>
# **GetWeb3CollectionTrait**
> GetWeb3CollectionTraitResponse GetWeb3CollectionTrait (string chain, string contract)

Every trait type and value in a collection, with how many tokens have each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionTraitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // Every trait type and value in a collection, with how many tokens have each.
                GetWeb3CollectionTraitResponse result = apiInstance.GetWeb3CollectionTrait(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CollectionTrait: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionTraitResponse**

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

<a name="getweb3collectiontraittoken"></a>
# **GetWeb3CollectionTraitToken**
> GetWeb3CollectionTraitTokenResponse GetWeb3CollectionTraitToken (string chain, string contract)

Token ids in a collection with one trait — what a trait offer commits to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectionTraitTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // Token ids in a collection with one trait — what a trait offer commits to.
                GetWeb3CollectionTraitTokenResponse result = apiInstance.GetWeb3CollectionTraitToken(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CollectionTraitToken: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CollectionTraitTokenResponse**

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

<a name="getweb3collector"></a>
# **GetWeb3Collector**
> GetWeb3CollectorResponse GetWeb3Collector ()

Your collector perks: how many different NFTs you bought through Crossly, your Collector pin tier, relist rewards paid, and each NFT you still hold with the Bought on Crossly mark.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CollectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your collector perks: how many different NFTs you bought through Crossly, your Collector pin tier, relist rewards paid, and each NFT you still hold with the Bought on Crossly mark.
                GetWeb3CollectorResponse result = apiInstance.GetWeb3Collector();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Collector: " + e.Message );
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

**GetWeb3CollectorResponse**

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

<a name="getweb3creator"></a>
# **GetWeb3Creator**
> GetWeb3CreatorResponse GetWeb3Creator (string chain, string contract)

A collection’s creator dashboard: sales by marketplace and day, estimated royalties, holders, and for a launch the mint revenue and what is waiting to be withdrawn (wei of the chain’s native currency).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CreatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // A collection’s creator dashboard: sales by marketplace and day, estimated royalties, holders, and for a launch the mint revenue and what is waiting to be withdrawn (wei of the chain’s native currency).
                GetWeb3CreatorResponse result = apiInstance.GetWeb3Creator(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Creator: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**GetWeb3CreatorResponse**

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

<a name="getweb3crosslistquote"></a>
# **GetWeb3CrosslistQuote**
> GetWeb3CrosslistQuoteResponse GetWeb3CrosslistQuote ()

Each marketplace's terms for listing a token: Crossly fee, OpenSea required fees and zone, Tensor availability.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3CrosslistQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Each marketplace's terms for listing a token: Crossly fee, OpenSea required fees and zone, Tensor availability.
                GetWeb3CrosslistQuoteResponse result = apiInstance.GetWeb3CrosslistQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3CrosslistQuote: " + e.Message );
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

**GetWeb3CrosslistQuoteResponse**

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

<a name="getweb3featured"></a>
# **GetWeb3Featured**
> GetWeb3FeaturedResponse GetWeb3Featured ()

The NFT home's featured collections: chosen by Crossly, else the hottest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3FeaturedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // The NFT home's featured collections: chosen by Crossly, else the hottest.
                GetWeb3FeaturedResponse result = apiInstance.GetWeb3Featured();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Featured: " + e.Message );
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

**GetWeb3FeaturedResponse**

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

<a name="getweb3inventory"></a>
# **GetWeb3Inventory**
> GetWeb3InventoryResponse GetWeb3Inventory (string itemId)

The NFT behind an inventory item: its token, wallet, and open listings on every marketplace (null if it is not an NFT).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3InventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var itemId = "itemId_example";  // string | 

            try
            {
                // The NFT behind an inventory item: its token, wallet, and open listings on every marketplace (null if it is not an NFT).
                GetWeb3InventoryResponse result = apiInstance.GetWeb3Inventory(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Inventory: " + e.Message );
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
 **itemId** | **string**|  | 

### Return type

**GetWeb3InventoryResponse**

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

<a name="getweb3launchallowlistroottx"></a>
# **GetWeb3LaunchAllowlistRootTx**
> GetWeb3LaunchAllowlistRootTxResponse GetWeb3LaunchAllowlistRootTx (string id)

The setAllowlistRoot transaction for the allowlist Crossly holds (EVM, live): `{ chain, from, to, data }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3LaunchAllowlistRootTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // The setAllowlistRoot transaction for the allowlist Crossly holds (EVM, live): `{ chain, from, to, data }`.
                GetWeb3LaunchAllowlistRootTxResponse result = apiInstance.GetWeb3LaunchAllowlistRootTx(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3LaunchAllowlistRootTx: " + e.Message );
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

**GetWeb3LaunchAllowlistRootTxResponse**

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

<a name="getweb3launchdeploytx"></a>
# **GetWeb3LaunchDeployTx**
> GetWeb3LaunchDeployTxResponse GetWeb3LaunchDeployTx (string id)

The contract-creation transaction for the draft: send it from the owner wallet, then confirm it. Returns `{ chain, from, data }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3LaunchDeployTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // The contract-creation transaction for the draft: send it from the owner wallet, then confirm it. Returns `{ chain, from, data }`.
                GetWeb3LaunchDeployTxResponse result = apiInstance.GetWeb3LaunchDeployTx(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3LaunchDeployTx: " + e.Message );
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

**GetWeb3LaunchDeployTxResponse**

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

<a name="getweb3launchtool"></a>
# **GetWeb3LaunchTool**
> GetWeb3LaunchToolResponse GetWeb3LaunchTool (string id)

A launch’s creator tools: allowlist size and root (and whether the contract has it yet), uploaded art and reveal, supply minted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3LaunchToolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // A launch’s creator tools: allowlist size and root (and whether the contract has it yet), uploaded art and reveal, supply minted.
                GetWeb3LaunchToolResponse result = apiInstance.GetWeb3LaunchTool(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3LaunchTool: " + e.Message );
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

**GetWeb3LaunchToolResponse**

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

<a name="getweb3orderfulfillment"></a>
# **GetWeb3OrderFulfillment**
> GetWeb3OrderFulfillmentResponse GetWeb3OrderFulfillment (string chain, string hash)

The signed order a taker passes to Seaport, after re-checking it can still fill.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3OrderFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var hash = "hash_example";  // string | 

            try
            {
                // The signed order a taker passes to Seaport, after re-checking it can still fill.
                GetWeb3OrderFulfillmentResponse result = apiInstance.GetWeb3OrderFulfillment(chain, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3OrderFulfillment: " + e.Message );
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
 **chain** | **string**|  | 
 **hash** | **string**|  | 

### Return type

**GetWeb3OrderFulfillmentResponse**

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

<a name="getweb3phygital"></a>
# **GetWeb3Phygital**
> GetWeb3PhygitalResponse GetWeb3Phygital (string chain, string contract, string tokenId)

A token's phygital: the physical item it can be redeemed for, and whether it has been.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3PhygitalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 
            var tokenId = "tokenId_example";  // string | 

            try
            {
                // A token's phygital: the physical item it can be redeemed for, and whether it has been.
                GetWeb3PhygitalResponse result = apiInstance.GetWeb3Phygital(chain, contract, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Phygital: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

**GetWeb3PhygitalResponse**

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

<a name="getweb3phygital2"></a>
# **GetWeb3Phygital2**
> GetWeb3Phygital2Response GetWeb3Phygital2 ()

Phygitals you linked (with each redemption and its shipping address) and ones you redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3Phygital2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Phygitals you linked (with each redemption and its shipping address) and ones you redeemed.
                GetWeb3Phygital2Response result = apiInstance.GetWeb3Phygital2();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Phygital2: " + e.Message );
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

**GetWeb3Phygital2Response**

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

<a name="getweb3portfolio"></a>
# **GetWeb3Portfolio**
> GetWeb3PortfolioResponse GetWeb3Portfolio ()

Your NFTs with value (Crossly floor, else recent sales) and cost (what a linked wallet paid), realised sales, and USD totals at each day’s coin price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3PortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your NFTs with value (Crossly floor, else recent sales) and cost (what a linked wallet paid), realised sales, and USD totals at each day’s coin price.
                GetWeb3PortfolioResponse result = apiInstance.GetWeb3Portfolio();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Portfolio: " + e.Message );
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

**GetWeb3PortfolioResponse**

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

<a name="getweb3portfoliotax"></a>
# **GetWeb3PortfolioTax**
> GetWeb3PortfolioTaxResponse GetWeb3PortfolioTax ()

One calendar year of NFT disposals from your linked wallets as CSV text: acquired, sold, proceeds, cost basis, gain (coin and USD).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3PortfolioTaxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // One calendar year of NFT disposals from your linked wallets as CSV text: acquired, sold, proceeds, cost basis, gain (coin and USD).
                GetWeb3PortfolioTaxResponse result = apiInstance.GetWeb3PortfolioTax();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3PortfolioTax: " + e.Message );
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

**GetWeb3PortfolioTaxResponse**

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

<a name="getweb3profile"></a>
# **GetWeb3Profile**
> GetWeb3ProfileResponse GetWeb3Profile (string address)

A wallet's public profile: NFTs held, open Crossly listings, and activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3ProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var address = "address_example";  // string | 

            try
            {
                // A wallet's public profile: NFTs held, open Crossly listings, and activity.
                GetWeb3ProfileResponse result = apiInstance.GetWeb3Profile(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Profile: " + e.Message );
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
 **address** | **string**|  | 

### Return type

**GetWeb3ProfileResponse**

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

<a name="getweb3resolve"></a>
# **GetWeb3Resolve**
> GetWeb3ResolveResponse GetWeb3Resolve (string chain, string slug)

A collection's chain and contract from its readable URL slug (e.g. eth / boredapeyachtclub).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3ResolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var slug = "slug_example";  // string | 

            try
            {
                // A collection's chain and contract from its readable URL slug (e.g. eth / boredapeyachtclub).
                GetWeb3ResolveResponse result = apiInstance.GetWeb3Resolve(chain, slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Resolve: " + e.Message );
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
 **chain** | **string**|  | 
 **slug** | **string**|  | 

### Return type

**GetWeb3ResolveResponse**

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

<a name="getweb3solanacollectiontensorbid"></a>
# **GetWeb3SolanaCollectionTensorBid**
> GetWeb3SolanaCollectionTensorBidResponse GetWeb3SolanaCollectionTensorBid (string collection)

A Solana collection’s Tensor bids (collection-wide and by trait), best first; price in lamports. Needs your Tensor key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3SolanaCollectionTensorBidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var collection = "collection_example";  // string | 

            try
            {
                // A Solana collection’s Tensor bids (collection-wide and by trait), best first; price in lamports. Needs your Tensor key.
                GetWeb3SolanaCollectionTensorBidResponse result = apiInstance.GetWeb3SolanaCollectionTensorBid(collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3SolanaCollectionTensorBid: " + e.Message );
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
 **collection** | **string**|  | 

### Return type

**GetWeb3SolanaCollectionTensorBidResponse**

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

<a name="getweb3token"></a>
# **GetWeb3Token**
> GetWeb3TokenResponse GetWeb3Token (string chain, string contract, string tokenId)

One NFT: metadata, traits, owner, open listings and offers, activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3TokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 
            var tokenId = "tokenId_example";  // string | 

            try
            {
                // One NFT: metadata, traits, owner, open listings and offers, activity.
                GetWeb3TokenResponse result = apiInstance.GetWeb3Token(chain, contract, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Token: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

**GetWeb3TokenResponse**

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

<a name="listweb3activity"></a>
# **ListWeb3Activity**
> ListWeb3ActivityResponse ListWeb3Activity ()

Listings, offers, sales and cancels in the Crossly book, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3ActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Listings, offers, sales and cancels in the Crossly book, newest first.
                ListWeb3ActivityResponse result = apiInstance.ListWeb3Activity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Activity: " + e.Message );
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

**ListWeb3ActivityResponse**

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

<a name="listweb3alerts"></a>
# **ListWeb3Alerts**
> ListWeb3AlertsResponse ListWeb3Alerts ()

Your NFT price alerts, with the cheapest open Crossly listing each one covers now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3AlertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your NFT price alerts, with the cheapest open Crossly listing each one covers now.
                ListWeb3AlertsResponse result = apiInstance.ListWeb3Alerts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Alerts: " + e.Message );
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

**ListWeb3AlertsResponse**

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

<a name="listweb3approvals"></a>
# **ListWeb3Approvals**
> ListWeb3ApprovalsResponse ListWeb3Approvals ()

Your collections the OpenSea conduit is approved to move, per linked wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3ApprovalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your collections the OpenSea conduit is approved to move, per linked wallet.
                ListWeb3ApprovalsResponse result = apiInstance.ListWeb3Approvals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Approvals: " + e.Message );
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

**ListWeb3ApprovalsResponse**

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

<a name="listweb3auctions"></a>
# **ListWeb3Auctions**
> ListWeb3AuctionsResponse ListWeb3Auctions ()

Live English auctions on the Crossly book, ending soonest first, each with its top bid and the least the next bid can be.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3AuctionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Live English auctions on the Crossly book, ending soonest first, each with its top bid and the least the next bid can be.
                ListWeb3AuctionsResponse result = apiInstance.ListWeb3Auctions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Auctions: " + e.Message );
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

**ListWeb3AuctionsResponse**

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

<a name="listweb3browsecollections"></a>
# **ListWeb3BrowseCollections**
> ListWeb3BrowseCollectionsResponse ListWeb3BrowseCollections ()

Browse NFT collections by chain, category and name; sort hot (Crossly sales, listings, favourites), new, volume, floor or name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3BrowseCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Browse NFT collections by chain, category and name; sort hot (Crossly sales, listings, favourites), new, volume, floor or name.
                ListWeb3BrowseCollectionsResponse result = apiInstance.ListWeb3BrowseCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3BrowseCollections: " + e.Message );
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

**ListWeb3BrowseCollectionsResponse**

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

<a name="listweb3browsetokens"></a>
# **ListWeb3BrowseTokens**
> ListWeb3BrowseTokensResponse ListWeb3BrowseTokens ()

Hot NFTs: what is for sale on Crossly first, then tokens from the hottest collections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3BrowseTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Hot NFTs: what is for sale on Crossly first, then tokens from the hottest collections.
                ListWeb3BrowseTokensResponse result = apiInstance.ListWeb3BrowseTokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3BrowseTokens: " + e.Message );
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

**ListWeb3BrowseTokensResponse**

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

<a name="listweb3bundles"></a>
# **ListWeb3Bundles**
> ListWeb3BundlesResponse ListWeb3Bundles ()

Open bundle listings (2–30 NFTs for one price), newest first, by chain or by a contract any item is from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3BundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Open bundle listings (2–30 NFTs for one price), newest first, by chain or by a contract any item is from.
                ListWeb3BundlesResponse result = apiInstance.ListWeb3Bundles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Bundles: " + e.Message );
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

**ListWeb3BundlesResponse**

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

<a name="listweb3collectionhistory"></a>
# **ListWeb3CollectionHistory**
> ListWeb3CollectionHistoryResponse ListWeb3CollectionHistory (string chain, string contract)

Daily floor, sales, volume, holders and listed count for a collection, oldest first (up to 365 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3CollectionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // Daily floor, sales, volume, holders and listed count for a collection, oldest first (up to 365 days).
                ListWeb3CollectionHistoryResponse result = apiInstance.ListWeb3CollectionHistory(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3CollectionHistory: " + e.Message );
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
 **chain** | **string**|  | 
 **contract** | **string**|  | 

### Return type

**ListWeb3CollectionHistoryResponse**

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

<a name="listweb3collections"></a>
# **ListWeb3Collections**
> ListWeb3CollectionsResponse ListWeb3Collections ()

Collections ranked by 30-day Crossly volume, with floor and listed count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3CollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Collections ranked by 30-day Crossly volume, with floor and listed count.
                ListWeb3CollectionsResponse result = apiInstance.ListWeb3Collections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Collections: " + e.Message );
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

**ListWeb3CollectionsResponse**

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

<a name="listweb3creatorcollections"></a>
# **ListWeb3CreatorCollections**
> ListWeb3CreatorCollectionsResponse ListWeb3CreatorCollections ()

Collections you are the creator of: your launches, and contracts you claimed by owning them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3CreatorCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Collections you are the creator of: your launches, and contracts you claimed by owning them.
                ListWeb3CreatorCollectionsResponse result = apiInstance.ListWeb3CreatorCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3CreatorCollections: " + e.Message );
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

**ListWeb3CreatorCollectionsResponse**

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

<a name="listweb3drops"></a>
# **ListWeb3Drops**
> ListWeb3DropsResponse ListWeb3Drops ()

Upcoming and live NFT drops (curated mints on the creator's own page), soonest first, with whether you asked to be reminded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3DropsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Upcoming and live NFT drops (curated mints on the creator's own page), soonest first, with whether you asked to be reminded.
                ListWeb3DropsResponse result = apiInstance.ListWeb3Drops();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Drops: " + e.Message );
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

**ListWeb3DropsResponse**

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

<a name="listweb3holderperks"></a>
# **ListWeb3HolderPerks**
> ListWeb3HolderPerksResponse ListWeb3HolderPerks ()

Your holder perks: percent off your Crossly shop for holders of an NFT collection, best first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3HolderPerksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your holder perks: percent off your Crossly shop for holders of an NFT collection, best first.
                ListWeb3HolderPerksResponse result = apiInstance.ListWeb3HolderPerks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3HolderPerks: " + e.Message );
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

**ListWeb3HolderPerksResponse**

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

<a name="listweb3launches"></a>
# **ListWeb3Launches**
> ListWeb3LaunchesResponse ListWeb3Launches ()

Your launchpad collections (drafts and live), newest first, with minted count and phase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3LaunchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your launchpad collections (drafts and live), newest first, with minted count and phase.
                ListWeb3LaunchesResponse result = apiInstance.ListWeb3Launches();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Launches: " + e.Message );
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

**ListWeb3LaunchesResponse**

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

<a name="listweb3listings"></a>
# **ListWeb3Listings**
> ListWeb3ListingsResponse ListWeb3Listings ()

Open NFT listings in the Crossly book — the cheapest per token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3ListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Open NFT listings in the Crossly book — the cheapest per token.
                ListWeb3ListingsResponse result = apiInstance.ListWeb3Listings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Listings: " + e.Message );
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

**ListWeb3ListingsResponse**

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

<a name="listweb3marketplacekeys"></a>
# **ListWeb3MarketplaceKeys**
> ListWeb3MarketplaceKeysResponse ListWeb3MarketplaceKeys ()

Your own marketplace API keys (last four characters only) and whether Crossly's key covers each marketplace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3MarketplaceKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your own marketplace API keys (last four characters only) and whether Crossly's key covers each marketplace.
                ListWeb3MarketplaceKeysResponse result = apiInstance.ListWeb3MarketplaceKeys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3MarketplaceKeys: " + e.Message );
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

**ListWeb3MarketplaceKeysResponse**

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

<a name="listweb3nfts"></a>
# **ListWeb3Nfts**
> ListWeb3NftsResponse ListWeb3Nfts (string chain = null, string walletId = null, int? page = null, int? limit = null)

List the NFTs in your inventory, imported from your linked wallets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3NftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var chain = "ethereum";  // string |  (optional) 
            var walletId = "walletId_example";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List the NFTs in your inventory, imported from your linked wallets.
                ListWeb3NftsResponse result = apiInstance.ListWeb3Nfts(chain, walletId, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Nfts: " + e.Message );
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
 **chain** | **string**|  | [optional] 
 **walletId** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListWeb3NftsResponse**

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

<a name="listweb3orders"></a>
# **ListWeb3Orders**
> ListWeb3OrdersResponse ListWeb3Orders ()

Your orders in the Crossly book (listings and offers), any status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3OrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your orders in the Crossly book (listings and offers), any status.
                ListWeb3OrdersResponse result = apiInstance.ListWeb3Orders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Orders: " + e.Message );
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

**ListWeb3OrdersResponse**

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

<a name="listweb3purchases"></a>
# **ListWeb3Purchases**
> ListWeb3PurchasesResponse ListWeb3Purchases ()

NFTs your linked wallets bought — on Crossly or any marketplace the chain feed saw — newest first, with price and whether you still hold each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3PurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // NFTs your linked wallets bought — on Crossly or any marketplace the chain feed saw — newest first, with price and whether you still hold each.
                ListWeb3PurchasesResponse result = apiInstance.ListWeb3Purchases();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Purchases: " + e.Message );
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

**ListWeb3PurchasesResponse**

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

<a name="listweb3rankings"></a>
# **ListWeb3Rankings**
> ListWeb3RankingsResponse ListWeb3Rankings ()

Collections by sales volume over 24h, 7d or 30d, in one coin: the ETH chains together, or Polygon / Solana on their own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3RankingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Collections by sales volume over 24h, 7d or 30d, in one coin: the ETH chains together, or Polygon / Solana on their own.
                ListWeb3RankingsResponse result = apiInstance.ListWeb3Rankings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Rankings: " + e.Message );
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

**ListWeb3RankingsResponse**

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

<a name="listweb3reserved"></a>
# **ListWeb3Reserved**
> ListWeb3BundlesResponse ListWeb3Reserved ()

Private listings reserved for one of your linked wallets — only you can see or buy them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3ReservedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Private listings reserved for one of your linked wallets — only you can see or buy them.
                ListWeb3BundlesResponse result = apiInstance.ListWeb3Reserved();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Reserved: " + e.Message );
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

**ListWeb3BundlesResponse**

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

<a name="listweb3sales"></a>
# **ListWeb3Sales**
> ListWeb3SalesResponse ListWeb3Sales ()

The latest NFT sales across the directory, from the chain (Seaport and Blur) and the Crossly book, newest first; page with `before`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3SalesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // The latest NFT sales across the directory, from the chain (Seaport and Blur) and the Crossly book, newest first; page with `before`.
                ListWeb3SalesResponse result = apiInstance.ListWeb3Sales();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Sales: " + e.Message );
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

**ListWeb3SalesResponse**

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

<a name="listweb3search"></a>
# **ListWeb3Search**
> ListWeb3SearchResponse ListWeb3Search ()

Find collections by contract address (every chain) or by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3SearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Find collections by contract address (every chain) or by name.
                ListWeb3SearchResponse result = apiInstance.ListWeb3Search();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Search: " + e.Message );
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

**ListWeb3SearchResponse**

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

<a name="listweb3searchtokens"></a>
# **ListWeb3SearchTokens**
> ListWeb3SearchTokensResponse ListWeb3SearchTokens ()

Find tokens by collection name and number: 'pudgy 42', 'Bored Ape #1234'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3SearchTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Find tokens by collection name and number: 'pudgy 42', 'Bored Ape #1234'.
                ListWeb3SearchTokensResponse result = apiInstance.ListWeb3SearchTokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3SearchTokens: " + e.Message );
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

**ListWeb3SearchTokensResponse**

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

<a name="listweb3wallets"></a>
# **ListWeb3Wallets**
> ListWeb3WalletsResponse ListWeb3Wallets ()

List your verified, linked wallets (EVM and Solana).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3WalletsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // List your verified, linked wallets (EVM and Solana).
                ListWeb3WalletsResponse result = apiInstance.ListWeb3Wallets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Wallets: " + e.Message );
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

**ListWeb3WalletsResponse**

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

<a name="listweb3watchlist"></a>
# **ListWeb3Watchlist**
> ListWeb3WatchlistResponse ListWeb3Watchlist ()

Your favourited NFTs, with the cheapest open Crossly listing and the last sale of each.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3WatchlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Your favourited NFTs, with the cheapest open Crossly listing and the last sale of each.
                ListWeb3WatchlistResponse result = apiInstance.ListWeb3Watchlist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3Watchlist: " + e.Message );
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

**ListWeb3WatchlistResponse**

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

<a name="updateweb3holderperk"></a>
# **UpdateWeb3HolderPerk**
> ListWeb3HolderPerksItem UpdateWeb3HolderPerk ()

Set the percent off (100–5000 bps) holders of a collection get across your Crossly shop; one perk per collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3HolderPerkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);

            try
            {
                // Set the percent off (100–5000 bps) holders of a collection get across your Crossly shop; one perk per collection.
                ListWeb3HolderPerksItem result = apiInstance.UpdateWeb3HolderPerk();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3HolderPerk: " + e.Message );
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

**ListWeb3HolderPerksItem**

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

<a name="updateweb3launchallowlist"></a>
# **UpdateWeb3LaunchAllowlist**
> UpdateWeb3LaunchAllowlistResponse UpdateWeb3LaunchAllowlist (string id)

Replace the early-phase allowlist (up to 10,000 wallets). EVM live launches get back `rootTx`, the setAllowlistRoot transaction for the owner wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3LaunchAllowlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // string | 

            try
            {
                // Replace the early-phase allowlist (up to 10,000 wallets). EVM live launches get back `rootTx`, the setAllowlistRoot transaction for the owner wallet.
                UpdateWeb3LaunchAllowlistResponse result = apiInstance.UpdateWeb3LaunchAllowlist(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3LaunchAllowlist: " + e.Message );
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

**UpdateWeb3LaunchAllowlistResponse**

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

<a name="updateweb3marketplacekey"></a>
# **UpdateWeb3MarketplaceKey**
> ListWeb3MarketplaceKeysItem UpdateWeb3MarketplaceKey (string marketplace)

Save your own API key for a marketplace (checked against the marketplace first where it can be); stored encrypted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3MarketplaceKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var marketplace = "opensea";  // string | 

            try
            {
                // Save your own API key for a marketplace (checked against the marketplace first where it can be); stored encrypted.
                ListWeb3MarketplaceKeysItem result = apiInstance.UpdateWeb3MarketplaceKey(marketplace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3MarketplaceKey: " + e.Message );
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
 **marketplace** | **string**|  | 

### Return type

**ListWeb3MarketplaceKeysItem**

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

