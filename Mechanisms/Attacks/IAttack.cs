namespace myRPG.Mechanisms.Attacks
{
    public interface IAttack
    {
        public void Attak(ref Character enemy, out int damage);
        public int Defence();
        public int MagicAttak(string spell, out int MP, out int damage);
    }
}