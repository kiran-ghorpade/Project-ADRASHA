using ADRASHA_Main.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Splash_Screen());
            //Application.Run(new Asha_Registration());
            //Application.Run(new MDI());
            Application.Run(new HBNC_First_Examination_Form(5,"kiran ghorpade"));
        }
    }
}
