using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.DAL.Abstract
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthor(int id);
        void CreateAuthor(Author author);
    }
}
