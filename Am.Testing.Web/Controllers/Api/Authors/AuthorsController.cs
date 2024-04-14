using Am.Testing.App.Database.Main;
using Am.Testing.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Am.Testing.Web.Controllers.Api.Authors
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController(MainDbContext dbContext) : ControllerBase
    {
        private readonly MainDbContext _dbContext = dbContext;

        // GET: api/<AuthorsController>
        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            try
            {
                var list = _dbContext.Authors.ToList();
                return Ok(list);
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            try
            {
                var found = _dbContext.Authors.FirstOrDefault(x => x.Id == id);

                if (found is not null)
                {
                    return Ok(found);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
