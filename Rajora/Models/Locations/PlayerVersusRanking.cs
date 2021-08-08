using Newtonsoft.Json;

namespace Rajora
{
    public class PlayerVersusRanking : BaseJsonModel
    {
        [JsonProperty("clan")]
        public PartialClan Clan { get; set; }

        [JsonProperty("versusBattleWins")]
        public int VersusBattleWins { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("previousRank")]
        public int PreviousRank { get; set; }

        [JsonProperty("versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}