using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Helper
    {
        public static void FormTemizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;

                else if (item is MaskedTextBox) ((MaskedTextBox)item).Clear();

                else if (item is PictureBox)
                {
                    ((PictureBox)item).Image = null;
                    item.Tag = null;
                }
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                else if (item is GroupBox) FormTemizle(((GroupBox)item).Controls);

            }
        }
        //public static void TextKontrol(Control.ControlCollection controlCollection)
        //{
        //    foreach (Control item in controlCollection)
        //    {
        //        if (item is GroupBox)
        //        {
        //            foreach (var jitem in item.Controls)
        //            {
        //                if (jitem is TextBox)
        //                {
        //                    if (string.IsNullOrEmpty(((TextBox)jitem).Text))
        //                        throw new Exception("Txt labelları boş geçilemez");

        //                }
        //                else if (jitem is MaskedTextBox) ((MaskedTextBox)item).Clear();
        //            }   
        //        }
        //    }
        //}
    }
}
