using Newtonsoft.Json;

namespace Rajora.Models
{
    public class BadgeJsonModel
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }
}