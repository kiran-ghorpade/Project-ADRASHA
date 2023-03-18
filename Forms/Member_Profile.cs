using Microsoft.Data.Sqlite;
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
    public partial class Member_Profile : Form
    {
        MyFunctions functions = new MyFunctions();
        int member_id=5;
        int family_id = 1;

        public Member_Profile()
        {
            InitializeComponent();
            SetOutputData();
        }
        public Member_Profile(int member_id)
        {
            InitializeComponent();
            this.member_id=member_id;
            SetOutputData();
        }

        private void SetOutputData()
        {
            int partner_id=5;
            string marital_status="single";
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                // personal details from member details
                SqliteCommand cmd = new SqliteCommand("select * from member_details where member_id =" + member_id, conn);
                SqliteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString()+" " + reader["middle_name"].ToString()+" " + reader["last_name"].ToString();
                    lblHeadName.Text =name;
                    family_id= Convert.ToInt32(reader["family_Id"]);
                    lblPersonalId.Text = reader["member_id"].ToString();
                    lblFamilId.Text = family_id.ToString();
                    lblBirthDate.Text = reader["birth_date"].ToString();
                    lblBirthPlace.Text = reader["Birth_Place"].ToString();
                    lblGender.Text = reader["Gender"].ToString();
                    lblEducation.Text = reader["Education"].ToString();
                    lblOccupationName.Text = reader["Occupation_name"].ToString();
                    lblWorkPlace.Text = reader["work_place"].ToString();
                    lblWorkType.Text = reader["work_type"].ToString();
                    lblABHAId.Text = reader["abha_number"].ToString();
                    lblAdharId.Text = reader["adhar_number"].ToString();
                    lblMobileNo.Text = reader["mobile_number"].ToString();

                    marital_status= reader["marital_status"].ToString();
                    lblMaritalStatus.Text = marital_status;
                    lblMarriageDate.Text = reader["marriage_Date"].ToString() ;
                    lblNoOfChild.Text = reader["child_number"].ToString();

                    if (marital_status.Equals("Married"))
                    {
                        partner_id = int.Parse(reader["partner_id"].ToString());
                        lblPartnerPersonalId.Text = partner_id.ToString();
                    }

                }

                // residential details from family details
                SqliteCommand cmd1 = new SqliteCommand("select * from family_details where family_id =" +family_id, conn);
                SqliteDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    lblVillage.Text = reader1["village"].ToString();
                    lblPinCode.Text = reader1["PinCode"].ToString();
                    lblTaluka.Text = reader1["taluka"].ToString();
                    lblState.Text = reader1["state"].ToString();
                    lblCountry.Text = reader1["country"].ToString();
                }

                if (marital_status.Equals("Married"))
                {
                    // partner details from member details
                    SqliteCommand cmd2 = new SqliteCommand("select * from member_details where member_id =" + partner_id, conn);
                    SqliteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        string name = reader["first_name"].ToString() + " " + reader["middle_name"].ToString() + " " + reader["last_name"].ToString();
                        lblPartnerName.Text = name;
                    }
                }

            }

        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlPersonal);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlMaritalInfo);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlResidential);
        }

        void Submit()
        {
            DataManipulation dm = new DataManipulation();
            dm.InsertData("member",this);
        }

        private void MemberProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnFamilyProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            functions.LoadChildForm(new Add_New_Member(family_id, ""), MDI.childformpanel);
        }

        private void btnHealthProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            functions.LoadChildForm(new Member_Health_Profile(member_id),MDI.childformpanel);
        }
    }
}
