namespace myRPG.Dtos.Player
{
    public class CreatePlayer : IGetCharacterTypeRaceClass
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterType { get; set; }
    }
}
