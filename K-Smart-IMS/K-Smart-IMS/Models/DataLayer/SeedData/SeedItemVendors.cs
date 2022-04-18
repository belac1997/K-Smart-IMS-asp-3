using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedItemVendors : IEntityTypeConfiguration<ItemVendor>
    {
        public void Configure(EntityTypeBuilder<ItemVendor> entity)
        {
            entity.HasData(
                new ItemVendor { ItemId = 1, VendorId = 1 }
            );
        }
    }

}
