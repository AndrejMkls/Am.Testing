using Am.Testing.App.Database.Main;
using Am.Testing.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Am.Testing.Web.Controllers.Api.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(MainDbContext dbContext) : ControllerBase
    {
        private readonly MainDbContext _dbContext = dbContext;

        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            try
            {
                var list = _dbContext.Books.ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
