using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class DeliveriesConfiguration : IEntityTypeConfiguration<Deliveries>
{
    public void Configure(EntityTypeBuilder<Deliveries> builder)
    {
        builder.ToTable("Deliveries");
        builder.Property(x => x.DeliveryId).HasMaxLength(11);
        builder.Property(x => x.UserId).HasMaxLength(11);
        builder.Property(x => x.Date);
    }
}