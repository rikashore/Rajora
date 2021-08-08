namespace Rajora
{
    public class WarlogClan
    {
        public float DestructionPercentage { get; set; }

        public string Tag { get; set; }

        public string Name { get; set; }

        public Badge BadgeUrls { get; set; }

        public int ClanLevel { get; set; }

        public int Attacks { get; set; }

        public int Stars { get; set; }

        public int ExpEarned { get; set; }

        public WarlogClanMember[] Members { get; set; }
    }
}