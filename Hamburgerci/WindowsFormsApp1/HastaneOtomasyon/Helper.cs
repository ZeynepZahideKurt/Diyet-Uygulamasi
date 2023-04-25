using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    internal static class Helper
    {

        public static void FormTemizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox) ((TextBox)item).Clear();                            
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                else if (item is GroupBox) FormTemizle(((GroupBox)item).Controls);

            }
        }

    }
}
