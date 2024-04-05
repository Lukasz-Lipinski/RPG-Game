namespace myRPG.Mechanisms.Statistics
{
    public class PlayerStatisticsForReportDto : IStatistics
    {
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
    }
}
