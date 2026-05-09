using CartFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartFlow.Context.Configurations;

public sealed class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Carts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.CouponId)
            .IsRequired(false);

        builder.Property(x => x.IsCheckedOut)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.Carts)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Coupon)
            .WithMany()
            .HasForeignKey(x => x.CouponId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(x => x.CartItems)
            .WithOne(x => x.Cart)
            .HasForeignKey(x => x.CartId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}