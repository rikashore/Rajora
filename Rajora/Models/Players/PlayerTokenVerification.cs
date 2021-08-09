using Newtonsoft.Json;

namespace Rajora
{
    public class PlayerTokenVerification
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}