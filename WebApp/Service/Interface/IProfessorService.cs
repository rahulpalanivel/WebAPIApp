using WebApp.Data.DTO;
using WebApp.Data.Entity;

namespace WebApp.Service.Interface
{
    public interface IProfessorService
    {
        Task<List<ProfessorDTO>> getProfessors();

        Task <ProfessorDTO> getProfessor(int id);

        Task addProfessor(Professor professor);

        Task deleteProfessor(int id);

        Task updateProfessor(Professor professor);
    }
}
