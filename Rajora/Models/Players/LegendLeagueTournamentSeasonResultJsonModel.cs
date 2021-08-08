using System;
using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LegendLeagueTournamentSeasonResultJsonModel
    {
        [JsonProperty("trophies")]
        public int Trophies { get; set; }

        [JsonProperty("id")]
        public DateTimeOffset Id { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}