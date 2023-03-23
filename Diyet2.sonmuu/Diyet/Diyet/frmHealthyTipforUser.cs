using Diet_BL.Services;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet
{
    public partial class frmHealthyTipforUser : Form
    {

        HealthyTipServices healthyTipServices;
        public frmHealthyTipforUser()
        {
            InitializeComponent();
            healthyTipServices = new HealthyTipServices();
        }

        private void frmHealthyTipforUser_Load(object sender, EventArgs e)
        {

            List<HealthyTip> Nutrients = healthyTipServices.GetList();
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Nutrients.Count + 1);
            HealthyTip randomTip = Nutrients[randomIndex];
            label1.Text = randomTip.Text;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                Login frmlog = new Login();
                frmlog.Show();
            }
            else
            {
                MessageBox.Show("Haydi kalori eklemeye devam edelim!");
            }
        }
    }
}
