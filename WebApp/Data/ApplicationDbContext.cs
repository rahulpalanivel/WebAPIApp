using Microsoft.EntityFrameworkCore;
using WebApp.Data.Entity;

namespace WebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
