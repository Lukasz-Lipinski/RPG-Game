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

        public void GenerateBattleReport(ref AttackReportDto attackReportPlayer, ref AttackReportDto? attackReportEnemy, int round)
        {
            var TourDto = new TourDto()
            {
                Number = round,
                Reports = new()
            };

            TourDto.Reports.Add(attackReportPlayer);
            if (attackReportEnemy is not null)
            {
                TourDto.Reports.Add(attackReportEnemy);
            }

            Store.AttackReports.Add(TourDto);
        }

        public void GenerateWinnerAttackReport(ref TourDto tour, Character character)
        {
            tour.Winner = character;
        }
    }
}

