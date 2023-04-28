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
            Extras = new List<Extra>();
            Menus = new List<Menu>();
           
        }
        
        //public int Piece { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; }=DateTime.Now;

        
        public AppUser AppUser { get; set; }
        //public int MenuId { get; set; }
        //public virtual Menu Menu { get; set; }

        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }

        public class OrderConfiguration : IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order> builder)
            {
                builder.HasKey(o => o.Id);
                builder.HasMany(a => a.Extras).WithMany(o => o.Orders);
                builder.HasMany(a => a.Menus).WithMany(o => o.Orders);
                builder.HasOne(a=>a.AppUser).WithMany(o => o.Orders);
            }
        }
    }
}
