using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Crossly
{
    /// <summary>
    /// Auto-pagination over Crossly list endpoints, which all answer <c>{ data, pagination }</c> and page with
    /// <c>page</c> (1-based) and <c>limit</c>.
    /// </summary>
    /// <remarks>
    /// Pages are fetched lazily, one request per page, as the enumeration reaches them. It stops at
    /// <c>pagination.totalPages</c>; when the response carries no pagination the endpoint returned everything in one
    /// page; when it carries pagination without a total, a short page is the last one.
    /// <code>
    /// await foreach (var item in CrosslyPages.AllAsync((page, limit) => listings.ListListingsAsync(page, limit), r => r.Data))
    /// </code>
    /// </remarks>
    public static class CrosslyPages
    {
        /// <summary>The default page size: the API's own default, and inside every list endpoint's maximum.</summary>
        public const int DefaultLimit = 25;

        /// <summary>Every item, fetching each page asynchronously when the enumeration reaches it.</summary>
        public static async IAsyncEnumerable<TItem> AllAsync<TResponse, TItem>(
            Func<int, int, Task<TResponse>> fetch,
            Func<TResponse, IEnumerable<TItem>?> items,
            int limit = DefaultLimit,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            if (limit < 1) throw new ArgumentOutOfRangeException(nameof(limit), "limit must be >= 1");
            for (var page = 1; ; page++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var response = await fetch(page, limit).ConfigureAwait(false);
                var count = 0;
                foreach (var item in items(response) ?? Array.Empty<TItem>())
                {
                    count++;
                    yield return item;
                }
                if (IsLast(response, page, count, limit)) yield break;
            }
        }

        /// <summary>Every item, fetching each page synchronously when the enumeration reaches it.</summary>
        public static IEnumerable<TItem> All<TResponse, TItem>(
            Func<int, int, TResponse> fetch,
            Func<TResponse, IEnumerable<TItem>?> items,
            int limit = DefaultLimit)
        {
            if (limit < 1) throw new ArgumentOutOfRangeException(nameof(limit), "limit must be >= 1");
            return Iterate(fetch, items, limit);
        }

        private static IEnumerable<TItem> Iterate<TResponse, TItem>(
            Func<int, int, TResponse> fetch, Func<TResponse, IEnumerable<TItem>?> items, int limit)
        {
            for (var page = 1; ; page++)
            {
                var response = fetch(page, limit);
                var count = 0;
                foreach (var item in items(response) ?? Array.Empty<TItem>())
                {
                    count++;
                    yield return item;
                }
                if (IsLast(response, page, count, limit)) yield break;
            }
        }

        /// <summary>Whether <paramref name="page"/>, which returned <paramref name="count"/> items, was the last.</summary>
        public static bool IsLast(object? response, int page, int count, int limit)
        {
            var pagination = Property(response, "Pagination");
            if (pagination == null || count == 0) return true;
            var totalPages = Property(pagination, "TotalPages");
            if (totalPages != null) return page >= Convert.ToInt32(totalPages, System.Globalization.CultureInfo.InvariantCulture);
            var pageLimit = Property(pagination, "Limit");
            return count < (pageLimit != null ? Convert.ToInt32(pageLimit, System.Globalization.CultureInfo.InvariantCulture) : limit);
        }

        private static object? Property(object? target, string name) =>
            target?.GetType().GetProperty(name)?.GetValue(target);
    }
}
