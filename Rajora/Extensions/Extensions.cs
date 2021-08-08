using System;
using System.Collections.Generic;

namespace Rajora.Extensions
{
    internal static class Extensions
    {
        internal static Uri FormatUri(this string s, params object[] args)
            => new Uri(new Uri("https://api.clashofclans.com/v1"), new Uri(string.Format(s, args), UriKind.Relative));

        internal static Uri AddQueryParams(this Uri uri, IDictionary<string, object> queries)
        {
            var builder = new UriBuilder(uri);

            foreach (var (key, value) in queries)
                builder.Query += $"{key}={value}";

            return builder.Uri;
        }
    }
}