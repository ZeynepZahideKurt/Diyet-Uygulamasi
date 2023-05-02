using HamburgerProject.Entity.Concrete;

namespace HamburgerProject.Repositories.Abstract
{
    public interface IOrderRepository: IRepository<Order>, ICalculate
    {
        List<Order> GetAllMenuAndExtras();

        Order GetAllMenuAndExtras(int id);
      
    }
}
