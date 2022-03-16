using AutoMapper;
using ToDoInDotNet6.Models.Dtos;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDto>().ForMember(dest =>dest.Location,opt => opt.MapFrom(src =>
            $"{src.Address} , {src.Streat}, {src.City}"
            ));
            CreateMap<CreateAuthorDto, Author>();
            CreateMap<Todo, TodoDto>();
            CreateMap<CreateTodoDto, Todo>();
        }
    }
}
