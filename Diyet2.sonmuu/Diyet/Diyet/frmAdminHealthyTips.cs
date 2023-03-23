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
    public partial class frmAdminHealthyTips : Form
    {
        HealthyTipServices adminHealthyTipsService;
        public frmAdminHealthyTips()
        {
            InitializeComponent();
            adminHealthyTipsService = new HealthyTipServices();
        }
        bool result;
        int healtyTipId;

        private void button2_Click(object sender, EventArgs e)
        {
            result = adminHealthyTipsService.Insert(new HealthyTip()
            {
                Text = richTextBox1.Text
            });
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
            FillInfos();
        }
        void FillInfos()
        {
            try
            {
                List<HealthyTip> nutrientInfos = adminHealthyTipsService.GetList();
                listBox1.DataSource = nutrientInfos;
                listBox1.DisplayMember = "Text";
                listBox1.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //healtyTipId = (int)listBox1.SelectedValue;
            //if (listBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seçili eleman yok");
            //}
            //else
            //{
            //    result = adminHealthyTipsService.Update(new HealthyTip()
            //    {
            //        ID = healtyTipId,
            //        Text = richTextBox1.Text
            //    });
            //    MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız!");
            //    richTextBox1.Clear();
            //    FillInfos();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            healtyTipId = (int)listBox1.SelectedValue;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seçili eleman yok");
            }
            else
            {
                try
                {
                    bool result = adminHealthyTipsService.DeleteWithId(healtyTipId);
                    MessageBox.Show(result ? " Silme başarılı" : "Sileme işlemi başarısız");
                    richTextBox1.Clear();
                    FillInfos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void frmAdminHealthyTips_Load(object sender, EventArgs e)
        {
            FillInfos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBox1.SelectedIndex != -1){
                int i = (int)listBox1.SelectedValue;
                HealthyTip h = adminHealthyTipsService.GetHealthyTipById(i);
                richTextBox1.Text = h.Text;
            }
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                HealthyTip h = adminHealthyTipsService.GetHealthyTipById(selectedIndex);
                string tipText = h.Text;
                richTextBox1.Text = tipText;
            }*/

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
