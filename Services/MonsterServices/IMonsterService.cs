namespace myRPG.Services.MonsterServices
{
    public interface IMonsterService
    {
        public GetMonsterDto? FindMonster(int playerLevel);
        public GetMonsterDto CreateNewMonster(int playerLevel, string name);
    }
}
