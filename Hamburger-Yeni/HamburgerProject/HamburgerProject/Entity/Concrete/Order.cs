using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamburgerProject.Entity.Concrete
{
    public class Order:BaseEntity
    {
        public Order()
        {
            Products = new List<Product>();

        }
        public int Piece { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        
        public AppUser AppUser { get; set; }

        public virtual ICollection<Product>? Products { get; set; }


        public class OrderConfiguration : IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order> builder)
            {
                builder.HasKey(o => o.Id);

                builder.HasMany(a => a.Products).WithMany(o => o.Orders).UsingEntity<OrderDetails>();
                builder.HasOne(a => a.AppUser).WithMany(o => o.Orders);
            }
        }
    }
}
