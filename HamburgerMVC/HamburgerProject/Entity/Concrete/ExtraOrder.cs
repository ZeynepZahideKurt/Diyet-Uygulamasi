using HamburgerProject.Entity.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.Entity.Concrete
{
    public class ExtraOrder:BaseEntity
    {
        public int OrderId { get; set; }
       

        public int ExtraId { get; set; }
       

        public class MenuOrderConfiguration : IEntityTypeConfiguration<ExtraOrder>
        {
            public void Configure(EntityTypeBuilder<ExtraOrder> builder)
            {
                builder.HasKey(o => o.Id);
                //builder.HasOne(a => a.Extra).WithMany(o => o.ExtraOrder);
                //builder.HasOne(a => a.Order).WithMany(o => o.Extras);
            }

        }
    }
}
