using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;
using HamburgerProject.Repositories.Abstract;
using Microsoft.Build.Framework;

namespace HamburgerProject.Models.Customer
{
    public class AddOrderVM
    {
        public AddOrderVM()
        {
            CustomerExtras = new List<Extra>();
            AdminExtras = new List<Extra>();
            CustomerMenus= new List<Menu>();
            AdminMenus = new List<Menu>();
        }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int UserId { get; set; }
        public Size size   { get; set; }

        public List<Menu>? AdminMenus { get; set; }

        public List<Extra>? AdminExtras { get; set; }

        public List<Menu>? CustomerMenus { get; set; }

        public List<Extra>? CustomerExtras { get; set; }

        public int MenuId { get; set; }

        public int ExtraId { get; set; }

        public int ExtraQuantity { get; set; }
        public int MenuQuantity { get; set; }
        public DateTime CreateTime { get; set; }= DateTime.Now;

        public double Totalprice { get; set; }
    }
}
