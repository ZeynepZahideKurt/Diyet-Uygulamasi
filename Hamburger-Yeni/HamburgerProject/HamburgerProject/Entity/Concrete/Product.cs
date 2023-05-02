using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using HamburgerProject.Entity.Enums;

namespace HamburgerProject.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

        public Product()
        {
           
            Orders = new List<Order>();
        }
        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                builder.HasKey(o => o.Id);
                //builder.HasOne(o => o.Order).WithOne(o => o.Menu).HasForeignKey<Menu>("OrderId");
                builder.HasOne(o => o.Category).WithMany(a => a.Products);
            }
        }
    }
}
