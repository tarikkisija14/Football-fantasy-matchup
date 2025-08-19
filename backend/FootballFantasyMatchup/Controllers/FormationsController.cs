using FootballFantasyMatchup.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FootballApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormationsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Formations>>Get()
        {
            
            var f433 = new Formations()
            {
                Name = "4-3-3",
                Spots = new()
                {
                    new() { Position = "GK", X = 50, Y = 95 },
                    new() { Position = "LB", X = 20, Y = 80 },
                    new() { Position = "CB", X = 40, Y = 80 },
                    new() { Position = "CB", X = 60, Y = 80 },
                    new() { Position = "RB", X = 80, Y = 80 },
                    new() { Position = "CM", X = 35, Y = 60 },
                    new() { Position = "CM", X = 50, Y = 60 },
                    new() { Position = "CM", X = 65, Y = 60 },
                    new() { Position = "LW", X = 20, Y = 40 },
                    new() { Position = "ST", X = 50, Y = 30 },
                    new() { Position = "RW", X = 80, Y = 40 }
                }
            };
            return Ok(new[] { f433 });

        }
    }
}
