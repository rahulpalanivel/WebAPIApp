using WebApp.Data.Entity;

namespace WebApp.Data.DTO
{
    public class ProfessorDTO
    {
        public ProfessorDTO() 
        {
            Courses = new List<Course>();
        }

        public required string Name { get; set; }

        public required string email { get; set; }

        public required ICollection<Course> Courses { get; set; }
    }
}
