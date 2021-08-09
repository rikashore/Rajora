using System;
using Newtonsoft.Json;

namespace Rajora
{
    public class ClanCurrentWar
    {
        [JsonProperty("clan")]
        public WarlogClan Clan { get; set; }

        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }

        [JsonProperty("opponent")]
        public WarlogClan Opponent { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("preparationStartTime")]
        public DateTimeOffset PreparationStartTime { get; set; }
    }
}