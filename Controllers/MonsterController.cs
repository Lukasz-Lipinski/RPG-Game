using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myRPG.Dtos.Monster;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonsterController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Monster> GetMonster()
        {
            Monster newMonster = new()
            {
                Name = "Skeleton",
                HP = 200,
                MP = 25,
                Level = 1,
                CharacterClass = CharacterClass.Warrior,
                CharacterRace = CharacterRace.Skeleton,
                CharacterType = CharacterType.Undead,
            };

            GetMonsterDto monster = new()
            {
                HP = newMonster.HP,
                MP = newMonster.MP,
                Level = newMonster.Level,
                CharacterClass = newMonster.CharacterClass.ToString(),
                CharacterRace = newMonster.CharacterRace.ToString(),
                CharacterType = newMonster.CharacterType.ToString(),
            };

            return Ok(monster);
        }
    }
}