using Newtonsoft.Json;

namespace Rajora
{
    public class Clan : BaseJsonModel
    {
        [JsonProperty("warLeague")]
        public WarLeague WarLeague { get; set; }

        [JsonProperty("memberList")]
        public ClanMember[] MemberList { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("isWarlogPublic")]
        public bool IsWarlogPublic { get; set; }

        [JsonProperty("warWinStreak")]
        public int WarWinStreak { get; set; }

        [JsonProperty("warLosses")]
        public int WarLosses { get; set; }

        [JsonProperty("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty("requiredVersusTrophies")]
        public int RequiredVersusTrophies { get; set; }

        [JsonProperty("requiredTrophies")]
        public int RequiredTrophies { get; set; }

        [JsonProperty("requiredTownhallLevel")]
        public int RequiredTownhallLevel { get; set; }

        [JsonProperty("warWins")]
        public int WarWins { get; set; }

        [JsonProperty("warTies")]
        public int WarTies { get; set; }

        [JsonProperty("warFrequency")]
        public WarFrequency WarFrequency { get; set; }

        [JsonProperty("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        [JsonProperty("labels")]
        public Label Labels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("clanPoints")]
        public int ClanPoints { get; set; }

        [JsonProperty("ChatLanguage")]
        public ChatLanguage ChatLanguage { get; set; }

        [JsonProperty("type")]
        public ClanType Type { get; set; }

        [JsonProperty("badgeUrls")]
        public Badge BadgeUrls { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}