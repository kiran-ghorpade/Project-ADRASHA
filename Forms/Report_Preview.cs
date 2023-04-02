using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Reports
{
    public partial class Report_Preview : Form
    {
        string currentReport = "";
        
        public Report_Preview(string ReportName)
        {
            InitializeComponent();
            this.currentReport = ReportName;
        }

        private void Report_Preview_Load(object sender, EventArgs e)
        {
            ChooseReport();
            pnlSaveAs.Visible = false;
            this.reportViewer.RefreshReport();
        }

        void ChooseReport()
        { string path = "";
          string query = "select * from ";

            if (string.IsNullOrEmpty(this.currentReport)) { return; }

            if (currentReport == "Child_list")
            {
                path = "Reports/Child_List.rdlc";
                query += "child_list";
            }
            if(currentReport == "Head_list")
            {
                path = "Reports/Family_Head_list.rdlc";
                query += "Family_Head_list";
            }
            if(currentReport == "NCD_list")
            {
                path = "Reports/NCD_Report.rdlc";
                query += "ncd_List";
            }
            if(currentReport == "Pregnancy_list")
            {
                path = "Reports/Pregnancy_list.rdlc";
                query += "Pregnancy_list";
            }
            if(currentReport == "Vaccination_list")
            {
                path = "Reports/VaccinationList.rdlc";
                query += "Vaccination_list";
            }
            if (currentReport == "Member_list")
            {
                path = "Reports/Member_List.rdlc";
                query += "Member_list";
            }

            showReport(path,query);
        }

        void showReport(string path,String query)
        {
            reportViewer.ProcessingMode = ProcessingMode.Local;
            LocalReport report = reportViewer.LocalReport;
            report.ReportPath = path;

            DataTable dt = DatabaseClass.GetDataTable(query);
            DataTable dt2 = DatabaseClass.GetDataTable("select * from header_view");

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));

            this.reportViewer.RefreshReport();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            pnlSaveAs.Visible = true;
            FileName.Focus();
        }

        private void Vaccination_Place_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Text(sender,e);
        }

        private void btnPnlClose_Click(object sender, EventArgs e)
        {
            FileName.Clear();
            pnlSaveAs.Visible=false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName.Text))
            {
                MessageBox.Show("Enter File Name");
                return;
            }

            pnlSaveAs.Visible = true;
            string sPath = "ADRASHA\\Reports";
            String directoryPath = sPath;
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string savePath = directoryPath;
            byte[] Bytes = reportViewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath + "\\" + FileName.Text+".pdf", FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }

            MessageBox.Show("File Saved.");
            FileName.Clear();
            pnlSaveAs.Visible = false;
            this.Close();
        }
    }
}
