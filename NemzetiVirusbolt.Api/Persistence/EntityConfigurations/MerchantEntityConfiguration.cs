using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Persistence.EntityConfigurations
{
    public class MerchantEntityConfiguration : IEntityTypeConfiguration<Merchant>
    {
        public void Configure(EntityTypeBuilder<Merchant> builder)
        {
            builder
                .ToTable("merchants");

            builder
                .Property(merchant => merchant.Id)
                .HasColumnName("id");

            builder
                .Property(merchant => merchant.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
