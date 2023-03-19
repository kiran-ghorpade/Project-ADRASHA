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
    }
}
