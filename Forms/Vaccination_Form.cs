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
    public partial class Vaccination_Form : Form
    {
        int memberId;
        MyFunctions MyFunctions = new MyFunctions();
        public Vaccination_Form(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void btnBCG_D1_Click(object sender, EventArgs e)
        {
            if(btnBCG_D1.BackColor == Color.Red) 
            btnBCG_D1.BackColor = Color.Green;
            else
                btnBCG_D1.BackColor = Color.Red;
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Member_Health_Profile(memberId), MDI.childformpanel);
        }
    }
}
