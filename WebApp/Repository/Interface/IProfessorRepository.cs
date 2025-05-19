using WebApp.Data.Entity;

namespace WebApp.Repository.Interface
{
    public interface IProfessorRepository
    {
        List<Professor> getProfessors();

        void addProfessor(Professor professor);

        void deleteProfessor(int id);

        void updateProfessor(Professor professor);

    }
}
