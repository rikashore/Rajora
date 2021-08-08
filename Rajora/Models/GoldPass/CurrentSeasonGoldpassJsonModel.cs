using System;
using Newtonsoft.Json;

namespace Rajora.Models.GoldPass
{
    public class CurrentSeasonGoldpassJsonModel : BaseJsonModel
    {
        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset EndTime { get; set; }
    }
}