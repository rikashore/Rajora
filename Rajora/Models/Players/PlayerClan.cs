using Newtonsoft.Json;

namespace Rajora
{
    public class PlayerClan
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("badgeUrls")]
        public Badge BadgeUrls { get; set; }
    }
}