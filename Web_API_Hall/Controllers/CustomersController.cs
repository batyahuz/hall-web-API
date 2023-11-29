using Microsoft.AspNetCore.Mvc;
using Web_API_Hall;
using Web_API_Hall.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApWeb_API_Hallplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IActionResult Get()
        {
            if (_context.Customers.Count == 0)
                return NoContent();
            return Ok(_context.Customers);
        }
        // GET api/<CustomersController>/5
        [HttpGet("{phonenum}")]
        public IActionResult Get(string phonenum)
        {
            if (_context.Customers.Count == 0)
                return NoContent();
            var c = _context.Customers.Find(c => c.PhoneNum.Equals(phonenum));
            if (c == null)
                return NoContent();
            return Ok(c);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer value)
        {
            _context.Customers.Add(new Customer(value));
            return NoContent();
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{phonenum}")]
        public IActionResult Put(string phonenum, [FromBody] Customer value)
        {
            var c = _context.Customers.Find(c => c.PhoneNum.Equals(phonenum));
            if (c == null)
            {
                _context.Customers.Add(value);
                return NotFound();
            }
            _context.Customers.Remove(c);
            _context.Customers.Add(value);
            return Ok(value);
        }

        // DELETE api/<CustomersController>/5
        [HttpPost("{phonenum}/{status}")]
        public IActionResult UpdateStatus(string phonenum, bool status)
        {
            if (_context.Customers.Count == 0)
                return NotFound();
            var c = _context.Customers.Find(c => c.PhoneNum.Equals(phonenum));
            if (c == null)
                return NotFound();
            c.Status = status;
            return Ok(c);
        }

    }
}
