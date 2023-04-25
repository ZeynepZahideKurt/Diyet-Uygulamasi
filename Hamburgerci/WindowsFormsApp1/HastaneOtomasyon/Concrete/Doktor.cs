using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Enums;
using HastaneOtomasyon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Concrete
{
    internal class Doktor : Personel, ISil, IMuayane, IKanAl,IAlan
    {
        public Alan Alan { get; set; }=Alan.Acil;

        public void CamSil()
        {
            //
        }

        public void KanAl()
        {
            //
        }

        public void KanalAc()
        {
            //
        }

        public void MuayaneEt()
        {
            //
        }

        public void TemilzikYap()
        {
            //
        }
    }
}
