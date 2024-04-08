namespace myRPG.Dtos.Response
{
    public class TourDto
    {
        public int Number { get; set; }
        public List<AttackReportDto> Reports { get; set; }
        public Character Winner { get; set; }
    }
}
