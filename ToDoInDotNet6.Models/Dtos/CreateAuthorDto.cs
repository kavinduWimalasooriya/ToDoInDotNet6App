using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInDotNet6.Models.Dtos
{
    public class CreateAuthorDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Streat { get; set; }
        public string? City { get; set; }
    }
}
