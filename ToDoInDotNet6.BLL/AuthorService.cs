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
    public class AuthorService : IAuthorService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public AuthorService(IRepositoryManager repository,IMapper mapper)
        {
            _repository= repository;
            _mapper= mapper;
        }

        public void createAuthor(CreateAuthorDto author)
        {
            var AuthorToDb = _mapper.Map<Author>(author);
            _repository.AuthorRepository.CreateAuthor(AuthorToDb);
            _repository.Save();
        }

        public IEnumerable<AuthorDto> GetAllAuthors()
        {
            var authorsFromDb = _repository.AuthorRepository.GetAllAuthors();
            var authorsDtos = _mapper.Map<IEnumerable<AuthorDto>>(authorsFromDb);
            return authorsDtos;
        }

        public AuthorDto GetAuthor(int id)
        {
            var authorFromDb = _repository.AuthorRepository.GetAuthor(id);
            var authorDto = _mapper.Map<AuthorDto>(authorFromDb);
            return authorDto;
        }
    }
}
