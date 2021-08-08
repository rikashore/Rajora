using Newtonsoft.Json;

namespace Rajora
{
    public class LeagueSeason : BaseJsonModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}