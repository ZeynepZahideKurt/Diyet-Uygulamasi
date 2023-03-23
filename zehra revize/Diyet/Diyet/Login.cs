using Diet_BL.Services;
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
    public partial class Login : Form
    {
        UserService userService;
        User user;
        public Login()
        {
            InitializeComponent();
            userService = new UserService();
            user = new User();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            this.Hide();
            rg.ShowDialog();
        }

        string mail;
        string password;
        private bool TextEmptyorFull()
        {
             mail = txtMail.Text;
             password = txtPassword.Text;

            if (string.IsNullOrEmpty(mail) == true || string.IsNullOrEmpty(password) == true)
            {

                return false;
            }
            else
            {

                return true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (TextEmptyorFull() == false)
            {
                MessageBox.Show("Lütfen her şeyi eksiksiz olarak giriniz.");
                return;
            }
            else
            {
                user = userService.CheckLogin(mail, password);

                if (user != null)
                {
                    if (user.UserType == UserType.Standard)
                    {
                        frmHomePage homePage = new frmHomePage(user);
                        this.Hide();
                        homePage.ShowDialog();
                    }
                    else
                    {
                        FrmAdminMain homePageadmin = new FrmAdminMain(user);
                        this.Hide();
                        homePageadmin.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
