using Kolokwium_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_1.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }
    public DbSet<PurchasedTicket> PurchasedTickets { get; set; }

    protected DatabaseContext() { }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // tutaj seedować dane - ale to na koniec
        base.OnModelCreating(modelBuilder);
    }

}