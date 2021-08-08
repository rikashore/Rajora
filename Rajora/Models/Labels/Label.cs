using Newtonsoft.Json;

namespace Rajora
{
    public class Label
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iconUrls")]
        public LabelIcon IconUrls { get; set; }
    }
}