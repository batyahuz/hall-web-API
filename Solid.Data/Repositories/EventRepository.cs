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

        public bool AddEvent(Event eve)
        {
            _context.Events.Add(eve);
            return true;
        }

        public List<Event> GetEvents()
        {
            return _context.Events;
        }

        public bool RemoveEvent(Event eve)
        {
            return _context.Events.Remove(eve);
        }

        public bool UpdateEvent(Event source, Event eve)
        {
            return RemoveEvent(source) && AddEvent(eve);
        }
    }
}
