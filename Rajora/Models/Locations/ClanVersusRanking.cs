using Newtonsoft.Json;

namespace Rajora
{
    public class ClanVersusRanking : BaseJsonModel
    {
        [JsonProperty("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }
    }
}