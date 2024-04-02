namespace myRPG.Dtos.Response
{
    public class AttackReport
    {
        public int Tour { get; set; }
        public string CharacterName { get; set; }
        public string Skill { get; set; }
        public int Damage { get; set; }
        public string Msg { get; set; }
    }
}
