using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Reports
{
    public partial class Report_Preview : Form
    {
        public Report_Preview()
        {
            InitializeComponent();
        }

        private void Report_Preview_Load(object sender, EventArgs e)
        {
            showReport();
            this.reportViewer.RefreshReport();
        }

        void showReport()
        {
            reportViewer.ProcessingMode = ProcessingMode.Local;

            LocalReport report = reportViewer.LocalReport;
            report.ReportPath = "Reports/VaccinationList.rdlc";

            DataTable dt = DatabaseClass.GetDataTable("select * from Vaccination_View ");
            DataTable dt2 = DatabaseClass.GetDataTable("select * from header_view");

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));

            this.reportViewer.RefreshReport();
        }
    }
}
