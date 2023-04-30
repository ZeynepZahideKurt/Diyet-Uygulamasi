using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.Entity.Concrete
{
    public class Extra:BaseEntity
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

        public int Quantity { get; set; }

        public Extra()
        {
            Orders = new List<Order>();
        }
        public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
        {
            public void Configure(EntityTypeBuilder<Extra> builder)
            {
                builder.HasKey(o => o.Id);

            }
        }
    }
}
