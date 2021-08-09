using System;
using Newtonsoft.Json;

namespace Rajora
{
    public class CurrentSeasonGoldpass
    {
        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset EndTime { get; set; }
    }
}