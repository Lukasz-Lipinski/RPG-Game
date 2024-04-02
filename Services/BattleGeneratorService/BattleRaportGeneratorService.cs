using myRPG.Dtos.Response;

namespace myRPG.Services.BattleGeneratorService
{
    public class BattleRaportGeneratorService : IBattleRaportGeneratorService
    {
        public string GenerateAttackReport(string characterName, string skill, int damage) => $@"
                Player: {characterName}
                used {skill} on Enemy
                damage: {damage}";

        public HashSet<AttackReport> GenerateBattleReport(string attackReport)
        {
            throw new NotImplementedException();
        }
    }
}

