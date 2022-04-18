using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


namespace K_Smart_IMS.Models
{
    public class InventoryContext : IdentityDbContext<User>
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        { }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemVendor> ItemVendors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderArchive> OrderArchives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ItemVendor: set primary key 
            modelBuilder.Entity<ItemVendor>().HasKey(ba => new { ba.ItemId, ba.VendorId });

            // ItemVendor: set foreign keys 
            modelBuilder.Entity<ItemVendor>().HasOne(ba => ba.Item)
                .WithMany(b => b.ItemVendors)
                .HasForeignKey(ba => ba.ItemId);
            modelBuilder.Entity<ItemVendor>().HasOne(ba => ba.Vendor)
                .WithMany(a => a.ItemVendors)
                .HasForeignKey(ba => ba.VendorId);

            // Item: remove cascading delete with Category
            modelBuilder.Entity<Item>().HasOne(b => b.Category)
                .WithMany(g => g.Items)
                .OnDelete(DeleteBehavior.Restrict);

            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedCategories());
            modelBuilder.ApplyConfiguration(new SeedItems());
            modelBuilder.ApplyConfiguration(new SeedVendors());
            modelBuilder.ApplyConfiguration(new SeedItemVendors());
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "Senior Project!";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}