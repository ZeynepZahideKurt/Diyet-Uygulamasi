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
        public frmHomePage(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
