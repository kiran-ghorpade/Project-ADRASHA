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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            setupDashboard();
        }

        void setupDashboard()
        {
            // Information Cards
            int total_families= DatabaseClass.GetAutoID("select Total_Families from asha_details where asha_id=1")-1;
            int total_population = DatabaseClass.GetAutoID("select Total_Population from asha_details where asha_id=1")-1;
            int totalRegisteredPopulation=DatabaseClass.GetAutoID("select count(member_id) from member_details")-1;
            int total_registered_families = DatabaseClass.GetAutoID("select count(family_id) from family_details")-1;
            int total_pregnancy = DatabaseClass.GetAutoID("select count(Pregnancy_Id) from pregnancy")-1;
            int total_children=DatabaseClass.GetAutoID("select count(member_id) from member_details where age between 0 and 5")-1;


            lblTotalFamilies.Text= total_families.ToString();
            lblTotalPopulation.Text= total_population.ToString();
            lblTotal_Registered_Families.Text= total_registered_families.ToString();
            lblRegisteredPopulation.Text= totalRegisteredPopulation.ToString();
            lblTotalPregnancy.Text= total_pregnancy.ToString();
            lblChildren.Text= total_children.ToString();


            //demography pie chart
            int men = DatabaseClass.GetAutoID("select count(member_id) from member_details where gender = 'Male'")-1;
            int women = DatabaseClass.GetAutoID("select count(member_id) from member_details where gender = 'Female'")-1;
            if (men > 0 )
                Demography_Chart.Series["Demography"].Points.AddXY("Men", men);

            if (women > 0)
                Demography_Chart.Series["Demography"].Points.AddXY("Women", women);
            
            


            // Pie Chartss
            DataTable dt = DatabaseClass.GetDataTable("select DISTINCT ncd_name from ncd_details");
            
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DataTable dt1 = DatabaseClass.GetDataTable("select distinct memberid from ncd_details where ncd_name='" + dr["ncd_name"] + "'");

                    if(dt1.Rows.Count >0)
                    NCD_Chart.Series["NCD"].Points.AddXY(dr["ncd_name"], dt1.Rows.Count);
                }
            }
            else
            {
                NCD_Chart.Series["NCD"].Points.AddXY("NO Data",1);
            }

            //Upcoming Vaccination Notification
            string next = DateTime.Now.Date.AddDays(10).ToString("yyyy-MM-dd");
            string sql =@" select
                         vaccination.Member_Id as child_id,
                         vaccination.next_Vaccine_DATE as next_date,
                         vaccination.next_Vaccine_name as next_vaccine,
                         member_details.First_Name||' '||member_details.Middle_Name||' '||member_details.Last_Name as child_name
                         from vaccination 
                         join member_details
                        where (next_vaccine_date between '"+DateTime.Now.Date.ToString("yyyy-MM-dd") +"' and '"+next+"') and member_details.Member_Id=vaccination.Member_Id order by next_vaccine_date desc";
            DatabaseClass.BindGridView(GridUpcomingVaccination,sql);
        }
    }
}
