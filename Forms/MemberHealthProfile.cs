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
    public partial class MemberHealthProfile : Form
    {
        MyFunctions MyFunctions = new MyFunctions();
        public MemberHealthProfile()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBasicHealth_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlBasicHealth);
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlVaccination);
        }

        private void btnMaternalHealth_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlMaternal);
        }

        private void btnHBNC_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlHBNC);
        }

        private void btnNCD_Click(object sender, EventArgs e)
        {
            MyFunctions.nextpanel_code(pnlNCD);
        }
    }
}
