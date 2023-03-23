using System;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //MDI mdiform = new MDI();
            WaitSomeTime(3);
            this.Close();
            //mdiform.Show();          
        }

        public void WaitSomeTime(int time)
        {
            var t = Task.Delay(time*1000);
            t.Wait();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void SplashScreen_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
    }
}
