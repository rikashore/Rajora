using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace Rajora.Extensions
{
    internal static class Extensions
    {
        internal static Uri FormatUri(this string s, params object[] args)
            => new Uri(string.Format(s, args), UriKind.Relative);

        internal static Uri AddQueryParams(this Uri uri, IDictionary<string, object> queries)
        {
            var builder = new UriBuilder(uri);

            var queryParams = queries.Select(pair =>
                $"{WebUtility.UrlEncode(pair.Key)}={WebUtility.UrlEncode(pair.Value.ToString())}");

            var query = string.Join("&", queryParams);

            builder.Query = uri.Query.Length > 1
                ? $"{uri.Query.Substring(1)}&{query}"
                : builder.Query = query;

            return builder.Uri;
        }

        internal static T DeserializeTo<T>(this Stream s)
        {
            using var reader = new StreamReader(s);
            using var jsonTextReader = new JsonTextReader(reader);
            var ser = new JsonSerializer();
            return ser.Deserialize<T>(jsonTextReader);
        }
    }
}