using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LocationJsonModel : BaseJsonModel
    {
        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isCountry")]
        public bool IsCountry { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}