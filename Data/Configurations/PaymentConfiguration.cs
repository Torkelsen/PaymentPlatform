using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentPlatform.Models.Entities;

namespace PaymentPlatform.Data.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");  // Specify plural table name

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Amount)
            .HasPrecision(18, 2)  // Suitable for currency values
            .IsRequired();

        builder.Property(p => p.Currency)
            .HasMaxLength(3);     // ISO 4217 currency codes are 3 characters

        builder.Property(p => p.Status)
            .HasMaxLength(50);

        builder.Property(p => p.ReferenceCode)
            .HasMaxLength(100);

        // Relationship with PaymentProvider
        builder.HasOne(p => p.Provider)
            .WithMany()
            .HasForeignKey(p => p.Provider_Id)
            .OnDelete(DeleteBehavior.Restrict);  // Prevent accidental deletion of providers

        // Index on Status for faster filtering
        builder.HasIndex(p => p.Status);
        
        // Composite index on Provider and ReferenceCode
        builder.HasIndex(p => new { p.Provider_Id, p.ReferenceCode });
    }
} 