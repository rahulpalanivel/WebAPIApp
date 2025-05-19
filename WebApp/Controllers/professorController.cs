using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Service.Implementation;
using WebApp.Service.Interface;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class professorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public professorController(IProfessorService professorService) 
        {
            this._professorService = professorService;
        }

        [HttpGet]
        public IActionResult GetProfessors() 
        {
            var professors = _professorService.getProfessors();
            if (professors.Count == 0) 
            {
                return NotFound();
            }
            return Ok(professors);
        }
        
    }
}
