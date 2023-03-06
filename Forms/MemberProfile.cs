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
    public partial class MemberProfile : Form
    {
        MyFunctions functions = new MyFunctions();
        public MemberProfile()
        {
            InitializeComponent();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlpersonal);
        }

        private void btnidentity_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlidentity);
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlcontact);
        }

        private void btnoccupation_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnloccupation);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlmaritalinfo);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlresidential);
        }
    }
}
