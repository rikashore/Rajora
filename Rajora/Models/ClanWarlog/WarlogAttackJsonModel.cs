using Newtonsoft.Json;

namespace Rajora.Models
{
    public class WarlogAttackJsonModel
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("attackerTag")]
        public string AttackerTag { get; set; }

        [JsonProperty("defenderTag")]
        public string DefenderTag { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("destructionPercentage")]
        public int DestructionPercentage { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}