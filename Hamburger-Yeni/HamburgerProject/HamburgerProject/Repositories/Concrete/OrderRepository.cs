using HamburgerProject.AppDbContext;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;
using HamburgerProject.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;
using System.Linq.Expressions;

namespace HamburgerProject.Repositories.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext db;

        public OrderRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
            this.db = applicationDb;
        }

       
        public void Calculate(Order order)
        {
            double TotalPrice = 0;
            if (order.Products != null)
            {
                foreach (var item in order.Products)
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
            }

            
            //TotalPrice = TotalPrice * order.Piece;
            order.TotalPrice = TotalPrice;
        }

        public List<Order> GetAllMenuAndExtras()
        {
            return db.Orders.Include(a => a.Products).ToList();
        }

        public Order GetAllMenuAndExtras(int id)
        {
            var list=db.Orders.Include(a => a.Products).ToList();
            Order order = list.Where(a => a.Id == id).FirstOrDefault();
            return order;
        }
    }
}
