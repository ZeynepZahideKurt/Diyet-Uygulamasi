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
    public partial class frmHomePage : Form
    {
        User user;
        MotivationNoteServices motivationNoteServices;
        MainTableServices mainTableServices;
        public frmHomePage(User _user)
        {
            InitializeComponent();
            motivationNoteServices = new MotivationNoteServices();
            mainTableServices= new MainTableServices();
            user = _user;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string fname=user.FirstName.ToString();
            string lname=user.LastName.ToString();
            lblWelcome.Text = "Merhaba " + fname + " " + lname + "\n" + "YummyLose'a Hoşgeldiniz";
            int randoMoti = rnd.Next(1, 3); //Burada 3 yerine; motivation note kadar olmalı
            label5.Text = motivationNoteServices.GetMotivationById(randoMoti).Text;
            string dt1 = dateTimePicker1.Value.ToString().Substring(0,10);
          
            if (CalculateTotalCal(user.ID, Convert.ToDateTime(dt1)).ToString() != null)
            {
                label7.Text = CalculateTotalCal(user.ID, Convert.ToDateTime(dt1)).ToString();
            }

        }

        private void pbNutrient_Click(object sender, EventArgs e)
        {
            frmAddNutrient frm = new frmAddNutrient(user);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void adminRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminReports frmnot = new FrmAdminReports(user);
            this.Hide();
            frmnot.ShowDialog();
            this.Show();
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

        private void pbNutrient_Click_1(object sender, EventArgs e)
        {
            frmAddNutrient frm = new frmAddNutrient(user);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        public double CalculateTotalCal(int userid,DateTime d1)
        {
            double totalCal  = mainTableServices.CalculateTotalCal(d1, userid).Nutrient.Calories * mainTableServices.CalculateTotalCal(d1, userid).Amt;

            return totalCal;
        }
    }
}
