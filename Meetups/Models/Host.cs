using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meetups.Models
{
    public class Host
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HostName { get; set; }
        [Required]

        public string EmailAddress { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
    }
}
