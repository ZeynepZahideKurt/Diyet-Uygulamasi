using HamburgerProject.AppDbContext;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;
using HamburgerProject.Repositories.Abstract;
using System.IO.Pipelines;
using System.Linq.Expressions;

namespace HamburgerProject.Repositories.Concrete
{
    public class OrderRepository :  IOrderRepository, ICalculate 
    {
        private readonly ApplicationDbContext db;

        public OrderRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool Add(Order entity)
        {
            db.Add(entity);
            return db.SaveChanges() > 0;
        }

        public double Calculate(Order order)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetWhere(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
