using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data.DTO;
using WebApp.Data.Entity;
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
        public async Task<IActionResult> GetProfessors() 
        {
            var professors = await _professorService.getProfessors();
            if (professors.Count == 0) 
            {
                return NotFound();
            }
            return Ok(professors);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetProfessorsById(int id) 
        {
            var professor = await _professorService.getProfessor(id);
            if(professor == null) 
            {
                return NotFound();
            }
            return Ok(professor);
        }

        [HttpPost]
        public async Task<IActionResult> addProfessor(Professor professor) 
        {
            await _professorService.addProfessor(professor);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteProfessor(int id) 
        {
            var professor = await _professorService.getProfessor(id);
            if (professor == null)
            {
                return NotFound();
            }
            await _professorService.deleteProfessor(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateProfessor(Professor professor) 
        {
            var prof = await _professorService.getProfessor(professor.Id);
            if (professor == null)
            {
                return NotFound();
            }
            await _professorService.updateProfessor(professor);
            return Ok();
        }
        
    }
}
