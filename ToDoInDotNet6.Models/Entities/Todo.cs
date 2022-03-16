using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInDotNet6.Models.Entities
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }

        [Required, MaxLength(100)]
        public string? Description { get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }

        [Required]
        public TodoStatus? Status { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }


    }
}
