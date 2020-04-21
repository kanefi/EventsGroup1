using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Meetups.Context;
using Meetups.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meetups.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetupsController: Controller
    {

        private readonly IEventRepo _eventRepo;

        public MeetupsController(IEventRepo eventRepo)
        {
            _eventRepo = eventRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var eventsAsync = await _eventRepo.GetEventsAsync();

            return Ok(eventsAsync);
        }

    }
}
