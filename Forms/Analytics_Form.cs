using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //age wise population chart
            int max_age = DatabaseClass.GetAutoID("select max(age) from member_details")-1;
            DataTable dt1;

            Age_wise_population.Series["Men"].Points.AddXY(0,0);
            Age_wise_population.Series["Women"].Points.AddXY(0,0);

            for (int i=0; i<max_age+10; i++)
            {
                 dt1 = DatabaseClass.GetDataTable("select count(member_id) from member_details where age="+i+" and gender='Male'");
                 int age = Convert.ToInt32(dt1.Rows[0][0]);
                if(age > 0) 
                 Age_wise_population.Series["Men"].Points.AddXY(i, age);
                
                 dt1 = DatabaseClass.GetDataTable("select count(member_id) from member_details where age="+i+" and gender='Female'");
                 age = Convert.ToInt32(dt1.Rows[0][0]);
                if(age > 0)
                 Age_wise_population.Series["Women"].Points.AddXY(i, age);
             }
            Age_wise_population.Series["Men"].Points.AddXY(max_age+10, 0);
            Age_wise_population.Series["Women"].Points.AddXY(max_age+10, 0);



            //HBNC Chart pie chart
            HBNC_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            HBNC_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            HBNC_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            HBNC_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            HBNC_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            HBNC_Chart.Series["NCD"].Points.AddXY("Healty", 80);    


            //Maternal Chart
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Healty", 80);

           
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
