using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K_Smart_IMS.Models
{
    internal class SeedItems : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> entity)
        {
            entity.HasData(
                //Appliances
                new Item { Id = 1, Name = "Kenmore Countertop Microwave", CategoryId = "Appliances", Price = 116.99, Qty = 3 },
                new Item { Id = 2, Name = "Kenmore Slide-In Gas Range with Turbo Boil", CategoryId = "Appliances", Price = 1554.69, Qty = 4 },
                new Item { Id = 3, Name = "Samsung Elite 4-door Fridge", CategoryId = "Appliances", Price = 2229.99, Qty = 2 },
                new Item { Id = 4, Name = "Kenmore Enery Star Top-Load Washer", CategoryId = "Appliances", Price = 854.99, Qty = 5 },
                new Item { Id = 5, Name = "Front Load Gas Dryer", CategoryId = "Appliances", Price = 767.99, Qty = 3 },
                new Item { Id = 6, Name = "Front Load Electric Dryer", CategoryId = "Appliances", Price = 724.99, Qty = 2 },
                //Baby
                new Item { Id = 7, Name = "Evenflo Angled Feeding Bottle, 4pk", CategoryId = "Baby", Price = 13.99, Qty = 9 },
                new Item { Id = 8, Name = "Anti-Bacterial Bottle Covers, 6pk", CategoryId = "Baby", Price = 9.99, Qty = 12 },
                new Item { Id = 9, Name = "Chicco Glow-in-the-Dark Pacifier", CategoryId = "Baby", Price = 8.49, Qty = 8 },
                new Item { Id = 10, Name = "Pumpkin & Banana Pureed Baby Food, 8pk", CategoryId = "Baby", Price = 19.89, Qty = 17 },
                new Item { Id = 11, Name = "Carrot and Squash Pureed Baby Food, 8pk", CategoryId = "Baby", Price = 19.49, Qty = 15 },
                new Item { Id = 12, Name = "Turkey and Peas Pureed Baby Food, 8pk", CategoryId = "Baby", Price = 21.09, Qty = 12 },
                new Item { Id = 13, Name = "Similac Soy Isomil Infant Formula w/ Iron", CategoryId = "Baby", Price = 36.99, Qty = 10 },
                //Cleaning
                new Item { Id = 14, Name = "Dawn Ultra Liquid Dishwashing Dish Soap", CategoryId = "Cleaning", Price = 4.99, Qty = 13 },
                new Item { Id = 15, Name = "Dawn Antibacterial Dishwashing Liquid Dish Soap, Orange Scent", CategoryId = "Cleaning", Price = 5.99, Qty = 10 },
                new Item { Id = 16, Name = "Dawn Ultra Bottle Brush", CategoryId = "Cleaning", Price = 3.49, Qty = 9 },
                new Item { Id = 17, Name = "Clorox Splashless Bleach", CategoryId = "Cleaning", Price = 9.09, Qty = 15 },
                new Item { Id = 18, Name = "Clorox Pro Results Regular Scent Outdoor Bleach", CategoryId = "Cleaning", Price = 9.09, Qty = 10 },
                new Item { Id = 19, Name = "Lysol Linen Disenfectant Spray, 2-pk", CategoryId = "Cleaning", Price = 7.49, Qty = 23 },
                new Item { Id = 20, Name = "Glad Lemon Scented 13-gal Kitchen Bags, 110pk", CategoryId = "Cleaning", Price = 14.99, Qty = 8 },
                new Item { Id = 21, Name = "Glad Force Flex 13-gal Kitchen Bags, 110pk", CategoryId = "Cleaning", Price = 16.99, Qty = 9 },
                //Clothes
                new Item { Id = 22, Name = "Men's Short Sleeve Work Shirt", CategoryId = "Clothes", Price = 12.99, Qty = 15 },
                new Item { Id = 23, Name = "Men's Fleece Plaid Shirt Jacket", CategoryId = "Clothes", Price = 27.69, Qty = 9 },
                new Item { Id = 24, Name = "Men's Hooded Sweatshirt", CategoryId = "Clothes", Price = 19.99, Qty = 11 },
                new Item { Id = 25, Name = "Women's Skinny Jeans", CategoryId = "Clothes", Price = 20.99, Qty = 3 },
                new Item { Id = 26, Name = "Men's Straight Leg Pants", CategoryId = "Clothes", Price = 17.99, Qty = 8 },
                new Item { Id = 27, Name = "Women's Utility Jacket", CategoryId = "Clothes", Price = 14.99, Qty = 6 },
                new Item { Id = 28, Name = "Men's Denim Jacket", CategoryId = "Clothes", Price = 28.99, Qty = 5 },
                //Electronics
                new Item { Id = 29, Name = "82in Class Ultra High Definition Crystal 4K Smart TV", CategoryId = "Electronics", Price = 1119.99, Qty = 5 },
                new Item { Id = 30, Name = "50in X85J 4K HDR LED TV", CategoryId = "Electronics", Price = 999.99, Qty = 4 },
                new Item { Id = 31, Name = "Home Audio Radio CD/Cassette Boombox", CategoryId = "Electronics", Price = 69.99, Qty = 11 },
                new Item { Id = 32, Name = "Nintendo Switch Lite Handheld Console - Gray", CategoryId = "Electronics", Price = 234.99, Qty = 7 },
                new Item { Id = 33, Name = "Sony PlayStation 5 DualSense Wireless Controller PS5 - White", CategoryId = "Electronics", Price = 67.99, Qty = 10 },
                //Jewelry
                new Item { Id = 34, Name = "Timex Main Street Classic Silver Tone Stainless Steel Watch", CategoryId = "Jewelry", Price = 209.49, Qty = 1 },
                new Item { Id = 35, Name = "Timex Kids Machines Soccer Watch", CategoryId = "Jewelry", Price = 29.99, Qty = 9 },
                new Item { Id = 36, Name = "Timex Women's Miami Bracelet 20mm Nylon Strap Watch", CategoryId = "Jewelry", Price = 89.99, Qty = 4 },
                new Item { Id = 37, Name = "Pompeii 1/3ct Diamond Studs 14K Yellow Gold", CategoryId = "Jewelry", Price = 114.99, Qty = 2 },
                new Item { Id = 38, Name = "Giant 2.00CTW Reversible Genuine Diamond White Heart Pendant Necklace", CategoryId = "Jewelry", Price = 99.99, Qty = 4 },
                //Shoes
                new Item { Id = 39, Name = "Adidas Nite Jogger Men's Shoes White-Black-Signal Green", CategoryId = "Shoes", Price = 96.99, Qty = 10 },
                new Item { Id = 40, Name = "Adidas UltraBoost 5.0 DNA Men's Shoes Cloud White", CategoryId = "Shoes", Price = 78.69, Qty = 3 },
                new Item { Id = 41, Name = "Skechers Performance Womens Go Walk Lite", CategoryId = "Shoes", Price = 35.99, Qty = 8 },
                new Item { Id = 42, Name = "Skechers Women's Empress Solo Mood Slip On", CategoryId = "Shoes", Price = 45.99, Qty = 7 },
                new Item { Id = 43, Name = "Steve Madden Mens Boxxeer Lace Up Oxford Shoe", CategoryId = "Shoes", Price = 79.99, Qty = 6 },
                new Item { Id = 44, Name = "Steve Madden Womens NONSTP Heeled Sandal", CategoryId = "Shoes", Price = 85.99, Qty = 4 },
                //Sports
                new Item { Id = 45, Name = "Wilson Football Official Duke NFL Goodell", CategoryId = "Sports", Price = 88.99, Qty = 14 },
                new Item { Id = 46, Name = "Wilson Evolution Intermediate Size Game Basketball", CategoryId = "Sports", Price = 54.69, Qty = 9 },
                new Item { Id = 47, Name = "Wilson Sporting Goods Serena 21 Inch Junior Tennis Racquet", CategoryId = "Sports", Price = 29.99, Qty = 10 },
                new Item { Id = 48, Name = "Premium Mens Golf Clubs Set, Right Hand", CategoryId = "Sports", Price = 554.99, Qty = 3 },
                new Item { Id = 49, Name = "Coleman Dome Tent w/ Screen Room", CategoryId = "Sports", Price = 177.99, Qty = 4 },
                new Item { Id = 50, Name = "LED Green Battery Lantern", CategoryId = "Sports", Price = 24.99, Qty = 6 },
                new Item { Id = 51, Name = "Stearns Infinity Floating Vest", CategoryId = "Sports", Price = 33.99, Qty = 1 },
                //Tools
                new Item { Id = 52, Name = "12-Volt Lithium-Ion Cordless 1/4 in. Hex Screwdriver", CategoryId = "Tools", Price = 66.99, Qty = 5 },
                new Item { Id = 53, Name = "M18 FUEL 16in Chainsaw Kit", CategoryId = "Tools", Price = 754.69, Qty = 3 },
                new Item { Id = 54, Name = "Craftsman 165-Piece Mechanic Tool Set", CategoryId = "Tools", Price = 129.99, Qty = 3 },
                new Item { Id = 55, Name = "Craftsman 14 pc. Combination Wrench Set", CategoryId = "Tools", Price = 19.99, Qty = 10 },
                new Item { Id = 56, Name = "Craftsman 5-Piece Phillips Screwdriver Set", CategoryId = "Tools", Price = 12.99, Qty = 7 },
                new Item { Id = 57, Name = "Stanley 19-Inch Toolbox w/ AutoLatch", CategoryId = "Tools", Price = 27.99, Qty = 6 },
                new Item { Id = 58, Name = "Stanley Hacksaw, Black/Yellow", CategoryId = "Tools", Price = 14.99, Qty = 9 },
                //Toys
                new Item { Id = 59, Name = "Guess Who? Classic Game", CategoryId = "Toys", Price = 14.99, Qty = 11 },
                new Item { Id = 60, Name = "Classic Jenga Game", CategoryId = "Toys", Price = 14.69, Qty = 12 },
                new Item { Id = 61, Name = "Classic Operation Game", CategoryId = "Toys", Price = 29.99, Qty = 4 },
                new Item { Id = 62, Name = "Barbie Spin ‘n Twirl Gymnast Doll and Accessories", CategoryId = "Toys", Price = 24.99, Qty = 7 },
                new Item { Id = 63, Name = "Barbie Dreamhouse Adventures Tiki Hut", CategoryId = "Toys", Price = 29.99, Qty = 5 },
                new Item { Id = 64, Name = "Hot Wheels Mega Car Wash Play Set", CategoryId = "Toys", Price = 44.99, Qty = 4 }
            );
        }
    }

}
