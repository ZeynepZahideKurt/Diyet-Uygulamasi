using HastaneOtomasyon.Abstract;
using HastaneOtomasyon.Concrete;
using HastaneOtomasyon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
       public static Dictionary<string, Personel> PersonelList;
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            PersonelList = new Dictionary<string, Personel>();
            Doktor doktor = new Doktor()
            {
                Ad = "Mahmut",
                Soyad = "Yıldırım",
                TcNo = "123456",
                Yas = 56,
                Cinsiyet = Enums.Cinsiyet.Erkek,
                Maas = 25000,
                Bina = Enums.Bina.ABlok,
                Alan = Alan.GenelCerrahi
            };
            Hemsire hemsire = new Hemsire()
            {
                Ad = "Ayşe",
                Soyad = "Baş",
                TcNo = "1234567",
                Yas = 46,
                Cinsiyet = Enums.Cinsiyet.Kadin,
                Maas = 15000,
                Bina = Enums.Bina.ABlok,
                Alan = Alan.Dahiliye
            };
            Ebe ebe = new Ebe()
            {
                Ad = "Esra",
                Soyad = "Uçuncu",
                TcNo = "123",
                Yas = 28,
                Cinsiyet = Enums.Cinsiyet.Kadin,
                Maas = 16000,
                Bina = Enums.Bina.BBlok
            };
            Sekreter sekreter = new Sekreter()
            {
                Ad = "Aysu",
                Soyad = "Dadaş",
                TcNo = "45678",
                Yas = 34,
                Cinsiyet = Enums.Cinsiyet.Kadin,
                Maas = 10000,
                Bina = Enums.Bina.CBlok
            };
            Temizlikci temizlikci = new Temizlikci()
            {
                Ad = "Hamdi",
                Soyad = "Tosun",
                TcNo = "4897",
                Yas = 56,
                Cinsiyet = Enums.Cinsiyet.Erkek,
                Maas = 8000,
                Bina = Enums.Bina.BBlok
            };
            PersonelList.Add(doktor.TcNo, doktor);
            PersonelList.Add(hemsire.TcNo, hemsire);
            PersonelList.Add(ebe.TcNo, ebe);
            PersonelList.Add(temizlikci.TcNo, temizlikci);
            PersonelList.Add(sekreter.TcNo, sekreter);
            ListViewDoldur(PersonelList);
        }

        void ListViewDoldur(Dictionary<string, Personel> personelList)
        {
            lvPersonel.Items.Clear();
            foreach (var item in personelList)
            {
                Personel personel = item.Value;
                string[] forLvi = { personel.Ad, personel.Soyad, personel.TcNo, personel.Cinsiyet.ToString(), personel.Bina.ToString() };
                ListViewItem lvi = new ListViewItem(forLvi);
                lvi.Tag = personel;

                lvPersonel.Items.Add(lvi);
            }
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {          
            PersonelEkle form = new PersonelEkle();
            DialogResult result=form.ShowDialog();
            if(result==DialogResult.OK) ListViewDoldur(PersonelList);
        }
        
        
        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel gosterilenPersonel= (Personel)lvPersonel.SelectedItems[0].Tag;
            DetayEkran form=new DetayEkran(gosterilenPersonel);
            form.ShowDialog();
        }
    }
}
