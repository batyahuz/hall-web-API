using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _context;

        public EventRepository(DataContext context)
        {
            _context = context;
        }

        public Event AddEvent(Event eve)
        {
            _context.Events.Add(eve);
            _context.SaveChanges();
            return eve;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events;
        }

        public Event? GetEventById(int id)
        {
            return _context.Events.Find(id);
        }

        public Event RemoveEvent(int id)
        {
            var e = GetEventById(id);
            _context.Events.Remove(e);
            _context.SaveChanges();
            return e;
        }

        public Event UpdateEvent(Event source, Event eve)
        {
            //var e = _context.Events.Find(source.Id);
            //_context.Events.Update(source);
            _context.Events.Remove(source);
            _context.Events.Add(eve);
            _context.SaveChanges();
            return eve;
        }
    }
}
