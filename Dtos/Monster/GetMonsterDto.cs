using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Monster
{
    public class GetMonsterDto : Monster, IGetCharacterTypeRaceClass, IStatistics
    {
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterType { get; set; }
    }
}
