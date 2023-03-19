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

            //demography pie chart
            Demography_Chart.Series["Demography"].Points.AddXY("Children",20);
            Demography_Chart.Series["Demography"].Points.AddXY("Women",40);
            Demography_Chart.Series["Demography"].Points.AddXY("Old",20);
            Demography_Chart.Series["Demography"].Points.AddXY("Infants",5);
            Demography_Chart.Series["Demography"].Points.AddXY("Men",40);
            
            //NCD pie chart
            NCD_Chart.Series["NCD"].Points.AddXY("Blood Pressure",20);
            NCD_Chart.Series["NCD"].Points.AddXY("Diebeties",40);
            NCD_Chart.Series["NCD"].Points.AddXY("Astama",20);
            NCD_Chart.Series["NCD"].Points.AddXY("Cancer",5);
            NCD_Chart.Series["NCD"].Points.AddXY("arthritis", 40);
            NCD_Chart.Series["NCD"].Points.AddXY("Healty", 80);
        }
    }
}
