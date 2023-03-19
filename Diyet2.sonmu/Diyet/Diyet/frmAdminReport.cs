using Diet_BL.Services;
using Diet_Model.Entity;
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
        MealServices mealServices;
        public frmAdminReport()
        {
            InitializeComponent();
            noteServices = new NoteServices();
            userService = new UserService();
            mealServices = new MealServices();
        }

        private void frmAdminReport_Load(object sender, EventArgs e)
        {

        }
        void FillCombox()
        {
            try
            {
                List<User> users = userService.GetAllUsers();
                comboBox1.DataSource = users;
                comboBox1.DisplayMember = "Firstname";
                comboBox1.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int userID;
        private void button1_Click(object sender, EventArgs e)
        {
            userID = (int)comboBox1.SelectedValue;
            bool result;
            bool datetimeControl = DateTimeControl();
            try
            {
                if(changedD1 == true && changedD2==true || changedD1==false && changedD2==true ||
                    changedD1==true && changedD2 == false)
                {
                    if(datetimeControl == true) 
                    {
                        if (comboBox1.SelectedIndex == -1)
                        {
                            result = noteServices.Insert(new Note()
                            {
                                Text = richTextBox1.Text,
                                UserID = userID,
                            });
                            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
                            richTextBox1.Clear();
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
                else
                {
                    MessageBox.Show("Herhangi bir tarih seçimi yapmadınız! Tarihlerinizi tekrar kontrol ediniz!");
                    return;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrafikOlustur();
        }
        private void GrafikOlustur()
        {

            chart1.DataSource = mealServices.GetMealbyUserIDwithTime(userID, dateTimePicker1.Value, dateTimePicker2.Value);
            chart1.Series["Günlük Kalori"].XValueMember = "CreateTime";
            chart1.Series["Günlük Kalori"].YValueMembers = "Calories";
            chart1.Titles.Add(dateTimePicker1.Value.ToString() + " - " + dateTimePicker2.Value.ToString() + " Arasında Alınan Kalori Değeri");

        }
        private bool DateTimeControl()
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool changedD1=false;
        bool changedD2=false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            changedD1= true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            changedD2= true;
        }

       
    }
}
