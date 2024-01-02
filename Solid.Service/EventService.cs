using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Event AddEvent(Event eve)
        {
            _eventRepository.AddEvent(eve);
            return eve;
        }

        public IEnumerable<Event> GetAllEvents(string? text = "")
        {
            return _eventRepository.GetAllEvents().Where(c => c.Comments.Contains(text));
        }

        public Event? GetEventById(int id, string? text = "")
        {
            return _eventRepository.GetEventById(id);
        }

        public Event RemoveEventById(int id)
        {
            return _eventRepository.RemoveEvent(id);

        }

        public Event? UpdateEventById(int id, Event eve)
        {
            var source = GetEventById(id);
            return source == null ? null : _eventRepository.UpdateEvent(source, eve);
        }
    }
}
