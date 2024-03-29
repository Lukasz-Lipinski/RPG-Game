using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public interface ICharacterTypeRaceClass
    {
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterType { get; set; }
    }
}
