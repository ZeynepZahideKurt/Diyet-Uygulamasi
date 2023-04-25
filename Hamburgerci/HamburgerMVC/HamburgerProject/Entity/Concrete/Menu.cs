using HamburgerProject.Entity.Abstract;

namespace HamburgerProject.Entity.Concrete
{
    public class Menu:BaseEntity
    {
        public override string ToString()
        {
            return Name + " Menu";
        }
    }
}
