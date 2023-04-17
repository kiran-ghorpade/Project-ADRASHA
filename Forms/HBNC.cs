using System;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class HBNC : Form
    {
        int memberId;
        string name;

        public HBNC(int memeber_id, string name)
        {
            InitializeComponent();
            this.memberId = memeber_id;
            this.name = name;
            lblMemberName.Text = name;

        }

        private void btnFirstExamination_Click(object sender, EventArgs e)
        {
            HBNC_First_Examination_Form first = new HBNC_First_Examination_Form(memberId, name);
            first.ShowDialog();
        }

        private void BtnAddVisit_Click(object sender, EventArgs e)
        {
                HBNC_VISIT_FORM hBNC_VISIT_FORM = new HBNC_VISIT_FORM(memberId,name);
                hBNC_VISIT_FORM.ShowDialog();
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new Health_Profile(memberId),MDI.childformpanel);
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            MyFunctions.LoadChildForm(new Member_Profile(memberId),MDI.childformpanel);
        }
    }
}
