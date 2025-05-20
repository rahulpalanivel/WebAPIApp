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

        public async Task addProfessor(Professor prof)
        {
            Professor professor = new Professor() 
            {
                Name = prof.Name,
                email = prof.email,
                Courses = prof.Courses,
                CreatedAt = DateTime.Now,
            };

            _dbContext.Professors.Add(professor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task deleteProfessor(int id)
        {
            var professor = _dbContext.Professors.Where(p => p.Id == id).FirstOrDefault();
            if (professor != null) 
            {
                _dbContext.Professors.Remove(professor);
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Professor>> getProfessors()
        {
            var professors = await _dbContext.Professors.ToListAsync();
            return professors;
        }

        public async Task updateProfessor(Professor professor)
        {
            try 
            {
                var profs = await _dbContext.Professors.ToListAsync();
                var prof = profs.Where(p => p.Id == professor.Id).FirstOrDefault();
                if (prof != null)
                {
                    prof.Name = professor.Name;
                    prof.email = professor.email;
                    prof.Courses = professor.Courses;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
