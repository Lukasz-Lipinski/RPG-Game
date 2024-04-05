namespace myRPG.Mechanisms.Attacks
{
    public interface IAttack
    {
        public void Attak(ref Character enemy);
        public int Defence();
        public int MagicAttak(string spell, out int MP);
    }
}