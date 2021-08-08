using Newtonsoft.Json;

namespace Rajora
{
    public class ClanWarLeagueRound
    {
        [JsonProperty("warTags")]
        public string[] WarTags { get; set; }
    }
}