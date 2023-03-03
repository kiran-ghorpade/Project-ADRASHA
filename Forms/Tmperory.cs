using System;
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
    public partial class Tmperory : KryptonForm
    {
        public Tmperory()
        {
            InitializeComponent();
        }

        private void Tmperory_Load(object sender, EventArgs e)
        {

        }

        private void panelControl1_Load(object sender, EventArgs e)
        {

        }

        private void panelControl2_Load(object sender, EventArgs e)
        {

        }

        private void Tmperory_Resize(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
    }
}
