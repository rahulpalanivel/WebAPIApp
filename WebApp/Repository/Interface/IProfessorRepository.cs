using WebApp.Data.Entity;

namespace WebApp.Repository.Interface
{
    public interface IProfessorRepository
    {
        Task<List<Professor>> getProfessors();

        Task addProfessor(Professor professor);

        Task deleteProfessor(int id);

        Task updateProfessor(Professor professor);

    }
}
