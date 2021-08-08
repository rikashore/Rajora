using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ChatLanguageJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }
    }
}