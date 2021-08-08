using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanWarLeagueClanMemberJsonModel
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }
    }
}