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
    public partial class frmAdminMotivationNotes : Form
    {
        MotivationNoteServices AdminmotivationNoteService;
        public frmAdminMotivationNotes()
        {
            InitializeComponent();
            AdminmotivationNoteService = new MotivationNoteServices();
        }
        bool result;
        int motivationNoteId;

        private void button2_Click(object sender, EventArgs e)
        {
            result = AdminmotivationNoteService.Insert(new MotivationNote()
            {
                Text = richTextBox1.Text
            });
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarız!");
            FillNotes();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminMotivationNotes_Load(object sender, EventArgs e)
        {
            FillNotes();
        }
        void FillNotes()
        {
            try
            {
                List<MotivationNote> notes = AdminmotivationNoteService.GetList();
                listBox1.DataSource = notes;
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
            //MotivationNote selectedNote = (MotivationNote)listBox1.SelectedItem;
            //if (selectedNote == null)
            //{
            //    MessageBox.Show("Seçili eleman yok");
            //}
            //else
            //{
            //    motivationNoteId = selectedNote.ID;
            //    result = AdminmotivationNoteService.Update(new MotivationNote()
            //    {
            //        ID = motivationNoteId,
            //        Text = richTextBox1.Text
            //    });
            //    MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız!");
            //    richTextBox1.Clear();
            //    FillNotes();


            //motivationNoteId = (int)listBox1.SelectedValue;
            //if (listBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seçili eleman yok");
            //}
            //else
            //{
            //    result = AdminmotivationNoteService.Update(new MotivationNote()
            //    {
            //        ID = motivationNoteId,
            //        Text = richTextBox1.Text
            //    });
            //    MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız!");
            //    richTextBox1.Clear();

            //}
            //FillNotes();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            MotivationNote selectedNote = (MotivationNote)listBox1.SelectedItem;
            if (selectedNote == null)
            {
                MessageBox.Show("Seçili eleman yok");
            }
            else
            {
                motivationNoteId = selectedNote.ID;
                try
                {
                    bool result = AdminmotivationNoteService.Delete(motivationNoteId);
                    MessageBox.Show(result ? " Silme başarılı" : "Sileme işlemi başarısız");
                    richTextBox1.Clear();
                    FillNotes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotivationNote selectedNote = (MotivationNote)listBox1.SelectedItem;
            if (selectedNote != null)
            {
                richTextBox1.Text = selectedNote.Text;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
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
    }
}
