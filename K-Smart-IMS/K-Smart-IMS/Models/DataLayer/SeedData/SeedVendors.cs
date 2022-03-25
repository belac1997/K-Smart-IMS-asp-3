using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedVendors : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> entity)
        {
            entity.HasData(
                new Vendor { Id = 1, Name = "Dawn" }
            );
        }
    }

}