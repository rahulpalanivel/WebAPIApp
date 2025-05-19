using WebApp.Data.DTO;
using WebApp.Data.Entity;

namespace WebApp.Service.Interface
{
    public interface IProfessorService
    {
        List<ProfessorDTO> getProfessors();

        ProfessorDTO getProfessor(int id);

        void addProfessor(Professor professor);

        void deleteProfessor(int id);

        void updateProfessor(Professor professor);
    }
}
