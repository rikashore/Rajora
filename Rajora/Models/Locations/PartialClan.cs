using Newtonsoft.Json;

namespace Rajora
{
    public class PartialClan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("badgeUrls")]
        public Badge BadgeUrls { get; set; }
    }
}