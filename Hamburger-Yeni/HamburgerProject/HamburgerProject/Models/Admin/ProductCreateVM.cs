using HamburgerProject.Entity.Concrete;

namespace HamburgerProject.Models.Admin
{
    public class ProductCreateVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Category>? Categories { get; set; }
        public int? CategoryId { get; set; }
    }
}
