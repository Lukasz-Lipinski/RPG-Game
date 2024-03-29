using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("login")]
        public ActionResult<string> GetPlayer([FromBody] Guid playerId)
        {
            if (Store.Battle.ContainsKey("player"))
            {
                return BadRequest("You cannot log once again");
            }

            var player = this.playerService.GetPlayerById(playerId);

            if (player is null)
            {
                return BadRequest("Invalid data");
            }

            Store.Battle.Add("player", player);
            return Ok("You're logged successfully");
        }

        [HttpPost("create-hero")]
        public ActionResult<GetPlayerDto> CreateCharakter([FromBody] CreatePlayer newCharacter)
        {
            if (newCharacter == null)
            {
                return NoContent();
            }

            var newPlayer = this.playerService.CreatePlayer(newCharacter);
            GetPlayerDto newPlayerDto = this.mapper.Map<GetPlayerDto>(newPlayer);

            Store.Players.Add(newPlayer);

            return Ok(newPlayerDto);
        }

        [HttpGet("all-players")]
        public IActionResult GetAllPlayers()
        {
            return Ok(Store.Players);
        }

        [HttpPatch("attack/basic")]
        public ActionResult<Dictionary<string, Character>> Attack()
        {
            var enemy = Store.Battle["enemy"];
            var player = Store.Battle["player"];
            return Ok();
        }

        [HttpPatch("attack/magical/{spell}")]
        public ActionResult<Dictionary<string, Character>> MagicalAttack(string spell)
        {
            return Ok();
        }

        [HttpPatch("attack/skill/{skill}")]
        public ActionResult<Dictionary<string, Character>> SkillAttack(string skill)
        {
            return Ok();
        }
    }
}
