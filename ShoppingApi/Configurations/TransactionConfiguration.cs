using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transaction");
        builder.Property(x => x.TransactionId).HasMaxLength(11);
        builder.Property(x => x.TransactionType).HasMaxLength(255);
        builder.Property(x => x.Description);
        builder.Property(x => x.UserId).HasMaxLength(11);
        builder.Property(x => x.Date);
    }
}