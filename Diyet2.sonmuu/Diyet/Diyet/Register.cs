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
                if (TextEmptyorFull() == true)
                {
                    if (userService.IsValidEmail(txtMail.Text) == true && txtMail.Text.EndsWith(".com"))
                    {
                        if (txtPassword.Text == txtPsswordAgain.Text)
                        {
                            if (IsPasswordValid(txtPassword.Text) == true && txtPassword.Text.Length >= 8)
                            {
                                User user = new User()
                                {

                                    FirstName = txtName.Text,
                                    LastName = txtSurname.Text,
                                    Mail = txtMail.Text,
                                    Password = txtPassword.Text,
                                    Gender = "0",
                                    Height = 0,
                                    Kilo = 0,

                                };

                                Register2 reg2 = new Register2(user);
                                this.Hide();
                                reg2.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("•En az 8 karakter uzunluğunda olmalıdır.\n" +
                                "•En az 2 büyük harf içermelidir.\n" +
                                "•En az 3 küçük harf içermelidir.\n" +
                                "•! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir. ");
                            }
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Şifre tekrarı hatalı. Lütfen şifrenizi kontrol ediniz.");
                            return;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz mail girdiniz.Lüten tekrar giriş yapınız...");
                        txtMail.Clear();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen eksiksiz bilgi giriniz!");
                    return;
                }
                
                
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

        private bool TextEmptyorFull()
        {
            if (string.IsNullOrEmpty(txtName.Text) == true || string.IsNullOrEmpty(txtSurname.Text) == true || string.IsNullOrEmpty(txtPassword.Text) == true || string.IsNullOrEmpty(txtPsswordAgain.Text) == true || string.IsNullOrEmpty(txtMail.Text) == true)
            {

                return false;
            }
            else
            {

                return true;
            }
        }
        public bool IsPasswordValid(string _sifre)
        {
            var charArray = _sifre.ToCharArray();
            int buyukSayac = 0, kucukSayac = 0, ozelSayac = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] < 91 && charArray[i] >= 65)
                    //Büyük
                    buyukSayac++;
                else if (charArray[i] < 123 && charArray[i] >= 97)
                    //Küçük
                    kucukSayac++;
                else if (charArray[i] == 58 || charArray[i] == 43 || charArray[i] == 42 || charArray[i] == 33)
                    //özel
                    ozelSayac++;
            }
            if (buyukSayac >= 2 && kucukSayac >= 3 && ozelSayac >= 2)
                return true;
            else
                return false;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {

        }
    }
}
