using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class MemberListView : UserControl
    {
        public MemberListView()
        {
            InitializeComponent();
        }

        #region Properties


        private string _headtitle;
        private string _memberid;
        private string _age;
        private Image _icons;

        [Category("Custom Props")]
        public string Title
        {
            get { return _headtitle; }
            set { _headtitle = value; Member_Name.Text = value; }
        }

        [Category("Custom Props")]
        public string FamilyID
        {
            get { return _memberid; }
            set { _memberid = value; Member_Id.Text = value; }
        }

        [Category("Custom Props")]
        public string age
        {
            get { return _age; }
            set { _age = value; Age.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icons; }
            set { _icons = value; Profile_Image.Image = value; }
        }


        #endregion
    }
}
