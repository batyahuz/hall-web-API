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
            return _eventRepository.GetEvents().Where(c => c.Comments.Contains(text));
        }

        public IEnumerable<Event> GetEventById(int id, string? text = "")
        {
            return GetAllEvents(text).Where(c => c.Id == id);
        }

        public bool RemoveEventById(int id)
        {
            return _eventRepository.RemoveEvent((Event)GetEventById(id));

        }

        public bool UpdateEventById(int id, Event eve)
        {
            return _eventRepository.UpdateEvent((Event)GetEventById(id), eve);

        }
    }
}
