using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using HamburgerProject.Entity.Enums;

namespace HamburgerProject.Entity.Concrete
{
    public class Menu:BaseEntity
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public double Price { get; set; }

        //public int OrderId { get; set; }
        //public virtual Order Order { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public class MenuConfiguration : IEntityTypeConfiguration<Menu>
        {
            public void Configure(EntityTypeBuilder<Menu> builder)
            {
                builder.HasKey(o => o.Id);
                //builder.HasOne(o => o.Order).WithOne(o => o.Menu).HasForeignKey<Menu>("OrderId");
            }
        }
    }
}
