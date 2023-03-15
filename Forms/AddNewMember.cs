﻿using ADRASHA_Main.Forms;
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
    public partial class AddNewMember : Form
    {
        MyFunctions myfunctions = new MyFunctions();
        int family_id;
        int member_id;
        string status;

        public AddNewMember()
        {
            InitializeComponent();
        }

        public AddNewMember(int family_id, string status)
        {
            InitializeComponent();
            this.status = status;
            this.family_id = family_id;
            member_id = DatabaseClass.GetAutoID("select max(member_id) from member_details");
            Family_Id.Text = family_id.ToString();
            Member_Id.Text = member_id.ToString();
            Partner_Id.Text= member_id.ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlidentity);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlcontact);
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlpersonal);
        }

        private void btnidentity_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlidentity);
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlcontact);
        }

        private void btnoccupation_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnloccupation);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlmaritalinfo);
        }

        private void nextbtnContact_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnloccupation);
        }

        private void btnnextidentity_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlcontact);
        }

        private void btnnextOccupation_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlmaritalinfo);
        }

        private void BtnSaveMarital_Click(object sender, EventArgs e)
        {
            DataManipulation dm = new DataManipulation();
            if (dm.InsertData("member_details", this))
            {
                MessageBox.Show("Member Registered.");
            }

            if (status == "head")
            {
                using (SqliteConnection conn = DatabaseClass.GetConnection())
                {
                    string sql = "update family_details set family_head=" + member_id + " where family_id=" + family_id;
                    SqliteCommand sqliteCommand = new SqliteCommand(sql, conn);
                    sqliteCommand.ExecuteNonQuery();
                }
            }
                this.Dispose();
                MyFunctions functions = new MyFunctions();
                functions.LoadChildForm(new FamilyProfile(family_id), MDI.childformpanel);
            
        }

        private void Adhar_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
