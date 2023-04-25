using HamburgerProject.Entity.Abstract;
using HamburgerProject.Entity.Enums;

namespace HamburgerProject.Entity.Concrete
{
    public class Order:BaseEntity
    {
        public Size Size { get; set; }
        public Menu Menu { get; set; }

        public List<Extra> Extras { get; set; }
        public int Piece { get; set; }
        public decimal TotalPrice { get; set; }

        public void Hesapla()
        {
            TotalPrice = 0;
            TotalPrice += Menu.Price;
            switch (Size)
            {
                case Size.Medium:
                    TotalPrice += TotalPrice * 0.20M;
                    break;
                case Size.Large:
                    TotalPrice += TotalPrice * 0.40M;
                    break;
            }
            foreach (var item in Extras)
            {
                TotalPrice += item.Price;
            }
            TotalPrice = TotalPrice * Piece;
        }
    }
}
