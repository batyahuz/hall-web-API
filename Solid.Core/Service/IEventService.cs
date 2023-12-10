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
        IEnumerable<Event> GetAllEvents(string? text = "");
        IEnumerable<Event> GetEventById(int id, string? text = "");
        Event AddEvent(Event eve);
        bool UpdateEventById(int id, Event eve);
        bool RemoveEventById(int id);
    }
}
