using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.DAL.Abstract;
using ToDoInDotNet6.Models.Data;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.DAL
{
    public class AuthorRepository : BaseRepository<Author> , IAuthorRepository
    {
       
        public AuthorRepository(DataContext context) :base(context)  { }

        public void CreateAuthor(Author author)
        {
           Create(author);
        }

        public IEnumerable<Author> GetAllAuthors()
        {
           return GetAll().ToList();
        }

        public Author GetAuthor(int id)
        {
            return GetAll().FirstOrDefault(a =>a.Id == id);
        }
    }
}
