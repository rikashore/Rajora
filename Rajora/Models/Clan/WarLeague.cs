using Newtonsoft.Json;

namespace Rajora
{
    public class WarLeague
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}