using Meetups.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meetups.Context
{
    public class MeetupsContext : DbContext
    {
        public MeetupsContext(DbContextOptions<MeetupsContext> options): base(options)
        {

        }

        DbSet<Events> Events { get; set; }
        DbSet<Host> Host { get; set; }
        DbSet<User> User { get; set; }
    }
}
