﻿using ADRASHA_Main.Forms;
using ADRASHA_Main.Reports;
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

            //for loading sqltypes namespace
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            Application.Run(new Splash_Screen());
            //Application.Run(new Asha_Registration());
            //Application.Run(new MDI());
            //Application.Run(new Report_Preview());
            //Application.Run(new Sample_Report_form());
            //Application.Run(new HBNC_VISIT_FORM(5,"kiran ghorpade"));
        }
    }
}
