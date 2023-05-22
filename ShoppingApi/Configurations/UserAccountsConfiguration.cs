using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class UserAccountsConfiguration : IEntityTypeConfiguration<UserAccounts>
{
    public void Configure(EntityTypeBuilder<UserAccounts> builder)
    {
        builder.ToTable("UserAccounts");
        builder.Property(x => x.UserId).HasMaxLength(11);
        builder.Property(x => x.TypeId).HasMaxLength(11);
        builder.Property(x => x.Name).HasMaxLength(255); ;
        builder.Property(x => x.Age).HasMaxLength(11);
        builder.Property(x => x.Gender).HasMaxLength(255);
        builder.Property(x => x.Address);
        builder.Property(x => x.ContactNumber).HasMaxLength(255);
        builder.Property(x => x.UserName).HasMaxLength(255);
        builder.Property(x => x.Password).HasMaxLength(255);
    }
}