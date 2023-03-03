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
        private Form activeform = null;

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
            LoadChildForm(new FamilyProfileform());
        }

        private void LoadChildForm(Form childform)
        {
            if (activeform != null )
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle= FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childformpanel.Controls.Clear();
            childformpanel.Controls.Add(childform);
            childformpanel.Tag= childform;
            childform.BringToFront();
            childform.Show();

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
            LoadChildForm(new RegistryBookForm());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            LoadChildForm(new MemberProfile());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AddNewMember());
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SettingForm());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LoadChildForm(new HealthProfile());
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            
            LoadChildForm(new FamilyProfileform());
        }
    }
}
