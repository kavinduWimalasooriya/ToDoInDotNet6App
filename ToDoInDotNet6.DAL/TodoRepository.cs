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
    public class TodoRepository :BaseRepository<Todo>,ITodoRepository
    {
        public TodoRepository(DataContext context):base(context)
        {

        }

        public void CreateTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;
            Create(todo);
        }

        public IEnumerable<Todo> GetAllTodos(int authorId)
        {
            return GetAll().Where(todo =>todo.AuthorId == authorId).ToList();
        }
    }
}
