# net.crossly.Api.ActivityApi

All URIs are relative to *https://crossly.net/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateActionLogExport**](ActivityApi.md#createactionlogexport) | **POST** /v1/action-log/exports | Queue an export of the Activity Log: every event (csv, ndjson, pdf) or a summary report (pdf, ndjson). Poll GET /api/v1/action-log/exports/{exportId}, then download it. Exports never contain IP addresses.
[**CreateActionLogSearchTranslate**](ActivityApi.md#createactionlogsearchtranslate) | **POST** /v1/action-log/search/translate | Turn a question in words (\&quot;failed delists on Mercari last week\&quot;) into an Activity Log search: pass the returned &#x60;q&#x60; to GET /api/v1/action-log (or the histogram and csv/ndjson exports). Nothing is run. A 404 with details.code &#x60;not_enabled&#x60; means natural-language search is off for this account.
[**CreateDetectedEventEventConfirm**](ActivityApi.md#createdetectedeventeventconfirm) | **POST** /v1/detected-events/events/{id}/confirm | Answer an open ask (canConfirm true): optionally which item it is (itemId, one of the match candidates) and which actions to run instead of the ask&#39;s preselected ones. Returns the event. 409 ask_not_open when the event is not waiting.
[**CreateDetectedEventEventDismiss**](ActivityApi.md#createdetectedeventeventdismiss) | **POST** /v1/detected-events/events/{id}/dismiss | Close an open ask without acting (status dismissed): nothing runs and nothing is recorded for the event. reason is kept with it. Returns the event. 409 ask_not_open when the event is not waiting.
[**CreateDetectedEventEventReject**](ActivityApi.md#createdetectedeventeventreject) | **POST** /v1/detected-events/events/{id}/reject | \&quot;Not this item\&quot;: drop the suggested match of an open ask (itemId: just that candidate; omitted: every candidate). The ask stays open with the remaining candidates, or asks which item it is. Returns the event.
[**CreateDetectedEventEventUndo**](ActivityApi.md#createdetectedeventeventundo) | **POST** /v1/detected-events/events/{id}/undo | Undo what Crossly did for an event (canUndo true): every executed action&#39;s stored inverse runs, newest first (restore stock, relist, unlink…). Returns the event. 409 nothing_to_undo when nothing is reversible.
[**CreateDetectedEventRule**](ActivityApi.md#createdetectedeventrule) | **POST** /v1/detected-events/rules | Create a detection rule: which detected events it applies to (filter + optional condition over any event axis) and what Crossly does then (and else). Without order it is placed most-specific-first, above the default set. Returns the stored rule with its id.
[**CreateDetectedEventRuleCopy**](ActivityApi.md#createdetectedeventrulecopy) | **POST** /v1/detected-events/rules/{ref}/copy | Copy one rule (a stored id, or default.&lt;key&gt; for the store&#39;s effective rule of a situation) into other stores of yours, at the same relative position. A target store that already has its own rule for that situation keeps it unless overwrite is true. Returns what was copied (and whether it replaced a rule) and what was skipped, and why.
[**CreateDetectedEventRulePlace**](ActivityApi.md#createdetectedeventruleplace) | **POST** /v1/detected-events/rules/place | Save one rule and the whole evaluation order in one transaction: rule.id is an existing id (replace) or any new client id (create); ids is every rule id top-down, naming the rule by that id. Returns the stored rule and the list.
[**CreateDetectedEventRuleReorder**](ActivityApi.md#createdetectedeventrulereorder) | **POST** /v1/detected-events/rules/reorder | Set the evaluation order: ids top-down, defaults included (ids from the rules list). Rules are re-numbered 10, 20, 30…; a default moved above one of your rules is stored as your edit. Returns the list.
[**CreateDetectedEventRuleResetDefault**](ActivityApi.md#createdetectedeventruleresetdefault) | **POST** /v1/detected-events/rules/reset-defaults | Drop your edits of the shipped default rules (keys, or all when omitted). Returns the list.
[**CreateDetectedEventSimulate**](ActivityApi.md#createdetectedeventsimulate) | **POST** /v1/detected-events/simulate | Run one event through the rules without acting: the winning rule, rules it shadowed, the trace, the guards that held actions back and the plan per target with how it would run (direct / relay / ask / skip). event needs only kind; every axis left out takes its default. rules &#x3D; an unsaved draft list.
[**CreateDetectedEventSimulateImpact**](ActivityApi.md#createdetectedeventsimulateimpact) | **POST** /v1/detected-events/simulate/impact | What a rule edit would change: your detected events of the last days (default 30, at most 500) re-resolved against the draft rules and against the stored ones. Per event: winning rule and actions before and after, and whether it changed. Nothing runs.
[**CreateDetectedEventStartingPointPreview**](ActivityApi.md#createdetectedeventstartingpointpreview) | **POST** /v1/detected-events/starting-point/preview | What applying a starting point would change, nothing saved: per situation its title, the outcome now and after, and whether it would overwrite a default you edited by hand (those are kept: a starting point only rewrites untouched defaults, never your own rules).
[**CreateEmailEventConfirm**](ActivityApi.md#createemaileventconfirm) | **POST** /v1/email-events/{id}/confirm | Confirm an email-detected event: re-run it as certain (a possible sale records the sale and delists the item elsewhere). When several listings could be meant, pass platformListingDbId to choose one.
[**CreateEmailEventDismiss**](ActivityApi.md#createemaileventdismiss) | **POST** /v1/email-events/{id}/dismiss | Dismiss an email-detected event (\&quot;not a sale\&quot;): closes the card without acting.
[**CreateEmailEventReprocess**](ActivityApi.md#createemaileventreprocess) | **POST** /v1/email-events/{id}/reprocess | Re-process a marketplace email with the current templates (one Crossly did not recognise, could not finish, or ignored). Refused (409) for an email that already changed something, or once its 30-day copy is gone.
[**CreateEventPolicyDecisionConfirm**](ActivityApi.md#createeventpolicydecisionconfirm) | **POST** /v1/event-policies/decisions/{id}/confirm | Confirm a review decision from a webhook, order poller or app relay (canConfirm true): the event runs again with the seller confirmed, so a review rule runs the strongest allowed non-review action for that cell. Returns the new decision. 409 when the decision was already confirmed or is not confirmable (email review decisions are confirmed on their review card).
[**DeleteDetectedEventRule**](ActivityApi.md#deletedetectedeventrule) | **DELETE** /v1/detected-events/rules/{id} | Delete a detection rule. Deleting your edit of a default (its id, or default:&lt;key&gt;) brings the shipped default back; deleting a translated event-policy rule deletes that policy rule too.
[**DeleteEventPolicyRule**](ActivityApi.md#deleteeventpolicyrule) | **DELETE** /v1/event-policies/rules/{id} | Delete a rule: its cell falls back to the next scope (platform → global → the built-in default).
[**GetActionLog**](ActivityApi.md#getactionlog) | **GET** /v1/action-log/{id} | One Activity Log event by id, with &#x60;view&#x60; including its steps and, for bulk jobs, its children.
[**GetActionLogExport**](ActivityApi.md#getactionlogexport) | **GET** /v1/action-log/exports/{exportId} | The state of one Activity Log export.
[**GetActionLogExportDownload**](ActivityApi.md#getactionlogexportdownload) | **GET** /v1/action-log/exports/{exportId}/download | Download a finished Activity Log export (for 24 hours after it completes).
[**GetActionLogFacet**](ActivityApi.md#getactionlogfacet) | **GET** /v1/action-log/facets | Filter options of the caller&#39;s Activity Log (last 90 days): areas with their actions and counts, the team members who acted, platforms and outcomes.
[**GetDetectedEventEvent**](ActivityApi.md#getdetectedeventevent) | **GET** /v1/detected-events/events/{id} | One detected event with every report of it (first + corroborations, with correlation and contradiction), the guards that held actions back, the plan and each executed action&#39;s outcome and reversibility.
[**GetDetectedEventOverview**](ActivityApi.md#getdetectedeventoverview) | **GET** /v1/detected-events/overview | What Crossly does today in each situation for the store, computed from the store&#39;s real rules the way the engine decides: per situation its topic, title, the outcome in words, the rule ref that decides it, whether it differs from the recommended default, and narrower rules (one marketplace, account or app) that decide it differently there. Also the headline situations per topic, the starting point (hands_on / balanced / hands_off / custom), how many rules are your own and how many events wait for you. The store is X-Storefront-Id (omitted: the default store).
[**GetDetectedEventRule**](ActivityApi.md#getdetectedeventrule) | **GET** /v1/detected-events/rules/{ref} | One detection rule by its ref: a stored rule&#39;s id, or default.&lt;key&gt; for a situation (the store&#39;s effective rule for it: your edit when there is one, else the shipped default). Returns the rule, the situation it decides (topic, title, why it is the default), the choice cards offered for that situation (each a complete rule body, the recommended one first) and which card the rule is (custom when none). A retired key (order.notify, account) opens the key it was split into. 404 when the ref names nothing.
[**GetDetectedEventStartingPoint**](ActivityApi.md#getdetectedeventstartingpoint) | **GET** /v1/detected-events/starting-point | The store&#39;s starting point: hands_on, balanced (recommended), hands_off, or custom once a default was edited by hand. Preview a change with POST starting-point/preview, apply it with PUT starting-point.
[**GetEmailEvent**](ActivityApi.md#getemailevent) | **GET** /v1/email-events/{id} | One marketplace email Crossly read: what it did with it (outcome), the fields the template extracted, and the mailbox it came from.
[**GetEmailEventPreview**](ActivityApi.md#getemaileventpreview) | **GET** /v1/email-events/{id}/preview | A marketplace email&#39;s sanitized preview: text only, buyer address lines hidden, links without their query. Crossly keeps each email 30 days; after that this is a 409.
[**GetEventPolicy**](ActivityApi.md#geteventpolicy) | **GET** /v1/event-policies | What Crossly does with each detected marketplace event (sale, listing ended, offer, cancellation, label, shipped, delivered, refund, return, payout, message), per who owns the item (crossly, imported, app_managed, other_tool, untracked). Each matrix cell lists the allowed actions and the effective one, with the scope it comes from (app &gt; platform &gt; global &gt; default). Pass platform (or appId) to see the matrix as that platform&#39;s (or app&#39;s) items see it. Also returns the rules, platforms and connected apps.
[**ListActionLog**](ActivityApi.md#listactionlog) | **GET** /v1/action-log | List Activity Log events, newest first. Each event carries &#x60;view&#x60; (title, sentence, fields, failure advice, who did it) and typed &#x60;detail&#x60;. Page with &#x60;cursor&#x60;; &#x60;pagination.total&#x60; counts matches.
[**ListActionLogCalls**](ActivityApi.md#listactionlogcalls) | **GET** /v1/action-log/{id}/calls | The outbound platform HTTP calls under an event (oldest first) — platform, operation, method, host, status, latency, error class/message, proxy + recipe id. Answers \&quot;what was sent / what went wrong\&quot;. The URL path, request/response bodies and persisted-query hash are never returned.
[**ListActionLogHistogram**](ActivityApi.md#listactionloghistogram) | **GET** /v1/action-log/histogram | Events per UTC day for the list filters (default: the last 30 days; at most 366).
[**ListDetectedEventEvents**](ActivityApi.md#listdetectedeventevents) | **GET** /v1/detected-events/events | Every event Crossly detected (sales, order changes, listing changes, offers, messages, account notices), newest first: all its axes, the rule that decided it, its corroborating reports, the plan per target and how each action went, with canConfirm (an open ask) and canUndo. Cursor-paged; filter by kinds, platforms, statuses, accounts and channels (comma-separated), one item, listing, order or deciding rule, and since (ISO time). statuses&#x3D;asked is what waits for you; dismissed is an ask closed without acting. Rows from before the rules update carry legacy: true and have no actions. Per store: X-Storefront-Id (omitted: the default store, which also keeps events recorded before stores existed).
[**ListDetectedEventRules**](ActivityApi.md#listdetectedeventrules) | **GET** /v1/detected-events/rules | The seller&#39;s detection rules, top-down in the order they are evaluated (first match wins unless a rule says continue): the seller&#39;s own rules, translations of their event-policy rules (source legacy), then the shipped default set (source default, ids default:&lt;key&gt;; a stored edit of a default replaces it). Each rule has a filter (event kinds, platforms, accounts, apps, tags, items), an optional condition over any event axis, the actions it runs (then / else) and its guard loosenings.
[**ListDetectedEventSituations**](ActivityApi.md#listdetectedeventsituations) | **GET** /v1/detected-events/situations | Every situation Crossly decides (a sale of an item in Crossly, a sale not in Crossly with no match, a return opened, a connection lost…), grouped by topic (sales, orders, listings, buyers, account): its title, whether it is a headline row of the Overview, why the default is what it is, its rule ref (default.&lt;key&gt;) and the choice cards offered for it. To pick a card, PUT its body to the rule default:&lt;key&gt;. The same catalog for every seller; GET overview says what each does today.
[**ListEmailEvents**](ActivityApi.md#listemailevents) | **GET** /v1/email-events | List email-detected events waiting for the seller (status&#x3D;needs_review): a possible sale, ended listing, cancellation or other event an email reported that was not certain enough to act on automatically.
[**ListEventPolicyDecisions**](ActivityApi.md#listeventpolicydecisions) | **GET** /v1/event-policies/decisions | The decision log, newest first: for each detected event, what the rule or default asked for, what was done (after capability fallback and the email confidence ceiling), the rule that decided it, and the outcome (done / skipped / failed / review). Cursor-paged; filter by event, ownership, platform or outcome (outcome&#x3D;review: still waiting for the seller). Kept 90 days.
[**UpdateDetectedEventRule**](ActivityApi.md#updatedetectedeventrule) | **PUT** /v1/detected-events/rules/{id} | Replace a detection rule. An id default:&lt;key&gt; stores your edit of that shipped default (delete it, or reset-defaults, to go back to the shipped one).
[**UpdateDetectedEventStartingPoint**](ActivityApi.md#updatedetectedeventstartingpoint) | **PUT** /v1/detected-events/starting-point | Apply a starting point to the store: rewrites the store&#39;s untouched default rules as ordinary rules (balanced removes them, so the shipped defaults apply). Defaults you edited and your own rules stay as they are; starting points do not stack. Logged to Activity. Returns the starting point now in effect.
[**UpdateEventPolicyRule**](ActivityApi.md#updateeventpolicyrule) | **PUT** /v1/event-policies/rules | Set what Crossly does with one kind of detected event for one kind of item: scope global (scopeValue null), platform (scopeValue &#x3D; platform id) or app (scopeValue &#x3D; OAuth app id, app_managed items only). Replaces the rule for the same cell and scope. The action must be one the matrix allows for that cell; import actions exist only for untracked items.


<a name="createactionlogexport"></a>
# **CreateActionLogExport**
> GetActionLogExportResponse CreateActionLogExport (CreateActionLogExportRequest createActionLogExportRequest)

Queue an export of the Activity Log: every event (csv, ndjson, pdf) or a summary report (pdf, ndjson). Poll GET /api/v1/action-log/exports/{exportId}, then download it. Exports never contain IP addresses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateActionLogExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createActionLogExportRequest = new CreateActionLogExportRequest(); // CreateActionLogExportRequest | 

            try
            {
                // Queue an export of the Activity Log: every event (csv, ndjson, pdf) or a summary report (pdf, ndjson). Poll GET /api/v1/action-log/exports/{exportId}, then download it. Exports never contain IP addresses.
                GetActionLogExportResponse result = apiInstance.CreateActionLogExport(createActionLogExportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateActionLogExport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createActionLogExportRequest** | **CreateActionLogExportRequest**|  | 

### Return type

**GetActionLogExportResponse**

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

<a name="createactionlogsearchtranslate"></a>
# **CreateActionLogSearchTranslate**
> CreateActionLogSearchTranslateResponse CreateActionLogSearchTranslate (CreateActionLogSearchTranslateRequest createActionLogSearchTranslateRequest)

Turn a question in words (\"failed delists on Mercari last week\") into an Activity Log search: pass the returned `q` to GET /api/v1/action-log (or the histogram and csv/ndjson exports). Nothing is run. A 404 with details.code `not_enabled` means natural-language search is off for this account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateActionLogSearchTranslateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createActionLogSearchTranslateRequest = new CreateActionLogSearchTranslateRequest(); // CreateActionLogSearchTranslateRequest | 

            try
            {
                // Turn a question in words (\"failed delists on Mercari last week\") into an Activity Log search: pass the returned `q` to GET /api/v1/action-log (or the histogram and csv/ndjson exports). Nothing is run. A 404 with details.code `not_enabled` means natural-language search is off for this account.
                CreateActionLogSearchTranslateResponse result = apiInstance.CreateActionLogSearchTranslate(createActionLogSearchTranslateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateActionLogSearchTranslate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createActionLogSearchTranslateRequest** | **CreateActionLogSearchTranslateRequest**|  | 

### Return type

**CreateActionLogSearchTranslateResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createdetectedeventeventconfirm"></a>
# **CreateDetectedEventEventConfirm**
> DetectedEventEventResponse CreateDetectedEventEventConfirm (Guid id, CreateDetectedEventEventConfirmRequest createDetectedEventEventConfirmRequest)

Answer an open ask (canConfirm true): optionally which item it is (itemId, one of the match candidates) and which actions to run instead of the ask's preselected ones. Returns the event. 409 ask_not_open when the event is not waiting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventEventConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 
            var createDetectedEventEventConfirmRequest = new CreateDetectedEventEventConfirmRequest(); // CreateDetectedEventEventConfirmRequest | 

            try
            {
                // Answer an open ask (canConfirm true): optionally which item it is (itemId, one of the match candidates) and which actions to run instead of the ask's preselected ones. Returns the event. 409 ask_not_open when the event is not waiting.
                DetectedEventEventResponse result = apiInstance.CreateDetectedEventEventConfirm(id, createDetectedEventEventConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventEventConfirm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createDetectedEventEventConfirmRequest** | **CreateDetectedEventEventConfirmRequest**|  | 

### Return type

**DetectedEventEventResponse**

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

<a name="createdetectedeventeventdismiss"></a>
# **CreateDetectedEventEventDismiss**
> DetectedEventEventResponse CreateDetectedEventEventDismiss (Guid id, CreateDetectedEventEventDismissRequest createDetectedEventEventDismissRequest)

Close an open ask without acting (status dismissed): nothing runs and nothing is recorded for the event. reason is kept with it. Returns the event. 409 ask_not_open when the event is not waiting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventEventDismissExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 
            var createDetectedEventEventDismissRequest = new CreateDetectedEventEventDismissRequest(); // CreateDetectedEventEventDismissRequest | 

            try
            {
                // Close an open ask without acting (status dismissed): nothing runs and nothing is recorded for the event. reason is kept with it. Returns the event. 409 ask_not_open when the event is not waiting.
                DetectedEventEventResponse result = apiInstance.CreateDetectedEventEventDismiss(id, createDetectedEventEventDismissRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventEventDismiss: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createDetectedEventEventDismissRequest** | **CreateDetectedEventEventDismissRequest**|  | 

### Return type

**DetectedEventEventResponse**

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

<a name="createdetectedeventeventreject"></a>
# **CreateDetectedEventEventReject**
> DetectedEventEventResponse CreateDetectedEventEventReject (Guid id, CreateDetectedEventEventRejectRequest createDetectedEventEventRejectRequest)

\"Not this item\": drop the suggested match of an open ask (itemId: just that candidate; omitted: every candidate). The ask stays open with the remaining candidates, or asks which item it is. Returns the event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventEventRejectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 
            var createDetectedEventEventRejectRequest = new CreateDetectedEventEventRejectRequest(); // CreateDetectedEventEventRejectRequest | 

            try
            {
                // \"Not this item\": drop the suggested match of an open ask (itemId: just that candidate; omitted: every candidate). The ask stays open with the remaining candidates, or asks which item it is. Returns the event.
                DetectedEventEventResponse result = apiInstance.CreateDetectedEventEventReject(id, createDetectedEventEventRejectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventEventReject: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createDetectedEventEventRejectRequest** | **CreateDetectedEventEventRejectRequest**|  | 

### Return type

**DetectedEventEventResponse**

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

<a name="createdetectedeventeventundo"></a>
# **CreateDetectedEventEventUndo**
> DetectedEventEventResponse CreateDetectedEventEventUndo (Guid id)

Undo what Crossly did for an event (canUndo true): every executed action's stored inverse runs, newest first (restore stock, relist, unlink…). Returns the event. 409 nothing_to_undo when nothing is reversible.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventEventUndoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Undo what Crossly did for an event (canUndo true): every executed action's stored inverse runs, newest first (restore stock, relist, unlink…). Returns the event. 409 nothing_to_undo when nothing is reversible.
                DetectedEventEventResponse result = apiInstance.CreateDetectedEventEventUndo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventEventUndo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DetectedEventEventResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createdetectedeventrule"></a>
# **CreateDetectedEventRule**
> CreateDetectedEventRuleResponse CreateDetectedEventRule (CreateDetectedEventRuleRequest createDetectedEventRuleRequest)

Create a detection rule: which detected events it applies to (filter + optional condition over any event axis) and what Crossly does then (and else). Without order it is placed most-specific-first, above the default set. Returns the stored rule with its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventRuleRequest = new CreateDetectedEventRuleRequest(); // CreateDetectedEventRuleRequest | 

            try
            {
                // Create a detection rule: which detected events it applies to (filter + optional condition over any event axis) and what Crossly does then (and else). Without order it is placed most-specific-first, above the default set. Returns the stored rule with its id.
                CreateDetectedEventRuleResponse result = apiInstance.CreateDetectedEventRule(createDetectedEventRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventRuleRequest** | **CreateDetectedEventRuleRequest**|  | 

### Return type

**CreateDetectedEventRuleResponse**

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

<a name="createdetectedeventrulecopy"></a>
# **CreateDetectedEventRuleCopy**
> CreateDetectedEventRuleCopyResponse CreateDetectedEventRuleCopy (string _ref, CreateDetectedEventRuleCopyRequest createDetectedEventRuleCopyRequest)

Copy one rule (a stored id, or default.<key> for the store's effective rule of a situation) into other stores of yours, at the same relative position. A target store that already has its own rule for that situation keeps it unless overwrite is true. Returns what was copied (and whether it replaced a rule) and what was skipped, and why.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventRuleCopyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var _ref = "_ref_example";  // string | A rule id, or default.<key> (default:<key> works).
            var createDetectedEventRuleCopyRequest = new CreateDetectedEventRuleCopyRequest(); // CreateDetectedEventRuleCopyRequest | 

            try
            {
                // Copy one rule (a stored id, or default.<key> for the store's effective rule of a situation) into other stores of yours, at the same relative position. A target store that already has its own rule for that situation keeps it unless overwrite is true. Returns what was copied (and whether it replaced a rule) and what was skipped, and why.
                CreateDetectedEventRuleCopyResponse result = apiInstance.CreateDetectedEventRuleCopy(_ref, createDetectedEventRuleCopyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventRuleCopy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_ref** | **string**| A rule id, or default.&lt;key&gt; (default:&lt;key&gt; works). | 
 **createDetectedEventRuleCopyRequest** | **CreateDetectedEventRuleCopyRequest**|  | 

### Return type

**CreateDetectedEventRuleCopyResponse**

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

<a name="createdetectedeventruleplace"></a>
# **CreateDetectedEventRulePlace**
> CreateDetectedEventRulePlaceResponse CreateDetectedEventRulePlace (CreateDetectedEventRulePlaceRequest createDetectedEventRulePlaceRequest)

Save one rule and the whole evaluation order in one transaction: rule.id is an existing id (replace) or any new client id (create); ids is every rule id top-down, naming the rule by that id. Returns the stored rule and the list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventRulePlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventRulePlaceRequest = new CreateDetectedEventRulePlaceRequest(); // CreateDetectedEventRulePlaceRequest | 

            try
            {
                // Save one rule and the whole evaluation order in one transaction: rule.id is an existing id (replace) or any new client id (create); ids is every rule id top-down, naming the rule by that id. Returns the stored rule and the list.
                CreateDetectedEventRulePlaceResponse result = apiInstance.CreateDetectedEventRulePlace(createDetectedEventRulePlaceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventRulePlace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventRulePlaceRequest** | **CreateDetectedEventRulePlaceRequest**|  | 

### Return type

**CreateDetectedEventRulePlaceResponse**

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

<a name="createdetectedeventrulereorder"></a>
# **CreateDetectedEventRuleReorder**
> CreateDetectedEventRuleReorderResponse CreateDetectedEventRuleReorder (CreateDetectedEventRuleReorderRequest createDetectedEventRuleReorderRequest)

Set the evaluation order: ids top-down, defaults included (ids from the rules list). Rules are re-numbered 10, 20, 30…; a default moved above one of your rules is stored as your edit. Returns the list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventRuleReorderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventRuleReorderRequest = new CreateDetectedEventRuleReorderRequest(); // CreateDetectedEventRuleReorderRequest | 

            try
            {
                // Set the evaluation order: ids top-down, defaults included (ids from the rules list). Rules are re-numbered 10, 20, 30…; a default moved above one of your rules is stored as your edit. Returns the list.
                CreateDetectedEventRuleReorderResponse result = apiInstance.CreateDetectedEventRuleReorder(createDetectedEventRuleReorderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventRuleReorder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventRuleReorderRequest** | **CreateDetectedEventRuleReorderRequest**|  | 

### Return type

**CreateDetectedEventRuleReorderResponse**

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

<a name="createdetectedeventruleresetdefault"></a>
# **CreateDetectedEventRuleResetDefault**
> CreateDetectedEventRuleReorderResponse CreateDetectedEventRuleResetDefault (CreateDetectedEventRuleResetDefaultRequest createDetectedEventRuleResetDefaultRequest)

Drop your edits of the shipped default rules (keys, or all when omitted). Returns the list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventRuleResetDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventRuleResetDefaultRequest = new CreateDetectedEventRuleResetDefaultRequest(); // CreateDetectedEventRuleResetDefaultRequest | 

            try
            {
                // Drop your edits of the shipped default rules (keys, or all when omitted). Returns the list.
                CreateDetectedEventRuleReorderResponse result = apiInstance.CreateDetectedEventRuleResetDefault(createDetectedEventRuleResetDefaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventRuleResetDefault: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventRuleResetDefaultRequest** | **CreateDetectedEventRuleResetDefaultRequest**|  | 

### Return type

**CreateDetectedEventRuleReorderResponse**

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

<a name="createdetectedeventsimulate"></a>
# **CreateDetectedEventSimulate**
> CreateDetectedEventSimulateResponse CreateDetectedEventSimulate (CreateDetectedEventSimulateRequest createDetectedEventSimulateRequest)

Run one event through the rules without acting: the winning rule, rules it shadowed, the trace, the guards that held actions back and the plan per target with how it would run (direct / relay / ask / skip). event needs only kind; every axis left out takes its default. rules = an unsaved draft list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventSimulateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventSimulateRequest = new CreateDetectedEventSimulateRequest(); // CreateDetectedEventSimulateRequest | 

            try
            {
                // Run one event through the rules without acting: the winning rule, rules it shadowed, the trace, the guards that held actions back and the plan per target with how it would run (direct / relay / ask / skip). event needs only kind; every axis left out takes its default. rules = an unsaved draft list.
                CreateDetectedEventSimulateResponse result = apiInstance.CreateDetectedEventSimulate(createDetectedEventSimulateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventSimulate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventSimulateRequest** | **CreateDetectedEventSimulateRequest**|  | 

### Return type

**CreateDetectedEventSimulateResponse**

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

<a name="createdetectedeventsimulateimpact"></a>
# **CreateDetectedEventSimulateImpact**
> CreateDetectedEventSimulateImpactResponse CreateDetectedEventSimulateImpact (CreateDetectedEventSimulateImpactRequest createDetectedEventSimulateImpactRequest)

What a rule edit would change: your detected events of the last days (default 30, at most 500) re-resolved against the draft rules and against the stored ones. Per event: winning rule and actions before and after, and whether it changed. Nothing runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventSimulateImpactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var createDetectedEventSimulateImpactRequest = new CreateDetectedEventSimulateImpactRequest(); // CreateDetectedEventSimulateImpactRequest | 

            try
            {
                // What a rule edit would change: your detected events of the last days (default 30, at most 500) re-resolved against the draft rules and against the stored ones. Per event: winning rule and actions before and after, and whether it changed. Nothing runs.
                CreateDetectedEventSimulateImpactResponse result = apiInstance.CreateDetectedEventSimulateImpact(createDetectedEventSimulateImpactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventSimulateImpact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDetectedEventSimulateImpactRequest** | **CreateDetectedEventSimulateImpactRequest**|  | 

### Return type

**CreateDetectedEventSimulateImpactResponse**

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

<a name="createdetectedeventstartingpointpreview"></a>
# **CreateDetectedEventStartingPointPreview**
> CreateDetectedEventStartingPointPreviewResponse CreateDetectedEventStartingPointPreview (UpdateDetectedEventStartingPointRequest updateDetectedEventStartingPointRequest)

What applying a starting point would change, nothing saved: per situation its title, the outcome now and after, and whether it would overwrite a default you edited by hand (those are kept: a starting point only rewrites untouched defaults, never your own rules).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateDetectedEventStartingPointPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var updateDetectedEventStartingPointRequest = new UpdateDetectedEventStartingPointRequest(); // UpdateDetectedEventStartingPointRequest | 

            try
            {
                // What applying a starting point would change, nothing saved: per situation its title, the outcome now and after, and whether it would overwrite a default you edited by hand (those are kept: a starting point only rewrites untouched defaults, never your own rules).
                CreateDetectedEventStartingPointPreviewResponse result = apiInstance.CreateDetectedEventStartingPointPreview(updateDetectedEventStartingPointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateDetectedEventStartingPointPreview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateDetectedEventStartingPointRequest** | **UpdateDetectedEventStartingPointRequest**|  | 

### Return type

**CreateDetectedEventStartingPointPreviewResponse**

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

<a name="createemaileventconfirm"></a>
# **CreateEmailEventConfirm**
> CreateEmailEventConfirmResponse CreateEmailEventConfirm (Guid id, CreateEmailEventConfirmRequest createEmailEventConfirmRequest)

Confirm an email-detected event: re-run it as certain (a possible sale records the sale and delists the item elsewhere). When several listings could be meant, pass platformListingDbId to choose one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailEventConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 
            var createEmailEventConfirmRequest = new CreateEmailEventConfirmRequest(); // CreateEmailEventConfirmRequest | 

            try
            {
                // Confirm an email-detected event: re-run it as certain (a possible sale records the sale and delists the item elsewhere). When several listings could be meant, pass platformListingDbId to choose one.
                CreateEmailEventConfirmResponse result = apiInstance.CreateEmailEventConfirm(id, createEmailEventConfirmRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateEmailEventConfirm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createEmailEventConfirmRequest** | **CreateEmailEventConfirmRequest**|  | 

### Return type

**CreateEmailEventConfirmResponse**

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

<a name="createemaileventdismiss"></a>
# **CreateEmailEventDismiss**
> IdStatusResponse CreateEmailEventDismiss (Guid id)

Dismiss an email-detected event (\"not a sale\"): closes the card without acting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailEventDismissExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Dismiss an email-detected event (\"not a sale\"): closes the card without acting.
                IdStatusResponse result = apiInstance.CreateEmailEventDismiss(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateEmailEventDismiss: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**IdStatusResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createemaileventreprocess"></a>
# **CreateEmailEventReprocess**
> GetEmailEventResponse CreateEmailEventReprocess (Guid id)

Re-process a marketplace email with the current templates (one Crossly did not recognise, could not finish, or ignored). Refused (409) for an email that already changed something, or once its 30-day copy is gone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEmailEventReprocessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Re-process a marketplace email with the current templates (one Crossly did not recognise, could not finish, or ignored). Refused (409) for an email that already changed something, or once its 30-day copy is gone.
                GetEmailEventResponse result = apiInstance.CreateEmailEventReprocess(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateEmailEventReprocess: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetEmailEventResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="createeventpolicydecisionconfirm"></a>
# **CreateEventPolicyDecisionConfirm**
> CreateEventPolicyDecisionConfirmResponse CreateEventPolicyDecisionConfirm (Guid id)

Confirm a review decision from a webhook, order poller or app relay (canConfirm true): the event runs again with the seller confirmed, so a review rule runs the strongest allowed non-review action for that cell. Returns the new decision. 409 when the decision was already confirmed or is not confirmable (email review decisions are confirmed on their review card).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class CreateEventPolicyDecisionConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Confirm a review decision from a webhook, order poller or app relay (canConfirm true): the event runs again with the seller confirmed, so a review rule runs the strongest allowed non-review action for that cell. Returns the new decision. 409 when the decision was already confirmed or is not confirmable (email review decisions are confirmed on their review card).
                CreateEventPolicyDecisionConfirmResponse result = apiInstance.CreateEventPolicyDecisionConfirm(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.CreateEventPolicyDecisionConfirm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**CreateEventPolicyDecisionConfirmResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deletedetectedeventrule"></a>
# **DeleteDetectedEventRule**
> DeleteStoryResponse DeleteDetectedEventRule (string id)

Delete a detection rule. Deleting your edit of a default (its id, or default:<key>) brings the shipped default back; deleting a translated event-policy rule deletes that policy rule too.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteDetectedEventRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a detection rule. Deleting your edit of a default (its id, or default:<key>) brings the shipped default back; deleting a translated event-policy rule deletes that policy rule too.
                DeleteStoryResponse result = apiInstance.DeleteDetectedEventRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.DeleteDetectedEventRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteStoryResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="deleteeventpolicyrule"></a>
# **DeleteEventPolicyRule**
> DeleteStoryResponse DeleteEventPolicyRule (Guid id)

Delete a rule: its cell falls back to the next scope (platform → global → the built-in default).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class DeleteEventPolicyRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a rule: its cell falls back to the next scope (platform → global → the built-in default).
                DeleteStoryResponse result = apiInstance.DeleteEventPolicyRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.DeleteEventPolicyRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**DeleteStoryResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getactionlog"></a>
# **GetActionLog**
> ListActionLogItem GetActionLog (Guid id)

One Activity Log event by id, with `view` including its steps and, for bulk jobs, its children.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One Activity Log event by id, with `view` including its steps and, for bulk jobs, its children.
                ListActionLogItem result = apiInstance.GetActionLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListActionLogItem**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getactionlogexport"></a>
# **GetActionLogExport**
> GetActionLogExportResponse GetActionLogExport (string exportId)

The state of one Activity Log export.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var exportId = "exportId_example";  // string | 

            try
            {
                // The state of one Activity Log export.
                GetActionLogExportResponse result = apiInstance.GetActionLogExport(exportId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLogExport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportId** | **string**|  | 

### Return type

**GetActionLogExportResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getactionlogexportdownload"></a>
# **GetActionLogExportDownload**
> GetActionLogExportDownloadResponse GetActionLogExportDownload (string exportId)

Download a finished Activity Log export (for 24 hours after it completes).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogExportDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var exportId = "exportId_example";  // string | 

            try
            {
                // Download a finished Activity Log export (for 24 hours after it completes).
                GetActionLogExportDownloadResponse result = apiInstance.GetActionLogExportDownload(exportId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLogExportDownload: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportId** | **string**|  | 

### Return type

**GetActionLogExportDownloadResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getactionlogfacet"></a>
# **GetActionLogFacet**
> GetActionLogFacetResponse GetActionLogFacet ()

Filter options of the caller's Activity Log (last 90 days): areas with their actions and counts, the team members who acted, platforms and outcomes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetActionLogFacetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // Filter options of the caller's Activity Log (last 90 days): areas with their actions and counts, the team members who acted, platforms and outcomes.
                GetActionLogFacetResponse result = apiInstance.GetActionLogFacet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActionLogFacet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetActionLogFacetResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getdetectedeventevent"></a>
# **GetDetectedEventEvent**
> GetDetectedEventEventResponse GetDetectedEventEvent (Guid id)

One detected event with every report of it (first + corroborations, with correlation and contradiction), the guards that held actions back, the plan and each executed action's outcome and reversibility.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDetectedEventEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One detected event with every report of it (first + corroborations, with correlation and contradiction), the guards that held actions back, the plan and each executed action's outcome and reversibility.
                GetDetectedEventEventResponse result = apiInstance.GetDetectedEventEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetDetectedEventEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetDetectedEventEventResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getdetectedeventoverview"></a>
# **GetDetectedEventOverview**
> GetDetectedEventOverviewResponse GetDetectedEventOverview ()

What Crossly does today in each situation for the store, computed from the store's real rules the way the engine decides: per situation its topic, title, the outcome in words, the rule ref that decides it, whether it differs from the recommended default, and narrower rules (one marketplace, account or app) that decide it differently there. Also the headline situations per topic, the starting point (hands_on / balanced / hands_off / custom), how many rules are your own and how many events wait for you. The store is X-Storefront-Id (omitted: the default store).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDetectedEventOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // What Crossly does today in each situation for the store, computed from the store's real rules the way the engine decides: per situation its topic, title, the outcome in words, the rule ref that decides it, whether it differs from the recommended default, and narrower rules (one marketplace, account or app) that decide it differently there. Also the headline situations per topic, the starting point (hands_on / balanced / hands_off / custom), how many rules are your own and how many events wait for you. The store is X-Storefront-Id (omitted: the default store).
                GetDetectedEventOverviewResponse result = apiInstance.GetDetectedEventOverview();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetDetectedEventOverview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetDetectedEventOverviewResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getdetectedeventrule"></a>
# **GetDetectedEventRule**
> GetDetectedEventRuleResponse GetDetectedEventRule (string _ref)

One detection rule by its ref: a stored rule's id, or default.<key> for a situation (the store's effective rule for it: your edit when there is one, else the shipped default). Returns the rule, the situation it decides (topic, title, why it is the default), the choice cards offered for that situation (each a complete rule body, the recommended one first) and which card the rule is (custom when none). A retired key (order.notify, account) opens the key it was split into. 404 when the ref names nothing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDetectedEventRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var _ref = "_ref_example";  // string | A stored rule id (uuid), or default.<key> for a situation default (default:<key> also works).

            try
            {
                // One detection rule by its ref: a stored rule's id, or default.<key> for a situation (the store's effective rule for it: your edit when there is one, else the shipped default). Returns the rule, the situation it decides (topic, title, why it is the default), the choice cards offered for that situation (each a complete rule body, the recommended one first) and which card the rule is (custom when none). A retired key (order.notify, account) opens the key it was split into. 404 when the ref names nothing.
                GetDetectedEventRuleResponse result = apiInstance.GetDetectedEventRule(_ref);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetDetectedEventRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_ref** | **string**| A stored rule id (uuid), or default.&lt;key&gt; for a situation default (default:&lt;key&gt; also works). | 

### Return type

**GetDetectedEventRuleResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getdetectedeventstartingpoint"></a>
# **GetDetectedEventStartingPoint**
> GetDetectedEventStartingPointResponse GetDetectedEventStartingPoint ()

The store's starting point: hands_on, balanced (recommended), hands_off, or custom once a default was edited by hand. Preview a change with POST starting-point/preview, apply it with PUT starting-point.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetDetectedEventStartingPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // The store's starting point: hands_on, balanced (recommended), hands_off, or custom once a default was edited by hand. Preview a change with POST starting-point/preview, apply it with PUT starting-point.
                GetDetectedEventStartingPointResponse result = apiInstance.GetDetectedEventStartingPoint();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetDetectedEventStartingPoint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**GetDetectedEventStartingPointResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getemailevent"></a>
# **GetEmailEvent**
> GetEmailEventResponse GetEmailEvent (Guid id)

One marketplace email Crossly read: what it did with it (outcome), the fields the template extracted, and the mailbox it came from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetEmailEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // One marketplace email Crossly read: what it did with it (outcome), the fields the template extracted, and the mailbox it came from.
                GetEmailEventResponse result = apiInstance.GetEmailEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetEmailEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetEmailEventResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="getemaileventpreview"></a>
# **GetEmailEventPreview**
> GetEmailEventPreviewResponse GetEmailEventPreview (Guid id)

A marketplace email's sanitized preview: text only, buyer address lines hidden, links without their query. Crossly keeps each email 30 days; after that this is a 409.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetEmailEventPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // A marketplace email's sanitized preview: text only, buyer address lines hidden, links without their query. Crossly keeps each email 30 days; after that this is a 409.
                GetEmailEventPreviewResponse result = apiInstance.GetEmailEventPreview(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetEmailEventPreview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**GetEmailEventPreviewResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="geteventpolicy"></a>
# **GetEventPolicy**
> GetEventPolicyResponse GetEventPolicy (string platform = null, Guid? appId = null)

What Crossly does with each detected marketplace event (sale, listing ended, offer, cancellation, label, shipped, delivered, refund, return, payout, message), per who owns the item (crossly, imported, app_managed, other_tool, untracked). Each matrix cell lists the allowed actions and the effective one, with the scope it comes from (app > platform > global > default). Pass platform (or appId) to see the matrix as that platform's (or app's) items see it. Also returns the rules, platforms and connected apps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class GetEventPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var platform = "platform_example";  // string |  (optional) 
            var appId = "appId_example";  // Guid? |  (optional) 

            try
            {
                // What Crossly does with each detected marketplace event (sale, listing ended, offer, cancellation, label, shipped, delivered, refund, return, payout, message), per who owns the item (crossly, imported, app_managed, other_tool, untracked). Each matrix cell lists the allowed actions and the effective one, with the scope it comes from (app > platform > global > default). Pass platform (or appId) to see the matrix as that platform's (or app's) items see it. Also returns the rules, platforms and connected apps.
                GetEventPolicyResponse result = apiInstance.GetEventPolicy(platform, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetEventPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **platform** | **string**|  | [optional] 
 **appId** | **Guid?**|  | [optional] 

### Return type

**GetEventPolicyResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listactionlog"></a>
# **ListActionLog**
> ListActionLogResponse ListActionLog (string platform = null, string action = null, string category = null, string area = null, string status = null, string source = null, string targetType = null, string targetId = null, string actorUserId = null, string q = null, DateTime? since = null, DateTime? until = null, DateTime? at = null, string cursor = null, int? limit = null, int? offset = null)

List Activity Log events, newest first. Each event carries `view` (title, sentence, fields, failure advice, who did it) and typed `detail`. Page with `cursor`; `pagination.total` counts matches.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListActionLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var platform = "platform_example";  // string | Platform id (`ebay`, `poshmark`, ...). (optional) 
            var action = "action_example";  // string | A canonical action key (`listing.delist`, see the public action catalog) or a legacy action word. (optional) 
            var category = "category_example";  // string |  (optional) 
            var area = "listings";  // string | A seller area: every action of that area (the grouped filter of the dashboard). (optional) 
            var status = "pending";  // string |  (optional) 
            var source = "source_example";  // string |  (optional) 
            var targetType = "targetType_example";  // string | With targetId: events about that object (any of their targets). (optional) 
            var targetId = "targetId_example";  // string |  (optional) 
            var actorUserId = "actorUserId_example";  // string | Only what one team member did. (optional) 
            var q = "q_example";  // string | A search in the activity query language (`action:listing.* -outcome:failure \"free text\"`), ANDed with the other filters. POST /api/v1/action-log/search/translate turns a question in words into one. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Inclusive lower bound on when the action happened. (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Exclusive upper bound. (optional) 
            var at = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Jump to a time: the page starts at the newest event at or before it. (optional) 
            var cursor = "cursor_example";  // string | `pagination.nextCursor` of the previous page. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var offset = 56;  // int? | Deprecated: use cursor. offset + limit may reach at most 1000 events. (optional) 

            try
            {
                // List Activity Log events, newest first. Each event carries `view` (title, sentence, fields, failure advice, who did it) and typed `detail`. Page with `cursor`; `pagination.total` counts matches.
                ListActionLogResponse result = apiInstance.ListActionLog(platform, action, category, area, status, source, targetType, targetId, actorUserId, q, since, until, at, cursor, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListActionLog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **platform** | **string**| Platform id (&#x60;ebay&#x60;, &#x60;poshmark&#x60;, ...). | [optional] 
 **action** | **string**| A canonical action key (&#x60;listing.delist&#x60;, see the public action catalog) or a legacy action word. | [optional] 
 **category** | **string**|  | [optional] 
 **area** | **string**| A seller area: every action of that area (the grouped filter of the dashboard). | [optional] 
 **status** | **string**|  | [optional] 
 **source** | **string**|  | [optional] 
 **targetType** | **string**| With targetId: events about that object (any of their targets). | [optional] 
 **targetId** | **string**|  | [optional] 
 **actorUserId** | **string**| Only what one team member did. | [optional] 
 **q** | **string**| A search in the activity query language (&#x60;action:listing.* -outcome:failure \&quot;free text\&quot;&#x60;), ANDed with the other filters. POST /api/v1/action-log/search/translate turns a question in words into one. | [optional] 
 **since** | **DateTime?**| Inclusive lower bound on when the action happened. | [optional] 
 **until** | **DateTime?**| Exclusive upper bound. | [optional] 
 **at** | **DateTime?**| Jump to a time: the page starts at the newest event at or before it. | [optional] 
 **cursor** | **string**| &#x60;pagination.nextCursor&#x60; of the previous page. | [optional] 
 **limit** | **int?**|  | [optional] [default to 50]
 **offset** | **int?**| Deprecated: use cursor. offset + limit may reach at most 1000 events. | [optional] 

### Return type

**ListActionLogResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listactionlogcalls"></a>
# **ListActionLogCalls**
> ListActionLogCallsResponse ListActionLogCalls (Guid id)

The outbound platform HTTP calls under an event (oldest first) — platform, operation, method, host, status, latency, error class/message, proxy + recipe id. Answers \"what was sent / what went wrong\". The URL path, request/response bodies and persisted-query hash are never returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListActionLogCallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // The outbound platform HTTP calls under an event (oldest first) — platform, operation, method, host, status, latency, error class/message, proxy + recipe id. Answers \"what was sent / what went wrong\". The URL path, request/response bodies and persisted-query hash are never returned.
                ListActionLogCallsResponse result = apiInstance.ListActionLogCalls(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListActionLogCalls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

**ListActionLogCallsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listactionloghistogram"></a>
# **ListActionLogHistogram**
> ListActionLogHistogramResponse ListActionLogHistogram (string platform = null, string action = null, string category = null, string area = null, string status = null, string source = null, string targetType = null, string targetId = null, string actorUserId = null, string q = null, DateTime? since = null, DateTime? until = null)

Events per UTC day for the list filters (default: the last 30 days; at most 366).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListActionLogHistogramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var platform = "platform_example";  // string | Platform id (`ebay`, `poshmark`, ...). (optional) 
            var action = "action_example";  // string | A canonical action key (`listing.delist`, see the public action catalog) or a legacy action word. (optional) 
            var category = "category_example";  // string |  (optional) 
            var area = "listings";  // string | A seller area: every action of that area (the grouped filter of the dashboard). (optional) 
            var status = "pending";  // string |  (optional) 
            var source = "source_example";  // string |  (optional) 
            var targetType = "targetType_example";  // string | With targetId: events about that object (any of their targets). (optional) 
            var targetId = "targetId_example";  // string |  (optional) 
            var actorUserId = "actorUserId_example";  // string | Only what one team member did. (optional) 
            var q = "q_example";  // string | A search in the activity query language (`action:listing.* -outcome:failure \"free text\"`), ANDed with the other filters. POST /api/v1/action-log/search/translate turns a question in words into one. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Inclusive lower bound on when the action happened. (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Exclusive upper bound. (optional) 

            try
            {
                // Events per UTC day for the list filters (default: the last 30 days; at most 366).
                ListActionLogHistogramResponse result = apiInstance.ListActionLogHistogram(platform, action, category, area, status, source, targetType, targetId, actorUserId, q, since, until);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListActionLogHistogram: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **platform** | **string**| Platform id (&#x60;ebay&#x60;, &#x60;poshmark&#x60;, ...). | [optional] 
 **action** | **string**| A canonical action key (&#x60;listing.delist&#x60;, see the public action catalog) or a legacy action word. | [optional] 
 **category** | **string**|  | [optional] 
 **area** | **string**| A seller area: every action of that area (the grouped filter of the dashboard). | [optional] 
 **status** | **string**|  | [optional] 
 **source** | **string**|  | [optional] 
 **targetType** | **string**| With targetId: events about that object (any of their targets). | [optional] 
 **targetId** | **string**|  | [optional] 
 **actorUserId** | **string**| Only what one team member did. | [optional] 
 **q** | **string**| A search in the activity query language (&#x60;action:listing.* -outcome:failure \&quot;free text\&quot;&#x60;), ANDed with the other filters. POST /api/v1/action-log/search/translate turns a question in words into one. | [optional] 
 **since** | **DateTime?**| Inclusive lower bound on when the action happened. | [optional] 
 **until** | **DateTime?**| Exclusive upper bound. | [optional] 

### Return type

**ListActionLogHistogramResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listdetectedeventevents"></a>
# **ListDetectedEventEvents**
> ListDetectedEventEventsResponse ListDetectedEventEvents (string kinds = null, string platforms = null, string accounts = null, string statuses = null, string channels = null, Guid? itemId = null, Guid? listingId = null, Guid? orderId = null, string ruleId = null, string ownership = null, DateTime? since = null, string cursor = null, int? limit = null)

Every event Crossly detected (sales, order changes, listing changes, offers, messages, account notices), newest first: all its axes, the rule that decided it, its corroborating reports, the plan per target and how each action went, with canConfirm (an open ask) and canUndo. Cursor-paged; filter by kinds, platforms, statuses, accounts and channels (comma-separated), one item, listing, order or deciding rule, and since (ISO time). statuses=asked is what waits for you; dismissed is an ask closed without acting. Rows from before the rules update carry legacy: true and have no actions. Per store: X-Storefront-Id (omitted: the default store, which also keeps events recorded before stores existed).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDetectedEventEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var kinds = "kinds_example";  // string |  (optional) 
            var platforms = "platforms_example";  // string |  (optional) 
            var accounts = "accounts_example";  // string | Comma-separated platform account ids (scope.account). (optional) 
            var statuses = "statuses_example";  // string | Comma-separated: acted, held, asked, confirmed, ignored, undone, failed, received, corrected, dismissed (optional) 
            var channels = "channels_example";  // string | Comma-separated, how it was reported: platform_webhook, platform_poll, cookie_poll, health_probe, listing_discovery, app_push, email, extension, manual (optional) 
            var itemId = "itemId_example";  // Guid? | Only events about this inventory item. (optional) 
            var listingId = "listingId_example";  // Guid? | Only events about this platform listing. (optional) 
            var orderId = "orderId_example";  // Guid? | Only events about this order. (optional) 
            var ruleId = "ruleId_example";  // string | Only events this rule decided (a rule id, or default:<key>). (optional) 
            var ownership = "ownership_example";  // string | Comma-separated, who manages the item (crossly, imported, app_managed, other_tool, untracked). (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Every event Crossly detected (sales, order changes, listing changes, offers, messages, account notices), newest first: all its axes, the rule that decided it, its corroborating reports, the plan per target and how each action went, with canConfirm (an open ask) and canUndo. Cursor-paged; filter by kinds, platforms, statuses, accounts and channels (comma-separated), one item, listing, order or deciding rule, and since (ISO time). statuses=asked is what waits for you; dismissed is an ask closed without acting. Rows from before the rules update carry legacy: true and have no actions. Per store: X-Storefront-Id (omitted: the default store, which also keeps events recorded before stores existed).
                ListDetectedEventEventsResponse result = apiInstance.ListDetectedEventEvents(kinds, platforms, accounts, statuses, channels, itemId, listingId, orderId, ruleId, ownership, since, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListDetectedEventEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kinds** | **string**|  | [optional] 
 **platforms** | **string**|  | [optional] 
 **accounts** | **string**| Comma-separated platform account ids (scope.account). | [optional] 
 **statuses** | **string**| Comma-separated: acted, held, asked, confirmed, ignored, undone, failed, received, corrected, dismissed | [optional] 
 **channels** | **string**| Comma-separated, how it was reported: platform_webhook, platform_poll, cookie_poll, health_probe, listing_discovery, app_push, email, extension, manual | [optional] 
 **itemId** | **Guid?**| Only events about this inventory item. | [optional] 
 **listingId** | **Guid?**| Only events about this platform listing. | [optional] 
 **orderId** | **Guid?**| Only events about this order. | [optional] 
 **ruleId** | **string**| Only events this rule decided (a rule id, or default:&lt;key&gt;). | [optional] 
 **ownership** | **string**| Comma-separated, who manages the item (crossly, imported, app_managed, other_tool, untracked). | [optional] 
 **since** | **DateTime?**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

**ListDetectedEventEventsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listdetectedeventrules"></a>
# **ListDetectedEventRules**
> ListDetectedEventRulesResponse ListDetectedEventRules ()

The seller's detection rules, top-down in the order they are evaluated (first match wins unless a rule says continue): the seller's own rules, translations of their event-policy rules (source legacy), then the shipped default set (source default, ids default:<key>; a stored edit of a default replaces it). Each rule has a filter (event kinds, platforms, accounts, apps, tags, items), an optional condition over any event axis, the actions it runs (then / else) and its guard loosenings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDetectedEventRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // The seller's detection rules, top-down in the order they are evaluated (first match wins unless a rule says continue): the seller's own rules, translations of their event-policy rules (source legacy), then the shipped default set (source default, ids default:<key>; a stored edit of a default replaces it). Each rule has a filter (event kinds, platforms, accounts, apps, tags, items), an optional condition over any event axis, the actions it runs (then / else) and its guard loosenings.
                ListDetectedEventRulesResponse result = apiInstance.ListDetectedEventRules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListDetectedEventRules: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListDetectedEventRulesResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listdetectedeventsituations"></a>
# **ListDetectedEventSituations**
> ListDetectedEventSituationsResponse ListDetectedEventSituations ()

Every situation Crossly decides (a sale of an item in Crossly, a sale not in Crossly with no match, a return opened, a connection lost…), grouped by topic (sales, orders, listings, buyers, account): its title, whether it is a headline row of the Overview, why the default is what it is, its rule ref (default.<key>) and the choice cards offered for it. To pick a card, PUT its body to the rule default:<key>. The same catalog for every seller; GET overview says what each does today.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListDetectedEventSituationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);

            try
            {
                // Every situation Crossly decides (a sale of an item in Crossly, a sale not in Crossly with no match, a return opened, a connection lost…), grouped by topic (sales, orders, listings, buyers, account): its title, whether it is a headline row of the Overview, why the default is what it is, its rule ref (default.<key>) and the choice cards offered for it. To pick a card, PUT its body to the rule default:<key>. The same catalog for every seller; GET overview says what each does today.
                ListDetectedEventSituationsResponse result = apiInstance.ListDetectedEventSituations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListDetectedEventSituations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**ListDetectedEventSituationsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listemailevents"></a>
# **ListEmailEvents**
> ListEmailEventsResponse ListEmailEvents (string status = null)

List email-detected events waiting for the seller (status=needs_review): a possible sale, ended listing, cancellation or other event an email reported that was not certain enough to act on automatically.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListEmailEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var status = "needs_review";  // string |  (optional)  (default to needs_review)

            try
            {
                // List email-detected events waiting for the seller (status=needs_review): a possible sale, ended listing, cancellation or other event an email reported that was not certain enough to act on automatically.
                ListEmailEventsResponse result = apiInstance.ListEmailEvents(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListEmailEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**|  | [optional] [default to needs_review]

### Return type

**ListEmailEventsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="listeventpolicydecisions"></a>
# **ListEventPolicyDecisions**
> ListEventPolicyDecisionsResponse ListEventPolicyDecisions (string cursor = null, int? limit = null, string _event = null, string ownership = null, string platform = null, string outcome = null)

The decision log, newest first: for each detected event, what the rule or default asked for, what was done (after capability fallback and the email confidence ceiling), the rule that decided it, and the outcome (done / skipped / failed / review). Cursor-paged; filter by event, ownership, platform or outcome (outcome=review: still waiting for the seller). Kept 90 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class ListEventPolicyDecisionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var cursor = "cursor_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var _event = "sale";  // string |  (optional) 
            var ownership = "crossly";  // string |  (optional) 
            var platform = "platform_example";  // string |  (optional) 
            var outcome = "done";  // string |  (optional) 

            try
            {
                // The decision log, newest first: for each detected event, what the rule or default asked for, what was done (after capability fallback and the email confidence ceiling), the rule that decided it, and the outcome (done / skipped / failed / review). Cursor-paged; filter by event, ownership, platform or outcome (outcome=review: still waiting for the seller). Kept 90 days.
                ListEventPolicyDecisionsResponse result = apiInstance.ListEventPolicyDecisions(cursor, limit, _event, ownership, platform, outcome);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.ListEventPolicyDecisions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cursor** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **_event** | **string**|  | [optional] 
 **ownership** | **string**|  | [optional] 
 **platform** | **string**|  | [optional] 
 **outcome** | **string**|  | [optional] 

### Return type

**ListEventPolicyDecisionsResponse**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Error |  -  |
| **403** | Error |  -  |
| **404** | Error |  -  |
| **429** | Error |  -  |
| **500** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

<a name="updatedetectedeventrule"></a>
# **UpdateDetectedEventRule**
> CreateDetectedEventRuleResponse UpdateDetectedEventRule (string id, CreateDetectedEventRuleRequest createDetectedEventRuleRequest)

Replace a detection rule. An id default:<key> stores your edit of that shipped default (delete it, or reset-defaults, to go back to the shipped one).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDetectedEventRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var id = "id_example";  // string | 
            var createDetectedEventRuleRequest = new CreateDetectedEventRuleRequest(); // CreateDetectedEventRuleRequest | 

            try
            {
                // Replace a detection rule. An id default:<key> stores your edit of that shipped default (delete it, or reset-defaults, to go back to the shipped one).
                CreateDetectedEventRuleResponse result = apiInstance.UpdateDetectedEventRule(id, createDetectedEventRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.UpdateDetectedEventRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **createDetectedEventRuleRequest** | **CreateDetectedEventRuleRequest**|  | 

### Return type

**CreateDetectedEventRuleResponse**

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

<a name="updatedetectedeventstartingpoint"></a>
# **UpdateDetectedEventStartingPoint**
> GetDetectedEventStartingPointResponse UpdateDetectedEventStartingPoint (UpdateDetectedEventStartingPointRequest updateDetectedEventStartingPointRequest)

Apply a starting point to the store: rewrites the store's untouched default rules as ordinary rules (balanced removes them, so the shipped defaults apply). Defaults you edited and your own rules stay as they are; starting points do not stack. Logged to Activity. Returns the starting point now in effect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateDetectedEventStartingPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var updateDetectedEventStartingPointRequest = new UpdateDetectedEventStartingPointRequest(); // UpdateDetectedEventStartingPointRequest | 

            try
            {
                // Apply a starting point to the store: rewrites the store's untouched default rules as ordinary rules (balanced removes them, so the shipped defaults apply). Defaults you edited and your own rules stay as they are; starting points do not stack. Logged to Activity. Returns the starting point now in effect.
                GetDetectedEventStartingPointResponse result = apiInstance.UpdateDetectedEventStartingPoint(updateDetectedEventStartingPointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.UpdateDetectedEventStartingPoint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateDetectedEventStartingPointRequest** | **UpdateDetectedEventStartingPointRequest**|  | 

### Return type

**GetDetectedEventStartingPointResponse**

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

<a name="updateeventpolicyrule"></a>
# **UpdateEventPolicyRule**
> UpdateEventPolicyRuleResponse UpdateEventPolicyRule (UpdateEventPolicyRuleRequest updateEventPolicyRuleRequest)

Set what Crossly does with one kind of detected event for one kind of item: scope global (scopeValue null), platform (scopeValue = platform id) or app (scopeValue = OAuth app id, app_managed items only). Replaces the rule for the same cell and scope. The action must be one the matrix allows for that cell; import actions exist only for untracked items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using net.crossly.Api;
using net.crossly.Client;
using net.crossly.Model;

namespace Example
{
    public class UpdateEventPolicyRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://crossly.net/api";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivityApi(config);
            var updateEventPolicyRuleRequest = new UpdateEventPolicyRuleRequest(); // UpdateEventPolicyRuleRequest | 

            try
            {
                // Set what Crossly does with one kind of detected event for one kind of item: scope global (scopeValue null), platform (scopeValue = platform id) or app (scopeValue = OAuth app id, app_managed items only). Replaces the rule for the same cell and scope. The action must be one the matrix allows for that cell; import actions exist only for untracked items.
                UpdateEventPolicyRuleResponse result = apiInstance.UpdateEventPolicyRule(updateEventPolicyRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.UpdateEventPolicyRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateEventPolicyRuleRequest** | **UpdateEventPolicyRuleRequest**|  | 

### Return type

**UpdateEventPolicyRuleResponse**

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

