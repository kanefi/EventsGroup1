using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meetups.Models;

namespace Meetups.Repository
{
    public interface IEventRepo
    {
        Task<IEnumerable<Event>> GetEventsAsync();
    }
}
