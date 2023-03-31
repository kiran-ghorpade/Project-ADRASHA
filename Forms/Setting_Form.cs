using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class Setting_Form : Form
    {
        public Setting_Form()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(current_password.Text) ||
                string.IsNullOrEmpty(new_password.Text) ||
                string.IsNullOrEmpty(confirm_password.Text) 
                )
            {
                MessageBox.Show("All Values Required.");
                return;
            }

            DataTable dt = DatabaseClass.GetDataTable("select password from asha_details where asha_id=1");

            if (current_password.Text == dt.Rows[0][0].ToString())
            {
                if (new_password.Text == confirm_password.Text)
                {
                    DatabaseClass.UpdateRow("asha_details","asha_id",1,"password",confirm_password.Text);
                    MessageBox.Show("Password Updated");
                    current_password.Clear();
                    new_password.Clear();
                    confirm_password.Clear();
                }
                else
                {
                    MessageBox.Show("new password and confirm password should mactch.");
                }
            }
            else
            {
                MessageBox.Show("Current Password is Wrong.");
            }
        }
    }
}
