using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public class CharacterWithAttack : Character, IAttack
    {
        private int GetDmg(int minDmg, int maxDmg) => new Random().Next(minDmg, maxDmg);
        public void Attak(ref Character enemy)
        {
            var levelIndex = this.Level * 0.1;
            var dmg = (int)(this.AttackIndexRelatedToClass() * this.AttackIndexRelatedToRace() + this.Damage);
            var minDmg = dmg - 4 <= 1 ? 1 : dmg - 4;
            var randomDmg = this.GetDmg(minDmg, dmg);
            enemy.HP -= (int)(levelIndex * randomDmg);
            System.Console.WriteLine(enemy.HP);
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