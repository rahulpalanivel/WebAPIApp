using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Data.Entity;
using WebApp.Repository.Interface;

namespace WebApp.Repository.Implementation
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProfessorRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void addProfessor(Professor professor)
        {
            throw new NotImplementedException();
        }

        public void deleteProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public Professor getProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public List<Professor> getProfessors()
        {
            var professors = _dbContext.Professors.ToList();
            return professors;
        }

        public void updateProfessor(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
