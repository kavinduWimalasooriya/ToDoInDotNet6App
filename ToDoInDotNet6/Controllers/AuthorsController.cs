using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoInDotNet6.BLL.Abstract;
using ToDoInDotNet6.Models.Dtos;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthorsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var authors = _service.AuthorService.GetAllAuthors();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public ActionResult<AuthorDto> GetAuthor(int id)
        {
            var author = _service.AuthorService.GetAuthor(id);
            return Ok(author);
        }

        [HttpPost]
        public ActionResult createAuthor([FromBody] CreateAuthorDto author)
        {
            _service.AuthorService.createAuthor(author);
            return StatusCode(201);
        }
    }
}
