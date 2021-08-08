using System;
using Newtonsoft.Json;

namespace Rajora.GoldPass
{
    public class CurrentSeasonGoldpass : BaseJsonModel
    {
        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset EndTime { get; set; }
    }
}