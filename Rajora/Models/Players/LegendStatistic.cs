using Newtonsoft.Json;

namespace Rajora
{
    public class LegendStatistic
    {
        [JsonProperty("currentSeason")]
        public LegendLeagueTournamentSeasonResult CurrentSeason { get; set; }

        [JsonProperty("previousVersusSeason")]
        public LegendLeagueTournamentSeasonResult PreviousVersusSeason { get; set; }

        [JsonProperty("bestVersusSeason")]
        public LegendLeagueTournamentSeasonResult BestVersusSeason { get; set; }

        [JsonProperty("bestSeason")]
        public LegendLeagueTournamentSeasonResult BestSeason { get; set; }

        [JsonProperty("previousSeason")]
        public LegendLeagueTournamentSeasonResult PreviousSeason { get; set; }

        [JsonProperty("legendTrophies")]
        public int LegendTrophies { get; set; }
    }
}