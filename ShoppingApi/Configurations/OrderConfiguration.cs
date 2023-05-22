using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Order");
        builder.Property(x => x.OrderId).HasMaxLength(11);
        builder.Property(x => x.UserId).HasMaxLength(11);
        builder.Property(x => x.CartId).HasMaxLength(11);
        builder.Property(x => x.Date);
    }
}