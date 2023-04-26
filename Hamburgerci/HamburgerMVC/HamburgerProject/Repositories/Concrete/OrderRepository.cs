using HamburgerProject.AppDbContext;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;
using HamburgerProject.Repositories.Abstract;
using System.IO.Pipelines;

namespace HamburgerProject.Repositories.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository,ICalculate
    {
        private readonly ApplicationDbContext db;

        public OrderRepository(ApplicationDbContext db) : base(db) 
        {
            this.db = db;
        }
        public double Calculate(Order order)
        {
            double TotalPrice = 0;
            TotalPrice += order.Menu.Price;

            switch (order.Size)
            {
                case Size.Medium:
                    TotalPrice += TotalPrice * 0.20;
                    break;
                case Size.Large:
                    TotalPrice += TotalPrice * 0.40;
                    break;
            }
            foreach (var item in order.Extras)
            {
                TotalPrice += item.Price;
            }
            TotalPrice = TotalPrice * order.Price;
            return TotalPrice;
        }
        
    }
}
