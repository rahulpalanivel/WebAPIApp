 using System.Threading.Tasks;
using WebApp.Data.DTO;
using WebApp.Data.Entity;
using WebApp.Repository.Implementation;
using WebApp.Repository.Interface;
using WebApp.Service.Interface;

namespace WebApp.Service.Implementation
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorService(IProfessorRepository professorRepository)
        {
            this._professorRepository = professorRepository;
        }
        public async Task addProfessor(Professor professor)
        {
            await _professorRepository.addProfessor(professor);
        }

        public async Task deleteProfessor(int id)
        {
            await _professorRepository.deleteProfessor(id);
        }

        public async Task<ProfessorDTO> getProfessor(int id)
        {
            List<Professor>? professors = await _professorRepository.getProfessors();
            var professor = professors.Where(p => p.Id == id).FirstOrDefault();


            if (professor == null) 
            {
                return null;
            }
            
            ProfessorDTO professorDTO = new ProfessorDTO() 
            { 
                Name = professor.Name,
                email = professor.email,
                Courses = professor.Courses,
            };

            return professorDTO;
        }

        public async Task<List<ProfessorDTO>> getProfessors()
        {
            List<ProfessorDTO> professorDTOs = new List<ProfessorDTO>();

            List<Professor> professors = await _professorRepository.getProfessors();
            foreach(Professor professor in professors) 
            {
                ProfessorDTO professorDTO = new ProfessorDTO() 
                {
                    Name = professor.Name,
                    email = professor.email,
                    Courses = professor.Courses,
                };
                professorDTOs.Add(professorDTO);
            }

            return professorDTOs;
            
        }

        public async Task updateProfessor(Professor professor)
        {
            await _professorRepository.updateProfessor(professor);
        }
    }
}
