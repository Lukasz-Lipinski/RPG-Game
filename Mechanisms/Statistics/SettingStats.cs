namespace myRPG.Dtos.Mechanisms
{
    public class SettingStats
    {
        public int GenerateLevel(int level) => new Random().Next(1, level);

        public double GetHPIndex(CharacterClass characterClass) =>
            characterClass switch
            {
                CharacterClass.Warrior => 2.2,
                CharacterClass.Knight => 2,
                CharacterClass.Thief => 1.6,
                CharacterClass.Archer => 1.4,
                CharacterClass.Mage => 1.2,
                _ => 1,
            };

        public double GetMPIndex(CharacterClass characterClass) =>
            characterClass switch
            {
                CharacterClass.Mage => 2.1,
                CharacterClass.Knight => 1.3,
                CharacterClass.Archer => 1.2,
                CharacterClass.Thief => 1.1,
                CharacterClass.Warrior => 1,
                _ => 1,
            };

        public int GetHPOnStart(CharacterClass characterClass) =>
            characterClass switch
            {
                CharacterClass.Knight => 110,
                CharacterClass.Warrior => 100,
                CharacterClass.Thief => 70,
                CharacterClass.Archer => 60,
                CharacterClass.Mage => 50,
                _ => 10,
            };

        public int GetMPOnStart(CharacterClass characterClass) =>
            characterClass switch
            {
                CharacterClass.Mage => 100,
                CharacterClass.Knight => 50,
                CharacterClass.Archer => 30,
                CharacterClass.Warrior => 20,
                CharacterClass.Thief => 20,
                _ => 10,
            };

        public int GenerateCharacterDetails(int max = 3) => new Random().Next(0, max);

        public int GetDmgOnStart(CharacterClass characterClass) =>
            characterClass switch
            {
                CharacterClass.Warrior => 35,
                CharacterClass.Knight => 27,
                CharacterClass.Thief => 20,
                CharacterClass.Archer => 20,
                CharacterClass.Mage => 10,
            };
    }
}
