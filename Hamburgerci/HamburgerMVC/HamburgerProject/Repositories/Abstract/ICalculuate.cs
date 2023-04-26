using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;

namespace HamburgerProject.Repositories.Abstract
{
    public interface ICalculate
    {
        double Calculate(Order order);
    }
}
