using System.ComponentModel.DataAnnotations;

namespace WebApp.Data.Entity
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength (100)]
        public required string Code { get; set; }

        public required Professor Professor { get; set; }

        public required DateTime CreatedAt { get; set; }

    }
}
