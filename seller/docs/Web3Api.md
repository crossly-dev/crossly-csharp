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
[**CreateWeb3SolanaTensorBidConfirm**](Web3Api.md#createweb3solanatensorbidconfirm) | **POST** /v1/web3/solana/tensor-bids/confirm | After your wallet’s Tensor transaction confirms: &#x60;action&#x60; place, cancel or accept, with its &#x60;signature&#x60; and the &#x60;wallet&#x60; that signed. Checked on chain, then recorded in your Activity. Accept needs listings:write; place and cancel need buyer:offers:write.
[**CreateWeb3SolanaTensorBidPlaceTx**](Web3Api.md#createweb3solanatensorbidplacetx) | **POST** /v1/web3/solana/tensor-bids/place-tx | Build a Tensor collection bid (or trait bid with &#x60;trait&#x60;) for your Solana wallet to sign. Price in lamports.
[**CreateWeb3StakingStake**](Web3Api.md#createweb3stakingstake) | **POST** /v1/web3/staking/stake | Lock earned CBX (&#x60;baseUnits&#x60;, a string) into the best tier it reaches. 409 while a stake or unstake is in progress.
[**CreateWeb3StakingUnstake**](Web3Api.md#createweb3stakingunstake) | **POST** /v1/web3/staking/unstake | Start unstaking: the earn boost stops now, the tokens release when the tier’s cooldown ends. Returns &#x60;{ unlocksAt, cooldownDays }&#x60;.
[**CreateWeb3StoreWallet**](Web3Api.md#createweb3storewallet) | **POST** /v1/web3/store-wallets | Link one of your verified wallets to the store so it sells NFTs from it and is paid into it.
[**CreateWeb3StoreWalletChallenge**](Web3Api.md#createweb3storewalletchallenge) | **POST** /v1/web3/store-wallets/challenge | Start adding a selling wallet to the store: the message the wallet signs.
[**CreateWeb3StoreWalletImport**](Web3Api.md#createweb3storewalletimport) | **POST** /v1/web3/store-wallets/{walletId}/import | Add picked NFTs (&#x60;tokens: [{ chain, contract, tokenId }]&#x60;) from a store wallet to inventory.
[**CreateWeb3StoreWalletSync**](Web3Api.md#createweb3storewalletsync) | **POST** /v1/web3/store-wallets/{walletId}/sync | Sync a store wallet: refresh its NFTs in inventory; new ones are added when the store&#39;s link auto-imports.
[**CreateWeb3StoreWalletVerify**](Web3Api.md#createweb3storewalletverify) | **POST** /v1/web3/store-wallets/verify | Finish adding a selling wallet: verify its signature and link it to the store.
[**CreateWeb3TokenRefresh**](Web3Api.md#createweb3tokenrefresh) | **POST** /v1/web3/tokens/{chain}/{contract}/{tokenId}/refresh | Re-read a token&#39;s metadata from the chain&#39;s provider (name, traits, image — a new image is copied to Crossly&#39;s CDN). Once per token per 10 minutes.
[**CreateWeb3Transaction**](Web3Api.md#createweb3transaction) | **POST** /v1/web3/transactions | Apply a Seaport transaction&#39;s fills and cancels to the Crossly book (read from the receipt).
[**CreateWeb3WalletChallenge**](Web3Api.md#createweb3walletchallenge) | **POST** /v1/web3/wallets/challenge | Start linking a wallet: returns the message the wallet must sign.
[**CreateWeb3WalletImport**](Web3Api.md#createweb3walletimport) | **POST** /v1/web3/wallets/{id}/import | Add picked NFTs (&#x60;tokens&#x60;: chain, contract, tokenId; up to 200) from a linked wallet to inventory. Tokens the wallet does not hold are counted in &#x60;notInWallet&#x60;, never added.
[**CreateWeb3WalletSync**](Web3Api.md#createweb3walletsync) | **POST** /v1/web3/wallets/{id}/sync | Import a linked wallet&#39;s NFTs into inventory; archives ones that have left the wallet.
[**CreateWeb3WalletVerify**](Web3Api.md#createweb3walletverify) | **POST** /v1/web3/wallets/verify | Finish linking a wallet with its signature over the challenge message.
[**DeleteWeb3Alert**](Web3Api.md#deleteweb3alert) | **DELETE** /v1/web3/alerts/{id} | Delete a price alert.
[**DeleteWeb3HolderPerk**](Web3Api.md#deleteweb3holderperk) | **DELETE** /v1/web3/holder-perks/{id} | DEPRECATED: use /api/v1/discounts/holders/:id. Remove a Collection holders deal. Returns &#x60;{ ok }&#x60;.
[**DeleteWeb3Launch**](Web3Api.md#deleteweb3launch) | **DELETE** /v1/web3/launches/{id} | Delete a launch draft that never went live. Returns &#x60;{ ok }&#x60;.
[**DeleteWeb3LaunchFollowCreator**](Web3Api.md#deleteweb3launchfollowcreator) | **DELETE** /v1/web3/launches/{id}/follow-creator | Stop following the creator of a launch. Returns &#x60;{ following }&#x60;.
[**DeleteWeb3LaunchPerk**](Web3Api.md#deleteweb3launchperk) | **DELETE** /v1/web3/launches/{id}/perks | Remove every collection perk of a launch. Returns &#x60;{ ok }&#x60;.
[**DeleteWeb3MarketplaceKey**](Web3Api.md#deleteweb3marketplacekey) | **DELETE** /v1/web3/marketplace-keys/{marketplace} | Remove your own key for a marketplace; Crossly&#39;s key is used again.
[**DeleteWeb3StoreWallet**](Web3Api.md#deleteweb3storewallet) | **DELETE** /v1/web3/store-wallets/{walletId} | Stop the store selling from a wallet (the wallet and its other stores are unaffected).
[**DeleteWeb3Wallet**](Web3Api.md#deleteweb3wallet) | **DELETE** /v1/web3/wallets/{id} | Unlink a wallet. Its NFTs stay in inventory but stop syncing.
[**GetWeb3Auction**](Web3Api.md#getweb3auction) | **GET** /v1/web3/auctions/{chain}/{contract}/{tokenId} | A token&#39;s live (or latest) auction: reserve, end, top bid, bid count and the minimum next bid.
[**GetWeb3Balance**](Web3Api.md#getweb3balance) | **GET** /v1/web3/balances | Every CBX you have, in one read, with the three balances kept apart.
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
[**GetWeb3LaunchStat**](Web3Api.md#getweb3launchstat) | **GET** /v1/web3/launches/{id}/stats | A launch’s phase timeline, mint progress, proceeds (gross, Crossly’s cut, yours; airdrops excluded), allowlist and art counts, and recent mints.
[**GetWeb3LaunchTool**](Web3Api.md#getweb3launchtool) | **GET** /v1/web3/launches/{id}/tools | A launch’s creator tools: allowlist size and root (and whether the contract has it yet), uploaded art and reveal, supply minted.
[**GetWeb3OrderFulfillment**](Web3Api.md#getweb3orderfulfillment) | **GET** /v1/web3/orders/{chain}/{hash}/fulfillment | The signed order a taker passes to Seaport, after re-checking it can still fill.
[**GetWeb3Phygital**](Web3Api.md#getweb3phygital) | **GET** /v1/web3/phygitals/{chain}/{contract}/{tokenId} | A token&#39;s phygital: the physical item it can be redeemed for, and whether it has been.
[**GetWeb3Phygital2**](Web3Api.md#getweb3phygital2) | **GET** /v1/web3/phygitals | Phygitals you linked (with each redemption and its shipping address) and ones you redeemed.
[**GetWeb3Portfolio**](Web3Api.md#getweb3portfolio) | **GET** /v1/web3/portfolio | Your NFTs with value (Crossly floor, else recent sales) and cost (what a linked wallet paid), realised sales, and USD totals at each day’s coin price.
[**GetWeb3PortfolioTax**](Web3Api.md#getweb3portfoliotax) | **GET** /v1/web3/portfolio/tax | One calendar year of NFT disposals from your linked wallets as CSV text: acquired, sold, proceeds, cost basis, gain (coin and USD).
[**GetWeb3Profile**](Web3Api.md#getweb3profile) | **GET** /v1/web3/profiles/{address} | A wallet&#39;s public profile: NFTs held, open Crossly listings, and activity.
[**GetWeb3Resolve**](Web3Api.md#getweb3resolve) | **GET** /v1/web3/resolve/{chain}/{slug} | A collection&#39;s chain and contract from its readable URL slug (e.g. eth / boredapeyachtclub).
[**GetWeb3SolanaCollectionTensorBid**](Web3Api.md#getweb3solanacollectiontensorbid) | **GET** /v1/web3/solana/collections/{collection}/tensor-bids | A Solana collection’s Tensor bids (collection-wide and by trait), best first; price in lamports. Needs your Tensor key.
[**GetWeb3Staking**](Web3Api.md#getweb3staking) | **GET** /v1/web3/staking | Your CBX stake: what is locked, its tier, the tier ladder and your past positions.
[**GetWeb3StoreWalletHolding**](Web3Api.md#getweb3storewalletholding) | **GET** /v1/web3/store-wallets/{walletId}/holdings | What a store wallet holds (chain + contract + token id), each marked in-inventory or not.
[**GetWeb3StoreWalletNft**](Web3Api.md#getweb3storewalletnft) | **GET** /v1/web3/store-wallets/nfts | The store&#39;s Crossly NFTs: plots (deeds and leases), streets its owner founded and vault receipt tokens in its wallets, with the wallets a plot purchase and a receipt export use.
[**GetWeb3Token**](Web3Api.md#getweb3token) | **GET** /v1/web3/tokens/{chain}/{contract}/{tokenId} | One NFT: metadata, traits, owner, open listings and offers, activity.
[**GetWeb3WalletHolding**](Web3Api.md#getweb3walletholding) | **GET** /v1/web3/wallets/{id}/holdings | What a linked wallet holds right now, each NFT marked &#x60;inInventory&#x60; or not. Reads the chain; writes nothing.
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
[**ListWeb3HolderPerks**](Web3Api.md#listweb3holderperks) | **GET** /v1/web3/holder-perks | DEPRECATED: use /api/v1/discounts/holders. Your Collection holders deals in the old holder-perk shape, best first.
[**ListWeb3LaunchPerks**](Web3Api.md#listweb3launchperks) | **GET** /v1/web3/launches/{id}/perks | The perks holders of this launch’s collection get (percent off your shop, early drop access, a World item, a loyalty tier, live early entry, an event ticket).
[**ListWeb3Launches**](Web3Api.md#listweb3launches) | **GET** /v1/web3/launches | Your launchpad collections (drafts and live), newest first, with minted count and phase.
[**ListWeb3Listings**](Web3Api.md#listweb3listings) | **GET** /v1/web3/listings | Open NFT listings in the Crossly book — the cheapest per token.
[**ListWeb3MarketplaceKeys**](Web3Api.md#listweb3marketplacekeys) | **GET** /v1/web3/marketplace-keys | Your own marketplace API keys (last four characters only) and whether Crossly&#39;s key covers each marketplace.
[**ListWeb3Nfts**](Web3Api.md#listweb3nfts) | **GET** /v1/web3/nfts | List the NFTs in your inventory, imported from your linked wallets.
[**ListWeb3Orders**](Web3Api.md#listweb3orders) | **GET** /v1/web3/orders | Your orders in the Crossly book (listings and offers), any status. With X-Storefront-Id: that store&#39;s listings (offers always).
[**ListWeb3Purchases**](Web3Api.md#listweb3purchases) | **GET** /v1/web3/purchases | NFTs your linked wallets bought — on Crossly or any marketplace the chain feed saw — newest first, with price and whether you still hold each.
[**ListWeb3Rankings**](Web3Api.md#listweb3rankings) | **GET** /v1/web3/rankings | Collections by sales volume over 24h, 7d or 30d, in one coin: the ETH chains together, or Polygon / Solana on their own.
[**ListWeb3Reserved**](Web3Api.md#listweb3reserved) | **GET** /v1/web3/reserved | Private listings reserved for one of your linked wallets — only you can see or buy them.
[**ListWeb3Sales**](Web3Api.md#listweb3sales) | **GET** /v1/web3/sales | The latest NFT sales across the directory, from the chain (Seaport and Blur) and the Crossly book, newest first; page with &#x60;before&#x60;.
[**ListWeb3Search**](Web3Api.md#listweb3search) | **GET** /v1/web3/search | Find collections by contract address (every chain) or by name.
[**ListWeb3SearchTokens**](Web3Api.md#listweb3searchtokens) | **GET** /v1/web3/search/tokens | Find tokens by collection name and number: &#39;pudgy 42&#39;, &#39;Bored Ape #1234&#39;.
[**ListWeb3StoreWalletBalances**](Web3Api.md#listweb3storewalletbalances) | **GET** /v1/web3/store-wallets/balances | The native-coin balance (SOL, ETH, POL, …) of each of the store&#39;s selling wallets, read on chain.
[**ListWeb3StoreWalletMarketplaces**](Web3Api.md#listweb3storewalletmarketplaces) | **GET** /v1/web3/store-wallets/marketplaces | Each NFT marketplace&#39;s status for this store: Live only with a usable API key AND a verified store wallet of its network switched on for it. &#x60;keyMode&#x60; is &#x60;crossly&#x60; (Crossly&#39;s key, nothing to set up) or &#x60;own_key&#x60; (connect your own key).
[**ListWeb3StoreWallets**](Web3Api.md#listweb3storewallets) | **GET** /v1/web3/store-wallets | List the store&#39;s selling wallets (X-Storefront-Id; default store when omitted).
[**ListWeb3Wallets**](Web3Api.md#listweb3wallets) | **GET** /v1/web3/wallets | List your verified, linked wallets (EVM and Solana).
[**ListWeb3Watchlist**](Web3Api.md#listweb3watchlist) | **GET** /v1/web3/watchlist | Your favourited NFTs, with the cheapest open Crossly listing and the last sale of each.
[**UpdateWeb3HolderPerk**](Web3Api.md#updateweb3holderperk) | **PUT** /v1/web3/holder-perks | DEPRECATED: use /api/v1/discounts/holders. Set the percent off (100–5000 bps) holders of a collection get in your store (the key’s store, else the default); one per collection.
[**UpdateWeb3Launch**](Web3Api.md#updateweb3launch) | **PATCH** /v1/web3/launches/{id} | Edit a launch draft (or a failed deploy) before it deploys: any creation field except chain and owner. The schedule is re-checked; 409 once live.
[**UpdateWeb3LaunchAllowlist**](Web3Api.md#updateweb3launchallowlist) | **PUT** /v1/web3/launches/{id}/allowlist | Replace the early-phase allowlist (up to 10,000 wallets). EVM live launches get back &#x60;rootTx&#x60;, the setAllowlistRoot transaction for the owner wallet.
[**UpdateWeb3LaunchPerk**](Web3Api.md#updateweb3launchperk) | **PUT** /v1/web3/launches/{id}/perks | Replace a launch’s collection perks: &#x60;{ perks: [{ config: { type, ... }, active }] }&#x60;, one per type; a type left out is removed.
[**UpdateWeb3MarketplaceKey**](Web3Api.md#updateweb3marketplacekey) | **PUT** /v1/web3/marketplace-keys/{marketplace} | Save your own API key for a marketplace (checked against the marketplace first where it can be); stored encrypted.
[**UpdateWeb3StoreWallet**](Web3Api.md#updateweb3storewallet) | **PATCH** /v1/web3/store-wallets/{walletId} | Turn on or off whether syncing this store wallet adds new NFTs to the store’s inventory (X-Storefront-Id).
[**UpdateWeb3StoreWalletDefault**](Web3Api.md#updateweb3storewalletdefault) | **PUT** /v1/web3/store-wallets/{walletId}/default | Make a linked wallet the store&#39;s default selling wallet on its network (EVM or Solana).
[**UpdateWeb3StoreWalletMarketplace**](Web3Api.md#updateweb3storewalletmarketplace) | **PUT** /v1/web3/store-wallets/{walletId}/marketplaces/{marketplace} | Switch one NFT marketplace (opensea, rarible on EVM; magic_eden, tensor on Solana) on or off for a store wallet: &#x60;{ enabled }&#x60;.
[**UpdateWeb3Wallet**](Web3Api.md#updateweb3wallet) | **PATCH** /v1/web3/wallets/{id} | Change a linked wallet: &#x60;autoImport&#x60; (a sync adds new NFTs to inventory; off, it only refreshes the ones there) and &#x60;label&#x60;.


<a name="createweb3alert"></a>
# **CreateWeb3Alert**
> IdResponse CreateWeb3Alert (CreateWeb3AlertRequest createWeb3AlertRequest)

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
            var createWeb3AlertRequest = new CreateWeb3AlertRequest(); // CreateWeb3AlertRequest | 

            try
            {
                // Set a price alert on a token, or on a whole collection without tokenId: you are notified when one is listed at or below `price` (the chain's native coin). Setting it again moves the price.
                IdResponse result = apiInstance.CreateWeb3Alert(createWeb3AlertRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3AlertRequest** | **CreateWeb3AlertRequest**|  | 

### Return type

**IdResponse**

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

<a name="createweb3auction"></a>
# **CreateWeb3Auction**
> CreateWeb3AuctionResponse CreateWeb3Auction (CreateWeb3AuctionRequest createWeb3AuctionRequest)

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
            var createWeb3AuctionRequest = new CreateWeb3AuctionRequest(); // CreateWeb3AuctionRequest | 

            try
            {
                // Start an English auction on a token in your linked wallet: `reserve` is the opening bid in the chain's native coin, `hours` its length (1–720). Bids must rise 5%; a late bid extends the end by 10 minutes.
                CreateWeb3AuctionResponse result = apiInstance.CreateWeb3Auction(createWeb3AuctionRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3AuctionRequest** | **CreateWeb3AuctionRequest**|  | 

### Return type

**CreateWeb3AuctionResponse**

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
> CreateWeb3CreatorClaimResponse CreateWeb3CreatorClaim (CreateWeb3CreatorClaimRequest createWeb3CreatorClaimRequest)

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
            var createWeb3CreatorClaimRequest = new CreateWeb3CreatorClaimRequest(); // CreateWeb3CreatorClaimRequest | 

            try
            {
                // Claim an EVM collection as its creator: its owner() must be one of your verified wallets. Returns `{ chain, contract }`.
                CreateWeb3CreatorClaimResponse result = apiInstance.CreateWeb3CreatorClaim(createWeb3CreatorClaimRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3CreatorClaimRequest** | **CreateWeb3CreatorClaimRequest**|  | 

### Return type

**CreateWeb3CreatorClaimResponse**

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

<a name="createweb3crosslist"></a>
# **CreateWeb3Crosslist**
> CreateWeb3CrosslistResponse CreateWeb3Crosslist (CreateWeb3CrosslistRequest createWeb3CrosslistRequest)

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
            var createWeb3CrosslistRequest = new CreateWeb3CrosslistRequest(); // CreateWeb3CrosslistRequest | 

            try
            {
                // Submit signed Seaport listings for several marketplaces at once (crossly, opensea); results per marketplace.
                CreateWeb3CrosslistResponse result = apiInstance.CreateWeb3Crosslist(createWeb3CrosslistRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3CrosslistRequest** | **CreateWeb3CrosslistRequest**|  | 

### Return type

**CreateWeb3CrosslistResponse**

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
> CreateWeb3FavoriteResponse CreateWeb3Favorite (CreateWeb3FavoriteRequest createWeb3FavoriteRequest)

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
            var createWeb3FavoriteRequest = new CreateWeb3FavoriteRequest(); // CreateWeb3FavoriteRequest | 

            try
            {
                // Favourite an NFT, or unfavourite it if it already is. Returns `{ favorited }`.
                CreateWeb3FavoriteResponse result = apiInstance.CreateWeb3Favorite(createWeb3FavoriteRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3FavoriteRequest** | **CreateWeb3FavoriteRequest**|  | 

### Return type

**CreateWeb3FavoriteResponse**

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

<a name="createweb3launch"></a>
# **CreateWeb3Launch**
> ListWeb3LaunchesItem CreateWeb3Launch (CreateWeb3LaunchRequest createWeb3LaunchRequest)

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
            var createWeb3LaunchRequest = new CreateWeb3LaunchRequest(); // CreateWeb3LaunchRequest | 

            try
            {
                // Draft a launchpad collection: name, symbol, supply, mint price (wei of the chain’s native currency), schedule, optional holder phase and royalty. Crossly takes 5% of each mint inside the contract.
                ListWeb3LaunchesItem result = apiInstance.CreateWeb3Launch(createWeb3LaunchRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3LaunchRequest** | **CreateWeb3LaunchRequest**|  | 

### Return type

**ListWeb3LaunchesItem**

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
> CreateWeb3OrderResponse CreateWeb3Order (CreateWeb3OrderRequest createWeb3OrderRequest)

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
            var createWeb3OrderRequest = new CreateWeb3OrderRequest(); // CreateWeb3OrderRequest | 

            try
            {
                // Place a signed Seaport 1.6 order (listing, offer or collection offer) in the Crossly book.
                CreateWeb3OrderResponse result = apiInstance.CreateWeb3Order(createWeb3OrderRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3OrderRequest** | **CreateWeb3OrderRequest**|  | 

### Return type

**CreateWeb3OrderResponse**

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
> CreateWeb3OrderFulfillmentBatchResponse CreateWeb3OrderFulfillmentBatch (CreateWeb3OrderFulfillmentBatchRequest createWeb3OrderFulfillmentBatchRequest)

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
            var createWeb3OrderFulfillmentBatchRequest = new CreateWeb3OrderFulfillmentBatchRequest(); // CreateWeb3OrderFulfillmentBatchRequest | 

            try
            {
                // Fulfilments for sweeping several listings in one Seaport transaction; unfillable ones are skipped with a reason.
                CreateWeb3OrderFulfillmentBatchResponse result = apiInstance.CreateWeb3OrderFulfillmentBatch(createWeb3OrderFulfillmentBatchRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3OrderFulfillmentBatchRequest** | **CreateWeb3OrderFulfillmentBatchRequest**|  | 

### Return type

**CreateWeb3OrderFulfillmentBatchResponse**

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

<a name="createweb3phygital"></a>
# **CreateWeb3Phygital**
> CreateWeb3PhygitalResponse CreateWeb3Phygital (CreateWeb3PhygitalRequest createWeb3PhygitalRequest)

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
            var createWeb3PhygitalRequest = new CreateWeb3PhygitalRequest(); // CreateWeb3PhygitalRequest | 

            try
            {
                // Make an NFT you hold redeemable for one of your physical inventory items.
                CreateWeb3PhygitalResponse result = apiInstance.CreateWeb3Phygital(createWeb3PhygitalRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3PhygitalRequest** | **CreateWeb3PhygitalRequest**|  | 

### Return type

**CreateWeb3PhygitalResponse**

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

<a name="createweb3phygitalredeem"></a>
# **CreateWeb3PhygitalRedeem**
> CreateWeb3PhygitalRedeemResponse CreateWeb3PhygitalRedeem (string id, CreateWeb3PhygitalRedeemRequest createWeb3PhygitalRedeemRequest)

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
            var createWeb3PhygitalRedeemRequest = new CreateWeb3PhygitalRedeemRequest(); // CreateWeb3PhygitalRedeemRequest | 

            try
            {
                // Redeem a phygital you hold (checked on-chain) for its physical item, with a shipping address. Once per phygital.
                CreateWeb3PhygitalRedeemResponse result = apiInstance.CreateWeb3PhygitalRedeem(id, createWeb3PhygitalRedeemRequest);
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
 **createWeb3PhygitalRedeemRequest** | **CreateWeb3PhygitalRedeemRequest**|  | 

### Return type

**CreateWeb3PhygitalRedeemResponse**

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

<a name="createweb3phygitalredemptionship"></a>
# **CreateWeb3PhygitalRedemptionShip**
> OkResponse CreateWeb3PhygitalRedemptionShip (string id, CreateWeb3PhygitalRedemptionShipRequest createWeb3PhygitalRedemptionShipRequest)

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
            var createWeb3PhygitalRedemptionShipRequest = new CreateWeb3PhygitalRedemptionShipRequest(); // CreateWeb3PhygitalRedemptionShipRequest | 

            try
            {
                // Mark a redemption shipped with its carrier and tracking number; the redeemer is notified.
                OkResponse result = apiInstance.CreateWeb3PhygitalRedemptionShip(id, createWeb3PhygitalRedemptionShipRequest);
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
 **createWeb3PhygitalRedemptionShipRequest** | **CreateWeb3PhygitalRedemptionShipRequest**|  | 

### Return type

**OkResponse**

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

<a name="createweb3raribledraft"></a>
# **CreateWeb3RaribleDraft**
> CreateWeb3RaribleDraftResponse CreateWeb3RaribleDraft (CreateWeb3RaribleDraftRequest createWeb3RaribleDraftRequest)

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
            var createWeb3RaribleDraftRequest = new CreateWeb3RaribleDraftRequest(); // CreateWeb3RaribleDraftRequest | 

            try
            {
                // Draft a Rarible V2 listing for an NFT in your linked wallet: the EIP-712 order to sign and whether Rarible's transfer proxy is approved.
                CreateWeb3RaribleDraftResponse result = apiInstance.CreateWeb3RaribleDraft(createWeb3RaribleDraftRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3RaribleDraftRequest** | **CreateWeb3RaribleDraftRequest**|  | 

### Return type

**CreateWeb3RaribleDraftResponse**

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

<a name="createweb3rariblelisting"></a>
# **CreateWeb3RaribleListing**
> OrderHashResponse CreateWeb3RaribleListing (CreateWeb3RaribleListingRequest createWeb3RaribleListingRequest)

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
            var createWeb3RaribleListingRequest = new CreateWeb3RaribleListingRequest(); // CreateWeb3RaribleListingRequest | 

            try
            {
                // Submit a signed Rarible V2 listing: the signature is verified, then the order is posted to Rarible and recorded.
                OrderHashResponse result = apiInstance.CreateWeb3RaribleListing(createWeb3RaribleListingRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3RaribleListingRequest** | **CreateWeb3RaribleListingRequest**|  | 

### Return type

**OrderHashResponse**

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

<a name="createweb3solanalisttx"></a>
# **CreateWeb3SolanaListTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaListTx (string marketplace, CreateWeb3SolanaListTxRequest createWeb3SolanaListTxRequest)

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
            var createWeb3SolanaListTxRequest = new CreateWeb3SolanaListTxRequest(); // CreateWeb3SolanaListTxRequest | 

            try
            {
                // Build an unsigned listing transaction on the Crossly book, Tensor or Magic Eden for a Solana NFT in your linked wallet.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaListTx(marketplace, createWeb3SolanaListTxRequest);
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
 **createWeb3SolanaListTxRequest** | **CreateWeb3SolanaListTxRequest**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanalisting"></a>
# **CreateWeb3SolanaListing**
> OrderHashResponse CreateWeb3SolanaListing (string marketplace, CreateWeb3SolanaListingRequest createWeb3SolanaListingRequest)

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
            var createWeb3SolanaListingRequest = new CreateWeb3SolanaListingRequest(); // CreateWeb3SolanaListingRequest | 

            try
            {
                // Record a Crossly-book, Tensor or Magic Eden listing your wallet sent (read back from the chain first).
                OrderHashResponse result = apiInstance.CreateWeb3SolanaListing(marketplace, createWeb3SolanaListingRequest);
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
 **createWeb3SolanaListingRequest** | **CreateWeb3SolanaListingRequest**|  | 

### Return type

**OrderHashResponse**

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

<a name="createweb3solanaoffer"></a>
# **CreateWeb3SolanaOffer**
> OrderHashResponse CreateWeb3SolanaOffer (CreateWeb3SolanaOfferRequest createWeb3SolanaOfferRequest)

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
            var createWeb3SolanaOfferRequest = new CreateWeb3SolanaOfferRequest(); // CreateWeb3SolanaOfferRequest | 

            try
            {
                // Record a sent bid; it is recorded only once its trade state exists on chain.
                OrderHashResponse result = apiInstance.CreateWeb3SolanaOffer(createWeb3SolanaOfferRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3SolanaOfferRequest** | **CreateWeb3SolanaOfferRequest**|  | 

### Return type

**OrderHashResponse**

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

<a name="createweb3solanaofferaccepttx"></a>
# **CreateWeb3SolanaOfferAcceptTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOfferAcceptTx (string hash, CreateWeb3SolanaOfferAcceptTxRequest createWeb3SolanaOfferAcceptTxRequest)

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
            var createWeb3SolanaOfferAcceptTxRequest = new CreateWeb3SolanaOfferAcceptTxRequest(); // CreateWeb3SolanaOfferAcceptTxRequest | 

            try
            {
                // Build the sale into a bid from your linked wallet that holds the NFT (sell + execute_sale, one transaction).
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOfferAcceptTx(hash, createWeb3SolanaOfferAcceptTxRequest);
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
 **createWeb3SolanaOfferAcceptTxRequest** | **CreateWeb3SolanaOfferAcceptTxRequest**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanaoffercanceltx"></a>
# **CreateWeb3SolanaOfferCancelTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOfferCancelTx (string hash, CreateWeb3SolanaOfferCancelTxRequest createWeb3SolanaOfferCancelTxRequest)

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
            var createWeb3SolanaOfferCancelTxRequest = new CreateWeb3SolanaOfferCancelTxRequest(); // CreateWeb3SolanaOfferCancelTxRequest | 

            try
            {
                // Build the cancel of your bid: the SOL your other bids do not need comes back.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOfferCancelTx(hash, createWeb3SolanaOfferCancelTxRequest);
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
 **createWeb3SolanaOfferCancelTxRequest** | **CreateWeb3SolanaOfferCancelTxRequest**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanaofferconfirm"></a>
# **CreateWeb3SolanaOfferConfirm**
> CreateWeb3SolanaOfferConfirmResponse CreateWeb3SolanaOfferConfirm (string hash, CreateWeb3SolanaOfferConfirmRequest createWeb3SolanaOfferConfirmRequest)

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
            var createWeb3SolanaOfferConfirmRequest = new CreateWeb3SolanaOfferConfirmRequest(); // CreateWeb3SolanaOfferConfirmRequest | 

            try
            {
                // Apply a sent accept or cancel once the chain shows the bid closed.
                CreateWeb3SolanaOfferConfirmResponse result = apiInstance.CreateWeb3SolanaOfferConfirm(hash, createWeb3SolanaOfferConfirmRequest);
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
 **createWeb3SolanaOfferConfirmRequest** | **CreateWeb3SolanaOfferConfirmRequest**|  | 

### Return type

**CreateWeb3SolanaOfferConfirmResponse**

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

<a name="createweb3solanaoffertx"></a>
# **CreateWeb3SolanaOfferTx**
> CreateWeb3SolanaOfferTxResponse CreateWeb3SolanaOfferTx (CreateWeb3SolanaOfferTxRequest createWeb3SolanaOfferTxRequest)

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
            var createWeb3SolanaOfferTxRequest = new CreateWeb3SolanaOfferTxRequest(); // CreateWeb3SolanaOfferTxRequest | 

            try
            {
                // Build a bid on a Solana NFT on Crossly's book for your linked wallet to sign; the SOL goes into your Auction House escrow.
                CreateWeb3SolanaOfferTxResponse result = apiInstance.CreateWeb3SolanaOfferTx(createWeb3SolanaOfferTxRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3SolanaOfferTxRequest** | **CreateWeb3SolanaOfferTxRequest**|  | 

### Return type

**CreateWeb3SolanaOfferTxResponse**

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

<a name="createweb3solanaorderbuytx"></a>
# **CreateWeb3SolanaOrderBuyTx**
> CreateWeb3SolanaOrderBuyTxResponse CreateWeb3SolanaOrderBuyTx (string hash, CreateWeb3SolanaOrderBuyTxRequest createWeb3SolanaOrderBuyTxRequest)

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
            var createWeb3SolanaOrderBuyTxRequest = new CreateWeb3SolanaOrderBuyTxRequest(); // CreateWeb3SolanaOrderBuyTxRequest | 

            try
            {
                // Build the unsigned transaction that buys a Solana listing (price capped at the listed price).
                CreateWeb3SolanaOrderBuyTxResponse result = apiInstance.CreateWeb3SolanaOrderBuyTx(hash, createWeb3SolanaOrderBuyTxRequest);
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
 **createWeb3SolanaOrderBuyTxRequest** | **CreateWeb3SolanaOrderBuyTxRequest**|  | 

### Return type

**CreateWeb3SolanaOrderBuyTxResponse**

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

<a name="createweb3solanaorderconfirm"></a>
# **CreateWeb3SolanaOrderConfirm**
> CreateWeb3SolanaOfferConfirmResponse CreateWeb3SolanaOrderConfirm (string hash, CreateWeb3SolanaOrderConfirmRequest createWeb3SolanaOrderConfirmRequest)

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
            var createWeb3SolanaOrderConfirmRequest = new CreateWeb3SolanaOrderConfirmRequest(); // CreateWeb3SolanaOrderConfirmRequest | 

            try
            {
                // Apply a sent Solana buy or delist to the book (the transaction is read back from the chain).
                CreateWeb3SolanaOfferConfirmResponse result = apiInstance.CreateWeb3SolanaOrderConfirm(hash, createWeb3SolanaOrderConfirmRequest);
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
 **createWeb3SolanaOrderConfirmRequest** | **CreateWeb3SolanaOrderConfirmRequest**|  | 

### Return type

**CreateWeb3SolanaOfferConfirmResponse**

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

<a name="createweb3solanaorderdelisttx"></a>
# **CreateWeb3SolanaOrderDelistTx**
> CreateWeb3SolanaListTxResponse CreateWeb3SolanaOrderDelistTx (string hash, CreateWeb3SolanaOfferCancelTxRequest createWeb3SolanaOfferCancelTxRequest)

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
            var createWeb3SolanaOfferCancelTxRequest = new CreateWeb3SolanaOfferCancelTxRequest(); // CreateWeb3SolanaOfferCancelTxRequest | 

            try
            {
                // Build the unsigned transaction that takes your Solana listing down.
                CreateWeb3SolanaListTxResponse result = apiInstance.CreateWeb3SolanaOrderDelistTx(hash, createWeb3SolanaOfferCancelTxRequest);
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
 **createWeb3SolanaOfferCancelTxRequest** | **CreateWeb3SolanaOfferCancelTxRequest**|  | 

### Return type

**CreateWeb3SolanaListTxResponse**

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

<a name="createweb3solanatensorbidconfirm"></a>
# **CreateWeb3SolanaTensorBidConfirm**
> CreateWeb3SolanaTensorBidConfirmResponse CreateWeb3SolanaTensorBidConfirm ()

After your wallet’s Tensor transaction confirms: `action` place, cancel or accept, with its `signature` and the `wallet` that signed. Checked on chain, then recorded in your Activity. Accept needs listings:write; place and cancel need buyer:offers:write.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3SolanaTensorBidConfirmExample
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
                // After your wallet’s Tensor transaction confirms: `action` place, cancel or accept, with its `signature` and the `wallet` that signed. Checked on chain, then recorded in your Activity. Accept needs listings:write; place and cancel need buyer:offers:write.
                CreateWeb3SolanaTensorBidConfirmResponse result = apiInstance.CreateWeb3SolanaTensorBidConfirm();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3SolanaTensorBidConfirm: " + e.Message );
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

**CreateWeb3SolanaTensorBidConfirmResponse**

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

<a name="createweb3stakingstake"></a>
# **CreateWeb3StakingStake**
> CreateWeb3StakingStakeResponse CreateWeb3StakingStake ()

Lock earned CBX (`baseUnits`, a string) into the best tier it reaches. 409 while a stake or unstake is in progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StakingStakeExample
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
                // Lock earned CBX (`baseUnits`, a string) into the best tier it reaches. 409 while a stake or unstake is in progress.
                CreateWeb3StakingStakeResponse result = apiInstance.CreateWeb3StakingStake();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StakingStake: " + e.Message );
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

**CreateWeb3StakingStakeResponse**

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

<a name="createweb3stakingunstake"></a>
# **CreateWeb3StakingUnstake**
> CreateWeb3StakingUnstakeResponse CreateWeb3StakingUnstake ()

Start unstaking: the earn boost stops now, the tokens release when the tier’s cooldown ends. Returns `{ unlocksAt, cooldownDays }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StakingUnstakeExample
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
                // Start unstaking: the earn boost stops now, the tokens release when the tier’s cooldown ends. Returns `{ unlocksAt, cooldownDays }`.
                CreateWeb3StakingUnstakeResponse result = apiInstance.CreateWeb3StakingUnstake();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StakingUnstake: " + e.Message );
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

**CreateWeb3StakingUnstakeResponse**

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

<a name="createweb3storewallet"></a>
# **CreateWeb3StoreWallet**
> CreateWeb3StoreWalletResponse CreateWeb3StoreWallet (CreateWeb3StoreWalletRequest createWeb3StoreWalletRequest)

Link one of your verified wallets to the store so it sells NFTs from it and is paid into it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StoreWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var createWeb3StoreWalletRequest = new CreateWeb3StoreWalletRequest(); // CreateWeb3StoreWalletRequest | 

            try
            {
                // Link one of your verified wallets to the store so it sells NFTs from it and is paid into it.
                CreateWeb3StoreWalletResponse result = apiInstance.CreateWeb3StoreWallet(createWeb3StoreWalletRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StoreWallet: " + e.Message );
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
 **createWeb3StoreWalletRequest** | **CreateWeb3StoreWalletRequest**|  | 

### Return type

**CreateWeb3StoreWalletResponse**

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

<a name="createweb3storewalletchallenge"></a>
# **CreateWeb3StoreWalletChallenge**
> CreateWeb3WalletChallengeResponse CreateWeb3StoreWalletChallenge (CreateWeb3WalletChallengeRequest createWeb3WalletChallengeRequest)

Start adding a selling wallet to the store: the message the wallet signs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StoreWalletChallengeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var createWeb3WalletChallengeRequest = new CreateWeb3WalletChallengeRequest(); // CreateWeb3WalletChallengeRequest | 

            try
            {
                // Start adding a selling wallet to the store: the message the wallet signs.
                CreateWeb3WalletChallengeResponse result = apiInstance.CreateWeb3StoreWalletChallenge(createWeb3WalletChallengeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StoreWalletChallenge: " + e.Message );
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
 **createWeb3WalletChallengeRequest** | **CreateWeb3WalletChallengeRequest**|  | 

### Return type

**CreateWeb3WalletChallengeResponse**

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

<a name="createweb3storewalletimport"></a>
# **CreateWeb3StoreWalletImport**
> CreateWeb3WalletImportResponse CreateWeb3StoreWalletImport (Guid walletId, CreateWeb3StoreWalletImportRequest createWeb3StoreWalletImportRequest)

Add picked NFTs (`tokens: [{ chain, contract, tokenId }]`) from a store wallet to inventory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StoreWalletImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 
            var createWeb3StoreWalletImportRequest = new CreateWeb3StoreWalletImportRequest(); // CreateWeb3StoreWalletImportRequest | 

            try
            {
                // Add picked NFTs (`tokens: [{ chain, contract, tokenId }]`) from a store wallet to inventory.
                CreateWeb3WalletImportResponse result = apiInstance.CreateWeb3StoreWalletImport(walletId, createWeb3StoreWalletImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StoreWalletImport: " + e.Message );
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
 **walletId** | **Guid**|  | 
 **createWeb3StoreWalletImportRequest** | **CreateWeb3StoreWalletImportRequest**|  | 

### Return type

**CreateWeb3WalletImportResponse**

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

<a name="createweb3storewalletsync"></a>
# **CreateWeb3StoreWalletSync**
> CreateWeb3StoreWalletSyncResponse CreateWeb3StoreWalletSync (Guid walletId)

Sync a store wallet: refresh its NFTs in inventory; new ones are added when the store's link auto-imports.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StoreWalletSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 

            try
            {
                // Sync a store wallet: refresh its NFTs in inventory; new ones are added when the store's link auto-imports.
                CreateWeb3StoreWalletSyncResponse result = apiInstance.CreateWeb3StoreWalletSync(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StoreWalletSync: " + e.Message );
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
 **walletId** | **Guid**|  | 

### Return type

**CreateWeb3StoreWalletSyncResponse**

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

<a name="createweb3storewalletverify"></a>
# **CreateWeb3StoreWalletVerify**
> CreateWeb3StoreWalletResponse CreateWeb3StoreWalletVerify (CreateWeb3StoreWalletVerifyRequest createWeb3StoreWalletVerifyRequest)

Finish adding a selling wallet: verify its signature and link it to the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3StoreWalletVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var createWeb3StoreWalletVerifyRequest = new CreateWeb3StoreWalletVerifyRequest(); // CreateWeb3StoreWalletVerifyRequest | 

            try
            {
                // Finish adding a selling wallet: verify its signature and link it to the store.
                CreateWeb3StoreWalletResponse result = apiInstance.CreateWeb3StoreWalletVerify(createWeb3StoreWalletVerifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3StoreWalletVerify: " + e.Message );
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
 **createWeb3StoreWalletVerifyRequest** | **CreateWeb3StoreWalletVerifyRequest**|  | 

### Return type

**CreateWeb3StoreWalletResponse**

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
> CreateWeb3TransactionResponse CreateWeb3Transaction (CreateWeb3TransactionRequest createWeb3TransactionRequest)

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
            var createWeb3TransactionRequest = new CreateWeb3TransactionRequest(); // CreateWeb3TransactionRequest | 

            try
            {
                // Apply a Seaport transaction's fills and cancels to the Crossly book (read from the receipt).
                CreateWeb3TransactionResponse result = apiInstance.CreateWeb3Transaction(createWeb3TransactionRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3TransactionRequest** | **CreateWeb3TransactionRequest**|  | 

### Return type

**CreateWeb3TransactionResponse**

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

<a name="createweb3walletchallenge"></a>
# **CreateWeb3WalletChallenge**
> CreateWeb3WalletChallengeResponse CreateWeb3WalletChallenge (CreateWeb3WalletChallengeRequest createWeb3WalletChallengeRequest)

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
            var createWeb3WalletChallengeRequest = new CreateWeb3WalletChallengeRequest(); // CreateWeb3WalletChallengeRequest | 

            try
            {
                // Start linking a wallet: returns the message the wallet must sign.
                CreateWeb3WalletChallengeResponse result = apiInstance.CreateWeb3WalletChallenge(createWeb3WalletChallengeRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3WalletChallengeRequest** | **CreateWeb3WalletChallengeRequest**|  | 

### Return type

**CreateWeb3WalletChallengeResponse**

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

<a name="createweb3walletimport"></a>
# **CreateWeb3WalletImport**
> CreateWeb3WalletImportResponse CreateWeb3WalletImport (string id)

Add picked NFTs (`tokens`: chain, contract, tokenId; up to 200) from a linked wallet to inventory. Tokens the wallet does not hold are counted in `notInWallet`, never added.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWeb3WalletImportExample
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
                // Add picked NFTs (`tokens`: chain, contract, tokenId; up to 200) from a linked wallet to inventory. Tokens the wallet does not hold are counted in `notInWallet`, never added.
                CreateWeb3WalletImportResponse result = apiInstance.CreateWeb3WalletImport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.CreateWeb3WalletImport: " + e.Message );
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

**CreateWeb3WalletImportResponse**

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
> CreateWeb3WalletVerifyResponse CreateWeb3WalletVerify (CreateWeb3WalletVerifyRequest createWeb3WalletVerifyRequest)

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
            var createWeb3WalletVerifyRequest = new CreateWeb3WalletVerifyRequest(); // CreateWeb3WalletVerifyRequest | 

            try
            {
                // Finish linking a wallet with its signature over the challenge message.
                CreateWeb3WalletVerifyResponse result = apiInstance.CreateWeb3WalletVerify(createWeb3WalletVerifyRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWeb3WalletVerifyRequest** | **CreateWeb3WalletVerifyRequest**|  | 

### Return type

**CreateWeb3WalletVerifyResponse**

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

DEPRECATED: use /api/v1/discounts/holders/:id. Remove a Collection holders deal. Returns `{ ok }`.

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
                // DEPRECATED: use /api/v1/discounts/holders/:id. Remove a Collection holders deal. Returns `{ ok }`.
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

<a name="deleteweb3launchperk"></a>
# **DeleteWeb3LaunchPerk**
> OkResponse DeleteWeb3LaunchPerk (Guid id)

Remove every collection perk of a launch. Returns `{ ok }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3LaunchPerkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Remove every collection perk of a launch. Returns `{ ok }`.
                OkResponse result = apiInstance.DeleteWeb3LaunchPerk(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3LaunchPerk: " + e.Message );
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
 **id** | **Guid**|  | 

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

<a name="deleteweb3storewallet"></a>
# **DeleteWeb3StoreWallet**
> void DeleteWeb3StoreWallet (Guid walletId)

Stop the store selling from a wallet (the wallet and its other stores are unaffected).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWeb3StoreWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 

            try
            {
                // Stop the store selling from a wallet (the wallet and its other stores are unaffected).
                apiInstance.DeleteWeb3StoreWallet(walletId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.DeleteWeb3StoreWallet: " + e.Message );
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
 **walletId** | **Guid**|  | 

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

<a name="getweb3balance"></a>
# **GetWeb3Balance**
> GetWeb3BalanceResponse GetWeb3Balance ()

Every CBX you have, in one read, with the three balances kept apart.

`credit`: EARNED (withdrawable once matured; `withdrawableBaseUnits` is earned minus anything staked) and GRANTED (in-platform spend only, never withdrawable). `connected`: headroom on your connected-wallet delegation, a ceiling on what Crossly may pull, never a balance. `wallets`: each linked wallet with its own on-chain CBX (`status` read / not_solana / not_live / unavailable). `totals.allBaseUnits` is credit + wallets and never adds the delegation headroom. Amounts are base-unit strings (`decimals`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3BalanceExample
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
                // Every CBX you have, in one read, with the three balances kept apart.
                GetWeb3BalanceResponse result = apiInstance.GetWeb3Balance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Balance: " + e.Message );
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

**GetWeb3BalanceResponse**

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
> GetWeb3BrowseResponse GetWeb3Browse (string chain = null, string category = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var category = "pfps";  // string |  (optional) 

            try
            {
                // The Web3 directory's categories and chains, with how many collections each holds.
                GetWeb3BrowseResponse result = apiInstance.GetWeb3Browse(chain, category);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 

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
> GetWeb3CollectionItemResponse GetWeb3CollectionItem (string chain, string contract, decimal? offset = null, decimal? limit = null, string q = null, string sort = null, string trait = null, bool? listed = null, string pageKey = null)

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
            var offset = 8.14D;  // decimal? |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var sort = "id";  // string |  (optional) 
            var trait = "trait_example";  // string |  (optional) 
            var listed = true;  // bool? |  (optional) 
            var pageKey = "pageKey_example";  // string |  (optional) 

            try
            {
                // A collection's NFTs: filter by traits (repeat trait=Type:Value; OR within a type, AND across), search by name or token id, sort by id, rarity or Crossly price. Whole-collection once indexed.
                GetWeb3CollectionItemResponse result = apiInstance.GetWeb3CollectionItem(chain, contract, offset, limit, q, sort, trait, listed, pageKey);
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
 **offset** | **decimal?**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **trait** | **string**|  | [optional] 
 **listed** | **bool?**|  | [optional] 
 **pageKey** | **string**|  | [optional] 

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
> GetWeb3CollectionTraitTokenResponse GetWeb3CollectionTraitToken (string chain, string contract, string type, string value)

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
            var type = "type_example";  // string | 
            var value = "value_example";  // string | 

            try
            {
                // Token ids in a collection with one trait — what a trait offer commits to.
                GetWeb3CollectionTraitTokenResponse result = apiInstance.GetWeb3CollectionTraitToken(chain, contract, type, value);
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
 **type** | **string**|  | 
 **value** | **string**|  | 

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
> GetWeb3CrosslistQuoteResponse GetWeb3CrosslistQuote (string chain, string contract, string tokenId)

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
            var chain = "ethereum";  // string | 
            var contract = "contract_example";  // string | 
            var tokenId = "tokenId_example";  // string | 

            try
            {
                // Each marketplace's terms for listing a token: Crossly fee, OpenSea required fees and zone, Tensor availability.
                GetWeb3CrosslistQuoteResponse result = apiInstance.GetWeb3CrosslistQuote(chain, contract, tokenId);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | 
 **contract** | **string**|  | 
 **tokenId** | **string**|  | 

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

<a name="getweb3launchstat"></a>
# **GetWeb3LaunchStat**
> GetWeb3LaunchStatResponse GetWeb3LaunchStat (string id)

A launch’s phase timeline, mint progress, proceeds (gross, Crossly’s cut, yours; airdrops excluded), allowlist and art counts, and recent mints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3LaunchStatExample
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
                // A launch’s phase timeline, mint progress, proceeds (gross, Crossly’s cut, yours; airdrops excluded), allowlist and art counts, and recent mints.
                GetWeb3LaunchStatResponse result = apiInstance.GetWeb3LaunchStat(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3LaunchStat: " + e.Message );
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

**GetWeb3LaunchStatResponse**

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
> GetWeb3OrderFulfillmentResponse GetWeb3OrderFulfillment (string chain, string hash, string tokenId = null)

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
            var tokenId = "tokenId_example";  // string |  (optional) 

            try
            {
                // The signed order a taker passes to Seaport, after re-checking it can still fill.
                GetWeb3OrderFulfillmentResponse result = apiInstance.GetWeb3OrderFulfillment(chain, hash, tokenId);
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
 **tokenId** | **string**|  | [optional] 

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
> GetWeb3PortfolioTaxResponse GetWeb3PortfolioTax (decimal year)

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
            var year = 8.14D;  // decimal | 

            try
            {
                // One calendar year of NFT disposals from your linked wallets as CSV text: acquired, sold, proceeds, cost basis, gain (coin and USD).
                GetWeb3PortfolioTaxResponse result = apiInstance.GetWeb3PortfolioTax(year);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **decimal**|  | 

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

<a name="getweb3staking"></a>
# **GetWeb3Staking**
> GetWeb3StakingResponse GetWeb3Staking ()

Your CBX stake: what is locked, its tier, the tier ladder and your past positions.

A stake locks EARNED CBX; it moves nothing and pays no yield. Each tier buys a withdrawal-fee discount and an earn-rate boost on future purchases, and has a cooldown before an unstake releases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3StakingExample
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
                // Your CBX stake: what is locked, its tier, the tier ladder and your past positions.
                GetWeb3StakingResponse result = apiInstance.GetWeb3Staking();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3Staking: " + e.Message );
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

**GetWeb3StakingResponse**

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

<a name="getweb3storewalletholding"></a>
# **GetWeb3StoreWalletHolding**
> GetWeb3WalletHoldingResponse GetWeb3StoreWalletHolding (Guid walletId)

What a store wallet holds (chain + contract + token id), each marked in-inventory or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3StoreWalletHoldingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 

            try
            {
                // What a store wallet holds (chain + contract + token id), each marked in-inventory or not.
                GetWeb3WalletHoldingResponse result = apiInstance.GetWeb3StoreWalletHolding(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3StoreWalletHolding: " + e.Message );
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
 **walletId** | **Guid**|  | 

### Return type

**GetWeb3WalletHoldingResponse**

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

<a name="getweb3storewalletnft"></a>
# **GetWeb3StoreWalletNft**
> GetWeb3StoreWalletNftResponse GetWeb3StoreWalletNft ()

The store's Crossly NFTs: plots (deeds and leases), streets its owner founded and vault receipt tokens in its wallets, with the wallets a plot purchase and a receipt export use.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3StoreWalletNftExample
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
                // The store's Crossly NFTs: plots (deeds and leases), streets its owner founded and vault receipt tokens in its wallets, with the wallets a plot purchase and a receipt export use.
                GetWeb3StoreWalletNftResponse result = apiInstance.GetWeb3StoreWalletNft();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3StoreWalletNft: " + e.Message );
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

**GetWeb3StoreWalletNftResponse**

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

<a name="getweb3walletholding"></a>
# **GetWeb3WalletHolding**
> GetWeb3WalletHoldingResponse GetWeb3WalletHolding (string id)

What a linked wallet holds right now, each NFT marked `inInventory` or not. Reads the chain; writes nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWeb3WalletHoldingExample
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
                // What a linked wallet holds right now, each NFT marked `inInventory` or not. Reads the chain; writes nothing.
                GetWeb3WalletHoldingResponse result = apiInstance.GetWeb3WalletHolding(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.GetWeb3WalletHolding: " + e.Message );
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

**GetWeb3WalletHoldingResponse**

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
> ListWeb3ActivityResponse ListWeb3Activity (string chain = null, string contract = null, string tokenId = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var contract = "contract_example";  // string |  (optional) 
            var tokenId = "tokenId_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Listings, offers, sales and cancels in the Crossly book, newest first.
                ListWeb3ActivityResponse result = apiInstance.ListWeb3Activity(chain, contract, tokenId, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **contract** | **string**|  | [optional] 
 **tokenId** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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
> ListWeb3AuctionsResponse ListWeb3Auctions (string chain = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Live English auctions on the Crossly book, ending soonest first, each with its top bid and the least the next bid can be.
                ListWeb3AuctionsResponse result = apiInstance.ListWeb3Auctions(chain, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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
> ListWeb3BrowseCollectionsResponse ListWeb3BrowseCollections (string chain = null, string category = null, string q = null, string sort = null, bool? listed = null, bool? verified = null, string floorMin = null, string floorMax = null, decimal? limit = null, decimal? offset = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var category = "pfps";  // string |  (optional) 
            var q = "q_example";  // string |  (optional) 
            var sort = "name";  // string |  (optional) 
            var listed = true;  // bool? |  (optional) 
            var verified = true;  // bool? |  (optional) 
            var floorMin = "floorMin_example";  // string | Floor range in the chosen chain's native coin, e.g. 0.5 (ETH); ignored without a chain. (optional) 
            var floorMax = "floorMax_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var offset = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Browse NFT collections by chain, category and name; sort hot (Crossly sales, listings, favourites), new, volume, floor or name.
                ListWeb3BrowseCollectionsResponse result = apiInstance.ListWeb3BrowseCollections(chain, category, q, sort, listed, verified, floorMin, floorMax, limit, offset);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **listed** | **bool?**|  | [optional] 
 **verified** | **bool?**|  | [optional] 
 **floorMin** | **string**| Floor range in the chosen chain&#39;s native coin, e.g. 0.5 (ETH); ignored without a chain. | [optional] 
 **floorMax** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **offset** | **decimal?**|  | [optional] 

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
> ListWeb3BrowseTokensResponse ListWeb3BrowseTokens (string chain = null, string category = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var category = "pfps";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Hot NFTs: what is for sale on Crossly first, then tokens from the hottest collections.
                ListWeb3BrowseTokensResponse result = apiInstance.ListWeb3BrowseTokens(chain, category, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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
> ListWeb3BundlesResponse ListWeb3Bundles (string chain = null, string contract = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var contract = "contract_example";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Open bundle listings (2–30 NFTs for one price), newest first, by chain or by a contract any item is from.
                ListWeb3BundlesResponse result = apiInstance.ListWeb3Bundles(chain, contract, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **contract** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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
> ListWeb3CollectionHistoryResponse ListWeb3CollectionHistory (string chain, string contract, decimal? days = null)

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
            var days = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Daily floor, sales, volume, holders and listed count for a collection, oldest first (up to 365 days).
                ListWeb3CollectionHistoryResponse result = apiInstance.ListWeb3CollectionHistory(chain, contract, days);
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
 **days** | **decimal?**|  | [optional] 

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
> ListWeb3CollectionsResponse ListWeb3Collections (string chain = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Collections ranked by 30-day Crossly volume, with floor and listed count.
                ListWeb3CollectionsResponse result = apiInstance.ListWeb3Collections(chain, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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

DEPRECATED: use /api/v1/discounts/holders. Your Collection holders deals in the old holder-perk shape, best first.

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
                // DEPRECATED: use /api/v1/discounts/holders. Your Collection holders deals in the old holder-perk shape, best first.
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

<a name="listweb3launchperks"></a>
# **ListWeb3LaunchPerks**
> ListWeb3LaunchPerksResponse ListWeb3LaunchPerks (Guid id)

The perks holders of this launch’s collection get (percent off your shop, early drop access, a World item, a loyalty tier, live early entry, an event ticket).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3LaunchPerksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // Guid | 

            try
            {
                // The perks holders of this launch’s collection get (percent off your shop, early drop access, a World item, a loyalty tier, live early entry, an event ticket).
                ListWeb3LaunchPerksResponse result = apiInstance.ListWeb3LaunchPerks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3LaunchPerks: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**ListWeb3LaunchPerksResponse**

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
> ListWeb3ListingsResponse ListWeb3Listings (string chain = null, string contract = null, string sort = null, decimal? page = null, decimal? limit = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var contract = "contract_example";  // string |  (optional) 
            var sort = "price_asc";  // string |  (optional) 
            var page = 8.14D;  // decimal? |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Open NFT listings in the Crossly book — the cheapest per token.
                ListWeb3ListingsResponse result = apiInstance.ListWeb3Listings(chain, contract, sort, page, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **contract** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **page** | **decimal?**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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

Your orders in the Crossly book (listings and offers), any status. With X-Storefront-Id: that store's listings (offers always).

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
                // Your orders in the Crossly book (listings and offers), any status. With X-Storefront-Id: that store's listings (offers always).
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
> ListWeb3RankingsResponse ListWeb3Rankings (string window = null, string chain = null, string category = null, decimal? limit = null)

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
            var window = "7d";  // string |  (optional) 
            var chain = "ethereum";  // string |  (optional) 
            var category = "pfps";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Collections by sales volume over 24h, 7d or 30d, in one coin: the ETH chains together, or Polygon / Solana on their own.
                ListWeb3RankingsResponse result = apiInstance.ListWeb3Rankings(window, chain, category, limit);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **window** | **string**|  | [optional] 
 **chain** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

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
> ListWeb3SalesResponse ListWeb3Sales (string chain = null, string category = null, decimal? limit = null, string before = null)

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
            var chain = "ethereum";  // string |  (optional) 
            var category = "pfps";  // string |  (optional) 
            var limit = 8.14D;  // decimal? |  (optional) 
            var before = "before_example";  // string |  (optional) 

            try
            {
                // The latest NFT sales across the directory, from the chain (Seaport and Blur) and the Crossly book, newest first; page with `before`.
                ListWeb3SalesResponse result = apiInstance.ListWeb3Sales(chain, category, limit, before);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chain** | **string**|  | [optional] 
 **category** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 
 **before** | **string**|  | [optional] 

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
> ListWeb3SearchResponse ListWeb3Search (string q)

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
            var q = "q_example";  // string | 

            try
            {
                // Find collections by contract address (every chain) or by name.
                ListWeb3SearchResponse result = apiInstance.ListWeb3Search(q);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | 

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
> ListWeb3SearchTokensResponse ListWeb3SearchTokens (string q)

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
            var q = "q_example";  // string | 

            try
            {
                // Find tokens by collection name and number: 'pudgy 42', 'Bored Ape #1234'.
                ListWeb3SearchTokensResponse result = apiInstance.ListWeb3SearchTokens(q);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | 

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

<a name="listweb3storewalletbalances"></a>
# **ListWeb3StoreWalletBalances**
> ListWeb3StoreWalletBalancesResponse ListWeb3StoreWalletBalances ()

The native-coin balance (SOL, ETH, POL, …) of each of the store's selling wallets, read on chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3StoreWalletBalancesExample
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
                // The native-coin balance (SOL, ETH, POL, …) of each of the store's selling wallets, read on chain.
                ListWeb3StoreWalletBalancesResponse result = apiInstance.ListWeb3StoreWalletBalances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3StoreWalletBalances: " + e.Message );
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

**ListWeb3StoreWalletBalancesResponse**

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

<a name="listweb3storewalletmarketplaces"></a>
# **ListWeb3StoreWalletMarketplaces**
> ListWeb3StoreWalletMarketplacesResponse ListWeb3StoreWalletMarketplaces ()

Each NFT marketplace's status for this store: Live only with a usable API key AND a verified store wallet of its network switched on for it. `keyMode` is `crossly` (Crossly's key, nothing to set up) or `own_key` (connect your own key).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3StoreWalletMarketplacesExample
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
                // Each NFT marketplace's status for this store: Live only with a usable API key AND a verified store wallet of its network switched on for it. `keyMode` is `crossly` (Crossly's key, nothing to set up) or `own_key` (connect your own key).
                ListWeb3StoreWalletMarketplacesResponse result = apiInstance.ListWeb3StoreWalletMarketplaces();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3StoreWalletMarketplaces: " + e.Message );
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

**ListWeb3StoreWalletMarketplacesResponse**

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

<a name="listweb3storewallets"></a>
# **ListWeb3StoreWallets**
> ListWeb3StoreWalletsResponse ListWeb3StoreWallets ()

List the store's selling wallets (X-Storefront-Id; default store when omitted).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWeb3StoreWalletsExample
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
                // List the store's selling wallets (X-Storefront-Id; default store when omitted).
                ListWeb3StoreWalletsResponse result = apiInstance.ListWeb3StoreWallets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.ListWeb3StoreWallets: " + e.Message );
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

**ListWeb3StoreWalletsResponse**

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
> UpdateWeb3HolderPerkResponse UpdateWeb3HolderPerk (UpdateWeb3HolderPerkRequest updateWeb3HolderPerkRequest)

DEPRECATED: use /api/v1/discounts/holders. Set the percent off (100–5000 bps) holders of a collection get in your store (the key’s store, else the default); one per collection.

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
            var updateWeb3HolderPerkRequest = new UpdateWeb3HolderPerkRequest(); // UpdateWeb3HolderPerkRequest | 

            try
            {
                // DEPRECATED: use /api/v1/discounts/holders. Set the percent off (100–5000 bps) holders of a collection get in your store (the key’s store, else the default); one per collection.
                UpdateWeb3HolderPerkResponse result = apiInstance.UpdateWeb3HolderPerk(updateWeb3HolderPerkRequest);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWeb3HolderPerkRequest** | **UpdateWeb3HolderPerkRequest**|  | 

### Return type

**UpdateWeb3HolderPerkResponse**

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

<a name="updateweb3launch"></a>
# **UpdateWeb3Launch**
> UpdateWeb3LaunchResponse UpdateWeb3Launch (string id)

Edit a launch draft (or a failed deploy) before it deploys: any creation field except chain and owner. The schedule is re-checked; 409 once live.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3LaunchExample
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
                // Edit a launch draft (or a failed deploy) before it deploys: any creation field except chain and owner. The schedule is re-checked; 409 once live.
                UpdateWeb3LaunchResponse result = apiInstance.UpdateWeb3Launch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3Launch: " + e.Message );
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

**UpdateWeb3LaunchResponse**

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

<a name="updateweb3launchperk"></a>
# **UpdateWeb3LaunchPerk**
> ListWeb3LaunchPerksResponse UpdateWeb3LaunchPerk (Guid id)

Replace a launch’s collection perks: `{ perks: [{ config: { type, ... }, active }] }`, one per type; a type left out is removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3LaunchPerkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Replace a launch’s collection perks: `{ perks: [{ config: { type, ... }, active }] }`, one per type; a type left out is removed.
                ListWeb3LaunchPerksResponse result = apiInstance.UpdateWeb3LaunchPerk(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3LaunchPerk: " + e.Message );
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
 **id** | **Guid**|  | 

### Return type

**ListWeb3LaunchPerksResponse**

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
> ListWeb3MarketplaceKeysItem UpdateWeb3MarketplaceKey (string marketplace, UpdateWeb3MarketplaceKeyRequest updateWeb3MarketplaceKeyRequest)

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
            var updateWeb3MarketplaceKeyRequest = new UpdateWeb3MarketplaceKeyRequest(); // UpdateWeb3MarketplaceKeyRequest | 

            try
            {
                // Save your own API key for a marketplace (checked against the marketplace first where it can be); stored encrypted.
                ListWeb3MarketplaceKeysItem result = apiInstance.UpdateWeb3MarketplaceKey(marketplace, updateWeb3MarketplaceKeyRequest);
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
 **updateWeb3MarketplaceKeyRequest** | **UpdateWeb3MarketplaceKeyRequest**|  | 

### Return type

**ListWeb3MarketplaceKeysItem**

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

<a name="updateweb3storewallet"></a>
# **UpdateWeb3StoreWallet**
> UpdateWeb3StoreWalletResponse UpdateWeb3StoreWallet (Guid walletId, UpdateWeb3StoreWalletRequest updateWeb3StoreWalletRequest)

Turn on or off whether syncing this store wallet adds new NFTs to the store’s inventory (X-Storefront-Id).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3StoreWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 
            var updateWeb3StoreWalletRequest = new UpdateWeb3StoreWalletRequest(); // UpdateWeb3StoreWalletRequest | 

            try
            {
                // Turn on or off whether syncing this store wallet adds new NFTs to the store’s inventory (X-Storefront-Id).
                UpdateWeb3StoreWalletResponse result = apiInstance.UpdateWeb3StoreWallet(walletId, updateWeb3StoreWalletRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3StoreWallet: " + e.Message );
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
 **walletId** | **Guid**|  | 
 **updateWeb3StoreWalletRequest** | **UpdateWeb3StoreWalletRequest**|  | 

### Return type

**UpdateWeb3StoreWalletResponse**

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

<a name="updateweb3storewalletdefault"></a>
# **UpdateWeb3StoreWalletDefault**
> ListWeb3StoreWalletsResponse UpdateWeb3StoreWalletDefault (Guid walletId)

Make a linked wallet the store's default selling wallet on its network (EVM or Solana).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3StoreWalletDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 

            try
            {
                // Make a linked wallet the store's default selling wallet on its network (EVM or Solana).
                ListWeb3StoreWalletsResponse result = apiInstance.UpdateWeb3StoreWalletDefault(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3StoreWalletDefault: " + e.Message );
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
 **walletId** | **Guid**|  | 

### Return type

**ListWeb3StoreWalletsResponse**

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

<a name="updateweb3storewalletmarketplace"></a>
# **UpdateWeb3StoreWalletMarketplace**
> UpdateWeb3StoreWalletResponse UpdateWeb3StoreWalletMarketplace (Guid walletId, string marketplace, EnabledRequest enabledRequest)

Switch one NFT marketplace (opensea, rarible on EVM; magic_eden, tensor on Solana) on or off for a store wallet: `{ enabled }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3StoreWalletMarketplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3Api(config);
            var walletId = "walletId_example";  // Guid | 
            var marketplace = "opensea";  // string | 
            var enabledRequest = new EnabledRequest(); // EnabledRequest | 

            try
            {
                // Switch one NFT marketplace (opensea, rarible on EVM; magic_eden, tensor on Solana) on or off for a store wallet: `{ enabled }`.
                UpdateWeb3StoreWalletResponse result = apiInstance.UpdateWeb3StoreWalletMarketplace(walletId, marketplace, enabledRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3StoreWalletMarketplace: " + e.Message );
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
 **walletId** | **Guid**|  | 
 **marketplace** | **string**|  | 
 **enabledRequest** | **EnabledRequest**|  | 

### Return type

**UpdateWeb3StoreWalletResponse**

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

<a name="updateweb3wallet"></a>
# **UpdateWeb3Wallet**
> UpdateWeb3WalletResponse UpdateWeb3Wallet (string id)

Change a linked wallet: `autoImport` (a sync adds new NFTs to inventory; off, it only refreshes the ones there) and `label`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWeb3WalletExample
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
                // Change a linked wallet: `autoImport` (a sync adds new NFTs to inventory; off, it only refreshes the ones there) and `label`.
                UpdateWeb3WalletResponse result = apiInstance.UpdateWeb3Wallet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3Api.UpdateWeb3Wallet: " + e.Message );
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

**UpdateWeb3WalletResponse**

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

