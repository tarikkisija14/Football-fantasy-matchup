using FootballFantasyMatchup.DTOs;
using FootballFantasyMatchup.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _players;
        public PlayersController(IPlayerService players) => _players = players;
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> Get([FromQuery]string position,CancellationToken ct)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                return BadRequest("Query param 'position' is required ( DM, ST, GK)");
            }
            var result=await _players.GetByPositionAsync(position,ct);
            return Ok(result);
        }
    }
}
