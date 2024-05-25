using Am.Testing.App.Database.Main;
using Am.Testing.Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Am.Testing.Web.Controllers.Api.Authors
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController(MainDbContext dbContext, IValidator<Author> validator) : ControllerBase
    {
        private readonly MainDbContext _dbContext = dbContext;
        private readonly IValidator<Author> _validator = validator;

        // GET: api/<AuthorsController>
        /// <summary>
        /// Returns a list of all authors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        /// <summary>
        /// Returns filtered list by author fullname
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Author>> Get([FromQuery] string name)
        {
            try
            {
                var list = _dbContext.Authors.Where(x => x.FullName.ToLower().Contains(name.ToLower())).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<AuthorsController>/5
        /// <summary>
        /// Return author by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Author>> Get(int id)
        {
            await Task.Delay(1000);
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
        /// <summary>
        /// Creates a new Author
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] Author value)
        {
            try
            {
                var validationResult = _validator.Validate(value);

                if (validationResult.IsValid == false)
                {
                    return BadRequest();
                }

                var found = _dbContext.Authors.Add(value);
                _dbContext.SaveChanges();
                return Created();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
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
