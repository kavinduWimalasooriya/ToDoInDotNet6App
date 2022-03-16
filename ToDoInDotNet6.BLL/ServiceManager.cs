using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.BLL.Abstract;
using ToDoInDotNet6.DAL.Abstract;

namespace ToDoInDotNet6.BLL
{
    public class ServiceManager : IServiceManager
    {
        private Lazy<ITodoService> _todoService;
        private Lazy<IAuthorService> _authorService;

       
        public ServiceManager(IRepositoryManager repository,IMapper mapper)
        {
            _todoService = new Lazy<ITodoService>(() => new TodoService(repository,mapper));
            _authorService = new Lazy<IAuthorService>(() => new AuthorService(repository,mapper));
        }
        public ITodoService TodoService => _todoService.Value;

        public IAuthorService AuthorService => _authorService.Value;
    }
}
