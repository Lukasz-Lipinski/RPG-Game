using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public class Character : ICharacterTypeRaceClass, IStatistics, IIdentifier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterType { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
        protected float AttackIndexRelatedToClass()
        {
            Enum.TryParse(this.CharacterClass, out CharacterClass result);
            return result switch
            {
                Schemas.CharacterClass.Warrior => 1.802f,
                Schemas.CharacterClass.Knight => 1.61f,
                Schemas.CharacterClass.Archer => 1.504f,
                Schemas.CharacterClass.Thief => 1.214f,
                Schemas.CharacterClass.Mage => 1.03f,
            };
        }
        protected float AttackIndexRelatedToRace()
        {
            Enum.TryParse(this.CharacterRace, out CharacterRace result);
            return result switch
            {
                Schemas.CharacterRace.Orc => 1.41f,
                Schemas.CharacterRace.Dwarf => 1.22f,
                Schemas.CharacterRace.Human => 1.115f,
                Schemas.CharacterRace.Elf => 1.03f,
                _ => 1,

            };
        }
    }
}
