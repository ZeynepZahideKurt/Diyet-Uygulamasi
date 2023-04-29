using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static HamburgerProject.Entity.Concrete.Extra;
using static HamburgerProject.Entity.Concrete.Menu;
using static HamburgerProject.Entity.Concrete.Order;

namespace HamburgerProject.AppDbContext
{
    public class ApplicationDbContext: IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new MenuConfiguration());
            builder.ApplyConfiguration(new ExtraConfiguration());


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
                }
            );
        }
        
       







            







    }
}
