using Diet_BL.Services;
using Diet_Model.Entity;
using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet
{
    public partial class frmAddNutrient : Form
    {
        NutrientServices nutrientServices;
        MealServices mealServices;
        CategoryServices categoryServices;
        UserService userService;
        MainTableServices mainTableServices;
        User user;
        public frmAddNutrient(User _user)
        {
            InitializeComponent();
            mealServices= new MealServices();
            nutrientServices=new NutrientServices();   
            categoryServices= new CategoryServices();
            userService= new UserService();
            mainTableServices= new MainTableServices(); 
            user =_user;
        }
       
        private void frmAddNutrient_Load(object sender, EventArgs e)
        {
            txtBoxSearch.Text = "";
            FillCmbMeal();
            FillListBox();
            //listBoxFoods.SelectedIndex = -1;
            FillCmbCategory();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //private void FillListboxByCategory()
        //{
        //    listBoxFoods.Items.Clear();
        //    var list = nutrientServices.GetNutrientsbyCategoryID(catID);
        //    listBoxFoods.DataSource= list;
        //    listBoxFoods.DisplayMember= "NutrientName";
        //    listBoxFoods.ValueMember = "ID";
        //}
        void ListNutrientforCategory(int catID)
        {
            //listBoxFoods.Items.Clear();
            listBoxFoods.DataSource = categoryServices.GetNutrientByCategoryId(catID);
            listBoxFoods.DisplayMember = "NutrientName";
            listBoxFoods.ValueMember = "ID";
        }
        private void FillListBox()
        {
            //listBoxFoods.Items.Clear();
            listBoxFoods.DataSource = nutrientServices.GetList();
            listBoxFoods.DisplayMember = "NutrientName";
            listBoxFoods.ValueMember = "ID";
        }
        private void FillCmbMeal()
        {
            string[] mealname = Enum.GetNames(typeof(MealName));
            cbMeal.DataSource = mealname;
           
        }
        private void FillCmbCategory()
        {
            cbCategory.DataSource = categoryServices.GetList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember= "ID";
        }

        
       
        int index;
        private void cbMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            index=cbMeal.SelectedIndex;
        }

      
        int catID;
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //catID=cbCategory.SelectedIndex;
          
        }

        double toplam=0;
        MainTable mainTable;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedIndex != -1 && textBox1.Text!=null)
            {
                int categoryId = nutrientServices.GetByNutrientId((int)listBoxFoods.SelectedValue).CategoryID;
                string categoryName = categoryServices.GetByCategoryId(categoryId).CategoryName; 

                dataGridView1.Rows.Add(cbMeal.Text, categoryName, nutrientServices.GetByNutrientId((int)listBoxFoods.SelectedValue).NutrientName, textBox1.Text, nutrientServices.GetCalorieByNutrientID((int)listBoxFoods.SelectedValue) * Convert.ToInt32(textBox1.Text));
                toplam += nutrientServices.GetCalorieByNutrientID((int)listBoxFoods.SelectedValue) * Convert.ToInt32(textBox1.Text);
                label6.Text = toplam.ToString();
                Meal meal = new Meal();
                meal.MealName = (MealName)index;
                meal.CreateTime = dateTimePicker1.Value;
                mealServices.Insert(meal);
                mainTable = new MainTable
                {
                    UserID = user.ID,
                    MealID = meal.ID,
                    NutrientID = (int)listBoxFoods.SelectedValue,
                    Amt = Convert.ToDouble(textBox1.Text),
                    TotalCalorie= Convert.ToDouble(textBox1.Text) * nutrientServices.GetByNutrientId((int)listBoxFoods.SelectedValue).Calories,
                };
                bool result = mainTableServices.Insert(mainTable);
                if(nutrientServices.GetByNutrientId((int)listBoxFoods.SelectedValue).Description!= null)
                    MessageBox.Show(nutrientServices.GetByNutrientId((int)listBoxFoods.SelectedValue).Description);
            }
            else if(listBoxFoods.SelectedIndex!=-1 && textBox1.Text == null)
            {
                MessageBox.Show("Lütfen besinin miktarını giriniz!");
                return;
            }
            else if(listBoxFoods.SelectedIndex <= -1 && textBox1.Text != null)
            {
                MessageBox.Show("Lütfen bir besin seçiniz!");
                return;
            }
            else
            {
                MessageBox.Show("Lütfen bir besin seçiniz ve bu besinin adedini giriniz!");
                return;
            }
        }

        private void frmAddNutrient_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void listBoxFoods_MouseClick(object sender, MouseEventArgs e)
        {
            int i = (int)listBoxFoods.SelectedValue;
            try
            {
                label4.Text = nutrientServices.GetByNutrientId(i).Amount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                catID = (int)cbCategory.SelectedValue;
                ListNutrientforCategory(catID);
            }
            
           
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxFoods.DataSource = nutrientServices.Search(txtBoxSearch.Text);
            listBoxFoods.DisplayMember = "NutrientName";
            listBoxFoods.ValueMember = "ID";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                FillListBox();
            }
            else
            {
                
                ListNutrientforCategory(catID);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmHomePage f = new frmHomePage(user);
            this.Hide();
            f.ShowDialog();
        }
    }
}
