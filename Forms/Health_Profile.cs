﻿using ADRASHA_Main.Forms;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class Health_Profile : Form
    {
        MyFunctions MyFunctions = new MyFunctions();
        readonly int member_id = 5;
        int family_id = 0, Age;
        string name, Gender;

        public Health_Profile()
        {
            InitializeComponent();
            SetOutputData();
        }

        public Health_Profile(int member_id)
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
                    Gender = reader["gender"].ToString();
                    Age = Convert.ToInt32(reader["age"]);
                    family_id = Convert.ToInt32(reader["family_id"]);
                }
            }
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            Member_Profile profile = new Member_Profile(member_id);
            this.Dispose();
            MyFunctions.LoadChildForm(profile,MDI.childformpanel);
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            Family_Profile familyProfile = new Family_Profile(family_id);
            this.Dispose();
            MyFunctions.LoadChildForm(familyProfile,MDI.childformpanel);
        }

        private void btnUpdateVaccination_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Vaccination_Form(member_id,name),MDI.childformpanel);
        }

        private void panelControl2_Load(object sender, EventArgs e)
        {

        }

        private void Member_Health_Profile_Load(object sender, EventArgs e)
        {
            setData();
            if(Gender == "Male")
            {
                btnMaternalHealth.Enabled = false;
                btnAddNewVisit.Enabled = false;
                btn_new_pregnancy.Enabled = false;
            }
            if(Age > 18)
            {
                btnUpdateVaccination.Enabled = false;
                btnHBNC.Enabled = false;
            }
        }

        private void setData()
        {
            try
            {
                //Vaccination Data
                DataTable dt;

                string[] vaccines = {"BCG_D1","HepB_D1","HepB_D2","HepB_D3",
                                 "DTaP_D1","DTaP_D2","DTaP_D3","DTap_B1",
                                 "Tdap_B2",
                                 "IPV_D1","IPV_D2","IPV_D3","IPV_B1","IPV_B2",
                                 "Hib_D1","Hib_D2","Hib_D3","Hib_B1","Hib_B2",
                                 "PCV_D1","PCV_D2","PCV_B1",
                                 "MMR_D1","MMR_D2",
                                 "VAR_D1","VAR_D2",
                                 "HPV_D1","HPV_D2"
                                };
                foreach (string vaccine in vaccines)
                {
                    dt = DatabaseClass.GetDataTable("select * from vaccination where member_id=" + member_id + " and vaccine_name='" + vaccine + "'");

                    if (dt.Rows.Count == 1)
                    {
                        setBtnColor(vaccine);
                    }
                }

                //Maternal Health
                lblTotalVisits.Text = (DatabaseClass.GetAutoID("select max(Pregnancy_Visit_id) from Pregnancy_Visits where Mother_id=" + member_id) - 1).ToString();
                dt = DatabaseClass.GetDataTable("select * from pregnancy where mother_id=" + member_id);
                if (dt.Rows.Count > 0)
                {
                    lblLMPDate.Text = dt.Rows[0]["Last_period"].ToString();
                    lblExpectedDeliveryDate.Text = dt.Rows[0]["Expected_date"].ToString();
                }
                dt = DatabaseClass.GetDataTable("select visit_date from Pregnancy_Visits where mother_id = " + member_id + " order by visit_date desc");
                lblLastVisitDate.Text = dt.Rows[0][0].ToString();
            }
            catch(Exception) {
                return;
            }
        }

        //for vaccination status
        private void setBtnColor(string vaccine)
        {
            Control btn = searchBtn(this.pnlVaccination, vaccine);
                btn.Visible=true;
        }

        private Control searchBtn(Control panel, string vaccine)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is PanelControl)
                {
                    continue;
                }

                // Check if the control is button
                if (control is PictureBox)
                {
                    if (control.Name == vaccine)
                    {
                        return control;
                    }

                    control.Visible = false;
                }

                // Recursively iterate over child controls
                if (control.HasChildren)
                {
                    searchBtn(control, vaccine);
                }
            }
            return null;
        }

        private void btnUpdateHBNC_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new HBNC(member_id,name),MDI.childformpanel);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new NCD(member_id,name),MDI.childformpanel);
        }

        private void btnAddNewVisit_Click(object sender, EventArgs e)
        {
            Maternal_Health_Form mhf = new Maternal_Health_Form(member_id,name);
            mhf.ShowDialog();
        }

        private void btn_new_pregnancy_Click(object sender, EventArgs e)
        {
            Add_New_Pregnancy add = new Add_New_Pregnancy(member_id,name);
            add.ShowDialog();
        }
    }
}

