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
            mainTableServices = new MainTableServices();
            user = _user;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string fname = user.FirstName.ToString();
            string lname = user.LastName.ToString();
            lblWelcome.Text = "Merhaba " + fname + " " + lname + "\n" + "YummyLose'a Hoşgeldiniz";
            int randoMoti = rnd.Next(1, 3); //Burada 3 yerine; motivation note kadar olmalı
            label5.Text = motivationNoteServices.GetMotivationById(randoMoti).Text;

            string dt1 = dateTimePicker1.Value.ToString().Substring(0, 10);

            double toplam = mainTableServices.CalculateTotalCalTurnList(Convert.ToDateTime(dt1), user.ID);

            lblVki.Text += VkiCalculate(user).ToString();
            LblAlinanKalori.Text += toplam.ToString();
            lblAlinmasiGerekenKalori.Text += CaloriesNeeded(user).ToString();


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
        /*public double CalculateTotalCal(int userid,DateTime d1)
        {
            double totalCal  = mainTableServices.CalculateTotalCal(d1, userid).Nutrient.Calories * mainTableServices.CalculateTotalCal(d1, userid).Amt;

            return totalCal;
        }
        public double CalculateTotalCal2(int userid, DateTime d1)
        {
            double totalCal = mainTableServices.CalculateTotalCal(d1, userid).Nutrient.Calories * mainTableServices.CalculateTotalCal(d1, userid).Amt;

            return totalCal;
        }*/

        public double CaloriesNeeded(User user)
        {
            double cal;
            if (user.Gender.ToLower() == "kadın")
            {
                cal = 655.1 + (9.56 * user.Kilo) + (1.85 * user.Height) - (4.67 * user.Age);
            }
            else
            {
                cal = 66.5 + (13.75 * user.Kilo) + (5 * user.Height) - (6.77 * user.Age);
            }
            double bki = VkiCalculate(user);

            if (bki < 19)
                return cal + 200;
            else if (bki > 25)
                return cal - 200;
            else
                return cal;
        }
        public double VkiCalculate(User user)
        {
            double vki;
            vki = (user.Kilo / (user.Height * user.Height)) * 10000;
            vki = Math.Round(vki, 1);
            return vki;
        }

        private void yemekÇeşitliliğiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNutrientVarietyReport fnvp=new frmNutrientVarietyReport(user);
            this.Hide();
            fnvp.ShowDialog();
            this.Show();
        }
    }
}
