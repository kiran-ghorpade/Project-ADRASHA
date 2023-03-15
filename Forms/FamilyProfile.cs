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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADRASHA_Main.Forms
{
    public partial class FamilyProfile : Form
    {
        int family_id = 1;
        MyFunctions MyFunctions = new MyFunctions();

        public FamilyProfile()
        {
            InitializeComponent();
            SetOutputData();
        }
        public FamilyProfile(int  family_id)
        {
            InitializeComponent();
            this.family_id = family_id;
            SetOutputData();
        }
        private void FamilyProfile_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void SetOutputData()
        {
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("select * from family_details where family_id ="+family_id, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
            
                while (reader.Read())
                {
                    string head= reader["family_head"].ToString();
                    SqliteCommand cmd1 = new SqliteCommand("select first_name,middle_name,last_name from member_details where member_id=" + head, conn);
                    SqliteDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read()) 
                    lblHeadName.Text = reader1["first_name"].ToString() + " " + reader1["middle_name"].ToString() + " " + reader1["last_name"].ToString();
                    
                    lblFamilyID.Text = reader["family_Id"].ToString();
                    lblTotalMembers.Text = reader["total_members"].ToString();
                    lblhousetype.Text = reader["house_type"].ToString();
                    lblvehicles.Text = reader["vehicle"].ToString();
                    lbltoilet.Text = reader["toilet_type"].ToString();
                    lbllpg.Text = reader["fuel_type"].ToString();
                    lblaplbpl.Text = reader["poverty_status"].ToString();
                    lblresidence.Text = reader["residence_type"].ToString();
                    lblwatersupply.Text = reader["water_supply"].ToString();
                    lbleletricity.Text = reader["electricity_type"].ToString();
                }

            }

        }
        private void PopulateItems()
        {
            int age;
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                //getting values;
                SqliteCommand cmd = new SqliteCommand("select member_id,first_name,middle_name,last_name,birth_date from member_details where family_id=" + family_id, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                MemberListView listView;

                while (reader.Read())
                {
                    listView = new MemberListView();
                    
                    //to set values to the form 
                    listView.Title = reader["first_name"].ToString() + " " + reader["middle_name"].ToString() + " " + reader["last_name"].ToString();
                    listView.MemberID = reader["member_id"].ToString();


                    //calculating age and set it to the form

                    age = MyFunctions.CalculateAge(reader["birth_date"].ToString());
                    listView.age = age.ToString() ;

                    if (ListViewPanel.Controls.Count < 0)
                    {
                        ListViewPanel.Controls.Clear();
                    }
                    else
                    {
                        listView.Width = ListViewPanel.Width - 30;
                        ListViewPanel.Controls.Add(listView);
                    }
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new AddNewMember(family_id),MDI.childformpanel);
        }
    }

}