using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEventRepository
    {
        public Event AddEvent(Event eve);
        public IEnumerable<Event> GetAllEvents();
        public Event? GetEventById(int id);
        public Event RemoveEvent(int id);
        public Event UpdateEvent(Event source, Event eve);
    }
}
