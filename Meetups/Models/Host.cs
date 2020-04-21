using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meetups.Models
{
    public class Host
    {
        public int Id { get; set; }
        public string HostName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Events Event { get; set; }
    }
}
