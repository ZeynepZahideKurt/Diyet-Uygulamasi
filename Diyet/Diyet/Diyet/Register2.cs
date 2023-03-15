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
            user.Kilo = Convert.ToDouble(txtWeight.Text);
            user.Height = Convert.ToInt32(txtHeight.Text);
            user.Gender = cbGender.SelectedItem.ToString();

            bool result = userService.Insert(user);
            MessageBox.Show(result ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
        }

        private void Register2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
