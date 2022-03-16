using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.DAL.Abstract
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAllTodos(int authorId);
        void CreateTodo(int authorId,Todo todo);
    }
}
