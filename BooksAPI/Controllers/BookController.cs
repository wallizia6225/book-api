using BooksAPI.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Clean Code", Author = "Robert Martin" },
                new Book { Id = 2, Title = "Design Patterns", Author = "Gang of Four" }
            };
            return Ok(books);
        }
    }
}
