using Newtonsoft.Json;

namespace Rajora.Models
{
    public class LeagueSeasonJsonModel : BaseJsonModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}