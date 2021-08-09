using System;
using Newtonsoft.Json;

namespace Rajora
{
    public class ClanWarLeagueGroup
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("state")]
        public ClanWarState State { get; set; }

        [JsonProperty("season")]
        public DateTimeOffset? Season { get; set; }

        [JsonProperty("clans")]
        public ClanWarLeagueClan[] Clans { get; set; }

        [JsonProperty("rounds")]
        public ClanWarLeagueRound[] Rounds { get; set; }
    }
}