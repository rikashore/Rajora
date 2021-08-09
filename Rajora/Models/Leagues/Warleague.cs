using Newtonsoft.Json;

namespace Rajora
{
    public class Warleague
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}