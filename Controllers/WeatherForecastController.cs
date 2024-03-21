using Microsoft.AspNetCore.Mvc;
using myRPG.Dtos.Monster;

namespace myRPG.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public ActionResult<Monster> GetMonster()
    {
        Monster monster =
            new()
            {
                HP = 100,
                MP = 0,
                Name = "Cookie Monster",
                CharacterClass = CharacterClass.Warrior,
                CharacterRace = CharacterRace.Orc,
                CharacterType = CharacterType.Alive
            };

        return Ok(monster);
    }
}
