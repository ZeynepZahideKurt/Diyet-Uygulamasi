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
    public partial class FrmAdminMain : Form
    {
        User user;
        public FrmAdminMain(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {

        }
    }
}
