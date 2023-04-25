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
using Menu = Hamburgerci24012023.Concrete.Menu;

namespace Hamburgerci24012023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu() { Adi=txtMenuAdi.Text,Fiyat=nmrMenuFiyati.Value};
            Form1.menuler.Add(menu);

            MessageBox.Show("Ekleme işlemi başarılır");
        }
    }
}
