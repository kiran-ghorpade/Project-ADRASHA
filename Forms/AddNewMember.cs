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

        public AddNewMember()
        {
            InitializeComponent();
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
                MessageBox.Show("Data Inserted.");
          
        }

        private void Adhar_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
