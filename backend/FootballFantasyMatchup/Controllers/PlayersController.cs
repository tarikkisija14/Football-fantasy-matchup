using FootballFantasyMatchup.DTOs;
using FootballFantasyMatchup.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballFantasyMatchup.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {

        private readonly PlayerService _playerService;

        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult GetAllPlayers()
        {
            return Ok(_playerService.GetAllPlayers());
        }

        [HttpGet("club/{club}")]
        public IActionResult GetPlayersByClub(string club)
        {
            return Ok(_playerService.GetPlayersByClub(club));
        }

        [HttpGet("nation/{nation}")]
        public IActionResult GetPlayersByNation(string nation)
        {
            return Ok(_playerService.GetPlayersByNation(nation));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetPlayerByName(string name)
        {
            var player = _playerService.GetPlayerByName(name);
            if (player == null) return NotFound();
            return Ok(player);
        }

        
        [HttpGet("position/{position}")]
        public IActionResult GetPlayersByPositionSorted(string position)
        {
            var players = _playerService.GetPlayersByPositionSorted(position);
            return Ok(players);
        }
    }
}
