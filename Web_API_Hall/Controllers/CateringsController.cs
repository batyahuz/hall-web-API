using Microsoft.AspNetCore.Mvc;
using Web_API_Hall.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateringsController : ControllerBase
    {
        private readonly DataContext _context;

        public CateringsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<CateringsController>
        [HttpGet]
        public IActionResult Get()
        {
            if (_context.Caterings.Count == 0)
                return NoContent();
            return Ok(_context.Caterings);
        }

        // GET api/<CateringsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (_context.Caterings.Count == 0)
                return NoContent();
            var c = _context.Caterings.Find(c => c.Id == id);
            if (c == null)
                return NoContent();
            return Ok(c);
        }

        // POST api/<CateringsController>
        [HttpPost]
        public IActionResult Post([FromBody] Catering value)
        {
            _context.Caterings.Add(new Catering(value));
            return NoContent();
        }

        // PUT api/<CateringsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Catering value)
        {
            var c = _context.Caterings.Find(c => c.Id == id);
            if (c == null)
            {
                _context.Caterings.Add(value);
                return NotFound();
            }
            _context.Caterings.Remove(c);
            _context.Caterings.Add(value);
            return Ok(value);
        }

        // DELETE api/<CateringsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_context.Caterings.Count == 0)
                return NotFound();
            var c = _context.Caterings.Find(c => c.Id == id);
            if (c == null)
                return NotFound();
            _context.Caterings.Remove(c);
            return NoContent();
        }
    }
}
