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
    public partial class Add_New_Pregnancy : Form
    {

        int Mother_id = 0;

        public Add_New_Pregnancy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnVerify.BackColor == Color.Green)
            {
                Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"Mother_Id",Mother_id},
                {"Father_Id",Father_Id.Text},
                {"Last_period",Last_Period.Value.Date},
                {"Expected_date",Expected_Date.Value.Date},
                {"Previous_Pregnancies",Previous_Pregnancies.Text}
            };

                DatabaseClass db = new DatabaseClass();
                db.InsertRow("pregnancy", data);
            }
            else
                MessageBox.Show("Verify Husband Name");
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(btnVerify.BackColor == Color.OrangeRed)
            {
                btnVerify.BackColor = Color.Green;
                btnVerify.Text = "Verified";
            }
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
