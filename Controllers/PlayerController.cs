using Microsoft.AspNetCore.Mvc;
using myRPG.DB;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<Player> GetPlayer(string name)
        {
            var player = Store.Players.FirstOrDefault(p => p.Name == name);

            if (player == null)
            {
                return BadRequest("User with passed name doesn't exist");
            }

            GetPlayerDto newPlayer =
                new()
                {
                    HP = player.HP,
                    MP = player.MP,
                    Name = player.Name,
                    Level = player.Level,
                    CharacterClass = player.CharacterClass.ToString(),
                    CharacterRace = player.CharacterRace.ToString(),
                    CharacterType = player.CharacterType.ToString(),
                };

            return Ok(newPlayer);
        }

        [HttpPost("create-hero")]
        public ActionResult<Player> CreateCharakter([FromBody] CreatePlayer newCharacter)
        {
            var user = Store.Players.FirstOrDefault(p => p.Name == newCharacter.Name);

            if (user is not null)
            {
                return Conflict("Added user already exist!");
            }

            if (newCharacter == null)
            {
                return NoContent();
            }

            var newPlayer = new Player()
            {
                Name = newCharacter.Name,
                Level = 1,
                HP = 100,
                MP = 100,
                CharacterClass = (CharacterClass)
                    Enum.Parse(typeof(CharacterClass), newCharacter.CharacterClass),
                CharacterRace = (CharacterRace)
                    Enum.Parse(typeof(CharacterRace), newCharacter.CharacterRace),
                CharacterType = (CharacterType)
                    Enum.Parse(typeof(CharacterType), newCharacter.CharacterType),
            };

            GetPlayerDto newPlayerDto =
                new()
                {
                    Name = newPlayer.Name,
                    Level = newPlayer.Level,
                    HP = newPlayer.HP,
                    MP = newPlayer.MP,
                    CharacterClass = newPlayer.CharacterClass.ToString(),
                    CharacterRace = newPlayer.CharacterRace.ToString(),
                    CharacterType = newPlayer.CharacterType.ToString(),
                };

            Store.Players.Add(newPlayer);

            return Ok(newPlayerDto);
        }
    }
}
