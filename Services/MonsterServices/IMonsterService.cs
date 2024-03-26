using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.MonsterServices
{
    public interface IMonsterService
    {
        public GetMonsterDto FindMonster();
        public GetMonsterDto CreateNewMonster(int playerLevel);
        public void AddNewMonster(Monster monster);
    }
}