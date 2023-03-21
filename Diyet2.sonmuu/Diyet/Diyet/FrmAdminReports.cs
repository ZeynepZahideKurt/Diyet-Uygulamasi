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
            richTextBox1.Enabled= false;
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
