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
    public partial class Setting_Form : Form
    {
        public Setting_Form()
        {
            InitializeComponent();
        }

        private void form_head_panelcontrol_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonalize_Click(object sender, EventArgs e)
        {
            pnlPersonalize.BringToFront();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            pnlSecurity.BringToFront();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            pnlOther.BringToFront();
        }
    }
}
