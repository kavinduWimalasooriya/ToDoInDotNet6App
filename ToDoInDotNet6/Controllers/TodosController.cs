using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoInDotNet6.BLL.Abstract;
using ToDoInDotNet6.Models.Dtos;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly IServiceManager _service;
        public TodosController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet(Name ="getTodo")]
        public ActionResult<IEnumerable<Todo>> GetAllTodos(int authorId)
        {
            var todos = _service.TodoService.GetAllTodos(authorId);
            return Ok(todos);
        }

        [HttpPost]
        public ActionResult CreateTodo(int authorId,[FromBody]CreateTodoDto todo)
        {
            var newTodo =_service.TodoService.CreateTodo(authorId, todo);
            return CreatedAtRoute("getTodo", new {authorId=authorId});
        }
    }
}
