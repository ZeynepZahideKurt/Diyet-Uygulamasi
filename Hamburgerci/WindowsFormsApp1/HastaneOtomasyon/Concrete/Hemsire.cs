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
    internal class Hemsire : Personel, ISil, IKanAl, IAlan
    {
        public Alan Alan { get; set; }

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

        public void TemilzikYap()
        {
            //
        }
    }
}
