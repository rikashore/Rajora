﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Rajora.Extensions;

namespace Rajora
{
    public partial class RajoraClient
    {
        private async Task<T> GetAsync<T>(Uri route, IDictionary<string, object> queryParams = null)
            where T : BaseJsonModel
        {
            if (queryParams is not null)
                route.AddQueryParams(queryParams);

            var res = await _httpClient.GetAsync(route);

            using var content = res.Content;
            var s = await content.ReadAsStreamAsync();
            return s.DeserializeTo<T>();
        }

        private async Task<T> PostAsync<T>(Uri route, string payload)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, route)
            {
                Content = new StringContent(payload)
            };

            var res = await _httpClient.SendAsync(message);

            using var content = res.Content;
            var s = await content.ReadAsStreamAsync();
            return s.DeserializeTo<T>();
        }
    }
}