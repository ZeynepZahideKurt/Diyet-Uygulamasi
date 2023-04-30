using HamburgerProject.Entity.Abstract;

namespace HamburgerProject.Entity.Concrete
{
    public class OrderDetails:BaseEntity
    {
        public ICollection<Menu> Menu { get; set; }

        public ICollection<Order> Order { get; set; }

        public ICollection<Extra> Extra { get; set; }
    }
}
