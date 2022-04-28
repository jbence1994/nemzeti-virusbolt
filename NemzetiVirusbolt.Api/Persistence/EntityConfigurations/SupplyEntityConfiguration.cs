using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NemzetiVirusbolt.Api.Core.Models;

namespace NemzetiVirusbolt.Api.Persistence.EntityConfigurations
{
    public class SupplyEntityConfiguration : IEntityTypeConfiguration<Supply>
    {
        public void Configure(EntityTypeBuilder<Supply> builder)
        {
            builder
                .ToTable("supplies");

            builder
                .Property(supply => supply.Id)
                .HasColumnName("id");

            builder
                .Property(supply => supply.ProductId)
                .HasColumnName("product_id");

            builder
                .Property(supply => supply.Quantity)
                .HasColumnName("quantity")
                .IsRequired();

            builder
                .Property(supply => supply.CreatedDateTime)
                .HasColumnName("created_date_time")
                .IsRequired();
        }
    }
}
