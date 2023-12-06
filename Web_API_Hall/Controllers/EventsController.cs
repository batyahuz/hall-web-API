using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context = context;
        }


        /*
           -שליפת רשימת הארועים
            GET   https://golden_hall.co.il/events
               -שליפת ארוע ע"פ מזהה
            GET  https://golden_hall.co.il/events/id
             - הוספת ארוע
            POST  https://golden_hall.co.il/events
            -עדכון ארוע לפי מזהה
            PUT  https://golden_hall.co.il/events/id
             מחיקת ארוע לפי מזהה
            DELETE https://golden_hall.co.il/events/id
         */

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get()
        {
            if (_context.Events.Count == 0)
                return NotFound();
            return Ok(_context.Events);
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (_context.Events.Count == 0)
                return NoContent();
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
                return NoContent();
            return Ok(e);
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event value)
        {
            _context.Events.Add(new Event(value));
            return NoContent();
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event value)
        {
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
            {
                _context.Events.Add(value);
                return NotFound();
            }
            _context.Events.Remove(e);
            _context.Events.Add(value);
            return Ok(value);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_context.Events.Count == 0)
                return NotFound();
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            _context.Events.Remove(e);
            return NoContent();
        }
    }
}
