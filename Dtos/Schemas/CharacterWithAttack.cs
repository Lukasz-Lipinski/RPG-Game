using myRPG.Mechanisms.Attacks;

namespace myRPG.Dtos.Schemas
{
    public class CharacterWithAttack : Character, IAttack
    {
        public void Attak(ref Character enemy, out int damage)
        {
            var levelIndex = this.Level * 0.1;
            var dmg = (int)(levelIndex * this.Damage + this.Damage);
            damage = dmg;
            enemy.HP -= dmg;
        }

        public int MagicAttak(string spell, out int MP, out int damage)
        {
            throw new NotImplementedException();
        }

        public int Defence()
        {
            throw new NotImplementedException();
        }
    }
}