using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedItemVendors : IEntityTypeConfiguration<ItemVendor>
    {
        public void Configure(EntityTypeBuilder<ItemVendor> entity)
        {
            entity.HasData(
                //Appliances
                new ItemVendor { ItemId = 1, VendorId = 1 },
                new ItemVendor { ItemId = 2, VendorId = 1 },
                new ItemVendor { ItemId = 3, VendorId = 2 },
                new ItemVendor { ItemId = 4, VendorId = 1 },
                new ItemVendor { ItemId = 5, VendorId = 3 },
                new ItemVendor { ItemId = 6, VendorId = 3 },
                //Baby
                new ItemVendor { ItemId = 7, VendorId = 4 },
                new ItemVendor { ItemId = 8, VendorId = 5 },
                new ItemVendor { ItemId = 9, VendorId = 7 },
                new ItemVendor { ItemId = 10, VendorId = 6 },
                new ItemVendor { ItemId = 11, VendorId = 6 },
                new ItemVendor { ItemId = 12, VendorId = 6 },
                new ItemVendor { ItemId = 13, VendorId = 5 },
                //Cleaning
                new ItemVendor { ItemId = 14, VendorId = 8 },
                new ItemVendor { ItemId = 15, VendorId = 8 },
                new ItemVendor { ItemId = 16, VendorId = 8 },
                new ItemVendor { ItemId = 17, VendorId = 9 },
                new ItemVendor { ItemId = 18, VendorId = 9 },
                new ItemVendor { ItemId = 19, VendorId = 10 },
                new ItemVendor { ItemId = 20, VendorId = 11 },
                new ItemVendor { ItemId = 21, VendorId = 11 },
                //Clothes
                new ItemVendor { ItemId = 22, VendorId = 12 },
                new ItemVendor { ItemId = 23, VendorId = 12 },
                new ItemVendor { ItemId = 24, VendorId = 13 },
                new ItemVendor { ItemId = 25, VendorId = 14 },
                new ItemVendor { ItemId = 26, VendorId = 14 },
                new ItemVendor { ItemId = 27, VendorId = 14 },
                new ItemVendor { ItemId = 28, VendorId = 14 },
                //Electronics
                new ItemVendor { ItemId = 29, VendorId = 2 },
                new ItemVendor { ItemId = 30, VendorId = 15 },
                new ItemVendor { ItemId = 31, VendorId = 15 },
                new ItemVendor { ItemId = 32, VendorId = 16 },
                new ItemVendor { ItemId = 33, VendorId = 15 },
                //Jewelry
                new ItemVendor { ItemId = 34, VendorId = 17 },
                new ItemVendor { ItemId = 35, VendorId = 17 },
                new ItemVendor { ItemId = 36, VendorId = 17 },
                new ItemVendor { ItemId = 37, VendorId = 18 },
                new ItemVendor { ItemId = 38, VendorId = 19 },
                //Shoes
                new ItemVendor { ItemId = 39, VendorId = 20 },
                new ItemVendor { ItemId = 40, VendorId = 20 },
                new ItemVendor { ItemId = 41, VendorId = 21 },
                new ItemVendor { ItemId = 42, VendorId = 21 },
                new ItemVendor { ItemId = 43, VendorId = 22 },
                new ItemVendor { ItemId = 44, VendorId = 22 },
                //Sports
                new ItemVendor { ItemId = 45, VendorId = 23 },
                new ItemVendor { ItemId = 46, VendorId = 23 },
                new ItemVendor { ItemId = 47, VendorId = 23 },
                new ItemVendor { ItemId = 48, VendorId = 24 },
                new ItemVendor { ItemId = 49, VendorId = 25 },
                new ItemVendor { ItemId = 50, VendorId = 25 },
                new ItemVendor { ItemId = 51, VendorId = 25 },
                //Tools
                new ItemVendor { ItemId = 52, VendorId = 26 },
                new ItemVendor { ItemId = 53, VendorId = 26 },
                new ItemVendor { ItemId = 54, VendorId = 27 },
                new ItemVendor { ItemId = 55, VendorId = 27 },
                new ItemVendor { ItemId = 56, VendorId = 27 },
                new ItemVendor { ItemId = 57, VendorId = 28 },
                new ItemVendor { ItemId = 58, VendorId = 28 },
                //Toys
                new ItemVendor { ItemId = 59, VendorId = 29 },
                new ItemVendor { ItemId = 60, VendorId = 29 },
                new ItemVendor { ItemId = 61, VendorId = 29 },
                new ItemVendor { ItemId = 62, VendorId = 30 },
                new ItemVendor { ItemId = 63, VendorId = 30 },
                new ItemVendor { ItemId = 64, VendorId = 30 }


            );
        }
    }

}

