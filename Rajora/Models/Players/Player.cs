using Newtonsoft.Json;

namespace Rajora
{
    public class Player : BaseJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }

        [JsonProperty("expLevel")]
        public int ExpLevel { get; set; }

        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        [JsonProperty("bestTrophies")]
        public int BestTrophies { get; set; }

        [JsonProperty("warStars")]
        public int WarStars { get; set; }

        [JsonProperty("attackWins")]
        public int AttackWins { get; set; }

        [JsonProperty("defenseWins")]
        public int DefenseWins { get; set; }

        [JsonProperty("builderHallLevel")]
        public int BuilderHallLevel { get; set; }

        [JsonProperty("versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonProperty("bestVersusTrophies")]
        public int BestVersusTrophies { get; set; }

        [JsonProperty("versusBattleWins")]
        public int VersusBattleWins { get; set; }

        [JsonProperty("role")]
        public PlayerRole Role { get; set; }

        [JsonProperty("donations")]
        public int Donations { get; set; }

        [JsonProperty("donationsReceived")]
        public int DonationsReceived { get; set; }

        [JsonProperty("clan")]
        public PlayerClan Clan { get; set; }

        [JsonProperty("achievements")]
        public Achievement[] Achievements { get; set; }

        [JsonProperty("labels")]
        public Label Labels { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("legendStatistics")]
        public LegendStatistic LegendStatistics { get; set; }

        [JsonProperty("troops")]
        public PlayerItem[] Troops { get; set; }

        [JsonProperty("heroes")]
        public PlayerItem[] Heroes { get; set; }

        [JsonProperty("spells")]
        public PlayerItem[] Spells { get; set; }
    }
}
