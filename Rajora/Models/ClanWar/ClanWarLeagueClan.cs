using Newtonsoft.Json;

namespace Rajora
{
    public class ClanWarLeagueClan
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public ClanWarLeagueClanMember[] Members { get; set; }

        [JsonProperty("badgeUrls")]
        public Badge BadgeUrls { get; set; }
    }
}