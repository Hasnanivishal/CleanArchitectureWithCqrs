using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(nameof(Order));

        builder.HasKey(x => x.OrderId);

        builder.Property(x => x.OrderId).IsRequired();

        builder.Property(x => x.Name).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description).IsRequired()
            .HasMaxLength(500);
    }
}
