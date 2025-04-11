using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentPlatform.Constants;
using PaymentPlatform.Models.Entities;

namespace PaymentPlatform.Data.Configurations;

public class PaymentProviderConfiguration : IEntityTypeConfiguration<PaymentProvider>
{
    public void Configure(EntityTypeBuilder<PaymentProvider> builder)
    {
        builder.ToTable("PaymentProviders");  // Specify plural table name

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        // Index on Name for faster lookups
        builder.HasIndex(p => p.Name);

        // Seed initial payment providers
        builder.HasData(
            new PaymentProvider
            {
                Id = PaymentProviders.Stripe,
                Name = "Stripe",
                CreatedAt = DateTime.UtcNow
            },
            new PaymentProvider
            {
                Id = PaymentProviders.Strex,
                Name = "Strex",
                CreatedAt = DateTime.UtcNow
            },
            new PaymentProvider
            {
                Id = PaymentProviders.Vipps,
                Name = "Vipps",
                CreatedAt = DateTime.UtcNow
            }
        );
    }
} 