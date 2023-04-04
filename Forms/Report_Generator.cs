using ADRASHA_Main.Reports;
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

namespace ADRASHA_Main.Forms
{
    public partial class Report_Generator : Form
    {
        string columns = "*";

        public Report_Generator()
        {
            InitializeComponent();
        }

        private void Report_Generator_Load(object sender, EventArgs e)
        {
            setListBox();
            showReport("all");
            this.reportViewer1.RefreshReport();
        }

        void setListBox()
        {
            DataTable dt = DatabaseClass.GetDataTable("PRAGMA table_info(asha_details);");
            //dt.Merge(DatabaseClass.GetDataTable("PRAGMA table_info(member_details);"));
            //dt.Merge(DatabaseClass.GetDataTable("PRAGMA table_info(vaccination_details);"));
            //dt.Merge(DatabaseClass.GetDataTable("PRAGMA table_info(ncd_details);"));
            //dt.Merge(DatabaseClass.GetDataTable("PRAGMA table_info(pregnancy_details);"));

            DataTableReader dataTableReader = dt.CreateDataReader();
            while (dataTableReader.Read())
            {
                listBox1.Items.Add(dataTableReader["name"]);
            }
            dataTableReader.Close();
        }

        void showReport(string status)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            LocalReport report = reportViewer1.LocalReport;
            report.ReportPath = "Reports/Report_Generator.rdlc";

            DataTable dt = null;
            DataTable dt2 = DatabaseClass.GetDataTable("select * from header_view");

            if (status == "all")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details");
            }
            else if (status == "int")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + " between value1 and value2");
            }
            else if (status == "text")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + "= value");
            }
            else if (status == "date")
            {
                dt = DatabaseClass.GetDataTable("select " + columns + " from asha_details where " + listBox1.SelectedItem + " between value1 and value2");
            }


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetReportCells(dt)));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));

            this.reportViewer1.RefreshReport();

        }

        public List<ReportCell> GetReportCells(DataTable table)
        {
            return ReportCell.ConvertTableToCells(table);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem ==null)
            {
                MessageBox.Show("select column.");
                return;
            }
            if (!listBox2.Items.Contains(listBox1.SelectedItem))
            listBox2.Items.Add(listBox1.SelectedItem.ToString());

            listBox2.Refresh();

            if (!(listBox2.Items.Count == 0))
            {
                columns = "";

                foreach (var item in listBox2.Items)
                {
                    columns += item.ToString() + ",";
                }
                columns = columns.TrimEnd(',');

                showReport("all");
                listBox1.ClearSelected();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("select column.");
                return;
            }

            //listBox2.Items.Remove(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox2.Refresh();

            if (!(listBox2.Items.Count == 0))
            {
                columns = "";


                foreach (var item in listBox2.Items)
                {
                    columns += item.ToString() + ",";
                }
                columns = columns.TrimEnd(',');

                showReport("all");
            }
            listBox1.ClearSelected();
        }
    }
}
