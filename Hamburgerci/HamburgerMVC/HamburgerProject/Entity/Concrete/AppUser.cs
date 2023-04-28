using Microsoft.AspNetCore.Identity;

namespace HamburgerProject.Entity.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
