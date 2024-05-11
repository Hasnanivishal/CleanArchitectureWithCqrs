using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context;

public sealed class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
