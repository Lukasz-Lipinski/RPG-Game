namespace myRPG.Services.MonsterServices
{
    public class MonsterService : SettingStats, IMonsterService
    {
        private readonly IMapper mapper;

        public MonsterService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public GetMonsterDto? FindMonster(int playerLevel)
        {
            int maxLevel = playerLevel + 3;
            int minLevel = playerLevel - 3 <= 1 ? playerLevel : playerLevel - 3;

            var monsters = Store.Monsters
                .AsReadOnly()
                .Where(m => m.Level <= maxLevel && m.Level >= minLevel)
                .ToList();

            int randomMonster = new Random().Next(monsters.Count);
            return randomMonster < monsters.Count
                ? this.mapper.Map<GetMonsterDto>(monsters[randomMonster])
                : null;
        }

        public GetMonsterDto CreateNewMonster(int playerLevel, string name)
        {
            int monsterLevel = this.GenerateLevel(playerLevel);
            CharacterClass characterClass = (CharacterClass)this.GenerateCharacterDetails(5);
            int monsterHP =
                (int)this.GetHPIndex(characterClass) * monsterLevel
                + this.GetHPOnStart(characterClass);
            int monsterMP =
                (int)this.GetMPIndex(characterClass) * monsterLevel
                + this.GetMPOnStart(characterClass);

            var monster = new Character()
            {
                Name = name,
                HP = monsterHP,
                MP = monsterMP,
                Level = monsterLevel,
                Id = Guid.NewGuid(),
                Damage = this.GetDmgOnStart(characterClass),
                CharacterRace = ((CharacterRace)this.GenerateCharacterDetails(4)).ToString(),
                CharacterClass = characterClass.ToString(),
                CharacterType = ((CharacterType)this.GenerateCharacterDetails(3)).ToString(),
            };

            Store.Monsters.Add(monster);

            return this.mapper.Map<GetMonsterDto>(monster);
        }
    }
}
