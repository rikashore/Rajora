using Newtonsoft.Json;

namespace Rajora.Models
{
    public class AchievementJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("completionInfo")]
        public string CompletionInfo { get; set; }

        [JsonProperty("village")]
        public string Village { get; set; }
    }
}