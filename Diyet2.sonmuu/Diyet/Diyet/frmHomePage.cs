using Diet_BL.Services;
using Diet_DAL.Repositories;
using Diet_Model.Entity;
using Diet_Model.Enum;
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
        NutrientServices nutrientServices;
        MealServices mealServices;

        public frmHomePage(User _user)
        {
            InitializeComponent();
            motivationNoteServices = new MotivationNoteServices();
            mainTableServices = new MainTableServices();
            nutrientServices = new NutrientServices();
            mealServices = new MealServices();

            user = _user;
        }
        string dt1;

        
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string fname = user.FirstName.ToString();
            string lname = user.LastName.ToString();
            lblWelcome.Text = "Merhaba " + fname + " " + lname + "\n" + "YummyLose'a Hoşgeldiniz";
            int randoMoti = rnd.Next(1, 3); //Burada 3 yerine; motivation note kadar olmalı
            label5.Text = motivationNoteServices.GetMotivationById(randoMoti).Text;
            dt1 = dateTimePicker1.Value.ToString().Substring(0, 10);

            CalculateCal();

            lblVki.Text += VkiCalculate(user).ToString();
            lblAlinmasiGerekenKalori.Text += CaloriesNeeded(user).ToString();

            circularProgressBarFill(Convert.ToInt32(CalculateWater()));
            circularProgressBar2Fill(Convert.ToInt32(CalculateCal()));

            //label3.Text+= Convert.ToInt32(CalculateWater());

            /*circularProgressBar1.Value =Convert.ToInt32(CalculateWater());
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 4000;*/
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;


            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;


        }
        public void circularProgressBarFill(int i)
        {
            int oran = i / 40;

            if (i >= 4000)
                oran = 100;
            else if (oran <= 0)
                oran = 0;

            circularProgressBar1.Value = oran;

        }

        public void circularProgressBar2Fill(int i)
        {
            int alinanCal = Convert.ToInt32(CalculateCal());
            int maxCal = Convert.ToInt32(CaloriesNeeded(user));
            int oran = (100 * alinanCal) / maxCal;

            if (i >= Convert.ToInt32(CaloriesNeeded(user)))
                oran = 100;
            else if (oran <= 0)
                oran = 0;

            circularProgressBar2.Value = oran;

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

            if (LblAlinanKalori.Text.EndsWith("0") == false)
            {
                FrmAdminReports frmnot = new FrmAdminReports(user);
                this.Hide();
                frmnot.ShowDialog();
                this.Show();
            }
            else
            {

                MessageBox.Show("Eklemiş olduğunuz herhangi bir besin yok. Rapor alabilmek için öncelikle besin eklemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (LblAlinanKalori.Text.EndsWith("0") == false)
            {
                frmNutrientVarietyReport fnvp = new frmNutrientVarietyReport(user);
                this.Hide();
                fnvp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Eklemiş olduğunuz herhangi bir besin yok. Rapor alabilmek için öncelikle besin eklemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void günSonuRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LblAlinanKalori.Text.EndsWith("0") == false)
            {
                frmEndOfTheDayReport fredp = new frmEndOfTheDayReport(user, Convert.ToDateTime(dt1));
                this.Hide();
                fredp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Eklemiş olduğunuz herhangi bir besin yok. Rapor alabilmek için öncelikle besin eklemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kıyasRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LblAlinanKalori.Text.EndsWith("0") == false)
            {
                frmComparisonReport fcp = new frmComparisonReport();
                this.Hide();
                fcp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Eklemiş olduğunuz herhangi bir besin yok. Rapor alabilmek için öncelikle besin eklemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PasswordChange pc = new PasswordChange(user);
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }
        public double CalculateCal()
        {
            string dt1 = dateTimePicker1.Value.ToString().Substring(0, 10);

            double toplam = mainTableServices.CalculateTotalCalTurnList(Convert.ToDateTime(dt1), user.ID);

            LblAlinanKalori.Text = "Alınan Kalori: " + toplam.ToString();
            return toplam;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateCal();
            circularProgressBarFill(Convert.ToInt32(CalculateWater()));
            circularProgressBar2Fill(Convert.ToInt32(CalculateCal()));
        }

        private void sağlıklıYaşamTüyolarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHealthyTipforUser fhu=new frmHealthyTipforUser();
            this.Hide();
            fhu.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmAddNutrient frm = new frmAddNutrient(user);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pbWaterPlus_Click(object sender, EventArgs e)
        {
            string dt1 = dateTimePicker1.Value.ToString().Substring(0, 10);
            Meal me = new Meal();
            me.MealName = (MealName)0;
            me.CreateTime = dateTimePicker1.Value;
            mealServices.Insert(me);

            MainTable mainTable = new MainTable
            {
                UserID = user.ID,
                MealID = me.ID,
                NutrientID = nutrientServices.GetNutrientByName("su").ID,
                Amt = 200,
                TotalCalorie = 0,
            };
            bool result = mainTableServices.Insert(mainTable);

            //var amountWater = 200;
            //circularProgressBar1.Value += amountWater;

            //circularProgressBar1.Update();
            circularProgressBarFill(Convert.ToInt32(CalculateWater()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddNutrient frm = new frmAddNutrient(user);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        public double CalculateWater()
        {
            string dt1 = dateTimePicker1.Value.ToString().Substring(0, 10); double toplam = mainTableServices.GetWater(Convert.ToDateTime(dt1), user.ID);

            return toplam;
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {
            frmAddNutrient frm = new frmAddNutrient(user);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
