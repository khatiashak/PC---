using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
{
    public void Configure(EntityTypeBuilder<Categories> builder)
    {
        builder.ToTable("Categories");
        builder.Property(x => x.CategoryId).HasMaxLength(11);
        builder.Property(x => x.CategoryName).HasMaxLength(255);
        builder.Property(x => x.Description);
    }
}