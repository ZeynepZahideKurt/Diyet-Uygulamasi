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
    public partial class fmrAdminNutrientInfo : Form
    {
        NutrientServices nutrientServices;
        NutrientInfoServices nutrientInfoService;
        public fmrAdminNutrientInfo()
        {
            InitializeComponent();
            nutrientServices = new NutrientServices();
            nutrientInfoService = new NutrientInfoServices();
        }
        void FillNutrientInfos()
        {
            try
            {
                List<NutrientInfo> nutrientInfos = nutrientInfoService.GetList();
                listBox2.DataSource = nutrientInfos;
                listBox2.DisplayMember = "Text";
                listBox2.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void FillNutrients()
        {
            try
            {
                List<Nutrient> nutrients = nutrientServices.GetList();
                listBox1.DataSource = nutrients;
                listBox1.DisplayMember = "NutrientName";
                listBox1.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int nitruenId;
        bool result;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            nitruenId = (int)listBox1.SelectedValue;
            if (nutrientInfoService.GetByNutrientId(nitruenId).Count() !=0)
            {
                MessageBox.Show("Seçili besen için bilgi ekleyemezsiniz çünkü mevcut yiyecek bilgisi vardır.");
            }
            else
            {
                result = nutrientInfoService.Insert(new NutrientInfo()
                {
                    Text = richTextBoxInfo.Text,
                    NutrientID = nitruenId
                });
                MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
                FillNutrientInfos();
            }
        }

        private void fmrAdminNutrientInfo_Load(object sender, EventArgs e)
        {
            FillNutrients();
            FillNutrientInfos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            nitruenId = (int)listBox1.SelectedValue;
            int NutrientInfoId = (int)listBox2.SelectedValue;
            result = nutrientInfoService.Update(new NutrientInfo()
            {
                Text = richTextBoxInfo.Text
            });
            MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız!");
            FillNutrientInfos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nitruenId = (int)listBox1.SelectedValue;
            int NutrientInfoId = (int)listBox2.SelectedValue;

            try
            {
                result = nutrientInfoService.DeletewithId(NutrientInfoId);
                MessageBox.Show(result ? " Silme başarılı" : "Silme başarısız");
                FillNutrientInfos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
