using Hamburgerci24012023.Concrete;
using Hamburgerci24012023.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Hamburgerci24012023.Concrete.Menu;

namespace Hamburgerci24012023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu {Adi = "Big King", Fiyat = 18.25M},
            new Menu {Adi = "Double King Chicken", Fiyat = 19.75M},
            new Menu {Adi = "Steakhouse", Fiyat = 22.50M},
            new Menu {Adi = "Whooper", Fiyat = 20.00M},
            new Menu {Adi = "Whooper Jr.", Fiyat = 17.75M},
            new Menu {Adi = "Chicken Royal", Fiyat = 21.25M}
        };
        public static List<Ekstra> ekstras = new List<Ekstra>()
        {
            new Ekstra {Adi = "Ketçap", Fiyat = 0.50M},
            new Ekstra {Adi = "Mayonez", Fiyat = 0.50M},
            new Ekstra {Adi = "Hardal", Fiyat = 0.75M},
            new Ekstra {Adi = "BBQ", Fiyat = 1.00M},
            new Ekstra {Adi = "Ranch", Fiyat = 1.00M},
            new Ekstra {Adi = "Buffalo", Fiyat = 1.25M}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in menuler)
            {
                cmbMenuler.Items.Add(item); // Tostring() metodunu override ettik . .. Menu şeklinde bastırılacak
            }
            foreach (var item in ekstras)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.Adi, Tag = item });
            }
            TutarHesapla();
            rdoKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;//-1 olursa eleman seçili olmaz
        }

        private void btnSiparisiEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.Menu = (Menu)cmbMenuler.SelectedItem;

            if (rdoKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (rdoBuyuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Buyuk;
            }
            else if (rdoOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            yeniSiparis.EkstraMalzemeler = new List<Ekstra>();
            foreach (CheckBox ctrl in flpEkstraMalzemeler.Controls)
            {
                if (ctrl.Checked)
                {
                    yeniSiparis.EkstraMalzemeler.Add((Ekstra)ctrl.Tag);
                }
            }
            yeniSiparis.Adet=Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();
            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);

            TutarHesapla();
            rdoKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;//-1 olursa eleman seçili olma<
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar+=gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text=toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "Satın almayı tamamlamak ister misin?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if(result == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz tamamlandı");
            }
            else MessageBox.Show("Siparişiniz iptal edildi");
        }
    }
}
