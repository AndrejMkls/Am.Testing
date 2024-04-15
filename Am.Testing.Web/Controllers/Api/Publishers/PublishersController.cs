using Am.Testing.App.Database.Main;
using Am.Testing.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Am.Testing.Web.Controllers.Api.Publishers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController(MainDbContext dbContext) : ControllerBase
    {
        private readonly MainDbContext _dbContext = dbContext;

        // GET: api/<PublishersController>
        [HttpGet]
        public ActionResult<IEnumerable<Publisher>> Get()
        {
            try
            {
                var list = _dbContext.Publishers.ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<PublishersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PublishersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PublishersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PublishersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
