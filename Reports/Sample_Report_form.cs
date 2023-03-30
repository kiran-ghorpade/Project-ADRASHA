using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

namespace ADRASHA_Main.Reports
{
    public partial class Sample_Report_form : Form
    {
        string columns = "*";

        public Sample_Report_form()
        {
            InitializeComponent();
        }

        private void Sample_Report_form_Load(object sender, EventArgs e)
        {

            setListBox();
            showReport("all");

           

            //string savePath = "ReportPdf";
            //string sPath = "d:ADRASHA\\ReportPdf";
            //String directoryPath = sPath;//Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), sPath);

            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}

            //string savePath = directoryPath;
            //byte[] Bytes = reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "");

            //using (FileStream stream = new FileStream(savePath+"\\gaurav1", FileMode.Create))
            //{
            //    stream.Write(Bytes, 0, Bytes.Length);
            //}

        }

        void showReport(string status)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            LocalReport report = reportViewer1.LocalReport;
            report.ReportPath = "Reports/Asha_Details_Report.rdlc";

            DataTable dt=null;

            if (status == "all")
            {
               dt  = DatabaseClass.GetDataTable("select " + columns + " from asha_details");
            }
            else if (status == "int")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + " between value1 and value2");
            }
            else if(status == "text")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + "= value");
            }
            else if (status == "date")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + " between value1 and value2");
            }


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Sample_Dataset", dt));

            this.reportViewer1.RefreshReport();

        }

        void setListBox()
        {
            DataTable dt = DatabaseClass.GetDataTable("PRAGMA table_info(asha_details);");
            
            DataTableReader dataTableReader = dt.CreateDataReader();
            while (dataTableReader.Read())
            {
                listBox.Items.Add(dataTableReader["name"]);
            }
            dataTableReader.Close();
        }



        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox.SelectedItem.ToString());
            listBox1.Refresh();
            // Get the selected item
            string selected = listBox.SelectedItem.ToString();

            columns = "";

            foreach (var item in listBox1.Items)
            {
                columns += item.ToString() + ",";
            }
            columns = columns.TrimEnd(',');

            showReport("all");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
