using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ADRASHA_Main
{
    public partial class Asha_Registration : KryptonForm
    {
        public Asha_Registration()
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

            if (First_Name.Text == "" ||
                Middle_Name.Text==""||
                Last_Name.Text == "" ||
                Mobile_NO.Text == "" ||
                Marital_Status.Text == ""||
                Qualifications.Text == ""||
                Center.Text==""||
                Sub_Center.Text==""||
                Village.Text == ""||
                PinCode.Text ==""||
                Taluka.Text == ""||
                District.Text == ""||
                State.Text ==""||
                Total_Families.Text ==""||
                Total_Population.Text=="")
            {
                MessageBox.Show("All fields Required.");
                return;
            }

            if (dm.InsertData("asha_details", this))
            {
                Login_Setup login_Setup = new Login_Setup();
                this.Hide();
                login_Setup.Show();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "ADRASHA");
            }
        }

        private void First_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Text(sender,e);
        }

        private void Mobile_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Numeric(sender, e);
        }

        private void Asha_Registration_Load(object sender, EventArgs e)
        {
            Validation.SetComboBox(this);
        }
    }
}
