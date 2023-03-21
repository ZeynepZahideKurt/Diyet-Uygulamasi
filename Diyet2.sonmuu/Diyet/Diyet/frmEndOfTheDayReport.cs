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
        User user;
        DateTime addedDay;
        public frmEndOfTheDayReport(User _user, DateTime _addedDay)
        {
            InitializeComponent();
            nutrientServices = new NutrientServices();
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

           /* chart1.DataSource = nutrientServices.GetCaloribyUserID(user.ID,addedDay);
            chart1.Series["Günlük Kalori"].XValueMember = "MealName";
            chart1.Series["Günlük Kalori"].YValueMembers = "Calories";
            chart1.Titles.Add("Gün Sonu Raporu");*/

        }
        private void CreatePieChart()
        {

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            /*chart2.DataSource = nutrientServices.GetCaloribyUserID(user.ID, addedDay);
            chart2.Series["Günlük Kalori"].XValueMember = "MealName";
            chart2.Series["Günlük Kalori"].YValueMembers = "Calories";
            chart2.Titles.Add("Gün Sonu Raporu");*/
        }

    }
}
