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
        [Key]
        public int Id { get; set; }

        [ForeignKey("Host")]
        public int HostId { get; set; }
        [ForeignKey("User")]

        public int UserId { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public Host Host { get; set; }
        [Required]

        public User User { get; set; }
    }
}
