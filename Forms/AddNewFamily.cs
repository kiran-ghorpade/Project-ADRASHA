using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class AddNewFamily : Form
    {
        MyFunctions functions= new MyFunctions();

        public AddNewFamily()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlpersonal);
        }

        private void btnheadinfo_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlheadinfo);
        }

        private void pnlpersonal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
