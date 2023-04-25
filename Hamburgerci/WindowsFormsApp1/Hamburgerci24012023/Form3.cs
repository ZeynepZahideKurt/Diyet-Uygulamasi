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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Ekstra ekstra= new Ekstra() { Adi=txtEkstraAdi.Text,Fiyat=nmrEkstraFiyati.Value};
            Form1.ekstras.Add(ekstra);
            MessageBox.Show("Ekleme işlemi başarılır");
        }
    }
}
