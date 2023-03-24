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
    public partial class MDI : Form
    {
        MyFunctions functions = new MyFunctions();
        bool isdigit = true;

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            SearchBoxPanel.Visible = false;
            MyFunctions.LoadChildForm(new Dashboard(),childformpanel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

            if (SearchBox.Text == "")
            {
                SearchBoxPanel.Controls.Clear();
                SearchBoxPanel.Visible = false;
                return;
            }
            else
            {
                foreach(char c in SearchBox.Text)
                {
                    if (!Char.IsDigit(c))
                        isdigit = false;
                }
            }
            
            SearchBoxPanel.Controls.Clear();
            PopulateItems();

        }



        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            SearchBox.Clear();
            SearchBoxPanel.Visible=false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want to Exit? ", "Security Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //Registry Btn
            MyFunctions.LoadChildForm(new RegistryBook_Form(), childformpanel);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //Report Btn
            //MessageBox.Show("Coming Soon");
            MyFunctions.LoadChildForm(new Reports_Form(), childformpanel);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Profile Btn
            //MessageBox.Show("Coming Soon");
            MyFunctions.LoadChildForm(new Asha_Profile(), childformpanel);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            //Setting Btn
            //MessageBox.Show("Coming Soon");
            MyFunctions.LoadChildForm(new Setting_Form(),childformpanel);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Dashboard Btn
            //MessageBox.Show("Coming Soon");
            MyFunctions.LoadChildForm(new Dashboard(),childformpanel);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            //Analytics Btn
            // MessageBox.Show("Coming Soon");
            MyFunctions.LoadChildForm(new  Analytics_Form(),childformpanel);
        }

        //private void PopulateItems()
        //{
        //    MemberListView[] listView = new MemberListView[10];
        //    for (int i = 0; i < listView.Length; i++)
        //    {
        //        listView[i] = new MemberListView();
        //        listView[i].Title = "Madhav Mane";
        //        listView[i].FamilyID = "" + i;
        //        listView[i].age = "" + (i * 2);

        //        if (SearchBoxPanel.Controls.Count < 0)
        //        {
        //            SearchBoxPanel.Controls.Clear();
        //        }
        //        else
        //        {
        //            listView[i].Width = SearchBoxPanel.Width - 40;
        //            SearchBoxPanel.Controls.Add(listView[i]);
        //        }
        // }

        private void PopulateItems()
        {
            SearchBoxPanel.Visible = false;
            int age; //string name="";
            SqliteCommand cmd = null ;
            MyFunctions functions = new MyFunctions();
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                if (isdigit == true)
                {
                    //values for id
                    cmd = new SqliteCommand("select member_id,first_name,middle_name,last_name,birth_date from member_details where member_id like '%"+SearchBox.Text+"%' limit 10", conn);
                }
                else
                {
                    string s = SearchBox.Text;
  
                    cmd = new SqliteCommand("select member_id,first_name,middle_name,last_name,birth_date from member_details where first_name like '%" + s + "%' or middle_name like '%" + s + "%' or last_name Like '%" + s + "%' limit 10", conn);
                }
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
                    listView.age = age.ToString();

                    if (SearchBoxPanel.Controls.Count < 0)
                    {
                        SearchBoxPanel.Controls.Clear();
                    }
                    else
                    {
                        listView.Width = SearchBoxPanel.Width - 40;
                        SearchBoxPanel.Controls.Add(listView);
                    }
                }
            }

            SearchBoxPanel.BringToFront();
            SearchBoxPanel.Visible = true;
        }

    }
}
