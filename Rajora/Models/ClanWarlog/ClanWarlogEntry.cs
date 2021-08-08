using System;
using Newtonsoft.Json;

namespace Rajora
{
    public class ClanWarlogEntry : BaseJsonModel
    {
        [JsonProperty("clan")]
        public WarlogClan Clan { get; set; }

        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }

        [JsonProperty("opponent")]
        public WarlogClan Opponent { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("result")]
        public WarlogResult Result { get; set; }
    }
}