using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.Models.Dtos;

namespace ToDoInDotNet6.BLL.Abstract
{
    public interface ITodoService
    {
        IEnumerable<TodoDto> GetAllTodos(int authorId);
        TodoDto CreateTodo(int authorId,CreateTodoDto todo);
    }
}
