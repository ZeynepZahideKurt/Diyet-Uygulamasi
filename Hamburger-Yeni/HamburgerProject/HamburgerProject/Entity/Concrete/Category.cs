using HamburgerProject.Entity.Abstract;

namespace HamburgerProject.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
