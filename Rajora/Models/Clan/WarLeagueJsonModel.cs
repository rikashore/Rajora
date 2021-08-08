using Newtonsoft.Json;

namespace Rajora.Models
{
    public class WarLeagueJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}