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
    public partial class Add_New_Family : Form
    {
        MyFunctions functions= new MyFunctions();

        public Add_New_Family()
        {
            InitializeComponent();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlFamilyDetails);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlresidential);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlresidential);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataManipulation dm = new DataManipulation();
            if (dm.InsertData("family_details", this))
            {
                MessageBox.Show("Data Inserted.");
                this.Dispose();
                int family_id = DatabaseClass.GetAutoID("select max(family_id) from family_details")-1;
                functions.LoadChildForm(new Add_New_Member(family_id,"head"),MDI.childformpanel);

            }
        }
    }
}
