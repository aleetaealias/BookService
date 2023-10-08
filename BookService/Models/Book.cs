using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; } 
        public DateTime? RegistrationTimeStamp { get; set; }
        public string? Category { get; set; }

        public string? Description { get; set; }
    }
}