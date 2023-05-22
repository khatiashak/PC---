using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ShoppingApi.Configurations;
public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payment");
        builder.Property(x => x.PaymentId).HasMaxLength(11);
        builder.Property(x => x.ProductId).HasMaxLength(255);
        builder.Property(x => x.Quantity).HasMaxLength(255);
        builder.Property(x => x.Amount).HasMaxLength(11);
        builder.Property(x => x.Date);
        builder.Property(x => x.UserId).HasMaxLength(11);
    }
}