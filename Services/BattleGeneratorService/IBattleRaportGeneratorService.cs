using myRPG.Dtos.Response;

namespace myRPG.Services.BattleGeneratorService
{
    public interface IBattleRaportGeneratorService
    {
        public AttackReportDto GenerateAttackReport(string characterName, string usedSkill, int takenDamage, CharacterStatisticDto characterStats);
        public void GenerateBattleReport(AttackReportDto playerAttackReport, AttackReportDto enemyAttackReport, int tourNumber);
    }
}
