# net.crossly.Api.WorldApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSpatialInviteAccept**](WorldApi.md#createspatialinviteaccept) | **POST** /v1/spatial/invites/accept | Redeem an invite code (dashes optional); returns the room it opens.
[**CreateSpatialPropertyLeaseWithdraw**](WorldApi.md#createspatialpropertyleasewithdraw) | **POST** /v1/spatial/property/leases/{id}/withdraw | Withdraw a lease offer nobody has accepted yet.
[**CreateSpatialScene**](WorldApi.md#createspatialscene) | **POST** /v1/spatial/scenes | Start a 3D room: a collection (your items on shelves) or a warehouse (racks you arrange). Private until you make it public.
[**CreateSpatialSceneGrant**](WorldApi.md#createspatialscenegrant) | **POST** /v1/spatial/scenes/{id}/grants | Let a specific user into one of your rooms (visitor or staff), no code needed.
[**CreateSpatialSceneInvite**](WorldApi.md#createspatialsceneinvite) | **POST** /v1/spatial/scenes/{id}/invites | Mint an invite code to one of your rooms (visitor or staff, optional expiry in hours). The code is in this response only: just its hash is stored.
[**CreateSpatialSceneNode**](WorldApi.md#createspatialscenenode) | **POST** /v1/spatial/scenes/{id}/nodes | Add a unit (rack, shelf, bin) to one of your warehouse rooms.
[**CreateSpatialScenePlace**](WorldApi.md#createspatialsceneplace) | **POST** /v1/spatial/scenes/{id}/place | Pin an inventory item to a slot in one of your rooms: by warehouse nodeId, or by a collection container key and index.
[**CreateSpatialSceneRename**](WorldApi.md#createspatialscenerename) | **POST** /v1/spatial/scenes/{id}/rename | Rename one of your rooms.
[**CreateSpatialSceneShopPlace**](WorldApi.md#createspatialsceneshopplace) | **POST** /v1/spatial/scenes/{id}/shop/place | Place an inventory item in a section and display of your shop room.
[**CreateSpatialSceneUnpin**](WorldApi.md#createspatialsceneunpin) | **POST** /v1/spatial/scenes/{id}/unpin | Clear every pin in one of your rooms, so it arranges itself again.
[**CreateSpatialSceneVisibility**](WorldApi.md#createspatialscenevisibility) | **POST** /v1/spatial/scenes/{id}/visibility | Make one of your rooms private, unlisted (anyone with the link) or public (in the lobby and searchable).
[**CreateSpatialSceneWarehouseStock**](WorldApi.md#createspatialscenewarehousestock) | **POST** /v1/spatial/scenes/{id}/warehouse/stock | Put an inventory item (or unit) on a rack in one of your warehouse rooms.
[**CreateSpatialShopNeighbourhood**](WorldApi.md#createspatialshopneighbourhood) | **POST** /v1/spatial/shop/neighbourhood | Move your shop to another neighbourhood (by slug).
[**CreateSpatialStreetApply**](WorldApi.md#createspatialstreetapply) | **POST** /v1/spatial/streets/{slug}/apply | Ask to open your shop on a street whose owner reviews applications.
[**CreateSpatialStreetInvite**](WorldApi.md#createspatialstreetinvite) | **POST** /v1/spatial/streets/{slug}/invite | Invite a shop (by its slug) to open on a street you own.
[**CreateWorldAvatarEquip**](WorldApi.md#createworldavatarequip) | **POST** /v1/world/avatar/equip | Wear something you already own - - exactly ONE of { cosmeticId } (a cosmetic you hold), { receiptId } (a Crossly purchase from your closet) or { inventoryItemId } (your own stock). The slot comes from the thing itself; slot is only a fallback for an item with no catalog shape. Replaces whatever was in that slot. Moves no money. Answers the slot and your loadout after the change.
[**CreateWorldAvatarUnequip**](WorldApi.md#createworldavatarunequip) | **POST** /v1/world/avatar/unequip | Take off whatever is in one slot. Idempotent: an empty slot answers removed:false. Answers your loadout after the change.
[**CreateWorldAvatarWearable**](WorldApi.md#createworldavatarwearable) | **POST** /v1/world/avatar/wearables | Author a wearable for a body slot (a mesh profile and params, an asking price in COSM base units as a string). A submission: inactive until an operator approves it.
[**CreateWorldContest**](WorldApi.md#createworldcontest) | **POST** /v1/world/contests | Set up a skill contest on a game placed in your place: title, game (its instance id), entry { mode, feeCents? }, prizes by place, funder, window, attempts. Paid entry needs the operator to allow it where it runs.
[**CreateWorldContestEntrySettlePayment**](WorldApi.md#createworldcontestentrysettlepayment) | **POST** /v1/world/contests/entries/{id}/settle-payment | Read the fee of a paid entry back from Stripe and settle it (safe to repeat).
[**CreateWorldContestJoin**](WorldApi.md#createworldcontestjoin) | **POST** /v1/world/contests/{id}/join | Enter a contest. Free and sponsored contests take you in at once; a paid one answers a client secret to pay the entry fee.
[**CreateWorldConvention**](WorldApi.md#createworldconvention) | **POST** /v1/world/conventions | Host a convention in one of your rooms: title, dates, tables and how sellers get one (invite, free, a fee in cents, or a revenue share in basis points).
[**CreateWorldConventionAccept**](WorldApi.md#createworldconventionaccept) | **POST** /v1/world/conventions/{id}/accept | Accept: your own invitation (no body), or, as host, an application (username).
[**CreateWorldConventionApply**](WorldApi.md#createworldconventionapply) | **POST** /v1/world/conventions/{id}/apply | Ask for a table at a convention.
[**CreateWorldConventionInvite**](WorldApi.md#createworldconventioninvite) | **POST** /v1/world/conventions/{id}/invite | Invite a seller (by shop handle) to a convention you host.
[**CreateWorldConventionPaid**](WorldApi.md#createworldconventionpaid) | **POST** /v1/world/conventions/{id}/paid | As host, record that a seller (username) paid their table fee off-platform. Moves no money.
[**CreateWorldConventionWithdraw**](WorldApi.md#createworldconventionwithdraw) | **POST** /v1/world/conventions/{id}/withdraw | Withdraw your table or decline your invitation; as host, decline someone (username).
[**CreateWorldCrew**](WorldApi.md#createworldcrew) | **POST** /v1/world/crews | Start a crew you own: { name (2-32 chars), tag (2-5 letters or digits, shown on members&#39; nameplates) }. Answers its id and join code. 409 when you are already in a crew.
[**CreateWorldCrewChat**](WorldApi.md#createworldcrewchat) | **POST** /v1/world/crew/chat | Say a line to your crew (body: text, up to 400 characters). Returns data.messages, the crew chat ring (the last 50 lines, kept in memory only), and data.said when your line went out; a blocked or too-quick line is dropped silently. 404 when you are in no crew.
[**CreateWorldCrewJoin**](WorldApi.md#createworldcrewjoin) | **POST** /v1/world/crews/join | Join a crew by the code a member gave you. 404 for an unknown code, 409 when you are already in a crew or it is full (30).
[**CreateWorldCrewLeave**](WorldApi.md#createworldcrewleave) | **POST** /v1/world/crews/leave | Leave your crew. If you own it, the crew is disbanded. Idempotent: leaving when in none succeeds.
[**CreateWorldDecorDesign**](WorldApi.md#createworlddecordesign) | **POST** /v1/world/decor/designs | Author a decor design (what it unlocks, a mesh profile and params, an asking price in COSM base units as a string). Inactive until an operator approves it.
[**CreateWorldDecorDesignSubmit**](WorldApi.md#createworlddecordesignsubmit) | **POST** /v1/world/decor/designs/{id}/submit | Send one of your decor designs to the review queue.
[**CreateWorldDecorRetract**](WorldApi.md#createworlddecorretract) | **POST** /v1/world/decor/retract | Take a placed decor piece back into your inventory; answers the inventory after.
[**CreateWorldDm**](WorldApi.md#createworlddm) | **POST** /v1/world/dms/{userId} | Send a direct message to a friend (a mutual follow; never across a block), up to 400 characters, through the world chat guard. 403 when they are not a friend, 429 when sent too quickly.
[**CreateWorldFollow**](WorldApi.md#createworldfollow) | **POST** /v1/world/follows/{userId} | Follow somebody. When they follow you back you are friends (friends-here, invites, messages). Idempotent.
[**CreateWorldFriendInvite**](WorldApi.md#createworldfriendinvite) | **POST** /v1/world/friends/{userId}/invite | \&quot;Join me\&quot;: send one friend (a mutual follow) a notification with a link to the PUBLIC room you name by slug. 404 when they are not a friend or the room is not public; 429 when you invited them in the last minute.
[**CreateWorldGamePackage**](WorldApi.md#createworldgamepackage) | **POST** /v1/world/games/packages | Submit a game package version for review: files as { path, base64 } (game.json, thumb.png, logic/, scene/, audio/, images/). Checked like the CLI, assets quarantined, the entry document dry-run, then reviewed by a person.
[**CreateWorldGamePackageCheck**](WorldApi.md#createworldgamepackagecheck) | **POST** /v1/world/games/packages/check | Validate a game package exactly as a submission is checked (the shared intake report, your version still free) without storing, uploading or queuing anything: world-kit validate for an agent. Same files body as submit.
[**CreateWorldGameRating**](WorldApi.md#createworldgamerating) | **POST** /v1/world/games/{id}/rating | Rate a game you played, 1 to 5 stars (rating again replaces it). Only players the runner recorded in that game can rate it.
[**CreateWorldGameReport**](WorldApi.md#createworldgamereport) | **POST** /v1/world/games/{id}/report | Report a game: reason broken | unfair | offensive | scam | other, optional detail. Staff review it; the creator is told the reason, never who.
[**CreateWorldGameStoreCheckout**](WorldApi.md#createworldgamestorecheckout) | **POST** /v1/world/games/{id}/store/{item}/checkout | Buy an item or pass from a game store: answers a client secret for the payment; the item is yours once it succeeds.
[**CreateWorldGrailMatch**](WorldApi.md#createworldgrailmatch) | **POST** /v1/world/grails/match | Grail glints: send the ids on show somewhere (listingIds - - listings.id, inventoryIds, skuIds - - catalogue market SKUs; up to 400 each) and get back data.listingIds / data.inventoryIds / data.skuIds: the ones that are things you already want - - an open bid, a watched or wishlisted listing (or one selling the same SKU), a market watch, or a card your deck is missing. Read-only.
[**CreateWorldHallLoan**](WorldApi.md#createworldhallloan) | **POST** /v1/world/hall/loans | Lend a piece from your vault to this week&#39;s Hall of Grails exhibition: { vaultItemId, credit: &#39;name&#39; | &#39;anonymous&#39; }. It shows under your plaque until the exhibition ends; it stays in your vault (still listable and withdrawable), and stops showing if it leaves.
[**CreateWorldHomeAsk**](WorldApi.md#createworldhomeask) | **POST** /v1/world/homes/{slug}/ask | Ask a home owner whether they would sell a piece you saw there (an item or a decor piece).
[**CreateWorldHomeGuestbook**](WorldApi.md#createworldhomeguestbook) | **POST** /v1/world/homes/{slug}/guestbook | Sign a home guestbook (one short line).
[**CreateWorldHomeGuestbookReport**](WorldApi.md#createworldhomeguestbookreport) | **POST** /v1/world/homes/{slug}/guestbook/{id}/report | Report a guestbook entry to moderation.
[**CreateWorldHuntStart**](WorldApi.md#createworldhuntstart) | **POST** /v1/world/hunt/start | Start the Great Hunt this season by reading its first riddle (the Copper key&#39;s). Idempotent: starting again answers your progress unchanged. Answers the same shape as GET /v1/world/hunt. 409 when no season is running.
[**CreateWorldInteractiveAsset**](WorldApi.md#createworldinteractiveasset) | **POST** /v1/world/interactive/assets | Upload one asset for your designs: kind glb (4 MB), wav (4 MB) or png (1 MB), the file as base64. Answers its sha256 and the path to reference from MML.
[**CreateWorldInteractiveDesign**](WorldApi.md#createworldinteractivedesign) | **POST** /v1/world/interactive/designs | Create an interactive design: name, footprint (s, m, l or f), optional tint and description, an asking price in COSM base units (a string, six decimals) and optional max supply. Inactive until ops approve a submitted version.
[**CreateWorldInteractiveDesignCheck**](WorldApi.md#createworldinteractivedesigncheck) | **POST** /v1/world/interactive/designs/{id}/check | Check the draft: static rules, that every referenced upload exists, and a sandboxed dry run. Budgeted per person.
[**CreateWorldInteractiveDesignPreview**](WorldApi.md#createworldinteractivedesignpreview) | **POST** /v1/world/interactive/designs/{id}/preview | A private preview token for the draft (author only) and the socket path that runs it. Budgeted per person.
[**CreateWorldInteractiveDesignSubmit**](WorldApi.md#createworldinteractivedesignsubmit) | **POST** /v1/world/interactive/designs/{id}/submit | Freeze the draft as a new version and send it to ops review. Up to 10 a day.
[**CreateWorldInteractiveReset**](WorldApi.md#createworldinteractivereset) | **POST** /v1/world/interactive/reset | Wipe the stored state of an interactive piece standing in a place you own (a home or your boutique).
[**CreateWorldJobAppraisalAnswer**](WorldApi.md#createworldjobappraisalanswer) | **POST** /v1/world/jobs/appraisals/{id}/answers | Answer a price check: your estimate of the item value in CENTS and an optional note. Moves no money; the asker may accept it.
[**CreateWorldJobShiftClaim**](WorldApi.md#createworldjobshiftclaim) | **POST** /v1/world/jobs/shifts/{id}/claim | Claim an open shift. You work it by being in the place while it runs.
[**CreateWorldJobShiftRelease**](WorldApi.md#createworldjobshiftrelease) | **POST** /v1/world/jobs/shifts/{id}/release | Give a shift you claimed back to the board.
[**CreateWorldOutfit**](WorldApi.md#createworldoutfit) | **POST** /v1/world/outfits | Save what you are wearing now as a named look: { name (1-32 chars), appearance? (skin, hair, hairColour, eyes, build - - unknown keys fall back to the default) }. Each worn thing is recorded as the door it goes back on by; one that no longer traces to something you own is listed in skipped and not saved. 409 when you already keep 6.
[**CreateWorldOutfitApply**](WorldApi.md#createworldoutfitapply) | **POST** /v1/world/outfits/{id}/apply | Put a saved look on. Every item goes through the same equip as POST /v1/world/avatar/equip, so ownership still holds: something you no longer own is listed in skipped with the reason and not worn. Slots the look left empty are emptied (cleared). Answers the appearance of the look (for your character - - appearance lives on your device), applied, skipped and cleared. Moves no money.
[**CreateWorldParty**](WorldApi.md#createworldparty) | **POST** /v1/world/parties | Start a party with you as leader (up to 8 members).
[**CreateWorldPartyChat**](WorldApi.md#createworldpartychat) | **POST** /v1/world/parties/{id}/chat | Say something in your party chat (up to 2000 characters).
[**CreateWorldPartyInvite**](WorldApi.md#createworldpartyinvite) | **POST** /v1/world/parties/{id}/invite | Invite a friend (userId) to your party.
[**CreateWorldPartyInviteAccept**](WorldApi.md#createworldpartyinviteaccept) | **POST** /v1/world/parties/invites/{inviteId}/accept | Accept a party invite.
[**CreateWorldPartyInviteDecline**](WorldApi.md#createworldpartyinvitedecline) | **POST** /v1/world/parties/invites/{inviteId}/decline | Decline a party invite.
[**CreateWorldPartyKick**](WorldApi.md#createworldpartykick) | **POST** /v1/world/parties/{id}/kick | As leader, remove a member (userId).
[**CreateWorldPartyLeader**](WorldApi.md#createworldpartyleader) | **POST** /v1/world/parties/{id}/leader | As leader, pass the lead to a member (userId).
[**CreateWorldPartyLeave**](WorldApi.md#createworldpartyleave) | **POST** /v1/world/parties/{id}/leave | Leave your party (the lead passes on if you led it).
[**CreateWorldPartyWishlist**](WorldApi.md#createworldpartywishlist) | **POST** /v1/world/parties/{id}/wishlist | Add a listing (listingId, or its shop slug) to the party wishlist; answers the wishlist.
[**CreateWorldPartyWishlistVote**](WorldApi.md#createworldpartywishlistvote) | **POST** /v1/world/parties/{id}/wishlist/{listingId}/vote | Thumb a wishlist listing up or down (null clears your vote); answers the wishlist.
[**CreateWorldPlaceItemWant**](WorldApi.md#createworldplaceitemwant) | **POST** /v1/world/places/{slug}/items/{itemId}/want | Tell a room owner you would buy one of their items (once per person per item; they see the count). Moves no money.
[**CreateWorldSpace**](WorldApi.md#createworldspace) | **POST** /v1/world/spaces | Open a Space (sellers only, at most two): slug, name, venue, optional membership and about.
[**CreateWorldSpaceEvent**](WorldApi.md#createworldspaceevent) | **POST** /v1/world/spaces/{slug}/events | As host or co-host, put an event on: title, kind, optional about, ISO start and end with offset.
[**CreateWorldSpaceEventRsvp**](WorldApi.md#createworldspaceeventrsvp) | **POST** /v1/world/spaces/{slug}/events/{id}/rsvp | Say whether you are going to an event.
[**CreateWorldSpaceInvite**](WorldApi.md#createworldspaceinvite) | **POST** /v1/world/spaces/{slug}/invite | Invite somebody (userId) to a Space.
[**CreateWorldSpaceJoin**](WorldApi.md#createworldspacejoin) | **POST** /v1/world/spaces/{slug}/join | Join a Space, or ask to when it is request-only.
[**CreateWorldSpaceLeave**](WorldApi.md#createworldspaceleave) | **POST** /v1/world/spaces/{slug}/leave | Leave a Space.
[**CreateWorldSpaceRequestByUserId**](WorldApi.md#createworldspacerequestbyuserid) | **POST** /v1/world/spaces/{slug}/requests/{userId} | As host or co-host, accept or turn down a request to join.
[**CreateWorldSpaceRole**](WorldApi.md#createworldspacerole) | **POST** /v1/world/spaces/{slug}/role | As host, make a member a co-host or back to a member.
[**DeleteSpatialSceneGrant**](WorldApi.md#deletespatialscenegrant) | **DELETE** /v1/spatial/scenes/{id}/grants/{grantId} | Take somebody&#39;s access to your room away, or kill an invite nobody has used yet.
[**DeleteSpatialSceneNode**](WorldApi.md#deletespatialscenenode) | **DELETE** /v1/spatial/scenes/{id}/nodes | Remove units (by id, up to 500) from one of your warehouse rooms.
[**DeleteSpatialSceneWarehouseStock**](WorldApi.md#deletespatialscenewarehousestock) | **DELETE** /v1/spatial/scenes/{id}/warehouse/stock | Take an inventory item (or unit) off its rack.
[**DeleteSpatialStreetRequest**](WorldApi.md#deletespatialstreetrequest) | **DELETE** /v1/spatial/streets/requests/{id} | Withdraw a street request you made that has not been founded yet.
[**DeleteWorldBlock**](WorldApi.md#deleteworldblock) | **DELETE** /v1/world/blocks/{id} | Unblock somebody (by the block id from GET /v1/world/blocks).
[**DeleteWorldCollectionCapability**](WorldApi.md#deleteworldcollectioncapability) | **DELETE** /v1/world/collections/{chain}/{contract}/capabilities | Withdraw your declaration for a collection.
[**DeleteWorldFollow**](WorldApi.md#deleteworldfollow) | **DELETE** /v1/world/follows/{userId} | Unfollow somebody. Idempotent.
[**DeleteWorldHallLoan**](WorldApi.md#deleteworldhallloan) | **DELETE** /v1/world/hall/loans/{id} | Take one of your loans off show in the Hall of Grails.
[**DeleteWorldHomeGuestbook**](WorldApi.md#deleteworldhomeguestbook) | **DELETE** /v1/world/homes/{slug}/guestbook/{id} | As the home owner, hide a guestbook entry.
[**DeleteWorldInteractiveDesign**](WorldApi.md#deleteworldinteractivedesign) | **DELETE** /v1/world/interactive/designs/{id} | Delete a draft design, or archive a submitted one (off sale; owned copies keep working).
[**DeleteWorldJobShift**](WorldApi.md#deleteworldjobshift) | **DELETE** /v1/world/jobs/shifts/{id} | Cancel a shift you posted that nobody has worked yet.
[**DeleteWorldOutfit**](WorldApi.md#deleteworldoutfit) | **DELETE** /v1/world/outfits/{id} | Delete a saved look. 404 when it is not yours.
[**DeleteWorldPartyWishlist**](WorldApi.md#deleteworldpartywishlist) | **DELETE** /v1/world/parties/{id}/wishlist/{listingId} | Take a listing you added off the party wishlist; answers the wishlist.
[**DeleteWorldPlaceBan**](WorldApi.md#deleteworldplaceban) | **DELETE** /v1/world/places/{slug}/bans/{userId} | Lift a ban from a place you own; they can walk in again right away.
[**DeleteWorldSpace**](WorldApi.md#deleteworldspace) | **DELETE** /v1/world/spaces/{slug} | As host, close a Space.
[**DeleteWorldSpaceEvent**](WorldApi.md#deleteworldspaceevent) | **DELETE** /v1/world/spaces/{slug}/events/{id} | As host or co-host, cancel an event.
[**GetSpatialSceneAttention**](WorldApi.md#getspatialsceneattention) | **GET** /v1/spatial/scenes/{sceneId}/attention | What visitors looked at in one of your rooms: viewers, looks, inspects and dwell per item over the last days (1-35, default 30).
[**GetSpatialSceneWindow**](WorldApi.md#getspatialscenewindow) | **GET** /v1/spatial/scenes/{id}/window | The listings you chose for the street window of your shop, in slot order (left, middle, right; empty &#x3D; newest first), and &#x60;choices&#x60;: your listings that can go in it, newest first.
[**GetSpatialShopNeighbourhood**](WorldApi.md#getspatialshopneighbourhood) | **GET** /v1/spatial/shop/neighbourhood | Your shop&#39;s neighbourhood, and whether and where it may move.
[**GetSpatialSpace**](WorldApi.md#getspatialspace) | **GET** /v1/spatial/spaces | The room catalogue: every space profile (what it holds, how it is sorted, its containers) and the warehouse units.
[**GetSpatialStreetAdmission**](WorldApi.md#getspatialstreetadmission) | **GET** /v1/spatial/streets/admissions | Street applications and invitations: yours, and those waiting on streets you own.
[**GetSpatialStreetDecor**](WorldApi.md#getspatialstreetdecor) | **GET** /v1/spatial/streets/{slug}/decor | The decor on a street you may dress, and what you can place.
[**GetWorldArcade**](WorldApi.md#getworldarcade) | **GET** /v1/world/arcade | The Arcade in Crossly World: data.cabinets (slot, where it stands, host - - piece, price_guess or empty - -, game, title, blurb, the piece it hosts and where, record, packageId and thumbnail for a creator game from the Game Directory, players) and data.scores (the High Score wall: per game a title, kind - - leaderboard, record or top - - and up to five ASCII lines; a name shows only for somebody who chose to be seen by name, everyone else is \&quot;A player\&quot;), plus creatorGames (creator games with a cabinet now). Games are played in the world.
[**GetWorldAurora**](WorldApi.md#getworldaurora) | **GET** /v1/world/aurora | The Sales Aurora over the Commons in Crossly World: every real sale on Crossly in the last data.windowDays (30) days. data.total (sales in the window), data.families (key, label, colour, count per colour family: cards, coins, jewellery, electronics, media, fashion, toys, other) and data.sales (newest first, at most 48: family, ageHours, fresh - - sold in the last ten minutes, which shimmers). Aggregate only: no item, price, seller or platform. data.updatedAt is when it was read.
[**GetWorldAutoShop**](WorldApi.md#getworldautoshop) | **GET** /v1/world/auto-shop | Whether Crossly keeps a world shop for you automatically: enabled, and the shop (id, name, visibility, autoCreated, address, label) or null. Change it with PATCH /v1/world/auto-shop.
[**GetWorldAvatarIdentity**](WorldApi.md#getworldavataridentity) | **GET** /v1/world/avatar/identity | Whether others see your name in the world (named), or not (anonymous); null if you have never chosen.
[**GetWorldAvatarLoadout**](WorldApi.md#getworldavatarloadout) | **GET** /v1/world/avatar/loadout | What you are wearing: the rig, its slots (avatar_head, avatar_body, avatar_outer - - a jacket over the top, avatar_legs, avatar_feet, avatar_back) and each worn entry - - a cosmetic or a real item - - with its verified-purchase mark. Carries no price, receipt id, seller or order.
[**GetWorldAvatarLoadoutByUserId**](WorldApi.md#getworldavatarloadoutbyuserid) | **GET** /v1/world/avatar/loadout/{userId} | What somebody else is wearing, with the verified-purchase mark on each real item - - public on purpose, since a check only its owner can see is not a check. No price, receipt id, seller or order.
[**GetWorldAvatarLook**](WorldApi.md#getworldavatarlook) | **GET** /v1/world/avatar/look | Your world look on the account: the handle you chose (null if anonymous) and your appearance; null if you never made one.
[**GetWorldAvatarNftBadge**](WorldApi.md#getworldavatarnftbadge) | **GET** /v1/world/avatar/nft-badge | The NFT you wear on your nameplate in the world, or null.
[**GetWorldCapability**](WorldApi.md#getworldcapability) | **GET** /v1/world/capabilities | What your held NFTs unlock in Crossly World: each token with the capabilities its collection declared (wear, display, emote, gate, ...). Holding is your verified wallets (their synced tokens); the capabilities of a transferred token go within five minutes.
[**GetWorldCapabilityCatalogue**](WorldApi.md#getworldcapabilitycatalogue) | **GET** /v1/world/capabilities/catalogue | The capability kinds of spec crossly.nft-capabilities/1: what each does, whether only the creator of the collection may declare it, whether it needs review, and which clients honour it.
[**GetWorldCapabilityWear**](WorldApi.md#getworldcapabilitywear) | **GET** /v1/world/capabilities/wear | What you wear from your NFTs and COSM copies: your pick per avatar slot (head, body, legs, feet, back) and what the room sees.
[**GetWorldChest**](WorldApi.md#getworldchest) | **GET** /v1/world/chests | The Commons chest: data.window (this 20-minute window, UTC), spot ([x, z] on the plaza), endsAt (when the next chest comes) and mine (openedThis, and opened - - how many windows you have opened one in; the Chest opener pin comes at 10). A chest is opened by walking up to it in Crossly World, never over the API.
[**GetWorldCollectionCapability**](WorldApi.md#getworldcollectioncapability) | **GET** /v1/world/collections/{chain}/{contract}/capabilities | The live capability declaration of a collection (404 when it has none).
[**GetWorldContestMine**](WorldApi.md#getworldcontestmine) | **GET** /v1/world/contests/mine | Your contest entries (best score, attempts used, payment state) and prizes (granted, or owed until their gate opens).
[**GetWorldConvention**](WorldApi.md#getworldconvention) | **GET** /v1/world/conventions/{id} | One convention. 404 for an unknown or malformed id alike.
[**GetWorldCosmBalance**](WorldApi.md#getworldcosmbalance) | **GET** /v1/world/cosm/balance | Your COSM balance: baseUnits (a STRING - - COSM has 6 decimals and overflows a JSON number), decimals, available (false &#x3D; COSM is not provisioned on this deployment, not a zero balance).
[**GetWorldCrew**](WorldApi.md#getworldcrew) | **GET** /v1/world/crew | Your crew: data.crew is null when you are in none, else its name, tag, join code and whether you own it; data.members lists up to 30 members, each with the public room they are in right now when they chose to be seen by name (else null).
[**GetWorldCrewChat**](WorldApi.md#getworldcrewchat) | **GET** /v1/world/crew/chat | Your crew chat: data.messages is the last 50 lines (from, name, text, at), kept in memory only, so it starts empty after a restart. 404 when you are in no crew.
[**GetWorldCrewLeaderboard**](WorldApi.md#getworldcrewleaderboard) | **GET** /v1/world/crew/leaderboards | The game leaderboards (Price Guess, hunts, speed trades; this week and all time) ranked among your crew only, each member by the name the crew sees. 404 when you are in no crew.
[**GetWorldDm**](WorldApi.md#getworlddm) | **GET** /v1/world/dms/{userId} | Your direct-message thread with one friend, oldest first (the last 100 lines: id, from, text, at, mine). Reading it marks their lines read.
[**GetWorldEmoteShowable**](WorldApi.md#getworldemoteshowable) | **GET** /v1/world/emotes/showable | The things you own that a show-off emote can hold up.
[**GetWorldFirefly**](WorldApi.md#getworldfirefly) | **GET** /v1/world/fireflies | Fireflies on the Commons lawn: data.day (today, UTC), today (fireflies everyone has caught today) and mine (today - - your catches today, up to perDay - - total, all your catches; the Firefly Catcher pin comes at 30 - - and perDay). Fireflies are caught by walking up to a lit one in Crossly World after dark, never over the API, and nothing is spent.
[**GetWorldFitStat**](WorldApi.md#getworldfitstat) | **GET** /v1/world/fits/stats | Your walking storefront, last 7 days: distinct people who tapped \&quot;Shop this\&quot; or \&quot;Offer\&quot; on what you wore, and how many of each. Counts only; nobody is identified.
[**GetWorldFitValue**](WorldApi.md#getworldfitvalue) | **GET** /v1/world/fit-value | What your outfit is worth on the market: cents (sum of each catalogued piece&#39;s order-book price - - last sale, else lowest ask), pieces worn, how many were priced, and share (whether you show it on your card).
[**GetWorldGame**](WorldApi.md#getworldgame) | **GET** /v1/world/games/{id} | One live game: its manifest, its store items and which you own.
[**GetWorldGameLeaderboard**](WorldApi.md#getworldgameleaderboard) | **GET** /v1/world/games/{id}/leaderboard | A live game leaderboard, this week and all time, by its manifest scoring (wins, best points, or best time). Only people who chose to be named show by name. scoring is null for a game that keeps no board.
[**GetWorldGamePackage**](WorldApi.md#getworldgamepackage) | **GET** /v1/world/games/packages/{id} | One of your game packages with every version, its review state and decision note.
[**GetWorldGameTemplate**](WorldApi.md#getworldgametemplate) | **GET** /v1/world/games/templates/{kind} | A fresh game package from a template (table, arena, object; collection is an NFT capability declaration), as { path, base64 } files: the world-kit init, for an agent with no local kit. ?id&#x3D;my-game&amp;name&#x3D;My Game.
[**GetWorldHall**](WorldApi.md#getworldhall) | **GET** /v1/world/hall | The Hall of Grails in Crossly World: data.exhibition (key, title, blurb, endsAt - - a new one every Monday UTC - - and next, the coming one&#39;s title) and data.exhibits, up to twelve real catalogue items in slot order (skuId, name, brand, imageUrl, thumbUrl, retailCents, lowestAskCents, lastSaleCents: the live order book, null when the market has none). The first stands on the centre plinth. Buy, bid or watch an exhibit through the market endpoints with its skuId.
[**GetWorldHallLoan**](WorldApi.md#getworldhallloan) | **GET** /v1/world/hall/loans | Lend to the Hall: this week&#39;s exhibition (key, title, categorySlug, endsAt), your loans on show (id, vaultItemId, skuId, name, credit, since) and the vault pieces you can lend (eligible: vaultItemId, skuId, name, imageUrl, grade) - - held in your Crossly vault, not pledged, in the exhibition&#39;s category. perMember is how many you may lend each week.
[**GetWorldHomePlaceable**](WorldApi.md#getworldhomeplaceable) | **GET** /v1/world/home/placeable | What you can place in your home: your items and your furniture.
[**GetWorldHunt**](WorldApi.md#getworldhunt) | **GET** /v1/world/hunt | Your Great Hunt: data.season (id, name, startsAt, endsAt, the title and how many earn it, live), started (you read the first clue), held (keys held, 0-3, always in the order copper, jade, crystal), keys (each with its name, colour, its riddle once it is yours to read, and when you picked it up), and cleared (your rank through the Gate this season, when, and whether you earned the title) or null. Keys are picked up by walking to them in Crossly World; nothing here takes one.
[**GetWorldHuntScoreboard**](WorldApi.md#getworldhuntscoreboard) | **GET** /v1/world/hunt/scoreboard | The Great Hunt Scoreboard, as the monolith in the Commons shows it: data.season (the running season, or the last one between seasons), finishers (the first ten through the Gate in order: rank, name, short, named, at, titled - - a name shows only for somebody who chose to be seen by name in the world, everyone else is \&quot;A player\&quot;) and total (everybody through the Gate this season).
[**GetWorldInteractiveDesign**](WorldApi.md#getworldinteractivedesign) | **GET** /v1/world/interactive/designs/{id} | One of your interactive designs: its draft source, the last static check, and every submitted version with its review state.
[**GetWorldJob**](WorldApi.md#getworldjob) | **GET** /v1/world/jobs | The jobs board: open staff shifts you could claim, your claimed shifts and open price checks (appraisals), as the world shows them.
[**GetWorldKite**](WorldApi.md#getworldkite) | **GET** /v1/world/kites | Kites flown on the Commons lawn: data.day (today, UTC), today (kites everyone has flown today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have flown one on; the Kite flyer pin comes at 5). Kites are flown by standing out on the lawn in Crossly World by day, never over the API, and nothing is spent.
[**GetWorldLantern**](WorldApi.md#getworldlantern) | **GET** /v1/world/lanterns | Sky lanterns in the Commons: data.day (today, UTC), today (lanterns everyone has released today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have released one on; the Lantern lighter pin comes at 5). Lanterns are released at the lantern stand in Crossly World, never over the API, and nothing is spent.
[**GetWorldPartyChat**](WorldApi.md#getworldpartychat) | **GET** /v1/world/parties/{id}/chat | Your party chat: the recent lines. 404 when this is not your party.
[**GetWorldPlaceBoard**](WorldApi.md#getworldplaceboard) | **GET** /v1/world/places/{slug}/boards | The Trade Floor&#39;s wall of wants, its authentication desk and its Vault Markets ticker (vaultMovers: bookKey, name, label, units, markCents, change24hBps; only the trade-floor place has them).
[**GetWorldPlaceCollection**](WorldApi.md#getworldplacecollection) | **GET** /v1/world/places/{slug}/collections/{category}/{brand}/{model} | One collection room: every piece of the set, owned or missing. 404 for an unknown room or set.
[**GetWorldPlaceDrop**](WorldApi.md#getworldplacedrop) | **GET** /v1/world/places/{slug}/drop | The owner&#39;s next drop (name, cover, time, live) and how many people are waiting in the room.
[**GetWorldPlaceItemInterest**](WorldApi.md#getworldplaceiteminterest) | **GET** /v1/world/places/{slug}/items/{itemId}/interest | How many people looked at one item in this room today.
[**GetWorldPlaceLive**](WorldApi.md#getworldplacelive) | **GET** /v1/world/places/{slug}/live | The owner&#39;s live sale: their stream and the lot on the block, or null.
[**GetWorldPlaceSeller**](WorldApi.md#getworldplaceseller) | **GET** /v1/world/places/{slug}/seller | The shop whose public room this is (username and name), or null.
[**GetWorldPlaceShopPet**](WorldApi.md#getworldplaceshoppet) | **GET** /v1/world/places/{slug}/shop-pet | The shop&#39;s pet kind, or null.
[**GetWorldSpace**](WorldApi.md#getworldspace) | **GET** /v1/world/spaces/{slug} | One Space: its layout, host, events and your place in it.
[**GetWorldSpaceCanHost**](WorldApi.md#getworldspacecanhost) | **GET** /v1/world/spaces/can-host | Whether you may open a Space: sellers only, at most two active.
[**GetWorldTrialLeaderboard**](WorldApi.md#getworldtrialleaderboard) | **GET** /v1/world/trials/{course}/leaderboard | A Time Trials course&#39;s boards, as the board beside it in the Commons shows them: data.course, week, weekly (this week&#39;s ten fastest: rank, name, short, named, ms, at) and allTime (the ten fastest ever, each person once). A name shows only for somebody who chose to be seen by name in the world; everyone else is \&quot;A player\&quot;. 404 for an unknown course; course 1 is commons-loop.
[**GetWorldTrialMine**](WorldApi.md#getworldtrialmine) | **GET** /v1/world/trials/mine | Your Hoverboard Time Trials bests: data.week (its Monday, YYYY-MM-DD, UTC) and courses, each with course (id, name, parMs, rings, lengthM), week (your best lap this week in ms, your place on the weekly board, laps finished, and the split at each ring) or null, and allTime (your best ever in ms, your place on the all-time board, when) or null. Laps are timed by Crossly from where it saw you ride in the world; nothing here writes one.
[**GetWorldWallet**](WorldApi.md#getworldwallet) | **GET** /v1/world/wallet | Every balance you hold in Crossly World, read-only: bucksCents (Crossly Bucks, cents); cbx (available, decimals, and the three CBX balances kept apart as base-unit STRINGS - - granted (spend here only), earned (withdrawable once matured), connected (a delegation ceiling on your own wallet, not cash on hand) - - plus pendingCents of cashback not yet matured); cosm (available, decimals, baseUnits string). available:false means that currency is not provisioned on this deployment, not that you hold none.
[**GetWorldWish**](WorldApi.md#getworldwish) | **GET** /v1/world/wishes | The Wishing Fountain in the Commons: data.day (today, UTC), today (wishes everyone has made today) and mine (madeToday, days - - how many days you have wished on, the Wishmaker pin comes at 7 - - and nextAt, when tomorrow&#39;s wish opens). One wish a day; a wish is made by tossing a coin at the fountain in Crossly World, never over the API, and nothing is spent.
[**ListSpatialSceneGrants**](WorldApi.md#listspatialscenegrants) | **GET** /v1/spatial/scenes/{id}/grants | Everyone who can currently walk into one of your rooms, and unused invites. Never returns codes.
[**ListSpatialSceneWarehouseUnplaced**](WorldApi.md#listspatialscenewarehouseunplaced) | **GET** /v1/spatial/scenes/{id}/warehouse/unplaced | Stock not yet on a shelf in a warehouse room you can arrange (q filters by title).
[**ListSpatialSharedWithMe**](WorldApi.md#listspatialsharedwithme) | **GET** /v1/spatial/shared-with-me | Rooms other people let you into.
[**ListSpatialStreetLeases**](WorldApi.md#listspatialstreetleases) | **GET** /v1/spatial/streets/{slug}/leases | Plots on a street offered for lease: weekly rent in CENTS and terms.
[**ListWorldAvatarCloset**](WorldApi.md#listworldavatarcloset) | **GET** /v1/world/avatar/closet | Everything you can verifiably wear (your Crossly purchase receipts), newest first: receiptId, item title, brand, size, image, catalog sku/variant, quantity, purchasedAt. Pass a receiptId to POST /v1/world/avatar/equip to put one on. limit 1-200, offset for paging.
[**ListWorldAvatarStock**](WorldApi.md#listworldavatarstock) | **GET** /v1/world/avatar/stock | Items of your OWN inventory you could wear into a room as a walking storefront: inventoryItemId, title, image and the slot it would go on. Pass an inventoryItemId to POST /v1/world/avatar/equip.
[**ListWorldAvatarWearables**](WorldApi.md#listworldavatarwearables) | **GET** /v1/world/avatar/wearables | Wearables you have authored as a designer: id, sku, name, slot, priceBaseUnits (COSM base units, a string), maxSupply, mintedCount, active (false until reviewed). meta.available is false when COSM is not provisioned here.
[**ListWorldBestDressed**](WorldApi.md#listworldbestdressed) | **GET** /v1/world/best-dressed | This week&#39;s best-dressed board (Monday-based), top ten: name, profile username and loves. Only people still choosing to be seen by name.
[**ListWorldCapabilityDeclarations**](WorldApi.md#listworldcapabilitydeclarations) | **GET** /v1/world/capabilities/declarations | Your capability declarations, in every review state (pending, live, rejected with the note from the reviewer).
[**ListWorldContestStandings**](WorldApi.md#listworldconteststandings) | **GET** /v1/world/contests/{id}/standings | The standings of a contest now: best score first (or lowest, for a time game), ties to whoever got there first.
[**ListWorldContests**](WorldApi.md#listworldcontests) | **GET** /v1/world/contests | Open skill contests on Crossly World games, soonest ending first: entry mode (free, sponsored, paid) and prizes.
[**ListWorldConventionExhibitors**](WorldApi.md#listworldconventionexhibitors) | **GET** /v1/world/conventions/{id}/exhibitors | The host roster: who applied, who was invited, who is coming (by shop handle). Host only; 404 otherwise.
[**ListWorldConventionMine**](WorldApi.md#listworldconventionmine) | **GET** /v1/world/conventions/mine | Conventions you host and conventions you are exhibiting at.
[**ListWorldConventions**](WorldApi.md#listworldconventions) | **GET** /v1/world/conventions | Conventions open to sellers now or soon: title, room, dates, and how to get a table (invite, free, fee or revenue share).
[**ListWorldCosmCosmetics**](WorldApi.md#listworldcosmcosmetics) | **GET** /v1/world/cosm/cosmetics | The active cosmetics catalogue, optionally by tier (premium | earned | stake_exclusive) or slot: sku, name, slot, tier, priceCents (premium only), priceBaseUnits (earned only, COSM base units string), supply, fusable, preview and what it unlocks. Read-only: cosmetics are bought on crossly.net. meta.available / meta.decimals.
[**ListWorldCosmDesigns**](WorldApi.md#listworldcosmdesigns) | **GET** /v1/world/cosm/designs | Your COSM designs in the world: popularity toward the free chain unlock a popular limited design earns, whether it is on chain, and your opt-out. Declare what a design does with chain cosm and the design id as the contract.
[**ListWorldCosmInventory**](WorldApi.md#listworldcosminventory) | **GET** /v1/world/cosm/inventory | Cosmetics you hold, newest first: ownershipId, cosmeticId, sku, name, slot, tier, how it was acquired, bound, edition number, acquiredAt and what it unlocks. Pass a cosmeticId to POST /v1/world/avatar/equip to wear one. meta.available.
[**ListWorldDecorCatalogue**](WorldApi.md#listworlddecorcatalogue) | **GET** /v1/world/decor/catalogue | The Decor Shop: every active cosmetic grouped by surface (avatar | home | shop | stall | street) and slot - - name, tier, priceCents (premium: the dollar price, paid in CBX at spot) or priceBaseUnits (earned: COSM, base-unit string), edition supply and remaining, tint swatch, preview, what it unlocks, owned + your edition number, and buyWith. Read-only: buying and minting happen on crossly.net/shop/decor. meta.available, meta.mint {open, reason}, meta.cbx {open, reason} (CBX opens at mint), meta.balances (your COSM and CBX, base-unit strings), meta.surfaces. Never sold by card.
[**ListWorldDecorDesigns**](WorldApi.md#listworlddecordesigns) | **GET** /v1/world/decor/designs | Your decor designs and their review state. available is false until COSM is provisioned.
[**ListWorldDecorInventory**](WorldApi.md#listworlddecorinventory) | **GET** /v1/world/decor/inventory | Your decor as an INVENTORY. Decor is a quantity: every copy is one unit - - a placed prop (home_prop, prop) uses one per placement, a finish (wallpaper, floor, theme, shopfront, facade, sign style, street lamp/banner/paving/arch, booth canopy/pattern/lights/counter) one per space it dresses; free values are unlimited. Per item: key, value, pair (key:value), name, sku, surface, placeable, tint, owned, placed, available, placements [{ space { kind: home | shop | stall | street, id, name }, count }], copies [{ ownershipId, editionNumber }]. meta.available, meta.spaces (every space you dress). Read-only: placing and retracting happen in the app or on crossly.net.
[**ListWorldDecorMarket**](WorldApi.md#listworlddecormarket) | **GET** /v1/world/decor/market | Decor copies other people are reselling (asks in COSM); optional pair filter. Read only: listing and buying stay on crossly.net.
[**ListWorldDecorMine**](WorldApi.md#listworlddecormine) | **GET** /v1/world/decor/mine | Decor you hold AND decor you have minted to your wallet, newest first: ownershipId, cosmeticId, sku, name, surface, slot, tier, acquiredVia, bound, editionNumber of maxSupply, mintState (held | minting | minted), mintAddress, mintable, and what it unlocks. meta.available, meta.mint.
[**ListWorldDecorStalls**](WorldApi.md#listworlddecorstalls) | **GET** /v1/world/decor/stalls | Your stall bookings, to dress their booths.
[**ListWorldDecorStreets**](WorldApi.md#listworlddecorstreets) | **GET** /v1/world/decor/streets | Streets you may dress.
[**ListWorldDms**](WorldApi.md#listworlddms) | **GET** /v1/world/dms | Your friends (mutual follows) for direct messages: each with userId, name, the last line between you (text, at, mine) or null, and how many of theirs you have not read; most recent first.
[**ListWorldFollowingRooms**](WorldApi.md#listworldfollowingrooms) | **GET** /v1/world/following/rooms | The public rooms of people you follow, to walk into.
[**ListWorldFollows**](WorldApi.md#listworldfollows) | **GET** /v1/world/follows | Everybody you follow in Crossly World, newest first, each with mutual: true when they follow you back (a friend).
[**ListWorldFriendHere**](WorldApi.md#listworldfriendhere) | **GET** /v1/world/friends/here | Your friends in Crossly World right now, and where (when they share it).
[**ListWorldFriends**](WorldApi.md#listworldfriends) | **GET** /v1/world/friends | Your friends (mutual follows), each with the PUBLIC room they are in right now when they chose to be seen by name there (else null), and their home address slug when they let friends visit. Invisible and anonymous friends are never located.
[**ListWorldGamePackages**](WorldApi.md#listworldgamepackages) | **GET** /v1/world/games/packages | Your game packages, each with its latest version and review state.
[**ListWorldGameRewards**](WorldApi.md#listworldgamerewards) | **GET** /v1/world/games/rewards | Rewards you won in games: granted, or recorded as unfunded for COSM and CBX (a game prints no value).
[**ListWorldGames**](WorldApi.md#listworldgames) | **GET** /v1/world/games | The Game Directory: every live, reviewed game package with its players, places, rewards, contests and the piece people place.
[**ListWorldHomeBuilding**](WorldApi.md#listworldhomebuilding) | **GET** /v1/world/home/building | Homes whose owner made you a co-builder.
[**ListWorldInteractiveCatalogue**](WorldApi.md#listworldinteractivecatalogue) | **GET** /v1/world/interactive/catalogue | Interactive objects: every piece that runs a shared script in a room (first-party and approved creator designs). Per item: model (the piece key a home layout or boutique prop stores), decorValue (the home_prop value its SKU claims), source (first_party | creator), name, blurb, size [x, z] metres, fallbackMesh, cosmeticId (the SKU on the Decor Shop, null when not on sale) and version (a creator design: the approved version every copy runs). Read-only: buying is on crossly.net/shop/decor.
[**ListWorldInteractiveDesigns**](WorldApi.md#listworldinteractivedesigns) | **GET** /v1/world/interactive/designs | Your interactive-object designs (MML documents you wrote), newest first: id, handle, name, footprint (s | m | l | f), tint, priceBaseUnits (COSM, base-unit string), maxSupply, model, decorValue, cosmeticId, liveVersion (the approved version every copy runs; null &#x3D; none), withdrawnReason, archivedAt (you archived it: off sale, owned copies keep running; null &#x3D; not archived), latestVersion { version, state: pending | approved | rejected | withdrawn | cancelled, decisionNote }, inReview. &#x60;archived&#x60;: exclude (default), include or only archived designs. Read-only: writing, previewing, submitting and archiving happen on crossly.net/shop/decor?tab&#x3D;interactive.
[**ListWorldJobPosted**](WorldApi.md#listworldjobposted) | **GET** /v1/world/jobs/posted | Shifts you posted for your rooms, with who claimed each and how it went.
[**ListWorldOutfits**](WorldApi.md#listworldoutfits) | **GET** /v1/world/outfits | Your saved outfits (up to 6, oldest first): id, name, appearance (skin, hair, hairColour, eyes, build) and items - - each worn thing as the door it goes back on by (slot, door: cosmetic | receipt | stock, id, label). Put one on with POST /v1/world/outfits/:id/apply.
[**ListWorldPlaceBans**](WorldApi.md#listworldplacebans) | **GET** /v1/world/places/{slug}/bans | Who is banned from a place you own (your boutique or home).
[**ListWorldPlaceBundles**](WorldApi.md#listworldplacebundles) | **GET** /v1/world/places/{slug}/bundles | The owner&#39;s bundle deals mapped onto this room&#39;s items (itemIds null &#x3D; any N from the shop). The discount is decided at checkout.
[**ListWorldPlaceCollections**](WorldApi.md#listworldplacecollections) | **GET** /v1/world/places/{slug}/collections | The owner&#39;s collection rooms: one per category, brand and model they collect.
[**ListWorldPlaceOffers**](WorldApi.md#listworldplaceoffers) | **GET** /v1/world/places/{slug}/offers | What is for sale in a public room: price, condition and stock, with market references. 404 when no such room is shared.
[**ListWorldPlaceRadar**](WorldApi.md#listworldplaceradar) | **GET** /v1/world/places/{slug}/radar | What you have that someone here wants, and what is here that you want: matched on catalog ids.
[**ListWorldPlaceTradeTables**](WorldApi.md#listworldplacetradetables) | **GET** /v1/world/places/{slug}/trade-tables | The open trade tables in a place: who is sitting and what is laid on the mat.
[**ListWorldPlaceTrades**](WorldApi.md#listworldplacetrades) | **GET** /v1/world/places/{slug}/trades | Items in this room open to trades, each with its trade post path.
[**ListWorldProvenance**](WorldApi.md#listworldprovenance) | **GET** /v1/world/provenance | Provenance trails: where in Crossly World your purchases were found, newest first (optionally ?listingIds&#x3D;a,b - - platform listing ids). data: [{ platformListingId, slug (the listing public slug), kind (room | window | stall | space | drop | auction | worn | agent), place (its name, or null when gone), at, line - - e.g. \&quot;Found at The Sneaker Vault, Oct 2026\&quot; }]. Yours only.
[**ListWorldQuests**](WorldApi.md#listworldquests) | **GET** /v1/world/quests | Every world quest with your progress: key, the pin it earns, goal, target, count, done, colour. meta.wearing is the pin on your nameplate (or null); meta.streak your current and best daily visit streak. Progress only comes from what the server saw - - there is no write of it.
[**ListWorldSpaceMine**](WorldApi.md#listworldspacemine) | **GET** /v1/world/spaces/mine | Spaces you belong to.
[**ListWorldSpaceRequests**](WorldApi.md#listworldspacerequests) | **GET** /v1/world/spaces/{slug}/requests | As host or co-host, who asked to join.
[**ListWorldSpaceWhatsOn**](WorldApi.md#listworldspacewhatson) | **GET** /v1/world/spaces/whats-on | Live and upcoming events across Spaces (streets&#x3D;1 and stage&#x3D;1 add street and Main Stage events).
[**ListWorldSpaces**](WorldApi.md#listworldspaces) | **GET** /v1/world/spaces | The Spaces directory: seller-hosted clubs with a venue, members and events (optional venue filter).
[**ListWorldStreaks**](WorldApi.md#listworldstreaks) | **GET** /v1/world/streaks | The longest current daily visit streaks (2+ days), top ten: name and days. Only people still choosing to be seen by name.
[**ListWorldTradeMine**](WorldApi.md#listworldtrademine) | **GET** /v1/world/trades/mine | Your trades and each item progress through the authentication gate (verified or failed).
[**ListWorldTradeTableBinder**](WorldApi.md#listworldtradetablebinder) | **GET** /v1/world/trade-tables/binder | Your binder: unsold collection rows that are catalog items and may be laid on a trade mat - - key, variantId, condition, grade, portfolioId, name, image and valueCents (market value, cents).
[**ListWorldTradeTableListings**](WorldApi.md#listworldtradetablelistings) | **GET** /v1/world/trade-tables/listings | Your open Trade Block trade listings a trade table can be opened on in the world, each with its items&#39; names.
[**UpdateSpatialSceneCosmetic**](WorldApi.md#updatespatialscenecosmetic) | **PATCH** /v1/spatial/scenes/{id}/cosmetics | Redecorate one of your rooms (wall, floor, lighting, trim...). Unknown keys are dropped; the response is what survived. &#x60;clear&#x60; lists keys to reset.
[**UpdateSpatialSceneNode**](WorldApi.md#updatespatialscenenode) | **PATCH** /v1/spatial/scenes/{id}/nodes/{nodeId} | Move a rack in one of your warehouse rooms (position in metres).
[**UpdateSpatialSceneSetting**](WorldApi.md#updatespatialscenesetting) | **PATCH** /v1/spatial/scenes/{id}/settings | How one of your rooms is laid out and lit: grouping and sort keys, theme, overlay and the arrival camera. Cosmetics and the shop layout have their own writers.
[**UpdateSpatialSceneShopLayout**](WorldApi.md#updatespatialsceneshoplayout) | **PUT** /v1/spatial/scenes/{id}/shop/layout | Save your shop room&#39;s sections and displays (validated server-side; the response is the stored layout).
[**UpdateSpatialSceneWindow**](WorldApi.md#updatespatialscenewindow) | **PUT** /v1/spatial/scenes/{id}/window | Choose up to three of your live Crossly listings for the street window of your shop, in slot order. Picks that sell drop out and the newest fill in; an empty list goes back to newest first.
[**UpdateSpatialStreetDecor**](WorldApi.md#updatespatialstreetdecor) | **PUT** /v1/spatial/streets/{slug}/decor | Dress a street you own with decor you hold (validated against your inventory).
[**UpdateSpatialStreetOwned**](WorldApi.md#updatespatialstreetowned) | **PATCH** /v1/spatial/streets/owned/{id} | Who may open a shop on a street you own (open, apply or invite).
[**UpdateWorldAutoShop**](WorldApi.md#updateworldautoshop) | **PATCH** /v1/world/auto-shop | Turn your automatic world shop off ({ enabled: false } - - an auto-created shop is made private, never deleted) or back on. Answers the new status.
[**UpdateWorldAvatarIdentity**](WorldApi.md#updateworldavataridentity) | **PUT** /v1/world/avatar/identity | Choose named or anonymous. Rooms you are already in keep the old answer until you rejoin.
[**UpdateWorldAvatarLook**](WorldApi.md#updateworldavatarlook) | **PUT** /v1/world/avatar/look | Save your world look to the account, so every device starts from it. look: null stays anonymous.
[**UpdateWorldAvatarNftBadge**](WorldApi.md#updateworldavatarnftbadge) | **PUT** /v1/world/avatar/nft-badge | Wear an NFT you hold on your nameplate (null to take it off). Checked again each time you join a room.
[**UpdateWorldCapabilityWear**](WorldApi.md#updateworldcapabilitywear) | **PUT** /v1/world/capabilities/wear | Wear a held token on an avatar slot (refId from GET /v1/world/capabilities), or pass refId null to take it off. Its collection must declare a wear capability for that slot.
[**UpdateWorldCollectionCapability**](WorldApi.md#updateworldcollectioncapability) | **PUT** /v1/world/collections/{chain}/{contract}/capabilities | Declare what the tokens of a collection can do (the whole declaration, spec crossly.nft-capabilities/1). As its creator (launched on Crossly or claimed) any kind; as a holder, cosmetic kinds only. Replaces your previous declaration; pending if it names an uploaded asset or an always-reviewed kind.
[**UpdateWorldConventionStatus**](WorldApi.md#updateworldconventionstatus) | **PUT** /v1/world/conventions/{id}/status | Open, start, end or cancel a convention you host.
[**UpdateWorldCosmDesignChainAutoUnlock**](WorldApi.md#updateworldcosmdesignchainautounlock) | **PUT** /v1/world/cosm/designs/{id}/chain-auto-unlock | Opt one of your COSM designs in or out of the free chain unlock it earns when popular (on by default). Answers its popularity.
[**UpdateWorldEmoteWheel**](WorldApi.md#updateworldemotewheel) | **PUT** /v1/world/emotes/wheel | Arrange your emote wheel: up to 8 slots, each an emote id, a moment slot or null. Returns the saved wheel (locked or unknown ids are dropped).
[**UpdateWorldFitValueShare**](WorldApi.md#updateworldfitvalueshare) | **PUT** /v1/world/fit-value/share | Whether people in a room can see what your outfit is worth.
[**UpdateWorldHome**](WorldApi.md#updateworldhome) | **PATCH** /v1/world/home | Your home: privacy (open, friends, private), theme, and wall, floor and mood decor you hold.
[**UpdateWorldHomeBuilder**](WorldApi.md#updateworldhomebuilder) | **PUT** /v1/world/home/builders | Set the co-builders of your home: { userIds } - - friends (mutual follows) only, at most 4, replacing the list ([] clears it). They may rearrange your home in the world with your things and add free furniture, never your bought pieces. New co-builders get a world notice.
[**UpdateWorldHomeLayout**](WorldApi.md#updateworldhomelayout) | **PUT** /v1/world/home/layout | Arrange your home: the full layout (up to 200 pieces you own), validated server-side.
[**UpdateWorldHomeLayoutBySlug**](WorldApi.md#updateworldhomelayoutbyslug) | **PUT** /v1/world/homes/{slug}/layout | Rearrange a home you co-build (never adding the owner bought pieces).
[**UpdateWorldInteractiveDesignDraft**](WorldApi.md#updateworldinteractivedesigndraft) | **PUT** /v1/world/interactive/designs/{id}/draft | Save the draft MML source (up to 64 KB); the response carries its static check.
[**UpdateWorldListingHoldersOnly**](WorldApi.md#updateworldlistingholdersonly) | **PUT** /v1/world/listings/{id}/holders-only | Reserve one of your listings for holders of a collection you declared a holders_only perk for (or release it). Checkout refuses anybody else.
[**UpdateWorldOutfit**](WorldApi.md#updateworldoutfit) | **PATCH** /v1/world/outfits/{id} | Rename a saved look: { name (1-32 chars) }. 404 when it is not yours.
[**UpdateWorldPetActive**](WorldApi.md#updateworldpetactive) | **PUT** /v1/world/pets/active | Walk one of your pets with you in the world, or none (kind: null).
[**UpdateWorldQuestPin**](WorldApi.md#updateworldquestpin) | **PUT** /v1/world/quests/pin | Wear a pin you EARNED from a quest on your nameplate, or { pin: null } to wear none. 403 for a pin you have not earned. Shows from the next room you walk into.
[**UpdateWorldRoomHolderGate**](WorldApi.md#updateworldroomholdergate) | **PUT** /v1/world/rooms/{id}/holder-gate | Make your room holders-only (its collection rooms follow). Send null to open it again. Returns &#x60;{ gate }&#x60;.
[**UpdateWorldSpace**](WorldApi.md#updateworldspace) | **PATCH** /v1/world/spaces/{slug} | As host, change a Space name, about or membership.
[**UpdateWorldSpaceHolderGate**](WorldApi.md#updateworldspaceholdergate) | **PUT** /v1/world/spaces/{slug}/holder-gate | Make your Space holders-only: only holders of an NFT collection join it (others can look in). Send null to open it again. Returns &#x60;{ gate }&#x60;.
[**UpdateWorldStallBookingBooth**](WorldApi.md#updateworldstallbookingbooth) | **PUT** /v1/world/stalls/bookings/{id}/booth | Dress the booth of a stall you booked (decor you hold).


<a name="createspatialinviteaccept"></a>
# **CreateSpatialInviteAccept**
> CreateSpatialInviteAcceptResponse CreateSpatialInviteAccept ()

Redeem an invite code (dashes optional); returns the room it opens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialInviteAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Redeem an invite code (dashes optional); returns the room it opens.
                CreateSpatialInviteAcceptResponse result = apiInstance.CreateSpatialInviteAccept();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialInviteAccept: " + e.Message );
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

**CreateSpatialInviteAcceptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialpropertyleasewithdraw"></a>
# **CreateSpatialPropertyLeaseWithdraw**
> DeleteDaoProposalResponse CreateSpatialPropertyLeaseWithdraw (string id)

Withdraw a lease offer nobody has accepted yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialPropertyLeaseWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Withdraw a lease offer nobody has accepted yet.
                DeleteDaoProposalResponse result = apiInstance.CreateSpatialPropertyLeaseWithdraw(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialPropertyLeaseWithdraw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteDaoProposalResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialscene"></a>
# **CreateSpatialScene**
> SpatialSceneResponse2 CreateSpatialScene (CreateSpatialSceneRequest createSpatialSceneRequest)

Start a 3D room: a collection (your items on shelves) or a warehouse (racks you arrange). Private until you make it public.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createSpatialSceneRequest = new CreateSpatialSceneRequest(); // CreateSpatialSceneRequest | 

            try
            {
                // Start a 3D room: a collection (your items on shelves) or a warehouse (racks you arrange). Private until you make it public.
                SpatialSceneResponse2 result = apiInstance.CreateSpatialScene(createSpatialSceneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialScene: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSpatialSceneRequest** | **CreateSpatialSceneRequest**|  | 

### Return type

**SpatialSceneResponse2**

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

<a name="createspatialscenegrant"></a>
# **CreateSpatialSceneGrant**
> CreateSpatialSceneGrantResponse CreateSpatialSceneGrant (string id)

Let a specific user into one of your rooms (visitor or staff), no code needed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneGrantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Let a specific user into one of your rooms (visitor or staff), no code needed.
                CreateSpatialSceneGrantResponse result = apiInstance.CreateSpatialSceneGrant(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneGrant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateSpatialSceneGrantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialsceneinvite"></a>
# **CreateSpatialSceneInvite**
> CreateSpatialSceneInviteResponse CreateSpatialSceneInvite (string id)

Mint an invite code to one of your rooms (visitor or staff, optional expiry in hours). The code is in this response only: just its hash is stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Mint an invite code to one of your rooms (visitor or staff, optional expiry in hours). The code is in this response only: just its hash is stored.
                CreateSpatialSceneInviteResponse result = apiInstance.CreateSpatialSceneInvite(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateSpatialSceneInviteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialscenenode"></a>
# **CreateSpatialSceneNode**
> CreateSpatialSceneNodeResponse CreateSpatialSceneNode (string id)

Add a unit (rack, shelf, bin) to one of your warehouse rooms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Add a unit (rack, shelf, bin) to one of your warehouse rooms.
                CreateSpatialSceneNodeResponse result = apiInstance.CreateSpatialSceneNode(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneNode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateSpatialSceneNodeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialsceneplace"></a>
# **CreateSpatialScenePlace**
> SpatialSceneResponse CreateSpatialScenePlace (string id)

Pin an inventory item to a slot in one of your rooms: by warehouse nodeId, or by a collection container key and index.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialScenePlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Pin an inventory item to a slot in one of your rooms: by warehouse nodeId, or by a collection container key and index.
                SpatialSceneResponse result = apiInstance.CreateSpatialScenePlace(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialScenePlace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**SpatialSceneResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialscenerename"></a>
# **CreateSpatialSceneRename**
> SpatialSceneResponse2 CreateSpatialSceneRename (string id, CreateSpatialSceneRenameRequest createSpatialSceneRenameRequest)

Rename one of your rooms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var createSpatialSceneRenameRequest = new CreateSpatialSceneRenameRequest(); // CreateSpatialSceneRenameRequest | 

            try
            {
                // Rename one of your rooms.
                SpatialSceneResponse2 result = apiInstance.CreateSpatialSceneRename(id, createSpatialSceneRenameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneRename: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createSpatialSceneRenameRequest** | **CreateSpatialSceneRenameRequest**|  | 

### Return type

**SpatialSceneResponse2**

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

<a name="createspatialsceneshopplace"></a>
# **CreateSpatialSceneShopPlace**
> SpatialSceneResponse CreateSpatialSceneShopPlace (string id)

Place an inventory item in a section and display of your shop room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneShopPlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Place an inventory item in a section and display of your shop room.
                SpatialSceneResponse result = apiInstance.CreateSpatialSceneShopPlace(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneShopPlace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**SpatialSceneResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialsceneunpin"></a>
# **CreateSpatialSceneUnpin**
> DeleteSpatialSceneNodeResponse CreateSpatialSceneUnpin (string id)

Clear every pin in one of your rooms, so it arranges itself again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneUnpinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Clear every pin in one of your rooms, so it arranges itself again.
                DeleteSpatialSceneNodeResponse result = apiInstance.CreateSpatialSceneUnpin(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneUnpin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteSpatialSceneNodeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialscenevisibility"></a>
# **CreateSpatialSceneVisibility**
> SpatialSceneResponse2 CreateSpatialSceneVisibility (string id, CreateSpatialSceneVisibilityRequest createSpatialSceneVisibilityRequest)

Make one of your rooms private, unlisted (anyone with the link) or public (in the lobby and searchable).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneVisibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var createSpatialSceneVisibilityRequest = new CreateSpatialSceneVisibilityRequest(); // CreateSpatialSceneVisibilityRequest | 

            try
            {
                // Make one of your rooms private, unlisted (anyone with the link) or public (in the lobby and searchable).
                SpatialSceneResponse2 result = apiInstance.CreateSpatialSceneVisibility(id, createSpatialSceneVisibilityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneVisibility: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createSpatialSceneVisibilityRequest** | **CreateSpatialSceneVisibilityRequest**|  | 

### Return type

**SpatialSceneResponse2**

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

<a name="createspatialscenewarehousestock"></a>
# **CreateSpatialSceneWarehouseStock**
> SpatialSceneResponse CreateSpatialSceneWarehouseStock (string id)

Put an inventory item (or unit) on a rack in one of your warehouse rooms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialSceneWarehouseStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Put an inventory item (or unit) on a rack in one of your warehouse rooms.
                SpatialSceneResponse result = apiInstance.CreateSpatialSceneWarehouseStock(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialSceneWarehouseStock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**SpatialSceneResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialshopneighbourhood"></a>
# **CreateSpatialShopNeighbourhood**
> CreateSpatialShopNeighbourhoodResponse CreateSpatialShopNeighbourhood ()

Move your shop to another neighbourhood (by slug).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialShopNeighbourhoodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Move your shop to another neighbourhood (by slug).
                CreateSpatialShopNeighbourhoodResponse result = apiInstance.CreateSpatialShopNeighbourhood();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialShopNeighbourhood: " + e.Message );
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

**CreateSpatialShopNeighbourhoodResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialstreetapply"></a>
# **CreateSpatialStreetApply**
> CreateSpatialStreetApplyResponse CreateSpatialStreetApply (string slug)

Ask to open your shop on a street whose owner reviews applications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Ask to open your shop on a street whose owner reviews applications.
                CreateSpatialStreetApplyResponse result = apiInstance.CreateSpatialStreetApply(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialStreetApply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateSpatialStreetApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createspatialstreetinvite"></a>
# **CreateSpatialStreetInvite**
> CreateSpatialStreetApplyResponse CreateSpatialStreetInvite (string slug)

Invite a shop (by its slug) to open on a street you own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateSpatialStreetInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Invite a shop (by its slug) to open on a street you own.
                CreateSpatialStreetApplyResponse result = apiInstance.CreateSpatialStreetInvite(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateSpatialStreetInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateSpatialStreetApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldavatarequip"></a>
# **CreateWorldAvatarEquip**
> CreateWorldAvatarEquipResponse CreateWorldAvatarEquip (CreateWorldAvatarEquipRequest createWorldAvatarEquipRequest)

Wear something you already own - - exactly ONE of { cosmeticId } (a cosmetic you hold), { receiptId } (a Crossly purchase from your closet) or { inventoryItemId } (your own stock). The slot comes from the thing itself; slot is only a fallback for an item with no catalog shape. Replaces whatever was in that slot. Moves no money. Answers the slot and your loadout after the change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldAvatarEquipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldAvatarEquipRequest = new CreateWorldAvatarEquipRequest(); // CreateWorldAvatarEquipRequest | 

            try
            {
                // Wear something you already own - - exactly ONE of { cosmeticId } (a cosmetic you hold), { receiptId } (a Crossly purchase from your closet) or { inventoryItemId } (your own stock). The slot comes from the thing itself; slot is only a fallback for an item with no catalog shape. Replaces whatever was in that slot. Moves no money. Answers the slot and your loadout after the change.
                CreateWorldAvatarEquipResponse result = apiInstance.CreateWorldAvatarEquip(createWorldAvatarEquipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldAvatarEquip: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldAvatarEquipRequest** | **CreateWorldAvatarEquipRequest**|  | 

### Return type

**CreateWorldAvatarEquipResponse**

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

<a name="createworldavatarunequip"></a>
# **CreateWorldAvatarUnequip**
> CreateWorldAvatarUnequipResponse CreateWorldAvatarUnequip (CreateWorldAvatarUnequipRequest createWorldAvatarUnequipRequest)

Take off whatever is in one slot. Idempotent: an empty slot answers removed:false. Answers your loadout after the change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldAvatarUnequipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldAvatarUnequipRequest = new CreateWorldAvatarUnequipRequest(); // CreateWorldAvatarUnequipRequest | 

            try
            {
                // Take off whatever is in one slot. Idempotent: an empty slot answers removed:false. Answers your loadout after the change.
                CreateWorldAvatarUnequipResponse result = apiInstance.CreateWorldAvatarUnequip(createWorldAvatarUnequipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldAvatarUnequip: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldAvatarUnequipRequest** | **CreateWorldAvatarUnequipRequest**|  | 

### Return type

**CreateWorldAvatarUnequipResponse**

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

<a name="createworldavatarwearable"></a>
# **CreateWorldAvatarWearable**
> CreateWorldAvatarWearableResponse CreateWorldAvatarWearable ()

Author a wearable for a body slot (a mesh profile and params, an asking price in COSM base units as a string). A submission: inactive until an operator approves it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldAvatarWearableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Author a wearable for a body slot (a mesh profile and params, an asking price in COSM base units as a string). A submission: inactive until an operator approves it.
                CreateWorldAvatarWearableResponse result = apiInstance.CreateWorldAvatarWearable();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldAvatarWearable: " + e.Message );
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

**CreateWorldAvatarWearableResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldcontest"></a>
# **CreateWorldContest**
> CreateWorldContestResponse CreateWorldContest ()

Set up a skill contest on a game placed in your place: title, game (its instance id), entry { mode, feeCents? }, prizes by place, funder, window, attempts. Paid entry needs the operator to allow it where it runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldContestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Set up a skill contest on a game placed in your place: title, game (its instance id), entry { mode, feeCents? }, prizes by place, funder, window, attempts. Paid entry needs the operator to allow it where it runs.
                CreateWorldContestResponse result = apiInstance.CreateWorldContest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldContest: " + e.Message );
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

**CreateWorldContestResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldcontestentrysettlepayment"></a>
# **CreateWorldContestEntrySettlePayment**
> CreateWorldContestEntrySettlePaymentResponse CreateWorldContestEntrySettlePayment (string id)

Read the fee of a paid entry back from Stripe and settle it (safe to repeat).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldContestEntrySettlePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Read the fee of a paid entry back from Stripe and settle it (safe to repeat).
                CreateWorldContestEntrySettlePaymentResponse result = apiInstance.CreateWorldContestEntrySettlePayment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldContestEntrySettlePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldContestEntrySettlePaymentResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldcontestjoin"></a>
# **CreateWorldContestJoin**
> CreateWorldContestJoinResponse CreateWorldContestJoin (string id)

Enter a contest. Free and sponsored contests take you in at once; a paid one answers a client secret to pay the entry fee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldContestJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Enter a contest. Free and sponsored contests take you in at once; a paid one answers a client secret to pay the entry fee.
                CreateWorldContestJoinResponse result = apiInstance.CreateWorldContestJoin(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldContestJoin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldContestJoinResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconvention"></a>
# **CreateWorldConvention**
> CreateWorldConventionResponse CreateWorldConvention ()

Host a convention in one of your rooms: title, dates, tables and how sellers get one (invite, free, a fee in cents, or a revenue share in basis points).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Host a convention in one of your rooms: title, dates, tables and how sellers get one (invite, free, a fee in cents, or a revenue share in basis points).
                CreateWorldConventionResponse result = apiInstance.CreateWorldConvention();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConvention: " + e.Message );
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

**CreateWorldConventionResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconventionaccept"></a>
# **CreateWorldConventionAccept**
> CreateWorldConventionAcceptResponse CreateWorldConventionAccept (string id)

Accept: your own invitation (no body), or, as host, an application (username).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Accept: your own invitation (no body), or, as host, an application (username).
                CreateWorldConventionAcceptResponse result = apiInstance.CreateWorldConventionAccept(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConventionAccept: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldConventionAcceptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconventionapply"></a>
# **CreateWorldConventionApply**
> CreateWorldConventionApplyResponse CreateWorldConventionApply (string id)

Ask for a table at a convention.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Ask for a table at a convention.
                CreateWorldConventionApplyResponse result = apiInstance.CreateWorldConventionApply(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConventionApply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldConventionApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconventioninvite"></a>
# **CreateWorldConventionInvite**
> CreateWorldSpaceInviteResponse CreateWorldConventionInvite (string id)

Invite a seller (by shop handle) to a convention you host.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Invite a seller (by shop handle) to a convention you host.
                CreateWorldSpaceInviteResponse result = apiInstance.CreateWorldConventionInvite(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConventionInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldSpaceInviteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconventionpaid"></a>
# **CreateWorldConventionPaid**
> CreateBreakCancelResponse CreateWorldConventionPaid (string id)

As host, record that a seller (username) paid their table fee off-platform. Moves no money.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionPaidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // As host, record that a seller (username) paid their table fee off-platform. Moves no money.
                CreateBreakCancelResponse result = apiInstance.CreateWorldConventionPaid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConventionPaid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateBreakCancelResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldconventionwithdraw"></a>
# **CreateWorldConventionWithdraw**
> CreateBreakCancelResponse CreateWorldConventionWithdraw (string id)

Withdraw your table or decline your invitation; as host, decline someone (username).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldConventionWithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Withdraw your table or decline your invitation; as host, decline someone (username).
                CreateBreakCancelResponse result = apiInstance.CreateWorldConventionWithdraw(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldConventionWithdraw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateBreakCancelResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldcrew"></a>
# **CreateWorldCrew**
> CreateWorldCrewResponse CreateWorldCrew (CreateWorldCrewRequest createWorldCrewRequest)

Start a crew you own: { name (2-32 chars), tag (2-5 letters or digits, shown on members' nameplates) }. Answers its id and join code. 409 when you are already in a crew.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCrewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldCrewRequest = new CreateWorldCrewRequest(); // CreateWorldCrewRequest | 

            try
            {
                // Start a crew you own: { name (2-32 chars), tag (2-5 letters or digits, shown on members' nameplates) }. Answers its id and join code. 409 when you are already in a crew.
                CreateWorldCrewResponse result = apiInstance.CreateWorldCrew(createWorldCrewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldCrew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldCrewRequest** | **CreateWorldCrewRequest**|  | 

### Return type

**CreateWorldCrewResponse**

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

<a name="createworldcrewchat"></a>
# **CreateWorldCrewChat**
> WorldResponse CreateWorldCrewChat (CreateWorldCrewChatRequest createWorldCrewChatRequest)

Say a line to your crew (body: text, up to 400 characters). Returns data.messages, the crew chat ring (the last 50 lines, kept in memory only), and data.said when your line went out; a blocked or too-quick line is dropped silently. 404 when you are in no crew.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCrewChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldCrewChatRequest = new CreateWorldCrewChatRequest(); // CreateWorldCrewChatRequest | 

            try
            {
                // Say a line to your crew (body: text, up to 400 characters). Returns data.messages, the crew chat ring (the last 50 lines, kept in memory only), and data.said when your line went out; a blocked or too-quick line is dropped silently. 404 when you are in no crew.
                WorldResponse result = apiInstance.CreateWorldCrewChat(createWorldCrewChatRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldCrewChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldCrewChatRequest** | **CreateWorldCrewChatRequest**|  | 

### Return type

**WorldResponse**

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

<a name="createworldcrewjoin"></a>
# **CreateWorldCrewJoin**
> CreateWorldCrewJoinResponse CreateWorldCrewJoin (CreateWorldCrewJoinRequest createWorldCrewJoinRequest)

Join a crew by the code a member gave you. 404 for an unknown code, 409 when you are already in a crew or it is full (30).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCrewJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldCrewJoinRequest = new CreateWorldCrewJoinRequest(); // CreateWorldCrewJoinRequest | 

            try
            {
                // Join a crew by the code a member gave you. 404 for an unknown code, 409 when you are already in a crew or it is full (30).
                CreateWorldCrewJoinResponse result = apiInstance.CreateWorldCrewJoin(createWorldCrewJoinRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldCrewJoin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldCrewJoinRequest** | **CreateWorldCrewJoinRequest**|  | 

### Return type

**CreateWorldCrewJoinResponse**

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

<a name="createworldcrewleave"></a>
# **CreateWorldCrewLeave**
> CreateWorldCrewLeaveResponse CreateWorldCrewLeave ()

Leave your crew. If you own it, the crew is disbanded. Idempotent: leaving when in none succeeds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldCrewLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Leave your crew. If you own it, the crew is disbanded. Idempotent: leaving when in none succeeds.
                CreateWorldCrewLeaveResponse result = apiInstance.CreateWorldCrewLeave();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldCrewLeave: " + e.Message );
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

**CreateWorldCrewLeaveResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworlddecordesign"></a>
# **CreateWorldDecorDesign**
> CreateWorldDecorDesignResponse CreateWorldDecorDesign ()

Author a decor design (what it unlocks, a mesh profile and params, an asking price in COSM base units as a string). Inactive until an operator approves it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldDecorDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Author a decor design (what it unlocks, a mesh profile and params, an asking price in COSM base units as a string). Inactive until an operator approves it.
                CreateWorldDecorDesignResponse result = apiInstance.CreateWorldDecorDesign();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldDecorDesign: " + e.Message );
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

**CreateWorldDecorDesignResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworlddecordesignsubmit"></a>
# **CreateWorldDecorDesignSubmit**
> CreateWorldDecorDesignSubmitResponse CreateWorldDecorDesignSubmit (string id)

Send one of your decor designs to the review queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldDecorDesignSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Send one of your decor designs to the review queue.
                CreateWorldDecorDesignSubmitResponse result = apiInstance.CreateWorldDecorDesignSubmit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldDecorDesignSubmit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldDecorDesignSubmitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworlddecorretract"></a>
# **CreateWorldDecorRetract**
> CreateWorldDecorRetractResponse CreateWorldDecorRetract ()

Take a placed decor piece back into your inventory; answers the inventory after.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldDecorRetractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Take a placed decor piece back into your inventory; answers the inventory after.
                CreateWorldDecorRetractResponse result = apiInstance.CreateWorldDecorRetract();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldDecorRetract: " + e.Message );
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

**CreateWorldDecorRetractResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworlddm"></a>
# **CreateWorldDm**
> CreateWorldDmResponse CreateWorldDm (string userId, CreateWorldCrewChatRequest createWorldCrewChatRequest)

Send a direct message to a friend (a mutual follow; never across a block), up to 400 characters, through the world chat guard. 403 when they are not a friend, 429 when sent too quickly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldDmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // string | 
            var createWorldCrewChatRequest = new CreateWorldCrewChatRequest(); // CreateWorldCrewChatRequest | 

            try
            {
                // Send a direct message to a friend (a mutual follow; never across a block), up to 400 characters, through the world chat guard. 403 when they are not a friend, 429 when sent too quickly.
                CreateWorldDmResponse result = apiInstance.CreateWorldDm(userId, createWorldCrewChatRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldDm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **createWorldCrewChatRequest** | **CreateWorldCrewChatRequest**|  | 

### Return type

**CreateWorldDmResponse**

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

<a name="createworldfollow"></a>
# **CreateWorldFollow**
> CreateWorldFollowResponse CreateWorldFollow (string userId)

Follow somebody. When they follow you back you are friends (friends-here, invites, messages). Idempotent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Follow somebody. When they follow you back you are friends (friends-here, invites, messages). Idempotent.
                CreateWorldFollowResponse result = apiInstance.CreateWorldFollow(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldFollow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**CreateWorldFollowResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldfriendinvite"></a>
# **CreateWorldFriendInvite**
> CreateWorldFriendInviteResponse CreateWorldFriendInvite (Guid userId, CreateWorldFriendInviteRequest createWorldFriendInviteRequest)

\"Join me\": send one friend (a mutual follow) a notification with a link to the PUBLIC room you name by slug. 404 when they are not a friend or the room is not public; 429 when you invited them in the last minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldFriendInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // Guid | 
            var createWorldFriendInviteRequest = new CreateWorldFriendInviteRequest(); // CreateWorldFriendInviteRequest | 

            try
            {
                // \"Join me\": send one friend (a mutual follow) a notification with a link to the PUBLIC room you name by slug. 404 when they are not a friend or the room is not public; 429 when you invited them in the last minute.
                CreateWorldFriendInviteResponse result = apiInstance.CreateWorldFriendInvite(userId, createWorldFriendInviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldFriendInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Guid**|  | 
 **createWorldFriendInviteRequest** | **CreateWorldFriendInviteRequest**|  | 

### Return type

**CreateWorldFriendInviteResponse**

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

<a name="createworldgamepackage"></a>
# **CreateWorldGamePackage**
> CreateWorldGamePackageResponse CreateWorldGamePackage ()

Submit a game package version for review: files as { path, base64 } (game.json, thumb.png, logic/, scene/, audio/, images/). Checked like the CLI, assets quarantined, the entry document dry-run, then reviewed by a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGamePackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Submit a game package version for review: files as { path, base64 } (game.json, thumb.png, logic/, scene/, audio/, images/). Checked like the CLI, assets quarantined, the entry document dry-run, then reviewed by a person.
                CreateWorldGamePackageResponse result = apiInstance.CreateWorldGamePackage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGamePackage: " + e.Message );
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

**CreateWorldGamePackageResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldgamepackagecheck"></a>
# **CreateWorldGamePackageCheck**
> CreateWorldGamePackageCheckResponse CreateWorldGamePackageCheck ()

Validate a game package exactly as a submission is checked (the shared intake report, your version still free) without storing, uploading or queuing anything: world-kit validate for an agent. Same files body as submit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGamePackageCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Validate a game package exactly as a submission is checked (the shared intake report, your version still free) without storing, uploading or queuing anything: world-kit validate for an agent. Same files body as submit.
                CreateWorldGamePackageCheckResponse result = apiInstance.CreateWorldGamePackageCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGamePackageCheck: " + e.Message );
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

**CreateWorldGamePackageCheckResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldgamerating"></a>
# **CreateWorldGameRating**
> CreateWorldGameRatingResponse CreateWorldGameRating (string id)

Rate a game you played, 1 to 5 stars (rating again replaces it). Only players the runner recorded in that game can rate it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGameRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Rate a game you played, 1 to 5 stars (rating again replaces it). Only players the runner recorded in that game can rate it.
                CreateWorldGameRatingResponse result = apiInstance.CreateWorldGameRating(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGameRating: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldGameRatingResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldgamereport"></a>
# **CreateWorldGameReport**
> CreateWorldGameReportResponse CreateWorldGameReport (string id)

Report a game: reason broken | unfair | offensive | scam | other, optional detail. Staff review it; the creator is told the reason, never who.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGameReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Report a game: reason broken | unfair | offensive | scam | other, optional detail. Staff review it; the creator is told the reason, never who.
                CreateWorldGameReportResponse result = apiInstance.CreateWorldGameReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGameReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldGameReportResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldgamestorecheckout"></a>
# **CreateWorldGameStoreCheckout**
> CreateWorldGameStoreCheckoutResponse CreateWorldGameStoreCheckout (string id, string item)

Buy an item or pass from a game store: answers a client secret for the payment; the item is yours once it succeeds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGameStoreCheckoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var item = "item_example";  // string | 

            try
            {
                // Buy an item or pass from a game store: answers a client secret for the payment; the item is yours once it succeeds.
                CreateWorldGameStoreCheckoutResponse result = apiInstance.CreateWorldGameStoreCheckout(id, item);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGameStoreCheckout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **item** | **string**|  | 

### Return type

**CreateWorldGameStoreCheckoutResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldgrailmatch"></a>
# **CreateWorldGrailMatch**
> CreateWorldGrailMatchResponse CreateWorldGrailMatch ()

Grail glints: send the ids on show somewhere (listingIds - - listings.id, inventoryIds, skuIds - - catalogue market SKUs; up to 400 each) and get back data.listingIds / data.inventoryIds / data.skuIds: the ones that are things you already want - - an open bid, a watched or wishlisted listing (or one selling the same SKU), a market watch, or a card your deck is missing. Read-only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldGrailMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Grail glints: send the ids on show somewhere (listingIds - - listings.id, inventoryIds, skuIds - - catalogue market SKUs; up to 400 each) and get back data.listingIds / data.inventoryIds / data.skuIds: the ones that are things you already want - - an open bid, a watched or wishlisted listing (or one selling the same SKU), a market watch, or a card your deck is missing. Read-only.
                CreateWorldGrailMatchResponse result = apiInstance.CreateWorldGrailMatch();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldGrailMatch: " + e.Message );
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

**CreateWorldGrailMatchResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldhallloan"></a>
# **CreateWorldHallLoan**
> CreateWorldHallLoanResponse CreateWorldHallLoan ()

Lend a piece from your vault to this week's Hall of Grails exhibition: { vaultItemId, credit: 'name' | 'anonymous' }. It shows under your plaque until the exhibition ends; it stays in your vault (still listable and withdrawable), and stops showing if it leaves.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldHallLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Lend a piece from your vault to this week's Hall of Grails exhibition: { vaultItemId, credit: 'name' | 'anonymous' }. It shows under your plaque until the exhibition ends; it stays in your vault (still listable and withdrawable), and stops showing if it leaves.
                CreateWorldHallLoanResponse result = apiInstance.CreateWorldHallLoan();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldHallLoan: " + e.Message );
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

**CreateWorldHallLoanResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldhomeask"></a>
# **CreateWorldHomeAsk**
> CreateWorldHomeAskResponse CreateWorldHomeAsk (string slug)

Ask a home owner whether they would sell a piece you saw there (an item or a decor piece).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldHomeAskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Ask a home owner whether they would sell a piece you saw there (an item or a decor piece).
                CreateWorldHomeAskResponse result = apiInstance.CreateWorldHomeAsk(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldHomeAsk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldHomeAskResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldhomeguestbook"></a>
# **CreateWorldHomeGuestbook**
> CreateWorldHomeGuestbookResponse CreateWorldHomeGuestbook (string slug)

Sign a home guestbook (one short line).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldHomeGuestbookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Sign a home guestbook (one short line).
                CreateWorldHomeGuestbookResponse result = apiInstance.CreateWorldHomeGuestbook(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldHomeGuestbook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldHomeGuestbookResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldhomeguestbookreport"></a>
# **CreateWorldHomeGuestbookReport**
> CreateWorldGameReportResponse CreateWorldHomeGuestbookReport (string slug, string id)

Report a guestbook entry to moderation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldHomeGuestbookReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Report a guestbook entry to moderation.
                CreateWorldGameReportResponse result = apiInstance.CreateWorldHomeGuestbookReport(slug, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldHomeGuestbookReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **id** | **string**|  | 

### Return type

**CreateWorldGameReportResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldhuntstart"></a>
# **CreateWorldHuntStart**
> GetWorldHuntResponse CreateWorldHuntStart ()

Start the Great Hunt this season by reading its first riddle (the Copper key's). Idempotent: starting again answers your progress unchanged. Answers the same shape as GET /v1/world/hunt. 409 when no season is running.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldHuntStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Start the Great Hunt this season by reading its first riddle (the Copper key's). Idempotent: starting again answers your progress unchanged. Answers the same shape as GET /v1/world/hunt. 409 when no season is running.
                GetWorldHuntResponse result = apiInstance.CreateWorldHuntStart();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldHuntStart: " + e.Message );
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

**GetWorldHuntResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractiveasset"></a>
# **CreateWorldInteractiveAsset**
> CreateWorldInteractiveAssetResponse CreateWorldInteractiveAsset ()

Upload one asset for your designs: kind glb (4 MB), wav (4 MB) or png (1 MB), the file as base64. Answers its sha256 and the path to reference from MML.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Upload one asset for your designs: kind glb (4 MB), wav (4 MB) or png (1 MB), the file as base64. Answers its sha256 and the path to reference from MML.
                CreateWorldInteractiveAssetResponse result = apiInstance.CreateWorldInteractiveAsset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveAsset: " + e.Message );
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

**CreateWorldInteractiveAssetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractivedesign"></a>
# **CreateWorldInteractiveDesign**
> GetWorldInteractiveDesignResponse CreateWorldInteractiveDesign ()

Create an interactive design: name, footprint (s, m, l or f), optional tint and description, an asking price in COSM base units (a string, six decimals) and optional max supply. Inactive until ops approve a submitted version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Create an interactive design: name, footprint (s, m, l or f), optional tint and description, an asking price in COSM base units (a string, six decimals) and optional max supply. Inactive until ops approve a submitted version.
                GetWorldInteractiveDesignResponse result = apiInstance.CreateWorldInteractiveDesign();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveDesign: " + e.Message );
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

**GetWorldInteractiveDesignResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractivedesigncheck"></a>
# **CreateWorldInteractiveDesignCheck**
> CreateWorldInteractiveDesignCheckResponse CreateWorldInteractiveDesignCheck (string id)

Check the draft: static rules, that every referenced upload exists, and a sandboxed dry run. Budgeted per person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveDesignCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Check the draft: static rules, that every referenced upload exists, and a sandboxed dry run. Budgeted per person.
                CreateWorldInteractiveDesignCheckResponse result = apiInstance.CreateWorldInteractiveDesignCheck(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveDesignCheck: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldInteractiveDesignCheckResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractivedesignpreview"></a>
# **CreateWorldInteractiveDesignPreview**
> CreateWorldInteractiveDesignPreviewResponse CreateWorldInteractiveDesignPreview (string id)

A private preview token for the draft (author only) and the socket path that runs it. Budgeted per person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveDesignPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A private preview token for the draft (author only) and the socket path that runs it. Budgeted per person.
                CreateWorldInteractiveDesignPreviewResponse result = apiInstance.CreateWorldInteractiveDesignPreview(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveDesignPreview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldInteractiveDesignPreviewResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractivedesignsubmit"></a>
# **CreateWorldInteractiveDesignSubmit**
> CreateWorldInteractiveDesignSubmitResponse CreateWorldInteractiveDesignSubmit (string id)

Freeze the draft as a new version and send it to ops review. Up to 10 a day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveDesignSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Freeze the draft as a new version and send it to ops review. Up to 10 a day.
                CreateWorldInteractiveDesignSubmitResponse result = apiInstance.CreateWorldInteractiveDesignSubmit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveDesignSubmit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldInteractiveDesignSubmitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldinteractivereset"></a>
# **CreateWorldInteractiveReset**
> CreateWorldInteractiveResetResponse CreateWorldInteractiveReset ()

Wipe the stored state of an interactive piece standing in a place you own (a home or your boutique).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldInteractiveResetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Wipe the stored state of an interactive piece standing in a place you own (a home or your boutique).
                CreateWorldInteractiveResetResponse result = apiInstance.CreateWorldInteractiveReset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldInteractiveReset: " + e.Message );
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

**CreateWorldInteractiveResetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldjobappraisalanswer"></a>
# **CreateWorldJobAppraisalAnswer**
> CreateWorldJobAppraisalAnswerResponse CreateWorldJobAppraisalAnswer (string id)

Answer a price check: your estimate of the item value in CENTS and an optional note. Moves no money; the asker may accept it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldJobAppraisalAnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Answer a price check: your estimate of the item value in CENTS and an optional note. Moves no money; the asker may accept it.
                CreateWorldJobAppraisalAnswerResponse result = apiInstance.CreateWorldJobAppraisalAnswer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldJobAppraisalAnswer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldJobAppraisalAnswerResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldjobshiftclaim"></a>
# **CreateWorldJobShiftClaim**
> CreateWorldJobShiftClaimResponse CreateWorldJobShiftClaim (string id)

Claim an open shift. You work it by being in the place while it runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldJobShiftClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Claim an open shift. You work it by being in the place while it runs.
                CreateWorldJobShiftClaimResponse result = apiInstance.CreateWorldJobShiftClaim(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldJobShiftClaim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldJobShiftClaimResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldjobshiftrelease"></a>
# **CreateWorldJobShiftRelease**
> CreateWorldJobShiftReleaseResponse CreateWorldJobShiftRelease (string id)

Give a shift you claimed back to the board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldJobShiftReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Give a shift you claimed back to the board.
                CreateWorldJobShiftReleaseResponse result = apiInstance.CreateWorldJobShiftRelease(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldJobShiftRelease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldJobShiftReleaseResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldoutfit"></a>
# **CreateWorldOutfit**
> CreateWorldOutfitResponse CreateWorldOutfit (CreateWorldOutfitRequest createWorldOutfitRequest)

Save what you are wearing now as a named look: { name (1-32 chars), appearance? (skin, hair, hairColour, eyes, build - - unknown keys fall back to the default) }. Each worn thing is recorded as the door it goes back on by; one that no longer traces to something you own is listed in skipped and not saved. 409 when you already keep 6.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldOutfitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var createWorldOutfitRequest = new CreateWorldOutfitRequest(); // CreateWorldOutfitRequest | 

            try
            {
                // Save what you are wearing now as a named look: { name (1-32 chars), appearance? (skin, hair, hairColour, eyes, build - - unknown keys fall back to the default) }. Each worn thing is recorded as the door it goes back on by; one that no longer traces to something you own is listed in skipped and not saved. 409 when you already keep 6.
                CreateWorldOutfitResponse result = apiInstance.CreateWorldOutfit(createWorldOutfitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldOutfit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldOutfitRequest** | **CreateWorldOutfitRequest**|  | 

### Return type

**CreateWorldOutfitResponse**

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

<a name="createworldoutfitapply"></a>
# **CreateWorldOutfitApply**
> CreateWorldOutfitApplyResponse CreateWorldOutfitApply (Guid id)

Put a saved look on. Every item goes through the same equip as POST /v1/world/avatar/equip, so ownership still holds: something you no longer own is listed in skipped with the reason and not worn. Slots the look left empty are emptied (cleared). Answers the appearance of the look (for your character - - appearance lives on your device), applied, skipped and cleared. Moves no money.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldOutfitApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Put a saved look on. Every item goes through the same equip as POST /v1/world/avatar/equip, so ownership still holds: something you no longer own is listed in skipped with the reason and not worn. Slots the look left empty are emptied (cleared). Answers the appearance of the look (for your character - - appearance lives on your device), applied, skipped and cleared. Moves no money.
                CreateWorldOutfitApplyResponse result = apiInstance.CreateWorldOutfitApply(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldOutfitApply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldOutfitApplyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldparty"></a>
# **CreateWorldParty**
> CreateBreakResponse CreateWorldParty ()

Start a party with you as leader (up to 8 members).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Start a party with you as leader (up to 8 members).
                CreateBreakResponse result = apiInstance.CreateWorldParty();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldParty: " + e.Message );
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

**CreateBreakResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartychat"></a>
# **CreateWorldPartyChat**
> WorldResponse CreateWorldPartyChat (string id)

Say something in your party chat (up to 2000 characters).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Say something in your party chat (up to 2000 characters).
                WorldResponse result = apiInstance.CreateWorldPartyChat(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**WorldResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartyinvite"></a>
# **CreateWorldPartyInvite**
> CreateWorldPartyInviteResponse CreateWorldPartyInvite (string id)

Invite a friend (userId) to your party.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Invite a friend (userId) to your party.
                CreateWorldPartyInviteResponse result = apiInstance.CreateWorldPartyInvite(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldPartyInviteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartyinviteaccept"></a>
# **CreateWorldPartyInviteAccept**
> CreateWorldPartyInviteAcceptResponse CreateWorldPartyInviteAccept (string inviteId)

Accept a party invite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyInviteAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var inviteId = "inviteId_example";  // string | 

            try
            {
                // Accept a party invite.
                CreateWorldPartyInviteAcceptResponse result = apiInstance.CreateWorldPartyInviteAccept(inviteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyInviteAccept: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inviteId** | **string**|  | 

### Return type

**CreateWorldPartyInviteAcceptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartyinvitedecline"></a>
# **CreateWorldPartyInviteDecline**
> CreateWorldPartyInviteAcceptResponse CreateWorldPartyInviteDecline (string inviteId)

Decline a party invite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyInviteDeclineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var inviteId = "inviteId_example";  // string | 

            try
            {
                // Decline a party invite.
                CreateWorldPartyInviteAcceptResponse result = apiInstance.CreateWorldPartyInviteDecline(inviteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyInviteDecline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inviteId** | **string**|  | 

### Return type

**CreateWorldPartyInviteAcceptResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartykick"></a>
# **CreateWorldPartyKick**
> CreateWorldPartyKickResponse CreateWorldPartyKick (string id)

As leader, remove a member (userId).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyKickExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // As leader, remove a member (userId).
                CreateWorldPartyKickResponse result = apiInstance.CreateWorldPartyKick(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyKick: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldPartyKickResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartyleader"></a>
# **CreateWorldPartyLeader**
> CreateWorldPartyLeaderResponse CreateWorldPartyLeader (string id)

As leader, pass the lead to a member (userId).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyLeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // As leader, pass the lead to a member (userId).
                CreateWorldPartyLeaderResponse result = apiInstance.CreateWorldPartyLeader(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyLeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldPartyLeaderResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartyleave"></a>
# **CreateWorldPartyLeave**
> CreateWorldPartyLeaveResponse CreateWorldPartyLeave (string id)

Leave your party (the lead passes on if you led it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Leave your party (the lead passes on if you led it).
                CreateWorldPartyLeaveResponse result = apiInstance.CreateWorldPartyLeave(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyLeave: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldPartyLeaveResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartywishlist"></a>
# **CreateWorldPartyWishlist**
> CreateWorldPartyWishlistResponse CreateWorldPartyWishlist (string id)

Add a listing (listingId, or its shop slug) to the party wishlist; answers the wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Add a listing (listingId, or its shop slug) to the party wishlist; answers the wishlist.
                CreateWorldPartyWishlistResponse result = apiInstance.CreateWorldPartyWishlist(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyWishlist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldPartyWishlistResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldpartywishlistvote"></a>
# **CreateWorldPartyWishlistVote**
> CreateWorldPartyWishlistResponse CreateWorldPartyWishlistVote (string id, string listingId)

Thumb a wishlist listing up or down (null clears your vote); answers the wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPartyWishlistVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var listingId = "listingId_example";  // string | 

            try
            {
                // Thumb a wishlist listing up or down (null clears your vote); answers the wishlist.
                CreateWorldPartyWishlistResponse result = apiInstance.CreateWorldPartyWishlistVote(id, listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPartyWishlistVote: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **listingId** | **string**|  | 

### Return type

**CreateWorldPartyWishlistResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldplaceitemwant"></a>
# **CreateWorldPlaceItemWant**
> CreateWorldPlaceItemWantResponse CreateWorldPlaceItemWant (string slug, string itemId)

Tell a room owner you would buy one of their items (once per person per item; they see the count). Moves no money.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldPlaceItemWantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var itemId = "itemId_example";  // string | 

            try
            {
                // Tell a room owner you would buy one of their items (once per person per item; they see the count). Moves no money.
                CreateWorldPlaceItemWantResponse result = apiInstance.CreateWorldPlaceItemWant(slug, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldPlaceItemWant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **itemId** | **string**|  | 

### Return type

**CreateWorldPlaceItemWantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspace"></a>
# **CreateWorldSpace**
> CreateWorldSpaceResponse CreateWorldSpace ()

Open a Space (sellers only, at most two): slug, name, venue, optional membership and about.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Open a Space (sellers only, at most two): slug, name, venue, optional membership and about.
                CreateWorldSpaceResponse result = apiInstance.CreateWorldSpace();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpace: " + e.Message );
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

**CreateWorldSpaceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspaceevent"></a>
# **CreateWorldSpaceEvent**
> CreateWorldSpaceEventResponse CreateWorldSpaceEvent (string slug)

As host or co-host, put an event on: title, kind, optional about, ISO start and end with offset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // As host or co-host, put an event on: title, kind, optional about, ISO start and end with offset.
                CreateWorldSpaceEventResponse result = apiInstance.CreateWorldSpaceEvent(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldSpaceEventResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspaceeventrsvp"></a>
# **CreateWorldSpaceEventRsvp**
> CreateWorldSpaceEventRsvpResponse CreateWorldSpaceEventRsvp (string slug, string id)

Say whether you are going to an event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceEventRsvpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // Say whether you are going to an event.
                CreateWorldSpaceEventRsvpResponse result = apiInstance.CreateWorldSpaceEventRsvp(slug, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceEventRsvp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **id** | **string**|  | 

### Return type

**CreateWorldSpaceEventRsvpResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspaceinvite"></a>
# **CreateWorldSpaceInvite**
> CreateWorldSpaceInviteResponse CreateWorldSpaceInvite (string slug)

Invite somebody (userId) to a Space.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Invite somebody (userId) to a Space.
                CreateWorldSpaceInviteResponse result = apiInstance.CreateWorldSpaceInvite(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldSpaceInviteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspacejoin"></a>
# **CreateWorldSpaceJoin**
> CreateWorldSpaceJoinResponse CreateWorldSpaceJoin (string slug)

Join a Space, or ask to when it is request-only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceJoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Join a Space, or ask to when it is request-only.
                CreateWorldSpaceJoinResponse result = apiInstance.CreateWorldSpaceJoin(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceJoin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldSpaceJoinResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspaceleave"></a>
# **CreateWorldSpaceLeave**
> CreateWorldCrewLeaveResponse CreateWorldSpaceLeave (string slug)

Leave a Space.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceLeaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Leave a Space.
                CreateWorldCrewLeaveResponse result = apiInstance.CreateWorldSpaceLeave(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceLeave: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldCrewLeaveResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspacerequestbyuserid"></a>
# **CreateWorldSpaceRequestByUserId**
> CreateWorldSpaceRequestByUserIdResponse CreateWorldSpaceRequestByUserId (string slug, string userId)

As host or co-host, accept or turn down a request to join.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceRequestByUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // As host or co-host, accept or turn down a request to join.
                CreateWorldSpaceRequestByUserIdResponse result = apiInstance.CreateWorldSpaceRequestByUserId(slug, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceRequestByUserId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userId** | **string**|  | 

### Return type

**CreateWorldSpaceRequestByUserIdResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createworldspacerole"></a>
# **CreateWorldSpaceRole**
> CreateWorldSpaceRoleResponse CreateWorldSpaceRole (string slug)

As host, make a member a co-host or back to a member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateWorldSpaceRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // As host, make a member a co-host or back to a member.
                CreateWorldSpaceRoleResponse result = apiInstance.CreateWorldSpaceRole(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorldSpaceRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateWorldSpaceRoleResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletespatialscenegrant"></a>
# **DeleteSpatialSceneGrant**
> DeleteSpatialSceneGrantResponse DeleteSpatialSceneGrant (string id, string grantId)

Take somebody's access to your room away, or kill an invite nobody has used yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSpatialSceneGrantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var grantId = "grantId_example";  // string | 

            try
            {
                // Take somebody's access to your room away, or kill an invite nobody has used yet.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteSpatialSceneGrant(id, grantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteSpatialSceneGrant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteSpatialSceneGrantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletespatialscenenode"></a>
# **DeleteSpatialSceneNode**
> DeleteSpatialSceneNodeResponse DeleteSpatialSceneNode (string id)

Remove units (by id, up to 500) from one of your warehouse rooms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSpatialSceneNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Remove units (by id, up to 500) from one of your warehouse rooms.
                DeleteSpatialSceneNodeResponse result = apiInstance.DeleteSpatialSceneNode(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteSpatialSceneNode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteSpatialSceneNodeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletespatialscenewarehousestock"></a>
# **DeleteSpatialSceneWarehouseStock**
> DeleteSpatialSceneGrantResponse DeleteSpatialSceneWarehouseStock (string id)

Take an inventory item (or unit) off its rack.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSpatialSceneWarehouseStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take an inventory item (or unit) off its rack.
                DeleteSpatialSceneGrantResponse result = apiInstance.DeleteSpatialSceneWarehouseStock(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteSpatialSceneWarehouseStock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteSpatialSceneGrantResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletespatialstreetrequest"></a>
# **DeleteSpatialStreetRequest**
> DeleteDaoProposalResponse DeleteSpatialStreetRequest (string id)

Withdraw a street request you made that has not been founded yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteSpatialStreetRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Withdraw a street request you made that has not been founded yet.
                DeleteDaoProposalResponse result = apiInstance.DeleteSpatialStreetRequest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteSpatialStreetRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteDaoProposalResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldblock"></a>
# **DeleteWorldBlock**
> DeleteWorldBlockResponse DeleteWorldBlock (string id)

Unblock somebody (by the block id from GET /v1/world/blocks).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Unblock somebody (by the block id from GET /v1/world/blocks).
                DeleteWorldBlockResponse result = apiInstance.DeleteWorldBlock(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldBlock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteWorldBlockResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldcollectioncapability"></a>
# **DeleteWorldCollectionCapability**
> void DeleteWorldCollectionCapability (string chain, string contract)

Withdraw your declaration for a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldCollectionCapabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // Withdraw your declaration for a collection.
                apiInstance.DeleteWorldCollectionCapability(chain, contract);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldCollectionCapability: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

<a name="deleteworldfollow"></a>
# **DeleteWorldFollow**
> CreateWorldFollowResponse DeleteWorldFollow (string userId)

Unfollow somebody. Idempotent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Unfollow somebody. Idempotent.
                CreateWorldFollowResponse result = apiInstance.DeleteWorldFollow(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldFollow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**CreateWorldFollowResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldhallloan"></a>
# **DeleteWorldHallLoan**
> CreateBreakResponse DeleteWorldHallLoan (string id)

Take one of your loans off show in the Hall of Grails.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldHallLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Take one of your loans off show in the Hall of Grails.
                CreateBreakResponse result = apiInstance.DeleteWorldHallLoan(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldHallLoan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateBreakResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldhomeguestbook"></a>
# **DeleteWorldHomeGuestbook**
> DeleteWorldHomeGuestbookResponse DeleteWorldHomeGuestbook (string slug, string id)

As the home owner, hide a guestbook entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldHomeGuestbookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // As the home owner, hide a guestbook entry.
                DeleteWorldHomeGuestbookResponse result = apiInstance.DeleteWorldHomeGuestbook(slug, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldHomeGuestbook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **id** | **string**|  | 

### Return type

**DeleteWorldHomeGuestbookResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldinteractivedesign"></a>
# **DeleteWorldInteractiveDesign**
> DeleteWorldInteractiveDesignResponse DeleteWorldInteractiveDesign (string id)

Delete a draft design, or archive a submitted one (off sale; owned copies keep working).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldInteractiveDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a draft design, or archive a submitted one (off sale; owned copies keep working).
                DeleteWorldInteractiveDesignResponse result = apiInstance.DeleteWorldInteractiveDesign(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldInteractiveDesign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteWorldInteractiveDesignResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldjobshift"></a>
# **DeleteWorldJobShift**
> DeleteWorldJobShiftResponse DeleteWorldJobShift (string id)

Cancel a shift you posted that nobody has worked yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldJobShiftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Cancel a shift you posted that nobody has worked yet.
                DeleteWorldJobShiftResponse result = apiInstance.DeleteWorldJobShift(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldJobShift: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteWorldJobShiftResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldoutfit"></a>
# **DeleteWorldOutfit**
> DeleteWorldOutfitResponse DeleteWorldOutfit (Guid id)

Delete a saved look. 404 when it is not yours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldOutfitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a saved look. 404 when it is not yours.
                DeleteWorldOutfitResponse result = apiInstance.DeleteWorldOutfit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldOutfit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteWorldOutfitResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldpartywishlist"></a>
# **DeleteWorldPartyWishlist**
> CreateWorldPartyWishlistResponse DeleteWorldPartyWishlist (string id, string listingId)

Take a listing you added off the party wishlist; answers the wishlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldPartyWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var listingId = "listingId_example";  // string | 

            try
            {
                // Take a listing you added off the party wishlist; answers the wishlist.
                CreateWorldPartyWishlistResponse result = apiInstance.DeleteWorldPartyWishlist(id, listingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldPartyWishlist: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **listingId** | **string**|  | 

### Return type

**CreateWorldPartyWishlistResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldplaceban"></a>
# **DeleteWorldPlaceBan**
> DeleteWorldPlaceBanResponse DeleteWorldPlaceBan (string slug, string userId)

Lift a ban from a place you own; they can walk in again right away.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldPlaceBanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var userId = "userId_example";  // string | 

            try
            {
                // Lift a ban from a place you own; they can walk in again right away.
                DeleteWorldPlaceBanResponse result = apiInstance.DeleteWorldPlaceBan(slug, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldPlaceBan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **userId** | **string**|  | 

### Return type

**DeleteWorldPlaceBanResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldspace"></a>
# **DeleteWorldSpace**
> DeleteWorldSpaceResponse DeleteWorldSpace (string slug)

As host, close a Space.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // As host, close a Space.
                DeleteWorldSpaceResponse result = apiInstance.DeleteWorldSpace(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldSpace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteWorldSpaceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteworldspaceevent"></a>
# **DeleteWorldSpaceEvent**
> DeleteWorldJobShiftResponse DeleteWorldSpaceEvent (string slug, string id)

As host or co-host, cancel an event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteWorldSpaceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                // As host or co-host, cancel an event.
                DeleteWorldJobShiftResponse result = apiInstance.DeleteWorldSpaceEvent(slug, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorldSpaceEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **id** | **string**|  | 

### Return type

**DeleteWorldJobShiftResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialsceneattention"></a>
# **GetSpatialSceneAttention**
> GetSpatialSceneAttentionResponse GetSpatialSceneAttention (string sceneId)

What visitors looked at in one of your rooms: viewers, looks, inspects and dwell per item over the last days (1-35, default 30).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialSceneAttentionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var sceneId = "sceneId_example";  // string | 

            try
            {
                // What visitors looked at in one of your rooms: viewers, looks, inspects and dwell per item over the last days (1-35, default 30).
                GetSpatialSceneAttentionResponse result = apiInstance.GetSpatialSceneAttention(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialSceneAttention: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sceneId** | **string**|  | 

### Return type

**GetSpatialSceneAttentionResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialscenewindow"></a>
# **GetSpatialSceneWindow**
> GetSpatialSceneWindowResponse GetSpatialSceneWindow (string id)

The listings you chose for the street window of your shop, in slot order (left, middle, right; empty = newest first), and `choices`: your listings that can go in it, newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialSceneWindowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The listings you chose for the street window of your shop, in slot order (left, middle, right; empty = newest first), and `choices`: your listings that can go in it, newest first.
                GetSpatialSceneWindowResponse result = apiInstance.GetSpatialSceneWindow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialSceneWindow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetSpatialSceneWindowResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialshopneighbourhood"></a>
# **GetSpatialShopNeighbourhood**
> GetSpatialShopNeighbourhoodResponse GetSpatialShopNeighbourhood ()

Your shop's neighbourhood, and whether and where it may move.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialShopNeighbourhoodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your shop's neighbourhood, and whether and where it may move.
                GetSpatialShopNeighbourhoodResponse result = apiInstance.GetSpatialShopNeighbourhood();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialShopNeighbourhood: " + e.Message );
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

**GetSpatialShopNeighbourhoodResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialspace"></a>
# **GetSpatialSpace**
> GetSpatialSpaceResponse GetSpatialSpace ()

The room catalogue: every space profile (what it holds, how it is sorted, its containers) and the warehouse units.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The room catalogue: every space profile (what it holds, how it is sorted, its containers) and the warehouse units.
                GetSpatialSpaceResponse result = apiInstance.GetSpatialSpace();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialSpace: " + e.Message );
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

**GetSpatialSpaceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialstreetadmission"></a>
# **GetSpatialStreetAdmission**
> GetSpatialStreetAdmissionResponse GetSpatialStreetAdmission ()

Street applications and invitations: yours, and those waiting on streets you own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialStreetAdmissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Street applications and invitations: yours, and those waiting on streets you own.
                GetSpatialStreetAdmissionResponse result = apiInstance.GetSpatialStreetAdmission();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialStreetAdmission: " + e.Message );
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

**GetSpatialStreetAdmissionResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getspatialstreetdecor"></a>
# **GetSpatialStreetDecor**
> GetSpatialStreetDecorResponse GetSpatialStreetDecor (string slug)

The decor on a street you may dress, and what you can place.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetSpatialStreetDecorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The decor on a street you may dress, and what you can place.
                GetSpatialStreetDecorResponse result = apiInstance.GetSpatialStreetDecor(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetSpatialStreetDecor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetSpatialStreetDecorResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldarcade"></a>
# **GetWorldArcade**
> GetWorldArcadeResponse GetWorldArcade ()

The Arcade in Crossly World: data.cabinets (slot, where it stands, host - - piece, price_guess or empty - -, game, title, blurb, the piece it hosts and where, record, packageId and thumbnail for a creator game from the Game Directory, players) and data.scores (the High Score wall: per game a title, kind - - leaderboard, record or top - - and up to five ASCII lines; a name shows only for somebody who chose to be seen by name, everyone else is \"A player\"), plus creatorGames (creator games with a cabinet now). Games are played in the world.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldArcadeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Arcade in Crossly World: data.cabinets (slot, where it stands, host - - piece, price_guess or empty - -, game, title, blurb, the piece it hosts and where, record, packageId and thumbnail for a creator game from the Game Directory, players) and data.scores (the High Score wall: per game a title, kind - - leaderboard, record or top - - and up to five ASCII lines; a name shows only for somebody who chose to be seen by name, everyone else is \"A player\"), plus creatorGames (creator games with a cabinet now). Games are played in the world.
                GetWorldArcadeResponse result = apiInstance.GetWorldArcade();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldArcade: " + e.Message );
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

**GetWorldArcadeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldaurora"></a>
# **GetWorldAurora**
> GetWorldAuroraResponse GetWorldAurora ()

The Sales Aurora over the Commons in Crossly World: every real sale on Crossly in the last data.windowDays (30) days. data.total (sales in the window), data.families (key, label, colour, count per colour family: cards, coins, jewellery, electronics, media, fashion, toys, other) and data.sales (newest first, at most 48: family, ageHours, fresh - - sold in the last ten minutes, which shimmers). Aggregate only: no item, price, seller or platform. data.updatedAt is when it was read.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAuroraExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Sales Aurora over the Commons in Crossly World: every real sale on Crossly in the last data.windowDays (30) days. data.total (sales in the window), data.families (key, label, colour, count per colour family: cards, coins, jewellery, electronics, media, fashion, toys, other) and data.sales (newest first, at most 48: family, ageHours, fresh - - sold in the last ten minutes, which shimmers). Aggregate only: no item, price, seller or platform. data.updatedAt is when it was read.
                GetWorldAuroraResponse result = apiInstance.GetWorldAurora();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAurora: " + e.Message );
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

**GetWorldAuroraResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldautoshop"></a>
# **GetWorldAutoShop**
> GetWorldAutoShopResponse GetWorldAutoShop ()

Whether Crossly keeps a world shop for you automatically: enabled, and the shop (id, name, visibility, autoCreated, address, label) or null. Change it with PATCH /v1/world/auto-shop.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAutoShopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Whether Crossly keeps a world shop for you automatically: enabled, and the shop (id, name, visibility, autoCreated, address, label) or null. Change it with PATCH /v1/world/auto-shop.
                GetWorldAutoShopResponse result = apiInstance.GetWorldAutoShop();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAutoShop: " + e.Message );
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

**GetWorldAutoShopResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldavataridentity"></a>
# **GetWorldAvatarIdentity**
> GetWorldAvatarIdentityResponse GetWorldAvatarIdentity ()

Whether others see your name in the world (named), or not (anonymous); null if you have never chosen.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAvatarIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Whether others see your name in the world (named), or not (anonymous); null if you have never chosen.
                GetWorldAvatarIdentityResponse result = apiInstance.GetWorldAvatarIdentity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAvatarIdentity: " + e.Message );
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

**GetWorldAvatarIdentityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldavatarloadout"></a>
# **GetWorldAvatarLoadout**
> GetWorldAvatarLoadoutResponse GetWorldAvatarLoadout ()

What you are wearing: the rig, its slots (avatar_head, avatar_body, avatar_outer - - a jacket over the top, avatar_legs, avatar_feet, avatar_back) and each worn entry - - a cosmetic or a real item - - with its verified-purchase mark. Carries no price, receipt id, seller or order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAvatarLoadoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // What you are wearing: the rig, its slots (avatar_head, avatar_body, avatar_outer - - a jacket over the top, avatar_legs, avatar_feet, avatar_back) and each worn entry - - a cosmetic or a real item - - with its verified-purchase mark. Carries no price, receipt id, seller or order.
                GetWorldAvatarLoadoutResponse result = apiInstance.GetWorldAvatarLoadout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAvatarLoadout: " + e.Message );
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

**GetWorldAvatarLoadoutResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldavatarloadoutbyuserid"></a>
# **GetWorldAvatarLoadoutByUserId**
> GetWorldAvatarLoadoutResponse GetWorldAvatarLoadoutByUserId (Guid userId)

What somebody else is wearing, with the verified-purchase mark on each real item - - public on purpose, since a check only its owner can see is not a check. No price, receipt id, seller or order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAvatarLoadoutByUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // Guid | 

            try
            {
                // What somebody else is wearing, with the verified-purchase mark on each real item - - public on purpose, since a check only its owner can see is not a check. No price, receipt id, seller or order.
                GetWorldAvatarLoadoutResponse result = apiInstance.GetWorldAvatarLoadoutByUserId(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAvatarLoadoutByUserId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Guid**|  | 

### Return type

**GetWorldAvatarLoadoutResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldavatarlook"></a>
# **GetWorldAvatarLook**
> GetWorldAvatarLookResponse GetWorldAvatarLook ()

Your world look on the account: the handle you chose (null if anonymous) and your appearance; null if you never made one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAvatarLookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your world look on the account: the handle you chose (null if anonymous) and your appearance; null if you never made one.
                GetWorldAvatarLookResponse result = apiInstance.GetWorldAvatarLook();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAvatarLook: " + e.Message );
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

**GetWorldAvatarLookResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldavatarnftbadge"></a>
# **GetWorldAvatarNftBadge**
> GetWorldAvatarNftBadgeResponse GetWorldAvatarNftBadge ()

The NFT you wear on your nameplate in the world, or null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldAvatarNftBadgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The NFT you wear on your nameplate in the world, or null.
                GetWorldAvatarNftBadgeResponse result = apiInstance.GetWorldAvatarNftBadge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldAvatarNftBadge: " + e.Message );
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

**GetWorldAvatarNftBadgeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcapability"></a>
# **GetWorldCapability**
> GetWorldCapabilityResponse GetWorldCapability ()

What your held NFTs unlock in Crossly World: each token with the capabilities its collection declared (wear, display, emote, gate, ...). Holding is your verified wallets (their synced tokens); the capabilities of a transferred token go within five minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCapabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // What your held NFTs unlock in Crossly World: each token with the capabilities its collection declared (wear, display, emote, gate, ...). Holding is your verified wallets (their synced tokens); the capabilities of a transferred token go within five minutes.
                GetWorldCapabilityResponse result = apiInstance.GetWorldCapability();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCapability: " + e.Message );
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

**GetWorldCapabilityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcapabilitycatalogue"></a>
# **GetWorldCapabilityCatalogue**
> GetWorldCapabilityCatalogueResponse GetWorldCapabilityCatalogue ()

The capability kinds of spec crossly.nft-capabilities/1: what each does, whether only the creator of the collection may declare it, whether it needs review, and which clients honour it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCapabilityCatalogueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The capability kinds of spec crossly.nft-capabilities/1: what each does, whether only the creator of the collection may declare it, whether it needs review, and which clients honour it.
                GetWorldCapabilityCatalogueResponse result = apiInstance.GetWorldCapabilityCatalogue();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCapabilityCatalogue: " + e.Message );
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

**GetWorldCapabilityCatalogueResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcapabilitywear"></a>
# **GetWorldCapabilityWear**
> GetWorldCapabilityWearResponse GetWorldCapabilityWear ()

What you wear from your NFTs and COSM copies: your pick per avatar slot (head, body, legs, feet, back) and what the room sees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCapabilityWearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // What you wear from your NFTs and COSM copies: your pick per avatar slot (head, body, legs, feet, back) and what the room sees.
                GetWorldCapabilityWearResponse result = apiInstance.GetWorldCapabilityWear();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCapabilityWear: " + e.Message );
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

**GetWorldCapabilityWearResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldchest"></a>
# **GetWorldChest**
> GetWorldChestResponse GetWorldChest ()

The Commons chest: data.window (this 20-minute window, UTC), spot ([x, z] on the plaza), endsAt (when the next chest comes) and mine (openedThis, and opened - - how many windows you have opened one in; the Chest opener pin comes at 10). A chest is opened by walking up to it in Crossly World, never over the API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldChestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Commons chest: data.window (this 20-minute window, UTC), spot ([x, z] on the plaza), endsAt (when the next chest comes) and mine (openedThis, and opened - - how many windows you have opened one in; the Chest opener pin comes at 10). A chest is opened by walking up to it in Crossly World, never over the API.
                GetWorldChestResponse result = apiInstance.GetWorldChest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldChest: " + e.Message );
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

**GetWorldChestResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcollectioncapability"></a>
# **GetWorldCollectionCapability**
> GetWorldCollectionCapabilityResponse GetWorldCollectionCapability (string chain, string contract)

The live capability declaration of a collection (404 when it has none).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCollectionCapabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // The live capability declaration of a collection (404 when it has none).
                GetWorldCollectionCapabilityResponse result = apiInstance.GetWorldCollectionCapability(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCollectionCapability: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldCollectionCapabilityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcontestmine"></a>
# **GetWorldContestMine**
> GetWorldContestMineResponse GetWorldContestMine ()

Your contest entries (best score, attempts used, payment state) and prizes (granted, or owed until their gate opens).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldContestMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your contest entries (best score, attempts used, payment state) and prizes (granted, or owed until their gate opens).
                GetWorldContestMineResponse result = apiInstance.GetWorldContestMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldContestMine: " + e.Message );
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

**GetWorldContestMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldconvention"></a>
# **GetWorldConvention**
> GetWorldConventionResponse GetWorldConvention (string id)

One convention. 404 for an unknown or malformed id alike.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldConventionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One convention. 404 for an unknown or malformed id alike.
                GetWorldConventionResponse result = apiInstance.GetWorldConvention(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldConvention: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldConventionResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcosmbalance"></a>
# **GetWorldCosmBalance**
> GetWorldCosmBalanceResponse GetWorldCosmBalance ()

Your COSM balance: baseUnits (a STRING - - COSM has 6 decimals and overflows a JSON number), decimals, available (false = COSM is not provisioned on this deployment, not a zero balance).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCosmBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your COSM balance: baseUnits (a STRING - - COSM has 6 decimals and overflows a JSON number), decimals, available (false = COSM is not provisioned on this deployment, not a zero balance).
                GetWorldCosmBalanceResponse result = apiInstance.GetWorldCosmBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCosmBalance: " + e.Message );
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

**GetWorldCosmBalanceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcrew"></a>
# **GetWorldCrew**
> GetWorldCrewResponse GetWorldCrew ()

Your crew: data.crew is null when you are in none, else its name, tag, join code and whether you own it; data.members lists up to 30 members, each with the public room they are in right now when they chose to be seen by name (else null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCrewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your crew: data.crew is null when you are in none, else its name, tag, join code and whether you own it; data.members lists up to 30 members, each with the public room they are in right now when they chose to be seen by name (else null).
                GetWorldCrewResponse result = apiInstance.GetWorldCrew();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCrew: " + e.Message );
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

**GetWorldCrewResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcrewchat"></a>
# **GetWorldCrewChat**
> WorldResponse GetWorldCrewChat ()

Your crew chat: data.messages is the last 50 lines (from, name, text, at), kept in memory only, so it starts empty after a restart. 404 when you are in no crew.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCrewChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your crew chat: data.messages is the last 50 lines (from, name, text, at), kept in memory only, so it starts empty after a restart. 404 when you are in no crew.
                WorldResponse result = apiInstance.GetWorldCrewChat();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCrewChat: " + e.Message );
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

**WorldResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldcrewleaderboard"></a>
# **GetWorldCrewLeaderboard**
> GetGameLeaderboardResponse GetWorldCrewLeaderboard ()

The game leaderboards (Price Guess, hunts, speed trades; this week and all time) ranked among your crew only, each member by the name the crew sees. 404 when you are in no crew.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldCrewLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The game leaderboards (Price Guess, hunts, speed trades; this week and all time) ranked among your crew only, each member by the name the crew sees. 404 when you are in no crew.
                GetGameLeaderboardResponse result = apiInstance.GetWorldCrewLeaderboard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldCrewLeaderboard: " + e.Message );
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

**GetGameLeaderboardResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworlddm"></a>
# **GetWorldDm**
> GetWorldDmResponse GetWorldDm (string userId)

Your direct-message thread with one friend, oldest first (the last 100 lines: id, from, text, at, mine). Reading it marks their lines read.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldDmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Your direct-message thread with one friend, oldest first (the last 100 lines: id, from, text, at, mine). Reading it marks their lines read.
                GetWorldDmResponse result = apiInstance.GetWorldDm(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldDm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**GetWorldDmResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldemoteshowable"></a>
# **GetWorldEmoteShowable**
> GetWorldEmoteShowableResponse GetWorldEmoteShowable ()

The things you own that a show-off emote can hold up.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldEmoteShowableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The things you own that a show-off emote can hold up.
                GetWorldEmoteShowableResponse result = apiInstance.GetWorldEmoteShowable();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldEmoteShowable: " + e.Message );
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

**GetWorldEmoteShowableResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldfirefly"></a>
# **GetWorldFirefly**
> GetWorldFireflyResponse GetWorldFirefly ()

Fireflies on the Commons lawn: data.day (today, UTC), today (fireflies everyone has caught today) and mine (today - - your catches today, up to perDay - - total, all your catches; the Firefly Catcher pin comes at 30 - - and perDay). Fireflies are caught by walking up to a lit one in Crossly World after dark, never over the API, and nothing is spent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldFireflyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Fireflies on the Commons lawn: data.day (today, UTC), today (fireflies everyone has caught today) and mine (today - - your catches today, up to perDay - - total, all your catches; the Firefly Catcher pin comes at 30 - - and perDay). Fireflies are caught by walking up to a lit one in Crossly World after dark, never over the API, and nothing is spent.
                GetWorldFireflyResponse result = apiInstance.GetWorldFirefly();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldFirefly: " + e.Message );
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

**GetWorldFireflyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldfitstat"></a>
# **GetWorldFitStat**
> GetWorldFitStatResponse GetWorldFitStat ()

Your walking storefront, last 7 days: distinct people who tapped \"Shop this\" or \"Offer\" on what you wore, and how many of each. Counts only; nobody is identified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldFitStatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your walking storefront, last 7 days: distinct people who tapped \"Shop this\" or \"Offer\" on what you wore, and how many of each. Counts only; nobody is identified.
                GetWorldFitStatResponse result = apiInstance.GetWorldFitStat();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldFitStat: " + e.Message );
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

**GetWorldFitStatResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldfitvalue"></a>
# **GetWorldFitValue**
> GetWorldFitValueResponse GetWorldFitValue ()

What your outfit is worth on the market: cents (sum of each catalogued piece's order-book price - - last sale, else lowest ask), pieces worn, how many were priced, and share (whether you show it on your card).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldFitValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // What your outfit is worth on the market: cents (sum of each catalogued piece's order-book price - - last sale, else lowest ask), pieces worn, how many were priced, and share (whether you show it on your card).
                GetWorldFitValueResponse result = apiInstance.GetWorldFitValue();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldFitValue: " + e.Message );
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

**GetWorldFitValueResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldgame"></a>
# **GetWorldGame**
> GetWorldGameResponse GetWorldGame (string id)

One live game: its manifest, its store items and which you own.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One live game: its manifest, its store items and which you own.
                GetWorldGameResponse result = apiInstance.GetWorldGame(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldGame: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldGameResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldgameleaderboard"></a>
# **GetWorldGameLeaderboard**
> GetWorldGameLeaderboardResponse GetWorldGameLeaderboard (string id)

A live game leaderboard, this week and all time, by its manifest scoring (wins, best points, or best time). Only people who chose to be named show by name. scoring is null for a game that keeps no board.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldGameLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // A live game leaderboard, this week and all time, by its manifest scoring (wins, best points, or best time). Only people who chose to be named show by name. scoring is null for a game that keeps no board.
                GetWorldGameLeaderboardResponse result = apiInstance.GetWorldGameLeaderboard(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldGameLeaderboard: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldGameLeaderboardResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldgamepackage"></a>
# **GetWorldGamePackage**
> GetWorldGamePackageResponse GetWorldGamePackage (string id)

One of your game packages with every version, its review state and decision note.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldGamePackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One of your game packages with every version, its review state and decision note.
                GetWorldGamePackageResponse result = apiInstance.GetWorldGamePackage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldGamePackage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldGamePackageResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldgametemplate"></a>
# **GetWorldGameTemplate**
> GetWorldGameTemplateResponse GetWorldGameTemplate (string kind)

A fresh game package from a template (table, arena, object; collection is an NFT capability declaration), as { path, base64 } files: the world-kit init, for an agent with no local kit. ?id=my-game&name=My Game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldGameTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var kind = "kind_example";  // string | 

            try
            {
                // A fresh game package from a template (table, arena, object; collection is an NFT capability declaration), as { path, base64 } files: the world-kit init, for an agent with no local kit. ?id=my-game&name=My Game.
                GetWorldGameTemplateResponse result = apiInstance.GetWorldGameTemplate(kind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldGameTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **string**|  | 

### Return type

**GetWorldGameTemplateResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldhall"></a>
# **GetWorldHall**
> GetWorldHallResponse GetWorldHall ()

The Hall of Grails in Crossly World: data.exhibition (key, title, blurb, endsAt - - a new one every Monday UTC - - and next, the coming one's title) and data.exhibits, up to twelve real catalogue items in slot order (skuId, name, brand, imageUrl, thumbUrl, retailCents, lowestAskCents, lastSaleCents: the live order book, null when the market has none). The first stands on the centre plinth. Buy, bid or watch an exhibit through the market endpoints with its skuId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldHallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Hall of Grails in Crossly World: data.exhibition (key, title, blurb, endsAt - - a new one every Monday UTC - - and next, the coming one's title) and data.exhibits, up to twelve real catalogue items in slot order (skuId, name, brand, imageUrl, thumbUrl, retailCents, lowestAskCents, lastSaleCents: the live order book, null when the market has none). The first stands on the centre plinth. Buy, bid or watch an exhibit through the market endpoints with its skuId.
                GetWorldHallResponse result = apiInstance.GetWorldHall();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldHall: " + e.Message );
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

**GetWorldHallResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldhallloan"></a>
# **GetWorldHallLoan**
> GetWorldHallLoanResponse GetWorldHallLoan ()

Lend to the Hall: this week's exhibition (key, title, categorySlug, endsAt), your loans on show (id, vaultItemId, skuId, name, credit, since) and the vault pieces you can lend (eligible: vaultItemId, skuId, name, imageUrl, grade) - - held in your Crossly vault, not pledged, in the exhibition's category. perMember is how many you may lend each week.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldHallLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Lend to the Hall: this week's exhibition (key, title, categorySlug, endsAt), your loans on show (id, vaultItemId, skuId, name, credit, since) and the vault pieces you can lend (eligible: vaultItemId, skuId, name, imageUrl, grade) - - held in your Crossly vault, not pledged, in the exhibition's category. perMember is how many you may lend each week.
                GetWorldHallLoanResponse result = apiInstance.GetWorldHallLoan();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldHallLoan: " + e.Message );
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

**GetWorldHallLoanResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldhomeplaceable"></a>
# **GetWorldHomePlaceable**
> GetWorldHomePlaceableResponse GetWorldHomePlaceable ()

What you can place in your home: your items and your furniture.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldHomePlaceableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // What you can place in your home: your items and your furniture.
                GetWorldHomePlaceableResponse result = apiInstance.GetWorldHomePlaceable();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldHomePlaceable: " + e.Message );
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

**GetWorldHomePlaceableResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldhunt"></a>
# **GetWorldHunt**
> GetWorldHuntResponse GetWorldHunt ()

Your Great Hunt: data.season (id, name, startsAt, endsAt, the title and how many earn it, live), started (you read the first clue), held (keys held, 0-3, always in the order copper, jade, crystal), keys (each with its name, colour, its riddle once it is yours to read, and when you picked it up), and cleared (your rank through the Gate this season, when, and whether you earned the title) or null. Keys are picked up by walking to them in Crossly World; nothing here takes one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldHuntExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your Great Hunt: data.season (id, name, startsAt, endsAt, the title and how many earn it, live), started (you read the first clue), held (keys held, 0-3, always in the order copper, jade, crystal), keys (each with its name, colour, its riddle once it is yours to read, and when you picked it up), and cleared (your rank through the Gate this season, when, and whether you earned the title) or null. Keys are picked up by walking to them in Crossly World; nothing here takes one.
                GetWorldHuntResponse result = apiInstance.GetWorldHunt();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldHunt: " + e.Message );
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

**GetWorldHuntResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldhuntscoreboard"></a>
# **GetWorldHuntScoreboard**
> GetWorldHuntScoreboardResponse GetWorldHuntScoreboard ()

The Great Hunt Scoreboard, as the monolith in the Commons shows it: data.season (the running season, or the last one between seasons), finishers (the first ten through the Gate in order: rank, name, short, named, at, titled - - a name shows only for somebody who chose to be seen by name in the world, everyone else is \"A player\") and total (everybody through the Gate this season).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldHuntScoreboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Great Hunt Scoreboard, as the monolith in the Commons shows it: data.season (the running season, or the last one between seasons), finishers (the first ten through the Gate in order: rank, name, short, named, at, titled - - a name shows only for somebody who chose to be seen by name in the world, everyone else is \"A player\") and total (everybody through the Gate this season).
                GetWorldHuntScoreboardResponse result = apiInstance.GetWorldHuntScoreboard();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldHuntScoreboard: " + e.Message );
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

**GetWorldHuntScoreboardResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldinteractivedesign"></a>
# **GetWorldInteractiveDesign**
> GetWorldInteractiveDesignResponse GetWorldInteractiveDesign (string id)

One of your interactive designs: its draft source, the last static check, and every submitted version with its review state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldInteractiveDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // One of your interactive designs: its draft source, the last static check, and every submitted version with its review state.
                GetWorldInteractiveDesignResponse result = apiInstance.GetWorldInteractiveDesign(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldInteractiveDesign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldInteractiveDesignResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldjob"></a>
# **GetWorldJob**
> GetWorldJobResponse GetWorldJob ()

The jobs board: open staff shifts you could claim, your claimed shifts and open price checks (appraisals), as the world shows them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The jobs board: open staff shifts you could claim, your claimed shifts and open price checks (appraisals), as the world shows them.
                GetWorldJobResponse result = apiInstance.GetWorldJob();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldJob: " + e.Message );
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

**GetWorldJobResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldkite"></a>
# **GetWorldKite**
> GetWorldKiteResponse GetWorldKite ()

Kites flown on the Commons lawn: data.day (today, UTC), today (kites everyone has flown today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have flown one on; the Kite flyer pin comes at 5). Kites are flown by standing out on the lawn in Crossly World by day, never over the API, and nothing is spent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldKiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Kites flown on the Commons lawn: data.day (today, UTC), today (kites everyone has flown today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have flown one on; the Kite flyer pin comes at 5). Kites are flown by standing out on the lawn in Crossly World by day, never over the API, and nothing is spent.
                GetWorldKiteResponse result = apiInstance.GetWorldKite();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldKite: " + e.Message );
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

**GetWorldKiteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldlantern"></a>
# **GetWorldLantern**
> GetWorldKiteResponse GetWorldLantern ()

Sky lanterns in the Commons: data.day (today, UTC), today (lanterns everyone has released today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have released one on; the Lantern lighter pin comes at 5). Lanterns are released at the lantern stand in Crossly World, never over the API, and nothing is spent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldLanternExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Sky lanterns in the Commons: data.day (today, UTC), today (lanterns everyone has released today) and mine (today - - yours today, up to perDay - - perDay, and days - - the days you have released one on; the Lantern lighter pin comes at 5). Lanterns are released at the lantern stand in Crossly World, never over the API, and nothing is spent.
                GetWorldKiteResponse result = apiInstance.GetWorldLantern();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldLantern: " + e.Message );
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

**GetWorldKiteResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldpartychat"></a>
# **GetWorldPartyChat**
> WorldResponse GetWorldPartyChat (string id)

Your party chat: the recent lines. 404 when this is not your party.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPartyChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Your party chat: the recent lines. 404 when this is not your party.
                WorldResponse result = apiInstance.GetWorldPartyChat(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPartyChat: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**WorldResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplaceboard"></a>
# **GetWorldPlaceBoard**
> GetWorldPlaceBoardResponse GetWorldPlaceBoard (string slug)

The Trade Floor's wall of wants, its authentication desk and its Vault Markets ticker (vaultMovers: bookKey, name, label, units, markCents, change24hBps; only the trade-floor place has them).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceBoardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The Trade Floor's wall of wants, its authentication desk and its Vault Markets ticker (vaultMovers: bookKey, name, label, units, markCents, change24hBps; only the trade-floor place has them).
                GetWorldPlaceBoardResponse result = apiInstance.GetWorldPlaceBoard(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceBoard: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldPlaceBoardResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplacecollection"></a>
# **GetWorldPlaceCollection**
> GetWorldPlaceCollectionResponse GetWorldPlaceCollection (string slug, string category, string brand, string model)

One collection room: every piece of the set, owned or missing. 404 for an unknown room or set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var category = "category_example";  // string | 
            var brand = "brand_example";  // string | 
            var model = "model_example";  // string | 

            try
            {
                // One collection room: every piece of the set, owned or missing. 404 for an unknown room or set.
                GetWorldPlaceCollectionResponse result = apiInstance.GetWorldPlaceCollection(slug, category, brand, model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **category** | **string**|  | 
 **brand** | **string**|  | 
 **model** | **string**|  | 

### Return type

**GetWorldPlaceCollectionResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplacedrop"></a>
# **GetWorldPlaceDrop**
> GetWorldPlaceDropResponse GetWorldPlaceDrop (string slug)

The owner's next drop (name, cover, time, live) and how many people are waiting in the room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceDropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The owner's next drop (name, cover, time, live) and how many people are waiting in the room.
                GetWorldPlaceDropResponse result = apiInstance.GetWorldPlaceDrop(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceDrop: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldPlaceDropResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplaceiteminterest"></a>
# **GetWorldPlaceItemInterest**
> GetWorldPlaceItemInterestResponse GetWorldPlaceItemInterest (string slug, string itemId)

How many people looked at one item in this room today.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceItemInterestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 
            var itemId = "itemId_example";  // string | 

            try
            {
                // How many people looked at one item in this room today.
                GetWorldPlaceItemInterestResponse result = apiInstance.GetWorldPlaceItemInterest(slug, itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceItemInterest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **itemId** | **string**|  | 

### Return type

**GetWorldPlaceItemInterestResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplacelive"></a>
# **GetWorldPlaceLive**
> GetWorldPlaceLiveResponse GetWorldPlaceLive (string slug)

The owner's live sale: their stream and the lot on the block, or null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceLiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The owner's live sale: their stream and the lot on the block, or null.
                GetWorldPlaceLiveResponse result = apiInstance.GetWorldPlaceLive(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceLive: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldPlaceLiveResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplaceseller"></a>
# **GetWorldPlaceSeller**
> GetWorldPlaceSellerResponse GetWorldPlaceSeller (string slug)

The shop whose public room this is (username and name), or null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceSellerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The shop whose public room this is (username and name), or null.
                GetWorldPlaceSellerResponse result = apiInstance.GetWorldPlaceSeller(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceSeller: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldPlaceSellerResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldplaceshoppet"></a>
# **GetWorldPlaceShopPet**
> GetWorldPlaceShopPetResponse GetWorldPlaceShopPet (string slug)

The shop's pet kind, or null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldPlaceShopPetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The shop's pet kind, or null.
                GetWorldPlaceShopPetResponse result = apiInstance.GetWorldPlaceShopPet(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldPlaceShopPet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldPlaceShopPetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldspace"></a>
# **GetWorldSpace**
> GetWorldSpaceResponse GetWorldSpace (string slug)

One Space: its layout, host, events and your place in it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // One Space: its layout, host, events and your place in it.
                GetWorldSpaceResponse result = apiInstance.GetWorldSpace(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldSpace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldSpaceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldspacecanhost"></a>
# **GetWorldSpaceCanHost**
> GetWorldSpaceCanHostResponse GetWorldSpaceCanHost ()

Whether you may open a Space: sellers only, at most two active.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldSpaceCanHostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Whether you may open a Space: sellers only, at most two active.
                GetWorldSpaceCanHostResponse result = apiInstance.GetWorldSpaceCanHost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldSpaceCanHost: " + e.Message );
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

**GetWorldSpaceCanHostResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldtrialleaderboard"></a>
# **GetWorldTrialLeaderboard**
> GetWorldTrialLeaderboardResponse GetWorldTrialLeaderboard (string course)

A Time Trials course's boards, as the board beside it in the Commons shows them: data.course, week, weekly (this week's ten fastest: rank, name, short, named, ms, at) and allTime (the ten fastest ever, each person once). A name shows only for somebody who chose to be seen by name in the world; everyone else is \"A player\". 404 for an unknown course; course 1 is commons-loop.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldTrialLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var course = "course_example";  // string | 

            try
            {
                // A Time Trials course's boards, as the board beside it in the Commons shows them: data.course, week, weekly (this week's ten fastest: rank, name, short, named, ms, at) and allTime (the ten fastest ever, each person once). A name shows only for somebody who chose to be seen by name in the world; everyone else is \"A player\". 404 for an unknown course; course 1 is commons-loop.
                GetWorldTrialLeaderboardResponse result = apiInstance.GetWorldTrialLeaderboard(course);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldTrialLeaderboard: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **course** | **string**|  | 

### Return type

**GetWorldTrialLeaderboardResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldtrialmine"></a>
# **GetWorldTrialMine**
> GetWorldTrialMineResponse GetWorldTrialMine ()

Your Hoverboard Time Trials bests: data.week (its Monday, YYYY-MM-DD, UTC) and courses, each with course (id, name, parMs, rings, lengthM), week (your best lap this week in ms, your place on the weekly board, laps finished, and the split at each ring) or null, and allTime (your best ever in ms, your place on the all-time board, when) or null. Laps are timed by Crossly from where it saw you ride in the world; nothing here writes one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldTrialMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your Hoverboard Time Trials bests: data.week (its Monday, YYYY-MM-DD, UTC) and courses, each with course (id, name, parMs, rings, lengthM), week (your best lap this week in ms, your place on the weekly board, laps finished, and the split at each ring) or null, and allTime (your best ever in ms, your place on the all-time board, when) or null. Laps are timed by Crossly from where it saw you ride in the world; nothing here writes one.
                GetWorldTrialMineResponse result = apiInstance.GetWorldTrialMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldTrialMine: " + e.Message );
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

**GetWorldTrialMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldwallet"></a>
# **GetWorldWallet**
> GetWorldWalletResponse GetWorldWallet ()

Every balance you hold in Crossly World, read-only: bucksCents (Crossly Bucks, cents); cbx (available, decimals, and the three CBX balances kept apart as base-unit STRINGS - - granted (spend here only), earned (withdrawable once matured), connected (a delegation ceiling on your own wallet, not cash on hand) - - plus pendingCents of cashback not yet matured); cosm (available, decimals, baseUnits string). available:false means that currency is not provisioned on this deployment, not that you hold none.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Every balance you hold in Crossly World, read-only: bucksCents (Crossly Bucks, cents); cbx (available, decimals, and the three CBX balances kept apart as base-unit STRINGS - - granted (spend here only), earned (withdrawable once matured), connected (a delegation ceiling on your own wallet, not cash on hand) - - plus pendingCents of cashback not yet matured); cosm (available, decimals, baseUnits string). available:false means that currency is not provisioned on this deployment, not that you hold none.
                GetWorldWalletResponse result = apiInstance.GetWorldWallet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldWallet: " + e.Message );
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

**GetWorldWalletResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getworldwish"></a>
# **GetWorldWish**
> GetWorldWishResponse GetWorldWish ()

The Wishing Fountain in the Commons: data.day (today, UTC), today (wishes everyone has made today) and mine (madeToday, days - - how many days you have wished on, the Wishmaker pin comes at 7 - - and nextAt, when tomorrow's wish opens). One wish a day; a wish is made by tossing a coin at the fountain in Crossly World, never over the API, and nothing is spent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetWorldWishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Wishing Fountain in the Commons: data.day (today, UTC), today (wishes everyone has made today) and mine (madeToday, days - - how many days you have wished on, the Wishmaker pin comes at 7 - - and nextAt, when tomorrow's wish opens). One wish a day; a wish is made by tossing a coin at the fountain in Crossly World, never over the API, and nothing is spent.
                GetWorldWishResponse result = apiInstance.GetWorldWish();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorldWish: " + e.Message );
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

**GetWorldWishResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listspatialscenegrants"></a>
# **ListSpatialSceneGrants**
> ListSpatialSceneGrantsResponse ListSpatialSceneGrants (string id)

Everyone who can currently walk into one of your rooms, and unused invites. Never returns codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialSceneGrantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Everyone who can currently walk into one of your rooms, and unused invites. Never returns codes.
                ListSpatialSceneGrantsResponse result = apiInstance.ListSpatialSceneGrants(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListSpatialSceneGrants: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListSpatialSceneGrantsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listspatialscenewarehouseunplaced"></a>
# **ListSpatialSceneWarehouseUnplaced**
> ListSpatialSceneWarehouseUnplacedResponse ListSpatialSceneWarehouseUnplaced (string id)

Stock not yet on a shelf in a warehouse room you can arrange (q filters by title).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialSceneWarehouseUnplacedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Stock not yet on a shelf in a warehouse room you can arrange (q filters by title).
                ListSpatialSceneWarehouseUnplacedResponse result = apiInstance.ListSpatialSceneWarehouseUnplaced(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListSpatialSceneWarehouseUnplaced: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListSpatialSceneWarehouseUnplacedResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listspatialsharedwithme"></a>
# **ListSpatialSharedWithMe**
> ListSpatialSharedWithMeResponse ListSpatialSharedWithMe ()

Rooms other people let you into.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialSharedWithMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Rooms other people let you into.
                ListSpatialSharedWithMeResponse result = apiInstance.ListSpatialSharedWithMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListSpatialSharedWithMe: " + e.Message );
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

**ListSpatialSharedWithMeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listspatialstreetleases"></a>
# **ListSpatialStreetLeases**
> ListSpatialStreetLeasesResponse ListSpatialStreetLeases (string slug)

Plots on a street offered for lease: weekly rent in CENTS and terms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListSpatialStreetLeasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Plots on a street offered for lease: weekly rent in CENTS and terms.
                ListSpatialStreetLeasesResponse result = apiInstance.ListSpatialStreetLeases(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListSpatialStreetLeases: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListSpatialStreetLeasesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldavatarcloset"></a>
# **ListWorldAvatarCloset**
> ListWorldAvatarClosetResponse ListWorldAvatarCloset (int? limit = null, int? offset = null)

Everything you can verifiably wear (your Crossly purchase receipts), newest first: receiptId, item title, brand, size, image, catalog sku/variant, quantity, purchasedAt. Pass a receiptId to POST /v1/world/avatar/equip to put one on. limit 1-200, offset for paging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldAvatarClosetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // Everything you can verifiably wear (your Crossly purchase receipts), newest first: receiptId, item title, brand, size, image, catalog sku/variant, quantity, purchasedAt. Pass a receiptId to POST /v1/world/avatar/equip to put one on. limit 1-200, offset for paging.
                ListWorldAvatarClosetResponse result = apiInstance.ListWorldAvatarCloset(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldAvatarCloset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

**ListWorldAvatarClosetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldavatarstock"></a>
# **ListWorldAvatarStock**
> ListWorldAvatarStockResponse ListWorldAvatarStock ()

Items of your OWN inventory you could wear into a room as a walking storefront: inventoryItemId, title, image and the slot it would go on. Pass an inventoryItemId to POST /v1/world/avatar/equip.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldAvatarStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Items of your OWN inventory you could wear into a room as a walking storefront: inventoryItemId, title, image and the slot it would go on. Pass an inventoryItemId to POST /v1/world/avatar/equip.
                ListWorldAvatarStockResponse result = apiInstance.ListWorldAvatarStock();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldAvatarStock: " + e.Message );
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

**ListWorldAvatarStockResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldavatarwearables"></a>
# **ListWorldAvatarWearables**
> ListWorldAvatarWearablesResponse ListWorldAvatarWearables ()

Wearables you have authored as a designer: id, sku, name, slot, priceBaseUnits (COSM base units, a string), maxSupply, mintedCount, active (false until reviewed). meta.available is false when COSM is not provisioned here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldAvatarWearablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Wearables you have authored as a designer: id, sku, name, slot, priceBaseUnits (COSM base units, a string), maxSupply, mintedCount, active (false until reviewed). meta.available is false when COSM is not provisioned here.
                ListWorldAvatarWearablesResponse result = apiInstance.ListWorldAvatarWearables();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldAvatarWearables: " + e.Message );
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

**ListWorldAvatarWearablesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldbestdressed"></a>
# **ListWorldBestDressed**
> ListWorldBestDressedResponse ListWorldBestDressed ()

This week's best-dressed board (Monday-based), top ten: name, profile username and loves. Only people still choosing to be seen by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldBestDressedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // This week's best-dressed board (Monday-based), top ten: name, profile username and loves. Only people still choosing to be seen by name.
                ListWorldBestDressedResponse result = apiInstance.ListWorldBestDressed();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldBestDressed: " + e.Message );
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

**ListWorldBestDressedResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldcapabilitydeclarations"></a>
# **ListWorldCapabilityDeclarations**
> ListWorldCapabilityDeclarationsResponse ListWorldCapabilityDeclarations ()

Your capability declarations, in every review state (pending, live, rejected with the note from the reviewer).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldCapabilityDeclarationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your capability declarations, in every review state (pending, live, rejected with the note from the reviewer).
                ListWorldCapabilityDeclarationsResponse result = apiInstance.ListWorldCapabilityDeclarations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldCapabilityDeclarations: " + e.Message );
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

**ListWorldCapabilityDeclarationsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldconteststandings"></a>
# **ListWorldContestStandings**
> ListWorldContestStandingsResponse ListWorldContestStandings (string id)

The standings of a contest now: best score first (or lowest, for a time game), ties to whoever got there first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldContestStandingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The standings of a contest now: best score first (or lowest, for a time game), ties to whoever got there first.
                ListWorldContestStandingsResponse result = apiInstance.ListWorldContestStandings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldContestStandings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldContestStandingsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldcontests"></a>
# **ListWorldContests**
> ListWorldContestsResponse ListWorldContests ()

Open skill contests on Crossly World games, soonest ending first: entry mode (free, sponsored, paid) and prizes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldContestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Open skill contests on Crossly World games, soonest ending first: entry mode (free, sponsored, paid) and prizes.
                ListWorldContestsResponse result = apiInstance.ListWorldContests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldContests: " + e.Message );
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

**ListWorldContestsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldconventionexhibitors"></a>
# **ListWorldConventionExhibitors**
> ListWorldConventionExhibitorsResponse ListWorldConventionExhibitors (string id)

The host roster: who applied, who was invited, who is coming (by shop handle). Host only; 404 otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldConventionExhibitorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // The host roster: who applied, who was invited, who is coming (by shop handle). Host only; 404 otherwise.
                ListWorldConventionExhibitorsResponse result = apiInstance.ListWorldConventionExhibitors(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldConventionExhibitors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldConventionExhibitorsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldconventionmine"></a>
# **ListWorldConventionMine**
> ListWorldConventionMineResponse ListWorldConventionMine ()

Conventions you host and conventions you are exhibiting at.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldConventionMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Conventions you host and conventions you are exhibiting at.
                ListWorldConventionMineResponse result = apiInstance.ListWorldConventionMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldConventionMine: " + e.Message );
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

**ListWorldConventionMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldconventions"></a>
# **ListWorldConventions**
> ListWorldConventionsResponse ListWorldConventions ()

Conventions open to sellers now or soon: title, room, dates, and how to get a table (invite, free, fee or revenue share).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldConventionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Conventions open to sellers now or soon: title, room, dates, and how to get a table (invite, free, fee or revenue share).
                ListWorldConventionsResponse result = apiInstance.ListWorldConventions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldConventions: " + e.Message );
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

**ListWorldConventionsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldcosmcosmetics"></a>
# **ListWorldCosmCosmetics**
> ListCosmCosmeticsResponse ListWorldCosmCosmetics (string tier = null, string slot = null)

The active cosmetics catalogue, optionally by tier (premium | earned | stake_exclusive) or slot: sku, name, slot, tier, priceCents (premium only), priceBaseUnits (earned only, COSM base units string), supply, fusable, preview and what it unlocks. Read-only: cosmetics are bought on crossly.net. meta.available / meta.decimals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldCosmCosmeticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var tier = "premium";  // string |  (optional) 
            var slot = "slot_example";  // string |  (optional) 

            try
            {
                // The active cosmetics catalogue, optionally by tier (premium | earned | stake_exclusive) or slot: sku, name, slot, tier, priceCents (premium only), priceBaseUnits (earned only, COSM base units string), supply, fusable, preview and what it unlocks. Read-only: cosmetics are bought on crossly.net. meta.available / meta.decimals.
                ListCosmCosmeticsResponse result = apiInstance.ListWorldCosmCosmetics(tier, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldCosmCosmetics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tier** | **string**|  | [optional] 
 **slot** | **string**|  | [optional] 

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

<a name="listworldcosmdesigns"></a>
# **ListWorldCosmDesigns**
> ListWorldCosmDesignsResponse ListWorldCosmDesigns ()

Your COSM designs in the world: popularity toward the free chain unlock a popular limited design earns, whether it is on chain, and your opt-out. Declare what a design does with chain cosm and the design id as the contract.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldCosmDesignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your COSM designs in the world: popularity toward the free chain unlock a popular limited design earns, whether it is on chain, and your opt-out. Declare what a design does with chain cosm and the design id as the contract.
                ListWorldCosmDesignsResponse result = apiInstance.ListWorldCosmDesigns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldCosmDesigns: " + e.Message );
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

**ListWorldCosmDesignsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldcosminventory"></a>
# **ListWorldCosmInventory**
> ListWorldCosmInventoryResponse ListWorldCosmInventory ()

Cosmetics you hold, newest first: ownershipId, cosmeticId, sku, name, slot, tier, how it was acquired, bound, edition number, acquiredAt and what it unlocks. Pass a cosmeticId to POST /v1/world/avatar/equip to wear one. meta.available.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldCosmInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Cosmetics you hold, newest first: ownershipId, cosmeticId, sku, name, slot, tier, how it was acquired, bound, edition number, acquiredAt and what it unlocks. Pass a cosmeticId to POST /v1/world/avatar/equip to wear one. meta.available.
                ListWorldCosmInventoryResponse result = apiInstance.ListWorldCosmInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldCosmInventory: " + e.Message );
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

**ListWorldCosmInventoryResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecorcatalogue"></a>
# **ListWorldDecorCatalogue**
> ListWorldDecorCatalogueResponse ListWorldDecorCatalogue (string surface = null)

The Decor Shop: every active cosmetic grouped by surface (avatar | home | shop | stall | street) and slot - - name, tier, priceCents (premium: the dollar price, paid in CBX at spot) or priceBaseUnits (earned: COSM, base-unit string), edition supply and remaining, tint swatch, preview, what it unlocks, owned + your edition number, and buyWith. Read-only: buying and minting happen on crossly.net/shop/decor. meta.available, meta.mint {open, reason}, meta.cbx {open, reason} (CBX opens at mint), meta.balances (your COSM and CBX, base-unit strings), meta.surfaces. Never sold by card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorCatalogueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var surface = "avatar";  // string |  (optional) 

            try
            {
                // The Decor Shop: every active cosmetic grouped by surface (avatar | home | shop | stall | street) and slot - - name, tier, priceCents (premium: the dollar price, paid in CBX at spot) or priceBaseUnits (earned: COSM, base-unit string), edition supply and remaining, tint swatch, preview, what it unlocks, owned + your edition number, and buyWith. Read-only: buying and minting happen on crossly.net/shop/decor. meta.available, meta.mint {open, reason}, meta.cbx {open, reason} (CBX opens at mint), meta.balances (your COSM and CBX, base-unit strings), meta.surfaces. Never sold by card.
                ListWorldDecorCatalogueResponse result = apiInstance.ListWorldDecorCatalogue(surface);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorCatalogue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **surface** | **string**|  | [optional] 

### Return type

**ListWorldDecorCatalogueResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecordesigns"></a>
# **ListWorldDecorDesigns**
> ListWorldDecorDesignsResponse ListWorldDecorDesigns ()

Your decor designs and their review state. available is false until COSM is provisioned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorDesignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your decor designs and their review state. available is false until COSM is provisioned.
                ListWorldDecorDesignsResponse result = apiInstance.ListWorldDecorDesigns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorDesigns: " + e.Message );
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

**ListWorldDecorDesignsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecorinventory"></a>
# **ListWorldDecorInventory**
> ListWorldDecorInventoryResponse ListWorldDecorInventory ()

Your decor as an INVENTORY. Decor is a quantity: every copy is one unit - - a placed prop (home_prop, prop) uses one per placement, a finish (wallpaper, floor, theme, shopfront, facade, sign style, street lamp/banner/paving/arch, booth canopy/pattern/lights/counter) one per space it dresses; free values are unlimited. Per item: key, value, pair (key:value), name, sku, surface, placeable, tint, owned, placed, available, placements [{ space { kind: home | shop | stall | street, id, name }, count }], copies [{ ownershipId, editionNumber }]. meta.available, meta.spaces (every space you dress). Read-only: placing and retracting happen in the app or on crossly.net.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your decor as an INVENTORY. Decor is a quantity: every copy is one unit - - a placed prop (home_prop, prop) uses one per placement, a finish (wallpaper, floor, theme, shopfront, facade, sign style, street lamp/banner/paving/arch, booth canopy/pattern/lights/counter) one per space it dresses; free values are unlimited. Per item: key, value, pair (key:value), name, sku, surface, placeable, tint, owned, placed, available, placements [{ space { kind: home | shop | stall | street, id, name }, count }], copies [{ ownershipId, editionNumber }]. meta.available, meta.spaces (every space you dress). Read-only: placing and retracting happen in the app or on crossly.net.
                ListWorldDecorInventoryResponse result = apiInstance.ListWorldDecorInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorInventory: " + e.Message );
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

**ListWorldDecorInventoryResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecormarket"></a>
# **ListWorldDecorMarket**
> ListWorldDecorMarketResponse ListWorldDecorMarket ()

Decor copies other people are reselling (asks in COSM); optional pair filter. Read only: listing and buying stay on crossly.net.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Decor copies other people are reselling (asks in COSM); optional pair filter. Read only: listing and buying stay on crossly.net.
                ListWorldDecorMarketResponse result = apiInstance.ListWorldDecorMarket();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorMarket: " + e.Message );
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

**ListWorldDecorMarketResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecormine"></a>
# **ListWorldDecorMine**
> ListWorldDecorMineResponse ListWorldDecorMine ()

Decor you hold AND decor you have minted to your wallet, newest first: ownershipId, cosmeticId, sku, name, surface, slot, tier, acquiredVia, bound, editionNumber of maxSupply, mintState (held | minting | minted), mintAddress, mintable, and what it unlocks. meta.available, meta.mint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Decor you hold AND decor you have minted to your wallet, newest first: ownershipId, cosmeticId, sku, name, surface, slot, tier, acquiredVia, bound, editionNumber of maxSupply, mintState (held | minting | minted), mintAddress, mintable, and what it unlocks. meta.available, meta.mint.
                ListWorldDecorMineResponse result = apiInstance.ListWorldDecorMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorMine: " + e.Message );
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

**ListWorldDecorMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecorstalls"></a>
# **ListWorldDecorStalls**
> ListStallMineResponse ListWorldDecorStalls ()

Your stall bookings, to dress their booths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorStallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your stall bookings, to dress their booths.
                ListStallMineResponse result = apiInstance.ListWorldDecorStalls();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorStalls: " + e.Message );
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

**ListStallMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddecorstreets"></a>
# **ListWorldDecorStreets**
> ListWorldDecorStreetsResponse ListWorldDecorStreets ()

Streets you may dress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDecorStreetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Streets you may dress.
                ListWorldDecorStreetsResponse result = apiInstance.ListWorldDecorStreets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDecorStreets: " + e.Message );
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

**ListWorldDecorStreetsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworlddms"></a>
# **ListWorldDms**
> ListWorldDmsResponse ListWorldDms ()

Your friends (mutual follows) for direct messages: each with userId, name, the last line between you (text, at, mine) or null, and how many of theirs you have not read; most recent first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldDmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your friends (mutual follows) for direct messages: each with userId, name, the last line between you (text, at, mine) or null, and how many of theirs you have not read; most recent first.
                ListWorldDmsResponse result = apiInstance.ListWorldDms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldDms: " + e.Message );
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

**ListWorldDmsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldfollowingrooms"></a>
# **ListWorldFollowingRooms**
> ListWorldFollowingRoomsResponse ListWorldFollowingRooms ()

The public rooms of people you follow, to walk into.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldFollowingRoomsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The public rooms of people you follow, to walk into.
                ListWorldFollowingRoomsResponse result = apiInstance.ListWorldFollowingRooms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldFollowingRooms: " + e.Message );
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

**ListWorldFollowingRoomsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldfollows"></a>
# **ListWorldFollows**
> ListWorldFollowsResponse ListWorldFollows ()

Everybody you follow in Crossly World, newest first, each with mutual: true when they follow you back (a friend).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldFollowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Everybody you follow in Crossly World, newest first, each with mutual: true when they follow you back (a friend).
                ListWorldFollowsResponse result = apiInstance.ListWorldFollows();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldFollows: " + e.Message );
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

**ListWorldFollowsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldfriendhere"></a>
# **ListWorldFriendHere**
> ListWorldFriendsResponse ListWorldFriendHere ()

Your friends in Crossly World right now, and where (when they share it).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldFriendHereExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your friends in Crossly World right now, and where (when they share it).
                ListWorldFriendsResponse result = apiInstance.ListWorldFriendHere();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldFriendHere: " + e.Message );
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

**ListWorldFriendsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldfriends"></a>
# **ListWorldFriends**
> ListWorldFriendsResponse ListWorldFriends ()

Your friends (mutual follows), each with the PUBLIC room they are in right now when they chose to be seen by name there (else null), and their home address slug when they let friends visit. Invisible and anonymous friends are never located.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldFriendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your friends (mutual follows), each with the PUBLIC room they are in right now when they chose to be seen by name there (else null), and their home address slug when they let friends visit. Invisible and anonymous friends are never located.
                ListWorldFriendsResponse result = apiInstance.ListWorldFriends();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldFriends: " + e.Message );
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

**ListWorldFriendsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldgamepackages"></a>
# **ListWorldGamePackages**
> ListWorldGamePackagesResponse ListWorldGamePackages ()

Your game packages, each with its latest version and review state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldGamePackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your game packages, each with its latest version and review state.
                ListWorldGamePackagesResponse result = apiInstance.ListWorldGamePackages();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldGamePackages: " + e.Message );
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

**ListWorldGamePackagesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldgamerewards"></a>
# **ListWorldGameRewards**
> ListWorldGameRewardsResponse ListWorldGameRewards ()

Rewards you won in games: granted, or recorded as unfunded for COSM and CBX (a game prints no value).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldGameRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Rewards you won in games: granted, or recorded as unfunded for COSM and CBX (a game prints no value).
                ListWorldGameRewardsResponse result = apiInstance.ListWorldGameRewards();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldGameRewards: " + e.Message );
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

**ListWorldGameRewardsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldgames"></a>
# **ListWorldGames**
> ListWorldGamesResponse ListWorldGames ()

The Game Directory: every live, reviewed game package with its players, places, rewards, contests and the piece people place.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldGamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Game Directory: every live, reviewed game package with its players, places, rewards, contests and the piece people place.
                ListWorldGamesResponse result = apiInstance.ListWorldGames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldGames: " + e.Message );
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

**ListWorldGamesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldhomebuilding"></a>
# **ListWorldHomeBuilding**
> ListWorldHomeBuildingResponse ListWorldHomeBuilding ()

Homes whose owner made you a co-builder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldHomeBuildingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Homes whose owner made you a co-builder.
                ListWorldHomeBuildingResponse result = apiInstance.ListWorldHomeBuilding();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldHomeBuilding: " + e.Message );
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

**ListWorldHomeBuildingResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldinteractivecatalogue"></a>
# **ListWorldInteractiveCatalogue**
> ListWorldInteractiveCatalogueResponse ListWorldInteractiveCatalogue ()

Interactive objects: every piece that runs a shared script in a room (first-party and approved creator designs). Per item: model (the piece key a home layout or boutique prop stores), decorValue (the home_prop value its SKU claims), source (first_party | creator), name, blurb, size [x, z] metres, fallbackMesh, cosmeticId (the SKU on the Decor Shop, null when not on sale) and version (a creator design: the approved version every copy runs). Read-only: buying is on crossly.net/shop/decor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldInteractiveCatalogueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Interactive objects: every piece that runs a shared script in a room (first-party and approved creator designs). Per item: model (the piece key a home layout or boutique prop stores), decorValue (the home_prop value its SKU claims), source (first_party | creator), name, blurb, size [x, z] metres, fallbackMesh, cosmeticId (the SKU on the Decor Shop, null when not on sale) and version (a creator design: the approved version every copy runs). Read-only: buying is on crossly.net/shop/decor.
                ListWorldInteractiveCatalogueResponse result = apiInstance.ListWorldInteractiveCatalogue();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldInteractiveCatalogue: " + e.Message );
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

**ListWorldInteractiveCatalogueResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldinteractivedesigns"></a>
# **ListWorldInteractiveDesigns**
> ListWorldInteractiveDesignsResponse ListWorldInteractiveDesigns (string archived = null)

Your interactive-object designs (MML documents you wrote), newest first: id, handle, name, footprint (s | m | l | f), tint, priceBaseUnits (COSM, base-unit string), maxSupply, model, decorValue, cosmeticId, liveVersion (the approved version every copy runs; null = none), withdrawnReason, archivedAt (you archived it: off sale, owned copies keep running; null = not archived), latestVersion { version, state: pending | approved | rejected | withdrawn | cancelled, decisionNote }, inReview. `archived`: exclude (default), include or only archived designs. Read-only: writing, previewing, submitting and archiving happen on crossly.net/shop/decor?tab=interactive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldInteractiveDesignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var archived = "exclude";  // string |  (optional) 

            try
            {
                // Your interactive-object designs (MML documents you wrote), newest first: id, handle, name, footprint (s | m | l | f), tint, priceBaseUnits (COSM, base-unit string), maxSupply, model, decorValue, cosmeticId, liveVersion (the approved version every copy runs; null = none), withdrawnReason, archivedAt (you archived it: off sale, owned copies keep running; null = not archived), latestVersion { version, state: pending | approved | rejected | withdrawn | cancelled, decisionNote }, inReview. `archived`: exclude (default), include or only archived designs. Read-only: writing, previewing, submitting and archiving happen on crossly.net/shop/decor?tab=interactive.
                ListWorldInteractiveDesignsResponse result = apiInstance.ListWorldInteractiveDesigns(archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldInteractiveDesigns: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **archived** | **string**|  | [optional] 

### Return type

**ListWorldInteractiveDesignsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldjobposted"></a>
# **ListWorldJobPosted**
> ListJobShiftsResponse ListWorldJobPosted ()

Shifts you posted for your rooms, with who claimed each and how it went.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldJobPostedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Shifts you posted for your rooms, with who claimed each and how it went.
                ListJobShiftsResponse result = apiInstance.ListWorldJobPosted();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldJobPosted: " + e.Message );
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

**ListJobShiftsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldoutfits"></a>
# **ListWorldOutfits**
> ListWorldOutfitsResponse ListWorldOutfits ()

Your saved outfits (up to 6, oldest first): id, name, appearance (skin, hair, hairColour, eyes, build) and items - - each worn thing as the door it goes back on by (slot, door: cosmetic | receipt | stock, id, label). Put one on with POST /v1/world/outfits/:id/apply.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldOutfitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your saved outfits (up to 6, oldest first): id, name, appearance (skin, hair, hairColour, eyes, build) and items - - each worn thing as the door it goes back on by (slot, door: cosmetic | receipt | stock, id, label). Put one on with POST /v1/world/outfits/:id/apply.
                ListWorldOutfitsResponse result = apiInstance.ListWorldOutfits();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldOutfits: " + e.Message );
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

**ListWorldOutfitsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplacebans"></a>
# **ListWorldPlaceBans**
> ListWorldPlaceBansResponse ListWorldPlaceBans (string slug)

Who is banned from a place you own (your boutique or home).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceBansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Who is banned from a place you own (your boutique or home).
                ListWorldPlaceBansResponse result = apiInstance.ListWorldPlaceBans(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceBans: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceBansResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplacebundles"></a>
# **ListWorldPlaceBundles**
> ListWorldPlaceBundlesResponse ListWorldPlaceBundles (string slug)

The owner's bundle deals mapped onto this room's items (itemIds null = any N from the shop). The discount is decided at checkout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceBundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The owner's bundle deals mapped onto this room's items (itemIds null = any N from the shop). The discount is decided at checkout.
                ListWorldPlaceBundlesResponse result = apiInstance.ListWorldPlaceBundles(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceBundles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceBundlesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplacecollections"></a>
# **ListWorldPlaceCollections**
> ListWorldPlaceCollectionsResponse ListWorldPlaceCollections (string slug)

The owner's collection rooms: one per category, brand and model they collect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The owner's collection rooms: one per category, brand and model they collect.
                ListWorldPlaceCollectionsResponse result = apiInstance.ListWorldPlaceCollections(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceCollections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceCollectionsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplaceoffers"></a>
# **ListWorldPlaceOffers**
> ListWorldPlaceOffersResponse ListWorldPlaceOffers (string slug)

What is for sale in a public room: price, condition and stock, with market references. 404 when no such room is shared.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // What is for sale in a public room: price, condition and stock, with market references. 404 when no such room is shared.
                ListWorldPlaceOffersResponse result = apiInstance.ListWorldPlaceOffers(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceOffers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceOffersResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplaceradar"></a>
# **ListWorldPlaceRadar**
> ListWorldPlaceRadarResponse ListWorldPlaceRadar (string slug)

What you have that someone here wants, and what is here that you want: matched on catalog ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceRadarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // What you have that someone here wants, and what is here that you want: matched on catalog ids.
                ListWorldPlaceRadarResponse result = apiInstance.ListWorldPlaceRadar(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceRadar: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceRadarResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplacetradetables"></a>
# **ListWorldPlaceTradeTables**
> ListWorldPlaceTradeTablesResponse ListWorldPlaceTradeTables (string slug)

The open trade tables in a place: who is sitting and what is laid on the mat.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceTradeTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // The open trade tables in a place: who is sitting and what is laid on the mat.
                ListWorldPlaceTradeTablesResponse result = apiInstance.ListWorldPlaceTradeTables(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceTradeTables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceTradeTablesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldplacetrades"></a>
# **ListWorldPlaceTrades**
> ListWorldPlaceTradesResponse ListWorldPlaceTrades (string slug)

Items in this room open to trades, each with its trade post path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldPlaceTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Items in this room open to trades, each with its trade post path.
                ListWorldPlaceTradesResponse result = apiInstance.ListWorldPlaceTrades(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldPlaceTrades: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldPlaceTradesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldprovenance"></a>
# **ListWorldProvenance**
> ListWorldProvenanceResponse ListWorldProvenance ()

Provenance trails: where in Crossly World your purchases were found, newest first (optionally ?listingIds=a,b - - platform listing ids). data: [{ platformListingId, slug (the listing public slug), kind (room | window | stall | space | drop | auction | worn | agent), place (its name, or null when gone), at, line - - e.g. \"Found at The Sneaker Vault, Oct 2026\" }]. Yours only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldProvenanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Provenance trails: where in Crossly World your purchases were found, newest first (optionally ?listingIds=a,b - - platform listing ids). data: [{ platformListingId, slug (the listing public slug), kind (room | window | stall | space | drop | auction | worn | agent), place (its name, or null when gone), at, line - - e.g. \"Found at The Sneaker Vault, Oct 2026\" }]. Yours only.
                ListWorldProvenanceResponse result = apiInstance.ListWorldProvenance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldProvenance: " + e.Message );
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

**ListWorldProvenanceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldquests"></a>
# **ListWorldQuests**
> ListWorldQuestsResponse ListWorldQuests ()

Every world quest with your progress: key, the pin it earns, goal, target, count, done, colour. meta.wearing is the pin on your nameplate (or null); meta.streak your current and best daily visit streak. Progress only comes from what the server saw - - there is no write of it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldQuestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Every world quest with your progress: key, the pin it earns, goal, target, count, done, colour. meta.wearing is the pin on your nameplate (or null); meta.streak your current and best daily visit streak. Progress only comes from what the server saw - - there is no write of it.
                ListWorldQuestsResponse result = apiInstance.ListWorldQuests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldQuests: " + e.Message );
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

**ListWorldQuestsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldspacemine"></a>
# **ListWorldSpaceMine**
> ListWorldSpacesResponse ListWorldSpaceMine ()

Spaces you belong to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldSpaceMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Spaces you belong to.
                ListWorldSpacesResponse result = apiInstance.ListWorldSpaceMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldSpaceMine: " + e.Message );
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

**ListWorldSpacesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldspacerequests"></a>
# **ListWorldSpaceRequests**
> ListWorldSpaceRequestsResponse ListWorldSpaceRequests (string slug)

As host or co-host, who asked to join.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldSpaceRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // As host or co-host, who asked to join.
                ListWorldSpaceRequestsResponse result = apiInstance.ListWorldSpaceRequests(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldSpaceRequests: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListWorldSpaceRequestsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldspacewhatson"></a>
# **ListWorldSpaceWhatsOn**
> ListWorldSpaceWhatsOnResponse ListWorldSpaceWhatsOn ()

Live and upcoming events across Spaces (streets=1 and stage=1 add street and Main Stage events).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldSpaceWhatsOnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Live and upcoming events across Spaces (streets=1 and stage=1 add street and Main Stage events).
                ListWorldSpaceWhatsOnResponse result = apiInstance.ListWorldSpaceWhatsOn();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldSpaceWhatsOn: " + e.Message );
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

**ListWorldSpaceWhatsOnResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldspaces"></a>
# **ListWorldSpaces**
> ListWorldSpacesResponse ListWorldSpaces ()

The Spaces directory: seller-hosted clubs with a venue, members and events (optional venue filter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldSpacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The Spaces directory: seller-hosted clubs with a venue, members and events (optional venue filter).
                ListWorldSpacesResponse result = apiInstance.ListWorldSpaces();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldSpaces: " + e.Message );
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

**ListWorldSpacesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldstreaks"></a>
# **ListWorldStreaks**
> ListWorldStreaksResponse ListWorldStreaks ()

The longest current daily visit streaks (2+ days), top ten: name and days. Only people still choosing to be seen by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldStreaksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // The longest current daily visit streaks (2+ days), top ten: name and days. Only people still choosing to be seen by name.
                ListWorldStreaksResponse result = apiInstance.ListWorldStreaks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldStreaks: " + e.Message );
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

**ListWorldStreaksResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldtrademine"></a>
# **ListWorldTradeMine**
> ListWorldTradeMineResponse ListWorldTradeMine ()

Your trades and each item progress through the authentication gate (verified or failed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldTradeMineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your trades and each item progress through the authentication gate (verified or failed).
                ListWorldTradeMineResponse result = apiInstance.ListWorldTradeMine();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldTradeMine: " + e.Message );
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

**ListWorldTradeMineResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldtradetablebinder"></a>
# **ListWorldTradeTableBinder**
> ListWorldTradeTableBinderResponse ListWorldTradeTableBinder ()

Your binder: unsold collection rows that are catalog items and may be laid on a trade mat - - key, variantId, condition, grade, portfolioId, name, image and valueCents (market value, cents).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldTradeTableBinderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your binder: unsold collection rows that are catalog items and may be laid on a trade mat - - key, variantId, condition, grade, portfolioId, name, image and valueCents (market value, cents).
                ListWorldTradeTableBinderResponse result = apiInstance.ListWorldTradeTableBinder();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldTradeTableBinder: " + e.Message );
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

**ListWorldTradeTableBinderResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listworldtradetablelistings"></a>
# **ListWorldTradeTableListings**
> ListWorldTradeTableListingsResponse ListWorldTradeTableListings ()

Your open Trade Block trade listings a trade table can be opened on in the world, each with its items' names.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListWorldTradeTableListingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your open Trade Block trade listings a trade table can be opened on in the world, each with its items' names.
                ListWorldTradeTableListingsResponse result = apiInstance.ListWorldTradeTableListings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.ListWorldTradeTableListings: " + e.Message );
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

**ListWorldTradeTableListingsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialscenecosmetic"></a>
# **UpdateSpatialSceneCosmetic**
> UpdateSpatialSceneCosmeticResponse UpdateSpatialSceneCosmetic (string id)

Redecorate one of your rooms (wall, floor, lighting, trim...). Unknown keys are dropped; the response is what survived. `clear` lists keys to reset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialSceneCosmeticExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Redecorate one of your rooms (wall, floor, lighting, trim...). Unknown keys are dropped; the response is what survived. `clear` lists keys to reset.
                UpdateSpatialSceneCosmeticResponse result = apiInstance.UpdateSpatialSceneCosmetic(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialSceneCosmetic: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateSpatialSceneCosmeticResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialscenenode"></a>
# **UpdateSpatialSceneNode**
> UpdateSpatialSceneNodeResponse UpdateSpatialSceneNode (string id, string nodeId)

Move a rack in one of your warehouse rooms (position in metres).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialSceneNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 
            var nodeId = "nodeId_example";  // string | 

            try
            {
                // Move a rack in one of your warehouse rooms (position in metres).
                UpdateSpatialSceneNodeResponse result = apiInstance.UpdateSpatialSceneNode(id, nodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialSceneNode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **nodeId** | **string**|  | 

### Return type

**UpdateSpatialSceneNodeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialscenesetting"></a>
# **UpdateSpatialSceneSetting**
> SpatialSceneResponse2 UpdateSpatialSceneSetting (string id)

How one of your rooms is laid out and lit: grouping and sort keys, theme, overlay and the arrival camera. Cosmetics and the shop layout have their own writers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialSceneSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // How one of your rooms is laid out and lit: grouping and sort keys, theme, overlay and the arrival camera. Cosmetics and the shop layout have their own writers.
                SpatialSceneResponse2 result = apiInstance.UpdateSpatialSceneSetting(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialSceneSetting: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**SpatialSceneResponse2**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialsceneshoplayout"></a>
# **UpdateSpatialSceneShopLayout**
> UpdateSpatialSceneShopLayoutResponse UpdateSpatialSceneShopLayout (string id)

Save your shop room's sections and displays (validated server-side; the response is the stored layout).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialSceneShopLayoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Save your shop room's sections and displays (validated server-side; the response is the stored layout).
                UpdateSpatialSceneShopLayoutResponse result = apiInstance.UpdateSpatialSceneShopLayout(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialSceneShopLayout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateSpatialSceneShopLayoutResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialscenewindow"></a>
# **UpdateSpatialSceneWindow**
> UpdateSpatialSceneWindowResponse UpdateSpatialSceneWindow (string id)

Choose up to three of your live Crossly listings for the street window of your shop, in slot order. Picks that sell drop out and the newest fill in; an empty list goes back to newest first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialSceneWindowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Choose up to three of your live Crossly listings for the street window of your shop, in slot order. Picks that sell drop out and the newest fill in; an empty list goes back to newest first.
                UpdateSpatialSceneWindowResponse result = apiInstance.UpdateSpatialSceneWindow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialSceneWindow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateSpatialSceneWindowResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialstreetdecor"></a>
# **UpdateSpatialStreetDecor**
> GetSpatialStreetDecorResponse UpdateSpatialStreetDecor (string slug)

Dress a street you own with decor you hold (validated against your inventory).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialStreetDecorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Dress a street you own with decor you hold (validated against your inventory).
                GetSpatialStreetDecorResponse result = apiInstance.UpdateSpatialStreetDecor(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialStreetDecor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetSpatialStreetDecorResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatespatialstreetowned"></a>
# **UpdateSpatialStreetOwned**
> SpatialStreetResponse UpdateSpatialStreetOwned (string id)

Who may open a shop on a street you own (open, apply or invite).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateSpatialStreetOwnedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Who may open a shop on a street you own (open, apply or invite).
                SpatialStreetResponse result = apiInstance.UpdateSpatialStreetOwned(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateSpatialStreetOwned: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**SpatialStreetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldautoshop"></a>
# **UpdateWorldAutoShop**
> GetWorldAutoShopResponse UpdateWorldAutoShop (UpdateWorldAutoShopRequest updateWorldAutoShopRequest)

Turn your automatic world shop off ({ enabled: false } - - an auto-created shop is made private, never deleted) or back on. Answers the new status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldAutoShopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var updateWorldAutoShopRequest = new UpdateWorldAutoShopRequest(); // UpdateWorldAutoShopRequest | 

            try
            {
                // Turn your automatic world shop off ({ enabled: false } - - an auto-created shop is made private, never deleted) or back on. Answers the new status.
                GetWorldAutoShopResponse result = apiInstance.UpdateWorldAutoShop(updateWorldAutoShopRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldAutoShop: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWorldAutoShopRequest** | **UpdateWorldAutoShopRequest**|  | 

### Return type

**GetWorldAutoShopResponse**

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

<a name="updateworldavataridentity"></a>
# **UpdateWorldAvatarIdentity**
> UpdateWorldAvatarIdentityResponse UpdateWorldAvatarIdentity ()

Choose named or anonymous. Rooms you are already in keep the old answer until you rejoin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldAvatarIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Choose named or anonymous. Rooms you are already in keep the old answer until you rejoin.
                UpdateWorldAvatarIdentityResponse result = apiInstance.UpdateWorldAvatarIdentity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldAvatarIdentity: " + e.Message );
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

**UpdateWorldAvatarIdentityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldavatarlook"></a>
# **UpdateWorldAvatarLook**
> UpdateWorldAvatarLookResponse UpdateWorldAvatarLook ()

Save your world look to the account, so every device starts from it. look: null stays anonymous.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldAvatarLookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Save your world look to the account, so every device starts from it. look: null stays anonymous.
                UpdateWorldAvatarLookResponse result = apiInstance.UpdateWorldAvatarLook();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldAvatarLook: " + e.Message );
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

**UpdateWorldAvatarLookResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldavatarnftbadge"></a>
# **UpdateWorldAvatarNftBadge**
> GetWorldAvatarNftBadgeResponse UpdateWorldAvatarNftBadge ()

Wear an NFT you hold on your nameplate (null to take it off). Checked again each time you join a room.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldAvatarNftBadgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Wear an NFT you hold on your nameplate (null to take it off). Checked again each time you join a room.
                GetWorldAvatarNftBadgeResponse result = apiInstance.UpdateWorldAvatarNftBadge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldAvatarNftBadge: " + e.Message );
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

**GetWorldAvatarNftBadgeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldcapabilitywear"></a>
# **UpdateWorldCapabilityWear**
> GetWorldCapabilityWearResponse UpdateWorldCapabilityWear ()

Wear a held token on an avatar slot (refId from GET /v1/world/capabilities), or pass refId null to take it off. Its collection must declare a wear capability for that slot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldCapabilityWearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Wear a held token on an avatar slot (refId from GET /v1/world/capabilities), or pass refId null to take it off. Its collection must declare a wear capability for that slot.
                GetWorldCapabilityWearResponse result = apiInstance.UpdateWorldCapabilityWear();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldCapabilityWear: " + e.Message );
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

**GetWorldCapabilityWearResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldcollectioncapability"></a>
# **UpdateWorldCollectionCapability**
> GetWorldCollectionCapabilityResponse UpdateWorldCollectionCapability (string chain, string contract)

Declare what the tokens of a collection can do (the whole declaration, spec crossly.nft-capabilities/1). As its creator (launched on Crossly or claimed) any kind; as a holder, cosmetic kinds only. Replaces your previous declaration; pending if it names an uploaded asset or an always-reviewed kind.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldCollectionCapabilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var chain = "chain_example";  // string | 
            var contract = "contract_example";  // string | 

            try
            {
                // Declare what the tokens of a collection can do (the whole declaration, spec crossly.nft-capabilities/1). As its creator (launched on Crossly or claimed) any kind; as a holder, cosmetic kinds only. Replaces your previous declaration; pending if it names an uploaded asset or an always-reviewed kind.
                GetWorldCollectionCapabilityResponse result = apiInstance.UpdateWorldCollectionCapability(chain, contract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldCollectionCapability: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetWorldCollectionCapabilityResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldconventionstatus"></a>
# **UpdateWorldConventionStatus**
> UpdateWorldConventionStatusResponse UpdateWorldConventionStatus (string id)

Open, start, end or cancel a convention you host.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldConventionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Open, start, end or cancel a convention you host.
                UpdateWorldConventionStatusResponse result = apiInstance.UpdateWorldConventionStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldConventionStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldConventionStatusResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldcosmdesignchainautounlock"></a>
# **UpdateWorldCosmDesignChainAutoUnlock**
> CreateCosmDesignerChainAutoUnlockResponse UpdateWorldCosmDesignChainAutoUnlock (string id)

Opt one of your COSM designs in or out of the free chain unlock it earns when popular (on by default). Answers its popularity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldCosmDesignChainAutoUnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Opt one of your COSM designs in or out of the free chain unlock it earns when popular (on by default). Answers its popularity.
                CreateCosmDesignerChainAutoUnlockResponse result = apiInstance.UpdateWorldCosmDesignChainAutoUnlock(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldCosmDesignChainAutoUnlock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateCosmDesignerChainAutoUnlockResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldemotewheel"></a>
# **UpdateWorldEmoteWheel**
> UpdateWorldEmoteWheelResponse UpdateWorldEmoteWheel (UpdateWorldEmoteWheelRequest updateWorldEmoteWheelRequest)

Arrange your emote wheel: up to 8 slots, each an emote id, a moment slot or null. Returns the saved wheel (locked or unknown ids are dropped).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldEmoteWheelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var updateWorldEmoteWheelRequest = new UpdateWorldEmoteWheelRequest(); // UpdateWorldEmoteWheelRequest | 

            try
            {
                // Arrange your emote wheel: up to 8 slots, each an emote id, a moment slot or null. Returns the saved wheel (locked or unknown ids are dropped).
                UpdateWorldEmoteWheelResponse result = apiInstance.UpdateWorldEmoteWheel(updateWorldEmoteWheelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldEmoteWheel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWorldEmoteWheelRequest** | **UpdateWorldEmoteWheelRequest**|  | 

### Return type

**UpdateWorldEmoteWheelResponse**

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

<a name="updateworldfitvalueshare"></a>
# **UpdateWorldFitValueShare**
> UpdateWorldFitValueShareResponse UpdateWorldFitValueShare ()

Whether people in a room can see what your outfit is worth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldFitValueShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Whether people in a room can see what your outfit is worth.
                UpdateWorldFitValueShareResponse result = apiInstance.UpdateWorldFitValueShare();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldFitValueShare: " + e.Message );
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

**UpdateWorldFitValueShareResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldhome"></a>
# **UpdateWorldHome**
> WorldHomeResponse UpdateWorldHome ()

Your home: privacy (open, friends, private), theme, and wall, floor and mood decor you hold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldHomeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Your home: privacy (open, friends, private), theme, and wall, floor and mood decor you hold.
                WorldHomeResponse result = apiInstance.UpdateWorldHome();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldHome: " + e.Message );
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

**WorldHomeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldhomebuilder"></a>
# **UpdateWorldHomeBuilder**
> UpdateWorldHomeBuilderResponse UpdateWorldHomeBuilder (UpdateWorldHomeBuilderRequest updateWorldHomeBuilderRequest)

Set the co-builders of your home: { userIds } - - friends (mutual follows) only, at most 4, replacing the list ([] clears it). They may rearrange your home in the world with your things and add free furniture, never your bought pieces. New co-builders get a world notice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldHomeBuilderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var updateWorldHomeBuilderRequest = new UpdateWorldHomeBuilderRequest(); // UpdateWorldHomeBuilderRequest | 

            try
            {
                // Set the co-builders of your home: { userIds } - - friends (mutual follows) only, at most 4, replacing the list ([] clears it). They may rearrange your home in the world with your things and add free furniture, never your bought pieces. New co-builders get a world notice.
                UpdateWorldHomeBuilderResponse result = apiInstance.UpdateWorldHomeBuilder(updateWorldHomeBuilderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldHomeBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWorldHomeBuilderRequest** | **UpdateWorldHomeBuilderRequest**|  | 

### Return type

**UpdateWorldHomeBuilderResponse**

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

<a name="updateworldhomelayout"></a>
# **UpdateWorldHomeLayout**
> WorldHomeResponse UpdateWorldHomeLayout ()

Arrange your home: the full layout (up to 200 pieces you own), validated server-side.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldHomeLayoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);

            try
            {
                // Arrange your home: the full layout (up to 200 pieces you own), validated server-side.
                WorldHomeResponse result = apiInstance.UpdateWorldHomeLayout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldHomeLayout: " + e.Message );
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

**WorldHomeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldhomelayoutbyslug"></a>
# **UpdateWorldHomeLayoutBySlug**
> WorldHomeResponse UpdateWorldHomeLayoutBySlug (string slug)

Rearrange a home you co-build (never adding the owner bought pieces).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldHomeLayoutBySlugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Rearrange a home you co-build (never adding the owner bought pieces).
                WorldHomeResponse result = apiInstance.UpdateWorldHomeLayoutBySlug(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldHomeLayoutBySlug: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**WorldHomeResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldinteractivedesigndraft"></a>
# **UpdateWorldInteractiveDesignDraft**
> UpdateWorldInteractiveDesignDraftResponse UpdateWorldInteractiveDesignDraft (string id)

Save the draft MML source (up to 64 KB); the response carries its static check.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldInteractiveDesignDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Save the draft MML source (up to 64 KB); the response carries its static check.
                UpdateWorldInteractiveDesignDraftResponse result = apiInstance.UpdateWorldInteractiveDesignDraft(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldInteractiveDesignDraft: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldInteractiveDesignDraftResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldlistingholdersonly"></a>
# **UpdateWorldListingHoldersOnly**
> UpdateWorldListingHoldersOnlyResponse UpdateWorldListingHoldersOnly (string id)

Reserve one of your listings for holders of a collection you declared a holders_only perk for (or release it). Checkout refuses anybody else.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldListingHoldersOnlyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Reserve one of your listings for holders of a collection you declared a holders_only perk for (or release it). Checkout refuses anybody else.
                UpdateWorldListingHoldersOnlyResponse result = apiInstance.UpdateWorldListingHoldersOnly(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldListingHoldersOnly: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldListingHoldersOnlyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldoutfit"></a>
# **UpdateWorldOutfit**
> UpdateWorldOutfitResponse UpdateWorldOutfit (Guid id, UpdateWorldOutfitRequest updateWorldOutfitRequest)

Rename a saved look: { name (1-32 chars) }. 404 when it is not yours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldOutfitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // Guid | 
            var updateWorldOutfitRequest = new UpdateWorldOutfitRequest(); // UpdateWorldOutfitRequest | 

            try
            {
                // Rename a saved look: { name (1-32 chars) }. 404 when it is not yours.
                UpdateWorldOutfitResponse result = apiInstance.UpdateWorldOutfit(id, updateWorldOutfitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldOutfit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **updateWorldOutfitRequest** | **UpdateWorldOutfitRequest**|  | 

### Return type

**UpdateWorldOutfitResponse**

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

<a name="updateworldpetactive"></a>
# **UpdateWorldPetActive**
> UpdateWorldPetActiveResponse UpdateWorldPetActive (UpdateWorldPetActiveRequest updateWorldPetActiveRequest)

Walk one of your pets with you in the world, or none (kind: null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldPetActiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var updateWorldPetActiveRequest = new UpdateWorldPetActiveRequest(); // UpdateWorldPetActiveRequest | 

            try
            {
                // Walk one of your pets with you in the world, or none (kind: null).
                UpdateWorldPetActiveResponse result = apiInstance.UpdateWorldPetActive(updateWorldPetActiveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldPetActive: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWorldPetActiveRequest** | **UpdateWorldPetActiveRequest**|  | 

### Return type

**UpdateWorldPetActiveResponse**

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

<a name="updateworldquestpin"></a>
# **UpdateWorldQuestPin**
> UpdateWorldQuestPinResponse UpdateWorldQuestPin (UpdateWorldQuestPinRequest updateWorldQuestPinRequest)

Wear a pin you EARNED from a quest on your nameplate, or { pin: null } to wear none. 403 for a pin you have not earned. Shows from the next room you walk into.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldQuestPinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var updateWorldQuestPinRequest = new UpdateWorldQuestPinRequest(); // UpdateWorldQuestPinRequest | 

            try
            {
                // Wear a pin you EARNED from a quest on your nameplate, or { pin: null } to wear none. 403 for a pin you have not earned. Shows from the next room you walk into.
                UpdateWorldQuestPinResponse result = apiInstance.UpdateWorldQuestPin(updateWorldQuestPinRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldQuestPin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateWorldQuestPinRequest** | **UpdateWorldQuestPinRequest**|  | 

### Return type

**UpdateWorldQuestPinResponse**

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

<a name="updateworldroomholdergate"></a>
# **UpdateWorldRoomHolderGate**
> UpdateWorldRoomHolderGateResponse UpdateWorldRoomHolderGate (string id)

Make your room holders-only (its collection rooms follow). Send null to open it again. Returns `{ gate }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldRoomHolderGateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Make your room holders-only (its collection rooms follow). Send null to open it again. Returns `{ gate }`.
                UpdateWorldRoomHolderGateResponse result = apiInstance.UpdateWorldRoomHolderGate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldRoomHolderGate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldRoomHolderGateResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldspace"></a>
# **UpdateWorldSpace**
> UpdateWorldSpaceResponse UpdateWorldSpace (string slug)

As host, change a Space name, about or membership.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // As host, change a Space name, about or membership.
                UpdateWorldSpaceResponse result = apiInstance.UpdateWorldSpace(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldSpace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldSpaceResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldspaceholdergate"></a>
# **UpdateWorldSpaceHolderGate**
> UpdateWorldRoomHolderGateResponse UpdateWorldSpaceHolderGate (string slug)

Make your Space holders-only: only holders of an NFT collection join it (others can look in). Send null to open it again. Returns `{ gate }`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldSpaceHolderGateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var slug = "slug_example";  // string | 

            try
            {
                // Make your Space holders-only: only holders of an NFT collection join it (others can look in). Send null to open it again. Returns `{ gate }`.
                UpdateWorldRoomHolderGateResponse result = apiInstance.UpdateWorldSpaceHolderGate(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldSpaceHolderGate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldRoomHolderGateResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updateworldstallbookingbooth"></a>
# **UpdateWorldStallBookingBooth**
> UpdateWorldStallBookingBoothResponse UpdateWorldStallBookingBooth (string id)

Dress the booth of a stall you booked (decor you hold).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateWorldStallBookingBoothExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WorldApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Dress the booth of a stall you booked (decor you hold).
                UpdateWorldStallBookingBoothResponse result = apiInstance.UpdateWorldStallBookingBooth(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorldApi.UpdateWorldStallBookingBooth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**UpdateWorldStallBookingBoothResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

