namespace Rajora.Models
{
    public class PlayerVersusRankingJsonModel : BaseJsonModel
    {
        public PlayerRankingClanJsonModel Clan { get; set; }

        public int VersusBattleWins { get; set; }

        public int Rank { get; set; }

        public int PreviousRank { get; set; }

        public int VersusTrophies { get; set; }

        public string Tag { get; set; }

        public string Name { get; set; }
    }
}