using HastaneOtomasyon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Abstract
{
    public abstract class Personel
    {        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        //Maaş 0 dan küçük işe doktor maaşı otomatik olarak 25000 lira atansın
        private double _Maas;
        public double Maas
        {
            get { return _Maas; }
            set
            {
                if (value < 0)
                {
                    _Maas = 25000;
                }
                else if (value < 15000)
                {
                    _Maas = 20000;
                }
                else
                    _Maas = value;
            }

            //Kapsüllemede value dışarıdan yani kullanıcının verdiği değeri ifade eder.
        }
       
        public Bina Bina { get; set; }

        //public void AmeliyatYap()
        //{
        //    MessageBox.Show("Kırık çıkık ne varsa ameliyat eder düzeltirim. Gerekirse platin takar birleştiririm.");
        //}

        //public void MuayeneEt()
        //{
        //    DialogResult dialogResult = MessageBox.Show("Röntgen çektirdin mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        MessageBox.Show("Röntgen sonucununu inceleyip muayene edeceğim.");
        //    }
        //    else
        //        MessageBox.Show("Röntgen çektir ondan sonra yanıma gel aslan parçası!!");

        //}
        //public void ParaAl()
        //{
        //    MessageBox.Show($"Doner Sermayeden Bu Kadar Para Alırım : {DonerSermayeParasi} , Toplam Kazancım : {_Maas + DonerSermayeParasi}");
        //}
    }
}
