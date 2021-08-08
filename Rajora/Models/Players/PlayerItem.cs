using Newtonsoft.Json;

namespace Rajora
{
    public class PlayerItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonProperty("village")]
        public string Village { get; set; }
    }
}