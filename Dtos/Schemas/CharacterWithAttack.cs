namespace myRPG.Dtos.Schemas
{
    public class CharacterWithAttack : Character, IAttack
    {
        public void Attak(ref Character enemy)
        {
            var levelIndex = this.Level * 0.1;
            enemy.HP -= (int)(levelIndex * this.Damage + this.Damage);
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