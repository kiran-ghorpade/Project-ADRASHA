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

        private void Add_New_Family_Load(object sender, EventArgs e)
        {
            Validation.SetComboBox(this);
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
            bool valid = true;
            if (string.IsNullOrEmpty(Total_Members.Text) ||
                 House_Type.SelectedIndex == 0 ||
                 Vehicle.SelectedIndex == 0 ||
                 Toilet_Type.SelectedIndex == 0 ||
                 Fuel_Type.SelectedIndex == 0 ||
                 Residence_Type.SelectedIndex == 0 ||
                 Water_Supply.SelectedIndex == 0 ||
                 Electricity_Type.SelectedIndex == 0 ||
                 !(rdbtnAPL.Checked || rdbtnBPL.Checked)
                )
            {
                valid = false;
            }

            if (valid)
            {
                functions.nextpanel_code(pnlresidential);
            }
            else
            {
                MessageBox.Show("All values Required");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(Total_Members.Text) ||
                string.IsNullOrEmpty(Village.Text) ||
                string.IsNullOrEmpty(PinCode.Text) ||
                string.IsNullOrEmpty(Taluka.Text) ||
                string.IsNullOrEmpty(District.Text) ||
                string.IsNullOrEmpty(State.Text) ||
                string.IsNullOrEmpty(Country.Text)   
                )
            {
                valid = false;
            }

            if (valid)
            {
                DataManipulation dm = new DataManipulation();
                if (dm.InsertData("family_details", this))
                {
                    MessageBox.Show("Data Inserted.");
                    this.Dispose();
                    int family_id = DatabaseClass.GetAutoID("select max(family_id) from family_details") - 1;
                    functions.LoadChildForm(new Add_New_Member(family_id, "head"), MDI.childformpanel);

                }
            }
            else
            {
                MessageBox.Show("All values Required");
            }
        }

        private void Total_Members_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Numeric(sender,e);
        }
        private void PinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Text(sender, e);
        }
    }
}
