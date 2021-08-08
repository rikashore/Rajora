using Newtonsoft.Json;

namespace Rajora.Models
{
    public class WarlogClanMemberJsonModel
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
        public WarlogAttackJsonModel BestOpponentAttack { get; set; }

        [JsonProperty("attacks")]
        public WarlogAttackJsonModel[] Attacks { get; set; }
    }
}