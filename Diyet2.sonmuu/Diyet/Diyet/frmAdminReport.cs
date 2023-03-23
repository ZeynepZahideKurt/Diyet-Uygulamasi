using Diet_BL.Services;
using Diet_Model.Entity;
using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet
{
    public partial class frmAdminReport : Form
    {

        NoteServices noteServices;
        UserService userService;
        MainTableServices mainTableServices;
        public frmAdminReport()
        {
            InitializeComponent();
            noteServices = new NoteServices();
            userService = new UserService();
            mainTableServices = new MainTableServices();
        }

        private void frmAdminReport_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button2.Enabled = false;
            FillUserCombox();
            button1.Enabled = false;
            richTextBox1.Enabled = false;

        }
        void FillUserCombox()
        {
            try
            {
                List<User> users = userService.GetAllUsers().Where(a => a.UserType == UserType.Standard).ToList();
                comboBox1.DataSource = users;
                comboBox1.DisplayMember = "Firstname";
                comboBox1.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void FillDateCombos(int userid)
        {
            try
            {
                mainTableServices.GetDatebyUserId(userid, comboBox2);
                mainTableServices.GetDatebyUserId(userid, comboBox3);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int userID;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
      
        private void GrafikOlustur(int userid)
        {

            mainTableServices.GetCaloriesbyUserID(userid, chart1, Convert.ToDateTime(comboBox2.Text), Convert.ToDateTime(comboBox3.Text));

        }
        private bool DateTimeControl()
        {
            if (Convert.ToDateTime(comboBox2.Text) > Convert.ToDateTime(comboBox3.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        int userid;

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            userid = (int)comboBox1.SelectedValue;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            FillDateCombos(userid);
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrafikOlustur(userid);
            richTextBox1.Enabled = true;
            button1.Enabled = true;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            userID = (int)comboBox1.SelectedValue;
            bool result;
            bool datetimeControl = DateTimeControl();
            try
            {
                if (datetimeControl == true)
                {
                    if (comboBox1.SelectedIndex != -1)
                    {
                        result = noteServices.Insert(new Note()
                        {
                            Head = textBox1.Text,
                            Text = richTextBox1.Text,
                            UserID = userID,
                        });
                        MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
                        richTextBox1.Clear();
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bir note eklemeden önce kullanıcı seçmelisiniz");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Başlangıç bitiş tarihinden büyük olamaz. Lütfen tarihlerinizi kontrol ediniz");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
