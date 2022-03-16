using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.DAL.Abstract;
using ToDoInDotNet6.Models.Data;

namespace ToDoInDotNet6.DAL
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        private readonly Lazy<ITodoRepository> _todoRepository;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        public RepositoryManager(DataContext context)
        {
            _context = context;
            _todoRepository = new Lazy<ITodoRepository>(() => new TodoRepository(context));
            _authorRepository = new Lazy<IAuthorRepository>(()=> new AuthorRepository(context));
        }

        public ITodoRepository TodoRepository => _todoRepository.Value;

        public IAuthorRepository AuthorRepository => _authorRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
