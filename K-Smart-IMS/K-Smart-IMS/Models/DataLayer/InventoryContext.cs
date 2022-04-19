using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


namespace K_Smart_IMS.Models
{
    /* The meat of the project, the database context class that gets fired up in startup.cs
     * This thing increasingly became a mess and I'm sorry it's not more modularized. I ended up seeding user
     * data here because for some reason it was a giant pain trying to do it elsewhere
     * Contributed by Cody Tran
    */
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
            //I know this looks freaking awful but at least it works, right? Ha ha..
            string username = "admin";
            string manUsername = "manager";
            string employeeUsername = "employee";
            string password = "SFcollege123";
            string roleName = "Admin";
            string manRoleName = "Manager";
            string employeeRoleName = "Employee";

            //if role doesn't exist yet, which it won't since the DB is just being created, create this role
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            if (await roleManager.FindByNameAsync(manRoleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(manRoleName));
            }

            if (await roleManager.FindByNameAsync(employeeRoleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(employeeRoleName));
            }

            //if the username don't exist yet, create it
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
            if (await userManager.FindByNameAsync(manUsername) == null)
            {
                User user = new User { UserName = manUsername };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, manRoleName);
                }
            }
            if (await userManager.FindByNameAsync(employeeUsername) == null)
            {
                User user = new User { UserName = employeeUsername };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, employeeRoleName);
                }
            }
        }
    }
}