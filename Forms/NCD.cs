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
    public partial class NCD : Form
    {
        int member_id;
        string name;

        public NCD(int member_Id, string name)
        {
            InitializeComponent();
            this.member_id = member_Id;
            this.name = name;
            lblMemberName.Text = name;
        }

        private void NCD_FORM_Load(object sender, EventArgs e)
        {

            disable();
        }

        void disable()
        {
            btnAdd.Enabled = false;
            Screening_Date.Enabled = false;
            NCD_Name.Enabled = false;
            Diagnosis_Date.Enabled = false;
            Treatement_Status.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            NCD_Name.SelectedIndex = 0;
            Treatement_Status.SelectedIndex = 0;
            btnAdd.Enabled = true;
            Screening_Date.Enabled = true;
            NCD_Name.Enabled = true;
            Diagnosis_Date.Enabled = true;
            Treatement_Status.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"memberId",member_id },
                {"NCD_Name",NCD_Name.SelectedItem},
                {"Diagnosis_Date",Diagnosis_Date.Value.Date },
                {"Screening_Date",Screening_Date.Value.Date },
                {"Treatement_Status",Treatement_Status.SelectedItem},
            };

            DatabaseClass db = new DatabaseClass();
            db.InsertRow("NCD_details", data);

            clear();
            disable();

        }

        private void btnAddCBAC_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new CBAC_FORM(member_id,name),MDI.childformpanel);
        }
    }
}
