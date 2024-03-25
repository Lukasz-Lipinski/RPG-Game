using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IMonsterService monsterService;

        public GameController(IMonsterService monsterService)
        {
            this.monsterService = monsterService;
        }
        [HttpGet("find-monster")]
        public ActionResult<GetMonsterDto> FindMonster()
        {
            return Ok();
        }

        [HttpPost("create-new-monster")]
        public ActionResult<GetMonsterDto> CreateNewMonster(int level)
        {
            var newMonster = this.monsterService.CreateNewMonster(level);

            return Ok(newMonster);
        }
    }
}