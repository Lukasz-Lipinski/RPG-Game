using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Player
{
    public class GetPlayerDto : Character, IGetCharacterTypeRaceClass, IStatistics
    {
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterType { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }

        public override int Attack()
        {
            return 10;
        }

        public override int MagicAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
