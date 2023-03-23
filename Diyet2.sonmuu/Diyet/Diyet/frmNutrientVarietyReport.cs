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
    public partial class frmNutrientVarietyReport : Form
    {
        NutrientServices nutrientServices;
        MainTableServices mainTableServices;
        User user;
        public frmNutrientVarietyReport(User _user)
        {
            InitializeComponent();
            nutrientServices = new NutrientServices();
            mainTableServices = new MainTableServices();
            user = _user;
        }

        private void frmNutrientVarietyReport_Load(object sender, EventArgs e)
        {
            timer1.Start();
            FillCmbNutrient();
            FindTheMostSelectedNutrient();
        }
        void FillCmbNutrient()
        {
            nutrientServices.GetNutrientListByUserid(user.ID, cmbChooseNut);
        }
        void FindTheMostSelectedNutrient()
        {
            label2.Text = nutrientServices.GetTheMostSelectedNutrient(user.ID);
        }
        int nutrientId;

        private void cmbChooseNut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nutrientId = (int)cmbChooseNut.SelectedValue;
            nutrientServices.GetVariertyReport(user.ID, chart1, nutrientId);
        }
        int x;
        int y;
        int z;
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            label2.ForeColor = Color.FromArgb(x, y, z);
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
