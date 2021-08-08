using Newtonsoft.Json;

namespace Rajora.Models
{
    public class PlayerRankingClanJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("badgeUrls")]
        public BadgeJsonModel BadgeUrls { get; set; }
    }
}