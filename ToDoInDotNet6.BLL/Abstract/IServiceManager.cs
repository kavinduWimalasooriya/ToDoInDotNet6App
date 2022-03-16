using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInDotNet6.BLL.Abstract
{
    public interface IServiceManager
    {
        ITodoService TodoService { get; }
        IAuthorService AuthorService { get; }
    }
}
