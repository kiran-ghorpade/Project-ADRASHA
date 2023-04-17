using System;
using System.Data;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class Analytics_Form : Form
    {
        public Analytics_Form()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Analytics_Form_Load(object sender, EventArgs e)
        {
            
            int max_age = DatabaseClass.GetAutoID("select max(age) from member_details")-1;
            int registered_population = DatabaseClass.GetAutoID("select count(member_id) from member_details")-1;
            DataTable dt1;


            //Registration Status
            dt1 = DatabaseClass.GetDataTable("select total_Population from asha_details where asha_id=1");
            int total_population = Convert.ToInt32(dt1.Rows[0][0]);
            if (registered_population > 0)
                Registered.Series["Registration"].Points.AddXY("Registered",registered_population);
            if (total_population > 0)
                Registered.Series["Registration"].Points.AddXY("Not Registered",total_population-registered_population);


            //poverty chart
            int apl = DatabaseClass.GetAutoID("select count(Family_Id) from family_details where poverty_status='APL'")-1;
            int bpl = DatabaseClass.GetAutoID("select count(family_id) from family_details where poverty_status='BPL'")-1;

            if (apl > 0)
                Poverty_Status_Chart.Series["Poverty"].Points.AddXY("Above Povert Line",apl);
            if (bpl > 0)
                Poverty_Status_Chart.Series["Poverty"].Points.AddXY("Below Povert Line",bpl);

            //Age Wise Population
            int below_5,below_18,below_30,below_60,above_60;
            below_5 = DatabaseClass.GetAutoID("select count(member_id) from member_details where age between 0 and 5")-1;
            below_18 = DatabaseClass.GetAutoID("select count(member_id) from member_details where age between 6 and 18")-1;
            below_30 = DatabaseClass.GetAutoID("select count(member_id) from member_details where age between 19 and 30")-1;
            below_60 = DatabaseClass.GetAutoID("select count(member_id) from member_details where age between 31 and 60")-1;
            above_60 = DatabaseClass.GetAutoID("select count(member_id) from member_details where age>=60")-1;

            if (below_5 > 0)
                Age_Wise_Population.Series["Age_Wise"].Points.AddXY("Below 5 years",below_5);
            if (below_18 > 0)
                Age_Wise_Population.Series["Age_Wise"].Points.AddXY("5 to 18 years",below_18);
            if (below_30 > 0) 
                Age_Wise_Population.Series["Age_Wise"].Points.AddXY("18 to 30 years",below_30);
            if (below_60 > 0) 
                Age_Wise_Population.Series["Age_Wise"].Points.AddXY("30 to 60 years",below_60);
            if (above_60 > 0) 
                Age_Wise_Population.Series["Age_Wise"].Points.AddXY("Above 60 years",above_60);
           
            //demography pie chart
            int men = DatabaseClass.GetAutoID("select count(member_id) from member_details where gender = 'Male'") - 1;
            int women = DatabaseClass.GetAutoID("select count(member_id) from member_details where gender = 'Female'") - 1;
            if (men > 0)
                Demography_Chart.Series["Demography"].Points.AddXY("Men", men);

            if (women > 0)
                Demography_Chart.Series["Demography"].Points.AddXY("Women", women);




            // NCD
            DataTable dt = DatabaseClass.GetDataTable("select DISTINCT ncd_name from ncd_details");

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DataTable dt2 = DatabaseClass.GetDataTable("select distinct memberid from ncd_details where ncd_name='" + dr["ncd_name"] + "'");

                    if (dt2.Rows.Count > 0)
                        NCD_Chart.Series["NCD"].Points.AddXY(dr["ncd_name"], dt2.Rows.Count);
                }
            }
            else
            {
                NCD_Chart.Series["NCD"].Points.AddXY("NO Data", 1);
            }
        }
    }
}
