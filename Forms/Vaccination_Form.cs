using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class Vaccination_Form : Form
    {
        int memberId;
        string vaccineName = null, name;
        MyFunctions MyFunctions = new MyFunctions();
        DatabaseClass db = new DatabaseClass();


        public Vaccination_Form(int memberId,string name)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.name= name;
        }

        private void btnBCG_D1_Click(object sender, EventArgs e)
        {
            if(BCG_D1.BackColor == Color.Red)
            pnlDatePIcker.Visible = true;
            vaccineName = "BCG_D1";
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Health_Profile(memberId), MDI.childformpanel);
        }

        private void Vaccination_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseClass.GetDataTable("select gender from member_details where member_id="+memberId);
            if (dt.Rows[0][0].ToString()!="Female")
            {
                HPV_D1.Enabled = false;
                HPV_D2.Enabled = false;
            }
            pnlDatePIcker.Visible = false;
            lblMemberName.Text = name;
            setData();
        }

        private void setData()
        {
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
                dt = DatabaseClass.GetDataTable("select * from vaccination where member_id=" + memberId + " and vaccine_name='" + vaccine+"'");

                if (dt.Rows.Count == 1)
                {
                    setBtnColor(vaccine);
                }
            }
        }

        private void setBtnColor(string vaccine)
        {
            Control btn = searchBtn(this.pnlVaccineBack, vaccine);
           if (btn.BackColor == Color.Red)
               btn.BackColor = Color.Green;
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
                if (control is Button || control is KryptonButton)
                {
                    if (control.Name == vaccine)
                    {
                        return control;
                    }

                    control.BackColor= Color.Red;
                }

                // Recursively iterate over child controls
                if (control.HasChildren)
                {
                    searchBtn(control,vaccine);
                }
            }
            return null;
        }

        private void btnAddVaccination_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Vaccination_Place.Text))
            {
                MessageBox.Show("Place Required.");
                return;
            }

            if (MessageBox.Show("are you sure !","", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { DateTime dateTime = Vaccination_Date.Value.Date;
                string date = dateTime.ToString("yyyy-MM-dd");
                string place = Vaccination_Place.Text;

                Dictionary<string, object> vaccine = new Dictionary<string, object>
            {
                {"Member_id",memberId},
                {"Vaccine_name",vaccineName},
                {"Given_on",date},
                {"Given_at",place}
            };

                if (db.InsertRow("vaccination", vaccine))
                {
                    MessageBox.Show("Vaccination Added.");
                }
                setData();
                pnlDatePIcker.Visible = false;
            }
        }

        private void Vaccination_Place_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Text(sender,e);
        }

        private void HepB_D1_Click(object sender, EventArgs e)
        {
            if (HepB_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "HepB_D1";
        }

        private void HepB_D2_Click(object sender, EventArgs e)
        {
            if (HepB_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "HepB_D2";
        }

        private void HepB_D3_Click(object sender, EventArgs e)
        {
            if (HepB_D3.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "HepB_D3";
        }

        private void DTaP_D1_Click(object sender, EventArgs e)
        {
            if (DTaP_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "DTaP_D1";
        }

        private void DTaP_D2_Click(object sender, EventArgs e)
        {
            if (DTaP_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "DTaP_D2";
        }

        private void DTaP_D3_Click(object sender, EventArgs e)
        {
            if (DTaP_D3.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "DTaP_D3";
        }

        private void DTaP_B1_Click(object sender, EventArgs e)
        {
            if (DTaP_B1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "DTaP_B1";
        }

        private void Tdap_B2_Click(object sender, EventArgs e)
        {
            if (Tdap_B2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "Tdap_B2";
        }

        private void IPV_D1_Click(object sender, EventArgs e)
        {
            if (IPV_B1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "IPV_D1";
        }

        private void IPV_D2_Click(object sender, EventArgs e)
        {
            if (IPV_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "IPV_D2";
        }

        private void IPV_D3_Click(object sender, EventArgs e)
        {
            if (IPV_D3.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "IPV_D3";
        }

        private void IPV_B1_Click(object sender, EventArgs e)
        {
            if (IPV_B1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "IPV_B1";
        }

        private void Hib_B2_Click(object sender, EventArgs e)
        {
            if (IPV_B2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "IPV_B2";
        }

        private void Hib_D1_Click(object sender, EventArgs e)
        {
            if (Hib_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "Hib_D1";
        }

        private void Hib_D2_Click(object sender, EventArgs e)
        {
            if (Hib_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "Hib_D2";
        }

        private void Hib_D3_Click(object sender, EventArgs e)
        {
            if (Hib_D3.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "Hib_D3";
        }

        private void Hib_B1_Click(object sender, EventArgs e)
        {
            if (Hib_B1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "Hib_B1";
        }

        private void PCV_D1_Click(object sender, EventArgs e)
        {
            if (PCV_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "PCV_D1";
        }

        private void PCV_D2_Click(object sender, EventArgs e)
        {
            if (PCV_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "PCV_D2";
        }

        private void PCV_B1_Click(object sender, EventArgs e)
        {
            if (PCV_B1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "PCV_B1";
        }

        private void MMR_D1_Click(object sender, EventArgs e)
        {
            if (MMR_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "MMR_D1";
        }

        private void MMR_D2_Click(object sender, EventArgs e)
        {
            if (MMR_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "MMR_D2";
        }

        private void VAR_D1_Click(object sender, EventArgs e)
        {
            if (VAR_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "VAR_D1";
        }

        private void VAR_D2_Click(object sender, EventArgs e)
        {
            if (VAR_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "VAR_D2";
        }

        private void HPV_D1_Click(object sender, EventArgs e)
        {
            if (HPV_D1.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "HPV_D1";
        }

        private void HPV_D2_Click(object sender, EventArgs e)
        {
            if (HPV_D2.BackColor == Color.Red)
                pnlDatePIcker.Visible = true;
            vaccineName = "HPV_D2";
        }

        private void btnPnlClose_Click(object sender, EventArgs e)
        {
            pnlDatePIcker.Visible=false;
        }
    }
}
