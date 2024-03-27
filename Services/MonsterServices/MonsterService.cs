using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace myRPG.Services.MonsterServices
{
    public class MonsterService : IMonsterService
    {
        private readonly IMapper mapper;

        public MonsterService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private int GenerateLevel(int level) => new Random().Next(level);

        private int GenerateHPOrMP() => new Random().Next(10, 150);

        private int GenerateCharacterDetails(int max = 3) => new Random().Next(0, max);

        public GetMonsterDto FindMonster(int playerLevel)
        {
            int maxLevel = playerLevel + 3; // 8
            int minLevel = playerLevel - 3 <= 1 ? playerLevel : playerLevel - 3; //2

            System.Console.WriteLine(maxLevel);
            System.Console.WriteLine(minLevel);

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
            int monsterHP = this.GenerateHPOrMP();
            int monsterMP = this.GenerateHPOrMP();

            var monster = new Monster()
            {
                Name = name,
                HP = monsterLevel * monsterHP,
                MP = monsterLevel * monsterMP,
                Level = monsterLevel,
                CharacterRace = (CharacterRace)this.GenerateCharacterDetails(3),
                CharacterClass = (CharacterClass)this.GenerateCharacterDetails(3),
                CharacterType = (CharacterType)this.GenerateCharacterDetails(3),
            };

            this.AddNewMonster(monster);

            return this.mapper.Map<GetMonsterDto>(monster);
        }

        private void AddNewMonster(Monster monster)
        {
            Store.Monsters.Add(monster);
        }
    }
}
