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
    public partial class AddNewMember : Form
    {
        MyFunctions myfunctions = new MyFunctions();

        public AddNewMember()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlidentity);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlcontact);
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlpersonal);
        }

        private void btnidentity_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlidentity);
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlcontact);
        }

        private void btnoccupation_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnloccupation);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlmaritalinfo);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            myfunctions.nextpanel_code(pnlresidential);
        }

        private void panelControl4_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pnlresidential_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pnlmaritalinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pnloccupation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pnlidentity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pnlpersonal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbtnother_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbirthplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void datedob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelControl5_Load(object sender, EventArgs e)
        {

        }

        private void panelControl7_Load(object sender, EventArgs e)
        {

        }

        private void panelControl6_Load(object sender, EventArgs e)
        {

        }

        private void panelControl2_Load(object sender, EventArgs e)
        {

        }

        private void panelControl1_Load(object sender, EventArgs e)
        {

        }

        private void main_panelcontrol_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
