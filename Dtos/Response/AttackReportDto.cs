namespace myRPG.Dtos.Response
{
    public class AttackReportDto
    {
        public string CharacterName { get; set; }
        public string Skill { get; set; }
        public int Damage { get; set; }
        public CharacterStatisticDto CharacterStatistics { get; set; }
    }
}
