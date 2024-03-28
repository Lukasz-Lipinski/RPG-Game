namespace myRPG.Dtos.Monster
{
    public class Monster : Character, ICharacterTypeRaceClass, IIdentifier
    {
        public Guid Id { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public CharacterType CharacterType { get; set; }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
