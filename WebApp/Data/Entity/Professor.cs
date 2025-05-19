using System.ComponentModel.DataAnnotations;

namespace WebApp.Data.Entity
{
    public class Professor
    {
        public Professor() 
        {
            Courses = new List<Course>();
        }
        
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }

        [EmailAddress]
        public required string email { get; set; }

        public required ICollection<Course> Courses { get; set; }

        public required DateTime CreatedAt { get; set; }
    }
}
