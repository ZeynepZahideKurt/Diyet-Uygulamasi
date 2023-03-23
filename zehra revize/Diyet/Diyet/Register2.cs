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
    public partial class Register2 : Form
    {
        UserService userService;
        User user;
        public Register2(User _user)
        {
            InitializeComponent();
            userService= new UserService();
            user = _user;
        }

        private void Register2_Load(object sender, EventArgs e)
        {
            GenderComboList();
           
        }
        void GenderComboList()
        {
            cbGender.Items.Add("Erkek");
            cbGender.Items.Add("Kadın");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextEmtyorFull() == true)
                {
                    user.Kilo = Convert.ToDouble(txtWeight.Text);
                    user.Height = Convert.ToInt32(txtHeight.Text);
                    user.Gender = cbGender.SelectedItem.ToString();
                    user.Age = Convert.ToDouble(txtAge.Text);
                    bool result = userService.Insert(user);
                    MessageBox.Show(result ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
                    Login frmlog = new Login();
                    this.Hide();
                    frmlog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }
            
        }

        private void Register2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool TextEmtyorFull()
        {
            if (string.IsNullOrEmpty(txtHeight.Text)==true || string.IsNullOrEmpty(txtWeight.Text) == true || cbGender.SelectedIndex<=-1)
            {
               
                return false;
            }
            else
            {
                
                return true;
            }
        }
    }
}
