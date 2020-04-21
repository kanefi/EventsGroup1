using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Meetups.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Meetups.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetupsController: Controller
    {
        private readonly MeetupsContext _meetupsContextContext;

        public MeetupsController(MeetupsContext meetupsContext)
        {
            _meetupsContextContext = meetupsContext;
        }

        [HttpGet]
        public bool CheckConnetion()
        {
            try
            {
                _meetupsContextContext.Database.OpenConnection();
                _meetupsContextContext.Database.CanConnect();
             return true;

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
