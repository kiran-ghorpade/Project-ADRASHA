using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class FamilyListView : UserControl
    {
        public FamilyListView()
        {
            InitializeComponent();
        }


        #region Properties


        private string _headtitle;
        private string _familyid;
        private string _totalmembers;
        private Image _icons;

        [Category("Custom Props")]
        public string Title
        {
            get { return _headtitle; }
            set { _headtitle = value; Head_Name.Text = value; }
        }

        [Category("Custom Props")]
        public string FamilyID
        {
            get { return _familyid; }
            set { _familyid = value; Family_Id.Text = value; }
        }

        [Category("Custom Props")]
        public string TotalMemebers
        {
            get { return _totalmembers; }
            set { _totalmembers = value; Total_Members.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icons; }
            set { _icons = value; Profile_Image.Image = value; }
        }


        #endregion

        private void DisplayPanel_Click(object sender, EventArgs e)
        {
            Family_Profile profile = new Family_Profile(Convert.ToInt32(FamilyID));
            MyFunctions.LoadChildForm(profile,MDI.childformpanel);
        }

    }
}
