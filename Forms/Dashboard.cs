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

            //demography pie chart
            Demography_Chart.Series["Demography"].Points.AddXY("Children",20);
            Demography_Chart.Series["Demography"].Points.AddXY("Women",40);
            Demography_Chart.Series["Demography"].Points.AddXY("Old",20);
            Demography_Chart.Series["Demography"].Points.AddXY("Infants",5);
            Demography_Chart.Series["Demography"].Points.AddXY("Men",40);
            
            //NCD pie chart
            //NCD_Chart.Series["NCD"].Points.AddXY("Blood Pressure",20);
            //NCD_Chart.Series["NCD"].Points.AddXY("Diebeties",40);
            //NCD_Chart.Series["NCD"].Points.AddXY("Astama",20);
            //NCD_Chart.Series["NCD"].Points.AddXY("Cancer",5);
            //NCD_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            //NCD_Chart.Series["NCD"].Points.AddXY("Healty", 80);
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


            // Pie Charts
            DataTable dt = DatabaseClass.GetDataTable("select DISTINCT ncd_name from ncd_details");

            foreach(DataRow dr in dt.Rows)
            {
                DataTable dt1 = DatabaseClass.GetDataTable("select distinct memberid from ncd_details where ncd_name='" + dr["ncd_name"] +"'");

                NCD_Chart.Series["NCD"].Points.AddXY(dr["ncd_name"], dt1.Rows.Count);
                
            }
        }
    }
}
