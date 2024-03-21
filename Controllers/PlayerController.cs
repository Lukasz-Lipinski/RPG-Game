using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myRPG.Dtos.Player;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<Player> GetPlayer(string name)
        {
            Player player = new()
            {
                Name = name,
                Level = 1,
                HP = 100,
                MP = 150,
                CharacterClass = CharacterClass.Mag,
                CharacterRace = CharacterRace.Orc,
                CharacterType = CharacterType.Alive,
            };

            GetPlayerDto newPlayer = new()
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
                CharacterClass = (CharacterClass)Enum.Parse(typeof(CharacterClass), newCharacter.CharacterClass),
                CharacterRace = (CharacterRace)Enum.Parse(typeof(CharacterRace), newCharacter.CharacterRace),
                CharacterType = (CharacterType)Enum.Parse(typeof(CharacterType), newCharacter.CharacterType),
            };

            System.Console.WriteLine(newPlayer);

            GetPlayerDto newPlayerDto = new()
            {
                Name = newPlayer.Name,
                Level = newPlayer.Level,
                HP = newPlayer.HP,
                MP = newPlayer.MP,
                CharacterClass = newPlayer.CharacterClass.ToString(),
                CharacterRace = newPlayer.CharacterRace.ToString(),
                CharacterType = newPlayer.CharacterType.ToString(),
            };

            return Ok(newPlayerDto);
        }
    }
}