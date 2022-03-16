using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.Models.Dtos;

namespace ToDoInDotNet6.BLL.Abstract
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAllAuthors();
        AuthorDto GetAuthor(int id);
        void createAuthor(CreateAuthorDto author);
    }
}
