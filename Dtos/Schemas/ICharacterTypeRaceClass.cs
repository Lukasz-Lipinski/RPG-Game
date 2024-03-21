using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public interface ICharacterTypeRaceClass
    {
        public CharacterClass CharacterClass { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public CharacterType CharacterType { get; set; }
    }
}
