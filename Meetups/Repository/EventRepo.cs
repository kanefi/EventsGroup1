using Meetups.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Meetups.Repository
{
    public class EventRepo : IEventRepo
    {

        public string _cnnstring = "server=db-workshop.public-dev.zuto.cloud;user=bootcamp6;database=bootcamp6;port=3306;password=SimpleKettle";


        public Task<Event> GetEventsAsync()
        {
            

        }
    }

}
