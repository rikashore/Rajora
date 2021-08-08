using Newtonsoft.Json;

namespace Rajora.Models
{
    public class ClanVersusRankingJsonModel : BaseJsonModel
    {
        [JsonProperty("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }
    }
}