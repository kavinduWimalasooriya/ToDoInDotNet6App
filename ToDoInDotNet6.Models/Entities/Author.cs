using System.ComponentModel.DataAnnotations;

namespace ToDoInDotNet6.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }

        [Required, MaxLength(25)]
        public string? Name { get; set; }

        [Required, MaxLength(50)]
        public string? Address { get; set; }

        [Required, MaxLength(50)]
        public string? Streat { get; set; }

        [Required, MaxLength(50)]
        public string? City { get; set; }   
        public IEnumerable<Todo> Todos { get; set; } = new List<Todo>();
    }
}