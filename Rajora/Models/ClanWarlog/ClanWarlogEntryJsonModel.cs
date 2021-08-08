using System;
using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanWarlogEntryJsonModel : BaseJsonModel
    {
        [JsonProperty("clan")]
        public WarlogClanJsonModel Clan { get; set; }

        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }

        [JsonProperty("opponent")]
        public WarlogClanJsonModel Opponent { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("result")]
        public WarlogResult Result { get; set; }
    }
}