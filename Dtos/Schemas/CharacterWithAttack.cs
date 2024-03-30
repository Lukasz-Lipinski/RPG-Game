using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public class CharacterWithAttack : Character, IAttack
    {
        public int Attak()
        {
            var levelIndex = this.Level * 0.1;
            var dmg = (int)(this.AttackIndexRelatedToClass() * this.AttackIndexRelatedToRace() + this.Damage);
            var minDmg = dmg - 4 <= 1 ? 1 : dmg - 4;
            var countedDmg = new Random().Next(minDmg, dmg);

            return (int)(levelIndex * countedDmg);
        }

        public int MagicAttak(string spell, out int MP)
        {
            throw new NotImplementedException();
        }

        public int Defence()
        {
            throw new NotImplementedException();
        }
    }
}