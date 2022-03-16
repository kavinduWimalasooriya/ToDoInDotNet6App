using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.BLL.Abstract;
using ToDoInDotNet6.DAL.Abstract;
using ToDoInDotNet6.Models.Dtos;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.BLL
{
    public class TodoService : ITodoService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public TodoService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TodoDto CreateTodo(int authorId, CreateTodoDto todo)
        {
            var TodoToDb = _mapper.Map<Todo>(todo);
            _repository.TodoRepository.CreateTodo(authorId, TodoToDb);
            _repository.Save();
            var todoDto = _mapper.Map<TodoDto>(TodoToDb);
            return todoDto;
        }

        public IEnumerable<TodoDto> GetAllTodos(int authorId)
        {
            var todoFromDb = _repository.TodoRepository.GetAllTodos(authorId);
            var todos = _mapper.Map<IEnumerable<TodoDto>>(todoFromDb);
            return todos;
        }
    }
}
