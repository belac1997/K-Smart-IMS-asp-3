using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedCategories : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category { Id = "Appliances", Name = "Appliances" },
                new Category { Id = "Baby", Name = "Baby" },
                new Category { Id = "Cleaning", Name = "Cleaning" },
                new Category { Id = "Clothes", Name = "Clothes" },
                new Category { Id = "Electronics", Name = "Electronics" },
                new Category { Id = "Jewelry", Name = "Jewelry" },
                new Category { Id = "Shoes", Name = "Shoes" },
                new Category { Id = "Sports", Name = "Sports" },
                new Category { Id = "Tools", Name = "Tools" },
                new Category { Id = "Toys", Name = "Toys" }
            );
        }
    }

}
