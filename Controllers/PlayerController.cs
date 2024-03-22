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
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet("{name}")]
        public ActionResult<Player> GetPlayer(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name was assigned");
            };

            var player = Store.Players.FirstOrDefault(
                p => p.Name == name
            );

            if (player is null)
            {
                return BadRequest("Invalid name");
            }

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

            this.playerService.CheckIfPlayerExist(newPlayer, out bool isUserCreated);

            System.Console.WriteLine(isUserCreated);

            // if (!isUserCreated)
            // {
            //     return BadRequest("User exist!");
            // }

            // GetPlayerDto newPlayerDto = new()
            // {
            //     Name = newPlayer.Name,
            //     Level = newPlayer.Level,
            //     HP = newPlayer.HP,
            //     MP = newPlayer.MP,
            //     CharacterClass = newPlayer.CharacterClass.ToString(),
            //     CharacterRace = newPlayer.CharacterRace.ToString(),
            //     CharacterType = newPlayer.CharacterType.ToString(),
            // };

            return Ok(newPlayer);
        }
    }
}