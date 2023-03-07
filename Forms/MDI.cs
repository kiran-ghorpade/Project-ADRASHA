using ADRASHA_Main.Forms;
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
    public partial class MDI : Form
    {
        MyFunctions functions = new MyFunctions();

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            searchboxpanel.Visible = false;
            functions.LoadChildForm(new FamilyProfile(),childformpanel);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            searchboxpanel.BringToFront();
            searchboxpanel.Visible = true;
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            searchboxpanel.Visible=false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want to Exit? ", "Security Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new RegistryBookForm(), childformpanel);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new MemberProfile(), childformpanel);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new AddNewMember(), childformpanel);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new FamilyProfile(), childformpanel);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new MemberHealthProfile(), childformpanel);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            
            functions.LoadChildForm(new AddNewFamily(), childformpanel);
        }
    }
}
