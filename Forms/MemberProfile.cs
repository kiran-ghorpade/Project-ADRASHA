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
            functions.nextpanel_code(pnlPersonal);
        }

        private void btnidentity_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlIdentity);
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlContact);
        }

        private void btnoccupation_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlOccupation);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlMaritalInfo);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlResidential);
        }
    }
}
