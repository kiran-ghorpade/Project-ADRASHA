using ADRASHA_Main.Reports;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class Reports_Form : Form
    {
        MyFunctions functions = new MyFunctions();
        string currentReport = null;

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
            listboxSavedFiles.Items.Clear();
            Reports_Form_Load(sender, e);
            listboxSavedFiles.Refresh();
            functions.nextpanel_code(pnlSavedReports);
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            Report_Generator report_Generator = new Report_Generator();
            report_Generator.ShowDialog();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {
            string directoryPath = "ADRASHA\\Reports";
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string[] fileNames = Directory.GetFiles(directoryPath, "*.pdf");

            foreach (string fileName in fileNames)
            {
                listboxSavedFiles.Items.Add(Path.GetFileName(fileName));
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (listboxSavedFiles.SelectedItems != null)
            {
                Saved_Report_Viewer pdfviewer = new Saved_Report_Viewer(listboxSavedFiles.SelectedItem.ToString());
                pdfviewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select File.");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentReport))
            {
                MessageBox.Show("Select Tamplate");
                return;
            }
            Report_Preview preview = new Report_Preview(currentReport);
            preview.ShowDialog();
        }

        void clearFocus()
        {
            btnChildList.BackColor = Color.White;
            btnDemographic.BackColor = Color.White;
            btnFamilyHeadList.BackColor = Color.White;
            btnNCDList.BackColor = Color.White;
            btnPregnentList.BackColor = Color.White;
            btnVaccination.BackColor = Color.White;

        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnVaccination.BackColor = Color.Chartreuse;
            currentReport = "Vaccination_list";
        }

        private void btnPregnentList_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnPregnentList.BackColor = Color.Chartreuse;
            currentReport = "Pregnancy_list";
        }

        private void btnChildList_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnChildList.BackColor = Color.Chartreuse;
            currentReport = "Child_list";
        }

        private void btnDemographic_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnDemographic.BackColor = Color.Chartreuse;
            currentReport = "Member_list";
        }

        private void btnFamilyHeadList_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnFamilyHeadList.BackColor = Color.Chartreuse;
            currentReport = "Head_list";
        }

        private void btnNCDList_Click(object sender, EventArgs e)
        {
            clearFocus();
            btnNCDList.BackColor = Color.Chartreuse;
            currentReport = "NCD_list";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filepath = listboxSavedFiles.SelectedItem.ToString();
            string directory = Directory.GetCurrentDirectory();
            directory += "\\ADRASHA\\Reports\\" + filepath;

            if (MessageBox.Show("Are you want delete '" + filepath + "'.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(directory);
                MessageBox.Show("File(Report) Deleted. \n File Name : " + filepath);
                listboxSavedFiles.Refresh();
            }
        }
    }
}