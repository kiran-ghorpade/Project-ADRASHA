﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class Saved_Report_Viewer : Form
    {
        string filepath;
        public Saved_Report_Viewer(string filepath)
        {
            InitializeComponent();
            this.filepath = filepath;
        }


        private void Saved_Report_Viewer_Load(object sender, EventArgs e)
        {
            string directory = Directory.GetCurrentDirectory();
            webBrowser.Navigate(directory+"\\ADRASHA\\Reports\\"+filepath);
        }
    }
}
