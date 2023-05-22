using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class ProductsConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.ToTable("Products");
        builder.Property(x => x.ProductId).HasMaxLength(11);
        builder.Property(x => x.CategoryID).HasMaxLength(11);
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.Price).HasMaxLength(255);
        builder.Property(x => x.Count).HasMaxLength(11);
        builder.Property(x => x.Description);
        builder.Property(x => x.UserId).HasMaxLength(11);
    }
}