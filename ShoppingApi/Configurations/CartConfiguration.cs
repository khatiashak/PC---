using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Cart");
        builder.Property(x => x.CartId).HasMaxLength(11);
        builder.Property(x => x.ProductId).HasMaxLength(11);
        builder.Property(x => x.UserId).HasMaxLength(11);
        builder.Property(x => x.Count).HasMaxLength(11);

    }
}