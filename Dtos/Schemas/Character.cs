using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
        protected CharacterClass CharacterClass { get; set; }
        protected CharacterRace CharacterRace { get; set; }
        protected CharacterType CharacterType { get; set; }

        public abstract int Attack();
        public abstract void Defend();
    }
}
