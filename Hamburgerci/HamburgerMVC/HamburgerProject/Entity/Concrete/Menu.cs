using HamburgerProject.Entity.Abstract;

namespace HamburgerProject.Entity.Concrete
{
    public class Menu:BaseEntity
    {
        public AppUser AppUser { get; set; }
        
    }
}
