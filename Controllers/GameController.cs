using Microsoft.AspNetCore.Mvc;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IMonsterService monsterService;
        private readonly IMapper mapper;

        public GameController(IMonsterService monsterService, IMapper mapper)
        {
            this.monsterService = monsterService;
            this.mapper = mapper;
        }

        [HttpGet("start-battle")]
        public ActionResult<Dictionary<string, Character>> StartBattle()
        {
            if (!Store.Battle.ContainsKey("player"))
            {
                return NoContent();
            }
            var player = Store.Battle["player"];
            var monster = this.monsterService.FindMonster(player.Level);

            if (monster is null)
            {
                return NoContent();
            }

            Store.Battle.Add("enemy", monster);
            return Ok(Store.Battle);
        }


        [HttpPatch("attack/basic")]
        public ActionResult<Dictionary<string, Character>> Attack()
        {
            var enemy = Store.Battle["enemy"];
            var player = Store.Battle["player"];
            var attackEnemyDto = this.mapper.Map<AttackMonsterDto>(enemy);
            var attackPlayerDto = this.mapper.Map<AttackPlayerDto>(player);

            attackPlayerDto.Attak(ref enemy);

            if (enemy.HP <= 0)
            {
                Store.Battle.Remove("enemy");
                return Ok(Store.Battle);
            }

            attackEnemyDto.Attak(ref player);

            /*Store.Battle.Remove("player");
            Store.Battle.Add("player", player);
            Store.Battle.Remove("enemy");
            Store.Battle.Add("enemy", enemy);*/

            return Ok(Store.Battle);
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
