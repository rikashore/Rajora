using Newtonsoft.Json;

namespace Rajora
{
    public class WarlogClanMember
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mapPosition")]
        public int MapPosition { get; set; }

        [JsonProperty("townHallLevel")]
        public int TownHallLevel { get; set; }

        [JsonProperty("opponentAttacks")]
        public int OpponentAttacks { get; set; }

        [JsonProperty("bestOpponentAttack")]
        public WarlogAttack BestOpponentAttack { get; set; }

        [JsonProperty("attacks")]
        public WarlogAttack[] Attacks { get; set; }
    }
}