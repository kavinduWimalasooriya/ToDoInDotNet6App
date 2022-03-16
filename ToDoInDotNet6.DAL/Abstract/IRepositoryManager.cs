using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInDotNet6.DAL.Abstract
{
    public interface IRepositoryManager
    {
        ITodoRepository TodoRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        void Save();

    }
}
