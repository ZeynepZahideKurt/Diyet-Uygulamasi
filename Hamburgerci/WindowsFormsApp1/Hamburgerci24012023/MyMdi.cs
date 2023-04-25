using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci24012023
{
    public partial class MyMdi : Form
    {
        public MyMdi()
        {
            InitializeComponent();
        }

        void ChildFrom(Form childForm)
        {
            this.Width = childForm.Width;
            this.Height=childForm.Height;

            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if(form.Text==childForm.Text) // eğerki açık olan bir formu yeniden açmaya çalışırsam var olanı aktifleştir dedim.
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }

            if (durum == false)
            {
                childForm.MdiParent=this;
                childForm.Show();
            }

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();

            //ChildFrom(frm);
            ChildFrom(new Form1());
        }

        private void siparişYönetimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildFrom(new Form4());
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFrom(new Form2());
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFrom(new Form3());
        }
    }
}
