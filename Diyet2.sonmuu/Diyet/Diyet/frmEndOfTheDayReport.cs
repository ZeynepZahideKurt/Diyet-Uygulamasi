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
    public partial class frmEndOfTheDayReport : Form
    {
        NutrientServices nutrientServices;
        MainTableServices mainTableServices;
        User user;
        DateTime addedDay;
        public frmEndOfTheDayReport(User _user, DateTime _addedDay)
        {
            InitializeComponent();
            nutrientServices = new NutrientServices();
            mainTableServices= new MainTableServices();
            user = _user;
            addedDay = _addedDay;
        }

        private void frmEndOfTheDayReport_Load(object sender, EventArgs e)
        {
            CreateColumnGraph();
            CreatePieChart();
        }
        private void CreateColumnGraph()
        {

            mainTableServices.CalculateCalByMealID(addedDay, user.ID, chart1);

        }
        private void CreatePieChart()
        {
            mainTableServices.CalculateCalByMealID(addedDay, user.ID, chart2);

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
