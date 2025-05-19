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
            _dbContext.Professors.Add(professor);
            _dbContext.SaveChangesAsync();
        }

        public void deleteProfessor(int id)
        {
            var professor = _dbContext.Professors.Where(p => p.Id == id).FirstOrDefault();
            if (professor != null) 
            {
                _dbContext.Professors.Remove(professor);
            }
            _dbContext.SaveChangesAsync();
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
