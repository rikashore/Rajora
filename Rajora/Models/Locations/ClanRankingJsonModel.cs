using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanRankingJsonModel : BaseJsonModel
    {
        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }

        [JsonProperty("location")]
        public LocationJsonModel Location { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("previousRank")]
        public int PreviousRank { get; set; }

        [JsonProperty("badgeUrls")]
        public BadgeJsonModel BadgeUrls { get; set; }
    }
}