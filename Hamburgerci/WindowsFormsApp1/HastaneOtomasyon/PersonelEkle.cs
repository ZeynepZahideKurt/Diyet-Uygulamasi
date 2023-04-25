using HastaneOtomasyon.Concrete;
using HastaneOtomasyon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (AnaEkran.PersonelList.ContainsKey(txtTcNo.Text))
            {
                MessageBox.Show("Böyle bir kullanıcı var. Lütfen tc kimlik numaranızı kontrol edin");
                return;
            }
            if (rdbDoktor.Checked)
            {
                Doktor doktor = new Doktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TcNo = txtTcNo.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                    Bina = (Bina)Enum.Parse(typeof(Bina), cmbBina.Text),
                    Alan = (Alan)Enum.Parse(typeof(Alan), cmbAlan.Text)
                };
                AnaEkran.PersonelList.Add(doktor.TcNo, doktor);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            if (rdbHemsire.Checked)
            {
                Hemsire hemsire = new Hemsire()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TcNo = txtTcNo.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                    Bina = (Bina)Enum.Parse(typeof(Bina), cmbBina.Text),
                    Alan = (Alan)Enum.Parse(typeof(Alan), cmbAlan.Text)
                };
                AnaEkran.PersonelList.Add(hemsire.TcNo, hemsire);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            if (rdbEbe.Checked)
            {
                Ebe ebe = new Ebe()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TcNo = txtTcNo.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                    Bina = (Bina)Enum.Parse(typeof(Bina), cmbBina.Text),
                };
                AnaEkran.PersonelList.Add(ebe.TcNo, ebe);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            if (rdbSekreter.Checked)
            {
                Sekreter sekreter = new Sekreter()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TcNo = txtTcNo.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                    Bina = (Bina)Enum.Parse(typeof(Bina), cmbBina.Text),
                };
                AnaEkran.PersonelList.Add(sekreter.TcNo, sekreter);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            if (rdbTemizlikci.Checked)
            {
                Temizlikci temizlikci = new Temizlikci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TcNo = txtTcNo.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text),
                    Bina = (Bina)Enum.Parse(typeof(Bina), cmbBina.Text),
                };
                AnaEkran.PersonelList.Add(temizlikci.TcNo, temizlikci);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            lblAlan.Enabled = false;
            cmbAlan.Enabled = false;
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBina.Items.AddRange(Enum.GetNames(typeof(Bina)));
            cmbAlan.Items.AddRange(Enum.GetNames(typeof(Alan)));
        }

        private void rdbDoktor_CheckedChanged(object sender, EventArgs e)
        {
            lblAlan.Enabled = true;
            cmbAlan.Enabled = true;
        }

        private void rdbHemsire_CheckedChanged(object sender, EventArgs e)
        {

            lblAlan.Enabled = true;
            cmbAlan.Enabled = true;

        }

        void LabelKapat()
        {
            lblAlan.Enabled = false;
            cmbAlan.Enabled = false;
        }

        private void rdbEbe_CheckedChanged(object sender, EventArgs e)
        {
            LabelKapat();
        }

        private void rdbSekreter_CheckedChanged(object sender, EventArgs e)
        {
            LabelKapat();
        }

        private void rdbTemizlikci_CheckedChanged(object sender, EventArgs e)
        {
            LabelKapat();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Helper.FormTemizle(this.Controls);
        }
    }
}
