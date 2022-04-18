using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace K_Smart_IMS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CategoryId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemVendors",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVendors", x => new { x.ItemId, x.VendorId });
                    table.ForeignKey(
                        name: "FK_ItemVendors_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "Appliances", "Appliances" },
                    { "Baby", "Baby" },
                    { "Cleaning", "Cleaning" },
                    { "Clothes", "Clothes" },
                    { "Electronics", "Electronics" },
                    { "Jewelry", "Jewelry" },
                    { "Shoes", "Shoes" },
                    { "Sports", "Sports" },
                    { "Tools", "Tools" },
                    { "Toys", "Toys" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 17, "Timex" },
                    { 18, "Pompeii" },
                    { 19, "Natalia Drake" },
                    { 20, "Adidas" },
                    { 21, "Skechers" },
                    { 22, "Steve Madden" },
                    { 27, "Craftsman" },
                    { 24, "MacGregor Golf" },
                    { 25, "Coleman" },
                    { 26, "Milwaukee" },
                    { 16, "Nintendo" },
                    { 28, "Stanley" },
                    { 23, "Wilson" },
                    { 15, "Sony" },
                    { 10, "Lysol" },
                    { 13, "Gildan" },
                    { 12, "Dickies" },
                    { 11, "Glad" },
                    { 29, "Hasbro" },
                    { 9, "Clorox" },
                    { 8, "Dawn" },
                    { 7, "Chicco" },
                    { 6, "Gerber" },
                    { 5, "Similac" },
                    { 4, "Evenflo" },
                    { 3, "GE" },
                    { 2, "Samsung" },
                    { 1, "Kenmore" },
                    { 14, "Route 66" },
                    { 30, "Mattel" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, "Appliances", "Kenmore Countertop Microwave", 116.98999999999999, 3 },
                    { 35, "Jewelry", "Timex Kids Machines Soccer Watch", 29.989999999999998, 9 },
                    { 36, "Jewelry", "Timex Women's Miami Bracelet 20mm Nylon Strap Watch", 89.989999999999995, 4 },
                    { 37, "Jewelry", "Pompeii 1/3ct Diamond Studs 14K Yellow Gold", 114.98999999999999, 2 },
                    { 38, "Jewelry", "Giant 2.00CTW Reversible Genuine Diamond White Heart Pendant Necklace", 99.989999999999995, 4 },
                    { 39, "Shoes", "Adidas Nite Jogger Men's Shoes White-Black-Signal Green", 96.989999999999995, 10 },
                    { 40, "Shoes", "Adidas UltraBoost 5.0 DNA Men's Shoes Cloud White", 78.689999999999998, 3 },
                    { 41, "Shoes", "Skechers Performance Womens Go Walk Lite", 35.990000000000002, 8 },
                    { 42, "Shoes", "Skechers Women's Empress Solo Mood Slip On", 45.990000000000002, 7 },
                    { 43, "Shoes", "Steve Madden Mens Boxxeer Lace Up Oxford Shoe", 79.989999999999995, 6 },
                    { 44, "Shoes", "Steve Madden Womens NONSTP Heeled Sandal", 85.989999999999995, 4 },
                    { 45, "Sports", "Wilson Football Official Duke NFL Goodell", 88.989999999999995, 14 },
                    { 46, "Sports", "Wilson Evolution Intermediate Size Game Basketball", 54.689999999999998, 9 },
                    { 47, "Sports", "Wilson Sporting Goods Serena 21 Inch Junior Tennis Racquet", 29.989999999999998, 10 },
                    { 34, "Jewelry", "Timex Main Street Classic Silver Tone Stainless Steel Watch", 209.49000000000001, 1 },
                    { 48, "Sports", "Premium Mens Golf Clubs Set, Right Hand", 554.99000000000001, 3 },
                    { 50, "Sports", "LED Green Battery Lantern", 24.989999999999998, 6 },
                    { 51, "Sports", "Stearns Infinity Floating Vest", 33.990000000000002, 1 },
                    { 52, "Tools", "12-Volt Lithium-Ion Cordless 1/4 in. Hex Screwdriver", 66.989999999999995, 5 },
                    { 53, "Tools", "M18 FUEL 16in Chainsaw Kit", 754.69000000000005, 3 },
                    { 54, "Tools", "Craftsman 165-Piece Mechanic Tool Set", 129.99000000000001, 3 },
                    { 55, "Tools", "Craftsman 14 pc. Combination Wrench Set", 19.989999999999998, 10 },
                    { 56, "Tools", "Craftsman 5-Piece Phillips Screwdriver Set", 12.99, 7 },
                    { 57, "Tools", "Stanley 19-Inch Toolbox w/ AutoLatch", 27.989999999999998, 6 },
                    { 58, "Tools", "Stanley Hacksaw, Black/Yellow", 14.99, 9 },
                    { 59, "Toys", "Guess Who? Classic Game", 14.99, 11 },
                    { 60, "Toys", "Classic Jenga Game", 14.69, 12 },
                    { 61, "Toys", "Classic Operation Game", 29.989999999999998, 4 },
                    { 62, "Toys", "Barbie Spin ‘n Twirl Gymnast Doll and Accessories", 24.989999999999998, 7 },
                    { 49, "Sports", "Coleman Dome Tent w/ Screen Room", 177.99000000000001, 4 },
                    { 33, "Electronics", "Sony PlayStation 5 DualSense Wireless Controller PS5 - White", 67.989999999999995, 10 },
                    { 32, "Electronics", "Nintendo Switch Lite Handheld Console - Gray", 234.99000000000001, 7 },
                    { 31, "Electronics", "Home Audio Radio CD/Cassette Boombox", 69.989999999999995, 11 },
                    { 2, "Appliances", "Kenmore Slide-In Gas Range with Turbo Boil", 1554.6900000000001, 4 },
                    { 3, "Appliances", "Samsung Elite 4-door Fridge", 2229.9899999999998, 2 },
                    { 4, "Appliances", "Kenmore Enery Star Top-Load Washer", 854.99000000000001, 5 },
                    { 5, "Appliances", "Front Load Gas Dryer", 767.99000000000001, 3 },
                    { 6, "Appliances", "Front Load Electric Dryer", 724.99000000000001, 2 },
                    { 7, "Baby", "Evenflo Angled Feeding Bottle, 4pk", 13.99, 9 },
                    { 8, "Baby", "Anti-Bacterial Bottle Covers, 6pk", 9.9900000000000002, 12 },
                    { 9, "Baby", "Chicco Glow-in-the-Dark Pacifier", 8.4900000000000002, 8 },
                    { 10, "Baby", "Pumpkin & Banana Pureed Baby Food, 8pk", 19.890000000000001, 17 },
                    { 11, "Baby", "Carrot and Squash Pureed Baby Food, 8pk", 19.489999999999998, 15 },
                    { 12, "Baby", "Turkey and Peas Pureed Baby Food, 8pk", 21.09, 12 },
                    { 13, "Baby", "Similac Soy Isomil Infant Formula w/ Iron", 36.990000000000002, 10 },
                    { 14, "Cleaning", "Dawn Ultra Liquid Dishwashing Dish Soap", 4.9900000000000002, 13 },
                    { 15, "Cleaning", "Dawn Antibacterial Dishwashing Liquid Dish Soap, Orange Scent", 5.9900000000000002, 10 },
                    { 16, "Cleaning", "Dawn Ultra Bottle Brush", 3.4900000000000002, 9 },
                    { 17, "Cleaning", "Clorox Splashless Bleach", 9.0899999999999999, 15 },
                    { 18, "Cleaning", "Clorox Pro Results Regular Scent Outdoor Bleach", 9.0899999999999999, 10 },
                    { 19, "Cleaning", "Lysol Linen Disenfectant Spray, 2-pk", 7.4900000000000002, 23 },
                    { 20, "Cleaning", "Glad Lemon Scented 13-gal Kitchen Bags, 110pk", 14.99, 8 },
                    { 21, "Cleaning", "Glad Force Flex 13-gal Kitchen Bags, 110pk", 16.989999999999998, 9 },
                    { 22, "Clothes", "Men's Short Sleeve Work Shirt", 12.99, 15 },
                    { 23, "Clothes", "Men's Fleece Plaid Shirt Jacket", 27.690000000000001, 9 },
                    { 24, "Clothes", "Men's Hooded Sweatshirt", 19.989999999999998, 11 },
                    { 25, "Clothes", "Women's Skinny Jeans", 20.989999999999998, 3 },
                    { 26, "Clothes", "Men's Straight Leg Pants", 17.989999999999998, 8 },
                    { 27, "Clothes", "Women's Utility Jacket", 14.99, 6 },
                    { 28, "Clothes", "Men's Denim Jacket", 28.989999999999998, 5 },
                    { 29, "Electronics", "82in Class Ultra High Definition Crystal 4K Smart TV", 1119.99, 5 },
                    { 30, "Electronics", "50in X85J 4K HDR LED TV", 999.99000000000001, 4 },
                    { 63, "Toys", "Barbie Dreamhouse Adventures Tiki Hut", 29.989999999999998, 5 },
                    { 64, "Toys", "Hot Wheels Mega Car Wash Play Set", 44.990000000000002, 4 }
                });

            migrationBuilder.InsertData(
                table: "ItemVendors",
                columns: new[] { "ItemId", "VendorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 35, 17 },
                    { 36, 17 },
                    { 37, 18 },
                    { 38, 19 },
                    { 39, 20 },
                    { 40, 20 },
                    { 41, 21 },
                    { 42, 21 },
                    { 43, 22 },
                    { 44, 22 },
                    { 45, 23 },
                    { 46, 23 },
                    { 47, 23 },
                    { 34, 17 },
                    { 48, 24 },
                    { 50, 25 },
                    { 51, 25 },
                    { 52, 26 },
                    { 53, 26 },
                    { 54, 27 },
                    { 55, 27 },
                    { 56, 27 },
                    { 57, 28 },
                    { 58, 28 },
                    { 59, 29 },
                    { 60, 29 },
                    { 61, 29 },
                    { 62, 30 },
                    { 49, 25 },
                    { 33, 15 },
                    { 32, 16 },
                    { 31, 15 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 5 },
                    { 9, 7 },
                    { 10, 6 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 5 },
                    { 14, 8 },
                    { 15, 8 },
                    { 16, 8 },
                    { 17, 9 },
                    { 18, 9 },
                    { 19, 10 },
                    { 20, 11 },
                    { 21, 11 },
                    { 22, 12 },
                    { 23, 12 },
                    { 24, 13 },
                    { 25, 14 },
                    { 26, 14 },
                    { 27, 14 },
                    { 28, 14 },
                    { 29, 2 },
                    { 30, 15 },
                    { 63, 30 },
                    { 64, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVendors_VendorId",
                table: "ItemVendors",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ItemVendors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
