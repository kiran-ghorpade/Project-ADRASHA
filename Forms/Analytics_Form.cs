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
            //birthdeath pie chart
            BirthDeath_Chart.Series["birth"].Points.AddXY("January", 3);
            BirthDeath_Chart.Series["birth"].Points.AddXY("February", 4);
            BirthDeath_Chart.Series["birth"].Points.AddXY("March", 5);
            BirthDeath_Chart.Series["birth"].Points.AddXY("April", 5);
            BirthDeath_Chart.Series["birth"].Points.AddXY("May", 0);
            
            BirthDeath_Chart.Series["death"].Points.AddXY("January", 2);
            BirthDeath_Chart.Series["death"].Points.AddXY("February", 3);
            BirthDeath_Chart.Series["death"].Points.AddXY("March", 1);
            BirthDeath_Chart.Series["death"].Points.AddXY("April", 5);
            BirthDeath_Chart.Series["death"].Points.AddXY("May", 4);

            //NCD pie chart
            NCD_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            NCD_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            NCD_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            NCD_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            NCD_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            NCD_Chart.Series["NCD"].Points.AddXY("Healty", 80);
            
            //HBNC Chart pie chart
            HBNC_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            HBNC_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            HBNC_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            HBNC_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            HBNC_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            HBNC_Chart.Series["NCD"].Points.AddXY("Healty", 80);    
            
            //demography pie chart
            Demography_Chart.Series["Demography"].Points.AddXY("Children", 20);
            Demography_Chart.Series["Demography"].Points.AddXY("Women", 40);
            Demography_Chart.Series["Demography"].Points.AddXY("Old", 20);
            Demography_Chart.Series["Demography"].Points.AddXY("Infants", 5);
            Demography_Chart.Series["Demography"].Points.AddXY("Men", 40);

            //Maternal Chart
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            MaternalHealth_Chart.Series["NCD"].Points.AddXY("Healty", 80);
            
            ////NCD pie chart
            //NCD_Chart.Series["NCD"].Points.AddXY("Blood Pressure", 20);
            //NCD_Chart.Series["NCD"].Points.AddXY("Diebeties", 40);
            //NCD_Chart.Series["NCD"].Points.AddXY("Astama", 20);
            //NCD_Chart.Series["NCD"].Points.AddXY("Cancer", 5);
            //NCD_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            //NCD_Chart.Series["NCD"].Points.AddXY("Healty", 80);
        }
    }
}
