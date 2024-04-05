using myRPG.Dtos.Response;

namespace myRPG.Services.BattleGeneratorService
{
    public class BattleRaportGeneratorService : IBattleRaportGeneratorService
    {
        public AttackReportDto GenerateAttackReport(string characterName, string usedSkill, int takenDamage, CharacterStatisticDto playerStats)
        {
            return new AttackReportDto()
            {
                CharacterName = characterName,
                Skill = usedSkill,
                Damage = takenDamage,
                CharacterStatistics = playerStats
            };
        }

        public void GenerateBattleReport(AttackReportDto attackReportEnemy, AttackReportDto attackReportPlayer, int round)
        {
            var TourDto = new TourDto()
            {
                Number = round
            };

            TourDto.Reports.Add(attackReportPlayer);
            TourDto.Reports.Add(attackReportEnemy);

            Store.AttackReports.Add(TourDto);
        }
    }
}

