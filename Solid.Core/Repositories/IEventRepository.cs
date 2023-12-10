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
        List<Event> GetEvents();
        bool RemoveEvent(Event eve);
        bool UpdateEvent(Event source, Event eve);
        bool AddEvent(Event eve);
    }
}
