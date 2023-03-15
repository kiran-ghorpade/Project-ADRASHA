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
    public partial class FamilyProfile : Form
    {
        public FamilyProfile()
        {
            InitializeComponent();
        }

        private void FamilyProfile_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }
        private void PopulateItems()
        {
            MemberListView[] listView = new MemberListView[10];
            for (int i = 0; i < listView.Length; i++)
            {
                listView[i] = new MemberListView();
                listView[i].Title = "Madhav Mane";
                listView[i].FamilyID = "" + i;
                listView[i].age = "" + (i*2);

                if (ListViewPanel.Controls.Count < 0)
                {
                    ListViewPanel.Controls.Clear();
                }
                else
                {
                    listView[i].Width = ListViewPanel.Width - 40;
                    ListViewPanel.Controls.Add(listView[i]);
                }
            }
        }
    }
}
