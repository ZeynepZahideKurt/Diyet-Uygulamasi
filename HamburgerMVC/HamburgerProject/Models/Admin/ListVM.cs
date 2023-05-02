using HamburgerProject.Entity.Concrete;

namespace HamburgerProject.Models.Admin
{
    public class ListVM
    {
        public List<Extra> Extras { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
