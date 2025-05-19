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
        public void addProfessor(Professor professor)
        {
            throw new NotImplementedException();
        }

        public void deleteProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public ProfessorDTO getProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProfessorDTO> getProfessors()
        {
            List<ProfessorDTO> professorDTOs = new List<ProfessorDTO>();

            List<Professor> professors = _professorRepository.getProfessors();
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

        public void updateProfessor(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
