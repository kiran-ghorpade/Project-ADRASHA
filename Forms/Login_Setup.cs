using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ADRASHA_Main
{
    public partial class Login_Setup: KryptonForm
    {
        public Login_Setup()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (password.Text == "" ||
                Confirm_password.Text=="")
            {
                MessageBox.Show("All fields Required.");
                return;
            }

            if(password.Text == Confirm_password.Text)
            {
                string encrypted_pass = MyFunctions.Protect(Confirm_password.Text);
                if (DatabaseClass.UpdateRow("asha_details", "asha_id", 1, "password", encrypted_pass))
                {
                    MessageBox.Show("Registered Successfully.", "ADRASHA"); 
                    Application.Restart();
                }

            }
            else
            {
                MessageBox.Show("Confirm Password Should MATCH.", "ADRASHA");
            }
        }
    }
}
