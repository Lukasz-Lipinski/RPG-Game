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
        public GetMonsterDto FindMonster()
        {
            throw new NotImplementedException();
        }

        public GetMonsterDto CreateNewMonster(int playerLevel)
        {
            int monsterLevel = this.GenerateLevel(playerLevel);
            int monsterHP = this.GenerateHPOrMP();
            int monsterMP = this.GenerateHPOrMP();

            var monster = new Monster()
            {
                HP = monsterLevel * monsterHP,
                MP = monsterLevel * monsterMP,
                CharacterRace = (CharacterRace)this.GenerateCharacterDetails(3),
                CharacterClass = (CharacterClass)this.GenerateCharacterDetails(3),
                CharacterType = (CharacterType)this.GenerateCharacterDetails(3),
            };

            Store.Monsters.Add(monster);

            return this.mapper.Map<GetMonsterDto>(monster);
        }

        public void AddNewMonster(Monster monster)
        {
            throw new NotImplementedException();
        }
    }
}