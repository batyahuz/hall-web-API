using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Service;
using Solid.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _context;

        public EventsController(IEventService context)
        {
            _context = context;
        }

        /*  -שליפת רשימת הארועים
            GET   https://golden_hall.co.il/events
               -שליפת ארוע ע"פ מזהה
            GET  https://golden_hall.co.il/events/id
             - הוספת ארוע
            POST  https://golden_hall.co.il/events
            -עדכון ארוע לפי מזהה
            PUT  https://golden_hall.co.il/events/id
             מחיקת ארוע לפי מזהה
            DELETE https://golden_hall.co.il/events/id */

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = _context.GetAllEvents();
            return res == null ? NoContent() : Ok(res);
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = _context.GetEventById(id);
            return res == null ? NoContent() : Ok(res);
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event value)
        {
            _context.AddEvent(value);
            return NoContent();
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event value)
        {
            return _context.UpdateEventById(id, value) != null ? Ok(value) : NoContent();
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _context.RemoveEventById(id) != null ? NoContent() : NotFound();
        }
    }
}
