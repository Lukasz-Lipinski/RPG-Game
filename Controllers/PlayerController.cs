using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myRPG.DB;

namespace myRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private GetPlayerDto MapToGetPlayerDto(Character character) =>
            this.mapper.Map<GetPlayerDto>(character);

        private readonly IPlayerService playerService;
        private readonly IMapper mapper;

        public PlayerController(IPlayerService playerService, IMapper mapper)
        {
            this.playerService = playerService;
            this.mapper = mapper;
        }

        [HttpGet("{name}")]
        public ActionResult<Player> GetPlayer(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name was assigned");
            }
            ;

            var player = Store.Players.FirstOrDefault(p => p.Name == name);

            if (player is null)
            {
                return BadRequest("Invalid name");
            }

            GetPlayerDto newPlayer = this.MapToGetPlayerDto(player);

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
