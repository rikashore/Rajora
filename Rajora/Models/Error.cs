using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rajora
{
    public class Error
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object")]
        public JObject Object { get; set; }
    }
}