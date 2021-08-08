using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Rajora
{
    public partial class RajoraClient
    {
        private readonly HttpClient _httpClient;

        public string AuthToken { get; }

        public RajoraClient(string authToken)
        {
            AuthToken = authToken;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.clashofclans.com/v1/")
            };

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
        }
    }
}