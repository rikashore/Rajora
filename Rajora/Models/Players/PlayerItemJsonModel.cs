using Newtonsoft.Json;

namespace Rajora.Models
{
    public class PlayerItemJsonModel
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