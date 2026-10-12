# net.crossly.buyer.Api.BuyerApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuyerActivity**](BuyerApi.md#createbuyeractivity) | **POST** /v1/buyer/activity | Report an item your user is looking at, and get our answer.
[**CreateBuyerAuctionBid**](BuyerApi.md#createbuyerauctionbid) | **POST** /v1/buyer/auctions/{slug}/bids | Place a bid, optionally with a proxy maximum. A WINNING BID IS CHARGED AUTOMATICALLY.
[**CreateBuyerAuctionPay**](BuyerApi.md#createbuyerauctionpay) | **POST** /v1/buyer/auctions/{slug}/pay | Pay for an auction you won whose automatic charge did not go through.
[**CreateBuyerAuctionRetract**](BuyerApi.md#createbuyerauctionretract) | **POST** /v1/buyer/auctions/{slug}/retract | Retract your bids under eBay’s rules — a typo, a changed listing, or an unreachable seller.
[**CreateBuyerBoard**](BuyerApi.md#createbuyerboard) | **POST** /v1/buyer/boards | Create an outfit board.
[**CreateBuyerBoardItem**](BuyerApi.md#createbuyerboarditem) | **POST** /v1/buyer/boards/{id}/items | Add a listing (by slug) to a board, at the next free spot.
[**CreateBuyerBreakSpotHold**](BuyerApi.md#createbuyerbreakspothold) | **POST** /v1/buyer/breaks/{id}/spots/{spotId}/hold | Hold a spot in a pick-your-spot break, then buy it through checkout before the hold lapses.
[**CreateBuyerBuybackRequest**](BuyerApi.md#createbuyerbuybackrequest) | **POST** /v1/buyer/buybacks/{id}/request | Ask Crossly to buy an item back under its buyback guarantee.
[**CreateBuyerCartItem**](BuyerApi.md#createbuyercartitem) | **POST** /v1/buyer/cart/items | Add a listing to your cart.
[**CreateBuyerCartItemSaveForLater**](BuyerApi.md#createbuyercartitemsaveforlater) | **POST** /v1/buyer/cart/items/{id}/save-for-later | Move a cart line to saved-for-later.
[**CreateBuyerCartOptimizer**](BuyerApi.md#createbuyercartoptimizer) | **POST** /v1/buyer/cart-optimizer | Cart optimizer: send a shopping list (one item per line, \&quot;2 Charizard Base Set\&quot;) and get the cheapest delivered basket across sellers — one pick per line, items + each seller’s shipping with free-shipping thresholds applied. fewestPackages prefers fewer sellers. Nothing is added to the cart.
[**CreateBuyerCartQuote**](BuyerApi.md#createbuyercartquote) | **POST** /v1/buyer/cart/quote | Price the cart, delivered — item, shipping, tax, total.
[**CreateBuyerCartSavedMoveToCart**](BuyerApi.md#createbuyercartsavedmovetocart) | **POST** /v1/buyer/cart/saved/{id}/move-to-cart | Move a saved item back into your cart, at today’s price.
[**CreateBuyerCaseCounter**](BuyerApi.md#createbuyercasecounter) | **POST** /v1/buyer/cases/{id}/counter | Propose your own refund figure on a case.
[**CreateBuyerCaseEscalate**](BuyerApi.md#createbuyercaseescalate) | **POST** /v1/buyer/cases/{id}/escalate | Ask Crossly to step in on a case.
[**CreateBuyerCaseMessage**](BuyerApi.md#createbuyercasemessage) | **POST** /v1/buyer/cases/{id}/messages | Post a message on a case thread.
[**CreateBuyerCaseRespond**](BuyerApi.md#createbuyercaserespond) | **POST** /v1/buyer/cases/{id}/respond | Accept or reject the seller’s partial-refund offer on a case.
[**CreateBuyerCaseWithdraw**](BuyerApi.md#createbuyercasewithdraw) | **POST** /v1/buyer/cases/{id}/withdraw | Withdraw a case you opened.
[**CreateBuyerCatalogListingRental**](BuyerApi.md#createbuyercataloglistingrental) | **POST** /v1/buyer/catalog/listings/{slug}/rental | Book a rental. Returns a Stripe PaymentIntent client secret for rent + shipping both ways + deposit; the dates are held 30 minutes for payment. Crossly buys both labels; the deposit comes back after the item does.
[**CreateBuyerCatalogListingRentalQuote**](BuyerApi.md#createbuyercataloglistingrentalquote) | **POST** /v1/buyer/catalog/listings/{slug}/rental/quote | Price a rental: rent (the cheaper of by-the-day and by-the-week), both shipping legs once a ship-to is given, and the deposit. &#x60;problem&#x60; says why the dates can’t be booked.
[**CreateBuyerCatalogListingVideoRequest**](BuyerApi.md#createbuyercataloglistingvideorequest) | **POST** /v1/buyer/catalog/listings/{slug}/video-requests | Ask the seller for a video of an item (one open request per item). The seller is notified; their answer appears on the listing for every buyer.
[**CreateBuyerConversationInvite**](BuyerApi.md#createbuyerconversationinvite) | **POST** /v1/buyer/conversations/{id}/invite | Invite a friend into a chat with a seller: a single-use link (7 days) that makes whoever opens it a guest who can read and post. Only the thread’s buyer can invite; at most 5 guests.
[**CreateBuyerConversationJoin**](BuyerApi.md#createbuyerconversationjoin) | **POST** /v1/buyer/conversations/join/{token} | Join a chat you were invited into, as a guest.
[**CreateBuyerFeedback**](BuyerApi.md#createbuyerfeedback) | **POST** /v1/buyer/feedback | Leave feedback on up to 25 orders at once, with optional detailed seller ratings.
[**CreateBuyerFitRef**](BuyerApi.md#createbuyerfitref) | **POST** /v1/buyer/fit/refs | Save a reference garment (flat measurements, inches) to compare listings against.
[**CreateBuyerFollowingSellerSeen**](BuyerApi.md#createbuyerfollowingsellerseen) | **POST** /v1/buyer/following/sellers/seen | Clear the \&quot;new listings\&quot; count on a followed seller, or on all of them.
[**CreateBuyerGiftCard**](BuyerApi.md#createbuyergiftcard) | **POST** /v1/buyer/gift-cards | Start a gift card purchase.
[**CreateBuyerGiftCardRedeem**](BuyerApi.md#createbuyergiftcardredeem) | **POST** /v1/buyer/gift-cards/redeem | Redeem a gift card code into your own balance.
[**CreateBuyerGroupBuyJoin**](BuyerApi.md#createbuyergroupbuyjoin) | **POST** /v1/buyer/group-buys/{id}/join | Join a group buy: a hold at the starting price, captured at the price the group reaches. Checked against this key’s spending controls; send an Idempotency-Key.
[**CreateBuyerGroupBuyLeave**](BuyerApi.md#createbuyergroupbuyleave) | **POST** /v1/buyer/group-buys/{id}/leave | Leave a group buy and release your hold.
[**CreateBuyerHunt**](BuyerApi.md#createbuyerhunt) | **POST** /v1/buyer/hunts | Start a buyer-agent hunt — over a search (filters), or auto-buy on one listing (listingSlug: buy it once its price, sale applied, is within maxPriceCents). &#x60;offer&#x60; and &#x60;buy&#x60; modes also need buyer:checkout:write, and the budget is checked against this key’s spending controls.
[**CreateBuyerInstantOfferAccept**](BuyerApi.md#createbuyerinstantofferaccept) | **POST** /v1/buyer/instant-offers/{id}/accept | Accept Crossly’s instant offer on a collection item. Ops then send a prepaid label; the store credit is paid once the item arrives and checks out.
[**CreateBuyerLayawayCancel**](BuyerApi.md#createbuyerlayawaycancel) | **POST** /v1/buyer/layaways/{id}/cancel | Cancel a layaway: everything paid comes back except the layaway fee (10% of the price, at most $15).
[**CreateBuyerLayawayPay**](BuyerApi.md#createbuyerlayawaypay) | **POST** /v1/buyer/layaways/{id}/pay | Pay some (at least $1) or all of what is left now, on the saved card. Paid in full, it ships.
[**CreateBuyerListingAudioSummary**](BuyerApi.md#createbuyerlistingaudiosummary) | **POST** /v1/buyer/listings/{slug}/audio-summary | Record the spoken summary of a listing (cached per listing version). 503 naming TTS_API_KEY when no speech provider is configured.
[**CreateBuyerListingSplit**](BuyerApi.md#createbuyerlistingsplit) | **POST** /v1/buyer/listings/{slug}/split | Split a purchase: one pay link per person; nobody is charged until all have paid.
[**CreateBuyerListingSubscribe**](BuyerApi.md#createbuyerlistingsubscribe) | **POST** /v1/buyer/listings/{slug}/subscribe | Subscribe &amp; save: a standing order charged to your saved card every interval. Checked against this key’s spending controls; send an Idempotency-Key.
[**CreateBuyerListingTryOn**](BuyerApi.md#createbuyerlistingtryon) | **POST** /v1/buyer/listings/{slug}/try-on | Render an AI try-on of this listing on the buyer’s own photo (base64 &#x60;photo&#x60;, or &#x60;reuseLastPhoto&#x60;). &#x60;confirmSelfAdult&#x60; must be true: the photo is of the buyer and they are 18+. Wearables only; capped per day; 503 naming TRYON_API_KEY when no image model is configured.
[**CreateBuyerMarketBid**](BuyerApi.md#createbuyermarketbid) | **POST** /v1/buyer/market/bids | Place a fixed-price market bid. SPENDS MONEY: it fills against the lowest ask at or under your price and charges your saved card (plus the fast-ship premium when fastShip is set and it fills from vault stock). deliverTo vault keeps it in your Crossly vault; gradeWith sends a raw card to a Grading run first. Checked against this key’s spending controls; send an Idempotency-Key.
[**CreateBuyerMarketWatch**](BuyerApi.md#createbuyermarketwatch) | **POST** /v1/buyer/market/watches | Watch a market variant: alert at or below a price, or on any drop.
[**CreateBuyerOffer**](BuyerApi.md#createbuyeroffer) | **POST** /v1/buyer/offers | Offer a price on a listing.
[**CreateBuyerOfferRespond**](BuyerApi.md#createbuyerofferrespond) | **POST** /v1/buyer/offers/{id}/respond | Answer a seller’s counteroffer — accept, decline, or counter back.
[**CreateBuyerOrderCancel**](BuyerApi.md#createbuyerordercancel) | **POST** /v1/buyer/orders/{id}/cancel | Cancel an order before it ships — refunds it in full.
[**CreateBuyerOrderInr**](BuyerApi.md#createbuyerorderinr) | **POST** /v1/buyer/orders/{id}/inr | Open an item-not-received case.
[**CreateBuyerOrderReceived**](BuyerApi.md#createbuyerorderreceived) | **POST** /v1/buyer/orders/{id}/received | Confirm you received an order.
[**CreateBuyerOrderTip**](BuyerApi.md#createbuyerordertip) | **POST** /v1/buyer/orders/{id}/tip | Tip the seller on one of your shipped orders, charged to your saved card. One tip per order; $1–$500; checked against this key’s spending controls.
[**CreateBuyerPackFairnessRotate**](BuyerApi.md#createbuyerpackfairnessrotate) | **POST** /v1/buyer/packs/fairness/rotate | Reveal your current server seed and start a new one (optionally with your own client seed). Refused while an opening is awaiting payment.
[**CreateBuyerPackOpen**](BuyerApi.md#createbuyerpackopen) | **POST** /v1/buyer/packs/{slug}/open | Open a pack. SPENDS MONEY: charges the pack price to your saved card, then pulls one real item by the published odds (provably fair: see /buyer/packs/fairness) into your Crossly vault. confirmAdult must be true. Checked against this key’s spending controls; send an Idempotency-Key.
[**CreateBuyerPackOpeningSellBack**](BuyerApi.md#createbuyerpackopeningsellback) | **POST** /v1/buyer/pack-openings/{id}/sell-back | Sell a pull straight back for Crossly credit at the pack’s buyback rate, within its window, while it is still in your vault.
[**CreateBuyerPassportClaim**](BuyerApi.md#createbuyerpassportclaim) | **POST** /v1/buyer/passports/{code}/claim | Claim a passport as the item’s current owner (the buyer of its latest sale) — shown as “in its owner’s hands” until it sells again.
[**CreateBuyerProtectionPlanCancel**](BuyerApi.md#createbuyerprotectionplancancel) | **POST** /v1/buyer/protection-plans/{id}/cancel | Cancel a protection plan. The insurer decides what is refundable (pro-rata after the free-look window); that amount goes back to the card.
[**CreateBuyerPurchaseDownload**](BuyerApi.md#createbuyerpurchasedownload) | **POST** /v1/buyer/purchases/{id}/download | A ten-minute link to a digital purchase’s file; each call uses one of its downloads.
[**CreateBuyerPurchaseFit**](BuyerApi.md#createbuyerpurchasefit) | **POST** /v1/buyer/purchases/{id}/fit | Say how a delivered purchase fit: true_to_size, small or large. It teaches your size memory and, pooled with other buyers, how the brand runs.
[**CreateBuyerPurchaseReturn**](BuyerApi.md#createbuyerpurchasereturn) | **POST** /v1/buyer/purchases/{id}/return | Return a purchase under the seller’s policy, or send back a try-at-home item. With reason doesnt_fit, &#x60;fit&#x60; (small | large) says which way, and it feeds your size memory.
[**CreateBuyerRegistry**](BuyerApi.md#createbuyerregistry) | **POST** /v1/buyer/registries | Start a gift registry (wedding, baby, birthday, housewarming, graduation, other). Items are added like any wishlist item; set shipAddressId to one of your saved addresses so guests can buy — they never see it.
[**CreateBuyerRegistryGiftThanked**](BuyerApi.md#createbuyerregistrygiftthanked) | **POST** /v1/buyer/registries/{id}/gifts/{giftId}/thanked | Tick a gift as thanked (or untick it).
[**CreateBuyerRentalArrivalPhoto**](BuyerApi.md#createbuyerrentalarrivalphoto) | **POST** /v1/buyer/rentals/{id}/arrival-photos | Photograph a rental on arrival (URLs you uploaded): your side of the condition record.
[**CreateBuyerRentalCancel**](BuyerApi.md#createbuyerrentalcancel) | **POST** /v1/buyer/rentals/{id}/cancel | Cancel a rental that has not shipped: everything is refunded.
[**CreateBuyerRentalClaimResponse**](BuyerApi.md#createbuyerrentalclaimresponse) | **POST** /v1/buyer/rentals/{id}/claim-response | Answer a deposit claim: accept (the claim is paid, the rest refunded) or dispute (Crossly decides).
[**CreateBuyerRentalIdentityStart**](BuyerApi.md#createbuyerrentalidentitystart) | **POST** /v1/buyer/rentals/identity/start | Start the ID check renting needs (Stripe Identity: photo ID + selfie). Open &#x60;url&#x60; (hosted) or use &#x60;clientSecret&#x60; with Stripe.js.
[**CreateBuyerReturnCancel**](BuyerApi.md#createbuyerreturncancel) | **POST** /v1/buyer/returns/{id}/cancel | Cancel a return before it ships.
[**CreateBuyerReturnTracking**](BuyerApi.md#createbuyerreturntracking) | **POST** /v1/buyer/returns/{id}/tracking | Add tracking to a return you shipped on your own label.
[**CreateBuyerSellerClubJoin**](BuyerApi.md#createbuyersellerclubjoin) | **POST** /v1/buyer/sellers/{sellerUserId}/club/join | Join a seller’s loyalty club (free). Your tier’s discount then applies to their items — the best of it and any other rate you have with them, never stacked.
[**CreateBuyerSellerReport**](BuyerApi.md#createbuyersellerreport) | **POST** /v1/buyer/sellers/{username}/report | Report a seller to Crossly’s trust team.
[**CreateBuyerSplitCancel**](BuyerApi.md#createbuyersplitcancel) | **POST** /v1/buyer/splits/{id}/cancel | Cancel a split you organised; every held share is released.
[**CreateBuyerTogether**](BuyerApi.md#createbuyertogether) | **POST** /v1/buyer/together | Start a shop-together room.
[**CreateBuyerTogetherItem**](BuyerApi.md#createbuyertogetheritem) | **POST** /v1/buyer/together/{code}/items | Add a listing to a shop-together board.
[**CreateBuyerTogetherItemVote**](BuyerApi.md#createbuyertogetheritemvote) | **POST** /v1/buyer/together/{code}/items/{id}/vote | Vote an item on a room’s board up (1), down (-1) or clear (0).
[**CreateBuyerTogetherJoin**](BuyerApi.md#createbuyertogetherjoin) | **POST** /v1/buyer/together/{code}/join | Join a shop-together room by its code.
[**CreateBuyerTogetherLeave**](BuyerApi.md#createbuyertogetherleave) | **POST** /v1/buyer/together/{code}/leave | Leave a shop-together room.
[**CreateBuyerTogetherMessage**](BuyerApi.md#createbuyertogethermessage) | **POST** /v1/buyer/together/{code}/messages | Say something in a shop-together room.
[**CreateBuyerTotalRequest**](BuyerApi.md#createbuyertotalrequest) | **POST** /v1/buyer/total-requests | Ask a seller for one combined shipping total on everything of theirs in your cart.
[**CreateBuyerVaultList**](BuyerApi.md#createbuyervaultlist) | **POST** /v1/buyer/vault/{id}/list | Sell a vault item on the market at your price. It is already authenticated, so when it sells nothing ships in: the buyer keeps it vaulted or it ships straight to them.
[**CreateBuyerVaultUnlist**](BuyerApi.md#createbuyervaultunlist) | **POST** /v1/buyer/vault/{id}/unlist | Take a vault item off the market; it stays stored.
[**CreateBuyerVaultWithdraw**](BuyerApi.md#createbuyervaultwithdraw) | **POST** /v1/buyer/vault/{id}/withdraw | Ship a vault item home, standard or expedited. The shipping, any storage it owes and the early-withdrawal fee (within 90 days of arriving) are charged to your saved card now, all checked against this key’s spending controls; send an Idempotency-Key.
[**CreateBuyerWishlist**](BuyerApi.md#createbuyerwishlist) | **POST** /v1/buyer/wishlists | Create a wishlist.
[**CreateBuyerWishlistInvite**](BuyerApi.md#createbuyerwishlistinvite) | **POST** /v1/buyer/wishlists/{id}/invite | Share a wishlist with a co-editor: a single-use link (14 days). Members add and remove items; only the owner renames, deletes or removes members. At most 20.
[**CreateBuyerWishlistItem**](BuyerApi.md#createbuyerwishlistitem) | **POST** /v1/buyer/wishlists/{id}/items | Add a listing to a wishlist.
[**CreateBuyerWishlistJoin**](BuyerApi.md#createbuyerwishlistjoin) | **POST** /v1/buyer/wishlists/join/{token} | Join a wishlist you were invited to edit.
[**CreateBuyerWishlistShare**](BuyerApi.md#createbuyerwishlistshare) | **POST** /v1/buyer/wishlists/{id}/share | Share a wishlist — makes it public and returns its link.
[**DeleteBuyerBoard**](BuyerApi.md#deletebuyerboard) | **DELETE** /v1/buyer/boards/{id} | Delete a board.
[**DeleteBuyerBoardItem**](BuyerApi.md#deletebuyerboarditem) | **DELETE** /v1/buyer/boards/{id}/items/{platformListingId} | Take a listing off a board.
[**DeleteBuyerBreakSpotHold**](BuyerApi.md#deletebuyerbreakspothold) | **DELETE** /v1/buyer/breaks/{id}/spots/{spotId}/hold | Release a break spot you hold.
[**DeleteBuyerCartItem**](BuyerApi.md#deletebuyercartitem) | **DELETE** /v1/buyer/cart/items/{id} | Remove a line from your cart.
[**DeleteBuyerCartSaved**](BuyerApi.md#deletebuyercartsaved) | **DELETE** /v1/buyer/cart/saved/{id} | Remove an item from saved-for-later. Returns the remaining list.
[**DeleteBuyerConversationGuest**](BuyerApi.md#deletebuyerconversationguest) | **DELETE** /v1/buyer/conversations/{id}/guests/{userId} | Remove a guest (the thread’s buyer), or leave (a guest, with your own user id).
[**DeleteBuyerFitRef**](BuyerApi.md#deletebuyerfitref) | **DELETE** /v1/buyer/fit/refs/{id} | Delete a reference garment.
[**DeleteBuyerMarketBid**](BuyerApi.md#deletebuyermarketbid) | **DELETE** /v1/buyer/market/bids/{id} | Cancel a resting market bid.
[**DeleteBuyerMarketWatch**](BuyerApi.md#deletebuyermarketwatch) | **DELETE** /v1/buyer/market/watches/{id} | Stop watching a market variant.
[**DeleteBuyerOffer**](BuyerApi.md#deletebuyeroffer) | **DELETE** /v1/buyer/offers/{id} | Withdraw an offer you made that the seller has not answered.
[**DeleteBuyerRecentlyViewed**](BuyerApi.md#deletebuyerrecentlyviewed) | **DELETE** /v1/buyer/recently-viewed/{slug} | Remove one listing from your recently viewed.
[**DeleteBuyerRecentlyViewed2**](BuyerApi.md#deletebuyerrecentlyviewed2) | **DELETE** /v1/buyer/recently-viewed | Clear your recently viewed list.
[**DeleteBuyerRegistry**](BuyerApi.md#deletebuyerregistry) | **DELETE** /v1/buyer/registries/{id} | Delete a registry (and the wishlist behind it).
[**DeleteBuyerSellerClubJoin**](BuyerApi.md#deletebuyersellerclubjoin) | **DELETE** /v1/buyer/sellers/{sellerUserId}/club/join | Leave a seller’s loyalty club.
[**DeleteBuyerTogetherItem**](BuyerApi.md#deletebuyertogetheritem) | **DELETE** /v1/buyer/together/{code}/items/{id} | Take an item you added off a room’s board.
[**DeleteBuyerTotalRequest**](BuyerApi.md#deletebuyertotalrequest) | **DELETE** /v1/buyer/total-requests/{id} | Cancel a total request you made.
[**DeleteBuyerTryOn**](BuyerApi.md#deletebuyertryon) | **DELETE** /v1/buyer/try-ons/{id} | Delete a try-on and its images — or pass &#x60;all&#x60; to delete every photo and result.
[**DeleteBuyerWishlist**](BuyerApi.md#deletebuyerwishlist) | **DELETE** /v1/buyer/wishlists/{id} | Delete a wishlist and everything on it.
[**DeleteBuyerWishlistItem**](BuyerApi.md#deletebuyerwishlistitem) | **DELETE** /v1/buyer/wishlists/{id}/items/{slug} | Take a listing off a wishlist.
[**DeleteBuyerWishlistMember**](BuyerApi.md#deletebuyerwishlistmember) | **DELETE** /v1/buyer/wishlists/{id}/members/{userId} | Remove a co-editor (the owner), or leave a list shared with you (your own user id).
[**GetBuyerAuctionMe**](BuyerApi.md#getbuyerauctionme) | **GET** /v1/buyer/auctions/{slug}/me | Where you stand in one auction — your max, leading, won, must you pay.
[**GetBuyerBadge**](BuyerApi.md#getbuyerbadge) | **GET** /v1/buyer/badges | The counts behind the account badge — unread messages, offers waiting, orders to review.
[**GetBuyerBoard**](BuyerApi.md#getbuyerboard) | **GET** /v1/buyer/boards/{id} | One of your boards with its layout: each item’s x, y and width as fractions of the board, and stacking order.
[**GetBuyerBoardShared**](BuyerApi.md#getbuyerboardshared) | **GET** /v1/buyer/boards/shared/{token} | A shared outfit board, by its link token.
[**GetBuyerBreak**](BuyerApi.md#getbuyerbreak) | **GET** /v1/buyer/breaks/{id} | A card break’s board: spots, holders, and the seed after the draw.
[**GetBuyerCase**](BuyerApi.md#getbuyercase) | **GET** /v1/buyer/cases/{id} | One case — its state, the message thread, and the return parcel if there is one.
[**GetBuyerCatalogListingMySize**](BuyerApi.md#getbuyercataloglistingmysize) | **GET** /v1/buyer/catalog/listings/{slug}/my-size | This item against your size: the size you keep in this kind of item (and in this brand), whether this one is your size, smaller or larger, a warning if this brand and size ran small or large on you before, and how other buyers say the brand runs. null for an unsized item.
[**GetBuyerCatalogListingPrice**](BuyerApi.md#getbuyercataloglistingprice) | **GET** /v1/buyer/catalog/listings/{slug}/price | The price today. When the seller has the same item live on another marketplace for less, this IS that price (&#x60;priceMatch&#x60; says where from), and &#x60;lowestAnywhere&#x60; lists the marketplaces it is guaranteed not to be cheaper on. &#x60;priceCheck&#x60; rates it against real sales of the same catalog item in the same condition over the last 180 days (great / good / fair / high, with the median and middle-half range in cents); null until there are 3+ sales from 2+ sellers.
[**GetBuyerCatalogListingRental**](BuyerApi.md#getbuyercataloglistingrental) | **GET** /v1/buyer/catalog/listings/{slug}/rental | Whether a listing is for rent: day and week rates, the refundable deposit, length limits, the turnaround buffer, and the dates already booked. null when it is not for rent.
[**GetBuyerCheckoutUsdc**](BuyerApi.md#getbuyercheckoutusdc) | **GET** /v1/buyer/checkout/usdc | Whether Crossly takes USDC (Stripe stablecoin payments: Solana, Ethereum, Base, Polygon), and its per-order limit. Paying needs the buyer’s wallet, so it happens in the browser checkout, never unattended.
[**GetBuyerCollectionOffer**](BuyerApi.md#getbuyercollectionoffer) | **GET** /v1/buyer/collection/{id}/offer | What an item in your collection would fetch now: the top open bid on the market for the same variant, condition and grade, and Crossly’s instant offer in store credit when that is switched on (a quote valid for a limited time).
[**GetBuyerCollectionSet**](BuyerApi.md#getbuyercollectionset) | **GET** /v1/buyer/collection/sets/{category}/{brand}/{model} | One set: every piece (owned or missing, with its lowest ask on the market), what completing it would cost now, and the leaderboard of collectors who opted in, with your rank.
[**GetBuyerCreator**](BuyerApi.md#getbuyercreator) | **GET** /v1/buyer/creators/{handle} | A creator storefront: profile, affiliate code, and shelves of live picks.
[**GetBuyerFitVocabulary**](BuyerApi.md#getbuyerfitvocabulary) | **GET** /v1/buyer/fit/vocabulary | Garment kinds and the measurements each takes.
[**GetBuyerGiftFinderOption**](BuyerApi.md#getbuyergiftfinderoption) | **GET** /v1/buyer/gift-finder/options | The gift finder’s questions: recipients, interests, budgets.
[**GetBuyerImpact**](BuyerApi.md#getbuyerimpact) | **GET** /v1/buyer/impact | The sourced footprint your secondhand purchases avoided.
[**GetBuyerLayaway**](BuyerApi.md#getbuyerlayaway) | **GET** /v1/buyer/layaways/{id} | One layaway and its schedule.
[**GetBuyerListingAudioSummary**](BuyerApi.md#getbuyerlistingaudiosummary) | **GET** /v1/buyer/listings/{slug}/audio-summary | A spoken summary of a listing (accessibility): the text, built only from the listing’s own fields and the seller’s description, and the recording of it when one exists.
[**GetBuyerListingBoughtTogether**](BuyerApi.md#getbuyerlistingboughttogether) | **GET** /v1/buyer/listings/{slug}/bought-together | Frequently bought together / complete the look.
[**GetBuyerListingBreak**](BuyerApi.md#getbuyerlistingbreak) | **GET** /v1/buyer/listings/{slug}/break | The card break this listing sells spots in, if any; the seed is revealed after the draw.
[**GetBuyerListingCert**](BuyerApi.md#getbuyerlistingcert) | **GET** /v1/buyer/listings/{slug}/cert | A graded listing’s cert, checked with the grader: the seller’s claim (grader, grade, cert number), status (verified, mismatch, not_found, or unchecked where the grader has no lookup), population and how many graded higher where the grader publishes them, and the grader’s own cert page.
[**GetBuyerListingFit**](BuyerApi.md#getbuyerlistingfit) | **GET** /v1/buyer/listings/{slug}/fit | A listing’s flat measurements, compared with your saved reference garments.
[**GetBuyerListingGroupBuy**](BuyerApi.md#getbuyerlistinggroupbuy) | **GET** /v1/buyer/listings/{slug}/group-buy | The group buy open on this listing, if any.
[**GetBuyerListingImpact**](BuyerApi.md#getbuyerlistingimpact) | **GET** /v1/buyer/listings/{slug}/impact | The sourced footprint of making a new equivalent; null when no published figure applies.
[**GetBuyerListingResaleValue**](BuyerApi.md#getbuyerlistingresalevalue) | **GET** /v1/buyer/listings/{slug}/resale-value | What the same brand and category resold for on Crossly, and the buyback offer when enabled.
[**GetBuyerListingSubscribeOffer**](BuyerApi.md#getbuyerlistingsubscribeoffer) | **GET** /v1/buyer/listings/{slug}/subscribe-offer | The subscribe &amp; save discount and intervals on a listing; null when the seller has none.
[**GetBuyerListingTryOn**](BuyerApi.md#getbuyerlistingtryon) | **GET** /v1/buyer/listings/{slug}/try-on | Whether an AI try-on is offered for this listing (a wearable with a photo) and whether the image model is configured.
[**GetBuyerLiveStreamAuction**](BuyerApi.md#getbuyerlivestreamauction) | **GET** /v1/buyer/live-streams/{id}/auction | The auction running on a live stream right now, if any. Bid on it by its &#x60;slug&#x60; at POST /v1/buyer/auctions/:slug/bids.
[**GetBuyerMarketPurchaseOption**](BuyerApi.md#getbuyermarketpurchaseoption) | **GET** /v1/buyer/market/purchase-options | Before you bid or buy: whether the lowest ask is vault stock (keep it vaulted, or pay fastShipCents to rush it), and the grading runs a raw card can go straight to (pass gradeWith on the bid).
[**GetBuyerOrderEligibility**](BuyerApi.md#getbuyerordereligibility) | **GET** /v1/buyer/orders/{id}/eligibility | What you can do with one order right now — cancel, confirm receipt, report not received, leave feedback.
[**GetBuyerOrderExport**](BuyerApi.md#getbuyerorderexport) | **GET** /v1/buyer/orders/export | Your order history as CSV text (up to 5,000 orders).
[**GetBuyerOrderPriceProtection**](BuyerApi.md#getbuyerorderpriceprotection) | **GET** /v1/buyer/orders/{id}/price-protection | Price protection on one order: if the item gets cheaper before &#x60;until&#x60;, the difference is credited to your Bucks automatically. &#x60;creditedCents&#x60; is what it has paid so far.
[**GetBuyerPack**](BuyerApi.md#getbuyerpack) | **GET** /v1/buyer/packs/{slug} | One pack: tiers and odds, items left, expected value, the chase items still in it.
[**GetBuyerPackFairness**](BuyerApi.md#getbuyerpackfairness) | **GET** /v1/buyer/packs/fairness | Your provably-fair seeds: the active server-seed commitment (sha256), your client seed and nonce, and every retired seed in full so past openings can be re-run.
[**GetBuyerParty**](BuyerApi.md#getbuyerparty) | **GET** /v1/buyer/parties/{slug} | One shopping party.
[**GetBuyerPassport**](BuyerApi.md#getbuyerpassport) | **GET** /v1/buyer/passports/{code} | What a product passport tag opens: the item, whether it was authenticated, how many owners on Crossly and since when — never who or for how much.
[**GetBuyerPreference**](BuyerApi.md#getbuyerpreference) | **GET** /v1/buyer/preferences | The shopping profile derived from that activity.
[**GetBuyerPriceGuide**](BuyerApi.md#getbuyerpriceguide) | **GET** /v1/buyer/price-guide | What matching items actually sold for on Crossly: median, quartiles, by month, and recent sales. Needs q, brand or category.
[**GetBuyerProfile**](BuyerApi.md#getbuyerprofile) | **GET** /v1/buyer/profile | Your Crossly shopping profile — name, email, saved address, Bucks balance.
[**GetBuyerPurchaseDelivery**](BuyerApi.md#getbuyerpurchasedelivery) | **GET** /v1/buyer/purchases/{id}/delivery | Where a purchase is going when not to your door: the pickup point (with its release code) or its ship-together consolidation.
[**GetBuyerPurchaseLiveMoment**](BuyerApi.md#getbuyerpurchaselivemoment) | **GET** /v1/buyer/purchases/{id}/live-moment | The live show a purchase was bought in, with the offset (seconds) into its replay where it sold. null when it was not bought in a show.
[**GetBuyerPurchaseReturn**](BuyerApi.md#getbuyerpurchasereturn) | **GET** /v1/buyer/purchases/{id}/return | What a return would refund for each reason, by when, and any return already open.
[**GetBuyerPurchaseStory**](BuyerApi.md#getbuyerpurchasestory) | **GET** /v1/buyer/purchases/{id}/story | Your owner story on a purchase, passed on to the next owner if you resell it.
[**GetBuyerRegistry**](BuyerApi.md#getbuyerregistry) | **GET** /v1/buyer/registries/{id} | One of your registries: items with how many are wanted and bought.
[**GetBuyerRegistryByToken**](BuyerApi.md#getbuyerregistrybytoken) | **GET** /v1/buyer/registry/{token} | A registry as a guest sees it: items, how many are still wanted, and whether it can ship. Never the address.
[**GetBuyerRentalEligibility**](BuyerApi.md#getbuyerrentaleligibility) | **GET** /v1/buyer/rentals/eligibility | Can you rent right now: ID-verified (a photo ID and a matching selfie, once), the verified name rentals ship to, and your standing (one rental at a time until your first comes back; none after one that never did).
[**GetBuyerSellerClub**](BuyerApi.md#getbuyersellerclub) | **GET** /v1/buyer/sellers/{sellerUserId}/club | A seller’s loyalty club: its tiers (spend threshold, discount, perks) and your standing. null when the seller has none.
[**GetBuyerSellerTrust**](BuyerApi.md#getbuyersellertrust) | **GET** /v1/buyer/sellers/{username}/trust | Seller at a glance: member since, completed sales, independent rating, typical handling time, dispute rate, trust tier, badges — and the plain sentences the profile shows.
[**GetBuyerTogether**](BuyerApi.md#getbuyertogether) | **GET** /v1/buyer/together/{code} | A shop-together room: members, the board with votes, and chat.
[**GetBuyerVaultMarketHistory**](BuyerApi.md#getbuyervaultmarkethistory) | **GET** /v1/buyer/vault-markets/history | Your Vault Markets value by day at the marks (oldest first, today live) over &#x60;days&#x60; (default 90), and today’s change against yesterday’s close.
[**GetBuyerVaultMarketIndex**](BuyerApi.md#getbuyervaultmarketindex) | **GET** /v1/buyer/vault-markets/indexes/{slug} | One index with its published daily closes (oldest first, &#x60;days&#x60; default 365) and its level now.
[**GetBuyerVaultMarketInstantExit**](BuyerApi.md#getbuyervaultmarketinstantexit) | **GET** /v1/buyer/vault-markets/instant-exit/{id} | The Instant Exit quote for one vault unit you hold, and whether it can be sold now.
[**GetBuyerVaultMarketWorth**](BuyerApi.md#getbuyervaultmarketworth) | **GET** /v1/buyer/vault-markets/worth | What your vault is worth now: value at the market prices (marks come only from trades) split into reliable and indicative marks, cost and P&amp;L, today’s change, and an estimate of what the units free to sell would fetch from the bids resting on the book now. Read only.
[**ListBuyerActivity**](BuyerApi.md#listbuyeractivity) | **GET** /v1/buyer/activity | What this buyer has compared lately.
[**ListBuyerAuctionBids**](BuyerApi.md#listbuyerauctionbids) | **GET** /v1/buyer/auctions/{slug}/bids | An auction’s bid history, highest first, bidders anonymised.
[**ListBuyerAuctions**](BuyerApi.md#listbuyerauctions) | **GET** /v1/buyer/auctions | Auctions you have bid in — bidding, won or lost (last 100).
[**ListBuyerBoards**](BuyerApi.md#listbuyerboards) | **GET** /v1/buyer/boards | Your outfit boards: collages of listings, each with a share link.
[**ListBuyerBreaks**](BuyerApi.md#listbuyerbreaks) | **GET** /v1/buyer/breaks | Card-break spots you hold or bought, with what each pulled.
[**ListBuyerBuybacks**](BuyerApi.md#listbuyerbuybacks) | **GET** /v1/buyer/buybacks | Your buyback guarantees and requests.
[**ListBuyerCart**](BuyerApi.md#listbuyercart) | **GET** /v1/buyer/cart | What is in your Crossly cart.
[**ListBuyerCartSaved**](BuyerApi.md#listbuyercartsaved) | **GET** /v1/buyer/cart/saved | Items you saved for later out of your cart (last 200).
[**ListBuyerCases**](BuyerApi.md#listbuyercases) | **GET** /v1/buyer/cases | Resolution center — every case you opened (returns, not received, problems).
[**ListBuyerCashback**](BuyerApi.md#listbuyercashback) | **GET** /v1/buyer/cashback | Your Scout cashback — pending, confirmed, paid.
[**ListBuyerCatalogListingVideos**](BuyerApi.md#listbuyercataloglistingvideos) | **GET** /v1/buyer/catalog/listings/{slug}/videos | Videos the seller recorded for this item on request, newest first, with the question each one answers.
[**ListBuyerClubs**](BuyerApi.md#listbuyerclubs) | **GET** /v1/buyer/clubs | Sellers’ loyalty clubs you belong to: your spend with each, your tier and its discount, and the next tier.
[**ListBuyerCollectionSets**](BuyerApi.md#listbuyercollectionsets) | **GET** /v1/buyer/collection/sets | Sets you are collecting — a catalogue brand + model you own at least two pieces of — with owned / total and percent complete, most complete first; and whether you show on set leaderboards.
[**ListBuyerConsolidations**](BuyerApi.md#listbuyerconsolidations) | **GET** /v1/buyer/consolidations | Your ship-together orders: parcels at the hub, and the one box out.
[**ListBuyerConversationGuests**](BuyerApi.md#listbuyerconversationguests) | **GET** /v1/buyer/conversations/{id}/guests | Guests in a chat.
[**ListBuyerFeedback**](BuyerApi.md#listbuyerfeedback) | **GET** /v1/buyer/feedback | Feedback you have left sellers, newest first — with the ids you revise by.
[**ListBuyerFeedbackPending**](BuyerApi.md#listbuyerfeedbackpending) | **GET** /v1/buyer/feedback/pending | Orders from the last 60 days that are on their way or arrived and still need your feedback.
[**ListBuyerFitRefs**](BuyerApi.md#listbuyerfitrefs) | **GET** /v1/buyer/fit/refs | Your saved reference garments for fit comparison.
[**ListBuyerFollowingSellers**](BuyerApi.md#listbuyerfollowingsellers) | **GET** /v1/buyer/following/sellers | Sellers you follow, with how many new listings each has since you last looked.
[**ListBuyerGiftCardCredit**](BuyerApi.md#listbuyergiftcardcredit) | **GET** /v1/buyer/gift-cards/credit | Gift card credit on your account, and when it expires.
[**ListBuyerGiftCards**](BuyerApi.md#listbuyergiftcards) | **GET** /v1/buyer/gift-cards | Gift cards you bought, newest first.
[**ListBuyerGiftFinder**](BuyerApi.md#listbuyergiftfinder) | **GET** /v1/buyer/gift-finder | Live listings for a recipient, interest and budget.
[**ListBuyerGiftSent**](BuyerApi.md#listbuyergiftsent) | **GET** /v1/buyer/gifts/sent | Items you sent as gifts: whether the teaser went out, whether it arrived and was opened, and any thank-you. Send one with &#x60;gift&#x60; on checkout.
[**ListBuyerHotspots**](BuyerApi.md#listbuyerhotspots) | **GET** /v1/buyer/hotspots | Shop-the-look tags on a story or lookbook photo: each tagged listing and where it sits on the image (x, y as fractions).
[**ListBuyerHunts**](BuyerApi.md#listbuyerhunts) | **GET** /v1/buyer/hunts | Your buyer-agent hunts and what they did.
[**ListBuyerInstantOffers**](BuyerApi.md#listbuyerinstantoffers) | **GET** /v1/buyer/instant-offers | Your instant offers: live quotes, accepted ones awaiting a label, approved ones (with the prepaid label) and paid ones.
[**ListBuyerLayaways**](BuyerApi.md#listbuyerlayaways) | **GET** /v1/buyer/layaways | Your layaways: price, paid so far, what is left, and the installment schedule. Put an item on layaway at checkout with layawayItemIds.
[**ListBuyerListingQuickQuestions**](BuyerApi.md#listbuyerlistingquickquestions) | **GET** /v1/buyer/listings/{slug}/quick-questions | One-tap questions this listing supports; send one as &#x60;quick&#x60; on a message.
[**ListBuyerListingSellerReviews**](BuyerApi.md#listbuyerlistingsellerreviews) | **GET** /v1/buyer/listings/{slug}/seller-reviews | The seller’s public reviews: summary, text, photos, replies.
[**ListBuyerLiveShipments**](BuyerApi.md#listbuyerliveshipments) | **GET** /v1/buyer/live-shipments | Your one-box-per-show shipments: every order won in a show ships together, and postage is charged once (the rest refunded when it ships).
[**ListBuyerLiveStreamLineup**](BuyerApi.md#listbuyerlivestreamlineup) | **GET** /v1/buyer/live-streams/{id}/lineup | What a live show will sell, in order: each item, its price, and whether it is still available.
[**ListBuyerMarketBids**](BuyerApi.md#listbuyermarketbids) | **GET** /v1/buyer/market/bids | Your resting market bids.
[**ListBuyerMarketWatches**](BuyerApi.md#listbuyermarketwatches) | **GET** /v1/buyer/market/watches | Market variants you watch, with the price you are waiting for.
[**ListBuyerOffers**](BuyerApi.md#listbuyeroffers) | **GET** /v1/buyer/offers | Offers you have made, newest first (last 100).
[**ListBuyerOrders**](BuyerApi.md#listbuyerorders) | **GET** /v1/buyer/orders | What you have bought on Crossly, newest first.
[**ListBuyerPackOpenings**](BuyerApi.md#listbuyerpackopenings) | **GET** /v1/buyer/pack-openings | Your pulls: what you got, its value, sell-back status, and the fairness proof for each (the server seed once rotated).
[**ListBuyerPacks**](BuyerApi.md#listbuyerpacks) | **GET** /v1/buyer/packs | Packs you can open: price, every tier with its published odds, what is left in it and its value range, and the expected value of one opening.
[**ListBuyerParties**](BuyerApi.md#listbuyerparties) | **GET** /v1/buyer/parties | Themed shopping parties, live and upcoming.
[**ListBuyerPartyListings**](BuyerApi.md#listbuyerpartylistings) | **GET** /v1/buyer/parties/{slug}/listings | Listings shared to a party, featured first.
[**ListBuyerPickupPoints**](BuyerApi.md#listbuyerpickuppoints) | **GET** /v1/buyer/pickup-points | Carrier pickup points (UPS Access Point / FedEx Hold at Location) near an address; pass one as &#x60;pickupPoint&#x60; to POST /v1/buyer/checkout.
[**ListBuyerProtectionPlans**](BuyerApi.md#listbuyerprotectionplans) | **GET** /v1/buyer/protection-plans | Your protection plans (bought at checkout with &#x60;protection&#x60;): status, term, coverage, contract id, and any refund.
[**ListBuyerRegistries**](BuyerApi.md#listbuyerregistries) | **GET** /v1/buyer/registries | Your gift registries.
[**ListBuyerRegistryGifts**](BuyerApi.md#listbuyerregistrygifts) | **GET** /v1/buyer/registries/{id}/gifts | Your thank-you list: who bought what off the registry, and whether you have thanked them.
[**ListBuyerRegistrySearch**](BuyerApi.md#listbuyerregistrysearch) | **GET** /v1/buyer/registries/search | Find a registry by its name or the registrant’s name. Current and recent registries only.
[**ListBuyerRentals**](BuyerApi.md#listbuyerrentals) | **GET** /v1/buyer/rentals | Your rentals: dates, status (reserved, out, returned, claimed, closed, cancelled), the return label, and what happened to the deposit.
[**ListBuyerSizeMemoryPrompts**](BuyerApi.md#listbuyersizememoryprompts) | **GET** /v1/buyer/size-memory/prompts | Delivered orders with a size that you haven’t said how they fit (the last 60 days).
[**ListBuyerSizeMemorySizes**](BuyerApi.md#listbuyersizememorysizes) | **GET** /v1/buyer/size-memory/sizes | The sizes learned from what you bought and kept, by kind of item (shoes, tops, bottoms, dresses, outerwear) and department.
[**ListBuyerSplits**](BuyerApi.md#listbuyersplits) | **GET** /v1/buyer/splits | Purchases you split, with each share’s status.
[**ListBuyerSubscriptions**](BuyerApi.md#listbuyersubscriptions) | **GET** /v1/buyer/subscriptions | Your subscribe &amp; save standing orders.
[**ListBuyerTogether**](BuyerApi.md#listbuyertogether) | **GET** /v1/buyer/together | Shop-together rooms you are in.
[**ListBuyerTotalRequests**](BuyerApi.md#listbuyertotalrequests) | **GET** /v1/buyer/total-requests | Your combined-shipping total requests, newest per seller.
[**ListBuyerTryOns**](BuyerApi.md#listbuyertryons) | **GET** /v1/buyer/try-ons | Your AI try-ons: the rendered images (labelled AI-generated wherever shown).
[**ListBuyerVault**](BuyerApi.md#listbuyervault) | **GET** /v1/buyer/vault | What you own in the Crossly vault: stored (authenticated, on a shelf), listed for sale, or on its way home — with the price to ship one home.
[**ListBuyerVaultMarketHoldings**](BuyerApi.md#listbuyervaultmarketholdings) | **GET** /v1/buyer/vault-markets/holdings | Each unit you hold in the vault at its market price, with the mark’s quality (A or B reliable, C indicative, none), cost, P&amp;L and where it stands (stored, listed, lent, pledged, at the grader); &#x60;meta&#x60; carries the totals and the units you have out on loan.
[**ListBuyerVaultMarketIndexes**](BuyerApi.md#listbuyervaultmarketindexes) | **GET** /v1/buyer/vault-markets/indexes | Crossly indexes over vault book keys (category, brand, curated, composite, segment, and your own), each with its level now and change since the last daily close. Index levels are valued only from the book’s marks.
[**ListBuyerVaultMarketInstantExit**](BuyerApi.md#listbuyervaultmarketinstantexit) | **GET** /v1/buyer/vault-markets/instant-exit | Instant Exit quotes for what you hold, one per book key: the best resting bid (yours left out), its share of the mark, the bid levels, units held and which are free to sell, and why a key cannot be sold instantly. A quote, not an order.
[**ListBuyerVaultMarketWatchlist**](BuyerApi.md#listbuyervaultmarketwatchlist) | **GET** /v1/buyer/vault-markets/watchlist | The book keys you watch, with mark and its quality, 24 h and 7 d change, and the last 30 daily marks.
[**ListBuyerVideoRequests**](BuyerApi.md#listbuyervideorequests) | **GET** /v1/buyer/video-requests | Your video requests and their answers.
[**ListBuyerWishlistItems**](BuyerApi.md#listbuyerwishlistitems) | **GET** /v1/buyer/wishlists/{id}/items | What is on one wishlist.
[**ListBuyerWishlistMembers**](BuyerApi.md#listbuyerwishlistmembers) | **GET** /v1/buyer/wishlists/{id}/members | Co-editors of a shared wishlist.
[**ListBuyerWishlists**](BuyerApi.md#listbuyerwishlists) | **GET** /v1/buyer/wishlists | Your wishlists.
[**UpdateBuyerBoard**](BuyerApi.md#updatebuyerboard) | **PATCH** /v1/buyer/boards/{id} | Rename a board, change its description, or make it public / private.
[**UpdateBuyerBoardLayout**](BuyerApi.md#updatebuyerboardlayout) | **PUT** /v1/buyer/boards/{id}/layout | Replace a board’s layout: items by platform listing id or slug, with x, y, w (0–1) and z. At most 40.
[**UpdateBuyerCollectionSetLeaderboard**](BuyerApi.md#updatebuyercollectionsetleaderboard) | **PUT** /v1/buyer/collection/sets/leaderboard | Show or hide yourself (by your public handle) on set leaderboards.
[**UpdateBuyerFeedback**](BuyerApi.md#updatebuyerfeedback) | **PATCH** /v1/buyer/feedback/{id} | Revise feedback you left, within 60 days.
[**UpdateBuyerHunt**](BuyerApi.md#updatebuyerhunt) | **PATCH** /v1/buyer/hunts/{id} | Pause, resume or stop a hunt.
[**UpdateBuyerPurchaseStory**](BuyerApi.md#updatebuyerpurchasestory) | **PUT** /v1/buyer/purchases/{id}/story | Write your owner story (280 characters); it travels with the item if you resell it.
[**UpdateBuyerRegistry**](BuyerApi.md#updatebuyerregistry) | **PATCH** /v1/buyer/registries/{id} | Edit a registry: title, kind, date, message, ship-to address.
[**UpdateBuyerRegistryItem**](BuyerApi.md#updatebuyerregistryitem) | **PUT** /v1/buyer/registries/{id}/items/{platformListingId} | How many of an item you want (1–50).
[**UpdateBuyerSubscription**](BuyerApi.md#updatebuyersubscription) | **PATCH** /v1/buyer/subscriptions/{id} | Pause, resume, skip the next delivery, change the interval, or cancel.
[**UpdateBuyerWishlist**](BuyerApi.md#updatebuyerwishlist) | **PATCH** /v1/buyer/wishlists/{id} | Rename a wishlist, or make it public / private.


<a name="createbuyeractivity"></a>
# **CreateBuyerActivity**
> CreateBuyerActivityResponse CreateBuyerActivity (CreateBuyerActivityRequest createBuyerActivityRequest)

Report an item your user is looking at, and get our answer.

Records the look and returns whether Crossly has the item and at what price. Send an identifier and a store DOMAIN — a full URL is refused. Nothing about the page itself is stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerActivityRequest = new CreateBuyerActivityRequest(); // CreateBuyerActivityRequest | 

            try
            {
                // Report an item your user is looking at, and get our answer.
                CreateBuyerActivityResponse result = apiInstance.CreateBuyerActivity(createBuyerActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerActivity: " + e.Message );
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
 **createBuyerActivityRequest** | **CreateBuyerActivityRequest**|  | 

### Return type

**CreateBuyerActivityResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerauctionbid"></a>
# **CreateBuyerAuctionBid**
> CreateBuyerAuctionBidResponse CreateBuyerAuctionBid (string slug, CreateBuyerAuctionBidRequest createBuyerAuctionBidRequest)

Place a bid, optionally with a proxy maximum. A WINNING BID IS CHARGED AUTOMATICALLY.

Spends money: if you win, your saved card is charged when the auction closes, with nobody present. Requires buyer:checkout:write AND this key switched on at PUT /v1/buyer/checkout/controls; the bid’s maximum (or amount) is checked against the key’s per-order and daily ceilings. Amounts are integer cents. `leading: false` means a standing proxy bid outbid you at once. Send an Idempotency-Key: a retried bid is a second bid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAuctionBidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The auction listing slug.
            var createBuyerAuctionBidRequest = new CreateBuyerAuctionBidRequest(); // CreateBuyerAuctionBidRequest | 

            try
            {
                // Place a bid, optionally with a proxy maximum. A WINNING BID IS CHARGED AUTOMATICALLY.
                CreateBuyerAuctionBidResponse result = apiInstance.CreateBuyerAuctionBid(slug, createBuyerAuctionBidRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerAuctionBid: " + e.Message );
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
 **slug** | **string**| The auction listing slug. | 
 **createBuyerAuctionBidRequest** | **CreateBuyerAuctionBidRequest**|  | 

### Return type

**CreateBuyerAuctionBidResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerauctionpay"></a>
# **CreateBuyerAuctionPay**
> CreateBuyerAuctionPayResponse CreateBuyerAuctionPay (string slug)

Pay for an auction you won whose automatic charge did not go through.

Returns a Stripe client secret to confirm on the buyer’s device (3-D Secure, a new card). Charges nothing by itself. `paid: true` means there is nothing left to pay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAuctionPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The auction listing slug.

            try
            {
                // Pay for an auction you won whose automatic charge did not go through.
                CreateBuyerAuctionPayResponse result = apiInstance.CreateBuyerAuctionPay(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerAuctionPay: " + e.Message );
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
 **slug** | **string**| The auction listing slug. | 

### Return type

**CreateBuyerAuctionPayResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerauctionretract"></a>
# **CreateBuyerAuctionRetract**
> CreateBuyerAuctionRetractResponse CreateBuyerAuctionRetract (string slug, CreateBuyerAuctionRetractRequest createBuyerAuctionRetractRequest)

Retract your bids under eBay’s rules — a typo, a changed listing, or an unreachable seller.

With 12 hours or more left every bid of yours is withdrawn; inside 12 hours only bids placed in the last hour. Proxy answers your bid triggered are withdrawn with it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerAuctionRetractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The auction listing slug.
            var createBuyerAuctionRetractRequest = new CreateBuyerAuctionRetractRequest(); // CreateBuyerAuctionRetractRequest | 

            try
            {
                // Retract your bids under eBay’s rules — a typo, a changed listing, or an unreachable seller.
                CreateBuyerAuctionRetractResponse result = apiInstance.CreateBuyerAuctionRetract(slug, createBuyerAuctionRetractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerAuctionRetract: " + e.Message );
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
 **slug** | **string**| The auction listing slug. | 
 **createBuyerAuctionRetractRequest** | **CreateBuyerAuctionRetractRequest**|  | 

### Return type

**CreateBuyerAuctionRetractResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerboard"></a>
# **CreateBuyerBoard**
> CreateBuyerBoardResponse CreateBuyerBoard ()

Create an outfit board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Create an outfit board.
                CreateBuyerBoardResponse result = apiInstance.CreateBuyerBoard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerBoard: " + e.Message );
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

**CreateBuyerBoardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerboarditem"></a>
# **CreateBuyerBoardItem**
> BuyerResponse CreateBuyerBoardItem (string id)

Add a listing (by slug) to a board, at the next free spot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerBoardItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Add a listing (by slug) to a board, at the next free spot.
                BuyerResponse result = apiInstance.CreateBuyerBoardItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerBoardItem: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerbreakspothold"></a>
# **CreateBuyerBreakSpotHold**
> CreateBuyerBreakSpotHoldResponse CreateBuyerBreakSpotHold (string id, string spotId)

Hold a spot in a pick-your-spot break, then buy it through checkout before the hold lapses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerBreakSpotHoldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var spotId = "spotId_example";  // string | 

            try
            {
                // Hold a spot in a pick-your-spot break, then buy it through checkout before the hold lapses.
                CreateBuyerBreakSpotHoldResponse result = apiInstance.CreateBuyerBreakSpotHold(id, spotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerBreakSpotHold: " + e.Message );
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
 **spotId** | **string**|  | 

### Return type

**CreateBuyerBreakSpotHoldResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerbuybackrequest"></a>
# **CreateBuyerBuybackRequest**
> BuyerResponse CreateBuyerBuybackRequest (string id)

Ask Crossly to buy an item back under its buyback guarantee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerBuybackRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Ask Crossly to buy an item back under its buyback guarantee.
                BuyerResponse result = apiInstance.CreateBuyerBuybackRequest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerBuybackRequest: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercartitem"></a>
# **CreateBuyerCartItem**
> CreateBuyerCartItemResponse CreateBuyerCartItem (CreateBuyerCartItemRequest createBuyerCartItemRequest)

Add a listing to your cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCartItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerCartItemRequest = new CreateBuyerCartItemRequest(); // CreateBuyerCartItemRequest | 

            try
            {
                // Add a listing to your cart.
                CreateBuyerCartItemResponse result = apiInstance.CreateBuyerCartItem(createBuyerCartItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCartItem: " + e.Message );
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
 **createBuyerCartItemRequest** | **CreateBuyerCartItemRequest**|  | 

### Return type

**CreateBuyerCartItemResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyercartitemsaveforlater"></a>
# **CreateBuyerCartItemSaveForLater**
> BuyerCartResponse CreateBuyerCartItemSaveForLater (Guid id)

Move a cart line to saved-for-later.

Returns the whole saved list. A line from an accepted offer cannot be saved — its price only holds in the cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCartItemSaveForLaterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Move a cart line to saved-for-later.
                BuyerCartResponse result = apiInstance.CreateBuyerCartItemSaveForLater(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCartItemSaveForLater: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerCartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercartoptimizer"></a>
# **CreateBuyerCartOptimizer**
> CreateBuyerCartOptimizerResponse CreateBuyerCartOptimizer ()

Cart optimizer: send a shopping list (one item per line, \"2 Charizard Base Set\") and get the cheapest delivered basket across sellers — one pick per line, items + each seller’s shipping with free-shipping thresholds applied. fewestPackages prefers fewer sellers. Nothing is added to the cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCartOptimizerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Cart optimizer: send a shopping list (one item per line, \"2 Charizard Base Set\") and get the cheapest delivered basket across sellers — one pick per line, items + each seller’s shipping with free-shipping thresholds applied. fewestPackages prefers fewer sellers. Nothing is added to the cart.
                CreateBuyerCartOptimizerResponse result = apiInstance.CreateBuyerCartOptimizer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCartOptimizer: " + e.Message );
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

**CreateBuyerCartOptimizerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercartquote"></a>
# **CreateBuyerCartQuote**
> CreateBuyerCartQuoteResponse CreateBuyerCartQuote ()

Price the cart, delivered — item, shipping, tax, total.

Runs the real checkout cascade and returns the totals instead of charging. Nothing is purchased. `taxComplete: false` means there is no saved delivery address, so the total is a floor rather than a final figure. `shippingOptions` lists each seller’s shipping services; send `shippingServiceBySeller` to price a different speed (an id the seller does not offer to the destination is a 400). Optional body: `{ \"shippingServiceBySeller\": { \"<sellerUserId>\": \"<serviceId>\" } }` — omitted sellers get the cheapest service; `registryToken` prices it as a gift shipped to that registry. (No body JSON schema: existing callers POST with none.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCartQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Price the cart, delivered — item, shipping, tax, total.
                CreateBuyerCartQuoteResponse result = apiInstance.CreateBuyerCartQuote();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCartQuote: " + e.Message );
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

**CreateBuyerCartQuoteResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercartsavedmovetocart"></a>
# **CreateBuyerCartSavedMoveToCart**
> BuyerCartResponse CreateBuyerCartSavedMoveToCart (Guid id)

Move a saved item back into your cart, at today’s price.

Refused when the item has sold or delisted. Returns the remaining saved list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCartSavedMoveToCartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Move a saved item back into your cart, at today’s price.
                BuyerCartResponse result = apiInstance.CreateBuyerCartSavedMoveToCart(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCartSavedMoveToCart: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerCartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercasecounter"></a>
# **CreateBuyerCaseCounter**
> BuyerResponse CreateBuyerCaseCounter (Guid id, CreateBuyerCaseCounterRequest createBuyerCaseCounterRequest)

Propose your own refund figure on a case.

In cents, at most what you paid. The case goes back to the seller for 72 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCaseCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var createBuyerCaseCounterRequest = new CreateBuyerCaseCounterRequest(); // CreateBuyerCaseCounterRequest | 

            try
            {
                // Propose your own refund figure on a case.
                BuyerResponse result = apiInstance.CreateBuyerCaseCounter(id, createBuyerCaseCounterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCaseCounter: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **createBuyerCaseCounterRequest** | **CreateBuyerCaseCounterRequest**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyercaseescalate"></a>
# **CreateBuyerCaseEscalate**
> BuyerResponse CreateBuyerCaseEscalate (Guid id)

Ask Crossly to step in on a case.

Hands the case to Crossly’s reviewers. Refused once it is closed or already escalated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCaseEscalateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Ask Crossly to step in on a case.
                BuyerResponse result = apiInstance.CreateBuyerCaseEscalate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCaseEscalate: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercasemessage"></a>
# **CreateBuyerCaseMessage**
> BuyerResponse CreateBuyerCaseMessage (Guid id, CreateBuyerCaseMessageRequest createBuyerCaseMessageRequest)

Post a message on a case thread.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCaseMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var createBuyerCaseMessageRequest = new CreateBuyerCaseMessageRequest(); // CreateBuyerCaseMessageRequest | 

            try
            {
                // Post a message on a case thread.
                BuyerResponse result = apiInstance.CreateBuyerCaseMessage(id, createBuyerCaseMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCaseMessage: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **createBuyerCaseMessageRequest** | **CreateBuyerCaseMessageRequest**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyercaserespond"></a>
# **CreateBuyerCaseRespond**
> BuyerResponse CreateBuyerCaseRespond (Guid id, CreateBuyerCaseRespondRequest createBuyerCaseRespondRequest)

Accept or reject the seller’s partial-refund offer on a case.

Accepting refunds the offered amount and closes the case. Rejecting hands it back to the seller for 72 hours. To propose your own figure instead, use the counter endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCaseRespondExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var createBuyerCaseRespondRequest = new CreateBuyerCaseRespondRequest(); // CreateBuyerCaseRespondRequest | 

            try
            {
                // Accept or reject the seller’s partial-refund offer on a case.
                BuyerResponse result = apiInstance.CreateBuyerCaseRespond(id, createBuyerCaseRespondRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCaseRespond: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **createBuyerCaseRespondRequest** | **CreateBuyerCaseRespondRequest**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyercasewithdraw"></a>
# **CreateBuyerCaseWithdraw**
> BuyerResponse CreateBuyerCaseWithdraw (Guid id)

Withdraw a case you opened.

Closes it with no refund and lets the order complete normally. Cannot be reopened — one case per order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCaseWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Withdraw a case you opened.
                BuyerResponse result = apiInstance.CreateBuyerCaseWithdraw(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCaseWithdraw: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercataloglistingrental"></a>
# **CreateBuyerCatalogListingRental**
> CreateBuyerCatalogListingRentalResponse CreateBuyerCatalogListingRental (string slug)

Book a rental. Returns a Stripe PaymentIntent client secret for rent + shipping both ways + deposit; the dates are held 30 minutes for payment. Crossly buys both labels; the deposit comes back after the item does.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCatalogListingRentalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Book a rental. Returns a Stripe PaymentIntent client secret for rent + shipping both ways + deposit; the dates are held 30 minutes for payment. Crossly buys both labels; the deposit comes back after the item does.
                CreateBuyerCatalogListingRentalResponse result = apiInstance.CreateBuyerCatalogListingRental(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCatalogListingRental: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerCatalogListingRentalResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercataloglistingrentalquote"></a>
# **CreateBuyerCatalogListingRentalQuote**
> CreateBuyerCatalogListingRentalQuoteResponse CreateBuyerCatalogListingRentalQuote (string slug)

Price a rental: rent (the cheaper of by-the-day and by-the-week), both shipping legs once a ship-to is given, and the deposit. `problem` says why the dates can’t be booked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCatalogListingRentalQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Price a rental: rent (the cheaper of by-the-day and by-the-week), both shipping legs once a ship-to is given, and the deposit. `problem` says why the dates can’t be booked.
                CreateBuyerCatalogListingRentalQuoteResponse result = apiInstance.CreateBuyerCatalogListingRentalQuote(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCatalogListingRentalQuote: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerCatalogListingRentalQuoteResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyercataloglistingvideorequest"></a>
# **CreateBuyerCatalogListingVideoRequest**
> CreateBuyerCatalogListingVideoRequestResponse CreateBuyerCatalogListingVideoRequest (string slug)

Ask the seller for a video of an item (one open request per item). The seller is notified; their answer appears on the listing for every buyer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerCatalogListingVideoRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Ask the seller for a video of an item (one open request per item). The seller is notified; their answer appears on the listing for every buyer.
                CreateBuyerCatalogListingVideoRequestResponse result = apiInstance.CreateBuyerCatalogListingVideoRequest(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerCatalogListingVideoRequest: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerCatalogListingVideoRequestResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerconversationinvite"></a>
# **CreateBuyerConversationInvite**
> CreateBuyerWishlistInviteResponse CreateBuyerConversationInvite (string id)

Invite a friend into a chat with a seller: a single-use link (7 days) that makes whoever opens it a guest who can read and post. Only the thread’s buyer can invite; at most 5 guests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerConversationInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Invite a friend into a chat with a seller: a single-use link (7 days) that makes whoever opens it a guest who can read and post. Only the thread’s buyer can invite; at most 5 guests.
                CreateBuyerWishlistInviteResponse result = apiInstance.CreateBuyerConversationInvite(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerConversationInvite: " + e.Message );
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

**CreateBuyerWishlistInviteResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerconversationjoin"></a>
# **CreateBuyerConversationJoin**
> CreateBuyerConversationJoinResponse CreateBuyerConversationJoin (string token)

Join a chat you were invited into, as a guest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerConversationJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var token = "token_example";  // string | 

            try
            {
                // Join a chat you were invited into, as a guest.
                CreateBuyerConversationJoinResponse result = apiInstance.CreateBuyerConversationJoin(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerConversationJoin: " + e.Message );
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
 **token** | **string**|  | 

### Return type

**CreateBuyerConversationJoinResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerfeedback"></a>
# **CreateBuyerFeedback**
> CreateBuyerFeedbackResponse CreateBuyerFeedback (CreateBuyerFeedbackRequest createBuyerFeedbackRequest)

Leave feedback on up to 25 orders at once, with optional detailed seller ratings.

Each entry is checked on its own — one refused comment never sinks the others; read `data[].ok`. Orders to review come from GET /v1/buyer/feedback/pending.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerFeedbackRequest = new CreateBuyerFeedbackRequest(); // CreateBuyerFeedbackRequest | 

            try
            {
                // Leave feedback on up to 25 orders at once, with optional detailed seller ratings.
                CreateBuyerFeedbackResponse result = apiInstance.CreateBuyerFeedback(createBuyerFeedbackRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerFeedback: " + e.Message );
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
 **createBuyerFeedbackRequest** | **CreateBuyerFeedbackRequest**|  | 

### Return type

**CreateBuyerFeedbackResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerfitref"></a>
# **CreateBuyerFitRef**
> BuyerResponse2 CreateBuyerFitRef ()

Save a reference garment (flat measurements, inches) to compare listings against.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerFitRefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Save a reference garment (flat measurements, inches) to compare listings against.
                BuyerResponse2 result = apiInstance.CreateBuyerFitRef();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerFitRef: " + e.Message );
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

**BuyerResponse2**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerfollowingsellerseen"></a>
# **CreateBuyerFollowingSellerSeen**
> CreateBuyerFollowingSellerSeenResponse CreateBuyerFollowingSellerSeen (CreateBuyerFollowingSellerSeenRequest createBuyerFollowingSellerSeenRequest)

Clear the \"new listings\" count on a followed seller, or on all of them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerFollowingSellerSeenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerFollowingSellerSeenRequest = new CreateBuyerFollowingSellerSeenRequest(); // CreateBuyerFollowingSellerSeenRequest | 

            try
            {
                // Clear the \"new listings\" count on a followed seller, or on all of them.
                CreateBuyerFollowingSellerSeenResponse result = apiInstance.CreateBuyerFollowingSellerSeen(createBuyerFollowingSellerSeenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerFollowingSellerSeen: " + e.Message );
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
 **createBuyerFollowingSellerSeenRequest** | **CreateBuyerFollowingSellerSeenRequest**|  | 

### Return type

**CreateBuyerFollowingSellerSeenResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyergiftcard"></a>
# **CreateBuyerGiftCard**
> CreateBuyerGiftCardResponse CreateBuyerGiftCard (CreateBuyerGiftCardRequest createBuyerGiftCardRequest)

Start a gift card purchase.

Creates an unpaid card and a Stripe PaymentIntent, and returns its client secret. Nothing is charged until the PaymentIntent is confirmed; the code is emailed to the recipient once payment clears (at deliverAt, if given) and is never returned here. $10–$500. Cards and their credit expire 5 years after purchase. Idempotency-Key required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerGiftCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerGiftCardRequest = new CreateBuyerGiftCardRequest(); // CreateBuyerGiftCardRequest | 

            try
            {
                // Start a gift card purchase.
                CreateBuyerGiftCardResponse result = apiInstance.CreateBuyerGiftCard(createBuyerGiftCardRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerGiftCard: " + e.Message );
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
 **createBuyerGiftCardRequest** | **CreateBuyerGiftCardRequest**|  | 

### Return type

**CreateBuyerGiftCardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyergiftcardredeem"></a>
# **CreateBuyerGiftCardRedeem**
> CreateBuyerGiftCardRedeemResponse CreateBuyerGiftCardRedeem (CreateBuyerGiftCardRedeemRequest createBuyerGiftCardRedeemRequest)

Redeem a gift card code into your own balance.

Adds the card’s value to the token owner’s Crossly balance (Crossly Bucks today; CBX granted balance when Crossly issues CBX), spendable at checkout. One redemption per card. The credit keeps the card’s expiry date. Refusals: 404 invalid_code, 409 already_redeemed / not_paid / void / expired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerGiftCardRedeemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerGiftCardRedeemRequest = new CreateBuyerGiftCardRedeemRequest(); // CreateBuyerGiftCardRedeemRequest | 

            try
            {
                // Redeem a gift card code into your own balance.
                CreateBuyerGiftCardRedeemResponse result = apiInstance.CreateBuyerGiftCardRedeem(createBuyerGiftCardRedeemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerGiftCardRedeem: " + e.Message );
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
 **createBuyerGiftCardRedeemRequest** | **CreateBuyerGiftCardRedeemRequest**|  | 

### Return type

**CreateBuyerGiftCardRedeemResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyergroupbuyjoin"></a>
# **CreateBuyerGroupBuyJoin**
> CreateBuyerGroupBuyJoinResponse CreateBuyerGroupBuyJoin (string id)

Join a group buy: a hold at the starting price, captured at the price the group reaches. Checked against this key’s spending controls; send an Idempotency-Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerGroupBuyJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Join a group buy: a hold at the starting price, captured at the price the group reaches. Checked against this key’s spending controls; send an Idempotency-Key.
                CreateBuyerGroupBuyJoinResponse result = apiInstance.CreateBuyerGroupBuyJoin(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerGroupBuyJoin: " + e.Message );
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

**CreateBuyerGroupBuyJoinResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyergroupbuyleave"></a>
# **CreateBuyerGroupBuyLeave**
> BuyerResponse CreateBuyerGroupBuyLeave (string id)

Leave a group buy and release your hold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerGroupBuyLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Leave a group buy and release your hold.
                BuyerResponse result = apiInstance.CreateBuyerGroupBuyLeave(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerGroupBuyLeave: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerhunt"></a>
# **CreateBuyerHunt**
> BuyerResponse2 CreateBuyerHunt ()

Start a buyer-agent hunt — over a search (filters), or auto-buy on one listing (listingSlug: buy it once its price, sale applied, is within maxPriceCents). `offer` and `buy` modes also need buyer:checkout:write, and the budget is checked against this key’s spending controls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerHuntExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Start a buyer-agent hunt — over a search (filters), or auto-buy on one listing (listingSlug: buy it once its price, sale applied, is within maxPriceCents). `offer` and `buy` modes also need buyer:checkout:write, and the budget is checked against this key’s spending controls.
                BuyerResponse2 result = apiInstance.CreateBuyerHunt();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerHunt: " + e.Message );
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

**BuyerResponse2**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerinstantofferaccept"></a>
# **CreateBuyerInstantOfferAccept**
> BuyerResponse CreateBuyerInstantOfferAccept (string id)

Accept Crossly’s instant offer on a collection item. Ops then send a prepaid label; the store credit is paid once the item arrives and checks out.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerInstantOfferAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Accept Crossly’s instant offer on a collection item. Ops then send a prepaid label; the store credit is paid once the item arrives and checks out.
                BuyerResponse result = apiInstance.CreateBuyerInstantOfferAccept(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerInstantOfferAccept: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlayawaycancel"></a>
# **CreateBuyerLayawayCancel**
> BuyerLayawayResponse CreateBuyerLayawayCancel (string id)

Cancel a layaway: everything paid comes back except the layaway fee (10% of the price, at most $15).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerLayawayCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a layaway: everything paid comes back except the layaway fee (10% of the price, at most $15).
                BuyerLayawayResponse result = apiInstance.CreateBuyerLayawayCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerLayawayCancel: " + e.Message );
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

**BuyerLayawayResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlayawaypay"></a>
# **CreateBuyerLayawayPay**
> BuyerLayawayResponse CreateBuyerLayawayPay (string id)

Pay some (at least $1) or all of what is left now, on the saved card. Paid in full, it ships.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerLayawayPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pay some (at least $1) or all of what is left now, on the saved card. Paid in full, it ships.
                BuyerLayawayResponse result = apiInstance.CreateBuyerLayawayPay(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerLayawayPay: " + e.Message );
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

**BuyerLayawayResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlistingaudiosummary"></a>
# **CreateBuyerListingAudioSummary**
> GetBuyerListingAudioSummaryResponse CreateBuyerListingAudioSummary (string slug)

Record the spoken summary of a listing (cached per listing version). 503 naming TTS_API_KEY when no speech provider is configured.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerListingAudioSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Record the spoken summary of a listing (cached per listing version). 503 naming TTS_API_KEY when no speech provider is configured.
                GetBuyerListingAudioSummaryResponse result = apiInstance.CreateBuyerListingAudioSummary(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerListingAudioSummary: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingAudioSummaryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlistingsplit"></a>
# **CreateBuyerListingSplit**
> CreateBuyerListingSplitResponse CreateBuyerListingSplit (string slug)

Split a purchase: one pay link per person; nobody is charged until all have paid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerListingSplitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Split a purchase: one pay link per person; nobody is charged until all have paid.
                CreateBuyerListingSplitResponse result = apiInstance.CreateBuyerListingSplit(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerListingSplit: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerListingSplitResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlistingsubscribe"></a>
# **CreateBuyerListingSubscribe**
> BuyerResponse2 CreateBuyerListingSubscribe (string slug)

Subscribe & save: a standing order charged to your saved card every interval. Checked against this key’s spending controls; send an Idempotency-Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerListingSubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Subscribe & save: a standing order charged to your saved card every interval. Checked against this key’s spending controls; send an Idempotency-Key.
                BuyerResponse2 result = apiInstance.CreateBuyerListingSubscribe(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerListingSubscribe: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**BuyerResponse2**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerlistingtryon"></a>
# **CreateBuyerListingTryOn**
> CreateBuyerListingTryOnResponse CreateBuyerListingTryOn (string slug)

Render an AI try-on of this listing on the buyer’s own photo (base64 `photo`, or `reuseLastPhoto`). `confirmSelfAdult` must be true: the photo is of the buyer and they are 18+. Wearables only; capped per day; 503 naming TRYON_API_KEY when no image model is configured.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerListingTryOnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Render an AI try-on of this listing on the buyer’s own photo (base64 `photo`, or `reuseLastPhoto`). `confirmSelfAdult` must be true: the photo is of the buyer and they are 18+. Wearables only; capped per day; 503 naming TRYON_API_KEY when no image model is configured.
                CreateBuyerListingTryOnResponse result = apiInstance.CreateBuyerListingTryOn(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerListingTryOn: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerListingTryOnResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyermarketbid"></a>
# **CreateBuyerMarketBid**
> CreateBuyerMarketBidResponse CreateBuyerMarketBid ()

Place a fixed-price market bid. SPENDS MONEY: it fills against the lowest ask at or under your price and charges your saved card (plus the fast-ship premium when fastShip is set and it fills from vault stock). deliverTo vault keeps it in your Crossly vault; gradeWith sends a raw card to a Grading run first. Checked against this key’s spending controls; send an Idempotency-Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerMarketBidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Place a fixed-price market bid. SPENDS MONEY: it fills against the lowest ask at or under your price and charges your saved card (plus the fast-ship premium when fastShip is set and it fills from vault stock). deliverTo vault keeps it in your Crossly vault; gradeWith sends a raw card to a Grading run first. Checked against this key’s spending controls; send an Idempotency-Key.
                CreateBuyerMarketBidResponse result = apiInstance.CreateBuyerMarketBid();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerMarketBid: " + e.Message );
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

**CreateBuyerMarketBidResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyermarketwatch"></a>
# **CreateBuyerMarketWatch**
> BuyerResponse CreateBuyerMarketWatch ()

Watch a market variant: alert at or below a price, or on any drop.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerMarketWatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Watch a market variant: alert at or below a price, or on any drop.
                BuyerResponse result = apiInstance.CreateBuyerMarketWatch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerMarketWatch: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyeroffer"></a>
# **CreateBuyerOffer**
> CreateBuyerOfferResponse CreateBuyerOffer (CreateBuyerOfferRequest createBuyerOfferRequest)

Offer a price on a listing.

Sends an offer to the seller. Spends nothing — a seller accepting still leaves you to complete checkout. Offers at or above the asking price are refused; buy it instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerOfferRequest = new CreateBuyerOfferRequest(); // CreateBuyerOfferRequest | 

            try
            {
                // Offer a price on a listing.
                CreateBuyerOfferResponse result = apiInstance.CreateBuyerOffer(createBuyerOfferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOffer: " + e.Message );
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
 **createBuyerOfferRequest** | **CreateBuyerOfferRequest**|  | 

### Return type

**CreateBuyerOfferResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerofferrespond"></a>
# **CreateBuyerOfferRespond**
> CreateBuyerOfferRespondResponse CreateBuyerOfferRespond (Guid id, CreateBuyerOfferRespondRequest createBuyerOfferRespondRequest)

Answer a seller’s counteroffer — accept, decline, or counter back.

Only an offer with `awaitingBuyer: true` can be answered. Accepting opens a 48-hour window to pay on Crossly; it charges nothing. A counter must be below the seller’s price (in cents) and becomes a new offer waiting on the seller.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOfferRespondExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The offer id.
            var createBuyerOfferRespondRequest = new CreateBuyerOfferRespondRequest(); // CreateBuyerOfferRespondRequest | 

            try
            {
                // Answer a seller’s counteroffer — accept, decline, or counter back.
                CreateBuyerOfferRespondResponse result = apiInstance.CreateBuyerOfferRespond(id, createBuyerOfferRespondRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOfferRespond: " + e.Message );
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
 **id** | **Guid**| The offer id. | 
 **createBuyerOfferRespondRequest** | **CreateBuyerOfferRespondRequest**|  | 

### Return type

**CreateBuyerOfferRespondResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerordercancel"></a>
# **CreateBuyerOrderCancel**
> CreateBuyerOrderCancelResponse CreateBuyerOrderCancel (Guid id)

Cancel an order before it ships — refunds it in full.

Instant while the seller has not bought a label or shipped. Refused with 409 once they have (`details.shopCode`: already_shipped, label_purchased, disputed, already_refunded). Check GET /v1/buyer/orders/{id}/eligibility first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOrderCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Cancel an order before it ships — refunds it in full.
                CreateBuyerOrderCancelResponse result = apiInstance.CreateBuyerOrderCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOrderCancel: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**CreateBuyerOrderCancelResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerorderinr"></a>
# **CreateBuyerOrderInr**
> CreateBuyerOrderInrResponse CreateBuyerOrderInr (Guid id, CreateBuyerOrderInrRequest createBuyerOrderInrRequest)

Open an item-not-received case.

Only after the expected delivery window — a 409 carries `details.reason` and `details.opensAt` when it is too early. The seller then has 72 hours to respond. One case per order, ever.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOrderInrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var createBuyerOrderInrRequest = new CreateBuyerOrderInrRequest(); // CreateBuyerOrderInrRequest | 

            try
            {
                // Open an item-not-received case.
                CreateBuyerOrderInrResponse result = apiInstance.CreateBuyerOrderInr(id, createBuyerOrderInrRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOrderInr: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **createBuyerOrderInrRequest** | **CreateBuyerOrderInrRequest**|  | 

### Return type

**CreateBuyerOrderInrResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerorderreceived"></a>
# **CreateBuyerOrderReceived**
> CreateBuyerOrderReceivedResponse CreateBuyerOrderReceived (Guid id)

Confirm you received an order.

Records receipt and opens feedback. It does NOT release the seller’s money sooner or shorten your buyer protection. Closes the item-not-received entry point.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOrderReceivedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Confirm you received an order.
                CreateBuyerOrderReceivedResponse result = apiInstance.CreateBuyerOrderReceived(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOrderReceived: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**CreateBuyerOrderReceivedResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerordertip"></a>
# **CreateBuyerOrderTip**
> CreateBuyerOrderTipResponse CreateBuyerOrderTip (string id)

Tip the seller on one of your shipped orders, charged to your saved card. One tip per order; $1–$500; checked against this key’s spending controls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerOrderTipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Tip the seller on one of your shipped orders, charged to your saved card. One tip per order; $1–$500; checked against this key’s spending controls.
                CreateBuyerOrderTipResponse result = apiInstance.CreateBuyerOrderTip(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerOrderTip: " + e.Message );
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

**CreateBuyerOrderTipResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpackfairnessrotate"></a>
# **CreateBuyerPackFairnessRotate**
> GetBuyerPackFairnessResponse CreateBuyerPackFairnessRotate ()

Reveal your current server seed and start a new one (optionally with your own client seed). Refused while an opening is awaiting payment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPackFairnessRotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Reveal your current server seed and start a new one (optionally with your own client seed). Refused while an opening is awaiting payment.
                GetBuyerPackFairnessResponse result = apiInstance.CreateBuyerPackFairnessRotate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPackFairnessRotate: " + e.Message );
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

**GetBuyerPackFairnessResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpackopen"></a>
# **CreateBuyerPackOpen**
> CreateBuyerPackOpenResponse CreateBuyerPackOpen (string slug)

Open a pack. SPENDS MONEY: charges the pack price to your saved card, then pulls one real item by the published odds (provably fair: see /buyer/packs/fairness) into your Crossly vault. confirmAdult must be true. Checked against this key’s spending controls; send an Idempotency-Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPackOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Open a pack. SPENDS MONEY: charges the pack price to your saved card, then pulls one real item by the published odds (provably fair: see /buyer/packs/fairness) into your Crossly vault. confirmAdult must be true. Checked against this key’s spending controls; send an Idempotency-Key.
                CreateBuyerPackOpenResponse result = apiInstance.CreateBuyerPackOpen(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPackOpen: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**CreateBuyerPackOpenResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpackopeningsellback"></a>
# **CreateBuyerPackOpeningSellBack**
> CreateBuyerPackOpeningSellBackResponse CreateBuyerPackOpeningSellBack (string id)

Sell a pull straight back for Crossly credit at the pack’s buyback rate, within its window, while it is still in your vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPackOpeningSellBackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Sell a pull straight back for Crossly credit at the pack’s buyback rate, within its window, while it is still in your vault.
                CreateBuyerPackOpeningSellBackResponse result = apiInstance.CreateBuyerPackOpeningSellBack(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPackOpeningSellBack: " + e.Message );
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

**CreateBuyerPackOpeningSellBackResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpassportclaim"></a>
# **CreateBuyerPassportClaim**
> GetBuyerPassportResponse CreateBuyerPassportClaim (string code)

Claim a passport as the item’s current owner (the buyer of its latest sale) — shown as “in its owner’s hands” until it sells again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPassportClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Claim a passport as the item’s current owner (the buyer of its latest sale) — shown as “in its owner’s hands” until it sells again.
                GetBuyerPassportResponse result = apiInstance.CreateBuyerPassportClaim(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPassportClaim: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**GetBuyerPassportResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerprotectionplancancel"></a>
# **CreateBuyerProtectionPlanCancel**
> CreateBuyerProtectionPlanCancelResponse CreateBuyerProtectionPlanCancel (string id)

Cancel a protection plan. The insurer decides what is refundable (pro-rata after the free-look window); that amount goes back to the card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerProtectionPlanCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a protection plan. The insurer decides what is refundable (pro-rata after the free-look window); that amount goes back to the card.
                CreateBuyerProtectionPlanCancelResponse result = apiInstance.CreateBuyerProtectionPlanCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerProtectionPlanCancel: " + e.Message );
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

**CreateBuyerProtectionPlanCancelResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpurchasedownload"></a>
# **CreateBuyerPurchaseDownload**
> CreateBuyerPurchaseDownloadResponse CreateBuyerPurchaseDownload (string id)

A ten-minute link to a digital purchase’s file; each call uses one of its downloads.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPurchaseDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A ten-minute link to a digital purchase’s file; each call uses one of its downloads.
                CreateBuyerPurchaseDownloadResponse result = apiInstance.CreateBuyerPurchaseDownload(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPurchaseDownload: " + e.Message );
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

**CreateBuyerPurchaseDownloadResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpurchasefit"></a>
# **CreateBuyerPurchaseFit**
> BuyerResponse CreateBuyerPurchaseFit (string id)

Say how a delivered purchase fit: true_to_size, small or large. It teaches your size memory and, pooled with other buyers, how the brand runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPurchaseFitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Say how a delivered purchase fit: true_to_size, small or large. It teaches your size memory and, pooled with other buyers, how the brand runs.
                BuyerResponse result = apiInstance.CreateBuyerPurchaseFit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPurchaseFit: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerpurchasereturn"></a>
# **CreateBuyerPurchaseReturn**
> BuyerResponse2 CreateBuyerPurchaseReturn (string id)

Return a purchase under the seller’s policy, or send back a try-at-home item. With reason doesnt_fit, `fit` (small | large) says which way, and it feeds your size memory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerPurchaseReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Return a purchase under the seller’s policy, or send back a try-at-home item. With reason doesnt_fit, `fit` (small | large) says which way, and it feeds your size memory.
                BuyerResponse2 result = apiInstance.CreateBuyerPurchaseReturn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerPurchaseReturn: " + e.Message );
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

**BuyerResponse2**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerregistry"></a>
# **CreateBuyerRegistry**
> CreateBuyerRegistryResponse CreateBuyerRegistry ()

Start a gift registry (wedding, baby, birthday, housewarming, graduation, other). Items are added like any wishlist item; set shipAddressId to one of your saved addresses so guests can buy — they never see it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Start a gift registry (wedding, baby, birthday, housewarming, graduation, other). Items are added like any wishlist item; set shipAddressId to one of your saved addresses so guests can buy — they never see it.
                CreateBuyerRegistryResponse result = apiInstance.CreateBuyerRegistry();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRegistry: " + e.Message );
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

**CreateBuyerRegistryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerregistrygiftthanked"></a>
# **CreateBuyerRegistryGiftThanked**
> CreateBuyerRegistryGiftThankedResponse CreateBuyerRegistryGiftThanked (string id, string giftId)

Tick a gift as thanked (or untick it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRegistryGiftThankedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var giftId = "giftId_example";  // string | 

            try
            {
                // Tick a gift as thanked (or untick it).
                CreateBuyerRegistryGiftThankedResponse result = apiInstance.CreateBuyerRegistryGiftThanked(id, giftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRegistryGiftThanked: " + e.Message );
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
 **giftId** | **string**|  | 

### Return type

**CreateBuyerRegistryGiftThankedResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerrentalarrivalphoto"></a>
# **CreateBuyerRentalArrivalPhoto**
> CreateBuyerRentalArrivalPhotoResponse CreateBuyerRentalArrivalPhoto (string id)

Photograph a rental on arrival (URLs you uploaded): your side of the condition record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRentalArrivalPhotoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Photograph a rental on arrival (URLs you uploaded): your side of the condition record.
                CreateBuyerRentalArrivalPhotoResponse result = apiInstance.CreateBuyerRentalArrivalPhoto(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRentalArrivalPhoto: " + e.Message );
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

**CreateBuyerRentalArrivalPhotoResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerrentalcancel"></a>
# **CreateBuyerRentalCancel**
> BuyerResponse CreateBuyerRentalCancel (string id)

Cancel a rental that has not shipped: everything is refunded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRentalCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a rental that has not shipped: everything is refunded.
                BuyerResponse result = apiInstance.CreateBuyerRentalCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRentalCancel: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerrentalclaimresponse"></a>
# **CreateBuyerRentalClaimResponse**
> BuyerResponse CreateBuyerRentalClaimResponse (string id)

Answer a deposit claim: accept (the claim is paid, the rest refunded) or dispute (Crossly decides).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRentalClaimResponseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Answer a deposit claim: accept (the claim is paid, the rest refunded) or dispute (Crossly decides).
                BuyerResponse result = apiInstance.CreateBuyerRentalClaimResponse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRentalClaimResponse: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerrentalidentitystart"></a>
# **CreateBuyerRentalIdentityStart**
> CreateBuyerRentalIdentityStartResponse CreateBuyerRentalIdentityStart ()

Start the ID check renting needs (Stripe Identity: photo ID + selfie). Open `url` (hosted) or use `clientSecret` with Stripe.js.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerRentalIdentityStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Start the ID check renting needs (Stripe Identity: photo ID + selfie). Open `url` (hosted) or use `clientSecret` with Stripe.js.
                CreateBuyerRentalIdentityStartResponse result = apiInstance.CreateBuyerRentalIdentityStart();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerRentalIdentityStart: " + e.Message );
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

**CreateBuyerRentalIdentityStartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerreturncancel"></a>
# **CreateBuyerReturnCancel**
> BuyerResponse CreateBuyerReturnCancel (string id)

Cancel a return before it ships.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerReturnCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a return before it ships.
                BuyerResponse result = apiInstance.CreateBuyerReturnCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerReturnCancel: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerreturntracking"></a>
# **CreateBuyerReturnTracking**
> BuyerResponse CreateBuyerReturnTracking (string id)

Add tracking to a return you shipped on your own label.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerReturnTrackingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Add tracking to a return you shipped on your own label.
                BuyerResponse result = apiInstance.CreateBuyerReturnTracking(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerReturnTracking: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyersellerclubjoin"></a>
# **CreateBuyerSellerClubJoin**
> CreateBuyerSellerClubJoinResponse CreateBuyerSellerClubJoin (string sellerUserId)

Join a seller’s loyalty club (free). Your tier’s discount then applies to their items — the best of it and any other rate you have with them, never stacked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerSellerClubJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var sellerUserId = "sellerUserId_example";  // string | 

            try
            {
                // Join a seller’s loyalty club (free). Your tier’s discount then applies to their items — the best of it and any other rate you have with them, never stacked.
                CreateBuyerSellerClubJoinResponse result = apiInstance.CreateBuyerSellerClubJoin(sellerUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerSellerClubJoin: " + e.Message );
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
 **sellerUserId** | **string**|  | 

### Return type

**CreateBuyerSellerClubJoinResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyersellerreport"></a>
# **CreateBuyerSellerReport**
> CreateBuyerSellerReportResponse CreateBuyerSellerReport (string username, CreateBuyerSellerReportRequest createBuyerSellerReportRequest)

Report a seller to Crossly’s trust team.

A second report while your first is still under review updates that report instead of filing another. `purchaseId` is attached only if it is your order from this seller.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerSellerReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var username = "username_example";  // string | The seller’s shop handle.
            var createBuyerSellerReportRequest = new CreateBuyerSellerReportRequest(); // CreateBuyerSellerReportRequest | 

            try
            {
                // Report a seller to Crossly’s trust team.
                CreateBuyerSellerReportResponse result = apiInstance.CreateBuyerSellerReport(username, createBuyerSellerReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerSellerReport: " + e.Message );
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
 **username** | **string**| The seller’s shop handle. | 
 **createBuyerSellerReportRequest** | **CreateBuyerSellerReportRequest**|  | 

### Return type

**CreateBuyerSellerReportResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyersplitcancel"></a>
# **CreateBuyerSplitCancel**
> BuyerResponse CreateBuyerSplitCancel (string id)

Cancel a split you organised; every held share is released.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerSplitCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a split you organised; every held share is released.
                BuyerResponse result = apiInstance.CreateBuyerSplitCancel(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerSplitCancel: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogether"></a>
# **CreateBuyerTogether**
> CreateBuyerTogetherResponse CreateBuyerTogether ()

Start a shop-together room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Start a shop-together room.
                CreateBuyerTogetherResponse result = apiInstance.CreateBuyerTogether();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogether: " + e.Message );
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

**CreateBuyerTogetherResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogetheritem"></a>
# **CreateBuyerTogetherItem**
> BuyerResponse CreateBuyerTogetherItem (string code)

Add a listing to a shop-together board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Add a listing to a shop-together board.
                BuyerResponse result = apiInstance.CreateBuyerTogetherItem(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogetherItem: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogetheritemvote"></a>
# **CreateBuyerTogetherItemVote**
> BuyerResponse CreateBuyerTogetherItemVote (string code, string id)

Vote an item on a room’s board up (1), down (-1) or clear (0).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherItemVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Vote an item on a room’s board up (1), down (-1) or clear (0).
                BuyerResponse result = apiInstance.CreateBuyerTogetherItemVote(code, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogetherItemVote: " + e.Message );
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
 **code** | **string**|  | 
 **id** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogetherjoin"></a>
# **CreateBuyerTogetherJoin**
> CreateBuyerTogetherResponse CreateBuyerTogetherJoin (string code)

Join a shop-together room by its code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Join a shop-together room by its code.
                CreateBuyerTogetherResponse result = apiInstance.CreateBuyerTogetherJoin(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogetherJoin: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**CreateBuyerTogetherResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogetherleave"></a>
# **CreateBuyerTogetherLeave**
> BuyerResponse CreateBuyerTogetherLeave (string code)

Leave a shop-together room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Leave a shop-together room.
                BuyerResponse result = apiInstance.CreateBuyerTogetherLeave(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogetherLeave: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertogethermessage"></a>
# **CreateBuyerTogetherMessage**
> BuyerResponse CreateBuyerTogetherMessage (string code)

Say something in a shop-together room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTogetherMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Say something in a shop-together room.
                BuyerResponse result = apiInstance.CreateBuyerTogetherMessage(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTogetherMessage: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyertotalrequest"></a>
# **CreateBuyerTotalRequest**
> CreateBuyerTotalRequestResponse CreateBuyerTotalRequest (CreateBuyerTotalRequestRequest createBuyerTotalRequestRequest)

Ask a seller for one combined shipping total on everything of theirs in your cart.

Needs two or more of the seller’s items in your cart. Spends nothing; the quote applies at checkout on Crossly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerTotalRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerTotalRequestRequest = new CreateBuyerTotalRequestRequest(); // CreateBuyerTotalRequestRequest | 

            try
            {
                // Ask a seller for one combined shipping total on everything of theirs in your cart.
                CreateBuyerTotalRequestResponse result = apiInstance.CreateBuyerTotalRequest(createBuyerTotalRequestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerTotalRequest: " + e.Message );
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
 **createBuyerTotalRequestRequest** | **CreateBuyerTotalRequestRequest**|  | 

### Return type

**CreateBuyerTotalRequestResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyervaultlist"></a>
# **CreateBuyerVaultList**
> CreateBuyerVaultListResponse CreateBuyerVaultList (string id)

Sell a vault item on the market at your price. It is already authenticated, so when it sells nothing ships in: the buyer keeps it vaulted or it ships straight to them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerVaultListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Sell a vault item on the market at your price. It is already authenticated, so when it sells nothing ships in: the buyer keeps it vaulted or it ships straight to them.
                CreateBuyerVaultListResponse result = apiInstance.CreateBuyerVaultList(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerVaultList: " + e.Message );
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

**CreateBuyerVaultListResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyervaultunlist"></a>
# **CreateBuyerVaultUnlist**
> BuyerResponse CreateBuyerVaultUnlist (string id)

Take a vault item off the market; it stays stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerVaultUnlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take a vault item off the market; it stays stored.
                BuyerResponse result = apiInstance.CreateBuyerVaultUnlist(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerVaultUnlist: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyervaultwithdraw"></a>
# **CreateBuyerVaultWithdraw**
> CreateBuyerVaultWithdrawResponse CreateBuyerVaultWithdraw (string id)

Ship a vault item home, standard or expedited. The shipping, any storage it owes and the early-withdrawal fee (within 90 days of arriving) are charged to your saved card now, all checked against this key’s spending controls; send an Idempotency-Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerVaultWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Ship a vault item home, standard or expedited. The shipping, any storage it owes and the early-withdrawal fee (within 90 days of arriving) are charged to your saved card now, all checked against this key’s spending controls; send an Idempotency-Key.
                CreateBuyerVaultWithdrawResponse result = apiInstance.CreateBuyerVaultWithdraw(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerVaultWithdraw: " + e.Message );
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

**CreateBuyerVaultWithdrawResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerwishlist"></a>
# **CreateBuyerWishlist**
> CreateBuyerWishlistResponse CreateBuyerWishlist (CreateBuyerWishlistRequest createBuyerWishlistRequest)

Create a wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var createBuyerWishlistRequest = new CreateBuyerWishlistRequest(); // CreateBuyerWishlistRequest | 

            try
            {
                // Create a wishlist.
                CreateBuyerWishlistResponse result = apiInstance.CreateBuyerWishlist(createBuyerWishlistRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerWishlist: " + e.Message );
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
 **createBuyerWishlistRequest** | **CreateBuyerWishlistRequest**|  | 

### Return type

**CreateBuyerWishlistResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerwishlistinvite"></a>
# **CreateBuyerWishlistInvite**
> CreateBuyerWishlistInviteResponse CreateBuyerWishlistInvite (string id)

Share a wishlist with a co-editor: a single-use link (14 days). Members add and remove items; only the owner renames, deletes or removes members. At most 20.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerWishlistInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Share a wishlist with a co-editor: a single-use link (14 days). Members add and remove items; only the owner renames, deletes or removes members. At most 20.
                CreateBuyerWishlistInviteResponse result = apiInstance.CreateBuyerWishlistInvite(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerWishlistInvite: " + e.Message );
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

**CreateBuyerWishlistInviteResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerwishlistitem"></a>
# **CreateBuyerWishlistItem**
> BuyerResponse2 CreateBuyerWishlistItem (Guid id, CreateBuyerWishlistItemRequest createBuyerWishlistItemRequest)

Add a listing to a wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerWishlistItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | 
            var createBuyerWishlistItemRequest = new CreateBuyerWishlistItemRequest(); // CreateBuyerWishlistItemRequest | 

            try
            {
                // Add a listing to a wishlist.
                BuyerResponse2 result = apiInstance.CreateBuyerWishlistItem(id, createBuyerWishlistItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerWishlistItem: " + e.Message );
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
 **createBuyerWishlistItemRequest** | **CreateBuyerWishlistItemRequest**|  | 

### Return type

**BuyerResponse2**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="createbuyerwishlistjoin"></a>
# **CreateBuyerWishlistJoin**
> CreateBuyerWishlistJoinResponse CreateBuyerWishlistJoin (string token)

Join a wishlist you were invited to edit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerWishlistJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var token = "token_example";  // string | 

            try
            {
                // Join a wishlist you were invited to edit.
                CreateBuyerWishlistJoinResponse result = apiInstance.CreateBuyerWishlistJoin(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerWishlistJoin: " + e.Message );
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
 **token** | **string**|  | 

### Return type

**CreateBuyerWishlistJoinResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createbuyerwishlistshare"></a>
# **CreateBuyerWishlistShare**
> CreateBuyerWishlistShareResponse CreateBuyerWishlistShare (Guid id, CreateBuyerWishlistShareRequest createBuyerWishlistShareRequest)

Share a wishlist — makes it public and returns its link.

`resetLink: true` issues a new link and kills the old one, for a link that went further than intended. To stop sharing, PATCH the list with isPublic: false.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class CreateBuyerWishlistShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var createBuyerWishlistShareRequest = new CreateBuyerWishlistShareRequest(); // CreateBuyerWishlistShareRequest | 

            try
            {
                // Share a wishlist — makes it public and returns its link.
                CreateBuyerWishlistShareResponse result = apiInstance.CreateBuyerWishlistShare(id, createBuyerWishlistShareRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.CreateBuyerWishlistShare: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **createBuyerWishlistShareRequest** | **CreateBuyerWishlistShareRequest**|  | 

### Return type

**CreateBuyerWishlistShareResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="deletebuyerboard"></a>
# **DeleteBuyerBoard**
> BuyerResponse DeleteBuyerBoard (string id)

Delete a board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a board.
                BuyerResponse result = apiInstance.DeleteBuyerBoard(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerBoard: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerboarditem"></a>
# **DeleteBuyerBoardItem**
> BuyerResponse DeleteBuyerBoardItem (string id, string platformListingId)

Take a listing off a board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerBoardItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var platformListingId = "platformListingId_example";  // string | 

            try
            {
                // Take a listing off a board.
                BuyerResponse result = apiInstance.DeleteBuyerBoardItem(id, platformListingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerBoardItem: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerbreakspothold"></a>
# **DeleteBuyerBreakSpotHold**
> BuyerResponse DeleteBuyerBreakSpotHold (string id, string spotId)

Release a break spot you hold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerBreakSpotHoldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var spotId = "spotId_example";  // string | 

            try
            {
                // Release a break spot you hold.
                BuyerResponse result = apiInstance.DeleteBuyerBreakSpotHold(id, spotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerBreakSpotHold: " + e.Message );
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
 **spotId** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyercartitem"></a>
# **DeleteBuyerCartItem**
> void DeleteBuyerCartItem (Guid id)

Remove a line from your cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerCartItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Remove a line from your cart.
                apiInstance.DeleteBuyerCartItem(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerCartItem: " + e.Message );
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

void (empty response body)

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="deletebuyercartsaved"></a>
# **DeleteBuyerCartSaved**
> BuyerCartResponse DeleteBuyerCartSaved (Guid id)

Remove an item from saved-for-later. Returns the remaining list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerCartSavedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Remove an item from saved-for-later. Returns the remaining list.
                BuyerCartResponse result = apiInstance.DeleteBuyerCartSaved(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerCartSaved: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerCartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerconversationguest"></a>
# **DeleteBuyerConversationGuest**
> BuyerResponse DeleteBuyerConversationGuest (string id, string userId)

Remove a guest (the thread’s buyer), or leave (a guest, with your own user id).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerConversationGuestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Remove a guest (the thread’s buyer), or leave (a guest, with your own user id).
                BuyerResponse result = apiInstance.DeleteBuyerConversationGuest(id, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerConversationGuest: " + e.Message );
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
 **userId** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerfitref"></a>
# **DeleteBuyerFitRef**
> BuyerResponse DeleteBuyerFitRef (string id)

Delete a reference garment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerFitRefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a reference garment.
                BuyerResponse result = apiInstance.DeleteBuyerFitRef(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerFitRef: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyermarketbid"></a>
# **DeleteBuyerMarketBid**
> BuyerResponse DeleteBuyerMarketBid (string id)

Cancel a resting market bid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerMarketBidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a resting market bid.
                BuyerResponse result = apiInstance.DeleteBuyerMarketBid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerMarketBid: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyermarketwatch"></a>
# **DeleteBuyerMarketWatch**
> BuyerResponse DeleteBuyerMarketWatch (string id)

Stop watching a market variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerMarketWatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Stop watching a market variant.
                BuyerResponse result = apiInstance.DeleteBuyerMarketWatch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerMarketWatch: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyeroffer"></a>
# **DeleteBuyerOffer**
> BuyerResponse DeleteBuyerOffer (Guid id)

Withdraw an offer you made that the seller has not answered.

Only a pending offer can be withdrawn — an accepted price the seller agreed to cannot be taken back here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The offer id.

            try
            {
                // Withdraw an offer you made that the seller has not answered.
                BuyerResponse result = apiInstance.DeleteBuyerOffer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerOffer: " + e.Message );
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
 **id** | **Guid**| The offer id. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerrecentlyviewed"></a>
# **DeleteBuyerRecentlyViewed**
> BuyerResponse DeleteBuyerRecentlyViewed (string slug)

Remove one listing from your recently viewed.

Viewing it again brings it back. Sellers’ view counts are unaffected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerRecentlyViewedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The listing slug.

            try
            {
                // Remove one listing from your recently viewed.
                BuyerResponse result = apiInstance.DeleteBuyerRecentlyViewed(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerRecentlyViewed: " + e.Message );
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
 **slug** | **string**| The listing slug. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerrecentlyviewed2"></a>
# **DeleteBuyerRecentlyViewed2**
> BuyerResponse DeleteBuyerRecentlyViewed2 ()

Clear your recently viewed list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerRecentlyViewed2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Clear your recently viewed list.
                BuyerResponse result = apiInstance.DeleteBuyerRecentlyViewed2();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerRecentlyViewed2: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerregistry"></a>
# **DeleteBuyerRegistry**
> BuyerResponse DeleteBuyerRegistry (string id)

Delete a registry (and the wishlist behind it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a registry (and the wishlist behind it).
                BuyerResponse result = apiInstance.DeleteBuyerRegistry(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerRegistry: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyersellerclubjoin"></a>
# **DeleteBuyerSellerClubJoin**
> BuyerResponse DeleteBuyerSellerClubJoin (string sellerUserId)

Leave a seller’s loyalty club.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerSellerClubJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var sellerUserId = "sellerUserId_example";  // string | 

            try
            {
                // Leave a seller’s loyalty club.
                BuyerResponse result = apiInstance.DeleteBuyerSellerClubJoin(sellerUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerSellerClubJoin: " + e.Message );
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
 **sellerUserId** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyertogetheritem"></a>
# **DeleteBuyerTogetherItem**
> BuyerResponse DeleteBuyerTogetherItem (string code, string id)

Take an item you added off a room’s board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerTogetherItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Take an item you added off a room’s board.
                BuyerResponse result = apiInstance.DeleteBuyerTogetherItem(code, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerTogetherItem: " + e.Message );
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
 **code** | **string**|  | 
 **id** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyertotalrequest"></a>
# **DeleteBuyerTotalRequest**
> BuyerResponse DeleteBuyerTotalRequest (Guid id)

Cancel a total request you made.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerTotalRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Cancel a total request you made.
                BuyerResponse result = apiInstance.DeleteBuyerTotalRequest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerTotalRequest: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyertryon"></a>
# **DeleteBuyerTryOn**
> DeleteBuyerTryOnResponse DeleteBuyerTryOn (string id)

Delete a try-on and its images — or pass `all` to delete every photo and result.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerTryOnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a try-on and its images — or pass `all` to delete every photo and result.
                DeleteBuyerTryOnResponse result = apiInstance.DeleteBuyerTryOn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerTryOn: " + e.Message );
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

**DeleteBuyerTryOnResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerwishlist"></a>
# **DeleteBuyerWishlist**
> BuyerResponse DeleteBuyerWishlist (Guid id)

Delete a wishlist and everything on it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // Delete a wishlist and everything on it.
                BuyerResponse result = apiInstance.DeleteBuyerWishlist(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerWishlist: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerwishlistitem"></a>
# **DeleteBuyerWishlistItem**
> DeleteBuyerWishlistItemResponse DeleteBuyerWishlistItem (Guid id, string slug)

Take a listing off a wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerWishlistItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The wishlist id.
            var slug = "slug_example";  // string | The listing slug.

            try
            {
                // Take a listing off a wishlist.
                DeleteBuyerWishlistItemResponse result = apiInstance.DeleteBuyerWishlistItem(id, slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerWishlistItem: " + e.Message );
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
 **id** | **Guid**| The wishlist id. | 
 **slug** | **string**| The listing slug. | 

### Return type

**DeleteBuyerWishlistItemResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletebuyerwishlistmember"></a>
# **DeleteBuyerWishlistMember**
> BuyerResponse DeleteBuyerWishlistMember (string id, string userId)

Remove a co-editor (the owner), or leave a list shared with you (your own user id).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class DeleteBuyerWishlistMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Remove a co-editor (the owner), or leave a list shared with you (your own user id).
                BuyerResponse result = apiInstance.DeleteBuyerWishlistMember(id, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.DeleteBuyerWishlistMember: " + e.Message );
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
 **userId** | **string**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerauctionme"></a>
# **GetBuyerAuctionMe**
> GetBuyerAuctionMeResponse GetBuyerAuctionMe (string slug)

Where you stand in one auction — your max, leading, won, must you pay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerAuctionMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The auction listing slug.

            try
            {
                // Where you stand in one auction — your max, leading, won, must you pay.
                GetBuyerAuctionMeResponse result = apiInstance.GetBuyerAuctionMe(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerAuctionMe: " + e.Message );
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
 **slug** | **string**| The auction listing slug. | 

### Return type

**GetBuyerAuctionMeResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerbadge"></a>
# **GetBuyerBadge**
> GetBuyerBadgeResponse GetBuyerBadge ()

The counts behind the account badge — unread messages, offers waiting, orders to review.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerBadgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The counts behind the account badge — unread messages, offers waiting, orders to review.
                GetBuyerBadgeResponse result = apiInstance.GetBuyerBadge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerBadge: " + e.Message );
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

**GetBuyerBadgeResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerboard"></a>
# **GetBuyerBoard**
> BuyerBoardResponse GetBuyerBoard (string id)

One of your boards with its layout: each item’s x, y and width as fractions of the board, and stacking order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One of your boards with its layout: each item’s x, y and width as fractions of the board, and stacking order.
                BuyerBoardResponse result = apiInstance.GetBuyerBoard(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerBoard: " + e.Message );
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

**BuyerBoardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerboardshared"></a>
# **GetBuyerBoardShared**
> BuyerBoardResponse GetBuyerBoardShared (string token)

A shared outfit board, by its link token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerBoardSharedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var token = "token_example";  // string | 

            try
            {
                // A shared outfit board, by its link token.
                BuyerBoardResponse result = apiInstance.GetBuyerBoardShared(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerBoardShared: " + e.Message );
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
 **token** | **string**|  | 

### Return type

**BuyerBoardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerbreak"></a>
# **GetBuyerBreak**
> GetBuyerBreakResponse GetBuyerBreak (string id)

A card break’s board: spots, holders, and the seed after the draw.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerBreakExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A card break’s board: spots, holders, and the seed after the draw.
                GetBuyerBreakResponse result = apiInstance.GetBuyerBreak(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerBreak: " + e.Message );
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

**GetBuyerBreakResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercase"></a>
# **GetBuyerCase**
> GetBuyerCaseResponse GetBuyerCase (Guid id)

One case — its state, the message thread, and the return parcel if there is one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // One case — its state, the message thread, and the return parcel if there is one.
                GetBuyerCaseResponse result = apiInstance.GetBuyerCase(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCase: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**GetBuyerCaseResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercataloglistingmysize"></a>
# **GetBuyerCatalogListingMySize**
> GetBuyerCatalogListingMySizeResponse GetBuyerCatalogListingMySize (string slug)

This item against your size: the size you keep in this kind of item (and in this brand), whether this one is your size, smaller or larger, a warning if this brand and size ran small or large on you before, and how other buyers say the brand runs. null for an unsized item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingMySizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // This item against your size: the size you keep in this kind of item (and in this brand), whether this one is your size, smaller or larger, a warning if this brand and size ran small or large on you before, and how other buyers say the brand runs. null for an unsized item.
                GetBuyerCatalogListingMySizeResponse result = apiInstance.GetBuyerCatalogListingMySize(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCatalogListingMySize: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerCatalogListingMySizeResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercataloglistingprice"></a>
# **GetBuyerCatalogListingPrice**
> GetBuyerCatalogListingPriceResponse GetBuyerCatalogListingPrice (string slug)

The price today. When the seller has the same item live on another marketplace for less, this IS that price (`priceMatch` says where from), and `lowestAnywhere` lists the marketplaces it is guaranteed not to be cheaper on. `priceCheck` rates it against real sales of the same catalog item in the same condition over the last 180 days (great / good / fair / high, with the median and middle-half range in cents); null until there are 3+ sales from 2+ sellers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The price today. When the seller has the same item live on another marketplace for less, this IS that price (`priceMatch` says where from), and `lowestAnywhere` lists the marketplaces it is guaranteed not to be cheaper on. `priceCheck` rates it against real sales of the same catalog item in the same condition over the last 180 days (great / good / fair / high, with the median and middle-half range in cents); null until there are 3+ sales from 2+ sellers.
                GetBuyerCatalogListingPriceResponse result = apiInstance.GetBuyerCatalogListingPrice(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCatalogListingPrice: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerCatalogListingPriceResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercataloglistingrental"></a>
# **GetBuyerCatalogListingRental**
> GetBuyerCatalogListingRentalResponse GetBuyerCatalogListingRental (string slug)

Whether a listing is for rent: day and week rates, the refundable deposit, length limits, the turnaround buffer, and the dates already booked. null when it is not for rent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCatalogListingRentalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Whether a listing is for rent: day and week rates, the refundable deposit, length limits, the turnaround buffer, and the dates already booked. null when it is not for rent.
                GetBuyerCatalogListingRentalResponse result = apiInstance.GetBuyerCatalogListingRental(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCatalogListingRental: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerCatalogListingRentalResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercheckoutusdc"></a>
# **GetBuyerCheckoutUsdc**
> GetBuyerCheckoutUsdcResponse GetBuyerCheckoutUsdc ()

Whether Crossly takes USDC (Stripe stablecoin payments: Solana, Ethereum, Base, Polygon), and its per-order limit. Paying needs the buyer’s wallet, so it happens in the browser checkout, never unattended.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCheckoutUsdcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Whether Crossly takes USDC (Stripe stablecoin payments: Solana, Ethereum, Base, Polygon), and its per-order limit. Paying needs the buyer’s wallet, so it happens in the browser checkout, never unattended.
                GetBuyerCheckoutUsdcResponse result = apiInstance.GetBuyerCheckoutUsdc();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCheckoutUsdc: " + e.Message );
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

**GetBuyerCheckoutUsdcResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercollectionoffer"></a>
# **GetBuyerCollectionOffer**
> GetBuyerCollectionOfferResponse GetBuyerCollectionOffer (string id)

What an item in your collection would fetch now: the top open bid on the market for the same variant, condition and grade, and Crossly’s instant offer in store credit when that is switched on (a quote valid for a limited time).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCollectionOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // What an item in your collection would fetch now: the top open bid on the market for the same variant, condition and grade, and Crossly’s instant offer in store credit when that is switched on (a quote valid for a limited time).
                GetBuyerCollectionOfferResponse result = apiInstance.GetBuyerCollectionOffer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCollectionOffer: " + e.Message );
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

**GetBuyerCollectionOfferResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercollectionset"></a>
# **GetBuyerCollectionSet**
> GetBuyerCollectionSetResponse GetBuyerCollectionSet (string category, string brand, string model)

One set: every piece (owned or missing, with its lowest ask on the market), what completing it would cost now, and the leaderboard of collectors who opted in, with your rank.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCollectionSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var category = "category_example";  // string | 
            var brand = "brand_example";  // string | 
            var model = "model_example";  // string | 

            try
            {
                // One set: every piece (owned or missing, with its lowest ask on the market), what completing it would cost now, and the leaderboard of collectors who opted in, with your rank.
                GetBuyerCollectionSetResponse result = apiInstance.GetBuyerCollectionSet(category, brand, model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCollectionSet: " + e.Message );
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
 **category** | **string**|  | 
 **brand** | **string**|  | 
 **model** | **string**|  | 

### Return type

**GetBuyerCollectionSetResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyercreator"></a>
# **GetBuyerCreator**
> GetBuyerCreatorResponse GetBuyerCreator (string handle)

A creator storefront: profile, affiliate code, and shelves of live picks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerCreatorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var handle = "handle_example";  // string | 

            try
            {
                // A creator storefront: profile, affiliate code, and shelves of live picks.
                GetBuyerCreatorResponse result = apiInstance.GetBuyerCreator(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerCreator: " + e.Message );
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

**GetBuyerCreatorResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerfitvocabulary"></a>
# **GetBuyerFitVocabulary**
> GetBuyerFitVocabularyResponse GetBuyerFitVocabulary ()

Garment kinds and the measurements each takes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerFitVocabularyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Garment kinds and the measurements each takes.
                GetBuyerFitVocabularyResponse result = apiInstance.GetBuyerFitVocabulary();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerFitVocabulary: " + e.Message );
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

**GetBuyerFitVocabularyResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyergiftfinderoption"></a>
# **GetBuyerGiftFinderOption**
> GetBuyerGiftFinderOptionResponse GetBuyerGiftFinderOption ()

The gift finder’s questions: recipients, interests, budgets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerGiftFinderOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The gift finder’s questions: recipients, interests, budgets.
                GetBuyerGiftFinderOptionResponse result = apiInstance.GetBuyerGiftFinderOption();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerGiftFinderOption: " + e.Message );
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

**GetBuyerGiftFinderOptionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerimpact"></a>
# **GetBuyerImpact**
> GetBuyerImpactResponse GetBuyerImpact ()

The sourced footprint your secondhand purchases avoided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerImpactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The sourced footprint your secondhand purchases avoided.
                GetBuyerImpactResponse result = apiInstance.GetBuyerImpact();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerImpact: " + e.Message );
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

**GetBuyerImpactResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlayaway"></a>
# **GetBuyerLayaway**
> BuyerLayawayResponse GetBuyerLayaway (string id)

One layaway and its schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerLayawayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One layaway and its schedule.
                BuyerLayawayResponse result = apiInstance.GetBuyerLayaway(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerLayaway: " + e.Message );
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

**BuyerLayawayResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingaudiosummary"></a>
# **GetBuyerListingAudioSummary**
> GetBuyerListingAudioSummaryResponse GetBuyerListingAudioSummary (string slug)

A spoken summary of a listing (accessibility): the text, built only from the listing’s own fields and the seller’s description, and the recording of it when one exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingAudioSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A spoken summary of a listing (accessibility): the text, built only from the listing’s own fields and the seller’s description, and the recording of it when one exists.
                GetBuyerListingAudioSummaryResponse result = apiInstance.GetBuyerListingAudioSummary(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingAudioSummary: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingAudioSummaryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingboughttogether"></a>
# **GetBuyerListingBoughtTogether**
> GetBuyerListingBoughtTogetherResponse GetBuyerListingBoughtTogether (string slug)

Frequently bought together / complete the look.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingBoughtTogetherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Frequently bought together / complete the look.
                GetBuyerListingBoughtTogetherResponse result = apiInstance.GetBuyerListingBoughtTogether(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingBoughtTogether: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingBoughtTogetherResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingbreak"></a>
# **GetBuyerListingBreak**
> GetBuyerListingBreakResponse GetBuyerListingBreak (string slug)

The card break this listing sells spots in, if any; the seed is revealed after the draw.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingBreakExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The card break this listing sells spots in, if any; the seed is revealed after the draw.
                GetBuyerListingBreakResponse result = apiInstance.GetBuyerListingBreak(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingBreak: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingBreakResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingcert"></a>
# **GetBuyerListingCert**
> GetBuyerListingCertResponse GetBuyerListingCert (string slug)

A graded listing’s cert, checked with the grader: the seller’s claim (grader, grade, cert number), status (verified, mismatch, not_found, or unchecked where the grader has no lookup), population and how many graded higher where the grader publishes them, and the grader’s own cert page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingCertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A graded listing’s cert, checked with the grader: the seller’s claim (grader, grade, cert number), status (verified, mismatch, not_found, or unchecked where the grader has no lookup), population and how many graded higher where the grader publishes them, and the grader’s own cert page.
                GetBuyerListingCertResponse result = apiInstance.GetBuyerListingCert(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingCert: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingCertResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingfit"></a>
# **GetBuyerListingFit**
> GetBuyerListingFitResponse GetBuyerListingFit (string slug)

A listing’s flat measurements, compared with your saved reference garments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingFitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // A listing’s flat measurements, compared with your saved reference garments.
                GetBuyerListingFitResponse result = apiInstance.GetBuyerListingFit(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingFit: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingFitResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistinggroupbuy"></a>
# **GetBuyerListingGroupBuy**
> GetBuyerListingGroupBuyResponse GetBuyerListingGroupBuy (string slug)

The group buy open on this listing, if any.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingGroupBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The group buy open on this listing, if any.
                GetBuyerListingGroupBuyResponse result = apiInstance.GetBuyerListingGroupBuy(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingGroupBuy: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingGroupBuyResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingimpact"></a>
# **GetBuyerListingImpact**
> GetBuyerListingImpactResponse GetBuyerListingImpact (string slug)

The sourced footprint of making a new equivalent; null when no published figure applies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingImpactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The sourced footprint of making a new equivalent; null when no published figure applies.
                GetBuyerListingImpactResponse result = apiInstance.GetBuyerListingImpact(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingImpact: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingImpactResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingresalevalue"></a>
# **GetBuyerListingResaleValue**
> GetBuyerListingResaleValueResponse GetBuyerListingResaleValue (string slug)

What the same brand and category resold for on Crossly, and the buyback offer when enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingResaleValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // What the same brand and category resold for on Crossly, and the buyback offer when enabled.
                GetBuyerListingResaleValueResponse result = apiInstance.GetBuyerListingResaleValue(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingResaleValue: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingResaleValueResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingsubscribeoffer"></a>
# **GetBuyerListingSubscribeOffer**
> GetBuyerListingSubscribeOfferResponse GetBuyerListingSubscribeOffer (string slug)

The subscribe & save discount and intervals on a listing; null when the seller has none.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingSubscribeOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The subscribe & save discount and intervals on a listing; null when the seller has none.
                GetBuyerListingSubscribeOfferResponse result = apiInstance.GetBuyerListingSubscribeOffer(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingSubscribeOffer: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingSubscribeOfferResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlistingtryon"></a>
# **GetBuyerListingTryOn**
> GetBuyerListingTryOnResponse GetBuyerListingTryOn (string slug)

Whether an AI try-on is offered for this listing (a wearable with a photo) and whether the image model is configured.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerListingTryOnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Whether an AI try-on is offered for this listing (a wearable with a photo) and whether the image model is configured.
                GetBuyerListingTryOnResponse result = apiInstance.GetBuyerListingTryOn(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerListingTryOn: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerListingTryOnResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerlivestreamauction"></a>
# **GetBuyerLiveStreamAuction**
> GetBuyerLiveStreamAuctionResponse GetBuyerLiveStreamAuction (string id)

The auction running on a live stream right now, if any. Bid on it by its `slug` at POST /v1/buyer/auctions/:slug/bids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerLiveStreamAuctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The auction running on a live stream right now, if any. Bid on it by its `slug` at POST /v1/buyer/auctions/:slug/bids.
                GetBuyerLiveStreamAuctionResponse result = apiInstance.GetBuyerLiveStreamAuction(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerLiveStreamAuction: " + e.Message );
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

**GetBuyerLiveStreamAuctionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyermarketpurchaseoption"></a>
# **GetBuyerMarketPurchaseOption**
> GetBuyerMarketPurchaseOptionResponse GetBuyerMarketPurchaseOption ()

Before you bid or buy: whether the lowest ask is vault stock (keep it vaulted, or pay fastShipCents to rush it), and the grading runs a raw card can go straight to (pass gradeWith on the bid).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerMarketPurchaseOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Before you bid or buy: whether the lowest ask is vault stock (keep it vaulted, or pay fastShipCents to rush it), and the grading runs a raw card can go straight to (pass gradeWith on the bid).
                GetBuyerMarketPurchaseOptionResponse result = apiInstance.GetBuyerMarketPurchaseOption();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerMarketPurchaseOption: " + e.Message );
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

**GetBuyerMarketPurchaseOptionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerordereligibility"></a>
# **GetBuyerOrderEligibility**
> GetBuyerOrderEligibilityResponse GetBuyerOrderEligibility (Guid id)

What you can do with one order right now — cancel, confirm receipt, report not received, leave feedback.

`inr.eligible` says whether an item-not-received case can be opened; when it cannot, `inr.reason` says why and `inr.opensAt` when it will. The same rules the order page and the action routes enforce.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerOrderEligibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.

            try
            {
                // What you can do with one order right now — cancel, confirm receipt, report not received, leave feedback.
                GetBuyerOrderEligibilityResponse result = apiInstance.GetBuyerOrderEligibility(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerOrderEligibility: " + e.Message );
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
 **id** | **Guid**| The id. | 

### Return type

**GetBuyerOrderEligibilityResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerorderexport"></a>
# **GetBuyerOrderExport**
> GetBuyerOrderExportResponse GetBuyerOrderExport (string from = null, string to = null)

Your order history as CSV text (up to 5,000 orders).

The same CSV the shop downloads, returned as a string in `data.csv` so a program or agent can read it without a file download. Money columns are dollars, as a spreadsheet expects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerOrderExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var from = "from_example";  // string | First day to include, YYYY-MM-DD. (optional) 
            var to = "to_example";  // string | Last day to include, YYYY-MM-DD (inclusive). (optional) 

            try
            {
                // Your order history as CSV text (up to 5,000 orders).
                GetBuyerOrderExportResponse result = apiInstance.GetBuyerOrderExport(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerOrderExport: " + e.Message );
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
 **from** | **string**| First day to include, YYYY-MM-DD. | [optional] 
 **to** | **string**| Last day to include, YYYY-MM-DD (inclusive). | [optional] 

### Return type

**GetBuyerOrderExportResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerorderpriceprotection"></a>
# **GetBuyerOrderPriceProtection**
> GetBuyerOrderPriceProtectionResponse GetBuyerOrderPriceProtection (string id)

Price protection on one order: if the item gets cheaper before `until`, the difference is credited to your Bucks automatically. `creditedCents` is what it has paid so far.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerOrderPriceProtectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Price protection on one order: if the item gets cheaper before `until`, the difference is credited to your Bucks automatically. `creditedCents` is what it has paid so far.
                GetBuyerOrderPriceProtectionResponse result = apiInstance.GetBuyerOrderPriceProtection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerOrderPriceProtection: " + e.Message );
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

**GetBuyerOrderPriceProtectionResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpack"></a>
# **GetBuyerPack**
> GetBuyerPackResponse GetBuyerPack (string slug)

One pack: tiers and odds, items left, expected value, the chase items still in it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One pack: tiers and odds, items left, expected value, the chase items still in it.
                GetBuyerPackResponse result = apiInstance.GetBuyerPack(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPack: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerPackResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpackfairness"></a>
# **GetBuyerPackFairness**
> GetBuyerPackFairnessResponse GetBuyerPackFairness ()

Your provably-fair seeds: the active server-seed commitment (sha256), your client seed and nonce, and every retired seed in full so past openings can be re-run.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPackFairnessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your provably-fair seeds: the active server-seed commitment (sha256), your client seed and nonce, and every retired seed in full so past openings can be re-run.
                GetBuyerPackFairnessResponse result = apiInstance.GetBuyerPackFairness();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPackFairness: " + e.Message );
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

**GetBuyerPackFairnessResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerparty"></a>
# **GetBuyerParty**
> GetBuyerPartyResponse GetBuyerParty (string slug)

One shopping party.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPartyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One shopping party.
                GetBuyerPartyResponse result = apiInstance.GetBuyerParty(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerParty: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerPartyResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpassport"></a>
# **GetBuyerPassport**
> GetBuyerPassportResponse GetBuyerPassport (string code)

What a product passport tag opens: the item, whether it was authenticated, how many owners on Crossly and since when — never who or for how much.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPassportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // What a product passport tag opens: the item, whether it was authenticated, how many owners on Crossly and since when — never who or for how much.
                GetBuyerPassportResponse result = apiInstance.GetBuyerPassport(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPassport: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**GetBuyerPassportResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpreference"></a>
# **GetBuyerPreference**
> GetBuyerPreferenceResponse GetBuyerPreference ()

The shopping profile derived from that activity.

Derived, never declared — there is no preferences form anywhere. `matchRate` is the share of this person's searches Crossly could answer; a low number is an inventory problem, not a personalisation one, which is why it is here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The shopping profile derived from that activity.
                GetBuyerPreferenceResponse result = apiInstance.GetBuyerPreference();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPreference: " + e.Message );
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

**GetBuyerPreferenceResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpriceguide"></a>
# **GetBuyerPriceGuide**
> GetBuyerPriceGuideResponse GetBuyerPriceGuide ()

What matching items actually sold for on Crossly: median, quartiles, by month, and recent sales. Needs q, brand or category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPriceGuideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // What matching items actually sold for on Crossly: median, quartiles, by month, and recent sales. Needs q, brand or category.
                GetBuyerPriceGuideResponse result = apiInstance.GetBuyerPriceGuide();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPriceGuide: " + e.Message );
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

**GetBuyerPriceGuideResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerprofile"></a>
# **GetBuyerProfile**
> GetBuyerProfileResponse GetBuyerProfile ()

Your Crossly shopping profile — name, email, saved address, Bucks balance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your Crossly shopping profile — name, email, saved address, Bucks balance.
                GetBuyerProfileResponse result = apiInstance.GetBuyerProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerProfile: " + e.Message );
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

**GetBuyerProfileResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpurchasedelivery"></a>
# **GetBuyerPurchaseDelivery**
> GetBuyerPurchaseDeliveryResponse GetBuyerPurchaseDelivery (string id)

Where a purchase is going when not to your door: the pickup point (with its release code) or its ship-together consolidation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPurchaseDeliveryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Where a purchase is going when not to your door: the pickup point (with its release code) or its ship-together consolidation.
                GetBuyerPurchaseDeliveryResponse result = apiInstance.GetBuyerPurchaseDelivery(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPurchaseDelivery: " + e.Message );
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

**GetBuyerPurchaseDeliveryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpurchaselivemoment"></a>
# **GetBuyerPurchaseLiveMoment**
> GetBuyerPurchaseLiveMomentResponse GetBuyerPurchaseLiveMoment (string id)

The live show a purchase was bought in, with the offset (seconds) into its replay where it sold. null when it was not bought in a show.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPurchaseLiveMomentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The live show a purchase was bought in, with the offset (seconds) into its replay where it sold. null when it was not bought in a show.
                GetBuyerPurchaseLiveMomentResponse result = apiInstance.GetBuyerPurchaseLiveMoment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPurchaseLiveMoment: " + e.Message );
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

**GetBuyerPurchaseLiveMomentResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpurchasereturn"></a>
# **GetBuyerPurchaseReturn**
> GetBuyerPurchaseReturnResponse GetBuyerPurchaseReturn (string id)

What a return would refund for each reason, by when, and any return already open.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPurchaseReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // What a return would refund for each reason, by when, and any return already open.
                GetBuyerPurchaseReturnResponse result = apiInstance.GetBuyerPurchaseReturn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPurchaseReturn: " + e.Message );
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

**GetBuyerPurchaseReturnResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerpurchasestory"></a>
# **GetBuyerPurchaseStory**
> GetBuyerPurchaseStoryResponse GetBuyerPurchaseStory (string id)

Your owner story on a purchase, passed on to the next owner if you resell it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerPurchaseStoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Your owner story on a purchase, passed on to the next owner if you resell it.
                GetBuyerPurchaseStoryResponse result = apiInstance.GetBuyerPurchaseStory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerPurchaseStory: " + e.Message );
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

**GetBuyerPurchaseStoryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerregistry"></a>
# **GetBuyerRegistry**
> BuyerRegistryResponse GetBuyerRegistry (string id)

One of your registries: items with how many are wanted and bought.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One of your registries: items with how many are wanted and bought.
                BuyerRegistryResponse result = apiInstance.GetBuyerRegistry(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerRegistry: " + e.Message );
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

**BuyerRegistryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerregistrybytoken"></a>
# **GetBuyerRegistryByToken**
> BuyerRegistryResponse GetBuyerRegistryByToken (string token)

A registry as a guest sees it: items, how many are still wanted, and whether it can ship. Never the address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerRegistryByTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var token = "token_example";  // string | 

            try
            {
                // A registry as a guest sees it: items, how many are still wanted, and whether it can ship. Never the address.
                BuyerRegistryResponse result = apiInstance.GetBuyerRegistryByToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerRegistryByToken: " + e.Message );
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
 **token** | **string**|  | 

### Return type

**BuyerRegistryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyerrentaleligibility"></a>
# **GetBuyerRentalEligibility**
> GetBuyerRentalEligibilityResponse GetBuyerRentalEligibility ()

Can you rent right now: ID-verified (a photo ID and a matching selfie, once), the verified name rentals ship to, and your standing (one rental at a time until your first comes back; none after one that never did).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerRentalEligibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Can you rent right now: ID-verified (a photo ID and a matching selfie, once), the verified name rentals ship to, and your standing (one rental at a time until your first comes back; none after one that never did).
                GetBuyerRentalEligibilityResponse result = apiInstance.GetBuyerRentalEligibility();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerRentalEligibility: " + e.Message );
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

**GetBuyerRentalEligibilityResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyersellerclub"></a>
# **GetBuyerSellerClub**
> GetBuyerSellerClubResponse GetBuyerSellerClub (string sellerUserId)

A seller’s loyalty club: its tiers (spend threshold, discount, perks) and your standing. null when the seller has none.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerSellerClubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var sellerUserId = "sellerUserId_example";  // string | 

            try
            {
                // A seller’s loyalty club: its tiers (spend threshold, discount, perks) and your standing. null when the seller has none.
                GetBuyerSellerClubResponse result = apiInstance.GetBuyerSellerClub(sellerUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerSellerClub: " + e.Message );
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
 **sellerUserId** | **string**|  | 

### Return type

**GetBuyerSellerClubResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyersellertrust"></a>
# **GetBuyerSellerTrust**
> GetBuyerSellerTrustResponse GetBuyerSellerTrust (string username)

Seller at a glance: member since, completed sales, independent rating, typical handling time, dispute rate, trust tier, badges — and the plain sentences the profile shows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerSellerTrustExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var username = "username_example";  // string | 

            try
            {
                // Seller at a glance: member since, completed sales, independent rating, typical handling time, dispute rate, trust tier, badges — and the plain sentences the profile shows.
                GetBuyerSellerTrustResponse result = apiInstance.GetBuyerSellerTrust(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerSellerTrust: " + e.Message );
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
 **username** | **string**|  | 

### Return type

**GetBuyerSellerTrustResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyertogether"></a>
# **GetBuyerTogether**
> GetBuyerTogetherResponse GetBuyerTogether (string code)

A shop-together room: members, the board with votes, and chat.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerTogetherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var code = "code_example";  // string | 

            try
            {
                // A shop-together room: members, the board with votes, and chat.
                GetBuyerTogetherResponse result = apiInstance.GetBuyerTogether(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerTogether: " + e.Message );
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
 **code** | **string**|  | 

### Return type

**GetBuyerTogetherResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyervaultmarkethistory"></a>
# **GetBuyerVaultMarketHistory**
> GetBuyerVaultMarketHistoryResponse GetBuyerVaultMarketHistory ()

Your Vault Markets value by day at the marks (oldest first, today live) over `days` (default 90), and today’s change against yesterday’s close.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerVaultMarketHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your Vault Markets value by day at the marks (oldest first, today live) over `days` (default 90), and today’s change against yesterday’s close.
                GetBuyerVaultMarketHistoryResponse result = apiInstance.GetBuyerVaultMarketHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerVaultMarketHistory: " + e.Message );
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

**GetBuyerVaultMarketHistoryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyervaultmarketindex"></a>
# **GetBuyerVaultMarketIndex**
> GetBuyerVaultMarketIndexResponse GetBuyerVaultMarketIndex (string slug)

One index with its published daily closes (oldest first, `days` default 365) and its level now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerVaultMarketIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One index with its published daily closes (oldest first, `days` default 365) and its level now.
                GetBuyerVaultMarketIndexResponse result = apiInstance.GetBuyerVaultMarketIndex(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerVaultMarketIndex: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**GetBuyerVaultMarketIndexResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyervaultmarketinstantexit"></a>
# **GetBuyerVaultMarketInstantExit**
> GetBuyerVaultMarketInstantExitResponse GetBuyerVaultMarketInstantExit (string id)

The Instant Exit quote for one vault unit you hold, and whether it can be sold now.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerVaultMarketInstantExitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The Instant Exit quote for one vault unit you hold, and whether it can be sold now.
                GetBuyerVaultMarketInstantExitResponse result = apiInstance.GetBuyerVaultMarketInstantExit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerVaultMarketInstantExit: " + e.Message );
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

**GetBuyerVaultMarketInstantExitResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getbuyervaultmarketworth"></a>
# **GetBuyerVaultMarketWorth**
> GetBuyerVaultMarketWorthResponse GetBuyerVaultMarketWorth ()

What your vault is worth now: value at the market prices (marks come only from trades) split into reliable and indicative marks, cost and P&L, today’s change, and an estimate of what the units free to sell would fetch from the bids resting on the book now. Read only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class GetBuyerVaultMarketWorthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // What your vault is worth now: value at the market prices (marks come only from trades) split into reliable and indicative marks, cost and P&L, today’s change, and an estimate of what the units free to sell would fetch from the bids resting on the book now. Read only.
                GetBuyerVaultMarketWorthResponse result = apiInstance.GetBuyerVaultMarketWorth();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.GetBuyerVaultMarketWorth: " + e.Message );
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

**GetBuyerVaultMarketWorthResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyeractivity"></a>
# **ListBuyerActivity**
> ListBuyerActivityResponse ListBuyerActivity ()

What this buyer has compared lately.

Newest first, and only as far back as the retention window — the link between a person and a comparison is dropped after 180 days, so this thins out rather than growing forever.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // What this buyer has compared lately.
                ListBuyerActivityResponse result = apiInstance.ListBuyerActivity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerActivity: " + e.Message );
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

**ListBuyerActivityResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerauctionbids"></a>
# **ListBuyerAuctionBids**
> ListBuyerAuctionBidsResponse ListBuyerAuctionBids (string slug)

An auction’s bid history, highest first, bidders anonymised.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerAuctionBidsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | The auction listing slug.

            try
            {
                // An auction’s bid history, highest first, bidders anonymised.
                ListBuyerAuctionBidsResponse result = apiInstance.ListBuyerAuctionBids(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerAuctionBids: " + e.Message );
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
 **slug** | **string**| The auction listing slug. | 

### Return type

**ListBuyerAuctionBidsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerauctions"></a>
# **ListBuyerAuctions**
> ListBuyerAuctionsResponse ListBuyerAuctions (string tab = null)

Auctions you have bid in — bidding, won or lost (last 100).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerAuctionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var tab = "bidding";  // string | bidding = still running; won = you are the winner; lost = ended, someone else won. (optional)  (default to bidding)

            try
            {
                // Auctions you have bid in — bidding, won or lost (last 100).
                ListBuyerAuctionsResponse result = apiInstance.ListBuyerAuctions(tab);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerAuctions: " + e.Message );
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
 **tab** | **string**| bidding &#x3D; still running; won &#x3D; you are the winner; lost &#x3D; ended, someone else won. | [optional] [default to bidding]

### Return type

**ListBuyerAuctionsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerboards"></a>
# **ListBuyerBoards**
> ListBuyerBoardsResponse ListBuyerBoards ()

Your outfit boards: collages of listings, each with a share link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerBoardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your outfit boards: collages of listings, each with a share link.
                ListBuyerBoardsResponse result = apiInstance.ListBuyerBoards();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerBoards: " + e.Message );
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

**ListBuyerBoardsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerbreaks"></a>
# **ListBuyerBreaks**
> BuyerResponse3 ListBuyerBreaks ()

Card-break spots you hold or bought, with what each pulled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerBreaksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Card-break spots you hold or bought, with what each pulled.
                BuyerResponse3 result = apiInstance.ListBuyerBreaks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerBreaks: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerbuybacks"></a>
# **ListBuyerBuybacks**
> BuyerResponse3 ListBuyerBuybacks ()

Your buyback guarantees and requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerBuybacksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your buyback guarantees and requests.
                BuyerResponse3 result = apiInstance.ListBuyerBuybacks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerBuybacks: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercart"></a>
# **ListBuyerCart**
> ListBuyerCartResponse ListBuyerCart ()

What is in your Crossly cart.

Line items with the price captured when each was added. This is NOT a quote — shipping, tax and any discounts are computed at checkout against a delivery address, and the sum of these lines is not what you will be charged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // What is in your Crossly cart.
                ListBuyerCartResponse result = apiInstance.ListBuyerCart();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCart: " + e.Message );
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

**ListBuyerCartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercartsaved"></a>
# **ListBuyerCartSaved**
> BuyerCartResponse ListBuyerCartSaved ()

Items you saved for later out of your cart (last 200).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCartSavedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Items you saved for later out of your cart (last 200).
                BuyerCartResponse result = apiInstance.ListBuyerCartSaved();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCartSaved: " + e.Message );
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

**BuyerCartResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercases"></a>
# **ListBuyerCases**
> ListBuyerCasesResponse ListBuyerCases (string status = null)

Resolution center — every case you opened (returns, not received, problems).

`yourTurn: true` means the case is waiting on you. `meta.counts` covers every case, not just this status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var status = "open";  // string | open = still being worked; closed = resolved or withdrawn; all = both. (optional)  (default to open)

            try
            {
                // Resolution center — every case you opened (returns, not received, problems).
                ListBuyerCasesResponse result = apiInstance.ListBuyerCases(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCases: " + e.Message );
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
 **status** | **string**| open &#x3D; still being worked; closed &#x3D; resolved or withdrawn; all &#x3D; both. | [optional] [default to open]

### Return type

**ListBuyerCasesResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercashback"></a>
# **ListBuyerCashback**
> ListBuyerCashbackResponse ListBuyerCashback (string status = null, int? page = null, int? limit = null)

Your Scout cashback — pending, confirmed, paid.

Newest first. `pending` means an order was reported and the retailer's return window has not closed; nothing is paid until it does. `expired` means a click was never reported as converting, which is the ordinary outcome for most clicks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCashbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var status = "pending";  // string |  (optional) 
            var page = 1;  // int? |  (optional)  (default to 1)
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // Your Scout cashback — pending, confirmed, paid.
                ListBuyerCashbackResponse result = apiInstance.ListBuyerCashback(status, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCashback: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListBuyerCashbackResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercataloglistingvideos"></a>
# **ListBuyerCatalogListingVideos**
> ListBuyerCatalogListingVideosResponse ListBuyerCatalogListingVideos (string slug)

Videos the seller recorded for this item on request, newest first, with the question each one answers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCatalogListingVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Videos the seller recorded for this item on request, newest first, with the question each one answers.
                ListBuyerCatalogListingVideosResponse result = apiInstance.ListBuyerCatalogListingVideos(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCatalogListingVideos: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ListBuyerCatalogListingVideosResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerclubs"></a>
# **ListBuyerClubs**
> ListBuyerClubsResponse ListBuyerClubs ()

Sellers’ loyalty clubs you belong to: your spend with each, your tier and its discount, and the next tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerClubsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Sellers’ loyalty clubs you belong to: your spend with each, your tier and its discount, and the next tier.
                ListBuyerClubsResponse result = apiInstance.ListBuyerClubs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerClubs: " + e.Message );
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

**ListBuyerClubsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyercollectionsets"></a>
# **ListBuyerCollectionSets**
> BuyerResponse3 ListBuyerCollectionSets ()

Sets you are collecting — a catalogue brand + model you own at least two pieces of — with owned / total and percent complete, most complete first; and whether you show on set leaderboards.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerCollectionSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Sets you are collecting — a catalogue brand + model you own at least two pieces of — with owned / total and percent complete, most complete first; and whether you show on set leaderboards.
                BuyerResponse3 result = apiInstance.ListBuyerCollectionSets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerCollectionSets: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerconsolidations"></a>
# **ListBuyerConsolidations**
> BuyerResponse3 ListBuyerConsolidations ()

Your ship-together orders: parcels at the hub, and the one box out.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerConsolidationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your ship-together orders: parcels at the hub, and the one box out.
                BuyerResponse3 result = apiInstance.ListBuyerConsolidations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerConsolidations: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerconversationguests"></a>
# **ListBuyerConversationGuests**
> ListBuyerWishlistMembersResponse ListBuyerConversationGuests (string id)

Guests in a chat.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerConversationGuestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Guests in a chat.
                ListBuyerWishlistMembersResponse result = apiInstance.ListBuyerConversationGuests(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerConversationGuests: " + e.Message );
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

**ListBuyerWishlistMembersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerfeedback"></a>
# **ListBuyerFeedback**
> ListBuyerFeedbackResponse ListBuyerFeedback ()

Feedback you have left sellers, newest first — with the ids you revise by.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Feedback you have left sellers, newest first — with the ids you revise by.
                ListBuyerFeedbackResponse result = apiInstance.ListBuyerFeedback();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerFeedback: " + e.Message );
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

**ListBuyerFeedbackResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerfeedbackpending"></a>
# **ListBuyerFeedbackPending**
> ListBuyerFeedbackPendingResponse ListBuyerFeedbackPending ()

Orders from the last 60 days that are on their way or arrived and still need your feedback.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerFeedbackPendingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Orders from the last 60 days that are on their way or arrived and still need your feedback.
                ListBuyerFeedbackPendingResponse result = apiInstance.ListBuyerFeedbackPending();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerFeedbackPending: " + e.Message );
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

**ListBuyerFeedbackPendingResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerfitrefs"></a>
# **ListBuyerFitRefs**
> BuyerResponse3 ListBuyerFitRefs ()

Your saved reference garments for fit comparison.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerFitRefsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your saved reference garments for fit comparison.
                BuyerResponse3 result = apiInstance.ListBuyerFitRefs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerFitRefs: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerfollowingsellers"></a>
# **ListBuyerFollowingSellers**
> ListBuyerFollowingSellersResponse ListBuyerFollowingSellers ()

Sellers you follow, with how many new listings each has since you last looked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerFollowingSellersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Sellers you follow, with how many new listings each has since you last looked.
                ListBuyerFollowingSellersResponse result = apiInstance.ListBuyerFollowingSellers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerFollowingSellers: " + e.Message );
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

**ListBuyerFollowingSellersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyergiftcardcredit"></a>
# **ListBuyerGiftCardCredit**
> ListBuyerGiftCardCreditResponse ListBuyerGiftCardCredit ()

Gift card credit on your account, and when it expires.

One row per gift card you redeemed. `meta.giftCreditCents` is the unspent, unexpired gift credit in your Crossly Bucks balance; `meta.nextExpiresAt` is the soonest date any of it lapses. Spending at checkout uses gift credit first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerGiftCardCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Gift card credit on your account, and when it expires.
                ListBuyerGiftCardCreditResponse result = apiInstance.ListBuyerGiftCardCredit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerGiftCardCredit: " + e.Message );
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

**ListBuyerGiftCardCreditResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyergiftcards"></a>
# **ListBuyerGiftCards**
> ListBuyerGiftCardsResponse ListBuyerGiftCards ()

Gift cards you bought, newest first.

Status, recipient and delivery for each card you paid for. The code is masked unless you sent the card to your own email address. Abandoned (unpaid) checkouts are omitted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerGiftCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Gift cards you bought, newest first.
                ListBuyerGiftCardsResponse result = apiInstance.ListBuyerGiftCards();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerGiftCards: " + e.Message );
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

**ListBuyerGiftCardsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyergiftfinder"></a>
# **ListBuyerGiftFinder**
> ListBuyerGiftFinderResponse ListBuyerGiftFinder ()

Live listings for a recipient, interest and budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerGiftFinderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Live listings for a recipient, interest and budget.
                ListBuyerGiftFinderResponse result = apiInstance.ListBuyerGiftFinder();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerGiftFinder: " + e.Message );
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

**ListBuyerGiftFinderResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyergiftsent"></a>
# **ListBuyerGiftSent**
> ListBuyerGiftSentResponse ListBuyerGiftSent ()

Items you sent as gifts: whether the teaser went out, whether it arrived and was opened, and any thank-you. Send one with `gift` on checkout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerGiftSentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Items you sent as gifts: whether the teaser went out, whether it arrived and was opened, and any thank-you. Send one with `gift` on checkout.
                ListBuyerGiftSentResponse result = apiInstance.ListBuyerGiftSent();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerGiftSent: " + e.Message );
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

**ListBuyerGiftSentResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerhotspots"></a>
# **ListBuyerHotspots**
> ListBuyerHotspotsResponse ListBuyerHotspots ()

Shop-the-look tags on a story or lookbook photo: each tagged listing and where it sits on the image (x, y as fractions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerHotspotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Shop-the-look tags on a story or lookbook photo: each tagged listing and where it sits on the image (x, y as fractions).
                ListBuyerHotspotsResponse result = apiInstance.ListBuyerHotspots();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerHotspots: " + e.Message );
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

**ListBuyerHotspotsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerhunts"></a>
# **ListBuyerHunts**
> ListBuyerHuntsResponse ListBuyerHunts ()

Your buyer-agent hunts and what they did.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerHuntsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your buyer-agent hunts and what they did.
                ListBuyerHuntsResponse result = apiInstance.ListBuyerHunts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerHunts: " + e.Message );
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

**ListBuyerHuntsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerinstantoffers"></a>
# **ListBuyerInstantOffers**
> BuyerResponse3 ListBuyerInstantOffers ()

Your instant offers: live quotes, accepted ones awaiting a label, approved ones (with the prepaid label) and paid ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerInstantOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your instant offers: live quotes, accepted ones awaiting a label, approved ones (with the prepaid label) and paid ones.
                BuyerResponse3 result = apiInstance.ListBuyerInstantOffers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerInstantOffers: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerlayaways"></a>
# **ListBuyerLayaways**
> ListBuyerLayawaysResponse ListBuyerLayaways ()

Your layaways: price, paid so far, what is left, and the installment schedule. Put an item on layaway at checkout with layawayItemIds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerLayawaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your layaways: price, paid so far, what is left, and the installment schedule. Put an item on layaway at checkout with layawayItemIds.
                ListBuyerLayawaysResponse result = apiInstance.ListBuyerLayaways();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerLayaways: " + e.Message );
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

**ListBuyerLayawaysResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerlistingquickquestions"></a>
# **ListBuyerListingQuickQuestions**
> ListBuyerListingQuickQuestionsResponse ListBuyerListingQuickQuestions (string slug)

One-tap questions this listing supports; send one as `quick` on a message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerListingQuickQuestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One-tap questions this listing supports; send one as `quick` on a message.
                ListBuyerListingQuickQuestionsResponse result = apiInstance.ListBuyerListingQuickQuestions(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerListingQuickQuestions: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ListBuyerListingQuickQuestionsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerlistingsellerreviews"></a>
# **ListBuyerListingSellerReviews**
> ListBuyerListingSellerReviewsResponse ListBuyerListingSellerReviews (string slug)

The seller’s public reviews: summary, text, photos, replies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerListingSellerReviewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The seller’s public reviews: summary, text, photos, replies.
                ListBuyerListingSellerReviewsResponse result = apiInstance.ListBuyerListingSellerReviews(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerListingSellerReviews: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**ListBuyerListingSellerReviewsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerliveshipments"></a>
# **ListBuyerLiveShipments**
> ListBuyerLiveShipmentsResponse ListBuyerLiveShipments ()

Your one-box-per-show shipments: every order won in a show ships together, and postage is charged once (the rest refunded when it ships).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerLiveShipmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your one-box-per-show shipments: every order won in a show ships together, and postage is charged once (the rest refunded when it ships).
                ListBuyerLiveShipmentsResponse result = apiInstance.ListBuyerLiveShipments();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerLiveShipments: " + e.Message );
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

**ListBuyerLiveShipmentsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerlivestreamlineup"></a>
# **ListBuyerLiveStreamLineup**
> ListBuyerLiveStreamLineupResponse ListBuyerLiveStreamLineup (string id)

What a live show will sell, in order: each item, its price, and whether it is still available.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerLiveStreamLineupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // What a live show will sell, in order: each item, its price, and whether it is still available.
                ListBuyerLiveStreamLineupResponse result = apiInstance.ListBuyerLiveStreamLineup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerLiveStreamLineup: " + e.Message );
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

**ListBuyerLiveStreamLineupResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyermarketbids"></a>
# **ListBuyerMarketBids**
> BuyerResponse3 ListBuyerMarketBids ()

Your resting market bids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerMarketBidsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your resting market bids.
                BuyerResponse3 result = apiInstance.ListBuyerMarketBids();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerMarketBids: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyermarketwatches"></a>
# **ListBuyerMarketWatches**
> BuyerResponse3 ListBuyerMarketWatches ()

Market variants you watch, with the price you are waiting for.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerMarketWatchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Market variants you watch, with the price you are waiting for.
                BuyerResponse3 result = apiInstance.ListBuyerMarketWatches();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerMarketWatches: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyeroffers"></a>
# **ListBuyerOffers**
> ListBuyerOffersResponse ListBuyerOffers (string awaitingBuyer = null)

Offers you have made, newest first (last 100).

`awaitingBuyer: true` is a seller counter waiting on you — answer it with POST /v1/buyer/offers/{id}/respond. `redeemable: true` is an accepted offer you can pay for on Crossly. Amounts are integer cents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var awaitingBuyer = "true";  // string | true returns only seller counters waiting on you. (optional) 

            try
            {
                // Offers you have made, newest first (last 100).
                ListBuyerOffersResponse result = apiInstance.ListBuyerOffers(awaitingBuyer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerOffers: " + e.Message );
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
 **awaitingBuyer** | **string**| true returns only seller counters waiting on you. | [optional] 

### Return type

**ListBuyerOffersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerorders"></a>
# **ListBuyerOrders**
> ListBuyerOrdersResponse ListBuyerOrders (int? page = null, int? limit = null)

What you have bought on Crossly, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var page = 1;  // int? |  (optional)  (default to 1)
            var limit = 25;  // int? |  (optional)  (default to 25)

            try
            {
                // What you have bought on Crossly, newest first.
                ListBuyerOrdersResponse result = apiInstance.ListBuyerOrders(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerOrders: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **limit** | **int?**|  | [optional] [default to 25]

### Return type

**ListBuyerOrdersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerpackopenings"></a>
# **ListBuyerPackOpenings**
> ListBuyerPackOpeningsResponse ListBuyerPackOpenings ()

Your pulls: what you got, its value, sell-back status, and the fairness proof for each (the server seed once rotated).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerPackOpeningsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your pulls: what you got, its value, sell-back status, and the fairness proof for each (the server seed once rotated).
                ListBuyerPackOpeningsResponse result = apiInstance.ListBuyerPackOpenings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerPackOpenings: " + e.Message );
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

**ListBuyerPackOpeningsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerpacks"></a>
# **ListBuyerPacks**
> ListBuyerPacksResponse ListBuyerPacks ()

Packs you can open: price, every tier with its published odds, what is left in it and its value range, and the expected value of one opening.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerPacksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Packs you can open: price, every tier with its published odds, what is left in it and its value range, and the expected value of one opening.
                ListBuyerPacksResponse result = apiInstance.ListBuyerPacks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerPacks: " + e.Message );
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

**ListBuyerPacksResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerparties"></a>
# **ListBuyerParties**
> ListBuyerPartiesResponse ListBuyerParties ()

Themed shopping parties, live and upcoming.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerPartiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Themed shopping parties, live and upcoming.
                ListBuyerPartiesResponse result = apiInstance.ListBuyerParties();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerParties: " + e.Message );
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

**ListBuyerPartiesResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerpartylistings"></a>
# **ListBuyerPartyListings**
> BuyerResponse3 ListBuyerPartyListings (string slug)

Listings shared to a party, featured first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerPartyListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Listings shared to a party, featured first.
                BuyerResponse3 result = apiInstance.ListBuyerPartyListings(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerPartyListings: " + e.Message );
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
 **slug** | **string**|  | 

### Return type

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerpickuppoints"></a>
# **ListBuyerPickupPoints**
> BuyerResponse3 ListBuyerPickupPoints ()

Carrier pickup points (UPS Access Point / FedEx Hold at Location) near an address; pass one as `pickupPoint` to POST /v1/buyer/checkout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerPickupPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Carrier pickup points (UPS Access Point / FedEx Hold at Location) near an address; pass one as `pickupPoint` to POST /v1/buyer/checkout.
                BuyerResponse3 result = apiInstance.ListBuyerPickupPoints();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerPickupPoints: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerprotectionplans"></a>
# **ListBuyerProtectionPlans**
> ListBuyerProtectionPlansResponse ListBuyerProtectionPlans ()

Your protection plans (bought at checkout with `protection`): status, term, coverage, contract id, and any refund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerProtectionPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your protection plans (bought at checkout with `protection`): status, term, coverage, contract id, and any refund.
                ListBuyerProtectionPlansResponse result = apiInstance.ListBuyerProtectionPlans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerProtectionPlans: " + e.Message );
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

**ListBuyerProtectionPlansResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerregistries"></a>
# **ListBuyerRegistries**
> ListBuyerRegistriesResponse ListBuyerRegistries ()

Your gift registries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerRegistriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your gift registries.
                ListBuyerRegistriesResponse result = apiInstance.ListBuyerRegistries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerRegistries: " + e.Message );
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

**ListBuyerRegistriesResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerregistrygifts"></a>
# **ListBuyerRegistryGifts**
> ListBuyerRegistryGiftsResponse ListBuyerRegistryGifts (string id)

Your thank-you list: who bought what off the registry, and whether you have thanked them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerRegistryGiftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Your thank-you list: who bought what off the registry, and whether you have thanked them.
                ListBuyerRegistryGiftsResponse result = apiInstance.ListBuyerRegistryGifts(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerRegistryGifts: " + e.Message );
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

**ListBuyerRegistryGiftsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerregistrysearch"></a>
# **ListBuyerRegistrySearch**
> ListBuyerRegistrySearchResponse ListBuyerRegistrySearch ()

Find a registry by its name or the registrant’s name. Current and recent registries only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerRegistrySearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Find a registry by its name or the registrant’s name. Current and recent registries only.
                ListBuyerRegistrySearchResponse result = apiInstance.ListBuyerRegistrySearch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerRegistrySearch: " + e.Message );
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

**ListBuyerRegistrySearchResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerrentals"></a>
# **ListBuyerRentals**
> ListBuyerRentalsResponse ListBuyerRentals ()

Your rentals: dates, status (reserved, out, returned, claimed, closed, cancelled), the return label, and what happened to the deposit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerRentalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your rentals: dates, status (reserved, out, returned, claimed, closed, cancelled), the return label, and what happened to the deposit.
                ListBuyerRentalsResponse result = apiInstance.ListBuyerRentals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerRentals: " + e.Message );
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

**ListBuyerRentalsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyersizememoryprompts"></a>
# **ListBuyerSizeMemoryPrompts**
> ListBuyerSizeMemoryPromptsResponse ListBuyerSizeMemoryPrompts ()

Delivered orders with a size that you haven’t said how they fit (the last 60 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerSizeMemoryPromptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Delivered orders with a size that you haven’t said how they fit (the last 60 days).
                ListBuyerSizeMemoryPromptsResponse result = apiInstance.ListBuyerSizeMemoryPrompts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerSizeMemoryPrompts: " + e.Message );
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

**ListBuyerSizeMemoryPromptsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyersizememorysizes"></a>
# **ListBuyerSizeMemorySizes**
> ListBuyerSizeMemorySizesResponse ListBuyerSizeMemorySizes ()

The sizes learned from what you bought and kept, by kind of item (shoes, tops, bottoms, dresses, outerwear) and department.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerSizeMemorySizesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The sizes learned from what you bought and kept, by kind of item (shoes, tops, bottoms, dresses, outerwear) and department.
                ListBuyerSizeMemorySizesResponse result = apiInstance.ListBuyerSizeMemorySizes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerSizeMemorySizes: " + e.Message );
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

**ListBuyerSizeMemorySizesResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyersplits"></a>
# **ListBuyerSplits**
> BuyerResponse3 ListBuyerSplits ()

Purchases you split, with each share’s status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerSplitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Purchases you split, with each share’s status.
                BuyerResponse3 result = apiInstance.ListBuyerSplits();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerSplits: " + e.Message );
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

**BuyerResponse3**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyersubscriptions"></a>
# **ListBuyerSubscriptions**
> ListBuyerSubscriptionsResponse ListBuyerSubscriptions ()

Your subscribe & save standing orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your subscribe & save standing orders.
                ListBuyerSubscriptionsResponse result = apiInstance.ListBuyerSubscriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerSubscriptions: " + e.Message );
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

**ListBuyerSubscriptionsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyertogether"></a>
# **ListBuyerTogether**
> ListBuyerTogetherResponse ListBuyerTogether ()

Shop-together rooms you are in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerTogetherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Shop-together rooms you are in.
                ListBuyerTogetherResponse result = apiInstance.ListBuyerTogether();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerTogether: " + e.Message );
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

**ListBuyerTogetherResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyertotalrequests"></a>
# **ListBuyerTotalRequests**
> ListBuyerTotalRequestsResponse ListBuyerTotalRequests ()

Your combined-shipping total requests, newest per seller.

A seller answers a request by quoting one shipping figure for every item of theirs in your cart. `matchesCart: false` means the cart changed since, so the quote will not apply at checkout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerTotalRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your combined-shipping total requests, newest per seller.
                ListBuyerTotalRequestsResponse result = apiInstance.ListBuyerTotalRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerTotalRequests: " + e.Message );
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

**ListBuyerTotalRequestsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyertryons"></a>
# **ListBuyerTryOns**
> ListBuyerTryOnsResponse ListBuyerTryOns ()

Your AI try-ons: the rendered images (labelled AI-generated wherever shown).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerTryOnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your AI try-ons: the rendered images (labelled AI-generated wherever shown).
                ListBuyerTryOnsResponse result = apiInstance.ListBuyerTryOns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerTryOns: " + e.Message );
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

**ListBuyerTryOnsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervault"></a>
# **ListBuyerVault**
> ListBuyerVaultResponse ListBuyerVault ()

What you own in the Crossly vault: stored (authenticated, on a shelf), listed for sale, or on its way home — with the price to ship one home.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // What you own in the Crossly vault: stored (authenticated, on a shelf), listed for sale, or on its way home — with the price to ship one home.
                ListBuyerVaultResponse result = apiInstance.ListBuyerVault();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVault: " + e.Message );
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

**ListBuyerVaultResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervaultmarketholdings"></a>
# **ListBuyerVaultMarketHoldings**
> ListBuyerVaultMarketHoldingsResponse ListBuyerVaultMarketHoldings ()

Each unit you hold in the vault at its market price, with the mark’s quality (A or B reliable, C indicative, none), cost, P&L and where it stands (stored, listed, lent, pledged, at the grader); `meta` carries the totals and the units you have out on loan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVaultMarketHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Each unit you hold in the vault at its market price, with the mark’s quality (A or B reliable, C indicative, none), cost, P&L and where it stands (stored, listed, lent, pledged, at the grader); `meta` carries the totals and the units you have out on loan.
                ListBuyerVaultMarketHoldingsResponse result = apiInstance.ListBuyerVaultMarketHoldings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVaultMarketHoldings: " + e.Message );
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

**ListBuyerVaultMarketHoldingsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervaultmarketindexes"></a>
# **ListBuyerVaultMarketIndexes**
> ListBuyerVaultMarketIndexesResponse ListBuyerVaultMarketIndexes ()

Crossly indexes over vault book keys (category, brand, curated, composite, segment, and your own), each with its level now and change since the last daily close. Index levels are valued only from the book’s marks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVaultMarketIndexesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Crossly indexes over vault book keys (category, brand, curated, composite, segment, and your own), each with its level now and change since the last daily close. Index levels are valued only from the book’s marks.
                ListBuyerVaultMarketIndexesResponse result = apiInstance.ListBuyerVaultMarketIndexes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVaultMarketIndexes: " + e.Message );
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

**ListBuyerVaultMarketIndexesResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervaultmarketinstantexit"></a>
# **ListBuyerVaultMarketInstantExit**
> ListBuyerVaultMarketInstantExitResponse ListBuyerVaultMarketInstantExit ()

Instant Exit quotes for what you hold, one per book key: the best resting bid (yours left out), its share of the mark, the bid levels, units held and which are free to sell, and why a key cannot be sold instantly. A quote, not an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVaultMarketInstantExitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Instant Exit quotes for what you hold, one per book key: the best resting bid (yours left out), its share of the mark, the bid levels, units held and which are free to sell, and why a key cannot be sold instantly. A quote, not an order.
                ListBuyerVaultMarketInstantExitResponse result = apiInstance.ListBuyerVaultMarketInstantExit();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVaultMarketInstantExit: " + e.Message );
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

**ListBuyerVaultMarketInstantExitResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervaultmarketwatchlist"></a>
# **ListBuyerVaultMarketWatchlist**
> ListBuyerVaultMarketWatchlistResponse ListBuyerVaultMarketWatchlist ()

The book keys you watch, with mark and its quality, 24 h and 7 d change, and the last 30 daily marks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVaultMarketWatchlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // The book keys you watch, with mark and its quality, 24 h and 7 d change, and the last 30 daily marks.
                ListBuyerVaultMarketWatchlistResponse result = apiInstance.ListBuyerVaultMarketWatchlist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVaultMarketWatchlist: " + e.Message );
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

**ListBuyerVaultMarketWatchlistResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyervideorequests"></a>
# **ListBuyerVideoRequests**
> ListBuyerVideoRequestsResponse ListBuyerVideoRequests ()

Your video requests and their answers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerVideoRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your video requests and their answers.
                ListBuyerVideoRequestsResponse result = apiInstance.ListBuyerVideoRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerVideoRequests: " + e.Message );
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

**ListBuyerVideoRequestsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerwishlistitems"></a>
# **ListBuyerWishlistItems**
> ListBuyerWishlistItemsResponse ListBuyerWishlistItems (Guid id)

What is on one wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerWishlistItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // What is on one wishlist.
                ListBuyerWishlistItemsResponse result = apiInstance.ListBuyerWishlistItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerWishlistItems: " + e.Message );
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

**ListBuyerWishlistItemsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerwishlistmembers"></a>
# **ListBuyerWishlistMembers**
> ListBuyerWishlistMembersResponse ListBuyerWishlistMembers (string id)

Co-editors of a shared wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerWishlistMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Co-editors of a shared wishlist.
                ListBuyerWishlistMembersResponse result = apiInstance.ListBuyerWishlistMembers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerWishlistMembers: " + e.Message );
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

**ListBuyerWishlistMembersResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listbuyerwishlists"></a>
# **ListBuyerWishlists**
> ListBuyerWishlistsResponse ListBuyerWishlists ()

Your wishlists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class ListBuyerWishlistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Your wishlists.
                ListBuyerWishlistsResponse result = apiInstance.ListBuyerWishlists();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.ListBuyerWishlists: " + e.Message );
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

**ListBuyerWishlistsResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerboard"></a>
# **UpdateBuyerBoard**
> BuyerResponse UpdateBuyerBoard (string id)

Rename a board, change its description, or make it public / private.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Rename a board, change its description, or make it public / private.
                BuyerResponse result = apiInstance.UpdateBuyerBoard(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerBoard: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerboardlayout"></a>
# **UpdateBuyerBoardLayout**
> BuyerBoardResponse UpdateBuyerBoardLayout (string id)

Replace a board’s layout: items by platform listing id or slug, with x, y, w (0–1) and z. At most 40.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerBoardLayoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Replace a board’s layout: items by platform listing id or slug, with x, y, w (0–1) and z. At most 40.
                BuyerBoardResponse result = apiInstance.UpdateBuyerBoardLayout(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerBoardLayout: " + e.Message );
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

**BuyerBoardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyercollectionsetleaderboard"></a>
# **UpdateBuyerCollectionSetLeaderboard**
> UpdateBuyerCollectionSetLeaderboardResponse UpdateBuyerCollectionSetLeaderboard ()

Show or hide yourself (by your public handle) on set leaderboards.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerCollectionSetLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);

            try
            {
                // Show or hide yourself (by your public handle) on set leaderboards.
                UpdateBuyerCollectionSetLeaderboardResponse result = apiInstance.UpdateBuyerCollectionSetLeaderboard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerCollectionSetLeaderboard: " + e.Message );
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

**UpdateBuyerCollectionSetLeaderboardResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerfeedback"></a>
# **UpdateBuyerFeedback**
> BuyerResponse UpdateBuyerFeedback (Guid id, UpdateBuyerFeedbackRequest updateBuyerFeedbackRequest)

Revise feedback you left, within 60 days.

Replaces the stars and comment; detailed ratings you omit stay as they were.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var updateBuyerFeedbackRequest = new UpdateBuyerFeedbackRequest(); // UpdateBuyerFeedbackRequest | 

            try
            {
                // Revise feedback you left, within 60 days.
                BuyerResponse result = apiInstance.UpdateBuyerFeedback(id, updateBuyerFeedbackRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerFeedback: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **updateBuyerFeedbackRequest** | **UpdateBuyerFeedbackRequest**|  | 

### Return type

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

<a name="updatebuyerhunt"></a>
# **UpdateBuyerHunt**
> BuyerResponse UpdateBuyerHunt (string id)

Pause, resume or stop a hunt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerHuntExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pause, resume or stop a hunt.
                BuyerResponse result = apiInstance.UpdateBuyerHunt(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerHunt: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerpurchasestory"></a>
# **UpdateBuyerPurchaseStory**
> BuyerResponse UpdateBuyerPurchaseStory (string id)

Write your owner story (280 characters); it travels with the item if you resell it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerPurchaseStoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Write your owner story (280 characters); it travels with the item if you resell it.
                BuyerResponse result = apiInstance.UpdateBuyerPurchaseStory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerPurchaseStory: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerregistry"></a>
# **UpdateBuyerRegistry**
> BuyerRegistryResponse UpdateBuyerRegistry (string id)

Edit a registry: title, kind, date, message, ship-to address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Edit a registry: title, kind, date, message, ship-to address.
                BuyerRegistryResponse result = apiInstance.UpdateBuyerRegistry(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerRegistry: " + e.Message );
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

**BuyerRegistryResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerregistryitem"></a>
# **UpdateBuyerRegistryItem**
> UpdateBuyerRegistryItemResponse UpdateBuyerRegistryItem (string id, string platformListingId)

How many of an item you want (1–50).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerRegistryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 
            var platformListingId = "platformListingId_example";  // string | 

            try
            {
                // How many of an item you want (1–50).
                UpdateBuyerRegistryItemResponse result = apiInstance.UpdateBuyerRegistryItem(id, platformListingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerRegistryItem: " + e.Message );
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

**UpdateBuyerRegistryItemResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyersubscription"></a>
# **UpdateBuyerSubscription**
> BuyerResponse UpdateBuyerSubscription (string id)

Pause, resume, skip the next delivery, change the interval, or cancel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pause, resume, skip the next delivery, change the interval, or cancel.
                BuyerResponse result = apiInstance.UpdateBuyerSubscription(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerSubscription: " + e.Message );
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

**BuyerResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatebuyerwishlist"></a>
# **UpdateBuyerWishlist**
> UpdateBuyerWishlistResponse UpdateBuyerWishlist (Guid id, UpdateBuyerWishlistRequest updateBuyerWishlistRequest)

Rename a wishlist, or make it public / private.

A public list can be opened by anyone holding its share link; making it private again stops that link working.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.buyer.Api;
using net.crossly.buyer.Client;
using net.crossly.buyer.Model;

namespace Example
{
    public class UpdateBuyerWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: BuyerOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BuyerApi(config);
            var id = "id_example";  // Guid | The id.
            var updateBuyerWishlistRequest = new UpdateBuyerWishlistRequest(); // UpdateBuyerWishlistRequest | 

            try
            {
                // Rename a wishlist, or make it public / private.
                UpdateBuyerWishlistResponse result = apiInstance.UpdateBuyerWishlist(id, updateBuyerWishlistRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuyerApi.UpdateBuyerWishlist: " + e.Message );
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
 **id** | **Guid**| The id. | 
 **updateBuyerWishlistRequest** | **UpdateBuyerWishlistRequest**|  | 

### Return type

**UpdateBuyerWishlistResponse**

### Authorization

[BuyerOAuth](../README.md#BuyerOAuth)

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

