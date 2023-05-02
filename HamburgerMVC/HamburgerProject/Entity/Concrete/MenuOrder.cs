using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.Entity.Concrete
{
    public class MenuOrder : BaseEntity
    {
        public int OrderId { get; set; }
       

        public int MenuId { get; set; }
     

        public class MenuOrderConfiguration : IEntityTypeConfiguration<MenuOrder>
        {
            public void Configure(EntityTypeBuilder<MenuOrder> builder)
            {
                builder.HasKey(o => o.Id);
                //builder.HasOne(a => a.Menu).WithMany(o => o.MenuOrders);
                //builder.HasOne(a => a.Order).WithMany(o => o.Menus);
            }

        }
        }
        
}
