﻿using System;
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
    public partial class SplashScreen : KryptonForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
    }
}
