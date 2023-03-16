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
    public partial class FrmAdminMain : Form
    {
        User user;
        NutrientServices nutrientService;
        CategoryServices categoryService;
        MealServices mealService;
        bool result;
        public FrmAdminMain(User _user)
        {
            InitializeComponent();
            user = _user;
            nutrientService = new NutrientServices();
            categoryService = new CategoryServices();
            mealService = new MealServices();
            ListNutrient();
            ListCategory(); ListCategory2();
            ListMeal();
            ListAmount();
        }
        public void ListNutrient()
        {
            dataGridView1.DataSource = nutrientService.GetList();
        }
        public void ListCategory()
        {
            //cmbCategory.Items.Clear();
            cmbCategory.DataSource= categoryService.GetList();
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
        public void ListMeal()
        {
            cmbCategory.DataSource = mealService.GetList();
            cmbCategory.DisplayMember = "MealName";
            cmbCategory.ValueMember = "ID";
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
            ListCategory(); ListCategory2();
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
                     CategoryName= txtCategoryName.Text
                });
                MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız Arkadaş!");
                txtCategoryName.Clear();
                ListCategory(); ListCategory2();
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
                Amount =(Amount)cmbMiktarCinsi.SelectedItem,
                //Amount =tx

            });
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
        }
    }
}
