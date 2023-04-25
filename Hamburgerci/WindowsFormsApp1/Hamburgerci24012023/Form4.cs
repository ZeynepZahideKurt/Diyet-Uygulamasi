using Hamburgerci24012023.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci24012023
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdeti = 0;
            foreach (Siparis siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra ekstraMalzemele in Form1.ekstras)
                {
                    ekstraMalzemeGeliri += ekstraMalzemele.Fiyat;
                }
                satisAdeti += siparis.Adet;
                lbxTumSiparisler.Items.Add(siparis);
            }
            lblToplamSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdeti.ToString();
        }
    }
}
