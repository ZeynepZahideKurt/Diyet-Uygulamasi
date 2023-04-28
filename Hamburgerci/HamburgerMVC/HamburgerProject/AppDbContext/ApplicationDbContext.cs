using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Concrete;
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
        }
    }
}
