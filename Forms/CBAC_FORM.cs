using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ADRASHA_Main.Forms
{
    public partial class CBAC_FORM : Form
    {
        MyFunctions MyFunctions = new MyFunctions();
        public CBAC_FORM(int member_id,string name)
        {
            InitializeComponent();
            this.member_id = member_id;
            DataRow dr= DatabaseClass.GetRowById("Member_details","member_id",member_id);
            lblMemberName.Text = name;
            int age = MyFunctions.CalculateAge(dr["birth_date"].ToString());
            if (age >= 30 && age < 40)
                Age.Text = "0";
            else if (age >=40 && age<50)
                Age.Text = "1";
            else if(age >=50)
                Age.Text = "2";
            else
                Age.Text = "0";
        }

        int total=0;
        int member_id;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Total_Score.Text == "None")
                MessageBox.Show("All Values Required.");
            else
            {
                DataManipulation dataManipulation = new DataManipulation();
                if (MessageBox.Show("Are you Sure to Save CBAC Form ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataManipulation.InsertData("CBAC_details", this);
                    DataTable dt = DatabaseClass.GetDataTable("select max(cbac_id) from cbac_details");
                    DatabaseClass.ExecuteNonQuery("update cbac_details set member_Id="+member_id+" where cbac_id=" + dt.Rows[0][0]);
                    MessageBox.Show("CBAC Form Added.");
                }
            }
        }

        private void NCD_Profile_Form_Load(object sender, EventArgs e)
        {
            Validation.SetComboBox(pnlCBAC);
        }

        private void btnAge_0_Click(object sender, EventArgs e)
        {
            Age.Text = "0";
        }

        private void btnAge_1_Click(object sender, EventArgs e)
        {
            Age.Text= "1";
        }

        private void btnAge_2_Click(object sender, EventArgs e)
        {
            Age.Text= "2";
        }

        private void btnGutka_0_Click(object sender, EventArgs e)
        {
            Gutka.Text = "0";
        }

        private void btnGutka_1_Click(object sender, EventArgs e)
        {
            Gutka.Text= "1";
        }

        private void btnGutka_2_Click(object sender, EventArgs e)
        {
            Gutka.Text = "2";
        }

        private void BtnAlcohol_0_Click(object sender, EventArgs e)
        {
            Alcohol.Text = "0";
        }

        private void BtnAlcohol_1_Click(object sender, EventArgs e)
        {
            Alcohol.Text= "1";
        }

        private void BtnWaist_0_Click(object sender, EventArgs e)
        {
            Waist.Text = "0";
        }

        private void BtnWaist_1_Click(object sender, EventArgs e)
        {
            Waist.Text= "1";
        }

        private void BtnWaist_2_Click(object sender, EventArgs e)
        {
            Waist.Text="2";
        }

        private void BtnExercise_0_Click(object sender, EventArgs e)
        {
            Exercise.Text = "0";
        }

        private void BtnExercise_1_Click(object sender, EventArgs e)
        {
            Exercise.Text= "1";
        }

        private void btnFamily_0_Click(object sender, EventArgs e)
        {
            History.Text = "0";
        }

        private void btnFamily_2_Click(object sender, EventArgs e)
        {
            History.Text= "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            total = 0;
            total += Convert.ToInt32(Age.Text);
            total += Convert.ToInt32(Alcohol.Text);
            total += Convert.ToInt32(Gutka.Text);
            total += Convert.ToInt32(Waist.Text);
            total += Convert.ToInt32(Exercise.Text);
            total += Convert.ToInt32(History.Text);

            Total_Score.Text = total.ToString();

        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new Health_Profile(member_id),MDI.childformpanel);
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new Member_Profile(member_id),MDI.childformpanel);
        }
    }
}
