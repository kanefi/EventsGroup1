using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Meetups.Models
{
    public class Event
    {

        public int Id { get; set; }
        public int HostId { get; set; }
        public int UserId { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Host Host { get; set; }
        public User User { get; set; }
    }
}
