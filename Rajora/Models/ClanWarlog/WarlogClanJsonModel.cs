namespace Rajora.Models
{
    public class WarlogClanJsonModel
    {
        public float DestructionPercentage { get; set; }

        public string Tag { get; set; }

        public string Name { get; set; }

        public BadgeJsonModel BadgeUrls { get; set; }

        public int ClanLevel { get; set; }

        public int Attacks { get; set; }

        public int Stars { get; set; }

        public int ExpEarned { get; set; }

        public WarlogClanMemberJsonModel[] Members { get; set; }
    }
}