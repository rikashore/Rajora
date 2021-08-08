using Newtonsoft.Json;

namespace Rajora
{
    public class ChatLanguage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }
    }
}