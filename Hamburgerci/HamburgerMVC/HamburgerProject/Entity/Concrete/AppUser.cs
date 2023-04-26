using Microsoft.AspNetCore.Identity;

namespace HamburgerProject.Entity.Concrete
{
    public class AppUser: IdentityUser
    {
        public AppUser()
        {
            Orders = new HashSet<Order>();
            Extras = new HashSet<Extra>();
            Menus = new HashSet<Menu>();
        }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Extra> Extras { get; set; }
        public ICollection<Menu> Menus { get; set; }

    }
}
