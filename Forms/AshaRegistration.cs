using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ADRASHA_Main
{
    public partial class AshaRegistration : KryptonForm
    {
        public AshaRegistration()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Do you Want to Exit ","Adrasha", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
  
        }

        private void panelControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataManipulation dm = new DataManipulation();

            if (dm.InsertData("asha_profile", this))
                MessageBox.Show("Submitted Successfully.", "ADRASHA");
            else
            {
                MessageBox.Show("Fill all fields.", "ADRASHA");
            }
        }
    }
}
