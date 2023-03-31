using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    internal class Validation
    {
       //public static bool validateAll(Control parentControl)
       // {
       //     bool status = true;
            
       //         foreach (Control control in parentControl.Controls)
       //         {
       //             if (control is PanelControl)
       //             {
       //                 continue;
       //             }

       //             // Check if the control is a TextBox, DateTimePicker or ComboBox
       //             if (control is TextBox txt)
       //             {
       //                     if (txt.SelectedIndex == -1)
       //                     {
       //                         cmb.SelectedIndex = 0;
       //                     }
       //             }

       //             // Recursively iterate over child controls
       //             if (control.HasChildren)
       //             {
       //                 validateAll(control);
       //             }
       //         }
       //     return status;
       // }

       
        public static bool IsOnlyLetterOrDigit(string input) 
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(input)) return false;
            else
            {
                foreach (char c in input)
                {
                    if(!char.IsLetterOrDigit(c)) isValid = false;
                }
                return isValid;
            }
        }

        public static bool isValidEmailId(string input)
        {
            bool isValid = true;
            if(string.IsNullOrEmpty(input)) return false;
            else
            {
                try
                {
                    MailAddress m = new MailAddress(input);
                    isValid = true;
                }
                catch(FormatException)
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.OemPeriod)))
            {
                e.Handled = true;
            }
        }
        public static void SetComboBox(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is PanelControl)
                {
                    continue;
                }

                // Check if the control is a TextBox, DateTimePicker or ComboBox
                     if (control is ComboBox cmb)
                    {
                            if (cmb.SelectedIndex == -1)
                            {
                                cmb.SelectedIndex = 0;
                            }
                     }
                
                // Recursively iterate over child controls
                if (control.HasChildren)
                {
                    SetComboBox(control);
                }
            }
        }

        public static void Required(Control control)
        {
            // Add the parameter to the command
            if (control is TextBox || control is KryptonTextBox)
            {
                if (control.Text == null)
                    control.BackColor= Color.FromArgb(255, 3, 62);
            }
            else if (control is ComboBox)
            {
            }
            else if (control is RadioButton)
            {
                if (((RadioButton)control).Checked) { }
            }
            else if (control is CheckBox)
            {
                if (((CheckBox)control).Checked) { }
            }
            else
            {
            }
        }
        
    }
}
