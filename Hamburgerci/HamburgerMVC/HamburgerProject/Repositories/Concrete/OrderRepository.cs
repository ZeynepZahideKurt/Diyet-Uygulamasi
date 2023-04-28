using HamburgerProject.AppDbContext;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;
using HamburgerProject.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;
using System.Linq.Expressions;

namespace HamburgerProject.Repositories.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository, ICalculate 
    {
        private readonly ApplicationDbContext db;

        public OrderRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
            this.db = db;
        }

       
        public void Calculate(Order order)
        {
            double TotalPrice = 0;
            foreach (var item in order.Menus)
            {
                switch (item.Size)
                {
                    case Size.Small:
                        TotalPrice = item.Price; 
                        break;
                    case Size.Medium:
                        TotalPrice += item.Price * 0.20;
                        break;
                    case Size.Large:
                        TotalPrice += item.Price * 0.40;
                        break;
                }
            }
            
            foreach (var item in order.Extras)
            {
                TotalPrice += item.Price;
            }
            //TotalPrice = TotalPrice * order.Piece;
            order.TotalPrice = TotalPrice;
        }

        public List<Order> GetAllMenuAndExtras()
        {
            return db.Orders.Include(a => a.Menus).Include(a=> a.Extras).ToList();
        }
    }
}
