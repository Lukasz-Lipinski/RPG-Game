using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Player
{
    public class Player : Character, ICharacterTypeRaceClass, IIdentifier
    {
        public Guid Id { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public CharacterType CharacterType { get; set; }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
