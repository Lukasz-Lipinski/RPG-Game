namespace myRPG.Dtos.Monster
{
    public class Monster : Character, ICharacterTypeRaceClass
    {
        public Monster() { }

        public CharacterClass CharacterClass
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public CharacterRace CharacterRace
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public CharacterType CharacterType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

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
