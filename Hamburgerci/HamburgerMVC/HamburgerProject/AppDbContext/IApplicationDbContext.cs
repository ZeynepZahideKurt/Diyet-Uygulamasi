using HamburgerProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.AppDbContext
{
    public interface IApplicationDbContext
    {
        DbSet<Extra> Extras { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}