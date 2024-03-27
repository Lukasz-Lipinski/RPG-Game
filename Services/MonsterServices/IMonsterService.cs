using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Services.MonsterServices
{
    public interface IMonsterService
    {
        public GetMonsterDto? FindMonster(int playerLevel);
        public GetMonsterDto CreateNewMonster(int playerLevel, string name);
    }
}
