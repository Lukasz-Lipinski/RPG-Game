using myRPG.Dtos.Response;

namespace myRPG.Services.BattleGeneratorService
{
    public interface IBattleRaportGeneratorService
    {
        public AttackReportDto GenerateAttackReport(string characterName, string usedSkill, int takenDamage, CharacterStatisticDto characterStats);
        public void GenerateWinnerAttackReport(ref TourDto tour, Character character);
        public void GenerateBattleReport(ref AttackReportDto playerAttackReport, ref AttackReportDto? enemyAttackReport, int tourNumber);
    }
}
