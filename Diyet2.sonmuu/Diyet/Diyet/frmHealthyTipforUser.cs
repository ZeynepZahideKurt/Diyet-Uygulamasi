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
    }
}
