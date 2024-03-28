using Microsoft.AspNetCore.Mvc;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonsterController : ControllerBase
    {
        private readonly IMonsterService monsterService;

        public MonsterController(IMonsterService monsterService)
        {
            this.monsterService = monsterService;
        }

        [HttpGet("find-monster")]
        public ActionResult<Monster> GetMonster(int level)
        {
            return Ok(this.monsterService.FindMonster(level));
        }
    }
}
