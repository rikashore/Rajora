using Newtonsoft.Json;

namespace Rajora.Models
{
    public class PlayerTokenVerificationJsonModel : BaseJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}