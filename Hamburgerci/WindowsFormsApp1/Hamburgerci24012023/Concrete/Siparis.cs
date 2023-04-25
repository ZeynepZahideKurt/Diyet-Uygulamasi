using Hamburgerci24012023.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci24012023.Concrete
{

    public class Siparis
    {
        public Boyut Boyut { get; set; }
        public Menu Menu { get; set; }

        public List<Ekstra> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }
        public decimal  ToplamTutar{ get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.20M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.40M;
                    break;
            }
            foreach (var item in EkstraMalzemeler)
            {
                ToplamTutar += item.Fiyat;
            }
            ToplamTutar=ToplamTutar * Adet;
        }
        public override string ToString()
        {
            //Siparis siparis=new Siparis() .tostring();
            if (EkstraMalzemeler.Count < 1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy,Toplam:{3}", Menu.Adi, Adet, Boyut.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                //ekstra malzeme varsa
                string ekstraMalzemeler = null;
                foreach (var ekstra in EkstraMalzemeler)
                {
                    ekstraMalzemeler += ekstra.Adi + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(','); // son virgülü siler
                return string.Format("{0} Menü x {1} Adet, {2} Boy,({3}),Toplam: {4}", Menu.Adi, Adet, Boyut.ToString(),ekstraMalzemeler ,ToplamTutar.ToString("C2"));
            }
        }
    }
}
