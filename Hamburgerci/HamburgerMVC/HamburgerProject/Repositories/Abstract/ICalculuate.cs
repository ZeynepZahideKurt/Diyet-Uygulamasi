using HamburgerProject.Entity.Concrete;
using HamburgerProject.Entity.Enums;

namespace HamburgerProject.Repositories.Abstract
{
    public interface ICalculate
    {
        void Calculate(Order order);
    }
}
