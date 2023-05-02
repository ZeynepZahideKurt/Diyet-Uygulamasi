using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static HamburgerProject.Entity.Concrete.Product;
using static HamburgerProject.Entity.Concrete.Order;
using static HamburgerProject.Entity.Concrete.OrderDetails;

namespace HamburgerProject.AppDbContext
{
    public class ApplicationDbContext: IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
     
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public DbSet<MenuOrder> MenuOrders { get; set; }
        //public DbSet<ExtraOrder> ExtraOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OrderDetailsConfiguration());



            //Seeding a  'Admin' role to AspNetRoles table
            builder.Entity<AppRole>().HasData(new AppRole { Id = 1, Name = Entity.Enums.Roles.Admin.ToString(), NormalizedName = Entity.Enums.Roles.Admin.ToString().ToUpper() });
            builder.Entity<AppRole>().HasData(new AppRole { Id =2, Name = Entity.Enums.Roles.User.ToString(), NormalizedName = Entity.Enums.Roles.User.ToString().ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();


            //Seeding the User to AspNetUsers table
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 1, // primary key
                    Email="admin@gmail.com",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "1234")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                });

                  //Seeding the User to AspNetUsers table
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 2, // primary key
                    Email = "benuser@gmail.com",
                    UserName = "User",
                    NormalizedUserName = "USER",
                    PasswordHash = hasher.HashPassword(null, "123456789")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 2,
                    UserId = 2
                }
            );
        }
        
       







            







    }
}
