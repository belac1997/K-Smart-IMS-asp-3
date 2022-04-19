using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedVendors : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> entity)
        {
            entity.HasData(
                //Appliances
                new Vendor { Id = 1, Name = "Kenmore" },
                new Vendor { Id = 2, Name = "Samsung" },
                new Vendor { Id = 3, Name = "GE" },
                //Baby
                new Vendor { Id = 4, Name = "Evenflo" },
                new Vendor { Id = 5, Name = "Similac" },
                new Vendor { Id = 6, Name = "Gerber" },
                new Vendor { Id = 7, Name = "Chicco" },
                //Cleaning
                new Vendor { Id = 8, Name = "Dawn" },
                new Vendor { Id = 9, Name = "Clorox" },
                new Vendor { Id = 10, Name = "Lysol" },
                new Vendor { Id = 11, Name = "Glad" },
                //Clothes
                new Vendor { Id = 12, Name = "Dickies" },
                new Vendor { Id = 13, Name = "Gildan" },
                new Vendor { Id = 14, Name = "Route 66" },
                //Electronics
                new Vendor { Id = 15, Name = "Sony" },
                new Vendor { Id = 16, Name = "Nintendo" },
                //Jewelry
                new Vendor { Id = 17, Name = "Timex" },
                new Vendor { Id = 18, Name = "Pompeii" },
                new Vendor { Id = 19, Name = "Natalia Drake" },
                //Shoes
                new Vendor { Id = 20, Name = "Adidas" },
                new Vendor { Id = 21, Name = "Skechers" },
                new Vendor { Id = 22, Name = "Steve Madden" },
                //Sports
                new Vendor { Id = 23, Name = "Wilson" },
                new Vendor { Id = 24, Name = "MacGregor Golf" },
                new Vendor { Id = 25, Name = "Coleman" },
                //Tools
                new Vendor { Id = 26, Name = "Milwaukee" },
                new Vendor { Id = 27, Name = "Craftsman" },
                new Vendor { Id = 28, Name = "Stanley" },
                //Toys
                new Vendor { Id = 29, Name = "Hasbro" },
                new Vendor { Id = 30, Name = "Mattel" }

            );
        }
    }

}