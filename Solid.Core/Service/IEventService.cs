using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IEventService
    {
        public Event AddEvent(Event eve);
        public IEnumerable<Event> GetAllEvents(string? text = "");
        public Event? GetEventById(int id, string? text = "");
        public Event RemoveEventById(int id);
        public Event? UpdateEventById(int id, Event eve);
    }
}
