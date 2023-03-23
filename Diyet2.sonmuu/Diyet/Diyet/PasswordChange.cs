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
    public partial class PasswordChange : Form
    {
        UserService UserService;
        User user;
        public PasswordChange(User _user)
        {
            InitializeComponent();
            UserService = new UserService();
            user = _user;
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }
        private bool IsItNewPassword(TextBox txt, TextBox txt2, User user)
        {
            if (txt.Text == user.Password && txt2.Text == user.Password)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (TextEmptyorFull() == true)
            {
                if (IsItNewPassword(txtPassword, txtPasswordAgain, user))
                {
                    if (txtPassword.Text == txtPasswordAgain.Text)
                    {
                        if (IsPasswordValid(txtPassword.Text) == true && txtPassword.Text.Length >= 8 && IsPasswordValid(txtPasswordAgain.Text) == true && txtPasswordAgain.Text.Length >= 8)
                        {
                            user.Password = txtPassword.Text;
                            bool result = UserService.UpdatePasswordByUserId(user);
                            MessageBox.Show(result ? "Şifreniz güncellendi" : "Şifreniz güncellenemedi");
                            frmHomePage hp = new frmHomePage(user);
                            this.Hide();
                            hp.ShowDialog();

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
                    MessageBox.Show("Şifreniz bir önceki şifreniz ile aynı olamaz.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Lütfen eksiksiz bilgi giriniz!");
                return;
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

        private bool TextEmptyorFull()
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true || string.IsNullOrEmpty(txtPasswordAgain.Text) == true)
            {

                return false;
            }
            else
            {

                return true;
            }
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
