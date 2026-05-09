using CartFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartFlow.Context.Configurations;

public sealed class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("Discounts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired(false);

        builder.Property(x => x.Amount)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(x => x.TargetType)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.IsPercentage)
            .IsRequired();

        builder.HasMany(x => x.Products)
            .WithOne(x => x.Discount)
            .HasForeignKey(x => x.DiscountId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}