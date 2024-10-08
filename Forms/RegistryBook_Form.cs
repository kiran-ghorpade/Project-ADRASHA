﻿using ADRASHA_Main.Forms;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class RegistryBook_Form : Form
    {
        MyFunctions functions = new MyFunctions();
        DatabaseClass db = new DatabaseClass();

        public RegistryBook_Form()
        {
            InitializeComponent();
            PopulateItems();
            //updatePanel();
        }

        private void main_panelcontrol_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Add_New_Family(), MDI.childformpanel);
        }

        private void RegistryBookForm_Load(object sender, EventArgs e)
        {

        }

        private void PopulateItems()
        {
            int head;
            using (SqliteConnection conn = DatabaseClass.GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand("select family_id, total_members, family_head from family_details order by family_id", conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                FamilyListView listView;
                while (reader.Read())
                {
                    //head = int.Parse((reader["family_head"].ToString()));
                    head = Convert.ToInt32(reader["family_Head"]);

                    SqliteCommand cmd1 = new SqliteCommand("select first_name,middle_name, last_name from member_details where member_id=" + head, conn);
                    SqliteDataReader reader1 = cmd1.ExecuteReader();

                    listView = new FamilyListView();
                    while (reader1.Read())
                    {
                        string name = reader1["first_name"].ToString() + " " + reader1["middle_name"].ToString() + " " + reader1["last_name"].ToString();
                        listView.Title = name;
                    }
                    listView.FamilyID = reader["family_id"].ToString();
                    listView.TotalMemebers = reader["total_members"].ToString();

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

        private void ListViewPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }
    }
}
