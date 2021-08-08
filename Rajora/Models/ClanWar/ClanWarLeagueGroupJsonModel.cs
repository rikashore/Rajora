using System;
using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanWarLeagueGroupJsonModel : BaseJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("state")]
        public ClanWarState State { get; set; }

        [JsonProperty("season")]
        public DateTimeOffset? Season { get; set; }

        [JsonProperty("clans")]
        public ClanWarLeagueClanJsonModel[] Clans { get; set; }

        [JsonProperty("rounds")]
        public ClanWarLeagueRoundJsonModel[] Rounds { get; set; }
    }
}