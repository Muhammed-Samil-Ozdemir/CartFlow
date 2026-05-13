using CartFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartFlow.Configurations;

public sealed class CouponConfiguration : IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> builder)
    {
        builder.ToTable("Coupons");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.DiscountAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.ExpiresAt)
            .IsRequired();

        builder.Property(x => x.IsPercentage)
            .IsRequired();

        builder.HasOne(x => x.Cart)
            .WithOne(x => x.Coupon)
            .HasForeignKey<Coupon>(x => x.CartId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}