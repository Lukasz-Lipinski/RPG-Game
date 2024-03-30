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
        public ActionResult<GetMonsterDto> GetMonster(int level)
        {
            if (Store.Battle.ContainsKey("enemy"))
            {
                return Conflict("Monster found");
            }
            var monster = this.monsterService.FindMonster(level);
            var getMonsterDto = this.mapper.Map<GetMonsterDto>(monster);
            return Ok(getMonsterDto);
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
