using Microsoft.AspNetCore.Mvc;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonsterController : ControllerBase
    {
        private readonly IMonsterService monsterService;
        private readonly IMapper mapper;

        public MonsterController(IMonsterService monsterService, IMapper mapper)
        {
            this.monsterService = monsterService;
            this.mapper = mapper;
        }

        [HttpGet("find-monster")]
        public ActionResult<Monster> GetMonster(int level)
        {
            return Ok(this.monsterService.FindMonster(level));
        }

        [HttpGet("all-monsters")]
        public ActionResult<List<GetMonsterDto>> FindMonster()
        {
            var monsters = Store.Monsters
                .AsReadOnly()
                .Select(m => this.mapper.Map<GetMonsterDto>(m))
                .ToList();

            return Ok(monsters);
        }

        [HttpPost("create-new-monster")]
        public ActionResult<GetMonsterDto> CreateNewMonster(int level, string name)
        {
            var newMonster = this.monsterService.CreateNewMonster(level, name);

            return Ok(newMonster);
        }
    }
}
