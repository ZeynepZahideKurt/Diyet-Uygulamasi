using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.Entity.Concrete
{
    public class OrderDetails : BaseEntity
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }
     

        public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
        {
            public void Configure(EntityTypeBuilder<OrderDetails> builder)
            {
                builder.HasKey(o => o.Id);
                //builder.HasOne(a => a.Menu).WithMany(o => o.MenuOrders);
                //builder.HasOne(a => a.Order).WithMany(o => o.Menus);
            }

        }
        }
        
}
