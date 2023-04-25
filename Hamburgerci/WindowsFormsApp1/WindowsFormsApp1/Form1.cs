using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            Helper.FormTemizle(this.Controls);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.Filter = "Personel Resmi(png,jpg) | *.png; *.jpg;";
            DialogResult dialogResult=fileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                pbPersonelResmi.ImageLocation= fileDialog.FileName;
            }
        }

        Personel PersonelDoldur (Personel personel)
        {
            personel.PersonelID = int.Parse(txtPersonelID.Text);
            personel.Ad = txtAd.Text;
            personel.SoyAd = txtSoyad.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;
            personel.Telefon = txtTelefon.Text;
            personel.Email = txtMail.Text;
            personel.Adress = txtAdres.Text;
            personel.IseGirisTarihi=dtpIseGirisTarihi.Value;
            personel.Unvan = (Unvan)Enum.Parse(typeof(Unvan), cbUnvan.Text);
            personel.Cinsiyet= (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cbCinsiyet.Text);
            
            if(pbPersonelResmi.ImageLocation!=null)
            {
                personel.PersonelResmiPath = pbPersonelResmi.ImageLocation;
            }
            return personel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            
            try
            {
                //Helper.TextKontrol(this.Controls);
                personel = PersonelDoldur(personel);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            

            ListViewItem lvi = ListViewDoldur(personel);
            lvPersonel.Items.Add(lvi);
            Helper.FormTemizle(this.Controls);
        }

        ListViewItem ListViewDoldur(Personel personel)
        {
            string[] forLvi = { personel.PersonelID.ToString(), personel.Ad, personel.SoyAd, personel.IseGirisTarihi.ToString(), personel.Email };
            ListViewItem lvi= new ListViewItem(forLvi);
            lvi.Tag=personel;
            return lvi;
        }
        int index;
        Personel guncellenecekPersonel;
        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            index = lvPersonel.SelectedItems[0].Index;
            guncellenecekPersonel = (Personel)lvPersonel.SelectedItems[0].Tag;
            txtPersonelID.Text = guncellenecekPersonel.PersonelID.ToString();
            txtAd.Text = guncellenecekPersonel.Ad;
            txtSoyad.Text = guncellenecekPersonel.SoyAd;
            dtpDogumTarihi.Value=guncellenecekPersonel.DogumTarihi;
            txtTelefon.Text = guncellenecekPersonel.Telefon;
            txtMail.Text=guncellenecekPersonel.Email;
            txtAdres.Text = guncellenecekPersonel.Adress;
            dtpIseGirisTarihi.Value = guncellenecekPersonel.IseGirisTarihi;
            cbUnvan.Text = guncellenecekPersonel.Unvan.ToString();
            cbCinsiyet.Text = guncellenecekPersonel.Cinsiyet.ToString();

            if(!string.IsNullOrWhiteSpace(guncellenecekPersonel.PersonelResmiPath))
            {
                pbPersonelResmi.ImageLocation=guncellenecekPersonel.PersonelResmiPath;
            }
            btnKaydet.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                guncellenecekPersonel = PersonelDoldur(guncellenecekPersonel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            lvPersonel.Items.RemoveAt(index);
            lvPersonel.Items.Insert(index,ListViewDoldur(guncellenecekPersonel));

            Helper.FormTemizle(this.Controls);
            btnKaydet.Enabled = true;
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            if (lvPersonel.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in lvPersonel.SelectedItems)
                {
                    lvPersonel.Items.Remove(item);
                }
            }
            else MessageBox.Show("Silenecek kayıt seçiniz");
        }

       
    }
}
