using HastaneOtomasyon.Abstract;
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
    public partial class DetayEkran : Form
    {
        private readonly Personel personel;

        public DetayEkran()
        {
            InitializeComponent();
        }
        public DetayEkran(Personel _personel)
        {
            InitializeComponent();
            personel = _personel;
        }

        private void DetayEkran_Load(object sender, EventArgs e)
        {
            txtAd.Text = personel.Ad;
            txtSoyad.Text = personel.Soyad;
            txtTcNo.Text=personel.TcNo;
            txtYas.Text = personel.Yas.ToString();
            cmbCinsiyet.Text = personel.Cinsiyet.ToString();
            cmbBina.Text = personel.Bina.ToString();
            txtMaas.Text=personel.Maas.ToString();
        }
    }
}
