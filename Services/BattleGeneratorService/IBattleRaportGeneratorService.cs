using myRPG.Dtos.Response;

namespace myRPG.Services.BattleGeneratorService
{
    public interface IBattleRaportGeneratorService
    {
        public string GenerateAttackReport(string characterName, string skill, int damage);
        public HashSet<AttackReport> GenerateBattleReport(string attackReport);
    }
}
