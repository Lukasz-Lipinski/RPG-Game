using Microsoft.AspNetCore.Mvc;
using myRPG.Dtos.Response;
using myRPG.Services.BattleGeneratorService;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IMonsterService monsterService;
        private readonly IMapper mapper;
        private readonly IBattleRaportGeneratorService battleGeneratorService;

        public GameController(IMonsterService monsterService, IMapper mapper, IBattleRaportGeneratorService battleGeneratorService)
        {
            this.monsterService = monsterService;
            this.mapper = mapper;
            this.battleGeneratorService = battleGeneratorService;
        }

        [HttpGet("start-battle")]
        public ActionResult<Dictionary<string, Character>> StartBattle()
        {
            if (!Store.Battle.ContainsKey("player"))
            {
                return NoContent();
            }
            var player = Store.Battle["player"];
            var monster = this.monsterService.FindMonster(player!.Level);

            if (monster is null)
            {
                return NoContent();
            }

            Store.Battle.Add("enemy", monster);
            return Ok(Store.Battle);
        }


        [HttpPatch("attack/basic")]
        public ActionResult<HashSet<TourDto>> Attack()
        {
            var enemy = Store.Battle["enemy"];
            var player = Store.Battle["player"];
            var attackEnemyDto = this.mapper.Map<AttackMonsterDto>(enemy);
            var attackPlayerDto = this.mapper.Map<AttackPlayerDto>(player);
            AttackReportDto playerAttackReport;
            AttackReportDto enemyAttackReport;

            attackPlayerDto.Attak(ref enemy, out int playerDmg);

            if (enemy.HP <= 0)
            {
                Store.Battle.Remove("enemy");
                return Ok(Store.Battle);
            }

            attackEnemyDto.Attak(ref player, out int enemyDmg);

            var playerStatsDto = this.mapper.Map<CharacterStatisticDto>(player);
            var enemyStatsDto = this.mapper.Map<CharacterStatisticDto>(enemy);

            playerAttackReport = this.battleGeneratorService.GenerateAttackReport(player.Name, "basic attack", playerDmg, playerStatsDto);
            enemyAttackReport = this.battleGeneratorService.GenerateAttackReport(enemy.Name, "basic attack", enemyDmg, enemyStatsDto);

            this.battleGeneratorService.GenerateBattleReport(playerAttackReport, enemyAttackReport, Store.AttackReports.Count);

            return Ok(Store.AttackReports);
        }

        [HttpPatch("attack/magical/{spell}")]
        public ActionResult<Dictionary<string, Character>> MagicalAttack(string spell)
        {
            return Ok();
        }

        [HttpPatch("attack/skill/{skill}")]
        public ActionResult<Dictionary<string, Character>> SkillAttack(string skill)
        {
            return Ok();
        }
    }
}
