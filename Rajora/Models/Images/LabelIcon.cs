using Newtonsoft.Json;

namespace Rajora
{
    public class LabelIcon
    {
        [JsonProperty("tiny")]
        public string Tiny { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }
    }
}