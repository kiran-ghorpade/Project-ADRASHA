using ADRASHA_Main.Forms;
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

namespace ADRASHA_Main
{
    public partial class MemberHealthProfile : Form
    {
        MyFunctions MyFunctions = new MyFunctions();
        int member_id = 5;
        int family_id = 0;
        string name;

        public MemberHealthProfile()
        {
            InitializeComponent();
            SetOutputData();
        }

        public MemberHealthProfile(int member_id)
        {
            InitializeComponent();
            this.member_id = member_id;
            SetOutputData();
        }

        private void SetOutputData()
        {
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                // personal details from member details
                SqliteCommand cmd = new SqliteCommand("select * from member_details where member_id =" + member_id, conn);
                SqliteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    lblMemberName.Text = name;
                    family_id = Convert.ToInt32(reader["family_id"]);
                }
            }
        }
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBasicHealth_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlBasicHealth);
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlVaccination);
        }

        private void btnMaternalHealth_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlMaternal);
        }

        private void btnHBNC_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlHBNC);
        }

        private void btnNCD_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlNCD);
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            MemberProfile profile = new MemberProfile(member_id);
            MyFunctions.LoadChildForm(profile,MDI.childformpanel);
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            FamilyProfile familyProfile = new FamilyProfile(family_id);
            MyFunctions.LoadChildForm(familyProfile,MDI.childformpanel);
        }
    }
}

