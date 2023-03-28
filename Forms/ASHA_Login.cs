using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class ASHA_Login : Form
    {   Form parent = null;
        public ASHA_Login(Form frm)
        {
            InitializeComponent();
            this.parent = frm;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text))
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Enter Password here .";
                lblWarning.ForeColor = Color.Red;
                lblWarning.Refresh();
                Password.Focus();
            }
            else
            {
                lblWarning.Visible = false;

                DataTable dt = DatabaseClass.GetDataTable($"select * from asha_details where password = '{Password.Text}'");

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    parent.Hide();
                    MDI mDI = new MDI();

                     mDI.ShowDialog();
                }
                else
                {
                    lblWarning.Visible = true;
                    lblWarning.ForeColor= Color.Red;
                    lblWarning.Text = "Password Incorrect.";
                    lblWarning.Refresh();
                    Password.Clear();
                    Password.Focus();
                }
            }
        }

        private void ASHA_Login_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            Password.Focus();
        }
    }
}
