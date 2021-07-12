using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class EventManagerContext : DbContext
    {
        public EventManagerContext(DbContextOptions<EventManagerContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PurchasedTicket> PurchasedTickets { get; set; }
    }
}
