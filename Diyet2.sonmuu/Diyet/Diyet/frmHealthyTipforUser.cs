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
        Random rnd;
        private void frmHealthyTipforUser_Load(object sender, EventArgs e)
        {

            List<HealthyTip> healtytips = healthyTipServices.GetList();
            rnd = new Random();
            int randomIndex = rnd.Next(0, healtytips.Count + 1);
            int randomIndex2 = rnd.Next(0, healtytips.Count + 1);
            HealthyTip randomTip = healtytips[randomIndex];
            HealthyTip randomTip2 = healtytips[randomIndex2];
           
            if (randomIndex == randomIndex2)
            {
                randomIndex2= randomIndex2+1;
                label2.Text = randomTip2.Text;
                label1.Text = randomTip.Text;
            }
            else
            {
                label1.Text = randomTip.Text;
                label2.Text = randomTip2.Text;

            }
          

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
