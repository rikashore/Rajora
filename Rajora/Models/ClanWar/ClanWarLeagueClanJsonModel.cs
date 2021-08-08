using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanWarLeagueClanJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public ClanWarLeagueClanMemberJsonModel[] Members { get; set; }

        [JsonProperty("badgeUrls")]
        public BadgeJsonModel BadgeUrls { get; set; }
    }
}