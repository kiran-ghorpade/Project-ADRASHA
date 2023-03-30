using ADRASHA_Main.Reports;
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

namespace ADRASHA_Main.Forms
{
    public partial class Reports_Form : Form
    {
        MyFunctions functions = new MyFunctions();
        public Reports_Form()
        {
            InitializeComponent();
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlReportTemplates);
        }

        private void btnSavedReports_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlSavedReports);
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            Sample_Report_form sample_Report_Form = new Sample_Report_form();
            sample_Report_Form.ShowDialog();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {
            string directoryPath = "ADRASHA\\Reports";
            string[] fileNames = Directory.GetFiles(directoryPath,"*.pdf");

            foreach (string fileName in fileNames)
            {
                listboxSavedFiles.Items.Add(Path.GetFileName(fileName));
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Saved_Report_Viewer pdfviewer = new Saved_Report_Viewer(listboxSavedFiles.SelectedItem.ToString());
            pdfviewer.ShowDialog();
        }
    }
}
