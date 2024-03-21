using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Monster
{
    public class GetMonsterDto : Monster, IGetCharacterTypeRaceClass
    {
        public string CharacterClass {get;set;}
        public string CharacterRace {get;set;}
        public string CharacterType {get;set;}
    }
}
