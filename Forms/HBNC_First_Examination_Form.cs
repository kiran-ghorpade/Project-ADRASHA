using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ADRASHA_Main.Forms
{
    public partial class HBNC_First_Examination_Form : Form
    {
        int member_id;

        public HBNC_First_Examination_Form(int member_id, string name)
        {
            InitializeComponent();
            this.member_id = member_id;
            lblMemberName.Text = name;
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Weight.Text))
            {
                MessageBox.Show("Weight Required.");
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                    {"VISIT_DATE",Visit_date.Value.Date},
                    {"MEMBER_ID",member_id},
                    {"BIRTH_DATE",Birth_date.Value.Date},
                    {"PRETERM_status",Pre_term_status.SelectedItem},
                    {"BIRTH_TIME",Birth_Time.Value.TimeOfDay},
                    {"PROBLEM",Mother_problem.SelectedItem},
                    {"HOW_FEED",baby_feed.SelectedItem},
                    {"BABY_WEIGHT",Weight.Text}
            };

            DatabaseClass db = new DatabaseClass();

            if (db.InsertRow("homedelivery_visit", data))
            {
                MessageBox.Show("Data Inserted.");
            }
            else
                MessageBox.Show("Error");
        }

        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Numeric(sender,e);
        }

        private void HBNC_First_Examination_Form_Load(object sender, EventArgs e)
        {
            Validation.SetComboBox(panel1);
        }
    }
}
