using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class UserTypesConfiguration : IEntityTypeConfiguration<UserTypes>
{
    public void Configure(EntityTypeBuilder<UserTypes> builder)
    {
        builder.ToTable("UserTypes");
        builder.Property(x => x.TypeID).HasMaxLength(11);
        builder.Property(x => x.TypeName).HasMaxLength(255);
        builder.Property(x => x.Description);
    }
}