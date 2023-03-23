using Diet_BL.Services;
using Diet_Model.Entity;
using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet
{
    public partial class FrmAdminMain : Form
    {
        User user;
        NutrientServices nutrientService;
        CategoryServices categoryService;
        bool result;
        int secilenCategoryId, row;
        public FrmAdminMain(User _user)
        {
            InitializeComponent();
            user = _user;
            nutrientService = new NutrientServices();
            categoryService = new CategoryServices();
            ListNutrient();
            ListCategory();
            ListCategory2();
            ListAmount();
        }
        public void ListNutrient()
        {
            dataGridView1.DataSource = nutrientService.GetList();
        }
        public void ListCategory()
        {
            //cmbCategory.Items.Clear();
            cmbCategory.DataSource = categoryService.GetList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";

        }


        public void ListCategory2()
        {
            //cmbCategory.Items.Clear();

            cmbKategoribesinin.DataSource = categoryService.GetList();
            cmbKategoribesinin.DisplayMember = "CategoryName";
            cmbKategoribesinin.ValueMember = "ID";
        }
        public void ListAmount()
        {
            //cmbCategory.Items.Clear();

            cmbMiktarCinsi.DataSource = Enum.GetNames(typeof(Amount));
            /* cmbMiktarCinsi.DisplayMember = "CategoryName";
             cmbMiktarCinsi.ValueMember = "ID";*/
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            result = categoryService.Insert(new Category()
            {
                CategoryName = txtCategoryName.Text
            });
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
            ListCategory();
            ListCategory2();
        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {


            if (cmbCategory.SelectedIndex == -1)
            {

                MessageBox.Show("Seçili eleman yok");
            }
            else
            {
                categoryId = (int)cmbCategory.SelectedValue;
                result = categoryService.Update(new Category()
                {
                    ID = categoryId,
                    CategoryName = txtCategoryName.Text
                });
                MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız Arkadaş!");
                txtCategoryName.Clear();
                ListCategory();
                ListCategory2();
            }
        }
        int categoryId;
        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex <= -1)
            {
                MessageBox.Show("Seçili eleman yok");
            }
            else
            {
                categoryId = (int)cmbCategory.SelectedValue;
                try
                {
                    result = categoryService.DeleteWithId(categoryId);
                    MessageBox.Show(result ? " Silme başarılı" : "Sileme işlemi başarısız");
                    txtCategoryName.Clear();
                    ListCategory(); ListCategory2();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int i = (int)cmbKategoribesinin.SelectedValue;


            result = nutrientService.Insert(new Nutrient()
            {
                NutrientName = txtAd.Text,
                Calories = Convert.ToInt32(txtKalori.Text),
                CategoryID = i,
                Amount = (Amount)cmbMiktarCinsi.SelectedIndex,
                PhotoPath = txtFoto.Text,
                Description =richTextBox1.Text

            });
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
            if (txtFoto.Text != "")
                pictureBox2.Image = Image.FromFile(txtFoto.Text);
            ListNutrient();
            txtClear();
        }

        private void healthyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminHealthyTips frm = new frmAdminHealthyTips();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())

            {

                dlg.Title = "Open Image";

                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";



                if (dlg.ShowDialog() == DialogResult.OK)

                {

                    string sFileName = dlg.FileName;
                    //txtFoto.Text = dlg.FileName;
                    pictureBox2.Image = Image.FromFile(sFileName);
                    txtFoto.Text = dlg.FileName;
                }

            }
        }
        public void txtClear()
        {
            txtAd.Text = "";
            txtCategoryName.Text = "";
            txtKalori.Text = "";
            txtFoto.Text = "";
            richTextBox1.Text = "";
            pictureBox2.Image = null;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Nutrient nutrient = new Nutrient();
            nutrient.ID = row;
            nutrient.NutrientName = txtAd.Text;
            nutrient.Amount = (Amount)cmbMiktarCinsi.SelectedIndex;
            nutrient.Calories = Convert.ToDouble(txtKalori.Text);
            nutrient.CategoryID = secilenCategoryId;
            nutrient.PhotoPath = txtFoto.Text;
            nutrient.Description = richTextBox1.Text;

            result = nutrientService.Update(nutrient);
            ListNutrient();
            txtClear();
            MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız !");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = nutrientService.DeleteWithId(row);
                MessageBox.Show(result ? " Silme başarılı" : "Silme başarısız");

                txtClear();
                ListNutrient();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void motivationNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMotivationNotes mn=new frmAdminMotivationNotes();
            this.Hide();
            mn.ShowDialog();
            this.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminReport frm=new frmAdminReport();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChange pc = new PasswordChange(user);
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                row = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());



                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[2].Value != null)
                    richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                else
                    richTextBox1.Text = "";

                txtKalori.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmbMiktarCinsi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[5].Value != null)
                    txtFoto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                else
                {
                    pictureBox2.Image = null;
                    txtFoto.Text = "";
                }

                if (txtFoto.Text != "")
                    pictureBox2.Image = Image.FromFile(txtFoto.Text);
                
                //dataGridView1.CurrentRow.Cells[5].Visible= false;

                secilenCategoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
