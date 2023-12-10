using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Service;
using Solid.Data;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateringsController : ControllerBase
    {
        private readonly ICateringService _context;

        public CateringsController(ICateringService contextService)
        {
            _context = contextService;
        }

        // GET: api/<CateringsController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = _context.GetAllCaterings();
            return res == null ? NoContent() : Ok(res);
        }

        // GET api/<CateringsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = _context.GetCateringById(id);
            return res == null ? NoContent() : Ok(res);
        }

        // POST api/<CateringsController>
        [HttpPost]
        public IActionResult Post([FromBody] Catering value)
        {
            _context.AddCatering(value);
            return NoContent();
        }

        // PUT api/<CateringsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Catering value)
        {
            return _context.UpdateCateringById(id, value) ? Ok(value) : NoContent();
        }

        // DELETE api/<CateringsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _context.RemoveCateringById(id) ? NoContent() : NotFound();
        }
    }
}
