using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data.Entity;
using WebApp.Service.Implementation;
using WebApp.Service.Interface;

namespace WebApp.Controllers
{
    [Route("api/v1/[controller]")]
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

        [HttpGet("{id}")]
        public IActionResult GetProfessorsById(int id) 
        {
            var professor = _professorService.getProfessor(id);
            if(professor == null) 
            {
                return NotFound();
            }
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult addProfessor(Professor professor) 
        {
            _professorService.addProfessor(professor);
            return Ok();
        }
        
    }
}
