using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LabelIconJsonModel
    {
        [JsonProperty("tiny")]
        public string Tiny { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }
    }
}