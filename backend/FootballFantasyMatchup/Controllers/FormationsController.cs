using FootballApi.Services;
using FootballFantasyMatchup.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FootballApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormationsController : ControllerBase
    {
        private readonly FormationService _formationService;

        public FormationsController(FormationService formationService)
        {
            _formationService = formationService;
        }

        [HttpGet]
        public ActionResult<List<Formations>> GetAll()
        {
            return Ok(_formationService.GetAllFormations());
        }
        [HttpGet("{id}")]
        public ActionResult<Formations> GetById(int id)
        {
            var formation = _formationService.GetFormationById(id);
            return formation is not null ? Ok(formation) : NotFound();
        }

        [HttpGet("name/{name}")]
        public ActionResult<Formations> GetByName(string name)
        {
            var formation = _formationService.GetFormationByName(name);
            return formation is not null ? Ok(formation) : NotFound();
        }

    }
}
