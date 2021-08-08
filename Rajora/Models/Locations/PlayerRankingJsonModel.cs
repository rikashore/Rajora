using Newtonsoft.Json;

namespace Rajora.Models
{
    public class PlayerRankingJsonModel : BaseJsonModel
    {
        [JsonProperty("league")]
        public LeagueJsonModel League { get; set; }

        [JsonProperty("clan")]
        public PlayerRankingClanJsonModel Clan { get; set; }

        [JsonProperty("attackWins")]
        public int AttackWins { get; set; }

        [JsonProperty("defenseWins")]
        public int DefenseWins { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("previousRank")]
        public int PreviousRank { get; set; }

        [JsonProperty("expLevel")]
        public int ExpLevel { get; set; }

        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}