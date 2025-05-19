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
            _professorRepository.addProfessor(professor);
        }

        public void deleteProfessor(int id)
        {
            _professorRepository.deleteProfessor(id);
        }

        public ProfessorDTO getProfessor(int id)
        {
            Professor? professor = _professorRepository.getProfessors().Where(p=>p.Id == id).FirstOrDefault();
            
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
