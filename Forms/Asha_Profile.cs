using System;
using System.Data;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class Asha_Profile : Form
    {
        public Asha_Profile()
        {
            InitializeComponent();
        }

        private void Asha_Profile_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseClass.GetDataTable("select * from asha_details where asha_id=1");

            string fullName= dt.Rows[0]["first_name"].ToString()+" "+ dt.Rows[0]["middle_name"].ToString()+" "+ dt.Rows[0]["last_name"].ToString();
        
            lblashaname.Text = fullName;
            lblBirthDate.Text = dt.Rows[0]["birth_date"].ToString();
            lblMobileNo.Text = dt.Rows[0]["mobile_no"].ToString();
            lblQualification.Text = dt.Rows[0]["Qualifications"].ToString();
            lblMaritalStatus.Text = dt.Rows[0]["marital_status"].ToString();
            lblSubCenter.Text = dt.Rows[0]["sub_center"].ToString();
            lblVillage.Text = dt.Rows[0]["village"].ToString();
            lblPincode.Text = dt.Rows[0]["pincode"].ToString();
            lblDistrict.Text = dt.Rows[0]["district"].ToString();
            lblTaluka.Text = dt.Rows[0]["taluka"].ToString();
            lblState.Text = dt.Rows[0]["state"].ToString();
            lblTotalFamilies.Text = dt.Rows[0]["total_families"].ToString();
            lblTotalPopulation.Text = dt.Rows[0]["total_population"].ToString();
            lblVillageType.Text = dt.Rows[0]["village_type"].ToString();
        }
    }
}
