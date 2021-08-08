using Newtonsoft.Json;

namespace Rajora.Models
{
    public class PartialClanJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("badgeUrls")]
        public BadgeJsonModel BadgeUrls { get; set; }
    }
}