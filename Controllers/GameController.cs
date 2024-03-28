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
    }
}
