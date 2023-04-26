using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Enums;
using System;

namespace HamburgerProject.Entity.Concrete
{
    public class Order:BaseEntity
    {
        public Order()
        {
            Extras = new HashSet<Extra>();
        }
        public Size Size { get; set; }

        public Menu Menu { get; set; }

        public ICollection<Extra> Extras { get; set; }


        public AppUser AppUser { get; set; }
        
        public int Piece { get; set; }
        public decimal TotalPrice { get; set; }

        
    }
}
