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
        public DbSet<Event> Events { get; set; }
        public DbSet<Host> Host { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Host>().ToTable("Hosts");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
