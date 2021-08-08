using Newtonsoft.Json;

namespace Rajora
{
    public class ClanWarLeagueClanMember
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }
    }
}