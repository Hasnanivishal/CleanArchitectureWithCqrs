using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(nameof(Customer));

        builder.HasKey(x => x.CustomerId);

        builder.Property(x => x.CustomerId).IsRequired();

        builder.Property(x => x.Name).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.AvailableBalance)
            .IsRequired();

        // One to Many Relation from Customer to Orders
        builder.HasMany<Order>()
            .WithOne()
            .HasForeignKey(x=> x.CustomerId)
            .IsRequired();
    }
}
