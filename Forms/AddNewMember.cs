using ADRASHA_Main.Forms;
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

        public AddNewMember()
        {
            InitializeComponent();
        }

        public AddNewMember(int family_id)
        {
            InitializeComponent();
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

            Dictionary<string, object> updatedValue = new Dictionary<string, object>
            {
                {"family_head", member_id }
            };
            DatabaseClass db = new DatabaseClass();
            db.UpdateRow("family_details","family_id",family_id,updatedValue);
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
