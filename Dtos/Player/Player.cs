using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Player
{
    public class Player : Character, ICharacterTypeRaceClass, IIdentifier, IStatistics
    {
        public Guid Id { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public CharacterType CharacterType { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override int MagicAttack()
        {
            throw new NotImplementedException();
        }
    }
}
