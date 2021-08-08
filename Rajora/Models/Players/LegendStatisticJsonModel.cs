using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LegendStatisticJsonModel
    {
        [JsonProperty("currentSeason")]
        public LegendLeagueTournamentSeasonResultJsonModel CurrentSeason { get; set; }

        [JsonProperty("previousVersusSeason")]
        public LegendLeagueTournamentSeasonResultJsonModel PreviousVersusSeason { get; set; }

        [JsonProperty("bestVersusSeason")]
        public LegendLeagueTournamentSeasonResultJsonModel BestVersusSeason { get; set; }

        [JsonProperty("bestSeason")]
        public LegendLeagueTournamentSeasonResultJsonModel BestSeason { get; set; }

        [JsonProperty("previousSeason")]
        public LegendLeagueTournamentSeasonResultJsonModel PreviousSeason { get; set; }

        [JsonProperty("legendTrophies")]
        public int LegendTrophies { get; set; }
    }
}