using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ADRASHA_Main.Forms
{
    public partial class Maternal_Health_Form : Form
    {
        int member_id = 10;
        public Maternal_Health_Form(int member_id , string name)
        {
            InitializeComponent();
            this.member_id = member_id;
            lblMemberName.Text = name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                   {"Mother_Id",member_id},
                   {"Visit_Date",Visit_date.Value.Date},
                   {"Month_of_Pregnancy",Month_Of_Pregnancy.SelectedItem},
                   {"Blood_Pressure",Blood_pressure.Text},
                   {"Weight",Weight.Text},
                   {"TT_Injection_Status",TT_injection_status.SelectedItem},
                   {"Iron_Tablets_Status",Iron_tablets_Status.SelectedItem},
                   {"Iron_Tablet_Given_Date",Iron_Tablet_Given_Date.Value.Date}
            };

            DatabaseClass db = new DatabaseClass();
            db.InsertRow("Pregnancy_VIsits",data);

            this.Dispose();
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
