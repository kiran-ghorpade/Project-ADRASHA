using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADRASHA_Main.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace ADRASHA_Main
{
    public partial class Splash_Screen : KryptonForm
    {
        public Splash_Screen()
        {
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;
            //this.Enabled = false;
        }

        bool First_Login = true;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Status.Text = "0 %";
            WaitSomeTime(1000);
            CheckFirstLogin();
            if (!First_Login)
            {
                UpdateAge();
                WaitSomeTime(30000);
                ASHA_Login loginform = new ASHA_Login(this);
                loginform.ShowDialog();
                this.Close();
            }
        }

        public void CheckFirstLogin()
        {
            if (!File.Exists("ADRASHA_DB.sqlite"))
            {
                WaitSomeTime(30000);
                Asha_Registration asha_Registration = new Asha_Registration();
                this.Hide();
                asha_Registration.Show();
            }
            else
                First_Login = false;
        }

        public void WaitSomeTime(int time)
        {
            var t = Task.Delay(time/10);
            t.Wait();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void UpdateAge()
        {
            int total_members = DatabaseClass.GetAutoID("select max(member_id) from member_details")-1;
            if(total_members <= 0)
                  total_members = 1;
            
            int age = 0;
            string date="";

            for(int i  = 1; i < total_members; i++)
            {
                DataTable dt = DatabaseClass.GetDataTable("select birth_date from member_details where member_id="+i);
                
                if(dt.Rows.Count > 0)
                {
                    date = dt.Rows[0]["birth_date"].ToString();
                }
                age = MyFunctions.CalculateAge(date);
                DatabaseClass.UpdateRow("member_details","member_id",i,"age",age);

                Status.Text = (i*100)/ total_members + " %";
                Status.Refresh();
                WaitSomeTime(5);
            }
            Status.Text ="100 % .";
            label3.Text = " Completed";
            Status.Refresh();
            label3.Refresh();

        }

        private void SplashScreen_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
    }
}
