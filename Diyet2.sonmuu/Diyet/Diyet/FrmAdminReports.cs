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
    public partial class FrmAdminReports : Form
    {
        NoteServices noteServices;
        User user;
        public FrmAdminReports(User _user)
        {
            InitializeComponent();
            noteServices= new NoteServices();
            user = _user;
        }

        private void FrmAdminReports_Load(object sender, EventArgs e)
        {
            
            FillListBox();
        }
        
        private void FillListBox()
        {
            try
            {
                List<Note> notes = noteServices.GetById(user.ID);
                listBox1.DataSource = notes;
                listBox1.DisplayMember = "Head";
                listBox1.ValueMember = "ID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
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

        private void listBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            int notId = (int)listBox1.SelectedValue;
            try
            {
                richTextBox1.Clear();
                Note note = noteServices.GetNoteById(notId);
                richTextBox1.Text = note.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
