namespace myRPG.DB
{
    public static class Store
    {
        public static List<Character> Players { get; set; } = new();
        public static List<Character> Monsters { get; set; } = new();
        public static Dictionary<string, Character?> Battle = new();
    }
}
