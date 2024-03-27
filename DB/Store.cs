namespace myRPG.DB
{
    public static class Store
    {
        public static List<Player> Players { get; set; } = new();
        public static List<Monster> Monsters { get; set; } = new();
    }
}
