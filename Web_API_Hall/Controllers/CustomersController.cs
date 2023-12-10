using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Service;
using Solid.Data;
using Web_API_Hall;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApWeb_API_Hallplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _context;

        public CustomersController(ICustomerService context)
        {
            _context = context;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = _context.GetAllCustomers();
            return res == null ? NoContent() : Ok(res);
        }
        // GET api/<CustomersController>/5
        [HttpGet("{phonenum}")]
        public IActionResult Get(string phonenum)
        {
            var res = _context.GetCustomerByPhonenum(phonenum);
            return res == null ? NoContent() : Ok(res);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer value)
        {
            _context.AddCustomer(value);
            return NoContent();
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{phonenum}")]
        public IActionResult Put(string phonenum, [FromBody] Customer value)
        {
            return _context.UpdateCustomerByPhonenum(phonenum, value) ? Ok(value) : NoContent();
        }

        // DELETE api/<CustomersController>/5
        [HttpPost("{phonenum}/{status}")]
        public IActionResult UpdateStatus(string phonenum, bool status)
        {
            return _context.UpdateCustomerStatusByPhonenum(phonenum, status) ? NoContent() : NotFound();
        }

    }
}
