using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedItems : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> entity)
        {
            entity.HasData(
                new Item { Id = 1, Name = "Dawn Dish Soap", CategoryId = "Cleaning", Price = 15.00 }
            );
        }
    }

}
