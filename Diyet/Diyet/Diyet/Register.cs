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
    public partial class Register : Form
    {
        UserService userService;
        
        public Register()
        {
            InitializeComponent();
            userService=new UserService();
        }

        private void Register_Load(object sender, EventArgs e)
        {


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtPassword.Text != txtPsswordAgain.Text)
                {
                    MessageBox.Show("Şifre tekrarı hatali");
                    return;
                }
                User user = new User()
                {
                    
                    FirstName = txtName.Text,
                    LastName = txtSurname.Text,
                    Mail = txtMail.Text,
                    Password = txtPassword.Text,
                    Gender = "0",
                    Height=0,
                    Kilo=0,

                };

                Register2 reg2 = new Register2(user);
                this.Hide();
                reg2.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
