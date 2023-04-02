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

        public Add_New_Pregnancy(int member_id,string name)
        {
            InitializeComponent();
            Mother_id=member_id;
            lblMemberName.Text = name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static DateTime CalculateDueDate(DateTime lastPeriodDate)
        {
            // Add 280 days (40 weeks) to the last period date
            DateTime dueDate = lastPeriodDate.AddDays(280);

            // Adjust the due date based on the day of the week of the last period
            int dayOfWeek = (int)lastPeriodDate.DayOfWeek;
            if (dayOfWeek == 6)
            {
                dueDate = dueDate.AddDays(2);
            }
            else if (dayOfWeek == 0)
            {
                dueDate = dueDate.AddDays(1);
            }

            return dueDate;
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

        private void Previous_Pregnancies_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Numeric(sender, e);
        }

        private void Add_New_Pregnancy_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseClass.GetDataTable("select partner_id from member_details where member_id="+Mother_id);
            Father_Id.Text = dt.Rows[0][0].ToString();
            dt = DatabaseClass.GetDataTable("select first_name ||' '|| middle_name ||' '|| last_name as fullName from member_details where member_id=" + dt.Rows[0][0]);
            lblFatherName.Text = dt.Rows[0]["fullName"].ToString();
        }

        private void Last_Period_ValueChanged(object sender, EventArgs e)
        {
            Expected_Date.Value = CalculateDueDate(Last_Period.Value);
        }
    }
}
